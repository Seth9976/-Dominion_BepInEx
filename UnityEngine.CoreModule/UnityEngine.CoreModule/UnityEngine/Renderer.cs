using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000053 RID: 83
	public class Renderer : Component
	{
		// Token: 0x06000678 RID: 1656 RVA: 0x0002514C File Offset: 0x0002334C
		// Note: this type is marked as 'beforefieldinit'.
		static Renderer()
		{
			Il2CppClassPointerStore<Renderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Renderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Renderer>.NativeClassPtr);
			Renderer.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663621);
			Renderer.NativeMethodInfoPtr_GetMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663622);
			Renderer.NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663623);
			Renderer.NativeMethodInfoPtr_SetMaterial_Private_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663624);
			Renderer.NativeMethodInfoPtr_GetMaterialArray_Private_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663625);
			Renderer.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663626);
			Renderer.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663627);
			Renderer.NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663628);
			Renderer.NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663629);
			Renderer.NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663630);
			Renderer.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663631);
			Renderer.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663632);
			Renderer.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663633);
			Renderer.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663634);
			Renderer.NativeMethodInfoPtr_get_materials_Public_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663635);
			Renderer.NativeMethodInfoPtr_get_material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663636);
			Renderer.NativeMethodInfoPtr_set_material_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663637);
			Renderer.NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663638);
			Renderer.NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663639);
			Renderer.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663640);
			Renderer.CopyMaterialArrayDelegateField = IL2CPP.ResolveICall<Renderer.CopyMaterialArrayDelegate>("UnityEngine.Renderer::CopyMaterialArray");
			Renderer.CopySharedMaterialArrayDelegateField = IL2CPP.ResolveICall<Renderer.CopySharedMaterialArrayDelegate>("UnityEngine.Renderer::CopySharedMaterialArray");
			Renderer.SetMaterialArrayDelegateField = IL2CPP.ResolveICall<Renderer.SetMaterialArrayDelegate>("UnityEngine.Renderer::SetMaterialArray");
			Renderer.Internal_SetPropertyBlockDelegateField = IL2CPP.ResolveICall<Renderer.Internal_SetPropertyBlockDelegate>("UnityEngine.Renderer::Internal_SetPropertyBlock");
			Renderer.Internal_GetPropertyBlockDelegateField = IL2CPP.ResolveICall<Renderer.Internal_GetPropertyBlockDelegate>("UnityEngine.Renderer::Internal_GetPropertyBlock");
			Renderer.Internal_SetPropertyBlockMaterialIndexDelegateField = IL2CPP.ResolveICall<Renderer.Internal_SetPropertyBlockMaterialIndexDelegate>("UnityEngine.Renderer::Internal_SetPropertyBlockMaterialIndex");
			Renderer.Internal_GetPropertyBlockMaterialIndexDelegateField = IL2CPP.ResolveICall<Renderer.Internal_GetPropertyBlockMaterialIndexDelegate>("UnityEngine.Renderer::Internal_GetPropertyBlockMaterialIndex");
			Renderer.HasPropertyBlockDelegateField = IL2CPP.ResolveICall<Renderer.HasPropertyBlockDelegate>("UnityEngine.Renderer::HasPropertyBlock");
			Renderer.GetClosestReflectionProbesInternalDelegateField = IL2CPP.ResolveICall<Renderer.GetClosestReflectionProbesInternalDelegate>("UnityEngine.Renderer::GetClosestReflectionProbesInternal");
			Renderer.get_shadowCastingModeDelegateField = IL2CPP.ResolveICall<Renderer.get_shadowCastingModeDelegate>("UnityEngine.Renderer::get_shadowCastingMode");
			Renderer.get_receiveShadowsDelegateField = IL2CPP.ResolveICall<Renderer.get_receiveShadowsDelegate>("UnityEngine.Renderer::get_receiveShadows");
			Renderer.get_forceRenderingOffDelegateField = IL2CPP.ResolveICall<Renderer.get_forceRenderingOffDelegate>("UnityEngine.Renderer::get_forceRenderingOff");
			Renderer.set_forceRenderingOffDelegateField = IL2CPP.ResolveICall<Renderer.set_forceRenderingOffDelegate>("UnityEngine.Renderer::set_forceRenderingOff");
			Renderer.GetIsStaticShadowCasterDelegateField = IL2CPP.ResolveICall<Renderer.GetIsStaticShadowCasterDelegate>("UnityEngine.Renderer::GetIsStaticShadowCaster");
			Renderer.SetIsStaticShadowCasterDelegateField = IL2CPP.ResolveICall<Renderer.SetIsStaticShadowCasterDelegate>("UnityEngine.Renderer::SetIsStaticShadowCaster");
			Renderer.get_motionVectorGenerationModeDelegateField = IL2CPP.ResolveICall<Renderer.get_motionVectorGenerationModeDelegate>("UnityEngine.Renderer::get_motionVectorGenerationMode");
			Renderer.set_motionVectorGenerationModeDelegateField = IL2CPP.ResolveICall<Renderer.set_motionVectorGenerationModeDelegate>("UnityEngine.Renderer::set_motionVectorGenerationMode");
			Renderer.get_lightProbeUsageDelegateField = IL2CPP.ResolveICall<Renderer.get_lightProbeUsageDelegate>("UnityEngine.Renderer::get_lightProbeUsage");
			Renderer.set_lightProbeUsageDelegateField = IL2CPP.ResolveICall<Renderer.set_lightProbeUsageDelegate>("UnityEngine.Renderer::set_lightProbeUsage");
			Renderer.get_reflectionProbeUsageDelegateField = IL2CPP.ResolveICall<Renderer.get_reflectionProbeUsageDelegate>("UnityEngine.Renderer::get_reflectionProbeUsage");
			Renderer.set_reflectionProbeUsageDelegateField = IL2CPP.ResolveICall<Renderer.set_reflectionProbeUsageDelegate>("UnityEngine.Renderer::set_reflectionProbeUsage");
			Renderer.get_renderingLayerMaskDelegateField = IL2CPP.ResolveICall<Renderer.get_renderingLayerMaskDelegate>("UnityEngine.Renderer::get_renderingLayerMask");
			Renderer.set_renderingLayerMaskDelegateField = IL2CPP.ResolveICall<Renderer.set_renderingLayerMaskDelegate>("UnityEngine.Renderer::set_renderingLayerMask");
			Renderer.get_rendererPriorityDelegateField = IL2CPP.ResolveICall<Renderer.get_rendererPriorityDelegate>("UnityEngine.Renderer::get_rendererPriority");
			Renderer.set_rendererPriorityDelegateField = IL2CPP.ResolveICall<Renderer.set_rendererPriorityDelegate>("UnityEngine.Renderer::set_rendererPriority");
			Renderer.get_rayTracingModeDelegateField = IL2CPP.ResolveICall<Renderer.get_rayTracingModeDelegate>("UnityEngine.Renderer::get_rayTracingMode");
			Renderer.set_rayTracingModeDelegateField = IL2CPP.ResolveICall<Renderer.set_rayTracingModeDelegate>("UnityEngine.Renderer::set_rayTracingMode");
			Renderer.get_sortingLayerNameDelegateField = IL2CPP.ResolveICall<Renderer.get_sortingLayerNameDelegate>("UnityEngine.Renderer::get_sortingLayerName");
			Renderer.set_sortingLayerNameDelegateField = IL2CPP.ResolveICall<Renderer.set_sortingLayerNameDelegate>("UnityEngine.Renderer::set_sortingLayerName");
			Renderer.get_sortingGroupIDDelegateField = IL2CPP.ResolveICall<Renderer.get_sortingGroupIDDelegate>("UnityEngine.Renderer::get_sortingGroupID");
			Renderer.set_sortingGroupIDDelegateField = IL2CPP.ResolveICall<Renderer.set_sortingGroupIDDelegate>("UnityEngine.Renderer::set_sortingGroupID");
			Renderer.get_sortingGroupOrderDelegateField = IL2CPP.ResolveICall<Renderer.get_sortingGroupOrderDelegate>("UnityEngine.Renderer::get_sortingGroupOrder");
			Renderer.set_sortingGroupOrderDelegateField = IL2CPP.ResolveICall<Renderer.set_sortingGroupOrderDelegate>("UnityEngine.Renderer::set_sortingGroupOrder");
			Renderer.get_allowOcclusionWhenDynamicDelegateField = IL2CPP.ResolveICall<Renderer.get_allowOcclusionWhenDynamicDelegate>("UnityEngine.Renderer::get_allowOcclusionWhenDynamic");
			Renderer.set_allowOcclusionWhenDynamicDelegateField = IL2CPP.ResolveICall<Renderer.set_allowOcclusionWhenDynamicDelegate>("UnityEngine.Renderer::set_allowOcclusionWhenDynamic");
			Renderer.get_staticBatchRootTransformDelegateField = IL2CPP.ResolveICall<Renderer.get_staticBatchRootTransformDelegate>("UnityEngine.Renderer::get_staticBatchRootTransform");
			Renderer.set_staticBatchRootTransformDelegateField = IL2CPP.ResolveICall<Renderer.set_staticBatchRootTransformDelegate>("UnityEngine.Renderer::set_staticBatchRootTransform");
			Renderer.get_staticBatchIndexDelegateField = IL2CPP.ResolveICall<Renderer.get_staticBatchIndexDelegate>("UnityEngine.Renderer::get_staticBatchIndex");
			Renderer.SetStaticBatchInfoDelegateField = IL2CPP.ResolveICall<Renderer.SetStaticBatchInfoDelegate>("UnityEngine.Renderer::SetStaticBatchInfo");
			Renderer.get_isPartOfStaticBatchDelegateField = IL2CPP.ResolveICall<Renderer.get_isPartOfStaticBatchDelegate>("UnityEngine.Renderer::get_isPartOfStaticBatch");
			Renderer.get_lightProbeProxyVolumeOverrideDelegateField = IL2CPP.ResolveICall<Renderer.get_lightProbeProxyVolumeOverrideDelegate>("UnityEngine.Renderer::get_lightProbeProxyVolumeOverride");
			Renderer.set_lightProbeProxyVolumeOverrideDelegateField = IL2CPP.ResolveICall<Renderer.set_lightProbeProxyVolumeOverrideDelegate>("UnityEngine.Renderer::set_lightProbeProxyVolumeOverride");
			Renderer.get_probeAnchorDelegateField = IL2CPP.ResolveICall<Renderer.get_probeAnchorDelegate>("UnityEngine.Renderer::get_probeAnchor");
			Renderer.set_probeAnchorDelegateField = IL2CPP.ResolveICall<Renderer.set_probeAnchorDelegate>("UnityEngine.Renderer::set_probeAnchor");
			Renderer.GetLightmapIndexDelegateField = IL2CPP.ResolveICall<Renderer.GetLightmapIndexDelegate>("UnityEngine.Renderer::GetLightmapIndex");
			Renderer.SetLightmapIndexDelegateField = IL2CPP.ResolveICall<Renderer.SetLightmapIndexDelegate>("UnityEngine.Renderer::SetLightmapIndex");
			Renderer.GetMaterialCountDelegateField = IL2CPP.ResolveICall<Renderer.GetMaterialCountDelegate>("UnityEngine.Renderer::GetMaterialCount");
			Renderer.GetSharedMaterialArrayDelegateField = IL2CPP.ResolveICall<Renderer.GetSharedMaterialArrayDelegate>("UnityEngine.Renderer::GetSharedMaterialArray");
			Renderer.SetStaticLightmapST_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.SetStaticLightmapST_InjectedDelegate>("UnityEngine.Renderer::SetStaticLightmapST_Injected");
			Renderer.get_worldToLocalMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.get_worldToLocalMatrix_InjectedDelegate>("UnityEngine.Renderer::get_worldToLocalMatrix_Injected");
			Renderer.get_localToWorldMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.get_localToWorldMatrix_InjectedDelegate>("UnityEngine.Renderer::get_localToWorldMatrix_Injected");
			Renderer.GetLightmapST_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.GetLightmapST_InjectedDelegate>("UnityEngine.Renderer::GetLightmapST_Injected");
			Renderer.SetLightmapST_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.SetLightmapST_InjectedDelegate>("UnityEngine.Renderer::SetLightmapST_Injected");
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00025628 File Offset: 0x00023828
		public unsafe Bounds bounds
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 62764, RefRangeEnd = 62786, XrefRangeStart = 62762, XrefRangeEnd = 62764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00025664 File Offset: 0x00023864
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 62788, RefRangeEnd = 62833, XrefRangeStart = 62786, XrefRangeEnd = 62788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x000256A4 File Offset: 0x000238A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 62835, RefRangeEnd = 62839, XrefRangeStart = 62833, XrefRangeEnd = 62835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetSharedMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x000256E4 File Offset: 0x000238E4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 62841, RefRangeEnd = 62852, XrefRangeStart = 62839, XrefRangeEnd = 62841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial(Material m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_SetMaterial_Private_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00025728 File Offset: 0x00023928
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 62854, RefRangeEnd = 62864, XrefRangeStart = 62852, XrefRangeEnd = 62854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Material> GetMaterialArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetMaterialArray_Private_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x00025768 File Offset: 0x00023968
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x000257A4 File Offset: 0x000239A4
		public unsafe bool enabled
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 62866, RefRangeEnd = 62869, XrefRangeStart = 62864, XrefRangeEnd = 62866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 62871, RefRangeEnd = 62877, XrefRangeStart = 62869, XrefRangeEnd = 62871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x000257E4 File Offset: 0x000239E4
		public unsafe bool isVisible
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62879, RefRangeEnd = 62880, XrefRangeStart = 62877, XrefRangeEnd = 62879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00005C3C File Offset: 0x00003E3C
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x00025820 File Offset: 0x00023A20
		public unsafe UnityEngine.Rendering.ShadowCastingMode shadowCastingMode
		{
			get
			{
				return Renderer.get_shadowCastingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62882, RefRangeEnd = 62883, XrefRangeStart = 62880, XrefRangeEnd = 62882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00005C4E File Offset: 0x00003E4E
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00025860 File Offset: 0x00023A60
		public unsafe bool receiveShadows
		{
			get
			{
				return Renderer.get_receiveShadowsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62885, RefRangeEnd = 62886, XrefRangeStart = 62883, XrefRangeEnd = 62885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x000258A0 File Offset: 0x00023AA0
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x000258DC File Offset: 0x00023ADC
		public unsafe int sortingLayerID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 62888, RefRangeEnd = 62891, XrefRangeStart = 62886, XrefRangeEnd = 62888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 62893, RefRangeEnd = 62897, XrefRangeStart = 62891, XrefRangeEnd = 62893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x0002591C File Offset: 0x00023B1C
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00025958 File Offset: 0x00023B58
		public unsafe int sortingOrder
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 62899, RefRangeEnd = 62902, XrefRangeStart = 62897, XrefRangeEnd = 62899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 62904, RefRangeEnd = 62908, XrefRangeStart = 62902, XrefRangeEnd = 62904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00025998 File Offset: 0x00023B98
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00005F0D File Offset: 0x0000410D
		public unsafe Il2CppReferenceArray<Material> materials
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 62854, RefRangeEnd = 62864, XrefRangeStart = 62854, XrefRangeEnd = 62864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_materials_Public_get_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
			}
			set
			{
				this.SetMaterialArray(value);
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x000259D8 File Offset: 0x00023BD8
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x00025A18 File Offset: 0x00023C18
		public unsafe Material material
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 62788, RefRangeEnd = 62833, XrefRangeStart = 62788, XrefRangeEnd = 62833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 62841, RefRangeEnd = 62852, XrefRangeStart = 62841, XrefRangeEnd = 62852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_material_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x00025A5C File Offset: 0x00023C5C
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x00025A9C File Offset: 0x00023C9C
		public unsafe Material sharedMaterial
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 62835, RefRangeEnd = 62839, XrefRangeStart = 62835, XrefRangeEnd = 62839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 62841, RefRangeEnd = 62852, XrefRangeStart = 62841, XrefRangeEnd = 62852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00025AE0 File Offset: 0x00023CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62908, XrefRangeEnd = 62910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00005AF4 File Offset: 0x00003CF4
		public Renderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00025B20 File Offset: 0x00023D20
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00005AFD File Offset: 0x00003CFD
		public bool castShadows
		{
			get
			{
				return this.shadowCastingMode > UnityEngine.Rendering.ShadowCastingMode.Off;
			}
			set
			{
				this.shadowCastingMode = (value ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off);
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x00025B3C File Offset: 0x00023D3C
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x00005B0E File Offset: 0x00003D0E
		public bool motionVectors
		{
			get
			{
				return this.motionVectorGenerationMode == MotionVectorGenerationMode.Object;
			}
			set
			{
				this.motionVectorGenerationMode = (value ? MotionVectorGenerationMode.Object : MotionVectorGenerationMode.Camera);
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00025B58 File Offset: 0x00023D58
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x00005B1F File Offset: 0x00003D1F
		public bool useLightProbes
		{
			get
			{
				return this.lightProbeUsage > UnityEngine.Rendering.LightProbeUsage.Off;
			}
			set
			{
				this.lightProbeUsage = (value ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off);
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00005B30 File Offset: 0x00003D30
		public void SetStaticLightmapST(Vector4 st)
		{
			this.SetStaticLightmapST_Injected(ref st);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00005B3A File Offset: 0x00003D3A
		public void CopyMaterialArray([Out] Il2CppReferenceArray<Material> m)
		{
			Renderer.CopyMaterialArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(m));
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00005B52 File Offset: 0x00003D52
		public void CopySharedMaterialArray([Out] Il2CppReferenceArray<Material> m)
		{
			Renderer.CopySharedMaterialArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(m));
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00005B6A File Offset: 0x00003D6A
		public void SetMaterialArray(Il2CppReferenceArray<Material> m)
		{
			Renderer.SetMaterialArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(m));
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00005B82 File Offset: 0x00003D82
		public void Internal_SetPropertyBlock(MaterialPropertyBlock properties)
		{
			Renderer.Internal_SetPropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00005B9A File Offset: 0x00003D9A
		public void Internal_GetPropertyBlock(MaterialPropertyBlock dest)
		{
			Renderer.Internal_GetPropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(dest));
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00005BB2 File Offset: 0x00003DB2
		public void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex)
		{
			Renderer.Internal_SetPropertyBlockMaterialIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(properties), materialIndex);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00005BCB File Offset: 0x00003DCB
		public void Internal_GetPropertyBlockMaterialIndex(MaterialPropertyBlock dest, int materialIndex)
		{
			Renderer.Internal_GetPropertyBlockMaterialIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(dest), materialIndex);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00005BE4 File Offset: 0x00003DE4
		public bool HasPropertyBlock()
		{
			return Renderer.HasPropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00005BF6 File Offset: 0x00003DF6
		public void SetPropertyBlock(MaterialPropertyBlock properties)
		{
			this.Internal_SetPropertyBlock(properties);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00005C01 File Offset: 0x00003E01
		public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex)
		{
			this.Internal_SetPropertyBlockMaterialIndex(properties, materialIndex);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00005C0D File Offset: 0x00003E0D
		public void GetPropertyBlock(MaterialPropertyBlock properties)
		{
			this.Internal_GetPropertyBlock(properties);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00005C18 File Offset: 0x00003E18
		public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex)
		{
			this.Internal_GetPropertyBlockMaterialIndex(properties, materialIndex);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00005C24 File Offset: 0x00003E24
		public void GetClosestReflectionProbesInternal(Object result)
		{
			Renderer.GetClosestReflectionProbesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(result));
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00005C60 File Offset: 0x00003E60
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00005C72 File Offset: 0x00003E72
		public bool forceRenderingOff
		{
			get
			{
				return Renderer.get_forceRenderingOffDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_forceRenderingOffDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00005C85 File Offset: 0x00003E85
		public bool GetIsStaticShadowCaster()
		{
			return Renderer.GetIsStaticShadowCasterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00005C97 File Offset: 0x00003E97
		public void SetIsStaticShadowCaster(bool value)
		{
			Renderer.SetIsStaticShadowCasterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00025B74 File Offset: 0x00023D74
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x00005CAA File Offset: 0x00003EAA
		public bool staticShadowCaster
		{
			get
			{
				return this.GetIsStaticShadowCaster();
			}
			set
			{
				this.SetIsStaticShadowCaster(value);
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00005CB5 File Offset: 0x00003EB5
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x00005CC7 File Offset: 0x00003EC7
		public MotionVectorGenerationMode motionVectorGenerationMode
		{
			get
			{
				return Renderer.get_motionVectorGenerationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_motionVectorGenerationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00005CDA File Offset: 0x00003EDA
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x00005CEC File Offset: 0x00003EEC
		public UnityEngine.Rendering.LightProbeUsage lightProbeUsage
		{
			get
			{
				return Renderer.get_lightProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_lightProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00005CFF File Offset: 0x00003EFF
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x00005D11 File Offset: 0x00003F11
		public UnityEngine.Rendering.ReflectionProbeUsage reflectionProbeUsage
		{
			get
			{
				return Renderer.get_reflectionProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_reflectionProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00005D24 File Offset: 0x00003F24
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x00005D36 File Offset: 0x00003F36
		public uint renderingLayerMask
		{
			get
			{
				return Renderer.get_renderingLayerMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_renderingLayerMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00005D49 File Offset: 0x00003F49
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00005D5B File Offset: 0x00003F5B
		public int rendererPriority
		{
			get
			{
				return Renderer.get_rendererPriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_rendererPriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00005D6E File Offset: 0x00003F6E
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x00005D80 File Offset: 0x00003F80
		public UnityEngine.Experimental.Rendering.RayTracingMode rayTracingMode
		{
			get
			{
				return Renderer.get_rayTracingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_rayTracingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00025B8C File Offset: 0x00023D8C
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x00005D93 File Offset: 0x00003F93
		public string sortingLayerName
		{
			get
			{
				IntPtr intPtr = Renderer.get_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				Renderer.set_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00005DAB File Offset: 0x00003FAB
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x00005DBD File Offset: 0x00003FBD
		public int sortingGroupID
		{
			get
			{
				return Renderer.get_sortingGroupIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_sortingGroupIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00005DD0 File Offset: 0x00003FD0
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x00005DE2 File Offset: 0x00003FE2
		public int sortingGroupOrder
		{
			get
			{
				return Renderer.get_sortingGroupOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_sortingGroupOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00005DF5 File Offset: 0x00003FF5
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x00005E07 File Offset: 0x00004007
		public bool allowOcclusionWhenDynamic
		{
			get
			{
				return Renderer.get_allowOcclusionWhenDynamicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_allowOcclusionWhenDynamicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00025BB0 File Offset: 0x00023DB0
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x00005E1A File Offset: 0x0000401A
		public Transform staticBatchRootTransform
		{
			get
			{
				IntPtr intPtr = Renderer.get_staticBatchRootTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				Renderer.set_staticBatchRootTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00005E32 File Offset: 0x00004032
		public int staticBatchIndex
		{
			get
			{
				return Renderer.get_staticBatchIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00005E44 File Offset: 0x00004044
		public void SetStaticBatchInfo(int firstSubMesh, int subMeshCount)
		{
			Renderer.SetStaticBatchInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), firstSubMesh, subMeshCount);
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00005E58 File Offset: 0x00004058
		public bool isPartOfStaticBatch
		{
			get
			{
				return Renderer.get_isPartOfStaticBatchDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00025BDC File Offset: 0x00023DDC
		public Matrix4x4 worldToLocalMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_worldToLocalMatrix_Injected(out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00025BF4 File Offset: 0x00023DF4
		public Matrix4x4 localToWorldMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_localToWorldMatrix_Injected(out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00025C0C File Offset: 0x00023E0C
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00005E6A File Offset: 0x0000406A
		public GameObject lightProbeProxyVolumeOverride
		{
			get
			{
				IntPtr intPtr = Renderer.get_lightProbeProxyVolumeOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				Renderer.set_lightProbeProxyVolumeOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00025C38 File Offset: 0x00023E38
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00005E82 File Offset: 0x00004082
		public Transform probeAnchor
		{
			get
			{
				IntPtr intPtr = Renderer.get_probeAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				Renderer.set_probeAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00005E9A File Offset: 0x0000409A
		public int GetLightmapIndex(global::UnityEngineInternal.LightmapType lt)
		{
			return Renderer.GetLightmapIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), lt);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00005EAD File Offset: 0x000040AD
		public void SetLightmapIndex(int index, global::UnityEngineInternal.LightmapType lt)
		{
			Renderer.SetLightmapIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, lt);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00025C64 File Offset: 0x00023E64
		public Vector4 GetLightmapST(global::UnityEngineInternal.LightmapType lt)
		{
			Vector4 vector;
			this.GetLightmapST_Injected(lt, out vector);
			return vector;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00005EC1 File Offset: 0x000040C1
		public void SetLightmapST(Vector4 st, global::UnityEngineInternal.LightmapType lt)
		{
			this.SetLightmapST_Injected(ref st, lt);
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00025C7C File Offset: 0x00023E7C
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x00005ECC File Offset: 0x000040CC
		public int lightmapIndex
		{
			get
			{
				return this.GetLightmapIndex(global::UnityEngineInternal.LightmapType.StaticLightmap);
			}
			set
			{
				this.SetLightmapIndex(value, global::UnityEngineInternal.LightmapType.StaticLightmap);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00025C98 File Offset: 0x00023E98
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00005ED8 File Offset: 0x000040D8
		public int realtimeLightmapIndex
		{
			get
			{
				return this.GetLightmapIndex(global::UnityEngineInternal.LightmapType.DynamicLightmap);
			}
			set
			{
				this.SetLightmapIndex(value, global::UnityEngineInternal.LightmapType.DynamicLightmap);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00025CB4 File Offset: 0x00023EB4
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x00005EE4 File Offset: 0x000040E4
		public Vector4 lightmapScaleOffset
		{
			get
			{
				return this.GetLightmapST(global::UnityEngineInternal.LightmapType.StaticLightmap);
			}
			set
			{
				this.SetStaticLightmapST(value);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00025CD0 File Offset: 0x00023ED0
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x00005EEF File Offset: 0x000040EF
		public Vector4 realtimeLightmapScaleOffset
		{
			get
			{
				return this.GetLightmapST(global::UnityEngineInternal.LightmapType.DynamicLightmap);
			}
			set
			{
				this.SetLightmapST(value, global::UnityEngineInternal.LightmapType.DynamicLightmap);
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00005EFB File Offset: 0x000040FB
		public int GetMaterialCount()
		{
			return Renderer.GetMaterialCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00025CEC File Offset: 0x00023EEC
		public Il2CppReferenceArray<Material> GetSharedMaterialArray()
		{
			IntPtr intPtr = Renderer.GetSharedMaterialArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00025D18 File Offset: 0x00023F18
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00005F18 File Offset: 0x00004118
		public Il2CppReferenceArray<Material> sharedMaterials
		{
			get
			{
				return this.GetSharedMaterialArray();
			}
			set
			{
				this.SetMaterialArray(value);
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00025D30 File Offset: 0x00023F30
		public void GetMaterials(List<Material> m)
		{
			bool flag = m == null;
			if (flag)
			{
				throw new ArgumentNullException("The result material list cannot be null.", "m");
			}
			NoAllocHelpers.EnsureListElemCount<Material>(m, this.GetMaterialCount());
			this.CopyMaterialArray(NoAllocHelpers.ExtractArrayFromListT<Material>(m));
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00025D70 File Offset: 0x00023F70
		public void GetSharedMaterials(List<Material> m)
		{
			bool flag = m == null;
			if (flag)
			{
				throw new ArgumentNullException("The result material list cannot be null.", "m");
			}
			NoAllocHelpers.EnsureListElemCount<Material>(m, this.GetMaterialCount());
			this.CopySharedMaterialArray(NoAllocHelpers.ExtractArrayFromListT<Material>(m));
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00005F23 File Offset: 0x00004123
		public void SetStaticLightmapST_Injected(ref Vector4 st)
		{
			Renderer.SetStaticLightmapST_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref st);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00005F36 File Offset: 0x00004136
		public void get_worldToLocalMatrix_Injected(out Matrix4x4 ret)
		{
			Renderer.get_worldToLocalMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00005F49 File Offset: 0x00004149
		public void get_localToWorldMatrix_Injected(out Matrix4x4 ret)
		{
			Renderer.get_localToWorldMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00005F5C File Offset: 0x0000415C
		public void GetLightmapST_Injected(global::UnityEngineInternal.LightmapType lt, out Vector4 ret)
		{
			Renderer.GetLightmapST_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), lt, out ret);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00005F70 File Offset: 0x00004170
		public void SetLightmapST_Injected(ref Vector4 st, global::UnityEngineInternal.LightmapType lt)
		{
			Renderer.SetLightmapST_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref st, lt);
		}

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Private_Material_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Private_Void_Material_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterialArray_Private_Il2CppReferenceArray_1_Material_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_get_materials_Public_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_get_Material_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Public_set_Void_Material_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x04000435 RID: 1077
		private static readonly Renderer.CopyMaterialArrayDelegate CopyMaterialArrayDelegateField;

		// Token: 0x04000436 RID: 1078
		private static readonly Renderer.CopySharedMaterialArrayDelegate CopySharedMaterialArrayDelegateField;

		// Token: 0x04000437 RID: 1079
		private static readonly Renderer.SetMaterialArrayDelegate SetMaterialArrayDelegateField;

		// Token: 0x04000438 RID: 1080
		private static readonly Renderer.Internal_SetPropertyBlockDelegate Internal_SetPropertyBlockDelegateField;

		// Token: 0x04000439 RID: 1081
		private static readonly Renderer.Internal_GetPropertyBlockDelegate Internal_GetPropertyBlockDelegateField;

		// Token: 0x0400043A RID: 1082
		private static readonly Renderer.Internal_SetPropertyBlockMaterialIndexDelegate Internal_SetPropertyBlockMaterialIndexDelegateField;

		// Token: 0x0400043B RID: 1083
		private static readonly Renderer.Internal_GetPropertyBlockMaterialIndexDelegate Internal_GetPropertyBlockMaterialIndexDelegateField;

		// Token: 0x0400043C RID: 1084
		private static readonly Renderer.HasPropertyBlockDelegate HasPropertyBlockDelegateField;

		// Token: 0x0400043D RID: 1085
		private static readonly Renderer.GetClosestReflectionProbesInternalDelegate GetClosestReflectionProbesInternalDelegateField;

		// Token: 0x0400043E RID: 1086
		private static readonly Renderer.get_shadowCastingModeDelegate get_shadowCastingModeDelegateField;

		// Token: 0x0400043F RID: 1087
		private static readonly Renderer.get_receiveShadowsDelegate get_receiveShadowsDelegateField;

		// Token: 0x04000440 RID: 1088
		private static readonly Renderer.get_forceRenderingOffDelegate get_forceRenderingOffDelegateField;

		// Token: 0x04000441 RID: 1089
		private static readonly Renderer.set_forceRenderingOffDelegate set_forceRenderingOffDelegateField;

		// Token: 0x04000442 RID: 1090
		private static readonly Renderer.GetIsStaticShadowCasterDelegate GetIsStaticShadowCasterDelegateField;

		// Token: 0x04000443 RID: 1091
		private static readonly Renderer.SetIsStaticShadowCasterDelegate SetIsStaticShadowCasterDelegateField;

		// Token: 0x04000444 RID: 1092
		private static readonly Renderer.get_motionVectorGenerationModeDelegate get_motionVectorGenerationModeDelegateField;

		// Token: 0x04000445 RID: 1093
		private static readonly Renderer.set_motionVectorGenerationModeDelegate set_motionVectorGenerationModeDelegateField;

		// Token: 0x04000446 RID: 1094
		private static readonly Renderer.get_lightProbeUsageDelegate get_lightProbeUsageDelegateField;

		// Token: 0x04000447 RID: 1095
		private static readonly Renderer.set_lightProbeUsageDelegate set_lightProbeUsageDelegateField;

		// Token: 0x04000448 RID: 1096
		private static readonly Renderer.get_reflectionProbeUsageDelegate get_reflectionProbeUsageDelegateField;

		// Token: 0x04000449 RID: 1097
		private static readonly Renderer.set_reflectionProbeUsageDelegate set_reflectionProbeUsageDelegateField;

		// Token: 0x0400044A RID: 1098
		private static readonly Renderer.get_renderingLayerMaskDelegate get_renderingLayerMaskDelegateField;

		// Token: 0x0400044B RID: 1099
		private static readonly Renderer.set_renderingLayerMaskDelegate set_renderingLayerMaskDelegateField;

		// Token: 0x0400044C RID: 1100
		private static readonly Renderer.get_rendererPriorityDelegate get_rendererPriorityDelegateField;

		// Token: 0x0400044D RID: 1101
		private static readonly Renderer.set_rendererPriorityDelegate set_rendererPriorityDelegateField;

		// Token: 0x0400044E RID: 1102
		private static readonly Renderer.get_rayTracingModeDelegate get_rayTracingModeDelegateField;

		// Token: 0x0400044F RID: 1103
		private static readonly Renderer.set_rayTracingModeDelegate set_rayTracingModeDelegateField;

		// Token: 0x04000450 RID: 1104
		private static readonly Renderer.get_sortingLayerNameDelegate get_sortingLayerNameDelegateField;

		// Token: 0x04000451 RID: 1105
		private static readonly Renderer.set_sortingLayerNameDelegate set_sortingLayerNameDelegateField;

		// Token: 0x04000452 RID: 1106
		private static readonly Renderer.get_sortingGroupIDDelegate get_sortingGroupIDDelegateField;

		// Token: 0x04000453 RID: 1107
		private static readonly Renderer.set_sortingGroupIDDelegate set_sortingGroupIDDelegateField;

		// Token: 0x04000454 RID: 1108
		private static readonly Renderer.get_sortingGroupOrderDelegate get_sortingGroupOrderDelegateField;

		// Token: 0x04000455 RID: 1109
		private static readonly Renderer.set_sortingGroupOrderDelegate set_sortingGroupOrderDelegateField;

		// Token: 0x04000456 RID: 1110
		private static readonly Renderer.get_allowOcclusionWhenDynamicDelegate get_allowOcclusionWhenDynamicDelegateField;

		// Token: 0x04000457 RID: 1111
		private static readonly Renderer.set_allowOcclusionWhenDynamicDelegate set_allowOcclusionWhenDynamicDelegateField;

		// Token: 0x04000458 RID: 1112
		private static readonly Renderer.get_staticBatchRootTransformDelegate get_staticBatchRootTransformDelegateField;

		// Token: 0x04000459 RID: 1113
		private static readonly Renderer.set_staticBatchRootTransformDelegate set_staticBatchRootTransformDelegateField;

		// Token: 0x0400045A RID: 1114
		private static readonly Renderer.get_staticBatchIndexDelegate get_staticBatchIndexDelegateField;

		// Token: 0x0400045B RID: 1115
		private static readonly Renderer.SetStaticBatchInfoDelegate SetStaticBatchInfoDelegateField;

		// Token: 0x0400045C RID: 1116
		private static readonly Renderer.get_isPartOfStaticBatchDelegate get_isPartOfStaticBatchDelegateField;

		// Token: 0x0400045D RID: 1117
		private static readonly Renderer.get_lightProbeProxyVolumeOverrideDelegate get_lightProbeProxyVolumeOverrideDelegateField;

		// Token: 0x0400045E RID: 1118
		private static readonly Renderer.set_lightProbeProxyVolumeOverrideDelegate set_lightProbeProxyVolumeOverrideDelegateField;

		// Token: 0x0400045F RID: 1119
		private static readonly Renderer.get_probeAnchorDelegate get_probeAnchorDelegateField;

		// Token: 0x04000460 RID: 1120
		private static readonly Renderer.set_probeAnchorDelegate set_probeAnchorDelegateField;

		// Token: 0x04000461 RID: 1121
		private static readonly Renderer.GetLightmapIndexDelegate GetLightmapIndexDelegateField;

		// Token: 0x04000462 RID: 1122
		private static readonly Renderer.SetLightmapIndexDelegate SetLightmapIndexDelegateField;

		// Token: 0x04000463 RID: 1123
		private static readonly Renderer.GetMaterialCountDelegate GetMaterialCountDelegateField;

		// Token: 0x04000464 RID: 1124
		private static readonly Renderer.GetSharedMaterialArrayDelegate GetSharedMaterialArrayDelegateField;

		// Token: 0x04000465 RID: 1125
		private static readonly Renderer.SetStaticLightmapST_InjectedDelegate SetStaticLightmapST_InjectedDelegateField;

		// Token: 0x04000466 RID: 1126
		private static readonly Renderer.get_worldToLocalMatrix_InjectedDelegate get_worldToLocalMatrix_InjectedDelegateField;

		// Token: 0x04000467 RID: 1127
		private static readonly Renderer.get_localToWorldMatrix_InjectedDelegate get_localToWorldMatrix_InjectedDelegateField;

		// Token: 0x04000468 RID: 1128
		private static readonly Renderer.GetLightmapST_InjectedDelegate GetLightmapST_InjectedDelegateField;

		// Token: 0x04000469 RID: 1129
		private static readonly Renderer.SetLightmapST_InjectedDelegate SetLightmapST_InjectedDelegateField;

		// Token: 0x020004EC RID: 1260
		// (Invoke) Token: 0x060027A7 RID: 10151
		private delegate void CopyMaterialArrayDelegate(IntPtr @this, [Out] IntPtr m);

		// Token: 0x020004ED RID: 1261
		// (Invoke) Token: 0x060027A9 RID: 10153
		private delegate void CopySharedMaterialArrayDelegate(IntPtr @this, [Out] IntPtr m);

		// Token: 0x020004EE RID: 1262
		// (Invoke) Token: 0x060027AB RID: 10155
		private delegate void SetMaterialArrayDelegate(IntPtr @this, IntPtr m);

		// Token: 0x020004EF RID: 1263
		// (Invoke) Token: 0x060027AD RID: 10157
		private delegate void Internal_SetPropertyBlockDelegate(IntPtr @this, IntPtr properties);

		// Token: 0x020004F0 RID: 1264
		// (Invoke) Token: 0x060027AF RID: 10159
		private delegate void Internal_GetPropertyBlockDelegate(IntPtr @this, IntPtr dest);

		// Token: 0x020004F1 RID: 1265
		// (Invoke) Token: 0x060027B1 RID: 10161
		private delegate void Internal_SetPropertyBlockMaterialIndexDelegate(IntPtr @this, IntPtr properties, int materialIndex);

		// Token: 0x020004F2 RID: 1266
		// (Invoke) Token: 0x060027B3 RID: 10163
		private delegate void Internal_GetPropertyBlockMaterialIndexDelegate(IntPtr @this, IntPtr dest, int materialIndex);

		// Token: 0x020004F3 RID: 1267
		// (Invoke) Token: 0x060027B5 RID: 10165
		private delegate bool HasPropertyBlockDelegate(IntPtr @this);

		// Token: 0x020004F4 RID: 1268
		// (Invoke) Token: 0x060027B7 RID: 10167
		private delegate void GetClosestReflectionProbesInternalDelegate(IntPtr @this, IntPtr result);

		// Token: 0x020004F5 RID: 1269
		// (Invoke) Token: 0x060027B9 RID: 10169
		private delegate UnityEngine.Rendering.ShadowCastingMode get_shadowCastingModeDelegate(IntPtr @this);

		// Token: 0x020004F6 RID: 1270
		// (Invoke) Token: 0x060027BB RID: 10171
		private delegate bool get_receiveShadowsDelegate(IntPtr @this);

		// Token: 0x020004F7 RID: 1271
		// (Invoke) Token: 0x060027BD RID: 10173
		private delegate bool get_forceRenderingOffDelegate(IntPtr @this);

		// Token: 0x020004F8 RID: 1272
		// (Invoke) Token: 0x060027BF RID: 10175
		private delegate void set_forceRenderingOffDelegate(IntPtr @this, bool value);

		// Token: 0x020004F9 RID: 1273
		// (Invoke) Token: 0x060027C1 RID: 10177
		private delegate bool GetIsStaticShadowCasterDelegate(IntPtr @this);

		// Token: 0x020004FA RID: 1274
		// (Invoke) Token: 0x060027C3 RID: 10179
		private delegate void SetIsStaticShadowCasterDelegate(IntPtr @this, bool value);

		// Token: 0x020004FB RID: 1275
		// (Invoke) Token: 0x060027C5 RID: 10181
		private delegate MotionVectorGenerationMode get_motionVectorGenerationModeDelegate(IntPtr @this);

		// Token: 0x020004FC RID: 1276
		// (Invoke) Token: 0x060027C7 RID: 10183
		private delegate void set_motionVectorGenerationModeDelegate(IntPtr @this, MotionVectorGenerationMode value);

		// Token: 0x020004FD RID: 1277
		// (Invoke) Token: 0x060027C9 RID: 10185
		private delegate UnityEngine.Rendering.LightProbeUsage get_lightProbeUsageDelegate(IntPtr @this);

		// Token: 0x020004FE RID: 1278
		// (Invoke) Token: 0x060027CB RID: 10187
		private delegate void set_lightProbeUsageDelegate(IntPtr @this, UnityEngine.Rendering.LightProbeUsage value);

		// Token: 0x020004FF RID: 1279
		// (Invoke) Token: 0x060027CD RID: 10189
		private delegate UnityEngine.Rendering.ReflectionProbeUsage get_reflectionProbeUsageDelegate(IntPtr @this);

		// Token: 0x02000500 RID: 1280
		// (Invoke) Token: 0x060027CF RID: 10191
		private delegate void set_reflectionProbeUsageDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeUsage value);

		// Token: 0x02000501 RID: 1281
		// (Invoke) Token: 0x060027D1 RID: 10193
		private delegate uint get_renderingLayerMaskDelegate(IntPtr @this);

		// Token: 0x02000502 RID: 1282
		// (Invoke) Token: 0x060027D3 RID: 10195
		private delegate void set_renderingLayerMaskDelegate(IntPtr @this, uint value);

		// Token: 0x02000503 RID: 1283
		// (Invoke) Token: 0x060027D5 RID: 10197
		private delegate int get_rendererPriorityDelegate(IntPtr @this);

		// Token: 0x02000504 RID: 1284
		// (Invoke) Token: 0x060027D7 RID: 10199
		private delegate void set_rendererPriorityDelegate(IntPtr @this, int value);

		// Token: 0x02000505 RID: 1285
		// (Invoke) Token: 0x060027D9 RID: 10201
		private delegate UnityEngine.Experimental.Rendering.RayTracingMode get_rayTracingModeDelegate(IntPtr @this);

		// Token: 0x02000506 RID: 1286
		// (Invoke) Token: 0x060027DB RID: 10203
		private delegate void set_rayTracingModeDelegate(IntPtr @this, UnityEngine.Experimental.Rendering.RayTracingMode value);

		// Token: 0x02000507 RID: 1287
		// (Invoke) Token: 0x060027DD RID: 10205
		private delegate IntPtr get_sortingLayerNameDelegate(IntPtr @this);

		// Token: 0x02000508 RID: 1288
		// (Invoke) Token: 0x060027DF RID: 10207
		private delegate void set_sortingLayerNameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000509 RID: 1289
		// (Invoke) Token: 0x060027E1 RID: 10209
		private delegate int get_sortingGroupIDDelegate(IntPtr @this);

		// Token: 0x0200050A RID: 1290
		// (Invoke) Token: 0x060027E3 RID: 10211
		private delegate void set_sortingGroupIDDelegate(IntPtr @this, int value);

		// Token: 0x0200050B RID: 1291
		// (Invoke) Token: 0x060027E5 RID: 10213
		private delegate int get_sortingGroupOrderDelegate(IntPtr @this);

		// Token: 0x0200050C RID: 1292
		// (Invoke) Token: 0x060027E7 RID: 10215
		private delegate void set_sortingGroupOrderDelegate(IntPtr @this, int value);

		// Token: 0x0200050D RID: 1293
		// (Invoke) Token: 0x060027E9 RID: 10217
		private delegate bool get_allowOcclusionWhenDynamicDelegate(IntPtr @this);

		// Token: 0x0200050E RID: 1294
		// (Invoke) Token: 0x060027EB RID: 10219
		private delegate void set_allowOcclusionWhenDynamicDelegate(IntPtr @this, bool value);

		// Token: 0x0200050F RID: 1295
		// (Invoke) Token: 0x060027ED RID: 10221
		private delegate IntPtr get_staticBatchRootTransformDelegate(IntPtr @this);

		// Token: 0x02000510 RID: 1296
		// (Invoke) Token: 0x060027EF RID: 10223
		private delegate void set_staticBatchRootTransformDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000511 RID: 1297
		// (Invoke) Token: 0x060027F1 RID: 10225
		private delegate int get_staticBatchIndexDelegate(IntPtr @this);

		// Token: 0x02000512 RID: 1298
		// (Invoke) Token: 0x060027F3 RID: 10227
		private delegate void SetStaticBatchInfoDelegate(IntPtr @this, int firstSubMesh, int subMeshCount);

		// Token: 0x02000513 RID: 1299
		// (Invoke) Token: 0x060027F5 RID: 10229
		private delegate bool get_isPartOfStaticBatchDelegate(IntPtr @this);

		// Token: 0x02000514 RID: 1300
		// (Invoke) Token: 0x060027F7 RID: 10231
		private delegate IntPtr get_lightProbeProxyVolumeOverrideDelegate(IntPtr @this);

		// Token: 0x02000515 RID: 1301
		// (Invoke) Token: 0x060027F9 RID: 10233
		private delegate void set_lightProbeProxyVolumeOverrideDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000516 RID: 1302
		// (Invoke) Token: 0x060027FB RID: 10235
		private delegate IntPtr get_probeAnchorDelegate(IntPtr @this);

		// Token: 0x02000517 RID: 1303
		// (Invoke) Token: 0x060027FD RID: 10237
		private delegate void set_probeAnchorDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000518 RID: 1304
		// (Invoke) Token: 0x060027FF RID: 10239
		private delegate int GetLightmapIndexDelegate(IntPtr @this, global::UnityEngineInternal.LightmapType lt);

		// Token: 0x02000519 RID: 1305
		// (Invoke) Token: 0x06002801 RID: 10241
		private delegate void SetLightmapIndexDelegate(IntPtr @this, int index, global::UnityEngineInternal.LightmapType lt);

		// Token: 0x0200051A RID: 1306
		// (Invoke) Token: 0x06002803 RID: 10243
		private delegate int GetMaterialCountDelegate(IntPtr @this);

		// Token: 0x0200051B RID: 1307
		// (Invoke) Token: 0x06002805 RID: 10245
		private delegate IntPtr GetSharedMaterialArrayDelegate(IntPtr @this);

		// Token: 0x0200051C RID: 1308
		// (Invoke) Token: 0x06002807 RID: 10247
		private delegate void SetStaticLightmapST_InjectedDelegate(IntPtr @this, IntPtr st);

		// Token: 0x0200051D RID: 1309
		// (Invoke) Token: 0x06002809 RID: 10249
		private delegate void get_worldToLocalMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200051E RID: 1310
		// (Invoke) Token: 0x0600280B RID: 10251
		private delegate void get_localToWorldMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200051F RID: 1311
		// (Invoke) Token: 0x0600280D RID: 10253
		private delegate void GetLightmapST_InjectedDelegate(IntPtr @this, global::UnityEngineInternal.LightmapType lt, [Out] IntPtr ret);

		// Token: 0x02000520 RID: 1312
		// (Invoke) Token: 0x0600280F RID: 10255
		private delegate void SetLightmapST_InjectedDelegate(IntPtr @this, IntPtr st, global::UnityEngineInternal.LightmapType lt);
	}
}
