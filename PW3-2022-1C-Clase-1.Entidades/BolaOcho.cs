using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_2022_1C_Clase_1.Entidades
{
    public static class BolaOcho
    {
        public static string[] arrayFrases = new string[] { "It is certain", "Yes definitely", "Signs point to yes.",
            "Reply hazy, try again.", "Ask again later.", "Better not tell you now.",
            "Don't count on it.","My reply is no.", "Very doubtful." };


        public static string DarFrase()
        {
            int cantidadFrasesEnArray = arrayFrases.Length;
            
            Random rand = new Random();
            int numeroFrase = rand.Next(0, cantidadFrasesEnArray);

            string frase = arrayFrases[numeroFrase];
            return frase;
        }


    }
}
