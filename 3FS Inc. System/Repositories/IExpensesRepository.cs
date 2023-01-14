using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3FS_System.Models;

namespace _3FS_System.Repositories
{
    public interface IExpensesRepository
    {
        IEnumerable<Expense> GetAllExpenses_PerDate(DateTime date);
        bool Insert(Expense expense);
        bool Update(Expense expense);
        bool Delete(Expense expense);
        float GetExpensesAmount_PerDate(DateTime date);
    }
}
