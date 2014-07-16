using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using NationalInstruments.VisaNS;

namespace DeviceControl
{
    class OSA
    {
        //public string statusMessage;
        private MessageBasedSession mbs;
        private string resrcName = "";
        public string resrcAddr = "";
        private string rtnString = "";
        //public string OSACmd = "";
        //public int measMode = 0;

        public bool OpenInstr()
        {
            if (resrcAddr=="")
            {
                resrcName="";
            }
            else if (resrcAddr.Contains("."))
            {
                resrcName = "TCPIP0::" + resrcAddr + "::inst0::INSTR";
            }
            else
            {
                resrcName = "GPIB0::" + resrcAddr + "::INSTR";
            }

            if (resrcName!="")
            {
                mbs=(MessageBasedSession)ResourceManager.GetLocalManager().Open(resrcName);
            
                rtnString = mbs.Query("*IDN?");
                if (rtnString.Contains("MS974"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool CloseInstr()
        {
            if (mbs != null)
            {
                mbs.Dispose();
            }
            return true;
        }

        public void PreSet()
        {
            if (OpenInstr())
            {
                mbs.Timeout = 10000;
                mbs.Write("PRE;*WAI");
                //Thread.Sleep(2000);

                mbs.Write("*CLS");
            }
        }

        public void Sweep(int measMode)
        {
            //Auto Sweep
            if (0 == measMode)
            {
                mbs.Write("AUT;*WAI");
            }
            //Single Sweep
            if (1==measMode)
            {
                mbs.Write("SSI;*WAI");
            }
            //Repeat Sweep
            if (2==measMode)
            {
                mbs.Write("SRT;*WAI");
            }
        }

        public bool SaveDataToFile(string fileFormat, string fileName)
        {
            if ("csv" == fileFormat)
            { 
                mbs.Write("SVCSV "+"\""+fileName+"\""+",D;*WAI");
                return true;
            }
            else if("xml"==fileFormat)
            {
                mbs.Write("SVXML " + "\"" + fileName + "\"" + ",D;*WAI");
                return true;
            }
            else if ("png" == fileFormat || "bmp" == fileFormat)
            {
                mbs.Write("PRINT " + "\"" + fileName + "\"" + ",D;*WAI");
                //mbs.Write("PRINT " + "\"" + fileName + "\"" + ",D");
                return true;
            }
            else if ("all"==fileFormat)
            {
                mbs.Write("PRINT " + "\"" + fileName + "\"" + ",D;*WAI");
                mbs.Write("SVXML " + "\"" + fileName + "\"" + ",D;*WAI");
                mbs.Write("PRINT " + "\"" + fileName + "\"" + ",D;*WAI");
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteDataFromFile(string fileFormat, string fileName)
        {
            if ("csv" == fileFormat)
            {
                mbs.Write("DELCSV " + "\"" + fileName + "\"" + ",D;*WAI");
                return true;
            }
            else if ("xml" == fileFormat)
            {
                mbs.Write("DELXML " + "\"" + fileName + "\"" + ",D;*WAI");
                return true;
            }
            else if ("png" == fileFormat || "bmp" == fileFormat)
            {
                mbs.Write("DELCOPYDAT " + "\"" + fileName + "\"" + ",D;*WAI");
                return true;
            }
            else if ("all" == fileFormat)
            {
                mbs.Write("DELCSV " + "\"" + fileName + "\"" + ",D;*WAI");
                mbs.Write("DELXML " + "\"" + fileName + "\"" + ",D;*WAI");
                mbs.Write("DELCOPYDAT " + "\"" + fileName + "\"" + ",D;*WAI");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PeakSearch()
        {
            mbs.Write("PKS PEAK;*WAI");
        }
    }
}
