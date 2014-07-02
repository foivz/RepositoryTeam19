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

        private List<TerminiClass> listaTermina;
        private List<RezervacijeAkcijeClass> listaTrmn;

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
            this.nazivVrsta.DataPropertyName = "nazivVrsta";
            this.opis.DataPropertyName = "opis";
            this.cijenaSata.DataPropertyName = "cijenaSata";

            List<TereniClass> listaTer = TereniClass.DohvatiTerene();
            // omogucavanje sortiranja liste terena uz pomoc SortableBindingList klase
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
            listaVremena.Items.Clear();
            // dohvacanje idTerena preko selektiranog reda
            int selectedRowIndexT = dgvTereni.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRowT = dgvTereni.Rows[selectedRowIndexT];
            int idTrn = Convert.ToInt32(selectedRowT.Cells["IdTeren"].Value);
            // dohvacanje liste sa id-evima termina
            listaTrmn = TerminiClass.DohvatiTermineIzRezervacije(kalendar.SelectionRange.Start, idTrn); 
            // dohvacanje liste sa terminima za ispis
            listaTermina = TerminiClass.DohvatiIspravneTermine(kalendar.SelectionRange.Start, listaTrmn);
            bool test = false;
            int vrijeme = 6;
            for (; vrijeme <= 23; vrijeme++)
            {
                test = true;
                foreach (TerminiClass t in listaTermina)
                {
                    String value = t.VrijemePocetka;
                    String[] token = value.Split(',');
                    String[] datetime = token[0].Split(' ');
                    String timeText = datetime[1];
                    DateTime time = Convert.ToDateTime(timeText);
                    if (time.Hour == vrijeme) 
                    {
                        KorisniciClass nazivKor = new KorisniciClass();
                        nazivKor.ImePrezimeKorisnik = KorisniciClass.DohvatiNazivKorisnika(t.IdTermin);
                        listaVremena.Items.Add(time.ToString("HH:mm") + " " + nazivKor.ImePrezimeKorisnik);
                        test = false;
                        break;
                    }
                }
                        
                if (test)
                {
                    if ((vrijeme > 5) && (vrijeme < 10))
                        listaVremena.Items.Add("0" + vrijeme.ToString() + ":00 Prazan termin!");
                    else
                        listaVremena.Items.Add(vrijeme.ToString() + ":00 Prazan termin!");
                }
            }
     
        }

        private void UnosTermina() // unosim termine u bazu podataka
        {
            DateTime datumRez = new DateTime(kalendar.SelectionRange.Start.Year, kalendar.SelectionRange.Start.Month, kalendar.SelectionRange.Start.Day, listaVremena.SelectedIndex + 6, 0, 0);
            DateTime vrijemePocRez = datumRez;
            DateTime vrijemeZavRez;
            try 
            { 
                vrijemeZavRez = new DateTime(kalendar.SelectionRange.Start.Year, kalendar.SelectionRange.Start.Month, kalendar.SelectionRange.Start.Day, listaVremena.SelectedIndex + 7, 0, 0);  
            }
            catch (System.ArgumentOutOfRangeException)
            {
                vrijemeZavRez = new DateTime(kalendar.SelectionRange.Start.Year, kalendar.SelectionRange.Start.Month, kalendar.SelectionRange.Start.Day, 0, 0, 0);  
            }

            TerminiClass noviTermin = new TerminiClass();
            noviTermin.VrijemePocetka = vrijemePocRez.ToString("HH:mm:ss");
            noviTermin.VrijemeZavrsetka = vrijemeZavRez.ToString("HH:mm:ss");
            noviTermin.DatumRezervacije = datumRez.ToString("yyyy-MM-dd");
            noviTermin.Spremi();

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            // Nijedan termin iz liste termina nije odabran
            if (this.listaVremena.SelectedIndex == -1) 
            {
                MessageBox.Show("Odaberite jedan od slobodnih termina.");
                return;
            }
            // Provjera dali korisnik želi unjeti termin koji je istekao
            DateTime datumRez = new DateTime(kalendar.SelectionRange.Start.Year, kalendar.SelectionRange.Start.Month, kalendar.SelectionRange.Start.Day, listaVremena.SelectedIndex + 6, 0, 0);
            DateTime datumDns = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
            if (datumRez < datumDns)
            {
                DialogResult result = MessageBox.Show("Odabrani termin je istekao. Želite li svejedno unjeti rezervaciju?", "Provjera unosa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes){}
                if (result == DialogResult.No){return;}
            }
            // Provjera dali je termin zauzet/slobodan
            string vrijednostLV = listaVremena.GetItemText(listaVremena.SelectedItem);
            if (vrijednostLV.Contains("Prazan termin!") == false)
            {
                MessageBox.Show("Odabrani termin je zauzet. Pokusajte ponovo molim.");
                return;
            }
            else
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
                // Dohvaćanje najvećeg idTeren
                string sqlUpit = "SELECT MAX(idTermin) FROM Termin;";
                c = Convert.ToInt32(DB.Instance.DohvatiVrijednost(sqlUpit));

                // spremanje dohvacenih id-eva u bazu
                RezervacijeAkcijeClass rez = new RezervacijeAkcijeClass(a, b, c);
                rez.Spremi();
            }
            this.Close();          
        }

        private void kalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            OsvjeziListu();
        }

        private void dgvTereni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OsvjeziListu();
        }

    }
}
