using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.ControlUsuario;

namespace ProyectoFinal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        //Metodo para mostrar el control de usuario respectivo al presionar su botón.
        private void agregarControlUsuario(UserControl controlUsuario)
        {
            controlUsuario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(controlUsuario);
            controlUsuario.BringToFront();
        }
        
        private void btnRegistrarCalificacion_Click(object sender, EventArgs e)
        {
            Registrar_calificacion controlUsuario = new Registrar_calificacion();
            agregarControlUsuario(controlUsuario);
        }

        private void btnModificarCalificacion_Click(object sender, EventArgs e)
        {
            ModificarCalificacion controlUsuario = new ModificarCalificacion();
            agregarControlUsuario(controlUsuario);
        }

        private void btnConsultarInformacion_Click(object sender, EventArgs e)
        {
            ConsultarInformacion controlUsuario = new ConsultarInformacion();
            agregarControlUsuario(controlUsuario);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            INFO controlUsuario = new INFO();
            agregarControlUsuario(controlUsuario);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
