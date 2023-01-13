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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            dataGridAddExpenses.RowCount++;
        }

        private void removeRowButton_Click(object sender, EventArgs e)
        {
            if(dataGridAddExpenses.Rows.Count > 0)
            {
                if(dataGridAddExpenses.CurrentCell.RowIndex >= 0)
                {
                    dataGridAddExpenses.Rows.RemoveAt(dataGridAddExpenses.CurrentCellAddress.Y);
                }
                
            }
            
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if(dataGridAddExpenses.Rows.Count > 0)
            {
                try
                {
                    ExpensesRepository expensesRepository = new ExpensesRepository();
                    for (int i = 0;i < dataGridAddExpenses.Rows.Count;i++)
                    {
                        Expense expense = new Expense
                        {
                            ExpenseReceipt = dataGridAddExpenses.Rows[i].Cells["ExpenseReceipt"].Value.ToString(),
                            Details = dataGridAddExpenses.Rows[i].Cells["Details"].Value.ToString(),
                            Amount = (float)Convert.ToDouble(dataGridAddExpenses.Rows[i].Cells["Amount"].Value),
                            TransactionDate = dateTimePicker1.Value,
                            UpdatedDate = DateTime.Now,
                            CreatedDate = DateTime.Now,
                            StoreID = 1
                        };
                        expensesRepository.Insert(expense);
                    }
                    dataGridAddExpenses.Rows.Clear();
                    dataGridExpenses.DataSource = expensesRepository.GetAllExpenses_PerDate(dateTimePicker1.Value);
                    dataGridExpenses.Columns["ExpenseID"].Visible = false;
                    dataGridExpenses.Columns["TransactionDate"].Visible = false;
                    dataGridExpenses.Columns["UpdatedDate"].Visible = false;
                    dataGridExpenses.Columns["CreatedDate"].Visible = false;
                    dataGridExpenses.Columns["StoreID"].Visible = false;
                }
                catch
                {
                    MessageBox.Show("Invalid Input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ExpensesRepository expensesRepository = new ExpensesRepository();
            dataGridExpenses.DataSource = expensesRepository.GetAllExpenses_PerDate(dateTimePicker1.Value);
            dataGridExpenses.Columns["ExpenseID"].Visible = false;
            dataGridExpenses.Columns["TransactionDate"].Visible = false;
            dataGridExpenses.Columns["UpdatedDate"].Visible = false;
            dataGridExpenses.Columns["CreatedDate"].Visible = false;
            dataGridExpenses.Columns["StoreID"].Visible = false;
        }
    }
}
