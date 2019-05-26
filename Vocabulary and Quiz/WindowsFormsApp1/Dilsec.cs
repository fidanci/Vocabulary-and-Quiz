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
    public partial class Dilsec : Form
    {
        public Dilsec()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                BilgiYarismasi yarisma = new BilgiYarismasi();
                this.Hide();
                yarisma.Show();
            }
            if(radioButton2.Checked)
            {
                KelimeYarismasi kelime = new KelimeYarismasi();
                this.Hide();
                kelime.Show();
            }
        }
    }
}
