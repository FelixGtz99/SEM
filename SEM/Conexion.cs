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
        private String  pass = "", nombre = "", apellido = "", correo = "", carrera = "", SelectedTeacher = "", SelectedClass = "";

        private List<Maestro> Maestros = new List<Maestro>();
        private List<Materia> Materias = new List<Materia>();
        private List<Materia> Clases = new List<Materia>();
        public NpgsqlConnection con = new NpgsqlConnection();
        public int USER
        {
            get { return userID; }
            set { userID = value; }
        }
        public string CARRERA
        {
            get { return carrera; }
            set { carrera = value; }
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
            set { SelectedTeacher = value; }
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
        //Arranca la conexion
        public void iniciar()
        {

            try
            {
                con.ConnectionString = "Username = upvmsjnvr3z0v9eomuvj; Password=7Sl66uKFKaVzyLgaEx8H; Host = b4cpheum57cmqfqw9rqn-postgresql.services.clever-cloud.com; Port = 5432; Database = b4cpheum57cmqfqw9rqn";
                con.Open();
                Console.WriteLine("Conexion hecha correctamente");

            }
            catch (Exception)
            {
                Console.WriteLine("Error de conexion");

            }
        }
        //Observa si existe esta combinacion email contraseña
        public int Login(String email, String Pass)
        {

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
        //Comprueba si existe el correo
        public Boolean CheckEmail(String email)
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
                    else
                    {
                        return false;
                    }
                }
            }

        }
        //Comprueba si existe un usuario con el mismo expediente
        public Boolean CheckID(String id)
        {
            int exp = Int32.Parse(id);
            String query = "SELECT expediente FROM usuarios WHERE expediente=@e ";
            using (var cmd = new NpgsqlCommand(query, con))
            {
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


        //Inserta los datos del usuario en la base de datos
        public int RegisterUser(String Expediente, String Nombre, String Apellido, String Contraseña, String Correo, String Carrera)
        {
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
            catch (Exception ex)
            {
                userID = 0;
                Console.WriteLine(ex.Message);

            }
            return userID;
        }

        //Crea una lista con los maestros
        public void getMaestros()
        {
            Maestros.Clear();
            String query = "SELECT * FROM docentes ";
            using (var cmd = new NpgsqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Maestro m = new Maestro(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));

                        Maestros.Add(m);
                    }
                }
            }
        }
        //Crea una lista con las materias
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
        //Crea una lista con las clases que da el maetro
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
        //Obtiene Cantidad de evaluaciones para designar su id
        public int getLastEvaluacion()
        {
            int id = 0;
            String query = "SELECT COUNT(*) FROM evaluacion";
            using (var cmd = new NpgsqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                }
            }
            return id;
        }
        //Guarda la evaluacion
        public void guardarEvaluacion(int idD, int idM, String Comen, int Calif)
        {
            String query = "INSERT INTO evaluacion(id_usuario, id_docentes, id_materia, calificacion, comentario, id_evaluacion, likes, dislikes, fecha) VALUES(@id, @d, @m, @calif, @comen, @e, 0, 0, @date); ";
            var date = DateTime.Now;
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
            cmd.Parameters.AddWithValue("date", date);
            cmd.ExecuteNonQuery();
            Console.WriteLine("va bine");



        }
        //Crea un tabla con los datos de con la evaluacion***Pendiente
        public DataTable getEvaluacion()
        {
            String query = "SELECT * FROM evaluacion";
            var cmd = new NpgsqlCommand(query, con);
            var datos = new NpgsqlDataAdapter(cmd);
            DataTable data = new DataTable();
            datos.Fill(data);
            return data;
        }
        public Boolean checkEvaluaciones(int idD, int idM) {
            String query = "Select * From evaluacion where id_usuario=@id AND id_docentes=@d AND id_materia= @m";
           
            var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", userID);
            cmd.Parameters.AddWithValue("d", idD);
            cmd.Parameters.AddWithValue("m", idM);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            else {
                reader.Close();
                return false;
            }
           
        }
        //Crea una tabla con todos los maestros y su promedio Corregir el tema de que puedas buscar por apellido
        public DataTable verMaestros(String m)
        {
            String query = "SELECT  (d.nombre || ' ' || d.apellido) as Maestro, AVG(e.calificacion) as Promedio, COUNT(e.calificacion) AS \"Cantidad de Evaluaciones\" FROM docentes d, evaluacion e WHERE d.id_docente=e.id_docentes  AND ((d.nombre ||' '|| d.apellido) LIKE @m OR alias LIKE @m)  GROUP BY(d.id_docente) UNION ALL SELECT (d.nombre || ' ' || d.apellido) as Maestro, 0 as Promedio, 0 FROM docentes d WHERE d.id_docente  NOT IN (SELECT e.id_docentes FROM evaluacion e) AND ((d.nombre || d.apellido) LIKE @m OR alias LIKE @m)";
            //String query = "SELECT  (d.nombre || ' ' || d.apellido) as Maestro, AVG(e.calificacion) as Promedio, COUNT(e.calificacion) AS \"Cantidad de Evaluaciones\" FROM docentes d, evaluacion e WHERE d.id_docente=e.id_docentes  AND ((d.nombre ||' '|| d.apellido) LIKE @m OR alias LIKE @m)  GROUP BY(d.id_docente)  UNION ALL SELECT (d.nombre || ' ' || d.apellido) as Maestro, 0 as Promedio, 0 FROM docentes d WHERE d.id_docente  NOT IN (SELECT e.id_docentes FROM evaluacion e) AND ((d.nombre || d.apellido) LIKE @m OR alias LIKE @m)";

            var cmd = new NpgsqlCommand(query, con);
            Console.WriteLine(query);
            cmd.Parameters.AddWithValue("m", "%" + m + "%");
            var datos = new NpgsqlDataAdapter(cmd);
            DataTable data = new DataTable();
            Console.WriteLine(data);
            datos.Fill(data);

            return data;
        }
        //Crea todas las tablas con sus materias
        public DataTable verMaterias(String m)
        {
            String query = "SELECT  nombre_materia as Materia FROM materia WHERE nombre_materia LIKE @m";
            var cmd = new NpgsqlCommand(query, con);
            Console.WriteLine(query);
            cmd.Parameters.AddWithValue("m", "%" + m + "%");
            var datos = new NpgsqlDataAdapter(cmd);
            DataTable data = new DataTable();
            Console.WriteLine(data);
            datos.Fill(data);

            return data;
        }
        //Materias de un maestro
        public DataTable verMateriasM()
        {
            String query = "SELECT (SELECT nombre_materia AS Materia FROM materia WHERE materia.id_materia = evaluacion.id_materia GROUP BY(id_materia)) AS Materia, AVG(calificacion) AS Promedio FROM evaluacion WHERE id_docentes = @doc GROUP BY(id_materia)";
            var cmd = new NpgsqlCommand(query, con);
            Console.WriteLine(query);
            cmd.Parameters.AddWithValue("doc", getIDMaestro());
            var datos = new NpgsqlDataAdapter(cmd);
            DataTable data = new DataTable();
            Console.WriteLine(data);
            datos.Fill(data);
            return data;
        }
        //Crea una tabla con laas clases del maestro seleccionado
        public DataTable verClases(int i)
        {
            String query = "SELECT m.nombre_materia as Materia FROM materia m, clases c WHERE m.id_materia=c.materria AND c.docente=@id";
            var cmd = new NpgsqlCommand(query, con);
            Console.WriteLine(query);
            cmd.Parameters.AddWithValue("id", i);
            var datos = new NpgsqlDataAdapter(cmd);
            DataTable data = new DataTable();
            Console.WriteLine(data);
            datos.Fill(data);

            return data;
        }
        //Permite el cmbio de contraseña
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //Permite borrar el usuario
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
            String query3 = "DELETE FROM public.usuarios WHERE expediente = @id; ";
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
        //Obtiene el id del maestro seleccionado
        public int getIDMaestro()
        {
            int id = 0;
            foreach (Maestro maestro in MAESTROS)
            {
                if (maestro.ToString().Equals(SMaestro))
                {
                    id = maestro.ID;
                }
            }

            return id;
        }
        //obtiene el id de la materia seleccionada
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
        //permite verlas evaluaciones
        public DataTable verEvaluaciones()
        {
            Console.WriteLine(getIDMateria());
            Console.WriteLine(getIDMaestro());
            String query = "SELECT fecha AS \"Fecha\", comentario AS \"Comentario\", calificacion AS \"Calificacion\", likes AS \"Me gusta\", dislikes AS \"No me gusta\" FROM evaluacion WHERE id_docentes=@idD and id_materia=@idM ORDER BY id_evaluacion DESC";
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
        //Ver si el usuario ya evaluo
        public Boolean checkUserEvaluation()
        {
            Console.WriteLine("Entro al check");
            String query = "SELECT * FROM evaluacion WHERE id_usuario=@idU AND id_docentes=@idD AND id_materia=@idM";
            var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("idU", USER);
            cmd.Parameters.AddWithValue("idD", getIDMaestro());
            cmd.Parameters.AddWithValue("idM", getIDMateria());
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
        }
        //Busca el id de la evaluacion hecha
        public int getIDEvaluacion(String Comentario, String Calificacion)
        {
            Console.WriteLine("Entro al check");
            int id = 0;
            String query = "SELECT id_evaluacion FROM evaluacion WHERE  id_docentes=@idD AND id_materia=@idM AND comentario=@co AND calificacion=@ca";
            var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("co", Comentario);
            cmd.Parameters.AddWithValue("ca", Int32.Parse(Calificacion));
            cmd.Parameters.AddWithValue("idD", getIDMaestro());
            cmd.Parameters.AddWithValue("idM", getIDMateria());
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);

                }

            }
            return id;
        }
        //Buscar si el usuario voto
        public Boolean chechUserVote(int id)
        {
            Console.WriteLine(USER);
            Console.WriteLine(id);
            String query = "SELECT * FROM votos WHERE id_usuario=@idU AND id_evaluacion=@idE";
            var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("idU", USER);
            cmd.Parameters.AddWithValue("idE", id);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }

        }
        //Buscar cuantos likes tienes
        public int getLikes(int id)
        {
            int likes = 0;
            String query = "SELECT likes FROM evaluacion WHERE id_evaluacion=@id";
            var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", id);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    likes = reader.GetInt32(0);
                }

            }
            return likes;
        }
        //Buscar cuantos dislikes tienes
        public int getDislikes(int id)
        {
            int dislikes = 0;
            String query = "SELECT dislikes FROM evaluacion WHERE id_evaluacion=@id";
            var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", id);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    dislikes = reader.GetInt32(0);
                }

            }
            return dislikes;
        }
        //Update likes
        public void updateLikes(int l, int id)
        {
            l++;
            String query = "UPDATE public.evaluacion SET likes=@l WHERE id_evaluacion=@id; ";
            try
            {
                var cmd = new NpgsqlCommand(query, con);


                cmd.Parameters.AddWithValue("l", l);
                cmd.Parameters.AddWithValue("id", id);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //Update dislikes
        public void updateDislikes(int d, int id)
        {
            d++;
            String query = "UPDATE public.evaluacion SET dislikes=@d WHERE id_evaluacion=@id; ";
            try
            {
                var cmd = new NpgsqlCommand(query, con);


                cmd.Parameters.AddWithValue("d", d);
                cmd.Parameters.AddWithValue("id", id);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //Update voto
        public void updateVotos(int id)
        {
            // Console.WriteLine("entras papu");

            String query = "INSERT INTO public.votos(id_evaluacion, id_usuario)  VALUES(@idE, @idU); ";
            try
            {
                var cmd = new NpgsqlCommand(query, con);


                cmd.Parameters.AddWithValue("idU", USER);
                cmd.Parameters.AddWithValue("idE", id);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //ver la actividad reciente
        public DataTable verRA()
        {
            String query = "SELECT (d.nombre || ' ' || d.apellido) as nombre, m.nombre_materia as Materia, e.comentario, e.calificacion, e.likes, e.dislikes, e.fecha FROM docentes d, evaluacion e, materia m WHERE e.id_docentes=d.id_docente AND e.id_materia=m.id_materia AND e.id_usuario!=1234 ORDER BY  e.id_evaluacion DESC limit 5";
            var cmd = new NpgsqlCommand(query, con);
            var datos = new NpgsqlDataAdapter(cmd);
            DataTable data = new DataTable();
            Console.WriteLine(data);
            datos.Fill(data);
            return data;
        }
        //Registrar Docente
        public void guardarDocente(String nombre, String apellido, String alias, List<Materia> m) 
        {
            String query = "INSERT INTO docentes(id_docente, nombre, apellido, alias, img) VALUES(@id, @n, @a, @alias,@img); ";

            var IDD = MAESTROS.Count + 1;

            var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("n", nombre);
            cmd.Parameters.AddWithValue("a", apellido);
            cmd.Parameters.AddWithValue("alias", alias);
            cmd.Parameters.AddWithValue("id", IDD);
            cmd.Parameters.AddWithValue("img", "no");
            cmd.ExecuteNonQuery();
            foreach (Materia materia in m)
            {
                guardarClaseDocente(materia.ID, IDD);
            }

        }
        //Guardar Las clases asignadas al docente
        public void guardarClaseDocente(int idM, int idD)
        {
            String query = "INSERT INTO clases(materria, docente) VALUES(@idM, @idD); ";


            var cmd = new NpgsqlCommand(query, con);

            cmd.Parameters.AddWithValue("idM", idM);
            cmd.Parameters.AddWithValue("idD", idD);
            cmd.ExecuteNonQuery();


        }
        public String getImgM() {
            String query = "SELECT img FROM docentes WHERE id_docente=@id";
            var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", getIDMaestro());
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return reader.GetString(0);
                }
                else
                {
                    return "null";
                }

            }
        }    
    }
    
}


