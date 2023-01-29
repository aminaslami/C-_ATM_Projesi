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
    public partial class ParaCekme : Form
    {
        public ParaCekme()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Rafi\ATM_Rafi\ATM_DB_Rafi.mdf;Integrated Security=True");
        string Hes = Giris.HesNumara;
        int bak;
        private void getBakiye()
        {
            Con.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("select Bakiye from HesapTable where HesapNo='" + Hes + "'", Con);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            bakiyeLabel.Text = "Bakiye TL " + dt.Rows[0][0].ToString();
            bak = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void ParaCekme_Load(object sender, EventArgs e)
        {
            getBakiye();
        }
        int  yeniBakiye;
        private void button1_Click(object sender, EventArgs e)
        {
            if (cekmeTable.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else if (Convert.ToInt32(cekmeTable.Text) <= 0)
            {
                MessageBox.Show("Geçerli Bir Tutar Girininiz");
            }
            else if (Convert.ToInt32(cekmeTable.Text) > bak)
            {
                MessageBox.Show("Bakiye Eksi Olamaz");
            }
            else
            {
                try
                {
                    yeniBakiye = bak - Convert.ToInt32(cekmeTable.Text);
                    try
                    {
                        Con.Open();
                        string query = "update HesapTable set Bakiye=" + yeniBakiye + "where HesapNo='" + Hes + "';";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Para Başarılı Bir Şekilde Çekildi");
                        Con.Close();
                        AnaSayfa ana = new AnaSayfa();
                        ana.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
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
