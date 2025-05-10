using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    public class Practica : Examen
    {
        private float _practica1;
        private float _practica2;
        private float _practica3;

        public float practica1
        {
            get { return _practica1; }
            set { _practica1 = value; }
        }

        public float practica2
        {
            get { return _practica2; }
            set { _practica2 = value; }
        }

        public float practica3
        {
            get { return _practica3; }
            set { _practica3 = value; }
        }


        public override void calcularPromedio()
        {
            promedio = (practica1 + practica2 + practica3) / 3;
            baseTotal = 40;
        }

        public float calcularPracticasTotal()
        {
            calcularPromedio();
            return (promedio / 100) * baseTotal;
        }


    }
}
