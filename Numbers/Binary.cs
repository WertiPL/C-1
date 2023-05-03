using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RPNCalulator.Numbers
{
    internal class Binary
    {

        public bool isItbin(string s)
        {
            if(s.EndsWith("b"))
            {
                foreach (var c in s.Substring(0, s.Length - 1))
                    if (c != '0' && c != '1')
                        return false;
                return true;
            }
            return false;
            
        }
        public  int BintoDec(string bin)
        {

            try
            {
                isItbin(bin);

                var value = (int)Convert.ToInt32(bin.Substring(0, bin.Length - 1), 2);
                return value;
            }


            catch (Exception)
            {
                Console.WriteLine("Something went Wrong");
                return 0;
            }

        }

    }
}
