using GraphLibrary;
using System;
using System.Windows.Forms;

namespace GraphDrawing
{
	public partial class BangGiaTri : Form
	{
		public BangGiaTri()
		{
			InitializeComponent();
		}

		private void BangGiaTri_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < ExpressionHelper.ArrExpression.Count; i++)
			{
				cbxExpressions.Items.Add(ExpressionHelper.ArrExpression[i].ToString());
				cbxExpressions.SelectedIndex = 0;
			}
			rdbDegree.Checked = false;
			rdbRadian.Checked = true;
		}

		private void btnDong_Click(object sender, EventArgs e)
		{
			rdbDegree.Checked = false;
			rdbRadian.Checked = true;
			Close();
		}

		private void btnXem_Click(object sender, EventArgs e)
		{
			lstValues.Items.Clear();
			Expression expression = new Expression(cbxExpressions.Text);
			for (int i = Convert.ToInt32(ExpressionHelper.XStartValue); i <= Convert.ToInt32(ExpressionHelper.XEndValue); i++)
			{
				double Y = expression.Evaluate(i);
				ListViewItem lvi = new ListViewItem(i.ToString());
				lvi.SubItems.Add(Y.ToString());
				lstValues.Items.Add(lvi);
			}
		}

		private void rbDo_CheckedChanged(object sender, EventArgs e)
		{
			ExpressionHelper.BlnDo = true;
			ExpressionHelper.BlnRadian = false;
		}

		private void rbRadian_CheckedChanged(object sender, EventArgs e)
		{
			ExpressionHelper.BlnDo = false;
			ExpressionHelper.BlnRadian = true;
		}
	}
}