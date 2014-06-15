using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace RezervacijeSportskihTerena
{
    class DB
    {
        private static DB instance;  //Singleton objekt
        private string connectionString;  //Putanja i ostali podaci za spajanje na bazu
        private SQLiteConnection connection; //Konekcija prema bazi
        public static DB Instance //Singleton instanca klase za rad za bazom.
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB();
                }
                return instance;
            }
        }

        public string ConnectionString //Putanja i ostali podaci za spajanje na bazu
        {
            get { return connectionString; }
            private set { connectionString = value; }
        }

        public SQLiteConnection Connection //Konekcija prema bazi
        {
            get { return connection; }
            private set { connection = value; }
        }

        private DB()  //Konstruktor klase
        {
            ConnectionString = @"Data source = ...\...\Baza\RST_DB.db";
            Connection = new SQLiteConnection(ConnectionString);
            Connection.Open();
        }

        ~DB()  //Destruktor klase
        {
            //Connection.Close();  OVA LINIJA STVARA SLJEDEĆI EXCEPTION kod izlaza iz aplikacije, samo ako je vršeno spajanje na bazu
            //An unhandled exception of type 'System.ObjectDisposedException' occurred in System.Data.SQLite.dll
            //Additional information: Cannot access a disposed object.
            Connection = null;
        }

        /// <summary>
        /// Dohvaća podatke u obliku DataReader objekta na temelju proslijeđenog upita.
        /// </summary>
        /// <param name="sqlUpit">SQL upit.</param>
        /// <returns>Rezultati upita.</returns>
        public SQLiteDataReader DohvatiDataReader(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        /// <summary>
        /// Dohvaća skalarnu vrijednost kao rezultat proslijeđenog upita.
        /// </summary>
        /// <param name="sqlUpit">SQL upit.</param>
        /// <returns>Skalarna vrijednost kao rezultat upita.</returns>
        public object DohvatiVrijednost(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        /// <summary>
        /// Izvršava INSERT, UPDATE, DELETE SQL izraz.
        /// </summary>
        /// <param name="sqlUpit">INSERT, UPDATE, DELETE SQL izraz.</param>
        /// <returns>Broj redaka u tablici koji su promijenjeni.</returns>
        public int IzvrsiUpit(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }

    }
}
