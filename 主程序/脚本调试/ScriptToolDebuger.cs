using dotNetLab.Vision.Halcon.Tools;
using dotNetLab.Vision.Halcon.Tools.Extension;
using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace shikii.VisionJob
{
   public class ScriptToolDebuger
    {
        //步骤
        ToolBlock ThisToolBlock = null;
        //指脚本本身
        ScriptTool ThisScriptTool;
        Functions Funcs;

        public ScriptToolDebuger()
        {
            Funcs = JobTool.Funcs;
        }
        public void Run(ToolBlock ThisToolBlock, MvToolBase tool)
        {
            this.ThisToolBlock = ThisToolBlock;
            GetThisScriptTool(tool);
            //在下面添加你的逻辑代码
            //在下面添加你的逻辑代码
            BlobTool blobTool = GetToolByIndex<BlobTool>(2);
            Funcs.SmallestRectangle2.Run(blobTool.SelectedRegions);
            //	Display(tool.InputImage) ;
            HObject hobj = Funcs.GenRectangle2.Run(Funcs.SmallestRectangle2.row1,
                Funcs.SmallestRectangle2.column1,
                Funcs.SmallestRectangle2.phi,
                Funcs.SmallestRectangle2.row2,
                Funcs.SmallestRectangle2.column2);
            ThisScriptTool.Tag = new object[2] { Funcs.SmallestRectangle2.row2 * 2, Funcs.SmallestRectangle2.column2 * 2 };
            double nWidth = Math.Round(Funcs.SmallestRectangle2.row2.D * 2, 2);
            double nHeight = Math.Round(Funcs.SmallestRectangle2.column2.D * 2, 2);

            //通过工具索引号得到相应的工具
            DispMessage(String.Format("总长{0},总宽{1}", nWidth, nHeight), 46, 4);

            Metrology2D LongMessure = GetToolByIndex<Metrology2D>(3);
            Metrology2D ShortMessureWidth = GetToolByIndex<Metrology2D>(4);
            Metrology2D ShortMessureHeight = GetToolByIndex<Metrology2D>(5);


            PMAlignTool pm = GetToolByIndex<PMAlignTool>(1);

            double lf = GetDistancePP(LongMessure.Lines[0], 2); ;

            DispMessage(tool.image, lf.ToString(), pm.Centers[0].Y, pm.Centers[0].X);

            lf = GetDistancePP(ShortMessureWidth.Lines[0], 2);
            LimittedBoxTool lim_Width  = GetToolByIndex<LimittedBoxTool>(6);
            LimittedBoxTool lim_Height = GetToolByIndex<LimittedBoxTool>(7);
 
                DispMessage(tool.image, lf.ToString(), lim_Width.CurrentCenterRow,  lim_Width.CurrentCenterCol);

            lf = GetDistancePP(ShortMessureHeight.Lines[0], 2);

            DispMessage(tool.image, lf.ToString(), lim_Height.CurrentCenterRow,lim_Height.CurrentCenterCol + 50);
             
        }

        //decs 小数位
        double GetDistancePP(double[] lfArr, int decs)
        {
            HTuple dist;
            HOperatorSet.DistancePp(lfArr[0], lfArr[1], lfArr[2], lfArr[3], out dist);
            return Math.Round(dist.D, decs);
        }
        //脚本自动调用
        void GetThisScriptTool(MvToolBase tool)
        {
            ThisScriptTool
              = tool as ScriptTool;
        }
        //通过工具索引号得到相应的工具
        T GetToolByIndex<T>(int nIndex)
        {
            return (T)ThisToolBlock.Tools[nIndex];
        }
        //显示一张图片，Region,
        void Display(HObject hoj)
        {
            ThisScriptTool.DisplayAdapter.Display(hoj);

        }
        //设置文本颜色，可以设置多次
        void SetCanvasColor(Color clr)
        {
            ThisScriptTool.DisplayAdapter.Canvas.CanvasColor = clr;
        }
        //只能修改一次字体颜色
        void AddTipText(String strText)
        {
            ThisToolBlock.DisplayTextInfo.Add(strText);
        }
        //可以修改多次字体颜色
        void AddTipTextEx(String strText, bool isFirstLine)
        {
            if (!isFirstLine)
                ThisToolBlock.DisplayAdapter.Canvas.AppendText(strText);
            else
                ThisToolBlock.DisplayAdapter.Canvas.AppendFirstText(strText);
        }
        //可以修改多次字体颜色的同时还可以指定文字所在的位置
        void AddTipTextEx(String Text, int rowx, int colx)
        {
            ThisToolBlock.DisplayAdapter.Canvas.DrawingText(Text, rowx, colx);
        }
        //显示框住的文本信息
        //显示在左上角时 rowx : 46, colx:4 行间隔为30
        void DispMessage(String Text, int rowx, int colx)
        {
            ThisToolBlock.DisplayAdapter.Canvas.DispMessage(Text, rowx, colx);
        }
        void DispMessage(HObject img, String Text, double rowx, double colx)
        {
            ThisToolBlock.DisplayAdapter.Canvas.DispMessage(img, Text, rowx, colx);
        }
        public bool Passed
        {
            get { return ThisScriptTool.InternalPassed; }
            set { ThisScriptTool.InternalPassed = value; }
        }
    }
}
