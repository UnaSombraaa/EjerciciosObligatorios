using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class JUGADOR
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Vivo { get; private set; }

        public JUGADOR(int id)
        {
            Id = id;
            Nombre = $"Jugador {id}";
            Vivo = true;
        }

        public bool Disparar(REVOLVER revolver)
        {
            if (revolver.Disparar())
            {
                Vivo = false;
                return true;
            }
            return false;
        }
    }
}
