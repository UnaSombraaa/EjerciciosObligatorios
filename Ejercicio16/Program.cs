using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AGENDA agenda = new AGENDA();

            // Crear contactos
            CONTACTO contacto1 = new CONTACTO("Juan", "123456789");
            CONTACTO contacto2 = new CONTACTO("Maria", "987654321");

            // Añadir contactos
            agenda.AniadirContacto(contacto1);
            agenda.AniadirContacto(contacto2);

            // Listar contactos
            agenda.ListarContactos();

            // Buscar un contacto
            agenda.BuscarContacto("Juan");

            // Eliminar un contacto
            agenda.EliminarContacto(contacto1);
            agenda.ListarContactos();
        }
    }
}
