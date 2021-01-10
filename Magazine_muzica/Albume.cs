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
    public partial class Albume : Form
    {
        public Albume()
        {
            InitializeComponent();
            Tip_sortare.SelectedIndex = 0;
            Sortare_coloana.SelectedIndex = 0;
            populate();
            findID_Magazin();
            FillFormat();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HGD9B6P;Initial Catalog=Magazine_muzica;Integrated Security=True");

        private void populate()
        {
            if (Tip_sortare.Text == "desc")
            {
                Con.Open();
                string Myquery = "select * from albume order by '" + Sortare_coloana.Text + "' desc;";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                DateAlbume.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                if (Sortare_coloana.Text == "id_album")
                {

                    Con.Open();
                    string Myquery = "select * from albume order by id_album;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateAlbume.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "nume_album")
                {
                    Con.Open();
                    string Myquery = "select * from albume order by nume_album;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateAlbume.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "nume_artist")
                {
                    Con.Open();
                    string Myquery = "select * from albume order by nume_artist;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateAlbume.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "format_album")
                {
                    Con.Open();
                    string Myquery = "select * from albume order by format_album;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateAlbume.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "data_lansare")
                {
                    Con.Open();
                    string Myquery = "select * from albume order by data_lansare;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateAlbume.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string Myquery = "select * from albume order by CUI_casa;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateAlbume.DataSource = ds.Tables[0];
                    Con.Close();
                }
            }
        }

        void FillFormat()
        {

            string query = "SELECT distinct format_album FROM albume;";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("format_album", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                Format_album.ValueMember = "format_album";
                Format_album.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }

        }

        private void findID_Magazin()
        {
            Con.Open();
            string Myquery = "select CUI_casa, nume_casa from casa_discuri;";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Date_IDcasa.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void CautareIDCasa_Click(object sender, EventArgs e)
        {

        }

        private void SearchMagazine_Click(object sender, EventArgs e)
        {

        }

        private void InsertAlbume_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand comand = new SqlCommand("SELECT count(*) FROM albume WHERE lower(nume_album) = lower('" + Nume_album.Text + "') and lower(nume_artist) = lower('" + Nume_artist.Text + "') and lower(format_album) = lower('" + Format_album.Text + "');",Con);
            int exist = (int)comand.ExecuteScalar();
            Con.Close();
            if (exist > 0)
            {
                MessageBox.Show("Albumul se afla deja in baza de date.");
            }
            else
            {
                try
                {
                    if(string.IsNullOrWhiteSpace(Nume_album.Text) || string.IsNullOrWhiteSpace(Nume_artist.Text) || string.IsNullOrWhiteSpace(Format_album.Text) || string.IsNullOrWhiteSpace(Data_lansare.Text))
                    {
                        MessageBox.Show("Datele introduse sunt gresite!");
                    }
                    else if (string.IsNullOrWhiteSpace(ID_casa.Text))
                    {
                        Con.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO albume (nume_album, nume_artist, format_album, data_lansare) VALUES ('" + Nume_album.Text + "', '"+Nume_artist.Text+"', '" + Format_album.Text + "', '" + Data_lansare.Text + "');", Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datele au fost introduse cu succes");

                        Con.Close();
                        populate();
                        findID_Magazin();
                    }
                    else
                    {
                        Con.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO albume (nume_album, nume_artist, format_album, data_lansare, CUI_casa) VALUES ('" + Nume_album.Text + "', '" + Nume_artist.Text + "', '" + Format_album.Text + "', '" + Data_lansare.Text + "', '" + ID_casa.Text + "');", Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datele au fost introduse cu succes");

                        Con.Close();
                        populate();
                        findID_Magazin();
                    }

                }
                catch
                {
                    MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a avut succes");
                    Con.Close();
                }
            }             
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Meniu meniu = new Meniu();
            meniu.Show();
            this.Hide();
        }

        private void UpdateAlbume_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ID_album.Text) || string.IsNullOrWhiteSpace(Nume_album.Text) || string.IsNullOrWhiteSpace(Nume_artist.Text) || string.IsNullOrWhiteSpace(Format_album.Text) || string.IsNullOrWhiteSpace(Data_lansare.Text))
                {
                    MessageBox.Show("Datele introduse sunt gresite!");
                }
                else if (string.IsNullOrWhiteSpace(ID_casa.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE albume SET nume_album = '" + Nume_album.Text + "', nume_artist = '" + Nume_artist.Text + "', format_album = '" + Format_album.Text + "', data_lansare = '" + Data_lansare.Text + "', CUI_casa = null WHERE id_album = '" + ID_album.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                    findID_Magazin();
                }
                else
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE albume SET nume_album = '" + Nume_album.Text + "', nume_artist = '" + Nume_artist.Text + "', format_album = '" + Format_album.Text + "', data_lansare = '" + Data_lansare.Text + "', CUI_casa = '" + ID_casa.Text + "' WHERE id_album = '" + ID_album.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                    findID_Magazin();
                }

            }
            catch
            {
                MessageBox.Show("Datele introduse sunt gresite. Modificarea nu a avut succes");
                Con.Close();
            }
        }

        private void DeleteAlbume_Click(object sender, EventArgs e)
        {
            Con.Open();
            string MyQuery = "DELETE FROM albume WHERE id_album = '" + ID_album.Text + "'";
            SqlCommand cmd = new SqlCommand(MyQuery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Datele au fost șterse cu succes");

            Con.Close();
            populate();
            findID_Magazin();

            ID_album.Text = "";
            Nume_album.Text = "";
            Nume_artist.Text = "";
            Format_album.Text = "";
            Data_lansare.Text = "";
            ID_casa.Text = "";
        }

        private void Albume_Load(object sender, EventArgs e)
        {
           
        }

        private void DateAlbume_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_album.Text = DateAlbume.SelectedRows[0].Cells[0].Value.ToString();
            Nume_album.Text = DateAlbume.SelectedRows[0].Cells[1].Value.ToString();
            Nume_artist.Text = DateAlbume.SelectedRows[0].Cells[2].Value.ToString();
            Format_album.Text = DateAlbume.SelectedRows[0].Cells[3].Value.ToString();
            Data_lansare.Text = DateAlbume.SelectedRows[0].Cells[4].Value.ToString();
            ID_casa.Text = DateAlbume.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void Cautare_albume_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_albume.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM albume WHERE lower(nume_album) LIKE '%" + keyword + "%' OR lower(nume_artist) LIKE '%" + keyword + "%' OR data_lansare LIKE '%" + keyword + "%' OR CUI_casa LIKE '%" + keyword + "%' OR lower(format_album) LIKE '%" + keyword + "%' OR id_album LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DateAlbume.DataSource = dt;

            Con.Close();
        }

        private void Date_IDcasa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_casa.Text = Date_IDcasa.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void Cautare_id_casa_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_id_casa.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT CUI_casa, nume_casa FROM casa_discuri WHERE lower(nume_casa) LIKE '%" + keyword + "%' OR CUI_casa LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            Date_IDcasa.DataSource = dt;

            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sortare_coloana_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate();
        }

        private void Tip_sortare_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate();

        }

        private void IDAlbum_Click(object sender, EventArgs e)
        {

        }

        private void ID_album_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
