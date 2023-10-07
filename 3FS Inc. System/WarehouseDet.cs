using _3FS_System.Helpers;
using _3FS_System.Models;
using _3FS_System.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3FS_System
{
    public partial class WarehouseDet : Form
    {
        public WarehouseDet()
        {
            InitializeComponent();
            WarehouseRepository warehouseRepository = new WarehouseRepository();

            dataGridWarehouse.DataSource = warehouseRepository.GetWarehouse_All();
            dataGridWarehouse.Columns["WarehouseID"].Visible = false;
            dataGridWarehouse.Columns["CreatedDate"].Visible = false;
            dataGridWarehouse.AutoResizeColumns();
            dataGridWarehouse.AutoResizeRows();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if ((String.IsNullOrEmpty(NameText.Text)) || (String.IsNullOrEmpty(DescriptionText.Text)) || (String.IsNullOrEmpty(AddressText.Text)) || (String.IsNullOrEmpty(CityText.Text)))
            {
                MessageBox.Show("Enter complete details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                WarehouseRepository warehouseRepository = new WarehouseRepository();
                Warehouse warehouse = new Warehouse
                {
                    Name = NameText.Text,
                    Description = DescriptionText.Text,
                    Address = AddressText.Text,
                    City = CityText.Text,
                    UpdatedDate= DateTime.Now,
                    CreatedDate= DateTime.Now
                };
                warehouseRepository.Insert(warehouse);

                MessageBox.Show("Added new entry!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NameText.Clear();
                DescriptionText.Clear();
                AddressText.Clear();
                CityText.Clear();

                dataGridWarehouse.DataSource = warehouseRepository.GetWarehouse_All();
                dataGridWarehouse.Columns["WarehouseID"].Visible = false;
                dataGridWarehouse.Columns["CreatedDate"].Visible = false;
                dataGridWarehouse.AutoResizeColumns();
                dataGridWarehouse.AutoResizeRows();
             
            }
        }
    }
}
