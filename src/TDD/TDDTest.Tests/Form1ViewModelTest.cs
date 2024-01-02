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
            var viewModel = new Form1ViewModel(new DBMock());

            Assert.AreEqual("", viewModel.ATextBoxText);
            Assert.AreEqual("", viewModel.BTextBoxText);
            Assert.AreEqual("", viewModel.ResultLabelText);

            viewModel.ATextBoxText = "2";
            viewModel.BTextBoxText = "5";
            viewModel.CalculationAction();

            Assert.AreEqual("107", viewModel.ResultLabelText);
        }
    }

    internal class DBMock : IDB
    {
        public int GetDBValue()
        {
            return 100;
        }
    }
}
