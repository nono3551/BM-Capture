﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dtypes.h(800,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DLIGHT
    {
        public uint dwSize;
        public _D3DLIGHTTYPE dltType;
        public _D3DCOLORVALUE dcvColor;
        public _D3DVECTOR dvPosition;
        public _D3DVECTOR dvDirection;
        public float dvRange;
        public float dvFalloff;
        public float dvAttenuation0;
        public float dvAttenuation1;
        public float dvAttenuation2;
        public float dvTheta;
        public float dvPhi;
    }
}
