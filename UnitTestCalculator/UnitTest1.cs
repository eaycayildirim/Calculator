using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using nsCalculator;
using nsIOperations;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumTwoNumbers()
        {
            //Given
            double firstNumber = 2;
            double secondNumber = 3;
            double expected = 5;
            IOperations operation = new Sum();

            //When
            Calculator calculator = new Calculator();
            double actual = calculator.Compute(firstNumber, secondNumber, operation);

            //Then
            Assert.AreEqual(expected, actual);
        }
    }
}
