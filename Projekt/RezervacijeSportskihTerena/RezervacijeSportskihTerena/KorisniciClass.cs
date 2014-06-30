using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Collections;

namespace RezervacijeSportskihTerena
{
    public class KorisniciClass
    {	
		/// <summary>
		/// Konstruktor za kreiranje novog korisnika
		/// </summary>
        public KorisniciClass() {}

		/// <summary>
		/// Konstruktor koji kreira Korisnika s podacima iz DataReader objekta
		/// </summary>
		/// <param name="dr"> DataReader objekt s podacima za Korisnika.</param>
        public KorisniciClass (SQLiteDataReader dr)
        {
            if (dr != null)
            {
                IdKorisnik = int.Parse(dr["idKorisnik"].ToString());
                ImePrezimeKorisnik = dr["imePrezimeKorisnik"].ToString();
                EmailKorisnik = dr["emailKorisnik"].ToString();
                TelefonKorisnik = dr["telefonKorisnik"].ToString();
            }
        }

        private int idKorisnik;
        private string imePrezimeKorisnik;
        private string emailKorisnik;
        private string telefonKorisnik;

        public int IdKorisnik
        {
            get { return idKorisnik; }
            set { idKorisnik = value; }
        }

        public string ImePrezimeKorisnik
        {
            get { return imePrezimeKorisnik; }
            set { imePrezimeKorisnik = value; }
        }

        public string EmailKorisnik
        {
            get { return emailKorisnik; }
            set { emailKorisnik = value; }
        }

        public string TelefonKorisnik
        {
            get { return telefonKorisnik; }
            set { telefonKorisnik = value; }
        }

		/// <summary>
		/// Sprema vrijednosti objekta u bazu podataka.
		/// </summary>
		/// <returns>Broj redaka koji su izmijenjeni ili dodani.</returns>
        public int Spremi()
        {
            string sqlUpit = "";

            if (IdKorisnik == 0)        //Ako se radi o novokreiranom timu tada treba izvršiti INSERT
            {
                sqlUpit = "INSERT INTO Korisnik (imePrezimeKorisnik, emailKorisnik, telefonKorisnik) "
                        + "VALUES ('" + ImePrezimeKorisnik + "','" + EmailKorisnik + "','" + TelefonKorisnik + "')";
            }
            else                //Ako se radi o izmjeni postojećeg tada treba izvršiti UPDATE
            {
                sqlUpit = "UPDATE Korisnik SET imePrezimeKorisnik = '" + ImePrezimeKorisnik
                + "', emailKorisnik = '" + EmailKorisnik
                + "', telefonKorisnik = '" + TelefonKorisnik
                + "' WHERE idKorisnik = " + IdKorisnik;
            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

		/// <summary>
		/// Briše objekt iz baze podataka.
		/// </summary>
		/// <returns>Broj obrisanih redaka.</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Korisnik WHERE idKorisnik = " + IdKorisnik;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }

		/// <summary>
		/// Dohvaća sve korisnike iz baze podataka i vraća ih u obliku generičke liste.
		/// </summary>
		/// <returns>Lista korisnika.</returns>
        public static List<KorisniciClass> DohvatiKorisnike()
        {
            List<KorisniciClass> lista = new List<KorisniciClass>();
            string sqlUpit = "SELECT * FROM Korisnik";
            SQLiteDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                KorisniciClass kap = new KorisniciClass(dr);
                lista.Add(kap);
            }
            dr.Close();  //DataReader treba obavezno zatvoriti nakon uporabe.
            return lista;
        }

        public static string DohvatiNazivKorisnika(int idTrmn)
        {
            try
            {
                string sqlUpit = "SELECT idKorisnik FROM Rezervacija WHERE idTermin IS " + idTrmn + ";";
                string idKor = (DB.Instance.DohvatiVrijednost(sqlUpit)).ToString();
                string sqlUpitTwo = "SELECT imePrezimeKorisnik FROM Korisnik WHERE idKorisnik IS " + idKor + ";";
                return (DB.Instance.DohvatiVrijednost(sqlUpitTwo)).ToString();
            }
            catch (NullReferenceException)
            {
                return "Prazan termin!";
            }
        }

    }
}
