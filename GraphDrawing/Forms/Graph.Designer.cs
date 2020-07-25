namespace GraphDrawing
{
	partial class Graph
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise,false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			label1 = new System.Windows.Forms.Label();
			lblPosition = new System.Windows.Forms.Label();
			lblSensitivity = new System.Windows.Forms.Label();
			contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
			cartesianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			polarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			ẩnHiệnKhungLướiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			ẩnHiệnBiểuThứcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			mniThemBotBieuThuc = new System.Windows.Forms.ToolStripMenuItem();
			thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			lblChuThich = new System.Windows.Forms.Label();
			expPlotter = new GraphDrawing.ExpressionPlotter();
			mniThongTinDoThi = new System.Windows.Forms.ToolStripMenuItem();
			btnGiamDoNhayPolar = new System.Windows.Forms.Button();
			btnTangDoNhayPolar = new System.Windows.Forms.Button();
			btnLuuDoThi = new System.Windows.Forms.Button();
			btnSangPhai = new System.Windows.Forms.Button();
			btnThuNhoTrucY = new System.Windows.Forms.Button();
			btnSaoChepDoThi = new System.Windows.Forms.Button();
			btnSangTrai = new System.Windows.Forms.Button();
			btnPhongToTrucY = new System.Windows.Forms.Button();
			btnThuNhoTrucX = new System.Windows.Forms.Button();
			btnPhongToTrucX = new System.Windows.Forms.Button();
			btnThuNho = new System.Windows.Forms.Button();
			btnPhongTo = new System.Windows.Forms.Button();
			btnXuongDuoi = new System.Windows.Forms.Button();
			btnLenTren = new System.Windows.Forms.Button();
			contextMenuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point((byte)(0)));
			label1.Location = new System.Drawing.Point(12, 70);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(132, 13);
			label1.TabIndex = 9;
			label1.Text = "Select expressions to view";
			// 
			// lblPosition
			// 
			lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			lblPosition.AutoSize = true;
			lblPosition.BackColor = System.Drawing.Color.White;
			lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point((byte)(0)));
			lblPosition.ForeColor = System.Drawing.Color.Red;
			lblPosition.Location = new System.Drawing.Point(12, 574);
			lblPosition.Name = "lblPosition";
			lblPosition.Size = new System.Drawing.Size(141, 16);
			lblPosition.TabIndex = 23;
			lblPosition.Tag = " ";
			lblPosition.Text = "Vị trí hiện tại của chuột:";
			// 
			// lblSensitivity
			// 
			lblSensitivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			lblSensitivity.AutoSize = true;
			lblSensitivity.BackColor = System.Drawing.Color.White;
			lblSensitivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point((byte)(0)));
			lblSensitivity.ForeColor = System.Drawing.Color.Red;
			lblSensitivity.Location = new System.Drawing.Point(488, 9);
			lblSensitivity.Name = "lblSensitivity";
			lblSensitivity.Size = new System.Drawing.Size(94, 16);
			lblSensitivity.TabIndex = 24;
			lblSensitivity.Text = "Độ nhạy polar:";
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			cartesianToolStripMenuItem,
			polarToolStripMenuItem,
			ẩnHiệnKhungLướiToolStripMenuItem,
			ẩnHiệnBiểuThứcToolStripMenuItem,
			mniThemBotBieuThuc,
			mniThongTinDoThi,
			thoátToolStripMenuItem1});
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new System.Drawing.Size(179, 180);
			// 
			// cartesianToolStripMenuItem
			// 
			cartesianToolStripMenuItem.Name = "cartesianToolStripMenuItem";
			cartesianToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			cartesianToolStripMenuItem.Text = "Cartesian";
			cartesianToolStripMenuItem.Click += new System.EventHandler(cartesianToolStripMenuItem_Click);
			// 
			// polarToolStripMenuItem
			// 
			polarToolStripMenuItem.Name = "polarToolStripMenuItem";
			polarToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			polarToolStripMenuItem.Text = "Polar";
			polarToolStripMenuItem.Click += new System.EventHandler(polarToolStripMenuItem_Click);
			// 
			// ẩnHiệnKhungLướiToolStripMenuItem
			// 
			ẩnHiệnKhungLướiToolStripMenuItem.Name = "ẩnHiệnKhungLướiToolStripMenuItem";
			ẩnHiệnKhungLướiToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			ẩnHiệnKhungLướiToolStripMenuItem.Text = "Ẩn hiện khung lưới";
			ẩnHiệnKhungLướiToolStripMenuItem.Click += new System.EventHandler(ẩnHiệnKhungLướiToolStripMenuItem_Click);
			// 
			// ẩnHiệnBiểuThứcToolStripMenuItem
			// 
			ẩnHiệnBiểuThứcToolStripMenuItem.Name = "ẩnHiệnBiểuThứcToolStripMenuItem";
			ẩnHiệnBiểuThứcToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			ẩnHiệnBiểuThứcToolStripMenuItem.Text = "Ẩn hiện biểu thức";
			ẩnHiệnBiểuThứcToolStripMenuItem.Click += new System.EventHandler(ẩnHiệnBiểuThứcToolStripMenuItem_Click);
			// 
			// mniThemBotBieuThuc
			// 
			mniThemBotBieuThuc.Name = "mniThemBotBieuThuc";
			mniThemBotBieuThuc.Size = new System.Drawing.Size(178, 22);
			mniThemBotBieuThuc.Text = "Thêm bớt biểu thức";
			mniThemBotBieuThuc.Click += new System.EventHandler(mniThemBotBieuThuc_Click);
			// 
			// thoátToolStripMenuItem1
			// 
			thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
			thoátToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
			thoátToolStripMenuItem1.Text = "Thoát";
			thoátToolStripMenuItem1.Click += new System.EventHandler(thoátToolStripMenuItem1_Click);
			// 
			// lblChuThich
			// 
			lblChuThich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			lblChuThich.AutoSize = true;
			lblChuThich.BackColor = System.Drawing.Color.White;
			lblChuThich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point((byte)(0)));
			lblChuThich.ForeColor = System.Drawing.Color.Red;
			lblChuThich.Location = new System.Drawing.Point(375, 574);
			lblChuThich.Name = "lblChuThich";
			lblChuThich.Size = new System.Drawing.Size(175, 16);
			lblChuThich.TabIndex = 39;
			lblChuThich.Tag = " ";
			lblChuThich.Text = "Hãy kích chuột phải để thoát";
			lblChuThich.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// expPlotter
			// 
			expPlotter.ContextMenuStrip = contextMenuStrip1;
			expPlotter.DisplayText = true;
			expPlotter.DivisionsX = 8;
			expPlotter.DivisionsY = 8;
			expPlotter.Dock = System.Windows.Forms.DockStyle.Fill;
			expPlotter.ForwardX = 0;
			expPlotter.ForwardY = 0;
			expPlotter.GraphMode = GraphDrawing.GraphMode.Rectangular;
			expPlotter.Grids = false;
			expPlotter.Location = new System.Drawing.Point(0, 0);
			expPlotter.Name = "expPlotter";
			expPlotter.PenWidth = 1;
			expPlotter.PolarSensitivity = 100;
			expPlotter.PrintStepX = 1;
			expPlotter.PrintStepY = 1;
			expPlotter.ScaleX = 8;
			expPlotter.ScaleY = 8;
			expPlotter.Size = new System.Drawing.Size(685, 599);
			expPlotter.TabIndex = 0;
			expPlotter.Text = "expressionPlotter1";
			expPlotter.Click += new System.EventHandler(expPlotter_Click);
			expPlotter.MouseMove += new System.Windows.Forms.MouseEventHandler(expPlotter_MouseMove);
			// 
			// mniThongTinDoThi
			// 
			mniThongTinDoThi.Name = "mniThongTinDoThi";
			mniThongTinDoThi.Size = new System.Drawing.Size(178, 22);
			mniThongTinDoThi.Text = "Thông tin đồ thị";
			mniThongTinDoThi.Click += new System.EventHandler(mniThongTinDoThi_Click);
			// 
			// btnGiamDoNhayPolar
			// 
			btnGiamDoNhayPolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			btnGiamDoNhayPolar.BackColor = System.Drawing.Color.White;
			btnGiamDoNhayPolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnGiamDoNhayPolar.Image = global::GraphDrawing.Properties.Resources.polarDown;
			btnGiamDoNhayPolar.Location = new System.Drawing.Point(637, 378);
			btnGiamDoNhayPolar.Name = "btnGiamDoNhayPolar";
			btnGiamDoNhayPolar.Size = new System.Drawing.Size(36, 36);
			btnGiamDoNhayPolar.TabIndex = 38;
			btnGiamDoNhayPolar.UseVisualStyleBackColor = false;
			btnGiamDoNhayPolar.Click += new System.EventHandler(btnGiamDoNhayPolar_Click);
			btnGiamDoNhayPolar.MouseMove += new System.Windows.Forms.MouseEventHandler(btnGiamDoNhayPolar_MouseMove);
			// 
			// btnTangDoNhayPolar
			// 
			btnTangDoNhayPolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			btnTangDoNhayPolar.BackColor = System.Drawing.Color.White;
			btnTangDoNhayPolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnTangDoNhayPolar.Image = global::GraphDrawing.Properties.Resources.polarup;
			btnTangDoNhayPolar.Location = new System.Drawing.Point(637, 336);
			btnTangDoNhayPolar.Name = "btnTangDoNhayPolar";
			btnTangDoNhayPolar.Size = new System.Drawing.Size(36, 36);
			btnTangDoNhayPolar.TabIndex = 37;
			btnTangDoNhayPolar.UseVisualStyleBackColor = false;
			btnTangDoNhayPolar.Click += new System.EventHandler(btnTangDoNhayPolar_Click);
			btnTangDoNhayPolar.MouseMove += new System.Windows.Forms.MouseEventHandler(btnTangDoNhayPolar_MouseMove);
			// 
			// btnLuuDoThi
			// 
			btnLuuDoThi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			btnLuuDoThi.BackColor = System.Drawing.Color.White;
			btnLuuDoThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnLuuDoThi.Image = global::GraphDrawing.Properties.Resources.disk;
			btnLuuDoThi.Location = new System.Drawing.Point(637, 0);
			btnLuuDoThi.Name = "btnLuuDoThi";
			btnLuuDoThi.Size = new System.Drawing.Size(36, 36);
			btnLuuDoThi.TabIndex = 36;
			btnLuuDoThi.Tag = "";
			btnLuuDoThi.UseVisualStyleBackColor = false;
			btnLuuDoThi.Click += new System.EventHandler(btnLuuDoThi_Click);
			btnLuuDoThi.MouseMove += new System.Windows.Forms.MouseEventHandler(btnLuuDoThi_MouseMove);
			// 
			// btnSangPhai
			// 
			btnSangPhai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			btnSangPhai.BackColor = System.Drawing.Color.White;
			btnSangPhai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnSangPhai.Image = global::GraphDrawing.Properties.Resources.right;
			btnSangPhai.Location = new System.Drawing.Point(637, 508);
			btnSangPhai.Name = "btnSangPhai";
			btnSangPhai.Size = new System.Drawing.Size(36, 36);
			btnSangPhai.TabIndex = 25;
			btnSangPhai.UseVisualStyleBackColor = false;
			btnSangPhai.Click += new System.EventHandler(btnSangPhai_Click);
			btnSangPhai.MouseMove += new System.Windows.Forms.MouseEventHandler(btnSangPhai_MouseMove);
			// 
			// btnThuNhoTrucY
			// 
			btnThuNhoTrucY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			btnThuNhoTrucY.BackColor = System.Drawing.Color.White;
			btnThuNhoTrucY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnThuNhoTrucY.Image = global::GraphDrawing.Properties.Resources.ZoomOut_Y;
			btnThuNhoTrucY.Location = new System.Drawing.Point(637, 294);
			btnThuNhoTrucY.Name = "btnThuNhoTrucY";
			btnThuNhoTrucY.Size = new System.Drawing.Size(36, 36);
			btnThuNhoTrucY.TabIndex = 34;
			btnThuNhoTrucY.UseVisualStyleBackColor = false;
			btnThuNhoTrucY.Click += new System.EventHandler(btnThuNhoTrucY_Click);
			btnThuNhoTrucY.MouseMove += new System.Windows.Forms.MouseEventHandler(btnThuNhoTrucY_MouseMove);
			// 
			// btnSaoChepDoThi
			// 
			btnSaoChepDoThi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			btnSaoChepDoThi.BackColor = System.Drawing.Color.White;
			btnSaoChepDoThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnSaoChepDoThi.Image = global::GraphDrawing.Properties.Resources.copy;
			btnSaoChepDoThi.Location = new System.Drawing.Point(637, 42);
			btnSaoChepDoThi.Name = "btnSaoChepDoThi";
			btnSaoChepDoThi.Size = new System.Drawing.Size(36, 36);
			btnSaoChepDoThi.TabIndex = 35;
			btnSaoChepDoThi.UseVisualStyleBackColor = false;
			btnSaoChepDoThi.Click += new System.EventHandler(btnSaoChepDoThi_Click);
			btnSaoChepDoThi.MouseMove += new System.Windows.Forms.MouseEventHandler(btnSaoChepDoThi_MouseMove);
			// 
			// btnSangTrai
			// 
			btnSangTrai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			btnSangTrai.BackColor = System.Drawing.Color.White;
			btnSangTrai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnSangTrai.Image = global::GraphDrawing.Properties.Resources.left;
			btnSangTrai.Location = new System.Drawing.Point(637, 550);
			btnSangTrai.Name = "btnSangTrai";
			btnSangTrai.Size = new System.Drawing.Size(36, 36);
			btnSangTrai.TabIndex = 27;
			btnSangTrai.UseVisualStyleBackColor = false;
			btnSangTrai.Click += new System.EventHandler(btnSangTrai_Click);
			btnSangTrai.MouseMove += new System.Windows.Forms.MouseEventHandler(btnSangTrai_MouseMove);
			// 
			// btnPhongToTrucY
			// 
			btnPhongToTrucY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			btnPhongToTrucY.BackColor = System.Drawing.Color.White;
			btnPhongToTrucY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnPhongToTrucY.Image = global::GraphDrawing.Properties.Resources.Zoomin_Y;
			btnPhongToTrucY.Location = new System.Drawing.Point(637, 252);
			btnPhongToTrucY.Name = "btnPhongToTrucY";
			btnPhongToTrucY.Size = new System.Drawing.Size(36, 36);
			btnPhongToTrucY.TabIndex = 33;
			btnPhongToTrucY.UseVisualStyleBackColor = false;
			btnPhongToTrucY.Click += new System.EventHandler(btnPhongToTrucY_Click);
			btnPhongToTrucY.MouseMove += new System.Windows.Forms.MouseEventHandler(btnPhongToTrucY_MouseMove);
			// 
			// btnThuNhoTrucX
			// 
			btnThuNhoTrucX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			btnThuNhoTrucX.BackColor = System.Drawing.Color.White;
			btnThuNhoTrucX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnThuNhoTrucX.Image = global::GraphDrawing.Properties.Resources.ZoomOut_X;
			btnThuNhoTrucX.Location = new System.Drawing.Point(637, 210);
			btnThuNhoTrucX.Name = "btnThuNhoTrucX";
			btnThuNhoTrucX.Size = new System.Drawing.Size(36, 36);
			btnThuNhoTrucX.TabIndex = 32;
			btnThuNhoTrucX.UseVisualStyleBackColor = false;
			btnThuNhoTrucX.Click += new System.EventHandler(btnThuNhoTrucX_Click);
			btnThuNhoTrucX.MouseMove += new System.Windows.Forms.MouseEventHandler(btnThuNhoTrucX_MouseMove);
			// 
			// btnPhongToTrucX
			// 
			btnPhongToTrucX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			btnPhongToTrucX.BackColor = System.Drawing.Color.White;
			btnPhongToTrucX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnPhongToTrucX.Image = global::GraphDrawing.Properties.Resources.ZoomIn_X;
			btnPhongToTrucX.Location = new System.Drawing.Point(637, 168);
			btnPhongToTrucX.Name = "btnPhongToTrucX";
			btnPhongToTrucX.Size = new System.Drawing.Size(36, 36);
			btnPhongToTrucX.TabIndex = 31;
			btnPhongToTrucX.UseVisualStyleBackColor = false;
			btnPhongToTrucX.Click += new System.EventHandler(btnPhongToTrucX_Click);
			btnPhongToTrucX.MouseMove += new System.Windows.Forms.MouseEventHandler(btnPhongToTrucX_MouseMove);
			// 
			// btnThuNho
			// 
			btnThuNho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			btnThuNho.BackColor = System.Drawing.Color.White;
			btnThuNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnThuNho.Image = global::GraphDrawing.Properties.Resources.Zoomout;
			btnThuNho.Location = new System.Drawing.Point(637, 126);
			btnThuNho.Name = "btnThuNho";
			btnThuNho.Size = new System.Drawing.Size(36, 36);
			btnThuNho.TabIndex = 30;
			btnThuNho.UseVisualStyleBackColor = false;
			btnThuNho.Click += new System.EventHandler(btnThuNho_Click);
			btnThuNho.MouseMove += new System.Windows.Forms.MouseEventHandler(btnThuNho_MouseMove);
			// 
			// btnPhongTo
			// 
			btnPhongTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			btnPhongTo.BackColor = System.Drawing.Color.White;
			btnPhongTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnPhongTo.Image = global::GraphDrawing.Properties.Resources.Zoomin;
			btnPhongTo.Location = new System.Drawing.Point(637, 84);
			btnPhongTo.Name = "btnPhongTo";
			btnPhongTo.Size = new System.Drawing.Size(36, 36);
			btnPhongTo.TabIndex = 29;
			btnPhongTo.UseVisualStyleBackColor = false;
			btnPhongTo.Click += new System.EventHandler(btnPhongTo_Click);
			btnPhongTo.MouseMove += new System.Windows.Forms.MouseEventHandler(btnPhongTo_MouseMove);
			// 
			// btnXuongDuoi
			// 
			btnXuongDuoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			btnXuongDuoi.BackColor = System.Drawing.Color.White;
			btnXuongDuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnXuongDuoi.Image = global::GraphDrawing.Properties.Resources.down;
			btnXuongDuoi.Location = new System.Drawing.Point(637, 468);
			btnXuongDuoi.Name = "btnXuongDuoi";
			btnXuongDuoi.Size = new System.Drawing.Size(36, 36);
			btnXuongDuoi.TabIndex = 26;
			btnXuongDuoi.UseVisualStyleBackColor = false;
			btnXuongDuoi.Click += new System.EventHandler(btnXuongDuoi_Click);
			btnXuongDuoi.MouseMove += new System.Windows.Forms.MouseEventHandler(btnXuongDuoi_MouseMove);
			// 
			// btnLenTren
			// 
			btnLenTren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			btnLenTren.BackColor = System.Drawing.Color.White;
			btnLenTren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnLenTren.Image = global::GraphDrawing.Properties.Resources.up;
			btnLenTren.Location = new System.Drawing.Point(637, 426);
			btnLenTren.Name = "btnLenTren";
			btnLenTren.Size = new System.Drawing.Size(36, 36);
			btnLenTren.TabIndex = 28;
			btnLenTren.UseVisualStyleBackColor = false;
			btnLenTren.Click += new System.EventHandler(btnLenTren_Click);
			btnLenTren.MouseMove += new System.Windows.Forms.MouseEventHandler(btnLenTren_MouseMove);
			// 
			// Graph
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(685, 599);
			Controls.Add(btnGiamDoNhayPolar);
			Controls.Add(btnTangDoNhayPolar);
			Controls.Add(btnLuuDoThi);
			Controls.Add(btnSangPhai);
			Controls.Add(btnThuNhoTrucY);
			Controls.Add(btnSaoChepDoThi);
			Controls.Add(lblChuThich);
			Controls.Add(btnSangTrai);
			Controls.Add(btnPhongToTrucY);
			Controls.Add(btnThuNhoTrucX);
			Controls.Add(btnPhongToTrucX);
			Controls.Add(btnThuNho);
			Controls.Add(btnPhongTo);
			Controls.Add(btnXuongDuoi);
			Controls.Add(btnLenTren);
			Controls.Add(lblSensitivity);
			Controls.Add(lblPosition);
			Controls.Add(expPlotter);
			Controls.Add(label1);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			MaximizeBox = false;
			Name = "Graph";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Graph";
			WindowState = System.Windows.Forms.FormWindowState.Maximized;
			Resize += new System.EventHandler(Graph_Resize);
			Load += new System.EventHandler(Graph_Load);
			contextMenuStrip1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblPosition;
		private System.Windows.Forms.Label lblSensitivity;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cartesianToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem polarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ẩnHiệnKhungLướiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ẩnHiệnBiểuThứcToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
		private System.Windows.Forms.Button btnSangPhai;
		private System.Windows.Forms.Button btnSangTrai;
		private System.Windows.Forms.Button btnXuongDuoi;
		private System.Windows.Forms.Button btnLenTren;
		private System.Windows.Forms.Button btnPhongTo;
		private System.Windows.Forms.Button btnThuNho;
		private System.Windows.Forms.Button btnPhongToTrucX;
		private System.Windows.Forms.Button btnThuNhoTrucX;
		private System.Windows.Forms.Button btnPhongToTrucY;
		private System.Windows.Forms.Button btnThuNhoTrucY;
		private System.Windows.Forms.Button btnSaoChepDoThi;
		private System.Windows.Forms.Button btnLuuDoThi;
		private System.Windows.Forms.Button btnTangDoNhayPolar;
		private System.Windows.Forms.Button btnGiamDoNhayPolar;
		private System.Windows.Forms.Label lblChuThich;
		private System.Windows.Forms.ToolStripMenuItem mniThemBotBieuThuc;
		private System.Windows.Forms.ToolStripMenuItem mniThongTinDoThi;
		public static ExpressionPlotter expPlotter;
	}
}