using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FS_System.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<Models.User> GetUsers_All();
        bool Insert(Models.User user);
        bool Update(Models.User user);
        bool Delete(Models.User user);
    }
}
