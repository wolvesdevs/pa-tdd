using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDD.UI;

namespace TDDTest.Tests
{
    [TestClass]
    public class Form1ViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var viewModel = new Form1ViewModel();
            Assert.AreEqual("", viewModel.ATextBoxText);
            Assert.AreEqual("", viewModel.BTextBoxText);
            Assert.AreEqual("", viewModel.ResultLabelText);
        }
    }
}
