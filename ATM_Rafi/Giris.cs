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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hesap hes = new Hesap();
            hes.Show();
            this.Hide();
        }
        public static String HesNumara;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Rafi\ATM_Rafi\ATM_DB_Rafi.mdf;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("select count(*) from HesapTable where HesapNo='" + HesNoTb.Text+"' and Sifre = " + SifreTb.Text + "",Con);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                HesNumara = HesNoTb.Text;
                AnaSayfa ana = new AnaSayfa();
                ana.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Yanlış Hesap Numarası veya Şifre Girdiniz");
            }
            Con.Close();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
             
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
