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
            label2 = new Label();
            label1 = new Label();
            sidebarT = new System.Windows.Forms.Timer(components);
            panel6 = new Panel();
            button7 = new Button();
            panel5 = new Panel();
            button8 = new Button();
            panel3 = new Panel();
            button5 = new Button();
            panel4 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            button6 = new Button();
            panel1 = new Panel();
            btnMenu = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(903, 14);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 2;
            label2.Text = "ADMIN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 12);
            label1.Name = "label1";
            label1.Size = new Size(296, 27);
            label1.TabIndex = 1;
            label1.Text = "CAR RENTAL MANAGEMENT";
            // 
            // sidebarT
            // 
            sidebarT.Interval = 10;
            sidebarT.Tick += sidebarT_Tick;
            // 
            // panel6
            // 
            panel6.Controls.Add(button7);
            panel6.Location = new Point(3, 274);
            panel6.Name = "panel6";
            panel6.Size = new Size(178, 38);
            panel6.TabIndex = 11;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaptionText;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-30, -9);
            button7.Name = "button7";
            button7.Padding = new Padding(30, 0, 0, 0);
            button7.Size = new Size(195, 57);
            button7.TabIndex = 8;
            button7.Text = "Customer";
            button7.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button8);
            panel5.Location = new Point(3, 224);
            panel5.Name = "panel5";
            panel5.Size = new Size(154, 44);
            panel5.TabIndex = 10;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveCaptionText;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-30, -24);
            button8.Name = "button8";
            button8.Padding = new Padding(30, 0, 0, 0);
            button8.Size = new Size(198, 83);
            button8.TabIndex = 9;
            button8.Text = "Payments";
            button8.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button5);
            panel3.Location = new Point(3, 169);
            panel3.Name = "panel3";
            panel3.Size = new Size(194, 49);
            panel3.TabIndex = 11;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-30, -19);
            button5.Name = "button5";
            button5.Padding = new Padding(30, 0, 0, 0);
            button5.Size = new Size(198, 79);
            button5.TabIndex = 6;
            button5.Text = "Bookings";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Location = new Point(3, 115);
            panel4.Name = "panel4";
            panel4.Size = new Size(168, 48);
            panel4.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-30, -17);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(198, 73);
            button1.TabIndex = 10;
            button1.Text = "Vehicles";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button6);
            panel2.Location = new Point(3, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 42);
            panel2.TabIndex = 8;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-30, -20);
            button6.Name = "button6";
            button6.Padding = new Padding(30, 0, 0, 0);
            button6.Size = new Size(198, 81);
            button6.TabIndex = 7;
            button6.Text = "Dashboard";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMenu);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 58);
            panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(3, 9);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(35, 38);
            btnMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMenu.TabIndex = 2;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Black;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
            sidebar.Dock = DockStyle.Left;
            sidebar.ForeColor = SystemColors.ControlLightLight;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(151, 434);
            sidebar.MinimumSize = new Size(47, 434);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(151, 434);
            sidebar.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 432);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer sidebarT;
        private Panel panel6;
        private Button button7;
        private Panel panel5;
        private Button button8;
        private Panel panel3;
        private Button button5;
        private Panel panel4;
        private Button button1;
        private Panel panel2;
        private Button button6;
        private Panel panel1;
        private PictureBox btnMenu;
        private FlowLayoutPanel sidebar;
    }
}
