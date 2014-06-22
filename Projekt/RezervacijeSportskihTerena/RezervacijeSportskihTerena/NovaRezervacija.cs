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
    public partial class frmNovaRezervacija : Form
    {
        public frmNovaRezervacija()
        {
            InitializeComponent();
        }

        public void OsvjeziKorisnike()
        {
            List<KorisniciClass> listaKor = KorisniciClass.DohvatiKorisnike();
            dgvKorisnici.DataSource = listaKor;
        }

        public void OsvjeziTerene()
        {
            List<TereniClass> listaTer = TereniClass.DohvatiTerene();
            dgvTereni.DataSource = listaTer;
        }

        private void frmNovaRezervacija_Load(object sender, EventArgs e)
        {
            OsvjeziKorisnike();
            OsvjeziTerene();
        }

        private void btnNoviKorisnik_Click(object sender, EventArgs e)
        {
            frmNoviKorisnik noviKorisnik = new frmNoviKorisnik();
            noviKorisnik.ShowDialog();
            OsvjeziKorisnike();
        }

        private void btnObrisiKorisnika_Click(object sender, EventArgs e)
        {
            if(dgvKorisnici.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvKorisnici.SelectedRows)
                {
                    KorisniciClass odabraniKorisnik = row.DataBoundItem as KorisniciClass;
                    odabraniKorisnik.Obrisi();
                }
            }
            OsvjeziKorisnike();
        }

        private void btnIzmjeniKorisnika_Click(object sender, EventArgs e)
        {
            if (dgvKorisnici.SelectedRows.Count > 0)
            {
                KorisniciClass odabraniKorisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as KorisniciClass;
                frmNoviKorisnik noviKorisnik = new frmNoviKorisnik(odabraniKorisnik);
                noviKorisnik.ShowDialog();
                OsvjeziKorisnike();   
            }
        }


    }
}
