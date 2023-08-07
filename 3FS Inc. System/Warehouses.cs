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
    public partial class Warehouses : Form
    {
        public Warehouses()
        {
            InitializeComponent();
        }

        private void storageComboBox_Click(object sender, EventArgs e)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository();
            IEnumerable<Warehouse> warehouse = warehouseRepository.GetWarehouse_All();
            var warehouselist = warehouse.Select(x => x.Name).ToList();
            var warehouseID = warehouse.Select(x => x.WarehouseID).ToList();
            storageComboBox.Items.Clear();  
            storageComboBox.Items.AddRange(warehouselist.ToArray());
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

        private void storageComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository();
            IEnumerable<Warehouse> warehouse = warehouseRepository.GetWarehouse_All();;
            var warehouseID = warehouse.Select(x => x.WarehouseID).ToList();
            Global.WAREHOUSEID = warehouseID[storageComboBox.SelectedIndex];
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            InventoryRepository inventoryRepository = new InventoryRepository();
            int[] c_r = { dataGridInventory.CurrentCellAddress.X, dataGridInventory.CurrentCellAddress.Y };
            Inventory inventory = new Inventory
            {
                //Assign parameters based on input
                ItemID = int.Parse(dataGridInventory.Rows[c_r[1]].Cells["ItemID"].Value.ToString()),
                Quantity = float.Parse(quantityText.Text),
                WarehouseID = Global.WAREHOUSEID,
                UpdatedDate = DateTime.Now,
                CreatedDate = DateTime.Now
            };
            inventoryRepository.Insert(inventory);
        }
    }
}
