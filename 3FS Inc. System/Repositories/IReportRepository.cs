using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3FS_System.Models;

namespace _3FS_System.Repositories
{
    public interface IReportRepository
    {
        IEnumerable<Report_SalesPerItem> GetReport_SalesPerItem(DateTime StartDate, DateTime EndDate);
    }

}
