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
        IEnumerable<Customer> GetCustomer();
        IEnumerable<Customer> GetCustomer_ByName(string Name);
        bool Insert(Customer customer);
        bool UpdateCredit(Customer customer, float amount);
        bool Update(Customer customer, int col, string input);
        bool Delete(Customer customer);
    }
}
