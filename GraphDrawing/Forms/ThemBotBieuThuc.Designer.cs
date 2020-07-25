namespace GraphDrawing
{
	partial class ThemBotBieuThuc
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemBotBieuThuc));
			clbExpression = new System.Windows.Forms.CheckedListBox();
			btnDongY = new System.Windows.Forms.Button();
			btnXoa = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// clbExpression
			// 
			clbExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point((byte)(0)));
			clbExpression.FormattingEnabled = true;
			clbExpression.Location = new System.Drawing.Point(12, 12);
			clbExpression.Name = "clbExpression";
			clbExpression.Size = new System.Drawing.Size(209, 123);
			clbExpression.TabIndex = 0;
			clbExpression.SelectedIndexChanged += new System.EventHandler(checkedListBox1_SelectedIndexChanged);
			// 
			// btnDongY
			// 
			btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point((byte)(0)));
			btnDongY.Location = new System.Drawing.Point(227, 12);
			btnDongY.Name = "btnDongY";
			btnDongY.Size = new System.Drawing.Size(75, 27);
			btnDongY.TabIndex = 1;
			btnDongY.Text = "Đồng ý";
			btnDongY.UseVisualStyleBackColor = true;
			btnDongY.Click += new System.EventHandler(btnDongY_Click);
			// 
			// btnXoa
			// 
			btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point((byte)(0)));
			btnXoa.Location = new System.Drawing.Point(227, 45);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new System.Drawing.Size(75, 27);
			btnXoa.TabIndex = 2;
			btnXoa.Text = "Đóng";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += new System.EventHandler(btnXoa_Click);
			// 
			// ThemBotBieuThuc
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(313, 148);
			Controls.Add(btnXoa);
			Controls.Add(btnDongY);
			Controls.Add(clbExpression);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
			Name = "ThemBotBieuThuc";
			Text = "Them Bot Bieu Thuc";
			Load += new System.EventHandler(ThemBotBieuThuc_Load);
			ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckedListBox clbExpression;
		private System.Windows.Forms.Button btnDongY;
		private System.Windows.Forms.Button btnXoa;
	}
}