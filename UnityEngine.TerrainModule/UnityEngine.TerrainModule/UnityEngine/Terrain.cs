using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public sealed class Terrain : Behaviour
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00003548 File Offset: 0x00001748
		// Note: this type is marked as 'beforefieldinit'.
		static Terrain()
		{
			Il2CppClassPointerStore<Terrain>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine", "Terrain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Terrain>.NativeClassPtr);
			Terrain.NativeMethodInfoPtr_get_terrainData_Public_get_TerrainData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663297);
			Terrain.NativeMethodInfoPtr_get_allowAutoConnect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663298);
			Terrain.NativeMethodInfoPtr_get_groupingID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663299);
			Terrain.NativeMethodInfoPtr_SetNeighbors_Public_Void_Terrain_Terrain_Terrain_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663300);
			Terrain.NativeMethodInfoPtr_get_activeTerrains_Public_Static_get_Il2CppReferenceArray_1_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663301);
			Terrain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663302);
			Terrain.set_terrainDataDelegateField = IL2CPP.ResolveICall<Terrain.set_terrainDataDelegate>("UnityEngine.Terrain::set_terrainData");
			Terrain.get_treeDistanceDelegateField = IL2CPP.ResolveICall<Terrain.get_treeDistanceDelegate>("UnityEngine.Terrain::get_treeDistance");
			Terrain.set_treeDistanceDelegateField = IL2CPP.ResolveICall<Terrain.set_treeDistanceDelegate>("UnityEngine.Terrain::set_treeDistance");
			Terrain.get_treeBillboardDistanceDelegateField = IL2CPP.ResolveICall<Terrain.get_treeBillboardDistanceDelegate>("UnityEngine.Terrain::get_treeBillboardDistance");
			Terrain.set_treeBillboardDistanceDelegateField = IL2CPP.ResolveICall<Terrain.set_treeBillboardDistanceDelegate>("UnityEngine.Terrain::set_treeBillboardDistance");
			Terrain.get_treeCrossFadeLengthDelegateField = IL2CPP.ResolveICall<Terrain.get_treeCrossFadeLengthDelegate>("UnityEngine.Terrain::get_treeCrossFadeLength");
			Terrain.set_treeCrossFadeLengthDelegateField = IL2CPP.ResolveICall<Terrain.set_treeCrossFadeLengthDelegate>("UnityEngine.Terrain::set_treeCrossFadeLength");
			Terrain.get_treeMaximumFullLODCountDelegateField = IL2CPP.ResolveICall<Terrain.get_treeMaximumFullLODCountDelegate>("UnityEngine.Terrain::get_treeMaximumFullLODCount");
			Terrain.set_treeMaximumFullLODCountDelegateField = IL2CPP.ResolveICall<Terrain.set_treeMaximumFullLODCountDelegate>("UnityEngine.Terrain::set_treeMaximumFullLODCount");
			Terrain.get_detailObjectDistanceDelegateField = IL2CPP.ResolveICall<Terrain.get_detailObjectDistanceDelegate>("UnityEngine.Terrain::get_detailObjectDistance");
			Terrain.set_detailObjectDistanceDelegateField = IL2CPP.ResolveICall<Terrain.set_detailObjectDistanceDelegate>("UnityEngine.Terrain::set_detailObjectDistance");
			Terrain.get_detailObjectDensityDelegateField = IL2CPP.ResolveICall<Terrain.get_detailObjectDensityDelegate>("UnityEngine.Terrain::get_detailObjectDensity");
			Terrain.set_detailObjectDensityDelegateField = IL2CPP.ResolveICall<Terrain.set_detailObjectDensityDelegate>("UnityEngine.Terrain::set_detailObjectDensity");
			Terrain.get_heightmapPixelErrorDelegateField = IL2CPP.ResolveICall<Terrain.get_heightmapPixelErrorDelegate>("UnityEngine.Terrain::get_heightmapPixelError");
			Terrain.set_heightmapPixelErrorDelegateField = IL2CPP.ResolveICall<Terrain.set_heightmapPixelErrorDelegate>("UnityEngine.Terrain::set_heightmapPixelError");
			Terrain.get_heightmapMaximumLODDelegateField = IL2CPP.ResolveICall<Terrain.get_heightmapMaximumLODDelegate>("UnityEngine.Terrain::get_heightmapMaximumLOD");
			Terrain.set_heightmapMaximumLODDelegateField = IL2CPP.ResolveICall<Terrain.set_heightmapMaximumLODDelegate>("UnityEngine.Terrain::set_heightmapMaximumLOD");
			Terrain.get_basemapDistanceDelegateField = IL2CPP.ResolveICall<Terrain.get_basemapDistanceDelegate>("UnityEngine.Terrain::get_basemapDistance");
			Terrain.set_basemapDistanceDelegateField = IL2CPP.ResolveICall<Terrain.set_basemapDistanceDelegate>("UnityEngine.Terrain::set_basemapDistance");
			Terrain.get_lightmapIndexDelegateField = IL2CPP.ResolveICall<Terrain.get_lightmapIndexDelegate>("UnityEngine.Terrain::get_lightmapIndex");
			Terrain.set_lightmapIndexDelegateField = IL2CPP.ResolveICall<Terrain.set_lightmapIndexDelegate>("UnityEngine.Terrain::set_lightmapIndex");
			Terrain.get_realtimeLightmapIndexDelegateField = IL2CPP.ResolveICall<Terrain.get_realtimeLightmapIndexDelegate>("UnityEngine.Terrain::get_realtimeLightmapIndex");
			Terrain.set_realtimeLightmapIndexDelegateField = IL2CPP.ResolveICall<Terrain.set_realtimeLightmapIndexDelegate>("UnityEngine.Terrain::set_realtimeLightmapIndex");
			Terrain.get_freeUnusedRenderingResourcesDelegateField = IL2CPP.ResolveICall<Terrain.get_freeUnusedRenderingResourcesDelegate>("UnityEngine.Terrain::get_freeUnusedRenderingResources");
			Terrain.set_freeUnusedRenderingResourcesDelegateField = IL2CPP.ResolveICall<Terrain.set_freeUnusedRenderingResourcesDelegate>("UnityEngine.Terrain::set_freeUnusedRenderingResources");
			Terrain.get_shadowCastingModeDelegateField = IL2CPP.ResolveICall<Terrain.get_shadowCastingModeDelegate>("UnityEngine.Terrain::get_shadowCastingMode");
			Terrain.set_shadowCastingModeDelegateField = IL2CPP.ResolveICall<Terrain.set_shadowCastingModeDelegate>("UnityEngine.Terrain::set_shadowCastingMode");
			Terrain.get_reflectionProbeUsageDelegateField = IL2CPP.ResolveICall<Terrain.get_reflectionProbeUsageDelegate>("UnityEngine.Terrain::get_reflectionProbeUsage");
			Terrain.set_reflectionProbeUsageDelegateField = IL2CPP.ResolveICall<Terrain.set_reflectionProbeUsageDelegate>("UnityEngine.Terrain::set_reflectionProbeUsage");
			Terrain.get_materialTemplateDelegateField = IL2CPP.ResolveICall<Terrain.get_materialTemplateDelegate>("UnityEngine.Terrain::get_materialTemplate");
			Terrain.set_materialTemplateDelegateField = IL2CPP.ResolveICall<Terrain.set_materialTemplateDelegate>("UnityEngine.Terrain::set_materialTemplate");
			Terrain.get_drawHeightmapDelegateField = IL2CPP.ResolveICall<Terrain.get_drawHeightmapDelegate>("UnityEngine.Terrain::get_drawHeightmap");
			Terrain.set_drawHeightmapDelegateField = IL2CPP.ResolveICall<Terrain.set_drawHeightmapDelegate>("UnityEngine.Terrain::set_drawHeightmap");
			Terrain.set_allowAutoConnectDelegateField = IL2CPP.ResolveICall<Terrain.set_allowAutoConnectDelegate>("UnityEngine.Terrain::set_allowAutoConnect");
			Terrain.set_groupingIDDelegateField = IL2CPP.ResolveICall<Terrain.set_groupingIDDelegate>("UnityEngine.Terrain::set_groupingID");
			Terrain.get_drawInstancedDelegateField = IL2CPP.ResolveICall<Terrain.get_drawInstancedDelegate>("UnityEngine.Terrain::get_drawInstanced");
			Terrain.set_drawInstancedDelegateField = IL2CPP.ResolveICall<Terrain.set_drawInstancedDelegate>("UnityEngine.Terrain::set_drawInstanced");
			Terrain.get_normalmapTextureDelegateField = IL2CPP.ResolveICall<Terrain.get_normalmapTextureDelegate>("UnityEngine.Terrain::get_normalmapTexture");
			Terrain.get_drawTreesAndFoliageDelegateField = IL2CPP.ResolveICall<Terrain.get_drawTreesAndFoliageDelegate>("UnityEngine.Terrain::get_drawTreesAndFoliage");
			Terrain.set_drawTreesAndFoliageDelegateField = IL2CPP.ResolveICall<Terrain.set_drawTreesAndFoliageDelegate>("UnityEngine.Terrain::set_drawTreesAndFoliage");
			Terrain.get_treeLODBiasMultiplierDelegateField = IL2CPP.ResolveICall<Terrain.get_treeLODBiasMultiplierDelegate>("UnityEngine.Terrain::get_treeLODBiasMultiplier");
			Terrain.set_treeLODBiasMultiplierDelegateField = IL2CPP.ResolveICall<Terrain.set_treeLODBiasMultiplierDelegate>("UnityEngine.Terrain::set_treeLODBiasMultiplier");
			Terrain.get_collectDetailPatchesDelegateField = IL2CPP.ResolveICall<Terrain.get_collectDetailPatchesDelegate>("UnityEngine.Terrain::get_collectDetailPatches");
			Terrain.set_collectDetailPatchesDelegateField = IL2CPP.ResolveICall<Terrain.set_collectDetailPatchesDelegate>("UnityEngine.Terrain::set_collectDetailPatches");
			Terrain.get_editorRenderFlagsDelegateField = IL2CPP.ResolveICall<Terrain.get_editorRenderFlagsDelegate>("UnityEngine.Terrain::get_editorRenderFlags");
			Terrain.set_editorRenderFlagsDelegateField = IL2CPP.ResolveICall<Terrain.set_editorRenderFlagsDelegate>("UnityEngine.Terrain::set_editorRenderFlags");
			Terrain.FlushDelegateField = IL2CPP.ResolveICall<Terrain.FlushDelegate>("UnityEngine.Terrain::Flush");
			Terrain.SetSplatMaterialPropertyBlockDelegateField = IL2CPP.ResolveICall<Terrain.SetSplatMaterialPropertyBlockDelegate>("UnityEngine.Terrain::SetSplatMaterialPropertyBlock");
			Terrain.Internal_GetSplatMaterialPropertyBlockDelegateField = IL2CPP.ResolveICall<Terrain.Internal_GetSplatMaterialPropertyBlockDelegate>("UnityEngine.Terrain::Internal_GetSplatMaterialPropertyBlock");
			Terrain.get_preserveTreePrototypeLayersDelegateField = IL2CPP.ResolveICall<Terrain.get_preserveTreePrototypeLayersDelegate>("UnityEngine.Terrain::get_preserveTreePrototypeLayers");
			Terrain.set_preserveTreePrototypeLayersDelegateField = IL2CPP.ResolveICall<Terrain.set_preserveTreePrototypeLayersDelegate>("UnityEngine.Terrain::set_preserveTreePrototypeLayers");
			Terrain.get_heightmapFormatDelegateField = IL2CPP.ResolveICall<Terrain.get_heightmapFormatDelegate>("UnityEngine.Terrain::get_heightmapFormat");
			Terrain.get_normalmapFormatDelegateField = IL2CPP.ResolveICall<Terrain.get_normalmapFormatDelegate>("UnityEngine.Terrain::get_normalmapFormat");
			Terrain.get_holesFormatDelegateField = IL2CPP.ResolveICall<Terrain.get_holesFormatDelegate>("UnityEngine.Terrain::get_holesFormat");
			Terrain.get_compressedHolesFormatDelegateField = IL2CPP.ResolveICall<Terrain.get_compressedHolesFormatDelegate>("UnityEngine.Terrain::get_compressedHolesFormat");
			Terrain.get_activeTerrainDelegateField = IL2CPP.ResolveICall<Terrain.get_activeTerrainDelegate>("UnityEngine.Terrain::get_activeTerrain");
			Terrain.SetConnectivityDirtyDelegateField = IL2CPP.ResolveICall<Terrain.SetConnectivityDirtyDelegate>("UnityEngine.Terrain::SetConnectivityDirty");
			Terrain.CreateTerrainGameObjectDelegateField = IL2CPP.ResolveICall<Terrain.CreateTerrainGameObjectDelegate>("UnityEngine.Terrain::CreateTerrainGameObject");
			Terrain.get_leftNeighborDelegateField = IL2CPP.ResolveICall<Terrain.get_leftNeighborDelegate>("UnityEngine.Terrain::get_leftNeighbor");
			Terrain.get_rightNeighborDelegateField = IL2CPP.ResolveICall<Terrain.get_rightNeighborDelegate>("UnityEngine.Terrain::get_rightNeighbor");
			Terrain.get_topNeighborDelegateField = IL2CPP.ResolveICall<Terrain.get_topNeighborDelegate>("UnityEngine.Terrain::get_topNeighbor");
			Terrain.get_bottomNeighborDelegateField = IL2CPP.ResolveICall<Terrain.get_bottomNeighborDelegate>("UnityEngine.Terrain::get_bottomNeighbor");
			Terrain.get_renderingLayerMaskDelegateField = IL2CPP.ResolveICall<Terrain.get_renderingLayerMaskDelegate>("UnityEngine.Terrain::get_renderingLayerMask");
			Terrain.set_renderingLayerMaskDelegateField = IL2CPP.ResolveICall<Terrain.set_renderingLayerMaskDelegate>("UnityEngine.Terrain::set_renderingLayerMask");
			Terrain.get_lightmapScaleOffset_InjectedDelegateField = IL2CPP.ResolveICall<Terrain.get_lightmapScaleOffset_InjectedDelegate>("UnityEngine.Terrain::get_lightmapScaleOffset_Injected");
			Terrain.set_lightmapScaleOffset_InjectedDelegateField = IL2CPP.ResolveICall<Terrain.set_lightmapScaleOffset_InjectedDelegate>("UnityEngine.Terrain::set_lightmapScaleOffset_Injected");
			Terrain.get_realtimeLightmapScaleOffset_InjectedDelegateField = IL2CPP.ResolveICall<Terrain.get_realtimeLightmapScaleOffset_InjectedDelegate>("UnityEngine.Terrain::get_realtimeLightmapScaleOffset_Injected");
			Terrain.set_realtimeLightmapScaleOffset_InjectedDelegateField = IL2CPP.ResolveICall<Terrain.set_realtimeLightmapScaleOffset_InjectedDelegate>("UnityEngine.Terrain::set_realtimeLightmapScaleOffset_Injected");
			Terrain.get_patchBoundsMultiplier_InjectedDelegateField = IL2CPP.ResolveICall<Terrain.get_patchBoundsMultiplier_InjectedDelegate>("UnityEngine.Terrain::get_patchBoundsMultiplier_Injected");
			Terrain.set_patchBoundsMultiplier_InjectedDelegateField = IL2CPP.ResolveICall<Terrain.set_patchBoundsMultiplier_InjectedDelegate>("UnityEngine.Terrain::set_patchBoundsMultiplier_Injected");
			Terrain.SampleHeight_InjectedDelegateField = IL2CPP.ResolveICall<Terrain.SampleHeight_InjectedDelegate>("UnityEngine.Terrain::SampleHeight_Injected");
			Terrain.GetPosition_InjectedDelegateField = IL2CPP.ResolveICall<Terrain.GetPosition_InjectedDelegate>("UnityEngine.Terrain::GetPosition_Injected");
			Terrain.RemoveTrees_InjectedDelegateField = IL2CPP.ResolveICall<Terrain.RemoveTrees_InjectedDelegate>("UnityEngine.Terrain::RemoveTrees_Injected");
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00003A38 File Offset: 0x00001C38
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe TerrainData terrainData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157659, XrefRangeEnd = 157661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Terrain.NativeMethodInfoPtr_get_terrainData_Public_get_TerrainData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TerrainData>(intPtr3) : null;
			}
			set
			{
				Terrain.set_terrainDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00003A78 File Offset: 0x00001C78
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000022C8 File Offset: 0x000004C8
		public unsafe bool allowAutoConnect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157661, XrefRangeEnd = 157663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Terrain.NativeMethodInfoPtr_get_allowAutoConnect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Terrain.set_allowAutoConnectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00003AB4 File Offset: 0x00001CB4
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000022DB File Offset: 0x000004DB
		public unsafe int groupingID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157663, XrefRangeEnd = 157665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Terrain.NativeMethodInfoPtr_get_groupingID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Terrain.set_groupingIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00003AF0 File Offset: 0x00001CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157667, RefRangeEnd = 157668, XrefRangeStart = 157665, XrefRangeEnd = 157667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(top);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bottom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Terrain.NativeMethodInfoPtr_SetNeighbors_Public_Void_Terrain_Terrain_Terrain_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00003B6C File Offset: 0x00001D6C
		public unsafe static Il2CppReferenceArray<Terrain> activeTerrains
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157668, XrefRangeEnd = 157670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Terrain.NativeMethodInfoPtr_get_activeTerrains_Public_Static_get_Il2CppReferenceArray_1_Terrain_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Terrain>>(intPtr3) : null;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Terrain()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Terrain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Terrain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		public Terrain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002071 File Offset: 0x00000271
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002083 File Offset: 0x00000283
		public float treeDistance
		{
			get
			{
				return Terrain.get_treeDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_treeDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000020A8 File Offset: 0x000002A8
		public float treeBillboardDistance
		{
			get
			{
				return Terrain.get_treeBillboardDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_treeBillboardDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020BB File Offset: 0x000002BB
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000020CD File Offset: 0x000002CD
		public float treeCrossFadeLength
		{
			get
			{
				return Terrain.get_treeCrossFadeLengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_treeCrossFadeLengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020E0 File Offset: 0x000002E0
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000020F2 File Offset: 0x000002F2
		public int treeMaximumFullLODCount
		{
			get
			{
				return Terrain.get_treeMaximumFullLODCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_treeMaximumFullLODCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002105 File Offset: 0x00000305
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002117 File Offset: 0x00000317
		public float detailObjectDistance
		{
			get
			{
				return Terrain.get_detailObjectDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_detailObjectDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000015 RID: 21 RVA: 0x0000213C File Offset: 0x0000033C
		public float detailObjectDensity
		{
			get
			{
				return Terrain.get_detailObjectDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_detailObjectDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000214F File Offset: 0x0000034F
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002161 File Offset: 0x00000361
		public float heightmapPixelError
		{
			get
			{
				return Terrain.get_heightmapPixelErrorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_heightmapPixelErrorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002174 File Offset: 0x00000374
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002186 File Offset: 0x00000386
		public int heightmapMaximumLOD
		{
			get
			{
				return Terrain.get_heightmapMaximumLODDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_heightmapMaximumLODDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002199 File Offset: 0x00000399
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000021AB File Offset: 0x000003AB
		public float basemapDistance
		{
			get
			{
				return Terrain.get_basemapDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_basemapDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000021BE File Offset: 0x000003BE
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000021D0 File Offset: 0x000003D0
		public int lightmapIndex
		{
			get
			{
				return Terrain.get_lightmapIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_lightmapIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000021E3 File Offset: 0x000003E3
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000021F5 File Offset: 0x000003F5
		public int realtimeLightmapIndex
		{
			get
			{
				return Terrain.get_realtimeLightmapIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_realtimeLightmapIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003BDC File Offset: 0x00001DDC
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002208 File Offset: 0x00000408
		public Vector4 lightmapScaleOffset
		{
			get
			{
				Vector4 vector;
				this.get_lightmapScaleOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_lightmapScaleOffset_Injected(ref value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003BF4 File Offset: 0x00001DF4
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002212 File Offset: 0x00000412
		public Vector4 realtimeLightmapScaleOffset
		{
			get
			{
				Vector4 vector;
				this.get_realtimeLightmapScaleOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_realtimeLightmapScaleOffset_Injected(ref value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000221C File Offset: 0x0000041C
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000222E File Offset: 0x0000042E
		public bool freeUnusedRenderingResources
		{
			get
			{
				return Terrain.get_freeUnusedRenderingResourcesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_freeUnusedRenderingResourcesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002241 File Offset: 0x00000441
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002253 File Offset: 0x00000453
		public ShadowCastingMode shadowCastingMode
		{
			get
			{
				return Terrain.get_shadowCastingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_shadowCastingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002266 File Offset: 0x00000466
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002278 File Offset: 0x00000478
		public ReflectionProbeUsage reflectionProbeUsage
		{
			get
			{
				return Terrain.get_reflectionProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_reflectionProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003C0C File Offset: 0x00001E0C
		// (set) Token: 0x0600002B RID: 43 RVA: 0x0000228B File Offset: 0x0000048B
		public Material materialTemplate
		{
			get
			{
				IntPtr intPtr = Terrain.get_materialTemplateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				Terrain.set_materialTemplateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000022A3 File Offset: 0x000004A3
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000022B5 File Offset: 0x000004B5
		public bool drawHeightmap
		{
			get
			{
				return Terrain.get_drawHeightmapDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_drawHeightmapDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000022EE File Offset: 0x000004EE
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002300 File Offset: 0x00000500
		public bool drawInstanced
		{
			get
			{
				return Terrain.get_drawInstancedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_drawInstancedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00003C38 File Offset: 0x00001E38
		public RenderTexture normalmapTexture
		{
			get
			{
				IntPtr intPtr = Terrain.get_normalmapTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002313 File Offset: 0x00000513
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002325 File Offset: 0x00000525
		public bool drawTreesAndFoliage
		{
			get
			{
				return Terrain.get_drawTreesAndFoliageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_drawTreesAndFoliageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00003C64 File Offset: 0x00001E64
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002338 File Offset: 0x00000538
		public Vector3 patchBoundsMultiplier
		{
			get
			{
				Vector3 vector;
				this.get_patchBoundsMultiplier_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_patchBoundsMultiplier_Injected(ref value);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002342 File Offset: 0x00000542
		public float SampleHeight(Vector3 worldPosition)
		{
			return this.SampleHeight_Injected(ref worldPosition);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000234C File Offset: 0x0000054C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000235E File Offset: 0x0000055E
		public float treeLODBiasMultiplier
		{
			get
			{
				return Terrain.get_treeLODBiasMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_treeLODBiasMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002371 File Offset: 0x00000571
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002383 File Offset: 0x00000583
		public bool collectDetailPatches
		{
			get
			{
				return Terrain.get_collectDetailPatchesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_collectDetailPatchesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002396 File Offset: 0x00000596
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000023A8 File Offset: 0x000005A8
		public TerrainRenderFlags editorRenderFlags
		{
			get
			{
				return Terrain.get_editorRenderFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_editorRenderFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003C7C File Offset: 0x00001E7C
		public Vector3 GetPosition()
		{
			Vector3 vector;
			this.GetPosition_Injected(out vector);
			return vector;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000023BB File Offset: 0x000005BB
		public void Flush()
		{
			Terrain.FlushDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000023CD File Offset: 0x000005CD
		public void RemoveTrees(Vector2 position, float radius, int prototypeIndex)
		{
			this.RemoveTrees_Injected(ref position, radius, prototypeIndex);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000023D9 File Offset: 0x000005D9
		public void SetSplatMaterialPropertyBlock(MaterialPropertyBlock properties)
		{
			Terrain.SetSplatMaterialPropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003C94 File Offset: 0x00001E94
		public void GetSplatMaterialPropertyBlock(MaterialPropertyBlock dest)
		{
			bool flag = dest == null;
			if (flag)
			{
				throw new ArgumentNullException("dest");
			}
			this.Internal_GetSplatMaterialPropertyBlock(dest);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000023F1 File Offset: 0x000005F1
		public void Internal_GetSplatMaterialPropertyBlock(MaterialPropertyBlock dest)
		{
			Terrain.Internal_GetSplatMaterialPropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(dest));
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002409 File Offset: 0x00000609
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0000241B File Offset: 0x0000061B
		public bool preserveTreePrototypeLayers
		{
			get
			{
				return Terrain.get_preserveTreePrototypeLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_preserveTreePrototypeLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000242E File Offset: 0x0000062E
		public static GraphicsFormat heightmapFormat
		{
			get
			{
				return Terrain.get_heightmapFormatDelegateField();
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00003CC0 File Offset: 0x00001EC0
		public static TextureFormat heightmapTextureFormat
		{
			get
			{
				return GraphicsFormatUtility.GetTextureFormat(Terrain.heightmapFormat);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00003CDC File Offset: 0x00001EDC
		public static RenderTextureFormat heightmapRenderTextureFormat
		{
			get
			{
				return GraphicsFormatUtility.GetRenderTextureFormat(Terrain.heightmapFormat);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000243A File Offset: 0x0000063A
		public static GraphicsFormat normalmapFormat
		{
			get
			{
				return Terrain.get_normalmapFormatDelegateField();
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00003CF8 File Offset: 0x00001EF8
		public static TextureFormat normalmapTextureFormat
		{
			get
			{
				return GraphicsFormatUtility.GetTextureFormat(Terrain.normalmapFormat);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003D14 File Offset: 0x00001F14
		public static RenderTextureFormat normalmapRenderTextureFormat
		{
			get
			{
				return GraphicsFormatUtility.GetRenderTextureFormat(Terrain.normalmapFormat);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002446 File Offset: 0x00000646
		public static GraphicsFormat holesFormat
		{
			get
			{
				return Terrain.get_holesFormatDelegateField();
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003D30 File Offset: 0x00001F30
		public static RenderTextureFormat holesRenderTextureFormat
		{
			get
			{
				return GraphicsFormatUtility.GetRenderTextureFormat(Terrain.holesFormat);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002452 File Offset: 0x00000652
		public static GraphicsFormat compressedHolesFormat
		{
			get
			{
				return Terrain.get_compressedHolesFormatDelegateField();
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003D4C File Offset: 0x00001F4C
		public static TextureFormat compressedHolesTextureFormat
		{
			get
			{
				return GraphicsFormatUtility.GetTextureFormat(Terrain.compressedHolesFormat);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00003D68 File Offset: 0x00001F68
		public static Terrain activeTerrain
		{
			get
			{
				IntPtr intPtr = Terrain.get_activeTerrainDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr2) : null;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000245E File Offset: 0x0000065E
		public static void SetConnectivityDirty()
		{
			Terrain.SetConnectivityDirtyDelegateField();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003D90 File Offset: 0x00001F90
		public static GameObject CreateTerrainGameObject(TerrainData assignTerrain)
		{
			IntPtr intPtr = Terrain.CreateTerrainGameObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtr(assignTerrain));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00003DBC File Offset: 0x00001FBC
		public Terrain leftNeighbor
		{
			get
			{
				IntPtr intPtr = Terrain.get_leftNeighborDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr2) : null;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003DE8 File Offset: 0x00001FE8
		public Terrain rightNeighbor
		{
			get
			{
				IntPtr intPtr = Terrain.get_rightNeighborDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr2) : null;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00003E14 File Offset: 0x00002014
		public Terrain topNeighbor
		{
			get
			{
				IntPtr intPtr = Terrain.get_topNeighborDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr2) : null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00003E40 File Offset: 0x00002040
		public Terrain bottomNeighbor
		{
			get
			{
				IntPtr intPtr = Terrain.get_bottomNeighborDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr2) : null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000246A File Offset: 0x0000066A
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000247C File Offset: 0x0000067C
		public uint renderingLayerMask
		{
			get
			{
				return Terrain.get_renderingLayerMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Terrain.set_renderingLayerMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00003E6C File Offset: 0x0000206C
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0000248F File Offset: 0x0000068F
		public float splatmapDistance
		{
			get
			{
				return this.basemapDistance;
			}
			set
			{
				this.basemapDistance = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00003E84 File Offset: 0x00002084
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0000249A File Offset: 0x0000069A
		public bool castShadows
		{
			get
			{
				return this.shadowCastingMode > ShadowCastingMode.Off;
			}
			set
			{
				this.shadowCastingMode = (value ? ShadowCastingMode.TwoSided : ShadowCastingMode.Off);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00003EA0 File Offset: 0x000020A0
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000024AB File Offset: 0x000006AB
		public Terrain.MaterialType materialType
		{
			get
			{
				return Terrain.MaterialType.Custom;
			}
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00003EB4 File Offset: 0x000020B4
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000024AE File Offset: 0x000006AE
		public Color legacySpecular
		{
			get
			{
				return Color.gray;
			}
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00003ECC File Offset: 0x000020CC
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000024B1 File Offset: 0x000006B1
		public float legacyShininess
		{
			get
			{
				return 0.078125f;
			}
			set
			{
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000024B4 File Offset: 0x000006B4
		public void ApplyDelayedHeightmapModification()
		{
			TerrainData terrainData = this.terrainData;
			if (terrainData != null)
			{
				terrainData.SyncHeightmap();
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000024C9 File Offset: 0x000006C9
		public void get_lightmapScaleOffset_Injected(out Vector4 ret)
		{
			Terrain.get_lightmapScaleOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000024DC File Offset: 0x000006DC
		public void set_lightmapScaleOffset_Injected(ref Vector4 value)
		{
			Terrain.set_lightmapScaleOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000024EF File Offset: 0x000006EF
		public void get_realtimeLightmapScaleOffset_Injected(out Vector4 ret)
		{
			Terrain.get_realtimeLightmapScaleOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002502 File Offset: 0x00000702
		public void set_realtimeLightmapScaleOffset_Injected(ref Vector4 value)
		{
			Terrain.set_realtimeLightmapScaleOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002515 File Offset: 0x00000715
		public void get_patchBoundsMultiplier_Injected(out Vector3 ret)
		{
			Terrain.get_patchBoundsMultiplier_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002528 File Offset: 0x00000728
		public void set_patchBoundsMultiplier_Injected(ref Vector3 value)
		{
			Terrain.set_patchBoundsMultiplier_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000253B File Offset: 0x0000073B
		public float SampleHeight_Injected(ref Vector3 worldPosition)
		{
			return Terrain.SampleHeight_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref worldPosition);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000254E File Offset: 0x0000074E
		public void GetPosition_Injected(out Vector3 ret)
		{
			Terrain.GetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002561 File Offset: 0x00000761
		public void RemoveTrees_Injected(ref Vector2 position, float radius, int prototypeIndex)
		{
			Terrain.RemoveTrees_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, radius, prototypeIndex);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_get_terrainData_Public_get_TerrainData_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_get_allowAutoConnect_Public_get_Boolean_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_get_groupingID_Public_get_Int32_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_SetNeighbors_Public_Void_Terrain_Terrain_Terrain_Terrain_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_activeTerrains_Public_Static_get_Il2CppReferenceArray_1_Terrain_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000007 RID: 7
		private static readonly Terrain.set_terrainDataDelegate set_terrainDataDelegateField;

		// Token: 0x04000008 RID: 8
		private static readonly Terrain.get_treeDistanceDelegate get_treeDistanceDelegateField;

		// Token: 0x04000009 RID: 9
		private static readonly Terrain.set_treeDistanceDelegate set_treeDistanceDelegateField;

		// Token: 0x0400000A RID: 10
		private static readonly Terrain.get_treeBillboardDistanceDelegate get_treeBillboardDistanceDelegateField;

		// Token: 0x0400000B RID: 11
		private static readonly Terrain.set_treeBillboardDistanceDelegate set_treeBillboardDistanceDelegateField;

		// Token: 0x0400000C RID: 12
		private static readonly Terrain.get_treeCrossFadeLengthDelegate get_treeCrossFadeLengthDelegateField;

		// Token: 0x0400000D RID: 13
		private static readonly Terrain.set_treeCrossFadeLengthDelegate set_treeCrossFadeLengthDelegateField;

		// Token: 0x0400000E RID: 14
		private static readonly Terrain.get_treeMaximumFullLODCountDelegate get_treeMaximumFullLODCountDelegateField;

		// Token: 0x0400000F RID: 15
		private static readonly Terrain.set_treeMaximumFullLODCountDelegate set_treeMaximumFullLODCountDelegateField;

		// Token: 0x04000010 RID: 16
		private static readonly Terrain.get_detailObjectDistanceDelegate get_detailObjectDistanceDelegateField;

		// Token: 0x04000011 RID: 17
		private static readonly Terrain.set_detailObjectDistanceDelegate set_detailObjectDistanceDelegateField;

		// Token: 0x04000012 RID: 18
		private static readonly Terrain.get_detailObjectDensityDelegate get_detailObjectDensityDelegateField;

		// Token: 0x04000013 RID: 19
		private static readonly Terrain.set_detailObjectDensityDelegate set_detailObjectDensityDelegateField;

		// Token: 0x04000014 RID: 20
		private static readonly Terrain.get_heightmapPixelErrorDelegate get_heightmapPixelErrorDelegateField;

		// Token: 0x04000015 RID: 21
		private static readonly Terrain.set_heightmapPixelErrorDelegate set_heightmapPixelErrorDelegateField;

		// Token: 0x04000016 RID: 22
		private static readonly Terrain.get_heightmapMaximumLODDelegate get_heightmapMaximumLODDelegateField;

		// Token: 0x04000017 RID: 23
		private static readonly Terrain.set_heightmapMaximumLODDelegate set_heightmapMaximumLODDelegateField;

		// Token: 0x04000018 RID: 24
		private static readonly Terrain.get_basemapDistanceDelegate get_basemapDistanceDelegateField;

		// Token: 0x04000019 RID: 25
		private static readonly Terrain.set_basemapDistanceDelegate set_basemapDistanceDelegateField;

		// Token: 0x0400001A RID: 26
		private static readonly Terrain.get_lightmapIndexDelegate get_lightmapIndexDelegateField;

		// Token: 0x0400001B RID: 27
		private static readonly Terrain.set_lightmapIndexDelegate set_lightmapIndexDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly Terrain.get_realtimeLightmapIndexDelegate get_realtimeLightmapIndexDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly Terrain.set_realtimeLightmapIndexDelegate set_realtimeLightmapIndexDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly Terrain.get_freeUnusedRenderingResourcesDelegate get_freeUnusedRenderingResourcesDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly Terrain.set_freeUnusedRenderingResourcesDelegate set_freeUnusedRenderingResourcesDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly Terrain.get_shadowCastingModeDelegate get_shadowCastingModeDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly Terrain.set_shadowCastingModeDelegate set_shadowCastingModeDelegateField;

		// Token: 0x04000022 RID: 34
		private static readonly Terrain.get_reflectionProbeUsageDelegate get_reflectionProbeUsageDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly Terrain.set_reflectionProbeUsageDelegate set_reflectionProbeUsageDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly Terrain.get_materialTemplateDelegate get_materialTemplateDelegateField;

		// Token: 0x04000025 RID: 37
		private static readonly Terrain.set_materialTemplateDelegate set_materialTemplateDelegateField;

		// Token: 0x04000026 RID: 38
		private static readonly Terrain.get_drawHeightmapDelegate get_drawHeightmapDelegateField;

		// Token: 0x04000027 RID: 39
		private static readonly Terrain.set_drawHeightmapDelegate set_drawHeightmapDelegateField;

		// Token: 0x04000028 RID: 40
		private static readonly Terrain.set_allowAutoConnectDelegate set_allowAutoConnectDelegateField;

		// Token: 0x04000029 RID: 41
		private static readonly Terrain.set_groupingIDDelegate set_groupingIDDelegateField;

		// Token: 0x0400002A RID: 42
		private static readonly Terrain.get_drawInstancedDelegate get_drawInstancedDelegateField;

		// Token: 0x0400002B RID: 43
		private static readonly Terrain.set_drawInstancedDelegate set_drawInstancedDelegateField;

		// Token: 0x0400002C RID: 44
		private static readonly Terrain.get_normalmapTextureDelegate get_normalmapTextureDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly Terrain.get_drawTreesAndFoliageDelegate get_drawTreesAndFoliageDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly Terrain.set_drawTreesAndFoliageDelegate set_drawTreesAndFoliageDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly Terrain.get_treeLODBiasMultiplierDelegate get_treeLODBiasMultiplierDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly Terrain.set_treeLODBiasMultiplierDelegate set_treeLODBiasMultiplierDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly Terrain.get_collectDetailPatchesDelegate get_collectDetailPatchesDelegateField;

		// Token: 0x04000032 RID: 50
		private static readonly Terrain.set_collectDetailPatchesDelegate set_collectDetailPatchesDelegateField;

		// Token: 0x04000033 RID: 51
		private static readonly Terrain.get_editorRenderFlagsDelegate get_editorRenderFlagsDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly Terrain.set_editorRenderFlagsDelegate set_editorRenderFlagsDelegateField;

		// Token: 0x04000035 RID: 53
		private static readonly Terrain.FlushDelegate FlushDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly Terrain.SetSplatMaterialPropertyBlockDelegate SetSplatMaterialPropertyBlockDelegateField;

		// Token: 0x04000037 RID: 55
		private static readonly Terrain.Internal_GetSplatMaterialPropertyBlockDelegate Internal_GetSplatMaterialPropertyBlockDelegateField;

		// Token: 0x04000038 RID: 56
		private static readonly Terrain.get_preserveTreePrototypeLayersDelegate get_preserveTreePrototypeLayersDelegateField;

		// Token: 0x04000039 RID: 57
		private static readonly Terrain.set_preserveTreePrototypeLayersDelegate set_preserveTreePrototypeLayersDelegateField;

		// Token: 0x0400003A RID: 58
		private static readonly Terrain.get_heightmapFormatDelegate get_heightmapFormatDelegateField;

		// Token: 0x0400003B RID: 59
		private static readonly Terrain.get_normalmapFormatDelegate get_normalmapFormatDelegateField;

		// Token: 0x0400003C RID: 60
		private static readonly Terrain.get_holesFormatDelegate get_holesFormatDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly Terrain.get_compressedHolesFormatDelegate get_compressedHolesFormatDelegateField;

		// Token: 0x0400003E RID: 62
		private static readonly Terrain.get_activeTerrainDelegate get_activeTerrainDelegateField;

		// Token: 0x0400003F RID: 63
		private static readonly Terrain.SetConnectivityDirtyDelegate SetConnectivityDirtyDelegateField;

		// Token: 0x04000040 RID: 64
		private static readonly Terrain.CreateTerrainGameObjectDelegate CreateTerrainGameObjectDelegateField;

		// Token: 0x04000041 RID: 65
		private static readonly Terrain.get_leftNeighborDelegate get_leftNeighborDelegateField;

		// Token: 0x04000042 RID: 66
		private static readonly Terrain.get_rightNeighborDelegate get_rightNeighborDelegateField;

		// Token: 0x04000043 RID: 67
		private static readonly Terrain.get_topNeighborDelegate get_topNeighborDelegateField;

		// Token: 0x04000044 RID: 68
		private static readonly Terrain.get_bottomNeighborDelegate get_bottomNeighborDelegateField;

		// Token: 0x04000045 RID: 69
		private static readonly Terrain.get_renderingLayerMaskDelegate get_renderingLayerMaskDelegateField;

		// Token: 0x04000046 RID: 70
		private static readonly Terrain.set_renderingLayerMaskDelegate set_renderingLayerMaskDelegateField;

		// Token: 0x04000047 RID: 71
		private static readonly Terrain.get_lightmapScaleOffset_InjectedDelegate get_lightmapScaleOffset_InjectedDelegateField;

		// Token: 0x04000048 RID: 72
		private static readonly Terrain.set_lightmapScaleOffset_InjectedDelegate set_lightmapScaleOffset_InjectedDelegateField;

		// Token: 0x04000049 RID: 73
		private static readonly Terrain.get_realtimeLightmapScaleOffset_InjectedDelegate get_realtimeLightmapScaleOffset_InjectedDelegateField;

		// Token: 0x0400004A RID: 74
		private static readonly Terrain.set_realtimeLightmapScaleOffset_InjectedDelegate set_realtimeLightmapScaleOffset_InjectedDelegateField;

		// Token: 0x0400004B RID: 75
		private static readonly Terrain.get_patchBoundsMultiplier_InjectedDelegate get_patchBoundsMultiplier_InjectedDelegateField;

		// Token: 0x0400004C RID: 76
		private static readonly Terrain.set_patchBoundsMultiplier_InjectedDelegate set_patchBoundsMultiplier_InjectedDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly Terrain.SampleHeight_InjectedDelegate SampleHeight_InjectedDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly Terrain.GetPosition_InjectedDelegate GetPosition_InjectedDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly Terrain.RemoveTrees_InjectedDelegate RemoveTrees_InjectedDelegateField;

		// Token: 0x02000016 RID: 22
		public enum MaterialType
		{
			// Token: 0x040000F3 RID: 243
			BuiltInStandard,
			// Token: 0x040000F4 RID: 244
			BuiltInLegacyDiffuse,
			// Token: 0x040000F5 RID: 245
			BuiltInLegacySpecular,
			// Token: 0x040000F6 RID: 246
			Custom
		}

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060001B0 RID: 432
		private delegate void set_terrainDataDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060001B2 RID: 434
		private delegate float get_treeDistanceDelegate(IntPtr @this);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060001B4 RID: 436
		private delegate void set_treeDistanceDelegate(IntPtr @this, float value);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060001B6 RID: 438
		private delegate float get_treeBillboardDistanceDelegate(IntPtr @this);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060001B8 RID: 440
		private delegate void set_treeBillboardDistanceDelegate(IntPtr @this, float value);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060001BA RID: 442
		private delegate float get_treeCrossFadeLengthDelegate(IntPtr @this);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060001BC RID: 444
		private delegate void set_treeCrossFadeLengthDelegate(IntPtr @this, float value);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x060001BE RID: 446
		private delegate int get_treeMaximumFullLODCountDelegate(IntPtr @this);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060001C0 RID: 448
		private delegate void set_treeMaximumFullLODCountDelegate(IntPtr @this, int value);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x060001C2 RID: 450
		private delegate float get_detailObjectDistanceDelegate(IntPtr @this);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x060001C4 RID: 452
		private delegate void set_detailObjectDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x060001C6 RID: 454
		private delegate float get_detailObjectDensityDelegate(IntPtr @this);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x060001C8 RID: 456
		private delegate void set_detailObjectDensityDelegate(IntPtr @this, float value);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x060001CA RID: 458
		private delegate float get_heightmapPixelErrorDelegate(IntPtr @this);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x060001CC RID: 460
		private delegate void set_heightmapPixelErrorDelegate(IntPtr @this, float value);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x060001CE RID: 462
		private delegate int get_heightmapMaximumLODDelegate(IntPtr @this);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x060001D0 RID: 464
		private delegate void set_heightmapMaximumLODDelegate(IntPtr @this, int value);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x060001D2 RID: 466
		private delegate float get_basemapDistanceDelegate(IntPtr @this);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x060001D4 RID: 468
		private delegate void set_basemapDistanceDelegate(IntPtr @this, float value);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x060001D6 RID: 470
		private delegate int get_lightmapIndexDelegate(IntPtr @this);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x060001D8 RID: 472
		private delegate void set_lightmapIndexDelegate(IntPtr @this, int value);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x060001DA RID: 474
		private delegate int get_realtimeLightmapIndexDelegate(IntPtr @this);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x060001DC RID: 476
		private delegate void set_realtimeLightmapIndexDelegate(IntPtr @this, int value);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x060001DE RID: 478
		private delegate bool get_freeUnusedRenderingResourcesDelegate(IntPtr @this);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x060001E0 RID: 480
		private delegate void set_freeUnusedRenderingResourcesDelegate(IntPtr @this, bool value);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x060001E2 RID: 482
		private delegate ShadowCastingMode get_shadowCastingModeDelegate(IntPtr @this);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x060001E4 RID: 484
		private delegate void set_shadowCastingModeDelegate(IntPtr @this, ShadowCastingMode value);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x060001E6 RID: 486
		private delegate ReflectionProbeUsage get_reflectionProbeUsageDelegate(IntPtr @this);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x060001E8 RID: 488
		private delegate void set_reflectionProbeUsageDelegate(IntPtr @this, ReflectionProbeUsage value);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x060001EA RID: 490
		private delegate IntPtr get_materialTemplateDelegate(IntPtr @this);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x060001EC RID: 492
		private delegate void set_materialTemplateDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x060001EE RID: 494
		private delegate bool get_drawHeightmapDelegate(IntPtr @this);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x060001F0 RID: 496
		private delegate void set_drawHeightmapDelegate(IntPtr @this, bool value);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x060001F2 RID: 498
		private delegate void set_allowAutoConnectDelegate(IntPtr @this, bool value);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x060001F4 RID: 500
		private delegate void set_groupingIDDelegate(IntPtr @this, int value);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x060001F6 RID: 502
		private delegate bool get_drawInstancedDelegate(IntPtr @this);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x060001F8 RID: 504
		private delegate void set_drawInstancedDelegate(IntPtr @this, bool value);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x060001FA RID: 506
		private delegate IntPtr get_normalmapTextureDelegate(IntPtr @this);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x060001FC RID: 508
		private delegate bool get_drawTreesAndFoliageDelegate(IntPtr @this);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x060001FE RID: 510
		private delegate void set_drawTreesAndFoliageDelegate(IntPtr @this, bool value);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x06000200 RID: 512
		private delegate float get_treeLODBiasMultiplierDelegate(IntPtr @this);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x06000202 RID: 514
		private delegate void set_treeLODBiasMultiplierDelegate(IntPtr @this, float value);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x06000204 RID: 516
		private delegate bool get_collectDetailPatchesDelegate(IntPtr @this);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x06000206 RID: 518
		private delegate void set_collectDetailPatchesDelegate(IntPtr @this, bool value);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x06000208 RID: 520
		private delegate TerrainRenderFlags get_editorRenderFlagsDelegate(IntPtr @this);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x0600020A RID: 522
		private delegate void set_editorRenderFlagsDelegate(IntPtr @this, TerrainRenderFlags value);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x0600020C RID: 524
		private delegate void FlushDelegate(IntPtr @this);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x0600020E RID: 526
		private delegate void SetSplatMaterialPropertyBlockDelegate(IntPtr @this, IntPtr properties);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x06000210 RID: 528
		private delegate void Internal_GetSplatMaterialPropertyBlockDelegate(IntPtr @this, IntPtr dest);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000212 RID: 530
		private delegate bool get_preserveTreePrototypeLayersDelegate(IntPtr @this);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x06000214 RID: 532
		private delegate void set_preserveTreePrototypeLayersDelegate(IntPtr @this, bool value);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000216 RID: 534
		private delegate GraphicsFormat get_heightmapFormatDelegate();

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x06000218 RID: 536
		private delegate GraphicsFormat get_normalmapFormatDelegate();

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x0600021A RID: 538
		private delegate GraphicsFormat get_holesFormatDelegate();

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x0600021C RID: 540
		private delegate GraphicsFormat get_compressedHolesFormatDelegate();

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x0600021E RID: 542
		private delegate IntPtr get_activeTerrainDelegate();

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x06000220 RID: 544
		private delegate void SetConnectivityDirtyDelegate();

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x06000222 RID: 546
		private delegate IntPtr CreateTerrainGameObjectDelegate(IntPtr assignTerrain);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x06000224 RID: 548
		private delegate IntPtr get_leftNeighborDelegate(IntPtr @this);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x06000226 RID: 550
		private delegate IntPtr get_rightNeighborDelegate(IntPtr @this);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x06000228 RID: 552
		private delegate IntPtr get_topNeighborDelegate(IntPtr @this);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x0600022A RID: 554
		private delegate IntPtr get_bottomNeighborDelegate(IntPtr @this);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x0600022C RID: 556
		private delegate uint get_renderingLayerMaskDelegate(IntPtr @this);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x0600022E RID: 558
		private delegate void set_renderingLayerMaskDelegate(IntPtr @this, uint value);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000230 RID: 560
		private delegate void get_lightmapScaleOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x06000232 RID: 562
		private delegate void set_lightmapScaleOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x06000234 RID: 564
		private delegate void get_realtimeLightmapScaleOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x06000236 RID: 566
		private delegate void set_realtimeLightmapScaleOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x06000238 RID: 568
		private delegate void get_patchBoundsMultiplier_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x0600023A RID: 570
		private delegate void set_patchBoundsMultiplier_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x0600023C RID: 572
		private delegate float SampleHeight_InjectedDelegate(IntPtr @this, IntPtr worldPosition);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x0600023E RID: 574
		private delegate void GetPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000240 RID: 576
		private delegate void RemoveTrees_InjectedDelegate(IntPtr @this, IntPtr position, float radius, int prototypeIndex);
	}
}
