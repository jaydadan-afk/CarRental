namespace CarRental
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            button6 = new Button();
            panel5 = new Panel();
            button8 = new Button();
            panel6 = new Panel();
            button7 = new Button();
            panel4 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button5 = new Button();
            sidebarT = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 49);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(918, 12);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 2;
            label2.Text = "ADMIN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 27);
            label1.TabIndex = 1;
            label1.Text = "CAR RENTAL MANAGEMENT";
            // 
            // btnHam
            // 
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(3, 3);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(40, 42);
            btnHam.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHam.TabIndex = 1;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Black;
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel3);
            sidebar.Dock = DockStyle.Left;
            sidebar.ForeColor = SystemColors.ControlLightLight;
            sidebar.Location = new Point(0, 49);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(151, 434);
            sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(button6);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 42);
            panel2.TabIndex = 8;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-4, -6);
            button6.Name = "button6";
            button6.Size = new Size(178, 53);
            button6.TabIndex = 7;
            button6.Text = "Dashboard";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button8);
            panel5.Location = new Point(3, 51);
            panel5.Name = "panel5";
            panel5.Size = new Size(172, 43);
            panel5.TabIndex = 10;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveCaptionText;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-4, -6);
            button8.Name = "button8";
            button8.Size = new Size(184, 56);
            button8.TabIndex = 9;
            button8.Text = "Payments";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(button7);
            panel6.Location = new Point(3, 100);
            panel6.Name = "panel6";
            panel6.Size = new Size(172, 38);
            panel6.TabIndex = 11;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaptionText;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-4, -9);
            button7.Name = "button7";
            button7.Size = new Size(184, 57);
            button7.TabIndex = 8;
            button7.Text = "Customer";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Location = new Point(3, 144);
            panel4.Name = "panel4";
            panel4.Size = new Size(168, 37);
            panel4.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-4, -5);
            button1.Name = "button1";
            button1.Size = new Size(178, 51);
            button1.TabIndex = 10;
            button1.Text = "Vehicles";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button5);
            panel3.Location = new Point(3, 187);
            panel3.Name = "panel3";
            panel3.Size = new Size(168, 39);
            panel3.TabIndex = 11;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-4, -6);
            button5.Name = "button5";
            button5.Size = new Size(176, 60);
            button5.TabIndex = 6;
            button5.Text = "Bookings";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // sidebarT
            // 
            sidebarT.Interval = 10;
            sidebarT.Tick += sidebarT_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 483);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Button button1;
        private Label label2;
        private Button button5;
        private Button button7;
        private Button button6;
        private Button button8;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private System.Windows.Forms.Timer sidebarT;
    }
}
