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
    public partial class Bakiye : Form
    {
        public Bakiye()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Rafi\ATM_Rafi\ATM_DB_Rafi.mdf;Integrated Security=True");
        private void getBakiye()
        {
            Con.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("select Bakiye from HesapTable where HesapNo='" + HesNumaraLabel.Text + "'", Con);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            BakiyeLabel.Text = "TL " + dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void Bakiye_Load(object sender, EventArgs e)
        {
            HesNumaraLabel.Text = AnaSayfa.HesNumara;
            getBakiye();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            this.Hide();
            ana.Show();
        }
    }
}
