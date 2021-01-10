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
    public partial class Edituri : Form
    {
        public Edituri()
        {
            InitializeComponent();
            Tip_sortare.SelectedIndex = 0;
            Sortare_coloana.SelectedIndex = 0;
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HGD9B6P;Initial Catalog=Magazine_muzica;Integrated Security=True");

        private void populate()
        {
            if (Tip_sortare.Text == "desc")
            {
                Con.Open();
                string Myquery = "select * from edituri order by '" + Sortare_coloana.Text + "' desc;";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                DateEdituri.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                if (Sortare_coloana.Text == "id_editura")
                {
                    Con.Open();
                    string Myquery = "select * from edituri order by id_editura;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateEdituri.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "nume_editura")
                {
                    Con.Open();
                    string Myquery = "select * from edituri order by nume_editura;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateEdituri.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "an_infiintare")
                {
                    Con.Open();
                    string Myquery = "select * from edituri order by an_infiintare;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateEdituri.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string Myquery = "select * from edituri order by numar_telefon;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateEdituri.DataSource = ds.Tables[0];
                    Con.Close();
                }
            }

        }


        private void Edituri_Load(object sender, EventArgs e)
        {
        }

        private void InsertEditura_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(Nume_editura.Text) || string.IsNullOrWhiteSpace(Telefon_editura.Text))
                {
                    MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a fost realizata.");
                }
                else if (string.IsNullOrWhiteSpace(An_editura.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO edituri (nume_editura, numar_telefon) VALUES ('" + Nume_editura.Text + "', '" + Telefon_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes!");

                    Con.Close();
                    populate();
                }
                else
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO edituri (nume_editura, an_infiintare, numar_telefon) VALUES ('" + Nume_editura.Text + "', '" + An_editura.Text + "', '" + Telefon_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes!");

                    Con.Close();
                    populate();
                }
                
            }
            catch
            {
                MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a avut succes.");
                Con.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Meniu meniu = new Meniu();
            meniu.Show();
            this.Hide();
        }

        private void DateEdituri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_editura.Text = DateEdituri.SelectedRows[0].Cells[0].Value.ToString();
            Nume_editura.Text = DateEdituri.SelectedRows[0].Cells[1].Value.ToString();
            An_editura.Text = DateEdituri.SelectedRows[0].Cells[2].Value.ToString();
            Telefon_editura.Text = DateEdituri.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void DeleteEdituri_Click(object sender, EventArgs e)
        {
           
            Con.Open();
            string MyQuery = "DELETE FROM edituri WHERE id_editura = '"+ID_editura.Text+"'";
            SqlCommand cmd = new SqlCommand(MyQuery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Datele au fost șterse cu succes");

            Con.Close();
            populate();


            ID_editura.Text = "";
            Nume_editura.Text = "";
            Telefon_editura.Text = "";
            An_editura.Text = "";

        }

        private void UpdateEditura_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Nume_editura.Text) || string.IsNullOrWhiteSpace(Telefon_editura.Text))
                {
                    MessageBox.Show("Datele introduse sunt gresite. Modificarea nu a fost realizata.");
                }
                else if (string.IsNullOrWhiteSpace(An_editura.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE edituri SET nume_editura = '" + Nume_editura.Text + "', an_infiintare = NULL, numar_telefon = '" + Telefon_editura.Text + "' WHERE id_editura = '" + ID_editura.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes!");

                    Con.Close();
                    populate();
                }
                else
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE edituri SET nume_editura = '" + Nume_editura.Text + "', an_infiintare = '" + An_editura.Text + "', numar_telefon = '" + Telefon_editura.Text + "' WHERE id_editura = '" + ID_editura.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes!");

                    Con.Close();
                    populate();
                }
             
            }
            catch
            {
                MessageBox.Show("Datele introduse sunt gresite. Modificarea nu a avut loc.");
                Con.Close();
            }
        }

        private void Cautare_editura_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_editura.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM edituri WHERE lower(nume_editura) LIKE '%"+keyword+"%' OR an_infiintare LIKE '%"+keyword+"%' OR numar_telefon LIKE '%"+keyword+ "%' OR id_editura LIKE '%"+keyword+"%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DateEdituri.DataSource = dt;

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
    }
}
