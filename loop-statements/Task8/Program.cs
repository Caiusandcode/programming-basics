using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random;

            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Row {0}: ", i);

                for (int j = 1; j <= 5; j++)
                {
                    random = rnd.Next(50);

                    if (random < 10)
                        Console.Write(" ");

                    // The last number needs to be printed without comma
                    if (j < 5)
                    {
                        Console.Write("{0}, ", random);
                    }
                    else
                    {
                        Console.Write("{0}", random);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
