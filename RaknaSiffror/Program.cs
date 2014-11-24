using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            string inputnumber;
            int zerocount = 0;
            int evencount = 0;
            int unevencount = 0;
            Console.Write("Mata in ett  heltal: ");
            inputnumber = Console.ReadLine();

            numbers = new int[inputnumber.Length];

            for (int i = 0; i < inputnumber.Length; i++)
            {
                int.TryParse(inputnumber[i].ToString(),out numbers[i]);
            }

                foreach (var n in numbers)
                {
                    if (n == 0)
                    {
                        zerocount++;
                    }
                    else if (n % 2 == 0)
                    {
                        evencount++;
                    }
                    else
                    {
                        unevencount++;
                    }
                }

                Console.WriteLine("Nollor: {0} Udda: {1} Jämna: {2}", zerocount, unevencount, evencount);
                Console.WriteLine("Tryck in valfri tangent för att avsluta.");
                Console.ReadLine();
        }
    }
}
