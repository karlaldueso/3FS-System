using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using _3FS_System.Helpers;
using _3FS_System.Models;
using _3FS_System.Repositories;
using _3FS_System.Global_Variables;

namespace _3FS_System
{
    public partial class CustomersProfile : Form
    {
        public CustomersProfile()
        {
            InitializeComponent();

            DataAccess db = new DataAccess();
            CustomerRepository customerRepository = new CustomerRepository();
            dataGridCustomers.DataSource = customerRepository.GetCustomer();
            dataGridCustomers.Columns["CustomerID"].Visible = false;
            dataGridCustomers.Columns["UpdatedDate"].Visible = false;
            dataGridCustomers.Columns["CreatedDate"].Visible = false;
            dataGridCustomers.Columns["StoreID"].Visible = false;
        }

        private void dataGridCustomers_SelectionChanged(object sender, EventArgs e)
        {
            _ = new DataAccess();
            var val = dataGridCustomers.CurrentCell.Value;
            int[] c_r = { dataGridCustomers.CurrentCellAddress.X, dataGridCustomers.CurrentCellAddress.Y };
            if (val != null)
            {
                int CustomerID = int.Parse(dataGridCustomers.Rows[c_r[1]].Cells[0].Value.ToString());

                float totalpayment = 0;
                float totalcredit = 0;
                float totalorders = 0;

                ReceiptRepository receiptRepository = new ReceiptRepository();
                dataGridReceipts.DataSource = receiptRepository.GetReceipt_ByCustomerID(CustomerID);
                dataGridReceipts.Columns["CustomerID"].Visible = false;
                dataGridReceipts.Columns["UpdatedDate"].Visible = false;
                dataGridReceipts.Columns["CreatedDate"].Visible = false;
                dataGridReceipts.Columns["StoreID"].Visible = false;
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
                    totalcredittextbox.Clear();
                    totalorderstextbox.Clear();
                }


                CollectiblesRepository collectiblesRepository = new CollectiblesRepository();
                dataCollectiblesLog.DataSource = collectiblesRepository.GetCollectibleLogs_ByCustomerID(CustomerID);
                dataCollectiblesLog.Columns["CollectiblesLogID"].Visible = false;
                dataCollectiblesLog.Columns["CustomerID"].Visible = false;
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
                EditText.Text = dataGridCustomers.Rows[c_r[1]].Cells[c_r[0]].Value.ToString();
            }
            switch (c_r[0])
            {
                case 1:
                    editlabel.Text = "First Name:";
                    break;
                case 2:
                    editlabel.Text = "Last Name:";
                    break;
                case 3:
                    editlabel.Text = "Contact Number:";
                    break;
                case 4:
                    editlabel.Text = "Email:";
                    break;
                case 5:
                    editlabel.Text = "Address:";
                    break;
                case 6:
                    editlabel.Text = "Credit:";
                    break;
                case 7:
                    editlabel.Text = "Terms:";
                    break;
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(firstNametext.Text)) || (String.IsNullOrEmpty(lastNametext.Text)) || (String.IsNullOrEmpty(contacttext.Text)) || (String.IsNullOrEmpty(emailtext.Text)) || (String.IsNullOrEmpty(addresstext.Text)))
            {
                MessageBox.Show("Enter complete details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Declaring and Init
                    _ = new DataAccess();
                    CustomerRepository customerRepository = new CustomerRepository();
                    Models.CustomerProfile customer = new Models.CustomerProfile
                    {
                        //Assign parameters based on input
                        FirstName= firstNametext.Text,
                        LastName= lastNametext.Text,
                        ContactNumber= contacttext.Text,
                        Email= emailtext.Text,
                        Address= addresstext.Text,
                        UpdatedDate = DateTime.Now,
                        CreatedDate= DateTime.Now,
                        StoreID = 1
                    };
                    customerRepository.Insert(customer);
                    //Display and clear textbox
                    firstNametext.Clear();
                    lastNametext.Clear();
                    contacttext.Clear();
                    emailtext.Clear();
                    addresstext.Clear();


                    dataGridCustomers.DataSource = customerRepository.GetCustomer();
                    dataGridCustomers.Columns["CustomerID"].Visible = false;
                    dataGridCustomers.Columns["UpdatedDate"].Visible = false;
                    dataGridCustomers.Columns["CreatedDate"].Visible = false;
                    dataGridCustomers.Columns["StoreID"].Visible = false;

                }
                catch
                {
                    MessageBox.Show("Invalid Input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void searchName_TextChanged(object sender, EventArgs e)
        {
            _ = new DataAccess();
            CustomerRepository customerRepository = new CustomerRepository();
            dataGridCustomers.DataSource = customerRepository.GetCustomer_ByName(searchName.Text);
            dataGridCustomers.Columns["CustomerID"].Visible = false;
            dataGridCustomers.Columns["UpdatedDate"].Visible = false;
            dataGridCustomers.Columns["CreatedDate"].Visible = false;
            dataGridCustomers.Columns["StoreID"].Visible = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _ = new DataAccess();
            CustomerRepository customerRepository = new CustomerRepository();
            int[] c_r = { dataGridCustomers.CurrentCellAddress.X, dataGridCustomers.CurrentCellAddress.Y };
            if (dataGridCustomers.Rows[c_r[1]].Cells[c_r[0]].Value.ToString() != EditText.Text)
            {
                CustomerProfile customer = new CustomerProfile
                {
                    //Assign parameters based on selected row on datagridview1
                    CustomerID = int.Parse(dataGridCustomers.Rows[c_r[1]].Cells[0].Value.ToString()),
                    FirstName = dataGridCustomers.Rows[c_r[1]].Cells[1].Value.ToString(),
                    LastName = dataGridCustomers.Rows[c_r[1]].Cells[2].Value.ToString(),
                    ContactNumber = dataGridCustomers.Rows[c_r[1]].Cells[3].Value.ToString(),
                    Email = dataGridCustomers.Rows[c_r[1]].Cells[4].Value.ToString(),
                    Address = dataGridCustomers.Rows[c_r[1]].Cells[5].Value.ToString(),
                    UpdatedDate = DateTime.Now
                };
                customerRepository.Update(customer, c_r[0], EditText.Text); //update selected row
                dataGridCustomers.DataSource = customerRepository.GetCustomer();
                dataGridCustomers.Columns["CustomerID"].Visible = false;
                dataGridCustomers.Columns["UpdatedDate"].Visible = false;
                dataGridCustomers.Columns["CreatedDate"].Visible = false;
                dataGridCustomers.Columns["StoreID"].Visible = false;
            }
            else
            {
                MessageBox.Show("Input is the same!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.FormBackground;
        }
    }
}
