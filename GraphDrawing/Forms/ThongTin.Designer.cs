namespace GraphDrawing
{
    partial class ThongTin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTin));
			this.lstExpressions = new System.Windows.Forms.ListBox();
			this.txtExpression = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnDraw = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.nudStartX = new System.Windows.Forms.NumericUpDown();
			this.nudEndX = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.nudEndY = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.nudStartY = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.axisRatio = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.nudSensitive = new System.Windows.Forms.NumericUpDown();
			this.cbxMode = new System.Windows.Forms.ComboBox();
			this.nudWidthStroke = new System.Windows.Forms.NumericUpDown();
			this.label12 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MenuFuncs = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuOprs = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.tácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.nudStartX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEndX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEndY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudStartY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axisRatio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSensitive)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWidthStroke)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstExpressions
			// 
			this.lstExpressions.FormattingEnabled = true;
			this.lstExpressions.HorizontalScrollbar = true;
			this.lstExpressions.ItemHeight = 16;
			this.lstExpressions.Location = new System.Drawing.Point(17, 113);
			this.lstExpressions.Margin = new System.Windows.Forms.Padding(4);
			this.lstExpressions.Name = "lstExpressions";
			this.lstExpressions.Size = new System.Drawing.Size(447, 116);
			this.lstExpressions.TabIndex = 3;
			this.lstExpressions.SelectedIndexChanged += new System.EventHandler(this.lstExpressions_SelectedIndexChanged);
			// 
			// txtExpression
			// 
			this.txtExpression.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.txtExpression.Location = new System.Drawing.Point(17, 55);
			this.txtExpression.Margin = new System.Windows.Forms.Padding(4);
			this.txtExpression.MaxLength = 1000;
			this.txtExpression.Multiline = false;
			this.txtExpression.Name = "txtExpression";
			this.txtExpression.Size = new System.Drawing.Size(345, 22);
			this.txtExpression.TabIndex = 1;
			this.txtExpression.Text = "";
			this.txtExpression.TextChanged += new System.EventHandler(this.txtExpression_TextChanged);
			this.txtExpression.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpression_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 36);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nhập biểu thức vào đây";
			// 
			// btnAdd
			// 
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAdd.Location = new System.Drawing.Point(372, 52);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(81, 27);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 93);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Danh sách biểu thức";
			// 
			// btnClear
			// 
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Location = new System.Drawing.Point(248, 247);
			this.btnClear.Margin = new System.Windows.Forms.Padding(4);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(135, 27);
			this.btnClear.TabIndex = 5;
			this.btnClear.Text = "Xóa danh sách";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemove.Location = new System.Drawing.Point(67, 247);
			this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(166, 27);
			this.btnRemove.TabIndex = 4;
			this.btnRemove.Text = "Xóa biểu thức đang chọn";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnDraw
			// 
			this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDraw.Location = new System.Drawing.Point(181, 465);
			this.btnDraw.Margin = new System.Windows.Forms.Padding(4);
			this.btnDraw.Name = "btnDraw";
			this.btnDraw.Size = new System.Drawing.Size(104, 27);
			this.btnDraw.TabIndex = 14;
			this.btnDraw.Text = "Vẽ đồ thị!";
			this.btnDraw.UseVisualStyleBackColor = true;
			this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 293);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Điểm bắt đầu trục X";
			// 
			// nudStartX
			// 
			this.nudStartX.DecimalPlaces = 2;
			this.nudStartX.Location = new System.Drawing.Point(161, 294);
			this.nudStartX.Margin = new System.Windows.Forms.Padding(4);
			this.nudStartX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudStartX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.nudStartX.Name = "nudStartX";
			this.nudStartX.Size = new System.Drawing.Size(81, 22);
			this.nudStartX.TabIndex = 6;
			this.nudStartX.Value = new decimal(new int[] {
            8,
            0,
            0,
            -2147483648});
			// 
			// nudEndX
			// 
			this.nudEndX.DecimalPlaces = 2;
			this.nudEndX.Location = new System.Drawing.Point(386, 292);
			this.nudEndX.Margin = new System.Windows.Forms.Padding(4);
			this.nudEndX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudEndX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.nudEndX.Name = "nudEndX";
			this.nudEndX.Size = new System.Drawing.Size(81, 22);
			this.nudEndX.TabIndex = 7;
			this.nudEndX.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(260, 293);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "Điểm kết thúc trục X";
			// 
			// nudEndY
			// 
			this.nudEndY.DecimalPlaces = 2;
			this.nudEndY.Location = new System.Drawing.Point(386, 323);
			this.nudEndY.Margin = new System.Windows.Forms.Padding(4);
			this.nudEndY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudEndY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.nudEndY.Name = "nudEndY";
			this.nudEndY.Size = new System.Drawing.Size(81, 22);
			this.nudEndY.TabIndex = 9;
			this.nudEndY.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(260, 324);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 16);
			this.label5.TabIndex = 15;
			this.label5.Text = "Điểm kết thúc trục Y";
			// 
			// nudStartY
			// 
			this.nudStartY.DecimalPlaces = 2;
			this.nudStartY.Location = new System.Drawing.Point(161, 325);
			this.nudStartY.Margin = new System.Windows.Forms.Padding(4);
			this.nudStartY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudStartY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.nudStartY.Name = "nudStartY";
			this.nudStartY.Size = new System.Drawing.Size(81, 22);
			this.nudStartY.TabIndex = 8;
			this.nudStartY.Value = new decimal(new int[] {
            8,
            0,
            0,
            -2147483648});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 324);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(123, 16);
			this.label6.TabIndex = 13;
			this.label6.Text = "Điểm bắt đầu trục Y";
			// 
			// axisRatio
			// 
			this.axisRatio.Location = new System.Drawing.Point(161, 355);
			this.axisRatio.Margin = new System.Windows.Forms.Padding(4);
			this.axisRatio.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.axisRatio.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.axisRatio.Name = "axisRatio";
			this.axisRatio.Size = new System.Drawing.Size(81, 22);
			this.axisRatio.TabIndex = 10;
			this.axisRatio.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(13, 354);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(137, 16);
			this.label8.TabIndex = 17;
			this.label8.Text = "Mức chia tỷ lệ các trục";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(14, 386);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(91, 16);
			this.label9.TabIndex = 21;
			this.label9.Text = "Độ nhạy polar";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(13, 420);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(86, 16);
			this.label10.TabIndex = 22;
			this.label10.Text = "Chế độ đồ thị";
			// 
			// nudSensitive
			// 
			this.nudSensitive.Enabled = false;
			this.nudSensitive.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nudSensitive.Location = new System.Drawing.Point(161, 385);
			this.nudSensitive.Margin = new System.Windows.Forms.Padding(4);
			this.nudSensitive.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudSensitive.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nudSensitive.Name = "nudSensitive";
			this.nudSensitive.Size = new System.Drawing.Size(81, 22);
			this.nudSensitive.TabIndex = 12;
			this.nudSensitive.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// cbxMode
			// 
			this.cbxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxMode.FormattingEnabled = true;
			this.cbxMode.Items.AddRange(new object[] {
            "Hệ tọa độ Descartes (Cartesian)",
            "Hệ tọa độ cực (Polar)"});
			this.cbxMode.Location = new System.Drawing.Point(161, 417);
			this.cbxMode.Margin = new System.Windows.Forms.Padding(4);
			this.cbxMode.Name = "cbxMode";
			this.cbxMode.Size = new System.Drawing.Size(306, 24);
			this.cbxMode.TabIndex = 13;
			this.cbxMode.SelectedIndexChanged += new System.EventHandler(this.cbxMode_SelectedIndexChanged);
			// 
			// nudWidthStroke
			// 
			this.nudWidthStroke.Location = new System.Drawing.Point(386, 352);
			this.nudWidthStroke.Margin = new System.Windows.Forms.Padding(4);
			this.nudWidthStroke.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudWidthStroke.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudWidthStroke.Name = "nudWidthStroke";
			this.nudWidthStroke.Size = new System.Drawing.Size(81, 22);
			this.nudWidthStroke.TabIndex = 11;
			this.nudWidthStroke.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(260, 356);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(90, 16);
			this.label12.TabIndex = 27;
			this.label12.Text = "Độ dày nét vẽ";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFuncs,
            this.MenuOprs,
            this.MenuInfo});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(477, 24);
			this.menuStrip1.TabIndex = 29;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// MenuFuncs
			// 
			this.MenuFuncs.Name = "MenuFuncs";
			this.MenuFuncs.Size = new System.Drawing.Size(91, 20);
			this.MenuFuncs.Text = "Chèn Hàm số";
			this.MenuFuncs.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuFuncs_DropDownItemClicked);
			// 
			// MenuOprs
			// 
			this.MenuOprs.Name = "MenuOprs";
			this.MenuOprs.Size = new System.Drawing.Size(89, 20);
			this.MenuOprs.Text = "Chèn Toán tử";
			this.MenuOprs.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuOprs_DropDownItemClicked);
			// 
			// MenuInfo
			// 
			this.MenuInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tácGiảToolStripMenuItem});
			this.MenuInfo.Name = "MenuInfo";
			this.MenuInfo.Size = new System.Drawing.Size(70, 20);
			this.MenuInfo.Text = "Thông tin";
			// 
			// tácGiảToolStripMenuItem
			// 
			this.tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
			this.tácGiảToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.tácGiảToolStripMenuItem.Text = "Tác giả";
			this.tácGiảToolStripMenuItem.Click += new System.EventHandler(this.MenuInfo_Click);
			// 
			// ThongTin
			// 
			this.AcceptButton = this.btnDraw;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(477, 505);
			this.Controls.Add(this.nudWidthStroke);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.cbxMode);
			this.Controls.Add(this.nudSensitive);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.axisRatio);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.nudEndY);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nudStartY);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.nudEndX);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nudStartX);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnDraw);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtExpression);
			this.Controls.Add(this.lstExpressions);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "ThongTin";
			this.Text = "Thông tin đồ thị";
			this.Load += new System.EventHandler(this.ThongTin_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudStartX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEndX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEndY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudStartY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axisRatio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSensitive)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWidthStroke)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lstExpressions;
        private System.Windows.Forms.RichTextBox txtExpression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudStartX;
        private System.Windows.Forms.NumericUpDown nudEndX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudEndY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudStartY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown axisRatio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudSensitive;
        private System.Windows.Forms.ComboBox cbxMode;
        private System.Windows.Forms.NumericUpDown nudWidthStroke;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFuncs;
        private System.Windows.Forms.ToolStripMenuItem MenuOprs;
        private System.Windows.Forms.ToolStripMenuItem MenuInfo;
        private System.Windows.Forms.ToolStripMenuItem tácGiảToolStripMenuItem;

    }
}

