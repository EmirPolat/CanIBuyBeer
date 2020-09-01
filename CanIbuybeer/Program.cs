
using System;

namespace CanIbuybeer
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Superduper Beer Calculator 1.02");
            //bool
            // strin inmating upper etc

            Console.Write("Hur gammal är du:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Location (Systemet eller krogen)");
            string legg = Console.ReadLine();
            Console.Write("Har du legg med dig (J/N):");
            string location = Console.ReadLine();
            Console.Write("Vilken promillehalt:");
            decimal promille = Convert.ToDecimal(Console.ReadLine());
            location = location.ToLower();

          


            bool Canibuybeer = false;
            if (legg == "J" && promille < 1.0m)
            {
                if (location == "krogen" && age > 17)
                {
                    Canibuybeer = true;

                }

                else if (location == "systemet" && age > 19)
                {
                    Canibuybeer = true;

                }

            }



            //    if (Canibuybeer == true)
            if (Canibuybeer)
                Console.WriteLine("Du får köpa öl");
            else
                Console.WriteLine("Du får inte köpa öl");

            //if (age > 17 && location == "krogen" && legg == "J" && promille < 1.0m)
            //  Console.WriteLine("Japp du får köpa öl");
            ////  Console.WriteLine("Japp du får köpa öl");
            //else
            ///  Console.Write("NejNej ingen öl för dig idag");


        }
    }
}



