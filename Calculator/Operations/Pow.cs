using System;

namespace nsOperations
{
    public class Pow : Operations
    {
        public Pow() : base(new OperationData(false, false, "x\u00B2"))
        {
        }

        public override double Compute(double firstNumber, double secondNumber = 2d)
        {
            return Math.Pow(firstNumber, secondNumber);
        }
    }
}
