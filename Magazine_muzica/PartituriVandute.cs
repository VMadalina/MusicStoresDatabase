﻿using System;
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
    public partial class PartituriVandute : Form
    {
        public PartituriVandute()
        {
            InitializeComponent();
            Tip_sortare.SelectedIndex = 0;
            Sortare_coloana.SelectedIndex = 0;
            populate();
            findISMN();
            findID_Magazin();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HGD9B6P;Initial Catalog=Magazine_muzica;Integrated Security=True");

        private void populate()
        {
            if (Tip_sortare.Text == "desc")
            {
                Con.Open();
                string Myquery = "select * from partituri_vandute order by '" + Sortare_coloana.Text + "' desc;";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                DatePartituriVandute.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                if (Sortare_coloana.Text == "ISMN")
                {
                    Con.Open();
                    string Myquery = "select * from partituri_vandute order by ISMN;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DatePartituriVandute.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "id_magazin")
                {
                    Con.Open();
                    string Myquery = "select * from partituri_vandute order by id_magazin;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DatePartituriVandute.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "data_achizitiei")
                {
                    Con.Open();
                    string Myquery = "select * from partituri_vandute order by data_achizitiei;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DatePartituriVandute.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else if (Sortare_coloana.Text == "pret_partitura")
                {
                    Con.Open();
                    string Myquery = "select * from partituri_vandute order by pret_partitura;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DatePartituriVandute.DataSource = ds.Tables[0];
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string Myquery = "select * from partituri_vandute order by cantitate_vanduta;";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    DatePartituriVandute.DataSource = ds.Tables[0];
                    Con.Close();
                }
            }

        }

        private void findISMN()
        {
            Con.Open();
            string Myquery = "select ISMN, nume_partitura from partituri;";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DateISMN.DataSource = ds.Tables[0];
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

        private void PartituriVandute_Load(object sender, EventArgs e)
        {

        }

        private void InsertPartitura_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(Cantitate_vanduta.Text))
            {
                MessageBox.Show("Datele au fost introduse incorect. Adaugarea nu a avut loc.");
                Con.Close();
            }
            else if (string.IsNullOrWhiteSpace(Pret_partitura.Text))
            {
                MessageBox.Show("Datele au fost introduse incorect. Adaugarea nu a avut loc.");
                Con.Close();
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO partituri_vandute VALUES ('"+ID_magazin.Text+"', '"+ISMN_partitura.Text+"', '"+Data_achizitie.Text+"', '"+Pret_partitura.Text+"', '"+Cantitate_vanduta.Text+"');", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost adăugate cu succes!");

                    Con.Close();
                    populate();
                    findISMN();
                    findID_Magazin();
                }
                catch
                {
                    MessageBox.Show("Datele introduse sunt greșite. Adăugarea nu a avut loc.");
                    Con.Close();
                }
            }
        }

        private void UpdatePartitura_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Cantitate_vanduta.Text))
            {
                MessageBox.Show("Datele au fost introduse incorect. Modificarea nu a avut loc.");
                Con.Close();
            }
            else if(string.IsNullOrWhiteSpace(Pret_partitura.Text))
            {
                MessageBox.Show("Datele au fost introduse incorect. Modificarea nu a avut loc.");
                Con.Close();
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE partituri_vandute SET pret_partitura = '" + Pret_partitura.Text + "', cantitate_vanduta = '" + Cantitate_vanduta.Text + "' WHERE id_magazin = '" + ID_magazin.Text + "' and  ISMN = '" + ISMN_partitura.Text + "' and data_achizitiei = '" + Data_achizitie.Text + "';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate cu succes!");

                    Con.Close();
                    populate();
                    findISMN();
                    findID_Magazin();
                }
                catch
                {
                        MessageBox.Show("Datele au fost introduse incorect. Modificarea nu a avut loc.");
                        MessageBox.Show("Data achizitiei, id-ul magazinului și id_ul accesoriului nu pot fi modificate. Dacă totuși doriți să efectuați această operație puteți șterge înregistrarea și adăugați datele noi ca o alta înregistrare.");

                        Con.Close();

                }
            }
        }

        private void DeletePartitura_Click(object sender, EventArgs e)
        {
            Con.Open();
            string MyQuery = "DELETE FROM partituri_vandute WHERE id_magazin = '" + ID_magazin.Text + "' and ISMN = '" + ISMN_partitura.Text + "' and data_achizitiei = '" + Data_achizitie.Text + "'";
            SqlCommand cmd = new SqlCommand(MyQuery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Datele au fost șterse cu succes");

            Con.Close();
            populate();
            findISMN();
            findID_Magazin();


            ID_magazin.Text = "";
            ISMN_partitura.Text = "";
            Data_achizitie.Text = "";
            Cantitate_vanduta.Text = "";
            Pret_partitura.Text = "";
        }

        private void DatePartituriVandute_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_magazin.Text = DatePartituriVandute.SelectedRows[0].Cells[0].Value.ToString();
            ISMN_partitura.Text = DatePartituriVandute.SelectedRows[0].Cells[1].Value.ToString();
            Data_achizitie.Text = DatePartituriVandute.SelectedRows[0].Cells[2].Value.ToString();
            Pret_partitura.Text = DatePartituriVandute.SelectedRows[0].Cells[3].Value.ToString();
            Cantitate_vanduta.Text = DatePartituriVandute.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void DateISMN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ISMN_partitura.Text = DateISMN.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void DateIDMagazin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_magazin.Text = DateIDMagazin.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void Cautare_partitura_vandut_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_partitura_vandut.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM partituri_vandute WHERE id_magazin LIKE '%" + keyword + "%' OR ISMN LIKE '%" + keyword + "%' OR data_achizitiei LIKE '%" + keyword + "%' OR pret_partitura LIKE '%" + keyword + "%' OR cantitate_vanduta LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DatePartituriVandute.DataSource = dt;

            Con.Close();
        }

        private void Cautare_ISMN_TextChanged(object sender, EventArgs e)
        {
            Con.Open();

            string keyword = Cautare_ISMN.Text;
            keyword.ToLower();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT ISMN, nume_partitura FROM partituri WHERE ISMN LIKE '%" + keyword + "%' OR lower(nume_partitura) LIKE '%" + keyword + "%';", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DateISMN.DataSource = dt;

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
