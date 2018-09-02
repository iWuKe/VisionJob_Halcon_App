using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dotNetLab.Common;
using dotNetLab.Vision.Halcon;
using dotNetLab.Vision.Halcon.Tools;
 
 
namespace shikii.VisionJob
{
   public class App
    {

        public static List<ToolBlockEditV2> ToolBlockEditSet; 
        public static   JobTool job;
        [STAThread]
       static void Main()
       {
            ToolBlockEditSet = new List<ToolBlockEditV2>();
           WinFormApp.BegineInvokeApp();
           MainForm frm = new MainForm() ;
           WinFormApp.EndInvokeApp(frm,frm.mobileListBox1);
         
         
       }
    }
}
