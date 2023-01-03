using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FS_System.Models
{
    public class Receipt
    {
        public DateTime TransactionDate { get; set; }
        public string ReceiptNum { get; set; }
        public int CustomerID { get; set; }
        public float AmountPaid { get; set; }
        public float GrandTotal { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int StoreID { get; set; }
    }
}
