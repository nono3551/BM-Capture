﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmdt.h(834,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_MONITOR_FREQUENCY_RANGE
    {
        public _D3DKMDT_MONITOR_CAPABILITIES_ORIGIN Origin;
        public _D3DKMDT_FREQUENCY_RANGE RangeLimits;
        public _D3DKMDT_MONITOR_FREQUENCY_RANGE_CONSTRAINT ConstraintType;
        public _D3DKMDT_MONITOR_FREQUENCY_RANGE__union_0 Constraint;
    }
}
