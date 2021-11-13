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
            return this._operation.Compute(Result, number);
        }

        public double Result { get; set; }

        private IOperations _operation;
    }
}
