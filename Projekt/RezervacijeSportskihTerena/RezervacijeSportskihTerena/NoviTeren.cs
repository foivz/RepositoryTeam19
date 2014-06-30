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

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if ((txtNazivTerena.Text == "") || (txtCijenaSata.Text == ""))
            {
                MessageBox.Show("Polja za naziv i cijenu moraju biti ispunjena.");
                return;
            }

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
            /* Popunjavanje forme sa postojećim podacima unesenog terena */
            if (teren != null)
            {
                txtIDTeren.Text = teren.IdTeren.ToString();
                txtOpis.Text = teren.Opis.ToString();
                txtNazivTerena.Text = teren.NazivTerena.ToString();
                txtVrstaTerena.Text = teren.Sport.ToString();
                txtCijenaSata.Text = teren.CijenaSata.ToString();
            }
        }

        private void txtNazivTerena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '\b')     // Dozvoljava samo slova, brojeve i backspace
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtVrstaTerena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == '\b')     // Dozvoljava samo slova i backspace
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtCijenaSata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')     // Dozvoljava samo brojeve i backspace
                e.Handled = false;
            else
                e.Handled = true;
        }


    }
}
