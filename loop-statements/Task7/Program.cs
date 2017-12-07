using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i<=9;i++)
            {
                for (int j=1; j<=9; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i*j);
                }
            }
        }
    }
}
