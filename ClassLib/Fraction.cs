using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class FractionLostPrecision : Exception
    {
        public FractionLostPrecision() { }
        public FractionLostPrecision(string message) : base(message) { }
        public FractionLostPrecision(string message, Exception? innerException) : base(message, innerException) { }
    }
    public class Fraction
    {
        public Fraction(int n = 0, int d = 1)
        {
            Num = n;
            Den = d;
        }

        public int Num { get; private init; }// with default props can set different access for get/set

        public int Den
        {          
            private init
            {
                if (value == 0)
                    throw new ArgumentException("Denominator may not be 0");

                _denominator = value;
            }
            get { return _denominator; }

        }

        private readonly int _denominator;

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(
                a.Num * b.Num,
                a.Den * b.Den);
        }
        /// <summary>
        /// INCORRECT
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return 1;
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
            try
            {
                return new Fraction(
                    -a.Num,
                    a.Den);
            }
            catch (ArgumentOutOfRangeException ae) // dont really expect to 
            {
                throw new FractionLostPrecision("xyz",ae);
            }
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

        public static explicit operator double(Fraction v)
        {
            return ((double)v.Num) / v.Den;
        }

        public static explicit operator int(Fraction v)
        {
            return v.Num / v.Den;
        }

        public static implicit operator Fraction(int x)
        {
            return new Fraction(x);
        }
    }
}
