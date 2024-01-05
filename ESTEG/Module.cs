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
    }
}
