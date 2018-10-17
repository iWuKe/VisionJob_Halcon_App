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
    }
}
