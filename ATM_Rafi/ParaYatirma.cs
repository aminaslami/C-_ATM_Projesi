using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Rafi
{
    public partial class ParaYatirma : Form
    {
        public ParaYatirma()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Rafi\ATM_Rafi\ATM_DB_Rafi.mdf;Integrated Security=True");
        string Hes = Giris.HesNumara;
        private void button1_Click(object sender, EventArgs e)
        {
            if(ParaYatirmaTutarTb.Text == "" || Convert.ToInt32(ParaYatirmaTutarTb.Text) <= 0)
            {
                MessageBox.Show("Yatırılacak Tutarı Girin");
            }
            else
            {
                string Hes = Giris.HesNumara;
                yeniBakiye = eskiBakiye + Convert.ToInt32(ParaYatirmaTutarTb.Text);
                try
                { 
                    Con.Open();
                    string query = "update HesapTable set Bakiye=" + yeniBakiye + "where HesapNo='" + Hes + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Para Başarılı Bir Şekilde Yatırıldı");
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
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }
        int eskiBakiye, yeniBakiye;
        private void getBakiye()
        {
            Con.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("select Bakiye from HesapTable where HesapNo='" + Hes + "'", Con);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            eskiBakiye = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ParaYatirma_Load(object sender, EventArgs e)
        {
            getBakiye();
        }
    }
}
