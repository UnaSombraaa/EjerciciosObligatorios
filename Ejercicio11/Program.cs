using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PARTIDO> partidos = new List<PARTIDO>
            {
                new PARTIDO("Barcelona", "Real Madrid"),
                new PARTIDO("Boca Juniors", "Sevilla")
            };

            PORRA porra = new PORRA(3, 10, partidos);
            porra.SimularJornada();
        }
    }
}
