using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.TerrainAPI;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public sealed class TerrainData : Object
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00003EE4 File Offset: 0x000020E4
		// Note: this type is marked as 'beforefieldinit'.
		static TerrainData()
		{
			Il2CppClassPointerStore<TerrainData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine", "TerrainData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainData>.NativeClassPtr);
			TerrainData.NativeFieldInfoPtr_k_MaximumResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumResolution");
			TerrainData.NativeFieldInfoPtr_k_MinimumDetailResolutionPerPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MinimumDetailResolutionPerPatch");
			TerrainData.NativeFieldInfoPtr_k_MaximumDetailResolutionPerPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumDetailResolutionPerPatch");
			TerrainData.NativeFieldInfoPtr_k_MaximumDetailPatchCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumDetailPatchCount");
			TerrainData.NativeFieldInfoPtr_k_MaximumDetailsPerRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumDetailsPerRes");
			TerrainData.NativeFieldInfoPtr_k_MinimumAlphamapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MinimumAlphamapResolution");
			TerrainData.NativeFieldInfoPtr_k_MaximumAlphamapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumAlphamapResolution");
			TerrainData.NativeFieldInfoPtr_k_MinimumBaseMapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MinimumBaseMapResolution");
			TerrainData.NativeFieldInfoPtr_k_MaximumBaseMapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumBaseMapResolution");
			TerrainData.NativeMethodInfoPtr_GetBoundaryValue_Private_Static_Int32_BoundaryValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663303);
			TerrainData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663304);
			TerrainData.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_TerrainData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663305);
			TerrainData.NativeMethodInfoPtr_get_size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663306);
			TerrainData.NativeMethodInfoPtr_GetAlphamapResolutionInternal_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663307);
			TerrainData.NativeMethodInfoPtr_get_users_Internal_get_Il2CppReferenceArray_1_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663308);
			TerrainData.NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663310);
			TerrainData.get_heightmapTextureDelegateField = IL2CPP.ResolveICall<TerrainData.get_heightmapTextureDelegate>("UnityEngine.TerrainData::get_heightmapTexture");
			TerrainData.get_internalHeightmapResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.get_internalHeightmapResolutionDelegate>("UnityEngine.TerrainData::get_internalHeightmapResolution");
			TerrainData.set_internalHeightmapResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.set_internalHeightmapResolutionDelegate>("UnityEngine.TerrainData::set_internalHeightmapResolution");
			TerrainData.get_enableHolesTextureCompressionDelegateField = IL2CPP.ResolveICall<TerrainData.get_enableHolesTextureCompressionDelegate>("UnityEngine.TerrainData::get_enableHolesTextureCompression");
			TerrainData.set_enableHolesTextureCompressionDelegateField = IL2CPP.ResolveICall<TerrainData.set_enableHolesTextureCompressionDelegate>("UnityEngine.TerrainData::set_enableHolesTextureCompression");
			TerrainData.IsHolesTextureCompressedDelegateField = IL2CPP.ResolveICall<TerrainData.IsHolesTextureCompressedDelegate>("UnityEngine.TerrainData::IsHolesTextureCompressed");
			TerrainData.GetHolesTextureDelegateField = IL2CPP.ResolveICall<TerrainData.GetHolesTextureDelegate>("UnityEngine.TerrainData::GetHolesTexture");
			TerrainData.GetCompressedHolesTextureDelegateField = IL2CPP.ResolveICall<TerrainData.GetCompressedHolesTextureDelegate>("UnityEngine.TerrainData::GetCompressedHolesTexture");
			TerrainData.GetHeightDelegateField = IL2CPP.ResolveICall<TerrainData.GetHeightDelegate>("UnityEngine.TerrainData::GetHeight");
			TerrainData.GetInterpolatedHeightDelegateField = IL2CPP.ResolveICall<TerrainData.GetInterpolatedHeightDelegate>("UnityEngine.TerrainData::GetInterpolatedHeight");
			TerrainData.GetMaximumHeightErrorDelegateField = IL2CPP.ResolveICall<TerrainData.GetMaximumHeightErrorDelegate>("UnityEngine.TerrainData::GetMaximumHeightError");
			TerrainData.OverrideMaximumHeightErrorDelegateField = IL2CPP.ResolveICall<TerrainData.OverrideMaximumHeightErrorDelegate>("UnityEngine.TerrainData::OverrideMaximumHeightError");
			TerrainData.Internal_IsHoleDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_IsHoleDelegate>("UnityEngine.TerrainData::Internal_IsHole");
			TerrainData.GetSteepnessDelegateField = IL2CPP.ResolveICall<TerrainData.GetSteepnessDelegate>("UnityEngine.TerrainData::GetSteepness");
			TerrainData.GetAdjustedSizeDelegateField = IL2CPP.ResolveICall<TerrainData.GetAdjustedSizeDelegate>("UnityEngine.TerrainData::GetAdjustedSize");
			TerrainData.get_wavingGrassStrengthDelegateField = IL2CPP.ResolveICall<TerrainData.get_wavingGrassStrengthDelegate>("UnityEngine.TerrainData::get_wavingGrassStrength");
			TerrainData.set_wavingGrassStrengthDelegateField = IL2CPP.ResolveICall<TerrainData.set_wavingGrassStrengthDelegate>("UnityEngine.TerrainData::set_wavingGrassStrength");
			TerrainData.get_wavingGrassAmountDelegateField = IL2CPP.ResolveICall<TerrainData.get_wavingGrassAmountDelegate>("UnityEngine.TerrainData::get_wavingGrassAmount");
			TerrainData.set_wavingGrassAmountDelegateField = IL2CPP.ResolveICall<TerrainData.set_wavingGrassAmountDelegate>("UnityEngine.TerrainData::set_wavingGrassAmount");
			TerrainData.get_wavingGrassSpeedDelegateField = IL2CPP.ResolveICall<TerrainData.get_wavingGrassSpeedDelegate>("UnityEngine.TerrainData::get_wavingGrassSpeed");
			TerrainData.set_wavingGrassSpeedDelegateField = IL2CPP.ResolveICall<TerrainData.set_wavingGrassSpeedDelegate>("UnityEngine.TerrainData::set_wavingGrassSpeed");
			TerrainData.get_detailWidthDelegateField = IL2CPP.ResolveICall<TerrainData.get_detailWidthDelegate>("UnityEngine.TerrainData::get_detailWidth");
			TerrainData.get_detailHeightDelegateField = IL2CPP.ResolveICall<TerrainData.get_detailHeightDelegate>("UnityEngine.TerrainData::get_detailHeight");
			TerrainData.Internal_SetDetailResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_SetDetailResolutionDelegate>("UnityEngine.TerrainData::Internal_SetDetailResolution");
			TerrainData.get_detailPatchCountDelegateField = IL2CPP.ResolveICall<TerrainData.get_detailPatchCountDelegate>("UnityEngine.TerrainData::get_detailPatchCount");
			TerrainData.get_detailResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.get_detailResolutionDelegate>("UnityEngine.TerrainData::get_detailResolution");
			TerrainData.get_detailResolutionPerPatchDelegateField = IL2CPP.ResolveICall<TerrainData.get_detailResolutionPerPatchDelegate>("UnityEngine.TerrainData::get_detailResolutionPerPatch");
			TerrainData.ResetDirtyDetailsDelegateField = IL2CPP.ResolveICall<TerrainData.ResetDirtyDetailsDelegate>("UnityEngine.TerrainData::ResetDirtyDetails");
			TerrainData.RefreshPrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.RefreshPrototypesDelegate>("UnityEngine.TerrainData::RefreshPrototypes");
			TerrainData.get_detailPrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.get_detailPrototypesDelegate>("UnityEngine.TerrainData::get_detailPrototypes");
			TerrainData.set_detailPrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.set_detailPrototypesDelegate>("UnityEngine.TerrainData::set_detailPrototypes");
			TerrainData.GetSupportedLayersDelegateField = IL2CPP.ResolveICall<TerrainData.GetSupportedLayersDelegate>("UnityEngine.TerrainData::GetSupportedLayers");
			TerrainData.get_treeInstanceCountDelegateField = IL2CPP.ResolveICall<TerrainData.get_treeInstanceCountDelegate>("UnityEngine.TerrainData::get_treeInstanceCount");
			TerrainData.get_treePrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.get_treePrototypesDelegate>("UnityEngine.TerrainData::get_treePrototypes");
			TerrainData.set_treePrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.set_treePrototypesDelegate>("UnityEngine.TerrainData::set_treePrototypes");
			TerrainData.RemoveTreePrototypeDelegateField = IL2CPP.ResolveICall<TerrainData.RemoveTreePrototypeDelegate>("UnityEngine.TerrainData::RemoveTreePrototype");
			TerrainData.RemoveDetailPrototypeDelegateField = IL2CPP.ResolveICall<TerrainData.RemoveDetailPrototypeDelegate>("UnityEngine.TerrainData::RemoveDetailPrototype");
			TerrainData.NeedUpgradeScaledTreePrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.NeedUpgradeScaledTreePrototypesDelegate>("UnityEngine.TerrainData::NeedUpgradeScaledTreePrototypes");
			TerrainData.UpgradeScaledTreePrototypeDelegateField = IL2CPP.ResolveICall<TerrainData.UpgradeScaledTreePrototypeDelegate>("UnityEngine.TerrainData::UpgradeScaledTreePrototype");
			TerrainData.get_alphamapLayersDelegateField = IL2CPP.ResolveICall<TerrainData.get_alphamapLayersDelegate>("UnityEngine.TerrainData::get_alphamapLayers");
			TerrainData.get_Internal_alphamapResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.get_Internal_alphamapResolutionDelegate>("UnityEngine.TerrainData::get_Internal_alphamapResolution");
			TerrainData.set_Internal_alphamapResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.set_Internal_alphamapResolutionDelegate>("UnityEngine.TerrainData::set_Internal_alphamapResolution");
			TerrainData.get_Internal_baseMapResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.get_Internal_baseMapResolutionDelegate>("UnityEngine.TerrainData::get_Internal_baseMapResolution");
			TerrainData.set_Internal_baseMapResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.set_Internal_baseMapResolutionDelegate>("UnityEngine.TerrainData::set_Internal_baseMapResolution");
			TerrainData.SetBaseMapDirtyDelegateField = IL2CPP.ResolveICall<TerrainData.SetBaseMapDirtyDelegate>("UnityEngine.TerrainData::SetBaseMapDirty");
			TerrainData.GetAlphamapTextureDelegateField = IL2CPP.ResolveICall<TerrainData.GetAlphamapTextureDelegate>("UnityEngine.TerrainData::GetAlphamapTexture");
			TerrainData.get_alphamapTextureCountDelegateField = IL2CPP.ResolveICall<TerrainData.get_alphamapTextureCountDelegate>("UnityEngine.TerrainData::get_alphamapTextureCount");
			TerrainData.get_splatPrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.get_splatPrototypesDelegate>("UnityEngine.TerrainData::get_splatPrototypes");
			TerrainData.set_splatPrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.set_splatPrototypesDelegate>("UnityEngine.TerrainData::set_splatPrototypes");
			TerrainData.get_terrainLayersDelegateField = IL2CPP.ResolveICall<TerrainData.get_terrainLayersDelegate>("UnityEngine.TerrainData::get_terrainLayers");
			TerrainData.set_terrainLayersDelegateField = IL2CPP.ResolveICall<TerrainData.set_terrainLayersDelegate>("UnityEngine.TerrainData::set_terrainLayers");
			TerrainData.Internal_DirtyHeightmapRegionDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_DirtyHeightmapRegionDelegate>("UnityEngine.TerrainData::Internal_DirtyHeightmapRegion");
			TerrainData.SyncHeightmapDelegateField = IL2CPP.ResolveICall<TerrainData.SyncHeightmapDelegate>("UnityEngine.TerrainData::SyncHeightmap");
			TerrainData.Internal_DirtyHolesRegionDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_DirtyHolesRegionDelegate>("UnityEngine.TerrainData::Internal_DirtyHolesRegion");
			TerrainData.Internal_SyncHolesDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_SyncHolesDelegate>("UnityEngine.TerrainData::Internal_SyncHoles");
			TerrainData.Internal_MarkAlphamapDirtyRegionDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_MarkAlphamapDirtyRegionDelegate>("UnityEngine.TerrainData::Internal_MarkAlphamapDirtyRegion");
			TerrainData.Internal_ClearAlphamapDirtyRegionDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_ClearAlphamapDirtyRegionDelegate>("UnityEngine.TerrainData::Internal_ClearAlphamapDirtyRegion");
			TerrainData.Internal_SyncAlphamapsDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_SyncAlphamapsDelegate>("UnityEngine.TerrainData::Internal_SyncAlphamaps");
			TerrainData.get_heightmapScale_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.get_heightmapScale_InjectedDelegate>("UnityEngine.TerrainData::get_heightmapScale_Injected");
			TerrainData.set_size_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.set_size_InjectedDelegate>("UnityEngine.TerrainData::set_size_Injected");
			TerrainData.get_bounds_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.get_bounds_InjectedDelegate>("UnityEngine.TerrainData::get_bounds_Injected");
			TerrainData.GetInterpolatedNormal_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.GetInterpolatedNormal_InjectedDelegate>("UnityEngine.TerrainData::GetInterpolatedNormal_Injected");
			TerrainData.get_wavingGrassTint_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.get_wavingGrassTint_InjectedDelegate>("UnityEngine.TerrainData::get_wavingGrassTint_Injected");
			TerrainData.set_wavingGrassTint_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.set_wavingGrassTint_InjectedDelegate>("UnityEngine.TerrainData::set_wavingGrassTint_Injected");
			TerrainData.RemoveTrees_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.RemoveTrees_InjectedDelegate>("UnityEngine.TerrainData::RemoveTrees_Injected");
			TerrainData.Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegate>("UnityEngine.TerrainData::Internal_CopyActiveRenderTextureToHeightmap_Injected");
			TerrainData.Internal_CopyActiveRenderTextureToHoles_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_CopyActiveRenderTextureToHoles_InjectedDelegate>("UnityEngine.TerrainData::Internal_CopyActiveRenderTextureToHoles_Injected");
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004444 File Offset: 0x00002644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157670, XrefRangeEnd = 157672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetBoundaryValue(TerrainData.BoundaryValueType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainData.NativeMethodInfoPtr_GetBoundaryValue_Private_Static_Int32_BoundaryValueType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004484 File Offset: 0x00002684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157672, XrefRangeEnd = 157681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TerrainData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000044C0 File Offset: 0x000026C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157681, XrefRangeEnd = 157711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(TerrainData terrainData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrainData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainData.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_TerrainData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000044F8 File Offset: 0x000026F8
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000268F File Offset: 0x0000088F
		public unsafe Vector3 size
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157711, XrefRangeEnd = 157713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainData.NativeMethodInfoPtr_get_size_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004534 File Offset: 0x00002734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157713, XrefRangeEnd = 157715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAlphamapResolutionInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainData.NativeMethodInfoPtr_GetAlphamapResolutionInternal_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00004570 File Offset: 0x00002770
		public unsafe Il2CppReferenceArray<Terrain> users
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157715, XrefRangeEnd = 157717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainData.NativeMethodInfoPtr_get_users_Internal_get_Il2CppReferenceArray_1_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Terrain>>(intPtr3) : null;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000045B0 File Offset: 0x000027B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157717, XrefRangeEnd = 157719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_size_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainData.NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002576 File Offset: 0x00000776
		public TerrainData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000045F0 File Offset: 0x000027F0
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000257F File Offset: 0x0000077F
		public unsafe static int k_MaximumResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MaximumResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MaximumResolution, (void*)(&value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000460C File Offset: 0x0000280C
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000258D File Offset: 0x0000078D
		public unsafe static int k_MinimumDetailResolutionPerPatch
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MinimumDetailResolutionPerPatch, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MinimumDetailResolutionPerPatch, (void*)(&value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00004628 File Offset: 0x00002828
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000259B File Offset: 0x0000079B
		public unsafe static int k_MaximumDetailResolutionPerPatch
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MaximumDetailResolutionPerPatch, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MaximumDetailResolutionPerPatch, (void*)(&value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00004644 File Offset: 0x00002844
		// (set) Token: 0x0600007D RID: 125 RVA: 0x000025A9 File Offset: 0x000007A9
		public unsafe static int k_MaximumDetailPatchCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MaximumDetailPatchCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MaximumDetailPatchCount, (void*)(&value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00004660 File Offset: 0x00002860
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000025B7 File Offset: 0x000007B7
		public unsafe static int k_MaximumDetailsPerRes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MaximumDetailsPerRes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MaximumDetailsPerRes, (void*)(&value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000467C File Offset: 0x0000287C
		// (set) Token: 0x06000081 RID: 129 RVA: 0x000025C5 File Offset: 0x000007C5
		public unsafe static int k_MinimumAlphamapResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MinimumAlphamapResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MinimumAlphamapResolution, (void*)(&value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00004698 File Offset: 0x00002898
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000025D3 File Offset: 0x000007D3
		public unsafe static int k_MaximumAlphamapResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MaximumAlphamapResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MaximumAlphamapResolution, (void*)(&value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000046B4 File Offset: 0x000028B4
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000025E1 File Offset: 0x000007E1
		public unsafe static int k_MinimumBaseMapResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MinimumBaseMapResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MinimumBaseMapResolution, (void*)(&value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000046D0 File Offset: 0x000028D0
		// (set) Token: 0x06000087 RID: 135 RVA: 0x000025EF File Offset: 0x000007EF
		public unsafe static int k_MaximumBaseMapResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MaximumBaseMapResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MaximumBaseMapResolution, (void*)(&value));
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000025FD File Offset: 0x000007FD
		public void UpdateDirtyRegion(int x, int y, int width, int height, bool syncHeightmapTextureImmediately)
		{
			this.DirtyHeightmapRegion(new RectInt(x, y, width, height), syncHeightmapTextureImmediately ? TerrainHeightmapSyncControl.HeightOnly : TerrainHeightmapSyncControl.None);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002619 File Offset: 0x00000819
		public int heightmapWidth
		{
			get
			{
				return this.heightmapResolution;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002621 File Offset: 0x00000821
		public int heightmapHeight
		{
			get
			{
				return this.heightmapResolution;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000046EC File Offset: 0x000028EC
		public RenderTexture heightmapTexture
		{
			get
			{
				IntPtr intPtr = TerrainData.get_heightmapTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004718 File Offset: 0x00002918
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00004730 File Offset: 0x00002930
		public int heightmapResolution
		{
			get
			{
				return this.internalHeightmapResolution;
			}
			set
			{
				int num = value;
				bool flag = value < 0 || value > TerrainData.k_MaximumResolution;
				if (flag)
				{
					Debug.LogWarning(String.Concat("heightmapResolution is clamped to the range of [0, ", TerrainData.k_MaximumResolution.ToString(), "]."));
					num = Math.Min(TerrainData.k_MaximumResolution, Math.Max(value, 0));
				}
				this.internalHeightmapResolution = num;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002629 File Offset: 0x00000829
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000263B File Offset: 0x0000083B
		public int internalHeightmapResolution
		{
			get
			{
				return TerrainData.get_internalHeightmapResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainData.set_internalHeightmapResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00004794 File Offset: 0x00002994
		public Vector3 heightmapScale
		{
			get
			{
				Vector3 vector;
				this.get_heightmapScale_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000047AC File Offset: 0x000029AC
		public Texture holesTexture
		{
			get
			{
				bool flag = this.IsHolesTextureCompressed();
				Texture texture;
				if (flag)
				{
					texture = this.GetCompressedHolesTexture();
				}
				else
				{
					texture = this.GetHolesTexture();
				}
				return texture;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000264E File Offset: 0x0000084E
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002660 File Offset: 0x00000860
		public bool enableHolesTextureCompression
		{
			get
			{
				return TerrainData.get_enableHolesTextureCompressionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainData.set_enableHolesTextureCompressionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000047DC File Offset: 0x000029DC
		public RenderTexture holesRenderTexture
		{
			get
			{
				return this.GetHolesTexture();
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002673 File Offset: 0x00000873
		public bool IsHolesTextureCompressed()
		{
			return TerrainData.IsHolesTextureCompressedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000047F4 File Offset: 0x000029F4
		public RenderTexture GetHolesTexture()
		{
			IntPtr intPtr = TerrainData.GetHolesTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004820 File Offset: 0x00002A20
		public Texture2D GetCompressedHolesTexture()
		{
			IntPtr intPtr = TerrainData.GetCompressedHolesTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002685 File Offset: 0x00000885
		public int holesResolution
		{
			get
			{
				return this.heightmapResolution - 1;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000484C File Offset: 0x00002A4C
		public Bounds bounds
		{
			get
			{
				Bounds bounds;
				this.get_bounds_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00004864 File Offset: 0x00002A64
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002699 File Offset: 0x00000899
		public float thickness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000269C File Offset: 0x0000089C
		public float GetHeight(int x, int y)
		{
			return TerrainData.GetHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000026B0 File Offset: 0x000008B0
		public float GetInterpolatedHeight(float x, float y)
		{
			return TerrainData.GetInterpolatedHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000487C File Offset: 0x00002A7C
		public Il2CppStructArray<float> GetMaximumHeightError()
		{
			IntPtr intPtr = TerrainData.GetMaximumHeightErrorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000026C4 File Offset: 0x000008C4
		public void OverrideMaximumHeightError(Il2CppStructArray<float> maxError)
		{
			TerrainData.OverrideMaximumHeightErrorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(maxError));
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000048A8 File Offset: 0x00002AA8
		public bool IsHole(int x, int y)
		{
			bool flag = x < 0 || x >= this.holesResolution || y < 0 || y >= this.holesResolution;
			if (flag)
			{
				throw new ArgumentException("Trying to access out-of-bounds terrain holes information.");
			}
			return this.Internal_IsHole(x, y);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000026DC File Offset: 0x000008DC
		public bool Internal_IsHole(int x, int y)
		{
			return TerrainData.Internal_IsHoleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000026F0 File Offset: 0x000008F0
		public float GetSteepness(float x, float y)
		{
			return TerrainData.GetSteepnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000048F4 File Offset: 0x00002AF4
		public Vector3 GetInterpolatedNormal(float x, float y)
		{
			Vector3 vector;
			this.GetInterpolatedNormal_Injected(x, y, out vector);
			return vector;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002704 File Offset: 0x00000904
		public int GetAdjustedSize(int size)
		{
			return TerrainData.GetAdjustedSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), size);
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002717 File Offset: 0x00000917
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002729 File Offset: 0x00000929
		public float wavingGrassStrength
		{
			get
			{
				return TerrainData.get_wavingGrassStrengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainData.set_wavingGrassStrengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000273C File Offset: 0x0000093C
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000274E File Offset: 0x0000094E
		public float wavingGrassAmount
		{
			get
			{
				return TerrainData.get_wavingGrassAmountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainData.set_wavingGrassAmountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00002761 File Offset: 0x00000961
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00002773 File Offset: 0x00000973
		public float wavingGrassSpeed
		{
			get
			{
				return TerrainData.get_wavingGrassSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainData.set_wavingGrassSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000490C File Offset: 0x00002B0C
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002786 File Offset: 0x00000986
		public Color wavingGrassTint
		{
			get
			{
				Color color;
				this.get_wavingGrassTint_Injected(out color);
				return color;
			}
			set
			{
				this.set_wavingGrassTint_Injected(ref value);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00002790 File Offset: 0x00000990
		public int detailWidth
		{
			get
			{
				return TerrainData.get_detailWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000027A2 File Offset: 0x000009A2
		public int detailHeight
		{
			get
			{
				return TerrainData.get_detailHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00004924 File Offset: 0x00002B24
		public static int maxDetailsPerRes
		{
			get
			{
				return TerrainData.k_MaximumDetailsPerRes;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000027B4 File Offset: 0x000009B4
		public void SetDetailResolution(int detailResolution, int resolutionPerPatch)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000027C1 File Offset: 0x000009C1
		public void Internal_SetDetailResolution(int patchCount, int resolutionPerPatch)
		{
			TerrainData.Internal_SetDetailResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), patchCount, resolutionPerPatch);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x000027D5 File Offset: 0x000009D5
		public int detailPatchCount
		{
			get
			{
				return TerrainData.get_detailPatchCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000027E7 File Offset: 0x000009E7
		public int detailResolution
		{
			get
			{
				return TerrainData.get_detailResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000027F9 File Offset: 0x000009F9
		public int detailResolutionPerPatch
		{
			get
			{
				return TerrainData.get_detailResolutionPerPatchDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000280B File Offset: 0x00000A0B
		public void ResetDirtyDetails()
		{
			TerrainData.ResetDirtyDetailsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000281D File Offset: 0x00000A1D
		public void RefreshPrototypes()
		{
			TerrainData.RefreshPrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000493C File Offset: 0x00002B3C
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000282F File Offset: 0x00000A2F
		public Il2CppReferenceArray<DetailPrototype> detailPrototypes
		{
			get
			{
				IntPtr intPtr = TerrainData.get_detailPrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DetailPrototype>>(intPtr2) : null;
			}
			set
			{
				TerrainData.set_detailPrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004968 File Offset: 0x00002B68
		public Il2CppStructArray<int> GetSupportedLayers(int xBase, int yBase, int totalWidth, int totalHeight)
		{
			IntPtr intPtr = TerrainData.GetSupportedLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), xBase, yBase, totalWidth, totalHeight);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00002847 File Offset: 0x00000A47
		public int treeInstanceCount
		{
			get
			{
				return TerrainData.get_treeInstanceCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000499C File Offset: 0x00002B9C
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002859 File Offset: 0x00000A59
		public Il2CppReferenceArray<TreePrototype> treePrototypes
		{
			get
			{
				IntPtr intPtr = TerrainData.get_treePrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TreePrototype>>(intPtr2) : null;
			}
			set
			{
				TerrainData.set_treePrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002871 File Offset: 0x00000A71
		public void RemoveTreePrototype(int index)
		{
			TerrainData.RemoveTreePrototypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002884 File Offset: 0x00000A84
		public void RemoveDetailPrototype(int index)
		{
			TerrainData.RemoveDetailPrototypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002897 File Offset: 0x00000A97
		public bool NeedUpgradeScaledTreePrototypes()
		{
			return TerrainData.NeedUpgradeScaledTreePrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000028A9 File Offset: 0x00000AA9
		public void UpgradeScaledTreePrototype()
		{
			TerrainData.UpgradeScaledTreePrototypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000028BB File Offset: 0x00000ABB
		public int alphamapLayers
		{
			get
			{
				return TerrainData.get_alphamapLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000049C8 File Offset: 0x00002BC8
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x000028CD File Offset: 0x00000ACD
		public int alphamapResolution
		{
			get
			{
				return this.Internal_alphamapResolution;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000028DA File Offset: 0x00000ADA
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x000028EC File Offset: 0x00000AEC
		public int Internal_alphamapResolution
		{
			get
			{
				return TerrainData.get_Internal_alphamapResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainData.set_Internal_alphamapResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000049E0 File Offset: 0x00002BE0
		public int alphamapWidth
		{
			get
			{
				return this.alphamapResolution;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000049F8 File Offset: 0x00002BF8
		public int alphamapHeight
		{
			get
			{
				return this.alphamapResolution;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00004A10 File Offset: 0x00002C10
		// (set) Token: 0x060000CA RID: 202 RVA: 0x000028FF File Offset: 0x00000AFF
		public int baseMapResolution
		{
			get
			{
				return this.Internal_baseMapResolution;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000290C File Offset: 0x00000B0C
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000291E File Offset: 0x00000B1E
		public int Internal_baseMapResolution
		{
			get
			{
				return TerrainData.get_Internal_baseMapResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainData.set_Internal_baseMapResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002931 File Offset: 0x00000B31
		public void SetBaseMapDirty()
		{
			TerrainData.SetBaseMapDirtyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004A28 File Offset: 0x00002C28
		public Texture2D GetAlphamapTexture(int index)
		{
			IntPtr intPtr = TerrainData.GetAlphamapTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00002943 File Offset: 0x00000B43
		public int alphamapTextureCount
		{
			get
			{
				return TerrainData.get_alphamapTextureCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002955 File Offset: 0x00000B55
		public Il2CppReferenceArray<Texture2D> alphamapTextures
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00004A58 File Offset: 0x00002C58
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002962 File Offset: 0x00000B62
		public Il2CppReferenceArray<SplatPrototype> splatPrototypes
		{
			get
			{
				IntPtr intPtr = TerrainData.get_splatPrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SplatPrototype>>(intPtr2) : null;
			}
			set
			{
				TerrainData.set_splatPrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00004A84 File Offset: 0x00002C84
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000297A File Offset: 0x00000B7A
		public Il2CppReferenceArray<TerrainLayer> terrainLayers
		{
			get
			{
				IntPtr intPtr = TerrainData.get_terrainLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TerrainLayer>>(intPtr2) : null;
			}
			set
			{
				TerrainData.set_terrainLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002992 File Offset: 0x00000B92
		public int RemoveTrees(Vector2 position, float radius, int prototypeIndex)
		{
			return this.RemoveTrees_Injected(ref position, radius, prototypeIndex);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000299E File Offset: 0x00000B9E
		public void Internal_CopyActiveRenderTextureToHeightmap(RectInt rect, int destX, int destY, TerrainHeightmapSyncControl syncControl)
		{
			this.Internal_CopyActiveRenderTextureToHeightmap_Injected(ref rect, destX, destY, syncControl);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000029AC File Offset: 0x00000BAC
		public void Internal_DirtyHeightmapRegion(int x, int y, int width, int height, TerrainHeightmapSyncControl syncControl)
		{
			TerrainData.Internal_DirtyHeightmapRegionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y, width, height, syncControl);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000029C5 File Offset: 0x00000BC5
		public void SyncHeightmap()
		{
			TerrainData.SyncHeightmapDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000029D7 File Offset: 0x00000BD7
		public void Internal_CopyActiveRenderTextureToHoles(RectInt rect, int destX, int destY, bool allowDelayedCPUSync)
		{
			this.Internal_CopyActiveRenderTextureToHoles_Injected(ref rect, destX, destY, allowDelayedCPUSync);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000029E5 File Offset: 0x00000BE5
		public void Internal_DirtyHolesRegion(int x, int y, int width, int height, bool allowDelayedCPUSync)
		{
			TerrainData.Internal_DirtyHolesRegionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y, width, height, allowDelayedCPUSync);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000029FE File Offset: 0x00000BFE
		public void Internal_SyncHoles()
		{
			TerrainData.Internal_SyncHolesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002A10 File Offset: 0x00000C10
		public void Internal_MarkAlphamapDirtyRegion(int alphamapIndex, int x, int y, int width, int height)
		{
			TerrainData.Internal_MarkAlphamapDirtyRegionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), alphamapIndex, x, y, width, height);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002A29 File Offset: 0x00000C29
		public void Internal_ClearAlphamapDirtyRegion(int alphamapIndex)
		{
			TerrainData.Internal_ClearAlphamapDirtyRegionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), alphamapIndex);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002A3C File Offset: 0x00000C3C
		public void Internal_SyncAlphamaps()
		{
			TerrainData.Internal_SyncAlphamapsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00004AB0 File Offset: 0x00002CB0
		public static bool SupportsCopyTextureBetweenRTAndTexture
		{
			get
			{
				return (SystemInfo.copyTextureSupport & (CopyTextureSupport)24) == (CopyTextureSupport)24;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00004AD0 File Offset: 0x00002CD0
		public void CopyActiveRenderTextureToHeightmap(RectInt sourceRect, Vector2Int dest, TerrainHeightmapSyncControl syncControl)
		{
			RenderTexture active = RenderTexture.active;
			bool flag = active == null;
			if (flag)
			{
				throw new InvalidOperationException("Active RenderTexture is null.");
			}
			bool flag2 = sourceRect.x < 0 || sourceRect.y < 0 || sourceRect.xMax > active.width || sourceRect.yMax > active.height;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("sourceRect");
			}
			bool flag3 = dest.x < 0 || dest.x + sourceRect.width > this.heightmapResolution;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("dest.x");
			}
			bool flag4 = dest.y < 0 || dest.y + sourceRect.height > this.heightmapResolution;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("dest.y");
			}
			this.Internal_CopyActiveRenderTextureToHeightmap(sourceRect, dest.x, dest.y, syncControl);
			TerrainCallbacks.InvokeHeightmapChangedCallback(this, new RectInt(dest.x, dest.y, sourceRect.width, sourceRect.height), syncControl == TerrainHeightmapSyncControl.HeightAndLod);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00004BEC File Offset: 0x00002DEC
		public void DirtyHeightmapRegion(RectInt region, TerrainHeightmapSyncControl syncControl)
		{
			int heightmapResolution = this.heightmapResolution;
			bool flag = region.x < 0 || region.x >= heightmapResolution;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("region.x");
			}
			bool flag2 = region.width <= 0 || region.xMax > heightmapResolution;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("region.width");
			}
			bool flag3 = region.y < 0 || region.y >= heightmapResolution;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("region.y");
			}
			bool flag4 = region.height <= 0 || region.yMax > heightmapResolution;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("region.height");
			}
			this.Internal_DirtyHeightmapRegion(region.x, region.y, region.width, region.height, syncControl);
			TerrainCallbacks.InvokeHeightmapChangedCallback(this, region, syncControl == TerrainHeightmapSyncControl.HeightAndLod);
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002A4E File Offset: 0x00000C4E
		public static string AlphamapTextureName
		{
			get
			{
				return "alphamap";
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00002A55 File Offset: 0x00000C55
		public static string HolesTextureName
		{
			get
			{
				return "holes";
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004CD4 File Offset: 0x00002ED4
		public void CopyActiveRenderTextureToTexture(string textureName, int textureIndex, RectInt sourceRect, Vector2Int dest, bool allowDelayedCPUSync)
		{
			bool flag = String.IsNullOrEmpty(textureName);
			if (flag)
			{
				throw new ArgumentNullException("textureName");
			}
			RenderTexture active = RenderTexture.active;
			bool flag2 = active == null;
			if (flag2)
			{
				throw new InvalidOperationException("Active RenderTexture is null.");
			}
			bool flag3 = textureName == TerrainData.HolesTextureName;
			int num2;
			int num;
			if (flag3)
			{
				bool flag4 = textureIndex != 0;
				if (flag4)
				{
					throw new ArgumentOutOfRangeException("textureIndex");
				}
				bool flag5 = active == this.holesTexture;
				if (flag5)
				{
					throw new ArgumentException("source", "Active RenderTexture cannot be holesTexture.");
				}
				num = (num2 = this.holesResolution);
			}
			else
			{
				bool flag6 = textureName == TerrainData.AlphamapTextureName;
				if (!flag6)
				{
					throw new ArgumentException(String.Concat("Unrecognized terrain texture name: \"", textureName, "\""));
				}
				bool flag7 = textureIndex < 0 || textureIndex >= this.alphamapTextureCount;
				if (flag7)
				{
					throw new ArgumentOutOfRangeException("textureIndex");
				}
				num = (num2 = this.alphamapResolution);
			}
			bool flag8 = sourceRect.x < 0 || sourceRect.y < 0 || sourceRect.xMax > active.width || sourceRect.yMax > active.height;
			if (flag8)
			{
				throw new ArgumentOutOfRangeException("sourceRect");
			}
			bool flag9 = dest.x < 0 || dest.x + sourceRect.width > num2;
			if (flag9)
			{
				throw new ArgumentOutOfRangeException("dest.x");
			}
			bool flag10 = dest.y < 0 || dest.y + sourceRect.height > num;
			if (flag10)
			{
				throw new ArgumentOutOfRangeException("dest.y");
			}
			bool flag11 = textureName == TerrainData.HolesTextureName;
			if (flag11)
			{
				this.Internal_CopyActiveRenderTextureToHoles(sourceRect, dest.x, dest.y, allowDelayedCPUSync);
			}
			else
			{
				Texture2D alphamapTexture = this.GetAlphamapTexture(textureIndex);
				allowDelayedCPUSync = allowDelayedCPUSync && TerrainData.SupportsCopyTextureBetweenRTAndTexture;
				bool flag12 = allowDelayedCPUSync;
				if (flag12)
				{
					bool flag13 = alphamapTexture.mipmapCount > 1;
					if (flag13)
					{
						RenderTexture temporary = RenderTexture.GetTemporary(new RenderTextureDescriptor(alphamapTexture.width, alphamapTexture.height, active.format)
						{
							sRGB = false,
							useMipMap = true,
							autoGenerateMips = false
						});
						bool flag14 = !temporary.IsCreated();
						if (flag14)
						{
							temporary.Create();
						}
						Graphics.CopyTexture(alphamapTexture, 0, 0, temporary, 0, 0);
						Graphics.CopyTexture(active, 0, 0, sourceRect.x, sourceRect.y, sourceRect.width, sourceRect.height, temporary, 0, 0, dest.x, dest.y);
						temporary.GenerateMips();
						Graphics.CopyTexture(temporary, alphamapTexture);
						RenderTexture.ReleaseTemporary(temporary);
					}
					else
					{
						Graphics.CopyTexture(active, 0, 0, sourceRect.x, sourceRect.y, sourceRect.width, sourceRect.height, alphamapTexture, 0, 0, dest.x, dest.y);
					}
					this.Internal_MarkAlphamapDirtyRegion(textureIndex, dest.x, dest.y, sourceRect.width, sourceRect.height);
				}
				else
				{
					bool flag15 = SystemInfo.graphicsDeviceType == GraphicsDeviceType.Metal || !SystemInfo.graphicsUVStartsAtTop;
					if (flag15)
					{
						alphamapTexture.ReadPixels(new Rect((float)sourceRect.x, (float)sourceRect.y, (float)sourceRect.width, (float)sourceRect.height), dest.x, dest.y);
					}
					else
					{
						alphamapTexture.ReadPixels(new Rect((float)sourceRect.x, (float)(active.height - sourceRect.yMax), (float)sourceRect.width, (float)sourceRect.height), dest.x, dest.y);
					}
					alphamapTexture.Apply(true);
					this.Internal_ClearAlphamapDirtyRegion(textureIndex);
				}
				TerrainCallbacks.InvokeTextureChangedCallback(this, textureName, new RectInt(dest.x, dest.y, sourceRect.width, sourceRect.height), !allowDelayedCPUSync);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000050C4 File Offset: 0x000032C4
		public void DirtyTextureRegion(string textureName, RectInt region, bool allowDelayedCPUSync)
		{
			bool flag = String.IsNullOrEmpty(textureName);
			if (flag)
			{
				throw new ArgumentNullException("textureName");
			}
			bool flag2 = textureName == TerrainData.AlphamapTextureName;
			int num;
			if (flag2)
			{
				num = this.alphamapResolution;
			}
			else
			{
				bool flag3 = textureName == TerrainData.HolesTextureName;
				if (!flag3)
				{
					throw new ArgumentException(String.Concat("Unrecognized terrain texture name: \"", textureName, "\""));
				}
				num = this.holesResolution;
			}
			bool flag4 = region.x < 0 || region.x >= num;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("region.x");
			}
			bool flag5 = region.width <= 0 || region.xMax > num;
			if (flag5)
			{
				throw new ArgumentOutOfRangeException("region.width");
			}
			bool flag6 = region.y < 0 || region.y >= num;
			if (flag6)
			{
				throw new ArgumentOutOfRangeException("region.y");
			}
			bool flag7 = region.height <= 0 || region.yMax > num;
			if (flag7)
			{
				throw new ArgumentOutOfRangeException("region.height");
			}
			bool flag8 = textureName == TerrainData.HolesTextureName;
			if (flag8)
			{
				this.Internal_DirtyHolesRegion(region.x, region.y, region.width, region.height, allowDelayedCPUSync);
			}
			else
			{
				this.Internal_MarkAlphamapDirtyRegion(-1, region.x, region.y, region.width, region.height);
				bool flag9 = !allowDelayedCPUSync;
				if (flag9)
				{
					this.SyncTexture(textureName);
				}
				else
				{
					TerrainCallbacks.InvokeTextureChangedCallback(this, textureName, region, false);
				}
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005254 File Offset: 0x00003454
		public void SyncTexture(string textureName)
		{
			bool flag = String.IsNullOrEmpty(textureName);
			if (flag)
			{
				throw new ArgumentNullException("textureName");
			}
			bool flag2 = textureName == TerrainData.AlphamapTextureName;
			if (flag2)
			{
				this.Internal_SyncAlphamaps();
			}
			else
			{
				bool flag3 = textureName == TerrainData.HolesTextureName;
				if (!flag3)
				{
					throw new ArgumentException(String.Concat("Unrecognized terrain texture name: \"", textureName, "\""));
				}
				bool flag4 = this.IsHolesTextureCompressed();
				if (flag4)
				{
					throw new InvalidOperationException("Holes texture is compressed. Compressed holes texture can not be read back from GPU. Use TerrainData.enableHolesTextureCompression to disable holes texture compression.");
				}
				this.Internal_SyncHoles();
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002A5C File Offset: 0x00000C5C
		public void get_heightmapScale_Injected(out Vector3 ret)
		{
			TerrainData.get_heightmapScale_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002A6F File Offset: 0x00000C6F
		public void set_size_Injected(ref Vector3 value)
		{
			TerrainData.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002A82 File Offset: 0x00000C82
		public void get_bounds_Injected(out Bounds ret)
		{
			TerrainData.get_bounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002A95 File Offset: 0x00000C95
		public void GetInterpolatedNormal_Injected(float x, float y, out Vector3 ret)
		{
			TerrainData.GetInterpolatedNormal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y, out ret);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002AAA File Offset: 0x00000CAA
		public void get_wavingGrassTint_Injected(out Color ret)
		{
			TerrainData.get_wavingGrassTint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002ABD File Offset: 0x00000CBD
		public void set_wavingGrassTint_Injected(ref Color value)
		{
			TerrainData.set_wavingGrassTint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002AD0 File Offset: 0x00000CD0
		public int RemoveTrees_Injected(ref Vector2 position, float radius, int prototypeIndex)
		{
			return TerrainData.RemoveTrees_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, radius, prototypeIndex);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002AE5 File Offset: 0x00000CE5
		public void Internal_CopyActiveRenderTextureToHeightmap_Injected(ref RectInt rect, int destX, int destY, TerrainHeightmapSyncControl syncControl)
		{
			TerrainData.Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rect, destX, destY, syncControl);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002AFC File Offset: 0x00000CFC
		public void Internal_CopyActiveRenderTextureToHoles_Injected(ref RectInt rect, int destX, int destY, bool allowDelayedCPUSync)
		{
			TerrainData.Internal_CopyActiveRenderTextureToHoles_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rect, destX, destY, allowDelayedCPUSync);
		}

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumResolution;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_k_MinimumDetailResolutionPerPatch;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumDetailResolutionPerPatch;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumDetailPatchCount;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumDetailsPerRes;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_k_MinimumAlphamapResolution;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumAlphamapResolution;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_k_MinimumBaseMapResolution;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumBaseMapResolution;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_GetBoundaryValue_Private_Static_Int32_BoundaryValueType_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_TerrainData_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector3_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_GetAlphamapResolutionInternal_Internal_Single_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_get_users_Internal_get_Il2CppReferenceArray_1_Terrain_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000060 RID: 96
		public const string k_ScriptingInterfaceName = "TerrainDataScriptingInterface";

		// Token: 0x04000061 RID: 97
		public const string k_ScriptingInterfacePrefix = "TerrainDataScriptingInterface::";

		// Token: 0x04000062 RID: 98
		public const string k_HeightmapPrefix = "GetHeightmap().";

		// Token: 0x04000063 RID: 99
		public const string k_DetailDatabasePrefix = "GetDetailDatabase().";

		// Token: 0x04000064 RID: 100
		public const string k_TreeDatabasePrefix = "GetTreeDatabase().";

		// Token: 0x04000065 RID: 101
		public const string k_SplatDatabasePrefix = "GetSplatDatabase().";

		// Token: 0x04000066 RID: 102
		private static readonly TerrainData.get_heightmapTextureDelegate get_heightmapTextureDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly TerrainData.get_internalHeightmapResolutionDelegate get_internalHeightmapResolutionDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly TerrainData.set_internalHeightmapResolutionDelegate set_internalHeightmapResolutionDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly TerrainData.get_enableHolesTextureCompressionDelegate get_enableHolesTextureCompressionDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly TerrainData.set_enableHolesTextureCompressionDelegate set_enableHolesTextureCompressionDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly TerrainData.IsHolesTextureCompressedDelegate IsHolesTextureCompressedDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly TerrainData.GetHolesTextureDelegate GetHolesTextureDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly TerrainData.GetCompressedHolesTextureDelegate GetCompressedHolesTextureDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly TerrainData.GetHeightDelegate GetHeightDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly TerrainData.GetInterpolatedHeightDelegate GetInterpolatedHeightDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly TerrainData.GetMaximumHeightErrorDelegate GetMaximumHeightErrorDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly TerrainData.OverrideMaximumHeightErrorDelegate OverrideMaximumHeightErrorDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly TerrainData.Internal_IsHoleDelegate Internal_IsHoleDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly TerrainData.GetSteepnessDelegate GetSteepnessDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly TerrainData.GetAdjustedSizeDelegate GetAdjustedSizeDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly TerrainData.get_wavingGrassStrengthDelegate get_wavingGrassStrengthDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly TerrainData.set_wavingGrassStrengthDelegate set_wavingGrassStrengthDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly TerrainData.get_wavingGrassAmountDelegate get_wavingGrassAmountDelegateField;

		// Token: 0x04000078 RID: 120
		private static readonly TerrainData.set_wavingGrassAmountDelegate set_wavingGrassAmountDelegateField;

		// Token: 0x04000079 RID: 121
		private static readonly TerrainData.get_wavingGrassSpeedDelegate get_wavingGrassSpeedDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly TerrainData.set_wavingGrassSpeedDelegate set_wavingGrassSpeedDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly TerrainData.get_detailWidthDelegate get_detailWidthDelegateField;

		// Token: 0x0400007C RID: 124
		private static readonly TerrainData.get_detailHeightDelegate get_detailHeightDelegateField;

		// Token: 0x0400007D RID: 125
		private static readonly TerrainData.Internal_SetDetailResolutionDelegate Internal_SetDetailResolutionDelegateField;

		// Token: 0x0400007E RID: 126
		private static readonly TerrainData.get_detailPatchCountDelegate get_detailPatchCountDelegateField;

		// Token: 0x0400007F RID: 127
		private static readonly TerrainData.get_detailResolutionDelegate get_detailResolutionDelegateField;

		// Token: 0x04000080 RID: 128
		private static readonly TerrainData.get_detailResolutionPerPatchDelegate get_detailResolutionPerPatchDelegateField;

		// Token: 0x04000081 RID: 129
		private static readonly TerrainData.ResetDirtyDetailsDelegate ResetDirtyDetailsDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly TerrainData.RefreshPrototypesDelegate RefreshPrototypesDelegateField;

		// Token: 0x04000083 RID: 131
		private static readonly TerrainData.get_detailPrototypesDelegate get_detailPrototypesDelegateField;

		// Token: 0x04000084 RID: 132
		private static readonly TerrainData.set_detailPrototypesDelegate set_detailPrototypesDelegateField;

		// Token: 0x04000085 RID: 133
		private static readonly TerrainData.GetSupportedLayersDelegate GetSupportedLayersDelegateField;

		// Token: 0x04000086 RID: 134
		private static readonly TerrainData.get_treeInstanceCountDelegate get_treeInstanceCountDelegateField;

		// Token: 0x04000087 RID: 135
		private static readonly TerrainData.get_treePrototypesDelegate get_treePrototypesDelegateField;

		// Token: 0x04000088 RID: 136
		private static readonly TerrainData.set_treePrototypesDelegate set_treePrototypesDelegateField;

		// Token: 0x04000089 RID: 137
		private static readonly TerrainData.RemoveTreePrototypeDelegate RemoveTreePrototypeDelegateField;

		// Token: 0x0400008A RID: 138
		private static readonly TerrainData.RemoveDetailPrototypeDelegate RemoveDetailPrototypeDelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly TerrainData.NeedUpgradeScaledTreePrototypesDelegate NeedUpgradeScaledTreePrototypesDelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly TerrainData.UpgradeScaledTreePrototypeDelegate UpgradeScaledTreePrototypeDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly TerrainData.get_alphamapLayersDelegate get_alphamapLayersDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly TerrainData.get_Internal_alphamapResolutionDelegate get_Internal_alphamapResolutionDelegateField;

		// Token: 0x0400008F RID: 143
		private static readonly TerrainData.set_Internal_alphamapResolutionDelegate set_Internal_alphamapResolutionDelegateField;

		// Token: 0x04000090 RID: 144
		private static readonly TerrainData.get_Internal_baseMapResolutionDelegate get_Internal_baseMapResolutionDelegateField;

		// Token: 0x04000091 RID: 145
		private static readonly TerrainData.set_Internal_baseMapResolutionDelegate set_Internal_baseMapResolutionDelegateField;

		// Token: 0x04000092 RID: 146
		private static readonly TerrainData.SetBaseMapDirtyDelegate SetBaseMapDirtyDelegateField;

		// Token: 0x04000093 RID: 147
		private static readonly TerrainData.GetAlphamapTextureDelegate GetAlphamapTextureDelegateField;

		// Token: 0x04000094 RID: 148
		private static readonly TerrainData.get_alphamapTextureCountDelegate get_alphamapTextureCountDelegateField;

		// Token: 0x04000095 RID: 149
		private static readonly TerrainData.get_splatPrototypesDelegate get_splatPrototypesDelegateField;

		// Token: 0x04000096 RID: 150
		private static readonly TerrainData.set_splatPrototypesDelegate set_splatPrototypesDelegateField;

		// Token: 0x04000097 RID: 151
		private static readonly TerrainData.get_terrainLayersDelegate get_terrainLayersDelegateField;

		// Token: 0x04000098 RID: 152
		private static readonly TerrainData.set_terrainLayersDelegate set_terrainLayersDelegateField;

		// Token: 0x04000099 RID: 153
		private static readonly TerrainData.Internal_DirtyHeightmapRegionDelegate Internal_DirtyHeightmapRegionDelegateField;

		// Token: 0x0400009A RID: 154
		private static readonly TerrainData.SyncHeightmapDelegate SyncHeightmapDelegateField;

		// Token: 0x0400009B RID: 155
		private static readonly TerrainData.Internal_DirtyHolesRegionDelegate Internal_DirtyHolesRegionDelegateField;

		// Token: 0x0400009C RID: 156
		private static readonly TerrainData.Internal_SyncHolesDelegate Internal_SyncHolesDelegateField;

		// Token: 0x0400009D RID: 157
		private static readonly TerrainData.Internal_MarkAlphamapDirtyRegionDelegate Internal_MarkAlphamapDirtyRegionDelegateField;

		// Token: 0x0400009E RID: 158
		private static readonly TerrainData.Internal_ClearAlphamapDirtyRegionDelegate Internal_ClearAlphamapDirtyRegionDelegateField;

		// Token: 0x0400009F RID: 159
		private static readonly TerrainData.Internal_SyncAlphamapsDelegate Internal_SyncAlphamapsDelegateField;

		// Token: 0x040000A0 RID: 160
		private static readonly TerrainData.get_heightmapScale_InjectedDelegate get_heightmapScale_InjectedDelegateField;

		// Token: 0x040000A1 RID: 161
		private static readonly TerrainData.set_size_InjectedDelegate set_size_InjectedDelegateField;

		// Token: 0x040000A2 RID: 162
		private static readonly TerrainData.get_bounds_InjectedDelegate get_bounds_InjectedDelegateField;

		// Token: 0x040000A3 RID: 163
		private static readonly TerrainData.GetInterpolatedNormal_InjectedDelegate GetInterpolatedNormal_InjectedDelegateField;

		// Token: 0x040000A4 RID: 164
		private static readonly TerrainData.get_wavingGrassTint_InjectedDelegate get_wavingGrassTint_InjectedDelegateField;

		// Token: 0x040000A5 RID: 165
		private static readonly TerrainData.set_wavingGrassTint_InjectedDelegate set_wavingGrassTint_InjectedDelegateField;

		// Token: 0x040000A6 RID: 166
		private static readonly TerrainData.RemoveTrees_InjectedDelegate RemoveTrees_InjectedDelegateField;

		// Token: 0x040000A7 RID: 167
		private static readonly TerrainData.Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegate Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegateField;

		// Token: 0x040000A8 RID: 168
		private static readonly TerrainData.Internal_CopyActiveRenderTextureToHoles_InjectedDelegate Internal_CopyActiveRenderTextureToHoles_InjectedDelegateField;

		// Token: 0x02000060 RID: 96
		public enum BoundaryValueType
		{
			// Token: 0x040000F8 RID: 248
			MaxHeightmapRes,
			// Token: 0x040000F9 RID: 249
			MinDetailResPerPatch,
			// Token: 0x040000FA RID: 250
			MaxDetailResPerPatch,
			// Token: 0x040000FB RID: 251
			MaxDetailPatchCount,
			// Token: 0x040000FC RID: 252
			MaxDetailsPerRes,
			// Token: 0x040000FD RID: 253
			MinAlphamapRes,
			// Token: 0x040000FE RID: 254
			MaxAlphamapRes,
			// Token: 0x040000FF RID: 255
			MinBaseMapRes,
			// Token: 0x04000100 RID: 256
			MaxBaseMapRes
		}

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x06000242 RID: 578
		private delegate IntPtr get_heightmapTextureDelegate(IntPtr @this);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x06000244 RID: 580
		private delegate int get_internalHeightmapResolutionDelegate(IntPtr @this);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x06000246 RID: 582
		private delegate void set_internalHeightmapResolutionDelegate(IntPtr @this, int value);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x06000248 RID: 584
		private delegate bool get_enableHolesTextureCompressionDelegate(IntPtr @this);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x0600024A RID: 586
		private delegate void set_enableHolesTextureCompressionDelegate(IntPtr @this, bool value);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x0600024C RID: 588
		private delegate bool IsHolesTextureCompressedDelegate(IntPtr @this);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x0600024E RID: 590
		private delegate IntPtr GetHolesTextureDelegate(IntPtr @this);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x06000250 RID: 592
		private delegate IntPtr GetCompressedHolesTextureDelegate(IntPtr @this);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x06000252 RID: 594
		private delegate float GetHeightDelegate(IntPtr @this, int x, int y);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x06000254 RID: 596
		private delegate float GetInterpolatedHeightDelegate(IntPtr @this, float x, float y);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x06000256 RID: 598
		private delegate IntPtr GetMaximumHeightErrorDelegate(IntPtr @this);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x06000258 RID: 600
		private delegate void OverrideMaximumHeightErrorDelegate(IntPtr @this, IntPtr maxError);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x0600025A RID: 602
		private delegate bool Internal_IsHoleDelegate(IntPtr @this, int x, int y);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x0600025C RID: 604
		private delegate float GetSteepnessDelegate(IntPtr @this, float x, float y);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x0600025E RID: 606
		private delegate int GetAdjustedSizeDelegate(IntPtr @this, int size);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x06000260 RID: 608
		private delegate float get_wavingGrassStrengthDelegate(IntPtr @this);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x06000262 RID: 610
		private delegate void set_wavingGrassStrengthDelegate(IntPtr @this, float value);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x06000264 RID: 612
		private delegate float get_wavingGrassAmountDelegate(IntPtr @this);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x06000266 RID: 614
		private delegate void set_wavingGrassAmountDelegate(IntPtr @this, float value);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x06000268 RID: 616
		private delegate float get_wavingGrassSpeedDelegate(IntPtr @this);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x0600026A RID: 618
		private delegate void set_wavingGrassSpeedDelegate(IntPtr @this, float value);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x0600026C RID: 620
		private delegate int get_detailWidthDelegate(IntPtr @this);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x0600026E RID: 622
		private delegate int get_detailHeightDelegate(IntPtr @this);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x06000270 RID: 624
		private delegate void Internal_SetDetailResolutionDelegate(IntPtr @this, int patchCount, int resolutionPerPatch);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x06000272 RID: 626
		private delegate int get_detailPatchCountDelegate(IntPtr @this);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x06000274 RID: 628
		private delegate int get_detailResolutionDelegate(IntPtr @this);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x06000276 RID: 630
		private delegate int get_detailResolutionPerPatchDelegate(IntPtr @this);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x06000278 RID: 632
		private delegate void ResetDirtyDetailsDelegate(IntPtr @this);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x0600027A RID: 634
		private delegate void RefreshPrototypesDelegate(IntPtr @this);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x0600027C RID: 636
		private delegate IntPtr get_detailPrototypesDelegate(IntPtr @this);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x0600027E RID: 638
		private delegate void set_detailPrototypesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x06000280 RID: 640
		private delegate IntPtr GetSupportedLayersDelegate(IntPtr @this, int xBase, int yBase, int totalWidth, int totalHeight);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x06000282 RID: 642
		private delegate int get_treeInstanceCountDelegate(IntPtr @this);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x06000284 RID: 644
		private delegate IntPtr get_treePrototypesDelegate(IntPtr @this);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x06000286 RID: 646
		private delegate void set_treePrototypesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x06000288 RID: 648
		private delegate void RemoveTreePrototypeDelegate(IntPtr @this, int index);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x0600028A RID: 650
		private delegate void RemoveDetailPrototypeDelegate(IntPtr @this, int index);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x0600028C RID: 652
		private delegate bool NeedUpgradeScaledTreePrototypesDelegate(IntPtr @this);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x0600028E RID: 654
		private delegate void UpgradeScaledTreePrototypeDelegate(IntPtr @this);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x06000290 RID: 656
		private delegate int get_alphamapLayersDelegate(IntPtr @this);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x06000292 RID: 658
		private delegate int get_Internal_alphamapResolutionDelegate(IntPtr @this);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x06000294 RID: 660
		private delegate void set_Internal_alphamapResolutionDelegate(IntPtr @this, int value);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x06000296 RID: 662
		private delegate int get_Internal_baseMapResolutionDelegate(IntPtr @this);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x06000298 RID: 664
		private delegate void set_Internal_baseMapResolutionDelegate(IntPtr @this, int value);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x0600029A RID: 666
		private delegate void SetBaseMapDirtyDelegate(IntPtr @this);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x0600029C RID: 668
		private delegate IntPtr GetAlphamapTextureDelegate(IntPtr @this, int index);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x0600029E RID: 670
		private delegate int get_alphamapTextureCountDelegate(IntPtr @this);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060002A0 RID: 672
		private delegate IntPtr get_splatPrototypesDelegate(IntPtr @this);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060002A2 RID: 674
		private delegate void set_splatPrototypesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060002A4 RID: 676
		private delegate IntPtr get_terrainLayersDelegate(IntPtr @this);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x060002A6 RID: 678
		private delegate void set_terrainLayersDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x060002A8 RID: 680
		private delegate void Internal_DirtyHeightmapRegionDelegate(IntPtr @this, int x, int y, int width, int height, TerrainHeightmapSyncControl syncControl);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x060002AA RID: 682
		private delegate void SyncHeightmapDelegate(IntPtr @this);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x060002AC RID: 684
		private delegate void Internal_DirtyHolesRegionDelegate(IntPtr @this, int x, int y, int width, int height, bool allowDelayedCPUSync);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x060002AE RID: 686
		private delegate void Internal_SyncHolesDelegate(IntPtr @this);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x060002B0 RID: 688
		private delegate void Internal_MarkAlphamapDirtyRegionDelegate(IntPtr @this, int alphamapIndex, int x, int y, int width, int height);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x060002B2 RID: 690
		private delegate void Internal_ClearAlphamapDirtyRegionDelegate(IntPtr @this, int alphamapIndex);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x060002B4 RID: 692
		private delegate void Internal_SyncAlphamapsDelegate(IntPtr @this);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x060002B6 RID: 694
		private delegate void get_heightmapScale_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x060002B8 RID: 696
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x060002BA RID: 698
		private delegate void get_bounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x060002BC RID: 700
		private delegate void GetInterpolatedNormal_InjectedDelegate(IntPtr @this, float x, float y, [Out] IntPtr ret);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x060002BE RID: 702
		private delegate void get_wavingGrassTint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x060002C0 RID: 704
		private delegate void set_wavingGrassTint_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x060002C2 RID: 706
		private delegate int RemoveTrees_InjectedDelegate(IntPtr @this, IntPtr position, float radius, int prototypeIndex);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x060002C4 RID: 708
		private delegate void Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegate(IntPtr @this, IntPtr rect, int destX, int destY, TerrainHeightmapSyncControl syncControl);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x060002C6 RID: 710
		private delegate void Internal_CopyActiveRenderTextureToHoles_InjectedDelegate(IntPtr @this, IntPtr rect, int destX, int destY, bool allowDelayedCPUSync);
	}
}
