using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorMVC.Models;
using System;

namespace CalculatorMVCTests
{
    [TestClass]
    public class CalculatorModelTests
    {
        private CalculatorModel _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new CalculatorModel();
        }

        [TestMethod]
        public void TestAdd()
        {
            double result = _calculator.Add(2, 3);
            Assert.AreEqual(5, result, "Операція додавання працює некоректно");
        }

        [TestMethod]
        public void TestSubtract()
        {
            double result = _calculator.Subtract(5, 3);
            Assert.AreEqual(2, result, "Операція віднімання працює некоректно");
        }

        [TestMethod]
        public void TestMultiply()
        {
            double result = _calculator.Multiply(4, 5);
            Assert.AreEqual(20, result, "Операція множення працює некоректно");
        }

        [TestMethod]
        public void TestDivide()
        {
            double result = _calculator.Divide(10, 2);
            Assert.AreEqual(5, result, "Операція ділення працює некоректно");
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            _calculator.Divide(10, 0);
        }
    }
}
