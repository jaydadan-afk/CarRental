namespace CarRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void sidebarT_Tick(object sender, EventArgs e)
        {
            sidebar.Width -= 10;
            if (sidebar.Width <= 0)
            {

                sidebarT.Stop();
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 243)
                {
                    sidebarT.Stop();
                }


            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarT.Start();
        }
    }
}
