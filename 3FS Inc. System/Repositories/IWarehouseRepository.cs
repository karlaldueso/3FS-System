using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using _3FS_System.Models;
using System.Data;

namespace _3FS_System.Repositories
{
    public interface IWarehouseRepository
    {
        IEnumerable<Warehouse> GetWarehouse_All();
        bool Insert(Warehouse warehouse);
        bool Update(Warehouse warehouse);
        bool Delete(Warehouse warehouse);
    }
}
