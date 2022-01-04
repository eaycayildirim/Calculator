namespace nsOperations
{
    public class Multiply : Operations
    {
        public Multiply() : base(new OperationData(true, true, "x"))
        {
        }

        public override double Compute(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
