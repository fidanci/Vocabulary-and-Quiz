using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BilgiYarismasi : Form
    {
        public BilgiYarismasi()
        {
            InitializeComponent();
        }
        int soruSayisi = 0;
        int puan = 0;
        int sure = 60;
        int dogru = 0;
        int yanlis = 0;
        
        void butonlarKapalı()
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }
        void butonlarAcik()
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            sure = 60;
            btnBasla.Text = "Sonraki Soru";
            lblSure.Text = sure.ToString();
            timer1.Enabled = true;
            soruSayisi++;
            lblSoruSayisi.Text = soruSayisi.ToString();
            butonlarAcik();
            Random rnd = new Random();
            int rndno = rnd.Next(0, 3);
            lblRnd.Text = rndno.ToString();
            if (soruSayisi == 1 && rndno == 0)
            {
                richTextBox1.Text = "";
                btnA.Text = "";
                btnB.Text = "";             //Questions written area.
                btnC.Text = "";             //You can increase the number of questions by increasing the run.
                btnD.Text = "";
                lblCevap.Text = "";
            }
            if(soruSayisi == 1 && rndno == 1)
            {
                richTextBox1.Text = "";
                btnA.Text = "";
                btnB.Text = "";                 //Enter the conditions by increasing the RND for the questions to be random
                btnC.Text = "";
                btnD.Text = "";
                lblCevap.Text = "";
            }
           
            if(soruSayisi == 8)
            {
                butonlarKapalı();
                timer1.Enabled = false;
                MessageBox.Show("Oyun Bitmiştir!!" + "Doğru sayınız : " + dogru + " Yanlış Sayınız : " + yanlis + " Puanınız : " + puan);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            butonlarKapalı();
            DialogResult secenek = MessageBox.Show(string.Format("Cevabı Onaylıyor Musunuz?"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                if (lblCevap.Text == btnA.Text)
                {
                    dogru++;
                    puan = puan + 10;
                    lblPuan.Text = puan.ToString();
                    lblDogru.Text = dogru.ToString();
                }
                else
                {
                    yanlis++;
                    lblYanlis.Text = yanlis.ToString();
                }
            }
            else
            {
                butonlarAcik();
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            butonlarKapalı();
            DialogResult secenek = MessageBox.Show(string.Format("Cevabı Onaylıyor Musunuz?"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                if (lblCevap.Text == btnA.Text)
                {
                    dogru++;
                    puan = puan + 10;
                    lblPuan.Text = puan.ToString();
                    lblDogru.Text = dogru.ToString();
                }
                else
                {
                    yanlis++;
                    lblYanlis.Text = yanlis.ToString();
                }
            }
            else
            {
                butonlarAcik();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            butonlarKapalı();
            DialogResult secenek = MessageBox.Show(string.Format("Cevabı Onaylıyor Musunuz?"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                if (lblCevap.Text == btnA.Text)
                {
                    dogru++;
                    puan = puan + 10;
                    lblPuan.Text = puan.ToString();
                    lblDogru.Text = dogru.ToString();
                }
                else
                {
                    yanlis++;
                    lblYanlis.Text = yanlis.ToString();
                }
            }
            else
            {
                butonlarAcik();
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            butonlarKapalı();
            DialogResult secenek = MessageBox.Show(string.Format("Cevabı Onaylıyor Musunuz?"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                if (lblCevap.Text == btnA.Text)
                {
                    dogru++;
                    puan = puan + 10;
                    lblPuan.Text = puan.ToString();
                    lblDogru.Text = dogru.ToString();
                }
                else
                {
                    yanlis++;
                    lblYanlis.Text = yanlis.ToString();
                }
            }
            else
            {
                butonlarAcik();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = Convert.ToInt32(lblSure.Text);
            sure--;
            lblSure.Text = sure.ToString();
            if(sure == 0)
            {
                timer1.Enabled = false;
                butonlarKapalı();
                MessageBox.Show("Süreniz Bitmiştir!!" + "Doğru sayınız : " + dogru + " Yanlış Sayınız : " + yanlis + " Puanınız : " + puan);
            }
        }
    }
}
