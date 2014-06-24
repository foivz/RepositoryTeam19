﻿using System;
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
        }

        public void OsvjeziKorisnike()
        {
            List<KorisniciClass> listaKor = KorisniciClass.DohvatiKorisnike();
            dgvKorisnici.DataSource = listaKor;
        }

        public void OsvjeziTerene()
        {
            List<TereniClass> listaTer = TereniClass.DohvatiTerene();
            dgvTereni.DataSource = listaTer;
        }

        private void frmNovaRezervacija_Load(object sender, EventArgs e)
        {
            OsvjeziKorisnike();
            OsvjeziTerene();
            OsvjeziListu();
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
            int vrijeme = 6;
            for (;vrijeme <= 23; vrijeme++)
            {
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

        private void button1_Click(object sender, EventArgs e)
        {
            UnosTermina();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            int a, b;
            // dohvacanje idKorisnika preko selektiranog reda
            if (dgvKorisnici.SelectedRows.Count > 0)
            {
                int selectedRowIndexK = dgvKorisnici.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRowK = dgvKorisnici.Rows[selectedRowIndexK];
                a = Convert.ToInt32(selectedRowK.Cells["IdKorisnik"].Value);
                MessageBox.Show(a.ToString());
            }
            // dohvacanje idTerena preko selektiranog reda
            if (dgvTereni.SelectedRows.Count > 0)
            {
                int selectedRowIndexT = dgvTereni.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRowT = dgvTereni.Rows[selectedRowIndexT];
                b = Convert.ToInt32(selectedRowT.Cells["IdTeren"].Value);
                MessageBox.Show(b.ToString());
            }

            /*   NASTAVITI OVDJE !!! upit vraća 0
            string sqlUpit = "SELECT MAX(idTermin) FROM Termin;";
            c = DB.Instance.IzvrsiUpit(sqlUpit);
            MessageBox.Show(c.ToString());
             */           
        }


    }
}