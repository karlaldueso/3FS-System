using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FS_System.Models
{
    public class ItemCategory
    {
        public int ItemCategoryID { get; set; }
        public string CategoryName { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int StoreID { get; set; }
    }
}
