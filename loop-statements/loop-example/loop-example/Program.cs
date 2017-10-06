using System;

namespace loop_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma laskee kertoma. Anna luku, jonka kertoma lasketaan: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number);
            int i = 0;
            int f = 1;
            do
            {               
                i = i + 1;                
                f = f * i;
                //Console.WriteLine($"{i}!={f}"); // 5!=120
            } while (i < number);

            Console.WriteLine($"Syotit: {number}\n Vastaus: {f}"); // 5!=120
            Console.ReadKey();
        }
    }
}
