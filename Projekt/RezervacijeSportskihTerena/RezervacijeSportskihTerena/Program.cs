using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RezervacijeSportskihTerena
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            /* instanciranje forme za prijavu i zatvaranje nakon što je prijava uspješna*/
           
            frmPrijava prijava = new frmPrijava();
            Application.Run(prijava);

            if (prijava.UspjesnaPrijava)
            {
                Application.Run(new frmGlavniIzbornik(prijava.strImePrezime));
                
            }
        }
    }
}
