﻿using System;
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

			if (parts.Length < 3)
			{
				return "E";
			}
			else if (isOperator(parts[1]) || isOperator(parts[0]))
			{
				return "E";
			
			}
			else if(parts.Length %2 == 0){
				return "E";
			}
			else
			{
				for (int i = 0; i < parts.Length; i++)
				{
					if (isNumber(parts[i]))
					{
						rpn.Push(parts[i]);
					}
					else if (isOperator(parts[i]))
					{
						if (parts.Length > 1)
						{
							second = rpn.Pop();
							first = rpn.Pop();
							if (first == null || second == null)
							{
								return "E";
							}
							else
							{
								four = calculate(parts[i], first, second, 4);
								rpn.Push(four);
							}
						}
						else
						{
							return "E";
						}
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
}
