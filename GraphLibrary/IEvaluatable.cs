using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
	public interface IEvaluatable
	{
		/// <summary>
		/// Returns text for expression
		/// </summary>
		string ExpressionText { get; set; }
		/// <summary>
		/// Returns if the expression is valid and can be evaluated
		/// </summary>
		bool IsValid { get; }
		/// <summary>
		/// Retuns the value of the expression
		/// </summary>
		/// <param name="dValueX"></param>
		/// <returns></returns>
		double Evaluate(double dValueX);
	}
}
