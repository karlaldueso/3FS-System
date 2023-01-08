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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(ItemNameText.Text)) || (String.IsNullOrEmpty(BrandNameText.Text)) || (String.IsNullOrEmpty(CategoryText.Text)) || (String.IsNullOrEmpty(QuantityText.Text)) || (String.IsNullOrEmpty(UnitText.Text)) || (String.IsNullOrEmpty(SRPText.Text)) || (String.IsNullOrEmpty(CapitalText.Text)) || (String.IsNullOrEmpty(StorageText.Text)))
            {
                MessageBox.Show("Enter complete details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Declaring and Init
                    DataAccess db = new DataAccess();
                    ItemRepository itemRepository = new ItemRepository();
                    ItemLogsRepository itemsLogsRepository = new ItemLogsRepository();
                    ItemInventory item = new ItemInventory
                    {
                        //Assign parameters based on input
                        ItemName = ItemNameText.Text,
                        BrandName = BrandNameText.Text,
                        CategoryID = int.Parse(CategoryText.Text),
                        Quantity = float.Parse(QuantityText.Text),
                        Unit = UnitText.Text,
                        SRP = float.Parse(SRPText.Text),
                        Capital = float.Parse(CapitalText.Text),
                        Storage = StorageText.Text,
                        UpdatedDate = DateTime.Now,
                        CreatedDate = DateTime.Now,
                        StoreID = 0
                    };
                    itemRepository.Insert(item);
                    //Display and clear textbox
                    ItemNameText.Text = "";
                    BrandNameText.Text = "";
                    CategoryText.Text = "";
                    QuantityText.Text = "";
                    UnitText.Text = "";
                    SRPText.Text = "";
                    CapitalText.Text = "";
                    StorageText.Text = "";
                    dataGridInventory.DataSource = itemRepository.GetItems_All();
                    dataGridInventory.Columns["ItemID"].Visible = false;
                    dataGridInventory.Columns["CategoryID"].Visible = false;
                    dataGridInventory.Columns["UpdatedDate"].Visible = false;
                    dataGridInventory.Columns["CreatedDate"].Visible = false;
                    dataGridInventory.Columns["StoreID"].Visible = false;

                    //Adding to ItemLogs
                    item.ItemID = itemRepository.GetItemID(new ItemInventory { ItemName = item.ItemName, BrandName = item.BrandName });
                    ItemLogs itemlogs = new ItemLogs
                    {
                        ItemID = item.ItemID,
                        TransactionType = "Add",
                        Previous = "",
                        Present = "",
                        TransactionDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                        CreatedDate = DateTime.Now,
                        StoreID = 0
                    };
                    itemsLogsRepository.Insert(itemlogs, 0);
                    dataGridLogs.DataSource = itemsLogsRepository.GetItemLogs_All();
                    dataGridInventory.AutoResizeColumns();
                    dataGridInventory.AutoResizeRows();
                    dataGridLogs.AutoResizeColumns();
                    dataGridLogs.AutoResizeRows();
                }
                catch
                {
                    MessageBox.Show("Invalid Input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Global.ITEMID = 0;
            _ = new DataAccess();
            ItemLogsRepository itemsLogsRepository = new ItemLogsRepository();
            if (dataGridInventory.Rows.Count != 0)
            {
                int[] c_r = { dataGridInventory.CurrentCellAddress.X, dataGridInventory.CurrentCellAddress.Y };
                Console.WriteLine(Global.ITEMID);
                Global.ITEMID = int.Parse(dataGridInventory.Rows[c_r[1]].Cells["ItemID"].Value.ToString());
                EditText.Text = dataGridInventory.Rows[c_r[1]].Cells[c_r[0]].Value.ToString();

                if (c_r[0] == 0 || c_r[0] == 9) //0, 8th columns of ItemInventoryTable
                {
                    EditText.Enabled = false;
                    UpdateButton.Enabled = false;
                }
                else
                {
                    EditText.Enabled = true;
                    UpdateButton.Enabled = true;
                }
                dataGridLogs.DataSource = itemsLogsRepository.GetItemLogs_ByID(Global.ITEMID);
                switch (c_r[0])
                {
                    case 0:
                        editlabel.Text = "Item ID:";
                        break;
                    case 1:
                        editlabel.Text = "Item Name:";
                        break;
                    case 2:
                        editlabel.Text = "Brand Name:";
                        break;
                    case 3:
                        editlabel.Text = "Category ID:";
                        break;
                    case 4:
                        editlabel.Text = "Quantity:";
                        break;
                    case 5:
                        editlabel.Text = "Unit:";
                        break;
                    case 6:
                        editlabel.Text = "SRP:";
                        break;
                    case 7:
                        editlabel.Text = "Capital:";
                        break;
                    case 8:
                        editlabel.Text = "Storage:";
                        break;
                }
            }
            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            ItemRepository itemRepository = new ItemRepository();
            ItemLogsRepository itemsLogsRepository = new ItemLogsRepository();
            int[] c_r = { dataGridInventory.CurrentCellAddress.X, dataGridInventory.CurrentCellAddress.Y };
            if (dataGridInventory.Rows[c_r[1]].Cells[c_r[0]].Value.ToString() != EditText.Text)
            { 
                ItemInventory item = new ItemInventory
                {
                    //Assign parameters based on selected row on datagridview1
                    ItemID = Global.ITEMID,
                    ItemName = dataGridInventory.Rows[c_r[1]].Cells["ItemName"].Value.ToString(),
                    BrandName = dataGridInventory.Rows[c_r[1]].Cells["BrandName"].Value.ToString(),
                    CategoryID = int.Parse(dataGridInventory.Rows[c_r[1]].Cells["CategoryID"].Value.ToString()),
                    Quantity = float.Parse(dataGridInventory.Rows[c_r[1]].Cells["Quantity"].Value.ToString()),
                    Unit = dataGridInventory.Rows[c_r[1]].Cells["Unit"].Value.ToString(),
                    SRP = float.Parse(dataGridInventory.Rows[c_r[1]].Cells["SRP"].Value.ToString()),
                    Capital = float.Parse(dataGridInventory.Rows[c_r[1]].Cells["Capital"].Value.ToString()),
                    Storage = dataGridInventory.Rows[c_r[1]].Cells["Storage"].Value.ToString(),
                    UpdatedDate = DateTime.Now
                };
                itemRepository.Update(item, c_r[0], EditText.Text); //update selected row
                item.ItemID = Global.ITEMID;
                ItemLogs itemlogs = new ItemLogs
                {
                    ItemID = item.ItemID,
                    TransactionType = "Update",
                    Previous = dataGridInventory.Rows[c_r[1]].Cells[c_r[0]].Value.ToString(),
                    Present = EditText.Text,
                    TransactionDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    StoreID = 0
                };
                itemsLogsRepository.Insert(itemlogs, c_r[0]);
                dataGridInventory.DataSource = itemRepository.GetItems_All();
                dataGridLogs.DataSource = itemsLogsRepository.GetItemLogs_ByID(itemlogs.ItemID);
                dataGridInventory.Columns["UpdatedDate"].Visible = false;
                dataGridInventory.Columns["ItemID"].Visible = false;
                dataGridInventory.Columns["CategoryID"].Visible = false;
                dataGridInventory.Columns["CreatedDate"].Visible = false;
                dataGridInventory.Columns["StoreID"].Visible = false;
                dataGridInventory.AutoResizeColumns();
                dataGridInventory.AutoResizeRows();
                dataGridLogs.AutoResizeColumns();
                dataGridLogs.AutoResizeRows();
            }
            else
            {
                MessageBox.Show("Input is the same!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchName_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            ItemRepository itemRepository = new ItemRepository();
            dataGridInventory.DataSource = itemRepository.GetItems_ByName(searchName.Text, searchBrandName.Text);
            dataGridInventory.Columns["UpdatedDate"].Visible = false;
            dataGridInventory.Columns["ItemID"].Visible = false;
            dataGridInventory.Columns["CategoryID"].Visible = false;
            dataGridInventory.Columns["CreatedDate"].Visible = false;
            dataGridInventory.Columns["StoreID"].Visible = false;
            dataGridInventory.AutoResizeColumns();
        }

        private void searchBrandName_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            ItemRepository itemRepository = new ItemRepository();
            dataGridInventory.DataSource = itemRepository.GetItems_ByName(searchName.Text, searchBrandName.Text);
            dataGridInventory.Columns["UpdatedDate"].Visible = false;
            dataGridInventory.Columns["ItemID"].Visible = false;
            dataGridInventory.Columns["CategoryID"].Visible = false;
            dataGridInventory.Columns["CreatedDate"].Visible = false;
            dataGridInventory.Columns["StoreID"].Visible = false;
            dataGridInventory.AutoResizeColumns();
            dataGridInventory.AutoResizeRows();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            ItemRepository itemRepository = new ItemRepository();
            ItemLogsRepository itemsLogsRepository = new ItemLogsRepository();
            dataGridInventory.DataSource = itemRepository.GetItems_All();
            dataGridInventory.Columns["UpdatedDate"].Visible = false;
            dataGridInventory.Columns["ItemID"].Visible = false;
            dataGridInventory.Columns["CategoryID"].Visible = false;
            dataGridInventory.Columns["CreatedDate"].Visible = false;
            dataGridInventory.Columns["StoreID"].Visible = false;
            dataGridInventory.AutoResizeColumns();
            dataGridInventory.AutoResizeRows();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.FormBackground;
        }

        private void inventorypanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
