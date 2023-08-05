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
        public bool Delete(Item item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems_All()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Item>("dbo.spItems_GetAll");
                return output;
            }
        }
        public IEnumerable<Item> GetItems_ByName(string ItemName, string BrandName)
        {
            string qry = string.Format("dbo.spItems_GetByName @ItemName='{0}', @BrandName='{1}'", ItemName, BrandName);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Item>(qry);
                return output;
            }
        }

        public bool Insert(Item item)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spItems_AddItem @ItemName, @BrandName, @CategoryID, @Unit, @SRP, @Capital, @UpdatedDate, @CreatedDate, @StoreID", item);
                return true;
            }
        }

        public bool Update(Item item, int col, string input)
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
                        item.Unit = input;
                        break;
                    case 5:
                        item.SRP = float.Parse(input);
                        break;
                    case 6:
                        item.Capital = float.Parse(input);
                        break;
                }
                _ = connection.Execute("dbo.spItems_UpdateItem @ItemID, @ItemName, @BrandName, @CategoryID, @Quantity, @Unit, @SRP, @Capital, @Storage, @UpdatedDate", item);
                return true;
            }
        }
        public bool UpdateQty(int itemID, float qty, int transactiontype, DateTime updatedDate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                _ = connection.Execute("dbo.spItems_UpdateQtyByID @ItemID, @Qty, @TransactionType, @UpdatedDate", new { itemID, qty, transactiontype, updatedDate});
                return true;
            }
        }
        public int GetItemID(Item item)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.ExecuteScalar("dbo.spItems_GetID_ByNameNBrandName @ItemName, @BrandName", new { item.ItemName, item.BrandName });
                return (int)output;
            }
        }
    }
}
