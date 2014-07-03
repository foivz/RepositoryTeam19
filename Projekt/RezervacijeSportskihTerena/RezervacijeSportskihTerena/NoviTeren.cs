using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace RezervacijeSportskihTerena
{
    public partial class frmNoviTeren : Form
    {
        //Referenca na postojećeg zaposlenika
        private TereniClass teren = null;

        public frmNoviTeren()
        {
            InitializeComponent();
            OsvjeziComboBox();
            comboBox1.SelectedIndex = 0;
        }

        void OsvjeziComboBox()
        {
            comboBox1.Items.Clear();
            string sqlUpit = "SELECT * FROM VrstaSporta";
            SQLiteDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                string str = dr["nazivVrsta"].ToString();
                comboBox1.Items.Add(str);
            }
            dr.Close();
        }

        public frmNoviTeren(TereniClass odabraniTeren)
        {
            InitializeComponent();
            teren = odabraniTeren;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if ((txtNazivTerena.Text == "") || (txtCijenaSata.Text == "") || (comboBox1.SelectedIndex < 0))
            {
                MessageBox.Show("Polja za naziv, cijenu i vrstu terena moraju biti ispunjena.");
                return;
            }

            if(teren == null)
            {
                teren = new TereniClass();
            }
            teren.NazivTerena = txtNazivTerena.Text;
            teren.Opis = txtOpis.Text;
            teren.CijenaSata = int.Parse(txtCijenaSata.Text);
            // dohvaćamo id iz tablice s vrstom sportova te ga prosljeđujemo kod spremanja novog terena
            try
            {
                string sqlUpit = "SELECT idVrsta, nazivVrsta FROM VrstaSporta where nazivVrsta ='" + comboBox1.SelectedItem.ToString() + "'";
                int IdVrsta = Convert.ToInt32(DB.Instance.DohvatiVrijednost(sqlUpit).ToString());
                teren.Spremi(IdVrsta);  
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNoviTeren_Load(object sender, EventArgs e)
        {
            OsvjeziComboBox();
            /* Popunjavanje forme sa postojećim podacima unesenog terena */
            if (teren != null)
            {
                txtIDTeren.Text = teren.IdTeren.ToString();
                txtOpis.Text = teren.Opis.ToString();
                txtNazivTerena.Text = teren.NazivTerena.ToString();
                txtCijenaSata.Text = teren.CijenaSata.ToString();
                comboBox1.SelectedItem = teren.NazivVrsta.ToString();
            }
        }

        private void txtNazivTerena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ' ')     // Dozvoljava samo slova, brojeve, space i backspace
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

        private void btnDodajVrstuTerena_Click(object sender, EventArgs e)
        {
            string sqlUpit = "INSERT INTO VrstaSporta ('nazivVrsta') " + "VALUES ('" + txtVrsta.Text +"');"; 
            DB.Instance.IzvrsiUpit(sqlUpit);
            OsvjeziComboBox();
        }


    }
}
