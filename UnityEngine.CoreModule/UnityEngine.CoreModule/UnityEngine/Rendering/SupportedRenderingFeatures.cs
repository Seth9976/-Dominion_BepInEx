using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000146 RID: 326
	public class SupportedRenderingFeatures : Object
	{
		// Token: 0x060018B3 RID: 6323 RVA: 0x0005B16C File Offset: 0x0005936C
		// Note: this type is marked as 'beforefieldinit'.
		static SupportedRenderingFeatures()
		{
			Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SupportedRenderingFeatures");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr);
			SupportedRenderingFeatures.NativeFieldInfoPtr_s_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "s_Active");
			SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbeModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbeModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<defaultMixedLightingModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__mixedLightingModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<mixedLightingModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightmapBakeTypes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapsModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightmapsModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__enlighten_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<enlighten>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightProbeProxyVolumes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__motionVectors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<motionVectors>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__receiveShadows_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<receiveShadows>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__rendererPriority_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendererPriority>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__terrainDetailUnsupported_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<terrainDetailUnsupported>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__rendersUIOverlay_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendersUIOverlay>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesEnvironmentLighting>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesFog_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesFog>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesRealtimeReflectionProbes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesOtherLightingSettings>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<editableMaterialRenderQueue>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLODBias_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesLODBias>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesMaximumLODLevel>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__rendererProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendererProbes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__particleSystemInstancing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<particleSystemInstancing>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<autoAmbientProbeBaking>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<autoDefaultReflectionProbeBaking>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesShadowmask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesShadowmask>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overrideShadowmaskMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overrideShadowmaskMessage>k__BackingField");
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665152);
			SupportedRenderingFeatures.NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665153);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665154);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665155);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665156);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665157);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665158);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665159);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoAmbientProbeBaking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665160);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoDefaultReflectionProbeBaking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665161);
			SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665162);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665163);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665164);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665165);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665166);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665167);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665168);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665169);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665170);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665171);
			SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665172);
			SupportedRenderingFeatures.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665173);
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x0005B570 File Offset: 0x00059770
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x0005B5A4 File Offset: 0x000597A4
		public unsafe static SupportedRenderingFeatures active
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 82545, RefRangeEnd = 82565, XrefRangeStart = 82533, XrefRangeEnd = 82545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SupportedRenderingFeatures>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82565, XrefRangeEnd = 82569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x0005B5DC File Offset: 0x000597DC
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x0000DFF7 File Offset: 0x0000C1F7
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._defaultMixedLightingModes_k__BackingField = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x0005B618 File Offset: 0x00059818
		// (set) Token: 0x06001904 RID: 6404 RVA: 0x0000E000 File Offset: 0x0000C200
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._mixedLightingModes_k__BackingField = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x0005B654 File Offset: 0x00059854
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x0000E009 File Offset: 0x0000C209
		public unsafe LightmapBakeType lightmapBakeTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._lightmapBakeTypes_k__BackingField = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x0005B690 File Offset: 0x00059890
		// (set) Token: 0x06001906 RID: 6406 RVA: 0x0000E012 File Offset: 0x0000C212
		public unsafe LightmapsMode lightmapsModes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._lightmapsModes_k__BackingField = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x0005B6CC File Offset: 0x000598CC
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x0000E01B File Offset: 0x0000C21B
		public unsafe bool enlighten
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._enlighten_k__BackingField = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x0005B708 File Offset: 0x00059908
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x0000E08A File Offset: 0x0000C28A
		public unsafe bool rendersUIOverlay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._rendersUIOverlay_k__BackingField = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x0005B744 File Offset: 0x00059944
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x0000E12C File Offset: 0x0000C32C
		public unsafe bool autoAmbientProbeBaking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoAmbientProbeBaking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._autoAmbientProbeBaking_k__BackingField = value;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060018BD RID: 6333 RVA: 0x0005B780 File Offset: 0x00059980
		// (set) Token: 0x06001928 RID: 6440 RVA: 0x0000E135 File Offset: 0x0000C335
		public unsafe bool autoDefaultReflectionProbeBaking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoDefaultReflectionProbeBaking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._autoDefaultReflectionProbeBaking_k__BackingField = value;
			}
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0005B7BC File Offset: 0x000599BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82569, XrefRangeEnd = 82582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fallbackModePtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0005B7F0 File Offset: 0x000599F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82582, XrefRangeEnd = 82603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mixedMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x0005B830 File Offset: 0x00059A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82603, XrefRangeEnd = 82611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mixedMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x0005B870 File Offset: 0x00059A70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 82628, RefRangeEnd = 82632, XrefRangeStart = 82611, XrefRangeEnd = 82628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bakeType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0005B8B0 File Offset: 0x00059AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82632, XrefRangeEnd = 82646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bakeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x0005B8F0 File Offset: 0x00059AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82646, XrefRangeEnd = 82651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x0005B930 File Offset: 0x00059B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82651, XrefRangeEnd = 82656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lightmapper;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x0005B970 File Offset: 0x00059B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82656, XrefRangeEnd = 82661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isSupportedPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0005B9A4 File Offset: 0x00059BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82661, XrefRangeEnd = 82666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isSupportedPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0005B9D8 File Offset: 0x00059BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82666, XrefRangeEnd = 82671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isSupportedPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x0005BA0C File Offset: 0x00059C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82671, XrefRangeEnd = 82672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FallbackLightmapperByRef(IntPtr lightmapperPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lightmapperPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x0005BA40 File Offset: 0x00059C40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82675, RefRangeEnd = 82677, XrefRangeStart = 82672, XrefRangeEnd = 82675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupportedRenderingFeatures()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x0000DD09 File Offset: 0x0000BF09
		public SupportedRenderingFeatures(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x0005BA7C File Offset: 0x00059C7C
		// (set) Token: 0x060018CC RID: 6348 RVA: 0x0000DD12 File Offset: 0x0000BF12
		public unsafe static SupportedRenderingFeatures s_Active
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SupportedRenderingFeatures.NativeFieldInfoPtr_s_Active, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SupportedRenderingFeatures>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SupportedRenderingFeatures.NativeFieldInfoPtr_s_Active, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x0005BAA4 File Offset: 0x00059CA4
		// (set) Token: 0x060018CE RID: 6350 RVA: 0x0000DD24 File Offset: 0x0000BF24
		public unsafe SupportedRenderingFeatures.ReflectionProbeModes _reflectionProbeModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbeModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbeModes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060018CF RID: 6351 RVA: 0x0005BACC File Offset: 0x00059CCC
		// (set) Token: 0x060018D0 RID: 6352 RVA: 0x0000DD3F File Offset: 0x0000BF3F
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes _defaultMixedLightingModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x0005BAF4 File Offset: 0x00059CF4
		// (set) Token: 0x060018D2 RID: 6354 RVA: 0x0000DD5A File Offset: 0x0000BF5A
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes _mixedLightingModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__mixedLightingModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__mixedLightingModes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060018D3 RID: 6355 RVA: 0x0005BB1C File Offset: 0x00059D1C
		// (set) Token: 0x060018D4 RID: 6356 RVA: 0x0000DD75 File Offset: 0x0000BF75
		public unsafe LightmapBakeType _lightmapBakeTypes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060018D5 RID: 6357 RVA: 0x0005BB44 File Offset: 0x00059D44
		// (set) Token: 0x060018D6 RID: 6358 RVA: 0x0000DD90 File Offset: 0x0000BF90
		public unsafe LightmapsMode _lightmapsModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapsModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapsModes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060018D7 RID: 6359 RVA: 0x0005BB6C File Offset: 0x00059D6C
		// (set) Token: 0x060018D8 RID: 6360 RVA: 0x0000DDAB File Offset: 0x0000BFAB
		public unsafe bool _enlighten_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlighten_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlighten_k__BackingField)) = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x0005BB94 File Offset: 0x00059D94
		// (set) Token: 0x060018DA RID: 6362 RVA: 0x0000DDC6 File Offset: 0x0000BFC6
		public unsafe bool _lightProbeProxyVolumes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x0005BBBC File Offset: 0x00059DBC
		// (set) Token: 0x060018DC RID: 6364 RVA: 0x0000DDE1 File Offset: 0x0000BFE1
		public unsafe bool _motionVectors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__motionVectors_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__motionVectors_k__BackingField)) = value;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060018DD RID: 6365 RVA: 0x0005BBE4 File Offset: 0x00059DE4
		// (set) Token: 0x060018DE RID: 6366 RVA: 0x0000DDFC File Offset: 0x0000BFFC
		public unsafe bool _receiveShadows_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__receiveShadows_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__receiveShadows_k__BackingField)) = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060018DF RID: 6367 RVA: 0x0005BC0C File Offset: 0x00059E0C
		// (set) Token: 0x060018E0 RID: 6368 RVA: 0x0000DE17 File Offset: 0x0000C017
		public unsafe bool _reflectionProbes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbes_k__BackingField)) = value;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060018E1 RID: 6369 RVA: 0x0005BC34 File Offset: 0x00059E34
		// (set) Token: 0x060018E2 RID: 6370 RVA: 0x0000DE32 File Offset: 0x0000C032
		public unsafe bool _rendererPriority_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererPriority_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererPriority_k__BackingField)) = value;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x0005BC5C File Offset: 0x00059E5C
		// (set) Token: 0x060018E4 RID: 6372 RVA: 0x0000DE4D File Offset: 0x0000C04D
		public unsafe bool _terrainDetailUnsupported_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__terrainDetailUnsupported_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__terrainDetailUnsupported_k__BackingField)) = value;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x0005BC84 File Offset: 0x00059E84
		// (set) Token: 0x060018E6 RID: 6374 RVA: 0x0000DE68 File Offset: 0x0000C068
		public unsafe bool _rendersUIOverlay_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendersUIOverlay_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendersUIOverlay_k__BackingField)) = value;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x0005BCAC File Offset: 0x00059EAC
		// (set) Token: 0x060018E8 RID: 6376 RVA: 0x0000DE83 File Offset: 0x0000C083
		public unsafe bool _overridesEnvironmentLighting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField)) = value;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x0005BCD4 File Offset: 0x00059ED4
		// (set) Token: 0x060018EA RID: 6378 RVA: 0x0000DE9E File Offset: 0x0000C09E
		public unsafe bool _overridesFog_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesFog_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesFog_k__BackingField)) = value;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x0005BCFC File Offset: 0x00059EFC
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x0000DEB9 File Offset: 0x0000C0B9
		public unsafe bool _overridesRealtimeReflectionProbes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x0005BD24 File Offset: 0x00059F24
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x0000DED4 File Offset: 0x0000C0D4
		public unsafe bool _overridesOtherLightingSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField)) = value;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x0005BD4C File Offset: 0x00059F4C
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x0000DEEF File Offset: 0x0000C0EF
		public unsafe bool _editableMaterialRenderQueue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField)) = value;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x0005BD74 File Offset: 0x00059F74
		// (set) Token: 0x060018F2 RID: 6386 RVA: 0x0000DF0A File Offset: 0x0000C10A
		public unsafe bool _overridesLODBias_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLODBias_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLODBias_k__BackingField)) = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x0005BD9C File Offset: 0x00059F9C
		// (set) Token: 0x060018F4 RID: 6388 RVA: 0x0000DF25 File Offset: 0x0000C125
		public unsafe bool _overridesMaximumLODLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x0005BDC4 File Offset: 0x00059FC4
		// (set) Token: 0x060018F6 RID: 6390 RVA: 0x0000DF40 File Offset: 0x0000C140
		public unsafe bool _rendererProbes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererProbes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererProbes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x0005BDEC File Offset: 0x00059FEC
		// (set) Token: 0x060018F8 RID: 6392 RVA: 0x0000DF5B File Offset: 0x0000C15B
		public unsafe bool _particleSystemInstancing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__particleSystemInstancing_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__particleSystemInstancing_k__BackingField)) = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x0005BE14 File Offset: 0x0005A014
		// (set) Token: 0x060018FA RID: 6394 RVA: 0x0000DF76 File Offset: 0x0000C176
		public unsafe bool _autoAmbientProbeBaking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField)) = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x0005BE3C File Offset: 0x0005A03C
		// (set) Token: 0x060018FC RID: 6396 RVA: 0x0000DF91 File Offset: 0x0000C191
		public unsafe bool _autoDefaultReflectionProbeBaking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField)) = value;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x0005BE64 File Offset: 0x0005A064
		// (set) Token: 0x060018FE RID: 6398 RVA: 0x0000DFAC File Offset: 0x0000C1AC
		public unsafe bool _overridesShadowmask_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesShadowmask_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesShadowmask_k__BackingField)) = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060018FF RID: 6399 RVA: 0x0005BE8C File Offset: 0x0005A08C
		// (set) Token: 0x06001900 RID: 6400 RVA: 0x0000DFC7 File Offset: 0x0000C1C7
		public unsafe string _overrideShadowmaskMessage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overrideShadowmaskMessage_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overrideShadowmaskMessage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x0000DFE6 File Offset: 0x0000C1E6
		// (set) Token: 0x06001902 RID: 6402 RVA: 0x0000DFEE File Offset: 0x0000C1EE
		public SupportedRenderingFeatures.ReflectionProbeModes reflectionProbeModes
		{
			get
			{
				return this._reflectionProbeModes_k__BackingField;
			}
			set
			{
				this._reflectionProbeModes_k__BackingField = value;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x0000E024 File Offset: 0x0000C224
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x0000E02C File Offset: 0x0000C22C
		public bool lightProbeProxyVolumes
		{
			get
			{
				return this._lightProbeProxyVolumes_k__BackingField;
			}
			set
			{
				this._lightProbeProxyVolumes_k__BackingField = value;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x0000E035 File Offset: 0x0000C235
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x0000E03D File Offset: 0x0000C23D
		public bool motionVectors
		{
			get
			{
				return this._motionVectors_k__BackingField;
			}
			set
			{
				this._motionVectors_k__BackingField = value;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x0000E046 File Offset: 0x0000C246
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x0000E04E File Offset: 0x0000C24E
		public bool receiveShadows
		{
			get
			{
				return this._receiveShadows_k__BackingField;
			}
			set
			{
				this._receiveShadows_k__BackingField = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x0000E057 File Offset: 0x0000C257
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x0000E05F File Offset: 0x0000C25F
		public bool reflectionProbes
		{
			get
			{
				return this._reflectionProbes_k__BackingField;
			}
			set
			{
				this._reflectionProbes_k__BackingField = value;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x0000E068 File Offset: 0x0000C268
		// (set) Token: 0x06001911 RID: 6417 RVA: 0x0000E070 File Offset: 0x0000C270
		public bool rendererPriority
		{
			get
			{
				return this._rendererPriority_k__BackingField;
			}
			set
			{
				this._rendererPriority_k__BackingField = value;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x0000E079 File Offset: 0x0000C279
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x0000E081 File Offset: 0x0000C281
		public bool terrainDetailUnsupported
		{
			get
			{
				return this._terrainDetailUnsupported_k__BackingField;
			}
			set
			{
				this._terrainDetailUnsupported_k__BackingField = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x0000E093 File Offset: 0x0000C293
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x0000E09B File Offset: 0x0000C29B
		public bool overridesEnvironmentLighting
		{
			get
			{
				return this._overridesEnvironmentLighting_k__BackingField;
			}
			set
			{
				this._overridesEnvironmentLighting_k__BackingField = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x0000E0A4 File Offset: 0x0000C2A4
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x0000E0AC File Offset: 0x0000C2AC
		public bool overridesFog
		{
			get
			{
				return this._overridesFog_k__BackingField;
			}
			set
			{
				this._overridesFog_k__BackingField = value;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x0000E0B5 File Offset: 0x0000C2B5
		// (set) Token: 0x0600191A RID: 6426 RVA: 0x0000E0BD File Offset: 0x0000C2BD
		public bool overridesRealtimeReflectionProbes
		{
			get
			{
				return this._overridesRealtimeReflectionProbes_k__BackingField;
			}
			set
			{
				this._overridesRealtimeReflectionProbes_k__BackingField = value;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x0000E0C6 File Offset: 0x0000C2C6
		// (set) Token: 0x0600191C RID: 6428 RVA: 0x0000E0CE File Offset: 0x0000C2CE
		public bool overridesOtherLightingSettings
		{
			get
			{
				return this._overridesOtherLightingSettings_k__BackingField;
			}
			set
			{
				this._overridesOtherLightingSettings_k__BackingField = value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x0000E0D7 File Offset: 0x0000C2D7
		// (set) Token: 0x0600191E RID: 6430 RVA: 0x0000E0DF File Offset: 0x0000C2DF
		public bool editableMaterialRenderQueue
		{
			get
			{
				return this._editableMaterialRenderQueue_k__BackingField;
			}
			set
			{
				this._editableMaterialRenderQueue_k__BackingField = value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		// (set) Token: 0x06001920 RID: 6432 RVA: 0x0000E0F0 File Offset: 0x0000C2F0
		public bool overridesLODBias
		{
			get
			{
				return this._overridesLODBias_k__BackingField;
			}
			set
			{
				this._overridesLODBias_k__BackingField = value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x0000E0F9 File Offset: 0x0000C2F9
		// (set) Token: 0x06001922 RID: 6434 RVA: 0x0000E101 File Offset: 0x0000C301
		public bool overridesMaximumLODLevel
		{
			get
			{
				return this._overridesMaximumLODLevel_k__BackingField;
			}
			set
			{
				this._overridesMaximumLODLevel_k__BackingField = value;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x0000E10A File Offset: 0x0000C30A
		// (set) Token: 0x06001924 RID: 6436 RVA: 0x0000E112 File Offset: 0x0000C312
		public bool rendererProbes
		{
			get
			{
				return this._rendererProbes_k__BackingField;
			}
			set
			{
				this._rendererProbes_k__BackingField = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x0000E11B File Offset: 0x0000C31B
		// (set) Token: 0x06001926 RID: 6438 RVA: 0x0000E123 File Offset: 0x0000C323
		public bool particleSystemInstancing
		{
			get
			{
				return this._particleSystemInstancing_k__BackingField;
			}
			set
			{
				this._particleSystemInstancing_k__BackingField = value;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x0000E13E File Offset: 0x0000C33E
		// (set) Token: 0x0600192A RID: 6442 RVA: 0x0000E146 File Offset: 0x0000C346
		public bool overridesShadowmask
		{
			get
			{
				return this._overridesShadowmask_k__BackingField;
			}
			set
			{
				this._overridesShadowmask_k__BackingField = value;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x0000E14F File Offset: 0x0000C34F
		// (set) Token: 0x0600192C RID: 6444 RVA: 0x0000E157 File Offset: 0x0000C357
		public string overrideShadowmaskMessage
		{
			get
			{
				return this._overrideShadowmaskMessage_k__BackingField;
			}
			set
			{
				this._overrideShadowmaskMessage_k__BackingField = value;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x0005BEB4 File Offset: 0x0005A0B4
		public string shadowmaskMessage
		{
			get
			{
				bool flag = !this.overridesShadowmask;
				string text;
				if (flag)
				{
					text = "The Shadowmask Mode used at run time can be set in the Quality Settings panel.";
				}
				else
				{
					text = this.overrideShadowmaskMessage;
				}
				return text;
			}
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x0005BEE4 File Offset: 0x0005A0E4
		public unsafe static MixedLightingMode FallbackMixedLightingMode()
		{
			MixedLightingMode mixedLightingMode;
			SupportedRenderingFeatures.FallbackMixedLightingModeByRef(new IntPtr((void*)(&mixedLightingMode)));
			return mixedLightingMode;
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x0005BF08 File Offset: 0x0005A108
		public unsafe static bool IsLightmapsModeSupported(LightmapsMode mode)
		{
			bool flag;
			SupportedRenderingFeatures.IsLightmapsModeSupportedByRef(mode, new IntPtr((void*)(&flag)));
			return flag;
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x0005BF2C File Offset: 0x0005A12C
		public unsafe static bool IsLightmapperSupported(int lightmapper)
		{
			bool flag;
			SupportedRenderingFeatures.IsLightmapperSupportedByRef(lightmapper, new IntPtr((void*)(&flag)));
			return flag;
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x0005BF50 File Offset: 0x0005A150
		public unsafe static int FallbackLightmapper()
		{
			int num;
			SupportedRenderingFeatures.FallbackLightmapperByRef(new IntPtr((void*)(&num)));
			return num;
		}

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeFieldInfoPtr_s_Active;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeFieldInfoPtr__reflectionProbeModes_k__BackingField;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeFieldInfoPtr__mixedLightingModes_k__BackingField;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeFieldInfoPtr__lightmapsModes_k__BackingField;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeFieldInfoPtr__enlighten_k__BackingField;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeFieldInfoPtr__motionVectors_k__BackingField;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeFieldInfoPtr__receiveShadows_k__BackingField;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeFieldInfoPtr__reflectionProbes_k__BackingField;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeFieldInfoPtr__rendererPriority_k__BackingField;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeFieldInfoPtr__terrainDetailUnsupported_k__BackingField;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeFieldInfoPtr__rendersUIOverlay_k__BackingField;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeFieldInfoPtr__overridesFog_k__BackingField;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeFieldInfoPtr__overridesLODBias_k__BackingField;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeFieldInfoPtr__rendererProbes_k__BackingField;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeFieldInfoPtr__particleSystemInstancing_k__BackingField;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeFieldInfoPtr__overridesShadowmask_k__BackingField;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeFieldInfoPtr__overrideShadowmaskMessage_k__BackingField;

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_get_autoAmbientProbeBaking_Public_get_Boolean_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_get_autoDefaultReflectionProbeBaking_Public_get_Boolean_0;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeMethodInfoPtr_IsAutoAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeMethodInfoPtr_IsAutoDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009AA RID: 2474
		[Flags]
		public enum ReflectionProbeModes
		{
			// Token: 0x04001D24 RID: 7460
			None = 0,
			// Token: 0x04001D25 RID: 7461
			Rotation = 1
		}

		// Token: 0x020009AB RID: 2475
		[Flags]
		public enum LightmapMixedBakeModes
		{
			// Token: 0x04001D27 RID: 7463
			None = 0,
			// Token: 0x04001D28 RID: 7464
			IndirectOnly = 1,
			// Token: 0x04001D29 RID: 7465
			Subtractive = 2,
			// Token: 0x04001D2A RID: 7466
			Shadowmask = 4
		}
	}
}
