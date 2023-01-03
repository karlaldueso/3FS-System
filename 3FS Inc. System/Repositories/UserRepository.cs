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
    internal class UserRepository : IUserRepository
    {
        public IEnumerable<User> GetUsers_All()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<User>("dbo.spUsers_GetAll");
                return output;
            }
        }
        public bool Insert(User user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spUsers_AddUser @UserName, @PW, @UserType, @FirstName, @LastName, @ContactNum, @UpdatedDate, @CreatedDate, @StoreID", user);
                return true;
            }
        }
        public bool Update(User user)
        {
            throw new NotImplementedException();
        }
        public bool Delete(User user)
        {
            throw new NotImplementedException();
        }
    }
}
