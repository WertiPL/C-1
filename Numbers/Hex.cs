using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RPNCalulator.Numbers
{
    internal class Hex
    {
        public bool isItHex(string hc)
        {
            return Regex.Match(hc, "^#[0-9a-fA-F]").Success;
        }
        public int hextoDec(string s)
        {

    
                isItHex(s);
                string x = s.Substring(1, s.Length-1);
                var value = Convert.ToInt32(x, 16);
                return value;
            

        }
    }
}
