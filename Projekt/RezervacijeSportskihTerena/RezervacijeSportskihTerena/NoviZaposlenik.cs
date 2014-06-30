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
            if ((txtImeZaposlenik.Text == "") || (txtPrezimeZaposlenik.Text == "") || (txtKorisnickoIme.Text == "") || (txtLozinka.Text == "") || (txtEmail.Text == ""))
            {
                MessageBox.Show("Ispunite sva polja molim.");
                return;
            }


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

        private void frmNoviZaposlenik_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtImeZaposlenik;

            /* Popunjavanje trenutno upisanih podataka kod izmjene unešenog zaposlenika */
            if (zaposlenik != null)
            {
                txtIdZaposlenik.Text = zaposlenik.IdZaposlenik.ToString();
                txtImeZaposlenik.Text = zaposlenik.ImeZaposlenik.ToString();
                txtPrezimeZaposlenik.Text = zaposlenik.PrezimeZaposlenik.ToString();
                txtEmail.Text = zaposlenik.Email.ToString();
                txtLozinka.Text = zaposlenik.Lozinka.ToString();
                txtKorisnickoIme.Text = zaposlenik.KorisnickoIme.ToString();
            }
        }

        private void txtImeZaposlenik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == '\b')     // Dozvoljava samo slova i backspace
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtPrezimeZaposlenik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == '\b')     // Dozvoljava samo slova i backspace
                e.Handled = false;
            else
                e.Handled = true;
        }



    }
}
