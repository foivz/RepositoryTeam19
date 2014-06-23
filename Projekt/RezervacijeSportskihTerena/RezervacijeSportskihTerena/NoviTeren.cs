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
    public partial class frmNoviTeren : Form
    {
        //Referenca na postojećeg zaposlenika
        private TereniClass teren = null;

        public frmNoviTeren()
        {
            InitializeComponent();
        }

        public frmNoviTeren(TereniClass odabraniTeren)
        {
            InitializeComponent();
            teren = odabraniTeren;
        }

        // provjerava dal je checkbox chekiran ili ne
        private bool provjeriDostupnost()
        {
            bool imaNema;
            if (chkDostupnost.Checked)
            {
                imaNema = true;
            }
            else
            {
                imaNema = false;
            }
            return imaNema;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if(teren == null)
            {
                teren = new TereniClass();
            }
            teren.NazivTerena = txtNazivTerena.Text;
            teren.Sport = txtVrstaTerena.Text;
            teren.Opis = txtOpis.Text;
            teren.CijenaSata = int.Parse(txtCijenaSata.Text);
            teren.Spremi();
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNoviTeren_Load(object sender, EventArgs e)
        {
            this.ActiveControl = chkDostupnost;
        }


    }
}
