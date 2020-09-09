using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsPractice
{
    public static class SimplifyPath
    {
        public static string Run(string path)
        {
            var stack = new Stack<string>();
            var tokens = path.Split('/');
            foreach (var token in tokens)
            {
                if (token == "..") stack.Pop();
                else if (token != "." && token != "/" && token != string.Empty) stack.Push(token);
            }

            var reverseStack = new Stack<string>();
            while (stack.Any())
                reverseStack.Push(stack.Pop());

            var result = new StringBuilder();
            while (reverseStack.Any())
                result.Append("/" + reverseStack.Pop());

            return result.ToString();
        }
    }
}
