using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yemek_siparis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("cagatay@cagatayakinci.com");
            mesaj.To.Add(textBox1.Text);
            mesaj.Subject = textBox2.Text;
            mesaj.Body = richTextBox1.Text;

            SmtpClient a = new SmtpClient();
            a.Credentials = new System.Net.NetworkCredential("cagatay@cagatayakinci.com", "Şifre");
            a.Port = 587;
            a.Host = "cagatayakinci.com";
            a.EnableSsl = true;
            object userState = mesaj;

            try
            {
                a.SendAsync(mesaj, (object)mesaj);
                MessageBox.Show("Mail Gönderilmiştir");
            }

            catch (SmtpException ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ödeme yöntemi seçilmiştir bizi tercih etdiginiz için teşekürler");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }

        }
    }
}
