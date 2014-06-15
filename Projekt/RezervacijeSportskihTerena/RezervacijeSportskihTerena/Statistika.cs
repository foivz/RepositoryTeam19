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
    }
}
