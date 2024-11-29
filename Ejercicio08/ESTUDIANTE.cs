using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    public class ESTUDIANTE
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
        public double Calificacion { get; set; }

        public ESTUDIANTE(string nombre, int edad, char sexo, double calificacion)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Calificacion = calificacion;
        }

        public bool EstaAprobado() => Calificacion >= 5;
    }

}

