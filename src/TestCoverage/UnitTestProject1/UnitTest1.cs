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
            Assert.AreEqual(3, Class1.Add(1, 2));
        }
    }
}
