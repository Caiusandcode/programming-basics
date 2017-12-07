using System;

namespace Task1
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

                if (!validNumber)
                {
                    Console.WriteLine("Not a valid number");
                    Console.WriteLine();
                }

            } while (!validNumber);

            Console.Write("The factorial for {0} is ", converted);

            // Factorial for zero is one
            if (converted == 0)
            {
                Console.WriteLine("1");

            // Factorial for negative value is not defined
            }else if (converted <0)
            {
                Console.WriteLine("not defined");
            }
            // Calculate "normal" factorial
            else
            {
                long factorial=1;

                for (int i = 1; i <= converted; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine(factorial);
            }
        }
    }
}
