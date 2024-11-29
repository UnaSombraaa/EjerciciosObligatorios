using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    public class PROFESOR
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
        public string Materia { get; set; }

        public PROFESOR(string nombre, int edad, char sexo, string materia)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Materia = materia;
        }

        public bool EstaDisponible()
        {
            Random rnd = new Random();
            return rnd.Next(0, 100) >= 20;
        }
    }
}

