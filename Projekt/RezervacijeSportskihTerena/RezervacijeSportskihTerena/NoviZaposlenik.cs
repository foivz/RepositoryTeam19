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
    public partial class frmNoviZaposlenik : Form
    {
        //Referenca na postojećeg zaposlenika
        private ZaposleniciClass zaposlenik = null;

        public frmNoviZaposlenik()
        {
            InitializeComponent();
        }

         public frmNoviZaposlenik(ZaposleniciClass odabraniZaposlenik)
        {
            InitializeComponent();
            zaposlenik = odabraniZaposlenik;
        }

        private void btnSpremiZaposlenik_Click(object sender, EventArgs e)
        {
            if (zaposlenik == null)
            {
                zaposlenik = new ZaposleniciClass();
            }
            zaposlenik.ImeZaposlenik = txtImeZaposlenik.Text;
            zaposlenik.PrezimeZaposlenik = txtPrezimeZaposlenik.Text;
            zaposlenik.KorisnickoIme = txtKorisnickoIme.Text;
            zaposlenik.Lozinka = txtLozinka.Text;
            zaposlenik.Email = txtEmail.Text;
            zaposlenik.Spremi();
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
