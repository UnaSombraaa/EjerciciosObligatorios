using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public class CARTA
    {
        public int Numero { get; set; }
        public string Palo { get; set; }

        public CARTA(int numero, string palo)
        {
            Numero = numero;
            Palo = palo;
        }

        public override string ToString()
        {
            return $"{Numero} de {Palo}";
        }
    }

    public class BARAJA
    {
        private List<CARTA> Cartas { get; set; }
        private Stack<CARTA> Monton { get; set; }

        private static readonly string[] Palos = { "Espadas", "Bastos", "Oros", "Copas" };

        public BARAJA()
        {
            Cartas = new List<CARTA>();
            Monton = new Stack<CARTA>();
            CrearBaraja();
        }

        private void CrearBaraja()
        {
            foreach (string palo in Palos)
            {
                for (int i = 1; i <= 12; i++)
                {
                    if (i != 8 && i != 9)
                    {
                        Cartas.Add(new CARTA(i, palo));
                    }
                }
            }
        }

        public void Barajar()
        {
            Random random = new Random();
            for (int i = 0; i < Cartas.Count; i++)
            {
                int index = random.Next(Cartas.Count);
                (Cartas[i], Cartas[index]) = (Cartas[index], Cartas[i]);
            }
        }

        public CARTA SiguienteCarta()
        {
            if (Cartas.Count > 0)
            {
                CARTA carta = Cartas[0];
                Monton.Push(carta);
                Cartas.RemoveAt(0);
                return carta;
            }
            Console.WriteLine("No hay más cartas.");
            return null;
        }

        public void MostrarBaraja()
        {
            foreach (CARTA carta in Cartas)
            {
                Console.WriteLine(carta);
            }
        }

        public void MostrarMonton()
        {
            if (Monton.Count == 0)
            {
                Console.WriteLine("No hay cartas en el montón.");
            }
            else
            {
                foreach (CARTA carta in Monton)
                {
                    Console.WriteLine(carta);
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BARAJA baraja = new BARAJA();
            baraja.Barajar();

            Console.WriteLine("Cartas mezcladas:");
            baraja.MostrarBaraja();

            Console.WriteLine("\nSiguiente carta:");
            Console.WriteLine(baraja.SiguienteCarta());

            Console.WriteLine("\nMonto:");
            baraja.MostrarMonton();
        }
    }
}
