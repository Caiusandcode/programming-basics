using System;

namespace Task4
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

            Console.Write("The answer is ");

            // If negative, multiply the number by -1 to get the loop working
            if (converted<0)
            {
                isNegative = true;
                converted *= -1;
            }
            else
            {
                isNegative = false;
            }

            long sum = 0;

            // Calculate the sum
            for (int i = 1; i <= converted; i++)
            {
                sum += i;
            }

            // Fix the negative value
            if (isNegative)
            {
                sum *= -1;
            }
            Console.WriteLine(sum);
        }
    }
}
