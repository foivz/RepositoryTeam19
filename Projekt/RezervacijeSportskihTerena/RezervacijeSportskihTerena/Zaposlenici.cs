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
using System.Collections;

namespace RezervacijeSportskihTerena
{
    public partial class frmZaposlenici : Form
    {
        /* omogućeno kreiranje samo jedne instance određene forme */
        private static frmZaposlenici instance;
        /* provjera postoji li već instanca tražene forme */
        public static frmZaposlenici GetInstance()
        {
            if (instance == null)
                instance = new frmZaposlenici();
            return instance;
        }
        public frmZaposlenici()
        {
            InitializeComponent();

            this.idZaposlenik.DataPropertyName = "idZaposlenik";
            this.imeZaposlenik.DataPropertyName = "imeZaposlenik";
            this.prezimeZaposlenik.DataPropertyName = "prezimeZaposlenik";
            this.korisnickoIme.DataPropertyName = "korisnickoIme";
            this.lozinka.DataPropertyName = "lozinka";
            this.email.DataPropertyName = "email";
            
            List<ZaposleniciClass> listaZap = ZaposleniciClass.DohvatiZaposlenike();
            // omogucavanje sortiranja liste zaposlenika uz pomoc SortableBindingList klase
            SortableBindingList<ZaposleniciClass> sortiranaListaZap = new SortableBindingList<ZaposleniciClass>(listaZap);
            this.dgvZaposlenici.DataSource = sortiranaListaZap;
        }
        private void OsvjeziZaposlenike()
        {
            List<ZaposleniciClass> listaZap = ZaposleniciClass.DohvatiZaposlenike();
            SortableBindingList<ZaposleniciClass> sortiranaListaZap = new SortableBindingList<ZaposleniciClass>(listaZap);
            this.dgvZaposlenici.DataSource = sortiranaListaZap;
        }

        private void frmZaposlenici_Load(object sender, EventArgs e)
        {
            OsvjeziZaposlenike();
        }

        private void btnNoviZaposlenik_Click(object sender, EventArgs e)
        {
            frmNoviZaposlenik frmNoviZaposlenik = new frmNoviZaposlenik();
            frmNoviZaposlenik.ShowDialog();
            OsvjeziZaposlenike();
        }

        private void btnIzmjeniZaposlenika_Click(object sender, EventArgs e)
        {
            if (dgvZaposlenici.SelectedRows.Count > 0)
            {
                ZaposleniciClass odabirZaposlenik = dgvZaposlenici.SelectedRows[0].DataBoundItem as ZaposleniciClass;
                frmNoviZaposlenik noviZaposlenik = new frmNoviZaposlenik(odabirZaposlenik);
                noviZaposlenik.ShowDialog();
                OsvjeziZaposlenike();

            }
        }

        private void btnObrisiZaposlenika_Click(object sender, EventArgs e)
        {
            if (dgvZaposlenici.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvZaposlenici.SelectedRows)
                {
                    ZaposleniciClass odabraniZaposlenik = row.DataBoundItem as ZaposleniciClass;
                    odabraniZaposlenik.Obrisi();
                }
            }
            OsvjeziZaposlenike();
        }

        private void frmZaposlenici_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }
    }
}
