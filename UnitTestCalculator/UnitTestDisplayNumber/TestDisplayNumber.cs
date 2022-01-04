using Microsoft.VisualStudio.TestTools.UnitTesting;
using nsDisplayNumber;

namespace UnitTestCalculator
{
    [TestClass]
    public class TestDisplayNumber : DisplayNumber
    {
        [TestMethod]
        public void Delete_LastCharacter()
        {
            //Arrange
            Number = "123";
            var expected = "12";

            //Act
            Delete();
            var actual = Number;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reset_ResetDisplayNumberString()
        {
            //Arrange
            Number = "12,3";
            var expected = "";

            //Act
            Reset();
            var actual = Number;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecimalComma_EmptyNumber_ZeroAndCommaAdded()
        {
            //Arrange
            Number = "";
            var expected = "0,";

            //Act
            var actual = DecimalComma();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecimalComma_NonDecimalNumber_CommaIsAdded()
        {
            //Arrange
            Number = "123";
            var expected = Number + ',';

            //Act
            var actual = DecimalComma();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecimalComma_DecimalNumber_CommaIsNotAdded()
        {
            //Arrange
            Number = "12,3";
            var expected = Number;

            //Act
            var actual = DecimalComma();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
