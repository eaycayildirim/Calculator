using System;
using nsOperations;
using nsDisplayNumber;

namespace nsResultNumber
{
    public class ResultNumber
    {
        public ResultNumber(string str = "")
        {
            Number = str;
            Operation = new Undefined();
        }

        ~ResultNumber() { }

        public void Reset()
        {
            Operation = new Undefined();
            Number = "";
        }

        public void Compute(Operations operation, ref DisplayNumber displayNumber)
        {
            if (operation != new Undefined() && operation.GetOperationData()._isResultAffected) //Is undefined necessary?
            {
                var resultOperation = this.Operation;

                if(!String.IsNullOrWhiteSpace(Number) && operation != new Equals())
                {
                    var newResult = resultOperation.Compute(Convert.ToDouble(Number), displayNumber.ToDouble());
                    Number = newResult.ToString();
                    return;
                }
                Number = displayNumber.Number;
            }
        }

        public string Number { get; set; }

        public Operations Operation { get; set; }
    }
}
