using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kysyy lukuja niin kauan, kunnes syötät kaksi samaa lukua peräkkäin.\n");
            Random rnd = new Random();
            int oldNumber = rnd.Next();
            int newNumber = 0;
            int sumOfNumbers = 0;

            while(true)
            {
                Console.Write("Anna luku: ");
                var userInput = Console.ReadLine();
                newNumber = int.Parse(userInput);
                if (newNumber == oldNumber)
                    break;
                else
                {
                    oldNumber = newNumber;
                    sumOfNumbers += newNumber;
                }
            }

            Console.WriteLine($"Lukujen summa on: {sumOfNumbers}");
            Console.ReadKey();

        }
    }
}
