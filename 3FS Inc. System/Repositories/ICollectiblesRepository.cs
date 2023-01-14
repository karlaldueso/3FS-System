using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3FS_System.Models;

namespace _3FS_System.Repositories
{
    public interface ICollectiblesRepository
    {
        IEnumerable<CollectiblesLog> GetCollectibleLogs_ByCustomerID(int CustomerID);
        IEnumerable<Collectible> GetCollectible_ByCustomerID(int CustomerID);
        bool InsertLog(CollectiblesLog collectibles);
        bool UpdateLog(CollectiblesLog collectibles);
        bool DeleteLog(CollectiblesLog collectibles);
        bool Insert(Collectible collectible);
        bool UpdateBalance(int CollectibleID, float Amount, DateTime UpdatedDate);
        float GetBalanceByCustomerID(int customerID);
        float GetCollectedAmountByDate(DateTime date);
    }
}
