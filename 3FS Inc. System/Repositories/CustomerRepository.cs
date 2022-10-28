using _3FS_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using _3FS_System.Helpers;

namespace _3FS_System.Repositories
{
    internal class CustomerRepository : ICustomerRepository
    {
        public bool Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomer_ByName(string Name)
        {
            string qry = string.Format("dbo.spCustomerProfile_GetByName @FirstName='{0}', @LastName='{0}'", Name);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Customer>(qry);
                return output;
            }
        }

        public bool Insert(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCredit(Customer customer, float amount)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spCustomerProfile_UpdateCredit @CustomerID, @Amount", new { customer.CustomerID, amount });
                return true;
            }
        }
    }
}
