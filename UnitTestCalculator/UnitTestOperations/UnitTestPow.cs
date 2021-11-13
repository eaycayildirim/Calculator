using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using nsOperations;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestPow
    {
        [TestMethod]
        public void PowTwoPositiveNumbers()
        {
            //Given
            double firstNumber = 3;
            double secondNumber = 2;
            double expected = 9;

            //When
            double actual = Pow.Calculate(firstNumber, secondNumber);

            //Then
            Assert.AreEqual(expected, actual);
        }
    }
}
