using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define instructions
            Console.WriteLine("Ohjelma selvittää onko syötetty luku pariton vai parillinen.");
            bool isNumber;
            Console.Write("Syötä luku: ");
            // define variables
            string userInput;
            userInput = Console.ReadLine();

            int evaluatedNumber;
            isNumber = int.TryParse(userInput, out evaluatedNumber);

            // program logic
            if(evaluatedNumber % 2 == 0)
            {
                Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on parillinen");
            }
            else
            {
                Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on pariton");
            }

            Console.ReadKey();
        }
    }
}
