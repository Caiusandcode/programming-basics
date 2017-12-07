using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sixCount = 0;

            for (int i = 1; i <= 1000; i++)
            {
                int x = rnd.Next(1,7) ;

                if (x == 6)
                {
                    sixCount++;
                }
                Console.WriteLine("{0}. {1}", i, x);
            }
            Console.WriteLine("Six was tossed {0} times.", sixCount);
        }
    }
}
