﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(5757,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_CAMERACONTROL_FOCAL_LENGTH_S
    {
        public KSIDENTIFIER Property;
        public int lOcularFocalLength;
        public int lObjectiveFocalLengthMin;
        public int lObjectiveFocalLengthMax;
    }
}
