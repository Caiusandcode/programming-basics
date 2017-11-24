using System;

namespace functions_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int userInput;
            Console.WriteLine("Syötä positiivinen luku.");
            int.TryParse(Console.ReadLine(), out userInput);

            Console.WriteLine($"{x(userInput)}");

            Console.ReadKey();
        }
        static string x(int y)
        {
            string value = "";

            for(int i = 0;i < y;i++)
            {
                value += "*";
            }
            return value;
        }
    }
}