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
    public partial class Vanzari : Form
    {
        public Vanzari()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Meniu meniu = new Meniu();
            meniu.Show();
            this.Hide();
        }

        private void Accesorii_vandute_Click(object sender, EventArgs e)
        {
            AccesoriiVandute vanzare_accesoriu = new AccesoriiVandute();
            vanzare_accesoriu.Show();
            this.Hide();
        }

        private void Albume_vandute_Click(object sender, EventArgs e)
        {
            AlbumeVandute vanzare_album = new AlbumeVandute();
            vanzare_album.Show();
            this.Hide();
        }

        private void Partituri_vandute_Click(object sender, EventArgs e)
        {
            PartituriVandute vanzare_partitura = new PartituriVandute();
            vanzare_partitura.Show();
            this.Hide();
        }

        private void info_sup_Click(object sender, EventArgs e)
        {
            Info_sup info = new Info_sup();
            info.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vanzari_totale vanzari = new Vanzari_totale();
            vanzari.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
