using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fraction
    {
        private int _numerator;
        private int _denominator;
        //private int number = 0;

        public int getNumerator
        {
            get{return _numerator; }
            set 
            {
                _numerator = value;
            }

        }
        public int getDenomirator 
        {
            get{return _denominator; }
            set
            {
                if( value == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    throw new ArgumentException ("Du kan inte ange en nämnare med värdet 0.");
                    
                }
                _denominator = value;
            }
            
        }
        public Fraction(int Numerator, int Denominator) 
        {
            getNumerator = Numerator;
            getDenomirator = Denominator;
        }
        // kollar varje bråk efter lika nämnare och plussar två bråktal, fann lösningen på http://www.codeproject.com/Articles/11971/Fractions-in-C
        public static Fraction operator + (Fraction a, Fraction b) 
        {
        int Nume = a.getNumerator  * b.getDenomirator +b.getNumerator *a.getDenomirator;
        int Denum =  a.getDenomirator *  b.getDenomirator;
        return new Fraction( Nume, Denum );

        }
        //multiplicerar täljarna, multiplicerar nämnarna, Fann lösningen på http://www.codeproject.com/Articles/11971/Fractions-in-C
        public static Fraction operator * (Fraction a, Fraction b) 
        {
            int Nume = a.getNumerator * b.getDenomirator;
            int Denum = a.getDenomirator * b.getNumerator;
            return new Fraction(Nume, Denum);
        }
        public bool isNegative() 
        {   //om täljaren / nämnaren är mindre än 0 så retunera sant
            if (_numerator < 0 || _denominator < 0) 
            {
                return true;
            }
            else 
            {
                return false;
            }

        }
        public bool isEqualTo( Fraction left, Fraction right)
        {
            return (decimal)left.getNumerator * right.getDenomirator == (decimal)right.getNumerator * right.getDenomirator;
            //if (left.getDenomirator == right.getDenomirator && left.getNumerator == right.getNumerator)
            //if (this.getDenomirator == left.getDenomirator && this.getNumerator == left.getNumerator)
            //{
              //  return true;
            //}
            //else 
            //{
              //  return false;
            //}
        
        }
        public override string ToString()
        {
            return string.Format("Ditt bråktal är {0}/{1}.", getNumerator, getDenomirator);
        }
    }
}
