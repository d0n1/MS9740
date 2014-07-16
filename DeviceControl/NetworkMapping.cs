using System;
using System.Text;
using System.Runtime.InteropServices;

namespace DeviceControl
{

    class NetworkMapping
    {
        [DllImport("mpr.dll")]
        private static extern int WNetAddConnection2A(ref structNetResource pstNetRes, string psPassword, string psUsername, UInt32 pdwFlags);
        [DllImport("mpr.dll")]
        private static extern int WNetCancelConnection2A(string psName, UInt32 pdwFlags, bool pblnForce);
        [DllImport("mpr.dll")]
        private static extern int WNetConnectionDialog(int phWnd, int piType);
        [DllImport("mpr.dll")]
        private static extern int WNetDisconnectDialog(int phWnd, int piType);
        [DllImport("mpr.dll")]
        private static extern int WNetRestoreConnectionW(int phWnd, string psLocalDrive);
        [StructLayout(LayoutKind.Sequential)]
        private struct structNetResource
        {
            public UInt32 dwScope;
            public UInt32 dwType;
            public UInt32 dwDisplayType;
            public UInt32 dwUsage;
            public string lpLocalName;
            public string lpRemoteName;
            public string lpComment;
            public string lpProvider;
        }
        #region Parameters
        //dwScope
        private const UInt32 RESOURCE_CONNECTED = 0x00000001;
        private const UInt32 RESOURCE_GLOBALNET = 0x00000002;
        private const UInt32 RESOURCE_REMEMBERED = 0x00000003;
        private const UInt32 RESOURCE_RECENT = 0x00000004;
        private const UInt32 RESOURCE_CONTEXT = 0x00000005;
        //dwType
        private const UInt32 RESOURCETYPE_ANY = 0x00000000;
        private const UInt32 RESOURCETYPE_DISK = 0x00000001;
        private const UInt32 RESOURCETYPE_PRINT = 0x00000002;
        private const UInt32 RESOURCETYPE_RESERVED = 0x00000008;
        private const UInt32 RESOURCETYPE_UNKNOWN = 0xFFFFFFFF;
        //dwUsage
        private const UInt32 RESOURCEUSAGE_CONNECTABLE = 0x00000001;
        private const UInt32 RESOURCEUSAGE_CONTAINER = 0x00000002;
        private const UInt32 RESOURCEUSAGE_NOLOCALDEVICE = 0x00000004;
        private const UInt32 RESOURCEUSAGE_SIBLING = 0x00000008;
        private const UInt32 RESOURCEUSAGE_ATTACHED = 0x00000010;
        private const UInt32 RESOURCEUSAGE_ALL = 0x00000013;
        //dwDisplayType
        private const UInt32 RESOURCEDISPLAYTYPE_GENERIC = 0x00000000;
        private const UInt32 RESOURCEDISPLAYTYPE_DOMAIN = 0x00000001;
        private const UInt32 RESOURCEDISPLAYTYPE_SERVER = 0x00000002;
        private const UInt32 RESOURCEDISPLAYTYPE_SHARE = 0x00000003;
        private const UInt32 RESOURCEDISPLAYTYPE_FILE = 0x00000004;
        private const UInt32 RESOURCEDISPLAYTYPE_GROUP = 0x00000005;
        private const UInt32 RESOURCEDISPLAYTYPE_NETWORK = 0x00000006;
        private const UInt32 RESOURCEDISPLAYTYPE_ROOT = 0x00000007;
        private const UInt32 RESOURCEDISPLAYTYPE_SHAREADMIN = 0x00000008;
        private const UInt32 RESOURCEDISPLAYTYPE_DIRECTORY = 0x00000009;
        private const UInt32 RESOURCEDISPLAYTYPE_TREE = 0x0000000A;
        private const UInt32 RESOURCEDISPLAYTYPE_NDSCONTAINER = 0x0000000B;
        //dwFlag
        private const UInt32 CONNECT_UPDATE_PROFILE = 0x00000001;
        private const UInt32 CONNECT_UPDATE_RECENT = 0x00000002;
        private const UInt32 CONNECT_TEMPORARY = 0x00000004;
        private const UInt32 CONNECT_INTERACTIVE = 0x00000008;
        private const UInt32 CONNECT_PROMPT = 0x00000010;
        private const UInt32 CONNECT_NEED_DRIVE = 0x00000020;
        private const UInt32 CONNECT_REFCOUNT = 0x00000040;
        private const UInt32 CONNECT_REDIRECT = 0x00000080;
        private const UInt32 CONNECT_LOCALDRIVE = 0x00000100;
        private const UInt32 CONNECT_CURRENT_MEDIA = 0x00000200;
        private const UInt32 CONNECT_DEFERRED = 0x00000400;
        private const UInt32 CONNECT_RESERVED = 0xFF000000;
        private const UInt32 CONNECT_COMMANDLINE = 0x00000800;
        private const UInt32 CONNECT_CMD_SAVECRED = 0x00001000;
        private const UInt32 CONNECT_CRED_RESET = 0x00002000;

        #endregion

        private string _remotePath;
        private string _localDriver;

        public string RemotePath
        {
            get { return _remotePath; }
            set { _remotePath = value; }
        }

        public string LocalDriver
        {
            get { return _localDriver; }
            set { _localDriver = value; }
        }

        public bool MapDrivers(string pstrUserName, string pstrPassword)
        {
            structNetResource NetResrc= new structNetResource();
            NetResrc.dwScope = RESOURCE_GLOBALNET;               	
            NetResrc.dwType = RESOURCETYPE_DISK;
            NetResrc.dwDisplayType = RESOURCEDISPLAYTYPE_SHARE;
            NetResrc.dwUsage = RESOURCEUSAGE_CONNECTABLE;               
            //NetResrc.lpRemoteName = RemotePath; 
            NetResrc.lpRemoteName = RemotePath; 
            NetResrc.lpLocalName = LocalDriver;
            UInt32 dwFlag = 0;
            // Connection interact with the user for authentication purposes and not be remembered.
            dwFlag = CONNECT_INTERACTIVE + CONNECT_TEMPORARY;
            int i = WNetAddConnection2A(ref NetResrc, pstrPassword, pstrUserName, dwFlag);
            if (i > 0)
            {
                //return false;
                throw new System.ComponentModel.Win32Exception(i);
                
            }
            else
                return true;
        }

        public bool UnMapDrivers(bool pblnForce)
        {
            UInt32 dwFlag = 0;//Connection is not persistent.
            
            int i = WNetCancelConnection2A(LocalDriver, dwFlag, pblnForce);

            if (i != 0)
            {
                i = WNetCancelConnection2A(RemotePath, dwFlag, pblnForce);
            }

            if (i > 0)
            {
                return false;
                throw new System.ComponentModel.Win32Exception(i);
            }
            return true;
        }
    }
}
