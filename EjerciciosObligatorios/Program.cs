using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//dos metodos Ingreso-Retiro Dos constructores uno Titular Oblig. Cantidad Opcional.
namespace Ejercicio01
{
    public class Cuenta
    {
        string Titular {  get; set; }
        double Cantidad { get; set; }

        public Cuenta(string titular) 
        {
            Titular = titular;
            Cantidad = 0;
        }
        public Cuenta(string titular, double cantidad) 
        {
            Titular = titular;
            if (Cantidad < 0)
            {
                Cantidad = 0;
            }
            else
            {
                Cantidad = cantidad;
            }
        }
        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                Cantidad += cantidad; //agrega lo que se ingrese a Cantidad (Valor actual 0 + Valor Ingresado (cantidad))
                Console.WriteLine($"Saldo actual: {Cantidad}, Ingresaste: {cantidad}");
            }
            else
            {
                
                Console.WriteLine("No podes ingresar valores negativos");
            }
        }
        public void Retirar(double cantidad)
        {
            if(cantidad > Cantidad)
            {
                cantidad = 0;
                Console.WriteLine("no se a podido retirar");
            }
            else
            {
                Cantidad -= cantidad; //Retira cantidad y muestra (Cantidad = cantidad actual)
                Console.WriteLine($"Retiraste {cantidad}, Saldo actual {Cantidad}");
            }
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"El titular es: {Titular}, El saldo es {Cantidad}");
        }
    }
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta ("Gustavo Fernandez de Kishner");
            cuenta1.Ingresar(100);
            cuenta1.Retirar(75);
            cuenta1.MostrarInformacion();

            //Caso de retirar más de lo que se tiene de por si
            Cuenta cuenta2 = new Cuenta("Marino Luan", 200);
            cuenta2.Retirar(300);
            cuenta2.MostrarInformacion();
        }
    }
}
