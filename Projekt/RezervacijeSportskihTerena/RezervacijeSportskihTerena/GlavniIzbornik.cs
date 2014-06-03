using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervacijeSportskihTerena
{
    public partial class frmGlavniIzbornik : Form
    {
        public frmGlavniIzbornik()
        {
            InitializeComponent();
        }


        private void tereniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void unosPodatakaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.Restart();
        }

        private void lblPozdrav_Click(object sender, EventArgs e)
        {

        }

        private void tereniToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmTereni linkTereni = new frmTereni();
            linkTereni.MdiParent = this;
            linkTereni.Show();
        }

        private void frmGlavniIzbornik_Load(object sender, EventArgs e)
        {

        }

        private void rezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRezervacije linkRezervacije = new frmRezervacije();
            linkRezervacije.MdiParent = this;
            linkRezervacije.Show();
        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatistika linkStatistika = new frmStatistika();
            linkStatistika.MdiParent = this;
            linkStatistika.Show();
        }

        private void izvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzvjestaj linkIzvjestaj = new frmIzvjestaj();
            linkIzvjestaj.MdiParent = this;
            linkIzvjestaj.Show();
        }

    }
}
