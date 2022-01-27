using FluentAssertions;
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
            var sum = ClassLib.Utilities.Add(1, 2, 3, 4); // inferred type
            Assert.AreEqual(10, sum);
            sum.Should().BeGreaterOrEqualTo(10).And.Be(10);
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
    }
}