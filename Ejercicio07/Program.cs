using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    public class RAICES
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public RAICES(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double GetDiscriminante()
        {
            return (B * B) - (4 * A * C);
        }

        public bool TieneRaices()
        {
            return GetDiscriminante() > 0;
        }

        public bool TieneRaiz()
        {
            return GetDiscriminante() == 0;
        }

        public void ObtenerRaices()
        {
            if (TieneRaices())
            {
                double raiz1 = (-B + Math.Sqrt(GetDiscriminante())) / (2 * A);
                double raiz2 = (-B - Math.Sqrt(GetDiscriminante())) / (2 * A);
                Console.WriteLine($"Soluciones: {raiz1} y {raiz2}");
            }
            else
            {
                Console.WriteLine("No tiene dos soluciones.");
            }
        }

        public void ObtenerRaiz()
        {
            if (TieneRaiz())
            {
                double raiz = -B / (2 * A);
                Console.WriteLine($"Única solución: {raiz}");
            }
            else
            {
                Console.WriteLine("No tiene una única solución.");
            }
        }

        public void Calcular()
        {
            if (TieneRaices())
            {
                ObtenerRaices();
            }
            else if (TieneRaiz())
            {
                ObtenerRaiz();
            }
            else
            {
                Console.WriteLine("No existen soluciones.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            RAICES ecuacion1 = new RAICES(1, -3, 2);
            RAICES ecuacion2 = new RAICES(1, -2, 1);
            RAICES ecuacion3 = new RAICES(1, 1, 1);

            Console.WriteLine("Ecuación 1:");
            ecuacion1.Calcular();

            Console.WriteLine("Ecuación 2:");
            ecuacion2.Calcular();

            Console.WriteLine("Ecuación 3:");
            ecuacion3.Calcular();
        }
    }
}
