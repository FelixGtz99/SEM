using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SEM.items;
using System.Collections;


namespace SEM
{
    public class Conexion
    {
        private int userID = 0;
        private String pass = "", nombre="",apellido="", correo="", carrera="", SelectedTeacher="", SelectedClass="";

        private List<Maestro> Maestros=new List<Maestro>();
        private List<Materia> Materias = new List<Materia>();
        private List<Materia> Clases = new List<Materia>();
        public NpgsqlConnection con = new NpgsqlConnection();
        public int USER {
            get { return userID; }
            set { userID = value; }
        }
        public string CARRERA
        {
            get { return carrera; }
            set { carrera= value; }
        }
        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string APELLIDO
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string CONTRA
        {
            get { return pass; }
            set { pass = value; }
        }
        public string SMaestro
        {
            get { return SelectedTeacher; }
            set { SelectedTeacher= value; }
        }
        public string SMateria
        {
            get { return SelectedClass; }
            set { SelectedClass = value; }
        }
        public List<Maestro> MAESTROS
        {
            get { return Maestros; }
            set { Maestros = value; }
        }
        public List<Materia> CLASES
        {
            get { return Clases; }
            set { Clases = value; }
        }
        public List<Materia> MATERIAS
        {
            get { return Materias; }
            set { Materias = value; }
        }
        public void iniciar() {

            try
            {
                con.ConnectionString = "Username = usr217210185; Password=pw217210185; Host = localhost; Port = 5432; Database = SEM";
                con.Open();
                Console.WriteLine("Conexion hecha correctamente");

            }
            catch (Exception)
            {
                Console.WriteLine("Error de conexion");

            }
        }

        public int Login(String email, String Pass) {

            String query = "SELECT * FROM usuarios WHERE correo=@e and contraseña=@p ";
            using (var cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("e", email);
                cmd.Parameters.AddWithValue("p", Pass);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userID = reader.GetInt32(0);
                        nombre = reader.GetString(1);
                        apellido = reader.GetString(2);
                        correo = reader.GetString(4);
                        pass = reader.GetString(3);
                        carrera = reader.GetString(5);

                    }
                }
            }
            return userID;
        }
        public Boolean CheckEnail(String email)
        {

            String query = "SELECT * FROM usuarios WHERE correo=@e";
            using (var cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("e", email);
               
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;

                    }
                    else {
                        return false;
                    }
                }
            }
            
        }
        public Boolean CheckID(String id)
        {
            int exp = Int32.Parse(id);
            String query = "SELECT expediente FROM usuarios WHERE expediente=@e ";
            using (var cmd = new NpgsqlCommand(query, con)) {
                cmd.Parameters.AddWithValue("e", exp);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
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
                correo = Correo;
                pass = Contraseña;
                carrera = Carrera;
                nombre = Nombre;
                apellido = Apellido;
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
        public void getMaterias()
        {
            String query = "SELECT id_materia, nombre_materia FROM materia ";
            using (var cmd = new NpgsqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Materia m = new Materia(reader.GetInt32(0), reader.GetString(1));
                        Materias.Add(m);
                    }
                }
            }
        }
        public void getClases(int id)
        {
            Clases.Clear();
            String query = "SELECT * FROM clases where docente=@i";
            using (var cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("i", id);
                using (var reader = cmd.ExecuteReader())
                {
                   
                    while (reader.Read())
                    {
                        foreach (Materia materia in Materias)
                        { 
                            if (reader.GetInt32(0) == materia.ID)
                            {
                                
                                Clases.Add(materia);
                            }
                        }
                    }
                }
            }
        }
        public int getLastEvaluacion() {
            int id=0;
            String query = "SELECT COUNT(*) FROM evaluacion";
            using (var cmd =new NpgsqlCommand(query, con))
            {
                using (var reader=cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                }
            }
            return id;
        }
        public void guardarEvaluacion(int idD, int idM, String Comen, int Calif) {
            String query = "INSERT INTO evaluacion(id_usuario, id_docentes, id_materia, calificacion, comentario, id_evaluacion) VALUES(@id, @d, @m, @calif, @comen, @e); ";
         
            var IDE = getLastEvaluacion() + 1;
            Console.WriteLine(idD.ToString());
            Console.WriteLine(idM.ToString());

                var cmd = new NpgsqlCommand(query, con);
               
                    cmd.Parameters.AddWithValue("id", userID);

                    cmd.Parameters.AddWithValue("d", idD);
                    cmd.Parameters.AddWithValue("m", idM);
                    cmd.Parameters.AddWithValue("calif", Calif);
                    cmd.Parameters.AddWithValue("comen", Comen);
                    cmd.Parameters.AddWithValue("e", IDE);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("va bine");
               
           

        }
        public DataTable getEvaluacion() {
            String query = "SELECT * FROM evaluacion";
            var cmd = new NpgsqlCommand(query, con);
            var datos = new NpgsqlDataAdapter(cmd);
            DataTable data = new DataTable();
            datos.Fill(data);
            return data;
        }

        public DataTable verMaestros(String m)
        {
            String query = "SELECT  (d.nombre || ' ' || d.apellido) as Maestro, AVG(e.calificacion) as Promedio FROM docentes d, evaluacion e WHERE d.id_docente=e.id_docentes AND d.nombre LIKE @m GROUP BY(d.id_docente)";
            var cmd = new NpgsqlCommand(query, con);
            Console.WriteLine(query);
            cmd.Parameters.AddWithValue("m", "%" + m + "%");
            var datos = new NpgsqlDataAdapter(cmd);
            DataTable data = new DataTable();
            Console.WriteLine(data);
            datos.Fill(data);
            
            return data;
        }
        public DataTable verMaterias(String m)
        {
            String query = "SELECT  nombre_materia as Materia FROM materia";
            var cmd = new NpgsqlCommand(query, con);
            Console.WriteLine(query);
            cmd.Parameters.AddWithValue("m", "%" + m + "%");
            var datos = new NpgsqlDataAdapter(cmd);
            DataTable data = new DataTable();
            Console.WriteLine(data);
            datos.Fill(data);

            return data;
        }
        public DataTable verClases(int i)
        {
            String query = "SELECT m.nombre_materia as Materia FROM materia m, clases c WHERE m.id_materia=c.materria AND c.docente=@id";
            var cmd = new NpgsqlCommand(query, con);
            Console.WriteLine(query);
            cmd.Parameters.AddWithValue("id",  i );
            var datos = new NpgsqlDataAdapter(cmd);
            DataTable data = new DataTable();
            Console.WriteLine(data);
            datos.Fill(data);

            return data;
        }

        public void ChangePass(String c)
        {
            String query = " UPDATE public.usuarios SET contraseña = @c   WHERE expediente = @id; ";
            try
            {
                using (var cmd = new NpgsqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("c", c);
                    cmd.Parameters.AddWithValue("id", userID);

                    cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
           
        }
        public void DeleteUser()
        {
            String query = " UPDATE public.evaluacion SET  id_usuario=0   WHERE id_usuario = @id; ";
            try
            {
                var cmd = new NpgsqlCommand(query, con);
                
               cmd.Parameters.AddWithValue("id", userID);

                    cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            String query2 = " UPDATE public.votos SET  id_usuario=0   WHERE id_usuario = @id; ";
            try
            {
                var cmd = new NpgsqlCommand(query2, con);
                
                    cmd.Parameters.AddWithValue("id", userID);

                    cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            String query3 =  "DELETE FROM public.usuarios WHERE expediente = @id; ";
            try
            {
                var cmd = new NpgsqlCommand(query3, con);
                
                    cmd.Parameters.AddWithValue("id", userID);

                    cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
        public int getIDMaestro() {
            int id=0;
            foreach (Maestro maestro in MAESTROS)
            {
                if (maestro.ToString().Equals(SMaestro))
                {
                    id = maestro.ID;
                }
            }

            return id;
        }
        public int getIDMateria()
        {
            int id = 0;
            foreach (Materia materia in Materias)
            {
                if (materia.ToString().Equals(SMateria))
                {
                    id = materia.ID;
                }
            }

            return id;
        }
        public DataTable verEvaluaciones()
        {
            Console.WriteLine(getIDMateria());
            Console.WriteLine(getIDMaestro());
            String query = "SELECT comentario, calificacion, likes AS Me_gusta, dislikes AS No_me_gusta FROM evaluacion WHERE id_docentes=@idD and id_materia=@idM";
            var cmd = new NpgsqlCommand(query, con);
            Console.WriteLine(query);
            cmd.Parameters.AddWithValue("idD", getIDMaestro());
            cmd.Parameters.AddWithValue("idM", getIDMateria());
            var datos = new NpgsqlDataAdapter(cmd);
            DataTable data = new DataTable();
            Console.WriteLine(data);
            datos.Fill(data);

            return data;
        }
    } 



}

