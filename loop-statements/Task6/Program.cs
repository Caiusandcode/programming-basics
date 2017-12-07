using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number   SQRT");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(" {0}       {1:.00}", i, Math.Round(Math.Sqrt(i),2));
            }
        }
    }
}
