using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000D5 RID: 213
	public sealed class SystemInfo : Object
	{
		// Token: 0x060011EC RID: 4588 RVA: 0x000479F4 File Offset: 0x00045BF4
		// Note: this type is marked as 'beforefieldinit'.
		static SystemInfo()
		{
			Il2CppClassPointerStore<SystemInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SystemInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr);
			SystemInfo.NativeMethodInfoPtr_get_operatingSystem_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664544);
			SystemInfo.NativeMethodInfoPtr_get_operatingSystemFamily_Public_Static_get_OperatingSystemFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664545);
			SystemInfo.NativeMethodInfoPtr_get_processorCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664546);
			SystemInfo.NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664547);
			SystemInfo.NativeMethodInfoPtr_get_deviceName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664548);
			SystemInfo.NativeMethodInfoPtr_get_deviceModel_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664549);
			SystemInfo.NativeMethodInfoPtr_get_deviceType_Public_Static_get_DeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664550);
			SystemInfo.NativeMethodInfoPtr_IsValidEnumValue_Private_Static_Boolean_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664551);
			SystemInfo.NativeMethodInfoPtr_SupportsTextureFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664552);
			SystemInfo.NativeMethodInfoPtr_GetOperatingSystem_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664553);
			SystemInfo.NativeMethodInfoPtr_GetOperatingSystemFamily_Private_Static_OperatingSystemFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664554);
			SystemInfo.NativeMethodInfoPtr_GetProcessorCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664555);
			SystemInfo.NativeMethodInfoPtr_GetDeviceUniqueIdentifier_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664556);
			SystemInfo.NativeMethodInfoPtr_GetDeviceName_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664557);
			SystemInfo.NativeMethodInfoPtr_GetDeviceModel_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664558);
			SystemInfo.NativeMethodInfoPtr_GetDeviceType_Private_Static_DeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664559);
			SystemInfo.NativeMethodInfoPtr_SupportsTextureFormatNative_Private_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664560);
			SystemInfo.NativeMethodInfoPtr_IsFormatSupported_Public_Static_Boolean_GraphicsFormat_FormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664561);
			SystemInfo.NativeMethodInfoPtr_GetCompatibleFormat_Public_Static_GraphicsFormat_GraphicsFormat_FormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664562);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100664563);
			SystemInfo.GetBatteryLevelDelegateField = IL2CPP.ResolveICall<SystemInfo.GetBatteryLevelDelegate>("UnityEngine.SystemInfo::GetBatteryLevel");
			SystemInfo.GetBatteryStatusDelegateField = IL2CPP.ResolveICall<SystemInfo.GetBatteryStatusDelegate>("UnityEngine.SystemInfo::GetBatteryStatus");
			SystemInfo.GetProcessorTypeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetProcessorTypeDelegate>("UnityEngine.SystemInfo::GetProcessorType");
			SystemInfo.GetProcessorFrequencyMHzDelegateField = IL2CPP.ResolveICall<SystemInfo.GetProcessorFrequencyMHzDelegate>("UnityEngine.SystemInfo::GetProcessorFrequencyMHz");
			SystemInfo.GetPhysicalMemoryMBDelegateField = IL2CPP.ResolveICall<SystemInfo.GetPhysicalMemoryMBDelegate>("UnityEngine.SystemInfo::GetPhysicalMemoryMB");
			SystemInfo.SupportsAccelerometerDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAccelerometerDelegate>("UnityEngine.SystemInfo::SupportsAccelerometer");
			SystemInfo.IsGyroAvailableDelegateField = IL2CPP.ResolveICall<SystemInfo.IsGyroAvailableDelegate>("UnityEngine.SystemInfo::IsGyroAvailable");
			SystemInfo.SupportsLocationServiceDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsLocationServiceDelegate>("UnityEngine.SystemInfo::SupportsLocationService");
			SystemInfo.SupportsVibrationDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsVibrationDelegate>("UnityEngine.SystemInfo::SupportsVibration");
			SystemInfo.SupportsAudioDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAudioDelegate>("UnityEngine.SystemInfo::SupportsAudio");
			SystemInfo.GetGraphicsMemorySizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsMemorySizeDelegate>("UnityEngine.SystemInfo::GetGraphicsMemorySize");
			SystemInfo.GetGraphicsDeviceNameDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsDeviceNameDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceName");
			SystemInfo.GetGraphicsDeviceVendorDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsDeviceVendorDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceVendor");
			SystemInfo.GetGraphicsDeviceIDDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsDeviceIDDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceID");
			SystemInfo.GetGraphicsDeviceVendorIDDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsDeviceVendorIDDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceVendorID");
			SystemInfo.GetGraphicsDeviceTypeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsDeviceTypeDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceType");
			SystemInfo.GetGraphicsUVStartsAtTopDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsUVStartsAtTopDelegate>("UnityEngine.SystemInfo::GetGraphicsUVStartsAtTop");
			SystemInfo.GetGraphicsDeviceVersionDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsDeviceVersionDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceVersion");
			SystemInfo.GetGraphicsShaderLevelDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsShaderLevelDelegate>("UnityEngine.SystemInfo::GetGraphicsShaderLevel");
			SystemInfo.GetGraphicsMultiThreadedDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsMultiThreadedDelegate>("UnityEngine.SystemInfo::GetGraphicsMultiThreaded");
			SystemInfo.GetRenderingThreadingModeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetRenderingThreadingModeDelegate>("UnityEngine.SystemInfo::GetRenderingThreadingMode");
			SystemInfo.HasHiddenSurfaceRemovalOnGPUDelegateField = IL2CPP.ResolveICall<SystemInfo.HasHiddenSurfaceRemovalOnGPUDelegate>("UnityEngine.SystemInfo::HasHiddenSurfaceRemovalOnGPU");
			SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegateField = IL2CPP.ResolveICall<SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegate>("UnityEngine.SystemInfo::HasDynamicUniformArrayIndexingInFragmentShaders");
			SystemInfo.SupportsShadowsDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsShadowsDelegate>("UnityEngine.SystemInfo::SupportsShadows");
			SystemInfo.SupportsRawShadowDepthSamplingDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsRawShadowDepthSamplingDelegate>("UnityEngine.SystemInfo::SupportsRawShadowDepthSampling");
			SystemInfo.SupportsMotionVectorsDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMotionVectorsDelegate>("UnityEngine.SystemInfo::SupportsMotionVectors");
			SystemInfo.Supports3DTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.Supports3DTexturesDelegate>("UnityEngine.SystemInfo::Supports3DTextures");
			SystemInfo.SupportsCompressed3DTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsCompressed3DTexturesDelegate>("UnityEngine.SystemInfo::SupportsCompressed3DTextures");
			SystemInfo.Supports2DArrayTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.Supports2DArrayTexturesDelegate>("UnityEngine.SystemInfo::Supports2DArrayTextures");
			SystemInfo.Supports3DRenderTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.Supports3DRenderTexturesDelegate>("UnityEngine.SystemInfo::Supports3DRenderTextures");
			SystemInfo.SupportsCubemapArrayTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsCubemapArrayTexturesDelegate>("UnityEngine.SystemInfo::SupportsCubemapArrayTextures");
			SystemInfo.GetCopyTextureSupportDelegateField = IL2CPP.ResolveICall<SystemInfo.GetCopyTextureSupportDelegate>("UnityEngine.SystemInfo::GetCopyTextureSupport");
			SystemInfo.SupportsComputeShadersDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsComputeShadersDelegate>("UnityEngine.SystemInfo::SupportsComputeShaders");
			SystemInfo.SupportsGeometryShadersDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsGeometryShadersDelegate>("UnityEngine.SystemInfo::SupportsGeometryShaders");
			SystemInfo.SupportsTessellationShadersDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsTessellationShadersDelegate>("UnityEngine.SystemInfo::SupportsTessellationShaders");
			SystemInfo.SupportsRenderTargetArrayIndexFromVertexShaderDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsRenderTargetArrayIndexFromVertexShaderDelegate>("UnityEngine.SystemInfo::SupportsRenderTargetArrayIndexFromVertexShader");
			SystemInfo.SupportsInstancingDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsInstancingDelegate>("UnityEngine.SystemInfo::SupportsInstancing");
			SystemInfo.SupportsHardwareQuadTopologyDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsHardwareQuadTopologyDelegate>("UnityEngine.SystemInfo::SupportsHardwareQuadTopology");
			SystemInfo.Supports32bitsIndexBufferDelegateField = IL2CPP.ResolveICall<SystemInfo.Supports32bitsIndexBufferDelegate>("UnityEngine.SystemInfo::Supports32bitsIndexBuffer");
			SystemInfo.SupportsSparseTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsSparseTexturesDelegate>("UnityEngine.SystemInfo::SupportsSparseTextures");
			SystemInfo.SupportedRenderTargetCountDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportedRenderTargetCountDelegate>("UnityEngine.SystemInfo::SupportedRenderTargetCount");
			SystemInfo.SupportsSeparatedRenderTargetsBlendDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsSeparatedRenderTargetsBlendDelegate>("UnityEngine.SystemInfo::SupportsSeparatedRenderTargetsBlend");
			SystemInfo.SupportedRandomWriteTargetCountDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportedRandomWriteTargetCountDelegate>("UnityEngine.SystemInfo::SupportedRandomWriteTargetCount");
			SystemInfo.MaxComputeBufferInputsVertexDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsVertexDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsVertex");
			SystemInfo.MaxComputeBufferInputsFragmentDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsFragmentDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsFragment");
			SystemInfo.MaxComputeBufferInputsGeometryDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsGeometryDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsGeometry");
			SystemInfo.MaxComputeBufferInputsDomainDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsDomainDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsDomain");
			SystemInfo.MaxComputeBufferInputsHullDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsHullDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsHull");
			SystemInfo.MaxComputeBufferInputsComputeDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsComputeDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsCompute");
			SystemInfo.SupportsMultisampledTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMultisampledTexturesDelegate>("UnityEngine.SystemInfo::SupportsMultisampledTextures");
			SystemInfo.SupportsMultisampled2DArrayTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMultisampled2DArrayTexturesDelegate>("UnityEngine.SystemInfo::SupportsMultisampled2DArrayTextures");
			SystemInfo.SupportsMultisampleAutoResolveDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMultisampleAutoResolveDelegate>("UnityEngine.SystemInfo::SupportsMultisampleAutoResolve");
			SystemInfo.SupportsTextureWrapMirrorOnceDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsTextureWrapMirrorOnceDelegate>("UnityEngine.SystemInfo::SupportsTextureWrapMirrorOnce");
			SystemInfo.UsesReversedZBufferDelegateField = IL2CPP.ResolveICall<SystemInfo.UsesReversedZBufferDelegate>("UnityEngine.SystemInfo::UsesReversedZBuffer");
			SystemInfo.HasRenderTextureNativeDelegateField = IL2CPP.ResolveICall<SystemInfo.HasRenderTextureNativeDelegate>("UnityEngine.SystemInfo::HasRenderTextureNative");
			SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegate>("UnityEngine.SystemInfo::SupportsBlendingOnRenderTextureFormatNative");
			SystemInfo.SupportsRandomWriteOnRenderTextureFormatNativeDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsRandomWriteOnRenderTextureFormatNativeDelegate>("UnityEngine.SystemInfo::SupportsRandomWriteOnRenderTextureFormatNative");
			SystemInfo.SupportsVertexAttributeFormatNativeDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsVertexAttributeFormatNativeDelegate>("UnityEngine.SystemInfo::SupportsVertexAttributeFormatNative");
			SystemInfo.GetNPOTSupportDelegateField = IL2CPP.ResolveICall<SystemInfo.GetNPOTSupportDelegate>("UnityEngine.SystemInfo::GetNPOTSupport");
			SystemInfo.GetMaxTextureSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxTextureSizeDelegate>("UnityEngine.SystemInfo::GetMaxTextureSize");
			SystemInfo.GetMaxCubemapSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxCubemapSizeDelegate>("UnityEngine.SystemInfo::GetMaxCubemapSize");
			SystemInfo.GetMaxRenderTextureSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxRenderTextureSizeDelegate>("UnityEngine.SystemInfo::GetMaxRenderTextureSize");
			SystemInfo.GetMaxComputeWorkGroupSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSize");
			SystemInfo.GetMaxComputeWorkGroupSizeXDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeXDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSizeX");
			SystemInfo.GetMaxComputeWorkGroupSizeYDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeYDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSizeY");
			SystemInfo.GetMaxComputeWorkGroupSizeZDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeZDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSizeZ");
			SystemInfo.SupportsAsyncComputeDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAsyncComputeDelegate>("UnityEngine.SystemInfo::SupportsAsyncCompute");
			SystemInfo.SupportsGpuRecorderDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsGpuRecorderDelegate>("UnityEngine.SystemInfo::SupportsGpuRecorder");
			SystemInfo.SupportsGPUFenceDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsGPUFenceDelegate>("UnityEngine.SystemInfo::SupportsGPUFence");
			SystemInfo.SupportsAsyncGPUReadbackDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAsyncGPUReadbackDelegate>("UnityEngine.SystemInfo::SupportsAsyncGPUReadback");
			SystemInfo.SupportsRayTracingDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsRayTracingDelegate>("UnityEngine.SystemInfo::SupportsRayTracing");
			SystemInfo.SupportsSetConstantBufferDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsSetConstantBufferDelegate>("UnityEngine.SystemInfo::SupportsSetConstantBuffer");
			SystemInfo.MinConstantBufferOffsetAlignmentDelegateField = IL2CPP.ResolveICall<SystemInfo.MinConstantBufferOffsetAlignmentDelegate>("UnityEngine.SystemInfo::MinConstantBufferOffsetAlignment");
			SystemInfo.HasMipMaxLevelDelegateField = IL2CPP.ResolveICall<SystemInfo.HasMipMaxLevelDelegate>("UnityEngine.SystemInfo::HasMipMaxLevel");
			SystemInfo.SupportsMipStreamingDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMipStreamingDelegate>("UnityEngine.SystemInfo::SupportsMipStreaming");
			SystemInfo.UsesLoadStoreActionsDelegateField = IL2CPP.ResolveICall<SystemInfo.UsesLoadStoreActionsDelegate>("UnityEngine.SystemInfo::UsesLoadStoreActions");
			SystemInfo.GetHDRDisplaySupportFlagsDelegateField = IL2CPP.ResolveICall<SystemInfo.GetHDRDisplaySupportFlagsDelegate>("UnityEngine.SystemInfo::GetHDRDisplaySupportFlags");
			SystemInfo.SupportsConservativeRasterDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsConservativeRasterDelegate>("UnityEngine.SystemInfo::SupportsConservativeRaster");
			SystemInfo.SupportsMultiviewDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMultiviewDelegate>("UnityEngine.SystemInfo::SupportsMultiview");
			SystemInfo.SupportsStoreAndResolveActionDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsStoreAndResolveActionDelegate>("UnityEngine.SystemInfo::SupportsStoreAndResolveAction");
			SystemInfo.GetRenderTextureSupportedMSAASampleCount_InjectedDelegateField = IL2CPP.ResolveICall<SystemInfo.GetRenderTextureSupportedMSAASampleCount_InjectedDelegate>("UnityEngine.SystemInfo::GetRenderTextureSupportedMSAASampleCount_Injected");
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x00048074 File Offset: 0x00046274
		public unsafe static string operatingSystem
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76652, RefRangeEnd = 76653, XrefRangeStart = 76650, XrefRangeEnd = 76652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_operatingSystem_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x000480A0 File Offset: 0x000462A0
		public unsafe static OperatingSystemFamily operatingSystemFamily
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 76655, RefRangeEnd = 76657, XrefRangeStart = 76653, XrefRangeEnd = 76655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_operatingSystemFamily_Public_Static_get_OperatingSystemFamily_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x000480D0 File Offset: 0x000462D0
		public unsafe static int processorCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 76659, RefRangeEnd = 76661, XrefRangeStart = 76657, XrefRangeEnd = 76659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_processorCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x00048100 File Offset: 0x00046300
		public unsafe static string deviceUniqueIdentifier
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 76663, RefRangeEnd = 76669, XrefRangeStart = 76661, XrefRangeEnd = 76663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x0004812C File Offset: 0x0004632C
		public unsafe static string deviceName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76671, RefRangeEnd = 76672, XrefRangeStart = 76669, XrefRangeEnd = 76671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_deviceName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x00048158 File Offset: 0x00046358
		public unsafe static string deviceModel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76674, RefRangeEnd = 76675, XrefRangeStart = 76672, XrefRangeEnd = 76674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_deviceModel_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x00048184 File Offset: 0x00046384
		public unsafe static DeviceType deviceType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76677, RefRangeEnd = 76678, XrefRangeStart = 76675, XrefRangeEnd = 76677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_deviceType_Public_Static_get_DeviceType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x000481B4 File Offset: 0x000463B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76678, XrefRangeEnd = 76683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidEnumValue(Enum value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_IsValidEnumValue_Private_Static_Boolean_Enum_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x000481F4 File Offset: 0x000463F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76683, XrefRangeEnd = 76693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsTextureFormat(TextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsTextureFormat_Public_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00048234 File Offset: 0x00046434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76652, RefRangeEnd = 76653, XrefRangeStart = 76652, XrefRangeEnd = 76653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetOperatingSystem()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetOperatingSystem_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00048260 File Offset: 0x00046460
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76655, RefRangeEnd = 76657, XrefRangeStart = 76655, XrefRangeEnd = 76657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OperatingSystemFamily GetOperatingSystemFamily()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetOperatingSystemFamily_Private_Static_OperatingSystemFamily_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00048290 File Offset: 0x00046490
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76659, RefRangeEnd = 76661, XrefRangeStart = 76659, XrefRangeEnd = 76661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetProcessorCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetProcessorCount_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x000482C0 File Offset: 0x000464C0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 76663, RefRangeEnd = 76669, XrefRangeStart = 76663, XrefRangeEnd = 76669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDeviceUniqueIdentifier()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetDeviceUniqueIdentifier_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x000482EC File Offset: 0x000464EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76671, RefRangeEnd = 76672, XrefRangeStart = 76671, XrefRangeEnd = 76672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDeviceName()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetDeviceName_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00048318 File Offset: 0x00046518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76674, RefRangeEnd = 76675, XrefRangeStart = 76674, XrefRangeEnd = 76675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDeviceModel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetDeviceModel_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00048344 File Offset: 0x00046544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76677, RefRangeEnd = 76678, XrefRangeStart = 76677, XrefRangeEnd = 76678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeviceType GetDeviceType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetDeviceType_Private_Static_DeviceType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00048374 File Offset: 0x00046574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76693, XrefRangeEnd = 76695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsTextureFormatNative(TextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsTextureFormatNative_Private_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x000483B4 File Offset: 0x000465B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76695, XrefRangeEnd = 76697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_IsFormatSupported_Public_Static_Boolean_GraphicsFormat_FormatUsage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00048400 File Offset: 0x00046600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76697, XrefRangeEnd = 76699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetCompatibleFormat_Public_Static_GraphicsFormat_GraphicsFormat_FormatUsage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0004844C File Offset: 0x0004664C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76701, RefRangeEnd = 76703, XrefRangeStart = 76699, XrefRangeEnd = 76701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_DefaultFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0000AE42 File Offset: 0x00009042
		public SystemInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x0004848C File Offset: 0x0004668C
		public static float batteryLevel
		{
			get
			{
				return SystemInfo.GetBatteryLevel();
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x000484A4 File Offset: 0x000466A4
		public static BatteryStatus batteryStatus
		{
			get
			{
				return SystemInfo.GetBatteryStatus();
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x000484BC File Offset: 0x000466BC
		public static string processorType
		{
			get
			{
				return SystemInfo.GetProcessorType();
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x000484D4 File Offset: 0x000466D4
		public static int processorFrequency
		{
			get
			{
				return SystemInfo.GetProcessorFrequencyMHz();
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x000484EC File Offset: 0x000466EC
		public static int systemMemorySize
		{
			get
			{
				return SystemInfo.GetPhysicalMemoryMB();
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x00048504 File Offset: 0x00046704
		public static bool supportsAccelerometer
		{
			get
			{
				return SystemInfo.SupportsAccelerometer();
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x0004851C File Offset: 0x0004671C
		public static bool supportsGyroscope
		{
			get
			{
				return SystemInfo.IsGyroAvailable();
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x00048534 File Offset: 0x00046734
		public static bool supportsLocationService
		{
			get
			{
				return SystemInfo.SupportsLocationService();
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x0004854C File Offset: 0x0004674C
		public static bool supportsVibration
		{
			get
			{
				return SystemInfo.SupportsVibration();
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x00048564 File Offset: 0x00046764
		public static bool supportsAudio
		{
			get
			{
				return SystemInfo.SupportsAudio();
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x0004857C File Offset: 0x0004677C
		public static int graphicsMemorySize
		{
			get
			{
				return SystemInfo.GetGraphicsMemorySize();
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x00048594 File Offset: 0x00046794
		public static string graphicsDeviceName
		{
			get
			{
				return SystemInfo.GetGraphicsDeviceName();
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x000485AC File Offset: 0x000467AC
		public static string graphicsDeviceVendor
		{
			get
			{
				return SystemInfo.GetGraphicsDeviceVendor();
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x000485C4 File Offset: 0x000467C4
		public static int graphicsDeviceID
		{
			get
			{
				return SystemInfo.GetGraphicsDeviceID();
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x000485DC File Offset: 0x000467DC
		public static int graphicsDeviceVendorID
		{
			get
			{
				return SystemInfo.GetGraphicsDeviceVendorID();
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x000485F4 File Offset: 0x000467F4
		public static UnityEngine.Rendering.GraphicsDeviceType graphicsDeviceType
		{
			get
			{
				return SystemInfo.GetGraphicsDeviceType();
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x0004860C File Offset: 0x0004680C
		public static bool graphicsUVStartsAtTop
		{
			get
			{
				return SystemInfo.GetGraphicsUVStartsAtTop();
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x00048624 File Offset: 0x00046824
		public static string graphicsDeviceVersion
		{
			get
			{
				return SystemInfo.GetGraphicsDeviceVersion();
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x0004863C File Offset: 0x0004683C
		public static int graphicsShaderLevel
		{
			get
			{
				return SystemInfo.GetGraphicsShaderLevel();
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00048654 File Offset: 0x00046854
		public static bool graphicsMultiThreaded
		{
			get
			{
				return SystemInfo.GetGraphicsMultiThreaded();
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x0004866C File Offset: 0x0004686C
		public static UnityEngine.Rendering.RenderingThreadingMode renderingThreadingMode
		{
			get
			{
				return SystemInfo.GetRenderingThreadingMode();
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x00048684 File Offset: 0x00046884
		public static bool hasHiddenSurfaceRemovalOnGPU
		{
			get
			{
				return SystemInfo.HasHiddenSurfaceRemovalOnGPU();
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x0004869C File Offset: 0x0004689C
		public static bool hasDynamicUniformArrayIndexingInFragmentShaders
		{
			get
			{
				return SystemInfo.HasDynamicUniformArrayIndexingInFragmentShaders();
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x000486B4 File Offset: 0x000468B4
		public static bool supportsShadows
		{
			get
			{
				return SystemInfo.SupportsShadows();
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x000486CC File Offset: 0x000468CC
		public static bool supportsRawShadowDepthSampling
		{
			get
			{
				return SystemInfo.SupportsRawShadowDepthSampling();
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x000486E4 File Offset: 0x000468E4
		public static bool supportsRenderTextures
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x000486F8 File Offset: 0x000468F8
		public static bool supportsMotionVectors
		{
			get
			{
				return SystemInfo.SupportsMotionVectors();
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x00048710 File Offset: 0x00046910
		public static bool supportsRenderToCubemap
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x00048724 File Offset: 0x00046924
		public static bool supportsImageEffects
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x00048738 File Offset: 0x00046938
		public static bool supports3DTextures
		{
			get
			{
				return SystemInfo.Supports3DTextures();
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x00048750 File Offset: 0x00046950
		public static bool supportsCompressed3DTextures
		{
			get
			{
				return SystemInfo.SupportsCompressed3DTextures();
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x00048768 File Offset: 0x00046968
		public static bool supports2DArrayTextures
		{
			get
			{
				return SystemInfo.Supports2DArrayTextures();
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x00048780 File Offset: 0x00046980
		public static bool supports3DRenderTextures
		{
			get
			{
				return SystemInfo.Supports3DRenderTextures();
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x00048798 File Offset: 0x00046998
		public static bool supportsCubemapArrayTextures
		{
			get
			{
				return SystemInfo.SupportsCubemapArrayTextures();
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x000487B0 File Offset: 0x000469B0
		public static UnityEngine.Rendering.CopyTextureSupport copyTextureSupport
		{
			get
			{
				return SystemInfo.GetCopyTextureSupport();
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x000487C8 File Offset: 0x000469C8
		public static bool supportsComputeShaders
		{
			get
			{
				return SystemInfo.SupportsComputeShaders();
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x000487E0 File Offset: 0x000469E0
		public static bool supportsGeometryShaders
		{
			get
			{
				return SystemInfo.SupportsGeometryShaders();
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x000487F8 File Offset: 0x000469F8
		public static bool supportsTessellationShaders
		{
			get
			{
				return SystemInfo.SupportsTessellationShaders();
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00048810 File Offset: 0x00046A10
		public static bool supportsRenderTargetArrayIndexFromVertexShader
		{
			get
			{
				return SystemInfo.SupportsRenderTargetArrayIndexFromVertexShader();
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x00048828 File Offset: 0x00046A28
		public static bool supportsInstancing
		{
			get
			{
				return SystemInfo.SupportsInstancing();
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x00048840 File Offset: 0x00046A40
		public static bool supportsHardwareQuadTopology
		{
			get
			{
				return SystemInfo.SupportsHardwareQuadTopology();
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x00048858 File Offset: 0x00046A58
		public static bool supports32bitsIndexBuffer
		{
			get
			{
				return SystemInfo.Supports32bitsIndexBuffer();
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x00048870 File Offset: 0x00046A70
		public static bool supportsSparseTextures
		{
			get
			{
				return SystemInfo.SupportsSparseTextures();
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x00048888 File Offset: 0x00046A88
		public static int supportedRenderTargetCount
		{
			get
			{
				return SystemInfo.SupportedRenderTargetCount();
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x000488A0 File Offset: 0x00046AA0
		public static bool supportsSeparatedRenderTargetsBlend
		{
			get
			{
				return SystemInfo.SupportsSeparatedRenderTargetsBlend();
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x000488B8 File Offset: 0x00046AB8
		public static int supportedRandomWriteTargetCount
		{
			get
			{
				return SystemInfo.SupportedRandomWriteTargetCount();
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x000488D0 File Offset: 0x00046AD0
		public static int supportsMultisampledTextures
		{
			get
			{
				return SystemInfo.SupportsMultisampledTextures();
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x000488E8 File Offset: 0x00046AE8
		public static bool supportsMultisampled2DArrayTextures
		{
			get
			{
				return SystemInfo.SupportsMultisampled2DArrayTextures();
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00048900 File Offset: 0x00046B00
		public static bool supportsMultisampleAutoResolve
		{
			get
			{
				return SystemInfo.SupportsMultisampleAutoResolve();
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00048918 File Offset: 0x00046B18
		public static int supportsTextureWrapMirrorOnce
		{
			get
			{
				return SystemInfo.SupportsTextureWrapMirrorOnce();
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x00048930 File Offset: 0x00046B30
		public static bool usesReversedZBuffer
		{
			get
			{
				return SystemInfo.UsesReversedZBuffer();
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x00048948 File Offset: 0x00046B48
		public static int supportsStencil
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0004895C File Offset: 0x00046B5C
		public static bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			bool flag = !SystemInfo.IsValidEnumValue(format);
			if (flag)
			{
				throw new ArgumentException("Failed SupportsRenderTextureFormat; format is not a valid RenderTextureFormat");
			}
			return SystemInfo.HasRenderTextureNative(format);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00048994 File Offset: 0x00046B94
		public static bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format)
		{
			bool flag = !SystemInfo.IsValidEnumValue(format);
			if (flag)
			{
				throw new ArgumentException("Failed SupportsBlendingOnRenderTextureFormat; format is not a valid RenderTextureFormat");
			}
			return SystemInfo.SupportsBlendingOnRenderTextureFormatNative(format);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x000489CC File Offset: 0x00046BCC
		public static bool SupportsRandomWriteOnRenderTextureFormat(RenderTextureFormat format)
		{
			bool flag = !SystemInfo.IsValidEnumValue(format);
			if (flag)
			{
				throw new ArgumentException("Failed SupportsRandomWriteOnRenderTextureFormat; format is not a valid RenderTextureFormat");
			}
			return SystemInfo.SupportsRandomWriteOnRenderTextureFormatNative(format);
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00048A04 File Offset: 0x00046C04
		public static bool SupportsVertexAttributeFormat(UnityEngine.Rendering.VertexAttributeFormat format, int dimension)
		{
			bool flag = !SystemInfo.IsValidEnumValue(format);
			if (flag)
			{
				throw new ArgumentException("Failed SupportsVertexAttributeFormat; format is not a valid VertexAttributeFormat");
			}
			bool flag2 = dimension < 1 || dimension > 4;
			if (flag2)
			{
				throw new ArgumentException("Failed SupportsVertexAttributeFormat; dimension must be in 1..4 range");
			}
			return SystemInfo.SupportsVertexAttributeFormatNative(format, dimension);
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x00048A54 File Offset: 0x00046C54
		public static NPOTSupport npotSupport
		{
			get
			{
				return SystemInfo.GetNPOTSupport();
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x00048A6C File Offset: 0x00046C6C
		public static int maxTextureSize
		{
			get
			{
				return SystemInfo.GetMaxTextureSize();
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x00048A84 File Offset: 0x00046C84
		public static int maxCubemapSize
		{
			get
			{
				return SystemInfo.GetMaxCubemapSize();
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x00048A9C File Offset: 0x00046C9C
		public static int maxRenderTextureSize
		{
			get
			{
				return SystemInfo.GetMaxRenderTextureSize();
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x00048AB4 File Offset: 0x00046CB4
		public static int maxComputeBufferInputsVertex
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsVertex();
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x00048ACC File Offset: 0x00046CCC
		public static int maxComputeBufferInputsFragment
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsFragment();
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x00048AE4 File Offset: 0x00046CE4
		public static int maxComputeBufferInputsGeometry
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsGeometry();
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x00048AFC File Offset: 0x00046CFC
		public static int maxComputeBufferInputsDomain
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsDomain();
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x00048B14 File Offset: 0x00046D14
		public static int maxComputeBufferInputsHull
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsHull();
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x00048B2C File Offset: 0x00046D2C
		public static int maxComputeBufferInputsCompute
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsCompute();
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x00048B44 File Offset: 0x00046D44
		public static int maxComputeWorkGroupSize
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSize();
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x00048B5C File Offset: 0x00046D5C
		public static int maxComputeWorkGroupSizeX
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSizeX();
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x00048B74 File Offset: 0x00046D74
		public static int maxComputeWorkGroupSizeY
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSizeY();
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x00048B8C File Offset: 0x00046D8C
		public static int maxComputeWorkGroupSizeZ
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSizeZ();
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x00048BA4 File Offset: 0x00046DA4
		public static bool supportsAsyncCompute
		{
			get
			{
				return SystemInfo.SupportsAsyncCompute();
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x00048BBC File Offset: 0x00046DBC
		public static bool supportsGpuRecorder
		{
			get
			{
				return SystemInfo.SupportsGpuRecorder();
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x00048BD4 File Offset: 0x00046DD4
		public static bool supportsGraphicsFence
		{
			get
			{
				return SystemInfo.SupportsGPUFence();
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x00048BEC File Offset: 0x00046DEC
		public static bool supportsAsyncGPUReadback
		{
			get
			{
				return SystemInfo.SupportsAsyncGPUReadback();
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x00048C04 File Offset: 0x00046E04
		public static bool supportsRayTracing
		{
			get
			{
				return SystemInfo.SupportsRayTracing();
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x00048C1C File Offset: 0x00046E1C
		public static bool supportsSetConstantBuffer
		{
			get
			{
				return SystemInfo.SupportsSetConstantBuffer();
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00048C34 File Offset: 0x00046E34
		public static int constantBufferOffsetAlignment
		{
			get
			{
				return SystemInfo.MinConstantBufferOffsetAlignment();
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x00048C4C File Offset: 0x00046E4C
		public static bool minConstantBufferOffsetAlignment
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00048C60 File Offset: 0x00046E60
		public static bool hasMipMaxLevel
		{
			get
			{
				return SystemInfo.HasMipMaxLevel();
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x00048C78 File Offset: 0x00046E78
		public static bool supportsMipStreaming
		{
			get
			{
				return SystemInfo.SupportsMipStreaming();
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00048C90 File Offset: 0x00046E90
		public static int graphicsPixelFillrate
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x00048CA4 File Offset: 0x00046EA4
		public static bool usesLoadStoreActions
		{
			get
			{
				return SystemInfo.UsesLoadStoreActions();
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x00048CBC File Offset: 0x00046EBC
		public static HDRDisplaySupportFlags hdrDisplaySupportFlags
		{
			get
			{
				return SystemInfo.GetHDRDisplaySupportFlags();
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x00048CD4 File Offset: 0x00046ED4
		public static bool supportsConservativeRaster
		{
			get
			{
				return SystemInfo.SupportsConservativeRaster();
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x00048CEC File Offset: 0x00046EEC
		public static bool supportsMultiview
		{
			get
			{
				return SystemInfo.SupportsMultiview();
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x00048D04 File Offset: 0x00046F04
		public static bool supportsStoreAndResolveAction
		{
			get
			{
				return SystemInfo.SupportsStoreAndResolveAction();
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x00048D1C File Offset: 0x00046F1C
		public static bool supportsVertexPrograms
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x0000AE4B File Offset: 0x0000904B
		public static float GetBatteryLevel()
		{
			return SystemInfo.GetBatteryLevelDelegateField();
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x0000AE57 File Offset: 0x00009057
		public static BatteryStatus GetBatteryStatus()
		{
			return SystemInfo.GetBatteryStatusDelegateField();
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00048D30 File Offset: 0x00046F30
		public static string GetProcessorType()
		{
			IntPtr intPtr = SystemInfo.GetProcessorTypeDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0000AE63 File Offset: 0x00009063
		public static int GetProcessorFrequencyMHz()
		{
			return SystemInfo.GetProcessorFrequencyMHzDelegateField();
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x0000AE6F File Offset: 0x0000906F
		public static int GetPhysicalMemoryMB()
		{
			return SystemInfo.GetPhysicalMemoryMBDelegateField();
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x0000AE7B File Offset: 0x0000907B
		public static bool SupportsAccelerometer()
		{
			return SystemInfo.SupportsAccelerometerDelegateField();
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0000AE87 File Offset: 0x00009087
		public static bool IsGyroAvailable()
		{
			return SystemInfo.IsGyroAvailableDelegateField();
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0000AE93 File Offset: 0x00009093
		public static bool SupportsLocationService()
		{
			return SystemInfo.SupportsLocationServiceDelegateField();
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x0000AE9F File Offset: 0x0000909F
		public static bool SupportsVibration()
		{
			return SystemInfo.SupportsVibrationDelegateField();
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0000AEAB File Offset: 0x000090AB
		public static bool SupportsAudio()
		{
			return SystemInfo.SupportsAudioDelegateField();
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0000AEB7 File Offset: 0x000090B7
		public static int GetGraphicsMemorySize()
		{
			return SystemInfo.GetGraphicsMemorySizeDelegateField();
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00048D50 File Offset: 0x00046F50
		public static string GetGraphicsDeviceName()
		{
			IntPtr intPtr = SystemInfo.GetGraphicsDeviceNameDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00048D70 File Offset: 0x00046F70
		public static string GetGraphicsDeviceVendor()
		{
			IntPtr intPtr = SystemInfo.GetGraphicsDeviceVendorDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x0000AEC3 File Offset: 0x000090C3
		public static int GetGraphicsDeviceID()
		{
			return SystemInfo.GetGraphicsDeviceIDDelegateField();
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x0000AECF File Offset: 0x000090CF
		public static int GetGraphicsDeviceVendorID()
		{
			return SystemInfo.GetGraphicsDeviceVendorIDDelegateField();
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x0000AEDB File Offset: 0x000090DB
		public static UnityEngine.Rendering.GraphicsDeviceType GetGraphicsDeviceType()
		{
			return SystemInfo.GetGraphicsDeviceTypeDelegateField();
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x0000AEE7 File Offset: 0x000090E7
		public static bool GetGraphicsUVStartsAtTop()
		{
			return SystemInfo.GetGraphicsUVStartsAtTopDelegateField();
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00048D90 File Offset: 0x00046F90
		public static string GetGraphicsDeviceVersion()
		{
			IntPtr intPtr = SystemInfo.GetGraphicsDeviceVersionDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x0000AEF3 File Offset: 0x000090F3
		public static int GetGraphicsShaderLevel()
		{
			return SystemInfo.GetGraphicsShaderLevelDelegateField();
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x0000AEFF File Offset: 0x000090FF
		public static bool GetGraphicsMultiThreaded()
		{
			return SystemInfo.GetGraphicsMultiThreadedDelegateField();
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x0000AF0B File Offset: 0x0000910B
		public static UnityEngine.Rendering.RenderingThreadingMode GetRenderingThreadingMode()
		{
			return SystemInfo.GetRenderingThreadingModeDelegateField();
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x0000AF17 File Offset: 0x00009117
		public static bool HasHiddenSurfaceRemovalOnGPU()
		{
			return SystemInfo.HasHiddenSurfaceRemovalOnGPUDelegateField();
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0000AF23 File Offset: 0x00009123
		public static bool HasDynamicUniformArrayIndexingInFragmentShaders()
		{
			return SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegateField();
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0000AF2F File Offset: 0x0000912F
		public static bool SupportsShadows()
		{
			return SystemInfo.SupportsShadowsDelegateField();
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x0000AF3B File Offset: 0x0000913B
		public static bool SupportsRawShadowDepthSampling()
		{
			return SystemInfo.SupportsRawShadowDepthSamplingDelegateField();
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x0000AF47 File Offset: 0x00009147
		public static bool SupportsMotionVectors()
		{
			return SystemInfo.SupportsMotionVectorsDelegateField();
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0000AF53 File Offset: 0x00009153
		public static bool Supports3DTextures()
		{
			return SystemInfo.Supports3DTexturesDelegateField();
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0000AF5F File Offset: 0x0000915F
		public static bool SupportsCompressed3DTextures()
		{
			return SystemInfo.SupportsCompressed3DTexturesDelegateField();
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0000AF6B File Offset: 0x0000916B
		public static bool Supports2DArrayTextures()
		{
			return SystemInfo.Supports2DArrayTexturesDelegateField();
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0000AF77 File Offset: 0x00009177
		public static bool Supports3DRenderTextures()
		{
			return SystemInfo.Supports3DRenderTexturesDelegateField();
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0000AF83 File Offset: 0x00009183
		public static bool SupportsCubemapArrayTextures()
		{
			return SystemInfo.SupportsCubemapArrayTexturesDelegateField();
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0000AF8F File Offset: 0x0000918F
		public static UnityEngine.Rendering.CopyTextureSupport GetCopyTextureSupport()
		{
			return SystemInfo.GetCopyTextureSupportDelegateField();
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0000AF9B File Offset: 0x0000919B
		public static bool SupportsComputeShaders()
		{
			return SystemInfo.SupportsComputeShadersDelegateField();
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0000AFA7 File Offset: 0x000091A7
		public static bool SupportsGeometryShaders()
		{
			return SystemInfo.SupportsGeometryShadersDelegateField();
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0000AFB3 File Offset: 0x000091B3
		public static bool SupportsTessellationShaders()
		{
			return SystemInfo.SupportsTessellationShadersDelegateField();
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x0000AFBF File Offset: 0x000091BF
		public static bool SupportsRenderTargetArrayIndexFromVertexShader()
		{
			return SystemInfo.SupportsRenderTargetArrayIndexFromVertexShaderDelegateField();
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0000AFCB File Offset: 0x000091CB
		public static bool SupportsInstancing()
		{
			return SystemInfo.SupportsInstancingDelegateField();
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0000AFD7 File Offset: 0x000091D7
		public static bool SupportsHardwareQuadTopology()
		{
			return SystemInfo.SupportsHardwareQuadTopologyDelegateField();
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0000AFE3 File Offset: 0x000091E3
		public static bool Supports32bitsIndexBuffer()
		{
			return SystemInfo.Supports32bitsIndexBufferDelegateField();
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0000AFEF File Offset: 0x000091EF
		public static bool SupportsSparseTextures()
		{
			return SystemInfo.SupportsSparseTexturesDelegateField();
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0000AFFB File Offset: 0x000091FB
		public static int SupportedRenderTargetCount()
		{
			return SystemInfo.SupportedRenderTargetCountDelegateField();
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0000B007 File Offset: 0x00009207
		public static bool SupportsSeparatedRenderTargetsBlend()
		{
			return SystemInfo.SupportsSeparatedRenderTargetsBlendDelegateField();
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0000B013 File Offset: 0x00009213
		public static int SupportedRandomWriteTargetCount()
		{
			return SystemInfo.SupportedRandomWriteTargetCountDelegateField();
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0000B01F File Offset: 0x0000921F
		public static int MaxComputeBufferInputsVertex()
		{
			return SystemInfo.MaxComputeBufferInputsVertexDelegateField();
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0000B02B File Offset: 0x0000922B
		public static int MaxComputeBufferInputsFragment()
		{
			return SystemInfo.MaxComputeBufferInputsFragmentDelegateField();
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0000B037 File Offset: 0x00009237
		public static int MaxComputeBufferInputsGeometry()
		{
			return SystemInfo.MaxComputeBufferInputsGeometryDelegateField();
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0000B043 File Offset: 0x00009243
		public static int MaxComputeBufferInputsDomain()
		{
			return SystemInfo.MaxComputeBufferInputsDomainDelegateField();
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x0000B04F File Offset: 0x0000924F
		public static int MaxComputeBufferInputsHull()
		{
			return SystemInfo.MaxComputeBufferInputsHullDelegateField();
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0000B05B File Offset: 0x0000925B
		public static int MaxComputeBufferInputsCompute()
		{
			return SystemInfo.MaxComputeBufferInputsComputeDelegateField();
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0000B067 File Offset: 0x00009267
		public static int SupportsMultisampledTextures()
		{
			return SystemInfo.SupportsMultisampledTexturesDelegateField();
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x0000B073 File Offset: 0x00009273
		public static bool SupportsMultisampled2DArrayTextures()
		{
			return SystemInfo.SupportsMultisampled2DArrayTexturesDelegateField();
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x0000B07F File Offset: 0x0000927F
		public static bool SupportsMultisampleAutoResolve()
		{
			return SystemInfo.SupportsMultisampleAutoResolveDelegateField();
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0000B08B File Offset: 0x0000928B
		public static int SupportsTextureWrapMirrorOnce()
		{
			return SystemInfo.SupportsTextureWrapMirrorOnceDelegateField();
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x0000B097 File Offset: 0x00009297
		public static bool UsesReversedZBuffer()
		{
			return SystemInfo.UsesReversedZBufferDelegateField();
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0000B0A3 File Offset: 0x000092A3
		public static bool HasRenderTextureNative(RenderTextureFormat format)
		{
			return SystemInfo.HasRenderTextureNativeDelegateField(format);
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0000B0B0 File Offset: 0x000092B0
		public static bool SupportsBlendingOnRenderTextureFormatNative(RenderTextureFormat format)
		{
			return SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegateField(format);
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0000B0BD File Offset: 0x000092BD
		public static bool SupportsRandomWriteOnRenderTextureFormatNative(RenderTextureFormat format)
		{
			return SystemInfo.SupportsRandomWriteOnRenderTextureFormatNativeDelegateField(format);
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0000B0CA File Offset: 0x000092CA
		public static bool SupportsVertexAttributeFormatNative(UnityEngine.Rendering.VertexAttributeFormat format, int dimension)
		{
			return SystemInfo.SupportsVertexAttributeFormatNativeDelegateField(format, dimension);
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0000B0D8 File Offset: 0x000092D8
		public static NPOTSupport GetNPOTSupport()
		{
			return SystemInfo.GetNPOTSupportDelegateField();
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0000B0E4 File Offset: 0x000092E4
		public static int GetMaxTextureSize()
		{
			return SystemInfo.GetMaxTextureSizeDelegateField();
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x0000B0F0 File Offset: 0x000092F0
		public static int GetMaxCubemapSize()
		{
			return SystemInfo.GetMaxCubemapSizeDelegateField();
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0000B0FC File Offset: 0x000092FC
		public static int GetMaxRenderTextureSize()
		{
			return SystemInfo.GetMaxRenderTextureSizeDelegateField();
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x0000B108 File Offset: 0x00009308
		public static int GetMaxComputeWorkGroupSize()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeDelegateField();
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0000B114 File Offset: 0x00009314
		public static int GetMaxComputeWorkGroupSizeX()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeXDelegateField();
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0000B120 File Offset: 0x00009320
		public static int GetMaxComputeWorkGroupSizeY()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeYDelegateField();
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0000B12C File Offset: 0x0000932C
		public static int GetMaxComputeWorkGroupSizeZ()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeZDelegateField();
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0000B138 File Offset: 0x00009338
		public static bool SupportsAsyncCompute()
		{
			return SystemInfo.SupportsAsyncComputeDelegateField();
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0000B144 File Offset: 0x00009344
		public static bool SupportsGpuRecorder()
		{
			return SystemInfo.SupportsGpuRecorderDelegateField();
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0000B150 File Offset: 0x00009350
		public static bool SupportsGPUFence()
		{
			return SystemInfo.SupportsGPUFenceDelegateField();
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0000B15C File Offset: 0x0000935C
		public static bool SupportsAsyncGPUReadback()
		{
			return SystemInfo.SupportsAsyncGPUReadbackDelegateField();
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0000B168 File Offset: 0x00009368
		public static bool SupportsRayTracing()
		{
			return SystemInfo.SupportsRayTracingDelegateField();
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0000B174 File Offset: 0x00009374
		public static bool SupportsSetConstantBuffer()
		{
			return SystemInfo.SupportsSetConstantBufferDelegateField();
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0000B180 File Offset: 0x00009380
		public static int MinConstantBufferOffsetAlignment()
		{
			return SystemInfo.MinConstantBufferOffsetAlignmentDelegateField();
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0000B18C File Offset: 0x0000938C
		public static bool HasMipMaxLevel()
		{
			return SystemInfo.HasMipMaxLevelDelegateField();
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0000B198 File Offset: 0x00009398
		public static bool SupportsMipStreaming()
		{
			return SystemInfo.SupportsMipStreamingDelegateField();
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x0000B1A4 File Offset: 0x000093A4
		public static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc)
		{
			return SystemInfo.GetRenderTextureSupportedMSAASampleCount_Injected(ref desc);
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0000B1AD File Offset: 0x000093AD
		public static bool UsesLoadStoreActions()
		{
			return SystemInfo.UsesLoadStoreActionsDelegateField();
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x0000B1B9 File Offset: 0x000093B9
		public static HDRDisplaySupportFlags GetHDRDisplaySupportFlags()
		{
			return SystemInfo.GetHDRDisplaySupportFlagsDelegateField();
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x0000B1C5 File Offset: 0x000093C5
		public static bool SupportsConservativeRaster()
		{
			return SystemInfo.SupportsConservativeRasterDelegateField();
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x0000B1D1 File Offset: 0x000093D1
		public static bool SupportsMultiview()
		{
			return SystemInfo.SupportsMultiviewDelegateField();
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x0000B1DD File Offset: 0x000093DD
		public static bool SupportsStoreAndResolveAction()
		{
			return SystemInfo.SupportsStoreAndResolveActionDelegateField();
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x00048DB0 File Offset: 0x00046FB0
		public static bool supportsGPUFence
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0000B1E9 File Offset: 0x000093E9
		public static int GetRenderTextureSupportedMSAASampleCount_Injected(ref RenderTextureDescriptor desc)
		{
			return SystemInfo.GetRenderTextureSupportedMSAASampleCount_InjectedDelegateField(ref desc);
		}

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeMethodInfoPtr_get_operatingSystem_Public_Static_get_String_0;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeMethodInfoPtr_get_operatingSystemFamily_Public_Static_get_OperatingSystemFamily_0;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeMethodInfoPtr_get_processorCount_Public_Static_get_Int32_0;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Static_get_String_0;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceName_Public_Static_get_String_0;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceModel_Public_Static_get_String_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceType_Public_Static_get_DeviceType_0;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr_IsValidEnumValue_Private_Static_Boolean_Enum_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_SupportsTextureFormat_Public_Static_Boolean_TextureFormat_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_GetOperatingSystem_Private_Static_String_0;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr_GetOperatingSystemFamily_Private_Static_OperatingSystemFamily_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr_GetProcessorCount_Private_Static_Int32_0;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceUniqueIdentifier_Private_Static_String_0;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceName_Private_Static_String_0;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceModel_Private_Static_String_0;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceType_Private_Static_DeviceType_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_SupportsTextureFormatNative_Private_Static_Boolean_TextureFormat_0;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr_IsFormatSupported_Public_Static_Boolean_GraphicsFormat_FormatUsage_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_GetCompatibleFormat_Public_Static_GraphicsFormat_GraphicsFormat_FormatUsage_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_DefaultFormat_0;

		// Token: 0x04000D78 RID: 3448
		public const string unsupportedIdentifier = "n/a";

		// Token: 0x04000D79 RID: 3449
		private static readonly SystemInfo.GetBatteryLevelDelegate GetBatteryLevelDelegateField;

		// Token: 0x04000D7A RID: 3450
		private static readonly SystemInfo.GetBatteryStatusDelegate GetBatteryStatusDelegateField;

		// Token: 0x04000D7B RID: 3451
		private static readonly SystemInfo.GetProcessorTypeDelegate GetProcessorTypeDelegateField;

		// Token: 0x04000D7C RID: 3452
		private static readonly SystemInfo.GetProcessorFrequencyMHzDelegate GetProcessorFrequencyMHzDelegateField;

		// Token: 0x04000D7D RID: 3453
		private static readonly SystemInfo.GetPhysicalMemoryMBDelegate GetPhysicalMemoryMBDelegateField;

		// Token: 0x04000D7E RID: 3454
		private static readonly SystemInfo.SupportsAccelerometerDelegate SupportsAccelerometerDelegateField;

		// Token: 0x04000D7F RID: 3455
		private static readonly SystemInfo.IsGyroAvailableDelegate IsGyroAvailableDelegateField;

		// Token: 0x04000D80 RID: 3456
		private static readonly SystemInfo.SupportsLocationServiceDelegate SupportsLocationServiceDelegateField;

		// Token: 0x04000D81 RID: 3457
		private static readonly SystemInfo.SupportsVibrationDelegate SupportsVibrationDelegateField;

		// Token: 0x04000D82 RID: 3458
		private static readonly SystemInfo.SupportsAudioDelegate SupportsAudioDelegateField;

		// Token: 0x04000D83 RID: 3459
		private static readonly SystemInfo.GetGraphicsMemorySizeDelegate GetGraphicsMemorySizeDelegateField;

		// Token: 0x04000D84 RID: 3460
		private static readonly SystemInfo.GetGraphicsDeviceNameDelegate GetGraphicsDeviceNameDelegateField;

		// Token: 0x04000D85 RID: 3461
		private static readonly SystemInfo.GetGraphicsDeviceVendorDelegate GetGraphicsDeviceVendorDelegateField;

		// Token: 0x04000D86 RID: 3462
		private static readonly SystemInfo.GetGraphicsDeviceIDDelegate GetGraphicsDeviceIDDelegateField;

		// Token: 0x04000D87 RID: 3463
		private static readonly SystemInfo.GetGraphicsDeviceVendorIDDelegate GetGraphicsDeviceVendorIDDelegateField;

		// Token: 0x04000D88 RID: 3464
		private static readonly SystemInfo.GetGraphicsDeviceTypeDelegate GetGraphicsDeviceTypeDelegateField;

		// Token: 0x04000D89 RID: 3465
		private static readonly SystemInfo.GetGraphicsUVStartsAtTopDelegate GetGraphicsUVStartsAtTopDelegateField;

		// Token: 0x04000D8A RID: 3466
		private static readonly SystemInfo.GetGraphicsDeviceVersionDelegate GetGraphicsDeviceVersionDelegateField;

		// Token: 0x04000D8B RID: 3467
		private static readonly SystemInfo.GetGraphicsShaderLevelDelegate GetGraphicsShaderLevelDelegateField;

		// Token: 0x04000D8C RID: 3468
		private static readonly SystemInfo.GetGraphicsMultiThreadedDelegate GetGraphicsMultiThreadedDelegateField;

		// Token: 0x04000D8D RID: 3469
		private static readonly SystemInfo.GetRenderingThreadingModeDelegate GetRenderingThreadingModeDelegateField;

		// Token: 0x04000D8E RID: 3470
		private static readonly SystemInfo.HasHiddenSurfaceRemovalOnGPUDelegate HasHiddenSurfaceRemovalOnGPUDelegateField;

		// Token: 0x04000D8F RID: 3471
		private static readonly SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegate HasDynamicUniformArrayIndexingInFragmentShadersDelegateField;

		// Token: 0x04000D90 RID: 3472
		private static readonly SystemInfo.SupportsShadowsDelegate SupportsShadowsDelegateField;

		// Token: 0x04000D91 RID: 3473
		private static readonly SystemInfo.SupportsRawShadowDepthSamplingDelegate SupportsRawShadowDepthSamplingDelegateField;

		// Token: 0x04000D92 RID: 3474
		private static readonly SystemInfo.SupportsMotionVectorsDelegate SupportsMotionVectorsDelegateField;

		// Token: 0x04000D93 RID: 3475
		private static readonly SystemInfo.Supports3DTexturesDelegate Supports3DTexturesDelegateField;

		// Token: 0x04000D94 RID: 3476
		private static readonly SystemInfo.SupportsCompressed3DTexturesDelegate SupportsCompressed3DTexturesDelegateField;

		// Token: 0x04000D95 RID: 3477
		private static readonly SystemInfo.Supports2DArrayTexturesDelegate Supports2DArrayTexturesDelegateField;

		// Token: 0x04000D96 RID: 3478
		private static readonly SystemInfo.Supports3DRenderTexturesDelegate Supports3DRenderTexturesDelegateField;

		// Token: 0x04000D97 RID: 3479
		private static readonly SystemInfo.SupportsCubemapArrayTexturesDelegate SupportsCubemapArrayTexturesDelegateField;

		// Token: 0x04000D98 RID: 3480
		private static readonly SystemInfo.GetCopyTextureSupportDelegate GetCopyTextureSupportDelegateField;

		// Token: 0x04000D99 RID: 3481
		private static readonly SystemInfo.SupportsComputeShadersDelegate SupportsComputeShadersDelegateField;

		// Token: 0x04000D9A RID: 3482
		private static readonly SystemInfo.SupportsGeometryShadersDelegate SupportsGeometryShadersDelegateField;

		// Token: 0x04000D9B RID: 3483
		private static readonly SystemInfo.SupportsTessellationShadersDelegate SupportsTessellationShadersDelegateField;

		// Token: 0x04000D9C RID: 3484
		private static readonly SystemInfo.SupportsRenderTargetArrayIndexFromVertexShaderDelegate SupportsRenderTargetArrayIndexFromVertexShaderDelegateField;

		// Token: 0x04000D9D RID: 3485
		private static readonly SystemInfo.SupportsInstancingDelegate SupportsInstancingDelegateField;

		// Token: 0x04000D9E RID: 3486
		private static readonly SystemInfo.SupportsHardwareQuadTopologyDelegate SupportsHardwareQuadTopologyDelegateField;

		// Token: 0x04000D9F RID: 3487
		private static readonly SystemInfo.Supports32bitsIndexBufferDelegate Supports32bitsIndexBufferDelegateField;

		// Token: 0x04000DA0 RID: 3488
		private static readonly SystemInfo.SupportsSparseTexturesDelegate SupportsSparseTexturesDelegateField;

		// Token: 0x04000DA1 RID: 3489
		private static readonly SystemInfo.SupportedRenderTargetCountDelegate SupportedRenderTargetCountDelegateField;

		// Token: 0x04000DA2 RID: 3490
		private static readonly SystemInfo.SupportsSeparatedRenderTargetsBlendDelegate SupportsSeparatedRenderTargetsBlendDelegateField;

		// Token: 0x04000DA3 RID: 3491
		private static readonly SystemInfo.SupportedRandomWriteTargetCountDelegate SupportedRandomWriteTargetCountDelegateField;

		// Token: 0x04000DA4 RID: 3492
		private static readonly SystemInfo.MaxComputeBufferInputsVertexDelegate MaxComputeBufferInputsVertexDelegateField;

		// Token: 0x04000DA5 RID: 3493
		private static readonly SystemInfo.MaxComputeBufferInputsFragmentDelegate MaxComputeBufferInputsFragmentDelegateField;

		// Token: 0x04000DA6 RID: 3494
		private static readonly SystemInfo.MaxComputeBufferInputsGeometryDelegate MaxComputeBufferInputsGeometryDelegateField;

		// Token: 0x04000DA7 RID: 3495
		private static readonly SystemInfo.MaxComputeBufferInputsDomainDelegate MaxComputeBufferInputsDomainDelegateField;

		// Token: 0x04000DA8 RID: 3496
		private static readonly SystemInfo.MaxComputeBufferInputsHullDelegate MaxComputeBufferInputsHullDelegateField;

		// Token: 0x04000DA9 RID: 3497
		private static readonly SystemInfo.MaxComputeBufferInputsComputeDelegate MaxComputeBufferInputsComputeDelegateField;

		// Token: 0x04000DAA RID: 3498
		private static readonly SystemInfo.SupportsMultisampledTexturesDelegate SupportsMultisampledTexturesDelegateField;

		// Token: 0x04000DAB RID: 3499
		private static readonly SystemInfo.SupportsMultisampled2DArrayTexturesDelegate SupportsMultisampled2DArrayTexturesDelegateField;

		// Token: 0x04000DAC RID: 3500
		private static readonly SystemInfo.SupportsMultisampleAutoResolveDelegate SupportsMultisampleAutoResolveDelegateField;

		// Token: 0x04000DAD RID: 3501
		private static readonly SystemInfo.SupportsTextureWrapMirrorOnceDelegate SupportsTextureWrapMirrorOnceDelegateField;

		// Token: 0x04000DAE RID: 3502
		private static readonly SystemInfo.UsesReversedZBufferDelegate UsesReversedZBufferDelegateField;

		// Token: 0x04000DAF RID: 3503
		private static readonly SystemInfo.HasRenderTextureNativeDelegate HasRenderTextureNativeDelegateField;

		// Token: 0x04000DB0 RID: 3504
		private static readonly SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegate SupportsBlendingOnRenderTextureFormatNativeDelegateField;

		// Token: 0x04000DB1 RID: 3505
		private static readonly SystemInfo.SupportsRandomWriteOnRenderTextureFormatNativeDelegate SupportsRandomWriteOnRenderTextureFormatNativeDelegateField;

		// Token: 0x04000DB2 RID: 3506
		private static readonly SystemInfo.SupportsVertexAttributeFormatNativeDelegate SupportsVertexAttributeFormatNativeDelegateField;

		// Token: 0x04000DB3 RID: 3507
		private static readonly SystemInfo.GetNPOTSupportDelegate GetNPOTSupportDelegateField;

		// Token: 0x04000DB4 RID: 3508
		private static readonly SystemInfo.GetMaxTextureSizeDelegate GetMaxTextureSizeDelegateField;

		// Token: 0x04000DB5 RID: 3509
		private static readonly SystemInfo.GetMaxCubemapSizeDelegate GetMaxCubemapSizeDelegateField;

		// Token: 0x04000DB6 RID: 3510
		private static readonly SystemInfo.GetMaxRenderTextureSizeDelegate GetMaxRenderTextureSizeDelegateField;

		// Token: 0x04000DB7 RID: 3511
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeDelegate GetMaxComputeWorkGroupSizeDelegateField;

		// Token: 0x04000DB8 RID: 3512
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeXDelegate GetMaxComputeWorkGroupSizeXDelegateField;

		// Token: 0x04000DB9 RID: 3513
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeYDelegate GetMaxComputeWorkGroupSizeYDelegateField;

		// Token: 0x04000DBA RID: 3514
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeZDelegate GetMaxComputeWorkGroupSizeZDelegateField;

		// Token: 0x04000DBB RID: 3515
		private static readonly SystemInfo.SupportsAsyncComputeDelegate SupportsAsyncComputeDelegateField;

		// Token: 0x04000DBC RID: 3516
		private static readonly SystemInfo.SupportsGpuRecorderDelegate SupportsGpuRecorderDelegateField;

		// Token: 0x04000DBD RID: 3517
		private static readonly SystemInfo.SupportsGPUFenceDelegate SupportsGPUFenceDelegateField;

		// Token: 0x04000DBE RID: 3518
		private static readonly SystemInfo.SupportsAsyncGPUReadbackDelegate SupportsAsyncGPUReadbackDelegateField;

		// Token: 0x04000DBF RID: 3519
		private static readonly SystemInfo.SupportsRayTracingDelegate SupportsRayTracingDelegateField;

		// Token: 0x04000DC0 RID: 3520
		private static readonly SystemInfo.SupportsSetConstantBufferDelegate SupportsSetConstantBufferDelegateField;

		// Token: 0x04000DC1 RID: 3521
		private static readonly SystemInfo.MinConstantBufferOffsetAlignmentDelegate MinConstantBufferOffsetAlignmentDelegateField;

		// Token: 0x04000DC2 RID: 3522
		private static readonly SystemInfo.HasMipMaxLevelDelegate HasMipMaxLevelDelegateField;

		// Token: 0x04000DC3 RID: 3523
		private static readonly SystemInfo.SupportsMipStreamingDelegate SupportsMipStreamingDelegateField;

		// Token: 0x04000DC4 RID: 3524
		private static readonly SystemInfo.UsesLoadStoreActionsDelegate UsesLoadStoreActionsDelegateField;

		// Token: 0x04000DC5 RID: 3525
		private static readonly SystemInfo.GetHDRDisplaySupportFlagsDelegate GetHDRDisplaySupportFlagsDelegateField;

		// Token: 0x04000DC6 RID: 3526
		private static readonly SystemInfo.SupportsConservativeRasterDelegate SupportsConservativeRasterDelegateField;

		// Token: 0x04000DC7 RID: 3527
		private static readonly SystemInfo.SupportsMultiviewDelegate SupportsMultiviewDelegateField;

		// Token: 0x04000DC8 RID: 3528
		private static readonly SystemInfo.SupportsStoreAndResolveActionDelegate SupportsStoreAndResolveActionDelegateField;

		// Token: 0x04000DC9 RID: 3529
		private static readonly SystemInfo.GetRenderTextureSupportedMSAASampleCount_InjectedDelegate GetRenderTextureSupportedMSAASampleCount_InjectedDelegateField;

		// Token: 0x020007D3 RID: 2003
		// (Invoke) Token: 0x06002D52 RID: 11602
		private delegate float GetBatteryLevelDelegate();

		// Token: 0x020007D4 RID: 2004
		// (Invoke) Token: 0x06002D54 RID: 11604
		private delegate BatteryStatus GetBatteryStatusDelegate();

		// Token: 0x020007D5 RID: 2005
		// (Invoke) Token: 0x06002D56 RID: 11606
		private delegate IntPtr GetProcessorTypeDelegate();

		// Token: 0x020007D6 RID: 2006
		// (Invoke) Token: 0x06002D58 RID: 11608
		private delegate int GetProcessorFrequencyMHzDelegate();

		// Token: 0x020007D7 RID: 2007
		// (Invoke) Token: 0x06002D5A RID: 11610
		private delegate int GetPhysicalMemoryMBDelegate();

		// Token: 0x020007D8 RID: 2008
		// (Invoke) Token: 0x06002D5C RID: 11612
		private delegate bool SupportsAccelerometerDelegate();

		// Token: 0x020007D9 RID: 2009
		// (Invoke) Token: 0x06002D5E RID: 11614
		private delegate bool IsGyroAvailableDelegate();

		// Token: 0x020007DA RID: 2010
		// (Invoke) Token: 0x06002D60 RID: 11616
		private delegate bool SupportsLocationServiceDelegate();

		// Token: 0x020007DB RID: 2011
		// (Invoke) Token: 0x06002D62 RID: 11618
		private delegate bool SupportsVibrationDelegate();

		// Token: 0x020007DC RID: 2012
		// (Invoke) Token: 0x06002D64 RID: 11620
		private delegate bool SupportsAudioDelegate();

		// Token: 0x020007DD RID: 2013
		// (Invoke) Token: 0x06002D66 RID: 11622
		private delegate int GetGraphicsMemorySizeDelegate();

		// Token: 0x020007DE RID: 2014
		// (Invoke) Token: 0x06002D68 RID: 11624
		private delegate IntPtr GetGraphicsDeviceNameDelegate();

		// Token: 0x020007DF RID: 2015
		// (Invoke) Token: 0x06002D6A RID: 11626
		private delegate IntPtr GetGraphicsDeviceVendorDelegate();

		// Token: 0x020007E0 RID: 2016
		// (Invoke) Token: 0x06002D6C RID: 11628
		private delegate int GetGraphicsDeviceIDDelegate();

		// Token: 0x020007E1 RID: 2017
		// (Invoke) Token: 0x06002D6E RID: 11630
		private delegate int GetGraphicsDeviceVendorIDDelegate();

		// Token: 0x020007E2 RID: 2018
		// (Invoke) Token: 0x06002D70 RID: 11632
		private delegate UnityEngine.Rendering.GraphicsDeviceType GetGraphicsDeviceTypeDelegate();

		// Token: 0x020007E3 RID: 2019
		// (Invoke) Token: 0x06002D72 RID: 11634
		private delegate bool GetGraphicsUVStartsAtTopDelegate();

		// Token: 0x020007E4 RID: 2020
		// (Invoke) Token: 0x06002D74 RID: 11636
		private delegate IntPtr GetGraphicsDeviceVersionDelegate();

		// Token: 0x020007E5 RID: 2021
		// (Invoke) Token: 0x06002D76 RID: 11638
		private delegate int GetGraphicsShaderLevelDelegate();

		// Token: 0x020007E6 RID: 2022
		// (Invoke) Token: 0x06002D78 RID: 11640
		private delegate bool GetGraphicsMultiThreadedDelegate();

		// Token: 0x020007E7 RID: 2023
		// (Invoke) Token: 0x06002D7A RID: 11642
		private delegate UnityEngine.Rendering.RenderingThreadingMode GetRenderingThreadingModeDelegate();

		// Token: 0x020007E8 RID: 2024
		// (Invoke) Token: 0x06002D7C RID: 11644
		private delegate bool HasHiddenSurfaceRemovalOnGPUDelegate();

		// Token: 0x020007E9 RID: 2025
		// (Invoke) Token: 0x06002D7E RID: 11646
		private delegate bool HasDynamicUniformArrayIndexingInFragmentShadersDelegate();

		// Token: 0x020007EA RID: 2026
		// (Invoke) Token: 0x06002D80 RID: 11648
		private delegate bool SupportsShadowsDelegate();

		// Token: 0x020007EB RID: 2027
		// (Invoke) Token: 0x06002D82 RID: 11650
		private delegate bool SupportsRawShadowDepthSamplingDelegate();

		// Token: 0x020007EC RID: 2028
		// (Invoke) Token: 0x06002D84 RID: 11652
		private delegate bool SupportsMotionVectorsDelegate();

		// Token: 0x020007ED RID: 2029
		// (Invoke) Token: 0x06002D86 RID: 11654
		private delegate bool Supports3DTexturesDelegate();

		// Token: 0x020007EE RID: 2030
		// (Invoke) Token: 0x06002D88 RID: 11656
		private delegate bool SupportsCompressed3DTexturesDelegate();

		// Token: 0x020007EF RID: 2031
		// (Invoke) Token: 0x06002D8A RID: 11658
		private delegate bool Supports2DArrayTexturesDelegate();

		// Token: 0x020007F0 RID: 2032
		// (Invoke) Token: 0x06002D8C RID: 11660
		private delegate bool Supports3DRenderTexturesDelegate();

		// Token: 0x020007F1 RID: 2033
		// (Invoke) Token: 0x06002D8E RID: 11662
		private delegate bool SupportsCubemapArrayTexturesDelegate();

		// Token: 0x020007F2 RID: 2034
		// (Invoke) Token: 0x06002D90 RID: 11664
		private delegate UnityEngine.Rendering.CopyTextureSupport GetCopyTextureSupportDelegate();

		// Token: 0x020007F3 RID: 2035
		// (Invoke) Token: 0x06002D92 RID: 11666
		private delegate bool SupportsComputeShadersDelegate();

		// Token: 0x020007F4 RID: 2036
		// (Invoke) Token: 0x06002D94 RID: 11668
		private delegate bool SupportsGeometryShadersDelegate();

		// Token: 0x020007F5 RID: 2037
		// (Invoke) Token: 0x06002D96 RID: 11670
		private delegate bool SupportsTessellationShadersDelegate();

		// Token: 0x020007F6 RID: 2038
		// (Invoke) Token: 0x06002D98 RID: 11672
		private delegate bool SupportsRenderTargetArrayIndexFromVertexShaderDelegate();

		// Token: 0x020007F7 RID: 2039
		// (Invoke) Token: 0x06002D9A RID: 11674
		private delegate bool SupportsInstancingDelegate();

		// Token: 0x020007F8 RID: 2040
		// (Invoke) Token: 0x06002D9C RID: 11676
		private delegate bool SupportsHardwareQuadTopologyDelegate();

		// Token: 0x020007F9 RID: 2041
		// (Invoke) Token: 0x06002D9E RID: 11678
		private delegate bool Supports32bitsIndexBufferDelegate();

		// Token: 0x020007FA RID: 2042
		// (Invoke) Token: 0x06002DA0 RID: 11680
		private delegate bool SupportsSparseTexturesDelegate();

		// Token: 0x020007FB RID: 2043
		// (Invoke) Token: 0x06002DA2 RID: 11682
		private delegate int SupportedRenderTargetCountDelegate();

		// Token: 0x020007FC RID: 2044
		// (Invoke) Token: 0x06002DA4 RID: 11684
		private delegate bool SupportsSeparatedRenderTargetsBlendDelegate();

		// Token: 0x020007FD RID: 2045
		// (Invoke) Token: 0x06002DA6 RID: 11686
		private delegate int SupportedRandomWriteTargetCountDelegate();

		// Token: 0x020007FE RID: 2046
		// (Invoke) Token: 0x06002DA8 RID: 11688
		private delegate int MaxComputeBufferInputsVertexDelegate();

		// Token: 0x020007FF RID: 2047
		// (Invoke) Token: 0x06002DAA RID: 11690
		private delegate int MaxComputeBufferInputsFragmentDelegate();

		// Token: 0x02000800 RID: 2048
		// (Invoke) Token: 0x06002DAC RID: 11692
		private delegate int MaxComputeBufferInputsGeometryDelegate();

		// Token: 0x02000801 RID: 2049
		// (Invoke) Token: 0x06002DAE RID: 11694
		private delegate int MaxComputeBufferInputsDomainDelegate();

		// Token: 0x02000802 RID: 2050
		// (Invoke) Token: 0x06002DB0 RID: 11696
		private delegate int MaxComputeBufferInputsHullDelegate();

		// Token: 0x02000803 RID: 2051
		// (Invoke) Token: 0x06002DB2 RID: 11698
		private delegate int MaxComputeBufferInputsComputeDelegate();

		// Token: 0x02000804 RID: 2052
		// (Invoke) Token: 0x06002DB4 RID: 11700
		private delegate int SupportsMultisampledTexturesDelegate();

		// Token: 0x02000805 RID: 2053
		// (Invoke) Token: 0x06002DB6 RID: 11702
		private delegate bool SupportsMultisampled2DArrayTexturesDelegate();

		// Token: 0x02000806 RID: 2054
		// (Invoke) Token: 0x06002DB8 RID: 11704
		private delegate bool SupportsMultisampleAutoResolveDelegate();

		// Token: 0x02000807 RID: 2055
		// (Invoke) Token: 0x06002DBA RID: 11706
		private delegate int SupportsTextureWrapMirrorOnceDelegate();

		// Token: 0x02000808 RID: 2056
		// (Invoke) Token: 0x06002DBC RID: 11708
		private delegate bool UsesReversedZBufferDelegate();

		// Token: 0x02000809 RID: 2057
		// (Invoke) Token: 0x06002DBE RID: 11710
		private delegate bool HasRenderTextureNativeDelegate(RenderTextureFormat format);

		// Token: 0x0200080A RID: 2058
		// (Invoke) Token: 0x06002DC0 RID: 11712
		private delegate bool SupportsBlendingOnRenderTextureFormatNativeDelegate(RenderTextureFormat format);

		// Token: 0x0200080B RID: 2059
		// (Invoke) Token: 0x06002DC2 RID: 11714
		private delegate bool SupportsRandomWriteOnRenderTextureFormatNativeDelegate(RenderTextureFormat format);

		// Token: 0x0200080C RID: 2060
		// (Invoke) Token: 0x06002DC4 RID: 11716
		private delegate bool SupportsVertexAttributeFormatNativeDelegate(UnityEngine.Rendering.VertexAttributeFormat format, int dimension);

		// Token: 0x0200080D RID: 2061
		// (Invoke) Token: 0x06002DC6 RID: 11718
		private delegate NPOTSupport GetNPOTSupportDelegate();

		// Token: 0x0200080E RID: 2062
		// (Invoke) Token: 0x06002DC8 RID: 11720
		private delegate int GetMaxTextureSizeDelegate();

		// Token: 0x0200080F RID: 2063
		// (Invoke) Token: 0x06002DCA RID: 11722
		private delegate int GetMaxCubemapSizeDelegate();

		// Token: 0x02000810 RID: 2064
		// (Invoke) Token: 0x06002DCC RID: 11724
		private delegate int GetMaxRenderTextureSizeDelegate();

		// Token: 0x02000811 RID: 2065
		// (Invoke) Token: 0x06002DCE RID: 11726
		private delegate int GetMaxComputeWorkGroupSizeDelegate();

		// Token: 0x02000812 RID: 2066
		// (Invoke) Token: 0x06002DD0 RID: 11728
		private delegate int GetMaxComputeWorkGroupSizeXDelegate();

		// Token: 0x02000813 RID: 2067
		// (Invoke) Token: 0x06002DD2 RID: 11730
		private delegate int GetMaxComputeWorkGroupSizeYDelegate();

		// Token: 0x02000814 RID: 2068
		// (Invoke) Token: 0x06002DD4 RID: 11732
		private delegate int GetMaxComputeWorkGroupSizeZDelegate();

		// Token: 0x02000815 RID: 2069
		// (Invoke) Token: 0x06002DD6 RID: 11734
		private delegate bool SupportsAsyncComputeDelegate();

		// Token: 0x02000816 RID: 2070
		// (Invoke) Token: 0x06002DD8 RID: 11736
		private delegate bool SupportsGpuRecorderDelegate();

		// Token: 0x02000817 RID: 2071
		// (Invoke) Token: 0x06002DDA RID: 11738
		private delegate bool SupportsGPUFenceDelegate();

		// Token: 0x02000818 RID: 2072
		// (Invoke) Token: 0x06002DDC RID: 11740
		private delegate bool SupportsAsyncGPUReadbackDelegate();

		// Token: 0x02000819 RID: 2073
		// (Invoke) Token: 0x06002DDE RID: 11742
		private delegate bool SupportsRayTracingDelegate();

		// Token: 0x0200081A RID: 2074
		// (Invoke) Token: 0x06002DE0 RID: 11744
		private delegate bool SupportsSetConstantBufferDelegate();

		// Token: 0x0200081B RID: 2075
		// (Invoke) Token: 0x06002DE2 RID: 11746
		private delegate int MinConstantBufferOffsetAlignmentDelegate();

		// Token: 0x0200081C RID: 2076
		// (Invoke) Token: 0x06002DE4 RID: 11748
		private delegate bool HasMipMaxLevelDelegate();

		// Token: 0x0200081D RID: 2077
		// (Invoke) Token: 0x06002DE6 RID: 11750
		private delegate bool SupportsMipStreamingDelegate();

		// Token: 0x0200081E RID: 2078
		// (Invoke) Token: 0x06002DE8 RID: 11752
		private delegate bool UsesLoadStoreActionsDelegate();

		// Token: 0x0200081F RID: 2079
		// (Invoke) Token: 0x06002DEA RID: 11754
		private delegate HDRDisplaySupportFlags GetHDRDisplaySupportFlagsDelegate();

		// Token: 0x02000820 RID: 2080
		// (Invoke) Token: 0x06002DEC RID: 11756
		private delegate bool SupportsConservativeRasterDelegate();

		// Token: 0x02000821 RID: 2081
		// (Invoke) Token: 0x06002DEE RID: 11758
		private delegate bool SupportsMultiviewDelegate();

		// Token: 0x02000822 RID: 2082
		// (Invoke) Token: 0x06002DF0 RID: 11760
		private delegate bool SupportsStoreAndResolveActionDelegate();

		// Token: 0x02000823 RID: 2083
		// (Invoke) Token: 0x06002DF2 RID: 11762
		private delegate int GetRenderTextureSupportedMSAASampleCount_InjectedDelegate(IntPtr desc);
	}
}
