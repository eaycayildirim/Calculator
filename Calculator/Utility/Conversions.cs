using System;

namespace nsUtility
{
    public static class Conversions
    {
        public static double TryParseToDouble(string number)
        {
            Double.TryParse(number, out double result);
            return result;
        }
    }
}
