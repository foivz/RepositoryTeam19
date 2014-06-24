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
                rIdRezervacija = int.Parse(dr["idRezervacija"].ToString());
                rImePrezimeKorisnik = dr["imePrezimeKorisnik"].ToString();
                rEmailKorisnik = dr["emailKorisnik"].ToString();
                rTelefonKorisnik = dr["telefonKorisnik"].ToString();
                rNazivTerena = dr["nazivTerena"].ToString();
                rCijenaSata = float.Parse(dr["cijenaSata"].ToString());
                rVrijemePocetka = dr.GetString(dr.GetOrdinal("vrijemePocetka"));
                rVrijemeZavrsetka = dr.GetString(dr.GetOrdinal("vrijemeZavrsetka"));
                rDatumRezervacije = dr.GetDateTime(dr.GetOrdinal("datumRezervacije"));
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

        public int rIdRezervacija
        {
            get { return idRezervacija; }
            set { idRezervacija = value; }
        }
        public string rImePrezimeKorisnik
        {
            get { return imePrezimeKorisnik; }
            set { imePrezimeKorisnik = value; }
        }
        public string rEmailKorisnik
        {
            get { return emailKorisnik; }
            set { emailKorisnik = value; }
        }
        public string rTelefonKorisnik
        {
            get { return telefonKorisnik; }
            set { telefonKorisnik = value; }
        }
        public string rNazivTerena
        {
            get { return nazivTerena; }
            set { nazivTerena = value; }
        }
        public float rCijenaSata
        {
            get { return cijenaSata; }
            set { cijenaSata = value; }
        }
        public string rVrijemePocetka
        {
            get { return vrijemePocetka; }
            set {  vrijemePocetka = value.Substring(0, 5); }
        }
        public string rVrijemeZavrsetka
        {
            get { return vrijemeZavrsetka; }
            set { vrijemeZavrsetka = value.Substring(0, 5); }
        }
        public DateTime rDatumRezervacije
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
}
