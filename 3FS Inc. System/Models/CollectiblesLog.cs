﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FS_System.Models
{
    public class CollectiblesLog
    {
        public int CollectiblesLogID { get; set; }
        public int CustomerID { get; set; }
        public DateTime TransactionDate { get; set; }
        public float Amount { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int StoreID { get; set; }
    }
}
