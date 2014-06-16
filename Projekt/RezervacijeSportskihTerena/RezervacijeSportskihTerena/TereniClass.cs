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
        public TereniClass()
        {
        }

        public TereniClass(SQLiteDataReader dr)
        {
            if (dr != null)
            {
                IdTeren = int.Parse(dr["idTeren"].ToString());
                NazivTerena = dr["nazivTerena"].ToString();
                VrstaTerena = dr["vrstaTerena"].ToString();
                RadnoVrijeme = dr["radnoVrijeme"].ToString();
                Opis = dr["opis"].ToString();
                CijenaSata = int.Parse(dr["cijenaSata"].ToString());
                Dostupnost = bool.Parse(dr["dostupnost"].ToString());
            }
        }

        private int idTeren;
        private string nazivTerena;
        private string vrstaTerena;
        private string radnoVrijeme;
        private string opis;
        private int cijenaSata;
        private bool dostupnost;

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
        public string VrstaTerena
        {
            get { return vrstaTerena; }
            set { vrstaTerena = value; }
        }
        public string RadnoVrijeme
        {
            get { return radnoVrijeme; }
            set { radnoVrijeme = value; }
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
        public bool Dostupnost
        {
            get { return dostupnost; }
            set { dostupnost = value; }
        }

        public int Spremi()
        {
            string sqlUpit = "";

            if (IdTeren == 0)        //Ako se radi o novokreiranom timu tada treba izvršiti INSERT
            {
                sqlUpit = "INSERT INTO Teren (nazivTerena, vrstaTerena, radnoVrijeme, opis, cijenaSata, dostupnost) "
                        + "VALUES ('" + NazivTerena + "','" + VrstaTerena + "','" + RadnoVrijeme + "','" + Opis + "','" + CijenaSata + "','" + Dostupnost + "')";
            }
            else                //Ako se radi o izmjeni postojećeg tada treba izvršiti UPDATE
            {
                sqlUpit = "UPDATE Teren SET nazivTerena = '" + NazivTerena
                + "', vrstaTerena = '" + VrstaTerena
                + "', radnoVrijeme = '" + RadnoVrijeme
                + "', opis = '" + Opis
                + "', cijenaSata = '" + CijenaSata
                + "', dostupnost = '" + Dostupnost
                + "' WHERE idTeren = " + IdTeren;
            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Teren WHERE idTeren = " + IdTeren;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }

        public static List<TereniClass> DohvatiTerene()
        {
            List<TereniClass> lista = new List<TereniClass>();
            string sqlUpit = "SELECT * FROM Teren";
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
