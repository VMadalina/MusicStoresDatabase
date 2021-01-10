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
    public partial class AccesoriiVandute : Form
    {
        public AccesoriiVandute()
        {
            InitializeComponent();
            Tip_sortare.SelectedIndex = 0;
            Sortare_coloana.SelectedIndex = 0;
            populate();
            findIDEditura();
            findID_Magazin();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HGD9B6P;Initial Catalog=Magazine_muzica;Integrated Security=True");

        private void populate()
        {
            if (Tip_sortare.Text == "desc")
            {
                Con.Open();
                string Myquery = "select * from accesorii_vandute order by '"+Sortare_coloana.Text+"' desc;";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                DateAccesoriiVandute.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                if (Sortare_coloana.Text == "id_accesoriu")
                {
                    Con.Open();
                    string Myquery = "select * from accesorii_vandute order by id_accesoriu;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateAccesoriiVandute.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "id_magazin")
                {
                    Con.Open();
                    string Myquery = "select * from accesorii_vandute order by id_magazin;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateAccesoriiVandute.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "data_achizitiei")
                {
                    Con.Open();
                    string Myquery = "select * from accesorii_vandute order by data_achizitiei;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateAccesoriiVandute.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "pret_accesoriu")
                {
                    Con.Open();
                    string Myquery = "select * from accesorii_vandute order by pret_accesoriu;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateAccesoriiVandute.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string Myquery = "select * from accesorii_vandute order by cantitate_vanduta;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateAccesoriiVandute.DataSource = ds.Tables[0];
                    Con.Close();
                }
            }
          

        }

        private void findIDEditura()
        {
            Con.Open();
            string Myquery = "select * from accesorii;";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DateIDAccesorii.DataSource = ds.Tables[0];
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
            DateIDMagazin.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SearchAccesoriu_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_accesoriu.Text = DateIDAccesorii.SelectedRows[0].Cells[0].Value.ToString();

        }

        private void InsertAccesoriu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Cantitate_vanduta.Text))
            {
                MessageBox.Show("Datele au fost introduse incorect. Modificarea nu a avut loc.");
                Con.Close();
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO accesorii_vandute (id_magazin, id_accesoriu, data_achizitiei, pret_accesoriu, cantitate_vanduta) VALUES ('" + ID_magazin.Text + "', '" + ID_accesoriu.Text + "', '" + Data_achizitie.Text + "', '" + Pret_accesoriu.Text + "', '" + Cantitate_vanduta.Text + "'); ", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost adăugate cu succes!");

                    Con.Close();
                    populate();
                    findIDEditura();
                    findID_Magazin();
                }
                catch
                {
                    MessageBox.Show("Datele introduse sunt greșite. Adăugarea nu a avut loc.");
                    Con.Close();
                }
            }
           
        }

        private void UpdateAccesoriu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Cantitate_vanduta.Text))
            {
                MessageBox.Show("Datele au fost introduse incorect. Modificarea nu a avut loc.");
                Con.Close();
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE accesorii_vandute SET pret_accesoriu = '" + Pret_accesoriu.Text + "', cantitate_vanduta = '" + Cantitate_vanduta.Text + "' WHERE id_magazin = '" + ID_magazin.Text + "' and  id_accesoriu = '" + ID_accesoriu.Text + "' and data_achizitiei = '" + Data_achizitie.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes!");

                    Con.Close();
                    populate();
                    findIDEditura();
                    findID_Magazin();
                }
                catch
                {
                    if (string.IsNullOrWhiteSpace(Pret_accesoriu.Text))
                    {
                        MessageBox.Show("Datele au fost introduse incorect. Modificarea nu a avut loc.");
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data achizitiei, id-ul magazinului și id_ul accesoriului nu pot fi modificate. Dacă totuși doriți să efectuați această operație puteți șterge înregistrarea și adăugați datele noi ca o alta înregistrare.");
                        Con.Close();
                    }

                }
            }
               
        }

        private void DeleteAccesoriu_Click(object sender, EventArgs e)
        {
            Con.Open();
            string MyQuery = "DELETE FROM accesorii_vandute WHERE id_magazin = '" + ID_magazin.Text + "' and id_accesoriu = '" + ID_accesoriu.Text + "' and data_achizitiei = '" + Data_achizitie.Text + "'";
            SqlCommand cmd = new SqlCommand(MyQuery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Datele au fost șterse cu succes");

            Con.Close();
            populate();
            findIDEditura();
            findID_Magazin();

            ID_accesoriu.Text = "";
            ID_magazin.Text = "";
            Data_achizitie.Text = "";
            Cantitate_vanduta.Text = "";
            Pret_accesoriu.Text = "";
        }

        private void DateAccesoriiVandute_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_magazin.Text = DateAccesoriiVandute.SelectedRows[0].Cells[0].Value.ToString();
            ID_accesoriu.Text = DateAccesoriiVandute.SelectedRows[0].Cells[1].Value.ToString();
            Data_achizitie.Text = DateAccesoriiVandute.SelectedRows[0].Cells[2].Value.ToString();
            Pret_accesoriu.Text = DateAccesoriiVandute.SelectedRows[0].Cells[3].Value.ToString();
            Cantitate_vanduta.Text = DateAccesoriiVandute.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void DateIDMagazin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_magazin.Text = DateIDMagazin.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void Cautare_accesoriu_vandut_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_accesoriu_vandut.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM accesorii_vandute WHERE id_magazin LIKE '%" + keyword + "%' OR id_accesoriu LIKE '%" + keyword + "%' OR data_achizitiei LIKE '%" + keyword + "%' OR pret_accesoriu LIKE '%" + keyword + "%' OR cantitate_vanduta LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DateAccesoriiVandute.DataSource = dt;

            Con.Close();
        }

        private void Cautare_ID_accesoriu_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_ID_accesoriu.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM accesorii WHERE id_accesoriu LIKE '%" + keyword + "%' OR lower(nume_accesoriu) LIKE '%" + keyword + "%' OR lower(obiect_compatibil) LIKE '%" + keyword + "%' OR lower(tip_instrument) LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DateIDAccesorii.DataSource = dt;

            Con.Close();
        }

        private void Cautare_ID_magazin_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_ID_magazin.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT id_magazin, nume_magazin FROM magazine WHERE id_magazin LIKE '%" + keyword + "%' OR lower(nume_magazin) LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DateIDMagazin.DataSource = dt;

            Con.Close();
        }

        private void AccesoriiVandute_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Vanzari vanzare_accesoriu = new Vanzari();
            vanzare_accesoriu.Show();
            this.Hide();
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
