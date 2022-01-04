using System;

namespace nsDisplayNumber
{
    public class DisplayNumber
    {
        public DisplayNumber(string str = "")
        {
            DisplayNumberString = str;
            Reset();
        }

        public void Reset()
        {
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

        public string DisplayNumberString { get; set; }

        private bool IsDecimal()
        {
            return DisplayNumberString.Contains(",");
        }
    }
}
