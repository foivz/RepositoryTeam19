using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervacijeSportskihTerena
{
    public class TerminiClass
    {
        public TerminiClass() { }


        private int idTermin;
        private string vrijemePocetka;
        private string vrijemeZavrsetka;
        private int trajanje;
        private string datumRezervacije;

        public int IdTermin
        {
            get { return idTermin; }
            set { idTermin = value; }
        }
        public string VrijemePocetka
        {
            get { return vrijemePocetka; }
            set { vrijemePocetka = value; }
        }
        public string VrijemeZavrsetka
        {
            get { return vrijemeZavrsetka; }
            set { vrijemeZavrsetka = value; }
        }
        public int Trajanje
        {
            get { return trajanje; }
            set { trajanje = value; }
        }
        public string DatumRezervacije
        {
            get { return datumRezervacije; }
            set { datumRezervacije = value; }
        }

        public int Spremi()
        {
            string sqlUpit = "";

            if (IdTermin == 0)        //Ako se radi o novokreiranom terminu tada treba izvršiti INSERT
            {
                sqlUpit = "INSERT INTO Termin (vrijemePocetka, vrijemeZavrsetka, trajanje, datumRezervacije) "
                        + "VALUES ('" + VrijemePocetka + "','" + VrijemeZavrsetka + "','" + Trajanje + "','" + DatumRezervacije + "')";
            }
            else                //Ako se radi o izmjeni postojećeg tada treba izvršiti UPDATE
            {
                sqlUpit = "UPDATE Termin SET vrijemePocetka = '" + VrijemePocetka
                + "', vrijemeZavrsetka = '" + VrijemeZavrsetka
                + "', trajanje = '" + Trajanje
                + "', datumRezervacije = '" + DatumRezervacije
                + "' WHERE idTermin = " + IdTermin;
            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public int DohvatiMaxIdTermina()
        {
            string sqlUpit = "SELECT MAX(idTermin) AS max_id FROM Termin;";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
    }
}
