using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FS_System.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public int ItemID { get; set; }
        public float Quantity { get; set; }
        public int WarehouseID { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
