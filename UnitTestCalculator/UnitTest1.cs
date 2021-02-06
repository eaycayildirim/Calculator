using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorOperations;
using Calculator;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestCalculator
    {
        [TestMethod]
        public void SummingTwoPositiveNumbers()
        {
            //Given
            int first_number = 2;
            int second_number = 5;
            double expected = 7;

            //When
            double actual = CalculatingOperations.compute(first_number, second_number, new Sum());

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SummingTwoNegativeNumbers()
        {
            //Given
            int first_number = -2;
            int second_number = -5;
            double expected = -7;

            //When
            double actual = CalculatingOperations.compute(first_number, second_number, new Sum());

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplyingTwoPosiviteNumbers()
        {
            Operation p = new Multiply();

            //Given
            int first_number = 2;
            int second_number = 5;
            double expected = 10;

            //When
            double actual = CalculatingOperations.compute(first_number, second_number, p);

            //Then
            Assert.AreEqual(expected, actual);
        }
    }
}
