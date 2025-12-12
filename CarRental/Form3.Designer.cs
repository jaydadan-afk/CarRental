namespace CarRental
{
    partial class Form3
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
            btnSignUp = new Button();
            txtUsername = new TextBox();
            txtPass = new TextBox();
            label2 = new Label();
            txtPassConfirm = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtMail = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.FlatStyle = FlatStyle.Popup;
            btnSignUp.Location = new Point(589, 389);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(123, 31);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(556, 169);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(186, 23);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(556, 223);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(186, 27);
            txtPass.TabIndex = 3;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(556, 205);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // txtPassConfirm
            // 
            txtPassConfirm.Location = new Point(556, 281);
            txtPassConfirm.Multiline = true;
            txtPassConfirm.Name = "txtPassConfirm";
            txtPassConfirm.Size = new Size(186, 27);
            txtPassConfirm.TabIndex = 6;
            txtPassConfirm.TextChanged += txtPassConfirm_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(556, 263);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 7;
            label3.Text = "Confirm Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(556, 151);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // txtMail
            // 
            txtMail.BorderStyle = BorderStyle.FixedSingle;
            txtMail.Location = new Point(556, 337);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(186, 27);
            txtMail.TabIndex = 8;
            txtMail.TextChanged += txtMail_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(556, 319);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 491);
            Controls.Add(label4);
            Controls.Add(txtMail);
            Controls.Add(label3);
            Controls.Add(txtPassConfirm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Controls.Add(btnSignUp);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private TextBox txtUsername;
        private TextBox txtPass;
        private Label label2;
        private TextBox txtPassConfirm;
        private Label label3;
        private Label label1;
        private TextBox txtMail;
        private Label label4;
    }
}