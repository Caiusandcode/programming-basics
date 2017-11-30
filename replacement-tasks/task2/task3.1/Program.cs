using System;
using System.Linq;

namespace task3._1
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

        static string ToTitleCase(string value)
        {
            var words = value.Split(' ');


            for (var i = 0; i < words.Length; i++)
            {
                var word = words[i].ToLower();
                if (i > 0 && IsPreposition(word))
                {
                    words[i] = word.ToLower();
                }
                else
                {
                    words[i] = TitleCase(word);
                }
            }
            return string.Join(" ", words);
        }

        private static bool IsPreposition(string word)
        {
            string[] proposition = { "the", "of" };
            return proposition.Contains(word);
        }

        private static string TitleCase(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        }

    }
}
