using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    public class Examen : Evaluacion
    {

        private float _examen1;
        private float _examen2;
        private float _examenFinal;

        public float examen1
        {
            get { return _examen1; }
            set { _examen1 = value; }
        }

        public float examen2
        {
            get { return _examen2; }
            set { _examen2 = value; }
        }

        public float examenFinal
        {
            get { return _examenFinal; }
            set { _examenFinal = value; }
        }

        //Metodos de calculo de resultados.
        public virtual void calcularPromedio()
        {
            promedio = (examen1 + examen2 + examenFinal) / 3;
            baseTotal = 60;
        }

        public virtual float calcularExamenestotal()
        {
            calcularPromedio();
            return (promedio / 100f) * baseTotal;
        }

    }
}
