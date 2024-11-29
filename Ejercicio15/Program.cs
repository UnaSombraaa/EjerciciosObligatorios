using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ALMACEN almacen = new ALMACEN(3, 3);

            AGUAMINERAL agua = new AGUAMINERAL("A001", 1, 0.5, "MarcaA", "ManantialA");
            BEBIDAAZUCARADA bebidaAzucarada = new BEBIDAAZUCARADA("B001", 2, 1.2, "MarcaB", 20, true);

            almacen.AgregarBebida(0, 0, agua);
            almacen.AgregarBebida(1, 1, bebidaAzucarada);

            Console.WriteLine($"Precio total del almacén: {almacen.CalcularPrecioTotal()}");
            Console.WriteLine($"Precio total de la MarcaB: {almacen.CalcularPrecioMarca("MarcaB")}");
        }
    }
}
