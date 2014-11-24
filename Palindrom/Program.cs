using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in en sträng: ");
            string input = Console.ReadLine();
            string myString = "";

            for (int i = input.Length - 1; i >= 0; i--) // kollar input strängens längd och går tillbaka åt andra hållet
            {
                myString += input[i]; // kollar ifall inmatningen är ett palindrom
            }
            if (myString == input) 
            {
                Console.WriteLine("{0} är ett palindrom.", input);
            }
            else 
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! {0} är inte ett palindrom.", input);
                Console.ResetColor();
            }
            Console.WriteLine("Tryck in valfri tangent för att avsluta.");
            Console.ReadLine();
        }
    }
}
