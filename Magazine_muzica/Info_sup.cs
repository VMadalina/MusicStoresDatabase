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
    public partial class Info_sup : Form
    {
        public Info_sup()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HGD9B6P;Initial Catalog=Magazine_muzica;Integrated Security=True");

        void FillMagazinAlbume()
        {

            string query = "SELECT distinct m.nume_magazin FROM magazine m JOIN albume_vandute a ON m.id_magazin = a.id_magazin;";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("nume_magazin", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                Nume_magazin.ValueMember = "nume_magazin";
                Nume_magazin.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }

        }

        void FillMagazinPartituri()
        {

            string query = "SELECT distinct m.nume_magazin FROM magazine m JOIN partituri_vandute a ON m.id_magazin = a.id_magazin;";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("nume_magazin", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                Nume_magazin_partituri.ValueMember = "nume_magazin";
                Nume_magazin_partituri.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }

        }

        void FillMagazinAccesorii()
        {

            string query = "SELECT distinct m.nume_magazin FROM magazine m JOIN accesorii_vandute a ON m.id_magazin = a.id_magazin;";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("nume_magazin", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                Nume_magazin_accesorii.ValueMember = "nume_magazin";
                Nume_magazin_accesorii.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }

        }


        private void populateAlbum()
        {
            if( (string.IsNullOrWhiteSpace(Nume_artist.Text) && string.IsNullOrWhiteSpace(Nume_albume.Text) ) || string.IsNullOrWhiteSpace(Nume_magazin.Text))
            {
                MessageBox.Show("Trebuie completat în mod obligatoriu numele magazinului și cel puțin unul din celelalte câmpuri.");
            }
            else if(string.IsNullOrWhiteSpace(Nume_albume.Text))
            {
                Con.Open();

                string Myquery = "select m.nume_magazin Magazin, a.nume_album Album, a.nume_artist Artist, a.format_album Format, cd.nume_casa 'Casa de discuri', av.data_achizitiei 'Data achizitiei', av.cantitate_vanduta 'Cantitatea vanduta' from magazine m join albume_vandute av on m.id_magazin = av.id_magazin join albume a on a.id_album = av.id_album left join casa_discuri cd on cd.CUI_casa = a.CUI_casa where lower (m.nume_magazin) = '" + Nume_magazin.Text + "' and lower (a.nume_artist) LIKE '%" + Nume_artist.Text + "%';";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                InfoAlbume.DataSource = ds.Tables[0];
                Con.Close();
            }
            else if(string.IsNullOrWhiteSpace(Nume_artist.Text))
            {
                Con.Open();

                string Myquery = "select m.nume_magazin Magazin, a.nume_album Album, a.nume_artist Artist, a.format_album Format, cd.nume_casa 'Casa de discuri', av.data_achizitiei 'Data achizitiei', av.cantitate_vanduta 'Cantitatea vanduta' from magazine m join albume_vandute av on m.id_magazin = av.id_magazin join albume a on a.id_album = av.id_album left join casa_discuri cd on cd.CUI_casa = a.CUI_casa where lower (m.nume_magazin) = '" + Nume_magazin.Text + "' and lower (a.nume_album) LIKE '%" + Nume_albume.Text + "%';";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                InfoAlbume.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                Con.Open();

                string Myquery = "select m.nume_magazin Magazin, a.nume_album Album, a.nume_artist Artist, a.format_album Format, cd.nume_casa 'Casa de discuri', av.data_achizitiei 'Data achizitiei', av.cantitate_vanduta 'Cantitatea vanduta' from magazine m join albume_vandute av on m.id_magazin = av.id_magazin join albume a on a.id_album = av.id_album left join casa_discuri cd on cd.CUI_casa = a.CUI_casa where lower (m.nume_magazin) = '" + Nume_magazin.Text + "' and lower (a.nume_album) LIKE '%" + Nume_albume.Text + "%' and lower (a.nume_artist) LIKE '%" + Nume_artist.Text + "%';";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                InfoAlbume.DataSource = ds.Tables[0];
                Con.Close();
            }
        }

        private void populateAlbumInitial()
        {
                Con.Open();

                string Myquery = "select m.nume_magazin Magazin, a.nume_album Album, a.nume_artist Artist, a.format_album Format, cd.nume_casa 'Casa de discuri', av.data_achizitiei 'Data achizitiei', av.cantitate_vanduta 'Cantitatea vanduta' from magazine m join albume_vandute av on m.id_magazin = av.id_magazin join albume a on a.id_album = av.id_album left join casa_discuri cd on cd.CUI_casa = a.CUI_casa;";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                InfoAlbume.DataSource = ds.Tables[0];
                Con.Close();
        }

        private void populatePartituri()
        {
            if ((string.IsNullOrWhiteSpace(Nume_partitura.Text) && string.IsNullOrWhiteSpace(Numele_editurii.Text)) || string.IsNullOrWhiteSpace(Nume_magazin_partituri.Text))
            {
                MessageBox.Show("Trebuie completat în mod obligatoriu numele magazinului și cel puțin unul din celelalte câmpuri.");
            }
            else if (string.IsNullOrWhiteSpace(Nume_partitura.Text))
            {
                Con.Open();

                string Myquery = "select m.nume_magazin Magazin, p.nume_partitura Partitura, e.nume_editura 'Editura', pv.data_achizitiei 'Data achizitiei', pv.cantitate_vanduta 'Cantitatea vanduta' from magazine m join partituri_vandute pv on m.id_magazin = pv.id_magazin join partituri p on p.ISMN = pv.ISMN left join edituri e on p.id_editura = e.id_editura WHERE lower (m.nume_magazin) = '" + Nume_magazin_partituri.Text + "' and lower (e.nume_editura) LIKE '%" + Numele_editurii.Text + "%';";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                InfoPartituri.DataSource = ds.Tables[0];
                Con.Close();
            }
            else if (string.IsNullOrWhiteSpace(Numele_editurii.Text))
            {
                Con.Open();

                string Myquery = "select m.nume_magazin Magazin, p.nume_partitura Partitura, e.nume_editura 'Editura', pv.data_achizitiei 'Data achizitiei', pv.cantitate_vanduta 'Cantitatea vanduta' from magazine m join partituri_vandute pv on m.id_magazin = pv.id_magazin join partituri p on p.ISMN = pv.ISMN left join edituri e on p.id_editura = e.id_editura WHERE lower (m.nume_magazin) = '" + Nume_magazin_partituri.Text + "' and lower (p.nume_partitura) LIKE '%" + Nume_partitura.Text + "%';";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                InfoPartituri.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                Con.Open();

                string Myquery = "select m.nume_magazin Magazin, p.nume_partitura Partitura, e.nume_editura 'Editura', pv.data_achizitiei 'Data achizitiei', pv.cantitate_vanduta 'Cantitatea vanduta' from magazine m join partituri_vandute pv on m.id_magazin = pv.id_magazin join partituri p on p.ISMN = pv.ISMN left join edituri e on p.id_editura = e.id_editura WHERE lower (m.nume_magazin) = '" + Nume_magazin_partituri.Text + "' and lower (p.nume_partitura) LIKE '%" + Nume_partitura.Text + "%' and lower (e.nume_editura) LIKE '%" + Numele_editurii.Text + "%';";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                InfoPartituri.DataSource = ds.Tables[0];
                Con.Close();
            }
        }

        private void populatePartituriInitial()
        {
                Con.Open();

                string Myquery = "select m.nume_magazin Magazin, p.nume_partitura Partitura, e.nume_editura 'Editura', pv.data_achizitiei 'Data achizitiei', pv.cantitate_vanduta 'Cantitatea vanduta' from magazine m join partituri_vandute pv on m.id_magazin = pv.id_magazin join partituri p on p.ISMN = pv.ISMN left join edituri e on p.id_editura = e.id_editura;";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                InfoPartituri.DataSource = ds.Tables[0];
                Con.Close();
        }

        private void populateAccesorii()
        {
            if ((string.IsNullOrWhiteSpace(Nume_obiect.Text) && string.IsNullOrWhiteSpace(Nume_accesoriu.Text)) || string.IsNullOrWhiteSpace(Nume_magazin_accesorii.Text))
            {
                MessageBox.Show("Trebuie completat în mod obligatoriu numele magazinului și cel puțin unul din celelalte câmpuri.");
            }
            else if (string.IsNullOrWhiteSpace(Nume_obiect.Text))
            {
                Con.Open();

                string Myquery = "select m.nume_magazin Magazin, a.nume_accesoriu 'Accesoriu', a.obiect_compatibil 'Obiect compatibil', a.tip_instrument 'Tipul instrumentului', av.data_achizitiei 'Data achizitiei', av.cantitate_vanduta 'Cantitatea vanduta' from magazine m join accesorii_vandute av on m.id_magazin = av.id_magazin join accesorii a on a.id_accesoriu = av.id_accesoriu WHERE lower (m.nume_magazin) = '" + Nume_magazin_accesorii.Text + "' and lower (a.nume_accesoriu) LIKE '%" + Nume_accesoriu.Text + "%';";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                InfoAccesorii.DataSource = ds.Tables[0];
                Con.Close();
            }
            else if (string.IsNullOrWhiteSpace(Nume_accesoriu.Text))
            {
                Con.Open();

                string Myquery = "select m.nume_magazin Magazin, a.nume_accesoriu 'Accesoriu', a.obiect_compatibil 'Obiect compatibil', a.tip_instrument 'Tipul instrumentului', av.data_achizitiei 'Data achizitiei', av.cantitate_vanduta 'Cantitatea vanduta' from magazine m join accesorii_vandute av on m.id_magazin = av.id_magazin join accesorii a on a.id_accesoriu = av.id_accesoriu WHERE lower (m.nume_magazin) = '" + Nume_magazin_accesorii.Text + "' and lower (a.obiect_compatibil) LIKE '%" + Nume_obiect.Text + "%';";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                InfoAccesorii.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                Con.Open();

                string Myquery = "select m.nume_magazin Magazin, a.nume_accesoriu 'Accesoriu', a.obiect_compatibil 'Obiect compatibil', a.tip_instrument 'Tipul instrumentului', av.data_achizitiei 'Data achizitiei', av.cantitate_vanduta 'Cantitatea vanduta' from magazine m join accesorii_vandute av on m.id_magazin = av.id_magazin join accesorii a on a.id_accesoriu = av.id_accesoriu WHERE lower (m.nume_magazin) = '" + Nume_magazin_accesorii.Text + "' and lower (a.obiect_compatibil) LIKE '%" + Nume_obiect.Text + "%' and lower (a.nume_accesoriu) LIKE '%" + Nume_accesoriu.Text + "%';";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                InfoAccesorii.DataSource = ds.Tables[0];
                Con.Close();
            }
        }

        private void populateAccesoriiInitial()
        {
                Con.Open();

                string Myquery = "select m.nume_magazin Magazin, a.nume_accesoriu 'Accesoriu', a.obiect_compatibil 'Obiect compatibil', a.tip_instrument 'Tipul instrumentului', av.data_achizitiei 'Data achizitiei', av.cantitate_vanduta 'Cantitatea vanduta' from magazine m join accesorii_vandute av on m.id_magazin = av.id_magazin join accesorii a on a.id_accesoriu = av.id_accesoriu;";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                InfoAccesorii.DataSource = ds.Tables[0];
                Con.Close();
        }


        private void populateInstrumente()
        {
            if(string.IsNullOrWhiteSpace(Cantitate_minima.Text))
            {
                MessageBox.Show("Trebuie completat în mod obligatoriu cantitatea minimă!");
            }
            else
            {
                Con.Open();

                string Myquery = "select  m.nume_magazin Magazin,  i.nume_instrument Instrument, count(*) 'Cantitate vanduta' from instrumente i join magazine m on i.id_magazin = m.id_magazin group by i.nume_instrument, m.nume_magazin having count(*) >= '" + Cantitate_minima.Text + "'; ";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                InfoInstrument.DataSource = ds.Tables[0];
                Con.Close();
            }
          
        }

        private void populateInstrumenteInitial()
        {
                Con.Open();

                string Myquery = "select  m.nume_magazin Magazin,  i.nume_instrument Instrument, count(*) 'Cantitate vanduta' from instrumente i join magazine m on i.id_magazin = m.id_magazin group by i.nume_instrument, m.nume_magazin;";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                InfoInstrument.DataSource = ds.Tables[0];
                Con.Close();
          
        }


        private void populatePerMagazin()
        {
            if (string.IsNullOrWhiteSpace(min_per_magazin.Text))
            {
                MessageBox.Show("Trebuie completat în mod obligatoriu cantitatea minimă!");
            }
            else
            {
                Con.Open();

                string Myquery = "select  m.nume_magazin Magazin, count(m.nume_magazin) 'Cantitate totala vanduta' from instrumente i join magazine m on i.id_magazin = m.id_magazin group by m.nume_magazin having count(m.nume_magazin) >= '" + min_per_magazin.Text + "';";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CantPerMagazin.DataSource = ds.Tables[0];
                Con.Close();
            }
        }

        private void populatePerMagazinInitial()
        {
                Con.Open();

                string Myquery = "select  m.nume_magazin Magazin, count(m.nume_magazin) 'Cantitate totala vanduta' from instrumente i join magazine m on i.id_magazin = m.id_magazin group by m.nume_magazin;";

                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CantPerMagazin.DataSource = ds.Tables[0];
                Con.Close();
                
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Vanzari vanzare = new Vanzari();
            vanzare.Show();
            this.Hide();
        }


        private void Info_sup_Load(object sender, EventArgs e)
        {
            FillMagazinAlbume();
            FillMagazinPartituri();
            FillMagazinAccesorii();
            populateAlbumInitial();
            populateAccesoriiInitial();
            populateInstrumenteInitial();
            populatePartituriInitial();
            populatePerMagazinInitial();
        }

        private void Info_albume_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InfoAlbume.Show();
            NumeAlbum.Show();
            Nume_albume.Show();
            Nume_artist.Show();
            NumeArtist.Show();
            NumeMagazin.Show();
            Nume_magazin.Show();
            Afisare_albume.Show();


            InfoPartituri.Hide();
            NumePartitura.Hide();
            Nume_partitura.Hide();
            Numemagazinpartituti.Hide();
            Nume_magazin_partituri.Hide();
            Nume_Editura.Hide();
            Numele_editurii.Hide();
            Afisare_partituri.Hide();

            InfoAccesorii.Hide();
            Nume_magazin_accesorii.Hide();
            NumeMagazinAccesorii.Hide();
            Nume_accesoriu.Hide();
            NumeAccesoriu.Hide();
            Nume_obiect.Hide();
            NumeObiect.Hide();
            Afisare_accesoriu.Hide();

            InfoInstrument.Hide();
            CantitateMinima.Hide();
            Cantitate_minima.Hide();
            Afisare_instrument.Hide();

            Info_per_magazin.Hide();
            min_per_magazin.Hide();
            Afisare_per_magazin.Hide();
            CantPerMagazin.Hide();

            Cant_totala_instrumente.Hide();
            Cant_total_per_magazin.Hide();

        }

        private void Afisare_albume_Click(object sender, EventArgs e)
        {
            populateAlbum();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void info_partituri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InfoPartituri.Show();
            NumePartitura.Show();
            Nume_partitura.Show();
            Numemagazinpartituti.Show();
            Nume_magazin_partituri.Show();
            Nume_Editura.Show();
            Numele_editurii.Show();
            Afisare_partituri.Show();


            InfoAlbume.Hide();
            NumeAlbum.Hide();
            Nume_albume.Hide();
            Nume_artist.Hide();
            NumeArtist.Hide();
            NumeMagazin.Hide();
            Nume_magazin.Hide();
            Afisare_albume.Hide();

            InfoAccesorii.Hide();
            Nume_magazin_accesorii.Hide();
            NumeMagazinAccesorii.Hide();
            Nume_accesoriu.Hide();
            NumeAccesoriu.Hide();
            Nume_obiect.Hide();
            NumeObiect.Hide();
            Afisare_accesoriu.Hide();

            InfoInstrument.Hide();
            CantitateMinima.Hide();
            Cantitate_minima.Hide();
            Afisare_instrument.Hide();

            Info_per_magazin.Hide();
            min_per_magazin.Hide();
            Afisare_per_magazin.Hide();
            CantPerMagazin.Hide();

            Cant_totala_instrumente.Hide();
            Cant_total_per_magazin.Hide();

        }

        private void Afisare_partituri_Click(object sender, EventArgs e)
        {
            populatePartituri();        
        }

        private void InfoPartituri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Info_accesorii_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InfoAccesorii.Show();
            Nume_magazin_accesorii.Show();
            NumeMagazinAccesorii.Show();
            Nume_accesoriu.Show();
            NumeAccesoriu.Show();
            Nume_obiect.Show();
            NumeObiect.Show();
            Afisare_accesoriu.Show();


            InfoAlbume.Hide();
            NumeAlbum.Hide();
            Nume_albume.Hide();
            Nume_artist.Hide();
            NumeArtist.Hide();
            NumeMagazin.Hide();
            Nume_magazin.Hide();
            Afisare_albume.Hide();

            InfoPartituri.Hide();
            NumePartitura.Hide();
            Nume_partitura.Hide();
            Numemagazinpartituti.Hide();
            Nume_magazin_partituri.Hide();
            Nume_Editura.Hide();
            Numele_editurii.Hide();
            Afisare_partituri.Hide();

            InfoInstrument.Hide();
            CantitateMinima.Hide();
            Cantitate_minima.Hide();
            Afisare_instrument.Hide();

            Info_per_magazin.Hide();
            min_per_magazin.Hide();
            Afisare_per_magazin.Hide();
            CantPerMagazin.Hide();

            Cant_totala_instrumente.Hide();
            Cant_total_per_magazin.Hide();
        }

        private void Afisare_accesoriu_Click(object sender, EventArgs e)
        {
            populateAccesorii();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Numemagazinpartituti_Click(object sender, EventArgs e)
        {

        }

        private void Afisare_instrument_Click(object sender, EventArgs e)
        {
            populateInstrumente();
        }

        private void InfoInstrumente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Cant_totala_instrumente.Show();
            Cant_total_per_magazin.Show();

            InfoAccesorii.Hide();
            Nume_magazin_accesorii.Hide();
            NumeMagazinAccesorii.Hide();
            Nume_accesoriu.Hide();
            NumeAccesoriu.Hide();
            Nume_obiect.Hide();
            NumeObiect.Hide();
            Afisare_accesoriu.Hide();


            InfoAlbume.Hide();
            NumeAlbum.Hide();
            Nume_albume.Hide();
            Nume_artist.Hide();
            NumeArtist.Hide();
            NumeMagazin.Hide();
            Nume_magazin.Hide();
            Afisare_albume.Hide();

            InfoPartituri.Hide();
            NumePartitura.Hide();
            Nume_partitura.Hide();
            Numemagazinpartituti.Hide();
            Nume_magazin_partituri.Hide();
            Nume_Editura.Hide();
            Numele_editurii.Hide();
            Afisare_partituri.Hide();
        }

        private void Nume_albume_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cant_total_per_magazin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info_per_magazin.Show();
            min_per_magazin.Show();
            Afisare_per_magazin.Show();
            CantPerMagazin.Show();

            InfoInstrument.Hide();
            CantitateMinima.Hide();
            Cantitate_minima.Hide();
            Afisare_instrument.Hide();
        }

        private void Cant_totala_instrumente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InfoInstrument.Show();
            CantitateMinima.Show();
            Cantitate_minima.Show();
            Afisare_instrument.Show();

            Info_per_magazin.Hide();
            min_per_magazin.Hide();
            Afisare_per_magazin.Hide();
            CantPerMagazin.Hide();
        }

        private void min_per_magazin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Afisare_per_magazin_Click_1(object sender, EventArgs e)
        {
            populatePerMagazin();
        }
    }
}
