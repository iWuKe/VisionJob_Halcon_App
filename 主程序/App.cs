using System;
using System.Windows.Forms;
using dotNetLab.Common;
namespace shikii.VisionJob
{
   public class App
    {
       public static dotNetLab.Debug.CodeEngine codeEngine;
       public static dotNetLab.Vision.DspWndLayout DspWndLayoutManager;
       [STAThread]
       static void Main()
       {
           WinFormApp.BegineInvokeApp();
           DspWndLayoutManager = new dotNetLab.Vision.DspWndLayout();
           WinFormApp.EndInvokeApp(new MainForm());
       }
    }
}
