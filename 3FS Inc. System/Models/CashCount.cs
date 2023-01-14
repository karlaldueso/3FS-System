using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FS_System.Models
{
    public class CashCount
    {
        public int CashCountID { get; set; }
        public float ActualRemainingCash { get; set; }
        public float ComputedRemainingCash { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int StoreID { get; set; }
    }
}
