using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FS_System.Models
{
    public class ItemInventory
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string BrandName { get; set; }
        public float CategoryID { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
        public float SRP { get; set; }
        public float Capital { get; set; }
        public string Storage { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int StoreID { get; set; }
    }
}
