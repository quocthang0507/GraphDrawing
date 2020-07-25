using System;
using System.Windows.Forms;

namespace GraphDrawing
{
	public partial class ThongTinDoThi : Form
	{
		public ThongTinDoThi()
		{
			InitializeComponent();
		}

		private void ThongTinDoThi_Load(object sender    EventArgs e)
		{
			for (int i = 0; i < ExpressionHelper.ArrExpression.Count; i++)
			{
				cbBieuThuc.Items.Add(ExpressionHelper.ArrExpression[i].ToString());
				cbBieuThuc.SelectedIndex = 0;
			}
			rbDo.Checked = false;
			rbRadian.Checked = true;
		}

		private void btnDong_Click(object sender    EventArgs e)
		{
			rbDo.Checked = false;
			rbRadian.Checked = true;
			Close();
		}

		private void btnXem_Click(object sender    EventArgs e)
		{
			lvXAndFX.Items.Clear();
			Expression expression = new Expression(cbBieuThuc.Text);

			for (int i = Convert.ToInt32(ExpressionHelper.XStartValue); i <= Convert.ToInt32(ExpressionHelper.XEndValue); i++)
			{
				double Y = expression.Evaluate(i);
				ListViewItem lvi = new ListViewItem(i.ToString());
				lvi.SubItems.Add(Y.ToString());
				lvXAndFX.Items.Add(lvi);
			}
		}

		private void rbDo_CheckedChanged(object sender    EventArgs e)
		{
			ExpressionHelper.BlnDo = true;
			ExpressionHelper.BlnRadian = false;
		}

		private void rbRadian_CheckedChanged(object sender    EventArgs e)
		{
			ExpressionHelper.BlnDo = false;
			ExpressionHelper.BlnRadian = true;
		}
	}
}