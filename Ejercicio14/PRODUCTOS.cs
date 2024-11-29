using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class PRODUCTOS
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public PRODUCTOS(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public virtual double Calcular(int cantidad)
        {
            return Precio * cantidad;
        }
    }
    public class PERECEDERO : PRODUCTOS
    {
        public int DiasACaducar { get; set; }

        public PERECEDERO(string nombre, double precio, int diasACaducar)
            : base(nombre, precio)
        {
            DiasACaducar = diasACaducar;
        }

        public override double Calcular(int cantidad)
        {
            double precioFinal = base.Calcular(cantidad);
            if (DiasACaducar == 1) precioFinal -= precioFinal * 0.4;
            else if (DiasACaducar == 2) precioFinal -= precioFinal * 0.3;
            else if (DiasACaducar == 3) precioFinal /= 2;
            return precioFinal;
        }
    }

    public class NOPERECEDERO : PRODUCTOS
    {
        public string Tipo { get; set; }

        public NOPERECEDERO(string nombre, double precio, string tipo)
            : base(nombre, precio)
        {
            Tipo = tipo;
        }

        public override double Calcular(int cantidad)
        {
            return base.Calcular(cantidad);
        }
    }
}
