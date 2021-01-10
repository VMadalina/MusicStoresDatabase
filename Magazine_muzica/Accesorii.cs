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
    public partial class Accesorii : Form
    {
        public Accesorii()
        {
            InitializeComponent();
            Tip_sortare.SelectedIndex = 0;
            Sortare_coloana.SelectedIndex = 0;
            populate();
            FillTipInstrument();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HGD9B6P;Initial Catalog=Magazine_muzica;Integrated Security=True");

        private void populate()
        { 
            
            if (Tip_sortare.Text == "desc")
            {
                Con.Open();
                string Myquery = "select * from accesorii order by '"+Sortare_coloana.Text+"' desc;";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                DateAccesorii.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                if(Sortare_coloana.Text == "id_accesoriu")
                {
                    Con.Open();

                    string Myquery = "select * from accesorii order by id_accesoriu;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateAccesorii.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if(Sortare_coloana.Text == "nume_accesoriu")
                {
                    Con.Open();

                    string Myquery = "select * from accesorii order by nume_accesoriu;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateAccesorii.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if(Sortare_coloana.Text == "obiect_compatibil")
                {
                    Con.Open();

                    string Myquery = "select * from accesorii order by nume_accesoriu;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateAccesorii.DataSource = ds.Tables[0];
                    Con.Close();                  
                }
                else
                {
                    Con.Open();

                    string Myquery = "select * from accesorii order by tip_instrument;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DateAccesorii.DataSource = ds.Tables[0];
                    Con.Close();
                }
            }
          
        }
       
        void FillTipInstrument()
        {
            
            string query = "SELECT distinct tip_instrument FROM accesorii;";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("tip_instrument", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                Tip_instrument.ValueMember = "tip_instrument";
                Tip_instrument.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }

        }

        private void DeleteEdituri_Click(object sender, EventArgs e)
        {

            Con.Open();
            string MyQuery = "DELETE FROM accesorii WHERE id_accesoriu = '" + ID_accesoriu.Text + "'";
            SqlCommand cmd = new SqlCommand(MyQuery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Datele au fost șterse cu succes");

            Con.Close();
            populate();

            ID_accesoriu.Text = "";
            Nume_accesoriu.Text = "";
            Obiect_compatibil.Text = "";
            Tip_instrument.Text = "";
        }

        private void InsertEditura_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(Nume_accesoriu.Text))
                {
                    MessageBox.Show("Datele introduse sunt gresite. Adaugarea nu a fost realizata.");
                }
                else if ((string.IsNullOrWhiteSpace(Obiect_compatibil.Text)) && (string.IsNullOrWhiteSpace(Tip_instrument.Text)))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO accesorii (nume_accesoriu) VALUES ('" + Nume_accesoriu.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                }
                else if (string.IsNullOrWhiteSpace(Tip_instrument.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO accesorii (nume_accesoriu, obiect_compatibil) VALUES ('" + Nume_accesoriu.Text + "', '" + Obiect_compatibil.Text + "');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes");

                    Con.Close();
                    populate();
                }
                else if (string.IsNullOrWhiteSpace(Obiect_compatibil.Text))
                {
                    if(string.IsNullOrWhiteSpace(Tip_instrument.Text))
                    {
                        Con.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO accesorii (nume_accesoriu) VALUES ('" + Nume_accesoriu.Text + "');", Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datele au fost introduse cu succes");

                        Con.Close();
                        populate();
                    }
                    else
                    {
                        MessageBox.Show("Campul pentru obiectul compatibil nu este completat!");

                        Con.Close();
                    }
                }
                else
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO accesorii (nume_accesoriu, obiect_compatibil, tip_instrument) VALUES ('" + Nume_accesoriu.Text + "', '" + Obiect_compatibil.Text + "','" + Tip_instrument.Text + "');", Con);
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

        private void DateAccesorii_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_accesoriu.Text = DateAccesorii.SelectedRows[0].Cells[0].Value.ToString();
            Nume_accesoriu.Text = DateAccesorii.SelectedRows[0].Cells[1].Value.ToString();
            Obiect_compatibil.Text = DateAccesorii.SelectedRows[0].Cells[2].Value.ToString();
            Tip_instrument.Text = DateAccesorii.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Meniu meniu = new Meniu();
            meniu.Show();
            this.Hide();
        }

        private void UpdateAccesoriu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Nume_accesoriu.Text))
                { 
                    MessageBox.Show("Datele introduse sunt gresite!");
                }
                else if (string.IsNullOrWhiteSpace(Tip_instrument.Text) && string.IsNullOrWhiteSpace(Obiect_compatibil.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE accesorii SET nume_accesoriu = '" + Nume_accesoriu.Text + "', obiect_compatibil = null, tip_instrument = null WHERE id_accesoriu = '" + ID_accesoriu.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                }
                else if (string.IsNullOrWhiteSpace(Tip_instrument.Text))
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE accesorii SET nume_accesoriu = '" + Nume_accesoriu.Text + "', obiect_compatibil = '" + Obiect_compatibil.Text + "', tip_instrument = null WHERE id_accesoriu = '" + ID_accesoriu.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                }
                else if (string.IsNullOrWhiteSpace(Obiect_compatibil.Text))
                {
                    if(string.IsNullOrWhiteSpace(Tip_instrument.Text))
                    {
                        Con.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE accesorii SET nume_accesoriu = '" + Nume_accesoriu.Text + "', obiect_compatibil = null, tip_instrument = '" + Tip_instrument.Text + "' WHERE id_accesoriu = '" + ID_accesoriu.Text + "';", Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datele au fost modificate cu succes");

                        Con.Close();
                        populate();
                    }
                    else
                    {
                        MessageBox.Show("Campul pentru obiectul compatibil nu este completat!");

                        Con.Close();
                    }
                }
                else
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE accesorii SET nume_accesoriu = '" + Nume_accesoriu.Text + "', obiect_compatibil = '" + Obiect_compatibil.Text + "', tip_instrument = '" + Tip_instrument.Text + "' WHERE id_accesoriu = '" + ID_accesoriu.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes");

                    Con.Close();
                    populate();
                }
            }
             catch
            {
                MessageBox.Show("Datele au fost introduse gresit. Modificarea nu a avut loc");
                Con.Close();
            }
        }

        private void Cautare_accesorii_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_accesorii.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM accesorii WHERE lower(nume_accesoriu) LIKE '%" + keyword + "%' OR obiect_compatibil LIKE '%" + keyword + "%' OR tip_instrument LIKE '%" + keyword + "%' OR id_accesoriu LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DateAccesorii.DataSource = dt;

            Con.Close();
        }

        private void Accesorii_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Tip_instrument_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void SearchAccesoriu_Click(object sender, EventArgs e)
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

