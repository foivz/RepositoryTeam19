using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace RezervacijeSportskihTerena
{
    public partial class frmNoviKorisnik : Form
    {
        //Referenca na postojećeg korisnika
        private KorisniciClass korisnik = null;

        public frmNoviKorisnik()
        {
            InitializeComponent();
        }

        public frmNoviKorisnik(KorisniciClass odabraniKorisnik)
        {
            InitializeComponent();
            korisnik = odabraniKorisnik;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if ((txtImePrezimeKorisnik.Text == "") || (txtTelefonKorisnik.Text == "") || (txtEmailKorisnik.Text == ""))
            {
                MessageBox.Show("Ispunite sva polja molim.");
                return;
            }

            if(ProvjeriEmail(txtEmailKorisnik.Text) == false)
            {
                MessageBox.Show("Uneseni email je u neispravnom formatu. Pokusajte ponovo molim.");
                return;
            }

            if (korisnik == null)
            {
                korisnik = new KorisniciClass();
            }
            korisnik.ImePrezimeKorisnik = txtImePrezimeKorisnik.Text;
            korisnik.EmailKorisnik = txtEmailKorisnik.Text;
            korisnik.TelefonKorisnik = txtTelefonKorisnik.Text;
            korisnik.Spremi();
            this.Close();
        }

        private void frmNoviKorisnik_Load(object sender, EventArgs e)
        {
            /* Popunjavanje forme sa postojećim podacima kod izmjene. */
            if (korisnik != null) {
                txtIdKorisnik.Text = korisnik.IdKorisnik.ToString();
                txtEmailKorisnik.Text = korisnik.EmailKorisnik.ToString();
                txtTelefonKorisnik.Text = korisnik.TelefonKorisnik.ToString();
                txtImePrezimeKorisnik.Text = korisnik.ImePrezimeKorisnik.ToString();
            }
        }

        public bool ProvjeriEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void txtImePrezimeKorisnik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ' ')     // Dozvoljava samo slova, space i backspace
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtTelefonKorisnik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b' // Dozvoljava samo brojeve, backspace, ( ) + i -
                || e.KeyChar == '-'
                || e.KeyChar == '+'
                || e.KeyChar == '('
                || e.KeyChar == ')')     
                e.Handled = false;
            else
                e.Handled = true;
        }


    }
}
