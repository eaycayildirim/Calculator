using nsOperations;

namespace nsOperations
{
    public class Equals : Operations
    {
        public Equals() : base(new OperationData(true, false, "="))
        {
        }

        public override double Compute(double firstNumber, double secondNumber = 0)
        {
            return firstNumber;
        }
    }
}
