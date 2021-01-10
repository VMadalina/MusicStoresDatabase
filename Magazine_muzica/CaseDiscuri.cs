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
    public partial class CaseDiscuri : Form
    {
        public CaseDiscuri()
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
                string Myquery = "select * from casa_discuri order by '" + Sortare_coloana.Text + "' desc;";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                DateCasa.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                if (Sortare_coloana.Text == "CUI_casa")
                {
                    Con.Open();
                    string Myquery = "select * from casa_discuri order by CUI_casa;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateCasa.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "nume_casa")
                {
                    Con.Open();
                    string Myquery = "select * from casa_discuri order by nume_casa;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateCasa.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "an_infiintare")
                {
                    Con.Open();
                    string Myquery = "select * from casa_discuri order by an_infiintare;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateCasa.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string Myquery = "select * from casa_discuri order by sediu_central;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateCasa.DataSource = ds.Tables[0];
                    Con.Close();
                }
            }
          
        }

        private void Cautare_albume_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_case.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM casa_discuri WHERE lower(nume_casa) LIKE '%" + keyword + "%' OR an_infiintare LIKE '%" + keyword + "%' OR sediu_central LIKE '%" + keyword + "%' OR CUI_casa LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DateCasa.DataSource = dt;

            Con.Close();
        }


        private void CaseDiscuri_Load(object sender, EventArgs e)
        {
        }

        private void InsertCasa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ID_casa.Text) || string.IsNullOrWhiteSpace(Nume_casa.Text))
                {
                    MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a fost realizata.");
                }
                else if ((string.IsNullOrWhiteSpace(Sediu_central.Text)) && (string.IsNullOrWhiteSpace(An_casa.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO casa_discuri (CUI_casa, nume_casa) VALUES ('"+ID_casa.Text+"', '" + Nume_casa.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                }
                else if (string.IsNullOrWhiteSpace(Sediu_central.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO casa_discuri (CUI_casa, nume_casa, an_infiintare) VALUES ('" + ID_casa.Text + "', '" + Nume_casa.Text + "', '" + An_casa.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                }
                else if (string.IsNullOrWhiteSpace(An_casa.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO casa_discuri (CUI_casa, nume_casa, sediu_central) VALUES ('" + ID_casa.Text + "', '" + Nume_casa.Text + "', '" + Sediu_central.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                }
                else
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO casa_discuri (CUI_casa, nume_casa, an_infiintare,  sediu_central) VALUES ('" + ID_casa.Text + "', '" + Nume_casa.Text + "', '" + An_casa.Text + "','" + Sediu_central.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                }

            }
            catch
            {
                MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a avut succes");
                Con.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Meniu meniu = new Meniu();
            meniu.Show();
            this.Hide();
        }

        private void DateCasa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_casa.Text = DateCasa.SelectedRows[0].Cells[0].Value.ToString();
            Nume_casa.Text = DateCasa.SelectedRows[0].Cells[1].Value.ToString();
            An_casa.Text = DateCasa.SelectedRows[0].Cells[2].Value.ToString();
            Sediu_central.Text = DateCasa.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void UpdateCasa_Click(object sender, EventArgs e)
        {
           try
            {

                Con.Open();
                if (string.IsNullOrWhiteSpace(ID_casa.Text) || string.IsNullOrWhiteSpace(Nume_casa.Text))
                {
                    MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a fost realizata.");
                }
                else if (string.IsNullOrWhiteSpace(An_casa.Text) && string.IsNullOrWhiteSpace(Sediu_central.Text))
                {
                    An_casa.Text = "";
                    Sediu_central.Text = "";
                    SqlCommand cmd = new SqlCommand("UPDATE casa_discuri SET nume_casa = '" + Nume_casa.Text + "', an_infiintare = NULL, sediu_central = NULL WHERE CUI_casa = '" + ID_casa.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");
                }
                else if (string.IsNullOrWhiteSpace(Sediu_central.Text))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE casa_discuri SET nume_casa = '" + Nume_casa.Text + "', an_infiintare = '" + An_casa.Text + "', sediu_central = NULL WHERE CUI_casa = '" + ID_casa.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");
                }
                else if (string.IsNullOrWhiteSpace(An_casa.Text))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE casa_discuri SET nume_casa = '" + Nume_casa.Text + "', an_infiintare = NULL, sediu_central = '" + Sediu_central.Text + "' WHERE CUI_casa = '" + ID_casa.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("UPDATE casa_discuri SET nume_casa = '" + Nume_casa.Text + "', an_infiintare = '" + An_casa.Text + "', sediu_central = '" + Sediu_central.Text + "' WHERE CUI_casa = '" + ID_casa.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");
                }
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Datele au fost introduse gresit. Modificarea nu a avut loc.");
                Con.Close();
            }
            
        }

        private void DeleteCasa_Click(object sender, EventArgs e)
        {
            Con.Open();
            string MyQuery = "DELETE FROM casa_discuri WHERE CUI_casa = '" + ID_casa.Text + "'";
            SqlCommand cmd = new SqlCommand(MyQuery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Datele au fost șterse cu succes");

            Con.Close();
            populate();


            ID_casa.Text = "";
            Nume_casa.Text = "";
            Sediu_central.Text = "";
            An_casa.Text = "";
        }

        private void ID_casa_TextChanged(object sender, EventArgs e)
        {

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
