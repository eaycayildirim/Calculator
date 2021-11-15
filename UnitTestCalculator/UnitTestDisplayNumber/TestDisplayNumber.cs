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
            DisplayNumberString = "123";
            var expected = "12";

            //Act
            Delete();
            var actual = DisplayNumberString;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecimalComma_NonDecimalNumber_CommaIsAdded()
        {
            //Arrange
            DisplayNumberString = "123";
            var expected = DisplayNumberString + ',';

            //Act
            var actual = DecimalComma();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecimalComma_DecimalNumber_CommaIsNotAdded()
        {
            //Arrange
            DisplayNumberString = "12,3";
            var expected = DisplayNumberString;

            //Act
            var actual = DecimalComma();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
