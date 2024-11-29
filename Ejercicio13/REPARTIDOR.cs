using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class REPARTIDOR : EMPLEADO
    {
        public string Zona { get; set; }

        public REPARTIDOR(string nombre, int edad, double salario, string zona)
            : base(nombre, edad, salario)
        {
            Zona = zona;
        }

        public override bool Plus()
        {
            if (Edad < 25 && Zona == "zona 3")
            {
                Salario += PLUS;
                return true;
            }
            return false;
        }
    }
}
