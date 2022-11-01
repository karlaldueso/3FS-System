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
                    Items item = new Items
                    {
                        //Assign parameters based on input
                        ItemName = ItemNameText.Text,
                        BrandName = BrandNameText.Text,
                        CategoryID = float.Parse(CategoryText.Text),
                        Quantity = float.Parse(QuantityText.Text),
                        Unit = UnitText.Text,
                        SRP = float.Parse(SRPText.Text),
                        Capital = float.Parse(CapitalText.Text),
                        Storage = StorageText.Text,
                        UpdatedDate = DateTime.Now
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
                    dataGridView1.DataSource = itemRepository.GetItems_All();
                    dataGridView1.Columns["UpdatedDate"].Visible = false;

                    //Adding to ItemLogs
                    item.ItemID = itemRepository.GetItemID(new Items { ItemName = item.ItemName, BrandName = item.BrandName });
                    ItemLogs itemlogs = new ItemLogs
                    {
                        ItemID = item.ItemID,
                        TransactionType = "Add",
                        Previous = "",
                        Present = "",
                        TransactionDate = DateTime.Now,
                        UpdatedDate = DateTime.Now
                    };
                    itemsLogsRepository.Insert(itemlogs, 0);
                    dataGridView2.DataSource = itemsLogsRepository.GetItemLogs_All();
                    dataGridView2.Columns["UpdatedDate"].Visible = false;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.AutoResizeRows();
                    dataGridView2.AutoResizeColumns();
                    dataGridView2.AutoResizeRows();
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
            DataAccess db = new DataAccess();
            ItemLogsRepository itemsLogsRepository = new ItemLogsRepository();

            var val = dataGridView1.CurrentCell.Value;
            int[] c_r = { dataGridView1.CurrentCellAddress.X, dataGridView1.CurrentCellAddress.Y };
            if (val != null)
            {
                Console.WriteLine(Global.ITEMID);
                Global.ITEMID = int.Parse(dataGridView1.Rows[c_r[1]].Cells[0].Value.ToString());
                EditText.Text = dataGridView1.Rows[c_r[1]].Cells[c_r[0]].Value.ToString();

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
            }
            dataGridView2.DataSource = itemsLogsRepository.GetItemLogs_ByID(Global.ITEMID);
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            ItemRepository itemRepository = new ItemRepository();
            ItemLogsRepository itemsLogsRepository = new ItemLogsRepository();
            int[] c_r = { dataGridView1.CurrentCellAddress.X, dataGridView1.CurrentCellAddress.Y };
            Items item = new Items
            {
                //Assign parameters based on selected row on datagridview1
                ItemID = Global.ITEMID,
                ItemName = dataGridView1.Rows[c_r[1]].Cells[1].Value.ToString(),
                BrandName = dataGridView1.Rows[c_r[1]].Cells[2].Value.ToString(),
                CategoryID = float.Parse(dataGridView1.Rows[c_r[1]].Cells[3].Value.ToString()),
                Quantity = float.Parse(dataGridView1.Rows[c_r[1]].Cells[4].Value.ToString()),
                Unit = dataGridView1.Rows[c_r[1]].Cells[5].Value.ToString(),
                SRP = float.Parse(dataGridView1.Rows[c_r[1]].Cells[6].Value.ToString()),
                Capital = float.Parse(dataGridView1.Rows[c_r[1]].Cells[7].Value.ToString()),
                Storage = dataGridView1.Rows[c_r[1]].Cells[8].Value.ToString(),
                UpdatedDate = DateTime.Now
            };
            itemRepository.Update(item, c_r[0], EditText.Text); //update selected row
            item.ItemID = Global.ITEMID;
            ItemLogs itemlogs = new ItemLogs
            {
                ItemID = item.ItemID,
                TransactionType = "Update",
                Previous = dataGridView1.Rows[c_r[1]].Cells[c_r[0]].Value.ToString(),
                Present = EditText.Text,
                TransactionDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            itemsLogsRepository.Insert(itemlogs, c_r[0]);
            dataGridView1.DataSource = itemRepository.GetItems_All();
            dataGridView2.DataSource = itemsLogsRepository.GetItemLogs_ByID(itemlogs.ItemID);
            dataGridView1.Columns["UpdatedDate"].Visible = false;
            dataGridView2.Columns["UpdatedDate"].Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoResizeRows();
        }

        private void searchName_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            ItemRepository itemRepository = new ItemRepository();
            dataGridView1.DataSource = itemRepository.GetItems_ByName(searchName.Text, searchBrandName.Text);
            dataGridView1.Columns["UpdatedDate"].Visible = false;
            dataGridView1.AutoResizeColumns();
        }

        private void searchBrandName_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            ItemRepository itemRepository = new ItemRepository();
            dataGridView1.DataSource = itemRepository.GetItems_ByName(searchName.Text, searchBrandName.Text);
            dataGridView1.Columns["UpdatedDate"].Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            ItemRepository itemRepository = new ItemRepository();
            ItemLogsRepository itemsLogsRepository = new ItemLogsRepository();
            dataGridView1.DataSource = itemRepository.GetItems_All();
            dataGridView1.Columns["UpdatedDate"].Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            
        }
    }
}
