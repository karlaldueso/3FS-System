using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3FS_System.Models;

namespace _3FS_System.Repositories
{
    public interface IReceiptRepository
    {
        IEnumerable<Receipt> GetReceipt_ByCustomerID(int CustomerID);
        IEnumerable<Receipt> GetReceipt_ByDate(DateTime TransactionDate);
        bool Insert(Receipt receipt);
        bool Update(Receipt receipt);
        bool Delete(Receipt receipt);
    }
}
