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
            _operation = new Sum();
        }

        public void SetOperation(IOperations operation)
        {
            this._operation = operation;
        }

        public double Compute(double number)
        {
            Result = this._operation.Compute(Result, number);
            return Result;
        }

        public double Result { get; set; }

        private IOperations _operation;
    }
}
