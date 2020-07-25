using System.Collections;

namespace GraphLibrary
{
	internal class ExpressionHelper
	{
		private static ArrayList _arrExpression = new ArrayList();
		private static bool _cartesian = false;
		private static bool _polar = false;
		private static double _xStartValue = -1;
		private static double _xEndValue = -1;
		private static bool _blnDo = false;
		private static bool _blnRadian = true;

		public static ArrayList ArrExpression
		{
			get => _arrExpression;
			set => _arrExpression = value;
		}

		public static bool Cartesian
		{
			get => _cartesian;
			set => _cartesian = value;
		}

		public static bool Polar
		{
			get => _polar;
			set => _polar = value;
		}

		public static double XStartValue
		{
			get => _xStartValue;
			set => _xStartValue = value;
		}

		public static double XEndValue
		{
			get => _xEndValue;
			set => _xEndValue = value;
		}

		public static bool BlnDo
		{
			get => _blnDo;
			set => _blnDo = value;
		}

		public static bool BlnRadian
		{
			get => _blnRadian;
			set => _blnRadian = value;
		}
	}
}
