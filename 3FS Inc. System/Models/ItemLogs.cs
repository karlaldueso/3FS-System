using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FS_System.Models
{
    public class ItemLogs
    {
        public int ItemLogID { get; set; }
        public int ItemID { get; set; }
        public string TransactionType { get; set; }
        public string Previous { get; set; }
        public string Present { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
