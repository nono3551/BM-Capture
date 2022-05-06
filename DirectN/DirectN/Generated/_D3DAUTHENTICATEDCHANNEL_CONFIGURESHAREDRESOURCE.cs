﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3d9types.h(2404,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE
    {
        public _D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT Parameters;
        public _D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE ProcessIdentiferType;
        public IntPtr ProcessHandle;
        public bool AllowAccess;
    }
}
