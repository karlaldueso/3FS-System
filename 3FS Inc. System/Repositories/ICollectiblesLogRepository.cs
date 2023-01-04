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
        IEnumerable<CollectiblesLog> GetCollectibleLogs_ByCustomerID(int CustomerID);
        bool InsertLog(CollectiblesLog collectibles);
        bool UpdateLog(CollectiblesLog collectibles);
        bool DeleteLog(CollectiblesLog collectibles);
        bool Insert(Collectible collectible);
        bool Update(Collectible collectible);
        float GetBalanceByCustomerID(int customerID);
    }
}
