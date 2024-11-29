using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PROFESOR profesor = new PROFESOR("Carlos", 40, 'M', "Matemáticas");
            ESTUDIANTE[] estudiantes = new ESTUDIANTE[10];
            for (int i = 0; i < estudiantes.Length; i++)
            {
                estudiantes[i] = new ESTUDIANTE($"Estudiante {i + 1}", 18 + i, i % 2 == 0 ? 'M' : 'F', i + 5);
            }

            AULA aula = new AULA(1, 10, "Matemáticas", profesor, estudiantes);

            if (aula.PuedeDarClase())
            {
                Console.WriteLine("Se puede dar clase.");
            }
            else
            {
                Console.WriteLine("No se puede dar clase.");
            }

        }
    }
}
