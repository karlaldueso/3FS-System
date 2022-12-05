using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Web;
using System.Windows;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using _3FS_System.Helpers;

namespace _3FS_System
{
    public partial class DatabaseSetting : Form
    {
        public DatabaseSetting()
        {
            InitializeComponent();
        }

        private void DatabaseSetting_Load(object sender, EventArgs e)
        {
            cboServer.Items.Add(".");
            cboServer.Items.Add("(local)");
            cboServer.Items.Add(@".\SQLEXPRESS");
            cboServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cboServer.SelectedIndex = 3;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Server={0};Database={1};User ID={2};Password={3}", cboServer.Text, databasetext.Text, usernametext.Text, passwordtext.Text);
            try
            {
                if (Helper.isConnection(connectionString))
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("3FSDatabase", connectionString);
                    MessageBox.Show("Successfully Saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
