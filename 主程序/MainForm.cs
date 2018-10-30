using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dotNetLab.Common.ModernUI;
using dotNetLab.Common;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using HalconDotNet;
using dotNetLab.Vision.Halcon;
using dotNetLab.Vision.Halcon.Tools;
using dotNetLab.Widgets;

namespace shikii.VisionJob
{
    public partial class MainForm : dotNetLab.Common.ModernUI.PageBase
    {
        
    // public  TCPFactoryServer factoryServer;
        public  dotNetLab.Vision.DspWndLayout DspWndLayoutManager;  
        public bool EnableAutoClean = false;
       
        protected override void prepareData()
        {
            base.prepareData();
            String str = CompactDB.FetchValue(App.AutoCleanTime);
            if (str == null)
                CompactDB.Write(App.AutoCleanTime, "0");
            String ApplyUserPriority = CompactDB.FetchValue(App.ApplyUserPriority);
            if(ApplyUserPriority == null)
                CompactDB.Write(App.ApplyUserPriority, "0");
            
            //to do 添加通讯支持
            //factoryServer = new TCPFactoryServer();

            //factoryServer.Boot();

            //factoryServer.Route = (nWhichClient, byts) =>
            //{

            //};

        }
          void CheckProjectFolder()
        {
            if (!Directory.Exists(App.ProjsFolderName))
            {
                Directory.CreateDirectory(App.ProjsFolderName);
                if (!Directory.Exists(App.OriginProjectPath))
                {
                    Directory.CreateDirectory(App.OriginProjectPath);
                    String str = CompactDB.FetchValue(App.CurrentProject);
                    if(String.IsNullOrEmpty(str)||str.Equals("0"))
                    {
                        CompactDB.Write(App.CurrentProject,App.OriginProjectPath);
                    }
                }

            }
        }
        private   void ShowCompactDBEditor(String dbFileName = "shikii.db")
        {
            AppManager.ShowCompactDBEditor(dbFileName);
        }
        protected override void prepareCtrls()
        {
            base.prepareCtrls();
            InitializeComponent();
            CheckProjectFolder();
            DspWndLayoutManager = new dotNetLab.Vision.DspWndLayout();
           cc:;
             String str = CompactDB.FetchValue("AppName");
            if(str == null)
            {
                CompactDB.Write("AppName","视觉检测应用");
                goto cc;
            }
            this.Text = str;
            if (-99999 == CompactDB.FetchIntValue("DisplayWndNum"))
                CompactDB.Write("DisplayWndNum", "1");
            DspWndLayoutManager.PrepareDspWnds(typeof(MVDisplay), this.canvasPanel1, CompactDB.FetchIntValue("DisplayWndNum"));
            
            this.Load += (sender, e) =>
            {
                //必须使用这个方法来最大化窗体
                this.MaxWindow();
            };
           // PrepareVision();
           
        }
        //准备视觉库（*.shikii）
        public void PrepareVision()
        {
            //使用作业管理器
           App.job = new JobTool();
           App.job.DisplayWnds = DspWndLayoutManager.DisplayWnds;
           App. job.mainFormInvoker.Host = this;
           App. job.CompactDB.Host = CompactDB;
           App. job.ConsolePipe.Host = ConsolePipe;
           App.job.LogPipe.Host = this.LogPipe;
           App.job.Deserialize();

            //手动管理作业
            //// 得到当前的项目名（路径）
            // String strShikiiFileDirectory = CompactDB.FetchValue("Current_Project");
            //// 加载ToolBlock,得到EditV2
            // App.ToolBlockEditSet.Add(ToolBlock.GetToolBlockEditV2(strShikiiFileDirectory + "\\test.shikii"));
            // // 与显示窗体进行关联
            //  ToolBlock thisToolBlock = App.ToolBlockEditSet[0].Subject as ToolBlock;
            //  thisToolBlock.DisplayAdapter = ((MVDisplay)DspWndLayoutManager.DisplayWnds[0]).adapter;
            //// 传出数据库及输出信息类对象
            //  thisToolBlock.CompactDB.DBObject = CompactDB;
            // thisToolBlock.ConsolePipe.ConsolePipe = ConsolePipe;
          

        }
        protected override void prepareEvents()
        {
            base.prepareEvents();
            this.KeyDown += MainForm_KeyDown;
            this.EnableDrawUpDownPattern = true;
            this.Img_Up = dotNetLab.UI.RibbonSpring;
            this.Img_Down = dotNetLab.UI.RibbonUnderwater;
            this.FormClosing += (s, e) =>
            {
                Process.GetCurrentProcess().Kill();
            };
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                       
            }
            if (e.KeyData == (Keys.Control | Keys.C))
            {
                this.mobileListBox1.Items.Clear();
            }
            if (e.KeyData == (Keys.Control | Keys.J))
            {
                ShowJobWindow();
            }
        }
       
        public void AutoSaveClearImage(HImage bmp,bool isNG)
        {
            //自动保存及清理图片
            //保存
            List<String> lst = CompactDB.GetNameColumnValues(CompactDB.DefaultTable);
            String picturePath = "图片";
            if (!Directory.Exists("图片"))
            {
                Directory.CreateDirectory(picturePath);
            }
            //当前图片保存到哪个位置
            String strNowPictureToGo = String.Format("图片\\{0}", DateTime.Now.ToString("yyyy-MM-dd"));
            if (!Directory.Exists(strNowPictureToGo))
            {
                Directory.CreateDirectory(strNowPictureToGo);
            }
            string strNGPictureToGo = String.Format("{0}\\NG",strNowPictureToGo);
            if(!Directory.Exists(strNGPictureToGo))
                Directory.CreateDirectory(strNGPictureToGo);
            string strOKPictureToGo = String.Format("{0}\\OK", strNowPictureToGo);
            if (!Directory.Exists(strOKPictureToGo))
                Directory.CreateDirectory(strOKPictureToGo);

            if(isNG)
            bmp.Save(Path.Combine(strNGPictureToGo, DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss") + ".bmp"));
            else
            bmp.Save(Path.Combine(strOKPictureToGo, DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss") + ".bmp"));


            int nGapDays = CompactDB.FetchIntValue("AutoClearTime");
            DateTime dt = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")).AddDays(-nGapDays);
            string deletingFolderName = dt.ToString("yyyy-MM-dd");

            if (!Directory.Exists(Path.Combine(picturePath, deletingFolderName)))
                return;

            string directoryName = Path.Combine(picturePath, deletingFolderName);
            String[] strDirs_OK_NG = Directory.GetDirectories(directoryName);
            //
            for (int j = 0; j < strDirs_OK_NG.Length; j++)
            {
              
                String[] strFiles = Directory.GetFiles(strDirs_OK_NG[j]);
                for (int i = 0; i < strFiles.Length; i++)
                {
                     File.Delete(strFiles[j]);
                }
            }
            Directory.Delete(directoryName);
        }
        #region  Extentsion
        public Object GetTCPFactoryServer()
        {
            return new TCPFactoryServer();
        }
        public Object GetTCPFactoryClient()
        {
            return new TCPFactoryClient();
        }
        public void ClearLogWindow()
        {
            this.mobileListBox1.Items.Clear();
        }
        public Form ShowPage(Type type, bool isFixedForm = false)
        {
            Form form = null;
            if (!isFixedForm)
                form = AppManager.ShowPage(type);
            else
                form = AppManager.ShowPage(type);
            return form;
        }


        //调试脚本工具，每次只能调试一个脚本工具（正式部署时请将代码退回到脚本工具中）
        public void ScriptToolDebug(ToolBlock tbk, MvToolBase sTool )
        {
            ScriptToolDebuger debuger1 = new ScriptToolDebuger();
            debuger1.Run(tbk, sTool);
        }


        //调试全局脚本,正式部署时请将代码退回到步骤全局脚本中
        public void GlobalScriptDebug(ToolBlock tbk, bool isBeginRunTool)
        {
            
            GlobaleScriptDebuger debuger1 = new GlobaleScriptDebuger();
            debuger1.Run(tbk, isBeginRunTool);
        }
        public void TCP_IP_Script_Debug(int nWhichClient, byte[] byts, TCPInvoker tcpInvoker, List<ToolBlock> ToolBlockSet
            , UIConsoleInvoker ConsolePipe, Action<String, bool> ConmmunicationOutputs)
        {
            TCP_IP_Debuger _Debuger = new TCP_IP_Debuger();
            _Debuger.Run(nWhichClient, byts, tcpInvoker, ToolBlockSet, ConsolePipe, ConmmunicationOutputs);
        }
        #endregion

        private void btn_More_Click(object sender, EventArgs e)
        {
            int n = 0;
            try
            {
            String ApplyUserPriority = CompactDB.FetchValue(App.ApplyUserPriority);
              n  = int.Parse(ApplyUserPriority);

            }
            catch (Exception ex)
            {

                Tipper.Error = "检测到你可能启用了权限管理,但是可能配置不正确！";    
            }
            if(n>0)
            {
                LogInForm logIn = new LogInForm();
                logIn.ShowDialog();
                if (!logIn.bCloseWindow)
                    return;
            }

            foreach (Form item in Application.OpenForms)
            {
                if (item is MenuForm)
                {
                    if (item.Owner != this)
                        return;
                    if (item.WindowState == FormWindowState.Minimized)
                        item.WindowState = FormWindowState.Normal;
                    item.BringToFront();
                    return;
                }
            }
            Form frm =  AppManager.ShowFixedPage(typeof(MenuForm));
                frm.Owner = this;
            
        }

        void ShowJobWindow()
        {
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
        private dotNetLab.Widgets.TextBlock lbl_OutputInfo;
        private dotNetLab.Widgets.Container.CanvasPanel canvasPanel1;
        private dotNetLab.Widgets.ColorDecorator colorDecorator1;
        public dotNetLab.Widgets.MobileListBox mobileListBox1;
        private dotNetLab.Widgets.Direction btn_More;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mobileListBox1 = new dotNetLab.Widgets.MobileListBox();
            this.lbl_OutputInfo = new dotNetLab.Widgets.TextBlock();
            this.canvasPanel1 = new dotNetLab.Widgets.Container.CanvasPanel();
            this.colorDecorator1 = new dotNetLab.Widgets.ColorDecorator();
            this.btn_More = new dotNetLab.Widgets.Direction();
            this.SuspendLayout();
            // 
            // tipper
            // 
            this.tipper.Location = new System.Drawing.Point(556, 480);
            // 
            // mobileListBox1
            // 
            this.mobileListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mobileListBox1.BackColor = System.Drawing.Color.Transparent;
            this.mobileListBox1.BorderColor = System.Drawing.Color.Gray;
            this.mobileListBox1.BorderThickness = 1;
            this.mobileListBox1.CornerAlignment = dotNetLab.Widgets.Alignments.All;
            this.mobileListBox1.DataBindingInfo = null;
            this.mobileListBox1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.mobileListBox1.ImagePos = new System.Drawing.Point(0, 0);
            this.mobileListBox1.ImageSize = new System.Drawing.Size(0, 0);
            this.mobileListBox1.Location = new System.Drawing.Point(610, 93);
            this.mobileListBox1.MainBindableProperty = "mobileListBox1";
            this.mobileListBox1.Name = "mobileListBox1";
            this.mobileListBox1.NormalColor = System.Drawing.Color.White;
            this.mobileListBox1.Radius = -1;
            this.mobileListBox1.Size = new System.Drawing.Size(228, 448);
            this.mobileListBox1.Source = null;
            this.mobileListBox1.TabIndex = 2;
            this.mobileListBox1.Text = "mobileListBox1";
            this.mobileListBox1.UIElementBinders = null;
            // 
            // lbl_OutputInfo
            // 
            this.lbl_OutputInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_OutputInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_OutputInfo.BorderColor = System.Drawing.Color.Empty;
            this.lbl_OutputInfo.BorderThickness = -1;
            this.lbl_OutputInfo.DataBindingInfo = null;
            this.lbl_OutputInfo.EnableFlag = true;
            this.lbl_OutputInfo.EnableTextRenderHint = true;
            this.lbl_OutputInfo.FlagAlign = dotNetLab.Widgets.Alignments.Left;
            this.lbl_OutputInfo.FlagColor = System.Drawing.Color.Crimson;
            this.lbl_OutputInfo.FlagThickness = 10;
            this.lbl_OutputInfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_OutputInfo.GapBetweenTextFlag = 0;
            this.lbl_OutputInfo.LEDStyle = false;
            this.lbl_OutputInfo.Location = new System.Drawing.Point(612, 71);
            this.lbl_OutputInfo.MainBindableProperty = "输出信息";
            this.lbl_OutputInfo.Name = "lbl_OutputInfo";
            this.lbl_OutputInfo.Radius = -1;
            this.lbl_OutputInfo.Size = new System.Drawing.Size(104, 16);
            this.lbl_OutputInfo.TabIndex = 4;
            this.lbl_OutputInfo.Text = "输出信息";
            this.lbl_OutputInfo.UIElementBinders = null;
            this.lbl_OutputInfo.UnderLine = false;
            this.lbl_OutputInfo.UnderLineColor = System.Drawing.Color.DarkGray;
            this.lbl_OutputInfo.UnderLineThickness = 2F;
            this.lbl_OutputInfo.Vertical = false;
            this.lbl_OutputInfo.WhereReturn = ((byte)(0));
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
            this.canvasPanel1.Location = new System.Drawing.Point(36, 85);
            this.canvasPanel1.MainBindableProperty = null;
            this.canvasPanel1.Name = "canvasPanel1";
            this.canvasPanel1.NormalColor = System.Drawing.Color.Silver;
            this.canvasPanel1.Radius = 20;
            this.canvasPanel1.Size = new System.Drawing.Size(554, 414);
            this.canvasPanel1.Source = null;
            this.canvasPanel1.TabIndex = 5;
            this.canvasPanel1.Text = null;
            this.canvasPanel1.UIElementBinders = null;
            // 
            // colorDecorator1
            // 
            this.colorDecorator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.colorDecorator1.BackColor = System.Drawing.Color.White;
            this.colorDecorator1.DataBindingInfo = null;
            this.colorDecorator1.Location = new System.Drawing.Point(6, 505);
            this.colorDecorator1.MainBindableProperty = "";
            this.colorDecorator1.Name = "colorDecorator1";
            this.colorDecorator1.Size = new System.Drawing.Size(150, 53);
            this.colorDecorator1.TabIndex = 6;
            this.colorDecorator1.UIElementBinders = null;
            // 
            // btn_More
            // 
            this.btn_More.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_More.ArrowAlignment = dotNetLab.Widgets.Alignments.Right;
            this.btn_More.BackColor = System.Drawing.Color.Transparent;
            this.btn_More.BorderColor = System.Drawing.Color.Gray;
            this.btn_More.BorderThickness = 2F;
            this.btn_More.CenterImage = true;
            this.btn_More.ClipCircleRegion = false;
            this.btn_More.DataBindingInfo = null;
            this.btn_More.Effect = null;
            this.btn_More.Fill = false;
            this.btn_More.FillColor = System.Drawing.Color.Empty;
            this.btn_More.ImagePostion = new System.Drawing.Point(0, 0);
            this.btn_More.ImageSize = new System.Drawing.SizeF(25F, 25F);
            this.btn_More.Location = new System.Drawing.Point(797, 51);
            this.btn_More.MainBindableProperty = "";
            this.btn_More.MouseDownColor = System.Drawing.Color.Gray;
            this.btn_More.Name = "btn_More";
            this.btn_More.NeedEffect = false;
            this.btn_More.Size = new System.Drawing.Size(40, 40);
            this.btn_More.Source = ((System.Drawing.Image)(resources.GetObject("btn_More.Source")));
            this.btn_More.TabIndex = 7;
            this.btn_More.UIElementBinders = null;
            this.btn_More.WhichShap = 6;
            this.btn_More.WhitePattern = false;
            this.btn_More.Click += new System.EventHandler(this.btn_More_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(859, 565);
            this.Controls.Add(this.btn_More);
            this.Controls.Add(this.colorDecorator1);
            this.Controls.Add(this.canvasPanel1);
            this.Controls.Add(this.lbl_OutputInfo);
            this.Controls.Add(this.mobileListBox1);
            this.FontX = new System.Drawing.Font("等线 Light", 30F);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "视觉检测应用";
            this.TitlePos = new System.Drawing.Point(10, 18);
            this.Controls.SetChildIndex(this.mobileListBox1, 0);
            this.Controls.SetChildIndex(this.lbl_OutputInfo, 0);
            this.Controls.SetChildIndex(this.canvasPanel1, 0);
            this.Controls.SetChildIndex(this.colorDecorator1, 0);
            this.Controls.SetChildIndex(this.btn_More, 0);
            this.ResumeLayout(false);

        }


       
        }
}

/*
         // image.Save(Path.Combine(strNowPictureToGo, DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss") + ".bmp"));
        protected void AutoSaveClearImage(HImage image)
        {
            //自动保存及清理图片
            //保存
            List<String> lst = CompactDB.GetNameColumnValues(CompactDB.DefaultTable);
            if (!lst.Contains("AutoClearTime"))
            {
                CompactDB.Write("AutoClearTime", "3");
            }


            String picturePath = "图片";
            if (!Directory.Exists("图片"))
            {
                Directory.CreateDirectory(picturePath);
            }
            //当前图片保存到哪个位置
            String strNowPictureToGo = String.Format("图片\\{0}", DateTime.Now.ToString("yyyy-MM-dd"));
            if (!Directory.Exists(strNowPictureToGo))
            {
                Directory.CreateDirectory(strNowPictureToGo);
            }
             image.Save(Path.Combine(strNowPictureToGo, DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss") + ".bmp"));
            //actSaveBmp(Path.Combine(strNowPictureToGo, DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss") + ".bmp"));
            // bmp.Save( DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss") + ".bmp");
            int nGapDays = CompactDB.FetchIntValue("AutoClearTime");
            DateTime dt = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")).AddDays(-nGapDays);
            string deletingFolderName = dt.ToString("yyyy-MM-dd");
            if (!Directory.Exists(Path.Combine(picturePath, deletingFolderName)))
                return;
            string directoryName = Path.Combine(picturePath, deletingFolderName);
            String[] strFiles = Directory.GetFiles(directoryName);
            for (int j = 0; j < strFiles.Length; j++)
            {
                File.Delete(strFiles[j]);
            }
            Directory.Delete(directoryName);
        }
     
     */

/*

  cc:;
        String str = CompactDB.FetchValue("EnableAutoClean");
        if (str == null)
        {
            CompactDB.Write("EnableAutoClean", "0");
            CompactDB.Write(App.AutoCleanTime, "0");
            goto cc;
        }
        if (str == "1")
            this.EnableAutoClean = true;
        else
            EnableAutoClean = false;

        String autoCleanTime = CompactDB.FetchValue(App.AutoCleanTime);
        int n = 0;
        int.TryParse(autoCleanTime, out n);

        if(EnableAutoClean && n >0)
        {

            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
            tmr.Tick += (sender, e) =>
            {

            };
        }

 */
