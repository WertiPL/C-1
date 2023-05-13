using RPNCalulator.Abstractions;
using RPNCalulator.Numbers;
using RPNCalulator.Operations;
using System;
using System.Collections.Generic;
using Testy.Operations;

namespace RPNCalulator
{
    public class RPN
    {
        private readonly Stack<int> _operators = new();
        private readonly List<INumbersParser> _numberParser = new()
        {
            new Hex(),
            new Dec(),
            new Bin()
        };
        private readonly Dictionary<string, IMathOperators> _mathOperator = new()
            {
                { "+", new PlusOperator() },
                { "-", new MinusOperator() },
                { "/", new DivideOperator() },
                { "*", new MultiplyOperator() },
                { "%", new ModuloOperator() },
                { "!", new FactorialOperator() }

            };
        public int EvalRPN(string input)
        {
            var splitInput = input.Split(' ');
            foreach (var op in splitInput)
            {
                var used = false;
                foreach (var num in _numberParser)
                {
                    if(num.TryNum(op, out var r))
                        {
                        used = true;
                        _operators.Push(r);
                        break;
                    }
                }    
                if(!used)
                {
                    var mathOperator = _mathOperator[op];
                    var matchOperatorResult = mathOperator.Calculate(_operators);
                    _operators.Push(matchOperatorResult);
                }
            }

            var result = _operators.Pop();
            if (_operators.Count() == 0)
            {
                return result;
            }
            throw new InvalidOperationException();
        }
    }
}