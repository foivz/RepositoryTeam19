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
    public partial class frmRezervacije : Form
    {
        /* omogućeno kreiranje samo jedne instance određene forme */
        private static frmRezervacije instance;
        /* provjera postoji li već instanca tražene forme */
        public static frmRezervacije GetInstance()
        {
            if (instance == null)
                instance = new frmRezervacije();
            return instance;
        }
        public frmRezervacije()
        {
            InitializeComponent();

            this.idRezervacija.DataPropertyName = "idRezervacija";
            this.imePrezimeKorisnik.DataPropertyName = "imePrezimeKorisnik";
            this.emailKorisnik.DataPropertyName = "emailKorisnik";
            this.telefonKorisnik.DataPropertyName = "telefonKorisnik";
            this.nazivTerena.DataPropertyName = "nazivTerena";
            this.cijenaSata.DataPropertyName = "cijenaSata";
            this.vrijemePocetka.DataPropertyName = "vrijemePocetka";
            this.vrijemeZavrsetka.DataPropertyName = "vrijemeZavrsetka";
            this.datumRezervacije.DataPropertyName = "datumRezervacije";

            List<RezervacijeClass> listaRez = RezervacijeClass.DohvatiRezervacije();
            // omogucavanje sortiranja liste rezervacija uz pomoc SortableBindingList klase
            SortableBindingList<RezervacijeClass> sortiranaListaRez = new SortableBindingList<RezervacijeClass>(listaRez);
            this.dgvRezervacije.DataSource = sortiranaListaRez;
        }

        public void OsvjeziRezervacije()
        {
            List<RezervacijeClass> listaRez = RezervacijeClass.DohvatiRezervacije();
            SortableBindingList<RezervacijeClass> sortiranaListaRez = new SortableBindingList<RezervacijeClass>(listaRez);
            this.dgvRezervacije.DataSource = sortiranaListaRez;
        }

        private void frmRezervacije_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void btnNovaRezervacija_Click(object sender, EventArgs e)
        {
            frmNovaRezervacija rez = new frmNovaRezervacija();
            rez.ShowDialog();
            OsvjeziRezervacije();
        }

        private void frmRezervacije_Load(object sender, EventArgs e)
        {
            OsvjeziRezervacije();
        }

        private void btnObrisiRezervaciju_Click(object sender, EventArgs e)
        {
            // Iz selektiranog reda izvlači se vrijednost IdRezervacija i prosljeđuje na funkciju Obrisi
            int selectedRowIndexR = dgvRezervacije.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRowR = dgvRezervacije.Rows[selectedRowIndexR];
            int a = Convert.ToInt32(selectedRowR.Cells["IdRezervacija"].Value);

            RezervacijeAkcijeClass rez = new RezervacijeAkcijeClass();
            rez.Obrisi(a);
               
            OsvjeziRezervacije();
        }
    }
}
