using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    public class PELICULA
    {
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public int EdadMinima { get; set; }
        public string Director { get; set; }

        public PELICULA(string titulo, int duracion, int edadMinima, string director)
        {
            Titulo = titulo;
            Duracion = duracion;
            EdadMinima = edadMinima;
            Director = director;
        }

        public override string ToString()
        {
            return $"Título: {Titulo}, Duración: {Duracion} minutos, Edad Mínima: {EdadMinima}, Director: {Director}";
        }
    }
}
