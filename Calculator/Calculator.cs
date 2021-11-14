using nsIOperations;
using System;
using nsTextBoxResult;
using nsDisplayNumber;

namespace nsCalculator
{
    public class Calculator
    {
        public Calculator()
        {
            this._result = new TextBoxResult();
            this._displayNumber = new DisplayNumber();
        }

        public void AddNumbers(string number)
        {
            this._displayNumber.DisplayNumberString += number;
        }

        public void SetOperation(IOperations operation)
        {
            this._result.SetOperation(operation);
        }

        public void Calculate()
        {
            this._result.Compute(this._displayNumber.ParseStringToDouble());
            //this._displayNumber.ParseDoubleToString(_result.Result);
        }

        public string UpdateNumber()
        {
            return this._displayNumber.DisplayNumberString;
        }

        public string UpdateResult()
        {
            if (_result.Result != 0)
                return _result.Result.ToString();
            else
                return _displayNumber.DisplayNumberString;
        }

        public void AddComma()
        {
            this._displayNumber.DecimalComma();
        }

        public void Reset()
        {
            this._result.Reset();
            ResetFirstNumber();
        }

        public void ResetFirstNumber()
        {
            this._displayNumber.Reset();
        }

        public void Delete()
        {
            this._displayNumber.Delete();
        }

        private TextBoxResult _result;
        private DisplayNumber _displayNumber;
    }
}
