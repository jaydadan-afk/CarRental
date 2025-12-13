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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(281, 530);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 58);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 785);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 3;
            label1.Text = "Don't have an account? ";
            // 
            // clickRegister
            // 
            clickRegister.AutoSize = true;
            clickRegister.BackColor = Color.Transparent;
            clickRegister.Cursor = Cursors.Hand;
            clickRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickRegister.ForeColor = Color.ForestGreen;
            clickRegister.Location = new Point(281, 782);
            clickRegister.Name = "clickRegister";
            clickRegister.Size = new Size(82, 28);
            clickRegister.TabIndex = 4;
            clickRegister.Text = "Register";
            clickRegister.Click += clickRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(100, 347);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(100, 436);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 6;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(100, 371);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(290, 27);
            txtUser.TabIndex = 7;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(100, 460);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(290, 27);
            txtPass.TabIndex = 8;
            txtPass.UseSystemPasswordChar = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 903);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(clickRegister);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Margin = new Padding(3, 4, 3, 4);
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