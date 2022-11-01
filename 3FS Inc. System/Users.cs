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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();

            DataAccess db = new DataAccess();
            UserRepository userRepository = new UserRepository();
            
            usersDataGrid.DataSource = userRepository.GetUsers_All();
            usersDataGrid.Columns["UpdatedDate"].Visible = false;
            usersDataGrid.AutoResizeColumns();
            usersDataGrid.AutoResizeRows();

        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(firstNametext.Text)) || (String.IsNullOrEmpty(lastNametext.Text)) || (String.IsNullOrEmpty(contacttext.Text)) || (String.IsNullOrEmpty(usernametext.Text)) || (String.IsNullOrEmpty(PWtextbox1.Text)) || (String.IsNullOrEmpty(PWtextbox2.Text)))
            {
                MessageBox.Show("Enter complete details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }
    }
}
