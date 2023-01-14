using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3FS_System.Models;

namespace _3FS_System.Repositories
{
    public interface IDepositRepository
    {
        IEnumerable<Deposit> GetDeposit_ByDate(DateTime date);
        bool Insert(Deposit deposit);
        bool Update(Deposit deposit);
        bool Delete(Deposit deposit);
    }
}
