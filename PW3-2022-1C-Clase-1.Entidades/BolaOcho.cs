using System;

namespace PW3_2022_1C_Clase_1.Entidades
{
    public static class BolaOcho
    {
        static String[] respuestas = new string[20] { "Es cierto.", "Es decididamente así.", "Sin lugar a dudas.", "Sí, definitivamente.", "Puedes confiar en ello.", "Como yo lo veo, sí.", "Lo más probable.", "Perspectiva buena.", "Sí.", "Las señales apuntan a que sí.", "Respuesta confusa, vuelve a intentarlo.", "Vuelve a preguntar más tarde.", "Mejor no decirte ahora.", "No se puede predecir ahora.", "Concéntrate y vuelve a preguntar.", "No cuentes con ello.", "Mi respuesta es no.", "Mis fuentes dicen que no.", "Las perspectivas no son muy buenas.", "Muy dudoso." };

        public static void Jugar()
        {
            Console.WriteLine("¡Bienvenido al juego de la Bola Ocho!");
            bool jugar = true;
            while (jugar)
            {
                HacerPregunta();
                DevolverRespuesta();
                jugar = PreguntarSeguirJugando();
                Console.WriteLine("");
            }
            Console.WriteLine("Juego finalizado.");
        }

        private static bool PreguntarSeguirJugando()
        {
            while (true)
            {
                Console.WriteLine("¿Hacer otra pregunta? \n1 - ¡Si!\n2 - Salir.");
                string respuesta = Console.ReadLine();
                if (respuesta == "1")
                {
                    return true;
                }
                if (respuesta == "2")
                {
                    return false;
                }
                Console.WriteLine("¡Esa es una respuesta inválida!");
            }
        }

        private static void HacerPregunta()
        {
            Console.WriteLine("¡Haz tu pregunta!\n");
            Console.ReadLine();
        }

        public static void DevolverRespuesta()
        {
            Random rand = new Random();
            byte index = (byte)rand.Next(20);
            Console.WriteLine(respuestas[index] + "\n");
        }
    }
}
