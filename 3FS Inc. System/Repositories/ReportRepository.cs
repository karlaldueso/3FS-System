using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using _3FS_System.Models;
using _3FS_System.Helpers;
using System.Data;

namespace _3FS_System.Repositories
{
    internal class ReportRepository : IReportRepository
    {
        public IEnumerable<Report_SalesPerItem> GetReport_SalesPerItem(DateTime StartDate, DateTime EndDate)
        {
            string qry = string.Format("dbo.spSales_GetPerItem @StartDate='{0}', @EndDate='{1}'", StartDate, EndDate);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<Report_SalesPerItem>(qry);
                return output;
            }
        }
    }
}
