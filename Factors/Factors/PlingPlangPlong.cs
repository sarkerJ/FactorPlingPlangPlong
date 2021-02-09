using System;
using System.Collections.Generic;
using System.Text;

namespace Factors
{
    public static class PlingPlangPlong
    {
        public static string GetFactorResult(int value)
        {
            StringBuilder result = new StringBuilder();

            if (value % 3 == 0) result.Append("Pling");
            if (value % 5 == 0) result.Append("Plang");
            if (value % 7 == 0) result.Append("Plong");

            if (result.ToString() == "") result.Append($"{value}");

            return result.ToString();
        }
    }
}
