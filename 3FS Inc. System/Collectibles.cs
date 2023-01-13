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
            dataGridCustomers.Columns["UpdatedDate"].Visible = false;
            dataGridCustomers.Columns["CreatedDate"].Visible = false;
            dataGridCustomers.Columns["StoreID"].Visible = false;
            dataCollectiblesLog.Columns["UpdatedDate"].Visible = false;
            dataCollectiblesLog.Columns["CreatedDate"].Visible = false;
            dataCollectiblesLog.Columns["StoreID"].Visible = false;
            dataGridCollectibles.Columns["CustomerID"].Visible = false;
            dataGridCollectibles.Columns["UpdatedDate"].Visible = false;
            dataGridCollectibles.Columns["CreatedDate"].Visible = false;
            dataGridCollectibles.Columns["StoreID"].Visible = false;
            dataGridCustomers.AutoResizeColumns();
            dataGridCustomers.AutoResizeRows();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            datetimeLabel.Text = DateTime.Now.ToString();
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
                        int[] c_r = { dataGridCustomers.CurrentCellAddress.X, dataGridCustomers.CurrentCellAddress.Y };
                        int[] c_r_2 = { dataGridCollectibles.CurrentCellAddress.X, dataGridCollectibles.CurrentCellAddress.Y };
                        if (int.Parse(dataGridCollectibles.Rows[c_r_2[1]].Cells["Paid"].Value.ToString()) == 0)
                        {
                            if((float)Convert.ToDouble(dataGridCollectibles.Rows[c_r_2[1]].Cells["Balance"].Value) >= float.Parse(amountText.Text))
                            {
                                int CustomerID = int.Parse(dataGridCustomers.Rows[c_r[1]].Cells["CustomerID"].Value.ToString());
                                int CollectiblesID = int.Parse(dataGridCollectibles.Rows[c_r_2[1]].Cells["CollectiblesID"].Value.ToString());
                                float amount = float.Parse(amountText.Text);
                                float totalpayment = 0;
                                CollectiblesRepository collectiblesRepository = new CollectiblesRepository();
                                CollectiblesLog collectiblelog = new CollectiblesLog
                                {
                                    CustomerID = CustomerID,
                                    Amount = amount,
                                    TransactionDate = DateTime.Now,
                                    UpdatedDate = DateTime.Now,
                                    CreatedDate = DateTime.Now,
                                    StoreID = 1
                                };
                                collectiblesRepository.InsertLog(collectiblelog);
                                collectiblesRepository.UpdateBalance(CollectiblesID, amount, collectiblelog.UpdatedDate);
                                //Update Collectibles Display
                                dataCollectiblesLog.DataSource = collectiblesRepository.GetCollectibleLogs_ByCustomerID(CustomerID);
                                dataCollectiblesLog.Columns["UpdatedDate"].Visible = false;
                                dataCollectiblesLog.Columns["CreatedDate"].Visible = false;
                                dataCollectiblesLog.Columns["StoreID"].Visible = false;
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
                                CustomerRepository customerRepository = new CustomerRepository();
                                dataGridCustomers.DataSource = customerRepository.GetCustomer_ByName(searchCustomerTextbox.Text);
                                dataGridCustomers.Columns["CustomerID"].Visible = false;
                                dataGridCustomers.Columns["ContactNumber"].Visible = false;
                                dataGridCustomers.Columns["Email"].Visible = false;
                                dataGridCustomers.Columns["Address"].Visible = false;
                                dataGridCustomers.Columns["UpdatedDate"].Visible = false;
                                dataGridCustomers.Columns["CreatedDate"].Visible = false;
                                dataGridCustomers.Columns["StoreID"].Visible = false;
                                dataGridCustomers.AutoResizeColumns();
                                dataGridCustomers.AutoResizeRows();
                                //Update Collectibles Display
                                remainingtextbox.Text = String.Format("P{0:N2}", collectiblesRepository.GetBalanceByCustomerID(CustomerID));
                                dataGridCollectibles.DataSource = collectiblesRepository.GetCollectible_ByCustomerID(CustomerID);
                                dataGridCollectibles.Columns["CollectiblesID"].Visible = false;
                                dataGridCollectibles.Columns["CustomerID"].Visible = false;
                                dataGridCollectibles.Columns["Paid"].Visible = false;
                                dataGridCollectibles.Columns["TransactionDate"].Visible = false;
                                dataGridCollectibles.Columns["UpdatedDate"].Visible = false;
                                dataGridCollectibles.Columns["CreatedDate"].Visible = false;
                                dataGridCollectibles.Columns["StoreID"].Visible = false;
                                dataGridCollectibles.AutoResizeColumns();
                                dataGridCollectibles.AutoResizeRows();
                                float totalcredit = 0;
                                if (dataGridCollectibles.Rows.Count != 0)
                                {
                                    for (int i = 0; i < dataGridCollectibles.RowCount; i++)
                                    {
                                        totalcredit += (float)Convert.ToDouble(dataGridCollectibles.Rows[i].Cells["Amount"].Value);
                                        if (int.Parse(dataGridCollectibles.Rows[i].Cells["Paid"].Value.ToString()) == 0)
                                        {
                                            dataGridCollectibles.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
                                        }
                                        else
                                        {
                                            dataGridCollectibles.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                                        }
                                    }
                                    totalcredittextbox.Text = String.Format("P{0:N2}", totalcredit);
                                }
                                else
                                {
                                    totalcredittextbox.Clear();
                                }
                                remainingtextbox.Text = String.Format("P{0:N2}", collectiblesRepository.GetBalanceByCustomerID(CustomerID));
                                amountText.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Amount paid is greater than the balance!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Balance already paid in full!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
        private void dataGridCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridCustomers.Rows.Count != 0)
            {
                int[] c_r = { dataGridCustomers.CurrentCellAddress.X, dataGridCustomers.CurrentCellAddress.Y };
                int CustomerID = int.Parse(dataGridCustomers.Rows[c_r[1]].Cells[0].Value.ToString());

                float totalpayment = 0;
                float totalcredit = 0;

                CollectiblesRepository collectiblesRepository = new CollectiblesRepository();
                remainingtextbox.Text = String.Format("P{0:N2}", collectiblesRepository.GetBalanceByCustomerID(CustomerID));
                dataGridCollectibles.DataSource = collectiblesRepository.GetCollectible_ByCustomerID(CustomerID);
                dataGridCollectibles.Columns["CollectiblesID"].Visible = false;
                dataGridCollectibles.Columns["CustomerID"].Visible = false;
                dataGridCollectibles.Columns["Paid"].Visible = false;
                dataGridCollectibles.Columns["TransactionDate"].Visible = false;
                dataGridCollectibles.Columns["UpdatedDate"].Visible = false;
                dataGridCollectibles.Columns["CreatedDate"].Visible = false;
                dataGridCollectibles.Columns["StoreID"].Visible = false;
                dataGridCollectibles.AutoResizeColumns();
                dataGridCollectibles.AutoResizeRows();
                if (dataGridCollectibles.Rows.Count != 0)
                {
                    for (int i = 0; i < dataGridCollectibles.RowCount; i++)
                    {
                        totalcredit += (float)Convert.ToDouble(dataGridCollectibles.Rows[i].Cells["Amount"].Value); 
                        if (int.Parse(dataGridCollectibles.Rows[i].Cells["Paid"].Value.ToString()) == 0)
                        {
                            dataGridCollectibles.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
                        }
                        else
                        {
                            dataGridCollectibles.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                    }
                    totalcredittextbox.Text = String.Format("P{0:N2}", totalcredit);
                }
                else
                {
                    totalcredittextbox.Clear();
                }

                dataCollectiblesLog.DataSource = collectiblesRepository.GetCollectibleLogs_ByCustomerID(CustomerID);
                dataCollectiblesLog.Columns["CollectiblesLogID"].Visible = false;
                dataCollectiblesLog.Columns["CustomerID"].Visible = false;
                dataCollectiblesLog.Columns["UpdatedDate"].Visible = false;
                dataCollectiblesLog.Columns["StoreID"].Visible = false;
                dataCollectiblesLog.AutoResizeColumns();
                dataCollectiblesLog.AutoResizeRows();
                if (dataCollectiblesLog.Rows.Count != 0)
                {
                    for (int i = 0; i < dataCollectiblesLog.RowCount; i++)
                    {
                        totalpayment += (float)Convert.ToDouble(dataCollectiblesLog.Rows[i].Cells["Amount"].Value);
                    }
                    totalpaymentstextbox.Text = String.Format("P{0:N2}", totalpayment);
                }
                else
                {
                    totalpaymentstextbox.Clear();
                }
            }
        }
        private void dataGridCollectibles_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridCollectibles.Rows.Count != 0)
            {
                int[] c_r = { dataGridCollectibles.CurrentCellAddress.X, dataGridCollectibles.CurrentCellAddress.Y };
                string ReceiptNum = dataGridCollectibles.Rows[c_r[1]].Cells["ReceiptNum"].Value.ToString();

                SalesRepository salesRepository = new SalesRepository();
                dataGridReceiptDetails.DataSource = salesRepository.GetSale_ByReceipt(ReceiptNum);
                dataGridReceiptDetails.AutoResizeColumns();
                dataGridReceiptDetails.AutoResizeRows();
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
