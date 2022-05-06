﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12shader.h(102,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D12_SHADER_DESC
    {
        public uint Version;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Creator;
        public uint Flags;
        public uint ConstantBuffers;
        public uint BoundResources;
        public uint InputParameters;
        public uint OutputParameters;
        public uint InstructionCount;
        public uint TempRegisterCount;
        public uint TempArrayCount;
        public uint DefCount;
        public uint DclCount;
        public uint TextureNormalInstructions;
        public uint TextureLoadInstructions;
        public uint TextureCompInstructions;
        public uint TextureBiasInstructions;
        public uint TextureGradientInstructions;
        public uint FloatInstructionCount;
        public uint IntInstructionCount;
        public uint UintInstructionCount;
        public uint StaticFlowControlCount;
        public uint DynamicFlowControlCount;
        public uint MacroInstructionCount;
        public uint ArrayInstructionCount;
        public uint CutInstructionCount;
        public uint EmitInstructionCount;
        public D3D_PRIMITIVE_TOPOLOGY GSOutputTopology;
        public uint GSMaxOutputVertexCount;
        public D3D_PRIMITIVE InputPrimitive;
        public uint PatchConstantParameters;
        public uint cGSInstanceCount;
        public uint cControlPoints;
        public D3D_TESSELLATOR_OUTPUT_PRIMITIVE HSOutputPrimitive;
        public D3D_TESSELLATOR_PARTITIONING HSPartitioning;
        public D3D_TESSELLATOR_DOMAIN TessellatorDomain;
        public uint cBarrierInstructions;
        public uint cInterlockedInstructions;
        public uint cTextureStoreInstructions;
    }
}
