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
        IEnumerable<Item> GetAll_ByWarehouse();
        IEnumerable<Item> GetByName(string ItemName, string BrandName);
        IEnumerable<Item> GetByName_ByWareHouse(string ItemName, string BrandName);
        bool Insert(Item item);
        bool Update(Item item, int col, string input);
        bool UpdateQty(int itemID, float qty, int transactiontype, DateTime updatedDate);
        bool Delete(Item item);
        int GetItemID(Item item);
    }
}
