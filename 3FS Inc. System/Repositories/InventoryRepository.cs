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
    internal class InventoryRepository : IInventoryRepository
    {
        public bool Delete(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inventory> GetAll_ByWarehouse()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inventory> GetByName(string ItemName, string BrandName)
        {
            string qry = string.Format("dbo.spItemInventory_GetByName @ItemName='{0}', @BrandName='{1}'", ItemName, BrandName);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Inventory>(qry);
                return output;
            }
        }

        public IEnumerable<Inventory> GetByName_ByWareHouse(string ItemName, string BrandName, int warehouseID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Inventory inventory)
        {
            string qry = string.Format("dbo.spInventory_AddEntry @ItemID='{0}', @Quantity='{1}', @WarehouseID='{2}', @UpdatedDate='{3}', @CreatedDate='{4}'", inventory.ItemID, inventory.Quantity, inventory.WarehouseID, inventory.UpdatedDate, inventory.CreatedDate);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Inventory>(qry);
                return true;
            }
        }

        public bool Update(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        public bool UpdateQty(Inventory inventory)
        {
            throw new NotImplementedException();
        }
    }
}
