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

        //todo improve the loading time
        private void frmInventory_Load(object sender, EventArgs e)
        {
            loadComboBox();
            loadData();
        }

        private void loadComboBox()
        {
            cmbUnits.DataSource = Enum.GetValues(typeof(Units));
        }

        private void loadData()
        {
            grdInventory.DataSource = inventoryServices.GetAll();
            grdInventory.Refresh();
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
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grdInventory.DataSource = inventoryServices.GetAllBySearchParameters(txtSearch.Text);
            grdInventory.Refresh();
        }

        private void clearTextFieldsAndComboBox()
        {
            lblId.Text = "";
            txtName.Clear();
            txtCode.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            cmbUnits.SelectedIndex = -1;
        }

        private void grdInventory_SelectionChanged(object sender, EventArgs e)
        {
            //check if the rows are selected or not
            var rows = grdInventory.SelectedRows;
            if (rows.Count > 0)
            {
                //load the data of first occurence
                var row = rows[0];
                lblId.Text = row.Cells["Id"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtCode.Text = row.Cells["Code"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                cmbUnits.SelectedItem = (Units)row.Cells["Units"].Value;

                ToggleControls();
            }
            else
            {
                clearTextFieldsAndComboBox();
                ToggleControls(false);
            }
        }

        private void ToggleControls(bool editMode = true)
        {
            btnCreate.Visible = !editMode;
            btnReset.Visible = !editMode;
            btnEdit.Visible = editMode;
            btnDelete.Visible = editMode;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearTextFieldsAndComboBox();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var inventory = new Inventory()
            {
                Id = Convert.ToInt32(lblId.Text),
                Name = txtName.Text,
                Code = txtCode.Text,
                Price = Convert.ToDouble(txtPrice.Text),
                Quantity = Convert.ToDouble(txtQuantity.Text),
                Units = (Units)cmbUnits.SelectedItem
            };
            var res = inventoryServices.Edit(inventory);
            if (res.Item1)
            {
                clearTextFieldsAndComboBox();
                ToggleControls(false);
                loadData();
            }
            else
            {
                MessageBox.Show(res.Item2);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(lblId.Text);
            var res = inventoryServices.Delete(id);
            if (res.Item1)
            {
                clearTextFieldsAndComboBox();
                ToggleControls(false);
                loadData();
            }
            else
            {
                MessageBox.Show(res.Item2);
            }
        }
    }
}