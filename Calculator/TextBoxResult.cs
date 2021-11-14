using System;
using nsIOperations;
using nsOperations;

namespace nsTextBoxResult
{
    public class TextBoxResult
    {
        public TextBoxResult()
        {
            Reset();
        }

        ~TextBoxResult() { }

        public void Reset()
        {
            Result = 0;
            Operation = new Sum();
            ResultString = "";
        }

        public void SetOperation(IOperations operation)
        {
            this.Operation = operation;
        }

        public double Compute(double number)
        {
            Result = this.Operation.Compute(Result, number);
            return Result;
        }

        private double Result { get; set; }

        public string ResultString { get; set; }

        public IOperations Operation { get; set; }
    }
}
