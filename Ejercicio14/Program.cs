using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PRODUCTOS[] productos = new PRODUCTOS[]
           {
                new PRODUCTOS("Producto General", 10),
                new PERECEDERO("Leche", 1.5, 2),
                new NOPERECEDERO("Arroz", 2, "Grano")
           };

            foreach (var producto in productos)
            {
                Console.WriteLine($"Precio total de 5 unidades de {producto.Nombre}: {producto.Calcular(5)}");
            }
        }
    }
}
