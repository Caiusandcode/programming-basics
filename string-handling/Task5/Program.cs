using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowels = "aeiouyäöå";
            int vowelCnt = 0;

            Console.Write("Give a string: ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.IndexOf(input.Substring(i, 1)) != -1)
                {
                    vowelCnt++;
                }
            }
            Console.WriteLine("The string {0} has {1} vowels.", input.ToUpper(), vowelCnt);
            Console.WriteLine();
        }
    }
}
