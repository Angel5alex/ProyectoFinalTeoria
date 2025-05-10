using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Clases;
using System.Data.Entity;

namespace ProyectoFinal.ControlUsuario
{
    public partial class Registrar_calificacion : UserControl
    {
        public Registrar_calificacion()
        {
            InitializeComponent();
        }

        private void lblPromedioExamenes_Click(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        
        float practica1, practica2, practica3, examen1, examen2, examenFinal, calificacionFinal, totalExamenes, totalPracticas,promedioPractica,promedioExamen;
        bool continuar = false;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //OBJETOS NECESARIOS

            Estudiante estudiante = new Estudiante();
            estudiante.Practica = new Practica();
            estudiante.Examen = new Examen();

            //Recopilación de datos

            estudiante.nombre = txtNombre.Text;

            estudiante.matricula = txtMatricula.Text;

            if (float.TryParse(txtPractica1.Text, out practica1))
            {
                estudiante.Practica.practica1 = practica1;
            }

            if (float.TryParse(txtPractica2.Text, out practica2))
            {
                estudiante.Practica.practica2 = practica2;
            }

            if (float.TryParse(txtPractica3.Text, out practica3))
            {
                estudiante.Practica.practica3 = practica3;
            }

            if (float.TryParse(txtParcial1.Text, out examen1))
            {
                estudiante.Examen.examen1 = examen1;
            }

            if (float.TryParse(txtParcial2.Text, out examen2))
            {
                estudiante.Examen.examen2 = examen2;
            }

            if (float.TryParse(txtExamenFinal.Text, out examenFinal))
            {
                estudiante.Examen.examenFinal = examenFinal;
            }

            //Comprabacion de Datos, Evitar calificaciones menores a 50 y mayores  a 100.

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtMatricula.Text)
                || practica1 < 50 || practica1 > 100 || practica2 < 50 || practica2 > 100 || practica3 < 50 || practica3 > 100 || examen1 < 50 || examen1 > 100
                || examen2 < 50 || examen2 > 100 || examenFinal < 50 || examenFinal > 100)
            {
                MessageBox.Show("Debe completar todos los campos necesarios (Nombre,Matricula,Practicas,Examenes.) Teniendo en cuenta que calificacion máxima es 100 y mínima 50");
                continuar = false;
            }

            else
            {
                continuar = true;
            }

            //Calculos en caso de que todos los campos hayan sido rellenados correctamente.

            if (continuar != false)
            {
                estudiante.Practica.calcularPromedio();
                estudiante.Examen.calcularPromedio();

                promedioPractica = estudiante.Practica.promedio;
                promedioExamen = estudiante.Examen.promedio;

                int promedioPracticaRedondeado = (int)Math.Round(promedioPractica);
                int promedioExamenRedondeado = (int)Math.Round(promedioExamen);

                totalExamenes = estudiante.Examen.calcularExamenestotal();
                totalPracticas = estudiante.Practica.calcularPracticasTotal();
                calificacionFinal = estudiante.calcularCalificacionFinal();
                estudiante.calificacionFinal = estudiante.calcularCalificacionFinal();

                //Se muestran los datos totales por pantalla.

                txtPromedioPracticas.Text = totalPracticas.ToString();
                txtPromedioExamenes.Text = totalExamenes.ToString();
                txtCalificacionFinal.Text = calificacionFinal.ToString();

                //Aqui se le envia los datos del promedio a las graficas.

                GraficaPromedioPractica.Value = int.Parse(promedioPracticaRedondeado.ToString());
                GraficaPromedioExamen.Value = int.Parse(promedioExamenRedondeado.ToString());

                //Se verifica estatus del estudiante

                if (calificacionFinal > 70)
                {
                    estudiante.estatus = "Aprobado";
                }
                else
                {
                    estudiante.estatus = "Reprobado";
                }

                txtStatus.Text = estudiante.estatus;

                //Verificar si el estudiante ya existe.

                if(Estudiante.ExisteMatricula(estudiante.matricula))
                {
                    MessageBox.Show("Este estudiante ya existe.No ha sido agregado...");
                    return; 
                }

                //Agregar el estudiante a la base de datos.

                if (Estudiante.BDagregarEstudiante(estudiante) > 0)
                {
                    MessageBox.Show("Estudiante agregado correctamente.");
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar al estudiante.");

                }
            }
        }
        private void GraficaPromedioPractica_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }


    }
}
