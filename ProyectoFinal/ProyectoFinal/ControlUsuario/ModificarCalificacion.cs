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
    public partial class ModificarCalificacion : UserControl
    {
        public ModificarCalificacion()
        {
            InitializeComponent();
        }

        private void GridViewModificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlIdentificacionM_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Verificar que la fila este seleccionada.

            if (GridViewModificar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor selecciona una fila para modificar.");
                return;
            }

            //Recolectamos los nuevos datos de la fila seleccionada.

            DataGridViewRow fila = GridViewModificar.SelectedRows[0];


            string matricula = fila.Cells["matricula"].Value.ToString(); 
            string nombre = fila.Cells["nombre"].Value.ToString();


            decimal practica1 = Convert.ToDecimal(fila.Cells["Practica1"].Value);
            decimal practica2 = Convert.ToDecimal(fila.Cells["Practica2"].Value);
            decimal practica3 = Convert.ToDecimal(fila.Cells["Practica3"].Value);
            decimal examen1 = Convert.ToDecimal(fila.Cells["Examen1"].Value);
            decimal examen2 = Convert.ToDecimal(fila.Cells["Examen2"].Value);
            decimal examenFinal = Convert.ToDecimal(fila.Cells["ExamenFinal"].Value);

            if (practica1 < 50 || practica1 > 100 || practica2 < 50 || practica2 > 100 || practica3 < 50
                || practica3 > 100 || examen1 < 50 || examen1 > 100
                || examen2 < 50 || examen2 > 100 || examenFinal < 50 || examenFinal > 100)
            {
                MessageBox.Show(" ERROR! Calificación máxima es 100 y mínima 50");
                return;
            }

            //Hacer los calculos con los nuevos datos y verificar el nuevo estado del estudiante.

            decimal totalPractica = ((practica1 + practica2 + practica3) / 3) * 0.4m;
            decimal totalExamenes = ((examen1 + examen2 + examenFinal) / 3) * 0.6m;
            decimal calificacionFinal = totalPractica + totalExamenes;


            string status = calificacionFinal >= 70 ? "Aprobado" : "Reprobado";

            //Query para actualizar los datos en la base de datos.

            string query = "UPDATE Estudiante SET nombre = @nombre, Practica1 = @Practica1, " +
                           "Practica2 = @Practica2, Practica3 = @Practica3, Examen1 = @Examen1, " +
                           "Examen2 = @Examen2, ExamenFinal = @ExamenFinal, TotalPractica = @TotalPractica, " +
                           "TotalExamenes = @TotalExamenes, CalificacionFinal = @CalificacionFinal, " +
                           "Status = @Status WHERE matricula = @matricula";

            using (SqlConnection conexion = BDEstudiantes.obtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Agregar los datos actualizados.

                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@matricula", matricula);
                    comando.Parameters.AddWithValue("@Practica1", practica1);
                    comando.Parameters.AddWithValue("@Practica2", practica2);
                    comando.Parameters.AddWithValue("@Practica3", practica3);
                    comando.Parameters.AddWithValue("@Examen1", examen1);
                    comando.Parameters.AddWithValue("@Examen2", examen2);
                    comando.Parameters.AddWithValue("@ExamenFinal", examenFinal);
                    comando.Parameters.AddWithValue("@TotalPractica", totalPractica);
                    comando.Parameters.AddWithValue("@TotalExamenes", totalExamenes);
                    comando.Parameters.AddWithValue("@CalificacionFinal", calificacionFinal);
                    comando.Parameters.AddWithValue("@Status", status);

                    // Ejucta el query y verifica su validez.

                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro actualizado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro.");
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Verificar que los campos de busqueda no esten vacios.

            if (string.IsNullOrEmpty(txtBusquedaNombreM.Text) && string.IsNullOrEmpty(txtBusquedaMatriculaM.Text))
            {
                MessageBox.Show("Por favor ingresa un nombre o matrícula para buscar.");
                return;
            }

            //Query que selecciona la fila en la base de datos que contiene el nombre o matricula en cuestion.

            string query = "SELECT * FROM Estudiante WHERE nombre LIKE @search OR matricula LIKE @search";

            using (SqlConnection conexion = BDEstudiantes.obtenerConexion())
            {
                //Adaptador para mostrar los datos en un Grid View.

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);

                if (string.IsNullOrEmpty(txtBusquedaNombreM.Text))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@search", "%" + txtBusquedaMatriculaM.Text + "%");
                }
                else
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@search", "%" + txtBusquedaNombreM.Text + "%");
                }

                //Usamos una tabla para utilizar como datasource para el Grid View.
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                GridViewModificar.DataSource = tabla;

                if (tabla.Rows.Count > 0)
                {
                    // Si encuentra registros, llena los TextBox.

                    txtNombreM.Text = tabla.Rows[0]["nombre"].ToString();
                    txtMatriculaM.Text = tabla.Rows[0]["matricula"].ToString();
                    txtCalificacionFinalM.Text = tabla.Rows[0]["CalificacionFinal"].ToString();
                    txtStatusM.Text = tabla.Rows[0]["Status"].ToString();
                }
                else
                {
    
                    MessageBox.Show("No se encontró ningún estudiante con esos datos.");

                    txtNombreM.Clear();
                    txtMatriculaM.Clear();
                    txtCalificacionFinalM.Clear();
                    txtStatusM.Clear();
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Query que elimina la fila que contiene la matricula o el nombre seleccionado.

            string query = "DELETE FROM Estudiante WHERE matricula = @matricula OR nombre = @nombre";

            using (SqlConnection conexion = BDEstudiantes.obtenerConexion())
            {

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@matricula", txtMatriculaM.Text);
                    comando.Parameters.AddWithValue("@nombre", txtNombreM.Text);

                    //Ejecuta el query, FilasAfectdas = 1 OK, FilasAfectadas =  ERROR.
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro eliminado exitosamente.");
                        txtNombreM.Clear();
                        txtMatriculaM.Clear();
                        txtCalificacionFinalM.Clear();
                        txtStatusM.Clear();
                        GridViewModificar.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro para eliminar.");
                    }
                }
            }
        }
    }
    
}
