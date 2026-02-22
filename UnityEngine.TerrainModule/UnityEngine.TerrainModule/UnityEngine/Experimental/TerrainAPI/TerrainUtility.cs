using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Experimental.TerrainAPI
{
	// Token: 0x02000005 RID: 5
	public static class TerrainUtility : Object
	{
		// Token: 0x060000FC RID: 252 RVA: 0x00005460 File Offset: 0x00003660
		// Note: this type is marked as 'beforefieldinit'.
		static TerrainUtility()
		{
			Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine.Experimental.TerrainAPI", "TerrainUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr);
			TerrainUtility.NativeMethodInfoPtr_HasValidTerrains_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100663317);
			TerrainUtility.NativeMethodInfoPtr_ClearConnectivity_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100663318);
			TerrainUtility.NativeMethodInfoPtr_CollectTerrains_Internal_Static_TerrainGroups_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100663319);
			TerrainUtility.NativeMethodInfoPtr_AutoConnect_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100663320);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000054E0 File Offset: 0x000036E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158026, RefRangeEnd = 158028, XrefRangeStart = 158024, XrefRangeEnd = 158026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasValidTerrains()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_HasValidTerrains_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00005510 File Offset: 0x00003710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158028, XrefRangeEnd = 158035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearConnectivity()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_ClearConnectivity_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00005538 File Offset: 0x00003738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158075, RefRangeEnd = 158076, XrefRangeStart = 158035, XrefRangeEnd = 158075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TerrainUtility.TerrainGroups CollectTerrains(bool onlyAutoConnectedTerrains = true)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyAutoConnectedTerrains;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_CollectTerrains_Internal_Static_TerrainGroups_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TerrainUtility.TerrainGroups>(intPtr3) : null;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00005578 File Offset: 0x00003778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158076, XrefRangeEnd = 158117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AutoConnect()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_AutoConnect_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002B74 File Offset: 0x00000D74
		public TerrainUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_HasValidTerrains_Internal_Static_Boolean_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_ClearConnectivity_Internal_Static_Void_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_CollectTerrains_Internal_Static_TerrainGroups_Boolean_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_AutoConnect_Public_Static_Void_0;

		// Token: 0x020000A6 RID: 166
		public class TerrainMap : Object
		{
			// Token: 0x060002D5 RID: 725 RVA: 0x00006694 File Offset: 0x00004894
			// Note: this type is marked as 'beforefieldinit'.
			static TerrainMap()
			{
				Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, "TerrainMap");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr);
				TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_patchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, "m_patchSize");
				TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_errorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, "m_errorCode");
				TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_terrainTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, "m_terrainTiles");
				TerrainUtility.TerrainMap.NativeMethodInfoPtr_GetTerrain_Public_Terrain_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663321);
				TerrainUtility.TerrainMap.NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Terrain_TerrainFilter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663322);
				TerrainUtility.TerrainMap.NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Vector2_Vector2_TerrainFilter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663323);
				TerrainUtility.TerrainMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663324);
				TerrainUtility.TerrainMap.NativeMethodInfoPtr_AddTerrainInternal_Private_Void_Int32_Int32_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663325);
				TerrainUtility.TerrainMap.NativeMethodInfoPtr_TryToAddTerrain_Private_Boolean_Int32_Int32_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663326);
				TerrainUtility.TerrainMap.NativeMethodInfoPtr_ValidateTerrain_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663327);
				TerrainUtility.TerrainMap.NativeMethodInfoPtr_Validate_Private_ErrorCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, 100663328);
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x0000679C File Offset: 0x0000499C
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 157780, RefRangeEnd = 157791, XrefRangeStart = 157777, XrefRangeEnd = 157780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Terrain GetTerrain(int tileX, int tileZ)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref tileX;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileZ;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr_GetTerrain_Public_Terrain_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr3) : null;
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x000067F8 File Offset: 0x000049F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157829, RefRangeEnd = 157830, XrefRangeStart = 157791, XrefRangeEnd = 157829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TerrainUtility.TerrainMap CreateFromPlacement(Terrain originTerrain, TerrainUtility.TerrainMap.TerrainFilter filter = null, bool fullValidation = true)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(originTerrain);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullValidation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Terrain_TerrainFilter_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TerrainUtility.TerrainMap>(intPtr3) : null;
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x0000685C File Offset: 0x00004A5C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157864, RefRangeEnd = 157865, XrefRangeStart = 157830, XrefRangeEnd = 157864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TerrainUtility.TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, TerrainUtility.TerrainMap.TerrainFilter filter = null, bool fullValidation = true)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref gridOrigin;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridSize;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullValidation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Vector2_Vector2_TerrainFilter_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TerrainUtility.TerrainMap>(intPtr3) : null;
			}

			// Token: 0x060002D9 RID: 729 RVA: 0x000068CC File Offset: 0x00004ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157865, XrefRangeEnd = 157872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TerrainMap()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002DA RID: 730 RVA: 0x00006908 File Offset: 0x00004B08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157872, XrefRangeEnd = 157888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddTerrainInternal(int x, int z, Terrain terrain)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(terrain);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr_AddTerrainInternal_Private_Void_Int32_Int32_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002DB RID: 731 RVA: 0x00006968 File Offset: 0x00004B68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157915, RefRangeEnd = 157916, XrefRangeStart = 157888, XrefRangeEnd = 157915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref tileX;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileZ;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(terrain);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr_TryToAddTerrain_Private_Boolean_Int32_Int32_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060002DC RID: 732 RVA: 0x000069D4 File Offset: 0x00004BD4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157993, RefRangeEnd = 157994, XrefRangeStart = 157916, XrefRangeEnd = 157993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ValidateTerrain(int tileX, int tileZ)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref tileX;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileZ;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr_ValidateTerrain_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002DD RID: 733 RVA: 0x00006A20 File Offset: 0x00004C20
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 158012, RefRangeEnd = 158013, XrefRangeStart = 157994, XrefRangeEnd = 158012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TerrainUtility.TerrainMap.ErrorCode Validate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.NativeMethodInfoPtr_Validate_Private_ErrorCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060002DE RID: 734 RVA: 0x0000339D File Offset: 0x0000159D
			public TerrainMap(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060002DF RID: 735 RVA: 0x00006A5C File Offset: 0x00004C5C
			// (set) Token: 0x060002E0 RID: 736 RVA: 0x000033A6 File Offset: 0x000015A6
			public unsafe Vector3 m_patchSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_patchSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_patchSize)) = value;
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060002E1 RID: 737 RVA: 0x00006A84 File Offset: 0x00004C84
			// (set) Token: 0x060002E2 RID: 738 RVA: 0x000033C1 File Offset: 0x000015C1
			public unsafe TerrainUtility.TerrainMap.ErrorCode m_errorCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_errorCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_errorCode)) = value;
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x060002E3 RID: 739 RVA: 0x00006AAC File Offset: 0x00004CAC
			// (set) Token: 0x060002E4 RID: 740 RVA: 0x000033DC File Offset: 0x000015DC
			public unsafe Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain> m_terrainTiles
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_terrainTiles);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.NativeFieldInfoPtr_m_terrainTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000105 RID: 261
			private static readonly IntPtr NativeFieldInfoPtr_m_patchSize;

			// Token: 0x04000106 RID: 262
			private static readonly IntPtr NativeFieldInfoPtr_m_errorCode;

			// Token: 0x04000107 RID: 263
			private static readonly IntPtr NativeFieldInfoPtr_m_terrainTiles;

			// Token: 0x04000108 RID: 264
			private static readonly IntPtr NativeMethodInfoPtr_GetTerrain_Public_Terrain_Int32_Int32_0;

			// Token: 0x04000109 RID: 265
			private static readonly IntPtr NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Terrain_TerrainFilter_Boolean_0;

			// Token: 0x0400010A RID: 266
			private static readonly IntPtr NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Vector2_Vector2_TerrainFilter_Boolean_0;

			// Token: 0x0400010B RID: 267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400010C RID: 268
			private static readonly IntPtr NativeMethodInfoPtr_AddTerrainInternal_Private_Void_Int32_Int32_Terrain_0;

			// Token: 0x0400010D RID: 269
			private static readonly IntPtr NativeMethodInfoPtr_TryToAddTerrain_Private_Boolean_Int32_Int32_Terrain_0;

			// Token: 0x0400010E RID: 270
			private static readonly IntPtr NativeMethodInfoPtr_ValidateTerrain_Private_Void_Int32_Int32_0;

			// Token: 0x0400010F RID: 271
			private static readonly IntPtr NativeMethodInfoPtr_Validate_Private_ErrorCode_0;

			// Token: 0x020000D8 RID: 216
			public sealed class TerrainFilter : MulticastDelegate
			{
				// Token: 0x06000335 RID: 821 RVA: 0x000034A3 File Offset: 0x000016A3
				// Note: this type is marked as 'beforefieldinit'.
				static TerrainFilter()
				{
					Il2CppClassPointerStore<TerrainUtility.TerrainMap.TerrainFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, "TerrainFilter");
					TerrainUtility.TerrainMap.TerrainFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TerrainFilter>.NativeClassPtr, 100663329);
					TerrainUtility.TerrainMap.TerrainFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TerrainFilter>.NativeClassPtr, 100663330);
				}

				// Token: 0x06000336 RID: 822 RVA: 0x00006D38 File Offset: 0x00004F38
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe TerrainFilter(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TerrainFilter>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.TerrainFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000337 RID: 823 RVA: 0x00006D94 File Offset: 0x00004F94
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 157774, RefRangeEnd = 157775, XrefRangeStart = 157774, XrefRangeEnd = 157774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool Invoke(Terrain terrain)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrain);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.TerrainFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06000338 RID: 824 RVA: 0x000034E1 File Offset: 0x000016E1
				public TerrainFilter(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06000339 RID: 825 RVA: 0x000034EA File Offset: 0x000016EA
				public static implicit operator TerrainUtility.TerrainMap.TerrainFilter(Func<Terrain, bool> A_0)
				{
					return DelegateSupport.ConvertDelegate<TerrainUtility.TerrainMap.TerrainFilter>(A_0);
				}

				// Token: 0x0600033A RID: 826 RVA: 0x000034F2 File Offset: 0x000016F2
				public static TerrainUtility.TerrainMap.TerrainFilter operator +(TerrainUtility.TerrainMap.TerrainFilter A_0, TerrainUtility.TerrainMap.TerrainFilter A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<TerrainUtility.TerrainMap.TerrainFilter>();
				}

				// Token: 0x0600033B RID: 827 RVA: 0x00003500 File Offset: 0x00001700
				public static TerrainUtility.TerrainMap.TerrainFilter operator -(TerrainUtility.TerrainMap.TerrainFilter A_0, TerrainUtility.TerrainMap.TerrainFilter A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<TerrainUtility.TerrainMap.TerrainFilter>();
					}
					return delegate2;
				}

				// Token: 0x04000124 RID: 292
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04000125 RID: 293
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Terrain_0;
			}

			// Token: 0x020000D9 RID: 217
			[StructLayout(2)]
			public struct TileCoord
			{
				// Token: 0x0600033C RID: 828 RVA: 0x00006DE4 File Offset: 0x00004FE4
				// Note: this type is marked as 'beforefieldinit'.
				static TileCoord()
				{
					Il2CppClassPointerStore<TerrainUtility.TerrainMap.TileCoord>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, "TileCoord");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TileCoord>.NativeClassPtr);
					TerrainUtility.TerrainMap.TileCoord.NativeFieldInfoPtr_tileX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TileCoord>.NativeClassPtr, "tileX");
					TerrainUtility.TerrainMap.TileCoord.NativeFieldInfoPtr_tileZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TileCoord>.NativeClassPtr, "tileZ");
					TerrainUtility.TerrainMap.TileCoord.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TileCoord>.NativeClassPtr, 100663331);
				}

				// Token: 0x0600033D RID: 829 RVA: 0x00006E4C File Offset: 0x0000504C
				[CallerCount(30)]
				[CachedScanResults(RefRangeStart = 16465, RefRangeEnd = 16495, XrefRangeStart = 16465, XrefRangeEnd = 16495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe TileCoord(int tileX, int tileZ)
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref tileX;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileZ;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.TileCoord.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600033E RID: 830 RVA: 0x00003511 File Offset: 0x00001711
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainUtility.TerrainMap.TileCoord>.NativeClassPtr, ref this));
				}

				// Token: 0x04000126 RID: 294
				private static readonly IntPtr NativeFieldInfoPtr_tileX;

				// Token: 0x04000127 RID: 295
				private static readonly IntPtr NativeFieldInfoPtr_tileZ;

				// Token: 0x04000128 RID: 296
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

				// Token: 0x04000129 RID: 297
				[FieldOffset(0)]
				public readonly int tileX;

				// Token: 0x0400012A RID: 298
				[FieldOffset(4)]
				public readonly int tileZ;
			}

			// Token: 0x020000DA RID: 218
			public enum ErrorCode
			{
				// Token: 0x0400012C RID: 300
				OK,
				// Token: 0x0400012D RID: 301
				Overlapping,
				// Token: 0x0400012E RID: 302
				SizeMismatch = 4,
				// Token: 0x0400012F RID: 303
				EdgeAlignmentMismatch = 8
			}

			// Token: 0x020000DB RID: 219
			[ObfuscatedName("UnityEngine.Experimental.TerrainAPI.TerrainUtility+TerrainMap+<>c__DisplayClass4_0")]
			public sealed class __c__DisplayClass4_0 : Object
			{
				// Token: 0x0600033F RID: 831 RVA: 0x00006E8C File Offset: 0x0000508C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass4_0()
				{
					Il2CppClassPointerStore<TerrainUtility.TerrainMap.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility.TerrainMap>.NativeClassPtr, "<>c__DisplayClass4_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility.TerrainMap.__c__DisplayClass4_0>.NativeClassPtr);
					TerrainUtility.TerrainMap.__c__DisplayClass4_0.NativeFieldInfoPtr_groupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.TerrainMap.__c__DisplayClass4_0>.NativeClassPtr, "groupID");
					TerrainUtility.TerrainMap.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap.__c__DisplayClass4_0>.NativeClassPtr, 100663332);
					TerrainUtility.TerrainMap.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateFromPlacement_b__0_Internal_Boolean_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainMap.__c__DisplayClass4_0>.NativeClassPtr, 100663333);
				}

				// Token: 0x06000340 RID: 832 RVA: 0x00006EF4 File Offset: 0x000050F4
				[CallerCount(817)]
				[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass4_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainUtility.TerrainMap.__c__DisplayClass4_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000341 RID: 833 RVA: 0x00006F30 File Offset: 0x00005130
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157775, XrefRangeEnd = 157777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _CreateFromPlacement_b__0(Terrain x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainMap.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateFromPlacement_b__0_Internal_Boolean_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06000342 RID: 834 RVA: 0x00003523 File Offset: 0x00001723
				public __c__DisplayClass4_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170000A7 RID: 167
				// (get) Token: 0x06000343 RID: 835 RVA: 0x00006F80 File Offset: 0x00005180
				// (set) Token: 0x06000344 RID: 836 RVA: 0x0000352C File Offset: 0x0000172C
				public unsafe int groupID
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.__c__DisplayClass4_0.NativeFieldInfoPtr_groupID);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.TerrainMap.__c__DisplayClass4_0.NativeFieldInfoPtr_groupID)) = value;
					}
				}

				// Token: 0x04000130 RID: 304
				private static readonly IntPtr NativeFieldInfoPtr_groupID;

				// Token: 0x04000131 RID: 305
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04000132 RID: 306
				private static readonly IntPtr NativeMethodInfoPtr__CreateFromPlacement_b__0_Internal_Boolean_Terrain_0;
			}

			// Token: 0x020000DC RID: 220
			public sealed class <>c__DisplayClass4_0
			{
			}
		}

		// Token: 0x020000A7 RID: 167
		public class TerrainGroups : Dictionary<int, TerrainUtility.TerrainMap>
		{
			// Token: 0x060002E5 RID: 741 RVA: 0x000033FB File Offset: 0x000015FB
			// Note: this type is marked as 'beforefieldinit'.
			static TerrainGroups()
			{
				Il2CppClassPointerStore<TerrainUtility.TerrainGroups>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, "TerrainGroups");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility.TerrainGroups>.NativeClassPtr);
				TerrainUtility.TerrainGroups.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.TerrainGroups>.NativeClassPtr, 100663334);
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x00006ADC File Offset: 0x00004CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158013, XrefRangeEnd = 158016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TerrainGroups()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainUtility.TerrainGroups>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.TerrainGroups.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x0000342F File Offset: 0x0000162F
			public TerrainGroups(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000110 RID: 272
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000A8 RID: 168
		[ObfuscatedName("UnityEngine.Experimental.TerrainAPI.TerrainUtility+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x060002E8 RID: 744 RVA: 0x00006B18 File Offset: 0x00004D18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_0>.NativeClassPtr);
				TerrainUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_onlyAutoConnectedTerrains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_0>.NativeClassPtr, "onlyAutoConnectedTerrains");
				TerrainUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_0>.NativeClassPtr, 100663335);
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x00006B6C File Offset: 0x00004D6C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002EA RID: 746 RVA: 0x00003438 File Offset: 0x00001638
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x060002EB RID: 747 RVA: 0x00006BA8 File Offset: 0x00004DA8
			// (set) Token: 0x060002EC RID: 748 RVA: 0x00003441 File Offset: 0x00001641
			public unsafe bool onlyAutoConnectedTerrains
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_onlyAutoConnectedTerrains);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_onlyAutoConnectedTerrains)) = value;
				}
			}

			// Token: 0x04000111 RID: 273
			private static readonly IntPtr NativeFieldInfoPtr_onlyAutoConnectedTerrains;

			// Token: 0x04000112 RID: 274
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000A9 RID: 169
		[ObfuscatedName("UnityEngine.Experimental.TerrainAPI.TerrainUtility+<>c__DisplayClass4_1")]
		public sealed class __c__DisplayClass4_1 : Object
		{
			// Token: 0x060002ED RID: 749 RVA: 0x00006BD0 File Offset: 0x00004DD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_1()
			{
				Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, "<>c__DisplayClass4_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_1>.NativeClassPtr);
				TerrainUtility.__c__DisplayClass4_1.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_1>.NativeClassPtr, "t");
				TerrainUtility.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_1>.NativeClassPtr, "CS$<>8__locals1");
				TerrainUtility.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_1>.NativeClassPtr, 100663336);
				TerrainUtility.__c__DisplayClass4_1.NativeMethodInfoPtr__CollectTerrains_b__0_Internal_Boolean_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_1>.NativeClassPtr, 100663337);
			}

			// Token: 0x060002EE RID: 750 RVA: 0x00006C4C File Offset: 0x00004E4C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass4_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002EF RID: 751 RVA: 0x00006C88 File Offset: 0x00004E88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158016, XrefRangeEnd = 158024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CollectTerrains_b__0(Terrain x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.__c__DisplayClass4_1.NativeMethodInfoPtr__CollectTerrains_b__0_Internal_Boolean_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002F0 RID: 752 RVA: 0x0000345C File Offset: 0x0000165C
			public __c__DisplayClass4_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x060002F1 RID: 753 RVA: 0x00006CD8 File Offset: 0x00004ED8
			// (set) Token: 0x060002F2 RID: 754 RVA: 0x00003465 File Offset: 0x00001665
			public unsafe Terrain t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass4_1.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass4_1.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x060002F3 RID: 755 RVA: 0x00006D08 File Offset: 0x00004F08
			// (set) Token: 0x060002F4 RID: 756 RVA: 0x00003484 File Offset: 0x00001684
			public unsafe TerrainUtility.__c__DisplayClass4_0 field_Public___c__DisplayClass4_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TerrainUtility.__c__DisplayClass4_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000113 RID: 275
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x04000114 RID: 276
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0;

			// Token: 0x04000115 RID: 277
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000116 RID: 278
			private static readonly IntPtr NativeMethodInfoPtr__CollectTerrains_b__0_Internal_Boolean_Terrain_0;
		}

		// Token: 0x020000AA RID: 170
		public sealed class <>c__DisplayClass4_0
		{
		}

		// Token: 0x020000AB RID: 171
		public sealed class <>c__DisplayClass4_1
		{
		}
	}
}
