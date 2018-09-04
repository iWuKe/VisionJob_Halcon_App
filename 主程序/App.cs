using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using dotNetLab.Common;
using dotNetLab.Vision.Halcon;
using dotNetLab.Vision.Halcon.Tools; 
namespace shikii.VisionJob
{
   public class App
    {

        public static List<ToolBlockEditV2> ToolBlockEditSet; 
        public static JobTool job;
        [STAThread]
       static void Main()
       {
            ToolBlockEditSet = new List<ToolBlockEditV2>();
           WinFormApp.BegineInvokeApp();
        
           MainForm frm = new MainForm() ;
           WinFormApp.EndInvokeApp(frm,frm.mobileListBox1);

       }
       


        public static String ProjsFolderName = "Projs";
        public static String OriginProjectPath = "Projs\\0";
        public static String CurrentProject = "Current_Project";
        public static String MainCompactDB = "shikii.db";
        public static string AutoCleanTime = "AutoClearTime";
       
    }
}
