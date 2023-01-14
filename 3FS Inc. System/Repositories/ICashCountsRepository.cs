using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3FS_System.Models;

namespace _3FS_System.Repositories
{
    public interface ICashCountsRepository
    {
        IEnumerable<CashCount> GetAllCashCount_PerDate(DateTime date);
        bool Insert(CashCount cashCount);
        bool Update(CashCount cashCount);
        bool Delete(CashCount cashCount);
        float GetActualRemainingCash_PerDate(DateTime date);
    }
}
