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
            string sqlUpit = "SELECT termin.[vrijemePocetka], COUNT(rezervacija.[idTermin]) brojRezervacija FROM termin left join rezervacija on rezervacija.[idTermin] = termin.[idTermin] GROUP BY termin.[vrijemePocetka] ORDER BY brojRezervacija DESC limit 5;";

            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);
           // prikaz.Items.Add(DB.Instance.DohvatiVrijednost(sqlUpit).ToString());
            lblNaslovRubrike.Text = "Najkorišteniji termini";
            while (popis.Read())
            {
              prikaz.Items.Add(popis.GetString(0));
            }  
        }

        private void btnNajviseKoristenTeren_Click(object sender, EventArgs e)
        {
            prikaz.Items.Clear();

            /* dohvaćanje najkorištenijih terena */
            string sqlUpit = "SELECT teren.[nazivTerena], COUNT(rezervacija.[idTeren]) brojRezervacijaPoTerenu FROM teren left join rezervacija on rezervacija.[idTeren] = teren.[idTeren] GROUP BY teren.[nazivTerena] ORDER BY brojRezervacijaPoTerenu DESC LIMIT 5";

            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);

            lblNaslovRubrike.Text = "Najkorišteniji tereni";
            while (popis.Read())
            {
                prikaz.Items.Add(popis.GetString(0));
            }  
        }

        private void btnNajcesciSport_Click(object sender, EventArgs e)
        {
            prikaz.Items.Clear();
            
            /* pretraga sporta čiji su tereni najkorišteniji */
            string sqlUpit = "SELECT teren.[sport], COUNT(rezervacija.[idTeren]) brojRezervacijaPoTerenu FROM teren left join rezervacija on rezervacija.[idTeren] = teren.[idTeren] GROUP BY teren.[nazivTerena] ORDER BY brojRezervacijaPoTerenu DESC LIMIT 5";
            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);
            while (popis.Read())
            {
                prikaz.Items.Add(popis.GetString(0));
            }  
            lblNaslovRubrike.Text = "Najčešći sportovi";
        }

        private void btnNajviseRezervacija_Click(object sender, EventArgs e)
        {
            // SQL upit za brojanje rezervacija prema korisniku  
            prikaz.Items.Clear();
            string sqlUpit = "SELECT korisnik.[imePrezimeKorisnik], COUNT(rezervacija.[idKorisnik]) brojRezervacija FROM korisnik left join rezervacija on rezervacija.[idKorisnik] = korisnik.[idKorisnik] GROUP BY korisnik.[imePrezimeKorisnik] ORDER BY brojRezervacija DESC LIMIT 5";

            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);
            while (popis.Read())
            {
                prikaz.Items.Add(popis.GetString(0));
            }
            lblNaslovRubrike.Text = "Korisnici s najviše rezervacija";
        }

        private void btnUkupanPrihod_Click(object sender, EventArgs e)
        {
            prikaz.Items.Clear();
            string sqlUpit = "select sum((substr(vrijemeZavrsetka,0,3)-substr(vrijemePocetka, 0,3))*cijenaSata) from teren join rezervacija on rezervacija.idTeren = teren.idTeren join termin  on termin.idTermin = rezervacija.idTermin;";
            prikaz.Items.Add(DB.Instance.DohvatiVrijednost(sqlUpit).ToString()+" kuna");
            lblNaslovRubrike.Text = "Ukupan ostvaren prihod";
        }

        private void btnMjesecniPrihod_Click(object sender, EventArgs e)
        {
            prikaz.Items.Clear();

            /* dohvaćanje terena i mjesečne sume za taj teren */
            string sqlUpit = "select distinct nazivTerena, sum((substr(vrijemeZavrsetka,0,3)-substr(vrijemePocetka, 0,3))*cijenaSata) from teren join rezervacija on rezervacija.idTeren = teren.idTeren join termin  on termin.idTermin = rezervacija.idTermin GROUP BY termin.[idTermin]";

            /* dohvaćanje ukupne mjesečne sume */
            string sqlUpit2 = "select sum((substr(vrijemeZavrsetka,0,3)-substr(vrijemePocetka, 0,3))*cijenaSata) from teren join rezervacija on rezervacija.idTeren = teren.idTeren join termin  on termin.idTermin = rezervacija.idTermin where rezervacija.[idTermin] =  termin.[idTermin]";

            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);
            while (popis.Read())
            {
                prikaz.Items.Add(popis.GetString(0)+": "+popis.GetValue(1)+" kuna");
            }
            prikaz.Items.Add("");
            prikaz.Items.Add("\nUkupno: "+DB.Instance.DohvatiVrijednost(sqlUpit2).ToString()+" kuna");
            lblNaslovRubrike.Text = "Prikaz mjesečnih prihoda po terenima";
            
        }

        /* metoda za automatsko završavanje stringa kod pretrage*/
        void AutoComplete()
        {
            txtTrazi.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTrazi.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection prijedlozi = new AutoCompleteStringCollection();
            string tekstZaPretragu = txtTrazi.Text;
            string sqlUpit = "SELECT imePrezimeKorisnik FROM korisnik where korisnik.imePrezimeKorisnik LIKE UPPER('%" + tekstZaPretragu + "%')";
            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);

            try
            {
                while (popis.Read())
                {
                    prijedlozi.Add(popis.GetString(0));
                } // dodavanje rezultata koji se podudaraju u AutocompleteString

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
            string tekstZaPretragu = txtTrazi.Text;
            try
            {
                /* dohvat broja rezervacija prema odabranom korisniku */
                string sqlUpit = "SELECT COUNT(rezervacija.[idKorisnik]) brojRezervacija FROM korisnik left join rezervacija on rezervacija.[idKorisnik] = korisnik.[idKorisnik] where korisnik.imePrezimeKorisnik LIKE UPPER('" + tekstZaPretragu + "%') GROUP BY korisnik.[imePrezimeKorisnik]";
                txtRez.Text = DB.Instance.DohvatiVrijednost(sqlUpit).ToString();

                /* dohvat sume prihoda ostvarenog za odabranog korisnika */
                string sqlUpit2 = "select sum((substr(vrijemeZavrsetka,0,3)-substr(vrijemePocetka, 0,3))*cijenaSata) from teren join rezervacija on rezervacija.idTeren = teren.idTeren join termin  on termin.idTermin = rezervacija.idTermin join korisnik on korisnik.idKorisnik = rezervacija.idKorisnik GROUP BY korisnik.[idKorisnik]";
                if (tekstZaPretragu == "")
                {
                    txtPrihod.Text = "";
                    txtRez.Text = "";
                }
                else
                {
                    txtPrihod.Text = DB.Instance.DohvatiVrijednost(sqlUpit2).ToString()+" kuna";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Korisnik ili rezervacije za korisnika ne postoje.", ex.Message);
            }
        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            prikaz.Items.Clear();
            try
            {
                string tekstZaPretragu = txtTrazi.Text;
                string sqlUpit = "SELECT imePrezimeKorisnik FROM korisnik where korisnik.imePrezimeKorisnik LIKE UPPER('%" + tekstZaPretragu + "%')";
            }
            catch(Exception ex)
            {
                txtRez.Text = "";
                MessageBox.Show("Nema takvog korisnika.", ex.Message);
                txtTrazi.Text = "";
            }
        }
    }
}
