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
    public partial class frmIzvjestaj : Form
    {
        /* omogućeno kreiranje samo jedne instance određene forme */
        private static frmIzvjestaj instance;
        /* provjera postoji li već instanca tražene forme */
        public static frmIzvjestaj GetInstance()
        {
            if (instance == null)
                instance = new frmIzvjestaj();
            return instance;
        }
        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        private void frmIzvjestaj_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }
    }
}
