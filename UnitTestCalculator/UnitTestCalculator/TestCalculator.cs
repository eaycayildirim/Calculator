using Microsoft.VisualStudio.TestTools.UnitTesting;
using nsCalculator;
using nsTextBoxResult;
using nsDisplayNumber;
using nsOperations;

namespace UnitTestCalculator
{
    [TestClass]
    public class TestCalculator
    {
        [TestInitialize]
        public void Initialize()
        {
            _result = new TextBoxResult();
            _displayNumber = new DisplayNumber();
            _calculator = new Calculator(_result, _displayNumber);
        }

        [TestMethod]
        public void AddChar_Char_IsAdded()
        {
            //Arrange
            var numberToAdd = '2';
            _calculator.AddChar(numberToAdd);
            var expected = "2";

            //Act
            var actual = _calculator.GetDisplayNumber();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_SumTwoNumbers_ReturnsTrue()
        {
            //Arrange
            _result.ResultString = "10";
            _result.Operation = new Sum();
            _displayNumber.DisplayNumberString = "3";
            var expected = 13;

            //Act
            _calculator.Calculate();
            var actual = _result.ResultString;

            //Assert
            Assert.AreEqual(expected.ToString(), actual);
        }

        [TestMethod]
        public void Reset_ResetTheResultAndTheDisplayNumber()
        {
            //Arrange
            var expectedDisplayNumber = "";
            var expectedResultString = "";

            //Act
            _calculator.Reset();
            var actualDisplayNumber = _calculator.GetDisplayNumber();
            var actualResult = _calculator.GetResult();

            //Assert
            Assert.AreEqual(expectedDisplayNumber, actualDisplayNumber);
            Assert.AreEqual(expectedResultString, actualResult);
        }

        private Calculator _calculator;
        private TextBoxResult _result;
        private DisplayNumber _displayNumber;
    }
}
