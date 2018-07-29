using dotNetLab.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dotNetLab.Common;
namespace shikii.VisionJob.通讯
{
   public class TCPFactoryClient : TCPClient
    {
        readonly string TCPTABLENAME = "TCP";
        // For Decoding Hex String
        byte[] byt_Arr = null;
        public TCPFactoryClient()
        {
            byt_Arr = new byte[256];
            this.TextEncode = Encoding.ASCII;
            try
            {
                R.CompactDB.GetAllTableNames();
                if (!R.CompactDB.AllTableNames.Contains(TCPTABLENAME))
                {
                    R.CompactDB.CreateKeyValueTable(TCPTABLENAME);
                }
                R.CompactDB.TargetTable = TCPTABLENAME;
                List<String> lst = R.CompactDB.GetNameColumnValues(R.CompactDB.TargetTable);
                if (lst.Count == 0)
                {
                    R.Pipe.Error("读取网络配置时失败，将增加新记录");
                }
                if (!lst.Contains("Port"))
                {
                    R.CompactDB.Write("Port", "8040");
                }
                if (!lst.Contains("LoopGapTime"))
                {
                    R.CompactDB.Write("LoopGapTime", "500");
                }
                if (!lst.Contains("IP"))
                {
                    R.CompactDB.Write("IP", "127.0.0.1");
                }
                Port = int.Parse(R.CompactDB.FetchValue("Port"));
                LoopGapTime = int.Parse(R.CompactDB.FetchValue("LoopGapTime"));
                IP = R.CompactDB.FetchValue("IP");
                R.CompactDB.TargetTable = R.CompactDB.DefaultTable;

            }
            catch (Exception ex)
            {

            }

        }
        public bool Send_Mill( byte[] byt_Content)
        {
            try
            {
                 
                int nResult = Client.Send(byt_Content);
                if (nResult > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {


                dotNetLab.Tipper.Ask = "是否未连接到指定的客户端？\r\n建议重新启动本程序重试。";

                return false;
            }

        }
         
        public bool Send_Mill(  String strWord)
        {
            byte[] bytArr = this.TextEncode.GetBytes(strWord);
            return Send_Mill( bytArr);
        }
        //Decode That String To Byte(0-255)
        void DecodeHexString(String str)
        {
            String[] temp = str.Split(new char[] { ' ' });
            int nIndex = 0;
            foreach (var item in temp)
            {
                this.byt_Arr[nIndex++] =
                    byte.Parse(item,
                    System.Globalization.NumberStyles.HexNumber);
            }
        }
        public virtual bool SendHexStr( String strContent)
        {
            DecodeHexString(strContent);
            return Send_Mill(  byt_Arr);
        }
        

    }
}
