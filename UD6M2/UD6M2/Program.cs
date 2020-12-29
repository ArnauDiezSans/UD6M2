using System;
using System.Collections.Generic;
using System.Threading;

namespace UD6M2
{
    class Program
    {
        public static int TipusCaracter(char a)
        {
            int tipus = 4; //retornara 1 per digits, 2 per vocals, 3 per espais, 4 per la resta
            if (a == '1' | a == '2' | a == '3' | a == '4' | a == '6' | a == '7' | a == '8' | a == '9' | a == '0')
            {
                tipus = 1;
            }
            if (a == 'a' | a == 'e' | a == 'i' | a == 'o' | a == 'u' | a == 'A' | a == 'E' | a == 'I' | a == 'O'|a == 'U')
            {
                tipus = 2;
            }
            if (a == ' ')
            {
                tipus = 3;
            }
            return tipus;
        }
        static void Main(string[] args)
        {
            //FASE1
            char[] nom = { 'A', 'R', 'N', 'A', 'U', ' ', 'D', 'I', 'E', 'Z', ' ', 'S', 'A', 'N', 'S' };
            for (int i = 0; i<nom.Length; i++)
            {
                Console.WriteLine("{0}", nom[i]);
            }
            //FASE2
            List<char> Lista = new List<char>();
            int lletra;
            for (int i = 0; i < nom.Length; i++)
            {
                Lista.Add(nom[i]);
                lletra = TipusCaracter(nom[i]);
                switch (lletra)
                {
                    case 1:
                        Console.WriteLine("Els noms no poden contenir numeros");
                        break;
                    case 2:
                        Console.WriteLine("Vocal");
                        break;
                    case 3:
                        Console.WriteLine("Espai en blanc");
                        break;
                    default:
                        Console.WriteLine("Consonant");
                        break;
                }

            }
            //FASE3


            //FASE4
            List<char> Nom = new List<char>() { 'A', 'R', 'N', 'A', 'U' };
            List<char> Cognom = new List<char>() { 'D', 'I', 'E', 'Z' };
            List<char> FullNom= new List<char>() ;
            FullNom.AddRange(Nom);
            FullNom.Add(' ');
            FullNom.AddRange(Cognom);
            Console.WriteLine("\n Nom complet: [{0}]", string.Join(", ", FullNom));
            //MILESTONE 2
            Console.WriteLine("Introdueix l'alçada de la piramide:");
            int alçada = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= alçada; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write(x);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Introdueix l'alçada de la piramide d'asteriscs:");
            alçada = Convert.ToInt32(Console.ReadLine());
            char[] asteriscos = new char[alçada*2];
            for(int i = 0; i<alçada*2; i++)
            {
                asteriscos[i] = '*';
            }
            //for (int z = 0; z < alçada; z++) { Console.Write(asteriscos[z]); }
            for (int i = 0; i < alçada; i++)
            {
                for (int x = 0; x < i; x++)
                {
                    asteriscos[x] = ' ';
                    asteriscos[(alçada*2) - x - 1] = ' ';
                }
                for (int z = 0; z < alçada*2; z++) { Console.Write(asteriscos[z]); }
                Console.WriteLine("");
            }
            //MILESTONE 3
            Console.WriteLine("Presiona enter per començar el rellotge");
            Console.ReadLine();
            
            int hour,minutes,seconds;
            DateTime date = DateTime.Now;
            hour = date.Hour;
            minutes = date.Minute;
            seconds = date.Second;

            string hora;
            string minuts;
            string segons;

            while (true)
            {
                hora = string.Format("{0:00}", hour);
                minuts = string.Format("{0:00}", minutes);
                segons = string.Format("{0:00}", seconds);
                Console.Clear();
                Console.WriteLine(hora + ":" + minuts + ":" + segons);
                /* Alternativament puc tenir les dades en int i fer
                 * Console.WriteLine("{0:00}:{1:00}:{2:00}", hora, minuts, segons);*/
                Thread.Sleep(1000);
                seconds++;
                if (seconds == 60)
                {
                    minutes++;
                    seconds = 0;
                }
                if (minutes == 60)
                {
                    hour++;
                    minutes = 0;
                }
                if (hour == 24)
                {
                    minutes = 0;
                    seconds = 0;
                    hour = 0;
                }
            }



        }
    }
}
