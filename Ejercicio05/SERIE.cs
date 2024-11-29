using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class SERIE
    {
        public string Titulo { get; set; }
        public int NumeroTemporadas { get; set; }
        public bool Entregado { get; set; }
        public string Genero { get; set; }
        public string Creador { get; set; }

        public SERIE(string titulo, int numeroTemporadas, string genero, string creador)
        {
            Titulo = titulo;
            NumeroTemporadas = numeroTemporadas;
            Entregado = false;
            Genero = genero;
            Creador = creador;
        }

        public void Entregar() => Entregado = true;
        public void Devolver() => Entregado = false;

        public override string ToString()
        {
            return $"Serie: {Titulo}, Temporadas: {NumeroTemporadas}, Genero: {Genero}, Creador: {Creador}, Entregado: {Entregado}";
        }
    }
}

