using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class VIDEOJUEGO
    {
        public string Titulo { get; set; }
        public int HorasEstimadas { get; set; }
        public bool Entregado { get; set; }
        public string Genero { get; set; }
        public string Compania { get; set; }

        public VIDEOJUEGO(string titulo, int horasEstimadas, string genero, string compania)
        {
            Titulo = titulo;
            HorasEstimadas = horasEstimadas;
            Entregado = false;
            Genero = genero;
            Compania = compania;
        }

        public void Entregar() => Entregado = true;
        public void Devolver() => Entregado = false;

        public override string ToString()
        {
            return $"Videojuego: {Titulo}, Horas: {HorasEstimadas}, Genero: {Genero}, Compañia: {Compania}, Entregado: {Entregado}";
        }
    }
}

