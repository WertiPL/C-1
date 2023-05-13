using NUnit.Framework.Constraints;
using RPNCalulator.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalulator.Operations
{
    public class FactorialOperator : IMathOperators
    {
        public int Calculate(Stack<int> num)
        {
            var num1 = num.Pop();
            if(num1 < 0)
            {
                return 1;
            }
            return _factorial(num1);
        }
        private int _factorial(int input)
        {
            int result = 1;
            for (int i = (input); i > 0; i--)
                result *= i;

            return result;
        }
    }
}
