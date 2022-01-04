using System;
using nsOperations;

namespace nsResultNumber
{
    public class ResultNumber
    {
        public ResultNumber(string str = "")
        {
            ResultString = str;
            Reset();
        }

        ~ResultNumber() { }

        public void Reset()
        {
            Result = 0;
            Operation = new Sum();
            ResultString = "";
        }

        public void SetOperation(Operations operation)
        {
            this.Operation = operation;
        }

        public void Compute(double number)
        {
            if (!ResultString.Equals(""))
            {
                Result = Convert.ToDouble(ResultString);
                Result = this.Operation.Compute(Result, number);
            }
            else
            {
                Result = number;
            }
            ResultString = Result.ToString();
        }

        private double Result { get; set; }

        public string ResultString { get; set; }

        public Operations Operation { get; set; }
    }
}
