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
    internal class CashCountRepository : ICashCountsRepository
    {
        public bool Delete(CashCount cashCount)
        {
            throw new NotImplementedException();
        }

        public float GetActualRemainingCash_PerDate(DateTime date)
        {
            object amount;
            string qry = string.Format("dbo.spCashCount_ActualRemainingCashByDate @Date='{0}'", date.ToString("yyyy/MM/dd"));
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                amount = connection.ExecuteScalar(qry);
            }
            if (amount != null)
                return (float)Convert.ToDouble(amount.ToString());
            else
                return 0;
        }

        public IEnumerable<CashCount> GetAllCashCount_PerDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CashCount cashCount)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spCashCount_AddCashCount @ActualRemainingCash, @ComputedRemainingCash, @TransactionDate, @UpdatedDate, @CreatedDate, @StoreID", cashCount);
                return true;
            }
        }

        public bool Update(CashCount cashCount)
        {
            throw new NotImplementedException();
        }
    }
}
