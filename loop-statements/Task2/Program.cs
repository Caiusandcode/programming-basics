using System;

namespace Task2
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

                if (!validNumber || converted <1)
                {
                    Console.WriteLine("Not a valid number");
                    Console.WriteLine();
                    validNumber = false;
                }

            } while (!validNumber);

            Console.Write("The answer is ");

            long sum = 0;

            for (int i = 1; i <= converted; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
