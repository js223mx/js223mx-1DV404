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
            int inputValue = 0;
            int maxValue = 0;
            int secMaxValue = 0;
            int tempvar = 0;
 
            int input;
           // Console.Write("Mata in 10 heltal:");
            //int.TryParse(input, out inputValue);

            for (int i = 0; i < 10; i++) 
            {
                Console.Write("Mata in {0} heltal: ", i + 1);
                //läser in numren från tangentbordet
                input = int.Parse(Console.ReadLine());

                if (i == 0) 
                {
                    maxValue = tempvar;
                        //i++;
                        //secMaxValue= maxValue;
                        //maxValue =inputValue;
                }
                else if (i == 1) 
                {
                    if (maxValue < tempvar) 
                    {

                    }
                    else 
                    {
                        secMaxValue = tempvar;
                    }
                    
                  
                }
                else 
                {
                    if (tempvar > secMaxValue && tempvar < maxValue) 
                    {
                        secMaxValue = tempvar;
                    }
                }
            }
            
        }

    }
}
