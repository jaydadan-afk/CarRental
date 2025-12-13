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
            Username_txt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            Back = new Button();
            Password_txt = new TextBox();
            ConfirmPass_txt = new TextBox();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.FlatStyle = FlatStyle.Popup;
            btnSignUp.Location = new Point(556, 324);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(89, 31);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // Username_txt
            // 
            Username_txt.Location = new Point(556, 169);
            Username_txt.Name = "Username_txt";
            Username_txt.Size = new Size(198, 23);
            Username_txt.TabIndex = 2;
            Username_txt.TextChanged += txtUsername_TextChanged;
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
            // Back
            // 
            Back.Location = new Point(671, 324);
            Back.Name = "Back";
            Back.Size = new Size(74, 31);
            Back.TabIndex = 8;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += button1_Click;
            // 
            // Password_txt
            // 
            Password_txt.Location = new Point(558, 230);
            Password_txt.Name = "Password_txt";
            Password_txt.Size = new Size(196, 23);
            Password_txt.TabIndex = 9;
            Password_txt.UseSystemPasswordChar = true;
            // 
            // ConfirmPass_txt
            // 
            ConfirmPass_txt.Location = new Point(556, 281);
            ConfirmPass_txt.Name = "ConfirmPass_txt";
            ConfirmPass_txt.Size = new Size(198, 23);
            ConfirmPass_txt.TabIndex = 10;
            ConfirmPass_txt.UseSystemPasswordChar = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 491);
            Controls.Add(ConfirmPass_txt);
            Controls.Add(Password_txt);
            Controls.Add(Back);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Username_txt);
            Controls.Add(btnSignUp);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private TextBox Username_txt;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button Back;
        private TextBox Password_txt;
        private TextBox ConfirmPass_txt;
    }
}