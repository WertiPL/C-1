using RPNCalulator.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy.Operations
{
    public class MultiplyOperator : IMathOperators
    {
        public int Calculate(Stack<int> num)
        {
            var num1 = num.Pop();
            var num2 = num.Pop();
            return num2 * num1;
        }
    }
}
