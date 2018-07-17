using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dotNetLab.Common.ModernUI;

namespace shikii.VisionJob
{
   public class ManualForm : SessionPage
    {
        private System.Windows.Forms.ComboBox cmbx_GongWei;
        private dotNetLab.Widgets.MobileButton btn_RunSingleGongWei;
        private dotNetLab.Widgets.MobileButton btn_RunProject;
        private dotNetLab.Widgets.ColorDecorator colorDecorator1;
        private dotNetLab.Widgets.TextBlock textBlock1;
   
       protected override void prepareAppearance()
       {
           base.prepareAppearance();
            this.EnableDialog = true;
            this.EnableDrawUpDownPattern = true;
            this.Img_Up = dotNetLab.UI.RibbonCircleAndStripes;
            Img_Down = dotNetLab.UI.RibbonLunchBox;

       }
       protected override void prepareCtrls()
       {
            base.prepareCtrls();
            InitializeComponent();
       }
       // To do
       private void btn_RunSingleGongWei_Click(object sender, EventArgs e)
       {

       }
       // To do 运行所有工位
       private void btn_RunProject_Click(object sender, EventArgs e)
       {

       }
        private void InitializeComponent()
        {
            this.textBlock1 = new dotNetLab.Widgets.TextBlock();
            this.cmbx_GongWei = new System.Windows.Forms.ComboBox();
            this.btn_RunSingleGongWei = new dotNetLab.Widgets.MobileButton();
            this.btn_RunProject = new dotNetLab.Widgets.MobileButton();
            this.colorDecorator1 = new dotNetLab.Widgets.ColorDecorator();
            this.SuspendLayout();
            // 
            // tipper
            // 
            this.tipper.Location = new System.Drawing.Point(341, 415);
            // 
            // textBlock1
            // 
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
            this.textBlock1.Location = new System.Drawing.Point(66, 73);
            this.textBlock1.MainBindableProperty = "选择工位";
            this.textBlock1.Name = "textBlock1";
            this.textBlock1.Radius = -1;
            this.textBlock1.Size = new System.Drawing.Size(121, 25);
            this.textBlock1.TabIndex = 1;
            this.textBlock1.Text = "选择工位";
            this.textBlock1.UIElementBinders = null;
            this.textBlock1.UnderLine = false;
            this.textBlock1.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock1.UnderLineThickness = 2F;
            this.textBlock1.Vertical = false;
            this.textBlock1.WhereReturn = ((byte)(0));
            // 
            // cmbx_GongWei
            // 
            this.cmbx_GongWei.BackColor = System.Drawing.Color.Silver;
            this.cmbx_GongWei.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbx_GongWei.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbx_GongWei.ForeColor = System.Drawing.Color.White;
            this.cmbx_GongWei.FormattingEnabled = true;
            this.cmbx_GongWei.Location = new System.Drawing.Point(98, 104);
            this.cmbx_GongWei.Name = "cmbx_GongWei";
            this.cmbx_GongWei.Size = new System.Drawing.Size(344, 29);
            this.cmbx_GongWei.TabIndex = 2;
            // 
            // btn_RunSingleGongWei
            // 
            this.btn_RunSingleGongWei.BackColor = System.Drawing.Color.Transparent;
            this.btn_RunSingleGongWei.BorderColor = System.Drawing.Color.Empty;
            this.btn_RunSingleGongWei.BorderThickness = -1;
            this.btn_RunSingleGongWei.CornerAligment = dotNetLab.Widgets.Alignments.All;
            this.btn_RunSingleGongWei.DataBindingInfo = null;
            this.btn_RunSingleGongWei.EnableFlag = false;
            this.btn_RunSingleGongWei.EnableMobileRound = true;
            this.btn_RunSingleGongWei.EnableTextRenderHint = false;
            this.btn_RunSingleGongWei.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.btn_RunSingleGongWei.FlagColor = System.Drawing.Color.DodgerBlue;
            this.btn_RunSingleGongWei.FlagThickness = 5;
            this.btn_RunSingleGongWei.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_RunSingleGongWei.ForeColor = System.Drawing.Color.White;
            this.btn_RunSingleGongWei.GapBetweenTextFlag = 10;
            this.btn_RunSingleGongWei.GapBetweenTextImage = 8;
            this.btn_RunSingleGongWei.IConAlignment = System.Windows.Forms.LeftRightAlignment.Left;
            this.btn_RunSingleGongWei.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_RunSingleGongWei.LEDStyle = false;
            this.btn_RunSingleGongWei.Location = new System.Drawing.Point(448, 100);
            this.btn_RunSingleGongWei.MainBindableProperty = "运行";
            this.btn_RunSingleGongWei.Name = "btn_RunSingleGongWei";
            this.btn_RunSingleGongWei.NeedAnimation = true;
            this.btn_RunSingleGongWei.NormalColor = System.Drawing.Color.DodgerBlue;
            this.btn_RunSingleGongWei.PressColor = System.Drawing.Color.Cyan;
            this.btn_RunSingleGongWei.Radius = 37;
            this.btn_RunSingleGongWei.Size = new System.Drawing.Size(125, 38);
            this.btn_RunSingleGongWei.Source = null;
            this.btn_RunSingleGongWei.TabIndex = 3;
            this.btn_RunSingleGongWei.Text = "运行";
            this.btn_RunSingleGongWei.UIElementBinders = null;
            this.btn_RunSingleGongWei.UnderLine = false;
            this.btn_RunSingleGongWei.UnderLineColor = System.Drawing.Color.DarkGray;
            this.btn_RunSingleGongWei.UnderLineThickness = 2F;
            this.btn_RunSingleGongWei.Vertical = false;
            this.btn_RunSingleGongWei.WhereReturn = ((byte)(0));
            this.btn_RunSingleGongWei.Click += new System.EventHandler(this.btn_RunSingleGongWei_Click);
            // 
            // btn_RunProject
            // 
            this.btn_RunProject.BackColor = System.Drawing.Color.Transparent;
            this.btn_RunProject.BorderColor = System.Drawing.Color.Empty;
            this.btn_RunProject.BorderThickness = -1;
            this.btn_RunProject.CornerAligment = dotNetLab.Widgets.Alignments.All;
            this.btn_RunProject.DataBindingInfo = null;
            this.btn_RunProject.EnableFlag = false;
            this.btn_RunProject.EnableMobileRound = true;
            this.btn_RunProject.EnableTextRenderHint = false;
            this.btn_RunProject.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.btn_RunProject.FlagColor = System.Drawing.Color.DodgerBlue;
            this.btn_RunProject.FlagThickness = 5;
            this.btn_RunProject.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_RunProject.ForeColor = System.Drawing.Color.White;
            this.btn_RunProject.GapBetweenTextFlag = 10;
            this.btn_RunProject.GapBetweenTextImage = 8;
            this.btn_RunProject.IConAlignment = System.Windows.Forms.LeftRightAlignment.Left;
            this.btn_RunProject.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_RunProject.LEDStyle = false;
            this.btn_RunProject.Location = new System.Drawing.Point(98, 155);
            this.btn_RunProject.MainBindableProperty = "运行所有工位";
            this.btn_RunProject.Name = "btn_RunProject";
            this.btn_RunProject.NeedAnimation = true;
            this.btn_RunProject.NormalColor = System.Drawing.Color.DarkTurquoise;
            this.btn_RunProject.PressColor = System.Drawing.Color.Cyan;
            this.btn_RunProject.Radius = 37;
            this.btn_RunProject.Size = new System.Drawing.Size(475, 38);
            this.btn_RunProject.Source = null;
            this.btn_RunProject.TabIndex = 4;
            this.btn_RunProject.Text = "运行所有工位";
            this.btn_RunProject.UIElementBinders = null;
            this.btn_RunProject.UnderLine = false;
            this.btn_RunProject.UnderLineColor = System.Drawing.Color.DarkGray;
            this.btn_RunProject.UnderLineThickness = 2F;
            this.btn_RunProject.Vertical = false;
            this.btn_RunProject.WhereReturn = ((byte)(0));
            this.btn_RunProject.Click += new System.EventHandler(this.btn_RunProject_Click);
            // 
            // colorDecorator1
            // 
            this.colorDecorator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.colorDecorator1.BackColor = System.Drawing.Color.White;
            this.colorDecorator1.DataBindingInfo = null;
            this.colorDecorator1.Location = new System.Drawing.Point(7, 441);
            this.colorDecorator1.MainBindableProperty = "";
            this.colorDecorator1.Name = "colorDecorator1";
            this.colorDecorator1.Size = new System.Drawing.Size(150, 53);
            this.colorDecorator1.TabIndex = 5;
            this.colorDecorator1.UIElementBinders = null;
            // 
            // ManualForm
            // 
            this.ClientSize = new System.Drawing.Size(644, 500);
            this.Controls.Add(this.colorDecorator1);
            this.Controls.Add(this.btn_RunProject);
            this.Controls.Add(this.btn_RunSingleGongWei);
            this.Controls.Add(this.cmbx_GongWei);
            this.Controls.Add(this.textBlock1);
            this.Name = "ManualForm";
            this.Text = "手动操作";
            this.TitlePos = new System.Drawing.Point(60, 15);
            this.Controls.SetChildIndex(this.textBlock1, 0);
            this.Controls.SetChildIndex(this.cmbx_GongWei, 0);
            this.Controls.SetChildIndex(this.btn_RunSingleGongWei, 0);
            this.Controls.SetChildIndex(this.btn_RunProject, 0);
            this.Controls.SetChildIndex(this.colorDecorator1, 0);
            this.ResumeLayout(false);

        }
    }
}
