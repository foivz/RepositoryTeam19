using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzracun_Click(object sender, EventArgs e)
        {
            int prvi = Int32.Parse(broj1.Text);
            int drugi = Int32.Parse(broj2.Text);
 
            txtRezultat.Text = (prvi + drugi).ToString();
        }

        private void rezultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtRezultat.Text = " ";
        }

    }
}
