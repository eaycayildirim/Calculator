using System;

namespace nsOperations
{
    public class Sqrt : Operations
    {
        public Sqrt() : base(new OperationData(false, false, "\u221A"))
        {
        }

        public override double Compute(double firstNumber, double secondNumber = 2d)
        {
            return Math.Pow(firstNumber, 1 / secondNumber);
        }
    }
}
