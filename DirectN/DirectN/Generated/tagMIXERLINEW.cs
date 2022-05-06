﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mmeapi.h(1888,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct tagMIXERLINEW
    {
        public uint cbStruct;
        public uint dwDestination;
        public uint dwSource;
        public uint dwLineID;
        public uint fdwLine;
        public IntPtr dwUser;
        public uint dwComponentType;
        public uint cChannels;
        public uint cConnections;
        public uint cControls;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)] 
        public string szShortName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] 
        public string szName;
        public tagMIXERLINEW__struct_0 Target;
    }
}
