
using GraphLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace GraphDrawing
{
	public partial class ThongTin : Form
	{
		private DoThi form;
		private readonly Color[] colorLevels = { Color.Red, Color.Green, Color.Blue, Color.Purple, Color.Brown, Color.Orange, Color.Chocolate, Color.Maroon, Color.Navy, Color.YellowGreen };
		private readonly char[] oprsArray = new char[] { '+', '-', '*', '/', '^', '(', ')' };

		public ThongTin()
		{
			InitializeComponent();
		}

		/*=======================================================================*/

		#region Events
		private void ThongTin_Load(object sender, EventArgs e)
		{
			cbxMode.SelectedIndex = 0;
			nudSensitive.Enabled = false;
			PopulateExps();
			PopulateMenuFuncs();
			PopulateMenuOprs();
		}

		private void MenuFuncs_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			txtExpression.Text += e.ClickedItem.Text + "(";
		}

		private void MenuOprs_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			txtExpression.Text += e.ClickedItem.Text;
		}

		private void MenuInfo_Click(object sender, EventArgs e)
		{
			TacGia frmTacGia = new TacGia();
			frmTacGia.Show();
		}

		private void txtExpression_TextChanged(object sender, EventArgs e)
		{
			int cursorPosition = txtExpression.SelectionStart;
			WriteText(txtExpression.Text);
			txtExpression.SelectionStart = cursorPosition;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			CheckDuplication();
		}

		private bool CheckDuplication()
		{
			if (lstExpressions.Items.Contains(txtExpression.Text))
			{
				MessageBox.Show("Đã có biểu thức này trong danh sách rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			AddExpression();
			lstExpressions.SelectedIndex = -1;
			lstExpressions.Refresh();
			return true;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			lstExpressions.Items.Clear();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			int index = lstExpressions.SelectedIndex;
			lstExpressions.Items.Remove(lstExpressions.SelectedItem);
			if (index == lstExpressions.Items.Count)
			{
				index--;
			}
			else if (index != -1)
			{
				lstExpressions.SelectedIndex = index;
			}
		}

		private void btnDraw_Click(object sender, EventArgs e)
		{
			if (cbxMode.SelectedIndex == 0)
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
			if (form == null || form.IsDisposed)
			{
				form = DoThi.Instance;
				form.Show();
			}
			form.SetRange((double)nudStartX.Value, (double)nudEndX.Value, (double)nudStartY.Value, (double)nudEndY.Value);
			form.SetDivisions((int)axisRatio.Value, (int)axisRatio.Value);
			form.SetPenWidth((int)nudWidthStroke.Value);
			if (cbxMode.SelectedIndex == 1)
			{
				form.SetMode(GraphMode.Polar, (int)nudSensitive.Value);
			}
			else
			{
				form.SetMode(GraphMode.Rectangular, 50);
			}

			ExpressionHelper.ArrExpression.Clear();
			for (int i = 0; i < lstExpressions.Items.Count; i++)
			{
				form.AddExpression((string)lstExpressions.Items[i], colorLevels[i % colorLevels.Length]);
				//Add expression to Array Expression (ThemBotBieuThuc form)
				ExpressionHelper.ArrExpression.Add(lstExpressions.Items[i]);
			}
			form.Refresh();
			form.Activate();
		}

		private void cbxMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxMode.SelectedIndex == 0)
			{
				nudSensitive.Enabled = false;
			}
			else
			{
				nudSensitive.Enabled = true;
			}
		}

		private void txtExpression_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13 && txtExpression.Text.Length > 0)
			{
				AddExpression();
			}
			//if a letter is found
			if (char.IsLetter(e.KeyChar))
			{
				int cursorPos = txtExpression.SelectionStart;
				if (cursorPos > 0)
				{
					//if the previous char is a digit, add a *
					if (char.IsDigit(txtExpression.Text[cursorPos - 1]))
					{
						txtExpression.Text = txtExpression.Text.Insert(cursorPos, "*" + e.KeyChar);
						cursorPos += 2;
						txtExpression.SelectionStart = cursorPos;
						e.Handled = true;
					}
					//if a function is formed, add a "("
					else
					{
						string text = "";
						int i = cursorPos - 1;
						while (i >= 0)
						{
							if (!char.IsLetter(txtExpression.Text[i]))
							{
								break;
							}

							i--;
						}
						i++;
						//now i is the index where last text is started
						if (i < cursorPos)
						{
							text = txtExpression.Text.Substring(i, cursorPos - i) + e.KeyChar;
						}
						if (IsFunction(text))
						{
							txtExpression.Text = txtExpression.Text.Insert(cursorPos, e.KeyChar.ToString() + "(");
							cursorPos += 2;
							txtExpression.SelectionStart = cursorPos;
							e.Handled = true;
						}
					}
				}
			}
		}

		private void lstExpressions_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstExpressions.SelectedIndex != -1)
			{
				txtExpression.Text = lstExpressions.Items[lstExpressions.SelectedIndex].ToString();
			}
		}

		#endregion

		/*=======================================================================*/

		#region Methods

		/// <summary>
		/// Generate operator dropdownitems
		/// </summary>
		private void PopulateMenuOprs()
		{
			foreach (char opr in oprsArray)
			{
				menuOprs.DropDownItems.Add("" + opr);
			}
		}

		/// <summary>
		/// Generate functional dropdownitems
		/// </summary>
		private void PopulateMenuFuncs()
		{
			foreach (string item in Enum.GetNames(typeof(EnumFuncs)))
			{
				menuFuncs.DropDownItems.Add(item);
			}
		}

		/// <summary>
		/// Generate example expressions
		/// </summary>
		private void PopulateExps()
		{
			lstExpressions.Items.Add("x");
			lstExpressions.Items.Add("sin(x)");
			lstExpressions.Items.Add("5*(sin(x)+sin(3*x)/3+sin(5*x)/5+sin(7*x)/7+sin(9*x)/9+sin(11*x)/11+sin(13*x)/13)");
		}

		/// <summary>
		/// This functions handles coloring of expressions
		/// </summary>
		/// <param name="text"></param>
		private void WriteText(string text)
		{
			int colorIndex = 0;
			txtExpression.Text = "";
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == '(')
				{
					colorIndex++;
					if (colorIndex == colorLevels.Length)
					{
						colorIndex = 0;
					}

					txtExpression.SelectionColor = colorLevels[colorIndex];
				}
				txtExpression.AppendText(text[i].ToString());
				if (text[i] == ')')
				{
					colorIndex--;
					if (colorIndex < 0)
					{
						colorIndex = colorLevels.Length - 1;
					}

					txtExpression.SelectionColor = colorLevels[colorIndex];
				}
			}
		}

		/// <summary>
		/// Check valid function
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		private bool IsFunction(string text)
		{
			for (int i = 0; i < Enum.GetValues(typeof(ContentAlignment)).Length; i++)
			{
				if (string.Compare(text, ((EnumFuncs)i).ToString(), true) == 0)
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Add current expression to list box
		/// </summary>
		private void AddExpression()
		{
			if (txtExpression.Text.Length == 0)
			{
				MessageBox.Show("Bạn không thể thêm biểu thức trống vào danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string expText = CompleteParenthesis(txtExpression.Text);
			IEvaluatable exp = new Expression(expText);
			if (!exp.IsValid)
			{
				if (MessageBox.Show("Biểu thức bạn định thêm vào danh sách không hợp lệ! Bạn vẫn muốn thêm nó vào danh sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					return;
				}
			}
			lstExpressions.Items.Add(expText);
			txtExpression.Text = "";
		}

		/// <summary>
		/// Automatically complete parenthesises on expression
		/// </summary>
		/// <param name="exp"></param>
		/// <returns></returns>
		private string CompleteParenthesis(string exp)
		{
			int p = 0; // number of parenthesises
			for (int i = 0; i < exp.Length; i++)
			{
				if (exp[i] == '(')
				{
					p++;
				}
				else if (exp[i] == ')')
				{
					p--;
				}
			}
			exp = exp.PadRight(exp.Length + p, ')');
			return exp;
		}

		#endregion

	}
}
