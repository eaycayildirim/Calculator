using Microsoft.VisualStudio.TestTools.UnitTesting;
using nsTextBoxResult;
using nsOperations;
using System;

namespace UnitTestCalculator
{
    [TestClass]
    public class TestTextBoxResult : TextBoxResult
    {
        [TestMethod]
        public void Reset_ResetResultString()
        {
            //Arrange
            ResultString = "2";
            var expectedResultString = "";

            //Act
            Reset();
            var actualResultString = ResultString;

            //Assert
            Assert.AreEqual(expectedResultString, actualResultString);
        }

        [TestMethod]
        public void Compute_TwoPlusOne_ReturnsThree()
        {
            //Arrange
            ResultString = "2";
            SetOperation(new Sum());
            var number = 1;
            var expected = Convert.ToDouble(ResultString) + number;

            //Act
            Compute(number);
            var actual = ResultString;

            //Assert
            Assert.AreEqual(expected.ToString(), actual);
        }
    }
}
