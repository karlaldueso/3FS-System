using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FS_System.Models
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public string ExpenseReceipt { get; set; }
        public string Details { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int StoreID { get; set; }
    }
}
