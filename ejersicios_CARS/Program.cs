using ejersicios_CARS.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicios_CARS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------PROBLEMA 1
            Persona persona = new Persona();

            Console.WriteLine("Dame tu nombre: ");
            persona.Nombre = Console.ReadLine();

            Console.WriteLine("Dame tu Edad: ");
            persona.Edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(persona.InfoPersona(persona.Nombre, persona.Edad));
            Console.ReadKey();
            */

            /*-----------------------------------------PROBLEMA 3
             
            Calculadora calculadora = new Calculadora();

            Console.WriteLine("inserte el primer numero: ");
            calculadora.numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserte el segundo numero: ");
            calculadora.numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("que operacion desea: ");
            Console.WriteLine("1._Sumar");
            Console.WriteLine("2._Restar");
            Console.WriteLine("3._Multiplicar");
            Console.WriteLine("4._Dividir");
            calculadora.opciones = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(calculadora.Operaciones(calculadora.numero1,calculadora.numero2,calculadora.opciones));
            Console.ReadKey();
            */

            //-----------------------------------------------PROBLEMA 4

            Rectangulo rectangulo = new Rectangulo();

            Console.WriteLine("inserte la Base del rectangulo: ");
            rectangulo.rectanguloBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("inserte la Altura del rectangulo: ");
            rectangulo.rectanguloBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(rectangulo.AreaTriangulo(rectangulo.rectanguloBase,rectangulo.rectanguloAltura));
            Console.ReadKey();

            //----------------------------------------------PROBLEMA 5


        }
    }
}
