using PW3_2022_1C_Clase_1.Entidades;
using System;


namespace BolaOcho_Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Bola Ocho");

            Console.WriteLine("Ingrese cualquier caracter");
            string ingresoBolaOcho = Console.ReadLine();

            Console.WriteLine($"La frase es {BolaOcho.DarFrase()} ");
        }
    }
}
