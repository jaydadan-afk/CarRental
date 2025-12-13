using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            if (username == "admin" && password == "12345")
            {
                MessageBox.Show("Welcome Admin!");
                this.Hide();
                new Form1().Show();
                return;
            }

            string filePath = "users.json";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No registered users found");
                return;
            }

            string json = File.ReadAllText(filePath);
            List<User> users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();


            foreach (User u in users)
            {
                if (u.Username == username && u.Password == password)
                {
                    MessageBox.Show("Login successful!");
                    this.Hide();
                    new Form1().Show();
                    return;
                }
            }

            MessageBox.Show("Invalid username or password");
        }

        private void clickRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
