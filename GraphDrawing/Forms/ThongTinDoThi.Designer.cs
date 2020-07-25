namespace GraphDrawing
{
	partial class ThongTinDoThi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinDoThi));
			cbBieuThuc = new System.Windows.Forms.ComboBox();
			btnXem = new System.Windows.Forms.Button();
			lvXAndFX = new System.Windows.Forms.ListView();
			chX = new System.Windows.Forms.ColumnHeader();
			chFX = new System.Windows.Forms.ColumnHeader();
			btnDong = new System.Windows.Forms.Button();
			rbDo = new System.Windows.Forms.RadioButton();
			groupBox1 = new System.Windows.Forms.GroupBox();
			rbRadian = new System.Windows.Forms.RadioButton();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// cbBieuThuc
			// 
			cbBieuThuc.FormattingEnabled = true;
			cbBieuThuc.Location = new System.Drawing.Point(16, 13);
			cbBieuThuc.Margin = new System.Windows.Forms.Padding(4);
			cbBieuThuc.Name = "cbBieuThuc";
			cbBieuThuc.Size = new System.Drawing.Size(291, 24);
			cbBieuThuc.TabIndex = 0;
			// 
			// btnXem
			// 
			btnXem.Location = new System.Drawing.Point(315, 13);
			btnXem.Margin = new System.Windows.Forms.Padding(4);
			btnXem.Name = "btnXem";
			btnXem.Size = new System.Drawing.Size(81, 24);
			btnXem.TabIndex = 1;
			btnXem.Text = "Xem";
			btnXem.UseVisualStyleBackColor = true;
			btnXem.Click += new System.EventHandler(btnXem_Click);
			// 
			// lvXAndFX
			// 
			lvXAndFX.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			chX,
			chFX});
			lvXAndFX.FullRowSelect = true;
			lvXAndFX.GridLines = true;
			lvXAndFX.Location = new System.Drawing.Point(16, 45);
			lvXAndFX.Margin = new System.Windows.Forms.Padding(4);
			lvXAndFX.Name = "lvXAndFX";
			lvXAndFX.Size = new System.Drawing.Size(291, 183);
			lvXAndFX.TabIndex = 2;
			lvXAndFX.UseCompatibleStateImageBehavior = false;
			lvXAndFX.View = System.Windows.Forms.View.Details;
			// 
			// chX
			// 
			chX.Text = "x";
			chX.Width = 94;
			// 
			// chFX
			// 
			chFX.Text = "f(x)";
			chFX.Width = 189;
			// 
			// btnDong
			// 
			btnDong.Location = new System.Drawing.Point(315, 45);
			btnDong.Margin = new System.Windows.Forms.Padding(4);
			btnDong.Name = "btnDong";
			btnDong.Size = new System.Drawing.Size(81, 25);
			btnDong.TabIndex = 3;
			btnDong.Text = "Đóng";
			btnDong.UseVisualStyleBackColor = true;
			btnDong.Click += new System.EventHandler(btnDong_Click);
			// 
			// rbDo
			// 
			rbDo.AutoSize = true;
			rbDo.Location = new System.Drawing.Point(6, 21);
			rbDo.Name = "rbDo";
			rbDo.Size = new System.Drawing.Size(43, 20);
			rbDo.TabIndex = 4;
			rbDo.TabStop = true;
			rbDo.Text = "Độ";
			rbDo.UseVisualStyleBackColor = true;
			rbDo.CheckedChanged += new System.EventHandler(rbDo_CheckedChanged);
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(rbRadian);
			groupBox1.Controls.Add(rbDo);
			groupBox1.Location = new System.Drawing.Point(315, 78);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(81, 150);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			// 
			// rbRadian
			// 
			rbRadian.AutoSize = true;
			rbRadian.Location = new System.Drawing.Point(6, 47);
			rbRadian.Name = "rbRadian";
			rbRadian.Size = new System.Drawing.Size(70, 20);
			rbRadian.TabIndex = 5;
			rbRadian.TabStop = true;
			rbRadian.Text = "Radian";
			rbRadian.UseVisualStyleBackColor = true;
			rbRadian.CheckedChanged += new System.EventHandler(rbRadian_CheckedChanged);
			// 
			// ThongTinDoThi
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(409, 247);
			Controls.Add(groupBox1);
			Controls.Add(btnDong);
			Controls.Add(lvXAndFX);
			Controls.Add(btnXem);
			Controls.Add(cbBieuThuc);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point((byte)(0)));
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
			Margin = new System.Windows.Forms.Padding(4);
			MaximizeBox = false;
			Name = "ThongTinDoThi";
			Text = "Thong Tin Do Thi";
			Load += new System.EventHandler(ThongTinDoThi_Load);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbBieuThuc;
		private System.Windows.Forms.Button btnXem;
		private System.Windows.Forms.ListView lvXAndFX;
		private System.Windows.Forms.Button btnDong;
		private System.Windows.Forms.ColumnHeader chX;
		private System.Windows.Forms.ColumnHeader chFX;
		private System.Windows.Forms.RadioButton rbDo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbRadian;
	}
}