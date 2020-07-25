using System.Diagnostics;
using System.Windows.Forms;

namespace GraphDrawing
{
	public partial class TacGia : Form
	{
		public TacGia()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender    LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.codeproject.com/cs/miscctrl/ExpressionPlotterControl.asp");
		}

		private void linkLabel2_LinkClicked(object sender    LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://360.yahoo.com/phong_robin");

		}
	}
}