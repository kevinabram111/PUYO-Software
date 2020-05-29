using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUYO
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_PARAMETER(string username, string password, string logintype)
        {
            if (logintype.Equals("Cashier"))
            {
                if (username.Equals("cashier") && password.Equals("cashier"))
                {
                    POS a = new POS();
                    a.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login failed, please input the correct username and password", "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
                }
            }
            if (logintype.Equals("Warehouse"))
            {
                if (username.Equals("warehouse") && password.Equals("warehouse"))
                {
                    WAREHOUSE a = new WAREHOUSE();
                    a.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login failed, please input the correct username and password", "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN_PARAMETER(UsernameText.Text, PasswordText.Text, "Cashier");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOGIN_PARAMETER(UsernameText.Text, PasswordText.Text, "Warehouse");

        }

        private void LOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void PasswordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (UsernameText.Text.Equals("cashier"))
                {
                    LOGIN_PARAMETER(UsernameText.Text, PasswordText.Text, "Cashier");
                }
                else if (UsernameText.Text.Equals("warehouse"))
                {
                    LOGIN_PARAMETER(UsernameText.Text, PasswordText.Text, "Warehouse");
                }
            }

          
        }
    }
}
