using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SERIE[] series = new SERIE[3]
            {
                new SERIE("Breaking Bad", 5, "Drama", "Vince Gilligan"),
                new SERIE("The Office", 9, "Comedia", "Greg Daniels"),
                new SERIE("Stranger Things", 4, "Ciencia Ficción", "Duffer Brothers")
            };

            VIDEOJUEGO[] videojuegos = new VIDEOJUEGO[3]
            {
                new VIDEOJUEGO("The Legend of Zelda", 40, "Aventura", "Nintendo"),
                new VIDEOJUEGO("Minecraft", 100, "Sandbox", "Mojang"),
                new VIDEOJUEGO("Red Dead Redemption 2", 60, "Acción", "Rockstar Games")
            };

            // Entregar los de la posicion 1
            series[1].Entregar();
            // Entregar lo de la posicion 2
            videojuegos[2].Entregar();

            // Mostrar entregados
            Console.WriteLine("Series entregadas:");
            foreach (var serie in series)
            {
                if (serie.Entregado) Console.WriteLine(serie);
            }

            Console.WriteLine("\nVideojuegos entregados:");
            foreach (var videojuego in videojuegos)
            {
                if (videojuego.Entregado) Console.WriteLine(videojuego);
            }
        }
    }
}
