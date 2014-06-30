using System;
using System.Collections.Generic;
using System.Collections;
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
            AutoComplete();
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
           SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);

            while (popis.Read())
            {
                prikaz.Items.Add("Najčešće korišten termin: "+popis.GetString(0));
            }  
            
            //prikaz.Items.Add("Najčešće korišten termin: "+DB.Instance.DohvatiVrijednost(sqlUpit).ToString()); 
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

            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);

            while (popis.Read())
            {
                prikaz.Items.Add("Korisnik s najviše rezervacija: " + popis.GetString(0) + " " + popis.GetValue(1) + " rezervacija/e.");
            }  
            //prikaz.Items.Add(DB.Instance.DohvatiVrijednost(sqlUpit).ToString()); 
        }

        private void btnUkupanPrihod_Click(object sender, EventArgs e)
        {
            prikaz.Items.Clear();
            string sqlUpit = "select sum((substr(vrijemeZavrsetka,0,3)-substr(vrijemePocetka, 0,3))*cijenaSata) from teren join rezervacija on rezervacija.idTeren = teren.idTeren join termin  on termin.idTermin = rezervacija.idTermin;";
            prikaz.Items.Add("Ukupni prihod: " + DB.Instance.DohvatiVrijednost(sqlUpit).ToString()+" kuna.");
        }

        private void btnMjesecniPrihod_Click(object sender, EventArgs e)
        {
            prikaz.Items.Clear();
            string sqlUpit = "select sum((substr(vrijemeZavrsetka,0,3)-substr(vrijemePocetka, 0,3))*cijenaSata) from teren join rezervacija on rezervacija.idTeren = teren.idTeren join termin  on termin.idTermin = rezervacija.idTermin where substr(datumRezervacije, 6,2) = substr(current_date, 6,2)";
            prikaz.Items.Add("Mjesečni prihod: "+DB.Instance.DohvatiVrijednost(sqlUpit).ToString()+" kuna.");
        }

        /* metoda za automatsko završavanje stringa kod pretrage*/
        void AutoComplete()
        {
            txtTrazi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTrazi.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection prijedlozi = new AutoCompleteStringCollection();
            string tekstZaPretragu = txtTrazi.Text;
            string sqlUpit = "SELECT imePrezimeKorisnik FROM korisnik where korisnik.imePrezimeKorisnik LIKE UPPER('%" + tekstZaPretragu + "%')";
            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);

            try { 
                while (popis.Read())
                {
                    prijedlozi.Add(popis.GetString(0));
                    MessageBox.Show(popis.GetString(0));
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtTrazi.AutoCompleteCustomSource = prijedlozi;
        }
        private void btnTrazi_Click(object sender, EventArgs e)
        {
            // SQL upit za brojanje rezervacija prema korisniku  
            prikaz.Items.Clear();
            string sqlUpit = "SELECT COUNT(rezervacija.[idKorisnik]) brojRezervacija FROM korisnik left join rezervacija on rezervacija.[idKorisnik] = korisnik.[idKorisnik] where korisnik.imePrezimeKorisnik LIKE UPPER('%" + txtTrazi.Text + "%') GROUP BY korisnik.[imePrezimeKorisnik]";

            txtRez.Text = DB.Instance.DohvatiVrijednost(sqlUpit).ToString();
        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            prikaz.Items.Clear();
            try
            {
                string tekstZaPretragu = txtTrazi.Text;
                string sqlUpit = "SELECT imePrezimeKorisnik FROM korisnik where korisnik.imePrezimeKorisnik LIKE UPPER('%"+tekstZaPretragu+"%')";
            }
            catch
            {
                txtRez.Text = "";                
                MessageBox.Show("Nema takvog korisnika.");
                txtTrazi.Text = "";
            }

            
        }
    }
}
