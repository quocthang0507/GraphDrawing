using System;
using System.Collections.Generic;

namespace GraphLibrary
{
	public class Expression : IEvaluatable
	{
		private string text = "";
		private string textInternal = "";
		private bool isValid = false;
		private readonly char charX = 'x';
		private readonly Dictionary<string, double> constants;

		public Expression(string expressionText)
		{
			constants = new Dictionary<string, double>
			{
				{ "pi",Math.PI },
				{ "e",Math.E }
			};
			ExpressionText = expressionText;
		}

		public string ExpressionText
		{
			get => text;
			set
			{
				text = value;
				textInternal = "(" + value + ")";
				textInternal = InsertPrecedenceBrackets().Trim();
				Validate();
			}
		}

		public bool IsValid => isValid;

		public double Evaluate(double dvalueX)
		{
			if (!isValid)
			{
				return double.NaN;
			}
			return EvaluateInternal(dvalueX, 0, out int temp);
		}

		public static double GetR(double X, double Y)
		{
			return Math.Sqrt(X * X + Y * Y);
		}

		public static double GetTheta(double X, double Y)
		{
			double theta;
			if (X == 0)
			{
				if (Y > 0)
				{
					theta = Math.PI / 2;
				}
				else
				{
					theta = -Math.PI / 2;
				}
			}
			else
			{
				theta = Math.Atan(Y / X);
			}

			//actual range of theta is from 0 to 2PI
			if (X < 0)
			{
				theta += Math.PI;
			}
			else if (Y < 0)
			{
				theta += 2 * Math.PI;
			}

			return theta;
		}

		private void Validate()
		{
			try
			{
				//if expression does not throw an exception when evaluated at "1",we assume it to be valid
				EvaluateInternal(1, 0, out int temp);
				isValid = true;
			}
			catch (FormatException)
			{
				isValid = false;
			}
			catch (KeyNotFoundException)
			{
				isValid = false;
			}

		}

		private static bool IsOperator(char character)
		{
			if (character == '+' || character == '-' || character == '*' || character == '/' || character == '^' || character == '%')
			{
				return true;
			}

			return false;
		}

		public double EvaluateInternal(double dvalueX, int startIndex, out int endIndex)
		{
			//exceptions are bubbled up

			//dAnswer is the running total
			double answer = 0, operand = 0;
			char currChar, opr = '+';
			string strAngleOperator;

			for (int i = startIndex + 1; i < textInternal.Length; i++)
			{
				startIndex = i;
				currChar = textInternal[startIndex];

				// if found a number,update dOperand
				if (char.IsDigit(currChar))
				{
					while (char.IsDigit(textInternal[i]) || textInternal[i] == '.')
					{
						i++;
					}

					operand = Convert.ToDouble(textInternal.Substring(startIndex, i - startIndex));
					i--;
				}
				//if found an operator
				else if (IsOperator(currChar))
				{
					answer = DoOperation(answer, operand, opr);
					opr = currChar;
				}
				//if found independent variable
				else if (char.ToLower(currChar) == charX)
				{
					operand = dvalueX;
				}
				//if found a bracket,solve it first
				else if (currChar == '(')
				{
					operand = EvaluateInternal(dvalueX, i, out endIndex);
					i = endIndex;
				}
				//if found closing bracket,return result
				else if (currChar == ')')
				{
					answer = DoOperation(answer, operand, opr);
					endIndex = i;
					return answer;
				}
				else //could be any function e.g. "sin" or any constant e.g "pi"
				{
					while (char.IsLetter(textInternal[i]))
					{
						i++;
					}
					//if we got letters followed by "(",we've got a function else a constant
					if (textInternal[i] == '(')
					{
						strAngleOperator = textInternal.Substring(startIndex, i - startIndex).ToLower();
						operand = EvaluateInternal(dvalueX, i, out endIndex);
						i = endIndex;
						operand = DoAngleOperation(operand, strAngleOperator);
					}
					else //constant
					{
						operand = constants[textInternal.Substring(startIndex, i - startIndex).ToLower()];
						i--;
					}
				}
				if (double.IsNaN(answer) || double.IsNaN(operand))
				{
					endIndex = i;
					return double.NaN;
				}
			}
			endIndex = textInternal.Length;
			return 0;
		}

		/// <summary>
		/// This function contains definitions for supported functions, we can add more also
		/// </summary>
		/// <param name="operand"></param>
		/// <param name="operator"></param>
		/// <returns></returns>
		private static double DoAngleOperation(double operand, string @operator)
		{
			const double pi = 3.1415926535897932384626433832795;
			@operator = @operator.ToLower();
			switch (@operator)
			{
				case "abs":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Abs(operand);
					}
					else
					{
						return Math.Abs(operand * pi / 180);
					}

				case "sin":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Sin(operand);
					}
					else
					{
						return Math.Sin(operand * pi / 180);
					}

				case "cos":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Cos(operand);
					}
					else
					{
						return Math.Cos(operand * pi / 180);
					}

				case "tan":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Tan(operand);
					}
					else
					{
						return Math.Tan(operand * pi / 180);
					}

				case "sec":
					if (ExpressionHelper.BlnRadian)
					{
						return 1.0 / Math.Cos(operand);
					}
					else
					{
						return 1.0 / Math.Cos(operand * pi / 180);
					}

				case "cosec":
					if (ExpressionHelper.BlnRadian)
					{
						return 1.0 / Math.Sin(operand);
					}
					else
					{
						return 1.0 / Math.Sin(operand * pi / 180);
					}

				case "cot":
					if (ExpressionHelper.BlnRadian)
					{
						return 1.0 / Math.Tan(operand);
					}
					else
					{
						return 1.0 / Math.Tan(operand * pi / 180);
					}

				case "arcsin":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Asin(operand);
					}
					else
					{
						return Math.Asin(operand * pi / 180);
					}

				case "arccos":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Acos(operand);
					}
					else
					{
						return Math.Acos(operand * pi / 180);
					}

				case "arctan":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Atan(operand);
					}
					else
					{
						return Math.Atan(operand * pi / 180);
					}

				case "exp":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Exp(operand);
					}
					else
					{
						return Math.Exp(operand * pi / 180);
					}

				case "ln":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Log(operand);
					}
					else
					{
						return Math.Log(operand * pi / 180);
					}

				case "log":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Log10(operand);
					}
					else
					{
						return Math.Log10(operand * pi / 180);
					}

				case "antilog":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Pow(10, operand);
					}
					else
					{
						return Math.Pow(10, operand) * pi / 180;
					}

				case "sqrt":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Sqrt(operand);
					}
					else
					{
						return Math.Sqrt(operand * pi / 180);
					}

				case "sinh":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Sinh(operand);
					}
					else
					{
						return Math.Sinh(operand * pi / 180);
					}

				case "cosh":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Cosh(operand);
					}
					else
					{
						return Math.Cosh(operand * pi / 180);
					}

				case "tanh":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Tanh(operand);
					}
					else
					{
						return Math.Tanh(operand * pi / 180);
					}

				case "arcsinh":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Log(operand + Math.Sqrt(operand * operand + 1));
					}
					else
					{
						return Math.Log(operand + Math.Sqrt((operand * operand + 1) * pi / 180));
					}

				case "arccosh":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Log(operand + Math.Sqrt(operand * operand - 1));
					}
					else
					{
						return Math.Log(operand + Math.Sqrt((operand * operand - 1) * pi / 180));
					}

				case "arctanh":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Log((1 + operand) / (1 - operand)) / 2;
					}
					else
					{
						return Math.Log(((1 + operand) / (1 - operand)) * pi / 180) / 2;
					}

				default:
					return double.NaN;
			}
		}

		private static double DoOperation(double operand1, double operand2, char @operator)
		{
			switch (@operator)
			{
				case '+':
					return operand1 + operand2;
				case '-':
					return operand1 - operand2;
				case '*':
					return operand1 * operand2;
				case '/':
					return operand1 / operand2;
				case '^':
					return Math.Pow(operand1, operand2);
				case '%':
					return operand1 % operand2;
				default:
					return double.NaN;
			}
		}

		/// <summary>
		/// Insert brackets at appropriate positions since the evaluation function 
		/// only evaluates from Left To Right considering only bracket's precedence
		/// </summary>
		/// <returns></returns>
		private string InsertPrecedenceBrackets()
		{
			int nBrackets = 0;
			bool isReplace = false;
			int lenExpression;
			string expression = textInternal;

			//Precedence for * && /
			int i = 1;
			lenExpression = expression.Length;
			int j;
			while (i <= lenExpression)
			{
				if (expression.Substring(-1 + i, 1) == "*" || expression.Substring(-1 + i, 1) == "/")
				{
					for (j = i - 1; j > 0; j--)
					{
						if (expression.Substring(-1 + j, 1) == ")")
						{
							nBrackets++;
						}

						if (expression.Substring(-1 + j, 1) == "(")
						{
							nBrackets--;
						}

						if (nBrackets < 0)
						{
							break;
						}

						if (nBrackets == 0)
						{
							if (expression.Substring(-1 + j, 1) == "+" || expression.Substring(-1 + j, 1) == "-")
							{
								expression = expression.Substring(0, j) + "(" + expression.Substring(j);
								isReplace = true;
								i++;
								break;
							}
						}
					}
					nBrackets = 0;
					j = i;
					i++;
					while (isReplace)
					{
						j++;
						if (expression.Substring(-1 + j, 1) == "(")
						{
							nBrackets++;
						}

						if (expression.Substring(-1 + j, 1) == ")")
						{
							if (nBrackets == 0)
							{
								expression = expression.Substring(0, j - 1) + ")" + expression.Substring(-1 + j);
								isReplace = false;
								i++;
								break;
							}
							else
							{
								nBrackets--;
							}
						}
						if (expression.Substring(-1 + j, 1) == "+" || expression.Substring(-1 + j, 1) == "-")
						{
							expression = expression.Substring(0, j - 1) + ")" + expression.Substring(-1 + j);
							isReplace = false;
							i++;
							break;
						}
					}
				}
				lenExpression = expression.Length;
				i++;
			}

			//Precedence for ^ && %
			i = 1;
			lenExpression = expression.Length;
			while (i <= lenExpression)
			{
				if (expression.Substring(-1 + i, 1) == "^" || expression.Substring(-1 + i, 1) == "%")
				{
					for (j = i - 1; j > 0; j--)
					{
						if (expression.Substring(-1 + j, 1) == ")")
						{
							nBrackets++;
						}
						else if (expression.Substring(-1 + j, 1) == "(")
						{
							nBrackets--;
						}

						if (nBrackets < 0)
						{
							break;
						}
						else if (nBrackets == 0)
						{
							if (expression.Substring(-1 + j, 1) == "+" || expression.Substring(-1 + j, 1) == "-" || expression.Substring(-1 + j, 1) == "*" || expression.Substring(-1 + j, 1) == "/")
							{
								expression = expression.Substring(0, j) + "(" + expression.Substring(j);
								isReplace = true;
								i++;
								break;
							}
						}
					}
					nBrackets = 0;
					j = i;
					i++;
					while (isReplace)
					{
						j++;
						if (expression.Substring(-1 + j, 1) == "(")
						{
							nBrackets++;
						}

						if (expression.Substring(-1 + j, 1) == ")")
						{
							if (nBrackets == 0)
							{
								expression = expression.Substring(0, j - 1) + ")" + expression.Substring(-1 + j);
								isReplace = false;
								i++;
								break;
							}
							else
							{
								nBrackets -= 1;
							}
						}
						if (expression.Substring(-1 + j, 1) == "+" || expression.Substring(-1 + j, 1) == "-" || expression.Substring(-1 + j, 1) == "*" || expression.Substring(-1 + j, 1) == "/")
						{
							expression = expression.Substring(0, j - 1) + ")" + expression.Substring(-1 + j);
							isReplace = false;
							i++;
							break;
						}
					}
				}
				lenExpression = expression.Length;
				i++;
			}
			return expression;
		}
	}
}

