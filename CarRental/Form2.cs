using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Form2 : Form
    {
        public static string RegisteredUsername = "";
        public static string RegisteredPassword = "";
        public Form2()
        {

            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (user == "admin" && pass == "123"
                || user == "user" && pass == "123")
            {
                Form1 dashboard = new Form1();
                dashboard.Show();
                this.Hide();
                return;
            }

           
            if (user == RegisteredUsername && pass == RegisteredPassword)
            {
                Form1 dashboard = new Form1();
                dashboard.Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Invalid username or password!");
        }

        private void clickRegister_Click(object sender, EventArgs e)
        {
                
            Form3 registrationForm = new Form3();
            registrationForm.Show();
            this.Hide();
        }
    }
}