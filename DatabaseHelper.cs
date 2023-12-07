using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteka
{
    public class DatabaseHelper
    {
        private string GetConnectionString()
        {
<<<<<<< HEAD
            string connString = "Server = localhost; Database = videoteka; Uid = igor2; Pwd = igor";
=======
            string connString = "Server = localhost; Database = videoteka; Uid = igor; Pwd = igor";
>>>>>>> 60f4f2cf0d628d981e60ce3494edc31675cddb44

            return connString;

        }


        public bool AutorizirajKorisnika(string username, string pwd)
        {
            bool postoji = false;
<<<<<<< HEAD


=======
>>>>>>> 60f4f2cf0d628d981e60ce3494edc31675cddb44
            var connection = new MySqlConnection(GetConnectionString());
            connection.Open();


            var command = new MySqlCommand("SELECT ime,prezime FROM korisnik " +
                "WHERE korisnicko_ime ='" + username + "' AND lozinka= '" +
                pwd + "'", connection);

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                postoji = reader.HasRows;
            }

            return postoji;

        }

        public User GetUser(string username)
        {
            User user = new User();

            var connection = new MySqlConnection(GetConnectionString());
            connection.Open();

            var command = new MySqlCommand("SELECT id, ime, prezime FROM korisnik " +
                "WHERE korisnicko_ime = '" + username + "'", connection);

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                user.ID = reader.GetInt32("id");
                user.Ime = reader.GetString("Ime");
                user.Prezime = reader.GetString("Prezime");
            }

            return user;
        }


        public List<Posudba> GetPosudba(int id_user)
        {
            List<Posudba> lista_posudbi = new List<Posudba>();

            var connection = new MySqlConnection(GetConnectionString());
            connection.Open();

            var command = new MySqlCommand("SELECT " + "p.id, p.datum_posudbe, f.naziv as NazivFilma, k.naziv as NazivKategorije, p.MaxIzdDana as MaxIzdDana " +
                " FROM posudba p " +
                "inner join filmovi f on p.id_film = f.id " +
                "inner join kategorija k on k.id =f.id_kategorija " +
                "WHERE p.id_korisnik='" + id_user + "'", connection);

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Posudba posudba = new Posudba();

                posudba.ID = reader.GetInt32("id");
                posudba.NazivFilma = reader.GetString("NazivFilma");
                posudba.NazivKategorije = reader.GetString("NazivKategorije");
                posudba.MaxIzdDana = reader.GetInt32("MaxIzdDana");

                lista_posudbi.Add(posudba);
            }

            return lista_posudbi;
        }
    }
}
