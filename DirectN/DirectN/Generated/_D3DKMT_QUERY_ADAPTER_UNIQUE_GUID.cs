﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(2014,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DKMT_QUERY_ADAPTER_UNIQUE_GUID
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)] 
        public string AdapterUniqueGUID;
    }
}
