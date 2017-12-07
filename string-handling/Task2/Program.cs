using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a string: ");
            string input = Console.ReadLine();

            Console.WriteLine(input.Replace("e","@"));
        }
    }
}
