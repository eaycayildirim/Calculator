using Microsoft.VisualStudio.TestTools.UnitTesting;
using nsTextBoxResult;
using nsOperations;

namespace UnitTestCalculator
{
    [TestClass]
    public class TestTextBoxResult : TextBoxResult
    {
        [TestMethod]
        public void Compute_TwoPlusOne_ReturnsThree()
        {
            //Arrange
            Result = 2;
            SetOperation(new Sum());
            var number = 1;
            var expected = Result + number;

            //Act
            var actual = Compute(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
