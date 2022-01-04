namespace nsOperations
{
    public class Sum : Operations
    {
        public Sum() : base(new OperationData(true, true, "+"))
        {
        }

        public override double Compute(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
