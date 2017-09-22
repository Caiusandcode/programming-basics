using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define instructions
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla sekä tarkastaa onko luku parillinen tai pariton.");
            bool isNumber;
            Console.Write("Syötä luku: ");
            // define variables
            string userInput;
            userInput = Console.ReadLine();

            int evaluatedNumber;
            isNumber = int.TryParse(userInput, out evaluatedNumber);

            // Check isNumber
            if(!isNumber)
            {
                Console.WriteLine("Syötit väärän arvon!");
                Console.ReadKey();
                return;               
            }

            // Program logic
            if (evaluatedNumber < 0)
            {
                Console.Write($"Numero {evaluatedNumber} on negatiivinen, ");
            }
            else if (evaluatedNumber > 0)
            {
                Console.Write($"Numero {evaluatedNumber} on positiivinen, ");
            }
            else
            {
                Console.Write($"Numero {evaluatedNumber} on nolla, ");
            }

           
            if (evaluatedNumber % 2 == 0)
            {
                Console.WriteLine("se on parillinen");
            }
            else
            {
                Console.WriteLine("se on pariton");
            }
            Console.ReadKey();
        }
    }
}
