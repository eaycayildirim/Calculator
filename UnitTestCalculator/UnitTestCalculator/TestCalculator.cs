using Microsoft.VisualStudio.TestTools.UnitTesting;
using nsCalculator;
using nsResultNumber;
using nsDisplayNumber;
using nsOperations;

namespace UnitTestCalculator
{
    [TestClass]
    public class TestCalculator
    {

        public void SetUp(ResultNumber result, DisplayNumber displayNumber)
        {
            this._result = result;
            this._displayNumber = displayNumber;
            this._calculator = new Calculator(ref result, ref displayNumber);
        }

        [TestMethod]
        public void AddChar_Char_IsAdded()
        {
            //Arrange
            SetUp(new ResultNumber("10"), new DisplayNumber(""));
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
            SetUp(new ResultNumber("10"), new DisplayNumber("3"));
            _result.Operation = new Sum();
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
            SetUp(new ResultNumber(""), new DisplayNumber(""));
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
        private ResultNumber _result;
        private DisplayNumber _displayNumber;
    }
}
