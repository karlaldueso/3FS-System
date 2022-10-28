﻿using _3FS_System.Helpers;
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
            dataGridCustomers.AutoResizeColumns();
        }

        private void dataGridCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _ = new DataAccess();
            var val = dataGridCustomers.CurrentCell.Value;
            if (val != null)
            {
                int[] c_r = { dataGridCustomers.CurrentCellAddress.X, dataGridCustomers.CurrentCellAddress.Y };
                int CustomerID = int.Parse(dataGridCustomers.Rows[c_r[1]].Cells[0].Value.ToString());
                
                float totalpayment = 0;
                float totalcredit = 0;

                remainingtextbox.Text = dataGridCustomers.Rows[c_r[1]].Cells[5].Value.ToString();

                ReceiptRepository receiptRepository = new ReceiptRepository();
                dataGridReceipts.DataSource = receiptRepository.GetReceipt_ByCustomerID(CustomerID);
                dataGridReceipts.Columns["CustomerID"].Visible = false;
                dataGridReceipts.AutoResizeColumns();
                if (dataGridReceipts.Rows.Count != 0)
                {
                    for (int i = 0; i < dataGridReceipts.RowCount; i++)
                    {
                        totalcredit += (float)Convert.ToDouble(dataGridReceipts.Rows[i].Cells[4].Value) - (float)Convert.ToDouble(dataGridReceipts.Rows[i].Cells[3].Value);
                    }
                    totalorderstextbox.Text = String.Format("{0}", totalcredit.ToString());
                }
                else
                {
                    totalorderstextbox.Clear();
                }


                CollectiblesRepository collectiblesRepository = new CollectiblesRepository();
                dataCollectiblesLog.DataSource = collectiblesRepository.GetCollectibleLogs_ByCustomerID(CustomerID);
                dataCollectiblesLog.Columns["CollectiblesLogID"].Visible = false;
                dataCollectiblesLog.Columns["CustomerID"].Visible = false;
                dataCollectiblesLog.AutoResizeColumns();
                if (dataCollectiblesLog.Rows.Count != 0)
                {
                    for (int i = 0; i < dataCollectiblesLog.RowCount; i++)
                    {
                        totalpayment += (float)Convert.ToDouble(dataCollectiblesLog.Rows[i].Cells[3].Value);
                    }
                    totalpaymentstextbox.Text = String.Format("{0}", totalpayment.ToString());
                }
                else
                {
                    totalpaymentstextbox.Clear();
                }
            }
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
                            TransactionDate = DateTime.Now
                        };
                        CustomerRepository customerRepository = new CustomerRepository();
                        Customer customer = new Customer
                        {
                            CustomerID = CustomerID
                        };
                        collectiblesRepository.Insert(collectible);
                        customerRepository.UpdateCredit(customer, -amount);
                        //Update Collectibles Display
                        dataCollectiblesLog.DataSource = collectiblesRepository.GetCollectibleLogs_ByCustomerID(CustomerID);
                        dataCollectiblesLog.Columns["CollectiblesLogID"].Visible = false;
                        dataCollectiblesLog.Columns["CustomerID"].Visible = false;
                        dataCollectiblesLog.AutoResizeColumns();
                        if (dataCollectiblesLog.Rows.Count != 0)
                        {
                            for (int i = 0; i < dataCollectiblesLog.RowCount; i++)
                            {
                                totalpayment += (float)Convert.ToDouble(dataCollectiblesLog.Rows[i].Cells[3].Value);
                            }
                            totalpaymentstextbox.Text = String.Format("{0}", totalpayment.ToString());
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
                        dataGridCustomers.AutoResizeColumns();

                        remainingtextbox.Text = dataGridCustomers.Rows[c_r[1]].Cells[5].Value.ToString();

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
    }
}
