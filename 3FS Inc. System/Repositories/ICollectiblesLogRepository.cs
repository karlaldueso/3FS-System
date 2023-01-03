using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3FS_System.Models;

namespace _3FS_System.Repositories
{
    public interface ICollectiblesLogRepository
    {
        IEnumerable<Models.CollectiblesLog> GetCollectibleLogs_ByCustomerID(int CustomerID);
        bool Insert(Models.CollectiblesLog collectibles);
        bool Update(Models.CollectiblesLog collectibles);
        bool Delete(Models.CollectiblesLog collectibles);
    }
}
