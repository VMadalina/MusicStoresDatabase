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
using System.Runtime.InteropServices;


namespace Magazine_muzica
{
    public partial class Magazine : Form
    {
        public Magazine()
        {
            InitializeComponent();
            Tip_sortare.SelectedIndex = 0;
            Sortare_coloana.SelectedIndex = 0;
            populate();
            FillTipStrada();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HGD9B6P;Initial Catalog=Magazine_muzica;Integrated Security=True");

        private void populate()
        {
            if (Tip_sortare.Text == "desc")
            {
                Con.Open();
                string Myquery = "select * from magazine order by '" + Sortare_coloana.Text + "' desc;";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                DateMagazine.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                if (Sortare_coloana.Text == "id_magazin")
                {

                    Con.Open();
                    string Myquery = "select * from magazine order by id_magazin;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateMagazine.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "nume_magazin")
                {
                    Con.Open();
                    string Myquery = "select * from magazine order by nume_magazin;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateMagazine.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "oras")
                {
                    Con.Open();
                    string Myquery = "select * from magazine order by oras;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateMagazine.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "tip_strada")
                {
                    Con.Open();
                    string Myquery = "select * from magazine order by tip_strada;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateMagazine.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "numele_strazii")
                {
                    Con.Open();
                    string Myquery = "select * from magazine order by numele_strazii;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateMagazine.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string Myquery = "select * from magazine order by numarul_strazii;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateMagazine.DataSource = ds.Tables[0];
                    Con.Close();
                }
            }

        }

        void FillTipStrada()
        {

            string query = "SELECT distinct tip_strada FROM magazine;";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("tip_strada", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                Tip_strada.ValueMember = "tip_strada";
                Tip_strada.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Meniu meniu = new Meniu();
            meniu.Show();
            this.Hide();
        }

        private void InsertMagazine_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Nume_magazin.Text) || string.IsNullOrWhiteSpace(oras.Text) || string.IsNullOrWhiteSpace(Nume_strada.Text) || string.IsNullOrWhiteSpace(Numar_strada.Text))
                {
                    MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a fost realizata.");
                    Con.Close();
                }
                else
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO magazine (nume_magazin, oras, tip_strada, numele_strazii, numarul_strazii) VALUES ('" + Nume_magazin.Text + "', '" + oras.Text + "', '" + Tip_strada.Text + "', '" + Nume_strada.Text + "', '" + Numar_strada.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a fost realizata.");
                Con.Close();
            }
        }

        private void UpdateMagazine_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Nume_magazin.Text) || string.IsNullOrWhiteSpace(oras.Text) || string.IsNullOrWhiteSpace(Nume_strada.Text) || string.IsNullOrWhiteSpace(Numar_strada.Text))
                {
                    MessageBox.Show("Datele introduse sunt gresite. Modificarea nu a fost realizata.");
                    Con.Close();
                }
                else
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE magazine SET nume_magazin = '" + Nume_magazin.Text + "', oras = '" + oras.Text + "', numele_strazii = '" + Nume_strada.Text + "', numarul_strazii = '" + Numar_strada.Text + "', tip_strada = '" + Tip_strada.Text + "' WHERE id_magazin = '" + ID_magazin.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Datele introduse sunt gresite. Modificarea nu a fost realizata.");
                Con.Close();
            }
        }

        private void DeleteMagazine_Click(object sender, EventArgs e)
        {
                Con.Open();
                string MyQuery = "DELETE FROM magazine WHERE id_magazin = '" + ID_magazin.Text + "'";
                SqlCommand cmd = new SqlCommand(MyQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datele au fost șterse cu succes");

                Con.Close();
                populate();

            ID_magazin.Text = "";
            Nume_magazin.Text = "";
            oras.Text = "";
            Numar_strada.Text = "";
            Tip_strada.Text = "";
            Nume_strada.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_magazin.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM magazine WHERE lower(nume_magazin) LIKE '%" + keyword + "%' OR oras LIKE '%" + keyword + "%' OR numele_strazii LIKE '%" + keyword + "%' OR numarul_strazii LIKE '%" + keyword + "%'OR id_magazin LIKE '%" + keyword + "%' OR lower(tip_strada) LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DateMagazine.DataSource = dt;

            Con.Close();
        }

        private void Magazine_Load(object sender, EventArgs e)
        {

        }

        private void DateMagazine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ID_magazin.Text = DateMagazine.SelectedRows[0].Cells[0].Value.ToString();
            Nume_magazin.Text = DateMagazine.SelectedRows[0].Cells[1].Value.ToString();
            oras.Text = DateMagazine.SelectedRows[0].Cells[2].Value.ToString();
            Tip_strada.Text = DateMagazine.SelectedRows[0].Cells[3].Value.ToString();
            Nume_strada.Text = DateMagazine.SelectedRows[0].Cells[4].Value.ToString();
            Numar_strada.Text = DateMagazine.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tip_strada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sortare_coloana_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate();
        }

        private void Tip_sortare_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate();
        }
    }
}
