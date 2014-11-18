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
            //int value;           
            //string input = Console.ReadLine();
            //int.TryParse(input, out value);
            //int number = 0;
            //int maxNumber = 0;
            //int tempvar;
            int maxValue;
            int secMaxValue;
            int input = 0;

            maxValue = input;
            secMaxValue = input;

            Console.Write("Mata in 10 heltal: ");
            //läser in numren från tangentbordet
            input = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < 10; i++) 
            {
               
                //if (i == 0) { 

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

                //}
            }
                       
        }

    }
}
