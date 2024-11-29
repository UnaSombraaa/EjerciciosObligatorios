using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class AGENDA
    {
        private List<CONTACTO> Contactos { get; set; }
        private int TamañoMaximo { get; set; }

        public AGENDA(int tamañoMaximo = 10)
        {
            TamañoMaximo = tamañoMaximo;
            Contactos = new List<CONTACTO>();
        }

        public void AniadirContacto(CONTACTO c)
        {
            if (Contactos.Count < TamañoMaximo)
            {
                if (!Contactos.Contains(c))
                {
                    Contactos.Add(c);
                    Console.WriteLine($"Contacto {c.Nombre} añadido.");
                }
                else
                {
                    Console.WriteLine("Contacto ya existe.");
                }
            }
            else
            {
                Console.WriteLine("Agenda llena.");
            }
        }

        public bool ExisteContacto(CONTACTO c)
        {
            return Contactos.Contains(c);
        }

        public void ListarContactos()
        {
            if (Contactos.Count > 0)
            {
                foreach (var contacto in Contactos)
                {
                    Console.WriteLine($"Nombre: {contacto.Nombre}, Teléfono: {contacto.Telefono}");
                }
            }
            else
            {
                Console.WriteLine("No hay contactos.");
            }
        }
        public void BuscarContacto(string nombre)
        {
            var contacto = Contactos.Find(c => c.Nombre == nombre);
            if (contacto != null)
            {
                Console.WriteLine($"Nombre: {contacto.Nombre}, Teléfono: {contacto.Telefono}");
            }
            else
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }

        public void EliminarContacto(CONTACTO c)
        {
            if (Contactos.Remove(c))
            {
                Console.WriteLine($"Contacto {c.Nombre} eliminado.");
            }
            else
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }

        public bool AgendaLlena()
        {
            return Contactos.Count >= TamañoMaximo;
        }

        public int HuecosLibres()
        {
            return TamañoMaximo - Contactos.Count;
        }
    }
}
