using GraphLibrary;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using Expression = GraphLibrary.Expression;

namespace GraphDrawing
{
	/// <summary>
	/// Interaction logic for Main.xaml
	/// </summary>
	public partial class Main : Window
	{
		private string[] oprArray = new string[] { "+", "-", "*", "/", "^", "(", ")" };
		private Graph graphFrm;
		private Color[] clrArray = { Color.Red, Color.Green, Color.Blue, Color.Purple, Color.Brown, Color.Orange, Color.Chocolate, Color.Maroon, Color.Navy, Color.YellowGreen };

		public Main()
		{
			InitializeComponent();
		}

		/*=============================== EVENTS BELOW===============================*/

		#region Events

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			GenerateFuncMenu();
			GenerateOprMenu();
			// Default disable button
			nudPolar.Enabled = false;
			// Add several expressions to list
			GenerateExpressions();
			tbxExpression.Focus();
		}

		private void GenerateExpressions()
		{
			lbxExpression.Items.Add("x");
			lbxExpression.Items.Add("-x");
			lbxExpression.Items.Add("x^2");
			lbxExpression.Items.Add("sin(x)");
			lbxExpression.Items.Add("cos(x)");
		}

		private void GenerateOprMenu()
		{
			foreach (var opr in oprArray)
			{
				System.Windows.Controls.MenuItem item = new System.Windows.Controls.MenuItem();
				item.Header = opr;
				menuOprs.Items.Add(item);
			}
		}

		private void GenerateFuncMenu()
		{
			foreach (var func in Enum.GetValues(typeof(EnumFuncs)))
			{
				System.Windows.Controls.MenuItem item = new System.Windows.Controls.MenuItem();
				item.Header = Enum.GetName(typeof(EnumFuncs), func);
				menuFuncs.Items.Add(item);
			}
		}

		private void menuFuncs_Click(object sender, RoutedEventArgs e)
		{

		}

		private void menuOprs_Click(object sender, RoutedEventArgs e)
		{

		}

		private void MenuIntro_Click(object sender, RoutedEventArgs e)
		{
			System.Windows.MessageBox.Show("Chương trình này được viết lại từ chương trình VietGraph 1.2\r\nLa Quốc Thắng", "Thông tin chương trình", MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{
			if (lbxExpression.Items.Contains(tbxExpression.Text))
			{
				System.Windows.MessageBox.Show("Đã tồn tại biểu thức trong danh sách", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			ProcessExpression(tbxExpression.Text);
		}

		private void btnDeleteExp_Click(object sender, RoutedEventArgs e)
		{
			lbxExpression.Items.RemoveAt(lbxExpression.Items.IndexOf(lbxExpression.SelectedItem));
		}

		private void btnDeleteAll_Click(object sender, RoutedEventArgs e)
		{
			lbxExpression.Items.Clear();
		}

		private void btnDraw_Click(object sender, RoutedEventArgs e)
		{
			if (cbxGraphMode.SelectedIndex == 1)
			{
				ExpressionHelper.Cartesian = true;
				ExpressionHelper.Polar = false;
			}
			else
			{
				ExpressionHelper.Polar = true;
				ExpressionHelper.Cartesian = false;
			}
			ExpressionHelper.XStartValue = Convert.ToDouble(nudStartX.Value);
			ExpressionHelper.XEndValue = Convert.ToDouble(nudEndX.Value);
			if (graphFrm == null)
			{
				graphFrm = new Graph();
				this.Hide();
				graphFrm.Show();
			}
		}

		private void cbxGraphMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (cbxGraphMode.SelectedIndex == 1)
				nudPolar.Enabled = true;
			else
				nudPolar.Enabled = false;
		}

		private void tbxExpression_TextChanged(object sender, EventArgs e)
		{
			int cursorPos = tbxExpression.SelectionStart;
			WriteText(tbxExpression.Text);
			tbxExpression.SelectionStart = cursorPos;
		}

		private void lbxExpression_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			tbxExpression.Text = lbxExpression.SelectedItem.ToString();
		}

		#endregion

		/*=============================== METHODS BELOW===============================*/

		#region Methods

		/// <summary>
		/// Handles coloring of expressions
		/// </summary>
		/// <param name="text"></param>
		private void WriteText(string text)
		{
			int colorIdx = 0;
			tbxExpression.Text = "";
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == '(')
				{
					colorIdx++;
					if (colorIdx == clrArray.Length)
						colorIdx = 0;
					tbxExpression.SelectionColor = clrArray[colorIdx];
				}
				tbxExpression.AppendText("" + text[i]);
				if (text[i] == ')')
				{
					colorIdx--;
					if (colorIdx < 0)
						colorIdx = clrArray.Length - 1;
					tbxExpression.SelectionColor = clrArray[colorIdx];
				}
			}
		}

		private void ProcessExpression(string expr)
		{
			if (expr.Length == 0)
			{
				System.Windows.MessageBox.Show("Không thể chèn biểu thức trống vào danh sách", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			string expression = CompleteParenthesis(tbxExpression.Text);
			IEvaluatable ie = new Expression(expression);
			if (!ie.IsValid)
			{
				System.Windows.MessageBox.Show("Biểu thức không hợp lệ nên không thể chèn vào danh sách", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			lbxExpression.Items.Add(expression);
			tbxExpression.Clear();
		}

		private string CompleteParenthesis(string expr)
		{
			int leftBracket = 0;
			int rightBracket = 0;
			for (int i = 0; i < expr.Length; i++)
			{
				if (expr[i] == '(')
					leftBracket++;
				else if (expr[i] == ')')
					rightBracket++;
			}
			expr = expr.PadRight(expr.Length + leftBracket - rightBracket, ')');
			return expr;
		}


		#endregion

	}
}
