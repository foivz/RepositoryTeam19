﻿using System;
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
        public KorisniciClass()
        {
        }

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

        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Korisnik WHERE idKorisnik = " + IdKorisnik;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }

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

    }
}
