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

        public void OsvjeziTerene()
        {
            List<TereniClass> listaTer = TereniClass.DohvatiTerene();
            dgvTereni.DataSource = listaTer;
        }

        private void frmTereni_Load(object sender, EventArgs e)
        {
            OsvjeziTerene();
        }

        private void btnNoviTeren_Click(object sender, EventArgs e)
        {
            frmNoviTeren noviTeren = new frmNoviTeren();
            noviTeren.ShowDialog();
            OsvjeziTerene();
        }

        private void btnIzmjeniTeren_Click(object sender, EventArgs e)
        {
            if (dgvTereni.SelectedRows.Count > 0)
            {
                TereniClass odabirTerena = dgvTereni.SelectedRows[0].DataBoundItem as TereniClass;
                frmNoviTeren noviTeren = new frmNoviTeren(odabirTerena);
                noviTeren.ShowDialog();
                OsvjeziTerene();
            }
        }

        private void btnObrisiTeren_Click(object sender, EventArgs e)
        {
            if (dgvTereni.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow row in dgvTereni.SelectedRows)
                {
                    TereniClass odabirTerena = row.DataBoundItem as TereniClass;
                    odabirTerena.Obrisi();
                }
                OsvjeziTerene();
            }
        }



    }
}
