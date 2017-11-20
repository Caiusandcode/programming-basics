using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tulostetaan taulukosta olevien lukujen verran tähtiä näytölle fuktiossa.");
            int[] numbers = new int[] { 2, 5, 10, 7, 3 };
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(getNAsterisks(numbers[i]));
            }
            Console.ReadKey();

        }

        static string getNAsterisks(int n)
        {
            string res = string.Empty;
            for (int i = 0; i < n; i++)
            {
                res += '*';
            }
            return res;
        }
    }
}
