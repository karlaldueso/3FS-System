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
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers_All();
        bool Insert(User user);
        bool Update(User user);
        bool Delete(User user);
    }
}
