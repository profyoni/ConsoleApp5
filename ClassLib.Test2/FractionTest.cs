using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLib;

namespace ClassLib.Test2
{
    [TestClass]
    public class FractionTest
    {
        [TestMethod]
        public void PropTest()
        {
            Fraction f = new Fraction(7, 9);
            //f.Num = 7; // value = 7 , prop is l-value

            f.Num.Should().Be(7);
        }

        [TestMethod]
        public void DefaultArgument()
        {
            Fraction f = new Fraction(5);
            f.Num.Should().Be(5);
            f.Den.Should().Be(1);
        }

        [TestMethod]
        public void DefaultArgument2()
        {
            Fraction f = new Fraction();
            f.Num.Should().Be(0);
            f.Den.Should().Be(1);
        }

        [TestMethod]
        public void PassByName()
        {
            Fraction f = new Fraction(d: 5);
            f.Num.Should().Be(0);
            f.Den.Should().Be(5);
        }

        [TestMethod]
        public void Add()
        {
            Fraction f1 = new Fraction(2, 3);
            Fraction f2 = new Fraction(2, 3);

            Fraction prod = f1 * f2;

            prod.Should().Be(new Fraction(4, 9));
        }

        [TestMethod]
        public void UnaryNegation()
        {
            Fraction f1 = new Fraction(2, 3);

            (-f1).Should().Be(new Fraction(-2, 3));
        }


        [TestMethod]
        public void EqialityOp()
        {
            Fraction f1 = new Fraction(2, 3);
            Fraction f2 = new Fraction(2, 3);

            (f1 == f2).Should().BeTrue();
        }

        [TestMethod]
        public void StringEquality()
        {
            var s1 = "Bob";
            var s2 = "Bob" + "";

            (s1 == s2).Should().BeTrue();
        }

        void foo(Fraction f)
        {

        }

        // lossy conversions required cast - explicit
        // nonlossy - auto cast - implicit
        [TestMethod]
        public void DoubleCast()
        {
            var f1 = new Fraction(7, 9);

            double d = (double)f1;

            d.Should().BeApproximately(7.0 / 9.0, 0.000001);
            int x = (int)f1;
            x.Should().Be(0);

            Fraction f2 = 3;
            f2.Num.Should().Be(3);
            f2.Den.Should().Be(1);

            foo(3); // safe

            var f3 = f1 * 6;

            f3.Num.Should().Be(42);
            f3.Den.Should().Be(9);

            (f3 != 4).Should().BeTrue();

            var q = f1 + f2 * f3;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ZeroDenominator()
        {
            new Fraction(1, 0);
        }

        [TestMethod]
        [Timeout(500)]
        public void FluentExceptionTest()
        {
            Action act = () => new Fraction(1, 0); ;
            System.Threading.Thread.Sleep(3);
            act.Should().Throw<ArgumentException>()
               // .WithInnerException<IndexOutOfBoundsException>()
                .WithMessage("Denominator may not be 0");
        }
    }
}