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
    public partial class frmStatistika : Form
    {
        /* omogućeno kreiranje samo jedne instance određene forme */
        private static frmStatistika instance;
        /* provjera postoji li već instanca tražene forme */
        public static frmStatistika GetInstance()
        {
            if (instance == null)
                instance = new frmStatistika();
            return instance;
        }
        public frmStatistika()
        {
            InitializeComponent();
        }

        private void frmStatistika_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void btnNajkoristenijiTermin_Click(object sender, EventArgs e)
        {
            // SQL upit za brojanje rezervacija prema korisniku  
            prikaz.Items.Clear();
            string sqlUpit = "SELECT termin.[vrijemePocetka], COUNT(rezervacija.[idTermin]) brojRezervacija FROM termin left join rezervacija on rezervacija.[idTermin] = termin.[idTermin] GROUP BY termin.[vrijemePocetka] ORDER BY brojRezervacija DESC LIMIT 1"; 

            prikaz.Items.Add(DB.Instance.DohvatiVrijednost(sqlUpit).ToString()); 
        }

        private void btnNajviseKoristenTeren_Click(object sender, EventArgs e)
        {
            prikaz.Items.Clear();
            string sqlUpit = "SELECT teren.[nazivTerena], COUNT(rezervacija.[idTeren]) brojRezervacijaPoTerenu FROM teren left join rezervacija on rezervacija.[idTeren] = teren.[idTeren] GROUP BY teren.[nazivTerena] ORDER BY brojRezervacijaPoTerenu DESC LIMIT 5";
            prikaz.Items.Add(DB.Instance.DohvatiVrijednost(sqlUpit).ToString());
        }

        private void btnNajcesciSport_Click(object sender, EventArgs e)
        {
            prikaz.Items.Clear();
            string sqlUpit = "SELECT teren.[sport], COUNT(rezervacija.[idTeren]) brojRezervacijaPoTerenu FROM teren left join rezervacija on rezervacija.[idTeren] = teren.[idTeren] GROUP BY teren.[nazivTerena] ORDER BY brojRezervacijaPoTerenu DESC LIMIT 5";
            prikaz.Items.Add(DB.Instance.DohvatiVrijednost(sqlUpit).ToString());
        }

        private void btnNajviseRezervacija_Click(object sender, EventArgs e)
        {
            // SQL upit za brojanje rezervacija prema korisniku  
            prikaz.Items.Clear();
            string sqlUpit = "SELECT korisnik.[imePrezimeKorisnik], COUNT(rezervacija.[idKorisnik]) brojRezervacija FROM korisnik left join rezervacija on rezervacija.[idKorisnik] = korisnik.[idKorisnik] GROUP BY korisnik.[imePrezimeKorisnik] ORDER BY brojRezervacija DESC LIMIT 1";

            prikaz.Items.Add(DB.Instance.DohvatiVrijednost(sqlUpit).ToString()); 
        }

        private void btnUkupanPrihod_Click(object sender, EventArgs e)
        {
            prikaz.Items.Clear();
            string sqlUpit = "select sum((substr(vrijemeZavrsetka,0,3)-substr(vrijemePocetka, 0,3))*cijenaSata) from teren join rezervacija on rezervacija.idTeren = teren.idTeren join termin  on termin.idTermin = rezervacija.idTermin;";
            prikaz.Items.Add(DB.Instance.DohvatiVrijednost(sqlUpit).ToString());
        }

        private void btnMjesecniPrihod_Click(object sender, EventArgs e)
        {
            prikaz.Items.Clear();
            string sqlUpit = "select sum((substr(vrijemeZavrsetka,0,3)-substr(vrijemePocetka, 0,3))*cijenaSata) from teren join rezervacija on rezervacija.idTeren = teren.idTeren join termin  on termin.idTermin = rezervacija.idTermin where substr(datumRezervacije, 6,2) = substr(current_date, 6,2)";
            prikaz.Items.Add(DB.Instance.DohvatiVrijednost(sqlUpit).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // SQL upit za brojanje rezervacija prema korisniku  
            prikaz.Items.Clear();
            string sqlUpit = "SELECT COUNT(rezervacija.[idKorisnik]) brojRezervacija FROM korisnik left join rezervacija on rezervacija.[idKorisnik] = korisnik.[idKorisnik] where korisnik.imePrezimeKorisnik LIKE '%" + textBox1.Text + "%' GROUP BY korisnik.[imePrezimeKorisnik] ";

           txtRez.Text = (DB.Instance.DohvatiVrijednost(sqlUpit).ToString()); 
        }
    }
}
