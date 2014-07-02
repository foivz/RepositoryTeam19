using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Collections;

namespace RezervacijeSportskihTerena
{
    public class TereniClass
    {
		
		/// <summary> 
		/// Konstruktor za kreiranje novog terena. 
		/// </summary>
        public TereniClass()
        {
        }

		/// <summary> 
		/// Konstruktor koji kreira Teren s podacima iz DataReader objekta. 
		/// </summary> 
		/// <param name="dr">DataReader objekt sa podacima za Terena.</param>
        public TereniClass(SQLiteDataReader dr)
        {
            if (dr != null)
            {
                IdTeren = int.Parse(dr["idTeren"].ToString());
                NazivTerena = dr["nazivTerena"].ToString();
                NazivVrsta = dr["nazivVrsta"].ToString();
                Opis = dr["opis"].ToString();
                CijenaSata = int.Parse(dr["cijenaSata"].ToString());
            }
        }

        private int idTeren;
        private string nazivTerena;
        private string nazivVrsta;
        private string opis;
        private int cijenaSata;


        public int IdTeren
         {
            get { return idTeren; }
            set { idTeren = value; }
        }
        public string NazivTerena
        {
            get { return nazivTerena; }
            set { nazivTerena = value; }
        }
        public string NazivVrsta
        {
            get { return nazivVrsta; }
            set { nazivVrsta = value; }
        }
        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }
        public int CijenaSata
        {
            get { return cijenaSata; }
            set { cijenaSata = value; }
        }
        
		/// <summary>
		/// Sprema vrijednosti objekta u bazu podataka.
		/// </summary>
		/// <returns>Broj redaka koji su izmijenjeni ili dodani.</returns>
        public int Spremi(int IdVrsta)
        {
            string sqlUpit = "";

            if (IdTeren == 0)        //Ako se radi o novokreiranom timu tada treba izvršiti INSERT
            {
                sqlUpit = "INSERT INTO Teren (nazivTerena, opis, cijenaSata, idVrsta) " //, sport
                        + "VALUES ('" + NazivTerena + "','" + Opis + "','" + CijenaSata + "','" + IdVrsta + "')"; //+ "','" + Sport
            }
            else                //Ako se radi o izmjeni postojećeg tada treba izvršiti UPDATE
            {
                sqlUpit = "UPDATE Teren SET nazivTerena = '" + NazivTerena
                //+ "', sport = '" + Sport
                + "', opis = '" + Opis
                + "', cijenaSata = '" + CijenaSata
                + "', idVrsta = '" + IdVrsta
                + "' WHERE idTeren = " + IdTeren;
            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

		/// <summary>
		/// Briše objekt iz baze podataka.
		/// </summary>
		/// <returns>Broj obrisanih redaka.</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Teren WHERE idTeren = " + IdTeren;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }

		/// <summary>
		/// Dohvaća sve terene iz baze podataka i vraća ih u obliku generičke liste.
		/// </summary>
		/// <returns>Lista terena.</returns>
        public static List<TereniClass> DohvatiTerene()
        {
            List<TereniClass> lista = new List<TereniClass>();
            string sqlUpit = "select idTeren, nazivTerena, nazivVrsta, opis, cijenaSata from teren join VrstaSporta on teren.idvrsta=VrstaSporta.idvrsta;";
            SQLiteDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                TereniClass tap = new TereniClass(dr);
                lista.Add(tap);
            }
            dr.Close();  //DataReader treba obavezno zatvoriti nakon uporabe.
            return lista;
        }

    }   
}
