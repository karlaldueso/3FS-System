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
    internal class DepositRepository : IDepositRepository
    {
        public bool Delete(Deposit deposit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Deposit> GetDeposit_ByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Deposit deposit)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spDeposits_AddDeposit @Amount, @TransactionDate, @UpdatedDate, @CreatedDate, @StoreID", deposit);
                return true;
            }
        }

        public bool Update(Deposit deposit)
        {
            throw new NotImplementedException();
        }
    }
}
