using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.Db.Admin;

namespace WinFormApp.Db
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginForm.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calc calculator = new calc();
            calculator.MdiParent = this;
            calculator.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.MdiParent = this;
            inventory.Show();
        }
    }
}