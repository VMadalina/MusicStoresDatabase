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
    public partial class Producatori : Form
    {
        public Producatori()
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
                string Myquery = "select * from producatori order by '" + Sortare_coloana.Text + "' desc;";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                DateProducator.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                if (Sortare_coloana.Text == "CUI")
                {

                    Con.Open();
                    string Myquery = "select * from producatori order by CUI;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateProducator.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "nume_producator")
                {
                    Con.Open();
                    string Myquery = "select * from producatori order by nume_producator;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateProducator.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "an_infiintare")
                {
                    Con.Open();
                    string Myquery = "select * from producatori order by an_infiintare;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateProducator.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "numar_telefon")
                {
                    Con.Open();
                    string Myquery = "select * from producatori order by numar_telefon;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateProducator.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string Myquery = "select * from producatori order by sediu_central;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateProducator.DataSource = ds.Tables[0];
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

        private void InsertProducator_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CUI_producator.Text) || string.IsNullOrWhiteSpace(Nume_producator.Text) || string.IsNullOrWhiteSpace(Tel_producator.Text))
                {
                    MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a fost realizata.");
                    Con.Close();
                }
                else if (string.IsNullOrWhiteSpace(An_producator.Text) && string.IsNullOrWhiteSpace(Sediu_central.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO producatori (CUI, nume_producator, numar_telefon) VALUES ('" + CUI_producator.Text + "', '" + Nume_producator.Text + "', '" + Tel_producator.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                }
                else if ((string.IsNullOrWhiteSpace(Sediu_central.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO producatori (CUI, nume_producator, an_infiintare, numar_telefon) VALUES ('" + CUI_producator.Text + "', '" + Nume_producator.Text + "', '" + An_producator.Text + "', '" + Tel_producator.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                }
                else if (string.IsNullOrWhiteSpace(An_producator.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO producatori (CUI, nume_producator, numar_telefon, sediu_central) VALUES ('" + CUI_producator.Text + "', '" + Nume_producator.Text + "','" + Tel_producator.Text + "', '" + Sediu_central.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                }
                else
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO producatori (CUI, nume_producator, an_infiintare, numar_telefon, sediu_central) VALUES ('" + CUI_producator.Text + "', '" + Nume_producator.Text + "', '" + An_producator.Text + "', '" +Tel_producator.Text + "', '" + Sediu_central.Text + "');", Con);
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

        public string CUI_vechi = "";

        private void UpdateProducator_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CUI_producator.Text) || string.IsNullOrWhiteSpace(Nume_producator.Text) || string.IsNullOrWhiteSpace(Tel_producator.Text))
                {
                    MessageBox.Show("Datele introduse sunt gresite. Modificarea nu a fost realizata.");
                    Con.Close();
                }
                else if (string.IsNullOrWhiteSpace(An_producator.Text) && string.IsNullOrWhiteSpace(Sediu_central.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE producatori SET nume_producator = '" + Nume_producator.Text + "', an_infiintare = null, numar_telefon = '" + Tel_producator.Text + "' , sediu_central = null WHERE CUI = '" + CUI_producator.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                }
                else if ((string.IsNullOrWhiteSpace(Sediu_central.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE producatori SET nume_producator = '" + Nume_producator.Text + "', an_infiintare = '" + An_producator.Text + "', numar_telefon = '" + Tel_producator.Text + "', sediu_central = null WHERE CUI = '" + CUI_producator.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                }
               
                else if (string.IsNullOrWhiteSpace(An_producator.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE producatori SET nume_producator = '" + Nume_producator.Text + "', an_infiintare = null, numar_telefon = '" + Tel_producator.Text + "', sediu_central = '" + Sediu_central.Text + "' WHERE CUI = '" + CUI_producator.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                }
                else
                {/*
                    if (!(CUI_vechi.Equals(CUI_producator.Text)))
                    {
                        Con.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE producatori SET  nume_producator = '" + Nume_producator.Text + "', an_infiintare = '" + An_producator.Text + "', CUI = '" + CUI_producator.Text + "', sediu_central = '" + Sediu_central.Text + "'  WHERE numar_telefon = '" + Tel_producator.Text + "';", Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datele au fost modificate cu succes");

                        Con.Close();
                        populate();
                    }
                    else
                    {*/
                    Con.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE producatori SET nume_producator = '" + Nume_producator.Text + "', an_infiintare = '" + An_producator.Text + "', numar_telefon = '" + Tel_producator.Text + "', sediu_central = '" + Sediu_central.Text + "'  WHERE CUI = '" + CUI_producator.Text + "';", Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datele au fost modificate cu succes");

                        Con.Close();
                        populate();
                    //}
                }
            }
            catch
            {
                MessageBox.Show("Datele introduse sunt gresite. Modificarea nu a avut succes");
                Con.Close();
            }

        }

        private void DeleteProducator_Click(object sender, EventArgs e)
        {
            Con.Open();
            string MyQuery = "DELETE FROM producatori WHERE CUI = '" + CUI_producator.Text + "'";
            SqlCommand cmd = new SqlCommand(MyQuery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Datele au fost șterse cu succes");

            Con.Close();
            populate();
        }

        private void Producatori_Load(object sender, EventArgs e)
        {
        }

        private void DateProducator_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CUI_producator.Text = DateProducator.SelectedRows[0].Cells[0].Value.ToString();
            Nume_producator.Text = DateProducator.SelectedRows[0].Cells[1].Value.ToString();
            An_producator.Text = DateProducator.SelectedRows[0].Cells[2].Value.ToString();
            Tel_producator.Text = DateProducator.SelectedRows[0].Cells[3].Value.ToString();
            Sediu_central.Text = DateProducator.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Cautare_producatori_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_producatori.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM producatori WHERE lower(nume_producator) LIKE '%" + keyword + "%' OR an_infiintare LIKE '%" + keyword + "%' OR sediu_central LIKE '%" + keyword + "%' OR CUI LIKE '%" + keyword + "%' OR numar_telefon LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DateProducator.DataSource = dt;

            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
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
