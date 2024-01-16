namespace yemek_siparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Kullanici;

            string sifre;

            Kullanici = textBox1.Text;

            sifre = textBox2.Text;

            if (Kullanici == "emirhan" && sifre == "123456")
            {

                this.Hide();
                Form2 frm = new Form2();
                frm.Show();

            }

            else

            {

                {
                    label4.Show();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

