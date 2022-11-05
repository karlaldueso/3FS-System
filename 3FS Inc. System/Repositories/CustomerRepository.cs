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
        public IEnumerable<Customer> GetCustomer()
        {
            string qry = string.Format("dbo.spCustomerProfile_GetAll");
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Customer>(qry);
                return output;
            }
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spCustomerProfile_AddProfile @FirstName, @LastName, @ContactNumber, @Email, @Address, @Credit, @Terms, @UpdatedDate", customer);
                return true;
            }
        }
        public bool Update(Customer customer, int col, string input)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                switch (col)
                {
                    case 1:
                        customer.FirstName = input;
                        break;
                    case 2:
                        customer.LastName = input;
                        break;
                    case 3:
                        customer.ContactNumber = input;
                        break;
                    case 4:
                        customer.Email = input;
                        break;
                    case 5:
                        customer.Address = input;
                        break;
                    case 6:
                        customer.Credit = float.Parse(input);
                        break;
                    case 7:
                        customer.Terms = int.Parse(input);
                        break;
                }
                _ = connection.Execute("dbo.spCustomerProfile_UpdateProfile @CustomerID, @FirstName, @LastName, @ContactNumber, @Email, @Address, @Credit, @Terms, @UpdatedDate", customer);
                return true;
            }
        }
        public bool UpdateCredit(Customer customer, float amount)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spCustomerProfile_UpdateCredit @CustomerID, @Amount, @UpdatedDate", new { customer.CustomerID, amount, customer.UpdatedDate });
                return true;
            }
        }
    }
}
