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

        public bool UspjesnaPrijava = false;
        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            UspjesnaPrijava = true;
            this.Close();
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
           
        }


    }
}
