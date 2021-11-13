using nsIOperations;
using System;
using nsResult;
using nsDisplayNumber;

namespace nsCalculator
{
    public class Calculator
    {
        public Calculator()
        {

        }


        //private double AskTheNumber()
        //{
        //    return Convert.ToDouble(Console.ReadLine());
        //}

        //private string AskTheOperation()
        //{
        //    return Console.ReadLine();
        //}

        //private IOperations GetOperation(string input)
        //{
        //    switch (input)
        //    {
        //        case "Sum":
        //            return new Sum();
        //        case "Substract":
        //            return new Substract();
        //        case "Multiply":
        //            return new Multiply();
        //        case "Division":
        //            return new Division();
        //        case "Pow":
        //            return new Pow();
        //        case "Sqrt":
        //            return new Sqrt();
        //        default:
        //            return new Equals();
        //    }
        //}

        //private double GetResult(double firstNumber, double secondNumber, IOperations operation)
        //{
        //    return operation.Compute(firstNumber, secondNumber);
        //}

        //public void Compute()
        //{
        //    double firstNumber = AskTheNumber();
        //    string operation = AskTheOperation();
        //    IOperations op = GetOperation(operation);
        //    double result = 0;

        //    while (operation != "Equals")
        //    {
        //        //if (operation == "Sqrt")
        //            //result = Sqrt.Calculate(firstNumber);
        //        //else
        //        //{
        //            double secondNumber = AskTheNumber();
        //            result = GetResult(firstNumber, secondNumber, op);
        //            firstNumber = result;
        //        //}
        //        operation = AskTheOperation();
        //        op = GetOperation(operation);
        //    }

        //    Console.WriteLine(result);
        //    Console.ReadKey();
        //}



        private Result _result;
        private DisplayNumber _displayNumber;
    }
}
