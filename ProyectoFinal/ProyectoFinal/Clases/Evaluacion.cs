using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    public class Evaluacion
    {
        private float _promedio;
        private float _baseTotal;

        public float promedio
        {
            get { return _promedio; }
            set { _promedio = value; }
        }

        public float baseTotal
        {
            get { return _baseTotal; }
            set { _baseTotal = value; }
        }

    }
}
