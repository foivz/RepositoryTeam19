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
    public partial class frmTereni : Form
    {
        /* omogućeno kreiranje samo jedne instance određene forme */
        private static frmTereni instance;
        /* provjera postoji li već instanca tražene forme */
        public static frmTereni GetInstance()
        {
            if (instance == null)
                instance = new frmTereni();
            return instance;
        }
        public frmTereni()
        {
            InitializeComponent();
        }

        private void frmTereni_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* prilikom izlaska, forma se dealocira kako bi se mogla kasnije ponovno pokrenuti */
            instance = null;
        }
    }
}
