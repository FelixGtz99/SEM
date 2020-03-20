using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SEM
{
   public  class Conexion
    {
       private int userID = 0;
        
        public NpgsqlConnection con = new NpgsqlConnection();
        public int USER {
            get { return userID; }  
            set { userID = value; }  
        }
        public void iniciar() {

            try
            {
                con.ConnectionString = "Username = AdminDB; Password=1234; Host = localhost; Port = 5432; Database = SEM";
                con.Open();
                Console.WriteLine("Conexion hecha correctamente");
             
            }
            catch (Exception x)
            {
                Console.WriteLine("Error de conexion");

            }
        }

        public int Login(String email, String pass) {
            String query = "SELECT expediente FROM usuarios WHERE correo=@e and contraseña=@p ";
            var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("e", email);
            cmd.Parameters.AddWithValue("p", pass);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                userID = reader.GetInt32(0);
            }
            else {
                userID = 0;
            }
            return userID;
        }
    
    } 

}

