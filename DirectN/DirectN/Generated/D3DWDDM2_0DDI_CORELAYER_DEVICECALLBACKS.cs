﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(6904,9)
using System;
using System.Runtime.InteropServices;
using PFND3D10DDI_DISABLE_DEFERRED_STAGING_RESOURCE_DESTRUCTION_CB = System.IntPtr;
using PFND3D10DDI_SETERROR_CB = System.IntPtr;
using PFND3D10DDI_STATE_GS_CONSTBUF_CB = System.IntPtr;
using PFND3D10DDI_STATE_GS_SAMPLER_CB = System.IntPtr;
using PFND3D10DDI_STATE_GS_SHADER_CB = System.IntPtr;
using PFND3D10DDI_STATE_GS_SRV_CB = System.IntPtr;
using PFND3D10DDI_STATE_IA_INDEXBUF_CB = System.IntPtr;
using PFND3D10DDI_STATE_IA_INPUTLAYOUT_CB = System.IntPtr;
using PFND3D10DDI_STATE_IA_PRIMITIVE_TOPOLOGY_CB = System.IntPtr;
using PFND3D10DDI_STATE_IA_VERTEXBUF_CB = System.IntPtr;
using PFND3D10DDI_STATE_OM_BLENDSTATE_CB = System.IntPtr;
using PFND3D10DDI_STATE_OM_DEPTHSTATE_CB = System.IntPtr;
using PFND3D10DDI_STATE_OM_RENDERTARGETS_CB = System.IntPtr;
using PFND3D10DDI_STATE_PS_CONSTBUF_CB = System.IntPtr;
using PFND3D10DDI_STATE_PS_SAMPLER_CB = System.IntPtr;
using PFND3D10DDI_STATE_PS_SHADER_CB = System.IntPtr;
using PFND3D10DDI_STATE_PS_SRV_CB = System.IntPtr;
using PFND3D10DDI_STATE_RS_RASTSTATE_CB = System.IntPtr;
using PFND3D10DDI_STATE_RS_SCISSOR_CB = System.IntPtr;
using PFND3D10DDI_STATE_RS_VIEWPORTS_CB = System.IntPtr;
using PFND3D10DDI_STATE_SO_TARGETS_CB = System.IntPtr;
using PFND3D10DDI_STATE_TEXTFILTERSIZE_CB = System.IntPtr;
using PFND3D10DDI_STATE_VS_CONSTBUF_CB = System.IntPtr;
using PFND3D10DDI_STATE_VS_SAMPLER_CB = System.IntPtr;
using PFND3D10DDI_STATE_VS_SHADER_CB = System.IntPtr;
using PFND3D10DDI_STATE_VS_SRV_CB = System.IntPtr;
using PFND3D11DDI_PERFORM_AMORTIZED_PROCESSING_CB = System.IntPtr;
using PFND3D11DDI_STATE_CS_CONSTBUF_CB = System.IntPtr;
using PFND3D11DDI_STATE_CS_SAMPLER_CB = System.IntPtr;
using PFND3D11DDI_STATE_CS_SHADER_CB = System.IntPtr;
using PFND3D11DDI_STATE_CS_SRV_CB = System.IntPtr;
using PFND3D11DDI_STATE_CS_UAV_CB = System.IntPtr;
using PFND3D11DDI_STATE_DS_CONSTBUF_CB = System.IntPtr;
using PFND3D11DDI_STATE_DS_SAMPLER_CB = System.IntPtr;
using PFND3D11DDI_STATE_DS_SHADER_CB = System.IntPtr;
using PFND3D11DDI_STATE_DS_SRV_CB = System.IntPtr;
using PFND3D11DDI_STATE_HS_CONSTBUF_CB = System.IntPtr;
using PFND3D11DDI_STATE_HS_SAMPLER_CB = System.IntPtr;
using PFND3D11DDI_STATE_HS_SHADER_CB = System.IntPtr;
using PFND3D11DDI_STATE_HS_SRV_CB = System.IntPtr;
using PFND3DWDDM2_0DDI_CREATECONTEXT_CB = System.IntPtr;
using PFND3DWDDM2_0DDI_CREATECONTEXTVIRTUAL_CB = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_0DDI_CORELAYER_DEVICECALLBACKS
    {
        public IntPtr pfnSetErrorCb;
        public IntPtr pfnStateVsConstBufCb;
        public IntPtr pfnStatePsSrvCb;
        public IntPtr pfnStatePsShaderCb;
        public IntPtr pfnStatePsSamplerCb;
        public IntPtr pfnStateVsShaderCb;
        public IntPtr pfnStatePsConstBufCb;
        public IntPtr pfnStateIaInputLayoutCb;
        public IntPtr pfnStateIaVertexBufCb;
        public IntPtr pfnStateIaIndexBufCb;
        public IntPtr pfnStateGsConstBufCb;
        public IntPtr pfnStateGsShaderCb;
        public IntPtr pfnStateIaPrimitiveTopologyCb;
        public IntPtr pfnStateVsSrvCb;
        public IntPtr pfnStateVsSamplerCb;
        public IntPtr pfnStateGsSrvCb;
        public IntPtr pfnStateGsSamplerCb;
        public IntPtr pfnStateOmRenderTargetsCb;
        public IntPtr pfnStateOmBlendStateCb;
        public IntPtr pfnStateOmDepthStateCb;
        public IntPtr pfnStateRsRastStateCb;
        public IntPtr pfnStateSoTargetsCb;
        public IntPtr pfnStateRsViewportsCb;
        public IntPtr pfnStateRsScissorCb;
        public IntPtr pfnDisableDeferredStagingResourceDestruction;
        public IntPtr pfnStateTextFilterSizeCb;
        public IntPtr pfnStateHsSrvCb;
        public IntPtr pfnStateHsShaderCb;
        public IntPtr pfnStateHsSamplerCb;
        public IntPtr pfnStateHsConstBufCb;
        public IntPtr pfnStateDsSrvCb;
        public IntPtr pfnStateDsShaderCb;
        public IntPtr pfnStateDsSamplerCb;
        public IntPtr pfnStateDsConstBufCb;
        public IntPtr pfnPerformAmortizedProcessingCb;
        public IntPtr pfnStateCsSrvCb;
        public IntPtr pfnStateCsUavCb;
        public IntPtr pfnStateCsShaderCb;
        public IntPtr pfnStateCsSamplerCb;
        public IntPtr pfnStateCsConstBufCb;
        public IntPtr pfnCreateContextCb;
        public IntPtr pfnCreateContextVirtualCb;
    }
}
