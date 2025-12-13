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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
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
            btnSignUp.BackColor = Color.SteelBlue;
            btnSignUp.FlatStyle = FlatStyle.Popup;
            btnSignUp.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(1202, 653);
            btnSignUp.Margin = new Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(189, 65);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // Username_txt
            // 
            Username_txt.Location = new Point(1154, 379);
            Username_txt.Margin = new Padding(3, 4, 3, 4);
            Username_txt.Name = "Username_txt";
            Username_txt.Size = new Size(305, 27);
            Username_txt.TabIndex = 2;
            Username_txt.TextChanged += txtUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F);
            label2.Location = new Point(1137, 452);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F);
            label3.Location = new Point(1137, 536);
            label3.Name = "label3";
            label3.Size = new Size(161, 22);
            label3.TabIndex = 7;
            label3.Text = "Confirm Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1137, 354);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(224, 224, 224);
            Back.Location = new Point(978, 849);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(85, 41);
            Back.TabIndex = 8;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += button1_Click;
            // 
            // Password_txt
            // 
            Password_txt.Location = new Point(1154, 478);
            Password_txt.Margin = new Padding(3, 4, 3, 4);
            Password_txt.Name = "Password_txt";
            Password_txt.Size = new Size(305, 27);
            Password_txt.TabIndex = 9;
            Password_txt.UseSystemPasswordChar = true;
            // 
            // ConfirmPass_txt
            // 
            ConfirmPass_txt.Location = new Point(1154, 562);
            ConfirmPass_txt.Margin = new Padding(3, 4, 3, 4);
            ConfirmPass_txt.Name = "ConfirmPass_txt";
            ConfirmPass_txt.Size = new Size(305, 27);
            ConfirmPass_txt.TabIndex = 10;
            ConfirmPass_txt.UseSystemPasswordChar = true;
            ConfirmPass_txt.TextChanged += ConfirmPass_txt_TextChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 903);
            Controls.Add(ConfirmPass_txt);
            Controls.Add(Password_txt);
            Controls.Add(Back);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Username_txt);
            Controls.Add(btnSignUp);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
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