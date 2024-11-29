using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Persona
    {
        // Constantes
        private const char SEXO_DEFECTO = 'H';
        private const int IMCBAJO = -1;
        private const int IMCIDEAL = 0;
        private const int IMCALTO = 1;

        // Atributos privados
        private string nombre = "";
        private int edad = 0;
        private string dni;
        private char sexo = SEXO_DEFECTO;
        private double peso = 0;
        private double altura = 0;

        // Constructores
        public Persona() { }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = comprobarSexo(sexo);
            this.dni = generaDNI();
        }

        public Persona(string nombre, int edad, char sexo, double peso, double altura)
            : this(nombre, edad, sexo)
        {
            this.peso = peso;
            this.altura = altura;
        }

        // Métodos
        public int calcularIMC()
        {
            double imc = peso / (altura * altura);
            if (imc < 20) return IMCBAJO;
            else if (imc <= 25) return IMCIDEAL;
            else return IMCALTO;
        }

        public bool esMayorDeEdad() => edad >= 18;

        private char comprobarSexo(char sexo) => (sexo == 'H' || sexo == 'M') ? sexo : SEXO_DEFECTO;

        private string generaDNI()
        {
            Random rnd = new Random();
            int numero = rnd.Next(10000000, 99999999);
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            char letra = letras[numero % 23];
            return $"{numero}{letra}";
        }

        public void setNombre(string nombre) => this.nombre = nombre;
        public void setEdad(int edad) => this.edad = edad;
        public void setSexo(char sexo) => this.sexo = comprobarSexo(sexo);
        public void setPeso(double peso) => this.peso = peso;
        public void setAltura(double altura) => this.altura = altura;

        public override string ToString()
        {
            return $"Nombre: {nombre}, Edad: {edad}, DNI: {dni}, Sexo: {sexo}, Peso: {peso}kg, Altura: {altura}m";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce la edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el sexo (H/M): ");
            char sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el peso (kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura (m): ");
            double altura = double.Parse(Console.ReadLine());

      
            Persona p1 = new Persona(nombre, edad, sexo, peso, altura);
            Persona p2 = new Persona(nombre, edad, sexo);
            Persona p3 = new Persona();
            p3.setNombre("Default");
            p3.setEdad(30);
            p3.setSexo('M');
            p3.setPeso(70);
            p3.setAltura(1.75);

            // Evaluar y mostrar resultados
            Persona[] personas = { p1, p2, p3 };
            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona.ToString());
                Console.WriteLine($"Mayor de edad: {persona.esMayorDeEdad()}");
                Console.WriteLine($"IMC: {interpretarIMC(persona.calcularIMC())}");
                Console.WriteLine();
            }
        }

        static string interpretarIMC(int imc)
        {
            if (imc == -1)
            {
                return "Debajo del peso ideal";
            }
            else if (imc == 0)
            {
                return "Peso ideal";
            }
            else if (imc == 1)
            {
                return "Sobrepeso";
            }
            else
            {
                return "Error";
            }
        }
    }
}