using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp.Db
{
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            txtResult.Text += btn.Text;
            txtResult.Text = Convert.ToDouble(txtResult.Text).ToString();
        }

        private double num1 = 0, num2 = 0, res = 0;
        private string ops;

        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtResult.Text);
            switch (ops)
            {
                case "+":
                    res = num1 + num2;
                    break;

                case "-":
                    res = num1 - num2;
                    break;

                case "x":
                    res = num1 * num2;
                    break;

                case "/":
                    res = num1 / num2;
                    break;

                default:
                    break;
            }
            txtResult.Text = res.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtResult.Text);
            var btn = (Button)sender;
            ops = btn.Text;
            txtResult.Clear();
        }
    }
}