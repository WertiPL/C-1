using System;
using System.Collections.Generic;

namespace RPNCalulator
{
    public class RPN
    {
        private Stack<int> _operators;
        Dictionary<string, Func<int, int, int>> _operationFunction;

        public int EvalRPN(string input)
        {
            _operationFunction = new Dictionary<string, Func<int, int, int>>
            {
                ["+"] = (fst, snd) => (fst + snd),
                ["-"] = (fst, snd) => (fst - snd),
                ["*"] = (fst, snd) => (fst * snd),
                ["/"] = (fst, snd) => (fst / snd),
                //["!"] = (fst, snd) => (_factorial(fst))
            };
            _operationFunction = new Dictionary<string, Func<int>>
            {
                ["!"] = (fst) => (_factorial(fst))
            };
            _operators = new Stack<int>();

            var splitInput = input.Split(' ');
            foreach (var op in splitInput)
            {
                if (IsNumber(op))
                    _operators.Push(Int32.Parse(op));
                else
                if (IsOperator(op))
                {
                    var num1 = _operators.Pop();
                    var num2 = _operators.Pop();
                    _operators.Push(_operationFunction[op](num1, num2));
                    //_operators.Push(Operation(op)(num1, num2));
                }
                else if(Isfunction(op))
                {
                    var num1 = _operators.Pop();
                    _operators.Push(_operationFunction[op](num1));
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

        private bool IsOperator(String input) =>
            input.Equals("+") || input.Equals("-") ||
            input.Equals("*") || input.Equals("/");
        private bool Isfunction(String input) =>
            input.Equals("!");
        private Func<int, int, int> Operation(String input) =>
            (x, y) =>
            (
                (input.Equals("+") ? x + y :
                    (input.Equals("*") ? x * y : int.MinValue)
                )
            );
        private Func<int, int> Operation(String input) =>
            (x) =>
            (
                input.Equals("!") ? x
            > int.MinValue

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