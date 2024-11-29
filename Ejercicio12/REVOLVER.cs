using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class REVOLVER
    {
        private int PosicionActual { get; set; }
        private int PosicionBala { get; set; }

        public REVOLVER()
        {
            Random rnd = new Random();
            PosicionActual = rnd.Next(1, 7);
            PosicionBala = rnd.Next(1, 7);
        }

        public bool Disparar()
        {
            bool resultado = PosicionActual == PosicionBala;
            SiguienteBala();
            return resultado;
        }

        private void SiguienteBala()
        {
            PosicionActual = PosicionActual == 6 ? 1 : PosicionActual + 1;
        }

        public override string ToString()
        {
            return $"Posición Actual: {PosicionActual}, Posición Bala: {PosicionBala}";
        }
    }
}
