using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validNumber;
            int converted;

            // Menu loop until valid number given
            do
            {
                Console.Write("Enter number: ");

                string inputStr = Console.ReadLine();
                validNumber = int.TryParse(inputStr, out converted);

                if (!validNumber || converted < 1)
                {
                    Console.WriteLine("Not a valid number");
                    Console.WriteLine();
                    validNumber = false;
                }

            } while (!validNumber);

            long sumOdd = 0;
            long sumEven = 0;

            for (int i = 1; i <= converted; i++)
            {
                if (i%2 == 0)
                {
                    sumEven += i;
                }
                else
                {
                    sumOdd += i;
                }
            }
            Console.WriteLine("The sum of odds = {0}, the sum of evens = {1}", sumOdd, sumEven);
        }
    }
}
