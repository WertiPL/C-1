using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalulator.Abstractions;
public interface IMathOperators
{
    public int Calculate(Stack<int> num);
}
