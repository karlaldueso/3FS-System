using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FS_System.Models
{
    public class SalesPerReceipt_byDate
    {
        public DateTime TransactionDate { get; set; }
        public string ReceiptNum { get; set; }
        public float AmountPaid { get; set; }
        public float GrandTotal { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
