namespace nsOperations
{
    public class Undefined : Operations
    {
        public Undefined() : base(new OperationData(false, false, ""))
        {
        }

        public override double Compute(double firstNumber, double secondNumber)
        {
            return firstNumber;
        }
    }
}
