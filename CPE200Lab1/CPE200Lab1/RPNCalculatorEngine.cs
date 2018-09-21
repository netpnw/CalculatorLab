using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    public class RPNCalculatorEngine : CalculatorEngine
    {
        public override string Process(string str)
        {
			// your code here
			string first, second, third, four;
			Stack<string> rpn = new Stack<string>();

			string[] parts = str.Split(' ');
			
			for (int i = 0; i < parts.Length; i++)
			{
				if (isNumber(parts[i]))
				{
					rpn.Push(parts[i]);
				}

				if (isOperator(parts[i]))
				{
					second = rpn.Pop();
					first = rpn.Pop();
					four = calculate(parts[i], first, second, 4);
					rpn.Push(four);
				}
			}
			
				if (!(isNumber(parts[0]) && isOperator(parts[1]) && isNumber(parts[2])))
				{
					return rpn.Peek();
				}
				else
				{
					return "E";
				}
			
        }
    }
}
