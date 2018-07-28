using System;
using System.Windows.Forms;
using dotNetLab.Common;
namespace shikii.VisionJob
{
   public class App
    {
       public static dotNetLab.Debug.CodeEngine codeEngine;
      
       [STAThread]
       static void Main()
       {
           WinFormApp.BegineInvokeApp();
           MainForm frm = new MainForm() ;
            WinFormApp.EndInvokeApp(frm,frm.mobileListBox1);
         
         
       }
    }
}
