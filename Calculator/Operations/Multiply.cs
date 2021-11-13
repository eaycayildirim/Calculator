﻿using System;

namespace nsIOperations
{
    public class Multiply : IOperations
    {
        public double Compute(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}