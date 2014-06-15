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
 
        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.Restart();
        }


        private void tereniToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmTereni linkTereni = new frmTereni();
            linkTereni.MdiParent = this;
            linkTereni.Show();
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

        private void zaposleniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZaposlenici linkZaposlenici = new frmZaposlenici();
            linkZaposlenici.MdiParent = this;
            linkZaposlenici.Show();
        }


        /// <summary>
        /// Na pritisak tipke escape nudi izbor izlaza iz aplikacije ili povratak u meni.
        /// </summary>
        private void frmGlavniIzbornik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result1 = MessageBox.Show("Jeste li sigurni da želite izaći iz programa?","Izlaz iz programa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
 
                if (result1 == DialogResult.Yes)
                {
                    Application.Exit();
                }
                if (result1 == DialogResult.No)
                {
                    return;
                }               
            }


        }
    }
}
