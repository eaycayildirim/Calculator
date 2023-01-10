using System;
using nsOperations;
using nsUtility;

namespace nsDisplayNumber
{
    public class DisplayNumber
    {
        public DisplayNumber(string str = "")
        {
            Number = str;
        }

        public double ToDouble()
        {
            return Conversions.TryParseToDouble(Number);
        }

        public void Compute(Operations operation)
        {
            if(operation != new Undefined() && !operation.GetOperationData()._isResultAffected) //Is undefined necessary?
            {
                var result = operation.Compute(Convert.ToDouble(Number), 2);
                Number = result.ToString();
            }
        }

        public void Reset()
        {
            Number = "";
        }

        public void DeleteLastNumber()
        {
            if(Number.Length > 0)
                Number = Number.Remove(Number.Length-1);
        }

        public string DecimalComma()
        {
            if (Number == "")
                return Number += "0,";
            if (!IsDecimal())
                return Number += ',';
            else
                return Number;
        }

        public string Number { get; set; }

        private bool IsDecimal()
        {
            return Number.Contains(",");
        }
    }
}
