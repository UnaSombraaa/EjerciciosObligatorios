using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class ELECTRODOMESTICO
    {
        protected double PrecioBase { get; set; }
        protected string Color { get; set; }
        protected char ConsumoEnergetico { get; set; }
        protected double Peso { get; set; }

        private const double PRECIO_BASE_DEFECTO = 100;
        private const string COLOR_DEFECTO = "Blanco";
        private const char CONSUMO_DEFECTO = 'F';
        private const double PESO_DEFECTO = 5;

        public ELECTRODOMESTICO()
        {
            PrecioBase = PRECIO_BASE_DEFECTO;
            Color = COLOR_DEFECTO;
            ConsumoEnergetico = CONSUMO_DEFECTO;
            Peso = PESO_DEFECTO;
        }

        public ELECTRODOMESTICO(double precioBase, double peso)
        {
            PrecioBase = precioBase;
            Peso = peso;
            Color = COLOR_DEFECTO;
            ConsumoEnergetico = CONSUMO_DEFECTO;
        }

        public ELECTRODOMESTICO(double precioBase, string color, char consumoEnergetico, double peso)
        {
            PrecioBase = precioBase;
            Color = ComprobarColor(color);
            ConsumoEnergetico = ComprobarConsumoEnergetico(consumoEnergetico);
            Peso = peso;
        }

        private string ComprobarColor(string color)
        {
            string[] coloresValidos = { "Blanco", "Negro", "Rojo", "Azul", "Gris" };
            return Array.Exists(coloresValidos, c => c.Equals(color, StringComparison.OrdinalIgnoreCase)) ? color : COLOR_DEFECTO;
        }

        private char ComprobarConsumoEnergetico(char letra)
        {
            return (letra >= 'A' && letra <= 'F') ? letra : CONSUMO_DEFECTO;
        }

        public virtual double PrecioFinal()
        {
        
            double incremento = 0;

            if (ConsumoEnergetico == 'A') incremento = 100;
            else if (ConsumoEnergetico == 'B') incremento = 80;
            else if (ConsumoEnergetico == 'C') incremento = 60;
            else if (ConsumoEnergetico == 'D') incremento = 50;
            else if (ConsumoEnergetico == 'E') incremento = 30;
            else incremento = 10;

            if (Peso >= 0 && Peso < 20) incremento += 10;
            else if (Peso >= 20 && Peso < 50) incremento += 50;
            else if (Peso >= 50 && Peso < 80) incremento += 80;
            else incremento += 100;

            return PrecioBase + incremento;
        }
    }

    public class LAVADORA : ELECTRODOMESTICO
    {
        private double Carga { get; set; }

        private const double cargapordefecto = 5;

        public LAVADORA() : base()
        {
            Carga = cargapordefecto;
        }

        public LAVADORA(double precioBase, double peso) : base(precioBase, peso)
        {
            Carga = cargapordefecto;
        }

        public LAVADORA(double precioBase, string color, char consumoEnergetico, double peso, double carga)
            : base(precioBase, color, consumoEnergetico, peso)
        {
            Carga = carga;
        }

        public override double PrecioFinal()
        {
            double precio = base.PrecioFinal();
            if (Carga > 30) precio += 50;
            return precio;
        }
    }

    public class TELEVISION : ELECTRODOMESTICO
    {
        private int Resolucion { get; set; }
        private bool SintonizadorTDT { get; set; }

        private const int resolucionpordefecto = 20;
        private const bool sintonizadorpordefecto = false;

        public TELEVISION() : base()
        {
            Resolucion = resolucionpordefecto;
            SintonizadorTDT = sintonizadorpordefecto;
        }

        public TELEVISION(double precioBase, double peso) : base(precioBase, peso)
        {
            Resolucion = resolucionpordefecto;
            SintonizadorTDT = sintonizadorpordefecto;
        }

        public TELEVISION(double precioBase, string color, char consumoEnergetico, double peso, int resolucion, bool sintonizadorTDT)
            : base(precioBase, color, consumoEnergetico, peso)
        {
            Resolucion = resolucion;
            SintonizadorTDT = sintonizadorTDT;
        }

        public override double PrecioFinal()
        {
            double precio = base.PrecioFinal();
            if (Resolucion > 40) precio += PrecioBase * 0.3;
            if (SintonizadorTDT) precio += 50;
            return precio;
        }
    }

}

