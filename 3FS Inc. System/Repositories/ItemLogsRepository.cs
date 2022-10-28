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
    internal class ItemLogsRepository : IItemLogsRepository
    {
        public bool Delete(ItemLogs item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemLogs_DisplayFormat> GetItemLogs_All()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<ItemLogs_DisplayFormat>("dbo.spItemLogs_GetAll");
                return output;
            }
        }
        public IEnumerable<ItemLogs_DisplayFormat> GetItemLogs_ByID(int ID)
        {
            string qry = string.Format("dbo.spItemLogs_GetByItemID @ItemID={0}", ID);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<ItemLogs_DisplayFormat>(qry);
                return output;
            }
        }

        public bool Insert(ItemLogs item, int col)
        {
            switch (col)
            {
                case 0:
                    item.TransactionType = "Added Item";
                    break;
                case 1:
                    item.TransactionType = "Update Name";
                    break;
                case 2:
                    item.TransactionType = "Update Brand";
                    break;
                case 3:
                    item.TransactionType = "Update Category";
                    break;
                case 4:
                    item.TransactionType = "Update Qty";
                    break;
                case 5:
                    item.TransactionType = "Update Unit";
                    break;
                case 6:
                    item.TransactionType = "Update SRP";
                    break;
                case 7:
                    item.TransactionType = "Update Capital";
                    break;
                case 8:
                    item.TransactionType = "Update Storage";
                    break;
                case 9:
                    item.TransactionType = "Sold";
                    break;
                case 10:
                    item.TransactionType = "Return";
                    break;
                default:
                    item.TransactionType = "";
                    break;
            }
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spItemLogs_AddLog @ItemID, @TransactionType, @Previous, @Present, @TransactionDate", item);
                return true;
            }
        }

        public bool Update(ItemLogs item)
        {
            throw new NotImplementedException();
        }
    }
}
