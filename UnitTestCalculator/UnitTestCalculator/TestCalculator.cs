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
            this._calculator = new Calculator(ref _result, ref _displayNumber);
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
        public void Compute_SumTenAndThree_ReturnsThirteen()
        {
            //Arrange
            SetUp(new ResultNumber("10"), new DisplayNumber("3"));
            var operation = new Sum();
            var expected = "13";

            //Act
            _calculator.Calculate(operation);
            var actual = _calculator.GetResult();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Compute_SubstractTenAndThree_ReturnsSeven()
        {
            //Arrange
            SetUp(new ResultNumber("10"), new DisplayNumber("3"));
            var operation = new Substract();
            var expected = "7";

            //Act
            _calculator.Calculate(operation);
            var actual = _calculator.GetResult();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Compute_DivisionTenAndFive_ReturnsTwo()
        {
            //Arrange
            SetUp(new ResultNumber("10"), new DisplayNumber("5"));
            var operation = new Division();
            var expected = "2";

            //Act
            _calculator.Calculate(operation);
            var actual = _calculator.GetResult();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Compute_MultiplyTwoAndFive_ReturnsTen()
        {
            //Arrange
            SetUp(new ResultNumber("2"), new DisplayNumber("5"));
            var operation = new Multiply();
            var expected = "10";

            //Act
            _calculator.Calculate(operation);
            var actual = _calculator.GetResult();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Compute_PowOfThree_ReturnsNine()
        {
            //Arrange
            SetUp(new ResultNumber("10"), new DisplayNumber("3"));
            var operation = new Pow();
            var expected = "9";

            //Act
            _calculator.Calculate(operation);
            var actual = _calculator.GetDisplayNumber();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Compute_SqrtOfNine_ReturnsThree()
        {
            //Arrange
            SetUp(new ResultNumber("10"), new DisplayNumber("9"));
            var operation = new Sqrt();
            var expected = "3";

            //Act
            _calculator.Calculate(operation);
            var actual = _calculator.GetDisplayNumber();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_SumThreeAndThree_ReturnsSix()
        {
            //Arrange
            SetUp(new ResultNumber("3"), new DisplayNumber("3"));
            var expected = "6";

            //Act
            _calculator.Calculate(new Sum());
            var actual = _calculator.GetResult();

            //Assert
            Assert.AreEqual(_calculator.GetDisplayNumber(), "3");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_SubstractNineAndThree_ReturnsSix()
        {
            //Arrange
            SetUp(new ResultNumber("9"), new DisplayNumber("3"));
            var expected = "6";

            //Act
            _calculator.Calculate(new Substract());
            var actual = _calculator.GetResult();

            Assert.AreEqual(_calculator.GetDisplayNumber(), "3");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_MultiplyTwoAndFive_ReturnsTen()
        {
            //Arrange
            SetUp(new ResultNumber("2"), new DisplayNumber("5"));
            var expected = "10";

            //Act
            _calculator.Calculate(new Multiply());
            var actual = _calculator.GetResult();

            Assert.AreEqual(_calculator.GetDisplayNumber(), "5");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_DivisionTenAndTwo_ReturnsFive()
        {
            //Arrange
            SetUp(new ResultNumber("10"), new DisplayNumber("2"));
            var expected = "5";

            //Act
            _calculator.Calculate(new Division());
            var actual = _calculator.GetResult();

            Assert.AreEqual(_calculator.GetDisplayNumber(), "2");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_SqrtOfNine_ReturnsThree()
        {
            //Arrange
            SetUp(new ResultNumber(""), new DisplayNumber("9"));
            var expected = "3";

            //Act
            _calculator.Calculate(new Sqrt());
            var actual = _calculator.GetDisplayNumber();

            Assert.AreEqual(_calculator.GetResult(), string.Empty);
            Assert.AreEqual(expected, actual);
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
