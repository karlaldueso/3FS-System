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
        private void storageComboBox_Enter(object sender, EventArgs e)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository();
            IEnumerable<Warehouse> warehouse = warehouseRepository.GetWarehouse_All();
            var warehouselist = warehouse.Select(x => x.Name).ToList();
            var warehouseID = warehouse.Select(x => x.WarehouseID).ToList();
            storageComboBox.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            storageComboBox.AutoCompleteCustomSource.AddRange(warehouselist.ToArray());
        }
        private void storageComboBox_Click(object sender, EventArgs e)
        {
            
        }
        private void storageComboBox_DropDown(object sender, EventArgs e)
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
            if (dataGridInventory.Rows.Count != 0)
            {
                try
                {
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
                    string unit = dataGridInventory.Rows[c_r[1]].Cells["Unit"].Value.ToString();
                    string item = dataGridInventory.Rows[c_r[1]].Cells["ItemName"].Value.ToString();
                    string brand = dataGridInventory.Rows[c_r[1]].Cells["BrandName"].Value.ToString();
                    string warehouse = storageComboBox.Text;
                    if (inventoryRepository.IfExists(inventory))
                    {
                        inventoryRepository.UpdateQty(inventory, 2);
                    }
                    else
                    {
                        inventoryRepository.Insert(inventory);
                    }
                    string msg = String.Format("Added {0} {1} of {2}({3}) to {4}!", inventory.Quantity, unit, item, brand, warehouse);
                    MessageBox.Show(msg, "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchName.Clear();
                    searchBrandName.Clear();
                    quantityText.Clear();

                }
                catch (Exception ex)
                {
                    string str = string.Format("Error: {0}!", ex.Message);
                    MessageBox.Show(str, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please choose an item!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchNameMove_TextChanged(object sender, EventArgs e)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository();
            IEnumerable<Warehouse> warehouse = warehouseRepository.GetWarehouse_All(); ;
            var warehouseID = warehouse.Select(x => x.WarehouseID).ToList();
            InventoryRepository inventoryrepository = new InventoryRepository();
            if (storagecombobox1.SelectedItem != null)
            {
                dataGridWarehouse1.DataSource = inventoryrepository.GetByName_ByWareHouse(searchNameMove.Text, searchBrandNameMove.Text, warehouseID[storagecombobox1.SelectedIndex]);
                dataGridWarehouse1.Columns["InventoryID"].Visible = false;
                dataGridWarehouse1.Columns["ItemID"].Visible = false;
                dataGridWarehouse1.Columns["Name"].Visible = false;
                dataGridWarehouse1.Columns["WarehouseID"].Visible = false;
                dataGridWarehouse1.Columns["UpdatedDate"].Visible = false;
                dataGridWarehouse1.Columns["CreatedDate"].Visible = false;
                dataGridWarehouse1.Rows[0].Selected = true;
                dataGridWarehouse1.AutoResizeColumns();
                dataGridWarehouse1.AutoResizeRows();
            }
            if (storagecombobox2.SelectedItem != null)
            {
                dataGridWarehouse2.DataSource = inventoryrepository.GetByName_ByWareHouse(searchNameMove.Text, searchBrandNameMove.Text, warehouseID[storagecombobox2.SelectedIndex]);
                dataGridWarehouse2.Columns["InventoryID"].Visible = false;
                dataGridWarehouse2.Columns["ItemID"].Visible = false;
                dataGridWarehouse2.Columns["Name"].Visible = false;
                dataGridWarehouse2.Columns["WarehouseID"].Visible = false;
                dataGridWarehouse2.Columns["UpdatedDate"].Visible = false;
                dataGridWarehouse2.Columns["CreatedDate"].Visible = false;
                dataGridWarehouse2.Rows[0].Selected = true;
                dataGridWarehouse2.AutoResizeColumns();
                dataGridWarehouse2.AutoResizeRows();
            }
        }

        private void searchBrandNameMove_TextChanged(object sender, EventArgs e)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository();
            IEnumerable<Warehouse> warehouse = warehouseRepository.GetWarehouse_All(); ;
            var warehouseID = warehouse.Select(x => x.WarehouseID).ToList();
            InventoryRepository inventoryrepository = new InventoryRepository();
            if (storagecombobox1.SelectedItem != null)
            {
                dataGridWarehouse1.DataSource = inventoryrepository.GetByName_ByWareHouse(searchNameMove.Text, searchBrandNameMove.Text, warehouseID[storagecombobox1.SelectedIndex]);
                dataGridWarehouse1.Columns["InventoryID"].Visible = false;
                dataGridWarehouse1.Columns["ItemID"].Visible = false;
                dataGridWarehouse1.Columns["Name"].Visible = false;
                dataGridWarehouse1.Columns["WarehouseID"].Visible = false;
                dataGridWarehouse1.Columns["UpdatedDate"].Visible = false;
                dataGridWarehouse1.Columns["CreatedDate"].Visible = false;
                dataGridWarehouse1.AutoResizeColumns();
                dataGridWarehouse1.AutoResizeRows();
            }
            if (storagecombobox2.SelectedItem != null)
            {
                dataGridWarehouse2.DataSource = inventoryrepository.GetByName_ByWareHouse(searchNameMove.Text, searchBrandNameMove.Text, warehouseID[storagecombobox2.SelectedIndex]);
                dataGridWarehouse2.Columns["InventoryID"].Visible = false;
                dataGridWarehouse2.Columns["ItemID"].Visible = false;
                dataGridWarehouse2.Columns["Name"].Visible = false;
                dataGridWarehouse2.Columns["WarehouseID"].Visible = false;
                dataGridWarehouse2.Columns["UpdatedDate"].Visible = false;
                dataGridWarehouse2.Columns["CreatedDate"].Visible = false;
                dataGridWarehouse2.AutoResizeColumns();
                dataGridWarehouse2.AutoResizeRows();
            }
        }

        private void storagecombobox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository();
            IEnumerable<Warehouse> warehouse = warehouseRepository.GetWarehouse_All(); ;
            var warehouseID = warehouse.Select(x => x.WarehouseID).ToList();
            InventoryRepository inventoryrepository = new InventoryRepository();
            dataGridWarehouse1.DataSource = inventoryrepository.GetByName_ByWareHouse(searchNameMove.Text, searchBrandNameMove.Text, warehouseID[storagecombobox1.SelectedIndex]);
            dataGridWarehouse1.Columns["InventoryID"].Visible = false;
            dataGridWarehouse1.Columns["ItemID"].Visible = false;
            dataGridWarehouse1.Columns["Name"].Visible = false;
            dataGridWarehouse1.Columns["WarehouseID"].Visible = false;
            dataGridWarehouse1.Columns["UpdatedDate"].Visible = false;
            dataGridWarehouse1.Columns["CreatedDate"].Visible = false;
            dataGridWarehouse1.AutoResizeColumns();
            dataGridWarehouse1.AutoResizeRows();
        }

        private void storagecombobox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository();
            IEnumerable<Warehouse> warehouse = warehouseRepository.GetWarehouse_All(); ;
            var warehouseID = warehouse.Select(x => x.WarehouseID).ToList();
            InventoryRepository inventoryrepository = new InventoryRepository();
            dataGridWarehouse2.DataSource = inventoryrepository.GetByName_ByWareHouse(searchNameMove.Text, searchBrandNameMove.Text, warehouseID[storagecombobox2.SelectedIndex]);
            dataGridWarehouse2.Columns["InventoryID"].Visible = false;
            dataGridWarehouse2.Columns["ItemID"].Visible = false;
            dataGridWarehouse2.Columns["Name"].Visible = false;
            dataGridWarehouse2.Columns["WarehouseID"].Visible = false;
            dataGridWarehouse2.Columns["UpdatedDate"].Visible = false;
            dataGridWarehouse2.Columns["CreatedDate"].Visible = false;
            dataGridWarehouse2.AutoResizeColumns();
            dataGridWarehouse2.AutoResizeRows();
        }

        private void storagecombobox1_Click(object sender, EventArgs e)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository();
            IEnumerable<Warehouse> warehouse = warehouseRepository.GetWarehouse_All();
            var warehouselist = warehouse.Select(x => x.Name).ToList();
            var warehouseID = warehouse.Select(x => x.WarehouseID).ToList();
            storagecombobox1.Items.Clear();
            storagecombobox1.Items.AddRange(warehouselist.ToArray());
        }

        private void storagecombobox2_Click(object sender, EventArgs e)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository();
            IEnumerable<Warehouse> warehouse = warehouseRepository.GetWarehouse_All();
            var warehouselist = warehouse.Select(x => x.Name).ToList();
            var warehouseID = warehouse.Select(x => x.WarehouseID).ToList();
            storagecombobox2.Items.Clear();
            storagecombobox2.Items.AddRange(warehouselist.ToArray());
        }

        private void movebutton1_Click(object sender, EventArgs e)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository();
            IEnumerable<Warehouse> warehouse = warehouseRepository.GetWarehouse_All();
            var warehouseID = warehouse.Select(x => x.WarehouseID).ToList();
            InventoryRepository inventoryRepository = new InventoryRepository();
            if (dataGridWarehouse1.Rows.Count != 0 && storagecombobox1.SelectedItem != null && storagecombobox2.SelectedItem != null)
            {
                try
                {
                    int[] c_r = { dataGridWarehouse1.CurrentCellAddress.X, dataGridWarehouse1.CurrentCellAddress.Y };
                    Inventory inventory1 = new Inventory
                    {
                        //Assign parameters based on input
                        ItemID = int.Parse(dataGridWarehouse1.Rows[c_r[1]].Cells["ItemID"].Value.ToString()),
                        Quantity = float.Parse(movequantityText.Text),
                        WarehouseID = warehouseID[storagecombobox1.SelectedIndex],
                        UpdatedDate = DateTime.Now,
                        CreatedDate = DateTime.Now
                    };
                    Inventory inventory2 = new Inventory
                    {
                        //Assign parameters based on input
                        ItemID = inventory1.ItemID,
                        Quantity = inventory1.Quantity,
                        WarehouseID = warehouseID[storagecombobox2.SelectedIndex],
                        UpdatedDate = DateTime.Now,
                        CreatedDate = DateTime.Now
                    };
                    float qty = float.Parse(dataGridWarehouse1.Rows[c_r[1]].Cells["Quantity"].Value.ToString());
                    float qty_disp = float.Parse(movequantityText.Text);
                    string unit = dataGridWarehouse1.Rows[c_r[1]].Cells["Unit"].Value.ToString();
                    string itemname = dataGridWarehouse1.Rows[c_r[1]].Cells["ItemName"].Value.ToString();
                    string itembrandname = dataGridWarehouse1.Rows[c_r[1]].Cells["BrandName"].Value.ToString();
                    string warehouse1 = storagecombobox1.Text;
                    string warehouse2 = storagecombobox2.Text;
                    if (qty < float.Parse(movequantityText.Text))
                    {
                        inventory1.Quantity = qty;
                        inventory2.Quantity = qty;
                        qty_disp = qty;
                    }

                    inventoryRepository.UpdateQty(inventory1, 1);
                    if (inventoryRepository.IfExists(inventory2))
                    {
                        inventoryRepository.UpdateQty(inventory2, 2);
                    }
                    else
                    {
                        inventoryRepository.Insert(inventory2);
                    }

                    dataGridWarehouse1.DataSource = inventoryRepository.GetByName_ByWareHouse(searchNameMove.Text, searchBrandNameMove.Text, warehouseID[storagecombobox1.SelectedIndex]);
                    dataGridWarehouse1.Columns["InventoryID"].Visible = false;
                    dataGridWarehouse1.Columns["ItemID"].Visible = false;
                    dataGridWarehouse1.Columns["Name"].Visible = false;
                    dataGridWarehouse1.Columns["WarehouseID"].Visible = false;
                    dataGridWarehouse1.Columns["UpdatedDate"].Visible = false;
                    dataGridWarehouse1.Columns["CreatedDate"].Visible = false;
                    dataGridWarehouse1.AutoResizeColumns();
                    dataGridWarehouse1.AutoResizeRows();
                    dataGridWarehouse2.DataSource = inventoryRepository.GetByName_ByWareHouse(searchNameMove.Text, searchBrandNameMove.Text, warehouseID[storagecombobox2.SelectedIndex]);
                    dataGridWarehouse2.Columns["InventoryID"].Visible = false;
                    dataGridWarehouse2.Columns["ItemID"].Visible = false;
                    dataGridWarehouse2.Columns["Name"].Visible = false;
                    dataGridWarehouse2.Columns["WarehouseID"].Visible = false;
                    dataGridWarehouse2.Columns["UpdatedDate"].Visible = false;
                    dataGridWarehouse2.Columns["CreatedDate"].Visible = false;
                    dataGridWarehouse2.AutoResizeColumns();
                    dataGridWarehouse2.AutoResizeRows();
                    string str = String.Format("Moved {0} {1} of {2}({3}) from {4} to {5}!", qty_disp, unit, itemname, itembrandname, warehouse1, warehouse2);
                    MessageBox.Show(str, "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string str = string.Format("Error: {0}!", ex.Message);
                    MessageBox.Show(str, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please choose an item!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void movebutton2_Click(object sender, EventArgs e)
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository();
            IEnumerable<Warehouse> warehouse = warehouseRepository.GetWarehouse_All();
            var warehouseID = warehouse.Select(x => x.WarehouseID).ToList();
            InventoryRepository inventoryRepository = new InventoryRepository();
            if (dataGridWarehouse2.Rows.Count != 0 && storagecombobox1.SelectedItem != null && storagecombobox2.SelectedItem != null)
            {
                try
                {
                    int[] c_r = { dataGridWarehouse2.CurrentCellAddress.X, dataGridWarehouse2.CurrentCellAddress.Y };
                    Inventory inventory2 = new Inventory
                    {
                        //Assign parameters based on input
                        ItemID = int.Parse(dataGridWarehouse2.Rows[c_r[1]].Cells["ItemID"].Value.ToString()),
                        Quantity = float.Parse(movequantityText.Text),
                        WarehouseID = warehouseID[storagecombobox2.SelectedIndex],
                        UpdatedDate = DateTime.Now,
                        CreatedDate = DateTime.Now
                    };
                    Inventory inventory1 = new Inventory
                    {
                        //Assign parameters based on input
                        ItemID = inventory2.ItemID,
                        Quantity = inventory2.Quantity,
                        WarehouseID = warehouseID[storagecombobox1.SelectedIndex],
                        UpdatedDate = DateTime.Now,
                        CreatedDate = DateTime.Now
                    };
                    float qty = float.Parse(dataGridWarehouse2.Rows[c_r[1]].Cells["Quantity"].Value.ToString());
                    float qty_disp = float.Parse(movequantityText.Text);
                    string unit = dataGridWarehouse2.Rows[c_r[1]].Cells["Unit"].Value.ToString();
                    string itemname = dataGridWarehouse2.Rows[c_r[1]].Cells["ItemName"].Value.ToString();
                    string itembrandname = dataGridWarehouse2.Rows[c_r[1]].Cells["BrandName"].Value.ToString();
                    string warehouse1 = storagecombobox1.Text;
                    string warehouse2 = storagecombobox2.Text;
                    if (qty < float.Parse(movequantityText.Text))
                    {
                        inventory1.Quantity = qty;
                        inventory2.Quantity = qty;
                        qty_disp = qty;
                        
                    }
                    inventoryRepository.UpdateQty(inventory2, 1);
                    if (inventoryRepository.IfExists(inventory1))
                    {
                        inventoryRepository.UpdateQty(inventory1, 2);
                    }
                    else
                    {
                        inventoryRepository.Insert(inventory1);
                    }
                    dataGridWarehouse1.DataSource = inventoryRepository.GetByName_ByWareHouse(searchNameMove.Text, searchBrandNameMove.Text, warehouseID[storagecombobox1.SelectedIndex]);
                    dataGridWarehouse1.Columns["InventoryID"].Visible = false;
                    dataGridWarehouse1.Columns["ItemID"].Visible = false;
                    dataGridWarehouse1.Columns["Name"].Visible = false;
                    dataGridWarehouse1.Columns["WarehouseID"].Visible = false;
                    dataGridWarehouse1.Columns["UpdatedDate"].Visible = false;
                    dataGridWarehouse1.Columns["CreatedDate"].Visible = false;
                    dataGridWarehouse1.AutoResizeColumns();
                    dataGridWarehouse1.AutoResizeRows();
                    dataGridWarehouse2.DataSource = inventoryRepository.GetByName_ByWareHouse(searchNameMove.Text, searchBrandNameMove.Text, warehouseID[storagecombobox2.SelectedIndex]);
                    dataGridWarehouse2.Columns["InventoryID"].Visible = false;
                    dataGridWarehouse2.Columns["ItemID"].Visible = false;
                    dataGridWarehouse2.Columns["Name"].Visible = false;
                    dataGridWarehouse2.Columns["WarehouseID"].Visible = false;
                    dataGridWarehouse2.Columns["UpdatedDate"].Visible = false;
                    dataGridWarehouse2.Columns["CreatedDate"].Visible = false;
                    dataGridWarehouse2.AutoResizeColumns();
                    dataGridWarehouse2.AutoResizeRows();
                    string str = String.Format("Moved {0} {1} of {2}({3}) from {4} to {5}!", qty_disp, unit, itemname, itembrandname, warehouse2, warehouse1);
                    MessageBox.Show(str, "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string str = string.Format("Error: {0}!", ex.Message);
                    MessageBox.Show(str, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please choose an item!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
