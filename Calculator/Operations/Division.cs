namespace nsOperations
{
    public class Division : Operations
    {
        public Division() : base(new OperationData(true, true, "\u00F7")) 
        {
        }

        public override double Compute(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
