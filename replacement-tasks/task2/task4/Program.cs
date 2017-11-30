using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuttaa lauseen sanat alkamaan isoilla kirjaimilla.");
            TitleCase tc = new TitleCase();
            Console.WriteLine(tc.Word);
            Console.WriteLine(tc.ToTitleCase(tc.Word));
            Console.ReadKey();
        }
    }
}
