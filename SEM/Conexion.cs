using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SEM.items;

namespace SEM
{
    public class Conexion
    {
        private int userID = 0;
        private List<Maestro> Maestros=new List<Maestro>();

        public NpgsqlConnection con = new NpgsqlConnection();
        public int USER {
            get { return userID; }
            set { userID = value; }
        }
        public List<Maestro> MAESTROS
        {
            get { return Maestros; }
            set { Maestros = value; }
        }
        public void iniciar() {

            try
            {
                con.ConnectionString = "Username = AdminDB; Password=1234; Host = localhost; Port = 5432; Database = SEM";
                con.Open();
                Console.WriteLine("Conexion hecha correctamente");

            }
            catch (Exception)
            {
                Console.WriteLine("Error de conexion");

            }
        }

        public int Login(String email, String pass) {

            String query = "SELECT expediente FROM usuarios WHERE correo=@e and contraseña=@p ";
            using (var cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("e", email);
                cmd.Parameters.AddWithValue("p", pass);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userID = reader.GetInt32(0);
                    }
                }
            }
            return userID;
        }
        //Esta el metodo pero no esta utilizado 
        public Boolean CheckID(String id)
        {
            int exp = Int32.Parse(id);
            String query = "SELECT expediente FROM usuarios WHERE expediente=@e ";
            using (var cmd = new NpgsqlCommand(query, con)) {
                cmd.Parameters.AddWithValue("e", exp);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return true;
                    }
                }
            }
            return false;
        }



        public int RegisterUser(String Expediente, String Nombre, String Apellido, String Contraseña, String Correo, String Carrera) {
            String query = "INSERT INTO usuarios (expediente, nombre, apellido, contraseña, correo, carrera) VALUES(@e, @n, @a, @pass, @email, @ca) ";
            try
            {
                userID = int.Parse(Expediente);
                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("e", userID);

                    cmd.Parameters.AddWithValue("n", Nombre);
                    cmd.Parameters.AddWithValue("a", Apellido);
                    cmd.Parameters.AddWithValue("pass", Contraseña);
                    cmd.Parameters.AddWithValue("email", Correo);
                    cmd.Parameters.AddWithValue("ca", Carrera);

                    cmd.ExecuteNonQueryAsync();
                }

            }
            catch (Exception ex) {
                userID = 0;
                Console.WriteLine(ex.Message);

            }
            return userID;
        }


        public void getMaestros() {
            String query = "SELECT * FROM docentes ";
            using (var cmd = new NpgsqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader()) { 
                while (reader.Read())
                {
                    Maestro m = new Maestro(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetString(3));
                  
                    Maestros.Add(m);
                }
            }
        } }
    } 

}

