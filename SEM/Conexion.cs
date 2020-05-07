﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SEM.items;
using System.Collections;
using SEM.Forms;
using System.IO;
using System.Drawing;

namespace SEM
{
    public class Conexion
    {
        private int userID = 0, carrera=0, escuela=0;
        private String  pass = "", nombre = "", apellido = "", correo = "",  SelectedTeacher = "", SelectedClass = "", SelectedCarrier="", SelectedSchool="";

        private List<Maestro> Maestros = new List<Maestro>();
        private List<Materia> Materias = new List<Materia>();
        private List<Materia> Clases = new List<Materia>();
        private List<Carrera> Carreras = new List<Carrera>();
        private List<Escuela> Escuelas = new List<Escuela>();
        public NpgsqlConnection con = new NpgsqlConnection();
        public int USER
        {
            get { return userID; }
            set { userID = value; }
        }
        public int CARRERA
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
        public byte[] imagen
        {
            get { return imagen; }
            set { imagen = value; }
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
        
        internal List<Carrera> CARRERAS { get => Carreras; set => Carreras = value; }
        internal List<Escuela> ESCUELAS { get => Escuelas; set => Escuelas = value; }
        public string SCarrera { get => SelectedCarrier; set => SelectedCarrier = value; }
        public string SEscuela { get => SelectedSchool; set => SelectedSchool = value; }


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
                        escuela = reader.GetInt32(5);
                        carrera = reader.GetInt32(6);
                       
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
                    reader.Close();
                }
            }
            return false;
        }


        //Inserta los datos del usuario en la base de datos
        public int RegisterUser(String Expediente, String Nombre, String Apellido, String Contraseña, String Correo)
        {
            String query = "INSERT INTO usuarios (expediente, nombre, apellido, contraseña, correo, escuela, carrera) VALUES(@e, @n, @a, @pass, @email,@es, @ca) ";
            try
            {
                userID = int.Parse(Expediente);
                correo = Correo;
                pass = Contraseña;
                carrera = getIDCarrera();
                escuela = getIDEscuela();
                nombre = Nombre;
                apellido = Apellido;
                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("e", userID);

                    cmd.Parameters.AddWithValue("n", Nombre);
                    cmd.Parameters.AddWithValue("a", Apellido);
                    cmd.Parameters.AddWithValue("pass", Contraseña);
                    cmd.Parameters.AddWithValue("email", Correo);
                    cmd.Parameters.AddWithValue("ca", carrera);
                    cmd.Parameters.AddWithValue("es", escuela);

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
        //Get Escuela
        public void getEscuela() {
            String query = "SELECT e.nombre, c.nombre FROM escuela e, carrera c WHERE e.id_escuela=c.id_escuela AND c.id=@id";
            using (var cmd=new NpgsqlCommand(query,con)) {
                cmd.Parameters.AddWithValue("id", CARRERA);
                using (var reader = cmd.ExecuteReader()) {
                    if (reader.Read())
                    {
                        SEscuela = reader.GetString(0);
                        SCarrera = reader.GetString(1);
                    }
                }
            }
        }
        //Crea una lista con los maestros
        public void getMaestros()
        {
            Maestros.Clear();
            String query = "SELECT id_docente, nombre, apellido, alias FROM docentes WHERE id_carrera=@id";
            using (var cmd = new NpgsqlCommand(query, con))
            {
               
                cmd.Parameters.AddWithValue("id", CARRERA);
                using (var reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                      
                        Maestro m = new Maestro(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));

                        Maestros.Add(m);
                    }
                    reader.Close();
                }
            }
        }
        //Crea una lista con las materias
        public void getMaterias()
        {
            String query = "SELECT id_materia, nombre_materia FROM materia WHERE id_carrera=@id";
            using (var cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("id", CARRERA);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Materia m = new Materia(reader.GetInt32(0), reader.GetString(1));
                        Materias.Add(m);
                    }
                    reader.Close();
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
                                Console.WriteLine(materia.ToString());
                            }
                        }
                    }
                   // reader.Close();
                }
            }
        }
        //Crea Lista de escuelas
        public void getEscuelas()
        {
            Escuelas.Clear();
            String query = "SELECT * FROM escuela ";
            using (var cmd = new NpgsqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Escuela e = new Escuela(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        Escuelas.Add(e);
                    }
                    reader.Close();
                }
            }
        }
        //Crea Lista de carreras
        public void getCarreras()
        {
            Carreras.Clear();
            String query = "SELECT * FROM carrera WHERE id_escuela=@ide";
            using (var cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("ide", getIDEscuela());
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Carrera c = new Carrera(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                        Carreras.Add(c);
                    }
                    reader.Close();
                }
            }
        }
        //Obtiene Cantidad de evaluaciones para designar su id
        public int getLastEvaluacion()
        {
            int id = 0;
            String query = "SELECT MAX(*) FROM evaluacion";
            using (var cmd = new NpgsqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                    reader.Close();
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
            try
            {
                String query = "SELECT  (d.nombre || ' ' || d.apellido) as \"Maestro\", AVG(e.calificacion) as \"Promedio\", COUNT(e.calificacion) AS \"Cantidad de Evaluaciones\" FROM docentes d, evaluacion e WHERE d.id_docente=e.id_docentes  AND ((d.nombre ||' '|| d.apellido) LIKE @m OR alias LIKE @m)  GROUP BY(d.id_docente) UNION ALL SELECT (d.nombre || ' ' || d.apellido) as \"Maestro\", 0 as \"Promedio\", 0 FROM docentes d WHERE d.id_docente  NOT IN (SELECT e.id_docentes FROM evaluacion e) AND ((d.nombre || d.apellido) LIKE @m OR alias LIKE @m) AND id_carrera=@idC";
                //String query = "SELECT  (d.nombre || ' ' || d.apellido) as Maestro, AVG(e.calificacion) as Promedio, COUNT(e.calificacion) AS \"Cantidad de Evaluaciones\" FROM docentes d, evaluacion e WHERE d.id_docente=e.id_docentes  AND ((d.nombre ||' '|| d.apellido) LIKE @m OR alias LIKE @m)  GROUP BY(d.id_docente)  UNION ALL SELECT (d.nombre || ' ' || d.apellido) as Maestro, 0 as Promedio, 0 FROM docentes d WHERE d.id_docente  NOT IN (SELECT e.id_docentes FROM evaluacion e) AND ((d.nombre || d.apellido) LIKE @m OR alias LIKE @m)";

                var cmd = new NpgsqlCommand(query, con);
                Console.WriteLine(query);
                cmd.Parameters.AddWithValue("m", "%" + m + "%");
                cmd.Parameters.AddWithValue("idC",CARRERA);
                var datos = new NpgsqlDataAdapter(cmd);
                DataTable data = new DataTable();
                Console.WriteLine(data);
                datos.Fill(data);

                return data;
            } catch(Exception e)
            {
                SemBox sb = new SemBox("long", "Error", e.Message, "Aceptar");
                sb.Show();
                return null;
            }
            
        }
        //Crea todas las tablas con sus materias
        public DataTable verMaterias(String m)
        {
            String query = "SELECT  nombre_materia as \"Materia\" FROM materia WHERE nombre_materia LIKE @m AND id_carrera=@idC";
            var cmd = new NpgsqlCommand(query, con);
            Console.WriteLine(query);
            cmd.Parameters.AddWithValue("m", "%" + m + "%");
            cmd.Parameters.AddWithValue("idC", CARRERA);
            var datos = new NpgsqlDataAdapter(cmd);
            DataTable data = new DataTable();
            Console.WriteLine(data);
            datos.Fill(data);

            return data;
        }
        //Materias de un maestro
        public DataTable verMateriasM()
        {
            String query = "SELECT (SELECT nombre_materia AS Materia FROM materia WHERE materia.id_materia = evaluacion.id_materia GROUP BY(id_materia)) AS \"Materia\", AVG(calificacion) AS \"Promedio\" FROM evaluacion WHERE id_docentes = @doc GROUP BY(id_materia)" +
                 "UNION ALL SELECT (SELECT nombre_materia AS Materia FROM materia WHERE materia.id_materia = clases.materria) AS \"Materia\", 0 AS \"Promedio\" FROM clases WHERE docente = @doc AND clases.materria NOT IN(SELECT id_materia FROM evaluacion)";
            var cmd = new NpgsqlCommand(query, con);
            Console.WriteLine(query);
            cmd.Parameters.AddWithValue("doc", getIDMaestro());
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
        //Obtiene el id de Escuela
        public int getIDEscuela()
        {
            int id = 0;
            foreach (Escuela escuela in Escuelas)
            {
                if (escuela.ToString().Equals(SEscuela))
                {
                    id = escuela.Id;
                }
            }

            return id;
        }
        public int getIDCarrera()
        {
            int id = 0;
            foreach (Carrera carrera in Carreras)
            {
                if (carrera.ToString().Equals(SCarrera))
                {
                    id = carrera.ID;
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
            String query = "SELECT id_evaluacion, fecha AS \"Fecha\", comentario AS \"Comentario\", calificacion AS \"Calificacion\", likes AS \"Me gusta\", dislikes AS \"No me gusta\" FROM evaluacion WHERE id_docentes=@idD and id_materia=@idM ORDER BY id_evaluacion DESC";
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
                reader.Close();
            }
        }
        //Busca el id de la evaluacion hecha
       
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
                reader.Close();
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
                reader.Close();
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
                reader.Close();
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
            String query = " SELECT notificacion as \"Actividad\", fecha as \"Fecha\" FROM \"RA\" ORDER BY  fecha DESC";
            var cmd = new NpgsqlCommand(query, con);
            var datos = new NpgsqlDataAdapter(cmd);
            DataTable data = new DataTable();
            Console.WriteLine(data);
            datos.Fill(data);
            return data;
        }
        //Registrar Docente
        public void guardarDocente(String nombre, String apellido, String alias, List<Materia> m, byte[] ImgByteA) 
        {
            String query = "INSERT INTO docentes(id_docente, nombre, apellido, alias, id_carrera, upload_img) VALUES(@id, @n, @a, @alias, @idC,@Image); ";

            var IDD = MAESTROS.Count + 1;

            var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("n", nombre);
            cmd.Parameters.AddWithValue("a", apellido);
            cmd.Parameters.AddWithValue("alias", alias);
            cmd.Parameters.AddWithValue("id", IDD);
            //cmd.Parameters.AddWithValue("img", "no");
            cmd.Parameters.AddWithValue("idC", CARRERA);
           
            NpgsqlParameter param = cmd.CreateParameter();
            param.ParameterName = "@Image";
            param.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;
            param.Value = ImgByteA;
            Console.WriteLine("Aqui estan los bytes: " + Encoding.Default.GetString(ImgByteA));
            cmd.Parameters.Add(param);
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
        /*public String getImgM() {
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
        }*/
        public Byte[] getImgM2()
        {
            String query = "SELECT upload_img FROM docentes WHERE id_docente=@id";
            var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", getIDMaestro());
            byte[] productImageByte = null;
            byte[] temporal = null;
            using (var reader = cmd.ExecuteReader())

            {
                if (reader.Read()){

                    //Convert.ToInt32(reader.GetByte(0)==null);
                    if (reader.IsDBNull(0))
                    {
                        return null;
                    }
                    else
                    {
                        productImageByte =((byte[])reader[0]);
                        return productImageByte;
                    }
                }
                
                else
                {
                    Console.Write("afuera");
                    return null;
                }


            }
        }
        public void ChangeImage(byte[] ImgByteA)
        {
            String query = " UPDATE public.docentes SET upload_img = @image   WHERE id_docente = @id; ";
            try
            {
                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", getIDMaestro());
                    
                    
                    NpgsqlParameter param = cmd.CreateParameter();
                    param.ParameterName = "@Image";
                    param.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;
                    param.Value = ImgByteA;
                    Console.WriteLine("Aqui estan los bytes: " + Encoding.Default.GetString(ImgByteA));
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //Obtener notificaciones
        public DataTable getNotifications()
        {
            String query = "SELECT notificacion FROM notificaciones ";
            var cmd = new NpgsqlCommand(query, con);
           // cmd.Parameters.AddWithValue("idC", getIDCarrera());
            var datos = new NpgsqlDataAdapter(cmd);
            DataTable data = new DataTable();
            Console.WriteLine(data);
            datos.Fill(data);
            return data;
        }
        //EliminaMateria
        public void deleteMateria() {
            String query = "DELETE FROM evaluacion WHERE id_materia=@m";
            var cmd = new NpgsqlCommand(query, con);
            try
            {
                cmd.Parameters.AddWithValue("m", getIDMateria());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            String query2 = "DELETE FROM clases WHERE materria=@m";
            var cmd2 = new NpgsqlCommand(query2, con);
            try
            {
                cmd2.Parameters.AddWithValue("m", getIDMateria());
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            String query3 = "DELETE FROM materia WHERE nombre_materia=@m";
            var cmd3 = new NpgsqlCommand(query3, con);
            try
            {
                cmd3.Parameters.AddWithValue("m", SMateria);
                cmd3.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        //Agregar Materia
        public void setMateria(String Materia) {
          
            String query = "INSERT INTO public.materia(id_materia, nombre_materia, id_carrera) VALUES((SELECT MAX(id_materia) FROM materia)+1 ,@m , @c); ";
            var cmd = new NpgsqlCommand(query, con);

            cmd.Parameters.AddWithValue("m", Materia);
            cmd.Parameters.AddWithValue("c", CARRERA);
            cmd.ExecuteNonQuery();

        
        }
        //ver si es admin
        public Boolean itsAdmin() {
            String query = "SELECT * FROM carrera WHERE admin=@id";
          
            using (var cmd = new NpgsqlCommand(query, con)) {
                cmd.Parameters.AddWithValue("id", userID);
                using (var reader = cmd.ExecuteReader()) {
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
        //ver si ya evaluo perfil
        public Boolean checkProfileVote() {
            String query = "SELECT * FROM votosperfil WHERE id_docente=@idD AND id_usuario=@idU";
            var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("idD", getIDMaestro());
            cmd.Parameters.AddWithValue("idU", userID);
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
        //Votar
        public void setProfileVote(String voto) {
            String query = "INSERT INTO public.votosperfil(id_docente, id_usuario, voto) VALUES(@idD, @idU, @v); ";
            var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("idD", getIDMaestro());
            cmd.Parameters.AddWithValue("idU", userID);
            cmd.Parameters.AddWithValue("v", voto);
            cmd.ExecuteNonQuery();
            
        }
    }
    
}


