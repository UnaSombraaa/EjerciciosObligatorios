using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public class ALMACEN
    {
        private BEBIDAS[,] Estanteria;

        public ALMACEN(int filas, int columnas)
        {
            Estanteria = new BEBIDAS[filas, columnas];
        }

        public void AgregarBebida(int fila, int columna, BEBIDAS bebida)
        {
            if (Estanteria[fila, columna] == null)
                Estanteria[fila, columna] = bebida;
            else
                Console.WriteLine("Ya hay una bebida en esa posición.");
        }

        public double CalcularPrecioTotal()
        {
            double total = 0;
            foreach (var bebida in Estanteria)
            {
                if (bebida != null)
                    total += bebida.CalcularPrecio();
            }
            return total;
        }

        public double CalcularPrecioMarca(string marca)
        {
            double total = 0;
            foreach (var bebida in Estanteria)
            {
                if (bebida != null && bebida.Marca == marca)
                    total += bebida.CalcularPrecio();
            }
            return total;
        }
    }
}
