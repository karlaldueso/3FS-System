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
        IEnumerable<CustomerProfile> GetCustomer();
        IEnumerable<CustomerProfile> GetCustomer_ByName(string Name);
        bool Insert(CustomerProfile customer);
        bool Update(CustomerProfile customer, int col, string input);
        bool Delete(CustomerProfile customer);
    }
}
