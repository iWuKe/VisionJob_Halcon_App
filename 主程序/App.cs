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
           MainForm frm = new MainForm() ;
           WinFormApp.EndInvokeApp(frm,frm.mobileListBox1);
           //这是Master 测试标记
       }
    }
}
