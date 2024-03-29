﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using nsResultNumber;
using nsOperations;
using System;

namespace UnitTestCalculator
{
    [TestClass]
    public class TestResultNumber : ResultNumber
    {
        [TestMethod]
        public void Reset_ResetResultString()
        {
            //Arrange
            Number = "2";
            var expectedResultString = "";

            //Act
            Reset();
            var actualResultString = Number;

            //Assert
            Assert.AreEqual(expectedResultString, actualResultString);
        }

        //[TestMethod]
        //public void Compute_TwoPlusOne_ReturnsThree()
        //{
        //    Arrange
        //    ResultString = "2";
        //    SetOperation(new Sum());
        //    var number = 1;
        //    var expected = Convert.ToDouble(ResultString) + number;

        //    Act
        //    Compute(number);
        //    var actual = ResultString;

        //    Assert
        //    Assert.AreEqual(expected.ToString(), actual);
        //}
    }
}
