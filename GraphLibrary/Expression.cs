using System;
using System.Collections.Generic;

namespace GraphLibrary
{
	public class Expression : IEvaluatable
	{
		private string text = "";
		private string textInternal = "";
		private bool isValid = false;
		private char charX = 'x';
		private Dictionary<string, double> constants;

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

		public bool IsValid { get => isValid; }

		public double Evaluate(double valueX)
		{
			if (!IsValid)
				return double.NaN;
			int temp;
			return EvaluateInternal(valueX, 0, out temp);
		}

		public Expression(string expressionText)
		{
			constants = new Dictionary<string, double>();
			constants.Add("pi", Math.PI);
			constants.Add("e", Math.E);
			ExpressionText = expressionText;
		}

		private void Validate()
		{
			try
			{
				int temp;
				EvaluateInternal(1, 0, out temp);
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
			switch (character)
			{
				case '+':
				case '-':
				case '*':
				case '/':
				case '^':
				case '%':
					return true;
				default:
					return false;
			}
		}

		private double EvaluateInternal(double valueX, int startIndex, out int endIndex)
		{
			double answer = 0, operand = 0;
			char currentChar, @operator = '+';
			string angleOperator;

			for (int i = startIndex + 1; i < textInternal.Length; i++)
			{
				startIndex = i;
				currentChar = textInternal[startIndex];

				// if found a number
				if (char.IsDigit(currentChar))
				{
					while (char.IsDigit(textInternal[i]) || textInternal[i] == '.')
						i++;
					operand = Convert.ToDouble(textInternal.Substring(startIndex, i - startIndex));
					i--;
				}
				//if found an operator
				else if (IsOperator(currentChar))
				{
					answer = DoOperation(answer, operand, @operator);
					@operator = currentChar;
				}
				//if found independent variable
				else if (char.ToLower(currentChar) == charX)
				{
					operand = valueX;
				}
				//if found a bracket, solve it first
				else if (currentChar == '(')
				{
					operand = EvaluateInternal(valueX, i, out endIndex);
					i = endIndex;
				}
				//if found closing bracket, return result
				else if (currentChar == ')')
				{
					answer = DoOperation(answer, operand, @operator);
					endIndex = i;
					return answer;
				}

				else //could be any function e.g. "sin" or any constant e.g "pi"
				{
					while (char.IsLetter(textInternal[i]))
						i++;
					//if we got letters followed by "(", we've got a function else a constant
					if (textInternal[i] == '(')
					{
						angleOperator = textInternal.Substring(startIndex, i - startIndex).ToLower();
						operand = EvaluateInternal(valueX, i, out endIndex);
						i = endIndex;
						operand = DoAngleOperation(operand, angleOperator);
					}
					else //constant
					{
						operand = this.constants[textInternal.Substring(startIndex, i - startIndex).ToLower()];
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
			}
			return double.NaN;
		}

		private static double DoAngleOperation(double operand, string @operator)
		{
			const double pi = Math.PI;
			@operator = @operator.ToLower();
			switch (@operator)
			{
				case "abs":
					if (ExpressionHelper.BlnRadian)
						return Math.Abs(operand);
					else
						return Math.Abs(operand * pi / 180);
				case "sin":
					if (ExpressionHelper.BlnRadian)
						return Math.Sin(operand);
					else
						return Math.Sin(operand * pi / 180);
				case "cos":
					if (ExpressionHelper.BlnRadian)
						return Math.Cos(operand);
					else
						return Math.Cos(operand * pi / 180);
				case "tan":
					if (ExpressionHelper.BlnRadian)
						return Math.Tan(operand);
					else
						return Math.Tan(operand * pi / 180);
				case "sec":
					if (ExpressionHelper.BlnRadian)
						return 1.0 / Math.Cos(operand);
					else
						return 1.0 / Math.Cos(operand * pi / 180);
				case "cosec":
					if (ExpressionHelper.BlnRadian)
						return 1.0 / Math.Sin(operand);
					else
						return 1.0 / Math.Sin(operand * pi / 180);
				case "cot":
					if (ExpressionHelper.BlnRadian)
						return 1.0 / Math.Tan(operand);
					else
						return 1.0 / Math.Tan(operand * pi / 180);
				case "arcsin":
					if (ExpressionHelper.BlnRadian)
						return Math.Asin(operand);
					else
						return Math.Asin(operand * pi / 180);
				case "arccos":
					if (ExpressionHelper.BlnRadian)
						return Math.Acos(operand);
					else
						return Math.Acos(operand * pi / 180);
				case "arctan":
					if (ExpressionHelper.BlnRadian)
						return Math.Atan(operand);
					else
						return Math.Atan(operand * pi / 180);
				case "exp":
					if (ExpressionHelper.BlnRadian)
						return Math.Exp(operand);
					else
						return Math.Exp(operand * pi / 180);
				case "ln":
					if (ExpressionHelper.BlnRadian)
						return Math.Log(operand);
					else
						return Math.Log(operand * pi / 180);
				case "log":
					if (ExpressionHelper.BlnRadian)
						return Math.Log10(operand);
					else
						return Math.Log10(operand * pi / 180);
				case "antilog":
					if (ExpressionHelper.BlnRadian)
						return Math.Pow(10, operand);
					else
						return Math.Pow(10, operand) * pi / 180;
				case "sqrt":
					if (ExpressionHelper.BlnRadian)
						return Math.Sqrt(operand);
					else
						return Math.Sqrt(operand * pi / 180);
				case "sinh":
					if (ExpressionHelper.BlnRadian)
						return Math.Sinh(operand);
					else
						return Math.Sinh(operand * pi / 180);
				case "cosh":
					if (ExpressionHelper.BlnRadian)
						return Math.Cosh(operand);
					else
						return Math.Cosh(operand * pi / 180);
				case "tanh":
					if (ExpressionHelper.BlnRadian)
						return Math.Tanh(operand);
					else
						return Math.Tanh(operand * pi / 180);
				case "arcsinh":
					if (ExpressionHelper.BlnRadian)
						return Math.Log(operand + Math.Sqrt(operand * operand + 1));
					else
						return Math.Log(operand + Math.Sqrt((operand * operand + 1) * pi / 180));
				case "arccosh":
					if (ExpressionHelper.BlnRadian)
						return Math.Log(operand + Math.Sqrt(operand * operand - 1));
					else
						return Math.Log(operand + Math.Sqrt((operand * operand - 1) * pi / 180));
				case "arctanh":
					if (ExpressionHelper.BlnRadian)
						return Math.Log((1 + operand) / (1 - operand)) / 2;
					else
						return Math.Log(((1 + operand) / (1 - operand)) * pi / 180) / 2;
				default:
					return double.NaN;
			}
		}

		/// <summary>
		/// Inserts brackets at appropriate positions
		/// </summary>
		/// <returns></returns>
		private string InsertPrecedenceBrackets()
		{
			int brackets = 0, lengthExpression;
			bool isReplace = false;
			string expression = textInternal;
			int i = 1;
			int j;

			//Precedence for * && /
			lengthExpression = expression.Length;
			while (i <= lengthExpression)
			{
				if (expression.Substring(-1 + i, 1) == "*" || expression.Substring(-1 + i, 1) == "/")
				{
					for (j = i - 1; j > 0; j--)
					{
						if (expression.Substring(-1 + j, 1) == ")")
							brackets += 1;
						if (expression.Substring(-1 + j, 1) == "(")
							brackets -= 1;
						if (brackets < 0)
							break;
						if (brackets == 0)
						{
							if (expression.Substring(-1 + j, 1) == "+" || expression.Substring(-1 + j, 1) == "-")
							{
								expression = expression.Substring(-1 + 1, j) + "(" + expression.Substring(-1 + j + 1);
								isReplace = true;
								i += 1;
								break;
							}
						}
					}
					brackets = 0;
					j = i;
					i += 1;
					while (isReplace)
					{
						j += 1;
						if (expression.Substring(-1 + j, 1) == "(")
							brackets += 1;
						if (expression.Substring(-1 + j, 1) == ")")
						{
							if (brackets == 0)
							{
								expression = expression.Substring(-1 + 1, j - 1) + ")" + expression.Substring(-1 + j);
								isReplace = false;
								i += 1;
								break;
							}
							else
								brackets -= 1;
						}
						if (expression.Substring(-1 + j, 1) == "+" || expression.Substring(-1 + j, 1) == "-")
						{
							expression = expression.Substring(-1 + 1, j - 1) + ")" + expression.Substring(-1 + j);
							isReplace = false;
							i += 1;
							break;
						}
					}
				}
				lengthExpression = expression.Length;
				i += 1;
			}

			//Precedence for ^ && %
			i = 1;
			lengthExpression = expression.Length;
			while (i <= lengthExpression)
			{
				if (expression.Substring(-1 + i, 1) == "^" || expression.Substring(-1 + i, 1) == "%")
				{
					for (j = i - 1; j > 0; j--)
					{
						if (expression.Substring(-1 + j, 1) == ")")
							brackets += 1;
						if (expression.Substring(-1 + j, 1) == "(")
							brackets -= 1;
						if (brackets < 0)
							break;
						if (brackets == 0)
						{
							if (expression.Substring(-1 + j, 1) == "+"
								|| expression.Substring(-1 + j, 1) == "-"
								|| expression.Substring(-1 + j, 1) == "*"
								|| expression.Substring(-1 + j, 1) == "/")
							{
								expression = expression.Substring(-1 + 1, j) + "(" + expression.Substring(-1 + j + 1);
								isReplace = true;
								i += 1;
								break;
							}
						}
					}
					brackets = 0;
					j = i;
					i += 1;
					while (isReplace)
					{
						j += 1;
						if (expression.Substring(-1 + j, 1) == "(")
							brackets += 1;
						if (expression.Substring(-1 + j, 1) == ")")
						{
							if (brackets == 0)
							{
								expression = expression.Substring(-1 + 1, j - 1) + ")" + expression.Substring(-1 + j);
								isReplace = false;
								i += 1;
								break;
							}
							else
								brackets -= 1;
						}
						if (expression.Substring(-1 + j, 1) == "+" || expression.Substring(-1 + j, 1) == "-"
							|| expression.Substring(-1 + j, 1) == "*" || expression.Substring(-1 + j, 1) == "/")
						{
							expression = expression.Substring(-1 + 1, j - 1) + ")" + expression.Substring(-1 + j);
							isReplace = false;
							i += 1;
							break;
						}
					}
				}
				lengthExpression = expression.Length;
				i += 1;
			}
			return expression;
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
					theta = Math.PI / 2;
				else
					theta = -Math.PI / 2;
			}
			else
				theta = Math.Atan(Y / X);

			//actual range of theta is from 0 to 2PI
			if (X < 0)
				theta += Math.PI;
			else if (Y < 0)
				theta += 2 * Math.PI;
			return theta;
		}
	}
}
