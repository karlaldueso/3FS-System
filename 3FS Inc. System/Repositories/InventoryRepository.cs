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
            string qry = string.Format("dbo.spItemInventory_GetByNameNWarehouse @ItemName='{0}', @BrandName='{1}', @WarehouseID='{2}'", ItemName, BrandName, warehouseID);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Inventory>(qry);
                return output;
            }
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

        public bool UpdateQty(Inventory inventory, int transactiontype)
        {
            string qry = string.Format("dbo.spInventory_UpdateQtyByID @ItemID='{0}', @WarehouseID='{1}', @Qty='{2}', @TransactionType='{3}', @UpdatedDate='{4}'", inventory.ItemID, inventory.WarehouseID, inventory.Quantity, transactiontype, inventory.UpdatedDate);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute(qry);
                return true;
            }
        }
        public bool IfExists(Inventory inventory)
        {
            string qry = string.Format("dbo.spInventory_IfExists @ItemID='{0}', @WarehouseID='{1}'", inventory.ItemID, inventory.WarehouseID);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                int output = (int)Convert.ToInt16(connection.ExecuteScalar(qry).ToString());
                if (output > 0)
                    return true;
                else 
                    return false;
            }
        }
    }
}
