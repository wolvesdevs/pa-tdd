using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UsefulTool;

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

        [TestMethod]
        [ExpectedException(typeof(InputException))]
        public void 例外のテスト()
        {
            Assert.AreEqual(3, Class1.Add(-1, 2));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Class1.Add(1,3).Is(4);
            var ex = AssertEx.Throws<InputException>(() => Class1.Add(-1, 3));
            ex.Message.Is("マイナス値は入力できません");
        }
    }
}
