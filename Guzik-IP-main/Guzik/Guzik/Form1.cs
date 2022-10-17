namespace Guzik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
private void label1_Click(object sender, EventArgs e)
        {
        

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ip1 = textBox1.Text;
            string ip2 = textBox2.Text;
            string ip3 = textBox3.Text;
            string ip4 = textBox4.Text;


            int chuj = int.Parse(ip1);
            int chuj2 = int.Parse(ip2);
            int chuj3 = int.Parse(ip3);
            int chuj4 = int.Parse(ip4);




            //spr
            if (chuj < 0 || chuj > 255)
            {
                label5.Text = "N I E";
            }
            else if (chuj2 < 0 || chuj2 > 255)
            {
                label5.Text = "N I E";
            }
            else if (chuj3 < 0 || chuj3 > 255)
            {
                label5.Text = "N I E";
            }
            else if (chuj4 < 0 || chuj4 > 255)
            {
                label5.Text = "N I E";
            }
            else { label5.Text = "T A K"; }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}