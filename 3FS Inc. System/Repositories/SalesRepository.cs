using _3FS_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using _3FS_System.Helpers;

namespace _3FS_System.Repositories
{
    internal class SalesRepository : ISalesRepository
    {
        public IEnumerable<Sale> GetSale_ByReceipt(string ReceiptNum)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Sale sale)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spSales_AddSales @ReceiptNum, @Qty, @Unit, @ItemID, @UnitPrice, @SubTotal ,@TransactionDate", sale);
                return true;
            }
        }

        public bool Update(Sale sale)
        {
            throw new NotImplementedException();
        }
        public bool Delete(Sale sale)
        {
            throw new NotImplementedException();
        }

    }
}
