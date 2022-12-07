using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using _3FS_System.Models;
using _3FS_System.Helpers;
using System.Data;

namespace _3FS_System.Repositories
{
    internal class ReceiptRepository : IReceiptRepository
    {
        public bool Delete(Receipt receipt)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Receipt> GetReceipt_ByCustomerID(int CustomerID)
        {
            string qry = string.Format("dbo.spReceipts_GetByCustomerID @CustomerID='{0}'", CustomerID);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Receipt>(qry);
                return output;
            }
        }

        public IEnumerable<Receipt_PerDay> GetReceipt_ByDate(DateTime TransactionDate)
        {
            string qry = string.Format("dbo.spReceipts_GetByDate @Date='{0}'", TransactionDate.ToString("yyyy/MM/dd"));
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Receipt_PerDay>(qry);
                return output;
            }
        }

        public bool Insert(Receipt receipt)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spReceipts_AddReceipt @ReceiptNum, @CustomerID, @AmountPaid, @GrandTotal, @TransactionDate, @UpdatedDate", receipt);
                return true;
            }
        }

        public bool Update(Receipt receipt)
        {
            throw new NotImplementedException();
        }
    }
}
