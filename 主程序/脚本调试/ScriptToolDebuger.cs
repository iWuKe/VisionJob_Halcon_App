using dotNetLab.Vision.Halcon;
using dotNetLab.Vision.Halcon.Tools;
using dotNetLab.Vision.Halcon.Tools.Extension;
using dotNetLab.Vision.PLCs;
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
         

        public ScriptToolDebuger()
        {
            InitFunctions();
        }
        public void Run(ToolBlock ThisToolBlock, MvToolBase tool)
        {
            //this.ThisToolBlock = ThisToolBlock;
            //GetThisScriptTool(tool);
            ////在下面添加你的逻辑代码
         
             
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
        public Color ForeColor
        {

            set
            {
                ThisScriptTool.DisplayAdapter.
                 Canvas.CanvasColor = value;
            }
        }
        //设置画笔颜色，可以设置多次
        public Color PenColor
        {
            get
            {
                return Color.FromName(ThisScriptTool.ForeColor);
            }
            set
            {
                ThisScriptTool.ForeColor = value.Name.ToLower(); ;
                ThisScriptTool.ApplyGraphics();
            }
        }
        //设置画笔的粗细
        public int PenThickness
        {

            get
            {
                return ThisScriptTool.PenThickness;

            }
            set
            {
                ThisScriptTool.PenThickness = value;
                ThisScriptTool.ApplyGraphics();

            }
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
        Object Outputs
        {
            set
            {
                ThisToolBlock.Outputs.Add(value);
            }
        }
        //得到指定的客户端
        public FactoryTCPClientInvoker GetClientByIndex(int nIndex)
        {
            return ThisToolBlock.ThisJob.TCPs[nIndex] as FactoryTCPClientInvoker;
        }
        //得到指定的服务器
        public FactoryTCPServerInvoker GetServerByIndex(int nIndex)
        {
            return ThisToolBlock.ThisJob.TCPs[nIndex] as FactoryTCPServerInvoker;
        }
        //通用串口类
        public NormalPlc GetCommonSerialByIndex(int nIndex)
        {
            return ThisToolBlock.ThisJob.TCPs[nIndex] as NormalPlc;
        }
        //地址型串口操作类
        public AddressPlc GetAddressPlcByIndex(int nIndex)
        {
            return ThisToolBlock.ThisJob.TCPs[nIndex] as AddressPlc;
        }
        void DisplayImageByToolIndex(int index)
        {
            MvToolBase tool = ThisToolBlock.Tools[index] as MvToolBase;
            Display(tool.OutputImage);
        }
        #region 函数
        public InternalGenRectangle1 GenRectangle1;
        public InternalGenRectangle2 GenRectangle2;
        public InternalAreaCenter AreaCenter;
        public InternalMinMaxGray MinMaxGray;
        public InternalSmallestRectangle1 SmallestRectangle1;
        public InternalReduceDomain ReduceDomain;
        public InternalGetImageSize GetImageSize;
        public InternalSmallestRectangle2 SmallestRectangle2;
        public InternalDifference Difference;
        public InternalFillUp FillUp;
        public InternalGenCircle GenCircle;
        public InternalGenCross GenCross;
        public InternalGenLine GenLine;
        public InternalIntersectionLC IntersectionLC;
        public void InitFunctions()
        {
            GenRectangle1 = JobTool.Funcs.GenRectangle1;
            GenRectangle2 = JobTool.Funcs.GenRectangle2;
            AreaCenter = JobTool.Funcs.AreaCenter;
            MinMaxGray = JobTool.Funcs.MinMaxGray;
            SmallestRectangle1 = JobTool.Funcs.SmallestRectangle1;
            ReduceDomain = JobTool.Funcs.ReduceDomain;
            GetImageSize = JobTool.Funcs.GetImageSize;
            SmallestRectangle2 = JobTool.Funcs.SmallestRectangle2;
            Difference = JobTool.Funcs.Difference;
            FillUp =  JobTool.Funcs.FillUp;
            GenCircle =JobTool.Funcs.GenCircle;
            GenCross = JobTool.Funcs.GenCross;
            GenLine = JobTool.Funcs.GenLine;
            IntersectionLC = JobTool.Funcs.IntersectionLC;
        }
        public HTuple Distance_PP(params HTuple[] p)
        {
            HTuple distance;
            HOperatorSet.DistancePp(p[0], p[1], p[2], p[3], out distance);

            return distance;
        }
        #endregion
    }
}
