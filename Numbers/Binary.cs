using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RPNCalulator.Numbers
{
    internal class Binary
    {
        public static bool isItbin(string bin)
        {
            return Regex.Match(bin, "[0-1]^#{6}$").Success;
        }
        public static int BintoDec(string bin)
        {
           return (int)Convert.ToInt64(bin, 2);
        }
    }
}
