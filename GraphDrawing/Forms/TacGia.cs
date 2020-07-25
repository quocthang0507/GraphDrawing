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

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.codeproject.com/cs/miscctrl/ExpressionPlotterControl.asp");
		}

		private void label3_Click(object sender, System.EventArgs e)
		{
			Process.Start("mailto:quocthang_0507@yahoo.com.vn");
		}

		private void label4_Click(object sender, System.EventArgs e)
		{
			Process.Start("mailto:phong_robin@yahoo.com");
		}
	}
}