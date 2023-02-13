using System.IO;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = ("Générateur 1.0");
            Init();
        }
        private static void Init()
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine   ("        _____________   ____________ ___  ______________  _______        ");
            Console.WriteLine   ("      / ____/ ____/ | / / ____/ __  /   |/_  __/ ____/ / / / __  /       ");
            Console.WriteLine   ("     / / __/ __/ /  |/ / __/ / /_/ / /| | / / / __/ / / / / /_/ /        ");
            Console.WriteLine   ("    / /_/ / /___/ /|  / /___/ _, _/ ___ |/ / / /___/ /_/ / _, _/         ");
            Console.WriteLine   ("   /____ /_____/_/ |_/_____/_/ |_/_/  |_/_/ /_____/ ____/_/ |_|  V1.5    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                           Dev by BobMoquette1337           ");
            Console.ForegroundColor = ConsoleColor.White;
            

            Console.WriteLine("\nChoisissez le format de votre numlist :\n");

            Console.WriteLine("[1] FR-06");
            Console.WriteLine("[2] FR-07");
            Console.WriteLine("[3] BE-32");
            Console.WriteLine("[4] GE-49\n");
            
            
            string choix = Console.ReadLine();

            //int choix = Convert.ToInt32(Console.ReadLine());

            if (choix == "1")
            {
                Console.Clear();
                FR_06();
            }
            else if (choix == "2")
            {
                Console.Clear();
                FR_07();
                
            }
            else if (choix == "3")
            {
                Console.Clear();
                BE_32();
            }
            else if (choix == "4")
            {
                Console.Clear();
                GE_49();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Erreur : ce choix n'est pas autorisé");
            }
        }
        private static void FR_06()
        {
            string format_fr = "[FR-06]";
            Console.WriteLine(format_fr);
            Console.WriteLine("Combien de numéros voulez-vous générer :");
            string z = Console.ReadLine();
            int zsol = Int32.Parse(z);
            var prefixfr = "336";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Random ramdom0 = new Random();
            Random ramdom1 = new Random();
            Random ramdom2 = new Random();
            Random ramdom3 = new Random();
            Random ramdom4 = new Random();
            Random ramdom5 = new Random();
            Random ramdom6 = new Random();
            Random ramdom7 = new Random();
            Random ramdom8 = new Random();
            Random ramdom9 = new Random();



            for (int i = 0; i < zsol;)
            {
                int number0 = ramdom9.Next(0, 9);
                int number1 = ramdom8.Next(0, 9);
                int number2 = ramdom7.Next(0, 9);
                int number3 = ramdom6.Next(0, 9);
                int number4 = ramdom5.Next(0, 9);
                int number5 = ramdom4.Next(0, 9);
                int number6 = ramdom3.Next(0, 9);
                int number7 = ramdom2.Next(0, 9);
                Console.WriteLine("[+] " + prefixfr + $"{number0}{number1}{number2}{number3}{number4}{number5}{number6}{number7}\n");


                i++;
                

                
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
            private static void FR_07()
            {
                string format_fr = "[FR-07]";
                Console.WriteLine(format_fr);
                Console.WriteLine("Combien de numéros voulez-vous générer :");
                string z = Console.ReadLine();
                int zsol = Int32.Parse(z);
                var prefixfr = "337";
                Console.Clear();

                Random ramdom0 = new Random();
                Random ramdom1 = new Random();
                Random ramdom2 = new Random();
                Random ramdom3 = new Random();
                Random ramdom4 = new Random();
                Random ramdom5 = new Random();
                Random ramdom6 = new Random();
                Random ramdom7 = new Random();
                Random ramdom8 = new Random();
                Random ramdom9 = new Random();

                for (int i = 0; i < zsol;)
                {
                    int number0 = ramdom9.Next(0, 9);
                    int number1 = ramdom8.Next(0, 9);
                    int number2 = ramdom7.Next(0, 9);
                    int number3 = ramdom6.Next(0, 9);
                    int number4 = ramdom5.Next(0, 9);
                    int number5 = ramdom4.Next(0, 9);
                    int number6 = ramdom3.Next(0, 9);
                    int number7 = ramdom2.Next(0, 9);
                    Console.WriteLine("[+]" + prefixfr + $"{number0}{number1}{number2}{number3}{number4}{number5}{number6}{number7}\n");


                    i++;

                }
            }
        private static void BE_32()
        {
            string format_fr = "BE-32";
            Console.WriteLine(format_fr);
            Console.WriteLine("Combien de numéros voulez-vous générer :");
            string z = Console.ReadLine();
            int zsol = Int32.Parse(z);
            var prefixfr = "32";
            Console.Clear();

            Random ramdom0 = new Random();
            Random ramdom1 = new Random();
            Random ramdom2 = new Random();
            Random ramdom3 = new Random();
            Random ramdom4 = new Random();
            Random ramdom5 = new Random();
            Random ramdom6 = new Random();
            Random ramdom7 = new Random();
            Random ramdom8 = new Random();
            Random ramdom9 = new Random();

            for (int i = 0; i < zsol;)
            {
                int number0 = ramdom9.Next(0, 9);
                int number1 = ramdom8.Next(0, 9);
                int number2 = ramdom7.Next(0, 9);
                int number3 = ramdom6.Next(0, 9);
                int number4 = ramdom5.Next(0, 9);
                int number5 = ramdom4.Next(0, 9);
                int number6 = ramdom3.Next(0, 9);
                int number7 = ramdom2.Next(0, 9);
                Console.WriteLine("[+]" + prefixfr + $"{number0}{number1}{number2}{number3}{number4}{number5}{number6}{number7}\n");


                i++;

            }
        }
        private static void GE_49()
        {
            string format_fr = "GE-49";
            Console.WriteLine(format_fr);
            Console.WriteLine("Combien de numéros voulez-vous générer :");
            string z = Console.ReadLine();
            int zsol = Int32.Parse(z);
            var prefixfr = "49";
            Console.Clear();

            Random ramdom0 = new Random();
            Random ramdom1 = new Random();
            Random ramdom2 = new Random();
            Random ramdom3 = new Random();
            Random ramdom4 = new Random();
            Random ramdom5 = new Random();
            Random ramdom6 = new Random();
            Random ramdom7 = new Random();
            Random ramdom8 = new Random();
            Random ramdom9 = new Random();

            string newline = Environment.Newline;


            for (int i = 0; i < zsol;)
            {
                int number0 = ramdom9.Next(0, 9);
                int number1 = ramdom8.Next(0, 9);
                int number2 = ramdom7.Next(0, 9);
                int number3 = ramdom6.Next(0, 9);
                int number4 = ramdom5.Next(0, 9);
                int number5 = ramdom4.Next(0, 9);
                int number6 = ramdom3.Next(0, 9);
                int number7 = ramdom2.Next(0, 9);
                Console.WriteLine("[+]" + prefixfr + $"{number0}{number1}{number2}{number3}{number4}{number5}{number6}{number7}\n");


                i++;

            }
        }
    }
}    

