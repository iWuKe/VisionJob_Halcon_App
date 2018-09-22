

using dotNetLab.Common;
using dotNetLab.Widgets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using dotNetLab.Vision.Halcon.Tools;

namespace shikii.VisionJob
{
    public class MenuForm : dotNetLab.Common.ModernUI.SessionPage
    {

        protected override void prepareCtrls()
        {
            base.prepareCtrls();
            this.InitializeComponent();

            PrepareProjsUI();

        }
        void PrepareProjsUI()
        {
            cmbx_CurrentProjectName.Items.Clear();
            cmbx_DeleteProject.Items.Clear();
            cmbx_NewProjectBaseOnWhichProject.Items.Clear();
            String[] strArr = null;
            if (!Directory.Exists("Projs"))
                Directory.CreateDirectory("Projs");

             strArr = Directory.GetDirectories("Projs");
           
            for (int i = 0; i < strArr.Length; i++)
            {
                strArr[i] = Path.GetFileNameWithoutExtension(strArr[i]);
            }
            this.cmbx_CurrentProjectName.Items.AddRange(strArr);
            cmbx_CurrentProjectName.Text = Path.GetFileNameWithoutExtension(CompactDB.FetchValue("Current_Project"));
            cmbx_DeleteProject.Items.AddRange(strArr);
            cmbx_NewProjectBaseOnWhichProject.Items.AddRange(strArr);
            cmbx_NewProjectBaseOnWhichProject.Text = cmbx_CurrentProjectName.Text;
        }
      
        protected override void prepareAppearance()
        {
            base.prepareAppearance();
            this.EnableDrawUpDownPattern = true;
            this.Img_Up = dotNetLab.UI.RibbonTreeRings;
            this.Img_Down = dotNetLab.UI.RibbonDoodleDiamonds;
        }

        protected override void prepareEvents()
        {
            base.prepareEvents();
            this.txb_NewProject.txb.KeyDown += (s, e) =>
            {

                if (e.KeyData == Keys.Enter)
                {

                    String strDirPath = String.Format("Projs\\{0}", txb_NewProject.Text.Trim());
                    Directory.CreateDirectory(strDirPath);
                    Thread.Sleep(500);
                    String [] arr = Directory.GetFiles(Path.Combine("Projs", cmbx_NewProjectBaseOnWhichProject.Text));
                    for (int i = 0; i < arr.Length; i++)
                    {
                        File.Copy(arr[i], Path.Combine(strDirPath, Path.GetFileName(arr[i])));
                    }
                    
                    dotNetLab.Tipper.Info = "创建项目完成";
                    PrepareProjsUI();
                }
            };

            this.btn_DeleteProject.Click += (s, e) =>
            {
                if (cmbx_DeleteProject.Text == cmbx_CurrentProjectName.Text)
                {
                    dotNetLab.Tipper.Error = "不能删除当前正在运行的项目";
                    return;
                }
                else
                {
                    String[] arr = Directory.GetFiles(String.Format("Projs\\{0}", cmbx_DeleteProject.Text));
                    for (int i = 0; i < arr.Length; i++)
                    {
                        File.Delete(arr[i]);
                    }
                    Directory.Delete(String.Format("Projs\\{0}", cmbx_DeleteProject.Text));
                }
                PrepareProjsUI();
            };

            //to do 切换项目,务必重写此方法
            //！ 注意务必使用ToolBlockEditV2.LoadShikii 来重新载入shikii
            cmbx_CurrentProjectName.SelectedIndexChanged += (s, e) =>
            {
                String strPath = String.Format("Projs\\{0}", cmbx_CurrentProjectName.Text);
                CompactDB.Write("Current_Project", strPath);
                // strPath =Path.Combine( Path.GetDirectoryName(Application.ExecutablePath),strPath);
                //使用作业管理器来切换项目
                App.job.Deserialize();



            };
        }


        //to do 训练模板
        private void lnk_TrainPattern_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item is PatternForm)
                {
                    if (item.Owner !=  this)
                        return;
                    if (item.WindowState == FormWindowState.Minimized)
                        item.WindowState = FormWindowState.Normal;
                    item.BringToFront();
                    return;
                }
            }
            PatternForm frm = new PatternForm();
            frm.Owner = this;
            frm.Text = "作业管理器";
            JobToolEditV2 editV2 = new JobToolEditV2();
            editV2.Subject = App.job;
            editV2.Dock = DockStyle.Fill;
            frm.Size = new System.Drawing.Size(editV2.Width + 20, editV2.Height + 20);

            frm.Controls.Add(editV2);
            frm.FormClosed += (s, ex) =>
            {

                frm.Dispose();
            };
            frm.Show();


        }
        private void lnk_RetriveLogs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RetriveLogForm frm = new RetriveLogForm();
            frm.Show();
            frm.FormClosed += (s, ex) =>
            {
                frm.Dispose();
            };
        }

        private void lnk_CommunicationConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppManager.ShowPage(typeof(TCPNetConnectForm));
        }
        private void lnk_ManualRun_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppManager.ShowPage(typeof(ManualForm));
        }
        private void lnk_UseDataCenter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppManager.ShowCompactDBEditor();
        }
        private dotNetLab.Widgets.Card card2;
        private LinkLabel lnk_TrainPattern;
        private dotNetLab.Widgets.TextBlock textBlock2;
        private dotNetLab.Widgets.Card card1;
        private dotNetLab.Widgets.MobileTextBox txb_NewProject;
        private dotNetLab.Widgets.TextBlock textBlock4;
        private dotNetLab.Widgets.TextBlock textBlock3;
        private dotNetLab.Widgets.TextBlock textBlock1;
        private dotNetLab.Widgets.MobileButton btn_DeleteProject;
        private dotNetLab.Widgets.TextBlock textBlock5;
        private dotNetLab.Widgets.TextBlock textBlock6;
        private ComboBox cmbx_NewProjectBaseOnWhichProject;
        private ComboBox cmbx_CurrentProjectName;
        private ComboBox cmbx_DeleteProject;
        private Label label2;
        private Label label1;
        private dotNetLab.Widgets.MobileTextBox mobileTextBox4;
        private LinkLabel lnk_RetriveLogs;
        private LinkLabel lnk_CommunicationConfig;
        private LinkLabel lnk_ManualRun;
        private LinkLabel lnk_UseDataCenter;
        private dotNetLab.Widgets.ColorDecorator colorDecorator1;
        private void InitializeComponent()
        {
            dotNetLab.Widgets.UIBinding.UIElementBinderInfo uiElementBinderInfo1 = new dotNetLab.Widgets.UIBinding.UIElementBinderInfo();
            this.mobileTextBox4 = new dotNetLab.Widgets.MobileTextBox();
            this.colorDecorator1 = new dotNetLab.Widgets.ColorDecorator();
            this.card2 = new dotNetLab.Widgets.Card();
            this.lnk_UseDataCenter = new System.Windows.Forms.LinkLabel();
            this.lnk_ManualRun = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnk_RetriveLogs = new System.Windows.Forms.LinkLabel();
            this.lnk_CommunicationConfig = new System.Windows.Forms.LinkLabel();
            this.lnk_TrainPattern = new System.Windows.Forms.LinkLabel();
            this.textBlock2 = new dotNetLab.Widgets.TextBlock();
            this.card1 = new dotNetLab.Widgets.Card();
            this.cmbx_DeleteProject = new System.Windows.Forms.ComboBox();
            this.cmbx_NewProjectBaseOnWhichProject = new System.Windows.Forms.ComboBox();
            this.cmbx_CurrentProjectName = new System.Windows.Forms.ComboBox();
            this.btn_DeleteProject = new dotNetLab.Widgets.MobileButton();
            this.textBlock5 = new dotNetLab.Widgets.TextBlock();
            this.txb_NewProject = new dotNetLab.Widgets.MobileTextBox();
            this.textBlock6 = new dotNetLab.Widgets.TextBlock();
            this.textBlock4 = new dotNetLab.Widgets.TextBlock();
            this.textBlock3 = new dotNetLab.Widgets.TextBlock();
            this.textBlock1 = new dotNetLab.Widgets.TextBlock();
            this.card2.SuspendLayout();
            this.card1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mobileTextBox4
            // 
            this.mobileTextBox4.ActiveColor = System.Drawing.Color.Cyan;
            this.mobileTextBox4.BackColor = System.Drawing.Color.Transparent;
            uiElementBinderInfo1.DBEngineIndex = 0;
            uiElementBinderInfo1.EnableCheckBox_One_Zero = false;
            uiElementBinderInfo1.FieldName = "Val";
            uiElementBinderInfo1.Filter = "Name=\'AutoClearTime\' ";
            uiElementBinderInfo1.Ptr = null;
            uiElementBinderInfo1.StoreInDB = true;
            uiElementBinderInfo1.StoreIntoDBRealTime = true;
            uiElementBinderInfo1.TableName = "App_Extension_Data_Table";
            uiElementBinderInfo1.ThisControl = this.mobileTextBox4;
            this.mobileTextBox4.DataBindingInfo = uiElementBinderInfo1;
            this.mobileTextBox4.DoubleValue = double.NaN;
            this.mobileTextBox4.EnableMobileRound = true;
            this.mobileTextBox4.EnableNullValue = false;
            this.mobileTextBox4.FillColor = System.Drawing.Color.Transparent;
            this.mobileTextBox4.FloatValue = float.NaN;
            this.mobileTextBox4.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.mobileTextBox4.ForeColor = System.Drawing.Color.Black;
            this.mobileTextBox4.GreyPattern = false;
            this.mobileTextBox4.IntValue = -2147483648;
            this.mobileTextBox4.LineThickness = 2F;
            this.mobileTextBox4.Location = new System.Drawing.Point(86, 259);
            this.mobileTextBox4.MainBindableProperty = "";
            this.mobileTextBox4.Name = "mobileTextBox4";
            this.mobileTextBox4.Radius = 29;
            this.mobileTextBox4.Size = new System.Drawing.Size(73, 30);
            this.mobileTextBox4.StaticColor = System.Drawing.Color.Gray;
            this.mobileTextBox4.TabIndex = 3;
            this.mobileTextBox4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.mobileTextBox4.TextBackColor = System.Drawing.SystemColors.Window;
            this.mobileTextBox4.TextBoxStyle = dotNetLab.Widgets.MobileTextBox.TextBoxStyles.Mobile;
            this.mobileTextBox4.UIElementBinders = null;
            this.mobileTextBox4.WhitePattern = false;
            // 
            // colorDecorator1
            // 
            this.colorDecorator1.BackColor = System.Drawing.Color.White;
            this.colorDecorator1.DataBindingInfo = null;
            this.colorDecorator1.Location = new System.Drawing.Point(6, 441);
            this.colorDecorator1.MainBindableProperty = "";
            this.colorDecorator1.Name = "colorDecorator1";
            this.colorDecorator1.Size = new System.Drawing.Size(150, 53);
            this.colorDecorator1.TabIndex = 1;
            this.colorDecorator1.UIElementBinders = null;
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.Transparent;
            this.card2.BorderColor = System.Drawing.Color.Gray;
            this.card2.BorderThickness = 0;
            this.card2.Controls.Add(this.lnk_UseDataCenter);
            this.card2.Controls.Add(this.lnk_ManualRun);
            this.card2.Controls.Add(this.label2);
            this.card2.Controls.Add(this.label1);
            this.card2.Controls.Add(this.mobileTextBox4);
            this.card2.Controls.Add(this.lnk_RetriveLogs);
            this.card2.Controls.Add(this.lnk_CommunicationConfig);
            this.card2.Controls.Add(this.lnk_TrainPattern);
            this.card2.Controls.Add(this.textBlock2);
            this.card2.CornerAlignment = dotNetLab.Widgets.Alignments.All;
            this.card2.DataBindingInfo = null;
            this.card2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.card2.HeadColor = System.Drawing.Color.Purple;
            this.card2.HeaderAlignment = dotNetLab.Widgets.Alignments.Right;
            this.card2.HeadHeight = 30;
            this.card2.ImagePos = new System.Drawing.Point(0, 0);
            this.card2.ImageSize = new System.Drawing.Size(0, 0);
            this.card2.Location = new System.Drawing.Point(318, 77);
            this.card2.MainBindableProperty = "card1";
            this.card2.Name = "card2";
            this.card2.NormalColor = System.Drawing.Color.Snow;
            this.card2.Radius = 10;
            this.card2.Size = new System.Drawing.Size(247, 347);
            this.card2.Source = null;
            this.card2.TabIndex = 2;
            this.card2.Text = "card1";
            this.card2.UIElementBinders = null;
            // 
            // lnk_UseDataCenter
            // 
            this.lnk_UseDataCenter.AutoSize = true;
            this.lnk_UseDataCenter.Location = new System.Drawing.Point(63, 226);
            this.lnk_UseDataCenter.Name = "lnk_UseDataCenter";
            this.lnk_UseDataCenter.Size = new System.Drawing.Size(99, 20);
            this.lnk_UseDataCenter.TabIndex = 5;
            this.lnk_UseDataCenter.TabStop = true;
            this.lnk_UseDataCenter.Text = "使用数据中心";
            this.lnk_UseDataCenter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_UseDataCenter_LinkClicked);
            // 
            // lnk_ManualRun
            // 
            this.lnk_ManualRun.AutoSize = true;
            this.lnk_ManualRun.Location = new System.Drawing.Point(73, 80);
            this.lnk_ManualRun.Name = "lnk_ManualRun";
            this.lnk_ManualRun.Size = new System.Drawing.Size(69, 20);
            this.lnk_ManualRun.TabIndex = 5;
            this.lnk_ManualRun.TabStop = true;
            this.lnk_ManualRun.Text = "手动操作";
            this.lnk_ManualRun.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_ManualRun_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "天";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "自动清理";
            // 
            // lnk_RetriveLogs
            // 
            this.lnk_RetriveLogs.AutoSize = true;
            this.lnk_RetriveLogs.Location = new System.Drawing.Point(62, 304);
            this.lnk_RetriveLogs.Name = "lnk_RetriveLogs";
            this.lnk_RetriveLogs.Size = new System.Drawing.Size(99, 20);
            this.lnk_RetriveLogs.TabIndex = 1;
            this.lnk_RetriveLogs.TabStop = true;
            this.lnk_RetriveLogs.Text = "查询往期日志";
            this.lnk_RetriveLogs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_RetriveLogs_LinkClicked);
            // 
            // lnk_CommunicationConfig
            // 
            this.lnk_CommunicationConfig.AutoSize = true;
            this.lnk_CommunicationConfig.Location = new System.Drawing.Point(73, 46);
            this.lnk_CommunicationConfig.Name = "lnk_CommunicationConfig";
            this.lnk_CommunicationConfig.Size = new System.Drawing.Size(69, 20);
            this.lnk_CommunicationConfig.TabIndex = 1;
            this.lnk_CommunicationConfig.TabStop = true;
            this.lnk_CommunicationConfig.Text = "通讯配置";
            this.lnk_CommunicationConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_CommunicationConfig_LinkClicked);
            // 
            // lnk_TrainPattern
            // 
            this.lnk_TrainPattern.AutoSize = true;
            this.lnk_TrainPattern.Location = new System.Drawing.Point(73, 11);
            this.lnk_TrainPattern.Name = "lnk_TrainPattern";
            this.lnk_TrainPattern.Size = new System.Drawing.Size(69, 20);
            this.lnk_TrainPattern.TabIndex = 1;
            this.lnk_TrainPattern.TabStop = true;
            this.lnk_TrainPattern.Text = "作业管理";
            this.lnk_TrainPattern.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_TrainPattern_LinkClicked);
            // 
            // textBlock2
            // 
            this.textBlock2.BackColor = System.Drawing.Color.Transparent;
            this.textBlock2.BorderColor = System.Drawing.Color.Empty;
            this.textBlock2.BorderThickness = 0;
            this.textBlock2.DataBindingInfo = null;
            this.textBlock2.EnableFlag = false;
            this.textBlock2.EnableTextRenderHint = false;
            this.textBlock2.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock2.FlagColor = System.Drawing.Color.DodgerBlue;
            this.textBlock2.FlagThickness = 5;
            this.textBlock2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock2.ForeColor = System.Drawing.Color.White;
            this.textBlock2.GapBetweenTextFlag = 10;
            this.textBlock2.LEDStyle = false;
            this.textBlock2.Location = new System.Drawing.Point(213, 139);
            this.textBlock2.MainBindableProperty = "杂项";
            this.textBlock2.Name = "textBlock2";
            this.textBlock2.Radius = 0;
            this.textBlock2.Size = new System.Drawing.Size(27, 48);
            this.textBlock2.TabIndex = 0;
            this.textBlock2.Text = "杂项";
            this.textBlock2.UIElementBinders = null;
            this.textBlock2.UnderLine = false;
            this.textBlock2.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock2.UnderLineThickness = 2F;
            this.textBlock2.Vertical = true;
            this.textBlock2.WhereReturn = ((byte)(0));
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.Transparent;
            this.card1.BorderColor = System.Drawing.Color.Gray;
            this.card1.BorderThickness = 0;
            this.card1.Controls.Add(this.cmbx_DeleteProject);
            this.card1.Controls.Add(this.cmbx_NewProjectBaseOnWhichProject);
            this.card1.Controls.Add(this.cmbx_CurrentProjectName);
            this.card1.Controls.Add(this.btn_DeleteProject);
            this.card1.Controls.Add(this.textBlock5);
            this.card1.Controls.Add(this.txb_NewProject);
            this.card1.Controls.Add(this.textBlock6);
            this.card1.Controls.Add(this.textBlock4);
            this.card1.Controls.Add(this.textBlock3);
            this.card1.Controls.Add(this.textBlock1);
            this.card1.CornerAlignment = dotNetLab.Widgets.Alignments.All;
            this.card1.DataBindingInfo = null;
            this.card1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.card1.HeadColor = System.Drawing.Color.DodgerBlue;
            this.card1.HeaderAlignment = dotNetLab.Widgets.Alignments.Up;
            this.card1.HeadHeight = 40;
            this.card1.ImagePos = new System.Drawing.Point(0, 0);
            this.card1.ImageSize = new System.Drawing.Size(0, 0);
            this.card1.Location = new System.Drawing.Point(53, 77);
            this.card1.MainBindableProperty = "card1";
            this.card1.Name = "card1";
            this.card1.NormalColor = System.Drawing.Color.Snow;
            this.card1.Radius = 10;
            this.card1.Size = new System.Drawing.Size(259, 347);
            this.card1.Source = null;
            this.card1.TabIndex = 3;
            this.card1.Text = "card1";
            this.card1.UIElementBinders = null;
            // 
            // cmbx_DeleteProject
            // 
            this.cmbx_DeleteProject.BackColor = System.Drawing.Color.DarkGray;
            this.cmbx_DeleteProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbx_DeleteProject.ForeColor = System.Drawing.Color.Black;
            this.cmbx_DeleteProject.FormattingEnabled = true;
            this.cmbx_DeleteProject.Location = new System.Drawing.Point(24, 263);
            this.cmbx_DeleteProject.Name = "cmbx_DeleteProject";
            this.cmbx_DeleteProject.Size = new System.Drawing.Size(218, 28);
            this.cmbx_DeleteProject.TabIndex = 8;
            // 
            // cmbx_NewProjectBaseOnWhichProject
            // 
            this.cmbx_NewProjectBaseOnWhichProject.BackColor = System.Drawing.Color.DarkGray;
            this.cmbx_NewProjectBaseOnWhichProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbx_NewProjectBaseOnWhichProject.ForeColor = System.Drawing.Color.Black;
            this.cmbx_NewProjectBaseOnWhichProject.FormattingEnabled = true;
            this.cmbx_NewProjectBaseOnWhichProject.Location = new System.Drawing.Point(24, 203);
            this.cmbx_NewProjectBaseOnWhichProject.Name = "cmbx_NewProjectBaseOnWhichProject";
            this.cmbx_NewProjectBaseOnWhichProject.Size = new System.Drawing.Size(218, 28);
            this.cmbx_NewProjectBaseOnWhichProject.TabIndex = 8;
            // 
            // cmbx_CurrentProjectName
            // 
            this.cmbx_CurrentProjectName.BackColor = System.Drawing.Color.DarkGray;
            this.cmbx_CurrentProjectName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbx_CurrentProjectName.ForeColor = System.Drawing.Color.Black;
            this.cmbx_CurrentProjectName.FormattingEnabled = true;
            this.cmbx_CurrentProjectName.Location = new System.Drawing.Point(24, 75);
            this.cmbx_CurrentProjectName.Name = "cmbx_CurrentProjectName";
            this.cmbx_CurrentProjectName.Size = new System.Drawing.Size(218, 28);
            this.cmbx_CurrentProjectName.TabIndex = 8;
            // 
            // btn_DeleteProject
            // 
            this.btn_DeleteProject.BackColor = System.Drawing.Color.Transparent;
            this.btn_DeleteProject.BorderColor = System.Drawing.Color.Empty;
            this.btn_DeleteProject.BorderThickness = 0;
            this.btn_DeleteProject.CornerAligment = dotNetLab.Widgets.Alignments.All;
            this.btn_DeleteProject.DataBindingInfo = null;
            this.btn_DeleteProject.EnableFlag = false;
            this.btn_DeleteProject.EnableMobileRound = true;
            this.btn_DeleteProject.EnableTextRenderHint = false;
            this.btn_DeleteProject.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.btn_DeleteProject.FlagColor = System.Drawing.Color.DodgerBlue;
            this.btn_DeleteProject.FlagThickness = 5;
            this.btn_DeleteProject.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_DeleteProject.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteProject.GapBetweenTextFlag = 10;
            this.btn_DeleteProject.GapBetweenTextImage = 8;
            this.btn_DeleteProject.IConAlignment = System.Windows.Forms.LeftRightAlignment.Left;
            this.btn_DeleteProject.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_DeleteProject.LEDStyle = false;
            this.btn_DeleteProject.Location = new System.Drawing.Point(12, 304);
            this.btn_DeleteProject.MainBindableProperty = "删除";
            this.btn_DeleteProject.Name = "btn_DeleteProject";
            this.btn_DeleteProject.NeedAnimation = true;
            this.btn_DeleteProject.NormalColor = System.Drawing.Color.Red;
            this.btn_DeleteProject.PressColor = System.Drawing.Color.Cyan;
            this.btn_DeleteProject.Radius = 34;
            this.btn_DeleteProject.Size = new System.Drawing.Size(230, 35);
            this.btn_DeleteProject.Source = null;
            this.btn_DeleteProject.TabIndex = 7;
            this.btn_DeleteProject.Text = "删除";
            this.btn_DeleteProject.UIElementBinders = null;
            this.btn_DeleteProject.UnderLine = false;
            this.btn_DeleteProject.UnderLineColor = System.Drawing.Color.DarkGray;
            this.btn_DeleteProject.UnderLineThickness = 2F;
            this.btn_DeleteProject.Vertical = false;
            this.btn_DeleteProject.WhereReturn = ((byte)(0));
            // 
            // textBlock5
            // 
            this.textBlock5.BackColor = System.Drawing.Color.Transparent;
            this.textBlock5.BorderColor = System.Drawing.Color.Empty;
            this.textBlock5.BorderThickness = 0;
            this.textBlock5.DataBindingInfo = null;
            this.textBlock5.EnableFlag = true;
            this.textBlock5.EnableTextRenderHint = true;
            this.textBlock5.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock5.FlagColor = System.Drawing.Color.Gold;
            this.textBlock5.FlagThickness = 7;
            this.textBlock5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock5.GapBetweenTextFlag = 10;
            this.textBlock5.LEDStyle = false;
            this.textBlock5.Location = new System.Drawing.Point(12, 237);
            this.textBlock5.MainBindableProperty = "删除项目";
            this.textBlock5.Name = "textBlock5";
            this.textBlock5.Radius = 0;
            this.textBlock5.Size = new System.Drawing.Size(96, 20);
            this.textBlock5.TabIndex = 5;
            this.textBlock5.Text = "删除项目";
            this.textBlock5.UIElementBinders = null;
            this.textBlock5.UnderLine = false;
            this.textBlock5.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock5.UnderLineThickness = 2F;
            this.textBlock5.Vertical = false;
            this.textBlock5.WhereReturn = ((byte)(0));
            // 
            // txb_NewProject
            // 
            this.txb_NewProject.ActiveColor = System.Drawing.Color.Silver;
            this.txb_NewProject.BackColor = System.Drawing.Color.Transparent;
            this.txb_NewProject.DataBindingInfo = null;
            this.txb_NewProject.DoubleValue = double.NaN;
            this.txb_NewProject.EnableMobileRound = true;
            this.txb_NewProject.EnableNullValue = false;
            this.txb_NewProject.FillColor = System.Drawing.Color.Silver;
            this.txb_NewProject.FloatValue = float.NaN;
            this.txb_NewProject.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.txb_NewProject.ForeColor = System.Drawing.Color.Black;
            this.txb_NewProject.GreyPattern = true;
            this.txb_NewProject.IntValue = -2147483648;
            this.txb_NewProject.LineThickness = 2F;
            this.txb_NewProject.Location = new System.Drawing.Point(12, 135);
            this.txb_NewProject.MainBindableProperty = "";
            this.txb_NewProject.Name = "txb_NewProject";
            this.txb_NewProject.Radius = 30;
            this.txb_NewProject.Size = new System.Drawing.Size(230, 31);
            this.txb_NewProject.StaticColor = System.Drawing.Color.Silver;
            this.txb_NewProject.TabIndex = 3;
            this.txb_NewProject.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_NewProject.TextBackColor = System.Drawing.Color.Silver;
            this.txb_NewProject.TextBoxStyle = dotNetLab.Widgets.MobileTextBox.TextBoxStyles.Mobile;
            this.txb_NewProject.UIElementBinders = null;
            this.txb_NewProject.WhitePattern = false;
            // 
            // textBlock6
            // 
            this.textBlock6.BackColor = System.Drawing.Color.Transparent;
            this.textBlock6.BorderColor = System.Drawing.Color.Empty;
            this.textBlock6.BorderThickness = 0;
            this.textBlock6.DataBindingInfo = null;
            this.textBlock6.EnableFlag = true;
            this.textBlock6.EnableTextRenderHint = true;
            this.textBlock6.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock6.FlagColor = System.Drawing.Color.DeepSkyBlue;
            this.textBlock6.FlagThickness = 7;
            this.textBlock6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock6.GapBetweenTextFlag = 10;
            this.textBlock6.LEDStyle = false;
            this.textBlock6.Location = new System.Drawing.Point(12, 175);
            this.textBlock6.MainBindableProperty = "基于此项目创建新项目";
            this.textBlock6.Name = "textBlock6";
            this.textBlock6.Radius = 0;
            this.textBlock6.Size = new System.Drawing.Size(193, 20);
            this.textBlock6.TabIndex = 1;
            this.textBlock6.Text = "基于此项目创建新项目";
            this.textBlock6.UIElementBinders = null;
            this.textBlock6.UnderLine = false;
            this.textBlock6.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock6.UnderLineThickness = 2F;
            this.textBlock6.Vertical = false;
            this.textBlock6.WhereReturn = ((byte)(0));
            // 
            // textBlock4
            // 
            this.textBlock4.BackColor = System.Drawing.Color.Transparent;
            this.textBlock4.BorderColor = System.Drawing.Color.Empty;
            this.textBlock4.BorderThickness = 0;
            this.textBlock4.DataBindingInfo = null;
            this.textBlock4.EnableFlag = true;
            this.textBlock4.EnableTextRenderHint = true;
            this.textBlock4.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock4.FlagColor = System.Drawing.Color.Green;
            this.textBlock4.FlagThickness = 7;
            this.textBlock4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock4.GapBetweenTextFlag = 10;
            this.textBlock4.LEDStyle = false;
            this.textBlock4.Location = new System.Drawing.Point(12, 109);
            this.textBlock4.MainBindableProperty = "新建项目";
            this.textBlock4.Name = "textBlock4";
            this.textBlock4.Radius = 0;
            this.textBlock4.Size = new System.Drawing.Size(96, 20);
            this.textBlock4.TabIndex = 1;
            this.textBlock4.Text = "新建项目";
            this.textBlock4.UIElementBinders = null;
            this.textBlock4.UnderLine = false;
            this.textBlock4.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock4.UnderLineThickness = 2F;
            this.textBlock4.Vertical = false;
            this.textBlock4.WhereReturn = ((byte)(0));
            // 
            // textBlock3
            // 
            this.textBlock3.BackColor = System.Drawing.Color.Transparent;
            this.textBlock3.BorderColor = System.Drawing.Color.Empty;
            this.textBlock3.BorderThickness = 0;
            this.textBlock3.DataBindingInfo = null;
            this.textBlock3.EnableFlag = true;
            this.textBlock3.EnableTextRenderHint = true;
            this.textBlock3.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock3.FlagColor = System.Drawing.Color.Crimson;
            this.textBlock3.FlagThickness = 7;
            this.textBlock3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock3.GapBetweenTextFlag = 10;
            this.textBlock3.LEDStyle = false;
            this.textBlock3.Location = new System.Drawing.Point(12, 46);
            this.textBlock3.MainBindableProperty = "当前项目";
            this.textBlock3.Name = "textBlock3";
            this.textBlock3.Radius = 0;
            this.textBlock3.Size = new System.Drawing.Size(96, 20);
            this.textBlock3.TabIndex = 1;
            this.textBlock3.Text = "当前项目";
            this.textBlock3.UIElementBinders = null;
            this.textBlock3.UnderLine = false;
            this.textBlock3.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock3.UnderLineThickness = 2F;
            this.textBlock3.Vertical = false;
            this.textBlock3.WhereReturn = ((byte)(0));
            // 
            // textBlock1
            // 
            this.textBlock1.BackColor = System.Drawing.Color.Transparent;
            this.textBlock1.BorderColor = System.Drawing.Color.Empty;
            this.textBlock1.BorderThickness = 0;
            this.textBlock1.DataBindingInfo = null;
            this.textBlock1.EnableFlag = false;
            this.textBlock1.EnableTextRenderHint = false;
            this.textBlock1.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock1.FlagColor = System.Drawing.Color.DodgerBlue;
            this.textBlock1.FlagThickness = 5;
            this.textBlock1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock1.ForeColor = System.Drawing.Color.White;
            this.textBlock1.GapBetweenTextFlag = 10;
            this.textBlock1.LEDStyle = false;
            this.textBlock1.Location = new System.Drawing.Point(67, 14);
            this.textBlock1.MainBindableProperty = "项目管理";
            this.textBlock1.Name = "textBlock1";
            this.textBlock1.Radius = 0;
            this.textBlock1.Size = new System.Drawing.Size(109, 17);
            this.textBlock1.TabIndex = 0;
            this.textBlock1.Text = "项目管理";
            this.textBlock1.UIElementBinders = null;
            this.textBlock1.UnderLine = false;
            this.textBlock1.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock1.UnderLineThickness = 2F;
            this.textBlock1.Vertical = false;
            this.textBlock1.WhereReturn = ((byte)(0));
            // 
            // MenuForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.ClipboardText = "mobileTextBox4";
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.colorDecorator1);
            this.Name = "MenuForm";
            this.Text = "控制面板";
            this.TitlePos = new System.Drawing.Point(80, 15);
            this.Controls.SetChildIndex(this.colorDecorator1, 0);
            this.Controls.SetChildIndex(this.card1, 0);
            this.Controls.SetChildIndex(this.card2, 0);
            this.card2.ResumeLayout(false);
            this.card2.PerformLayout();
            this.card1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
