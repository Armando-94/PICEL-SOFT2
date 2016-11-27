using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Trivia_Literaria.Datos
{
    class clsDatos
    {
        private MySqlConnection cConexion = new MySqlConnection();

        public void Conectar()
        {
            string strCadenaConexion;
            strCadenaConexion = "SERVER=" + "localhost" + ";PORT=3306" + ";DATABASE=" + "TriviaAD2016" + ";UID=" + "root" + ";PWD=" + "root";
            cConexion.ConnectionString = strCadenaConexion;
            cConexion.Open();
        }

        public void Cerrar()
        {
            cConexion.Close();
        }

        public int getId_Libro(string libro) {
            int id;
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@LIBRO", libro);
            sql = "SELECT IDLIBRO FROM LIBROS WHERE NOMBRE=@LIBRO";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            id=int.Parse(com.ExecuteScalar().ToString());
            Cerrar();
            return id;
        }

        public int getId_Trivia(string trivia)
        {
            int id;
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@TRIVIA", trivia);
            sql = "SELECT IDTRIVIAS FROM TRIVIAS WHERE NOMBRE=@TRIVIA";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            id = int.Parse(com.ExecuteScalar().ToString());
            Cerrar();
            return id;
        }

        public int getId_Equipo(string equipo)
        {
            int id;
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@EQUIPO", equipo);
            sql = "SELECT ID_EQUIPO FROM EQUIPOS WHERE NOMBRE=@EQUIPO";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            id = int.Parse(com.ExecuteScalar().ToString());
            Cerrar();
            return id;
        }

        public void AgregarLibrosTrivia(Pojos.clsLibros_Trivia objLT) {
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@Libros_idLibro", objLT.Libros_idLibro);
            com.Parameters.AddWithValue("@Trivias_idTrivias", objLT.Trivias_idTrivias);
            com.Parameters.AddWithValue("@combo", objLT.combo);
            sql = "INSERT INTO libros_trivias VALUES(@Libros_idLibro,@Trivias_idTrivias,@combo)";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            com.ExecuteNonQuery();
            Cerrar();
        }

        public void AgregarEquipo(Pojos.clsAgregarEquipo objAgEq) {
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@NOMBRE",objAgEq.Nombre);
            com.Parameters.AddWithValue("@SCORE", objAgEq.ScoreFinal);
            com.Parameters.AddWithValue("@NOPARTICIPANTES", objAgEq.NoParticipantes);
            sql = "INSERT INTO Equipos (Nombre,ScoreFinal,NoParticipantes) VALUES(@NOMBRE,@SCORE,@NOPARTICIPANTES)";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            com.ExecuteNonQuery();
            Cerrar();
        }

        public bool VerificarTriviaExistente(int trivia) {
            int n;
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@TRIVIA",trivia);
            sql = "select count(Trivias_idTrivias) from Libros_Trivias where Trivias_idTrivias = @TRIVIA ";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            n=Int16.Parse(com.ExecuteScalar().ToString());
            Cerrar();
            return n!=0;
        }

        public int VerificarLibrosRegistrados(char trivia)
        {
            int n;
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@TRIVIA", trivia);
            sql = "select count(Libros_idLibro) from Libros_Trivias where combo = '@TRIVIA' ";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            n = Int16.Parse(com.ExecuteScalar().ToString());
            Cerrar();
            return n;
        }

        public string[] Equipos(char trivia) {
            string sql;
            int tri,n;
            MySqlCommand com;
            Conectar();
            com=new MySqlCommand();
            if (trivia == 'A')
            {
                tri = 1;
            }
            else {
                tri = 2;
            }
            com.Parameters.AddWithValue("@TRIVIA", tri);
            sql = "SELECT COUNT(Equipos_Id_equipo) FROM equipos_trivias WHERE Trivias_idTrivias = @TRIVIA";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            n = int.Parse(com.ExecuteScalar().ToString());
            string[] arr = new string[n];
            int aux = 0;
            MySqlDataReader dr;
            sql = "SELECT Equipos_Id_equipo FROM equipos_trivias WHERE Trivias_idTrivias = @TRIVIA";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            dr = com.ExecuteReader();
            while(dr.Read()){
                arr[aux] = dr.GetString("Equipos_Id_equipo");
                aux++;
            }
            Cerrar();
            Conectar();
            for (int o = 0; o < arr.Length;o++ )
            {
                sql = "SELECT NOMBRE FROM EQUIPOS WHERE Id_equipo = "+arr[o];
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                arr[o] = com.ExecuteScalar().ToString();
            }
            Cerrar();
            return arr;
        }

        public int[] Score(char trivia) {
            string sql;
            int tri, n;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            if (trivia == 'A')
            {
                tri = 1;
            }
            else
            {
                tri = 2;
            }
            com.Parameters.AddWithValue("@TRIVIA", tri);
            sql = "SELECT COUNT(Equipos_Id_equipo) FROM equipos_trivias WHERE Trivias_idTrivias = @TRIVIA";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            n = int.Parse(com.ExecuteScalar().ToString());
            int[] arr = new int[n];
            int aux = 0;
            MySqlDataReader dr;
            sql = "SELECT Equipos_Id_equipo FROM equipos_trivias WHERE Trivias_idTrivias = @TRIVIA";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                arr[aux] = dr.GetInt16("Equipos_Id_equipo");
                aux++;
            }
            Cerrar();
            Conectar();
            for (int o = 0; o < arr.Length; o++)
            {
                sql = "SELECT ScoreFinal FROM EQUIPOS WHERE Id_equipo = " + arr[o];
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                arr[o] = int.Parse(com.ExecuteScalar().ToString());
            }
            Cerrar();
            return arr;
        }

        public string[] Preguntas(char trivia) {
            string sql,pregunta,respuesta,libro;
            int min, max,id,id_Libro;
            Random rnd = new Random();
            string[] arr= new string[8];
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            if (trivia == 'A')
            {
                for (int i = 1; i <= 7; i++)
                {
                    sql = "SELECT min(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = "+ i +" AND UTILIZADA = 0 AND COMBO = 'A'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    min = Int16.Parse(com.ExecuteScalar().ToString());
                    sql = "SELECT max(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = " + i + " AND UTILIZADA = 0 AND COMBO = 'A'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    max = Int16.Parse(com.ExecuteScalar().ToString());
                    id = rnd.Next(min,max);
                    sql="SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = "+ id + " AND UTILIZADA = 0 AND COMBO = 'A'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    try
                    {
                        pregunta = com.ExecuteScalar().ToString();
                    }
                    catch (Exception exe)
                    {
                        pregunta = "";
                    }
                    while(pregunta.Equals("")){
                        id = rnd.Next(min, max);
                        sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0  AND COMBO = 'A'";
                        com.CommandText = sql;
                        com.CommandType = CommandType.Text;
                        com.Connection = cConexion;
                        try
                        {
                            pregunta = com.ExecuteScalar().ToString();
                        }
                        catch (Exception exe)
                        {
                            pregunta = "";
                        }
                    }
                    sql = "SELECT RESPUESTA FROM PREGUNTAS WHERE idpreguntas = " + id;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    respuesta = com.ExecuteScalar().ToString();
                    sql = "SELECT Libros_idLibros FROM PREGUNTAS WHERE idpreguntas = " + id;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    id_Libro = Int16.Parse(com.ExecuteScalar().ToString());
                    sql = "select nombre from libros where idlibro = " + id_Libro;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    libro = com.ExecuteScalar().ToString();
                    arr[i - 1] = "Libro: " + libro + "\t" + "Id: " + id + "\r\n\r\n" + pregunta + ";" + respuesta;
                }
            }
            else
            {
                for (int i = 1; i <= 7; i++)
                {
                    sql = "SELECT min(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = " + i + " AND UTILIZADA = 0 AND COMBO = 'B'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    min = Int16.Parse(com.ExecuteScalar().ToString());
                    sql = "SELECT max(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = " + i + " AND UTILIZADA = 0 AND COMBO = 'B'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    max = Int16.Parse(com.ExecuteScalar().ToString());
                    id = rnd.Next(min, max);
                    sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0 AND COMBO = 'B'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    try
                    {
                        pregunta = com.ExecuteScalar().ToString();
                    }
                    catch(Exception exe)
                    {
                        pregunta = "";
                    }
                    while (pregunta.Equals(""))
                    {
                        id = rnd.Next(min, max);
                        sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0 AND COMBO = 'B'";
                        com.CommandText = sql;
                        com.CommandType = CommandType.Text;
                        com.Connection = cConexion;
                        try
                        {
                            pregunta = com.ExecuteScalar().ToString();
                        }
                        catch (Exception exe)
                        {
                            pregunta = "";
                        }
                    }
                    sql = "SELECT RESPUESTA FROM PREGUNTAS WHERE idpreguntas = " + id;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    respuesta = com.ExecuteScalar().ToString();
                    sql = "SELECT Libros_idLibros FROM PREGUNTAS WHERE idpreguntas = " + id;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    id_Libro = Int16.Parse(com.ExecuteScalar().ToString());
                    sql = "select nombre from libros where idlibro = " + id_Libro;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    libro = com.ExecuteScalar().ToString();
                    arr[i - 1] = "Libro: " + libro + "\t" + "Id: " + id + "\r\n\r\n" + pregunta + ";" + respuesta;
                }
            }
            Cerrar();
            return arr;
        }
        
        public string Extra(char trivia) {
            string sql, pregunta, respuesta, ex,libr;
            int min, max, id, id_Libro;
            Random rnd = new Random();
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            int libro = rnd.Next(1, 7);
            if (trivia == 'A')
            {
                sql = "SELECT min(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = " + libro + " AND UTILIZADA = 0 AND COMBO = 'A'";
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                min = Int16.Parse(com.ExecuteScalar().ToString());
                sql = "SELECT max(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = " + libro + " AND UTILIZADA = 0 AND COMBO = 'A'";
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                max = Int16.Parse(com.ExecuteScalar().ToString());
                id = rnd.Next(min, max);
                sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0 AND COMBO = 'A'";
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                try
                {
                    pregunta = com.ExecuteScalar().ToString();
                }
                catch (Exception exe)
                {
                    pregunta = "";
                }
                while (pregunta.Equals(""))
                {
                    id = rnd.Next(min, max);
                    sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0 AND COMBO = 'A'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    try
                    {
                        pregunta = com.ExecuteScalar().ToString();
                    }
                    catch (Exception exe)
                    {
                        pregunta = "";
                    }
                }
                sql = "SELECT RESPUESTA FROM PREGUNTAS WHERE idpreguntas = " + id;
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                respuesta = com.ExecuteScalar().ToString();
                sql = "SELECT Libros_idLibros FROM PREGUNTAS WHERE idpreguntas = " + id;
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                id_Libro = Int16.Parse(com.ExecuteScalar().ToString());
                sql = "select nombre from libros where idlibro = " + id_Libro;
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                libr = com.ExecuteScalar().ToString();
                ex = "Libro: " + libr + "\t" + "Id: " + id + "\r\n\r\n" + pregunta + ";" + respuesta;
            }
            else
            {
                sql = "SELECT min(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = " + libro + " AND UTILIZADA = 0 AND COMBO = 'B'";
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                min = Int16.Parse(com.ExecuteScalar().ToString());
                sql = "SELECT max(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = " + libro + " AND UTILIZADA = 0 AND COMBO = 'B'";
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                max = Int16.Parse(com.ExecuteScalar().ToString());
                id = rnd.Next(min, max);
                sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0 AND COMBO = 'B'";
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                try
                {
                    pregunta = com.ExecuteScalar().ToString();
                }
                catch (Exception exe)
                {
                    pregunta = "";
                }
                while (pregunta.Equals(""))
                {
                    id = rnd.Next(min, max);
                    sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0 AND COMBO = 'B'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    try
                    {
                        pregunta = com.ExecuteScalar().ToString();
                    }
                    catch (Exception exe)
                    {
                        pregunta = "";
                    }
                }
                sql = "SELECT RESPUESTA FROM PREGUNTAS WHERE idpreguntas = " + id;
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                respuesta = com.ExecuteScalar().ToString();
                sql = "SELECT Libros_idLibros FROM PREGUNTAS WHERE idpreguntas = " + id;
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                id_Libro = Int16.Parse(com.ExecuteScalar().ToString());
                sql = "select nombre from libros where idlibro = " + id_Libro;
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                libr = com.ExecuteScalar().ToString();
                ex = "Libro: " + libr + "\t" + "Id: " + id + "\r\n\r\n" + pregunta + ";" + respuesta;
            }
            Cerrar();
            return ex;
        }

        public void Usada(string respuesta) {
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@respuesta", respuesta);
            sql = "UPDATE `triviaad2016`.`preguntas` SET `Utilizada`='1' WHERE respuesta = @respuesta";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            com.ExecuteNonQuery();
            Cerrar();
        }

        public void ActualizarScore(string equipo,int score){
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@EQUIPO",equipo);
            sql = "UPDATE `triviaad2016`.`equipos` SET `ScoreFinal`= " + "'" + score + "'" +" WHERE Nombre = @EQUIPO";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            com.ExecuteNonQuery();
            Cerrar();
        }

        public void AgregarEquipo_Trivia(string trivia,string equipo) {
            string sql;
            int tri,equi;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            if (trivia.Equals("Trivia A"))
            {
                tri = 1;
            }
            else {
                tri = 2;
            }
            com.Parameters.AddWithValue("@EQUIPO", equipo);
            sql = "SELECT ID_EQUIPO FROM EQUIPOS WHERE NOMBRE = @EQUIPO";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            equi = int.Parse(com.ExecuteScalar().ToString());
            com.Parameters.AddWithValue("@TRIVIA", tri);
            com.Parameters.AddWithValue("@EQUI", equi);
            sql = "INSERT INTO equipos_trivias VALUES (@EQUI,@TRIVIA)";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            com.ExecuteNonQuery();
            Cerrar();
        }

        public List<string> getLibros()
        {
            List<string> lstLibros = new List<string>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            Conectar();
            sql = "select nombre from libros";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Pojos.clsLibros objLibro = new Pojos.clsLibros();
                objLibro.nombre = dr.GetString("nombre");
                lstLibros.Add(objLibro.nombre);
            }
            Cerrar();
            return lstLibros;
        }

        public List<string> getEquipos()
        {
            List<string> lstEquipos = new List<string>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            Conectar();
            sql = "select nombre from equipos";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Pojos.clsEquipos objE = new Pojos.clsEquipos();
                objE.Nombre = dr.GetString("Nombre");
                lstEquipos.Add(objE.Nombre);
            }
            Cerrar();
            return lstEquipos;
        }

        public List<string> getEquiposByTrivia(int trivia) {
            List<string> lstEquipos = new List<string>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            cm.Parameters.AddWithValue("@trivia", trivia);
            Conectar();
            sql = "select e.Nombre from equipos e join equipos_trivias et on e.Id_equipo = et.Equipos_Id_equipo where et.Trivias_idTrivias = @trivia";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Pojos.clsEquipos objEquipo = new Pojos.clsEquipos();
                objEquipo.Nombre = dr.GetString("Nombre");
                lstEquipos.Add(objEquipo.Nombre);
            }
            Cerrar();
            return lstEquipos;
        }

        public List<Pojos.clsLibro_Combo> getLibroComboByTrivia(int trivia) {
            List<Pojos.clsLibro_Combo> lstLibros = new List<Pojos.clsLibro_Combo>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            cm.Parameters.AddWithValue("@trivia", trivia);
            Conectar();
            sql = "select l.nombre Libro, lt.Combo from libros l join libros_trivias lt on lt.Libros_idLibro=l.idLibro where lt.Trivias_idTrivias = @trivia";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cConexion;
            dr = cm.ExecuteReader();
            while(dr.Read()){
                Pojos.clsLibro_Combo objLC = new Pojos.clsLibro_Combo();
                objLC.Libro = dr.GetString("Libro");
                objLC.Combo = dr.GetChar("Combo");
                lstLibros.Add(objLC);
            }
            Cerrar();
            return lstLibros;
        }

        public void Agregar_Participantes(Pojos.clsParticipantes objP) {
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@ID_PARTICIPANTE", objP.id_participante);
            com.Parameters.AddWithValue("@ID_EQUIPO", objP.id_equipo);
            com.Parameters.AddWithValue("@NOMBRE", objP.Nombre);
            com.Parameters.AddWithValue("@LIBRO_DESEADO", objP.LibroDeseado);
            sql = "INSERT INTO PARTICIPANTES VALUES(@ID_PARTICIPANTE,@ID_EQUIPO,@NOMBRE,@LIBRO_DESEADO)";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            com.ExecuteNonQuery();
            Cerrar();
        }

        public void Eliminar_Equipo(string equipo) {
            string sql;
            int id;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@EQUIPO",equipo);
            sql = "select Id_equipo from equipos where Nombre = @EQUIPO";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            id = int.Parse(com.ExecuteScalar().ToString());
            com.Parameters.AddWithValue("@ID",id);
            sql = "delete from participantes where Id_equipo = @ID";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            com.ExecuteNonQuery();
            sql = "delete from equipos_trivias where Equipos_Id_equipo = @ID";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            com.ExecuteNonQuery();
            sql = "delete from equipos where Id_equipo = @ID";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            com.ExecuteNonQuery();
            Cerrar();
        }

        public List<Pojos.clsPreguntasReporte> ReportePreguntas() {
            List<Pojos.clsPreguntasReporte> listReporte = new List<Pojos.clsPreguntasReporte>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            Conectar();
            sql = "select P.Combo,P.idPreguntas Id_Pregunta, L.nombre Libro,P.Pregunta,P.Respuesta from preguntas P join libros L on P.Libros_idLibros = L.idLibro order by combo";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Pojos.clsPreguntasReporte objPR = new Pojos.clsPreguntasReporte();
                objPR.Combo = dr.GetChar("Combo");
                objPR.idPreguntas = dr.GetInt32("Id_Pregunta");
                objPR.Libro = dr.GetString("Libro");
                objPR.Pregunta = dr.GetString("Pregunta");
                objPR.Respuesta = dr.GetString("Respuesta");
                listReporte.Add(objPR);
            }
            Cerrar();
            return listReporte;
        }

        /*public List<Pojos.clsPreguntas> ObtenerPregunta()
        {
            string sql;
            MySqlCommand com = new MySqlCommand();
            Conectar();
            com = new MySqlCommand();


            List<Pojos.clsPreguntas> preguntas = new List<Pojos.clsPreguntas>();
            
       
            sql = "select * from preguntas";
            
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Pojos.clsPreguntas x = new Pojos.clsPreguntas();
                x.idPreguntas = dr.GetInt32(0);
                x.Utilizada = dr.GetInt32(1);
                x.Combo = dr.GetChar(2);
                x.Respuesta = dr.GetString(3);
                x.Pregunta = dr.GetString(4);
                x.Libros_idLibros = dr.GetInt32(5);
                preguntas.Add(x);
            }
            com.Dispose();

            /// FINALIZAMOS LA CONEXION CERRAMOS TODO
            com.Close();
            com.Dispose();
            return preguntas;
            
        }*/
    }
}