using RPNCalulator.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RPNCalulator.Numbers
{
    internal class Dec : INumbersParser
    {
        public bool isItDec(string hc)
        {
            return Regex.Match(hc, "[0-9]").Success;
        }
        public bool TryNum(string s, out int value)
        {
            try
            {
                if (!isItDec(s))
                {
                    value = 0;
                    return false;
                }
                else
                {
                    value = Convert.ToInt32(s);
                    return true;
                }
            }
               
            catch (Exception e)
            {
                value = 0;
                return false;
            }

        }
    }
}
