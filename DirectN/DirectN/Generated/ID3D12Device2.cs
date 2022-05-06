﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(10068,5)
using System;
using System.Runtime.InteropServices;
using SECURITY_ATTRIBUTES = DirectN._SECURITY_ATTRIBUTES;

namespace DirectN
{
    [ComImport, Guid("30baa41e-b15b-475c-a0bb-1af5c5b64328"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12Device2 : ID3D12Device1
    {
        // ID3D12Object
        [PreserveSig]
        new HRESULT GetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name);
        
        // ID3D12Device
        [PreserveSig]
        new uint GetNodeCount();
        
        [PreserveSig]
        new HRESULT CreateCommandQueue(/* _In_ */ ref D3D12_COMMAND_QUEUE_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppCommandQueue);
        
        [PreserveSig]
        new HRESULT CreateCommandAllocator(/* _In_ */ D3D12_COMMAND_LIST_TYPE type, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppCommandAllocator);
        
        [PreserveSig]
        new HRESULT CreateGraphicsPipelineState(/* _In_ */ ref D3D12_GRAPHICS_PIPELINE_STATE_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPipelineState);
        
        [PreserveSig]
        new HRESULT CreateComputePipelineState(/* _In_ */ ref D3D12_COMPUTE_PIPELINE_STATE_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPipelineState);
        
        [PreserveSig]
        new HRESULT CreateCommandList(/* _In_ */ uint nodeMask, /* _In_ */ D3D12_COMMAND_LIST_TYPE type, /* _In_ */ ID3D12CommandAllocator pCommandAllocator, /* _In_opt_ */ ID3D12PipelineState pInitialState, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppCommandList);
        
        [PreserveSig]
        new HRESULT CheckFeatureSupport(D3D12_FEATURE Feature, /* _Inout_updates_bytes_(FeatureSupportDataSize) */ IntPtr pFeatureSupportData, uint FeatureSupportDataSize);
        
        [PreserveSig]
        new HRESULT CreateDescriptorHeap(/* _In_ */ ref D3D12_DESCRIPTOR_HEAP_DESC pDescriptorHeapDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvHeap);
        
        [PreserveSig]
        new uint GetDescriptorHandleIncrementSize(/* _In_ */ D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType);
        
        [PreserveSig]
        new HRESULT CreateRootSignature(/* _In_ */ uint nodeMask, /* _In_reads_(blobLengthInBytes) */ IntPtr pBlobWithRootSignature, /* _In_ */ IntPtr blobLengthInBytes, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvRootSignature);
        
        [PreserveSig]
        new void CreateConstantBufferView(/* optional(D3D12_CONSTANT_BUFFER_VIEW_DESC) */ IntPtr pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        new void CreateShaderResourceView(/* _In_opt_ */ ID3D12Resource pResource, /* optional(D3D12_SHADER_RESOURCE_VIEW_DESC) */ IntPtr pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        new void CreateUnorderedAccessView(/* _In_opt_ */ ID3D12Resource pResource, /* _In_opt_ */ ID3D12Resource pCounterResource, /* optional(D3D12_UNORDERED_ACCESS_VIEW_DESC) */ IntPtr pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        new void CreateRenderTargetView(/* _In_opt_ */ ID3D12Resource pResource, /* optional(D3D12_RENDER_TARGET_VIEW_DESC) */ IntPtr pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        new void CreateDepthStencilView(/* _In_opt_ */ ID3D12Resource pResource, /* optional(D3D12_DEPTH_STENCIL_VIEW_DESC) */ IntPtr pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        new void CreateSampler(/* _In_ */ ref D3D12_SAMPLER_DESC pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        new void CopyDescriptors(/* _In_ */ int NumDestDescriptorRanges, /* _In_reads_(NumDestDescriptorRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_CPU_DESCRIPTOR_HANDLE[] pDestDescriptorRangeStarts, /* _In_reads_opt_(NumDestDescriptorRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pDestDescriptorRangeSizes, /* _In_ */ int NumSrcDescriptorRanges, /* _In_reads_(NumSrcDescriptorRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D12_CPU_DESCRIPTOR_HANDLE[] pSrcDescriptorRangeStarts, /* _In_reads_opt_(NumSrcDescriptorRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] pSrcDescriptorRangeSizes, /* _In_ */ D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);
        
        [PreserveSig]
        new void CopyDescriptorsSimple(/* _In_ */ uint NumDescriptors, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, /* _In_ */ D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);
        
        [PreserveSig]
        new void GetResourceAllocationInfo(out D3D12_RESOURCE_ALLOCATION_INFO size, /* _In_ */ uint visibleMask, /* _In_ */ int numResourceDescs, /* _In_reads_(numResourceDescs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D12_RESOURCE_DESC[] pResourceDescs);
        
        [PreserveSig]
        new void GetCustomHeapProperties(out D3D12_HEAP_PROPERTIES size, /* _In_ */ uint nodeMask, D3D12_HEAP_TYPE heapType);
        
        [PreserveSig]
        new HRESULT CreateCommittedResource(/* _In_ */ ref D3D12_HEAP_PROPERTIES pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, /* _In_ */ ref D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialResourceState, /* optional(D3D12_CLEAR_VALUE) */ IntPtr pOptimizedClearValue, [MarshalAs(UnmanagedType.LPStruct)] Guid riidResource, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvResource);
        
        [PreserveSig]
        new HRESULT CreateHeap(/* _In_ */ ref D3D12_HEAP_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvHeap);
        
        [PreserveSig]
        new HRESULT CreatePlacedResource(/* _In_ */ ID3D12Heap pHeap, ulong HeapOffset, /* _In_ */ ref D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialState, /* optional(D3D12_CLEAR_VALUE) */ IntPtr pOptimizedClearValue, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvResource);
        
        [PreserveSig]
        new HRESULT CreateReservedResource(/* _In_ */ ref D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialState, /* optional(D3D12_CLEAR_VALUE) */ IntPtr pOptimizedClearValue, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvResource);
        
        [PreserveSig]
        new HRESULT CreateSharedHandle(/* _In_ */ ID3D12DeviceChild pObject, /* optional(SECURITY_ATTRIBUTES) */ IntPtr pAttributes, uint Access, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name, /* _Out_ */ out IntPtr pHandle);
        
        [PreserveSig]
        new HRESULT OpenSharedHandle(/* _In_ */ IntPtr NTHandle, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);
        
        [PreserveSig]
        new HRESULT OpenSharedHandleByName(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name, uint Access, /* [annotation][out] _Out_ */ out IntPtr pNTHandle);
        
        [PreserveSig]
        new HRESULT MakeResident(int NumObjects, /* _In_reads_(NumObjects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ID3D12Pageable[] ppObjects);
        
        [PreserveSig]
        new HRESULT Evict(int NumObjects, /* _In_reads_(NumObjects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ID3D12Pageable[] ppObjects);
        
        [PreserveSig]
        new HRESULT CreateFence(ulong InitialValue, D3D12_FENCE_FLAGS Flags, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppFence);
        
        [PreserveSig]
        new HRESULT GetDeviceRemovedReason();
        
        [PreserveSig]
        new void GetCopyableFootprints(/* _In_ */ ref D3D12_RESOURCE_DESC pResourceDesc, /* _In_range_(0,D3D12_REQ_SUBRESOURCES) */ uint FirstSubresource, /* _In_range_(0,D3D12_REQ_SUBRESOURCES-FirstSubresource) */ int NumSubresources, ulong BaseOffset, /* _Out_writes_opt_(NumSubresources) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D12_PLACED_SUBRESOURCE_FOOTPRINT[] pLayouts, /* _Out_writes_opt_(NumSubresources) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] pNumRows, /* _Out_writes_opt_(NumSubresources) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ulong[] pRowSizeInBytes, /* optional(UINT64) */ IntPtr pTotalBytes);
        
        [PreserveSig]
        new HRESULT CreateQueryHeap(/* _In_ */ ref D3D12_QUERY_HEAP_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvHeap);
        
        [PreserveSig]
        new HRESULT SetStablePowerState(bool Enable);
        
        [PreserveSig]
        new HRESULT CreateCommandSignature(/* _In_ */ ref D3D12_COMMAND_SIGNATURE_DESC pDesc, /* _In_opt_ */ ID3D12RootSignature pRootSignature, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvCommandSignature);
        
        [PreserveSig]
        new void GetResourceTiling(/* _In_ */ ID3D12Resource pTiledResource, /* optional(UINT) */ IntPtr pNumTilesForEntireResource, /* optional(D3D12_PACKED_MIP_INFO) */ IntPtr pPackedMipDesc, /* optional(D3D12_TILE_SHAPE) */ IntPtr pStandardTileShapeForNonPackedMips, /* optional(UINT) */ IntPtr pNumSubresourceTilings, /* _In_ */ uint FirstSubresourceTilingToGet, /* _Out_writes_(*pNumSubresourceTilings) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D3D12_SUBRESOURCE_TILING[] pSubresourceTilingsForNonPackedMips);
        
        [PreserveSig]
        new void GetAdapterLuid(out _LUID size);
        
        // ID3D12Device1
        [PreserveSig]
        new HRESULT CreatePipelineLibrary(/* _In_reads_(BlobLength) */ IntPtr pLibraryBlob, IntPtr BlobLength, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPipelineLibrary);
        
        [PreserveSig]
        new HRESULT SetEventOnMultipleFenceCompletion(/* _In_reads_(NumFences) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID3D12Fence[] ppFences, /* _In_reads_(NumFences) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ulong[] pFenceValues, int NumFences, D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags, IntPtr hEvent);
        
        [PreserveSig]
        new HRESULT SetResidencyPriority(int NumObjects, /* _In_reads_(NumObjects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ID3D12Pageable[] ppObjects, /* _In_reads_(NumObjects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_RESIDENCY_PRIORITY[] pPriorities);
        
        // ID3D12Device2
        [PreserveSig]
        HRESULT CreatePipelineState(ref D3D12_PIPELINE_STATE_STREAM_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPipelineState);
    }
}
