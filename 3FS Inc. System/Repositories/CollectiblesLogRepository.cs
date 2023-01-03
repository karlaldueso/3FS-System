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
    internal class CollectiblesLogRepository : ICollectiblesLogRepository
    {
        public bool Delete(Models.CollectiblesLog collectibles)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.CollectiblesLog> GetCollectibleLogs_ByCustomerID(int CustomerID)
        {
            string qry = string.Format("dbo.spCollectiblesLog_GetByCustomerID @CustomerID={0}", CustomerID);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Models.CollectiblesLog>(qry);
                return output;
            }
        }

        public bool Insert(Models.CollectiblesLog collectibles)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spCollectiblesLog_AddLog @CustomerID, @Amount, @TransactionDate, @UpdatedDate, @CreatedDate, @StoreID", collectibles);
                return true;
            }
        }

        public bool Update(Models.CollectiblesLog collectibles)
        {
            throw new NotImplementedException();
        }
    }
}
