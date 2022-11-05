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
    internal class ItemRepository : IItemRepository
    {
        public bool Delete(Items item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Items> GetItems_All()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Items>("dbo.spItemInventory_GetAll");
                return output;
            }
        }
        public IEnumerable<Items> GetItems_ByName(string ItemName, string BrandName)
        {
            string qry = string.Format("dbo.spItemInventory_GetByName @ItemName='{0}', @BrandName='{1}'", ItemName, BrandName);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Items>(qry);
                return output;
            }
        }

        public bool Insert(Items item)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spItemInventory_AddItem @ItemName, @BrandName, @CategoryID, @Quantity, @Unit, @SRP, @Capital, @Storage, @UpdatedDate", item);
                return true;
            }
        }

        public bool Update(Items item, int col, string input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                switch (col)
                {
                    case 1:
                        item.ItemName = input;
                        break;
                    case 2:
                        item.BrandName = input;
                        break;
                    case 3:
                        item.CategoryID = int.Parse(input);
                        break;
                    case 4:
                        item.Quantity = float.Parse(input);
                        break;
                    case 5:
                        item.Unit = input;
                        break;
                    case 6:
                        item.SRP = float.Parse(input);
                        break;
                    case 7:
                        item.Capital = float.Parse(input);
                        break;
                    case 8:
                        item.Storage = input;
                        break;
                }
                _ = connection.Execute("dbo.spItemInventory_UpdateItem @ItemID, @ItemName, @BrandName, @CategoryID, @Quantity, @Unit, @SRP, @Capital, @Storage, @UpdatedDate", item);
                return true;
            }
        }
        public bool UpdateQty(int itemID, float qty, int transactiontype, DateTime updatedDate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                _ = connection.Execute("dbo.spItemInventory_UpdateQtyByID @ItemID, @Qty, @TransactionType, @UpdatedDate", new { itemID, qty, transactiontype, updatedDate});
                return true;
            }
        }
        public int GetItemID(Items item)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.ExecuteScalar("dbo.spItemInventory_GetID_ByNameNBrandName @ItemName, @BrandName", new { item.ItemName, item.BrandName });
                return (int)output;
            }
        }
    }
}
