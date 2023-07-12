using System.Linq.Expressions;

namespace BigliYarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0;
        int dogru = 0;
        int yanlis = 0;
        private void btnnext_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnnext.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnnext.Text = "Sonraki";
            if (soruno == 5)
            {
                btnnext.Text = "Sonuçlar";
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnnext.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);

            }



            soruno++;
            lblsoruno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Atatürk İstanbul'dan Samsun'a hangi vapur ile gitmişir?";
                btnA.Text = "Savarona";
                btnB.Text = "Bandırma";
                btnC.Text = "Ali Kaptan";
                btnD.Text = "TCG Anadolu";
                label4.Text = "Bandırma";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Cumhuriyet hangi yıl ilan edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Çanakkale savaşı hangi yıl olmuştur?";
                btnA.Text = "1915";
                btnB.Text = "1917";
                btnC.Text = "1919";
                btnD.Text = "1918";
                label4.Text = "1918";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Atatürk hangi ilin nüfusuna kayıtlıdır?";
                btnA.Text = "Samsun";
                btnB.Text = "Ankara";
                btnC.Text = "Çanakkale";
                btnD.Text = "Gaziantep";
                label4.Text = "Gaziantep";

            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Atatürk 'Geldikleri gibi giderler sözünü hangi ilde söylemiştir?";
                btnA.Text = "Ankara";
                btnB.Text = "İstanbul";
                btnC.Text = "Çanakkale";
                btnD.Text = "Samsun";
                label4.Text = "İstanbul";

            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnnext.Enabled = true;
            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnnext.Enabled = true;
            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnnext.Enabled = true;
            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnnext.Enabled = true;
            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}