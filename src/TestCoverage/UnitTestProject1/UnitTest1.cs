using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestCoverage;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1.CallA(1, 2).Is(3);
            Class1.CallB(2, 5).Is(7);
            Class1.CallB(0, 5).Is(1);
            Class1.CallC(10, 4).Is(6);
        }
    }
}
