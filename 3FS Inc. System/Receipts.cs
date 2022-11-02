using _3FS_System.Helpers;
using _3FS_System.Models;
using _3FS_System.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3FS_System
{
    public partial class Receipts : Form
    {
        public Receipts()
        {
            InitializeComponent();

            _ = new DataAccess();
            ReceiptRepository receiptRepository = new ReceiptRepository();
            dataGridReceipts.DataSource = receiptRepository.GetReceipt_ByDate(dateTimePicker1.Value.Date);
            dataGridReceipts.AutoResizeColumns();
            dataGridReceipts.AutoResizeRows();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _ = new DataAccess();
            ReceiptRepository receiptRepository = new ReceiptRepository();
            dataGridReceipts.DataSource = receiptRepository.GetReceipt_ByDate(dateTimePicker1.Value.Date);
            dataGridReceipts.AutoResizeColumns();
            dataGridReceipts.AutoResizeRows();
        }

        private void dataGridReceipts_SelectionChanged(object sender, EventArgs e)
        {
            _ = new DataAccess();
            var val = dataGridReceipts.CurrentCell.Value;
            if (val != null)
            {
                int[] c_r = { dataGridReceipts.CurrentCellAddress.X, dataGridReceipts.CurrentCellAddress.Y };
                string ReceiptNum = dataGridReceipts.Rows[c_r[1]].Cells[0].Value.ToString();

                SalesRepository salesRepository = new SalesRepository();
                dataGridReceiptDetails.DataSource = salesRepository.GetSale_ByReceipt(ReceiptNum);
                dataGridReceiptDetails.AutoResizeColumns();
                dataGridReceiptDetails.AutoResizeRows();
            }
        }
    }
}
