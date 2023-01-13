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
            usersDataGrid.Columns["UserID"].Visible = false;
            usersDataGrid.Columns["PW"].Visible = false;
            usersDataGrid.Columns["CreatedDate"].Visible = false;
            usersDataGrid.Columns["StoreID"].Visible = false;
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
                if (PWtextbox1.Text == PWtextbox2.Text)
                {
                    DataAccess db = new DataAccess();
                    UserRepository userRepository = new UserRepository();
                    User user = new User
                    {
                        FirstName = firstNametext.Text,
                        LastName = lastNametext.Text,
                        UserName = usernametext.Text,
                        PW = PWtextbox1.Text,
                        ContactNum = contacttext.Text,
                        UserType = userTypecombobox.SelectedIndex,
                        UpdatedDate = DateTime.Now,
                        CreatedDate = DateTime.Now,
                        StoreID = 1
                    };

                    userRepository.Insert(user);

                    usersDataGrid.DataSource = userRepository.GetUsers_All();
                    usersDataGrid.Columns["UpdatedDate"].Visible = false;
                    usersDataGrid.Columns["UserID"].Visible = false;
                    usersDataGrid.Columns["PW"].Visible = false;
                    usersDataGrid.Columns["CreatedDate"].Visible = false;
                    usersDataGrid.Columns["StoreID"].Visible = false;
                    usersDataGrid.AutoResizeColumns();
                    usersDataGrid.AutoResizeRows();

                    firstNametext.Clear();
                    lastNametext.Clear();
                    contacttext.Clear();
                    usernametext.Clear();
                    PWtextbox1.Clear();
                    PWtextbox2.Clear();
                    userTypecombobox.Text = "";
                }
                else
                {
                    MessageBox.Show("Passwords do not match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.FormBackground;
            this.Height = 480;
            this.Width = 852;
        }

        private void userslabel_Click(object sender, EventArgs e)
        {

        }
    }
}
