using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLib.Test2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add()
        {
            //AAA
            int sum = ClassLib.Utilities.Add(3, 4);
            Assert.AreEqual(7, sum);

        }

        [TestMethod]
        public void Add4()
        {
            //AAA
            int sum = ClassLib.Utilities.Add(1,2,3,4);
            Assert.AreEqual(10, sum);

        }
    }
}