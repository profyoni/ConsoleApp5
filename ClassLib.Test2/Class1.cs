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

        //[TestMethod]
        //public void DoubleCast()
        //{
        //    var f1 = new Fraction(7, 9);

        //    double d = (double) f1;

        //    int x = (int) f1;

        //    f1 = 56; // safe
        //}
    }
}