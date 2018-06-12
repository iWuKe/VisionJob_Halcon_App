using dotNetLab.Framework;
using System;
using System.Windows.Forms;
 
using System.IO;
using System.Runtime.CompilerServices;

namespace dotNetLab

{
    namespace Vision
    {
        public class DspWndLayout
        {
            public Dsp_Base dsp_Container;
            public Control[] dspWndArr;
            Type type_DspWnd = null;
         
            protected virtual Control[] GetDisplayWndArr(int nHowDspWnds)
            {
                dspWndArr = new Control[nHowDspWnds];
                for (int i = 0; i < dspWndArr.Length; i++)
                {
                   dspWndArr[i] = System.Activator.CreateInstance(type_DspWnd) as Control ;

                }
                return dspWndArr;
            }

            public void PrepareDspWnds(Type type_DspWnd,Control What_Panel_Do_You_Want_To_Place_DisplayWnds,int nHowDspWnds)
            {
                this.type_DspWnd = type_DspWnd;
                Control ctrl_Panel = What_Panel_Do_You_Want_To_Place_DisplayWnds;
                

                Control[] dsp_WndArr = GetDisplayWndArr(nHowDspWnds);
                switch (dsp_WndArr.Length)
                {

                    case 1:
                        dsp_Container = new Dsp_1();
                        dsp_Container.AttachDspPanel(ctrl_Panel, dsp_WndArr);
                        break;
                    case 2:
                        dsp_Container = new Dsp_2();
                        dsp_Container.AttachDspPanel(ctrl_Panel, dsp_WndArr);
                        break;
                    case 3:
                        dsp_Container = new Dsp_3();
                        dsp_Container.AttachDspPanel(ctrl_Panel, dsp_WndArr);
                        break;
                    case 4:
                        dsp_Container = new Dsp_4();
                        dsp_Container.AttachDspPanel(ctrl_Panel, dsp_WndArr);
                        break;
                    case 5:
                        dsp_Container = new Dsp_6();
                        dsp_Container.AttachDspPanel(ctrl_Panel, dsp_WndArr);
                        break;
                    case 6:
                        dsp_Container = new Dsp_6();
                        dsp_Container.AttachDspPanel(ctrl_Panel, dsp_WndArr);
                        break;
                    case 7:
                        dsp_Container = new Dsp_9();
                        dsp_Container.AttachDspPanel(ctrl_Panel, dsp_WndArr);
                        break;
                    case 8:
                        dsp_Container = new Dsp_9();
                        dsp_Container.AttachDspPanel(ctrl_Panel, dsp_WndArr);
                        break;
                    case 9:
                        dsp_Container = new Dsp_9();
                        dsp_Container.AttachDspPanel(ctrl_Panel, dsp_WndArr);
                        break;

                }
            }
        }
    }
}

