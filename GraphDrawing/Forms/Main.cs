
using GraphLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace GraphDrawing
{
	public partial class Main : Form
	{
		private Graph form;
		private readonly Color[] colorLevels = { Color.Red, Color.Green, Color.Blue, Color.Purple, Color.Brown, Color.Orange, Color.Chocolate, Color.Maroon, Color.Navy, Color.YellowGreen };

		public Main()
		{
			InitializeComponent();
		}

		#region Event Handlers
		private void Form1_Load(object sender, EventArgs e)
		{
			mode.SelectedIndex = 0;
			sensitivity.Enabled = false;
			PopulateExps();
			PopulateFuncsMenu();
		}

		private void PopulateFuncsMenu()
		{
			foreach (var item in Enum.GetNames(typeof(EnumFuncs)))
			{
				hToolStripMenuItem.DropDownItems.Add(item);
			}
		}

		private void PopulateExps()
		{
			lstExpressions.Items.Add("x");
			lstExpressions.Items.Add("sin(x)");
			lstExpressions.Items.Add("5*(sin(x)+sin(3*x)/3+sin(5*x)/5+sin(7*x)/7+sin(9*x)/9+sin(11*x)/11+sin(13*x)/13)");
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
			for (int i = 0; i < lstExpressions.Items.Count; i++)
			{
				if (txtExpression.Text == lstExpressions.Items[i].ToString())
				{
					MessageBox.Show("Đã có biểu thức này trong danh sách rồi.");
					return false;
				}
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

			if (index != -1)
			{
				lstExpressions.SelectedIndex = index;
			}
		}

		private void cmdPlotGraph_Click(object sender, EventArgs e)
		{
			if (mode.Text == "Cartesian")
			{
				ExpressionHelper.Cartesian = true;
				ExpressionHelper.Polar = false;
			}
			else
			{
				ExpressionHelper.Polar = true;
				ExpressionHelper.Cartesian = false;
			}

			ExpressionHelper.XStartValue = Convert.ToDouble(startX.Value);
			ExpressionHelper.XEndValue = Convert.ToDouble(endX.Value);

			if (form == null || form.IsDisposed)
			{
				form = new Graph();
				form.Show();
			}

			form.SetRange((double)startX.Value, (double)endX.Value, (double)startY.Value, (double)endY.Value);
			form.SetDivisions((int)divX.Value, (int)divX.Value);
			form.SetPenWidth((int)penWidth.Value);

			if (mode.SelectedItem.ToString() == "Polar")
			{
				form.SetMode(GraphMode.Polar, (int)sensitivity.Value);
			}
			else
			{
				form.SetMode(GraphMode.Rectangular, 50);
			}

			//form.RemoveAllExpressions();
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

		private void mode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (mode.SelectedIndex == 1)
			{
				sensitivity.Enabled = true;
			}
			else
			{
				sensitivity.Enabled = false;
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
						string text = string.Empty;
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

		#region Helper Functions
		//this functions handles coloring of expressions
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

		private void AddExpression()
		{
			if (txtExpression.Text.Length == 0)
			{
				return;
			}

			txtExpression.Text = CompleteParenthesis(txtExpression.Text);
			string expText = txtExpression.Text;
			IEvaluatable exp = new Expression(expText);
			if (!exp.IsValid)
			{
				if (MessageBox.Show("Biểu thức bạn định thêm vào danh sách không hợp lệ! Bạn vẫn muốn thêm nó vào danh sách?", "", MessageBoxButtons.YesNo) == DialogResult.No)
				{
					return;
				}
			}
			lstExpressions.Items.Add(expText);
			txtExpression.Text = string.Empty;
		}
		private string CompleteParenthesis(string exp)
		{
			int leftBracket = 0;
			int rightBracket = 0;
			for (int i = 0; i < exp.Length; i++)
			{
				if (exp[i] == '(')
				{
					leftBracket++;
				}
				else if (exp[i] == ')')
				{
					rightBracket++;
				}
			}
			exp = exp.PadRight(exp.Length + leftBracket - rightBracket, ')');
			return exp;
		}

		#endregion

		#region Menu Area
		private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TacGia frmTacGia = new TacGia();
			frmTacGia.Show();
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			txtExpression.Text += "+";
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			txtExpression.Text += "-";
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			txtExpression.Text += "*";
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
			txtExpression.Text += "/";
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			txtExpression.Text += "^";
		}

		private void toolStripMenuItem7_Click(object sender, EventArgs e)
		{
			txtExpression.Text += "(";
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			txtExpression.Text += ")";
		}
		#endregion
	}
}
