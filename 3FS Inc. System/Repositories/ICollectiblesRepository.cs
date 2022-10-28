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
        IEnumerable<Models.Collectible> GetCollectibleLogs_ByCustomerID(int CustomerID);
        bool Insert(Models.Collectible collectibles);
        bool Update(Models.Collectible collectibles);
        bool Delete(Models.Collectible collectibles);
    }
}
