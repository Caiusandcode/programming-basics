using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minäpä tiedän luvun väliltä 1-100, jota sinä et tiedä!\n");
            Random rnd = new Random();
            int userQuessNumber = 0;
            string userInput = "";

            do
            {
                int rndNumber = rnd.Next(1, 101);               
                int quessCounter = 0;
                
                while (true)
                {
                    Console.Write("Arvaa luku: ");
                    userQuessNumber = int.Parse(Console.ReadLine());
                    quessCounter++;

                    if (userQuessNumber < rndNumber)
                        Console.WriteLine("Lukuni on isompi!");
                    else if (userQuessNumber > rndNumber)
                        Console.WriteLine("Lukuni on pienempi!");
                    else
                        break;                    
                }

                Console.WriteLine($"\nOikein! Arvauksia yhteensä: {quessCounter}\n");
                Console.Write("Pelaatko uuden kierroksen? [Y/N]: ");
                userInput = Console.ReadLine().ToUpper();
            } while (userInput == "Y");

            Console.WriteLine("Ohjelman suoritus päättyy!");
            Console.ReadKey();

        }
    }
}
