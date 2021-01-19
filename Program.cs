using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            string bestTeam = "MFF";
            Console.WriteLine("What soccer team is the best in Sweden?");
            string input = Console.ReadLine();
            string userAnswer = input.ToUpper();
            if (userAnswer == bestTeam)
            {
                Console.WriteLine("You are right!");
            }


            Console.WriteLine("What is the temperature in Svedala?");
            int svedelaTemp = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the temperature in Jukkasjärvi?");
            int jukkasjärviTemp = int.Parse(Console.ReadLine());

            if (svedelaTemp < jukkasjärviTemp)
            {
                Console.WriteLine("It is colder in Svedala, than in Jukkasjärvi");
            }
            else if (svedelaTemp > jukkasjärviTemp)
            {
                Console.WriteLine("It is colder in Jukkasjärvi, than in Svedala");
            }
            else
            {
                Console.WriteLine("It is the same temperature in both places");
            }

            Console.WriteLine("What is the temperature in Visby?");
            int visbyTemp = int.Parse(Console.ReadLine());

            if (svedelaTemp > jukkasjärviTemp && svedelaTemp > visbyTemp)
            {
                Console.WriteLine("The warmest place is Svedala");
            }
            else if (jukkasjärviTemp > svedelaTemp && jukkasjärviTemp > visbyTemp)
            {
                Console.WriteLine("The warmest place is Jukkasjärvi");

            }
            else if (visbyTemp > svedelaTemp && visbyTemp > jukkasjärviTemp)
            {
                Console.WriteLine("The warmest place is Visby");

            }
            else
            {
                Console.WriteLine("It is the same temperature in all three places");

            }

        }
    }
}
