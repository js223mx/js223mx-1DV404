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
        private int number = 0;

        public int getNumerator()
        {
            return _numerator;
        }
        public int getDenomirator() 
        {
            return _denominator;
            (if _denominator == 0)
            {

            }
        }
        public int add() 
        {

        }
        public int multiply() 
        {

        }
        public bool isNegative() 
        {   //om täljaren / nämnaren är mindre än 0 så retunera sant
            if (_numerator / _denominator < 0) 
            {
                return true;
            }
            else 
            {
                return false;
            }

        }
        public int isEqualTo() 
        {

        }
       
    }
}
