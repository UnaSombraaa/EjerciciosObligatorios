using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PELICULA pelicula = new PELICULA("Inception", 148, 13, "Christopher Nolan");
            CINE cine = new CINE(pelicula, 8.50);

            cine.GenerarAsientos();
            Console.WriteLine("Sala inicial:");
            cine.MostrarSala();

            ESPECTADOR[] espectadores = new ESPECTADOR[10];
            for (int i = 0; i < espectadores.Length; i++)
            {
                espectadores[i] = new ESPECTADOR($"Espectador {i + 1}", 10 + i, 10 + i);
            }

            foreach (var espectador in espectadores)
            {
                if (cine.SentarEspectador(espectador))
                {
                    Console.WriteLine($"{espectador.Nombre} se sentó.");
                }
                else
                {
                    Console.WriteLine($"{espectador.Nombre} no pudo sentarse.");
                }
            }

            Console.WriteLine("\nSala final:");
            cine.MostrarSala();
        }
    }
}
