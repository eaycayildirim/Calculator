using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using nsOperations;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestSum
    {
        [TestMethod]
        public void SumTwoPositiveNumbers()
        {
            //Given
            double firstNumber = 3;
            double secondNumber = 1;
            double expected = 4;

            //When
            double actual = Sum.Calculate(firstNumber, secondNumber);

            //Then
            Assert.AreEqual(expected, actual);
        }
    }
}
