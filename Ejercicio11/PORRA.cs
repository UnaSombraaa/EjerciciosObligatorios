using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class PORRA
    {
        private List<JUGADOR> Jugadores { get; set; }
        private List<PARTIDO> Partidos { get; set; }
        private int Pozo { get; set; }

        public PORRA(int numJugadores, int dineroInicial, List<PARTIDO> partidos)
        {
            Jugadores = new List<JUGADOR>();
            for (int i = 0; i < numJugadores; i++)
            {
                Jugadores.Add(new JUGADOR($"Jugador {i + 1}", dineroInicial));
            }
            Partidos = partidos;
            Pozo = 0;
        }

        public void RealizarApuestas()
        {
            foreach (var jugador in Jugadores)
            {
                jugador.Apostar(1);
                Pozo++;
            }
        }

        public void SimularJornada()
        {
            RealizarApuestas();
            foreach (var partido in Partidos)
            {
                Console.WriteLine(partido.Resultado());
            }

            // Ganador aleatorio
            Random rnd = new Random();
            int ganadorIndex = rnd.Next(Jugadores.Count);
            Jugadores[ganadorIndex].Ganar(Pozo);

            Console.WriteLine($"{Jugadores[ganadorIndex].Nombre} ganó el pozo de {Pozo}.");
        }
    }
}
