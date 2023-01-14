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
    internal class ExpensesRepository : IExpensesRepository
    {
        public bool Delete(Expense expense)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Expense> GetAllExpenses_PerDate(DateTime date)
        {
            string qry = string.Format("dbo.spExpenses_GetByDate @Date='{0}'", date.ToString("yyyy/MM/dd"));
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Expense>(qry);
                return output;
            }
        }

        public bool Insert(Expense expense)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spExpenses_AddExpense @ExpenseReceipt, @Details, @Amount, @TransactionDate, @UpdatedDate, @CreatedDate, @StoreID", expense);
                return true;
            }
        }

        public bool Update(Expense expense)
        {
            throw new NotImplementedException();
        }
        public float GetExpensesAmount_PerDate(DateTime date)
        {
            object amount;
            string qry = string.Format("dbo.spExpenses_AmountByDate @Date='{0}'", date.ToString("yyyy/MM/dd"));
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                amount = connection.ExecuteScalar(qry);
            }
            if (amount != null)
                return (float)Convert.ToDouble(amount.ToString());
            else
                return 0;
        }
    }
}
