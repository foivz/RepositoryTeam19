using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace RezervacijeSportskihTerena
{
    public class TerminiClass
    {
	
		/// <summary> 
		/// Konstruktor za kreiranje novog termina. 
		/// </summary>
        public TerminiClass() { }

        /// <summary> 
		/// Konstruktor koji kreira Termin s podacima iz DataReader objekta. 
		/// </summary> 
		/// <param name="dr">DataReader objekt sa podacima za Terena.</param>
        public TerminiClass(SQLiteDataReader dr)
        {
            if (dr != null)
            {
                IdTermin = int.Parse(dr["idTermin"].ToString());
                VrijemePocetka = dr["vrijemePocetka"].ToString();
                VrijemeZavrsetka = dr["vrijemeZavrsetka"].ToString();
                DatumRezervacije = dr["datumRezervacije"].ToString();
            }
        }

        private int idTermin;
        private string vrijemePocetka;
        private string vrijemeZavrsetka;
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
        public string DatumRezervacije
        {
            get { return datumRezervacije; }
            set { datumRezervacije = value; }
        }

		/// <summary>
		/// Sprema vrijednosti objekta u bazu podataka.
		/// </summary>
		/// <returns>Broj redaka koji su izmijenjeni ili dodani.</returns>
        public int Spremi()
        {
            string sqlUpit = "";

            if (IdTermin == 0)        //Ako se radi o novokreiranom terminu tada treba izvršiti INSERT
            {
                sqlUpit = "INSERT INTO Termin (vrijemePocetka, vrijemeZavrsetka, datumRezervacije) "
                        + "VALUES ('" + VrijemePocetka + "','" + VrijemeZavrsetka + "','" + DatumRezervacije + "')";
            }
            else                //Ako se radi o izmjeni postojećeg tada treba izvršiti UPDATE
            {
                sqlUpit = "UPDATE Termin SET vrijemePocetka = '" + VrijemePocetka
                + "', vrijemeZavrsetka = '" + VrijemeZavrsetka
               // + "', trajanje = '" + Trajanje
                + "', datumRezervacije = '" + DatumRezervacije
                + "' WHERE idTermin = " + IdTermin;
            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Kreira listu sa podacima za prikaz, u ovisnosti sa proslijeđenim datumom i listom rezervacija iz koje se očitavaju pojedini idTermina.
        /// </summary>
        /// <returns>Lista sa podacima iz tablice termina.</returns>
        public static List<TerminiClass> DohvatiIspravneTermine(DateTime d, List<RezervacijeAkcijeClass> listaTerena)
        { 
            string datum = d.ToString("yyyy-MM-dd");
            List<TerminiClass> lista = new List<TerminiClass>();
            foreach (RezervacijeAkcijeClass r in listaTerena)
            {
                string sqlUpit = "SELECT * FROM Termin WHERE datumRezervacije IS DATE('" + datum + "') AND vrijemePocetka BETWEEN TIME('06:00:00') AND TIME('22:00:00') AND vrijemeZavrsetka BETWEEN TIME('07:00:00') AND TIME('23:00:00') AND idTermin IS " + r.IdTermin + ";";
                SQLiteDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
                while (dr.Read())
                {
                    TerminiClass tap = new TerminiClass(dr);
                    lista.Add(tap);
                }
                dr.Close(); 
            }
            return lista;
        }

        /// <summary>
        /// Kreira listu sa podacima iz rezervacije u ovisnosti sa proslijeđenim datumom i ID-em Terena.
        /// </summary>
        /// <returns>Lista sa podacima iz tablice rezervacija.</returns>
        public static List<RezervacijeAkcijeClass> DohvatiTermineIzRezervacije(DateTime d, int idTrn)
        {
            string datum = d.ToString("yyyy-MM-dd");
            List<RezervacijeAkcijeClass> lista = new List<RezervacijeAkcijeClass>();
            string sqlUpit = " SELECT * FROM Rezervacija WHERE idTeren IS " + idTrn + "; ";
            SQLiteDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                RezervacijeAkcijeClass tap = new RezervacijeAkcijeClass(dr);
                lista.Add(tap);
            }
            dr.Close();          
            return lista;
        }


  
    }
}
