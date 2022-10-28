using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FS_System.Models
{
    public class Sale
    {
        public int SalesID { get; set; }
        public string ReceiptNum { get; set; }
        public float Qty { get; set; }
        public string Unit { get; set; }
        public int ItemID { get; set; }
        public float UnitPrice { get; set; }  
        public float SubTotal { get; set; }
        public DateTime TransactionDate { get; set; }  

    }
}
