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

        public void Delete()
        {
            if(DisplayNumberString.Length > 0)
                DisplayNumberString = DisplayNumberString.Remove(DisplayNumberString.Length-1);
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
