﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mmeapi.h(954,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct tagMIDIINCAPS2W
    {
        public ushort wMid;
        public ushort wPid;
        public uint vDriverVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string szPname;
        public uint dwSupport;
        public Guid ManufacturerGuid;
        public Guid ProductGuid;
        public Guid NameGuid;
    }
}
