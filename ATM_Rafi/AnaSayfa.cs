using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Rafi
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e) // label5 = Çıkış
        {
            Giris gir = new Giris();
            gir.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e) // button6 == Bakiye 
        {
            Bakiye bak = new Bakiye();
            this.Hide();
            bak.Show();

        }
        public static String HesNumara;
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            HesapNumaraLabel.Text = "Hesap Numara : " + Giris.HesNumara;
            HesNumara = Giris.HesNumara;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParaYatirma yatir = new ParaYatirma();
            yatir.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SifreDegistir sifre = new SifreDegistir();
            sifre.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParaCekme pc = new ParaCekme();
            pc.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
