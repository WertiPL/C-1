﻿using RPNCalulator.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RPNCalulator.Numbers
{
    internal class Hex : INumbersParser
    {
        public bool isItHex(string hc)
        {
            return Regex.Match(hc, "^#[0-9a-fA-F]").Success;
        }
        public bool TryNum(string s, out int value)
        {
            try
            {
                if (isItHex(s))
                {

                    string x = s.Substring(1, s.Length - 1);
                    value = Convert.ToInt32(x, 16);
                    return true;
                }
                else
                {
                    value = 0;
                    return false;
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
