namespace CarRental
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            label1 = new Label();
            clickRegister = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(549, 290);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(490, 372);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 3;
            label1.Text = "Don't have an account? ";
            // 
            // clickRegister
            // 
            clickRegister.AutoSize = true;
            clickRegister.BackColor = Color.Transparent;
            clickRegister.Cursor = Cursors.Hand;
            clickRegister.ForeColor = Color.ForestGreen;
            clickRegister.Location = new Point(619, 372);
            clickRegister.Name = "clickRegister";
            clickRegister.Size = new Size(49, 15);
            clickRegister.TabIndex = 4;
            clickRegister.Text = "Register";
            clickRegister.Click += clickRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(490, 175);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(490, 226);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(490, 193);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(191, 23);
            txtUser.TabIndex = 7;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(490, 244);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(191, 23);
            txtPass.TabIndex = 8;
            txtPass.UseSystemPasswordChar = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 442);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(clickRegister);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private Label label1;
        private Label clickRegister;
        private Label label2;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtPass;
    }
}