using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 1; i <= 13; i++)
            {
                double x = rnd.NextDouble();

                if (x >= 0 && x <=0.4)
                {
                    Console.WriteLine("{0}. 1", i);
                }
                else if (x>0.4 && x <=0.6)
                {
                    Console.WriteLine("{0}. X", i);
                }
                else
                {
                    Console.WriteLine("{0}. 2", i);
                }
            }
        }
    }
}
