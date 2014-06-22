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
    public partial class frmRezervacije : Form
    {
        /* omogućeno kreiranje samo jedne instance određene forme */
        private static frmRezervacije instance;
        /* provjera postoji li već instanca tražene forme */
        public static frmRezervacije GetInstance()
        {
            if (instance == null)
                instance = new frmRezervacije();
            return instance;
        }
        public frmRezervacije()
        {
            InitializeComponent();
        }

        private void frmRezervacije_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void btnNovaRezervacija_Click(object sender, EventArgs e)
        {
            frmNovaRezervacija rez = new frmNovaRezervacija();
            rez.ShowDialog();
        }
    }
}
