using nsOperations;
using System;

namespace nsCalculator
{
    public class Calculator
    {
        private double AskTheNumber()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        private string AskTheOperation()
        {
            return Console.ReadLine();
        }

        private double Calculate(double firstNumber, double secondNumber, string operation)
        {
            switch (operation)
            {
                case "Sum":
                    return Sum.Calculate(firstNumber, secondNumber);
                case "Substract":
                    return Substract.Calculate(firstNumber, secondNumber);
                case "Multiply":
                    return Multiply.Calculate(firstNumber, secondNumber);
                case "Division":
                    return Division.Calculate(firstNumber, secondNumber);
                case "Pow":
                    return Pow.Calculate(firstNumber, secondNumber);
                default:
                    return 0;
            }
        }

        public void Compute()
        {
            double firstNumber = AskTheNumber();
            string operation = AskTheOperation();
            double result = 0;

            while (operation != "Equal")
            {
                if (operation == "Sqrt")
                    result = Sqrt.Calculate(firstNumber);
                else
                {
                    double secondNumber = AskTheNumber();
                    result = Calculate(firstNumber, secondNumber, operation);
                    firstNumber = result;
                }
                operation = AskTheOperation();
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
