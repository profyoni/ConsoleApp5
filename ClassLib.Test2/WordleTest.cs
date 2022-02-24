using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ClassLib.Test2
{
    [TestClass]
    public class WordleTest
    {

        [TestMethod]
        public void Test()
        {
            var w = new ClassLib.Wordle();
            w.target = "TRAIN";
            w.TryGuess("STEAM");
        }
    }
}
