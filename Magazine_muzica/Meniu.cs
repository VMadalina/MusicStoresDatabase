using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazine_muzica
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Magazine magazin = new Magazine();
            magazin.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Instrumente instrument = new Instrumente();
            instrument.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Albume album = new Albume();
            album.Show();
            this.Hide();
        }

        private void Case_Click(object sender, EventArgs e)
        {
            CaseDiscuri casa = new CaseDiscuri();
            casa.Show();
            this.Hide();
        }

        private void Edituri_Click(object sender, EventArgs e)
        {
            Edituri editura = new Edituri();
            editura.Show();
            this.Hide();
        }

        private void Producatori_Click(object sender, EventArgs e)
        {
            Producatori prod = new Producatori();
            prod.Show();
            this.Hide();
        }

        private void Accesorii_Click(object sender, EventArgs e)
        {
            Accesorii accesoriu = new Accesorii();
            accesoriu.Show();
            this.Hide();
        }

        private void Partituri_Click(object sender, EventArgs e)
        {
            Partituri partitura = new Partituri();
            partitura.Show();
            this.Hide();
        }

        private void Vanzari_Click(object sender, EventArgs e)
        {
            Vanzari vanzare = new Vanzari();
            vanzare.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Meniu_Load(object sender, EventArgs e)
        {

        }
    }
}
