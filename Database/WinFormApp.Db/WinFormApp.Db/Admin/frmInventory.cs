using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.Db.Models;
using WinFormApp.Db.Services;

namespace WinFormApp.Db.Admin
{
    public partial class frmInventory : Form
    {
        private readonly InventoryServices inventoryServices = new InventoryServices();

        public frmInventory()
        {
            InitializeComponent();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            cmbUnits.DataSource = Enum.GetValues(typeof(Units));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var inventory = new Inventory()
            {
                Name = txtName.Text,
                Code = txtCode.Text,
                Price = Convert.ToDouble(txtPrice.Text),
                Quantity = Convert.ToDouble(txtQuantity.Text),
                Units = (Units)cmbUnits.SelectedItem
            };
            var res = inventoryServices.CreateInventory(inventory);
            MessageBox.Show(res.Item2);
        }
    }
}