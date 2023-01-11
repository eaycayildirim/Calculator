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
            if (!_isOperationPressed || operation.GetOperationData().symbol == new Equals().GetOperationData().symbol)
            {
                Compute(operation);
            }
        }

        public void Compute(Operations operation)
        {
            _displayNumber.Compute(operation);
            _result.Compute(operation, ref _displayNumber);
            _isOperationPressed = false;
        }

        public void SetOperationPressed(Operations operations) 
        {
            _isOperationPressed = true;
            _isEqualsPressed = operations.GetOperationData().symbol == new Equals().GetOperationData().symbol;
        }

        public bool isEqualsPressed() 
        { 
            return _isEqualsPressed;  
        }

        public string GetDisplayNumber()
        {
            return this._displayNumber.Number.Trim('0').PadLeft(1, '0');
        }

        public string GetResult()
        {
            return _result.Number;
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
            this._displayNumber.DeleteLastNumber();
        }

        private ResultNumber _result;
        private DisplayNumber _displayNumber;
        private bool _isOperationPressed = false;
        private bool _isEqualsPressed = false;
    }
}
