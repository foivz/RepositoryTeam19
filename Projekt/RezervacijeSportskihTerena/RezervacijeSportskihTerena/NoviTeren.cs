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
            btnDohvatiTeren.Visible = false;
        }

        public frmNoviTeren(TereniClass odabraniTeren)
        {
            InitializeComponent();
            teren = odabraniTeren;
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
            if (teren.NazivTerena == "" || teren.Sport == "" || teren.CijenaSata == null)
            {
                MessageBox.Show("Naziv, cijena i sport moraju biti popunjeni.");
                return;
            }
            teren.Spremi();
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDohvatiTeren_Click(object sender, EventArgs e)
        {
            txtIDTeren.Text = teren.IdTeren.ToString();
            txtOpis.Text = teren.Opis.ToString();
            txtNazivTerena.Text = teren.NazivTerena.ToString();
            txtVrstaTerena.Text = teren.Sport.ToString();
            txtCijenaSata.Text  = teren.CijenaSata.ToString();
        }

        private void frmNoviTren_Load(object sender, EventArgs e)
        {

        }


    }
}
