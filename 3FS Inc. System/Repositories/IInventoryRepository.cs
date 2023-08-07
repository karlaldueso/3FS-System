using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3FS_System.Models;

namespace _3FS_System.Repositories
{
    public interface IInventoryRepository
    {
        IEnumerable<Inventory> GetAll_ByWarehouse();
        IEnumerable<Inventory> GetByName(string ItemName, string BrandName);
        IEnumerable<Inventory> GetByName_ByWareHouse(string ItemName, string BrandName, int warehouseID);
        bool Insert(Inventory inventory);
        bool Update(Inventory inventory);
        bool UpdateQty(Inventory inventory);
        bool Delete(Inventory inventory);
    }
}
