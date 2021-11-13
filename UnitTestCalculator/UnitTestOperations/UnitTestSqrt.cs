using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using nsOperations;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestSqrt
    {
        [TestMethod]
        public void SqrtTwoPositiveNumbers()
        {
            //Given
            double number = 9;
            double expected = 3;

            //When
            double actual = Sqrt.Calculate(number);

            //Then
            Assert.AreEqual(expected, actual);
        }
    }
}
