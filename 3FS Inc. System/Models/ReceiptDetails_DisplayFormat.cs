using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FS_System.Models
{
    public class ReceiptDetails_DisplayFormat
    {
        public float QTY { get; set; }
        public string Unit { get; set; }
        public string BrandName { get; set; } 
        public string ItemName { get; set; }
        public float UnitPrice { get; set; }
        public float SubTotal { get; set; }
    }
}
