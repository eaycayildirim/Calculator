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
            this._displayNumber.Number += number;
        }

        public void SetOperation(Operations operation)
        {
            if (operation.GetOperationData()._isOperationChanged)
            {
                this._result.Operation = operation;
            }
        }

        public void PressChar(char number)
        {
            if (_isOperationPressed)
            {
                ResetDisplayNumber();
                _isOperationPressed = false;
            }
            AddChar(number);
        }

        public void Calculate(Operations operation)
        {
            SetOperation(operation);
            if (!_isOperationPressed || operation == new Equals())
            {
                Compute();
            }
        }

        public void Compute()
        {

        }

        public string GetDisplayNumber()
        {
            return this._displayNumber.Number;
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
        private bool _isOperationPressed = false;
    }
}
