using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dotNetLab.Common.ModernUI;
using dotNetLab.Vision.Halcon;

namespace shikii.VisionJob
{
   public class ManualForm : SessionPage
    {
     

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
       
        
       private void btn_UploadScript_Click(object sender, EventArgs e)
       {
            try
            {

            CompactDB.GetAllTableNames();
            if(!CompactDB.AllTableNames.Contains(App.HalconScriptTableName))
                CompactDB.CreateKeyValueTable(App.HalconScriptTableName);
            App.HalconEngineManager[cmbx_HalconScriptName.Text.Trim()].
                UploadHalconScript(CompactDB, App.HalconScriptTableName);
            }
            catch (Exception ex)
            {
                 
               DialogResult dlt   = MessageBox.Show("是否需要绕过特定引擎上传一个脚本文件？", "询问",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dlt == DialogResult.OK)
                {
                    Form form = new Form();
                    form.Size = new System.Drawing.Size(200, 150);
                    form.Text = "Procedure Name";
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.BackColor = System.Drawing.Color.Beige;
                    TextBox txb = new TextBox(); txb.Font = new System.Drawing.Font("微软雅黑", 11);
                    txb.Location = new System.Drawing.Point(form.Width / 2 - txb.Width / 2, form.Height / 2 - txb.Height / 2);
                    txb.KeyUp += (s , exx) =>
                     {
                         if(exx.KeyCode == Keys.Enter)
                         {
                             form.Close();
                         }
                     };
                    form.Controls.Add(txb);
                    form.ShowDialog();
                    String ProcedureName = txb.Text.Trim();
                    string strDesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    String filePath = Path.Combine(strDesktopPath, ProcedureName + ".xml");
                    String Content = File.ReadAllText(filePath, Encoding.Default);
                    CompactDB.Write(App.HalconScriptTableName, ProcedureName, Content);
                    form.Dispose();
                }
            }
       }

       private void btn_DownloadScript_Click(object sender, EventArgs e)
        {

            try
            {
            App.HalconEngineManager[cmbx_HalconScriptName.Text.Trim()].
                DownloadHalconScript(CompactDB, App.HalconScriptTableName);

            }
            catch (Exception ex)
            {

                DialogResult dlt = MessageBox.Show("是否需要绕过特定引擎下载一个脚本文件？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

               
                   
                if (dlt == DialogResult.OK)
                {
                    Form form = new Form();
                    form.Size = new System.Drawing.Size(200, 150);
                    form.Text = "Procedure Name";
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.BackColor = System.Drawing.Color.Beige;
                    TextBox txb = new TextBox(); txb.Font = new System.Drawing.Font("微软雅黑", 11);
                    txb.Location = new System.Drawing.Point(form.Width / 2 - txb.Width / 2, form.Height / 2 - txb.Height / 2);
                    txb.KeyUp += (s, exx) =>
                    {
                        if (exx.KeyCode == Keys.Enter)
                        {
                            form.Close();
                        }
                    };
                    form.Controls.Add(txb);
                    form.ShowDialog();
                    String ProcedureName = txb.Text.Trim();
                    string strDesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    String strContent = CompactDB.FetchValue(ProcedureName, App.HalconScriptTableName);
                    File.WriteAllText(Path.Combine(strDesktopPath, ProcedureName + ".xml")
                            , strContent, Encoding.Default);
                    form.Dispose();
                }
            }
        }





        private System.Windows.Forms.ComboBox cmbx_GongWei;
        private dotNetLab.Widgets.MobileButton btn_RunSingleGongWei;
        private dotNetLab.Widgets.MobileButton btn_RunProject;
        private dotNetLab.Widgets.ColorDecorator colorDecorator1;
        private System.Windows.Forms.ComboBox cmbx_HalconScriptName;
        private dotNetLab.Widgets.MobileButton btn_UploadScript;
        private dotNetLab.Widgets.MobileButton btn_DownloadScript;
        private dotNetLab.Widgets.TextBlock textBlock2;
        private dotNetLab.Widgets.TextBlock textBlock1;
        private void InitializeComponent()
        {
            this.textBlock1 = new dotNetLab.Widgets.TextBlock();
            this.cmbx_GongWei = new System.Windows.Forms.ComboBox();
            this.btn_RunSingleGongWei = new dotNetLab.Widgets.MobileButton();
            this.btn_RunProject = new dotNetLab.Widgets.MobileButton();
            this.colorDecorator1 = new dotNetLab.Widgets.ColorDecorator();
            this.cmbx_HalconScriptName = new System.Windows.Forms.ComboBox();
            this.btn_UploadScript = new dotNetLab.Widgets.MobileButton();
            this.btn_DownloadScript = new dotNetLab.Widgets.MobileButton();
            this.textBlock2 = new dotNetLab.Widgets.TextBlock();
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
            // cmbx_HalconScriptName
            // 
            this.cmbx_HalconScriptName.BackColor = System.Drawing.Color.Silver;
            this.cmbx_HalconScriptName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbx_HalconScriptName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbx_HalconScriptName.ForeColor = System.Drawing.Color.White;
            this.cmbx_HalconScriptName.FormattingEnabled = true;
            this.cmbx_HalconScriptName.Location = new System.Drawing.Point(193, 214);
            this.cmbx_HalconScriptName.Name = "cmbx_HalconScriptName";
            this.cmbx_HalconScriptName.Size = new System.Drawing.Size(380, 29);
            this.cmbx_HalconScriptName.TabIndex = 2;
            // 
            // btn_UploadScript
            // 
            this.btn_UploadScript.BackColor = System.Drawing.Color.Transparent;
            this.btn_UploadScript.BorderColor = System.Drawing.Color.Empty;
            this.btn_UploadScript.BorderThickness = -1;
            this.btn_UploadScript.CornerAligment = dotNetLab.Widgets.Alignments.All;
            this.btn_UploadScript.DataBindingInfo = null;
            this.btn_UploadScript.EnableFlag = false;
            this.btn_UploadScript.EnableMobileRound = true;
            this.btn_UploadScript.EnableTextRenderHint = false;
            this.btn_UploadScript.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.btn_UploadScript.FlagColor = System.Drawing.Color.DodgerBlue;
            this.btn_UploadScript.FlagThickness = 5;
            this.btn_UploadScript.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_UploadScript.ForeColor = System.Drawing.Color.White;
            this.btn_UploadScript.GapBetweenTextFlag = 10;
            this.btn_UploadScript.GapBetweenTextImage = 8;
            this.btn_UploadScript.IConAlignment = System.Windows.Forms.LeftRightAlignment.Left;
            this.btn_UploadScript.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_UploadScript.LEDStyle = false;
            this.btn_UploadScript.Location = new System.Drawing.Point(354, 270);
            this.btn_UploadScript.MainBindableProperty = "上传脚本";
            this.btn_UploadScript.Name = "btn_UploadScript";
            this.btn_UploadScript.NeedAnimation = true;
            this.btn_UploadScript.NormalColor = System.Drawing.Color.Crimson;
            this.btn_UploadScript.PressColor = System.Drawing.Color.Cyan;
            this.btn_UploadScript.Radius = 37;
            this.btn_UploadScript.Size = new System.Drawing.Size(113, 38);
            this.btn_UploadScript.Source = null;
            this.btn_UploadScript.TabIndex = 3;
            this.btn_UploadScript.Text = "上传脚本";
            this.btn_UploadScript.UIElementBinders = null;
            this.btn_UploadScript.UnderLine = false;
            this.btn_UploadScript.UnderLineColor = System.Drawing.Color.DarkGray;
            this.btn_UploadScript.UnderLineThickness = 2F;
            this.btn_UploadScript.Vertical = false;
            this.btn_UploadScript.WhereReturn = ((byte)(0));
            this.btn_UploadScript.Click += new System.EventHandler(this.btn_UploadScript_Click);
            // 
            // btn_DownloadScript
            // 
            this.btn_DownloadScript.BackColor = System.Drawing.Color.Transparent;
            this.btn_DownloadScript.BorderColor = System.Drawing.Color.Empty;
            this.btn_DownloadScript.BorderThickness = -1;
            this.btn_DownloadScript.CornerAligment = dotNetLab.Widgets.Alignments.All;
            this.btn_DownloadScript.DataBindingInfo = null;
            this.btn_DownloadScript.EnableFlag = false;
            this.btn_DownloadScript.EnableMobileRound = true;
            this.btn_DownloadScript.EnableTextRenderHint = false;
            this.btn_DownloadScript.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.btn_DownloadScript.FlagColor = System.Drawing.Color.DodgerBlue;
            this.btn_DownloadScript.FlagThickness = 5;
            this.btn_DownloadScript.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_DownloadScript.ForeColor = System.Drawing.Color.White;
            this.btn_DownloadScript.GapBetweenTextFlag = 10;
            this.btn_DownloadScript.GapBetweenTextImage = 8;
            this.btn_DownloadScript.IConAlignment = System.Windows.Forms.LeftRightAlignment.Left;
            this.btn_DownloadScript.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_DownloadScript.LEDStyle = false;
            this.btn_DownloadScript.Location = new System.Drawing.Point(473, 270);
            this.btn_DownloadScript.MainBindableProperty = "下载脚本";
            this.btn_DownloadScript.Name = "btn_DownloadScript";
            this.btn_DownloadScript.NeedAnimation = true;
            this.btn_DownloadScript.NormalColor = System.Drawing.Color.LimeGreen;
            this.btn_DownloadScript.PressColor = System.Drawing.Color.Cyan;
            this.btn_DownloadScript.Radius = 37;
            this.btn_DownloadScript.Size = new System.Drawing.Size(113, 38);
            this.btn_DownloadScript.Source = null;
            this.btn_DownloadScript.TabIndex = 3;
            this.btn_DownloadScript.Text = "下载脚本";
            this.btn_DownloadScript.UIElementBinders = null;
            this.btn_DownloadScript.UnderLine = false;
            this.btn_DownloadScript.UnderLineColor = System.Drawing.Color.DarkGray;
            this.btn_DownloadScript.UnderLineThickness = 2F;
            this.btn_DownloadScript.Vertical = false;
            this.btn_DownloadScript.WhereReturn = ((byte)(0));
            this.btn_DownloadScript.Click += new System.EventHandler(this.btn_DownloadScript_Click);
            // 
            // textBlock2
            // 
            this.textBlock2.BackColor = System.Drawing.Color.Transparent;
            this.textBlock2.BorderColor = System.Drawing.Color.Empty;
            this.textBlock2.BorderThickness = -1;
            this.textBlock2.DataBindingInfo = null;
            this.textBlock2.EnableFlag = true;
            this.textBlock2.EnableTextRenderHint = true;
            this.textBlock2.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock2.FlagColor = System.Drawing.Color.Crimson;
            this.textBlock2.FlagThickness = 8;
            this.textBlock2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock2.GapBetweenTextFlag = 10;
            this.textBlock2.LEDStyle = false;
            this.textBlock2.Location = new System.Drawing.Point(66, 218);
            this.textBlock2.MainBindableProperty = "上传下载脚本";
            this.textBlock2.Name = "textBlock2";
            this.textBlock2.Radius = -1;
            this.textBlock2.Size = new System.Drawing.Size(121, 25);
            this.textBlock2.TabIndex = 1;
            this.textBlock2.Text = "上传下载脚本";
            this.textBlock2.UIElementBinders = null;
            this.textBlock2.UnderLine = false;
            this.textBlock2.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock2.UnderLineThickness = 2F;
            this.textBlock2.Vertical = false;
            this.textBlock2.WhereReturn = ((byte)(0));
            // 
            // ManualForm
            // 
            this.ClientSize = new System.Drawing.Size(644, 500);
            this.ClipboardText = "HalconEngineManager";
            this.Controls.Add(this.colorDecorator1);
            this.Controls.Add(this.btn_RunProject);
            this.Controls.Add(this.btn_DownloadScript);
            this.Controls.Add(this.btn_UploadScript);
            this.Controls.Add(this.btn_RunSingleGongWei);
            this.Controls.Add(this.cmbx_HalconScriptName);
            this.Controls.Add(this.cmbx_GongWei);
            this.Controls.Add(this.textBlock2);
            this.Controls.Add(this.textBlock1);
            this.Name = "ManualForm";
            this.Text = "手动操作";
            this.TitlePos = new System.Drawing.Point(60, 15);
            this.Controls.SetChildIndex(this.textBlock1, 0);
            this.Controls.SetChildIndex(this.textBlock2, 0);
            this.Controls.SetChildIndex(this.cmbx_GongWei, 0);
            this.Controls.SetChildIndex(this.cmbx_HalconScriptName, 0);
            this.Controls.SetChildIndex(this.btn_RunSingleGongWei, 0);
            this.Controls.SetChildIndex(this.btn_UploadScript, 0);
            this.Controls.SetChildIndex(this.btn_DownloadScript, 0);
            this.Controls.SetChildIndex(this.btn_RunProject, 0);
            this.Controls.SetChildIndex(this.colorDecorator1, 0);
            this.ResumeLayout(false);

        }

    }
}
