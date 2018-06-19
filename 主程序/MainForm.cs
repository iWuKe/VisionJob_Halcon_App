using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dotNetLab.Common.ModernUI;
using dotNetLab.Common;

namespace shikii.VisionJob
{
    public partial class MainForm : dotNetLab.Forms.ModernPage
    {
        private dotNetLab.Widgets.MobileListBox mobileListBox1;

        protected override void prepareCtrls()
        {
            base.prepareCtrls();
            InitializeComponent();
            mobileListBox1.AppendLog("hahahsdffffffffffffffffffffffffffffffffffffffffffff");
            mobileListBox1.AppendLog("jiji", true);

        }
       
        private void InitializeComponent()
        {
            this.mobileListBox1 = new dotNetLab.Widgets.MobileListBox();
            this.SuspendLayout();
            // 
            // mobileListBox1
            // 
            this.mobileListBox1.BackColor = System.Drawing.Color.Transparent;
            this.mobileListBox1.BorderColor = System.Drawing.Color.Gray;
            this.mobileListBox1.BorderThickness = 1;
            this.mobileListBox1.CornerAlignment = dotNetLab.Widgets.Alignments.All;
            this.mobileListBox1.DataBindingInfo = null;
            this.mobileListBox1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.mobileListBox1.ImagePos = new System.Drawing.Point(0, 0);
            this.mobileListBox1.ImageSize = new System.Drawing.Size(0, 0);
            this.mobileListBox1.Location = new System.Drawing.Point(351, 65);
            this.mobileListBox1.MainBindableProperty = "mobileListBox1";
            this.mobileListBox1.Name = "mobileListBox1";
            this.mobileListBox1.NormalColor = System.Drawing.Color.White;
            this.mobileListBox1.Radius = -1;
            this.mobileListBox1.Size = new System.Drawing.Size(228, 411);
            this.mobileListBox1.Source = null;
            this.mobileListBox1.TabIndex = 2;
            this.mobileListBox1.Text = "mobileListBox1";
            this.mobileListBox1.UIElementBinders = null;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.mobileListBox1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Controls.SetChildIndex(this.mobileListBox1, 0);
            this.ResumeLayout(false);

        }

        //启动日志显示窗体
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Alt | Keys.O))
            {
                
            }
        }
    }
}
