using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.Db.Services;

namespace WinFormApp.Db
{
    public partial class frmLogin : Form
    {
        private readonly UserServices userServices = new UserServices();

        public frmLogin()
        {
            InitializeComponent();
            this.Load += FrmLogin_Load;
        }

        private void FrmLogin_Load(object? sender, EventArgs e)
        {
#if DEBUG
            txtUsername.Text = "Admin";
            txtPassword.Text = "Admin@123";
#endif
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearTextFields();
        }

        private void clearTextFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var res = userServices.Login(txtUsername.Text, txtPassword.Text);
            if (res.Item1)
            {
                //switch to new form
                frmMain main = new frmMain();
                main.Show();
                clearTextFields();
                this.Hide();
            }
            else
            {
                //show the message
                MessageBox.Show(res.Item2);
            }
        }
    }
}