using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task4
{
    class TitleCase
    {
        public string Word;

        public TitleCase()
        {
            Word = "tHe riSe oF tHE pLanET OF ThE aPeS";
        }

        public TitleCase(string word)
        {
            Word = word;
        }

        public string ToTitleCase(string value)
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
                    words[i] = TitleCaseX(word);
                }
            }
            return string.Join(" ", words);
        }

        private static bool IsPreposition(string word)
        {
            string[] proposition = { "the", "of" };
            return proposition.Contains(word);
        }

        private static string TitleCaseX(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        }

    }
}
