using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLib;

namespace ClassLib.Test2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add()
        {
            //AAA
            int sum = Utilities.Add(3, 4);
            Assert.AreEqual(7, sum);

        }

        [TestMethod]
        public void Add4()
        {
            //AAA
            var sum = ClassLib.Utilities.Add(1, 2, 3, 4); // inferred type
            Assert.AreEqual(10, sum);
            sum.Should().BeGreaterOrEqualTo(10).And.Be(10);
        }

        [TestMethod]
        public void LanguageTest2()
        {
            Assert.AreNotEqual(4.2m, 4.2f);
            Assert.AreEqual((float)Int32.MaxValue - 1, (float)Int32.MaxValue);
            Assert.AreNotEqual(Int32.MaxValue - 1, Int32.MaxValue);

            float f1 = 0.3333333333f, f2 = 1 / 3.0f;
            const double Delta = 0.00001;
            Assert.IsTrue(Math.Abs(f1 - f2) < Delta);
            Assert.AreEqual(f1, f2, Delta);

        }

        [TestMethod]
        public void LanguageTest()
        {
            // verbatim string @ as prefix ($ prefix string interpolation)
            "http:\\\\www.example.com".Should().Be(@"http:\\www.example.com");
            var s = @"The 
la  zy
brown
fox".Should().Contain("\n");
        }


        [TestMethod]
        public void Swap()
        {
            int a = 1, b = 2;
            Utilities.Swap(ref a, ref b);
            a.Should().Be(2);
        }


        [TestMethod]
        public void PassOut()
        {
            int a, b, price = 100;
            Utilities.PassOut(out a, out b);
            a.Should().Be(3);

            if (Int32.TryParse("2", out a))
            {
                price *= a;
                price.Should().Be(200);
            }
        }


        [TestMethod]
        public void MultiType()
        {
            var ret = Utilities.MultiType(5);
            ret.Item3.Should().Be("5");
            ret.Item2.Should().Be(5.0);

        }


        //[TestMethod]
        //public void TDatetime()
        //{
        //    DateTime dt = DateTime.Now;
        //    dt.Month.Should().Be(2);
        //    dt.DayOfWeek.Should().Be(DayOfWeek.Monday);
        //    DateTime dt2 = DateTime.Now.Subtract(TimeSpan.FromHours(2));
        //    dt2.Hour.Should().Be(16);

        //    ((int)DayOfWeek.Monday).Should().Be(1);
        //    ((int)DayOfWeek.Sunday).Should().Be(0);
        //    if (dt < dt2)
        //    {
        //        throw new Exception();
        //    }

        //    var diff = dt - dt2;
        //    diff.Should().BeCloseTo(TimeSpan.FromHours(2), TimeSpan.FromMilliseconds(109));
        //      DateTimeOffset
        //}

        // in Java enums are Not ints, they are final static objects
        // EFFective C#
        enum Gender // enums are int under the hood
        {
            NotSet = 0,
            Male = 10,
            Female = 15
        } // avoid magic number

        [TestMethod]
        public void EnumTest()
        {
            Gender g = Gender.Male;

            //if (g == Gender.Male)
            //{
            //    throw new Exception();
            //}

            g++;
            ((int)g).Should().Be(11);
            (--g).Should().Be(Gender.Male);

            
        }
    }
}