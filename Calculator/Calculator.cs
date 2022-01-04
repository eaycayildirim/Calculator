using nsOperations;
using System;
using nsResultNumber;
using nsDisplayNumber;

namespace nsCalculator
{
    public class Calculator
    {
        public Calculator(ref ResultNumber textBoxResult, ref DisplayNumber displayNumber)
        {
            this._result = textBoxResult;
            this._displayNumber = displayNumber;
        }

        public void AddChar(char number)
        {
            this._displayNumber.DisplayNumberString += number;
        }

        public void SetOperation(Operations operation)
        {
            this._result.SetOperation(operation);
        }

        public void Calculate()
        {
            if(!this._displayNumber.DisplayNumberString.Equals(""))
                this._result.Compute(Convert.ToDouble(this._displayNumber.DisplayNumberString));
        }

        public string GetDisplayNumber()
        {
            return this._displayNumber.DisplayNumberString;
        }

        public string GetResult()
        {
            return _result.ResultString;
        }

        public void DecimalComma()
        {
            this._displayNumber.DecimalComma();
        }

        public void Reset()
        {
            this._result.Reset();
            ResetDisplayNumber();
        }

        public void ResetDisplayNumber()
        {
            this._displayNumber.Reset();
        }

        public void DeleteLastNumber()
        {
            this._displayNumber.Delete();
        }

        private ResultNumber _result;
        private DisplayNumber _displayNumber;
    }
}
