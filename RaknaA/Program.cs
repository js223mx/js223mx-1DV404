using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaA
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;
            int noa = 0;
            int noA = 0;

            Console.Write("Mata in en textrad: ");
            myString = Console.ReadLine();

            foreach (char a in myString) 
            {
                char y = 'a';
                char x = 'A';

                if (y == a) 
                {
                    noa += 1;
                }
                else if(x == a) 
                {
                    noA += 1;
                }               

            }
            Console.WriteLine("Antal a: " + noa);
            Console.WriteLine("Antal A: " + noA);
            
            //System.Console.WriteLine("Antal a: {0} Antal A: {1}",noa, noA);

            //int count = myString.Length - myString.TrimStart('a').Length;
            //if (c == 'a') noa++; 
        }
    }
}
