using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLib.Test2
{
    [TestClass]
    public class Utilities2Test
    {
        [TestMethod]
        public void RangeList()
        {
            int total = 0;
            var range = Utilities2.RangeList(1, 1_000_000);
            foreach (var i in range)
            {
                total += i;
                if (i == 10)
                    break;
            }

            Assert.AreEqual(55, total);
        }

        [TestMethod]
        public void Range()
        {
            int total = 0;
            var range = Utilities2.Range(1, 100_000_000);
            foreach (var i in range)
            {
                total += i;
                if (i == 10)
                    break;
            }

            Assert.AreEqual(55, total);
        }

        [TestMethod]
        public void Transform1()
        {
            var list = new List<double>() { -4.9, 98.6 };
            Utilities2.Transform(list, Math.Abs);

            Assert.AreEqual(4.9, list[0]);
        }

        [TestMethod]
        public void Transform2()
        {
            var list = new List<double>() { -180, 90 };
            Utilities2.Transform(list, Math.Sin);
            
        }

        [TestMethod]
        public void Transform3()
        {
            var list = new List<double>() { -2, 6 };
            Utilities2.Transform(list, Math.Pow);
            Assert.AreEqual(4, list[0]);
        }

        [TestMethod]
        public void LanguageTest()
        {
            MathFunction2 foo; // delegate variable
            foo = Math.Pow;

            Assert.AreEqual(9.0, foo(3.0, 2));
        }

        [TestMethod]
        public void Lambda() // short hand for method 
        {
            MathFunction foo; // delegate variable
            foo = x => x * x;

            Assert.AreEqual(9.0, foo(3.0));
        }


        [TestMethod]
        public void Lambda2() // short hand for method 
        {
            MathFunction foo; // delegate variable
            foo = x => x * x;

            Assert.AreEqual(9.0, foo(3.0));
        }

        [TestMethod]
        public void Transform4()
        {
            var list = new List<double>() { -2, 6 };
            
            Utilities2.Transform(list, (a, b) =>
            {
                double total = 1;
                for (int i = 1; i <= b; i++)
                {
                    total *= a;
                }
                return total;
            });
            Assert.AreEqual(4, list[0]);
        }

        [TestMethod]
        public void Transform5()
        {
            var list = new List<double>() { -2, 6 };

            Utilities2.Transform(list, MySimplePowMethod);
            Assert.AreEqual(4, list[0]);
        }

        private double MySimplePowMethod(double a, double b)
        {
            double total = 1;
                for (int i = 1; i <= b; i++)
                {
                    total *= a;
                }
                return total;
            
        }
    }
}
