using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public abstract class BEBIDAS
    {
        public string Identificador { get; set; }
        public double Litros { get; set; }
        public double Precio { get; set; }
        public string Marca { get; set; }

        public BEBIDAS(string identificador, double litros, double precio, string marca)
        {
            Identificador = identificador;
            Litros = litros;
            Precio = precio;
            Marca = marca;
        }

        public abstract double CalcularPrecio();
    }

    public class AGUAMINERAL : BEBIDAS
    {
        public string Origen { get; set; }

        public AGUAMINERAL(string identificador, double litros, double precio, string marca, string origen)
            : base(identificador, litros, precio, marca)
        {
            Origen = origen;
        }

        public override double CalcularPrecio()
        {
            return Precio * Litros;
        }
    }

    public class BEBIDAAZUCARADA : BEBIDAS
    {
        public double PorcentajeAzucar { get; set; }
        public bool TienePromocion { get; set; }

        public BEBIDAAZUCARADA(string identificador, double litros, double precio, string marca, double porcentajeAzucar, bool tienePromocion)
            : base(identificador, litros, precio, marca)
        {
            PorcentajeAzucar = porcentajeAzucar;
            TienePromocion = tienePromocion;
        }

        public override double CalcularPrecio()
        {
            double precioFinal = Precio * Litros;
            if (TienePromocion)
                precioFinal *= 0.9; // 10% de descuento si tiene promoción
            return precioFinal;
        }
    }
}
