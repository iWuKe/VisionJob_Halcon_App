using dotNetLab.Vision.Halcon.Tools;
using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace shikii.VisionJob 
{
    public class GlobaleScriptDebuger
    {
        ToolBlock ThisToolBlock = null;
        public void Run(ToolBlock tbk,bool isBeginRunTool)
        {
            if (isBeginRunTool)
                BeginRunTool(tbk);
            else
                EndRunTool(tbk);
        }

        //运行工具前
        public void BeginRunTool(ToolBlock tbk  )
        {
            ThisToolBlock = tbk;
            //Tipper.Info = tool.Name + " 开始" ;
            //下面写逻辑代码

        }
        //结束运行工具
        public void EndRunTool(ToolBlock tbk)
        {
           
            ThisToolBlock = tbk;
            //Tipper.Info = tool.Name + " 结束" ;      
            //下面写逻辑代码


        }






        T GetToolByIndex<T>(int nIndex)
        {
            return (T)ThisToolBlock.Tools[nIndex];
        }

        void Display(HObject hoj)
        {
            ThisToolBlock.DisplayAdapter.Display(hoj);

        }
        void SetCanvasColor(Color clr)
        {
            ThisToolBlock.DisplayAdapter.Canvas.CanvasColor = clr;
        }
        void AddTipText(String strText)
        {
            ThisToolBlock.DisplayTextInfo.Add(strText);
        }

    }
}
