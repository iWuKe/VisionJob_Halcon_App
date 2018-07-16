using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dotNetLab.Common.ModernUI;
using dotNetLab.Common;
using System.Threading;
//using dotNetLab.Vision.VPro;
//using Cognex.VisionPro;
//using Cognex.VisionPro.PMAlign;
//using Cognex.VisionPro.Blob;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

namespace shikii.VisionJob
{
    public partial class MainForm : dotNetLab.Common.ModernUI.PageBase
    {
        private dotNetLab.Widgets.TextBlock lbl_OutputInfo;
        private dotNetLab.Widgets.Container.CanvasPanel canvasPanel1;
        private dotNetLab.Widgets.ColorDecorator colorDecorator1;
        public dotNetLab.Widgets.MobileListBox mobileListBox1;
        private dotNetLab.Widgets.Direction btn_More;
        TCPFactoryServer factoryServer;
        //List<Point> pnts_Results;
        //internal class CheckPoint
        //{
        //    public Point pnt = new Point();
        //    public bool isEmpty = true;

        //}
        //  Canvas cnv;

        protected override void prepareData()
        {
            base.prepareData();
           // pnts_Results = new List<Point>();
            //factoryServer = new TCPFactoryServer();
            //factoryServer.Port = int.Parse(CompactDB.FetchValue("Port"));
            //factoryServer.LoopGapTime = int.Parse(CompactDB.FetchValue("LoopGapTime"));
            //factoryServer.Boot(CompactDB.FetchValue("IP"));

            //factoryServer.Route = (nWhichClient, byts) =>
            //{
            //    if (byts[0] == 1)
            //    {
            //        byts[0] = 0;
            //        this.MainCheckLEDSupporting();

            //    }
            //};

        }
        protected override void prepareCtrls()
        {
            base.prepareCtrls();
            InitializeComponent();
            //cnv = new Canvas();
            //App.thisPowerSuite = this.PrepareToolBlockPowerSuit(CompactDB.FetchValue("Current_Project"), cnv);
            //App.DspWndLayoutManager.PrepareDspWnds(typeof(CogRecordDisplay), this.canvasPanel1, 1);
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
               // MainCheckLEDSupporting();
            }
            if (e.KeyData == (Keys.Control | Keys.C))
            {
                this.mobileListBox1.Items.Clear();
            }
        }
      
        //要使MenuForm 自动清理文本框正常显示请启用下列代码
        protected void AutoSaveClearImage(Bitmap bmp)
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
            bmp.Save(Path.Combine(strNowPictureToGo, DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss") + ".bmp"));
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
        private void btn_More_Click(object sender, EventArgs e)
        {
            AppManager.ShowFixedPage(typeof(MenuForm));
        }
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
            this.Text = "LED支架检测";
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
