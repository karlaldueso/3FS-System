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
    public interface IItemLogsRepository
    {
        IEnumerable<ItemLogs_DisplayFormat> GetItemLogs_All();
        IEnumerable<ItemLogs_DisplayFormat> GetItemLogs_ByID(int ID);
        bool Insert(ItemLogs item, int col);
        bool Update(ItemLogs item);
        bool Delete(ItemLogs item);
    }
}
