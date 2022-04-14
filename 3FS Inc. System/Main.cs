using System;
using System.Collections.Generic;
using ConnectionToSQL.DB_Helper;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3FS_Inc._System
{
    public partial class Main : Form
    {
        public string user;
        public string Uservalue {get; set;}
        public Main()
        {
            InitializeComponent();
        }

        public Main(string value)
        {
            InitializeComponent();
            user = value;
            DBHelper.EstablishConnection("item_inventory");
            DBHelper.conn.Open();
            DBHelper.dt = new DataTable();
            DBHelper.sda = new MySqlDataAdapter();
            DBHelper.sda.Fill(DBHelper.dt);
            dataGridView1 = DBHelper.dt;
        }
        
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void maintab_Selected(object sender, TabControlEventArgs e)
        {
            //MessageBox.Show(user);
            if (user == "nonadmin")
            {
                if (this.maintab.SelectedTab == this.maintab.TabPages[3] || this.maintab.SelectedTab == this.maintab.TabPages[4])
                {
                    this.maintab.SelectedTab = this.maintab.TabPages[0];
                }
            }
        }
    }
}
