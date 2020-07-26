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
			this.menuExitAll = new System.Windows.Forms.ToolStripMenuItem();
			this.lblChuThich = new System.Windows.Forms.Label();
			this.expPlotter = new GraphDrawing.ExpressionPlotter();
			this.btnDecPolar = new System.Windows.Forms.Button();
			this.btnIncPolar = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.btnZoomOutY = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btnZoonInY = new System.Windows.Forms.Button();
			this.btnZoomOutX = new System.Windows.Forms.Button();
			this.btnZoomInX = new System.Windows.Forms.Button();
			this.btnZoomOut = new System.Windows.Forms.Button();
			this.btnZoomIn = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
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
			this.lblSensitivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSensitivity.ForeColor = System.Drawing.Color.Red;
			this.lblSensitivity.Location = new System.Drawing.Point(488, 9);
			this.lblSensitivity.Name = "lblSensitivity";
			this.lblSensitivity.Size = new System.Drawing.Size(94, 16);
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
			this.contextMenuPlotter.Size = new System.Drawing.Size(240, 180);
			// 
			// menuCartesianMode
			// 
			this.menuCartesianMode.Name = "menuCartesianMode";
			this.menuCartesianMode.Size = new System.Drawing.Size(239, 22);
			this.menuCartesianMode.Text = "Hệ tọa độ Descartes (Cartesian)";
			this.menuCartesianMode.Click += new System.EventHandler(this.cartesianModeMenu_Click);
			// 
			// menuPolarMode
			// 
			this.menuPolarMode.Name = "menuPolarMode";
			this.menuPolarMode.Size = new System.Drawing.Size(239, 22);
			this.menuPolarMode.Text = "Hệ tọa độ cực (Polar)";
			this.menuPolarMode.Click += new System.EventHandler(this.polarModeMenu_Click);
			// 
			// menuShowGrid
			// 
			this.menuShowGrid.Name = "menuShowGrid";
			this.menuShowGrid.Size = new System.Drawing.Size(239, 22);
			this.menuShowGrid.Text = "Hiển thị lưới";
			this.menuShowGrid.Click += new System.EventHandler(this.showGridMenu_Click);
			// 
			// menuShowExpression
			// 
			this.menuShowExpression.Name = "menuShowExpression";
			this.menuShowExpression.Size = new System.Drawing.Size(239, 22);
			this.menuShowExpression.Text = "Hiển thị biểu thức";
			this.menuShowExpression.Click += new System.EventHandler(this.showExpMenu_Click);
			// 
			// menuChangeGraph
			// 
			this.menuChangeGraph.Name = "menuChangeGraph";
			this.menuChangeGraph.Size = new System.Drawing.Size(239, 22);
			this.menuChangeGraph.Text = "Thay đổi đồ thị trên màn hình";
			this.menuChangeGraph.Click += new System.EventHandler(this.ChangeGraphMenu_Click);
			// 
			// menuValueTable
			// 
			this.menuValueTable.Name = "menuValueTable";
			this.menuValueTable.Size = new System.Drawing.Size(239, 22);
			this.menuValueTable.Text = "Bảng giá trị";
			this.menuValueTable.Click += new System.EventHandler(this.ShowValueTableMenu_Click);
			// 
			// menuExit
			// 
			this.menuExit.Name = "menuExit";
			this.menuExit.Size = new System.Drawing.Size(239, 22);
			this.menuExit.Text = "Thoát";
			this.menuExit.Click += new System.EventHandler(this.thoátMenu_Click);
			// 
			// menuExitAll
			// 
			this.menuExitAll.Name = "menuExitAll";
			this.menuExitAll.Size = new System.Drawing.Size(239, 22);
			this.menuExitAll.Text = "Thoát khỏi chương trình";
			this.menuExitAll.Click += new System.EventHandler(this.thoátHếtMenu_Click);
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
			// btnDecPolar
			// 
			this.btnDecPolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDecPolar.BackColor = System.Drawing.Color.White;
			this.btnDecPolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDecPolar.Image = global::GraphDrawing.Properties.Resources.polarDown;
			this.btnDecPolar.Location = new System.Drawing.Point(639, 350);
			this.btnDecPolar.Name = "btnDecPolar";
			this.btnDecPolar.Size = new System.Drawing.Size(36, 36);
			this.btnDecPolar.TabIndex = 10;
			this.btnDecPolar.UseVisualStyleBackColor = false;
			this.btnDecPolar.Click += new System.EventHandler(this.btnDecPolar_Click);
			this.btnDecPolar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDecPolar_MouseMove);
			// 
			// btnIncPolar
			// 
			this.btnIncPolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnIncPolar.BackColor = System.Drawing.Color.White;
			this.btnIncPolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIncPolar.Image = global::GraphDrawing.Properties.Resources.polarup;
			this.btnIncPolar.Location = new System.Drawing.Point(639, 313);
			this.btnIncPolar.Name = "btnIncPolar";
			this.btnIncPolar.Size = new System.Drawing.Size(36, 36);
			this.btnIncPolar.TabIndex = 9;
			this.btnIncPolar.UseVisualStyleBackColor = false;
			this.btnIncPolar.Click += new System.EventHandler(this.btnIncPolar_Click);
			this.btnIncPolar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnIncPolar_MouseMove);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = global::GraphDrawing.Properties.Resources.disk;
			this.btnSave.Location = new System.Drawing.Point(639, 17);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(36, 36);
			this.btnSave.TabIndex = 1;
			this.btnSave.Tag = "";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnSave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSave_MouseMove);
			// 
			// btnRight
			// 
			this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRight.BackColor = System.Drawing.Color.White;
			this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRight.Image = global::GraphDrawing.Properties.Resources.right;
			this.btnRight.Location = new System.Drawing.Point(639, 464);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(36, 36);
			this.btnRight.TabIndex = 13;
			this.btnRight.UseVisualStyleBackColor = false;
			this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
			this.btnRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseMove);
			// 
			// btnZoomOutY
			// 
			this.btnZoomOutY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnZoomOutY.BackColor = System.Drawing.Color.White;
			this.btnZoomOutY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnZoomOutY.Image = global::GraphDrawing.Properties.Resources.ZoomOut_Y;
			this.btnZoomOutY.Location = new System.Drawing.Point(639, 276);
			this.btnZoomOutY.Name = "btnZoomOutY";
			this.btnZoomOutY.Size = new System.Drawing.Size(36, 36);
			this.btnZoomOutY.TabIndex = 8;
			this.btnZoomOutY.UseVisualStyleBackColor = false;
			this.btnZoomOutY.Click += new System.EventHandler(this.btnZoomOutY_Click);
			this.btnZoomOutY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnZoomOutY_MouseMove);
			// 
			// btnCopy
			// 
			this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopy.BackColor = System.Drawing.Color.White;
			this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCopy.Image = global::GraphDrawing.Properties.Resources.copy;
			this.btnCopy.Location = new System.Drawing.Point(639, 54);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(36, 36);
			this.btnCopy.TabIndex = 2;
			this.btnCopy.UseVisualStyleBackColor = false;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			this.btnCopy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCopy_MouseMove);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.BackColor = System.Drawing.Color.White;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Image = global::GraphDrawing.Properties.Resources.exit;
			this.btnExit.Location = new System.Drawing.Point(639, 559);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(36, 36);
			this.btnExit.TabIndex = 14;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseMove);
			// 
			// btnLeft
			// 
			this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLeft.BackColor = System.Drawing.Color.White;
			this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLeft.Image = global::GraphDrawing.Properties.Resources.left;
			this.btnLeft.Location = new System.Drawing.Point(639, 501);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(36, 36);
			this.btnLeft.TabIndex = 14;
			this.btnLeft.UseVisualStyleBackColor = false;
			this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
			this.btnLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseMove);
			// 
			// btnZoonInY
			// 
			this.btnZoonInY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnZoonInY.BackColor = System.Drawing.Color.White;
			this.btnZoonInY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnZoonInY.Image = global::GraphDrawing.Properties.Resources.Zoomin_Y;
			this.btnZoonInY.Location = new System.Drawing.Point(639, 239);
			this.btnZoonInY.Name = "btnZoonInY";
			this.btnZoonInY.Size = new System.Drawing.Size(36, 36);
			this.btnZoonInY.TabIndex = 7;
			this.btnZoonInY.UseVisualStyleBackColor = false;
			this.btnZoonInY.Click += new System.EventHandler(this.btnZoomInY_Click);
			this.btnZoonInY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnZoomInY_MouseMove);
			// 
			// btnZoomOutX
			// 
			this.btnZoomOutX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnZoomOutX.BackColor = System.Drawing.Color.White;
			this.btnZoomOutX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnZoomOutX.Image = global::GraphDrawing.Properties.Resources.ZoomOut_X;
			this.btnZoomOutX.Location = new System.Drawing.Point(639, 202);
			this.btnZoomOutX.Name = "btnZoomOutX";
			this.btnZoomOutX.Size = new System.Drawing.Size(36, 36);
			this.btnZoomOutX.TabIndex = 6;
			this.btnZoomOutX.UseVisualStyleBackColor = false;
			this.btnZoomOutX.Click += new System.EventHandler(this.btnZoomOutX_Click);
			this.btnZoomOutX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnZoomOutX_MouseMove);
			// 
			// btnZoomInX
			// 
			this.btnZoomInX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnZoomInX.BackColor = System.Drawing.Color.White;
			this.btnZoomInX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnZoomInX.Image = global::GraphDrawing.Properties.Resources.ZoomIn_X;
			this.btnZoomInX.Location = new System.Drawing.Point(639, 165);
			this.btnZoomInX.Name = "btnZoomInX";
			this.btnZoomInX.Size = new System.Drawing.Size(36, 36);
			this.btnZoomInX.TabIndex = 5;
			this.btnZoomInX.UseVisualStyleBackColor = false;
			this.btnZoomInX.Click += new System.EventHandler(this.btnZoomInX_Click);
			this.btnZoomInX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnZoomInX_MouseMove);
			// 
			// btnZoomOut
			// 
			this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnZoomOut.BackColor = System.Drawing.Color.White;
			this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnZoomOut.Image = global::GraphDrawing.Properties.Resources.Zoomout;
			this.btnZoomOut.Location = new System.Drawing.Point(639, 128);
			this.btnZoomOut.Name = "btnZoomOut";
			this.btnZoomOut.Size = new System.Drawing.Size(36, 36);
			this.btnZoomOut.TabIndex = 4;
			this.btnZoomOut.UseVisualStyleBackColor = false;
			this.btnZoomOut.Click += new System.EventHandler(this.btnOut_Click);
			this.btnZoomOut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnZoomOut_MouseMove);
			// 
			// btnZoomIn
			// 
			this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnZoomIn.BackColor = System.Drawing.Color.White;
			this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnZoomIn.Image = global::GraphDrawing.Properties.Resources.Zoomin;
			this.btnZoomIn.Location = new System.Drawing.Point(639, 91);
			this.btnZoomIn.Name = "btnZoomIn";
			this.btnZoomIn.Size = new System.Drawing.Size(36, 36);
			this.btnZoomIn.TabIndex = 3;
			this.btnZoomIn.UseVisualStyleBackColor = false;
			this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
			this.btnZoomIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnZoomIn_MouseMove);
			// 
			// btnDown
			// 
			this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDown.BackColor = System.Drawing.Color.White;
			this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDown.Image = global::GraphDrawing.Properties.Resources.down;
			this.btnDown.Location = new System.Drawing.Point(639, 426);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(36, 36);
			this.btnDown.TabIndex = 12;
			this.btnDown.UseVisualStyleBackColor = false;
			this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
			this.btnDown.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseMove);
			// 
			// btnUp
			// 
			this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUp.BackColor = System.Drawing.Color.White;
			this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUp.Image = global::GraphDrawing.Properties.Resources.up;
			this.btnUp.Location = new System.Drawing.Point(639, 388);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(36, 36);
			this.btnUp.TabIndex = 11;
			this.btnUp.UseVisualStyleBackColor = false;
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
			this.btnUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseMove);
			// 
			// DoThi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(685, 599);
			this.Controls.Add(this.btnDecPolar);
			this.Controls.Add(this.btnIncPolar);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnRight);
			this.Controls.Add(this.btnZoomOutY);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.lblChuThich);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnLeft);
			this.Controls.Add(this.btnZoonInY);
			this.Controls.Add(this.btnZoomOutX);
			this.Controls.Add(this.btnZoomInX);
			this.Controls.Add(this.btnZoomOut);
			this.Controls.Add(this.btnZoomIn);
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
		private System.Windows.Forms.Button btnZoomIn;
		private System.Windows.Forms.Button btnZoomOut;
		private System.Windows.Forms.Button btnZoomInX;
		private System.Windows.Forms.Button btnZoomOutX;
		private System.Windows.Forms.Button btnZoonInY;
		private System.Windows.Forms.Button btnZoomOutY;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnIncPolar;
		private System.Windows.Forms.Button btnDecPolar;
		private System.Windows.Forms.Label lblChuThich;
		private System.Windows.Forms.ToolStripMenuItem menuChangeGraph;
		private System.Windows.Forms.ToolStripMenuItem menuValueTable;
		public ExpressionPlotter expPlotter;
		private System.Windows.Forms.Button btnExit;
	}
}