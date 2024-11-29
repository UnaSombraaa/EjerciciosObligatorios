using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class PARTIDO
    {
        public string Equipo1 { get; set; }
        public string Equipo2 { get; set; }
        public int Goles1 { get; private set; }
        public int Goles2 { get; private set; }

        public PARTIDO(string equipo1, string equipo2)
        {
            Equipo1 = equipo1;
            Equipo2 = equipo2;
            Simular();
        }

        private void Simular()
        {
            Random rnd = new Random();
            Goles1 = rnd.Next(0, 5);
            Goles2 = rnd.Next(0, 5);
        }

        public string Resultado()
        {
            return $"{Equipo1} {Goles1} - {Goles2} {Equipo2}";
        }
    }

}
