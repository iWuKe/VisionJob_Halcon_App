using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shikii.VisionJob
{
   public  class TCPNetConnectForm : dotNetLab.Common.ModernUI.SessionPage
    {
        private dotNetLab.Widgets.MobileTextBox mobileTextBox3;
        private dotNetLab.Widgets.MobileTextBox mobileTextBox1;
        private dotNetLab.Widgets.MobileTextBox mobileTextBox2;
        private dotNetLab.Widgets.TextBlock textBlock9;
        private dotNetLab.Widgets.TextBlock textBlock8;
        private dotNetLab.Widgets.Card card1;
        private dotNetLab.Widgets.TextBlock textBlock1;
        private dotNetLab.Widgets.Card card2;
        private dotNetLab.Widgets.TextBlock textBlock2;
        private dotNetLab.Widgets.TextBlock textBlock3;
        private dotNetLab.Widgets.MobileTextBox mobileTextBox4;
        private dotNetLab.Widgets.TextBlock textBlock4;
        private dotNetLab.Widgets.TextBlock textBlock5;
        private dotNetLab.Widgets.MobileTextBox mobileTextBox5;
        private dotNetLab.Widgets.MobileTextBox mobileTextBox6;
        private dotNetLab.Widgets.TextBlock textBlock11;
        private dotNetLab.Widgets.TextBlock textBlock10;
        private dotNetLab.Widgets.TextBlock textBlock6;
        private dotNetLab.Widgets.MobileTextBox mobileTextBox9;
        private dotNetLab.Widgets.MobileTextBox mobileTextBox8;
        private dotNetLab.Widgets.MobileTextBox mobileTextBox7;
        private dotNetLab.Widgets.TextBlock textBlock7;

        protected override void prepareCtrls()
        {
            base.prepareCtrls();
            InitializeComponent();
            
        }


        private void InitializeComponent()
        {
            dotNetLab.Widgets.UIBinding.UIElementBinderInfo uiElementBinderInfo1 = new dotNetLab.Widgets.UIBinding.UIElementBinderInfo();
            dotNetLab.Widgets.UIBinding.UIElementBinderInfo uiElementBinderInfo2 = new dotNetLab.Widgets.UIBinding.UIElementBinderInfo();
            dotNetLab.Widgets.UIBinding.UIElementBinderInfo uiElementBinderInfo3 = new dotNetLab.Widgets.UIBinding.UIElementBinderInfo();
            dotNetLab.Widgets.UIBinding.UIElementBinderInfo uiElementBinderInfo4 = new dotNetLab.Widgets.UIBinding.UIElementBinderInfo();
            dotNetLab.Widgets.UIBinding.UIElementBinderInfo uiElementBinderInfo8 = new dotNetLab.Widgets.UIBinding.UIElementBinderInfo();
            dotNetLab.Widgets.UIBinding.UIElementBinderInfo uiElementBinderInfo9 = new dotNetLab.Widgets.UIBinding.UIElementBinderInfo();
            dotNetLab.Widgets.UIBinding.UIElementBinderInfo uiElementBinderInfo7 = new dotNetLab.Widgets.UIBinding.UIElementBinderInfo();
            dotNetLab.Widgets.UIBinding.UIElementBinderInfo uiElementBinderInfo6 = new dotNetLab.Widgets.UIBinding.UIElementBinderInfo();
            dotNetLab.Widgets.UIBinding.UIElementBinderInfo uiElementBinderInfo5 = new dotNetLab.Widgets.UIBinding.UIElementBinderInfo();
            this.mobileTextBox3 = new dotNetLab.Widgets.MobileTextBox();
            this.mobileTextBox1 = new dotNetLab.Widgets.MobileTextBox();
            this.mobileTextBox2 = new dotNetLab.Widgets.MobileTextBox();
            this.textBlock9 = new dotNetLab.Widgets.TextBlock();
            this.textBlock8 = new dotNetLab.Widgets.TextBlock();
            this.textBlock7 = new dotNetLab.Widgets.TextBlock();
            this.card1 = new dotNetLab.Widgets.Card();
            this.textBlock1 = new dotNetLab.Widgets.TextBlock();
            this.card2 = new dotNetLab.Widgets.Card();
            this.textBlock2 = new dotNetLab.Widgets.TextBlock();
            this.textBlock3 = new dotNetLab.Widgets.TextBlock();
            this.mobileTextBox4 = new dotNetLab.Widgets.MobileTextBox();
            this.textBlock4 = new dotNetLab.Widgets.TextBlock();
            this.textBlock5 = new dotNetLab.Widgets.TextBlock();
            this.mobileTextBox5 = new dotNetLab.Widgets.MobileTextBox();
            this.mobileTextBox6 = new dotNetLab.Widgets.MobileTextBox();
            this.mobileTextBox7 = new dotNetLab.Widgets.MobileTextBox();
            this.textBlock6 = new dotNetLab.Widgets.TextBlock();
            this.textBlock10 = new dotNetLab.Widgets.TextBlock();
            this.mobileTextBox8 = new dotNetLab.Widgets.MobileTextBox();
            this.mobileTextBox9 = new dotNetLab.Widgets.MobileTextBox();
            this.textBlock11 = new dotNetLab.Widgets.TextBlock();
            this.card1.SuspendLayout();
            this.card2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipper
            // 
            this.tipper.Location = new System.Drawing.Point(311, 467);
            // 
            // mobileTextBox3
            // 
            this.mobileTextBox3.ActiveColor = System.Drawing.Color.Cyan;
            this.mobileTextBox3.BackColor = System.Drawing.Color.Transparent;
            uiElementBinderInfo1.DBEngineIndex = 0;
            uiElementBinderInfo1.EnableCheckBox_One_Zero = false;
            uiElementBinderInfo1.FieldName = "Val";
            uiElementBinderInfo1.Filter = "Name=\'LoopGapTime\' ";
            uiElementBinderInfo1.Ptr = null;
            uiElementBinderInfo1.StoreInDB = true;
            uiElementBinderInfo1.StoreIntoDBRealTime = true;
            uiElementBinderInfo1.TableName = "App_Extension_Data_Table";
            uiElementBinderInfo1.ThisControl = this.mobileTextBox3;
            this.mobileTextBox3.DataBindingInfo = uiElementBinderInfo1;
            this.mobileTextBox3.DoubleValue = double.NaN;
            this.mobileTextBox3.EnableMobileRound = true;
            this.mobileTextBox3.EnableNullValue = false;
            this.mobileTextBox3.FillColor = System.Drawing.Color.Transparent;
            this.mobileTextBox3.FloatValue = float.NaN;
            this.mobileTextBox3.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.mobileTextBox3.ForeColor = System.Drawing.Color.Black;
            this.mobileTextBox3.GreyPattern = false;
            this.mobileTextBox3.IntValue = -2147483648;
            this.mobileTextBox3.LineThickness = 2F;
            this.mobileTextBox3.Location = new System.Drawing.Point(187, 130);
            this.mobileTextBox3.MainBindableProperty = "";
            this.mobileTextBox3.Name = "mobileTextBox3";
            this.mobileTextBox3.Radius = 29;
            this.mobileTextBox3.Size = new System.Drawing.Size(187, 30);
            this.mobileTextBox3.StaticColor = System.Drawing.Color.Gray;
            this.mobileTextBox3.TabIndex = 7;
            this.mobileTextBox3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.mobileTextBox3.TextBackColor = System.Drawing.SystemColors.Window;
            this.mobileTextBox3.TextBoxStyle = dotNetLab.Widgets.MobileTextBox.TextBoxStyles.Mobile;
            this.mobileTextBox3.UIElementBinders = null;
            this.mobileTextBox3.WhitePattern = false;
            // 
            // mobileTextBox1
            // 
            this.mobileTextBox1.ActiveColor = System.Drawing.Color.Cyan;
            this.mobileTextBox1.BackColor = System.Drawing.Color.Transparent;
            uiElementBinderInfo2.DBEngineIndex = 0;
            uiElementBinderInfo2.EnableCheckBox_One_Zero = false;
            uiElementBinderInfo2.FieldName = "Val";
            uiElementBinderInfo2.Filter = "Name=\'IP\' ";
            uiElementBinderInfo2.Ptr = null;
            uiElementBinderInfo2.StoreInDB = true;
            uiElementBinderInfo2.StoreIntoDBRealTime = true;
            uiElementBinderInfo2.TableName = "App_Extension_Data_Table";
            uiElementBinderInfo2.ThisControl = this.mobileTextBox1;
            this.mobileTextBox1.DataBindingInfo = uiElementBinderInfo2;
            this.mobileTextBox1.DoubleValue = double.NaN;
            this.mobileTextBox1.EnableMobileRound = true;
            this.mobileTextBox1.EnableNullValue = false;
            this.mobileTextBox1.FillColor = System.Drawing.Color.Transparent;
            this.mobileTextBox1.FloatValue = float.NaN;
            this.mobileTextBox1.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.mobileTextBox1.ForeColor = System.Drawing.Color.Black;
            this.mobileTextBox1.GreyPattern = false;
            this.mobileTextBox1.IntValue = -2147483648;
            this.mobileTextBox1.LineThickness = 2F;
            this.mobileTextBox1.Location = new System.Drawing.Point(187, 42);
            this.mobileTextBox1.MainBindableProperty = "";
            this.mobileTextBox1.Name = "mobileTextBox1";
            this.mobileTextBox1.Radius = 29;
            this.mobileTextBox1.Size = new System.Drawing.Size(187, 30);
            this.mobileTextBox1.StaticColor = System.Drawing.Color.Gray;
            this.mobileTextBox1.TabIndex = 8;
            this.mobileTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.mobileTextBox1.TextBackColor = System.Drawing.SystemColors.Window;
            this.mobileTextBox1.TextBoxStyle = dotNetLab.Widgets.MobileTextBox.TextBoxStyles.Mobile;
            this.mobileTextBox1.UIElementBinders = null;
            this.mobileTextBox1.WhitePattern = false;
            // 
            // mobileTextBox2
            // 
            this.mobileTextBox2.ActiveColor = System.Drawing.Color.Cyan;
            this.mobileTextBox2.BackColor = System.Drawing.Color.Transparent;
            uiElementBinderInfo3.DBEngineIndex = 0;
            uiElementBinderInfo3.EnableCheckBox_One_Zero = false;
            uiElementBinderInfo3.FieldName = "Val";
            uiElementBinderInfo3.Filter = "Name=\'Port\' ";
            uiElementBinderInfo3.Ptr = null;
            uiElementBinderInfo3.StoreInDB = true;
            uiElementBinderInfo3.StoreIntoDBRealTime = true;
            uiElementBinderInfo3.TableName = "App_Extension_Data_Table";
            uiElementBinderInfo3.ThisControl = this.mobileTextBox2;
            this.mobileTextBox2.DataBindingInfo = uiElementBinderInfo3;
            this.mobileTextBox2.DoubleValue = double.NaN;
            this.mobileTextBox2.EnableMobileRound = true;
            this.mobileTextBox2.EnableNullValue = false;
            this.mobileTextBox2.FillColor = System.Drawing.Color.Transparent;
            this.mobileTextBox2.FloatValue = float.NaN;
            this.mobileTextBox2.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.mobileTextBox2.ForeColor = System.Drawing.Color.Black;
            this.mobileTextBox2.GreyPattern = false;
            this.mobileTextBox2.IntValue = -2147483648;
            this.mobileTextBox2.LineThickness = 2F;
            this.mobileTextBox2.Location = new System.Drawing.Point(187, 87);
            this.mobileTextBox2.MainBindableProperty = "";
            this.mobileTextBox2.Name = "mobileTextBox2";
            this.mobileTextBox2.Radius = 29;
            this.mobileTextBox2.Size = new System.Drawing.Size(187, 30);
            this.mobileTextBox2.StaticColor = System.Drawing.Color.Gray;
            this.mobileTextBox2.TabIndex = 9;
            this.mobileTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.mobileTextBox2.TextBackColor = System.Drawing.SystemColors.Window;
            this.mobileTextBox2.TextBoxStyle = dotNetLab.Widgets.MobileTextBox.TextBoxStyles.Mobile;
            this.mobileTextBox2.UIElementBinders = null;
            this.mobileTextBox2.WhitePattern = false;
            // 
            // textBlock9
            // 
            this.textBlock9.BackColor = System.Drawing.Color.Transparent;
            this.textBlock9.BorderColor = System.Drawing.Color.Empty;
            this.textBlock9.BorderThickness = 0;
            this.textBlock9.DataBindingInfo = null;
            this.textBlock9.EnableFlag = true;
            this.textBlock9.EnableTextRenderHint = true;
            this.textBlock9.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock9.FlagColor = System.Drawing.Color.DodgerBlue;
            this.textBlock9.FlagThickness = 8;
            this.textBlock9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock9.GapBetweenTextFlag = 10;
            this.textBlock9.LEDStyle = false;
            this.textBlock9.Location = new System.Drawing.Point(87, 137);
            this.textBlock9.MainBindableProperty = "轮询频率";
            this.textBlock9.Name = "textBlock9";
            this.textBlock9.Radius = 0;
            this.textBlock9.Size = new System.Drawing.Size(94, 23);
            this.textBlock9.TabIndex = 4;
            this.textBlock9.Text = "轮询频率";
            this.textBlock9.UIElementBinders = null;
            this.textBlock9.UnderLine = false;
            this.textBlock9.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock9.UnderLineThickness = 2F;
            this.textBlock9.Vertical = false;
            this.textBlock9.WhereReturn = ((byte)(0));
            // 
            // textBlock8
            // 
            this.textBlock8.BackColor = System.Drawing.Color.Transparent;
            this.textBlock8.BorderColor = System.Drawing.Color.Empty;
            this.textBlock8.BorderThickness = 0;
            this.textBlock8.DataBindingInfo = null;
            this.textBlock8.EnableFlag = true;
            this.textBlock8.EnableTextRenderHint = true;
            this.textBlock8.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock8.FlagColor = System.Drawing.Color.DodgerBlue;
            this.textBlock8.FlagThickness = 8;
            this.textBlock8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock8.GapBetweenTextFlag = 10;
            this.textBlock8.LEDStyle = false;
            this.textBlock8.Location = new System.Drawing.Point(87, 87);
            this.textBlock8.MainBindableProperty = "端口号";
            this.textBlock8.Name = "textBlock8";
            this.textBlock8.Radius = 0;
            this.textBlock8.Size = new System.Drawing.Size(76, 23);
            this.textBlock8.TabIndex = 5;
            this.textBlock8.Text = "端口号";
            this.textBlock8.UIElementBinders = null;
            this.textBlock8.UnderLine = false;
            this.textBlock8.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock8.UnderLineThickness = 2F;
            this.textBlock8.Vertical = false;
            this.textBlock8.WhereReturn = ((byte)(0));
            // 
            // textBlock7
            // 
            this.textBlock7.BackColor = System.Drawing.Color.Transparent;
            this.textBlock7.BorderColor = System.Drawing.Color.Empty;
            this.textBlock7.BorderThickness = 0;
            this.textBlock7.DataBindingInfo = null;
            this.textBlock7.EnableFlag = true;
            this.textBlock7.EnableTextRenderHint = true;
            this.textBlock7.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock7.FlagColor = System.Drawing.Color.DodgerBlue;
            this.textBlock7.FlagThickness = 8;
            this.textBlock7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock7.GapBetweenTextFlag = 10;
            this.textBlock7.LEDStyle = false;
            this.textBlock7.Location = new System.Drawing.Point(87, 42);
            this.textBlock7.MainBindableProperty = "IP";
            this.textBlock7.Name = "textBlock7";
            this.textBlock7.Radius = 0;
            this.textBlock7.Size = new System.Drawing.Size(45, 23);
            this.textBlock7.TabIndex = 6;
            this.textBlock7.Text = "IP";
            this.textBlock7.UIElementBinders = null;
            this.textBlock7.UnderLine = false;
            this.textBlock7.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock7.UnderLineThickness = 2F;
            this.textBlock7.Vertical = false;
            this.textBlock7.WhereReturn = ((byte)(0));
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.Transparent;
            this.card1.BorderColor = System.Drawing.Color.Gray;
            this.card1.BorderThickness = -1;
            this.card1.Controls.Add(this.textBlock1);
            this.card1.Controls.Add(this.textBlock7);
            this.card1.Controls.Add(this.mobileTextBox3);
            this.card1.Controls.Add(this.textBlock8);
            this.card1.Controls.Add(this.textBlock9);
            this.card1.Controls.Add(this.mobileTextBox1);
            this.card1.Controls.Add(this.mobileTextBox2);
            this.card1.CornerAlignment = dotNetLab.Widgets.Alignments.All;
            this.card1.DataBindingInfo = null;
            this.card1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.card1.HeadColor = System.Drawing.Color.DodgerBlue;
            this.card1.HeaderAlignment = dotNetLab.Widgets.Alignments.Left;
            this.card1.HeadHeight = 50;
            this.card1.ImagePos = new System.Drawing.Point(0, 0);
            this.card1.ImageSize = new System.Drawing.Size(0, 0);
            this.card1.Location = new System.Drawing.Point(82, 84);
            this.card1.MainBindableProperty = "card1";
            this.card1.Name = "card1";
            this.card1.NormalColor = System.Drawing.Color.Snow;
            this.card1.Radius = 10;
            this.card1.Size = new System.Drawing.Size(446, 200);
            this.card1.Source = null;
            this.card1.TabIndex = 10;
            this.card1.Text = "card1";
            this.card1.UIElementBinders = null;
            // 
            // textBlock1
            // 
            this.textBlock1.BackColor = System.Drawing.Color.Transparent;
            this.textBlock1.BorderColor = System.Drawing.Color.Empty;
            this.textBlock1.BorderThickness = -1;
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
            this.textBlock1.Location = new System.Drawing.Point(12, 42);
            this.textBlock1.MainBindableProperty = "以太网设置";
            this.textBlock1.Name = "textBlock1";
            this.textBlock1.Radius = -1;
            this.textBlock1.Size = new System.Drawing.Size(27, 117);
            this.textBlock1.TabIndex = 10;
            this.textBlock1.Text = "以太网设置";
            this.textBlock1.UIElementBinders = null;
            this.textBlock1.UnderLine = false;
            this.textBlock1.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock1.UnderLineThickness = 2F;
            this.textBlock1.Vertical = true;
            this.textBlock1.WhereReturn = ((byte)(0));
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.Transparent;
            this.card2.BorderColor = System.Drawing.Color.Gray;
            this.card2.BorderThickness = -1;
            this.card2.Controls.Add(this.textBlock2);
            this.card2.Controls.Add(this.textBlock11);
            this.card2.Controls.Add(this.textBlock10);
            this.card2.Controls.Add(this.textBlock6);
            this.card2.Controls.Add(this.textBlock3);
            this.card2.Controls.Add(this.mobileTextBox4);
            this.card2.Controls.Add(this.mobileTextBox9);
            this.card2.Controls.Add(this.textBlock4);
            this.card2.Controls.Add(this.mobileTextBox8);
            this.card2.Controls.Add(this.mobileTextBox7);
            this.card2.Controls.Add(this.textBlock5);
            this.card2.Controls.Add(this.mobileTextBox5);
            this.card2.Controls.Add(this.mobileTextBox6);
            this.card2.CornerAlignment = dotNetLab.Widgets.Alignments.All;
            this.card2.DataBindingInfo = null;
            this.card2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.card2.HeadColor = System.Drawing.Color.Crimson;
            this.card2.HeaderAlignment = dotNetLab.Widgets.Alignments.Up;
            this.card2.HeadHeight = 40;
            this.card2.ImagePos = new System.Drawing.Point(0, 0);
            this.card2.ImageSize = new System.Drawing.Size(0, 0);
            this.card2.Location = new System.Drawing.Point(82, 301);
            this.card2.MainBindableProperty = "card1";
            this.card2.Name = "card2";
            this.card2.NormalColor = System.Drawing.Color.Snow;
            this.card2.Radius = 10;
            this.card2.Size = new System.Drawing.Size(446, 200);
            this.card2.Source = null;
            this.card2.TabIndex = 10;
            this.card2.Text = "card1";
            this.card2.UIElementBinders = null;
            this.card2.Load += new System.EventHandler(this.card2_Load);
            // 
            // textBlock2
            // 
            this.textBlock2.BackColor = System.Drawing.Color.Transparent;
            this.textBlock2.BorderColor = System.Drawing.Color.Empty;
            this.textBlock2.BorderThickness = -1;
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
            this.textBlock2.Location = new System.Drawing.Point(159, 8);
            this.textBlock2.MainBindableProperty = "串口设置";
            this.textBlock2.Name = "textBlock2";
            this.textBlock2.Radius = -1;
            this.textBlock2.Size = new System.Drawing.Size(120, 28);
            this.textBlock2.TabIndex = 10;
            this.textBlock2.Text = "串口设置";
            this.textBlock2.UIElementBinders = null;
            this.textBlock2.UnderLine = false;
            this.textBlock2.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock2.UnderLineThickness = 2F;
            this.textBlock2.Vertical = false;
            this.textBlock2.WhereReturn = ((byte)(0));
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
            this.textBlock3.FlagThickness = 8;
            this.textBlock3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock3.GapBetweenTextFlag = 10;
            this.textBlock3.LEDStyle = false;
            this.textBlock3.Location = new System.Drawing.Point(12, 52);
            this.textBlock3.MainBindableProperty = "端口名：";
            this.textBlock3.Name = "textBlock3";
            this.textBlock3.Radius = 0;
            this.textBlock3.Size = new System.Drawing.Size(76, 23);
            this.textBlock3.TabIndex = 6;
            this.textBlock3.Text = "端口名：";
            this.textBlock3.UIElementBinders = null;
            this.textBlock3.UnderLine = false;
            this.textBlock3.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock3.UnderLineThickness = 2F;
            this.textBlock3.Vertical = false;
            this.textBlock3.WhereReturn = ((byte)(0));
            // 
            // mobileTextBox4
            // 
            this.mobileTextBox4.ActiveColor = System.Drawing.Color.Cyan;
            this.mobileTextBox4.BackColor = System.Drawing.Color.Transparent;
            uiElementBinderInfo4.DBEngineIndex = 0;
            uiElementBinderInfo4.EnableCheckBox_One_Zero = false;
            uiElementBinderInfo4.FieldName = "Val";
            uiElementBinderInfo4.Filter = "Name=\'LoopGapTime\' ";
            uiElementBinderInfo4.Ptr = null;
            uiElementBinderInfo4.StoreInDB = true;
            uiElementBinderInfo4.StoreIntoDBRealTime = true;
            uiElementBinderInfo4.TableName = "App_Extension_Data_Table";
            uiElementBinderInfo4.ThisControl = this.mobileTextBox4;
            this.mobileTextBox4.DataBindingInfo = uiElementBinderInfo4;
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
            this.mobileTextBox4.Location = new System.Drawing.Point(112, 140);
            this.mobileTextBox4.MainBindableProperty = "";
            this.mobileTextBox4.Name = "mobileTextBox4";
            this.mobileTextBox4.Radius = 29;
            this.mobileTextBox4.Size = new System.Drawing.Size(98, 30);
            this.mobileTextBox4.StaticColor = System.Drawing.Color.Gray;
            this.mobileTextBox4.TabIndex = 7;
            this.mobileTextBox4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.mobileTextBox4.TextBackColor = System.Drawing.SystemColors.Window;
            this.mobileTextBox4.TextBoxStyle = dotNetLab.Widgets.MobileTextBox.TextBoxStyles.Mobile;
            this.mobileTextBox4.UIElementBinders = null;
            this.mobileTextBox4.WhitePattern = false;
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
            this.textBlock4.FlagColor = System.Drawing.Color.Crimson;
            this.textBlock4.FlagThickness = 8;
            this.textBlock4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock4.GapBetweenTextFlag = 10;
            this.textBlock4.LEDStyle = false;
            this.textBlock4.Location = new System.Drawing.Point(12, 97);
            this.textBlock4.MainBindableProperty = "波特率";
            this.textBlock4.Name = "textBlock4";
            this.textBlock4.Radius = 0;
            this.textBlock4.Size = new System.Drawing.Size(76, 23);
            this.textBlock4.TabIndex = 5;
            this.textBlock4.Text = "波特率";
            this.textBlock4.UIElementBinders = null;
            this.textBlock4.UnderLine = false;
            this.textBlock4.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock4.UnderLineThickness = 2F;
            this.textBlock4.Vertical = false;
            this.textBlock4.WhereReturn = ((byte)(0));
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
            this.textBlock5.FlagColor = System.Drawing.Color.Crimson;
            this.textBlock5.FlagThickness = 8;
            this.textBlock5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock5.GapBetweenTextFlag = 10;
            this.textBlock5.LEDStyle = false;
            this.textBlock5.Location = new System.Drawing.Point(12, 147);
            this.textBlock5.MainBindableProperty = "轮询频率";
            this.textBlock5.Name = "textBlock5";
            this.textBlock5.Radius = 0;
            this.textBlock5.Size = new System.Drawing.Size(94, 23);
            this.textBlock5.TabIndex = 4;
            this.textBlock5.Text = "轮询频率";
            this.textBlock5.UIElementBinders = null;
            this.textBlock5.UnderLine = false;
            this.textBlock5.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock5.UnderLineThickness = 2F;
            this.textBlock5.Vertical = false;
            this.textBlock5.WhereReturn = ((byte)(0));
            // 
            // mobileTextBox5
            // 
            this.mobileTextBox5.ActiveColor = System.Drawing.Color.Cyan;
            this.mobileTextBox5.BackColor = System.Drawing.Color.Transparent;
            uiElementBinderInfo8.DBEngineIndex = 0;
            uiElementBinderInfo8.EnableCheckBox_One_Zero = false;
            uiElementBinderInfo8.FieldName = "Val";
            uiElementBinderInfo8.Filter = "Name=\'IP\' ";
            uiElementBinderInfo8.Ptr = null;
            uiElementBinderInfo8.StoreInDB = true;
            uiElementBinderInfo8.StoreIntoDBRealTime = true;
            uiElementBinderInfo8.TableName = "App_Extension_Data_Table";
            uiElementBinderInfo8.ThisControl = this.mobileTextBox5;
            this.mobileTextBox5.DataBindingInfo = uiElementBinderInfo8;
            this.mobileTextBox5.DoubleValue = double.NaN;
            this.mobileTextBox5.EnableMobileRound = true;
            this.mobileTextBox5.EnableNullValue = false;
            this.mobileTextBox5.FillColor = System.Drawing.Color.Transparent;
            this.mobileTextBox5.FloatValue = float.NaN;
            this.mobileTextBox5.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.mobileTextBox5.ForeColor = System.Drawing.Color.Black;
            this.mobileTextBox5.GreyPattern = false;
            this.mobileTextBox5.IntValue = -2147483648;
            this.mobileTextBox5.LineThickness = 2F;
            this.mobileTextBox5.Location = new System.Drawing.Point(112, 52);
            this.mobileTextBox5.MainBindableProperty = "";
            this.mobileTextBox5.Name = "mobileTextBox5";
            this.mobileTextBox5.Radius = 29;
            this.mobileTextBox5.Size = new System.Drawing.Size(98, 30);
            this.mobileTextBox5.StaticColor = System.Drawing.Color.Gray;
            this.mobileTextBox5.TabIndex = 8;
            this.mobileTextBox5.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.mobileTextBox5.TextBackColor = System.Drawing.SystemColors.Window;
            this.mobileTextBox5.TextBoxStyle = dotNetLab.Widgets.MobileTextBox.TextBoxStyles.Mobile;
            this.mobileTextBox5.UIElementBinders = null;
            this.mobileTextBox5.WhitePattern = false;
            // 
            // mobileTextBox6
            // 
            this.mobileTextBox6.ActiveColor = System.Drawing.Color.Cyan;
            this.mobileTextBox6.BackColor = System.Drawing.Color.Transparent;
            uiElementBinderInfo9.DBEngineIndex = 0;
            uiElementBinderInfo9.EnableCheckBox_One_Zero = false;
            uiElementBinderInfo9.FieldName = "Val";
            uiElementBinderInfo9.Filter = "Name=\'Port\' ";
            uiElementBinderInfo9.Ptr = null;
            uiElementBinderInfo9.StoreInDB = true;
            uiElementBinderInfo9.StoreIntoDBRealTime = true;
            uiElementBinderInfo9.TableName = "App_Extension_Data_Table";
            uiElementBinderInfo9.ThisControl = this.mobileTextBox6;
            this.mobileTextBox6.DataBindingInfo = uiElementBinderInfo9;
            this.mobileTextBox6.DoubleValue = double.NaN;
            this.mobileTextBox6.EnableMobileRound = true;
            this.mobileTextBox6.EnableNullValue = false;
            this.mobileTextBox6.FillColor = System.Drawing.Color.Transparent;
            this.mobileTextBox6.FloatValue = float.NaN;
            this.mobileTextBox6.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.mobileTextBox6.ForeColor = System.Drawing.Color.Black;
            this.mobileTextBox6.GreyPattern = false;
            this.mobileTextBox6.IntValue = -2147483648;
            this.mobileTextBox6.LineThickness = 2F;
            this.mobileTextBox6.Location = new System.Drawing.Point(112, 97);
            this.mobileTextBox6.MainBindableProperty = "";
            this.mobileTextBox6.Name = "mobileTextBox6";
            this.mobileTextBox6.Radius = 29;
            this.mobileTextBox6.Size = new System.Drawing.Size(98, 30);
            this.mobileTextBox6.StaticColor = System.Drawing.Color.Gray;
            this.mobileTextBox6.TabIndex = 9;
            this.mobileTextBox6.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.mobileTextBox6.TextBackColor = System.Drawing.SystemColors.Window;
            this.mobileTextBox6.TextBoxStyle = dotNetLab.Widgets.MobileTextBox.TextBoxStyles.Mobile;
            this.mobileTextBox6.UIElementBinders = null;
            this.mobileTextBox6.WhitePattern = false;
            // 
            // mobileTextBox7
            // 
            this.mobileTextBox7.ActiveColor = System.Drawing.Color.Cyan;
            this.mobileTextBox7.BackColor = System.Drawing.Color.Transparent;
            uiElementBinderInfo7.DBEngineIndex = 0;
            uiElementBinderInfo7.EnableCheckBox_One_Zero = false;
            uiElementBinderInfo7.FieldName = "Val";
            uiElementBinderInfo7.Filter = "Name=\'IP\' ";
            uiElementBinderInfo7.Ptr = null;
            uiElementBinderInfo7.StoreInDB = true;
            uiElementBinderInfo7.StoreIntoDBRealTime = true;
            uiElementBinderInfo7.TableName = "App_Extension_Data_Table";
            uiElementBinderInfo7.ThisControl = this.mobileTextBox7;
            this.mobileTextBox7.DataBindingInfo = uiElementBinderInfo7;
            this.mobileTextBox7.DoubleValue = double.NaN;
            this.mobileTextBox7.EnableMobileRound = true;
            this.mobileTextBox7.EnableNullValue = false;
            this.mobileTextBox7.FillColor = System.Drawing.Color.Transparent;
            this.mobileTextBox7.FloatValue = float.NaN;
            this.mobileTextBox7.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.mobileTextBox7.ForeColor = System.Drawing.Color.Black;
            this.mobileTextBox7.GreyPattern = false;
            this.mobileTextBox7.IntValue = -2147483648;
            this.mobileTextBox7.LineThickness = 2F;
            this.mobileTextBox7.Location = new System.Drawing.Point(316, 52);
            this.mobileTextBox7.MainBindableProperty = "";
            this.mobileTextBox7.Name = "mobileTextBox7";
            this.mobileTextBox7.Radius = 29;
            this.mobileTextBox7.Size = new System.Drawing.Size(98, 30);
            this.mobileTextBox7.StaticColor = System.Drawing.Color.Gray;
            this.mobileTextBox7.TabIndex = 8;
            this.mobileTextBox7.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.mobileTextBox7.TextBackColor = System.Drawing.SystemColors.Window;
            this.mobileTextBox7.TextBoxStyle = dotNetLab.Widgets.MobileTextBox.TextBoxStyles.Mobile;
            this.mobileTextBox7.UIElementBinders = null;
            this.mobileTextBox7.WhitePattern = false;
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
            this.textBlock6.FlagColor = System.Drawing.Color.Crimson;
            this.textBlock6.FlagThickness = 8;
            this.textBlock6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock6.GapBetweenTextFlag = 10;
            this.textBlock6.LEDStyle = false;
            this.textBlock6.Location = new System.Drawing.Point(234, 56);
            this.textBlock6.MainBindableProperty = "数据位：";
            this.textBlock6.Name = "textBlock6";
            this.textBlock6.Radius = 0;
            this.textBlock6.Size = new System.Drawing.Size(76, 23);
            this.textBlock6.TabIndex = 6;
            this.textBlock6.Text = "数据位：";
            this.textBlock6.UIElementBinders = null;
            this.textBlock6.UnderLine = false;
            this.textBlock6.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock6.UnderLineThickness = 2F;
            this.textBlock6.Vertical = false;
            this.textBlock6.WhereReturn = ((byte)(0));
            // 
            // textBlock10
            // 
            this.textBlock10.BackColor = System.Drawing.Color.Transparent;
            this.textBlock10.BorderColor = System.Drawing.Color.Empty;
            this.textBlock10.BorderThickness = 0;
            this.textBlock10.DataBindingInfo = null;
            this.textBlock10.EnableFlag = true;
            this.textBlock10.EnableTextRenderHint = true;
            this.textBlock10.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock10.FlagColor = System.Drawing.Color.Crimson;
            this.textBlock10.FlagThickness = 8;
            this.textBlock10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock10.GapBetweenTextFlag = 10;
            this.textBlock10.LEDStyle = false;
            this.textBlock10.Location = new System.Drawing.Point(234, 104);
            this.textBlock10.MainBindableProperty = "停止位：";
            this.textBlock10.Name = "textBlock10";
            this.textBlock10.Radius = 0;
            this.textBlock10.Size = new System.Drawing.Size(76, 23);
            this.textBlock10.TabIndex = 6;
            this.textBlock10.Text = "停止位：";
            this.textBlock10.UIElementBinders = null;
            this.textBlock10.UnderLine = false;
            this.textBlock10.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock10.UnderLineThickness = 2F;
            this.textBlock10.Vertical = false;
            this.textBlock10.WhereReturn = ((byte)(0));
            // 
            // mobileTextBox8
            // 
            this.mobileTextBox8.ActiveColor = System.Drawing.Color.Cyan;
            this.mobileTextBox8.BackColor = System.Drawing.Color.Transparent;
            uiElementBinderInfo6.DBEngineIndex = 0;
            uiElementBinderInfo6.EnableCheckBox_One_Zero = false;
            uiElementBinderInfo6.FieldName = "Val";
            uiElementBinderInfo6.Filter = "Name=\'IP\' ";
            uiElementBinderInfo6.Ptr = null;
            uiElementBinderInfo6.StoreInDB = true;
            uiElementBinderInfo6.StoreIntoDBRealTime = true;
            uiElementBinderInfo6.TableName = "App_Extension_Data_Table";
            uiElementBinderInfo6.ThisControl = this.mobileTextBox8;
            this.mobileTextBox8.DataBindingInfo = uiElementBinderInfo6;
            this.mobileTextBox8.DoubleValue = double.NaN;
            this.mobileTextBox8.EnableMobileRound = true;
            this.mobileTextBox8.EnableNullValue = false;
            this.mobileTextBox8.FillColor = System.Drawing.Color.Transparent;
            this.mobileTextBox8.FloatValue = float.NaN;
            this.mobileTextBox8.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.mobileTextBox8.ForeColor = System.Drawing.Color.Black;
            this.mobileTextBox8.GreyPattern = false;
            this.mobileTextBox8.IntValue = -2147483648;
            this.mobileTextBox8.LineThickness = 2F;
            this.mobileTextBox8.Location = new System.Drawing.Point(316, 98);
            this.mobileTextBox8.MainBindableProperty = "";
            this.mobileTextBox8.Name = "mobileTextBox8";
            this.mobileTextBox8.Radius = 29;
            this.mobileTextBox8.Size = new System.Drawing.Size(98, 30);
            this.mobileTextBox8.StaticColor = System.Drawing.Color.Gray;
            this.mobileTextBox8.TabIndex = 8;
            this.mobileTextBox8.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.mobileTextBox8.TextBackColor = System.Drawing.SystemColors.Window;
            this.mobileTextBox8.TextBoxStyle = dotNetLab.Widgets.MobileTextBox.TextBoxStyles.Mobile;
            this.mobileTextBox8.UIElementBinders = null;
            this.mobileTextBox8.WhitePattern = false;
            // 
            // mobileTextBox9
            // 
            this.mobileTextBox9.ActiveColor = System.Drawing.Color.Cyan;
            this.mobileTextBox9.BackColor = System.Drawing.Color.Transparent;
            uiElementBinderInfo5.DBEngineIndex = 0;
            uiElementBinderInfo5.EnableCheckBox_One_Zero = false;
            uiElementBinderInfo5.FieldName = "Val";
            uiElementBinderInfo5.Filter = "Name=\'IP\' ";
            uiElementBinderInfo5.Ptr = null;
            uiElementBinderInfo5.StoreInDB = true;
            uiElementBinderInfo5.StoreIntoDBRealTime = true;
            uiElementBinderInfo5.TableName = "App_Extension_Data_Table";
            uiElementBinderInfo5.ThisControl = this.mobileTextBox9;
            this.mobileTextBox9.DataBindingInfo = uiElementBinderInfo5;
            this.mobileTextBox9.DoubleValue = double.NaN;
            this.mobileTextBox9.EnableMobileRound = true;
            this.mobileTextBox9.EnableNullValue = false;
            this.mobileTextBox9.FillColor = System.Drawing.Color.Transparent;
            this.mobileTextBox9.FloatValue = float.NaN;
            this.mobileTextBox9.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.mobileTextBox9.ForeColor = System.Drawing.Color.Black;
            this.mobileTextBox9.GreyPattern = false;
            this.mobileTextBox9.IntValue = -2147483648;
            this.mobileTextBox9.LineThickness = 2F;
            this.mobileTextBox9.Location = new System.Drawing.Point(316, 141);
            this.mobileTextBox9.MainBindableProperty = "";
            this.mobileTextBox9.Name = "mobileTextBox9";
            this.mobileTextBox9.Radius = 29;
            this.mobileTextBox9.Size = new System.Drawing.Size(98, 30);
            this.mobileTextBox9.StaticColor = System.Drawing.Color.Gray;
            this.mobileTextBox9.TabIndex = 8;
            this.mobileTextBox9.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.mobileTextBox9.TextBackColor = System.Drawing.SystemColors.Window;
            this.mobileTextBox9.TextBoxStyle = dotNetLab.Widgets.MobileTextBox.TextBoxStyles.Mobile;
            this.mobileTextBox9.UIElementBinders = null;
            this.mobileTextBox9.WhitePattern = false;
            // 
            // textBlock11
            // 
            this.textBlock11.BackColor = System.Drawing.Color.Transparent;
            this.textBlock11.BorderColor = System.Drawing.Color.Empty;
            this.textBlock11.BorderThickness = 0;
            this.textBlock11.DataBindingInfo = null;
            this.textBlock11.EnableFlag = true;
            this.textBlock11.EnableTextRenderHint = true;
            this.textBlock11.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.textBlock11.FlagColor = System.Drawing.Color.Crimson;
            this.textBlock11.FlagThickness = 8;
            this.textBlock11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBlock11.GapBetweenTextFlag = 10;
            this.textBlock11.LEDStyle = false;
            this.textBlock11.Location = new System.Drawing.Point(234, 147);
            this.textBlock11.MainBindableProperty = "奇偶性 : ";
            this.textBlock11.Name = "textBlock11";
            this.textBlock11.Radius = 0;
            this.textBlock11.Size = new System.Drawing.Size(76, 23);
            this.textBlock11.TabIndex = 6;
            this.textBlock11.Text = "奇偶性 : ";
            this.textBlock11.UIElementBinders = null;
            this.textBlock11.UnderLine = false;
            this.textBlock11.UnderLineColor = System.Drawing.Color.DarkGray;
            this.textBlock11.UnderLineThickness = 2F;
            this.textBlock11.Vertical = false;
            this.textBlock11.WhereReturn = ((byte)(0));
            // 
            // TCPNetConnectForm
            // 
            this.ClientSize = new System.Drawing.Size(614, 552);
            this.ClipboardText = "奇偶性";
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Name = "TCPNetConnectForm";
            this.Text = "视觉通讯";
            this.Controls.SetChildIndex(this.card1, 0);
            this.Controls.SetChildIndex(this.card2, 0);
            this.card1.ResumeLayout(false);
            this.card2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void card2_Load(object sender, EventArgs e)
        {

        }
    }
}
