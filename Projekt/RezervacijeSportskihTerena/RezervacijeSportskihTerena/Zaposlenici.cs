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
        public frmZaposlenici()
        {
            InitializeComponent();
        }
        private void OsvjeziZaposlenike()
        {
            List<ZaposleniciClass> listaZap = ZaposleniciClass.DohvatiZaposlenike();
            dgvZaposlenici.DataSource = listaZap;
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
    }
}
