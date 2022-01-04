using nsOperations;

namespace nsOperations
{
    public class Substract : Operations
    {
        public Substract() : base(new OperationData(true, true, "-"))
        {
        }

        public override double Compute(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
