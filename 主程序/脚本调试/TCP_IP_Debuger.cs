using dotNetLab.Vision.Halcon;
using dotNetLab.Vision.Halcon.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shikii.VisionJob
{
  public  class TCP_IP_Debuger
    {
        TCPInvoker ThisTCPInvoker;
        List<ToolBlock> ToolBlockSet;
        public void Run(int nWhichClient, byte[] byts, TCPInvoker tcpInvoker, List<ToolBlock> ToolBlockSet
            , UIConsoleInvoker ConsolePipe, Action<String, bool> ConmmunicationOutputs)
        {
            ThisTCPInvoker = tcpInvoker;
            this.ToolBlockSet = ToolBlockSet;
            //编写代码


        }

        public FactoryTCPServerInvoker ThisServer
        {
            get
            {
                return ThisTCPInvoker as FactoryTCPServerInvoker;
            }
        }


        public FactoryTCPClientInvoker ThisClient
        {
            get
            {
                return ThisTCPInvoker as FactoryTCPClientInvoker;
            }
        }
        void BindingMainFormDisplayWndByIndex(ToolBlock tbk, int nIndex)
        {
            tbk.DisplayAdapter = (ThisTCPInvoker.ThisJobTool.DisplayWnds[nIndex] as MVDisplay).adapter;
        }

        void AttachJobWindowDisplayWnd(ToolBlock tbk)
        {
            tbk.DisplayAdapter = ThisTCPInvoker.ThisJobTool.DisplayAdapter;
        }
        void RunToolBlockByIndex(int Index)
        {
            ToolBlockSet[Index].Run();
        }
    }
}
