using System;

namespace nsDisplayNumber
{
    public class DisplayNumber
    {
        public DisplayNumber()
        {
            Reset();
        }

        public void Reset()
        {
            DisplayNumberDouble = 0;
            DisplayNumberString = "";
        }

        public string Delete()
        {
            if(DisplayNumberString.Length > 0)
                return DisplayNumberString.Remove(DisplayNumberString.Length-1);
            else
                return DisplayNumberString;
        }

        public string DecimalComma()
        {
            if (DisplayNumberString == "")
                return DisplayNumberString += "0,";
            if (!IsDecimal())
                return DisplayNumberString += ',';
            else
                return DisplayNumberString;
        }

        public double DisplayNumberDouble { get; set; }
        public string DisplayNumberString { get; set; }

        private bool IsDecimal()
        {
            return DisplayNumberString.Contains(",");
        }
    }
}
