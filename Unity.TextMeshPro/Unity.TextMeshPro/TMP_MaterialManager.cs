using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000044 RID: 68
	public static class TMP_MaterialManager : global::Il2CppSystem.Object
	{
		// Token: 0x060007B4 RID: 1972 RVA: 0x00023FCC File Offset: 0x000221CC
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_MaterialManager()
		{
			Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_MaterialManager");
			TMP_MaterialManager.NativeFieldInfoPtr_m_materialList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "m_materialList");
			TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "m_fallbackMaterials");
			TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterialLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "m_fallbackMaterialLookup");
			TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackCleanupList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "m_fallbackCleanupList");
			TMP_MaterialManager.NativeFieldInfoPtr_isFallbackListDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "isFallbackListDirty");
			TMP_MaterialManager.NativeMethodInfoPtr_OnPreRender_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664112);
			TMP_MaterialManager.NativeMethodInfoPtr_GetStencilMaterial_Public_Static_Material_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664113);
			TMP_MaterialManager.NativeMethodInfoPtr_ReleaseStencilMaterial_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664114);
			TMP_MaterialManager.NativeMethodInfoPtr_GetBaseMaterial_Public_Static_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664115);
			TMP_MaterialManager.NativeMethodInfoPtr_SetStencil_Public_Static_Material_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664116);
			TMP_MaterialManager.NativeMethodInfoPtr_AddMaskingMaterial_Public_Static_Void_Material_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664117);
			TMP_MaterialManager.NativeMethodInfoPtr_RemoveStencilMaterial_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664118);
			TMP_MaterialManager.NativeMethodInfoPtr_ReleaseBaseMaterial_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664119);
			TMP_MaterialManager.NativeMethodInfoPtr_ClearMaterials_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664120);
			TMP_MaterialManager.NativeMethodInfoPtr_GetStencilID_Public_Static_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664121);
			TMP_MaterialManager.NativeMethodInfoPtr_GetMaterialForRendering_Public_Static_Material_MaskableGraphic_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664122);
			TMP_MaterialManager.NativeMethodInfoPtr_FindRootSortOverrideCanvas_Private_Static_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664123);
			TMP_MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Internal_Static_Material_TMP_FontAsset_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664124);
			TMP_MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Public_Static_Material_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664125);
			TMP_MaterialManager.NativeMethodInfoPtr_AddFallbackMaterialReference_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664126);
			TMP_MaterialManager.NativeMethodInfoPtr_RemoveFallbackMaterialReference_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664127);
			TMP_MaterialManager.NativeMethodInfoPtr_CleanupFallbackMaterials_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664128);
			TMP_MaterialManager.NativeMethodInfoPtr_ReleaseFallbackMaterial_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664129);
			TMP_MaterialManager.NativeMethodInfoPtr_CopyMaterialPresetProperties_Public_Static_Void_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664130);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000241D4 File Offset: 0x000223D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142947, XrefRangeEnd = 142954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnPreRender()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_OnPreRender_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000241FC File Offset: 0x000223FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142954, XrefRangeEnd = 142990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetStencilMaterial(Material baseMaterial, int stencilID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetStencilMaterial_Public_Static_Material_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00024250 File Offset: 0x00022450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143021, RefRangeEnd = 143023, XrefRangeStart = 142990, XrefRangeEnd = 143021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseStencilMaterial(Material stencilMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stencilMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_ReleaseStencilMaterial_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00024288 File Offset: 0x00022488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143023, XrefRangeEnd = 143047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetBaseMaterial(Material stencilMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stencilMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetBaseMaterial_Public_Static_Material_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x000242CC File Offset: 0x000224CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143047, XrefRangeEnd = 143059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material SetStencil(Material material, int stencilID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_SetStencil_Public_Static_Material_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00024320 File Offset: 0x00022520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143059, XrefRangeEnd = 143087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stencilMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_AddMaskingMaterial_Public_Static_Void_Material_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00024378 File Offset: 0x00022578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143087, XrefRangeEnd = 143112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveStencilMaterial(Material stencilMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stencilMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_RemoveStencilMaterial_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000243B0 File Offset: 0x000225B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143112, XrefRangeEnd = 143169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseBaseMaterial(Material baseMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_ReleaseBaseMaterial_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x000243E8 File Offset: 0x000225E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143169, XrefRangeEnd = 143199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearMaterials()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_ClearMaterials_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00024410 File Offset: 0x00022610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143199, XrefRangeEnd = 143265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetStencilID(GameObject obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetStencilID_Public_Static_Int32_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00024454 File Offset: 0x00022654
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143291, RefRangeEnd = 143293, XrefRangeStart = 143265, XrefRangeEnd = 143291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetMaterialForRendering_Public_Static_Material_MaskableGraphic_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000244AC File Offset: 0x000226AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143293, XrefRangeEnd = 143317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform FindRootSortOverrideCanvas(Transform start)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_FindRootSortOverrideCanvas_Private_Static_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x000244F0 File Offset: 0x000226F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143353, RefRangeEnd = 143355, XrefRangeStart = 143317, XrefRangeEnd = 143353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Internal_Static_Material_TMP_FontAsset_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00024554 File Offset: 0x00022754
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 143421, RefRangeEnd = 143425, XrefRangeStart = 143355, XrefRangeEnd = 143421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceMaterial);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Public_Static_Material_Material_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x000245AC File Offset: 0x000227AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143443, RefRangeEnd = 143445, XrefRangeStart = 143425, XrefRangeEnd = 143443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddFallbackMaterialReference(Material targetMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_AddFallbackMaterialReference_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000245E4 File Offset: 0x000227E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143445, XrefRangeEnd = 143469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveFallbackMaterialReference(Material targetMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_RemoveFallbackMaterialReference_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0002461C File Offset: 0x0002281C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143503, RefRangeEnd = 143504, XrefRangeStart = 143469, XrefRangeEnd = 143503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupFallbackMaterials()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_CleanupFallbackMaterials_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00024644 File Offset: 0x00022844
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 143531, RefRangeEnd = 143537, XrefRangeStart = 143504, XrefRangeEnd = 143531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseFallbackMaterial(Material fallbackMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallbackMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_ReleaseFallbackMaterial_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0002467C File Offset: 0x0002287C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143537, XrefRangeEnd = 143575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyMaterialPresetProperties(Material source, Material destination)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_CopyMaterialPresetProperties_Public_Static_Void_Material_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x000059DF File Offset: 0x00003BDF
		public TMP_MaterialManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x000246C4 File Offset: 0x000228C4
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x000059E8 File Offset: 0x00003BE8
		public unsafe static List<TMP_MaterialManager.MaskingMaterial> m_materialList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_MaterialManager.NativeFieldInfoPtr_m_materialList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_MaterialManager.MaskingMaterial>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MaterialManager.NativeFieldInfoPtr_m_materialList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x000246EC File Offset: 0x000228EC
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x000059FA File Offset: 0x00003BFA
		public unsafe static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterials, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<long, TMP_MaterialManager.FallbackMaterial>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterials, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00024714 File Offset: 0x00022914
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x00005A0C File Offset: 0x00003C0C
		public unsafe static Dictionary<int, long> m_fallbackMaterialLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterialLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, long>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterialLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x0002473C File Offset: 0x0002293C
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x00005A1E File Offset: 0x00003C1E
		public unsafe static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackCleanupList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_MaterialManager.FallbackMaterial>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackCleanupList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x00024764 File Offset: 0x00022964
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x00005A30 File Offset: 0x00003C30
		public unsafe static bool isFallbackListDirty
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TMP_MaterialManager.NativeFieldInfoPtr_isFallbackListDirty, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MaterialManager.NativeFieldInfoPtr_isFallbackListDirty, (void*)(&value));
			}
		}

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeFieldInfoPtr_m_materialList;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackMaterials;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackMaterialLookup;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackCleanupList;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeFieldInfoPtr_isFallbackListDirty;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_OnPreRender_Private_Static_Void_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_GetStencilMaterial_Public_Static_Material_Material_Int32_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseStencilMaterial_Public_Static_Void_Material_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseMaterial_Public_Static_Material_Material_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_SetStencil_Public_Static_Material_Material_Int32_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_AddMaskingMaterial_Public_Static_Void_Material_Material_Int32_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_RemoveStencilMaterial_Public_Static_Void_Material_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseBaseMaterial_Public_Static_Void_Material_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_ClearMaterials_Public_Static_Void_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_GetStencilID_Public_Static_Int32_GameObject_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterialForRendering_Public_Static_Material_MaskableGraphic_Material_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_FindRootSortOverrideCanvas_Private_Static_Transform_Transform_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_GetFallbackMaterial_Internal_Static_Material_TMP_FontAsset_Material_Int32_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_GetFallbackMaterial_Public_Static_Material_Material_Material_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_AddFallbackMaterialReference_Public_Static_Void_Material_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFallbackMaterialReference_Public_Static_Void_Material_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_CleanupFallbackMaterials_Public_Static_Void_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseFallbackMaterial_Public_Static_Void_Material_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_CopyMaterialPresetProperties_Public_Static_Void_Material_Material_0;

		// Token: 0x0200009E RID: 158
		public class FallbackMaterial : global::Il2CppSystem.Object
		{
			// Token: 0x06000F82 RID: 3970 RVA: 0x0003DB10 File Offset: 0x0003BD10
			// Note: this type is marked as 'beforefieldinit'.
			static FallbackMaterial()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "FallbackMaterial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr);
				TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, "fallbackID");
				TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, "sourceMaterial");
				TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterialCRC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, "sourceMaterialCRC");
				TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, "fallbackMaterial");
				TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, "count");
				TMP_MaterialManager.FallbackMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, 100664878);
			}

			// Token: 0x06000F83 RID: 3971 RVA: 0x0003DBB4 File Offset: 0x0003BDB4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FallbackMaterial()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.FallbackMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F84 RID: 3972 RVA: 0x000095A3 File Offset: 0x000077A3
			public FallbackMaterial(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A4 RID: 1444
			// (get) Token: 0x06000F85 RID: 3973 RVA: 0x0003DBF0 File Offset: 0x0003BDF0
			// (set) Token: 0x06000F86 RID: 3974 RVA: 0x000095AC File Offset: 0x000077AC
			public unsafe long fallbackID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackID)) = value;
				}
			}

			// Token: 0x170005A5 RID: 1445
			// (get) Token: 0x06000F87 RID: 3975 RVA: 0x0003DC18 File Offset: 0x0003BE18
			// (set) Token: 0x06000F88 RID: 3976 RVA: 0x000095C7 File Offset: 0x000077C7
			public unsafe Material sourceMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005A6 RID: 1446
			// (get) Token: 0x06000F89 RID: 3977 RVA: 0x0003DC48 File Offset: 0x0003BE48
			// (set) Token: 0x06000F8A RID: 3978 RVA: 0x000095E6 File Offset: 0x000077E6
			public unsafe int sourceMaterialCRC
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterialCRC);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterialCRC)) = value;
				}
			}

			// Token: 0x170005A7 RID: 1447
			// (get) Token: 0x06000F8B RID: 3979 RVA: 0x0003DC70 File Offset: 0x0003BE70
			// (set) Token: 0x06000F8C RID: 3980 RVA: 0x00009601 File Offset: 0x00007801
			public unsafe Material fallbackMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005A8 RID: 1448
			// (get) Token: 0x06000F8D RID: 3981 RVA: 0x0003DCA0 File Offset: 0x0003BEA0
			// (set) Token: 0x06000F8E RID: 3982 RVA: 0x00009620 File Offset: 0x00007820
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x04000C40 RID: 3136
			private static readonly IntPtr NativeFieldInfoPtr_fallbackID;

			// Token: 0x04000C41 RID: 3137
			private static readonly IntPtr NativeFieldInfoPtr_sourceMaterial;

			// Token: 0x04000C42 RID: 3138
			private static readonly IntPtr NativeFieldInfoPtr_sourceMaterialCRC;

			// Token: 0x04000C43 RID: 3139
			private static readonly IntPtr NativeFieldInfoPtr_fallbackMaterial;

			// Token: 0x04000C44 RID: 3140
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000C45 RID: 3141
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200009F RID: 159
		public class MaskingMaterial : global::Il2CppSystem.Object
		{
			// Token: 0x06000F8F RID: 3983 RVA: 0x0003DCC8 File Offset: 0x0003BEC8
			// Note: this type is marked as 'beforefieldinit'.
			static MaskingMaterial()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "MaskingMaterial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr);
				TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_baseMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr, "baseMaterial");
				TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr, "stencilMaterial");
				TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr, "count");
				TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr, "stencilID");
				TMP_MaterialManager.MaskingMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr, 100664879);
			}

			// Token: 0x06000F90 RID: 3984 RVA: 0x0003DD58 File Offset: 0x0003BF58
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MaskingMaterial()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.MaskingMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F91 RID: 3985 RVA: 0x0000963B File Offset: 0x0000783B
			public MaskingMaterial(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A9 RID: 1449
			// (get) Token: 0x06000F92 RID: 3986 RVA: 0x0003DD94 File Offset: 0x0003BF94
			// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00009644 File Offset: 0x00007844
			public unsafe Material baseMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_baseMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_baseMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005AA RID: 1450
			// (get) Token: 0x06000F94 RID: 3988 RVA: 0x0003DDC4 File Offset: 0x0003BFC4
			// (set) Token: 0x06000F95 RID: 3989 RVA: 0x00009663 File Offset: 0x00007863
			public unsafe Material stencilMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005AB RID: 1451
			// (get) Token: 0x06000F96 RID: 3990 RVA: 0x0003DDF4 File Offset: 0x0003BFF4
			// (set) Token: 0x06000F97 RID: 3991 RVA: 0x00009682 File Offset: 0x00007882
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x170005AC RID: 1452
			// (get) Token: 0x06000F98 RID: 3992 RVA: 0x0003DE1C File Offset: 0x0003C01C
			// (set) Token: 0x06000F99 RID: 3993 RVA: 0x0000969D File Offset: 0x0000789D
			public unsafe int stencilID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilID)) = value;
				}
			}

			// Token: 0x04000C46 RID: 3142
			private static readonly IntPtr NativeFieldInfoPtr_baseMaterial;

			// Token: 0x04000C47 RID: 3143
			private static readonly IntPtr NativeFieldInfoPtr_stencilMaterial;

			// Token: 0x04000C48 RID: 3144
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000C49 RID: 3145
			private static readonly IntPtr NativeFieldInfoPtr_stencilID;

			// Token: 0x04000C4A RID: 3146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000A0 RID: 160
		[ObfuscatedName("TMPro.TMP_MaterialManager+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000F9A RID: 3994 RVA: 0x0003DE44 File Offset: 0x0003C044
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr);
				TMP_MaterialManager.__c__DisplayClass9_0.NativeFieldInfoPtr_stencilMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr, "stencilMaterial");
				TMP_MaterialManager.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr, 100664880);
				TMP_MaterialManager.__c__DisplayClass9_0.NativeMethodInfoPtr__GetBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr, 100664881);
			}

			// Token: 0x06000F9B RID: 3995 RVA: 0x0003DEAC File Offset: 0x0003C0AC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F9C RID: 3996 RVA: 0x0003DEE8 File Offset: 0x0003C0E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142922, XrefRangeEnd = 142932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBaseMaterial_b__0(TMP_MaterialManager.MaskingMaterial item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass9_0.NativeMethodInfoPtr__GetBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F9D RID: 3997 RVA: 0x000096B8 File Offset: 0x000078B8
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005AD RID: 1453
			// (get) Token: 0x06000F9E RID: 3998 RVA: 0x0003DF38 File Offset: 0x0003C138
			// (set) Token: 0x06000F9F RID: 3999 RVA: 0x000096C1 File Offset: 0x000078C1
			public unsafe Material stencilMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass9_0.NativeFieldInfoPtr_stencilMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass9_0.NativeFieldInfoPtr_stencilMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C4B RID: 3147
			private static readonly IntPtr NativeFieldInfoPtr_stencilMaterial;

			// Token: 0x04000C4C RID: 3148
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C4D RID: 3149
			private static readonly IntPtr NativeMethodInfoPtr__GetBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0;
		}

		// Token: 0x020000A1 RID: 161
		[ObfuscatedName("TMPro.TMP_MaterialManager+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000FA0 RID: 4000 RVA: 0x0003DF68 File Offset: 0x0003C168
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr);
				TMP_MaterialManager.__c__DisplayClass11_0.NativeFieldInfoPtr_stencilMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr, "stencilMaterial");
				TMP_MaterialManager.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr, 100664882);
				TMP_MaterialManager.__c__DisplayClass11_0.NativeMethodInfoPtr__AddMaskingMaterial_b__0_Internal_Boolean_MaskingMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr, 100664883);
			}

			// Token: 0x06000FA1 RID: 4001 RVA: 0x0003DFD0 File Offset: 0x0003C1D0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FA2 RID: 4002 RVA: 0x0003E00C File Offset: 0x0003C20C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142932, XrefRangeEnd = 142937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddMaskingMaterial_b__0(TMP_MaterialManager.MaskingMaterial item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass11_0.NativeMethodInfoPtr__AddMaskingMaterial_b__0_Internal_Boolean_MaskingMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000FA3 RID: 4003 RVA: 0x000096E0 File Offset: 0x000078E0
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005AE RID: 1454
			// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x0003E05C File Offset: 0x0003C25C
			// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x000096E9 File Offset: 0x000078E9
			public unsafe Material stencilMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass11_0.NativeFieldInfoPtr_stencilMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass11_0.NativeFieldInfoPtr_stencilMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C4E RID: 3150
			private static readonly IntPtr NativeFieldInfoPtr_stencilMaterial;

			// Token: 0x04000C4F RID: 3151
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C50 RID: 3152
			private static readonly IntPtr NativeMethodInfoPtr__AddMaskingMaterial_b__0_Internal_Boolean_MaskingMaterial_0;
		}

		// Token: 0x020000A2 RID: 162
		[ObfuscatedName("TMPro.TMP_MaterialManager+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000FA6 RID: 4006 RVA: 0x0003E08C File Offset: 0x0003C28C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr);
				TMP_MaterialManager.__c__DisplayClass12_0.NativeFieldInfoPtr_stencilMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr, "stencilMaterial");
				TMP_MaterialManager.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr, 100664884);
				TMP_MaterialManager.__c__DisplayClass12_0.NativeMethodInfoPtr__RemoveStencilMaterial_b__0_Internal_Boolean_MaskingMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr, 100664885);
			}

			// Token: 0x06000FA7 RID: 4007 RVA: 0x0003E0F4 File Offset: 0x0003C2F4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FA8 RID: 4008 RVA: 0x0003E130 File Offset: 0x0003C330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142937, XrefRangeEnd = 142942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveStencilMaterial_b__0(TMP_MaterialManager.MaskingMaterial item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass12_0.NativeMethodInfoPtr__RemoveStencilMaterial_b__0_Internal_Boolean_MaskingMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000FA9 RID: 4009 RVA: 0x00009708 File Offset: 0x00007908
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005AF RID: 1455
			// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0003E180 File Offset: 0x0003C380
			// (set) Token: 0x06000FAB RID: 4011 RVA: 0x00009711 File Offset: 0x00007911
			public unsafe Material stencilMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass12_0.NativeFieldInfoPtr_stencilMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass12_0.NativeFieldInfoPtr_stencilMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C51 RID: 3153
			private static readonly IntPtr NativeFieldInfoPtr_stencilMaterial;

			// Token: 0x04000C52 RID: 3154
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C53 RID: 3155
			private static readonly IntPtr NativeMethodInfoPtr__RemoveStencilMaterial_b__0_Internal_Boolean_MaskingMaterial_0;
		}

		// Token: 0x020000A3 RID: 163
		[ObfuscatedName("TMPro.TMP_MaterialManager+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000FAC RID: 4012 RVA: 0x0003E1B0 File Offset: 0x0003C3B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr);
				TMP_MaterialManager.__c__DisplayClass13_0.NativeFieldInfoPtr_baseMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr, "baseMaterial");
				TMP_MaterialManager.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr, 100664886);
				TMP_MaterialManager.__c__DisplayClass13_0.NativeMethodInfoPtr__ReleaseBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr, 100664887);
			}

			// Token: 0x06000FAD RID: 4013 RVA: 0x0003E218 File Offset: 0x0003C418
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FAE RID: 4014 RVA: 0x0003E254 File Offset: 0x0003C454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142942, XrefRangeEnd = 142947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ReleaseBaseMaterial_b__0(TMP_MaterialManager.MaskingMaterial item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass13_0.NativeMethodInfoPtr__ReleaseBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000FAF RID: 4015 RVA: 0x00009730 File Offset: 0x00007930
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005B0 RID: 1456
			// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x0003E2A4 File Offset: 0x0003C4A4
			// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x00009739 File Offset: 0x00007939
			public unsafe Material baseMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass13_0.NativeFieldInfoPtr_baseMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass13_0.NativeFieldInfoPtr_baseMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C54 RID: 3156
			private static readonly IntPtr NativeFieldInfoPtr_baseMaterial;

			// Token: 0x04000C55 RID: 3157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C56 RID: 3158
			private static readonly IntPtr NativeMethodInfoPtr__ReleaseBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0;
		}
	}
}
