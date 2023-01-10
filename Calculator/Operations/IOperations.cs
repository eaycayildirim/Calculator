namespace nsOperations
{
    public struct OperationData
    {
        public OperationData(bool isResultAffected, bool isOperationChanged, string symbol)
        {
            this._isResultAffected = isResultAffected;
            this._isOperationChanged = isOperationChanged;
            this.symbol = symbol;
        }

        public bool _isResultAffected;
        public bool _isOperationChanged;
        public string symbol;
    }

    public abstract class Operations
    {
        public Operations(OperationData operationData)
        {
            this._operationData = operationData;
        }
        public abstract double Compute(double firstNumber, double secondNumber);

        public OperationData GetOperationData()
        {
            return this._operationData;
        }

        private OperationData _operationData;
    }
}
