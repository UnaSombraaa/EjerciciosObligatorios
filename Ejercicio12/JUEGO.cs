using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class JUEGO
    {
        private List<JUGADOR> Jugadores { get; set; }
        private REVOLVER Revolver { get; set; }

        public JUEGO(int numJugadores)
        {
            // Asegura que haya entre 1 y 6 jugadores
            if (numJugadores < 1) numJugadores = 1;
            if (numJugadores > 6) numJugadores = 6;
            
            Jugadores = new List<JUGADOR>();
            for (int i = 1; i <= numJugadores; i++)
            {
                Jugadores.Add(new JUGADOR(i));
            }
            Revolver = new REVOLVER();
        }

        public void Ronda()
        {
            foreach (var jugador in Jugadores)
            {
                Console.WriteLine($"{jugador.Nombre} se apunta...");
                if (jugador.Disparar(Revolver))
                {
                    Console.WriteLine($"{jugador.Nombre} murió.");
                    break;
                }
                else
                {
                    Console.WriteLine($"{jugador.Nombre} sobrevivió.");
                }
            }
        }
    }
}