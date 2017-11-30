using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuttaa sanan ensimmäisen kirjaimen isoksi kirjaimeksi ");
            string word = "heLLo";
            Console.WriteLine(toTitleCase(word));
            Console.ReadKey();

        }

        private static string toTitleCase(string word)
        {
            string[] proposition = {"the", "of", "and"};

            word = word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
            return word;
        }
    }
}
