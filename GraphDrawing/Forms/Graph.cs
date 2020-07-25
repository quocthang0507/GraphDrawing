using System;
using System.Drawing;
using System.Windows.Forms;


namespace GraphDrawing
{
	public partial class Graph : Form
	{
		public Graph()
		{
			InitializeComponent();
		}

		#region Public Methods
		public void AddExpression(string text, Color color)
		{
			expPlotter.AddExpression(new Expression(text), color, true);
			//lstExpressions.Items.Add(text);
			//lstExpressions.SetItemChecked(lstExpressions.Items.IndexOf(text),true);
		}
		public void RemoveAllExpressions()
		{
			expPlotter.RemoveAllExpressions();
			//lstExpressions.Items.Clear();
		}
		public void SetRange(double startX, double endX, double startY, double endY)
		{
			expPlotter.SetRangeX(startX, endX);
			expPlotter.SetRangeY(startY, endY);
		}
		public void SetDivisions(int divX, int divY)
		{
			expPlotter.DivisionsX = divX;
			expPlotter.DivisionsY = divY;
		}
		public void SetMode(GraphMode mode, int sensitivity)
		{
			expPlotter.GraphMode = mode;
			if (mode == GraphMode.Polar)
			{
				expPlotter.PolarSensitivity = sensitivity;
				lblSensitivity.Text = "Polar sensitivity: " + expPlotter.PolarSensitivity;
			}
		}
		public void SetPenWidth(int width)
		{
			expPlotter.PenWidth = width;
		}

		#endregion

		#region Private Methods

		private double GetR(double X, double Y)
		{
			return Math.Sqrt(X * X + Y * Y);
		}
		private double GetTheta(double X, double Y)
		{
			double dTheta;
			if (X == 0)
			{
				if (Y > 0)
				{
					dTheta = Math.PI / 2;
				}
				else
				{
					dTheta = -Math.PI / 2;
				}
			}
			else
			{
				dTheta = Math.Atan(Y / X);
			}

			//actual range of theta is from 0 to 2PI
			if (X < 0)
			{
				dTheta = dTheta + Math.PI;
			}
			else if (Y < 0)
			{
				dTheta = dTheta + 2 * Math.PI;
			}

			return dTheta;
		}

		private System.Drawing.Imaging.ImageFormat GetImageFormat(string filename)
		{
			string[] tempArray = filename.Split('.');
			string extension = tempArray[tempArray.Length - 1];
			switch (extension)
			{
				case "bmp":
					return System.Drawing.Imaging.ImageFormat.Bmp;
				case "jpg":
					return System.Drawing.Imaging.ImageFormat.Jpeg;
				case "gif":
					return System.Drawing.Imaging.ImageFormat.Gif;
				case "png":
					return System.Drawing.Imaging.ImageFormat.Png;
				case "tiff":
					return System.Drawing.Imaging.ImageFormat.Tiff;
				case "wmf":
					return System.Drawing.Imaging.ImageFormat.Wmf;
				default:
					return System.Drawing.Imaging.ImageFormat.Bmp;
			}

		}

		#endregion

		#region Event Handlers

		private void Graph_Load(object sender, EventArgs e)
		{
			expPlotter.MouseMove += new MouseEventHandler(ExpPlotter_OnMouseMove);
			//expPlotter.MouseWheel += new MouseEventHandler(ExpPlotter_OnMouseWheel);
			lblSensitivity.Text = "";
			if (ExpressionHelper.Cartesian == true)
			{
				cartesianToolStripMenuItem.Checked = true;
				polarToolStripMenuItem.Checked = false;
			}
			else
			{
				polarToolStripMenuItem.Checked = true;
				cartesianToolStripMenuItem.Checked = false;
			}
		}

		//private void ExpPlotter_OnMouseWheel(object sender,MouseEventArgs e)
		//{
		//,if (e.Delta > 0)
		//,,expPlotter.ZoomIn();
		//,else if (e.Delta < 0)
		//,,expPlotter.ZoomOut();
		//,expPlotter.Refresh();
		//}

		private void ExpPlotter_OnMouseMove(object sender, MouseEventArgs e)
		{
			double currentX, currentY;
			currentX = (e.X - expPlotter.Width / 2) * expPlotter.ScaleX / expPlotter.Width * 2.25 + expPlotter.ForwardX;
			currentY = (expPlotter.Width / 2 - e.Y) * expPlotter.ScaleY / expPlotter.Width * 2.25 + expPlotter.ForwardY;
			if (expPlotter.GraphMode == GraphMode.Polar)
			{
				double r = GetR(currentX, currentY);
				double theta = GetTheta(currentX, currentY);
				currentX = r;
				currentY = theta;
			}
			currentX = Math.Round(currentX, 3);
			currentY = Math.Round(currentY, 3);
			lblPosition.Text = "Vị trí hiện tại của chuột: " + currentX + "," + currentY;
		}


		private void btnShowOrigin_Click(object sender, EventArgs e)
		{
			expPlotter.ForwardX = expPlotter.ForwardY = 0;
			expPlotter.Refresh();
		}

		private void btnDefault_Click(object sender, EventArgs e)
		{
			expPlotter.RestoreDefaults();
			expPlotter.Refresh();
		}


		private void btnText_Click(object sender, EventArgs e)
		{
			expPlotter.DisplayText = !expPlotter.DisplayText;
			expPlotter.Refresh();
		}

		private void Graph_Resize(object sender, EventArgs e)
		{
			expPlotter.Refresh();
		}


		private void expPlotter_Click(object sender, EventArgs e)
		{
			expPlotter.Select();
		}

		#endregion

		private void lstExpressions_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cartesianToolStripMenuItem_Click(object sender, EventArgs e)
		{
			cartesianToolStripMenuItem.Checked = true;
			polarToolStripMenuItem.Checked = false;
			if (expPlotter.GraphMode != GraphMode.Rectangular)
			{
				lblSensitivity.Text = "";
				expPlotter.GraphMode = GraphMode.Rectangular;
				expPlotter.Refresh();
			}
		}

		private void polarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			cartesianToolStripMenuItem.Checked = false;
			polarToolStripMenuItem.Checked = true;
			if (expPlotter.GraphMode != GraphMode.Polar)
			{
				lblSensitivity.Text = "Độ nhạy polar: " + expPlotter.PolarSensitivity;
				expPlotter.GraphMode = GraphMode.Polar;
				expPlotter.Refresh();
			}
		}

		private void ẩnHiệnKhungLướiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			expPlotter.ToggleGrids();
			expPlotter.Refresh();
		}

		private void ẩnHiệnBiểuThứcToolStripMenuItem_Click(object sender, EventArgs e)
		{
			expPlotter.DisplayText = !expPlotter.DisplayText;
			expPlotter.Refresh();
		}

		private void btnLuuDoThi_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog
			{
				Title = "Luu do thi"
			};
			string filter = "Bitmap (*.bmp)|*.bmp|" +
							"JPEG (*.jpg)|*.jpg|" +
							"GIF (*.gif)|*.gif|" +
							"PNG (*.png)|*.png|" +
							"TIFF (*.tiff)|*.tiff|" +
							"WMF (*.wmf)|*.wmf";
			dialog.Filter = filter;
			dialog.FileName = "do thi";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Bitmap bmp = expPlotter.GetGraphBitmap();
				bmp.Save(dialog.FileName, GetImageFormat(dialog.FileName));
				MessageBox.Show("Đồ thị đã được lưu thành công tại địa chỉ " + dialog.FileName, "Đã lưu");
			}
		}

		private void btnSaoChepDoThi_Click(object sender, EventArgs e)
		{
			expPlotter.CopyToClipboard();
		}

		private void btnPhongTo_Click(object sender, EventArgs e)
		{
			expPlotter.ZoomIn();
			expPlotter.Refresh();
		}

		private void btnThuNho_Click(object sender, EventArgs e)
		{
			expPlotter.ZoomOut();
			expPlotter.Refresh();
		}

		private void btnPhongToTrucX_Click(object sender, EventArgs e)
		{
			expPlotter.ZoomInX();
			expPlotter.Refresh();
		}

		private void btnThuNhoTrucX_Click(object sender, EventArgs e)
		{
			expPlotter.ZoomOutX();
			expPlotter.Refresh();
		}

		private void btnPhongToTrucY_Click(object sender, EventArgs e)
		{
			expPlotter.ZoomInY();
			expPlotter.Refresh();
		}

		private void btnThuNhoTrucY_Click(object sender, EventArgs e)
		{
			expPlotter.ZoomOutY();
			expPlotter.Refresh();
		}

		private void btnLenTren_Click(object sender, EventArgs e)
		{
			expPlotter.MoveUp(1);
			expPlotter.Refresh();
		}

		private void btnXuongDuoi_Click(object sender, EventArgs e)
		{
			expPlotter.MoveDown(1);
			expPlotter.Refresh();
		}

		private void btnSangPhai_Click(object sender, EventArgs e)
		{
			expPlotter.MoveRight(1);
			expPlotter.Refresh();
		}

		private void btnSangTrai_Click(object sender, EventArgs e)
		{
			expPlotter.MoveLeft(1);
			expPlotter.Refresh();
		}

		private void btnTangDoNhayPolar_Click(object sender, EventArgs e)
		{
			if (expPlotter.GraphMode == GraphMode.Polar && expPlotter.PolarSensitivity < 500)
			{
				expPlotter.PolarSensitivity += 50;
				expPlotter.Refresh();
				lblSensitivity.Text = "Độ nhạy polar: " + expPlotter.PolarSensitivity;
			}
		}

		private void btnGiamDoNhayPolar_Click(object sender, EventArgs e)
		{
			if (expPlotter.GraphMode == GraphMode.Polar && expPlotter.PolarSensitivity > 50)
			{
				expPlotter.PolarSensitivity -= 50;
				expPlotter.Refresh();
				lblSensitivity.Text = "Độ nhạy polar: " + expPlotter.PolarSensitivity;
			}
		}



		private void btnLuuDoThi_MouseMove(object sender, MouseEventArgs e)
		{
			lblChuThich.Text = "Lưu đồ thị";
		}

		private void btnSaoChepDoThi_MouseMove(object sender, MouseEventArgs e)
		{
			lblChuThich.Text = "Sao chép tới clipboard";
		}

		private void btnPhongTo_MouseMove(object sender, MouseEventArgs e)
		{
			lblChuThich.Text = "Phóng to";
		}

		private void btnThuNho_MouseMove(object sender, MouseEventArgs e)
		{
			lblChuThich.Text = "Thu nhỏ";
		}

		private void btnPhongToTrucX_MouseMove(object sender, MouseEventArgs e)
		{
			lblChuThich.Text = "Phóng to trục X";
		}

		private void btnThuNhoTrucX_MouseMove(object sender, MouseEventArgs e)
		{
			lblChuThich.Text = "Thu nhỏ trục X";
		}

		private void btnPhongToTrucY_MouseMove(object sender, MouseEventArgs e)
		{
			lblChuThich.Text = "Phóng to trục Y";
		}

		private void btnThuNhoTrucY_MouseMove(object sender, MouseEventArgs e)
		{
			lblChuThich.Text = "Thu nhỏ trục Y";
		}

		private void btnTangDoNhayPolar_MouseMove(object sender, MouseEventArgs e)
		{
			lblChuThich.Text = "Tăng độ nhạy polar";
		}

		private void btnGiamDoNhayPolar_MouseMove(object sender, MouseEventArgs e)
		{
			lblChuThich.Text = "Giảm độ nhạy polar";
		}

		private void btnLenTren_MouseMove(object sender, MouseEventArgs e)
		{
			lblChuThich.Text = "Lên trên";
		}

		private void btnXuongDuoi_MouseMove(object sender, MouseEventArgs e)
		{
			lblChuThich.Text = "Xuống dưới";
		}

		private void btnSangPhai_MouseMove(object sender, MouseEventArgs e)
		{
			lblChuThich.Text = "Sang phải";
		}

		private void btnSangTrai_MouseMove(object sender, MouseEventArgs e)
		{
			lblChuThich.Text = "Sang trái";
		}

		private void expPlotter_MouseMove(object sender, MouseEventArgs e)
		{
			lblChuThich.Text = "Hãy kích chuột phải để thoát";
		}

		private void mniThemBotBieuThuc_Click(object sender, EventArgs e)
		{
			ThemBotBieuThuc frm = new ThemBotBieuThuc();
			frm.ShowDialog();
		}

		private void mniThongTinDoThi_Click(object sender, EventArgs e)
		{
			ThongTinDoThi frm = new ThongTinDoThi();
			frm.ShowDialog();
		}

	}
}