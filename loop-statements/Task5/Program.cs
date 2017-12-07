using System;

namespace Task5
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
                Console.Write("Enter number: ");

                string inputStr = Console.ReadLine();
                validNumber = int.TryParse(inputStr, out converted);

                if (!validNumber || converted == 0)
                {
                    Console.WriteLine("Not a valid number");
                    Console.WriteLine();
                    validNumber = false;
                }

            } while (!validNumber);

            // If negative, multiply the number by -1 to get the loop working
            if (converted < 0)
            {
                isNegative = true;
                converted *= -1;
            }
            else
            {
                isNegative = false;
            }

            // Loop and sum
            long sumOdd = 0;
            long sumEven = 0;

            for (int i = 1; i <= converted; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += i;
                }
                else
                {
                    sumOdd += i;
                }
            }

            // Fix negative values
            if (isNegative)
            {
                sumEven *= -1;
                sumOdd *= -1;
            }
            Console.WriteLine("The sum of odds = {0}, the sum of evens = {1}", sumOdd, sumEven);
        }
    }
}
