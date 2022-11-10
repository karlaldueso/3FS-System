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
    public partial class Collectibles : Form
    {
        public Collectibles()
        {
            InitializeComponent();
            datetimeLabel.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void searchCustomerTextbox_TextChanged(object sender, EventArgs e)
        {
            _ = new DataAccess();
            CustomerRepository customerRepository = new CustomerRepository();
            dataGridCustomers.DataSource = customerRepository.GetCustomer_ByName(searchCustomerTextbox.Text);
            dataGridCustomers.Columns["CustomerID"].Visible = false;
            dataGridCustomers.Columns["ContactNumber"].Visible = false;
            dataGridCustomers.Columns["Email"].Visible = false;
            dataGridCustomers.Columns["Address"].Visible = false;
            dataGridCustomers.Columns["Terms"].Visible = false;
            dataGridCustomers.Columns["UpdatedDate"].Visible = false;
            dataGridCustomers.AutoResizeColumns();
            dataGridCustomers.AutoResizeRows();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            datetimeLabel.Text = DateTime.Now.ToString();
        }

        private void paidButton_Click(object sender, EventArgs e)
        {

        }

        private void paidButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridCustomers.Rows.Count != 0)
            {
                if (!(String.IsNullOrEmpty(amountText.Text)))
                {
                    float parsedValue;
                    if (float.TryParse(amountText.Text, out parsedValue))
                    {
                        _ = new DataAccess();
                        int[] c_r = { dataGridCustomers.CurrentCellAddress.X, dataGridCustomers.CurrentCellAddress.Y };
                        int CustomerID = int.Parse(dataGridCustomers.Rows[c_r[1]].Cells[0].Value.ToString());

                        float amount = float.Parse(amountText.Text);
                        float totalpayment = 0;
                        CollectiblesRepository collectiblesRepository = new CollectiblesRepository();
                        Collectible collectible = new Collectible
                        {
                            CustomerID = CustomerID,
                            Amount = amount,
                            TransactionDate = DateTime.Now,
                            UpdatedDate = DateTime.Now
                        };
                        CustomerRepository customerRepository = new CustomerRepository();
                        Customer customer = new Customer
                        {
                            CustomerID = CustomerID,
                            UpdatedDate = DateTime.Now,
                        };
                        collectiblesRepository.Insert(collectible);
                        customerRepository.UpdateCredit(customer, -amount);
                        //Update Collectibles Display
                        dataCollectiblesLog.DataSource = collectiblesRepository.GetCollectibleLogs_ByCustomerID(CustomerID);
                        dataCollectiblesLog.Columns["CollectiblesLogID"].Visible = false;
                        dataCollectiblesLog.Columns["CustomerID"].Visible = false;
                        dataCollectiblesLog.Columns["UpdatedDate"].Visible = false;
                        dataCollectiblesLog.AutoResizeColumns();
                        dataCollectiblesLog.AutoResizeRows();
                        if (dataCollectiblesLog.Rows.Count != 0)
                        {
                            for (int i = 0; i < dataCollectiblesLog.RowCount; i++)
                            {
                                totalpayment += (float)Convert.ToDouble(dataCollectiblesLog.Rows[i].Cells[3].Value);
                            }
                            totalpaymentstextbox.Text = String.Format("P{0:N2}", totalpayment);
                        }
                        else
                        {
                            totalpaymentstextbox.Clear();
                        }
                        //Update Customers Display
                        dataGridCustomers.DataSource = customerRepository.GetCustomer_ByName(searchCustomerTextbox.Text);
                        dataGridCustomers.Columns["CustomerID"].Visible = false;
                        dataGridCustomers.Columns["ContactNumber"].Visible = false;
                        dataGridCustomers.Columns["Email"].Visible = false;
                        dataGridCustomers.Columns["UpdatedDate"].Visible = false;
                        dataGridCustomers.AutoResizeColumns();
                        dataGridCustomers.AutoResizeRows();

                        remainingtextbox.Text = String.Format("P{0:N2}", dataGridCustomers.Rows[c_r[1]].Cells[6].Value);

                        amountText.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Please enter numbers only!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter numbers only!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridReceipts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridReceipts_SelectionChanged(object sender, EventArgs e)
        {
            _ = new DataAccess();
            
            if (dataGridReceipts.Rows.Count != 0)
            {
                int[] c_r = { dataGridReceipts.CurrentCellAddress.X, dataGridReceipts.CurrentCellAddress.Y };
                string ReceiptNum = dataGridReceipts.Rows[c_r[1]].Cells[1].Value.ToString();

                SalesRepository salesRepository = new SalesRepository();
                dataGridReceiptDetails.DataSource = salesRepository.GetSale_ByReceipt(ReceiptNum);
                dataGridReceiptDetails.AutoResizeColumns();
                dataGridReceiptDetails.AutoResizeRows();
            }
        }

        private void dataGridCustomers_SelectionChanged(object sender, EventArgs e)
        {
            _ = new DataAccess();
            if (dataGridCustomers.Rows.Count != 0)
            {
                int[] c_r = { dataGridCustomers.CurrentCellAddress.X, dataGridCustomers.CurrentCellAddress.Y };
                int CustomerID = int.Parse(dataGridCustomers.Rows[c_r[1]].Cells[0].Value.ToString());

                float totalpayment = 0;
                float totalcredit = 0;
                float totalorders = 0;

                remainingtextbox.Text = String.Format("P{0:N2}", dataGridCustomers.Rows[c_r[1]].Cells[6].Value);

                ReceiptRepository receiptRepository = new ReceiptRepository();
                dataGridReceipts.DataSource = receiptRepository.GetReceipt_ByCustomerID(CustomerID);
                dataGridReceipts.Columns["CustomerID"].Visible = false;
                dataGridReceipts.Columns["UpdatedDate"].Visible = false;
                dataGridReceipts.AutoResizeColumns();
                dataGridReceipts.AutoResizeRows();
                if (dataGridReceipts.Rows.Count != 0)
                {
                    for (int i = 0; i < dataGridReceipts.RowCount; i++)
                    {
                        totalcredit += (float)Convert.ToDouble(dataGridReceipts.Rows[i].Cells[4].Value) - (float)Convert.ToDouble(dataGridReceipts.Rows[i].Cells[3].Value);
                        totalorders += (float)Convert.ToDouble(dataGridReceipts.Rows[i].Cells[4].Value);
                    }
                    totalcredittextbox.Text = String.Format("P{0:N2}", totalcredit);
                    totalorderstextbox.Text = String.Format("P{0:N2}", totalorders);
                }
                else
                {
                    totalorderstextbox.Clear();
                    totalcredittextbox.Clear();
                }


                CollectiblesRepository collectiblesRepository = new CollectiblesRepository();
                dataCollectiblesLog.DataSource = collectiblesRepository.GetCollectibleLogs_ByCustomerID(CustomerID);
                dataCollectiblesLog.Columns["CollectiblesLogID"].Visible = false;
                dataCollectiblesLog.Columns["CustomerID"].Visible = false;
                dataCollectiblesLog.Columns["UpdatedDate"].Visible = false;
                dataCollectiblesLog.AutoResizeColumns();
                dataCollectiblesLog.AutoResizeRows();
                if (dataCollectiblesLog.Rows.Count != 0)
                {
                    for (int i = 0; i < dataCollectiblesLog.RowCount; i++)
                    {
                        totalpayment += (float)Convert.ToDouble(dataCollectiblesLog.Rows[i].Cells[3].Value);
                    }
                    totalpaymentstextbox.Text = String.Format("P{0:N2}", totalpayment);
                }
                else
                {
                    totalpaymentstextbox.Clear();
                }
            }
        }

        private void Collectibles_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.FormBackground;
            panel3.BackColor = Properties.Settings.Default.FormBackground;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
