using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    public class Estudiante
    {
        private string _nombre;
        private string _matricula;
        private string _estatus;
        private float _calificacionFinal;
        private Examen _Examen;
        private Practica _Practica;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        public string estatus
        {
            get { return _estatus; }
            set { _estatus = value; }
        }

        public float calificacionFinal
        {
            get { return _calificacionFinal; }
            set { _calificacionFinal = value; }
        }

        public Examen Examen
        {
            get { return _Examen; }
            set { _Examen = value; }
        }

        public Practica Practica
        {
            get { return _Practica; }
            set { _Practica = value; }
        }

        public float calcularCalificacionFinal()
        {
            return Practica.calcularPracticasTotal() + Examen.calcularExamenestotal();
        }

        //Query que se encarga de agregar estudiantes a la base de datos.
        public static int BDagregarEstudiante(Estudiante estudiante)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDEstudiantes.obtenerConexion())
            {
                string query = @"INSERT INTO Estudiante 
                (matricula, nombre, Examen1, Examen2, ExamenFinal, 
                Practica1, Practica2, Practica3, 
                TotalExamenes, TotalPractica, Status, CalificacionFinal) 
                VALUES 
                (@Matricula, @Nombre, @Examen1, @Examen2, @ExamenFinal, 
                @Practica1, @Practica2, @Practica3, 
                @TotalExamenes, @TotalPractica, @Status, @CalificacionFinal)";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Matricula", estudiante.matricula);
                    comando.Parameters.AddWithValue("@Nombre", estudiante.nombre);
                    comando.Parameters.AddWithValue("@Examen1", estudiante.Examen.examen1);
                    comando.Parameters.AddWithValue("@Examen2", estudiante.Examen.examen2);
                    comando.Parameters.AddWithValue("@ExamenFinal", estudiante.Examen.examenFinal);
                    comando.Parameters.AddWithValue("@Practica1", estudiante.Practica.practica1);
                    comando.Parameters.AddWithValue("@Practica2", estudiante.Practica.practica2);
                    comando.Parameters.AddWithValue("@Practica3", estudiante.Practica.practica3);
                    comando.Parameters.AddWithValue("@TotalExamenes", estudiante.Examen.calcularExamenestotal());
                    comando.Parameters.AddWithValue("@TotalPractica", estudiante.Practica.calcularPracticasTotal());
                    comando.Parameters.AddWithValue("@Status", estudiante.estatus);
                    comando.Parameters.AddWithValue("@CalificacionFinal", estudiante.calificacionFinal);

                    retorno = comando.ExecuteNonQuery();
                }
            }

            //1 = OK 0 = ERROR
            return retorno;
        }

        public static bool ExisteMatricula(string matricula)
        {
            using (SqlConnection conexion = BDEstudiantes.obtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM Estudiante WHERE matricula = @matricula";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@matricula", matricula);
                int count = (int)comando.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
