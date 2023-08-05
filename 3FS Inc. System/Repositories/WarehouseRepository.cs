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
    internal class WarehouseRepository : IWarehouseRepository
    {
        public bool Delete(Warehouse warehouse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Warehouse> GetWarehouse_All()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Warehouse>("dbo.spWarehouse_GetAll");
                return output;
            }
        }

        public bool Insert(Warehouse warehouse)
        {
            throw new NotImplementedException();
        }

        public bool Update(Warehouse warehouse)
        {
            throw new NotImplementedException();
        }
    }
}
