using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {


            //Test 1 kollar om det går att skriva in ett bråktal
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------Bråk test 1--------\n");
            Console.ResetColor();
            Fraction a = new Fraction(7,2);
            Console.WriteLine(a.ToString());

            //Test 2 kollar om det går att addera 2 bråktal
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n--------Bråk test 2--------\n");
            Console.ResetColor();
            Fraction c = new Fraction(7, 3);
            Fraction d = new Fraction(7, 5);
            Fraction cd = c + d;
            Console.WriteLine(cd.ToString());

            //Test 3 kollar om det går att multiplicera 2 bråktal
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n--------Bråk test 3--------\n");
            Console.ResetColor();
            Fraction cdd = c * d;
            Console.WriteLine(cdd.ToString());

            //Test 4 kollar om det går att mata in negativa bråktal
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n--------Bråk test 4--------\n");
            Console.ResetColor();
            Fraction e = new Fraction(-7, -2);
            Console.WriteLine(e.isNegative());

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n--------Bråk test 5--------\n");
            Console.ResetColor();
            Fraction f = new Fraction(1, 2);
            Fraction g = new Fraction(2, 4);
            Console.WriteLine(f.isEqualTo(g));

            //Test 6 kollar om nämnaren är en nolla och kastar i sådana fall ett undantag
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n--------Bråk test 6--------\n");
            Console.ResetColor();
            Fraction s = new Fraction(7, 0);
            Console.WriteLine(s.ToString());
            Console.ReadKey();

        }
    }
}
