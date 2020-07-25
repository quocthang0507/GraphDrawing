namespace GraphDrawing
{
	partial class BangGiaTri
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangGiaTri));
			this.cbxExpressions = new System.Windows.Forms.ComboBox();
			this.btnView = new System.Windows.Forms.Button();
			this.lstValues = new System.Windows.Forms.ListView();
			this.chX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chFX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnExit = new System.Windows.Forms.Button();
			this.rdbDegree = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbRadian = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbxExpressions
			// 
			this.cbxExpressions.FormattingEnabled = true;
			this.cbxExpressions.Location = new System.Drawing.Point(16, 14);
			this.cbxExpressions.Margin = new System.Windows.Forms.Padding(4);
			this.cbxExpressions.Name = "cbxExpressions";
			this.cbxExpressions.Size = new System.Drawing.Size(291, 24);
			this.cbxExpressions.TabIndex = 0;
			// 
			// btnView
			// 
			this.btnView.Location = new System.Drawing.Point(315, 14);
			this.btnView.Margin = new System.Windows.Forms.Padding(4);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(81, 25);
			this.btnView.TabIndex = 1;
			this.btnView.Text = "Xem";
			this.btnView.UseVisualStyleBackColor = true;
			this.btnView.Click += new System.EventHandler(this.btnXem_Click);
			// 
			// lstValues
			// 
			this.lstValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chX,
            this.chFX});
			this.lstValues.FullRowSelect = true;
			this.lstValues.GridLines = true;
			this.lstValues.HideSelection = false;
			this.lstValues.Location = new System.Drawing.Point(16, 46);
			this.lstValues.Margin = new System.Windows.Forms.Padding(4);
			this.lstValues.Name = "lstValues";
			this.lstValues.Size = new System.Drawing.Size(291, 182);
			this.lstValues.TabIndex = 2;
			this.lstValues.UseCompatibleStateImageBehavior = false;
			this.lstValues.View = System.Windows.Forms.View.Details;
			// 
			// chX
			// 
			this.chX.Text = "x";
			this.chX.Width = 94;
			// 
			// chFX
			// 
			this.chFX.Text = "f(x)";
			this.chFX.Width = 189;
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(315, 46);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(81, 25);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// rdbDegree
			// 
			this.rdbDegree.AutoSize = true;
			this.rdbDegree.Location = new System.Drawing.Point(5, 21);
			this.rdbDegree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdbDegree.Name = "rdbDegree";
			this.rdbDegree.Size = new System.Drawing.Size(43, 20);
			this.rdbDegree.TabIndex = 4;
			this.rdbDegree.TabStop = true;
			this.rdbDegree.Text = "Độ";
			this.rdbDegree.UseVisualStyleBackColor = true;
			this.rdbDegree.CheckedChanged += new System.EventHandler(this.rbDo_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbRadian);
			this.groupBox1.Controls.Add(this.rdbDegree);
			this.groupBox1.Location = new System.Drawing.Point(315, 78);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(81, 86);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// rdbRadian
			// 
			this.rdbRadian.AutoSize = true;
			this.rdbRadian.Location = new System.Drawing.Point(5, 47);
			this.rdbRadian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdbRadian.Name = "rdbRadian";
			this.rdbRadian.Size = new System.Drawing.Size(70, 20);
			this.rdbRadian.TabIndex = 5;
			this.rdbRadian.TabStop = true;
			this.rdbRadian.Text = "Radian";
			this.rdbRadian.UseVisualStyleBackColor = true;
			this.rdbRadian.CheckedChanged += new System.EventHandler(this.rbRadian_CheckedChanged);
			// 
			// BangGiaTri
			// 
			this.AcceptButton = this.btnView;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(409, 247);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.lstValues);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.cbxExpressions);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "BangGiaTri";
			this.Text = "Bảng giá trị";
			this.Load += new System.EventHandler(this.BangGiaTri_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxExpressions;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.ListView lstValues;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ColumnHeader chX;
		private System.Windows.Forms.ColumnHeader chFX;
		private System.Windows.Forms.RadioButton rdbDegree;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdbRadian;
	}
}