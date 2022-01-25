using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLib.Test
{
    [TestClass] // ~annotation
    public class UtilitiesTest
    {
        [TestMethod]
        public void Add()
        {
            //AAA
            int sum = ClassLib.Utilities.Add(3, 4);
            Assert.AreEqual(7, sum);

        }
    }
}
