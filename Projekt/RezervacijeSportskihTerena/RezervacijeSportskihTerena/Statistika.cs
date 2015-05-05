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
        private frmStatistika()
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
            string sqlUpit = "SELECT termin.[vrijemePocetka], COUNT(rezervacija.[idTermin]) brojRezervacija FROM termin join rezervacija on rezervacija.[idTermin] = termin.[idTermin] GROUP BY termin.[vrijemePocetka] ORDER BY brojRezervacija DESC;";

            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);
           // prikaz.Items.Add(DB.Instance.DohvatiVrijednost(sqlUpit).ToString());
            lblNaslovRubrike.Text = "Najkorišteniji termini";
            int br = 1;
            while (popis.Read())
            {
              prikaz.Items.Add(br.ToString() + ". " + popis.GetString(0));
              br++;
            }  
        }

        private void btnNajviseKoristenTeren_Click(object sender, EventArgs e)
        {
            prikaz.Items.Clear();

            /* dohvaćanje najkorištenijih terena */
            string sqlUpit = "SELECT teren.[nazivTerena], COUNT(rezervacija.[idTeren]) brojRezervacijaPoTerenu FROM teren join rezervacija on rezervacija.[idTeren] = teren.[idTeren] GROUP BY teren.[nazivTerena] ORDER BY brojRezervacijaPoTerenu DESC";

            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);

            lblNaslovRubrike.Text = "Najkorišteniji tereni";
            int br = 1;
            while (popis.Read())
            {
                prikaz.Items.Add(br + ". " + popis.GetString(0));
                br++;
            }
            chartTeren.Visible = true;
            chartTeren.BringToFront();
            TereniGraf();

        }
        private void TereniGraf()
        {
            // dohvaćanje broja rezervacija prema terenu
            string sqlUpit = "select distinct nazivTerena, count(idrezervacija) as broj from teren join rezervacija on rezervacija.idTeren = teren.idTeren join termin  on termin.idTermin = rezervacija.idTermin where substr(datumrezervacije,0,8) = substr(current_date,0,8)  GROUP BY teren.idvrsta";

            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);

            string sqlUpit2 = "SELECT count(*) from teren join rezervacija on rezervacija.idTeren = teren.IdTeren JOIN termin on rezervacija.idtermin = termin.idtermin where substr(datumRezervacije, 0,8) = substr(current_date,0,8);";
            
            int ukupno = Convert.ToInt32(DB.Instance.DohvatiVrijednost(sqlUpit2));

            /* resetiranje grafa kako bi se izbjegli duplikati */
            foreach (var series in chartTeren.Series)
            {
                series.Points.Clear();
            }
            /* punjenje grafa podacima */
            while (popis.Read())
            {
                decimal a = decimal.Round((Convert.ToDecimal(popis.GetValue(1).ToString()) / ukupno) * 100, 2, MidpointRounding.AwayFromZero);
                chartTeren.Series["Tereni"].Points.AddXY(popis.GetString(0), a);
            }     
        }

        private void btnNajcesciSport_Click(object sender, EventArgs e)
        {
            prikaz.Items.Clear();
            
            /* pretraga sporta čiji su tereni najkorišteniji */
            string sqlUpit = "select distinct VrstaSporta.[nazivVrsta], count(idrezervacija) as broj from rezervacija join teren on rezervacija.idteren = teren.idteren join vrstaSporta on teren.idvrsta = vrstasporta.idvrsta join termin on termin.idTermin = rezervacija.idTermin where substr(datumrezervacije,0,8) = substr(current_date,0,8)  GROUP BY vrstasporta.idvrsta;";

            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);

            int br = 1;
            while (popis.Read())
            {
                prikaz.Items.Add(br+". "+popis.GetString(0));
                br++;
            }  
            lblNaslovRubrike.Text = "Najčešći sportovi";
            chartSport.Visible = true;
            chartSport.BringToFront();
            SportGraf();     
        }

        private void SportGraf()
        {
            string sqlUpit = "select distinct VrstaSporta.[nazivVrsta], count(idrezervacija) as broj from rezervacija join teren on rezervacija.idteren = teren.idteren join vrstaSporta on teren.idvrsta = vrstasporta.idvrsta join termin on termin.idTermin = rezervacija.idTermin where substr(datumrezervacije,0,8) = substr(current_date,0,8)  GROUP BY vrstasporta.idvrsta";


            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);

            //string sqlUpit2 = "SELECT count(*) from teren join VrstaSporta on teren.idVrsta = VrstaSporta.idVrsta JOIN rezervacija on rezervacija.idTeren = teren.IdTeren JOIN termin on rezervacija.idtermin = termin.idtermin where substr(datumRezervacije, 6,2) = substr(current_date,6,2);";

            string sqlUpit2 = "select count(*) from rezervacija join termin on termin.idtermin = rezervacija.idtermin where substr(datumRezervacije, 0,8) = substr(current_date,0,8);";
            int ukupno = Convert.ToInt32(DB.Instance.DohvatiVrijednost(sqlUpit2));

            /* resetiranje grafa kako bi se izbjegli duplikati */
            foreach (var series in chartSport.Series)
            {
                series.Points.Clear();
            }
            /* punjenje grafa podacima */
            while (popis.Read())
            {
                decimal a = decimal.Round((Convert.ToDecimal(popis.GetValue(1).ToString()) / ukupno) * 100, 2, MidpointRounding.AwayFromZero);
                chartSport.Series["Sport"].Points.AddXY(popis.GetString(0), a);
            }
        }

        private void btnNajviseRezervacija_Click(object sender, EventArgs e)
        {
            // SQL upit za brojanje rezervacija prema korisniku  
            prikaz.Items.Clear();
            string sqlUpit = "SELECT korisnik.[imePrezimeKorisnik], COUNT(rezervacija.[idKorisnik]) brojRezervacija FROM korisnik join rezervacija on rezervacija.[idKorisnik] = korisnik.[idKorisnik] GROUP BY korisnik.[imePrezimeKorisnik] ORDER BY brojRezervacija DESC";

            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);
            int br = 1;
            while (popis.Read())
            {
                prikaz.Items.Add(br + ". " + popis.GetString(0));
                br++;
            }
            lblNaslovRubrike.Text = "Korisnici s najviše rezervacija";
            chartKorisnik.Visible = true;
            chartKorisnik.BringToFront();
            KorisniciGraf();
        }

        private void KorisniciGraf()
        {
            string sqlUpit = "SELECT korisnik.[imePrezimeKorisnik], COUNT(rezervacija.[idKorisnik]), sum(cijenaSata) brojRezervacija FROM korisnik join rezervacija on rezervacija.[idKorisnik] = korisnik.[idKorisnik] join teren on teren.idteren = rezervacija.idteren join termin on rezervacija.idtermin = termin.idtermin GROUP BY korisnik.[imePrezimeKorisnik] having substr(datumRezervacije, 6,2) = substr(current_date,6,2)";
            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);

            /* resetiranje grafa kako bi se izbjegli duplikati */
            foreach (var series in chartKorisnik.Series)
            {
                series.Points.Clear();
            }
            /* punjenje grafa podacima */
            while (popis.Read())
            {
                chartKorisnik.Series["Prihod po korisniku (kn)"].Points.AddXY(popis.GetString(0), popis.GetValue(2));
                chartKorisnik.Series["Broj rezervacija"].Points.AddXY(popis.GetString(0), popis.GetValue(1));
                                       
            }
        }

        private void btnUkupanPrihod_Click(object sender, EventArgs e)
        {
            prikaz.Items.Clear();
            string sqlUpit = "select sum(cijenaSata) from teren join rezervacija on rezervacija.idTeren = teren.idTeren join termin  on termin.idTermin = rezervacija.idTermin;";
            prikaz.Items.Add(DB.Instance.DohvatiVrijednost(sqlUpit).ToString()+" kuna");
            lblNaslovRubrike.Text = "Ukupan ostvaren prihod";
        }

        private void btnMjesecniPrihod_Click(object sender, EventArgs e)
        {
            prikaz.Items.Clear();

            /* dohvaćanje terena i mjesečne sume za taj teren */
            string sqlUpit = "select distinct nazivTerena, sum(cijenaSata) from teren join rezervacija on rezervacija.idTeren = teren.idTeren join termin  on termin.idTermin = rezervacija.idTermin where substr(datumrezervacije,0,8) = substr(current_date,0,8) GROUP BY teren.[idTeren]";

            /* dohvaćanje ukupne mjesečne sume */
            string sqlUpit2 = "select sum(cijenaSata) from teren join rezervacija on rezervacija.idTeren = teren.idTeren join termin  on termin.idTermin = rezervacija.idTermin where rezervacija.[idTermin] =  termin.[idTermin] and substr(datumrezervacije,0,8) = substr(current_date,0,8)";

            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);

            while (popis.Read())
            {
                prikaz.Items.Add(popis.GetString(0)+": "+popis.GetValue(1)+" kuna");
            }
            prikaz.Items.Add("");
            prikaz.Items.Add("\nUkupno: "+DB.Instance.DohvatiVrijednost(sqlUpit2).ToString()+" kuna");
            lblNaslovRubrike.Text = "Prikaz mjesečnih prihoda po terenima";

            chartMjesecniPrihodi.Visible = true; 
            chartMjesecniPrihodi.BringToFront();

            MjesecniPrihodGraf();
        }
        private void MjesecniPrihodGraf()
        {
           string sqlUpit = "select distinct nazivTerena, sum(cijenaSata) from teren join rezervacija on rezervacija.idTeren = teren.idTeren join termin  on termin.idTermin = rezervacija.idTermin where substr(datumrezervacije,0,8) = substr(current_date,0,8) GROUP BY teren.[idTeren]";

            SQLiteDataReader popis = DB.Instance.DohvatiDataReader(sqlUpit);

            /* brisanje dosadašnjih podataka iz grafa kako bi se izbjegli duplikati */
            foreach (var series in chartMjesecniPrihodi.Series)
            {
                series.Points.Clear();
            }

            /* dohvat podataka i punjenje grafa */
            while (popis.Read())
            {
                chartMjesecniPrihodi.Series["Prihod (kn)"].Points.AddXY(popis.GetString(0), popis.GetValue(1));
            }

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
            txtPrihod.Text = "";
            txtRez.Text = "";
            string tekstZaPretragu = txtTrazi.Text;
            try
            {
                /* dohvat broja rezervacija prema odabranom korisniku */
                string sqlUpit = "SELECT COUNT(rezervacija.[idKorisnik]) brojRezervacija FROM korisnik join rezervacija on rezervacija.[idKorisnik] = korisnik.[idKorisnik] where korisnik.imePrezimeKorisnik LIKE UPPER('" + tekstZaPretragu + "%') GROUP BY korisnik.[imePrezimeKorisnik]";
                txtRez.Text = DB.Instance.DohvatiVrijednost(sqlUpit).ToString();

                /* dohvat sume prihoda ostvarenog za odabranog korisnika */
                string sqlUpit2 = "select sum(cijenaSata) from teren join rezervacija on rezervacija.idTeren = teren.idTeren join termin  on termin.idTermin = rezervacija.idTermin join korisnik on korisnik.idKorisnik = rezervacija.idKorisnik where korisnik.imePrezimeKorisnik LIKE UPPER('" + tekstZaPretragu + "%') GROUP BY korisnik.[imePrezimeKorisnik]";
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
