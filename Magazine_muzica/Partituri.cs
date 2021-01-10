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
    public partial class Partituri : Form
    {
        public Partituri()
        {
            InitializeComponent();
            Tip_sortare.SelectedIndex = 0;
            Sortare_coloana.SelectedIndex = 0;
            Sortare_coloana_vizualizare.SelectedIndex = 0;
            Tip_sortare_viz.SelectedIndex = 0;
            populatePartituri();
            populateViz();
            findIDEditura();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HGD9B6P;Initial Catalog=Magazine_muzica;Integrated Security=True");

        private void populatePartituri()
        {
            if (Tip_sortare.Text == "desc")
            {
                Con.Open();
                string Myquery = "select * from partituri order by '" + Sortare_coloana.Text + "' desc;";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                DatePartituri.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                if (Sortare_coloana.Text == "ISMN")
                {
                    Con.Open();
                    string Myquery = "select * from partituri order by ISMN;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DatePartituri.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "nume_partitura")
                {
                    Con.Open();
                    string Myquery = "select * from partituri order by nume_partitura;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DatePartituri.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "an_tiparire")
                {
                    Con.Open();
                    string Myquery = "select * from partituri order by an_tiparire;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DatePartituri.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "an_recomandat")
                {
                    Con.Open();
                    string Myquery = "select * from partituri order by an_recomandat;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DatePartituri.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "tip_partitura")
                {
                    Con.Open();
                    string Myquery = "select * from partituri order by tip_partitura;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DatePartituri.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string Myquery = "select * from partituri order by id_editura;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DatePartituri.DataSource = ds.Tables[0];
                    Con.Close();
                }
            }

        }

        private void populateViz()
        {
            if (Tip_sortare_viz.Text == "desc")
            {
                Con.Open();
                string Myquery = "select * from v_partituri order by '" + Sortare_coloana_vizualizare.Text + "' desc;";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                DateVizualizare.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                if (Sortare_coloana_vizualizare.Text == "ISMN")
                {
                    Con.Open();
                    string Myquery = "select * from v_partituri order by ISMN;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateVizualizare.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana_vizualizare.Text == "nume_partitura")
                {
                    Con.Open();
                    string Myquery = "select * from v_partituri order by nume_partitura;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateVizualizare.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana_vizualizare.Text == "an_tiparire")
                {
                    Con.Open();
                    string Myquery = "select * from v_partituri order by an_tiparire;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateVizualizare.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana_vizualizare.Text == "tip_partitura")
                {
                    Con.Open();
                    string Myquery = "select * from v_partituri order by tip_partitura;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateVizualizare.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana_vizualizare.Text == "an_recomandat")
                {
                    Con.Open();
                    string Myquery = "select * from v_partituri order by an_recomandat;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateVizualizare.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana_vizualizare.Text == "id_editura")
                {
                    Con.Open();
                    string Myquery = "select * from v_partituri order by id_editura;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateVizualizare.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string Myquery = "select * from v_partituri order by nume_editura;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateVizualizare.DataSource = ds.Tables[0];
                    Con.Close();
                }
            }


        }

        private void findIDEditura()
        {
            Con.Open();
            string Myquery = "select id_editura, nume_editura from edituri;";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Date_IDEdituri.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Meniu meniu = new Meniu();
            meniu.Show();
            this.Hide();
        }

        private void DatePartituri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ISMN.Text = DatePartituri.SelectedRows[0].Cells[0].Value.ToString();
            Nume_partitura.Text = DatePartituri.SelectedRows[0].Cells[1].Value.ToString();
            Tip_partitura.Text = DatePartituri.SelectedRows[0].Cells[2].Value.ToString();
            An_tiparire.Text = DatePartituri.SelectedRows[0].Cells[3].Value.ToString();
            An_recomandat.Text = DatePartituri.SelectedRows[0].Cells[4].Value.ToString();
            ID_editura.Text = DatePartituri.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void InsertPartitura_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ISMN.Text) || string.IsNullOrWhiteSpace(Nume_partitura.Text))
                {
                    MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a fost realizata.");

                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura, an_recomandat) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + An_recomandat.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura, an_tiparire) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + An_tiparire.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura, tip_partitura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura, an_recomandat, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + An_recomandat.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura, an_tiparire, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + An_tiparire.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura, an_tiparire, an_recomandat) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + An_tiparire.Text + "', '" + An_recomandat.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura, tip_partitura, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura, tip_partitura, an_recomandat) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "', '" + An_recomandat.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura, tip_partitura, an_tiparire) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "', '" + An_tiparire.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if (string.IsNullOrWhiteSpace(Tip_partitura.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura, an_tiparire, an_recomandat, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + An_tiparire.Text + "', '" + An_recomandat.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if (string.IsNullOrWhiteSpace(An_tiparire.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura, tip_partitura, an_recomandat, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "', '" + An_recomandat.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if (string.IsNullOrWhiteSpace(An_recomandat.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura, tip_partitura, an_tiparire, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "', '" + An_tiparire.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if (string.IsNullOrWhiteSpace(ID_editura.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura, tip_partitura, an_tiparire, an_recomandat) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "', '" + An_tiparire.Text + "', '" + An_recomandat.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else
                {

                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri (ISMN, nume_partitura, tip_partitura, an_tiparire, an_recomandat, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "', '" + An_tiparire.Text + "', '" + An_recomandat.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
            }
            catch
            {
                MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a fost realizata.");
                Con.Close();
            }
        }

        private void UpdatePartitura_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(ISMN.Text) || string.IsNullOrWhiteSpace(Nume_partitura.Text))
                {
                    MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a fost realizata.");

                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = null, an_recomandat = null, id_editura = null  WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes toate null");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = null, an_recomandat = null, id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();

                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = null, an_recomandat = '" + An_recomandat.Text + "', id_editura = null WHERE ISMN = '" + ISMN.Text + "' ;", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();

                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = '" + An_tiparire.Text + "', an_recomandat = null, id_editura = null WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();

                }
                else if ((string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = null, an_recomandat = null, id_editura = null WHERE ISMN = '" + ISMN.Text + "' ;", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = null, an_recomandat = '" + An_recomandat.Text + "', id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = '" + An_tiparire.Text + "', an_recomandat = null, id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = '" + An_tiparire.Text + "', an_recomandat = '" + An_recomandat.Text + "', id_editura = null WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = null, an_recomandat = null, id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = null, an_recomandat = '" + An_recomandat.Text + "', id_editura = null WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = '" + An_tiparire.Text + "',an_recomandat = null, id_editura = null WHERE ISMN = '" + ISMN.Text + "' ;", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if (string.IsNullOrWhiteSpace(Tip_partitura.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = '" + An_tiparire.Text + "', an_recomandat = '" + An_recomandat.Text + "', id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if (string.IsNullOrWhiteSpace(An_tiparire.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = null,an_recomandat = '" + An_recomandat.Text + "', id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if (string.IsNullOrWhiteSpace(An_recomandat.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = '" + An_tiparire.Text + "', an_recomandat = null, id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if (string.IsNullOrWhiteSpace(ID_editura.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = '" + An_tiparire.Text + "', an_recomandat = '" + An_recomandat.Text + "', id_editura = null WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else
                {

                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = '" + An_tiparire.Text + "', an_recomandat = '" + An_recomandat.Text + "', id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
            }
            catch
            {
                MessageBox.Show("Datele introduse sunt gresite. Modificarea nu a fost realizata.");
                Con.Close();
            }
        }

        private void DeletePartitura_Click(object sender, EventArgs e)
        {
            Con.Open();
            string MyQuery = "DELETE FROM partituri WHERE ISMN = '" + ISMN.Text + "'";
            SqlCommand cmd = new SqlCommand(MyQuery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Datele au fost șterse cu succes");

            Con.Close();
            populatePartituri();
            populateViz();
            findIDEditura();


            Nume_partitura.Text = "";
            ISMN.Text = "";
            An_recomandat.Text = "";
            An_tiparire.Text = "";
            ID_editura.Text = "";
            Tip_partitura.Text = "";
        }

        private void Cautare_partitura_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_partitura.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM partituri WHERE lower(nume_partitura) LIKE '%" + keyword + "%' OR lower(tip_partitura) LIKE '%" + keyword + "%' OR an_tiparire LIKE '%" + keyword + "%' OR an_recomandat LIKE '%" + keyword + "%' OR ISMN LIKE '%" + keyword + "%' OR id_editura LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DatePartituri.DataSource = dt;

            Con.Close();
        }

        private void Cautare_IDEditura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_editura.Text = Date_IDEdituri.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void CautareIDEditura_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = CautareIDEditura.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT id_editura, nume_editura FROM edituri WHERE lower(nume_editura) LIKE '%" + keyword + "%' OR id_editura LIKE '%" + keyword + "%'", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            Date_IDEdituri.DataSource = dt;

            Con.Close();
        }

        private void Partituri_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Vizualizare_CheckedChanged(object sender, EventArgs e)
        {
            if(Vizualizare.Checked == true)
            {
                DateVizualizare.Show();
                Insert_viz.Show();
                Delete_viz.Show();
                Update_viz.Show();
                Cautare_viz.Show();
                Sortare_coloana_vizualizare.Show();
                Tip_sortare_viz.Show();

            }
            else
            {
                DateVizualizare.Hide();
                Insert_viz.Hide();
                Delete_viz.Hide();
                Update_viz.Hide();
                Cautare_viz.Hide();
                Sortare_coloana_vizualizare.Hide();
                Tip_sortare_viz.Hide();
            }
        }

        private void Insert_viz_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(ISMN.Text) || string.IsNullOrWhiteSpace(Nume_partitura.Text))
                {
                    MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a fost realizata.");

                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura, an_recomandat) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + An_recomandat.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura, an_tiparire) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + An_tiparire.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura, tip_partitura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura, an_recomandat, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + An_recomandat.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura, an_tiparire, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + An_tiparire.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura, an_tiparire, an_recomandat) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + An_tiparire.Text + "', '" + An_recomandat.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura, tip_partitura, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura, tip_partitura, an_recomandat) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "', '" + An_recomandat.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populateViz();
                    findIDEditura();
                    populatePartituri();
                }
                else if ((string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura, tip_partitura, an_tiparire) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "', '" + An_tiparire.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if (string.IsNullOrWhiteSpace(Tip_partitura.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura, an_tiparire, an_recomandat, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + An_tiparire.Text + "', '" + An_recomandat.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populateViz();
                    findIDEditura();
                    populatePartituri();
                }
                else if (string.IsNullOrWhiteSpace(An_tiparire.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura, tip_partitura, an_recomandat, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "', '" + An_recomandat.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if (string.IsNullOrWhiteSpace(An_recomandat.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura, tip_partitura, an_tiparire, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "', '" + An_tiparire.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populateViz();
                    findIDEditura();
                    populatePartituri();
                }
                else if (string.IsNullOrWhiteSpace(ID_editura.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura, tip_partitura, an_tiparire, an_recomandat) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "', '" + An_tiparire.Text + "', '" + An_recomandat.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else
                {

                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_partituri (ISMN, nume_partitura, tip_partitura, an_tiparire, an_recomandat, id_editura) VALUES ('" + ISMN.Text + "', '" + Nume_partitura.Text + "', '" + Tip_partitura.Text + "', '" + An_tiparire.Text + "', '" + An_recomandat.Text + "', '" + ID_editura.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
            }
            catch
            {
                MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a fost realizata.");
                Con.Close();
            }
        }

        private void Update_viz_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ISMN.Text) || string.IsNullOrWhiteSpace(Nume_partitura.Text))
                {
                    MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a fost realizata.");

                }
                if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = null, an_recomandat = null, id_editura = null  WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes toate null");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = null, an_recomandat = null, id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();

                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = null, an_recomandat = '" + An_recomandat.Text + "', id_editura = null WHERE ISMN = '" + ISMN.Text + "' ;", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();

                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = '" + An_tiparire.Text + "', an_recomandat = null, id_editura = null WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populateViz();
                    findIDEditura();
                    populatePartituri();

                }
                else if ((string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = null, an_recomandat = null, id_editura = null WHERE ISMN = '" + ISMN.Text + "' ;", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_tiparire.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = null, an_recomandat = '" + An_recomandat.Text + "', id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populatePartituri();
                    populateViz();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = '" + An_tiparire.Text + "', an_recomandat = null, id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(Tip_partitura.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = '" + An_tiparire.Text + "', an_recomandat = '" + An_recomandat.Text + "', id_editura = null WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(An_recomandat.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = null, an_recomandat = null, id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(An_tiparire.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = null, an_recomandat = '" + An_recomandat.Text + "', id_editura = null WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if ((string.IsNullOrWhiteSpace(An_recomandat.Text)) && (string.IsNullOrWhiteSpace(ID_editura.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = '" + An_tiparire.Text + "',an_recomandat = null, id_editura = null WHERE ISMN = '" + ISMN.Text + "' ;", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if (string.IsNullOrWhiteSpace(Tip_partitura.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = null, an_tiparire = '" + An_tiparire.Text + "', an_recomandat = '" + An_recomandat.Text + "', id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if (string.IsNullOrWhiteSpace(An_tiparire.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = null,an_recomandat = '" + An_recomandat.Text + "', id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if (string.IsNullOrWhiteSpace(An_recomandat.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = '" + An_tiparire.Text + "', an_recomandat = null, id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else if (string.IsNullOrWhiteSpace(ID_editura.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = '" + An_tiparire.Text + "', an_recomandat = '" + An_recomandat.Text + "', id_editura = null WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populateViz();
                    populatePartituri();
                    findIDEditura();
                }
                else
                {

                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_partituri SET nume_partitura = '" + Nume_partitura.Text + "', tip_partitura = '" + Tip_partitura.Text + "', an_tiparire = '" + An_tiparire.Text + "', an_recomandat = '" + An_recomandat.Text + "', id_editura = '" + ID_editura.Text + "' WHERE ISMN = '" + ISMN.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populateViz();

                    populatePartituri();
                    findIDEditura();
                }
            }
            catch
            {
                MessageBox.Show("Datele introduse sunt gresite. Modificarea nu a fost realizata.");
                Con.Close();
            }
        }

        private void Delete_viz_Click(object sender, EventArgs e)
        {
            Con.Open();
            string MyQuery = "DELETE FROM partituri WHERE ISMN = '" + ISMN.Text + "'";
            SqlCommand cmd = new SqlCommand(MyQuery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Datele au fost șterse cu succes");

            Con.Close();
            populatePartituri();
            populateViz();
            findIDEditura();

            Nume_partitura.Text = "";
            ISMN.Text = "";
            An_recomandat.Text = "";
            An_tiparire.Text = "";
            ID_editura.Text = "";
            Tip_partitura.Text = "";
        }

        private void DateVizualizare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ISMN.Text = DateVizualizare.SelectedRows[0].Cells[0].Value.ToString();
            Nume_partitura.Text = DateVizualizare.SelectedRows[0].Cells[1].Value.ToString();
            Tip_partitura.Text = DateVizualizare.SelectedRows[0].Cells[2].Value.ToString();
            An_tiparire.Text = DateVizualizare.SelectedRows[0].Cells[3].Value.ToString();
            An_recomandat.Text = DateVizualizare.SelectedRows[0].Cells[4].Value.ToString();
            ID_editura.Text = DateVizualizare.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void Cautare_viz_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_viz.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM v_partituri WHERE lower(nume_partitura) LIKE '%" + keyword + "%' OR lower(tip_partitura) LIKE '%" + keyword + "%' OR an_tiparire LIKE '%" + keyword + "%' OR an_recomandat LIKE '%" + keyword + "%' OR ISMN LIKE '%" + keyword + "%' OR id_editura LIKE '%" + keyword + "%' OR lower(nume_editura) LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DateVizualizare.DataSource = dt;

            Con.Close();

        }

        private void Tip_sortare_viz_SelectedIndexChanged(object sender, EventArgs e)
        {
            populatePartituri();
        }

        private void Sortare_coloana_vizualizare_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateViz();
        }

        private void Sortare_coloana_SelectedIndexChanged(object sender, EventArgs e)
        {
            populatePartituri();
        }

        private void Tip_sortare_viz_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            populateViz();
        }
    }
}


