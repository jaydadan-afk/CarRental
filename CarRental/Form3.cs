using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
        string.IsNullOrWhiteSpace(txtPass.Text) ||
        string.IsNullOrWhiteSpace(txtPassConfirm.Text) ||
        string.IsNullOrWhiteSpace(txtMail.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (txtPass.Text != txtPassConfirm.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

    
            string email = txtMail.Text.Trim();
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address!", "Invalid Email");
                return;
            }

        
            Form2.RegisteredUsername = txtUsername.Text.Trim();
            Form2.RegisteredPassword = txtPass.Text.Trim();

            MessageBox.Show("Registered successfully!");

            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }
    }
}