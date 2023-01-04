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
        public bool Delete(Models.CustomerProfile customer)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Models.CustomerProfile> GetCustomer()
        {
            string qry = string.Format("dbo.spCustomerProfile_GetAll");
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Models.CustomerProfile>(qry);
                return output;
            }
        }
        public IEnumerable<Models.CustomerProfile> GetCustomer_ByName(string Name)
        {
            string qry = string.Format("dbo.spCustomerProfile_GetByName @FirstName='{0}', @LastName='{0}'", Name);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Models.CustomerProfile>(qry);
                return output;
            }
        }

        public bool Insert(Models.CustomerProfile customer)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spCustomerProfile_AddProfile @FirstName, @LastName, @ContactNumber, @Email, @Address, @UpdatedDate, @CreatedDate, @StoreID", customer);
                return true;
            }
        }
        public bool Update(Models.CustomerProfile customer, int col, string input)
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
                }
                _ = connection.Execute("dbo.spCustomerProfile_UpdateProfile @CustomerID, @FirstName, @LastName, @ContactNumber, @Email, @Address, @Credit, @Terms, @UpdatedDate", customer);
                return true;
            }
        }
    }
}
