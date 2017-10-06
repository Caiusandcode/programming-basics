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

            if (number < 0)
            {
                Console.WriteLine("Virheellinen syote");
            }
            else
            {
                //do
                //{               
                //    i = i + 1;                
                //    f = f * i;
                //    //Console.WriteLine($"{i}!={f}"); // 5!=120
                //} while (i < number);

                //while (i<number)
                //{
                //    i = i + 1;
                //    f = f * i;
                //    Console.WriteLine($"{i}!={f}"); // 5!=120
                //}

                for(int j=1;j<=number;j++)
                {
                    f = f * j;
                    Console.WriteLine($"{j}!={f}"); // 5!=120
                }
                
                Console.WriteLine($"Syotit: {number}\n Vastaus: {f}"); // 5!=120
            }
            Console.ReadKey();
        }
    }
}
