using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dotNetLab.Vision.Halcon.Tools;

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
            // PatternForm
            // 
            this.ClientSize = new System.Drawing.Size(634, 545);
            this.Name = "PatternForm";
            this.ResumeLayout(false);

        }
        // to do
        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
            
        //   ToolBlock.GetInstanceForm(App.ToolBlockEditSet[0]);
        //}
    }
}
