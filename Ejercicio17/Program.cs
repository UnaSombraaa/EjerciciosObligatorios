using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Baraja Española
            BarajaEspañola barajaEspañola = new BarajaEspañola();
            foreach (var carta in barajaEspañola.Cartas)
            {
                Console.WriteLine(carta);
            }

            // Baraja Francesa
            BarajaFrancesa barajaFrancesa = new BarajaFrancesa();
            foreach (var carta in barajaFrancesa.Cartas)
            {
                barajaFrancesa.CartaRoja(carta);
                barajaFrancesa.CartaNegra(carta);
                Console.WriteLine(carta);
            }
        }
    }
}
