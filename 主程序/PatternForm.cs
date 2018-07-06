using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace shikii.VisionJob
{
   public class PatternForm : Form
    {
       // public dotNetLab.Vision.VPro.ToolBlockEditorAdapter editDapter;
        public PatternForm()
        {
            InitializeComponent();
           // editDapter = new dotNetLab.Vision.VPro.ToolBlockEditorAdapter();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MoreForm
            // 
            this.ClientSize = new System.Drawing.Size(634, 406);
            this.Name = "MoreForm";
            this.ResumeLayout(false);

        }
    }
}
