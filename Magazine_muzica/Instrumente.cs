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
    public partial class Instrumente : Form
    {
        public Instrumente()
        {
            InitializeComponent();
            Tip_sortare.SelectedIndex = 0;
            Sortare_coloana.SelectedIndex = 0;
            Sortare_coloana_vizualizare.SelectedIndex = 0;
            Tip_sortare_viz.SelectedIndex = 0;
            populate();
            populateViz();
            findCUI();
            findID_Magazin();
            FillCategorie();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HGD9B6P;Initial Catalog=Magazine_muzica;Integrated Security=True");

        private void populate()
        {
            if (Tip_sortare.Text == "desc")
            {
                Con.Open();
                string Myquery = "select * from instrumente order by '" + Sortare_coloana.Text + "' desc;";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                DateInstrumente.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                if (Sortare_coloana.Text == "serie_instrument")
                {

                    Con.Open();
                    string Myquery = "select * from instrumente order by serie_instrument;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateInstrumente.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "nume_instrument")
                {
                    Con.Open();
                    string Myquery = "select * from instrumente order by nume_instrument;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateInstrumente.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "pret_instrument")
                {
                    Con.Open();
                    string Myquery = "select * from instrumente order by pret_instrument;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateInstrumente.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "categorie")
                {
                    Con.Open();
                    string Myquery = "select * from instrumente order by categorie;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateInstrumente.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "CUI")
                {
                    Con.Open();
                    string Myquery = "select * from instrumente order by CUI;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateInstrumente.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string Myquery = "select * from instrumente order by id_magazin;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateInstrumente.DataSource = ds.Tables[0];
                    Con.Close();
                }
            }

        }

        private void populateViz()
        {
            if (Tip_sortare_viz.Text == "desc")
            {
                Con.Open();
                string Myquery = "select * from v_instrumente order by '" + Sortare_coloana_vizualizare.Text + "' desc;";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                DateViz.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                if (Sortare_coloana_vizualizare.Text == "serie_instrument")
                {

                    Con.Open();
                    string Myquery = "select * from v_instrumente order by serie_instrument;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateViz.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana_vizualizare.Text == "nume_instrument")
                {
                    Con.Open();
                    string Myquery = "select * from v_instrumente order by nume_instrument;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateViz.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana_vizualizare.Text == "pret_instrument")
                {
                    Con.Open();
                    string Myquery = "select * from v_instrumente order by pret_instrument;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateViz.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana_vizualizare.Text == "categorie")
                {
                    Con.Open();
                    string Myquery = "select * from v_instrumente order by categorie;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateViz.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana_vizualizare.Text == "CUI")
                {
                    Con.Open();
                    string Myquery = "select * from v_instrumente order by CUI;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateViz.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana_vizualizare.Text == "nume_producator")
                {
                    Con.Open();
                    string Myquery = "select * from v_instrumente order by nume_producator;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateViz.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana_vizualizare.Text == "id_magazin")
                {
                    Con.Open();
                    string Myquery = "select * from v_instrumente order by id_magazin;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateViz.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string Myquery = "select * from v_instrumente order by nume_magazin;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateViz.DataSource = ds.Tables[0];
                    Con.Close();
                }
            }
        }

        private void findCUI()
        {
            Con.Open();
            string Myquery = "select CUI, nume_producator from producatori;";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Date_CUIProducator.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void findID_Magazin()
        {
            Con.Open();
            string Myquery = "select id_magazin, nume_magazin from magazine;";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Date_IDmagazin.DataSource = ds.Tables[0];
            Con.Close();
        }

        void FillCategorie()
        {

            string query = "SELECT distinct categorie FROM instrumente;";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("categorie", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                Categorie_instrument.ValueMember = "categorie";
                Categorie_instrument.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }

        }

        private void UpdateAlbume_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrWhiteSpace(CUI_producator.Text)) && (string.IsNullOrWhiteSpace(ID_magazin.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE instrumente SET nume_instrument = '" + Nume_instrument.Text + "', pret_instrument = '" + Pret_instrument.Text + "', categorie = '" + Categorie_instrument.Text + "', CUI = null, id_magazin = null WHERE serie_instrument = '" + Serie_intrument.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                    populateViz();
                    findCUI();
                    findID_Magazin();
                }
                else if (string.IsNullOrWhiteSpace(CUI_producator.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE instrumente SET nume_instrument = '" + Nume_instrument.Text + "', pret_instrument = '" + Pret_instrument.Text + "', categorie = '" + Categorie_instrument.Text + "', CUI = null, id_magazin = '"+ID_magazin.Text+"' WHERE serie_instrument = '" + Serie_intrument.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                    populateViz();
                    findCUI();
                    findID_Magazin();
                }
                else if (string.IsNullOrWhiteSpace(ID_magazin.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE instrumente SET nume_instrument = '" + Nume_instrument.Text + "', pret_instrument = '" + Pret_instrument.Text + "', categorie = '" + Categorie_instrument.Text + "', CUI = '"+CUI_producator.Text+"', id_magazin = null WHERE serie_instrument = '" + Serie_intrument.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                    populateViz();
                    findCUI();
                    findID_Magazin();
                }
                else
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE instrumente SET nume_instrument = '" + Nume_instrument.Text + "', pret_instrument = '" + Pret_instrument.Text + "', categorie = '" + Categorie_instrument.Text + "', CUI = '" + CUI_producator.Text + "', id_magazin = '" + ID_magazin.Text + "' WHERE serie_instrument = '" + Serie_intrument.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                    populateViz();
                    findCUI();
                    findID_Magazin();
                }
            }
            catch
            {
                MessageBox.Show("Datele introduse sunt gresite. Modificarea nu a avut succes");
                Con.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Meniu meniu = new Meniu();
            meniu.Show();
            this.Hide();
        }

        private void InsertInstrumente_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrWhiteSpace(CUI_producator.Text)) && (string.IsNullOrWhiteSpace(ID_magazin.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO instrumente (serie_instrument, nume_instrument, pret_instrument, categorie) VALUES ('" + Serie_intrument.Text + "', '" + Nume_instrument.Text + "', '" + Pret_instrument.Text + "', '" + Categorie_instrument.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                    populateViz();
                    findCUI();
                    findID_Magazin();
                }
                else if (string.IsNullOrWhiteSpace(CUI_producator.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO instrumente (serie_instrument, nume_instrument, pret_instrument, categorie, id_magazin) VALUES ('" + Serie_intrument.Text + "', '" + Nume_instrument.Text + "', '" + Pret_instrument.Text + "', '" + Categorie_instrument.Text + "', '" + ID_magazin.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                    populateViz();
                    findCUI();
                    findID_Magazin();
                }
                else if (string.IsNullOrWhiteSpace(ID_magazin.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO instrumente (serie_instrument, nume_instrument, pret_instrument, categorie, CUI) VALUES ('" + Serie_intrument.Text + "', '" + Nume_instrument.Text + "', '" + Pret_instrument.Text + "', '" + Categorie_instrument.Text + "', '" + CUI_producator.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                    findCUI();
                    populateViz();
                    findID_Magazin();
                }
                else
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO instrumente (serie_instrument, nume_instrument, pret_instrument, categorie, CUI, id_magazin) VALUES ('" + Serie_intrument.Text + "', '" + Nume_instrument.Text + "', '" + Pret_instrument.Text + "', '" + Categorie_instrument.Text + "', '" + CUI_producator.Text + "', '" + ID_magazin.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                    populateViz();
                    findCUI();
                    findID_Magazin();
                }

            }
            catch
            {
                MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a avut succes");
                Con.Close();
            }
        }

        private void DeleteIntrumente_Click(object sender, EventArgs e)
        {
            Con.Open();
            string MyQuery = "DELETE FROM instrumente WHERE serie_instrument = '" + Serie_intrument.Text + "'";
            SqlCommand cmd = new SqlCommand(MyQuery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Datele au fost șterse cu succes");

            Con.Close();
            populate();
            findCUI();
            populateViz();
            findID_Magazin();

            Serie_intrument.Text = "";
            Nume_instrument.Text = "";
            Categorie_instrument.Text = "";
            ID_magazin.Text = "";
            Pret_instrument.Text = "";
            CUI_producator.Text = "";
        }

        private void DateInstrumente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Serie_intrument.Text = DateInstrumente.SelectedRows[0].Cells[0].Value.ToString();
            Nume_instrument.Text = DateInstrumente.SelectedRows[0].Cells[1].Value.ToString();
            Pret_instrument.Text = DateInstrumente.SelectedRows[0].Cells[2].Value.ToString();
            Categorie_instrument.Text = DateInstrumente.SelectedRows[0].Cells[3].Value.ToString();
            CUI_producator.Text = DateInstrumente.SelectedRows[0].Cells[4].Value.ToString();
            ID_magazin.Text = DateInstrumente.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Cautare_instrumente_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_instrumente.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM instrumente WHERE lower(nume_instrument) LIKE '%" + keyword + "%' OR lower(categorie) LIKE '%" + keyword + "%' OR pret_instrument LIKE '%" + keyword + "%' OR serie_instrument LIKE '%" + keyword + "%' OR CUI LIKE '%" + keyword + "%' OR id_magazin LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DateInstrumente.DataSource = dt;

            Con.Close();
        }

        private void Date_CUIProducator_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CUI_producator.Text = Date_CUIProducator.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void Date_IDmagazin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_magazin.Text = Date_IDmagazin.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void Instrumente_Load(object sender, EventArgs e)
        {

        }

        private void Cautare_CUI_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_CUI.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT CUI, nume_producator FROM producatori WHERE lower(nume_producator) LIKE '%" + keyword + "%' OR CUI LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            Date_CUIProducator.DataSource = dt;

            Con.Close();
        }

        private void Cautare_ID_magazin_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_ID_magazin.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT id_magazin, nume_magazin FROM magazine WHERE lower(nume_magazin) LIKE '%" + keyword + "%' OR id_magazin LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            Date_IDmagazin.DataSource = dt;

            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Vizualizare_CheckedChanged(object sender, EventArgs e)
        {
            if (Vizualizare.Checked == true)
            {
                DateViz.Show();
                Insert_viz.Show();
                Delete_viz.Show();
                Update_viz.Show();
                Cautare_viz.Show();
                Sortare_coloana_vizualizare.Show();
                Tip_sortare_viz.Show();
            }
            else
            {
                DateViz.Hide();
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
                if ((string.IsNullOrWhiteSpace(CUI_producator.Text)) && (string.IsNullOrWhiteSpace(ID_magazin.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_instrumente (serie_instrument, nume_instrument, pret_instrument, categorie) VALUES ('" + Serie_intrument.Text + "', '" + Nume_instrument.Text + "', '" + Pret_instrument.Text + "', '" + Categorie_instrument.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                    populateViz();
                    findCUI();
                    findID_Magazin();
                }
                else if (string.IsNullOrWhiteSpace(CUI_producator.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_instrumente (serie_instrument, nume_instrument, pret_instrument, categorie, id_magazin) VALUES ('" + Serie_intrument.Text + "', '" + Nume_instrument.Text + "', '" + Pret_instrument.Text + "', '" + Categorie_instrument.Text + "', '" + ID_magazin.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                    populateViz();
                    findCUI();
                    findID_Magazin();
                }
                else if (string.IsNullOrWhiteSpace(ID_magazin.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_instrumente (serie_instrument, nume_instrument, pret_instrument, categorie, CUI) VALUES ('" + Serie_intrument.Text + "', '" + Nume_instrument.Text + "', '" + Pret_instrument.Text + "', '" + Categorie_instrument.Text + "', '" + CUI_producator.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                    populateViz();
                    findCUI();
                    findID_Magazin();
                }
                else
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO v_instrumente (serie_instrument, nume_instrument, pret_instrument, categorie, CUI, id_magazin) VALUES ('" + Serie_intrument.Text + "', '" + Nume_instrument.Text + "', '" + Pret_instrument.Text + "', '" + Categorie_instrument.Text + "', '" + CUI_producator.Text + "', '" + ID_magazin.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                    populateViz();
                    findCUI();
                    findID_Magazin();
                }

            }
            catch
            {
                MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a avut succes");
                Con.Close();
            }
        }

        private void Update_viz_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrWhiteSpace(CUI_producator.Text)) && (string.IsNullOrWhiteSpace(ID_magazin.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_instrumente SET nume_instrument = '" + Nume_instrument.Text + "', pret_instrument = '" + Pret_instrument.Text + "', categorie = '" + Categorie_instrument.Text + "', CUI = null, id_magazin = null WHERE serie_instrument = '" + Serie_intrument.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                    populateViz();
                    findCUI();
                    findID_Magazin();
                }
                else if (string.IsNullOrWhiteSpace(CUI_producator.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_instrumente SET nume_instrument = '" + Nume_instrument.Text + "', pret_instrument = '" + Pret_instrument.Text + "', categorie = '" + Categorie_instrument.Text + "', CUI = null, id_magazin = '" + ID_magazin.Text + "' WHERE serie_instrument = '" + Serie_intrument.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                    populateViz();
                    findCUI();
                    findID_Magazin();
                }
                else if (string.IsNullOrWhiteSpace(ID_magazin.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_instrumente SET nume_instrument = '" + Nume_instrument.Text + "', pret_instrument = '" + Pret_instrument.Text + "', categorie = '" + Categorie_instrument.Text + "', CUI = '" + CUI_producator.Text + "', id_magazin = null WHERE serie_instrument = '" + Serie_intrument.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                    populateViz();
                    findCUI();
                    findID_Magazin();
                }
                else
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE v_instrumente SET nume_instrument = '" + Nume_instrument.Text + "', pret_instrument = '" + Pret_instrument.Text + "', categorie = '" + Categorie_instrument.Text + "', CUI = '" + CUI_producator.Text + "', id_magazin = '" + ID_magazin.Text + "' WHERE serie_instrument = '" + Serie_intrument.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                    populateViz();
                    findCUI();
                    findID_Magazin();
                }
            }
            catch
            {
                MessageBox.Show("Datele introduse sunt gresite. Modificarea nu a avut succes");
                Con.Close();
            }

        }

        private void Delete_viz_Click(object sender, EventArgs e)
        {
            Con.Open();
            string MyQuery = "DELETE FROM instrumente WHERE serie_instrument = '" + Serie_intrument.Text + "'";
            SqlCommand cmd = new SqlCommand(MyQuery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Datele au fost șterse cu succes");

            Con.Close();
            populate();
            populateViz();
            findCUI();
            findID_Magazin();


            Serie_intrument.Text = "";
            Nume_instrument.Text = "";
            Categorie_instrument.Text = "";
            ID_magazin.Text = "";
            Pret_instrument.Text = "";
            CUI_producator.Text = "";
        }

        private void DateViz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Serie_intrument.Text = DateViz.SelectedRows[0].Cells[0].Value.ToString();
            Nume_instrument.Text = DateViz.SelectedRows[0].Cells[1].Value.ToString();
            Pret_instrument.Text = DateViz.SelectedRows[0].Cells[2].Value.ToString();
            Categorie_instrument.Text = DateViz.SelectedRows[0].Cells[3].Value.ToString();
            CUI_producator.Text = DateViz.SelectedRows[0].Cells[4].Value.ToString();
            ID_magazin.Text = DateViz.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void Cautare_viz_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_viz.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM v_instrumente WHERE lower(nume_instrument) LIKE '%" + keyword + "%' OR lower(categorie) LIKE '%" + keyword + "%' OR pret_instrument LIKE '%" + keyword + "%' OR serie_instrument LIKE '%" + keyword + "%' OR CUI LIKE '%" + keyword + "%' OR id_magazin LIKE '%" + keyword + "%' OR lower(nume_producator) LIKE '%" + keyword + "%' OR lower(nume_magazin) LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DateViz.DataSource = dt;

            Con.Close();

        }

        private void Sortare_coloana_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate();
        }

        private void Tip_sortare_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sortare_coloana_vizualizare_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateViz();
        }

        private void Tip_sortare_viz_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateViz();
        }
    }
}
