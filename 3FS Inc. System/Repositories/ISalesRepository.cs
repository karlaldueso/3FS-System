using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3FS_System.Models;

namespace _3FS_System.Repositories
{
    public interface ISalesRepository
    {
        IEnumerable<Sale> GetSale_ByReceipt(string ReceiptNum);
        bool Insert(Sale sale);
        bool Update(Sale sale);
        bool Delete(Sale sale);
    }
}
