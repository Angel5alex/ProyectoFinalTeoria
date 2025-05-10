using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;

namespace ProyectoFinal.Clases
{
    public class BDEstudiantes : DbContext
    {

        public static SqlConnection obtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDEstudiante;Data Source=DESKTOP-T5KF8DN\\SQLEXPRESS\r\n");
            conexion.Open();

            return conexion;
        }

    }
}
