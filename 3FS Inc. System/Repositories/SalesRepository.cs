using _3FS_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using _3FS_System.Helpers;

namespace _3FS_System.Repositories
{
    internal class SalesRepository : ISalesRepository
    {
        public IEnumerable<SalesPerReceipt_byDate> GetSale_ByDateRange(DateTime StartDate, DateTime EndDate)
        {
            string qry = string.Format("dbo.SalesPerReceipt_GetByDate @StartDate='{0}', @EndDate='{1}'", StartDate.ToString("yyyy/MM/dd"), EndDate.ToString("yyyy/MM/dd"));
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<SalesPerReceipt_byDate>(qry);
                return output;
            }
        }
        public IEnumerable<ReceiptDetails_DisplayFormat> GetSale_ByReceipt(string ReceiptNum)
        {
            string qry = string.Format("dbo.spSales_GetByReceipt @ReceiptNum={0}", ReceiptNum);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Query<ReceiptDetails_DisplayFormat>(qry);
                return output;
            }
        }
        public float GetTotalSalesOfTheDay(DateTime datetime)
        {
            object totalsales;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                totalsales = connection.ExecuteScalar("dbo.spReceipts_TotalSalesForTheDay @Date", datetime);
            }
            if (totalsales!=null)
                return (float)Convert.ToDouble(totalsales.ToString());
            else
                return 0;
        }
        public bool Insert(Sale sale)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("3FSDatabase")))
            {
                var output = connection.Execute("dbo.spSales_AddSales @ReceiptNum, @Qty, @Unit, @ItemID, @UnitPrice, @SubTotal ,@TransactionDate, @UpdatedDate", sale);
                return true;
            }
        }

        public bool Update(Sale sale)
        {
            throw new NotImplementedException();
        }
        public bool Delete(Sale sale)
        {
            throw new NotImplementedException();
        }

    }
}
