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
    public partial class frmNovaRezervacija : Form
    {
        public frmNovaRezervacija()
        {
            InitializeComponent();

            this.idKorisnik.DataPropertyName = "idKorisnik";
            this.imePrezimeKorisnik.DataPropertyName = "imePrezimeKorisnik";
            this.emailKorisnik.DataPropertyName = "emailKorisnik";
            this.telefonKorisnik.DataPropertyName = "telefonKorisnik";

            List<KorisniciClass> listaKor = KorisniciClass.DohvatiKorisnike();
            // omogucavanje sortiranja liste korisnika uz pomoc SortableBindingList klase
            SortableBindingList<KorisniciClass> sortiranaListaKor = new SortableBindingList<KorisniciClass>(listaKor);
            this.dgvKorisnici.DataSource = sortiranaListaKor;

            this.idTeren.DataPropertyName = "idTeren";
            this.nazivTeren.DataPropertyName = "nazivTerena";
            this.sport.DataPropertyName = "sport";
            this.opis.DataPropertyName = "opis";
            this.cijenaSata.DataPropertyName = "cijenaSata";

            List<TereniClass> listaTer = TereniClass.DohvatiTerene();
            SortableBindingList<TereniClass> sortiranaListaTer = new SortableBindingList<TereniClass>(listaTer);
            this.dgvTereni.DataSource = sortiranaListaTer;
        }

        private void frmNovaRezervacija_Load(object sender, EventArgs e)
        {
            OsvjeziKorisnike();
            OsvjeziTerene();
            OsvjeziListu();
        }

        public void OsvjeziKorisnike()
        {
            List<KorisniciClass> listaKor = KorisniciClass.DohvatiKorisnike();
            SortableBindingList<KorisniciClass> sortiranaListaKor = new SortableBindingList<KorisniciClass>(listaKor);
            this.dgvKorisnici.DataSource = sortiranaListaKor;
        }

        public void OsvjeziTerene()
        {
            List<TereniClass> listaTer = TereniClass.DohvatiTerene();
            SortableBindingList<TereniClass> sortiranaListaTer = new SortableBindingList<TereniClass>(listaTer);
            this.dgvTereni.DataSource = sortiranaListaTer;
        }

        private void btnNoviKorisnik_Click(object sender, EventArgs e)
        {
            frmNoviKorisnik noviKorisnik = new frmNoviKorisnik();
            noviKorisnik.ShowDialog();
            OsvjeziKorisnike();
        }

        private void btnObrisiKorisnika_Click(object sender, EventArgs e)
        {
            if(dgvKorisnici.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvKorisnici.SelectedRows)
                {
                    KorisniciClass odabraniKorisnik = row.DataBoundItem as KorisniciClass;
                    odabraniKorisnik.Obrisi();
                }
            }
            OsvjeziKorisnike();
        }

        private void btnIzmjeniKorisnika_Click(object sender, EventArgs e)
        {
            if (dgvKorisnici.SelectedRows.Count > 0)
            {
                KorisniciClass odabraniKorisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as KorisniciClass;
                frmNoviKorisnik noviKorisnik = new frmNoviKorisnik(odabraniKorisnik);
                noviKorisnik.ShowDialog();
                OsvjeziKorisnike();   
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OsvjeziListu()
        {
            DateTime start = new DateTime(2010, 1, 1, 0, 0, 0);
            DateTime end = new DateTime(2100, 1, 1, 0, 0, 0);
            DateTime selection = new DateTime(kalendar.SelectionRange.Start.Year, kalendar.SelectionRange.Start.Month, kalendar.SelectionRange.Start.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            DateTime now = DateTime.Now;
            int vrijeme = 6;
            for (;vrijeme <= 23; vrijeme++)
            {
                if ((selection > start) && (selection < now))
                   listaVremena.Items.Add(vrijeme.ToString() + ":00 Termin je istekao.");
                if ((selection > now) && (selection < end))
                    listaVremena.Items.Add(vrijeme.ToString() + ":00 Prazan termin !");
            }
        }

        private void UnosTermina() // unosim termine u bazu podataka
        {
            DateTime datumRez = new DateTime(kalendar.SelectionRange.Start.Year, kalendar.SelectionRange.Start.Month, kalendar.SelectionRange.Start.Day, listaVremena.SelectedIndex + 6, 0, 0);
            DateTime vrijemePocRez = datumRez;
            int trajanjeRez = (int)numBrSati.Value;
            DateTime vrijemeZavRez = new DateTime(kalendar.SelectionRange.Start.Year, kalendar.SelectionRange.Start.Month, kalendar.SelectionRange.Start.Day, listaVremena.SelectedIndex + 6 + trajanjeRez, 0, 0);
            
            TerminiClass noviTermin = new TerminiClass();
            noviTermin.VrijemePocetka = vrijemePocRez.ToString("HH:mm:ss");
            noviTermin.VrijemeZavrsetka = vrijemeZavRez.ToString("HH:mm:ss");
            noviTermin.Trajanje = trajanjeRez;
            noviTermin.DatumRezervacije = datumRez.ToString("yyyy-MM-dd");
            noviTermin.Spremi();

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            int a, b, c;
            // dohvacanje idKorisnika preko selektiranog reda
            int selectedRowIndexK = dgvKorisnici.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRowK = dgvKorisnici.Rows[selectedRowIndexK];
            a = Convert.ToInt32(selectedRowK.Cells["IdKorisnik"].Value);

            // dohvacanje idTerena preko selektiranog reda
            int selectedRowIndexT = dgvTereni.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRowT = dgvTereni.Rows[selectedRowIndexT];
            b = Convert.ToInt32(selectedRowT.Cells["IdTeren"].Value);

            UnosTermina();
            // Dohvačanje najveceg idTeren
            string sqlUpit = "SELECT MAX(idTermin) FROM Termin;";
            c = Convert.ToInt32(DB.Instance.DohvatiVrijednost(sqlUpit));
            // spremanje dohvacenih id-eva u bazu
            RezervacijeAkcijeClass rez = new RezervacijeAkcijeClass(a, b, c);
            rez.Spremi();

            this.Close();          
        }

        private void kalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            listaVremena.Items.Clear();
            OsvjeziListu();
        }

    }
}
