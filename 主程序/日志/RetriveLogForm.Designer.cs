namespace shikii.VisionJob
{
    partial class RetriveLogForm
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
            this.textBlock1 = new dotNetLab.Widgets.TextBlock();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBlock2 = new dotNetLab.Widgets.TextBlock();
            this.textBlock3 = new dotNetLab.Widgets.TextBlock();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new dotNetLab.Widgets.MobileButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lnk_ExportExecel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBlock1
            // 
            this.textBlock1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBlock1.BackColor = System.Drawing.Color.Transparent;
            this.textBlock1.BorderColor = System.Drawing.Color.Empty;
            this.textBlock1.BorderThickness = -1;
            this.textBlock1.DataBindingInfo = null;
            this.textBlock1.EnableFlag = true;
            this.textBlock1.EnableTextRenderHint = true;
            this.textBlock1.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock1.FlagColor = System.Drawing.Color.DodgerBlue;
            this.textBlock1.FlagThickness = 8;
            this.textBlock1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock1.GapBetweenTextFlag = 10;
            this.textBlock1.LEDStyle = false;
            this.textBlock1.Location = new System.Drawing.Point(12, 12);
            this.textBlock1.MainBindableProperty = "按日期来查";
            this.textBlock1.Name = "textBlock1";
            this.textBlock1.Radius = -1;
            this.textBlock1.Size = new System.Drawing.Size(150, 23);
            this.textBlock1.TabIndex = 0;
            this.textBlock1.Text = "按日期来查";
            this.textBlock1.UIElementBinders = null;
            this.textBlock1.UnderLine = false;
            this.textBlock1.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock1.UnderLineThickness = 2F;
            this.textBlock1.Vertical = false;
            this.textBlock1.WhereReturn = ((byte)(0));
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textBlock2
            // 
            this.textBlock2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBlock2.BackColor = System.Drawing.Color.Transparent;
            this.textBlock2.BorderColor = System.Drawing.Color.Empty;
            this.textBlock2.BorderThickness = -1;
            this.textBlock2.DataBindingInfo = null;
            this.textBlock2.EnableFlag = false;
            this.textBlock2.EnableTextRenderHint = false;
            this.textBlock2.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock2.FlagColor = System.Drawing.Color.DodgerBlue;
            this.textBlock2.FlagThickness = 8;
            this.textBlock2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock2.GapBetweenTextFlag = 10;
            this.textBlock2.LEDStyle = false;
            this.textBlock2.Location = new System.Drawing.Point(20, 53);
            this.textBlock2.MainBindableProperty = "从";
            this.textBlock2.Name = "textBlock2";
            this.textBlock2.Radius = -1;
            this.textBlock2.Size = new System.Drawing.Size(32, 23);
            this.textBlock2.TabIndex = 0;
            this.textBlock2.Text = "从";
            this.textBlock2.UIElementBinders = null;
            this.textBlock2.UnderLine = false;
            this.textBlock2.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock2.UnderLineThickness = 2F;
            this.textBlock2.Vertical = false;
            this.textBlock2.WhereReturn = ((byte)(0));
            // 
            // textBlock3
            // 
            this.textBlock3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBlock3.BackColor = System.Drawing.Color.Transparent;
            this.textBlock3.BorderColor = System.Drawing.Color.Empty;
            this.textBlock3.BorderThickness = -1;
            this.textBlock3.DataBindingInfo = null;
            this.textBlock3.EnableFlag = false;
            this.textBlock3.EnableTextRenderHint = false;
            this.textBlock3.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock3.FlagColor = System.Drawing.Color.DodgerBlue;
            this.textBlock3.FlagThickness = 8;
            this.textBlock3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock3.GapBetweenTextFlag = 10;
            this.textBlock3.LEDStyle = false;
            this.textBlock3.Location = new System.Drawing.Point(271, 53);
            this.textBlock3.MainBindableProperty = "至";
            this.textBlock3.Name = "textBlock3";
            this.textBlock3.Radius = -1;
            this.textBlock3.Size = new System.Drawing.Size(32, 23);
            this.textBlock3.TabIndex = 0;
            this.textBlock3.Text = "至";
            this.textBlock3.UIElementBinders = null;
            this.textBlock3.UnderLine = false;
            this.textBlock3.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock3.UnderLineThickness = 2F;
            this.textBlock3.Vertical = false;
            this.textBlock3.WhereReturn = ((byte)(0));
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Location = new System.Drawing.Point(309, 53);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.BorderColor = System.Drawing.Color.Empty;
            this.btn_Search.BorderThickness = -1;
            this.btn_Search.CornerAligment = dotNetLab.Widgets.Alignments.All;
            this.btn_Search.DataBindingInfo = null;
            this.btn_Search.EnableFlag = false;
            this.btn_Search.EnableMobileRound = false;
            this.btn_Search.EnableTextRenderHint = false;
            this.btn_Search.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.btn_Search.FlagColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.FlagThickness = 5;
            this.btn_Search.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.GapBetweenTextFlag = 10;
            this.btn_Search.GapBetweenTextImage = 8;
            this.btn_Search.IConAlignment = System.Windows.Forms.LeftRightAlignment.Left;
            this.btn_Search.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_Search.LEDStyle = false;
            this.btn_Search.Location = new System.Drawing.Point(529, 43);
            this.btn_Search.MainBindableProperty = "查询";
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.NeedAnimation = false;
            this.btn_Search.NormalColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.PressColor = System.Drawing.Color.RoyalBlue;
            this.btn_Search.Radius = 15;
            this.btn_Search.Size = new System.Drawing.Size(111, 41);
            this.btn_Search.Source = null;
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "查询";
            this.btn_Search.UIElementBinders = null;
            this.btn_Search.UnderLine = false;
            this.btn_Search.UnderLineColor = System.Drawing.Color.DarkGray;
            this.btn_Search.UnderLineThickness = 2F;
            this.btn_Search.Vertical = false;
            this.btn_Search.WhereReturn = ((byte)(0));
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(628, 387);
            this.dataGridView1.TabIndex = 3;
            // 
            // lnk_ExportExecel
            // 
            this.lnk_ExportExecel.AutoSize = true;
            this.lnk_ExportExecel.Location = new System.Drawing.Point(540, 23);
            this.lnk_ExportExecel.Name = "lnk_ExportExecel";
            this.lnk_ExportExecel.Size = new System.Drawing.Size(89, 12);
            this.lnk_ExportExecel.TabIndex = 4;
            this.lnk_ExportExecel.TabStop = true;
            this.lnk_ExportExecel.Text = "导出为Execel表";
            this.lnk_ExportExecel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_ExportExecel_Clicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(130, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "如果要详细查询请使用快捷键CTRL+Q";
            // 
            // RetriveLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnk_ExportExecel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBlock3);
            this.Controls.Add(this.textBlock2);
            this.Controls.Add(this.textBlock1);
            this.KeyPreview = true;
            this.Name = "RetriveLogForm";
            this.Text = "RetriveLogForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dotNetLab.Widgets.TextBlock textBlock1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private dotNetLab.Widgets.TextBlock textBlock2;
        private dotNetLab.Widgets.TextBlock textBlock3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private dotNetLab.Widgets.MobileButton btn_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel lnk_ExportExecel;
        private System.Windows.Forms.Label label1;
    }
}