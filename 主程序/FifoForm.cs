using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dotNetLab.Common.ModernUI;

namespace shikii.VisionJob
{
  public  class FifoForm : SessionPage
    {
        public System.Windows.Forms.ComboBox comboBox1;
        public dotNetLab.Widgets.Container.CanvasPanel canvasPanel1;
        public dotNetLab.Widgets.TextBlock textBlock1;

        protected override void prepareCtrls()
        {
            base.prepareCtrls();
            InitializeComponent();
            AttachFifoTool();
            BindLiveDeviceNames();
        }
        private void InitializeComponent()
        {
            this.textBlock1 = new dotNetLab.Widgets.TextBlock();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.canvasPanel1 = new dotNetLab.Widgets.Container.CanvasPanel();
            this.SuspendLayout();
            // 
            // textBlock1
            // 
            this.textBlock1.BackColor = System.Drawing.Color.Transparent;
            this.textBlock1.BorderColor = System.Drawing.Color.Empty;
            this.textBlock1.BorderThickness = -1;
            this.textBlock1.DataBindingInfo = null;
            this.textBlock1.EnableFlag = true;
            this.textBlock1.EnableTextRenderHint = false;
            this.textBlock1.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock1.FlagColor = System.Drawing.Color.DodgerBlue;
            this.textBlock1.FlagThickness = 7;
            this.textBlock1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock1.GapBetweenTextFlag = 10;
            this.textBlock1.LEDStyle = false;
            this.textBlock1.Location = new System.Drawing.Point(57, 80);
            this.textBlock1.MainBindableProperty = "相机实时取相";
            this.textBlock1.Name = "textBlock1";
            this.textBlock1.Radius = -1;
            this.textBlock1.Size = new System.Drawing.Size(166, 23);
            this.textBlock1.TabIndex = 1;
            this.textBlock1.Text = "相机实时取相";
            this.textBlock1.UIElementBinders = null;
            this.textBlock1.UnderLine = false;
            this.textBlock1.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock1.UnderLineThickness = 2F;
            this.textBlock1.Vertical = false;
            this.textBlock1.WhereReturn = ((byte)(0));
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.DarkGray;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(357, 27);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // canvasPanel1
            // 
            this.canvasPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasPanel1.BackColor = System.Drawing.Color.Transparent;
            this.canvasPanel1.BorderColor = System.Drawing.Color.Empty;
            this.canvasPanel1.BorderThickness = -1;
            this.canvasPanel1.CornerAlignment = dotNetLab.Widgets.Alignments.All;
            this.canvasPanel1.DataBindingInfo = null;
            this.canvasPanel1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.canvasPanel1.ImagePos = new System.Drawing.Point(0, 0);
            this.canvasPanel1.ImageSize = new System.Drawing.Size(0, 0);
            this.canvasPanel1.Location = new System.Drawing.Point(60, 142);
            this.canvasPanel1.MainBindableProperty = "显示区";
            this.canvasPanel1.Name = "canvasPanel1";
            this.canvasPanel1.NormalColor = System.Drawing.Color.DarkGray;
            this.canvasPanel1.Radius = -1;
            this.canvasPanel1.Size = new System.Drawing.Size(496, 334);
            this.canvasPanel1.Source = null;
            this.canvasPanel1.TabIndex = 3;
            this.canvasPanel1.Text = "显示区";
            this.canvasPanel1.UIElementBinders = null;
            // 
            // FifoForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.canvasPanel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBlock1);
            this.Name = "FifoForm";
            this.Text = "取相";
            this.TitlePos = new System.Drawing.Point(70, 15);
            this.Controls.SetChildIndex(this.textBlock1, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.canvasPanel1, 0);
            this.ResumeLayout(false);

        }

        protected void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LiveDisplay(comboBox1.Text);
        }

        public void AttachFifoTool() 
        {

        }

        public void BindLiveDeviceNames()
        {

        }

        public void LiveDisplay(string str)
        {
        }
    }
}
