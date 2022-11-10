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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            _ = new DataAccess();
            SalesRepository salesRepository = new SalesRepository();
            totalSales.Text = String.Format("P{0:N2}", salesRepository.GetTotalSalesOfTheDay(DateTime.Today));
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            if (dataGridInventory.SelectedCells.Count > 0)
            {
                int[] c_r = { dataGridInventory.CurrentCellAddress.X, dataGridInventory.CurrentCellAddress.Y };
                int row_count = dataGridItems.RowCount;
                string exstID = dataGridInventory.Rows[c_r[1]].Cells[0].Value.ToString();
                bool exst = false;
                int index = 0;
                dataGridItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                if (row_count >= 0)
                {
                    try
                    {
                        foreach (DataGridViewRow row in dataGridItems.Rows) //Check if item to be added exits in the list
                        {
                            if (row.Cells[0].Value.ToString().Equals(exstID))
                            {
                                index = (int)Convert.ToInt32(row.Index);
                                exst = true;
                                break;
                            }
                        }
                    }
                    catch
                    {

                    }
                }
                if (exst == true)
                {
                    //Qty
                    dataGridItems.Rows[index].Cells[2].Value = (float)Convert.ToDouble(dataGridItems.Rows[index].Cells[2].Value) + 1.00;
                    float qty = (float)Convert.ToDouble(dataGridItems.Rows[index].Cells[2].Value);
                    float unitprice = (float)Convert.ToDouble(dataGridItems.Rows[index].Cells[8].Value);
                    float subtot = qty * unitprice;
                    float grandtot = 0;
                    //Sub Total
                    dataGridItems.Rows[index].Cells[9].Value = String.Format("{0:0.##}", subtot);
                    for (int i = 0; i < row_count; i++)
                    {
                        grandtot += (float)Convert.ToDouble(dataGridItems.Rows[i].Cells[9].Value);
                    }
                    grandtotalTextbox.Text = String.Format("{0:N2}", grandtot);
                }
                else if (exst == false)
                {
                    dataGridItems.RowCount++;
                    //ItemID
                    dataGridItems.Rows[row_count].Cells[0].Value = dataGridInventory.Rows[c_r[1]].Cells[0].Value;
                    //Item#
                    dataGridItems.Rows[row_count].Cells[1].Value = row_count + 1;
                    //Qty
                    dataGridItems.Rows[row_count].Cells[2].Value = 1.00;
                    //Unit
                    dataGridItems.Rows[row_count].Cells[3].Value = dataGridInventory.Rows[c_r[1]].Cells[5].Value;
                    //Name
                    dataGridItems.Rows[row_count].Cells[4].Value = dataGridInventory.Rows[c_r[1]].Cells[1].Value;
                    //Brand
                    dataGridItems.Rows[row_count].Cells[5].Value = dataGridInventory.Rows[c_r[1]].Cells[2].Value;
                    //SRP
                    dataGridItems.Rows[row_count].Cells[6].Value = dataGridInventory.Rows[c_r[1]].Cells[6].Value;
                    //Capital
                    dataGridItems.Rows[row_count].Cells[7].Value = dataGridInventory.Rows[c_r[1]].Cells[7].Value;
                    //Unit Price
                    dataGridItems.Rows[row_count].Cells[8].Value = dataGridInventory.Rows[c_r[1]].Cells[6].Value;
                    float qty = (float)Convert.ToDouble(dataGridItems.Rows[row_count].Cells[2].Value);
                    float unitprice = (float)Convert.ToDouble(dataGridItems.Rows[row_count].Cells[8].Value);
                    float subtot = qty * unitprice;
                    float grandtot = 0;
                    //Sub Total
                    dataGridItems.Rows[row_count].Cells[9].Value = String.Format("{0:0.##}", subtot);
                    for (int i = 0; i <= row_count; i++)
                    {
                        grandtot += (float)Convert.ToDouble(dataGridItems.Rows[i].Cells[9].Value);
                    }
                    grandtotalTextbox.Text = String.Format("{0:N2}", grandtot);
                }
            }
        }

        private void searchName_TextChanged(object sender, EventArgs e)
        {
            _ = new DataAccess();
            ItemRepository itemRepository = new ItemRepository();
            dataGridInventory.DataSource = itemRepository.GetItems_ByName(searchName.Text, searchBrandName.Text);
            dataGridInventory.Columns["UpdatedDate"].Visible = false;
            dataGridInventory.Columns["ItemID"].Visible = false;
            dataGridInventory.Columns["CategoryID"].Visible = false;
            dataGridInventory.AutoResizeColumns();
        }

        private void searchBrandName_TextChanged(object sender, EventArgs e)
        {
            _ = new DataAccess();
            ItemRepository itemRepository = new ItemRepository();
            dataGridInventory.DataSource = itemRepository.GetItems_ByName(searchName.Text, searchBrandName.Text);
            dataGridInventory.Columns["UpdatedDate"].Visible = false;
            dataGridInventory.Columns["ItemID"].Visible = false;
            dataGridInventory.Columns["CategoryID"].Visible = false;
            dataGridInventory.AutoResizeColumns();
            dataGridInventory.AutoResizeRows();
        }

        private void removeitemButton_Click(object sender, EventArgs e)
        {

            int row_count = dataGridItems.RowCount;
            if (row_count != 0)
            {
                int[] c_r = { dataGridItems.CurrentCellAddress.X, dataGridItems.CurrentCellAddress.Y };
                dataGridItems.Rows.RemoveAt(c_r[1]);
                float grandtot = 0;
                for (int i = 0; i < row_count-1; i++)
                {
                    dataGridItems.Rows[i].Cells[1].Value = i + 1;
                    grandtot += (float)Convert.ToDouble(dataGridItems.Rows[i].Cells[9].Value);
                }
                grandtotalTextbox.Text = String.Format("{0:N2}", grandtot);
            }
            
        }

        private void dataGridItems_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int[] c_r = { dataGridItems.CurrentCellAddress.X, dataGridItems.CurrentCellAddress.Y };
            int row_count = dataGridItems.RowCount;
            
            float qty = (float)Convert.ToDouble(dataGridItems.Rows[c_r[1]].Cells[2].Value);
            float srp = (float)Convert.ToDouble(dataGridItems.Rows[c_r[1]].Cells[6].Value);
            float capital = (float)Convert.ToDouble(dataGridItems.Rows[c_r[1]].Cells[7].Value);
            float unitprice = (float)Convert.ToDouble(dataGridItems.Rows[c_r[1]].Cells[8].Value);
            float subtot;
            float grandtot = 0;
            if (unitprice < capital)
            {
                MessageBox.Show(String.Format("Capital: P{0:N2}\nSRP: P{0:N2}", capital, srp), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Unit Price
                dataGridItems.Rows[c_r[1]].Cells[8].Value = srp;
                subtot = qty * srp;
            }
            else
            {
                subtot = qty * unitprice;
            }
            //Sub Total
            dataGridItems.Rows[c_r[1]].Cells[9].Value = String.Format("{0:0.##}", subtot);
            for (int i = 0; i < row_count; i++)
            {
                grandtot += (float)Convert.ToDouble(dataGridItems.Rows[i].Cells[9].Value);
            }
            grandtotalTextbox.Text = String.Format("{0:N2}", grandtot);
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(receiptnumTextbox.Text)))
            {
                if ((dataGridInventory.SelectedCells.Count > 0) && (dataGridCustomers.SelectedCells.Count > 0))
                {
                    float parsedValue;
                    if (float.TryParse(amountPaidTextbox.Text, out parsedValue))
                    {
                        DateTime dateTime = dateTimePicker1.Value;
                        DataAccess db = new DataAccess();

                        //Insert to Receipt Table
                        ReceiptRepository receiptRepository = new ReceiptRepository();
                        int[] c_r = { dataGridCustomers.CurrentCellAddress.X, dataGridCustomers.CurrentCellAddress.Y };
                        int customerID = (int)Convert.ToInt32(dataGridCustomers.Rows[c_r[1]].Cells[0].Value);
                        Receipt receipt = new Receipt
                        {
                            ReceiptNum = receiptnumTextbox.Text,
                            CustomerID = customerID,
                            TransactionDate = dateTime,
                            UpdatedDate = DateTime.Now
                        };
                        receipt.AmountPaid = float.Parse(String.Format("{0:0.##}", amountPaidTextbox.Text));
                        receipt.GrandTotal = float.Parse(String.Format("{0:N2}", grandtotalTextbox.Text));
                        receiptRepository.Insert(receipt);

                        //Insert to Sales Table
                        SalesRepository salesRepository = new SalesRepository();
                        ItemRepository itemRepository = new ItemRepository();
                        Sale sales = new Sale();
                        sales.TransactionDate = dateTime;
                        sales.UpdatedDate = receipt.UpdatedDate; 
                        for (int i = 0; i < dataGridItems.Rows.Count; i++)
                        {
                            sales.ReceiptNum = receiptnumTextbox.Text;
                            sales.Qty = (float)Convert.ToDouble(dataGridItems.Rows[i].Cells[2].Value);
                            sales.Unit = dataGridItems.Rows[i].Cells[3].Value.ToString();
                            sales.ItemID = (int)Convert.ToInt32(dataGridItems.Rows[i].Cells[0].Value);
                            sales.UnitPrice = (float)Convert.ToDouble(dataGridItems.Rows[i].Cells[8].Value);
                            sales.SubTotal = (float)Convert.ToDouble(dataGridItems.Rows[i].Cells[9].Value);
                            salesRepository.Insert(sales);
                            itemRepository.UpdateQty(sales.ItemID, sales.Qty, 1, dateTime);
                        }

                        if (receipt.CustomerID != 3)
                        {
                            CustomerRepository customerRepository = new CustomerRepository();
                            //Update Customer Credit
                            Customer customer = new Customer
                            {
                                CustomerID = receipt.CustomerID,
                                UpdatedDate = receipt.UpdatedDate
                            };
                            float credit = receipt.GrandTotal-receipt.AmountPaid;
                            customerRepository.UpdateCredit(customer, credit);
                        }

                        totalSales.Text = String.Format("P{0:N2}", salesRepository.GetTotalSalesOfTheDay(DateTime.Today));

                        dataGridItems.Rows.Clear();
                        searchName.Clear();
                        amountPaidTextbox.Clear();
                        grandtotalTextbox.Clear();
                        receiptnumTextbox.Clear();

                        MessageBox.Show("Added successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    {
                        MessageBox.Show("Please enter numbers only!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Incomplete details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Input Receipt #!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void searchCustomerTextbox_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            CustomerRepository customerRepository = new CustomerRepository();
            dataGridCustomers.DataSource = customerRepository.GetCustomer_ByName(searchCustomerTextbox.Text);
            dataGridCustomers.Columns["CustomerID"].Visible = false;
            dataGridCustomers.Columns["ContactNumber"].Visible = false;
            dataGridCustomers.Columns["Email"].Visible = false;
            dataGridCustomers.Columns["UpdatedDate"].Visible = false;
            dataGridCustomers.AutoResizeColumns();
        }

        private void Sales_DockChanged(object sender, EventArgs e)
        {

        }

        private void dataGridInventory_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int[] c_r = { dataGridInventory.CurrentCellAddress.X, dataGridInventory.CurrentCellAddress.Y };
            int row_count = dataGridItems.RowCount;
            string exstID = dataGridInventory.Rows[c_r[1]].Cells[0].Value.ToString();
            bool exst = false;
            int index = 0;
            dataGridItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (row_count >= 0)
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridItems.Rows) //Check if item to be added exits in the list
                    {
                        if (row.Cells[0].Value.ToString().Equals(exstID))
                        {
                            index = (int)Convert.ToInt32(row.Index);
                            exst = true;
                            break;
                        }
                    }
                }
                catch
                {

                }
            }
            if (exst == true)
            {
                //Qty
                dataGridItems.Rows[index].Cells[2].Value = (float)Convert.ToDouble(dataGridItems.Rows[index].Cells[2].Value) + 1.00;
                float qty = (float)Convert.ToDouble(dataGridItems.Rows[index].Cells[2].Value);
                float unitprice = (float)Convert.ToDouble(dataGridItems.Rows[index].Cells[8].Value);
                float subtot = qty * unitprice;
                float grandtot = 0;
                //Sub Total
                dataGridItems.Rows[index].Cells[9].Value = String.Format("{0:0.##}", subtot);
                for (int i = 0; i < row_count; i++)
                {
                    grandtot += (float)Convert.ToDouble(dataGridItems.Rows[i].Cells[9].Value);
                }
                grandtotalTextbox.Text = String.Format("{0:N2}", grandtot);
            }
            else if (exst == false)
            {
                dataGridItems.RowCount++;
                //ItemID
                dataGridItems.Rows[row_count].Cells[0].Value = dataGridInventory.Rows[c_r[1]].Cells[0].Value;
                //Item#
                dataGridItems.Rows[row_count].Cells[1].Value = row_count + 1;
                //Qty
                dataGridItems.Rows[row_count].Cells[2].Value = 1.00;
                //Unit
                dataGridItems.Rows[row_count].Cells[3].Value = dataGridInventory.Rows[c_r[1]].Cells[5].Value;
                //Name
                dataGridItems.Rows[row_count].Cells[4].Value = dataGridInventory.Rows[c_r[1]].Cells[1].Value;
                //Brand
                dataGridItems.Rows[row_count].Cells[5].Value = dataGridInventory.Rows[c_r[1]].Cells[2].Value;
                //SRP
                dataGridItems.Rows[row_count].Cells[6].Value = dataGridInventory.Rows[c_r[1]].Cells[6].Value;
                //Capital
                dataGridItems.Rows[row_count].Cells[7].Value = dataGridInventory.Rows[c_r[1]].Cells[7].Value;
                //Unit Price
                dataGridItems.Rows[row_count].Cells[8].Value = dataGridInventory.Rows[c_r[1]].Cells[6].Value;
                float qty = (float)Convert.ToDouble(dataGridItems.Rows[row_count].Cells[2].Value);
                float unitprice = (float)Convert.ToDouble(dataGridItems.Rows[row_count].Cells[8].Value);
                float subtot = qty * unitprice;
                float grandtot = 0;
                //Sub Total
                dataGridItems.Rows[row_count].Cells[9].Value = String.Format("{0:0.##}", subtot);
                for (int i = 0; i <= row_count; i++)
                {
                    grandtot += (float)Convert.ToDouble(dataGridItems.Rows[i].Cells[9].Value);
                }
                grandtotalTextbox.Text = String.Format("{0:N2}", grandtot);
            }
        }

        private void receiptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Receipts")
                {
                    bFormNameOpen = true;
                    frm.Focus();
                    break;
                }
                else
                {
                    bFormNameOpen = false;
                }
            }
            if (bFormNameOpen == false)
            {
                Receipts receipts = new Receipts();
                receipts.MdiParent = this.ParentForm;
                receipts.Show();
            }
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.FormBackground;
            this.Height = 646;
            this.Width = 1128;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
