﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using _3FS_System.Models;
using System.Data;


namespace _3FS_System.Repositories
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetItems_All();
        IEnumerable<Item> GetItems_ByName(string ItemName, string BrandName);
        bool Insert(Item item);
        bool Update(Item item, int col, string input);
        bool UpdateQty(int itemID, float qty, int transactiontype, DateTime updatedDate);
        bool Delete(Item item);
        int GetItemID(Item item);
    }
}
