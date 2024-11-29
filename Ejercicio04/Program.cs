using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ELECTRODOMESTICO[] electrodomesticos = new ELECTRODOMESTICO[10];

            electrodomesticos[0] = new ELECTRODOMESTICO(200, "Rojo", 'A', 10);
            electrodomesticos[1] = new LAVADORA(300, "Blanco", 'B', 40, 35);
            electrodomesticos[2] = new TELEVISION(400, "Negro", 'C', 10, 50, true);
            electrodomesticos[3] = new TELEVISION(150, "Azul", 'D', 8, 32, false);
            electrodomesticos[4] = new LAVADORA(350, "Gris", 'E', 55, 20);
            electrodomesticos[5] = new ELECTRODOMESTICO(100, 15);
            electrodomesticos[6] = new TELEVISION(500, "Blanco", 'A', 20, 60, true);
            electrodomesticos[7] = new LAVADORA(250, 35);
            electrodomesticos[8] = new ELECTRODOMESTICO();
            electrodomesticos[9] = new LAVADORA();

            double totalElectrodomesticos = 0, totalLavadoras = 0, totalTelevisores = 0;

            foreach (var electro in electrodomesticos)
            {
                double precio = electro.PrecioFinal();
                totalElectrodomesticos += precio;

                if (electro is LAVADORA lavadora)
                {
                    totalLavadoras += precio;
                }
                else if (electro is TELEVISION televisor)
                {
                    totalTelevisores += precio;
                }
            }

            Console.WriteLine($"Precio total de electrodomésticos: {totalElectrodomesticos}");
            Console.WriteLine($"Precio total de lavadoras: {totalLavadoras}");
            Console.WriteLine($"Precio total de televisores: {totalTelevisores}");
        }
    }
}
