using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000052 RID: 82
	public sealed class QualitySettings : Object
	{
		// Token: 0x0600061D RID: 1565 RVA: 0x00024AB4 File Offset: 0x00022CB4
		// Note: this type is marked as 'beforefieldinit'.
		static QualitySettings()
		{
			Il2CppClassPointerStore<QualitySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "QualitySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr);
			QualitySettings.NativeMethodInfoPtr_get_vSyncCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100663617);
			QualitySettings.NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100663618);
			QualitySettings.NativeMethodInfoPtr_get_names_Public_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100663619);
			QualitySettings.NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100663620);
			QualitySettings.get_pixelLightCountDelegateField = IL2CPP.ResolveICall<QualitySettings.get_pixelLightCountDelegate>("UnityEngine.QualitySettings::get_pixelLightCount");
			QualitySettings.set_pixelLightCountDelegateField = IL2CPP.ResolveICall<QualitySettings.set_pixelLightCountDelegate>("UnityEngine.QualitySettings::set_pixelLightCount");
			QualitySettings.get_shadowsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowsDelegate>("UnityEngine.QualitySettings::get_shadows");
			QualitySettings.set_shadowsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowsDelegate>("UnityEngine.QualitySettings::set_shadows");
			QualitySettings.get_shadowProjectionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowProjectionDelegate>("UnityEngine.QualitySettings::get_shadowProjection");
			QualitySettings.set_shadowProjectionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowProjectionDelegate>("UnityEngine.QualitySettings::set_shadowProjection");
			QualitySettings.get_shadowCascadesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowCascadesDelegate>("UnityEngine.QualitySettings::get_shadowCascades");
			QualitySettings.set_shadowCascadesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowCascadesDelegate>("UnityEngine.QualitySettings::set_shadowCascades");
			QualitySettings.get_shadowDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowDistanceDelegate>("UnityEngine.QualitySettings::get_shadowDistance");
			QualitySettings.set_shadowDistanceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowDistanceDelegate>("UnityEngine.QualitySettings::set_shadowDistance");
			QualitySettings.get_shadowResolutionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowResolutionDelegate>("UnityEngine.QualitySettings::get_shadowResolution");
			QualitySettings.set_shadowResolutionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowResolutionDelegate>("UnityEngine.QualitySettings::set_shadowResolution");
			QualitySettings.get_shadowmaskModeDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowmaskModeDelegate>("UnityEngine.QualitySettings::get_shadowmaskMode");
			QualitySettings.set_shadowmaskModeDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowmaskModeDelegate>("UnityEngine.QualitySettings::set_shadowmaskMode");
			QualitySettings.get_shadowNearPlaneOffsetDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowNearPlaneOffsetDelegate>("UnityEngine.QualitySettings::get_shadowNearPlaneOffset");
			QualitySettings.set_shadowNearPlaneOffsetDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowNearPlaneOffsetDelegate>("UnityEngine.QualitySettings::set_shadowNearPlaneOffset");
			QualitySettings.get_shadowCascade2SplitDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowCascade2SplitDelegate>("UnityEngine.QualitySettings::get_shadowCascade2Split");
			QualitySettings.set_shadowCascade2SplitDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowCascade2SplitDelegate>("UnityEngine.QualitySettings::set_shadowCascade2Split");
			QualitySettings.get_lodBiasDelegateField = IL2CPP.ResolveICall<QualitySettings.get_lodBiasDelegate>("UnityEngine.QualitySettings::get_lodBias");
			QualitySettings.set_lodBiasDelegateField = IL2CPP.ResolveICall<QualitySettings.set_lodBiasDelegate>("UnityEngine.QualitySettings::set_lodBias");
			QualitySettings.get_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<QualitySettings.get_anisotropicFilteringDelegate>("UnityEngine.QualitySettings::get_anisotropicFiltering");
			QualitySettings.set_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<QualitySettings.set_anisotropicFilteringDelegate>("UnityEngine.QualitySettings::set_anisotropicFiltering");
			QualitySettings.get_masterTextureLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.get_masterTextureLimitDelegate>("UnityEngine.QualitySettings::get_masterTextureLimit");
			QualitySettings.set_masterTextureLimitDelegateField = IL2CPP.ResolveICall<QualitySettings.set_masterTextureLimitDelegate>("UnityEngine.QualitySettings::set_masterTextureLimit");
			QualitySettings.get_maximumLODLevelDelegateField = IL2CPP.ResolveICall<QualitySettings.get_maximumLODLevelDelegate>("UnityEngine.QualitySettings::get_maximumLODLevel");
			QualitySettings.set_maximumLODLevelDelegateField = IL2CPP.ResolveICall<QualitySettings.set_maximumLODLevelDelegate>("UnityEngine.QualitySettings::set_maximumLODLevel");
			QualitySettings.get_particleRaycastBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.get_particleRaycastBudgetDelegate>("UnityEngine.QualitySettings::get_particleRaycastBudget");
			QualitySettings.set_particleRaycastBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.set_particleRaycastBudgetDelegate>("UnityEngine.QualitySettings::set_particleRaycastBudget");
			QualitySettings.get_softParticlesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_softParticlesDelegate>("UnityEngine.QualitySettings::get_softParticles");
			QualitySettings.set_softParticlesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_softParticlesDelegate>("UnityEngine.QualitySettings::set_softParticles");
			QualitySettings.get_softVegetationDelegateField = IL2CPP.ResolveICall<QualitySettings.get_softVegetationDelegate>("UnityEngine.QualitySettings::get_softVegetation");
			QualitySettings.set_softVegetationDelegateField = IL2CPP.ResolveICall<QualitySettings.set_softVegetationDelegate>("UnityEngine.QualitySettings::set_softVegetation");
			QualitySettings.set_vSyncCountDelegateField = IL2CPP.ResolveICall<QualitySettings.set_vSyncCountDelegate>("UnityEngine.QualitySettings::set_vSyncCount");
			QualitySettings.get_antiAliasingDelegateField = IL2CPP.ResolveICall<QualitySettings.get_antiAliasingDelegate>("UnityEngine.QualitySettings::get_antiAliasing");
			QualitySettings.set_antiAliasingDelegateField = IL2CPP.ResolveICall<QualitySettings.set_antiAliasingDelegate>("UnityEngine.QualitySettings::set_antiAliasing");
			QualitySettings.get_asyncUploadTimeSliceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_asyncUploadTimeSliceDelegate>("UnityEngine.QualitySettings::get_asyncUploadTimeSlice");
			QualitySettings.set_asyncUploadTimeSliceDelegateField = IL2CPP.ResolveICall<QualitySettings.set_asyncUploadTimeSliceDelegate>("UnityEngine.QualitySettings::set_asyncUploadTimeSlice");
			QualitySettings.get_asyncUploadBufferSizeDelegateField = IL2CPP.ResolveICall<QualitySettings.get_asyncUploadBufferSizeDelegate>("UnityEngine.QualitySettings::get_asyncUploadBufferSize");
			QualitySettings.set_asyncUploadBufferSizeDelegateField = IL2CPP.ResolveICall<QualitySettings.set_asyncUploadBufferSizeDelegate>("UnityEngine.QualitySettings::set_asyncUploadBufferSize");
			QualitySettings.get_asyncUploadPersistentBufferDelegateField = IL2CPP.ResolveICall<QualitySettings.get_asyncUploadPersistentBufferDelegate>("UnityEngine.QualitySettings::get_asyncUploadPersistentBuffer");
			QualitySettings.set_asyncUploadPersistentBufferDelegateField = IL2CPP.ResolveICall<QualitySettings.set_asyncUploadPersistentBufferDelegate>("UnityEngine.QualitySettings::set_asyncUploadPersistentBuffer");
			QualitySettings.SetLODSettingsDelegateField = IL2CPP.ResolveICall<QualitySettings.SetLODSettingsDelegate>("UnityEngine.QualitySettings::SetLODSettings");
			QualitySettings.get_realtimeReflectionProbesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_realtimeReflectionProbesDelegate>("UnityEngine.QualitySettings::get_realtimeReflectionProbes");
			QualitySettings.set_realtimeReflectionProbesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_realtimeReflectionProbesDelegate>("UnityEngine.QualitySettings::set_realtimeReflectionProbes");
			QualitySettings.get_billboardsFaceCameraPositionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_billboardsFaceCameraPositionDelegate>("UnityEngine.QualitySettings::get_billboardsFaceCameraPosition");
			QualitySettings.set_billboardsFaceCameraPositionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_billboardsFaceCameraPositionDelegate>("UnityEngine.QualitySettings::set_billboardsFaceCameraPosition");
			QualitySettings.get_resolutionScalingFixedDPIFactorDelegateField = IL2CPP.ResolveICall<QualitySettings.get_resolutionScalingFixedDPIFactorDelegate>("UnityEngine.QualitySettings::get_resolutionScalingFixedDPIFactor");
			QualitySettings.set_resolutionScalingFixedDPIFactorDelegateField = IL2CPP.ResolveICall<QualitySettings.set_resolutionScalingFixedDPIFactorDelegate>("UnityEngine.QualitySettings::set_resolutionScalingFixedDPIFactor");
			QualitySettings.get_INTERNAL_renderPipelineDelegateField = IL2CPP.ResolveICall<QualitySettings.get_INTERNAL_renderPipelineDelegate>("UnityEngine.QualitySettings::get_INTERNAL_renderPipeline");
			QualitySettings.set_INTERNAL_renderPipelineDelegateField = IL2CPP.ResolveICall<QualitySettings.set_INTERNAL_renderPipelineDelegate>("UnityEngine.QualitySettings::set_INTERNAL_renderPipeline");
			QualitySettings.InternalGetRenderPipelineAssetAtDelegateField = IL2CPP.ResolveICall<QualitySettings.InternalGetRenderPipelineAssetAtDelegate>("UnityEngine.QualitySettings::InternalGetRenderPipelineAssetAt");
			QualitySettings.get_blendWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_blendWeightsDelegate>("UnityEngine.QualitySettings::get_blendWeights");
			QualitySettings.set_blendWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_blendWeightsDelegate>("UnityEngine.QualitySettings::set_blendWeights");
			QualitySettings.get_skinWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_skinWeightsDelegate>("UnityEngine.QualitySettings::get_skinWeights");
			QualitySettings.set_skinWeightsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_skinWeightsDelegate>("UnityEngine.QualitySettings::set_skinWeights");
			QualitySettings.get_streamingMipmapsActiveDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsActiveDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsActive");
			QualitySettings.set_streamingMipmapsActiveDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsActiveDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsActive");
			QualitySettings.get_streamingMipmapsMemoryBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsMemoryBudgetDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMemoryBudget");
			QualitySettings.set_streamingMipmapsMemoryBudgetDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsMemoryBudgetDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMemoryBudget");
			QualitySettings.get_streamingMipmapsRenderersPerFrameDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsRenderersPerFrameDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsRenderersPerFrame");
			QualitySettings.set_streamingMipmapsRenderersPerFrameDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsRenderersPerFrameDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsRenderersPerFrame");
			QualitySettings.get_streamingMipmapsMaxLevelReductionDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsMaxLevelReductionDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMaxLevelReduction");
			QualitySettings.set_streamingMipmapsMaxLevelReductionDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsMaxLevelReductionDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMaxLevelReduction");
			QualitySettings.get_streamingMipmapsAddAllCamerasDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsAddAllCamerasDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsAddAllCameras");
			QualitySettings.set_streamingMipmapsAddAllCamerasDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsAddAllCamerasDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsAddAllCameras");
			QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegateField = IL2CPP.ResolveICall<QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMaxFileIORequests");
			QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegateField = IL2CPP.ResolveICall<QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMaxFileIORequests");
			QualitySettings.get_maxQueuedFramesDelegateField = IL2CPP.ResolveICall<QualitySettings.get_maxQueuedFramesDelegate>("UnityEngine.QualitySettings::get_maxQueuedFrames");
			QualitySettings.set_maxQueuedFramesDelegateField = IL2CPP.ResolveICall<QualitySettings.set_maxQueuedFramesDelegate>("UnityEngine.QualitySettings::set_maxQueuedFrames");
			QualitySettings.GetQualityLevelDelegateField = IL2CPP.ResolveICall<QualitySettings.GetQualityLevelDelegate>("UnityEngine.QualitySettings::GetQualityLevel");
			QualitySettings.get_desiredColorSpaceDelegateField = IL2CPP.ResolveICall<QualitySettings.get_desiredColorSpaceDelegate>("UnityEngine.QualitySettings::get_desiredColorSpace");
			QualitySettings.get_shadowCascade4Split_InjectedDelegateField = IL2CPP.ResolveICall<QualitySettings.get_shadowCascade4Split_InjectedDelegate>("UnityEngine.QualitySettings::get_shadowCascade4Split_Injected");
			QualitySettings.set_shadowCascade4Split_InjectedDelegateField = IL2CPP.ResolveICall<QualitySettings.set_shadowCascade4Split_InjectedDelegate>("UnityEngine.QualitySettings::set_shadowCascade4Split_Injected");
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00024F7C File Offset: 0x0002317C
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x000058FA File Offset: 0x00003AFA
		public unsafe static int vSyncCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62753, RefRangeEnd = 62754, XrefRangeStart = 62751, XrefRangeEnd = 62753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_vSyncCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				QualitySettings.set_vSyncCountDelegateField(value);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00024FAC File Offset: 0x000231AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62756, RefRangeEnd = 62757, XrefRangeStart = 62754, XrefRangeEnd = 62756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetQualityLevel(int index, bool applyExpensiveChanges)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyExpensiveChanges;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00024FEC File Offset: 0x000231EC
		public unsafe static Il2CppStringArray names
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62759, RefRangeEnd = 62760, XrefRangeStart = 62757, XrefRangeEnd = 62759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_names_Public_Static_get_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x00025020 File Offset: 0x00023220
		public unsafe static ColorSpace activeColorSpace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62760, XrefRangeEnd = 62762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySettings.NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0000570C File Offset: 0x0000390C
		public QualitySettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00005715 File Offset: 0x00003915
		public static void IncreaseLevel(bool applyExpensiveChanges)
		{
			QualitySettings.SetQualityLevel(QualitySettings.GetQualityLevel() + 1, applyExpensiveChanges);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00005726 File Offset: 0x00003926
		public static void DecreaseLevel(bool applyExpensiveChanges)
		{
			QualitySettings.SetQualityLevel(QualitySettings.GetQualityLevel() - 1, applyExpensiveChanges);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00005737 File Offset: 0x00003937
		public static void SetQualityLevel(int index)
		{
			QualitySettings.SetQualityLevel(index, true);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00005742 File Offset: 0x00003942
		public static void IncreaseLevel()
		{
			QualitySettings.IncreaseLevel(false);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0000574C File Offset: 0x0000394C
		public static void DecreaseLevel()
		{
			QualitySettings.DecreaseLevel(false);
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00025050 File Offset: 0x00023250
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x00005756 File Offset: 0x00003956
		public static QualityLevel currentLevel
		{
			get
			{
				return (QualityLevel)QualitySettings.GetQualityLevel();
			}
			set
			{
				QualitySettings.SetQualityLevel((int)value, true);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x00005761 File Offset: 0x00003961
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x0000576D File Offset: 0x0000396D
		public static int pixelLightCount
		{
			get
			{
				return QualitySettings.get_pixelLightCountDelegateField();
			}
			set
			{
				QualitySettings.set_pixelLightCountDelegateField(value);
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x0000577A File Offset: 0x0000397A
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00005786 File Offset: 0x00003986
		public static ShadowQuality shadows
		{
			get
			{
				return QualitySettings.get_shadowsDelegateField();
			}
			set
			{
				QualitySettings.set_shadowsDelegateField(value);
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00005793 File Offset: 0x00003993
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x0000579F File Offset: 0x0000399F
		public static ShadowProjection shadowProjection
		{
			get
			{
				return QualitySettings.get_shadowProjectionDelegateField();
			}
			set
			{
				QualitySettings.set_shadowProjectionDelegateField(value);
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x000057AC File Offset: 0x000039AC
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x000057B8 File Offset: 0x000039B8
		public static int shadowCascades
		{
			get
			{
				return QualitySettings.get_shadowCascadesDelegateField();
			}
			set
			{
				QualitySettings.set_shadowCascadesDelegateField(value);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x000057C5 File Offset: 0x000039C5
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x000057D1 File Offset: 0x000039D1
		public static float shadowDistance
		{
			get
			{
				return QualitySettings.get_shadowDistanceDelegateField();
			}
			set
			{
				QualitySettings.set_shadowDistanceDelegateField(value);
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x000057DE File Offset: 0x000039DE
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x000057EA File Offset: 0x000039EA
		public static ShadowResolution shadowResolution
		{
			get
			{
				return QualitySettings.get_shadowResolutionDelegateField();
			}
			set
			{
				QualitySettings.set_shadowResolutionDelegateField(value);
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x000057F7 File Offset: 0x000039F7
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x00005803 File Offset: 0x00003A03
		public static ShadowmaskMode shadowmaskMode
		{
			get
			{
				return QualitySettings.get_shadowmaskModeDelegateField();
			}
			set
			{
				QualitySettings.set_shadowmaskModeDelegateField(value);
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00005810 File Offset: 0x00003A10
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x0000581C File Offset: 0x00003A1C
		public static float shadowNearPlaneOffset
		{
			get
			{
				return QualitySettings.get_shadowNearPlaneOffsetDelegateField();
			}
			set
			{
				QualitySettings.set_shadowNearPlaneOffsetDelegateField(value);
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00005829 File Offset: 0x00003A29
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00005835 File Offset: 0x00003A35
		public static float shadowCascade2Split
		{
			get
			{
				return QualitySettings.get_shadowCascade2SplitDelegateField();
			}
			set
			{
				QualitySettings.set_shadowCascade2SplitDelegateField(value);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00025068 File Offset: 0x00023268
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x00005842 File Offset: 0x00003A42
		public static Vector3 shadowCascade4Split
		{
			get
			{
				Vector3 vector;
				QualitySettings.get_shadowCascade4Split_Injected(out vector);
				return vector;
			}
			set
			{
				QualitySettings.set_shadowCascade4Split_Injected(ref value);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x0000584B File Offset: 0x00003A4B
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x00005857 File Offset: 0x00003A57
		public static float lodBias
		{
			get
			{
				return QualitySettings.get_lodBiasDelegateField();
			}
			set
			{
				QualitySettings.set_lodBiasDelegateField(value);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00005864 File Offset: 0x00003A64
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x00005870 File Offset: 0x00003A70
		public static AnisotropicFiltering anisotropicFiltering
		{
			get
			{
				return QualitySettings.get_anisotropicFilteringDelegateField();
			}
			set
			{
				QualitySettings.set_anisotropicFilteringDelegateField(value);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x0000587D File Offset: 0x00003A7D
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00005889 File Offset: 0x00003A89
		public static int masterTextureLimit
		{
			get
			{
				return QualitySettings.get_masterTextureLimitDelegateField();
			}
			set
			{
				QualitySettings.set_masterTextureLimitDelegateField(value);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00005896 File Offset: 0x00003A96
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x000058A2 File Offset: 0x00003AA2
		public static int maximumLODLevel
		{
			get
			{
				return QualitySettings.get_maximumLODLevelDelegateField();
			}
			set
			{
				QualitySettings.set_maximumLODLevelDelegateField(value);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x000058AF File Offset: 0x00003AAF
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x000058BB File Offset: 0x00003ABB
		public static int particleRaycastBudget
		{
			get
			{
				return QualitySettings.get_particleRaycastBudgetDelegateField();
			}
			set
			{
				QualitySettings.set_particleRaycastBudgetDelegateField(value);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x000058C8 File Offset: 0x00003AC8
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x000058D4 File Offset: 0x00003AD4
		public static bool softParticles
		{
			get
			{
				return QualitySettings.get_softParticlesDelegateField();
			}
			set
			{
				QualitySettings.set_softParticlesDelegateField(value);
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x000058E1 File Offset: 0x00003AE1
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x000058ED File Offset: 0x00003AED
		public static bool softVegetation
		{
			get
			{
				return QualitySettings.get_softVegetationDelegateField();
			}
			set
			{
				QualitySettings.set_softVegetationDelegateField(value);
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00005907 File Offset: 0x00003B07
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00005913 File Offset: 0x00003B13
		public static int antiAliasing
		{
			get
			{
				return QualitySettings.get_antiAliasingDelegateField();
			}
			set
			{
				QualitySettings.set_antiAliasingDelegateField(value);
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00005920 File Offset: 0x00003B20
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x0000592C File Offset: 0x00003B2C
		public static int asyncUploadTimeSlice
		{
			get
			{
				return QualitySettings.get_asyncUploadTimeSliceDelegateField();
			}
			set
			{
				QualitySettings.set_asyncUploadTimeSliceDelegateField(value);
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00005939 File Offset: 0x00003B39
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00005945 File Offset: 0x00003B45
		public static int asyncUploadBufferSize
		{
			get
			{
				return QualitySettings.get_asyncUploadBufferSizeDelegateField();
			}
			set
			{
				QualitySettings.set_asyncUploadBufferSizeDelegateField(value);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00005952 File Offset: 0x00003B52
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x0000595E File Offset: 0x00003B5E
		public static bool asyncUploadPersistentBuffer
		{
			get
			{
				return QualitySettings.get_asyncUploadPersistentBufferDelegateField();
			}
			set
			{
				QualitySettings.set_asyncUploadPersistentBufferDelegateField(value);
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0000596B File Offset: 0x00003B6B
		public static void SetLODSettings(float lodBias, int maximumLODLevel, [Optional] bool setDirty)
		{
			QualitySettings.SetLODSettingsDelegateField(lodBias, maximumLODLevel, setDirty);
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0000597A File Offset: 0x00003B7A
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00005986 File Offset: 0x00003B86
		public static bool realtimeReflectionProbes
		{
			get
			{
				return QualitySettings.get_realtimeReflectionProbesDelegateField();
			}
			set
			{
				QualitySettings.set_realtimeReflectionProbesDelegateField(value);
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00005993 File Offset: 0x00003B93
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x0000599F File Offset: 0x00003B9F
		public static bool billboardsFaceCameraPosition
		{
			get
			{
				return QualitySettings.get_billboardsFaceCameraPositionDelegateField();
			}
			set
			{
				QualitySettings.set_billboardsFaceCameraPositionDelegateField(value);
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x000059AC File Offset: 0x00003BAC
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x000059B8 File Offset: 0x00003BB8
		public static float resolutionScalingFixedDPIFactor
		{
			get
			{
				return QualitySettings.get_resolutionScalingFixedDPIFactorDelegateField();
			}
			set
			{
				QualitySettings.set_resolutionScalingFixedDPIFactorDelegateField(value);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00025080 File Offset: 0x00023280
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x000059C5 File Offset: 0x00003BC5
		public static ScriptableObject INTERNAL_renderPipeline
		{
			get
			{
				IntPtr intPtr = QualitySettings.get_INTERNAL_renderPipelineDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
			}
			set
			{
				QualitySettings.set_INTERNAL_renderPipelineDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x000250A8 File Offset: 0x000232A8
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x000059D7 File Offset: 0x00003BD7
		public static UnityEngine.Rendering.RenderPipelineAsset renderPipeline
		{
			get
			{
				return QualitySettings.INTERNAL_renderPipeline.TryCast<UnityEngine.Rendering.RenderPipelineAsset>();
			}
			set
			{
				QualitySettings.INTERNAL_renderPipeline = value;
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x000250C4 File Offset: 0x000232C4
		public static ScriptableObject InternalGetRenderPipelineAssetAt(int index)
		{
			IntPtr intPtr = QualitySettings.InternalGetRenderPipelineAssetAtDelegateField(index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x000250EC File Offset: 0x000232EC
		public static UnityEngine.Rendering.RenderPipelineAsset GetRenderPipelineAssetAt(int index)
		{
			bool flag = index < 0 || index >= QualitySettings.names.Length;
			if (flag)
			{
				throw new IndexOutOfRangeException(String.Format("{0} is out of range [0..{1}[", "index", QualitySettings.names.Length));
			}
			return QualitySettings.InternalGetRenderPipelineAssetAt(index).TryCast<UnityEngine.Rendering.RenderPipelineAsset>();
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x000059E1 File Offset: 0x00003BE1
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x000059ED File Offset: 0x00003BED
		public static BlendWeights blendWeights
		{
			get
			{
				return QualitySettings.get_blendWeightsDelegateField();
			}
			set
			{
				QualitySettings.set_blendWeightsDelegateField(value);
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x000059FA File Offset: 0x00003BFA
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00005A06 File Offset: 0x00003C06
		public static SkinWeights skinWeights
		{
			get
			{
				return QualitySettings.get_skinWeightsDelegateField();
			}
			set
			{
				QualitySettings.set_skinWeightsDelegateField(value);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00005A13 File Offset: 0x00003C13
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00005A1F File Offset: 0x00003C1F
		public static bool streamingMipmapsActive
		{
			get
			{
				return QualitySettings.get_streamingMipmapsActiveDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsActiveDelegateField(value);
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00005A2C File Offset: 0x00003C2C
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00005A38 File Offset: 0x00003C38
		public static float streamingMipmapsMemoryBudget
		{
			get
			{
				return QualitySettings.get_streamingMipmapsMemoryBudgetDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsMemoryBudgetDelegateField(value);
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00005A45 File Offset: 0x00003C45
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00005A51 File Offset: 0x00003C51
		public static int streamingMipmapsRenderersPerFrame
		{
			get
			{
				return QualitySettings.get_streamingMipmapsRenderersPerFrameDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsRenderersPerFrameDelegateField(value);
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00005A5E File Offset: 0x00003C5E
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00005A6A File Offset: 0x00003C6A
		public static int streamingMipmapsMaxLevelReduction
		{
			get
			{
				return QualitySettings.get_streamingMipmapsMaxLevelReductionDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsMaxLevelReductionDelegateField(value);
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00005A77 File Offset: 0x00003C77
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00005A83 File Offset: 0x00003C83
		public static bool streamingMipmapsAddAllCameras
		{
			get
			{
				return QualitySettings.get_streamingMipmapsAddAllCamerasDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsAddAllCamerasDelegateField(value);
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00005A90 File Offset: 0x00003C90
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00005A9C File Offset: 0x00003C9C
		public static int streamingMipmapsMaxFileIORequests
		{
			get
			{
				return QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegateField();
			}
			set
			{
				QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegateField(value);
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00005AA9 File Offset: 0x00003CA9
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00005AB5 File Offset: 0x00003CB5
		public static int maxQueuedFrames
		{
			get
			{
				return QualitySettings.get_maxQueuedFramesDelegateField();
			}
			set
			{
				QualitySettings.set_maxQueuedFramesDelegateField(value);
			}
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00005AC2 File Offset: 0x00003CC2
		public static int GetQualityLevel()
		{
			return QualitySettings.GetQualityLevelDelegateField();
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00005ACE File Offset: 0x00003CCE
		public static ColorSpace desiredColorSpace
		{
			get
			{
				return QualitySettings.get_desiredColorSpaceDelegateField();
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00005ADA File Offset: 0x00003CDA
		public static void get_shadowCascade4Split_Injected(out Vector3 ret)
		{
			QualitySettings.get_shadowCascade4Split_InjectedDelegateField(out ret);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00005AE7 File Offset: 0x00003CE7
		public static void set_shadowCascade4Split_Injected(ref Vector3 value)
		{
			QualitySettings.set_shadowCascade4Split_InjectedDelegateField(ref value);
		}

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_get_vSyncCount_Public_Static_get_Int32_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_Boolean_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_get_names_Public_Static_get_Il2CppStringArray_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0;

		// Token: 0x040003D8 RID: 984
		private static readonly QualitySettings.get_pixelLightCountDelegate get_pixelLightCountDelegateField;

		// Token: 0x040003D9 RID: 985
		private static readonly QualitySettings.set_pixelLightCountDelegate set_pixelLightCountDelegateField;

		// Token: 0x040003DA RID: 986
		private static readonly QualitySettings.get_shadowsDelegate get_shadowsDelegateField;

		// Token: 0x040003DB RID: 987
		private static readonly QualitySettings.set_shadowsDelegate set_shadowsDelegateField;

		// Token: 0x040003DC RID: 988
		private static readonly QualitySettings.get_shadowProjectionDelegate get_shadowProjectionDelegateField;

		// Token: 0x040003DD RID: 989
		private static readonly QualitySettings.set_shadowProjectionDelegate set_shadowProjectionDelegateField;

		// Token: 0x040003DE RID: 990
		private static readonly QualitySettings.get_shadowCascadesDelegate get_shadowCascadesDelegateField;

		// Token: 0x040003DF RID: 991
		private static readonly QualitySettings.set_shadowCascadesDelegate set_shadowCascadesDelegateField;

		// Token: 0x040003E0 RID: 992
		private static readonly QualitySettings.get_shadowDistanceDelegate get_shadowDistanceDelegateField;

		// Token: 0x040003E1 RID: 993
		private static readonly QualitySettings.set_shadowDistanceDelegate set_shadowDistanceDelegateField;

		// Token: 0x040003E2 RID: 994
		private static readonly QualitySettings.get_shadowResolutionDelegate get_shadowResolutionDelegateField;

		// Token: 0x040003E3 RID: 995
		private static readonly QualitySettings.set_shadowResolutionDelegate set_shadowResolutionDelegateField;

		// Token: 0x040003E4 RID: 996
		private static readonly QualitySettings.get_shadowmaskModeDelegate get_shadowmaskModeDelegateField;

		// Token: 0x040003E5 RID: 997
		private static readonly QualitySettings.set_shadowmaskModeDelegate set_shadowmaskModeDelegateField;

		// Token: 0x040003E6 RID: 998
		private static readonly QualitySettings.get_shadowNearPlaneOffsetDelegate get_shadowNearPlaneOffsetDelegateField;

		// Token: 0x040003E7 RID: 999
		private static readonly QualitySettings.set_shadowNearPlaneOffsetDelegate set_shadowNearPlaneOffsetDelegateField;

		// Token: 0x040003E8 RID: 1000
		private static readonly QualitySettings.get_shadowCascade2SplitDelegate get_shadowCascade2SplitDelegateField;

		// Token: 0x040003E9 RID: 1001
		private static readonly QualitySettings.set_shadowCascade2SplitDelegate set_shadowCascade2SplitDelegateField;

		// Token: 0x040003EA RID: 1002
		private static readonly QualitySettings.get_lodBiasDelegate get_lodBiasDelegateField;

		// Token: 0x040003EB RID: 1003
		private static readonly QualitySettings.set_lodBiasDelegate set_lodBiasDelegateField;

		// Token: 0x040003EC RID: 1004
		private static readonly QualitySettings.get_anisotropicFilteringDelegate get_anisotropicFilteringDelegateField;

		// Token: 0x040003ED RID: 1005
		private static readonly QualitySettings.set_anisotropicFilteringDelegate set_anisotropicFilteringDelegateField;

		// Token: 0x040003EE RID: 1006
		private static readonly QualitySettings.get_masterTextureLimitDelegate get_masterTextureLimitDelegateField;

		// Token: 0x040003EF RID: 1007
		private static readonly QualitySettings.set_masterTextureLimitDelegate set_masterTextureLimitDelegateField;

		// Token: 0x040003F0 RID: 1008
		private static readonly QualitySettings.get_maximumLODLevelDelegate get_maximumLODLevelDelegateField;

		// Token: 0x040003F1 RID: 1009
		private static readonly QualitySettings.set_maximumLODLevelDelegate set_maximumLODLevelDelegateField;

		// Token: 0x040003F2 RID: 1010
		private static readonly QualitySettings.get_particleRaycastBudgetDelegate get_particleRaycastBudgetDelegateField;

		// Token: 0x040003F3 RID: 1011
		private static readonly QualitySettings.set_particleRaycastBudgetDelegate set_particleRaycastBudgetDelegateField;

		// Token: 0x040003F4 RID: 1012
		private static readonly QualitySettings.get_softParticlesDelegate get_softParticlesDelegateField;

		// Token: 0x040003F5 RID: 1013
		private static readonly QualitySettings.set_softParticlesDelegate set_softParticlesDelegateField;

		// Token: 0x040003F6 RID: 1014
		private static readonly QualitySettings.get_softVegetationDelegate get_softVegetationDelegateField;

		// Token: 0x040003F7 RID: 1015
		private static readonly QualitySettings.set_softVegetationDelegate set_softVegetationDelegateField;

		// Token: 0x040003F8 RID: 1016
		private static readonly QualitySettings.set_vSyncCountDelegate set_vSyncCountDelegateField;

		// Token: 0x040003F9 RID: 1017
		private static readonly QualitySettings.get_antiAliasingDelegate get_antiAliasingDelegateField;

		// Token: 0x040003FA RID: 1018
		private static readonly QualitySettings.set_antiAliasingDelegate set_antiAliasingDelegateField;

		// Token: 0x040003FB RID: 1019
		private static readonly QualitySettings.get_asyncUploadTimeSliceDelegate get_asyncUploadTimeSliceDelegateField;

		// Token: 0x040003FC RID: 1020
		private static readonly QualitySettings.set_asyncUploadTimeSliceDelegate set_asyncUploadTimeSliceDelegateField;

		// Token: 0x040003FD RID: 1021
		private static readonly QualitySettings.get_asyncUploadBufferSizeDelegate get_asyncUploadBufferSizeDelegateField;

		// Token: 0x040003FE RID: 1022
		private static readonly QualitySettings.set_asyncUploadBufferSizeDelegate set_asyncUploadBufferSizeDelegateField;

		// Token: 0x040003FF RID: 1023
		private static readonly QualitySettings.get_asyncUploadPersistentBufferDelegate get_asyncUploadPersistentBufferDelegateField;

		// Token: 0x04000400 RID: 1024
		private static readonly QualitySettings.set_asyncUploadPersistentBufferDelegate set_asyncUploadPersistentBufferDelegateField;

		// Token: 0x04000401 RID: 1025
		private static readonly QualitySettings.SetLODSettingsDelegate SetLODSettingsDelegateField;

		// Token: 0x04000402 RID: 1026
		private static readonly QualitySettings.get_realtimeReflectionProbesDelegate get_realtimeReflectionProbesDelegateField;

		// Token: 0x04000403 RID: 1027
		private static readonly QualitySettings.set_realtimeReflectionProbesDelegate set_realtimeReflectionProbesDelegateField;

		// Token: 0x04000404 RID: 1028
		private static readonly QualitySettings.get_billboardsFaceCameraPositionDelegate get_billboardsFaceCameraPositionDelegateField;

		// Token: 0x04000405 RID: 1029
		private static readonly QualitySettings.set_billboardsFaceCameraPositionDelegate set_billboardsFaceCameraPositionDelegateField;

		// Token: 0x04000406 RID: 1030
		private static readonly QualitySettings.get_resolutionScalingFixedDPIFactorDelegate get_resolutionScalingFixedDPIFactorDelegateField;

		// Token: 0x04000407 RID: 1031
		private static readonly QualitySettings.set_resolutionScalingFixedDPIFactorDelegate set_resolutionScalingFixedDPIFactorDelegateField;

		// Token: 0x04000408 RID: 1032
		private static readonly QualitySettings.get_INTERNAL_renderPipelineDelegate get_INTERNAL_renderPipelineDelegateField;

		// Token: 0x04000409 RID: 1033
		private static readonly QualitySettings.set_INTERNAL_renderPipelineDelegate set_INTERNAL_renderPipelineDelegateField;

		// Token: 0x0400040A RID: 1034
		private static readonly QualitySettings.InternalGetRenderPipelineAssetAtDelegate InternalGetRenderPipelineAssetAtDelegateField;

		// Token: 0x0400040B RID: 1035
		private static readonly QualitySettings.get_blendWeightsDelegate get_blendWeightsDelegateField;

		// Token: 0x0400040C RID: 1036
		private static readonly QualitySettings.set_blendWeightsDelegate set_blendWeightsDelegateField;

		// Token: 0x0400040D RID: 1037
		private static readonly QualitySettings.get_skinWeightsDelegate get_skinWeightsDelegateField;

		// Token: 0x0400040E RID: 1038
		private static readonly QualitySettings.set_skinWeightsDelegate set_skinWeightsDelegateField;

		// Token: 0x0400040F RID: 1039
		private static readonly QualitySettings.get_streamingMipmapsActiveDelegate get_streamingMipmapsActiveDelegateField;

		// Token: 0x04000410 RID: 1040
		private static readonly QualitySettings.set_streamingMipmapsActiveDelegate set_streamingMipmapsActiveDelegateField;

		// Token: 0x04000411 RID: 1041
		private static readonly QualitySettings.get_streamingMipmapsMemoryBudgetDelegate get_streamingMipmapsMemoryBudgetDelegateField;

		// Token: 0x04000412 RID: 1042
		private static readonly QualitySettings.set_streamingMipmapsMemoryBudgetDelegate set_streamingMipmapsMemoryBudgetDelegateField;

		// Token: 0x04000413 RID: 1043
		private static readonly QualitySettings.get_streamingMipmapsRenderersPerFrameDelegate get_streamingMipmapsRenderersPerFrameDelegateField;

		// Token: 0x04000414 RID: 1044
		private static readonly QualitySettings.set_streamingMipmapsRenderersPerFrameDelegate set_streamingMipmapsRenderersPerFrameDelegateField;

		// Token: 0x04000415 RID: 1045
		private static readonly QualitySettings.get_streamingMipmapsMaxLevelReductionDelegate get_streamingMipmapsMaxLevelReductionDelegateField;

		// Token: 0x04000416 RID: 1046
		private static readonly QualitySettings.set_streamingMipmapsMaxLevelReductionDelegate set_streamingMipmapsMaxLevelReductionDelegateField;

		// Token: 0x04000417 RID: 1047
		private static readonly QualitySettings.get_streamingMipmapsAddAllCamerasDelegate get_streamingMipmapsAddAllCamerasDelegateField;

		// Token: 0x04000418 RID: 1048
		private static readonly QualitySettings.set_streamingMipmapsAddAllCamerasDelegate set_streamingMipmapsAddAllCamerasDelegateField;

		// Token: 0x04000419 RID: 1049
		private static readonly QualitySettings.get_streamingMipmapsMaxFileIORequestsDelegate get_streamingMipmapsMaxFileIORequestsDelegateField;

		// Token: 0x0400041A RID: 1050
		private static readonly QualitySettings.set_streamingMipmapsMaxFileIORequestsDelegate set_streamingMipmapsMaxFileIORequestsDelegateField;

		// Token: 0x0400041B RID: 1051
		private static readonly QualitySettings.get_maxQueuedFramesDelegate get_maxQueuedFramesDelegateField;

		// Token: 0x0400041C RID: 1052
		private static readonly QualitySettings.set_maxQueuedFramesDelegate set_maxQueuedFramesDelegateField;

		// Token: 0x0400041D RID: 1053
		private static readonly QualitySettings.GetQualityLevelDelegate GetQualityLevelDelegateField;

		// Token: 0x0400041E RID: 1054
		private static readonly QualitySettings.get_desiredColorSpaceDelegate get_desiredColorSpaceDelegateField;

		// Token: 0x0400041F RID: 1055
		private static readonly QualitySettings.get_shadowCascade4Split_InjectedDelegate get_shadowCascade4Split_InjectedDelegateField;

		// Token: 0x04000420 RID: 1056
		private static readonly QualitySettings.set_shadowCascade4Split_InjectedDelegate set_shadowCascade4Split_InjectedDelegateField;

		// Token: 0x020004A3 RID: 1187
		// (Invoke) Token: 0x06002715 RID: 10005
		private delegate int get_pixelLightCountDelegate();

		// Token: 0x020004A4 RID: 1188
		// (Invoke) Token: 0x06002717 RID: 10007
		private delegate void set_pixelLightCountDelegate(int value);

		// Token: 0x020004A5 RID: 1189
		// (Invoke) Token: 0x06002719 RID: 10009
		private delegate ShadowQuality get_shadowsDelegate();

		// Token: 0x020004A6 RID: 1190
		// (Invoke) Token: 0x0600271B RID: 10011
		private delegate void set_shadowsDelegate(ShadowQuality value);

		// Token: 0x020004A7 RID: 1191
		// (Invoke) Token: 0x0600271D RID: 10013
		private delegate ShadowProjection get_shadowProjectionDelegate();

		// Token: 0x020004A8 RID: 1192
		// (Invoke) Token: 0x0600271F RID: 10015
		private delegate void set_shadowProjectionDelegate(ShadowProjection value);

		// Token: 0x020004A9 RID: 1193
		// (Invoke) Token: 0x06002721 RID: 10017
		private delegate int get_shadowCascadesDelegate();

		// Token: 0x020004AA RID: 1194
		// (Invoke) Token: 0x06002723 RID: 10019
		private delegate void set_shadowCascadesDelegate(int value);

		// Token: 0x020004AB RID: 1195
		// (Invoke) Token: 0x06002725 RID: 10021
		private delegate float get_shadowDistanceDelegate();

		// Token: 0x020004AC RID: 1196
		// (Invoke) Token: 0x06002727 RID: 10023
		private delegate void set_shadowDistanceDelegate(float value);

		// Token: 0x020004AD RID: 1197
		// (Invoke) Token: 0x06002729 RID: 10025
		private delegate ShadowResolution get_shadowResolutionDelegate();

		// Token: 0x020004AE RID: 1198
		// (Invoke) Token: 0x0600272B RID: 10027
		private delegate void set_shadowResolutionDelegate(ShadowResolution value);

		// Token: 0x020004AF RID: 1199
		// (Invoke) Token: 0x0600272D RID: 10029
		private delegate ShadowmaskMode get_shadowmaskModeDelegate();

		// Token: 0x020004B0 RID: 1200
		// (Invoke) Token: 0x0600272F RID: 10031
		private delegate void set_shadowmaskModeDelegate(ShadowmaskMode value);

		// Token: 0x020004B1 RID: 1201
		// (Invoke) Token: 0x06002731 RID: 10033
		private delegate float get_shadowNearPlaneOffsetDelegate();

		// Token: 0x020004B2 RID: 1202
		// (Invoke) Token: 0x06002733 RID: 10035
		private delegate void set_shadowNearPlaneOffsetDelegate(float value);

		// Token: 0x020004B3 RID: 1203
		// (Invoke) Token: 0x06002735 RID: 10037
		private delegate float get_shadowCascade2SplitDelegate();

		// Token: 0x020004B4 RID: 1204
		// (Invoke) Token: 0x06002737 RID: 10039
		private delegate void set_shadowCascade2SplitDelegate(float value);

		// Token: 0x020004B5 RID: 1205
		// (Invoke) Token: 0x06002739 RID: 10041
		private delegate float get_lodBiasDelegate();

		// Token: 0x020004B6 RID: 1206
		// (Invoke) Token: 0x0600273B RID: 10043
		private delegate void set_lodBiasDelegate(float value);

		// Token: 0x020004B7 RID: 1207
		// (Invoke) Token: 0x0600273D RID: 10045
		private delegate AnisotropicFiltering get_anisotropicFilteringDelegate();

		// Token: 0x020004B8 RID: 1208
		// (Invoke) Token: 0x0600273F RID: 10047
		private delegate void set_anisotropicFilteringDelegate(AnisotropicFiltering value);

		// Token: 0x020004B9 RID: 1209
		// (Invoke) Token: 0x06002741 RID: 10049
		private delegate int get_masterTextureLimitDelegate();

		// Token: 0x020004BA RID: 1210
		// (Invoke) Token: 0x06002743 RID: 10051
		private delegate void set_masterTextureLimitDelegate(int value);

		// Token: 0x020004BB RID: 1211
		// (Invoke) Token: 0x06002745 RID: 10053
		private delegate int get_maximumLODLevelDelegate();

		// Token: 0x020004BC RID: 1212
		// (Invoke) Token: 0x06002747 RID: 10055
		private delegate void set_maximumLODLevelDelegate(int value);

		// Token: 0x020004BD RID: 1213
		// (Invoke) Token: 0x06002749 RID: 10057
		private delegate int get_particleRaycastBudgetDelegate();

		// Token: 0x020004BE RID: 1214
		// (Invoke) Token: 0x0600274B RID: 10059
		private delegate void set_particleRaycastBudgetDelegate(int value);

		// Token: 0x020004BF RID: 1215
		// (Invoke) Token: 0x0600274D RID: 10061
		private delegate bool get_softParticlesDelegate();

		// Token: 0x020004C0 RID: 1216
		// (Invoke) Token: 0x0600274F RID: 10063
		private delegate void set_softParticlesDelegate(bool value);

		// Token: 0x020004C1 RID: 1217
		// (Invoke) Token: 0x06002751 RID: 10065
		private delegate bool get_softVegetationDelegate();

		// Token: 0x020004C2 RID: 1218
		// (Invoke) Token: 0x06002753 RID: 10067
		private delegate void set_softVegetationDelegate(bool value);

		// Token: 0x020004C3 RID: 1219
		// (Invoke) Token: 0x06002755 RID: 10069
		private delegate void set_vSyncCountDelegate(int value);

		// Token: 0x020004C4 RID: 1220
		// (Invoke) Token: 0x06002757 RID: 10071
		private delegate int get_antiAliasingDelegate();

		// Token: 0x020004C5 RID: 1221
		// (Invoke) Token: 0x06002759 RID: 10073
		private delegate void set_antiAliasingDelegate(int value);

		// Token: 0x020004C6 RID: 1222
		// (Invoke) Token: 0x0600275B RID: 10075
		private delegate int get_asyncUploadTimeSliceDelegate();

		// Token: 0x020004C7 RID: 1223
		// (Invoke) Token: 0x0600275D RID: 10077
		private delegate void set_asyncUploadTimeSliceDelegate(int value);

		// Token: 0x020004C8 RID: 1224
		// (Invoke) Token: 0x0600275F RID: 10079
		private delegate int get_asyncUploadBufferSizeDelegate();

		// Token: 0x020004C9 RID: 1225
		// (Invoke) Token: 0x06002761 RID: 10081
		private delegate void set_asyncUploadBufferSizeDelegate(int value);

		// Token: 0x020004CA RID: 1226
		// (Invoke) Token: 0x06002763 RID: 10083
		private delegate bool get_asyncUploadPersistentBufferDelegate();

		// Token: 0x020004CB RID: 1227
		// (Invoke) Token: 0x06002765 RID: 10085
		private delegate void set_asyncUploadPersistentBufferDelegate(bool value);

		// Token: 0x020004CC RID: 1228
		// (Invoke) Token: 0x06002767 RID: 10087
		private delegate void SetLODSettingsDelegate(float lodBias, int maximumLODLevel, bool setDirty);

		// Token: 0x020004CD RID: 1229
		// (Invoke) Token: 0x06002769 RID: 10089
		private delegate bool get_realtimeReflectionProbesDelegate();

		// Token: 0x020004CE RID: 1230
		// (Invoke) Token: 0x0600276B RID: 10091
		private delegate void set_realtimeReflectionProbesDelegate(bool value);

		// Token: 0x020004CF RID: 1231
		// (Invoke) Token: 0x0600276D RID: 10093
		private delegate bool get_billboardsFaceCameraPositionDelegate();

		// Token: 0x020004D0 RID: 1232
		// (Invoke) Token: 0x0600276F RID: 10095
		private delegate void set_billboardsFaceCameraPositionDelegate(bool value);

		// Token: 0x020004D1 RID: 1233
		// (Invoke) Token: 0x06002771 RID: 10097
		private delegate float get_resolutionScalingFixedDPIFactorDelegate();

		// Token: 0x020004D2 RID: 1234
		// (Invoke) Token: 0x06002773 RID: 10099
		private delegate void set_resolutionScalingFixedDPIFactorDelegate(float value);

		// Token: 0x020004D3 RID: 1235
		// (Invoke) Token: 0x06002775 RID: 10101
		private delegate IntPtr get_INTERNAL_renderPipelineDelegate();

		// Token: 0x020004D4 RID: 1236
		// (Invoke) Token: 0x06002777 RID: 10103
		private delegate void set_INTERNAL_renderPipelineDelegate(IntPtr value);

		// Token: 0x020004D5 RID: 1237
		// (Invoke) Token: 0x06002779 RID: 10105
		private delegate IntPtr InternalGetRenderPipelineAssetAtDelegate(int index);

		// Token: 0x020004D6 RID: 1238
		// (Invoke) Token: 0x0600277B RID: 10107
		private delegate BlendWeights get_blendWeightsDelegate();

		// Token: 0x020004D7 RID: 1239
		// (Invoke) Token: 0x0600277D RID: 10109
		private delegate void set_blendWeightsDelegate(BlendWeights value);

		// Token: 0x020004D8 RID: 1240
		// (Invoke) Token: 0x0600277F RID: 10111
		private delegate SkinWeights get_skinWeightsDelegate();

		// Token: 0x020004D9 RID: 1241
		// (Invoke) Token: 0x06002781 RID: 10113
		private delegate void set_skinWeightsDelegate(SkinWeights value);

		// Token: 0x020004DA RID: 1242
		// (Invoke) Token: 0x06002783 RID: 10115
		private delegate bool get_streamingMipmapsActiveDelegate();

		// Token: 0x020004DB RID: 1243
		// (Invoke) Token: 0x06002785 RID: 10117
		private delegate void set_streamingMipmapsActiveDelegate(bool value);

		// Token: 0x020004DC RID: 1244
		// (Invoke) Token: 0x06002787 RID: 10119
		private delegate float get_streamingMipmapsMemoryBudgetDelegate();

		// Token: 0x020004DD RID: 1245
		// (Invoke) Token: 0x06002789 RID: 10121
		private delegate void set_streamingMipmapsMemoryBudgetDelegate(float value);

		// Token: 0x020004DE RID: 1246
		// (Invoke) Token: 0x0600278B RID: 10123
		private delegate int get_streamingMipmapsRenderersPerFrameDelegate();

		// Token: 0x020004DF RID: 1247
		// (Invoke) Token: 0x0600278D RID: 10125
		private delegate void set_streamingMipmapsRenderersPerFrameDelegate(int value);

		// Token: 0x020004E0 RID: 1248
		// (Invoke) Token: 0x0600278F RID: 10127
		private delegate int get_streamingMipmapsMaxLevelReductionDelegate();

		// Token: 0x020004E1 RID: 1249
		// (Invoke) Token: 0x06002791 RID: 10129
		private delegate void set_streamingMipmapsMaxLevelReductionDelegate(int value);

		// Token: 0x020004E2 RID: 1250
		// (Invoke) Token: 0x06002793 RID: 10131
		private delegate bool get_streamingMipmapsAddAllCamerasDelegate();

		// Token: 0x020004E3 RID: 1251
		// (Invoke) Token: 0x06002795 RID: 10133
		private delegate void set_streamingMipmapsAddAllCamerasDelegate(bool value);

		// Token: 0x020004E4 RID: 1252
		// (Invoke) Token: 0x06002797 RID: 10135
		private delegate int get_streamingMipmapsMaxFileIORequestsDelegate();

		// Token: 0x020004E5 RID: 1253
		// (Invoke) Token: 0x06002799 RID: 10137
		private delegate void set_streamingMipmapsMaxFileIORequestsDelegate(int value);

		// Token: 0x020004E6 RID: 1254
		// (Invoke) Token: 0x0600279B RID: 10139
		private delegate int get_maxQueuedFramesDelegate();

		// Token: 0x020004E7 RID: 1255
		// (Invoke) Token: 0x0600279D RID: 10141
		private delegate void set_maxQueuedFramesDelegate(int value);

		// Token: 0x020004E8 RID: 1256
		// (Invoke) Token: 0x0600279F RID: 10143
		private delegate int GetQualityLevelDelegate();

		// Token: 0x020004E9 RID: 1257
		// (Invoke) Token: 0x060027A1 RID: 10145
		private delegate ColorSpace get_desiredColorSpaceDelegate();

		// Token: 0x020004EA RID: 1258
		// (Invoke) Token: 0x060027A3 RID: 10147
		private delegate void get_shadowCascade4Split_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x020004EB RID: 1259
		// (Invoke) Token: 0x060027A5 RID: 10149
		private delegate void set_shadowCascade4Split_InjectedDelegate(IntPtr value);
	}
}
