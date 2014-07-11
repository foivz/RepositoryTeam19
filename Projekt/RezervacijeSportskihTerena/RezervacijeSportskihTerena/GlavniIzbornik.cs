using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace RezervacijeSportskihTerena
{
    public partial class frmGlavniIzbornik : Form
    {
        
        public frmGlavniIzbornik(string strLogin, int idAktivnog)
        {
            InitializeComponent();
            toolStripImePrezime.Text = strLogin;
            AktivniZaposlenikClass aktivni = new AktivniZaposlenikClass(idAktivnog);
        }
 
        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.Restart();
        }

        private void tereniToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            /* poziv metode koja provjerava je li forma već pokrenuta i ako je postavlja je na vrh kao aktivnu */
            frmTereni obj = frmTereni.GetInstance();
            obj.MdiParent = this;

            if (!obj.Visible)
                obj.Show();
            else
                obj.BringToFront();
        }

        private void rezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* poziv metode koja provjerava je li forma već pokrenuta i ako je postavlja je na vrh kao aktivnu */
            frmRezervacije obj = frmRezervacije.GetInstance();
            obj.MdiParent = this;

            if (!obj.Visible)
                obj.Show();
            else
                obj.BringToFront();

        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* poziv metode koja provjerava je li forma već pokrenuta i ako je postavlja je na vrh kao aktivnu */
            frmStatistika obj = frmStatistika.GetInstance();
            obj.MdiParent = this;

            if (!obj.Visible)
                obj.Show();
            else
                obj.BringToFront();
        }

        private void zaposleniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* poziv metode koja provjerava je li forma već pokrenuta i ako je postavlja je na vrh kao aktivnu */
            frmZaposlenici obj = frmZaposlenici.GetInstance();
            obj.MdiParent = this;

            if (!obj.Visible)
                obj.Show();
            else
                obj.BringToFront();
            
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
