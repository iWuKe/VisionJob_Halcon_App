using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dotNetLab
{
    namespace Framework
    {
        public partial class Dsp_9 : Dsp_Base
        {
            public Dsp_9()
            {
                InitializeComponent();
            }

            protected override void PrepareDspWnds(Control[] ctrl_ArrDspWnds)
            {
                int n = ctrl_ArrDspWnds.Length;
                int nIndex = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i * 3 + j < n)
                        {
                            this.AppendDspWnd(tableLayoutPanel1,   ctrl_ArrDspWnds[nIndex++], i, j);
                        }
                        else
                            return;
                    }
                }
            }
        }

    }
}