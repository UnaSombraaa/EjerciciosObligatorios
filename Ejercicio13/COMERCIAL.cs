using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class COMERCIAL : EMPLEADO
    {
        public double Comision { get; set; }

        public COMERCIAL(string nombre, int edad, double salario, double comision)
            : base(nombre, edad, salario)
        {
            Comision = comision;
        }

        public override bool Plus()
        {
            if (Edad > 30 && Comision > 200)
            {
                Salario += PLUS;
                return true;
            }
            return false;
        }
    }
}
