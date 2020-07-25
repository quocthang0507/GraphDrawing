namespace GraphDrawing
{
	partial class ThayDoiDoThi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThayDoiDoThi));
			this.clbExpressions = new System.Windows.Forms.CheckedListBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// clbExpressions
			// 
			this.clbExpressions.FormattingEnabled = true;
			this.clbExpressions.Location = new System.Drawing.Point(16, 15);
			this.clbExpressions.Margin = new System.Windows.Forms.Padding(4);
			this.clbExpressions.Name = "clbExpressions";
			this.clbExpressions.Size = new System.Drawing.Size(277, 157);
			this.clbExpressions.TabIndex = 0;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(303, 15);
			this.btnOK.Margin = new System.Windows.Forms.Padding(4);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(100, 33);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "Đồng ý";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(303, 55);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(100, 33);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Đóng";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// ThayDoiDoThi
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(417, 182);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.clbExpressions);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ThayDoiDoThi";
			this.Text = "Thay đổi đồ thị";
			this.Load += new System.EventHandler(this.ThayDoiDoThi_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckedListBox clbExpressions;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnExit;
	}
}