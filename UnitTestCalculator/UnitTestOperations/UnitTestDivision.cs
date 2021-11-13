using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using nsOperations;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestDivision
    {
        [TestMethod]
        public void DivisionTwoPositiveNumbers()
        {
            //Given
            double firstNumber = 10;
            double secondNumber = 2;
            double expected = 5;

            //When
            double actual = Division.Calculate(firstNumber, secondNumber);

            //Then
            Assert.AreEqual(expected, actual);
        }
    }
}
