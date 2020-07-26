namespace GraphDrawing
{
	partial class DoThi
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoThi));
			this.label1 = new System.Windows.Forms.Label();
			this.lblPosition = new System.Windows.Forms.Label();
			this.lblSensitivity = new System.Windows.Forms.Label();
			this.contextMenuPlotter = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuCartesianMode = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPolarMode = new System.Windows.Forms.ToolStripMenuItem();
			this.menuShowGrid = new System.Windows.Forms.ToolStripMenuItem();
			this.menuShowExpression = new System.Windows.Forms.ToolStripMenuItem();
			this.menuChangeGraph = new System.Windows.Forms.ToolStripMenuItem();
			this.menuValueTable = new System.Windows.Forms.ToolStripMenuItem();
			this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.lblChuThich = new System.Windows.Forms.Label();
			this.btnGiamDoNhayPolar = new System.Windows.Forms.Button();
			this.btnTangDoNhayPolar = new System.Windows.Forms.Button();
			this.btnLuuDoThi = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.btnThuNhoTrucY = new System.Windows.Forms.Button();
			this.btnSaoChepDoThi = new System.Windows.Forms.Button();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btnPhongToTrucY = new System.Windows.Forms.Button();
			this.btnThuNhoTrucX = new System.Windows.Forms.Button();
			this.btnPhongToTrucX = new System.Windows.Forms.Button();
			this.btnThuNho = new System.Windows.Forms.Button();
			this.btnPhongTo = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
			this.menuExitAll = new System.Windows.Forms.ToolStripMenuItem();
			this.expPlotter = new GraphDrawing.ExpressionPlotter();
			this.contextMenuPlotter.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Select expressions to view";
			// 
			// lblPosition
			// 
			this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblPosition.AutoSize = true;
			this.lblPosition.BackColor = System.Drawing.Color.White;
			this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPosition.ForeColor = System.Drawing.Color.Red;
			this.lblPosition.Location = new System.Drawing.Point(12, 574);
			this.lblPosition.Name = "lblPosition";
			this.lblPosition.Size = new System.Drawing.Size(141, 16);
			this.lblPosition.TabIndex = 23;
			this.lblPosition.Tag = " ";
			this.lblPosition.Text = "Vị trí hiện tại của chuột:";
			// 
			// lblSensitivity
			// 
			this.lblSensitivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSensitivity.AutoSize = true;
			this.lblSensitivity.BackColor = System.Drawing.Color.White;
			this.lblSensitivity.ForeColor = System.Drawing.Color.Red;
			this.lblSensitivity.Location = new System.Drawing.Point(488, 9);
			this.lblSensitivity.Name = "lblSensitivity";
			this.lblSensitivity.Size = new System.Drawing.Size(76, 13);
			this.lblSensitivity.TabIndex = 24;
			this.lblSensitivity.Text = "Độ nhạy polar:";
			// 
			// contextMenuPlotter
			// 
			this.contextMenuPlotter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCartesianMode,
            this.menuPolarMode,
            this.menuShowGrid,
            this.menuShowExpression,
            this.menuChangeGraph,
            this.menuValueTable,
            this.menuExit,
            this.menuExitAll});
			this.contextMenuPlotter.Name = "contextMenuStrip1";
			this.contextMenuPlotter.ShowCheckMargin = true;
			this.contextMenuPlotter.ShowImageMargin = false;
			this.contextMenuPlotter.Size = new System.Drawing.Size(240, 202);
			// 
			// menuCartesianMode
			// 
			this.menuCartesianMode.Name = "menuCartesianMode";
			this.menuCartesianMode.Size = new System.Drawing.Size(239, 22);
			this.menuCartesianMode.Text = "Hệ tọa độ Descartes (Cartesian)";
			this.menuCartesianMode.Click += new System.EventHandler(this.cartesianToolStripMenuItem_Click);
			// 
			// menuPolarMode
			// 
			this.menuPolarMode.Name = "menuPolarMode";
			this.menuPolarMode.Size = new System.Drawing.Size(239, 22);
			this.menuPolarMode.Text = "Hệ tọa độ cực (Polar)";
			this.menuPolarMode.Click += new System.EventHandler(this.polarToolStripMenuItem_Click);
			// 
			// menuShowGrid
			// 
			this.menuShowGrid.Name = "menuShowGrid";
			this.menuShowGrid.Size = new System.Drawing.Size(239, 22);
			this.menuShowGrid.Text = "Hiển thị lưới";
			this.menuShowGrid.Click += new System.EventHandler(this.ẩnHiệnKhungLướiToolStripMenuItem_Click);
			// 
			// menuShowExpression
			// 
			this.menuShowExpression.Name = "menuShowExpression";
			this.menuShowExpression.Size = new System.Drawing.Size(239, 22);
			this.menuShowExpression.Text = "Hiển thị biểu thức";
			this.menuShowExpression.Click += new System.EventHandler(this.ẩnHiệnBiểuThứcToolStripMenuItem_Click);
			// 
			// menuChangeGraph
			// 
			this.menuChangeGraph.Name = "menuChangeGraph";
			this.menuChangeGraph.Size = new System.Drawing.Size(239, 22);
			this.menuChangeGraph.Text = "Thay đổi đồ thị trên màn hình";
			this.menuChangeGraph.Click += new System.EventHandler(this.menuThayDoiDoThi_Click);
			// 
			// menuValueTable
			// 
			this.menuValueTable.Name = "menuValueTable";
			this.menuValueTable.Size = new System.Drawing.Size(239, 22);
			this.menuValueTable.Text = "Bảng giá trị";
			this.menuValueTable.Click += new System.EventHandler(this.menuBangGiaTri_Click);
			// 
			// menuExit
			// 
			this.menuExit.Name = "menuExit";
			this.menuExit.Size = new System.Drawing.Size(239, 22);
			this.menuExit.Text = "Thoát";
			this.menuExit.Click += new System.EventHandler(this.thoátMenu_Click);
			// 
			// lblChuThich
			// 
			this.lblChuThich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblChuThich.AutoSize = true;
			this.lblChuThich.BackColor = System.Drawing.Color.White;
			this.lblChuThich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChuThich.ForeColor = System.Drawing.Color.Red;
			this.lblChuThich.Location = new System.Drawing.Point(375, 574);
			this.lblChuThich.Name = "lblChuThich";
			this.lblChuThich.Size = new System.Drawing.Size(175, 16);
			this.lblChuThich.TabIndex = 39;
			this.lblChuThich.Tag = " ";
			this.lblChuThich.Text = "Hãy kích chuột phải để thoát";
			this.lblChuThich.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// btnGiamDoNhayPolar
			// 
			this.btnGiamDoNhayPolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGiamDoNhayPolar.BackColor = System.Drawing.Color.White;
			this.btnGiamDoNhayPolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGiamDoNhayPolar.Image = global::GraphDrawing.Properties.Resources.polarDown;
			this.btnGiamDoNhayPolar.Location = new System.Drawing.Point(637, 378);
			this.btnGiamDoNhayPolar.Name = "btnGiamDoNhayPolar";
			this.btnGiamDoNhayPolar.Size = new System.Drawing.Size(36, 36);
			this.btnGiamDoNhayPolar.TabIndex = 10;
			this.btnGiamDoNhayPolar.UseVisualStyleBackColor = false;
			this.btnGiamDoNhayPolar.Click += new System.EventHandler(this.btnGiamDoNhayPolar_Click);
			this.btnGiamDoNhayPolar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGiamDoNhayPolar_MouseMove);
			// 
			// btnTangDoNhayPolar
			// 
			this.btnTangDoNhayPolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTangDoNhayPolar.BackColor = System.Drawing.Color.White;
			this.btnTangDoNhayPolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTangDoNhayPolar.Image = global::GraphDrawing.Properties.Resources.polarup;
			this.btnTangDoNhayPolar.Location = new System.Drawing.Point(637, 336);
			this.btnTangDoNhayPolar.Name = "btnTangDoNhayPolar";
			this.btnTangDoNhayPolar.Size = new System.Drawing.Size(36, 36);
			this.btnTangDoNhayPolar.TabIndex = 9;
			this.btnTangDoNhayPolar.UseVisualStyleBackColor = false;
			this.btnTangDoNhayPolar.Click += new System.EventHandler(this.btnTangDoNhayPolar_Click);
			this.btnTangDoNhayPolar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTangDoNhayPolar_MouseMove);
			// 
			// btnLuuDoThi
			// 
			this.btnLuuDoThi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLuuDoThi.BackColor = System.Drawing.Color.White;
			this.btnLuuDoThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLuuDoThi.Image = global::GraphDrawing.Properties.Resources.disk;
			this.btnLuuDoThi.Location = new System.Drawing.Point(637, 0);
			this.btnLuuDoThi.Name = "btnLuuDoThi";
			this.btnLuuDoThi.Size = new System.Drawing.Size(36, 36);
			this.btnLuuDoThi.TabIndex = 1;
			this.btnLuuDoThi.Tag = "";
			this.btnLuuDoThi.UseVisualStyleBackColor = false;
			this.btnLuuDoThi.Click += new System.EventHandler(this.btnLuuDoThi_Click);
			this.btnLuuDoThi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLuuDoThi_MouseMove);
			// 
			// btnRight
			// 
			this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRight.BackColor = System.Drawing.Color.White;
			this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRight.Image = global::GraphDrawing.Properties.Resources.right;
			this.btnRight.Location = new System.Drawing.Point(637, 508);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(36, 36);
			this.btnRight.TabIndex = 13;
			this.btnRight.UseVisualStyleBackColor = false;
			this.btnRight.Click += new System.EventHandler(this.btnSangPhai_Click);
			this.btnRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSangPhai_MouseMove);
			// 
			// btnThuNhoTrucY
			// 
			this.btnThuNhoTrucY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThuNhoTrucY.BackColor = System.Drawing.Color.White;
			this.btnThuNhoTrucY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThuNhoTrucY.Image = global::GraphDrawing.Properties.Resources.ZoomOut_Y;
			this.btnThuNhoTrucY.Location = new System.Drawing.Point(637, 294);
			this.btnThuNhoTrucY.Name = "btnThuNhoTrucY";
			this.btnThuNhoTrucY.Size = new System.Drawing.Size(36, 36);
			this.btnThuNhoTrucY.TabIndex = 8;
			this.btnThuNhoTrucY.UseVisualStyleBackColor = false;
			this.btnThuNhoTrucY.Click += new System.EventHandler(this.btnThuNhoTrucY_Click);
			this.btnThuNhoTrucY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnThuNhoTrucY_MouseMove);
			// 
			// btnSaoChepDoThi
			// 
			this.btnSaoChepDoThi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaoChepDoThi.BackColor = System.Drawing.Color.White;
			this.btnSaoChepDoThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaoChepDoThi.Image = global::GraphDrawing.Properties.Resources.copy;
			this.btnSaoChepDoThi.Location = new System.Drawing.Point(637, 42);
			this.btnSaoChepDoThi.Name = "btnSaoChepDoThi";
			this.btnSaoChepDoThi.Size = new System.Drawing.Size(36, 36);
			this.btnSaoChepDoThi.TabIndex = 2;
			this.btnSaoChepDoThi.UseVisualStyleBackColor = false;
			this.btnSaoChepDoThi.Click += new System.EventHandler(this.btnSaoChepDoThi_Click);
			this.btnSaoChepDoThi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSaoChepDoThi_MouseMove);
			// 
			// btnLeft
			// 
			this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLeft.BackColor = System.Drawing.Color.White;
			this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLeft.Image = global::GraphDrawing.Properties.Resources.left;
			this.btnLeft.Location = new System.Drawing.Point(637, 550);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(36, 36);
			this.btnLeft.TabIndex = 14;
			this.btnLeft.UseVisualStyleBackColor = false;
			this.btnLeft.Click += new System.EventHandler(this.btnSangTrai_Click);
			this.btnLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSangTrai_MouseMove);
			// 
			// btnPhongToTrucY
			// 
			this.btnPhongToTrucY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPhongToTrucY.BackColor = System.Drawing.Color.White;
			this.btnPhongToTrucY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPhongToTrucY.Image = global::GraphDrawing.Properties.Resources.Zoomin_Y;
			this.btnPhongToTrucY.Location = new System.Drawing.Point(637, 252);
			this.btnPhongToTrucY.Name = "btnPhongToTrucY";
			this.btnPhongToTrucY.Size = new System.Drawing.Size(36, 36);
			this.btnPhongToTrucY.TabIndex = 7;
			this.btnPhongToTrucY.UseVisualStyleBackColor = false;
			this.btnPhongToTrucY.Click += new System.EventHandler(this.btnPhongToTrucY_Click);
			this.btnPhongToTrucY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPhongToTrucY_MouseMove);
			// 
			// btnThuNhoTrucX
			// 
			this.btnThuNhoTrucX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThuNhoTrucX.BackColor = System.Drawing.Color.White;
			this.btnThuNhoTrucX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThuNhoTrucX.Image = global::GraphDrawing.Properties.Resources.ZoomOut_X;
			this.btnThuNhoTrucX.Location = new System.Drawing.Point(637, 210);
			this.btnThuNhoTrucX.Name = "btnThuNhoTrucX";
			this.btnThuNhoTrucX.Size = new System.Drawing.Size(36, 36);
			this.btnThuNhoTrucX.TabIndex = 6;
			this.btnThuNhoTrucX.UseVisualStyleBackColor = false;
			this.btnThuNhoTrucX.Click += new System.EventHandler(this.btnThuNhoTrucX_Click);
			this.btnThuNhoTrucX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnThuNhoTrucX_MouseMove);
			// 
			// btnPhongToTrucX
			// 
			this.btnPhongToTrucX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPhongToTrucX.BackColor = System.Drawing.Color.White;
			this.btnPhongToTrucX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPhongToTrucX.Image = global::GraphDrawing.Properties.Resources.ZoomIn_X;
			this.btnPhongToTrucX.Location = new System.Drawing.Point(637, 168);
			this.btnPhongToTrucX.Name = "btnPhongToTrucX";
			this.btnPhongToTrucX.Size = new System.Drawing.Size(36, 36);
			this.btnPhongToTrucX.TabIndex = 5;
			this.btnPhongToTrucX.UseVisualStyleBackColor = false;
			this.btnPhongToTrucX.Click += new System.EventHandler(this.btnPhongToTrucX_Click);
			this.btnPhongToTrucX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPhongToTrucX_MouseMove);
			// 
			// btnThuNho
			// 
			this.btnThuNho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThuNho.BackColor = System.Drawing.Color.White;
			this.btnThuNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThuNho.Image = global::GraphDrawing.Properties.Resources.Zoomout;
			this.btnThuNho.Location = new System.Drawing.Point(637, 126);
			this.btnThuNho.Name = "btnThuNho";
			this.btnThuNho.Size = new System.Drawing.Size(36, 36);
			this.btnThuNho.TabIndex = 4;
			this.btnThuNho.UseVisualStyleBackColor = false;
			this.btnThuNho.Click += new System.EventHandler(this.btnThuNho_Click);
			this.btnThuNho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnThuNho_MouseMove);
			// 
			// btnPhongTo
			// 
			this.btnPhongTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPhongTo.BackColor = System.Drawing.Color.White;
			this.btnPhongTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPhongTo.Image = global::GraphDrawing.Properties.Resources.Zoomin;
			this.btnPhongTo.Location = new System.Drawing.Point(637, 84);
			this.btnPhongTo.Name = "btnPhongTo";
			this.btnPhongTo.Size = new System.Drawing.Size(36, 36);
			this.btnPhongTo.TabIndex = 3;
			this.btnPhongTo.UseVisualStyleBackColor = false;
			this.btnPhongTo.Click += new System.EventHandler(this.btnPhongTo_Click);
			this.btnPhongTo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPhongTo_MouseMove);
			// 
			// btnDown
			// 
			this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDown.BackColor = System.Drawing.Color.White;
			this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDown.Image = global::GraphDrawing.Properties.Resources.down;
			this.btnDown.Location = new System.Drawing.Point(637, 468);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(36, 36);
			this.btnDown.TabIndex = 12;
			this.btnDown.UseVisualStyleBackColor = false;
			this.btnDown.Click += new System.EventHandler(this.btnXuongDuoi_Click);
			this.btnDown.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnXuongDuoi_MouseMove);
			// 
			// btnUp
			// 
			this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUp.BackColor = System.Drawing.Color.White;
			this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUp.Image = global::GraphDrawing.Properties.Resources.up;
			this.btnUp.Location = new System.Drawing.Point(637, 426);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(36, 36);
			this.btnUp.TabIndex = 11;
			this.btnUp.UseVisualStyleBackColor = false;
			this.btnUp.Click += new System.EventHandler(this.btnLenTren_Click);
			this.btnUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLenTren_MouseMove);
			// 
			// menuExitAll
			// 
			this.menuExitAll.Name = "menuExitAll";
			this.menuExitAll.Size = new System.Drawing.Size(239, 22);
			this.menuExitAll.Text = "Thoát khỏi chương trình";
			this.menuExitAll.Click += new System.EventHandler(this.thoátHếtMenu_Click);
			// 
			// expPlotter
			// 
			this.expPlotter.ContextMenuStrip = this.contextMenuPlotter;
			this.expPlotter.DisplayText = true;
			this.expPlotter.DivisionsX = 8;
			this.expPlotter.DivisionsY = 8;
			this.expPlotter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.expPlotter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.expPlotter.ForwardX = 0D;
			this.expPlotter.ForwardY = 0D;
			this.expPlotter.GraphMode = GraphDrawing.GraphMode.Rectangular;
			this.expPlotter.Grids = false;
			this.expPlotter.Location = new System.Drawing.Point(0, 0);
			this.expPlotter.Name = "expPlotter";
			this.expPlotter.PenWidth = 1;
			this.expPlotter.PolarSensitivity = 100;
			this.expPlotter.PrintStepX = 1;
			this.expPlotter.PrintStepY = 1;
			this.expPlotter.ScaleX = 8D;
			this.expPlotter.ScaleY = 8D;
			this.expPlotter.Size = new System.Drawing.Size(685, 599);
			this.expPlotter.TabIndex = 0;
			this.expPlotter.Text = "Đồ thị";
			this.expPlotter.Click += new System.EventHandler(this.expPlotter_Click);
			this.expPlotter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.expPlotter_MouseMove);
			// 
			// DoThi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(685, 599);
			this.Controls.Add(this.btnGiamDoNhayPolar);
			this.Controls.Add(this.btnTangDoNhayPolar);
			this.Controls.Add(this.btnLuuDoThi);
			this.Controls.Add(this.btnRight);
			this.Controls.Add(this.btnThuNhoTrucY);
			this.Controls.Add(this.btnSaoChepDoThi);
			this.Controls.Add(this.lblChuThich);
			this.Controls.Add(this.btnLeft);
			this.Controls.Add(this.btnPhongToTrucY);
			this.Controls.Add(this.btnThuNhoTrucX);
			this.Controls.Add(this.btnPhongToTrucX);
			this.Controls.Add(this.btnThuNho);
			this.Controls.Add(this.btnPhongTo);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.lblSensitivity);
			this.Controls.Add(this.lblPosition);
			this.Controls.Add(this.expPlotter);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "DoThi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Graph";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.DoThi_Load);
			this.Resize += new System.EventHandler(this.DoThi_Resize);
			this.contextMenuPlotter.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblPosition;
		private System.Windows.Forms.Label lblSensitivity;
		private System.Windows.Forms.ContextMenuStrip contextMenuPlotter;
		private System.Windows.Forms.ToolStripMenuItem menuCartesianMode;
		private System.Windows.Forms.ToolStripMenuItem menuPolarMode;
		private System.Windows.Forms.ToolStripMenuItem menuShowGrid;
		private System.Windows.Forms.ToolStripMenuItem menuShowExpression;
		private System.Windows.Forms.ToolStripMenuItem menuExit;
		private System.Windows.Forms.ToolStripMenuItem menuExitAll;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Button btnUp;
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
		private System.Windows.Forms.ToolStripMenuItem menuChangeGraph;
		private System.Windows.Forms.ToolStripMenuItem menuValueTable;
		public ExpressionPlotter expPlotter;
	}
}