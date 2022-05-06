﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effectauthor.h(380,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Indicates whether shader support for doubles is present on the underlying hardware. This may be populated using CheckFeatureSupport.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_FEATURE_DATA_DOUBLES
    {
        public bool doublePrecisionFloatShaderOps;
    }
}
