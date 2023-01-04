using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FS_System.Models
{
    public class Collectible
    {
        public int CollectibleID { get; set; }
        public int CustomerID   { get; set; }
        public string ReceiptNum { get; set; }
        public float Amount { get; set; }
        public float Balance { get; set; }
        public int Paid { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int StoreID { get; set; }
    }
}
