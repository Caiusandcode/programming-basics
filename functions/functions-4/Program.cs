using System;

namespace functions_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxIndex = 0;
            Console.WriteLine($"Suurin luku oli {Numerot(ref maxIndex)} ja se oli {maxIndex}.");
            Console.ReadKey();
        }
        static int Numerot(ref int maxIndex)
        {
            int num = 0;
            int max = 0;
            
            bool isNumber;
            string output = "";
            Console.WriteLine("Syötä 10 positiivista lukua");

            //for (int i = 0; i < 10; i++)
            int i = 0;
            while(i<10)
            {
                Console.Write($"{i + 1}. ");
                isNumber = int.TryParse(Console.ReadLine(), out num);
                if (isNumber && num > 0)
                { 
                    output += $"{num} "; // luodaan palaute esim. 5 10 7 22 6 2 5 10
                    if (max < num)
                    {
                        max = num;
                        maxIndex = i+1;
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine("Väärä syöte, syötä positiivinen luku");
                    // i--;
                }               
            }
            Console.WriteLine($"Syötit seuraavat luvut:\n{output}\n");
            return max;
        }
    }
}
