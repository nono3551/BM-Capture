﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12shader.h(348,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("5a58797d-a72c-478d-8ba2-efc6b0efe88e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12ShaderReflection
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D12_SHADER_DESC pDesc);
        
        [PreserveSig]
        ID3D12ShaderReflectionConstantBuffer GetConstantBufferByIndex(/* THIS_ _In_ */ uint Index);
        
        [PreserveSig]
        ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        HRESULT GetResourceBindingDesc(/* THIS_ _In_ */ uint ResourceIndex, /* _Out_ */ out _D3D12_SHADER_INPUT_BIND_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetInputParameterDesc(/* THIS_ _In_ */ uint ParameterIndex, /* _Out_ */ out _D3D12_SIGNATURE_PARAMETER_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetOutputParameterDesc(/* THIS_ _In_ */ uint ParameterIndex, /* _Out_ */ out _D3D12_SIGNATURE_PARAMETER_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetPatchConstantParameterDesc(/* THIS_ _In_ */ uint ParameterIndex, /* _Out_ */ out _D3D12_SIGNATURE_PARAMETER_DESC pDesc);
        
        [PreserveSig]
        ID3D12ShaderReflectionVariable GetVariableByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        HRESULT GetResourceBindingDescByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name, /* _Out_ */ out _D3D12_SHADER_INPUT_BIND_DESC pDesc);
        
        [PreserveSig]
        uint GetMovInstructionCount();
        
        [PreserveSig]
        uint GetMovcInstructionCount();
        
        [PreserveSig]
        uint GetConversionInstructionCount();
        
        [PreserveSig]
        uint GetBitwiseInstructionCount();
        
        [PreserveSig]
        D3D_PRIMITIVE GetGSInputPrimitive();
        
        [PreserveSig]
        bool IsSampleFrequencyShader();
        
        [PreserveSig]
        uint GetNumInterfaceSlots();
        
        [PreserveSig]
        HRESULT GetMinFeatureLevel(/* THIS_ _Out_ */ out D3D_FEATURE_LEVEL pLevel);
        
        [PreserveSig]
        uint GetThreadGroupSize(/* optional(UINT) */ IntPtr pSizeX, /* optional(UINT) */ IntPtr pSizeY, /* optional(UINT) */ IntPtr pSizeZ);
        
        [PreserveSig]
        ulong GetRequiresFlags();
    }
}
