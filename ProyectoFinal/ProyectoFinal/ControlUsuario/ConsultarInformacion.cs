using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Clases;

namespace ProyectoFinal.ControlUsuario
{
    public partial class ConsultarInformacion : UserControl
    {
        public ConsultarInformacion()
        {
            InitializeComponent();
        }

        private void GridViewConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAprobados_Click(object sender, EventArgs e)
        {
            //Query que selecciona las fila de la tabla estudiante en la que estatus es aprobado.

            string query = "SELECT * FROM Estudiante WHERE Status LIKE @status";

            using (SqlConnection conexion = BDEstudiantes.obtenerConexion()) 
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion); 
                adaptador.SelectCommand.Parameters.AddWithValue("@status", "Aprobado");
                DataTable tabla = new DataTable();

                //Se muestran en el Grid View.

                adaptador.Fill(tabla);
                GridViewConsultar.DataSource = tabla;
            }   
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //Query que selecciona todas las fila de la tabla estudiante.
            string query = "SELECT * FROM Estudiante"; 

            using (SqlConnection conexion = BDEstudiantes.obtenerConexion()) 
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion); 
                DataTable tabla = new DataTable();

                //Se muestran en el Grid View.

                adaptador.Fill(tabla);
                GridViewConsultar.DataSource = tabla; 
            }
        }

        private void btnReprobados_Click(object sender, EventArgs e)
        {
            //Query que selecciona las fila de la tabla estudiante en la que estatus es reprobado.

            string query = "SELECT * FROM Estudiante WHERE Status LIKE @status";

            using (SqlConnection conexion = BDEstudiantes.obtenerConexion())
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                adaptador.SelectCommand.Parameters.AddWithValue("@status", "Reprobado");
                DataTable tabla = new DataTable();

                //Se muestran en el Grid View.
                adaptador.Fill(tabla);
                GridViewConsultar.DataSource = tabla;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Verifica que no esten vacios los campos necesarios.

            if (string.IsNullOrEmpty(txtBusquedaNombreC.Text) && string.IsNullOrEmpty(txtBusquedaMatriculaC.Text))
            {
                MessageBox.Show("Por favor ingresa un nombre o matrícula para buscar.");
                return;
            }

            //  //Query que selecciona la fila en la base de datos que contiene el nombre o matricula en cuestion.
            string query = "SELECT * FROM Estudiante WHERE nombre LIKE @search OR matricula LIKE @search";

            using (SqlConnection conexion = BDEstudiantes.obtenerConexion())
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);

                if (string.IsNullOrEmpty(txtBusquedaNombreC.Text))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@search", "%" + txtBusquedaMatriculaC.Text + "%");
                }
                else
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@search", "%" + txtBusquedaNombreC.Text + "%");
                }

                //Llena una tabla con los datos y luego lo usamos como datasource en el gridview.

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                GridViewConsultar.DataSource = tabla;
            }
        }
    }
}
