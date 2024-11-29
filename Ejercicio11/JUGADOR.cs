using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class JUGADOR
    {
        public string Nombre { get; set; }
        public int Dinero { get; private set; }
        public int Victorias { get; private set; }

        public JUGADOR(string nombre, int dineroInicial)
        {
            Nombre = nombre;
            Dinero = dineroInicial;
            Victorias = 0;
        }

        public void Apostar(int cantidad)
        {
            if (Dinero >= cantidad)
            {
                Dinero -= cantidad;
            }
            else
            {
                Console.WriteLine("No tienes suficiente dinero para apostar.");
            }
        }

        public void Ganar(int pozo)
        {
            Dinero += pozo;
            Victorias++;
        }
    }
}
