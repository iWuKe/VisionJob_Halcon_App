using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dotNetLab
{
    namespace Framework
    {
        public partial class Dsp_1 : Dsp_Base
        {
            public Dsp_1()
            {
                InitializeComponent();
            }

            protected override void PrepareDspWnds(Control[] ctrl_ArrDspWnds)
            {
                this.AppendDspWnd(this.tableLayoutPanel1, 
                      ctrl_ArrDspWnds[0], 0, 0);
            }
        }

    }
}