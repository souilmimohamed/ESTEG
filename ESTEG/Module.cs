using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTEG
{
    public static class Module
    {
        public static bool StringIsNullOrEmptyOrWhiteSpaces(this string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                return true;
            else
                return false;
        }
        public static string ReplaceSpaces(this string value)
        {
            return value.Replace("\u00A0", "")
                .Replace(" ", "")
                .Replace("\t", "");
        }
    }
}
