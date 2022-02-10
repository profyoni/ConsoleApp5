using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Fraction
    {
        public Fraction(int n = 0, int d = 1)
        {
            Num = n;
            Den = d;
        }

        public int Num { get; private set; }// with default props can set different access for get/set

        public int Den
        {
            get { return _denominator; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Denominator may not be 0");

                _denominator = value;
            }
        }

        private int _denominator;

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(
                a.Num * b.Num,
                a.Den * b.Den);
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a==b);
        }

        public static Fraction operator -(Fraction a)
        {
            return new Fraction(
                -a.Num ,
                a.Den );
        }

        public override bool Equals(Object o)
        {
            if (o == null)
                return false;
            if (o.GetType() != typeof(Fraction))
                return false;
            Fraction that = ((Fraction)o);
            return  this.Num == that.Num && this.Den == that.Den;
        }

    }
}
