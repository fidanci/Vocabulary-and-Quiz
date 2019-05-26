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
    public partial class kelimeYarismasi1 : Form
    {
        public kelimeYarismasi1()
        {
            InitializeComponent();
        }
        string kelime, harf;
        int uzunluk;
        int bilinenHarf;
        int kalanHak = 10;
        int kalanSüre = 60;
        string[] harfler;

        private void kelimeYarismasi1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string[] dizi = { }; // The series in which words are written
            Random sayi = new Random();
            int no = sayi.Next(0, dizi.Length);
            kelime = dizi[no];
            uzunluk = kelime.Length;
            harfler = new string[uzunluk];
            label4.Text = kelime;

            if (label4.Text == dizi[0])
            {
                label3.Text = "";
            }

            lblAktar();
            diziyeAktar();
            
        }
        void lblAktar()
        {
            label1.Text = "";
            for (int i = 0; i < uzunluk; i++)
            {
                label1.Text = " _ ";
            }
        }
        void diziyeAktar()
        {
            for(int i = 0; i >= uzunluk; i++)
            {
                harfler[i] = kelime.Substring(i, 1);
            }
        }

        private void btntamam_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                harf = textBox1.Text;
                int sorgula = 0;
                for (int i = 0; i < uzunluk; i++)
                {
                    if (harf == harfler[i])
                    {
                        string metin = label1.Text;
                        label1.Text = yazdir(metin, i, harf);
                        bilinenHarf++;
                        sorgula = 1;
                    }
                }
                if (sorgula == 0)
                {
                    kalanHak--;
                    MessageBox.Show(kalanHak.ToString());
                }

            }
            oyunBitti();
            textBox1.Clear();
        }
        void oyunBitti()
        {
            if (bilinenHarf == uzunluk)
            {
                timer1.Stop();
                MessageBox.Show("Kelimenin tüm harfleri bulundu.");
            }
            if (kalanSüre <= 0 || kalanHak <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Oyun bitti! Kelimeyi bulamadın!!");
            }  
        }

        static string yazdir(string metin, int indis, string yenideger)
        {
            metin = metin.Remove(indis, 1);
            return metin.Insert(indis, yenideger);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            oyunBitti();
            if (kalanSüre > 0)
            {
                kalanSüre--;
                label2.Text = " : " + kalanSüre;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ﺍ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ب";  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ت"; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ث";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ج";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ح";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "خ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "د";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ذ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ر";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ز";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "س";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ش";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ص";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ض";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ط";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ظ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ع";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "غ";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ف";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ق";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ك";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ل";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "م";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ن";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ه";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "و";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ي";
        }

    }
}
