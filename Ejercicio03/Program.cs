using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Cuenta
    {
        public string Titular { get; private set; }
        public double Cantidad { get; private set; }

        public Cuenta(string titular, double cantidadInicial)
        {
            Titular = titular;
            Cantidad = cantidadInicial > 0 ? cantidadInicial : 0;
        }

        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
                Cantidad += cantidad;
        }

        public void Retirar(double cantidad)
        {
            if (cantidad > Cantidad)
            {
                Console.WriteLine($"No puedes retirar más de lo que tienes. Saldo actual: {Cantidad}");
            }
            else
            {
                Cantidad -= cantidad;
                Console.WriteLine($"Has retirado {cantidad}. Saldo actual: {Cantidad}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("María", 100);
            cuenta.Ingresar(50);
            cuenta.Retirar(200);
            cuenta.Retirar(50);
        }
    }
}
