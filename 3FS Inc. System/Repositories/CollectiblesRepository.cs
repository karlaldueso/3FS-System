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
    internal class CollectiblesRepository : ICollectiblesLogRepository
    {
        public bool DeleteLog(CollectiblesLog collectibles)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CollectiblesLog> GetCollectibleLogs_ByCustomerID(int CustomerID)
        {
            string qry = string.Format("dbo.spCollectiblesLog_GetByCustomerID @CustomerID={0}", CustomerID);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<CollectiblesLog>(qry);
                return output;
            }
        }

        public bool InsertLog(CollectiblesLog collectibles)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spCollectiblesLog_AddLog @CustomerID, @Amount, @TransactionDate, @UpdatedDate, @CreatedDate, @StoreID", collectibles);
                return true;
            }
        }

        public bool UpdateLog(CollectiblesLog collectibles)
        {
            throw new NotImplementedException();
        }
        public bool Insert(Collectible collectible)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spCollectibles_AddCollectible @CustomerID, @ReceiptNum, @Amount, @Balance, @Paid, @DueDate, @TransactionDate, @UpdatedDate, @CreatedDate, @StoreID", collectible);
                return true;
            }
        }
        public bool Update(Collectible collectible)
        {
            throw new NotImplementedException();
        }
        public float GetBalanceByCustomerID(int customerID)
        {
            object totalbalance;
            string qry = string.Format("dbo.spCollectibles_TotalBalancePerCustomerID @CustomerID={0}", customerID);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                totalbalance = connection.ExecuteScalar(qry);
            }
            if (totalbalance != null)
                return (float)Convert.ToDouble(totalbalance.ToString());
            else
                return 0;
        }
    }
}
