using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace shikii.VisionJob
{
    public partial class MainForm : Form
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
