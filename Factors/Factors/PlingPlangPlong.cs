using System;
using System.Collections.Generic;
using System.Text;

namespace Factors
{
    public static class PlingPlangPlong
    {
        public static string GetFactorResult(int value)
        {
            string result = "";

            if (value % 3 == 0) result += "Pling";
            if (value % 5 == 0) result += "Plang";
            if (value % 7 == 0) result += "Plong";

            if (result == "") result += value.ToString();

            return result;
        }
    }
}
