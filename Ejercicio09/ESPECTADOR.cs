using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    public class ESPECTADOR
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Dinero { get; set; }

        public ESPECTADOR(string nombre, int edad, double dinero)
        {
            Nombre = nombre;
            Edad = edad;
            Dinero = dinero;
        }
    }
}
