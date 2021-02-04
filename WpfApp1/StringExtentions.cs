using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public static class StringExtentions
    {
        //public static bool IsNumeric (this string text)
        //{
        //    double test;
        //    return double.TryParse(text, out test);

        //}

        public static bool IsNumeric(this string text) => double.TryParse(text, out _);

    }
}
