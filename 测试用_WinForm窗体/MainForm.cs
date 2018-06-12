using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace shikii.Test.Wnd
{
   public class MainForm : Form
    {


       [STAThread]
       static void Main()
       {
           Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new MainForm());
       }
    }
}
