using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validNumber;
            bool isNegative;
            int converted;

            // Menu loop until valid number given
            do
            {
                Console.Write("Enter toss count: ");

                string inputStr = Console.ReadLine();
                validNumber = int.TryParse(inputStr, out converted);

                if (!validNumber || converted <1)
                {
                    Console.WriteLine("Not a valid number");
                    Console.WriteLine();
                    validNumber = false;
                }

            } while (!validNumber);

            Random rnd = new Random();

            int headsCount = 0;
            int tailsCount = 0;

            for (int i=1; i<=converted; i++)
            {
                int x = rnd.Next(2);

                if (x==0)
                {
                    tailsCount += 1;
                }
                else
                {
                    headsCount += 1;
                }
            }
            Console.WriteLine("Tossed {0} times.", converted);
            Console.WriteLine("Tails {0} and Heads {1}.", tailsCount, headsCount);
        }
    }
}
