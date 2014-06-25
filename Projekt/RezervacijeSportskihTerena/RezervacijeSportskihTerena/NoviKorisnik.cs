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
    }
}
