namespace nsIOperations
{
    public class Sum : IOperations
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
