using RPNCalulator.Numbers;
using System;
using System.Collections.Generic;

namespace RPNCalulator
{
    public class RPN
    {
        private Stack<int> _operators;
        Dictionary<string, Func<int, int, int>> _operationFunction2arg;
        Dictionary<string, Func<int, int>> _operationFunction1arg;
        Binary binary = new Binary();

        public int EvalRPN(string input)
        {
            _operationFunction2arg = new Dictionary<string, Func<int, int, int>>
            {
                ["+"] = (fst, snd) => (fst + snd),
                ["-"] = (fst, snd) => (fst - snd),
                ["*"] = (fst, snd) => (fst * snd),
                ["/"] = (fst, snd) => (fst / snd),
            };
            _operationFunction1arg = new Dictionary<string, Func<int,int>>
            {
                ["!"] = (fst) => (_factorial(fst))
            };
            _operators = new Stack<int>();

            var splitInput = input.Split(' ');
            foreach (var op in splitInput)
            {
                if (IsNumber(op))
                    if (binary.isItbin(op))
                    {

                    }

                        ;
                    _operators.Push(Int32.Parse(op));
                else
                if (IsOperator1(op))
                {
                    var num1 = _operators.Pop();
                    _operators.Push(_operationFunction1arg[op](num1));
                }
                else
                if (IsOperator2(op))
                {
                    var num1 = _operators.Pop();
                    var num2 = _operators.Pop();
                    _operators.Push(_operationFunction2arg[op](num1, num2));
                }


            }

            var result = _operators.Pop();
            if (_operators.Count() == 0)
            {
                return result;
            }
            throw new InvalidOperationException();
        }

        private bool IsNumber(String input) => Int32.TryParse(input, out _);

        private bool IsOperator2(String input) =>
            input.Equals("+") || input.Equals("-") ||
            input.Equals("*") || input.Equals("/");
        private bool IsOperator1(String input) =>
            input.Equals("!");
        private Func<int, int, int> Operation2(String input) =>
            (x, y) =>
            (
                ((input.Equals("+") ? x + y :
                    (input.Equals("*") ? x * y : int.MinValue))
                )
            );


        
        private int _factorial(int input)
        {
            int result = 1;
            for (int i = (input); i > 0; i--)
                result *= i;

            return result;
        }
    }
}