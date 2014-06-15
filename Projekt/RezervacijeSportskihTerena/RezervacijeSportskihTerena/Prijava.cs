﻿using System;
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
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        public bool UspjesnaPrijava = false;
        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            string sqlUpit = "SELECT * FROM Zaposlenik WHERE korisnickoIme = '" + this.txtKorisnickoIme.Text + "' and lozinka = '" + this.txtLozinka.Text + "' ";
            SQLiteDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            int count = 0;
            while (dr.Read())
            {
                count++;
            }

            if (count == 1)
            {
                MessageBox.Show("Prijava je uspješna.");
                UspjesnaPrijava = true;
                this.Close();
            }
            else if (count > 1)
            {
                MessageBox.Show("Pronađeno je duplo korisnicko ime i lozinka. Pokušajte ponovo.");
            }
            else if(count < 1)
            {
                MessageBox.Show("Korisničko ime i lozinka su ne ispravni. Pokušajte ponovo.");
            }
            
        }

        /// <summary>
        /// Na pritisak tipke enter izvršava pritisak tipke Prijava.
        /// </summary>
        private void frmPrijava_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPotvrda.PerformClick();
            }
        }

    }
}
