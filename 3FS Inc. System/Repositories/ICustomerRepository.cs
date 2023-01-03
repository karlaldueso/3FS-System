using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3FS_System.Models;

namespace _3FS_System.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Models.CustomerProfile> GetCustomer();
        IEnumerable<Models.CustomerProfile> GetCustomer_ByName(string Name);
        bool Insert(Models.CustomerProfile customer);
        bool UpdateCredit(Models.CustomerProfile customer, float amount);
        bool Update(Models.CustomerProfile customer, int col, string input);
        bool Delete(Models.CustomerProfile customer);
    }
}
