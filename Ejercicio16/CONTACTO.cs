using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class CONTACTO
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public CONTACTO(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }

        public override bool Equals(object obj)
        {
            if (obj is CONTACTO contacto)
                return Nombre == contacto.Nombre;
            return false;
        }

        public override int GetHashCode()
        {
            return Nombre.GetHashCode();
        }
    }

}
