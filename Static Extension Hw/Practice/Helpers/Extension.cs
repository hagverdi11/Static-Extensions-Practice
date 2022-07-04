using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace sdadasd_ad.Helpers
{
    public static class Extension
    {
        //public static bool WordCheck ( this string words, string pattern)
        //{
        //    return Regex.IsMatch(words, pattern);
        //}


        //public static int SumDigit (this int num1, int num2)
        //{
        //    return (num1 + num2);
        //}

        public static double Power (this double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}
