using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    
    public class LIBRO
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public LIBRO(string isbn, string titulo, string autor, int numeroPaginas)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
        }

        public override string ToString()
        {
            return $"El libro con ISBN {ISBN}, creado por {Autor}, tiene {NumeroPaginas} páginas.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            LIBRO libro1 = new LIBRO("978-3-16-148410-0", "Cien Años de Soledad", "Gabriel García Márquez", 417);
            LIBRO libro2 = new LIBRO("978-0-06-112008-4", "1984", "George Orwell", 328);

            Console.WriteLine(libro1);
            Console.WriteLine(libro2);

            if (libro1.NumeroPaginas > libro2.NumeroPaginas)
            {
                Console.WriteLine($"El libro \"{libro1.Titulo}\" tiene más páginas.");
            }
            else if (libro1.NumeroPaginas < libro2.NumeroPaginas)
            {
                Console.WriteLine($"El libro \"{libro2.Titulo}\" tiene más páginas.");
            }
            else
            {
                Console.WriteLine($"Ambos libros tienen el mismo número de páginas.");
            }
        }
    }
}
