using System;
using System.Windows.Forms;
namespace shikii.VisionJob
{
   public class App
    {
       public static dotNetLab.Debug.CodeEngine codeEngine;
       public static dotNetLab.Vision.DspWndLayout DspWndLayoutManager;
       [STAThread]
       static void Main()
       {

           Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
           DspWndLayoutManager = new dotNetLab.Vision.DspWndLayout();
           Application.Run(new MainForm());
       }
    }
}
