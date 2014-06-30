using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Collections;

namespace RezervacijeSportskihTerena
{
    public class RezervacijeClass
    {
		/// <summary> 
		/// Konstruktor za kreiranje nove rezervacije. 
		/// </summary>
        public RezervacijeClass() {}

		/// <summary> 
		/// Konstruktor koji kreira Rezervaciju s podacima iz DataReader objekta. 
		/// </summary> 
		/// <param name="dr">DataReader objekt sa podacima za Rezervaciju.</param>
        public RezervacijeClass(SQLiteDataReader dr)
        {
            if (dr != null)
            {
                IdRezervacija = int.Parse(dr["idRezervacija"].ToString());
                ImePrezimeKorisnik = dr["imePrezimeKorisnik"].ToString();
                EmailKorisnik = dr["emailKorisnik"].ToString();
                TelefonKorisnik = dr["telefonKorisnik"].ToString();
                NazivTerena = dr["nazivTerena"].ToString();
                CijenaSata = float.Parse(dr["cijenaSata"].ToString());
                VrijemePocetka = dr.GetString(dr.GetOrdinal("vrijemePocetka"));
                VrijemeZavrsetka = dr.GetString(dr.GetOrdinal("vrijemeZavrsetka"));
                DatumRezervacije = dr.GetDateTime(dr.GetOrdinal("datumRezervacije"));
            }
        }

        private int idRezervacija;
        private string imePrezimeKorisnik;
        private string emailKorisnik;
        private string telefonKorisnik;
        private string nazivTerena;
        private float cijenaSata;
        private string vrijemePocetka;
        private string vrijemeZavrsetka;
        private DateTime datumRezervacije;

        public int IdRezervacija
        {
            get { return idRezervacija; }
            set { idRezervacija = value; }
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
        public string NazivTerena
        {
            get { return nazivTerena; }
            set { nazivTerena = value; }
        }
        public float CijenaSata
        {
            get { return cijenaSata; }
            set { cijenaSata = value; }
        }
        public string VrijemePocetka
        {
            get { return vrijemePocetka; }
            set {  vrijemePocetka = value.Substring(0, 5); }
        }
        public string VrijemeZavrsetka
        {
            get { return vrijemeZavrsetka; }
            set { vrijemeZavrsetka = value.Substring(0, 5); }
        }
        public DateTime DatumRezervacije
        {
            get { return datumRezervacije; }
            set { datumRezervacije = value; }
        } 

		/// <summary> 
		/// Dohvaća sve rezervacije iz baze i vraća ih u obliku generičke liste. 
		/// </summary> 
		/// <returns>Lista rezervacija.</returns> 
        public static List<RezervacijeClass> DohvatiRezervacije()
        {
            List<RezervacijeClass> lista = new List<RezervacijeClass>();
            string sqlUpit = "select idRezervacija, imePrezimeKorisnik, emailKorisnik, telefonKorisnik, nazivTerena, cijenaSata, vrijemePocetka,  vrijemeZavrsetka, datumRezervacije from rezervacija join teren on rezervacija.idTeren = teren.idTeren join korisnik on rezervacija.idKorisnik=korisnik.idKorisnik join termin on rezervacija.idTermin = termin.idTermin;";
            SQLiteDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                RezervacijeClass rap = new RezervacijeClass(dr);
                lista.Add(rap);
            }
            dr.Close();  //DataReader treba obavezno zatvoriti nakon uporabe.
            return lista;
        }
    }

    public class RezervacijeAkcijeClass 
    {
        public RezervacijeAkcijeClass() { }

        /// <summary> 
        /// Konstruktor za spremanje nove rezervacije. 
        /// </summary>
        public RezervacijeAkcijeClass(int idKor, int idTrn, int idTmn)
        {
            IdKorisnik = idKor;
            IdTeren = idTrn;
            IdTermin = idTmn;
        }

        /// <summary> 
		/// Konstruktor koji kreira id-eve iz Rezervacija s podacima iz DataReader objekta. 
		/// </summary> 
		/// <param name="dr">DataReader objekt sa podacima za Terena.</param>
        public RezervacijeAkcijeClass(SQLiteDataReader dr)
        {
            if (dr != null)
            {
                IdKorisnik = int.Parse(dr["idKorisnik"].ToString());
                IdTeren = int.Parse(dr["idTeren"].ToString());
                IdTermin = int.Parse(dr["idTermin"].ToString());
            }
        }

        private int idKorisnik;
        private int idTeren;
        private int idTermin;

        public int IdKorisnik
        {
            get { return idKorisnik; }
            set { idKorisnik = value; }
        }
        public int IdTeren
        {
            get { return idTeren; }
            set { idTeren = value; }
        }
        public int IdTermin
        {
            get { return idTermin; }
            set { idTermin = value; }
        }

        /// <summary>
        /// Sprema vrijednosti objekta u bazu podataka.
        /// </summary>
        public int Spremi()
        {
            string sqlUpit = "";
            sqlUpit = "INSERT INTO Rezervacija (idKorisnik, idTeren, idTermin) "
                        + "VALUES ('" + IdKorisnik + "','" + IdTeren + "','" + IdTermin + "')";

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze podataka.
        /// </summary>
        /// <returns>Broj obrisanih redaka.</returns>
        public int Obrisi(int IdRezervacija)
        {
            string sqlDelete = "DELETE FROM Rezervacija WHERE idRezervacija = " + IdRezervacija;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }
    }

    
    
}
