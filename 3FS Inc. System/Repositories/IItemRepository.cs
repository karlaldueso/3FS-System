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
    public interface IItemRepository
    {
        IEnumerable<ItemInventory> GetItems_All();
        IEnumerable<ItemInventory> GetItems_ByName(string ItemName, string BrandName);
        bool Insert(ItemInventory item);
        bool Update(ItemInventory item, int col, string input);
        bool UpdateQty(int itemID, float qty, int transactiontype, DateTime updatedDate);
        bool Delete(ItemInventory item);
        int GetItemID(ItemInventory item);
    }
}
