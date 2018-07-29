using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dotNetLab.Common;
using dotNetLab.Vision.Halcon;
namespace shikii.VisionJob
{
   public class App
    {
       public static dotNetLab.Debug.CodeEngine codeEngine;
      
        public static Dictionary<String, HalconEnginePowerSuite> HalconEngineManager;
        public static String HalconScriptTableName = "HalconScriptList";
       [STAThread]
       static void Main()
       {
           HalconEngineManager = new Dictionary<string, HalconEnginePowerSuite>();
           WinFormApp.BegineInvokeApp();
           MainForm frm = new MainForm() ;
           WinFormApp.EndInvokeApp(frm,frm.mobileListBox1);
         
         
       }
    }
}
