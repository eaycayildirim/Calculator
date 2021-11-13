using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using nsOperations;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestSubstract
    {
        [TestMethod]
        public void SubstractTwoPositiveNumbers()
        {
            //Given
            double firstNumber = 3;
            double secondNumber = 1;
            double expected = 2;

            //When
            double actual = Substract.Calculate(firstNumber, secondNumber);

            //Then
            Assert.AreEqual(expected, actual);
        }
    }
}
