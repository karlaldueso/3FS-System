﻿using System;
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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(ItemNameText.Text)) || (String.IsNullOrEmpty(BrandNameText.Text)) || (String.IsNullOrEmpty(CategoryText.Text)) || (String.IsNullOrEmpty(UnitText.Text)) || (String.IsNullOrEmpty(SRPText.Text)) || (String.IsNullOrEmpty(CapitalText.Text)))
            {
                MessageBox.Show("Enter complete details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Declaring and Init
                    ItemRepository itemRepository = new ItemRepository();
                    ItemLogsRepository itemsLogsRepository = new ItemLogsRepository();
                    Item item = new Item
                    {
                        //Assign parameters based on input
                        ItemName = ItemNameText.Text,
                        BrandName = BrandNameText.Text,
                        CategoryID = int.Parse(CategoryText.Text),
                        Unit = UnitText.Text,
                        SRP = float.Parse(SRPText.Text),
                        Capital = float.Parse(CapitalText.Text),
                        UpdatedDate = DateTime.Now,
                        CreatedDate = DateTime.Now,
                        StoreID = 1
                    };
                    itemRepository.Insert(item);
                    //Display and clear textbox
                    ItemNameText.Text = "";
                    BrandNameText.Text = "";
                    CategoryText.Text = "";
                    UnitText.Text = "";
                    SRPText.Text = "";
                    CapitalText.Text = "";
                    dataGridInventory.DataSource = itemRepository.GetItems_All();
                    dataGridInventory.Columns["ItemID"].Visible = false;
                    dataGridInventory.Columns["CategoryID"].Visible = false;
                    dataGridInventory.Columns["UpdatedDate"].Visible = false;
                    dataGridInventory.Columns["CreatedDate"].Visible = false;
                    dataGridInventory.Columns["StoreID"].Visible = false;

                    //Adding to ItemLogs
                    item.ItemID = itemRepository.GetItemID(new Item { ItemName = item.ItemName, BrandName = item.BrandName });
                    ItemLogs itemlogs = new ItemLogs
                    {
                        ItemID = item.ItemID,
                        TransactionType = "Add",
                        Previous = "",
                        Present = "",
                        TransactionDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                        CreatedDate = DateTime.Now,
                        StoreID = 1
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
            ItemLogsRepository itemsLogsRepository = new ItemLogsRepository();
            InventoryRepository inventoryRepository = new InventoryRepository();
            if (dataGridInventory.Rows.Count != 0)
            {
                int[] c_r = { dataGridInventory.CurrentCellAddress.X, dataGridInventory.CurrentCellAddress.Y };
                Console.WriteLine(Global.ITEMID);
                Global.ITEMID = int.Parse(dataGridInventory.Rows[c_r[1]].Cells["ItemID"].Value.ToString());
                string itemname = dataGridInventory.Rows[c_r[1]].Cells["ItemName"].Value.ToString();
                string brandname = dataGridInventory.Rows[c_r[1]].Cells["BrandName"].Value.ToString();
                EditText.Text = dataGridInventory.Rows[c_r[1]].Cells[c_r[0]].Value.ToString();
                dataGridQuantity.DataSource = inventoryRepository.GetByName(itemname, brandname);
                dataGridQuantity.Columns["InventoryID"].Visible = false;
                dataGridQuantity.Columns["ItemID"].Visible = false;
                dataGridQuantity.Columns["WarehouseID"].Visible = false;
                dataGridQuantity.Columns["UpdatedDate"].Visible = false;
                dataGridQuantity.Columns["CreatedDate"].Visible = false;
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
                        editlabel.Text = "Unit:";
                        break;
                    case 5:
                        editlabel.Text = "SRP:";
                        break;
                    case 6:
                        editlabel.Text = "Capital:";
                        break;
                }
            }
            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ItemRepository itemRepository = new ItemRepository();
            ItemLogsRepository itemsLogsRepository = new ItemLogsRepository();
            int[] c_r = { dataGridInventory.CurrentCellAddress.X, dataGridInventory.CurrentCellAddress.Y };
            if (dataGridInventory.Rows[c_r[1]].Cells[c_r[0]].Value.ToString() != EditText.Text)
            { 
                Item item = new Item
                {
                    //Assign parameters based on selected row on datagridview1
                    ItemID = Global.ITEMID,
                    ItemName = dataGridInventory.Rows[c_r[1]].Cells["ItemName"].Value.ToString(),
                    BrandName = dataGridInventory.Rows[c_r[1]].Cells["BrandName"].Value.ToString(),
                    CategoryID = int.Parse(dataGridInventory.Rows[c_r[1]].Cells["CategoryID"].Value.ToString()),
                    Unit = dataGridInventory.Rows[c_r[1]].Cells["Unit"].Value.ToString(),
                    SRP = float.Parse(dataGridInventory.Rows[c_r[1]].Cells["SRP"].Value.ToString()),
                    Capital = float.Parse(dataGridInventory.Rows[c_r[1]].Cells["Capital"].Value.ToString()),
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
                    StoreID = 1
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

        private void searchBrandName_TextChanged(object sender, EventArgs e)
        {
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
            ItemRepository itemRepository = new ItemRepository();
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

        private void warehouseSearchCombobox_Click(object sender, EventArgs e)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository();
            IEnumerable<Warehouse> warehouse = warehouseRepository.GetWarehouse_All();
            var warehouselist = warehouse.Select(x => x.Name).ToList();
            var warehouseID = warehouse.Select(x => x.WarehouseID).ToList();
            warehouseSearchComboBox.Items.Clear();
            warehouseSearchComboBox.Items.AddRange(warehouselist.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Warehouses")
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
                Warehouses warehouses = new Warehouses();
                warehouses.MdiParent = this.MdiParent;
                warehouses.Show();
            }
        }
    }
}
