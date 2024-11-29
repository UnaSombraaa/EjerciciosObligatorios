using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    public class CINE
    {
        public PELICULA Pelicula { get; set; }
        public double PrecioEntrada { get; set; }
        public string[,] Sala { get; private set; }

        public CINE(PELICULA pelicula, double precioEntrada)
        {
            Pelicula = pelicula;
            PrecioEntrada = precioEntrada;
            Sala = new string[8, 9]; // 8 filas por 9 columnas
        }

        public void GenerarAsientos()
        {
            for (int i = 0; i < Sala.GetLength(0); i++)
            {
                for (int j = 0; j < Sala.GetLength(1); j++)
                {
                    Sala[i, j] = $"{8 - i}{(char)('A' + j)}";
                }
            }
        }

        public bool SentarEspectador(ESPECTADOR espectador)
        {
            if (espectador.Edad < Pelicula.EdadMinima || espectador.Dinero < PrecioEntrada)
            {
                return false;
            }

            Random random = new Random();
            while (true)
            {
                int fila = random.Next(0, 8);
                int columna = random.Next(0, 9);

                if (Sala[fila, columna] != "X") // Si el asiento no está ocupado
                {
                    Sala[fila, columna] = "X";
                    return true;
                }
            }
        }

        public void MostrarSala()
        {
            for (int i = 0; i < Sala.GetLength(0); i++)
            {
                for (int j = 0; j < Sala.GetLength(1); j++)
                {
                    Console.Write(Sala[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }


}
