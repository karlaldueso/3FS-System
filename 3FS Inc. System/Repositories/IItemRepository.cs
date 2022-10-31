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
        IEnumerable<Items> GetItems_All();
        IEnumerable<Items> GetItems_ByName(string ItemName, string BrandName);
        bool Insert(Items item);
        bool Update(Items item, int col, string input);
        bool UpdateQty(int itemID, float qty, int transactiontype, DateTime updatedDate);
        bool Delete(Items item);
        int GetItemID(Items item);
    }
}
