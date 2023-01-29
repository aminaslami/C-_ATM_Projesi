using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ATM_Rafi
{
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Rafi\ATM_Rafi\ATM_DB_Rafi.mdf;Integrated Security=True");
        string Hes = Giris.HesNumara;        
        private void button1_Click(object sender, EventArgs e)
        {
            if (Sifre1Table.Text == "" || Sifre2Table.Text == "")
            {
                MessageBox.Show("Yeni Şifreyi Giriniz ve Onaylayınız");
            }
            else if (Sifre2Table.Text != Sifre1Table.Text)
            {
                MessageBox.Show("1. Şifre ve 2. Şifre Farklıdır.");
            }
            else
            {
                // yeniBakiye = eskiBakiye + Convert.ToInt32(ParaYatirmaTutarTb.Text);
                try
                {
                    Con.Open();
                    string query = "update HesapTable set Sifre=" + Sifre1Table.Text + "where HesapNo='" + Hes + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Şifre Başarılı Bir Şekilde Değiştirildi");
                    Con.Close();
                    Giris ana = new Giris();
                    ana.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
