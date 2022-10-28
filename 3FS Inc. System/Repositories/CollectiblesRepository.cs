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
    internal class CollectiblesRepository : ICollectiblesRepository
    {
        public bool Delete(Models.Collectible collectibles)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Collectible> GetCollectibleLogs_ByCustomerID(int CustomerID)
        {
            string qry = string.Format("dbo.spCollectiblesLog_GetByCustomerID @CustomerID={0}", CustomerID);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Models.Collectible>(qry);
                return output;
            }
        }

        public bool Insert(Models.Collectible collectibles)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spCollectiblesLog_AddLog @CustomerID, @Amount, @TransactionDate", collectibles);
                return true;
            }
        }

        public bool Update(Models.Collectible collectibles)
        {
            throw new NotImplementedException();
        }
    }
}
