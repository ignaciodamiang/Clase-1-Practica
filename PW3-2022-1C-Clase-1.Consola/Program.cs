using PW3_2022_1C_Clase_1.Entidades;
using System;

namespace PW3_2022_1C_Clase_1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculaddora!");
            Console.WriteLine("Ingrese los numeros a sumar");
            
            Console.WriteLine("Num 1: ");
            string num1 = Console.ReadLine();
            //if (!Int32.TryParse(num1, out int int3))
            //    Console.WriteLine("El numero ingresado es inválido");

            Console.WriteLine("Num 2: ");
            string num2 = Console.ReadLine();

            Console.WriteLine($"{num1} + {num2} = {Calculadora.Sumar(num1, num2)}");
            Console.ReadKey();

        }
    }
}
