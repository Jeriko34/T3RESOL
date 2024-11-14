using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_RESOLUCIÓN
{
    internal class Cita
    {
        public int Numero { get; set; }
        public Estudiante Estudiante { get; set; }
        public string Enfermedad { get; set; }
        public double Precio { get; set; }

            public Cita(int Numero, Estudiante estudiante, string Enfermedad, double precio)
            {
            Numero = Numero;
            Estudiante = estudiante;
            Enfermedad = Enfermedad;
            precio = precio;
            }
        public override
    }
}
