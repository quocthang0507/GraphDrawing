using GraphLibrary;
using System;
using System.Windows.Forms;

namespace GraphDrawing
{
	public partial class ThayDoiDoThi : Form
	{
		public ThayDoiDoThi()
		{
			InitializeComponent();
		}

		private void ThayDoiDoThi_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < ExpressionHelper.ArrExpression.Count; i++)
			{
				clbExpressions.Items.Add(ExpressionHelper.ArrExpression[i].ToString());
				for (int j = 0; j < clbExpressions.Items.Count; j++)
				{
					clbExpressions.SetItemChecked(j, true);
				}
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			try
			{
				for (int i = 0; i < clbExpressions.Items.Count; i++)
				{
					if (clbExpressions.CheckedIndices.Contains(i))
					{
						DoThi.Instance.expPlotter.SetExpressionVisibility(i, true);
					}
					else
					{
						DoThi.Instance.expPlotter.SetExpressionVisibility(i, false);
					}
				}
				DoThi.Instance.expPlotter.Refresh();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}