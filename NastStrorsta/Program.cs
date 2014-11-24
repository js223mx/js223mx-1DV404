using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastStrorsta
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int maxValue;
            int secMaxValue;
            int input = 0;

            maxValue = input;
            secMaxValue = input;

            Console.WriteLine("Mata in 10 heltal: ");
            

            for (int i = 0; i < 10; i++) 
            {
                //läser in numren från tangentbordet
                input = int.Parse(Console.ReadLine());
                if (input > maxValue) 
                {
                    secMaxValue = maxValue;
                    maxValue = input;
                        //i++;
                        //secMaxValue= maxValue;
                        //maxValue =inputValue;
                }
                else if (input > secMaxValue) 
                {
                    secMaxValue = input;
                }
                else if (secMaxValue > maxValue) 
                {
                    secMaxValue = maxValue;
                }

                
            }
            Console.WriteLine("Det näst största talet är {0}.", secMaxValue);
            Console.WriteLine("Tryck in valfri tangent för att avsluta.");
            Console.ReadLine();           
        }

    }
}
