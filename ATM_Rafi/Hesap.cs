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
using System.Data.Sql;

namespace ATM_Rafi
{
    public partial class Hesap : Form
    {
        public Hesap()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Rafi\ATM_Rafi\ATM_DB_Rafi.mdf;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            int bakiye = 0;
            if (HesapAdTable.Text == "" || HesapNoTable.Text == "" || SoyadTable.Text == "" || TelefonTable.Text == "" || AdresTable.Text == "" || MeslekTable.Text == "" || SifreTable.Text == "")
            {
                MessageBox.Show("Eksik bilgi");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into HesapTable values('" + Convert.ToInt32(HesapNoTable.Text) + "', '" + HesapAdTable.Text + "', '" + SoyadTable.Text + "', '" + DogumTarihi.Value.Date + "', '" + TelefonTable.Text + "', '" + AdresTable.Text + "', '" + EgitimTable.SelectedItem.ToString() + "', '" + MeslekTable.Text + "', '" + Convert.ToInt32(SifreTable.Text) + "' , '" + bakiye + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hesap Başarıyla Oluşturuldu");
                    Con.Close();
                    Giris gir = new Giris();
                    gir.Show();
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
            Giris gir = new Giris();
            gir.Show();
            this.Hide();

        }
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
