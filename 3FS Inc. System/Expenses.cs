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
            if(dataGridAddExpenses.Rows.Count > 1)
            {
                if(dataGridAddExpenses.CurrentCell.RowIndex >= 0)
                {
                    dataGridAddExpenses.Rows.RemoveAt(dataGridAddExpenses.CurrentCellAddress.Y);
                }
                
            }
            
        }
    }
}
