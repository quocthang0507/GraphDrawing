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

		#region Public Properties for IEvaluatable

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
		#endregion

		#region Public Methods for IEvaluatable

		public double Evaluate(double dvalueX)
		{
			if (!isValid)
			{
				return double.NaN;
			}
			return EvaluateInternal(dvalueX, 0, out int temp);
		}

		#endregion

		#region Private Methods

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
		/// This function contains definitions for supported functions,we can add more also
		/// </summary>
		/// <param name="dOperand"></param>
		/// <param name="strOperator"></param>
		/// <returns></returns>
		private static double DoAngleOperation(double dOperand, string strOperator)
		{
			const double pi = 3.1415926535897932384626433832795;
			strOperator = strOperator.ToLower();
			switch (strOperator)
			{
				case "abs":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Abs(dOperand);
					}
					else
					{
						return Math.Abs(dOperand * pi / 180);
					}

				case "sin":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Sin(dOperand);
					}
					else
					{
						return Math.Sin(dOperand * pi / 180);
					}

				case "cos":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Cos(dOperand);
					}
					else
					{
						return Math.Cos(dOperand * pi / 180);
					}

				case "tan":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Tan(dOperand);
					}
					else
					{
						return Math.Tan(dOperand * pi / 180);
					}

				case "sec":
					if (ExpressionHelper.BlnRadian)
					{
						return 1.0 / Math.Cos(dOperand);
					}
					else
					{
						return 1.0 / Math.Cos(dOperand * pi / 180);
					}

				case "cosec":
					if (ExpressionHelper.BlnRadian)
					{
						return 1.0 / Math.Sin(dOperand);
					}
					else
					{
						return 1.0 / Math.Sin(dOperand * pi / 180);
					}

				case "cot":
					if (ExpressionHelper.BlnRadian)
					{
						return 1.0 / Math.Tan(dOperand);
					}
					else
					{
						return 1.0 / Math.Tan(dOperand * pi / 180);
					}

				case "arcsin":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Asin(dOperand);
					}
					else
					{
						return Math.Asin(dOperand * pi / 180);
					}

				case "arccos":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Acos(dOperand);
					}
					else
					{
						return Math.Acos(dOperand * pi / 180);
					}

				case "arctan":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Atan(dOperand);
					}
					else
					{
						return Math.Atan(dOperand * pi / 180);
					}

				case "exp":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Exp(dOperand);
					}
					else
					{
						return Math.Exp(dOperand * pi / 180);
					}

				case "ln":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Log(dOperand);
					}
					else
					{
						return Math.Log(dOperand * pi / 180);
					}

				case "log":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Log10(dOperand);
					}
					else
					{
						return Math.Log10(dOperand * pi / 180);
					}

				case "antilog":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Pow(10, dOperand);
					}
					else
					{
						return Math.Pow(10, dOperand) * pi / 180;
					}

				case "sqrt":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Sqrt(dOperand);
					}
					else
					{
						return Math.Sqrt(dOperand * pi / 180);
					}

				case "sinh":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Sinh(dOperand);
					}
					else
					{
						return Math.Sinh(dOperand * pi / 180);
					}

				case "cosh":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Cosh(dOperand);
					}
					else
					{
						return Math.Cosh(dOperand * pi / 180);
					}

				case "tanh":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Tanh(dOperand);
					}
					else
					{
						return Math.Tanh(dOperand * pi / 180);
					}

				case "arcsinh":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Log(dOperand + Math.Sqrt(dOperand * dOperand + 1));
					}
					else
					{
						return Math.Log(dOperand + Math.Sqrt((dOperand * dOperand + 1) * pi / 180));
					}

				case "arccosh":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Log(dOperand + Math.Sqrt(dOperand * dOperand - 1));
					}
					else
					{
						return Math.Log(dOperand + Math.Sqrt((dOperand * dOperand - 1) * pi / 180));
					}

				case "arctanh":
					if (ExpressionHelper.BlnRadian)
					{
						return Math.Log((1 + dOperand) / (1 - dOperand)) / 2;
					}
					else
					{
						return Math.Log(((1 + dOperand) / (1 - dOperand)) * pi / 180) / 2;
					}

				default:
					return double.NaN;
			}
		}

		private static double DoOperation(double dOperand1, double dOperand2, char chOperator)
		{
			switch (chOperator)
			{
				case '+':
					return dOperand1 + dOperand2;
				case '-':
					return dOperand1 - dOperand2;
				case '*':
					return dOperand1 * dOperand2;
				case '/':
					return dOperand1 / dOperand2;
				case '^':
					return Math.Pow(dOperand1, dOperand2);
				case '%':
					return dOperand1 % dOperand2;
			}
			return double.NaN;
		}

		/// <summary>
		/// Insert brackets at appropriate positions since the evaluation function 
		/// only evaluates from Left To Right considering only bracket's precedence
		/// </summary>
		/// <returns></returns>
		private string InsertPrecedenceBrackets()
		{
			int iBrackets = 0;
			bool bReplace = false;
			int iLengthExpression;
			string strExpression = textInternal;

			//Precedence for * && /
			int i = 1;
			iLengthExpression = strExpression.Length;
			int j;
			while (i <= iLengthExpression)
			{
				if (strExpression.Substring(-1 + i, 1) == "*" || strExpression.Substring(-1 + i, 1) == "/")
				{
					for (j = i - 1; j > 0; j--)
					{
						if (strExpression.Substring(-1 + j, 1) == ")")
						{
							iBrackets += 1;
						}

						if (strExpression.Substring(-1 + j, 1) == "(")
						{
							iBrackets -= 1;
						}

						if (iBrackets < 0)
						{
							break;
						}

						if (iBrackets == 0)
						{
							if (strExpression.Substring(-1 + j, 1) == "+" || strExpression.Substring(-1 + j, 1) == "-")
							{
								strExpression = strExpression.Substring(-1 + 1, j) + "(" + strExpression.Substring(-1 + j + 1);
								bReplace = true;
								i += 1;
								break;
							}
						}
					}
					iBrackets = 0;
					j = i;
					i += 1;
					while (bReplace)
					{
						j += 1;
						if (strExpression.Substring(-1 + j, 1) == "(")
						{
							iBrackets += 1;
						}

						if (strExpression.Substring(-1 + j, 1) == ")")
						{
							if (iBrackets == 0)
							{
								strExpression = strExpression.Substring(-1 + 1, j - 1) + ")" + strExpression.Substring(-1 + j);
								bReplace = false;
								i += 1;
								break;
							}
							else
							{
								iBrackets -= 1;
							}
						}
						if (strExpression.Substring(-1 + j, 1) == "+" || strExpression.Substring(-1 + j, 1) == "-")
						{
							strExpression = strExpression.Substring(-1 + 1, j - 1) + ")" + strExpression.Substring(-1 + j);
							bReplace = false;
							i += 1;
							break;
						}
					}
				}

				iLengthExpression = strExpression.Length;
				i += 1;
			}

			//Precedence for ^ && %
			i = 1;
			iLengthExpression = strExpression.Length;
			while (i <= iLengthExpression)
			{
				if (strExpression.Substring(-1 + i, 1) == "^" || strExpression.Substring(-1 + i, 1) == "%")
				{
					for (j = i - 1; j > 0; j--)
					{
						if (strExpression.Substring(-1 + j, 1) == ")")
						{
							iBrackets += 1;
						}

						if (strExpression.Substring(-1 + j, 1) == "(")
						{
							iBrackets -= 1;
						}

						if (iBrackets < 0)
						{
							break;
						}

						if (iBrackets == 0)
						{
							if (strExpression.Substring(-1 + j, 1) == "+" || strExpression.Substring(-1 + j, 1) == "-" || strExpression.Substring(-1 + j, 1) == "*" || strExpression.Substring(-1 + j, 1) == "/")
							{
								strExpression = strExpression.Substring(-1 + 1, j) + "(" + strExpression.Substring(-1 + j + 1);
								bReplace = true;
								i += 1;
								break;
							}
						}
					}
					iBrackets = 0;
					j = i;
					i += 1;
					while (bReplace)
					{
						j += 1;
						if (strExpression.Substring(-1 + j, 1) == "(")
						{
							iBrackets += 1;
						}

						if (strExpression.Substring(-1 + j, 1) == ")")
						{
							if (iBrackets == 0)
							{
								strExpression = strExpression.Substring(-1 + 1, j - 1) + ")" + strExpression.Substring(-1 + j);
								bReplace = false;
								i += 1;
								break;
							}
							else
							{
								iBrackets -= 1;
							}
						}
						if (strExpression.Substring(-1 + j, 1) == "+" || strExpression.Substring(-1 + j, 1) == "-" || strExpression.Substring(-1 + j, 1) == "*" || strExpression.Substring(-1 + j, 1) == "/")
						{
							strExpression = strExpression.Substring(-1 + 1, j - 1) + ")" + strExpression.Substring(-1 + j);
							bReplace = false;
							i += 1;
							break;
						}
					}
				}
				iLengthExpression = strExpression.Length;
				i += 1;
			}
			return strExpression;
		}

		private static double GetR(double X, double Y)
		{
			return Math.Sqrt(X * X + Y * Y);
		}

		private static double GetTheta(double X, double Y)
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

		#endregion

	}
}

