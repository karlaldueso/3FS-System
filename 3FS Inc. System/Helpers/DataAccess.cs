﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using _3FS_System.Models;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace _3FS_System.Helpers
{
    public class DataAccess
    {
        public List<Item> GetItem()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Item>("dbo.spItemInventory_GetAll").ToList();
                return output;
            }
        }
    }
}
