using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class AULA
    {
        public int Id { get; set; }
        public int MaxEstudiantes { get; set; }
        public string Materia { get; set; }
        public PROFESOR Profesor { get; set; }
        public ESTUDIANTE[] Estudiantes { get; set; }

        public AULA(int id, int maxEstudiantes, string materia, PROFESOR profesor, ESTUDIANTE[] estudiantes)
        {
            Id = id;
            MaxEstudiantes = maxEstudiantes;
            Materia = materia;
            Profesor = profesor;
            Estudiantes = estudiantes;
        }

        public bool PuedeDarClase()
        {
            int presentes = 0;
            foreach (var estudiante in Estudiantes)
            {
                Random rnd = new Random();
                if (rnd.Next(0, 100) >= 50) presentes++;
            }

            return Profesor.EstaDisponible() && Profesor.Materia == Materia && presentes >= MaxEstudiantes / 2;
        }
    }

}

