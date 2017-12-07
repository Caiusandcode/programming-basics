using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a string: ");
            string input = Console.ReadLine();

            int charCnt=0;

            for (int i=0; i<input.Length; i++)
            {
                if (input.Substring(i,1).ToUpper()== "L")
                {
                    charCnt++;
                }
            }
            Console.WriteLine("The string \"{0}\" has {1} \"L\" letters", input.ToUpper(), charCnt);
        }
    }
}
