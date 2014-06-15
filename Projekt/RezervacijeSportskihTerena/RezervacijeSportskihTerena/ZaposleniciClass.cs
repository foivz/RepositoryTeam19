﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Collections;

namespace RezervacijeSportskihTerena
{
    public class ZaposleniciClass
    {

        public ZaposleniciClass()
        {
        }

        public ZaposleniciClass(SQLiteDataReader dr)
        {
            if (dr != null)
            {
                idZaposlenik = int.Parse(dr["idZaposlenik"].ToString());
                ImeZaposlenik = dr["imeZaposlenik"].ToString();
                PrezimeZaposlenik = dr["prezimeZaposlenik"].ToString();
                KorisnickoIme = dr["korisnickoIme"].ToString();
                Lozinka = dr["lozinka"].ToString();
                Email = dr["email"].ToString();
            }
        }

        private int idZaposlenik;
        public int IdZaposlenik
        {
            get { return idZaposlenik; }
            set { idZaposlenik = value; }
        }

        private string imeZaposlenik;
        public string ImeZaposlenik
        {
            get { return imeZaposlenik; }
            set { imeZaposlenik = value; }
        }

        private string prezimeZaposlenik;
        public string PrezimeZaposlenik
        {
            get { return prezimeZaposlenik; }
            set { prezimeZaposlenik = value; }
        }

        /// <summary>
        /// Jedinstveno korisničko ime.
        /// </summary>
        private string korisnickoIme;
        public string KorisnickoIme
        {
            get 
            { 
                return korisnickoIme; 
            }
            set 
            {
                if (korisnickoIme != value)
                {
                    korisnickoIme = value;
                }
            }
        }

        private string lozinka;
        public string Lozinka
        {
            get { return lozinka; }
            set { lozinka = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Spremi()
        {
            string sqlUpit = "";

            if (IdZaposlenik == 0)        //Ako se radi o novokreiranom timu tada treba izvršiti INSERT
            {
                sqlUpit = "INSERT INTO Zaposlenik (imeZaposlenik, prezimeZaposlenik, korisnickoIme, lozinka, email) "
                        + "VALUES ('" + ImeZaposlenik + "','" + PrezimeZaposlenik + "','" + korisnickoIme + "','" + Lozinka + "','" + Email + "')";
            }
            else                //Ako se radi o izmjeni postojećeg tada treba izvršiti UPDATE
            {
                sqlUpit = "UPDATE Zaposlenik SET imeZaposlenik = '" + ImeZaposlenik
                + "', prezimeZaposlenik = '" + PrezimeZaposlenik
                + "', korisnickoIme = '" + KorisnickoIme
                + "', lozinka = '" + Lozinka
                + "', email = '" + Email
                + "' WHERE idZaposlenik = " + IdZaposlenik;

            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static List<ZaposleniciClass> DohvatiZaposlenike()
        {
            List<ZaposleniciClass> lista = new List<ZaposleniciClass>();
            string sqlUpit = "SELECT * FROM Zaposlenik";
            SQLiteDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                ZaposleniciClass zap = new ZaposleniciClass(dr);
                lista.Add(zap);
            }
            dr.Close();  //DataReader treba obavezno zatvoriti nakon uporabe.
            return lista;
        }

        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Zaposlenik WHERE idZaposlenik = " + IdZaposlenik;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }

    }
}

