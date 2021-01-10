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

namespace Magazine_muzica
{
    public partial class Vanzari_totale : Form
    {
        public Vanzari_totale()
        {
            InitializeComponent();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HGD9B6P;Initial Catalog=Magazine_muzica;Integrated Security=True");

        private void populate()
        {
            Con.Open();
            string Myquery = "select * from Vanzari_totale;";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            TotalVanzari.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void populate1()
        {
            if(string.IsNullOrWhiteSpace(Valoare_suma.Text))
            {
                Con.Open();
                string Myquery = "select * from Vanzari_totale";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                TotalVanzari.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                Con.Open();
                string Myquery = "select * from Vanzari_totale where total >= '" + Valoare_suma.Text + "';";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                TotalVanzari.DataSource = ds.Tables[0];
                Con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Vanzari v = new Vanzari();
            v.Show();
            this.Hide();
        }

        private void TotalVanzari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Vanzari_totale_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Case_discuri_Click(object sender, EventArgs e)
        {

        }

        private void Cauta_Click(object sender, EventArgs e)
        {
            populate1();
        }
    }
}
