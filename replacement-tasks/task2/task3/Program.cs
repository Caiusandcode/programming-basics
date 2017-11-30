using System;
using System.Linq;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuttaa lauseen sanat alkamaan isoilla kirjaimilla.");
            string word = "thE loRd oF tHe rInG";

            Console.WriteLine(ToTitleCase(word));
            Console.ReadKey();

        }

        private static string ToTitleCase(string value)
        {
            var words = value.Split(' ');
            string[] proposition = { "the", "of" };

            for (var i = 0; i < words.Length; i++)
            {
                var word = words[i].ToLower();
                if (i> 0 && proposition.Contains(word))
                {
                    words[i] = word.ToLower();
                }
                else
                {
                    words[i] = word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
                }
            }
            return string.Join(" ", words);
        }



    }
}

