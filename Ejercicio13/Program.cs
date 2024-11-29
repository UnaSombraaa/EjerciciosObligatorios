using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            COMERCIAL comercial = new COMERCIAL("Juan", 35, 1500, 250);
            REPARTIDOR repartidor = new REPARTIDOR("Carlos", 22, 1000, "zona 3");

            Console.WriteLine($"Salario Comercial antes del Plus: {comercial.Salario}");
            if (comercial.Plus()) Console.WriteLine($"Plus aplicado, salario ahora: {comercial.Salario}");

            Console.WriteLine($"Salario Repartidor antes del Plus: {repartidor.Salario}");
            if (repartidor.Plus()) Console.WriteLine($"Plus aplicado, salario ahora: {repartidor.Salario}");
        }
    }
}
