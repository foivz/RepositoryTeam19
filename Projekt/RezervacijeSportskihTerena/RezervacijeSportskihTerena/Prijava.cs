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
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            Form glavniIzbornik = new frmGlavniIzbornik();
            glavniIzbornik.Show();
            
            
        }
    }
}
