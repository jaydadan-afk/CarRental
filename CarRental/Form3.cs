using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
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
            string username = Username_txt.Text.Trim();
            string password = Password_txt.Text.Trim();
            string confirm = ConfirmPass_txt.Text.Trim();


            if (username == "" || password == "" || confirm == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }


            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long");
                return;
            }


            if (password.ToLower().Contains(username.ToLower()))
            {
                MessageBox.Show("Password must not contain the username");
                return;
            }


            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            string filePath = "users.json";
            List<User> users = new List<User>();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }

            // Username uniqueness check
            foreach (User u in users)
            {
                if (u.Username == username)
                {
                    MessageBox.Show("Username already exists");
                    return;
                }
            }

            users.Add(new User
            {
                Username = username,
                Password = password
            });

            string newJson = JsonSerializer.Serialize(users, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(filePath, newJson);

            MessageBox.Show("Registration successful!");

            this.Hide();
            new Form2().Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Form2 registrationForm = new Form2();
            registrationForm.Show();
            this.Hide();
        }

        private void ConfirmPass_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}