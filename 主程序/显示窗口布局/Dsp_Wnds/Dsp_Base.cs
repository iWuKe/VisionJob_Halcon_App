using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dotNetLab
{
    namespace Framework
    {
        public abstract partial class Dsp_Base : UserControl
        {
            public Dsp_Base()
            {
                InitializeComponent();
            }
            public void AttachDspPanel(Control ctrl,Control []ctrl_DspArr)
            {
                this.Dock = DockStyle.Fill;
                ctrl.Controls.Add(this);
                PrepareDspWnds(ctrl_DspArr);
            }
           protected abstract  void PrepareDspWnds(Control[] ctrl_ArrDspWnds);
            protected void AppendDspWnd(TableLayoutPanel ctrl_Parent,
                  Control ctrl ,int nRow,int nColunm
                )
           {
               ctrl.Dock = DockStyle.Fill;
               ctrl_Parent.Controls.Add(ctrl,nColunm,nRow);
            }
        }

    }
}