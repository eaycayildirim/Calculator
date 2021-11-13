using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using nsOperations;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestMultiply
    {
        [TestMethod]
        public void MultiplyTwoPositiveNumbers()
        {
            //Given
            double firstNumber = 3;
            double secondNumber = 2;
            double expected = 6;

            //When
            double actual = Multiply.Calculate(firstNumber, secondNumber);

            //Then
            Assert.AreEqual(expected, actual);
        }
    }
}
