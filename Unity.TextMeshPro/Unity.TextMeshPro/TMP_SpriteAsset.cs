using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;

namespace TMPro
{
	// Token: 0x02000053 RID: 83
	public class TMP_SpriteAsset : TMP_Asset
	{
		// Token: 0x06000971 RID: 2417 RVA: 0x0002868C File Offset: 0x0002688C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SpriteAsset()
		{
			Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SpriteAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr);
			TMP_SpriteAsset.NativeFieldInfoPtr_m_NameLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_NameLookup");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_GlyphIndexLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_GlyphIndexLookup");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_Version");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_FaceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_FaceInfo");
			TMP_SpriteAsset.NativeFieldInfoPtr_spriteSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "spriteSheet");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_SpriteCharacterTable");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_SpriteCharacterLookup");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_SpriteGlyphTable");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_SpriteGlyphLookup");
			TMP_SpriteAsset.NativeFieldInfoPtr_spriteInfoList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "spriteInfoList");
			TMP_SpriteAsset.NativeFieldInfoPtr_fallbackSpriteAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "fallbackSpriteAssets");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_IsSpriteAssetLookupTablesDirty");
			TMP_SpriteAsset.NativeFieldInfoPtr_k_searchedSpriteAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "k_searchedSpriteAssets");
			TMP_SpriteAsset.NativeMethodInfoPtr_get_version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664227);
			TMP_SpriteAsset.NativeMethodInfoPtr_set_version_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664228);
			TMP_SpriteAsset.NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664229);
			TMP_SpriteAsset.NativeMethodInfoPtr_set_faceInfo_Internal_set_Void_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664230);
			TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterTable_Public_get_List_1_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664231);
			TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterTable_Internal_set_Void_List_1_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664232);
			TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterLookupTable_Public_get_Dictionary_2_UInt32_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664233);
			TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterLookupTable_Internal_set_Void_Dictionary_2_UInt32_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664234);
			TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteGlyphTable_Public_get_List_1_TMP_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664235);
			TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteGlyphTable_Internal_set_Void_List_1_TMP_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664236);
			TMP_SpriteAsset.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664237);
			TMP_SpriteAsset.NativeMethodInfoPtr_GetDefaultSpriteMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664238);
			TMP_SpriteAsset.NativeMethodInfoPtr_UpdateLookupTables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664239);
			TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromHashcode_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664240);
			TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromUnicode_Public_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664241);
			TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromName_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664242);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664243);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664244);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664245);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664246);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664247);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664248);
			TMP_SpriteAsset.NativeMethodInfoPtr_SortGlyphTable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664249);
			TMP_SpriteAsset.NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664250);
			TMP_SpriteAsset.NativeMethodInfoPtr_SortGlyphAndCharacterTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664251);
			TMP_SpriteAsset.NativeMethodInfoPtr_UpgradeSpriteAsset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664252);
			TMP_SpriteAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664253);
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x000289DC File Offset: 0x00026BDC
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x00028A14 File Offset: 0x00026C14
		public unsafe string version
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_get_version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_set_version_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x00028A58 File Offset: 0x00026C58
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x00028A90 File Offset: 0x00026C90
		public unsafe FaceInfo faceInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FaceInfo(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_set_faceInfo_Internal_set_Void_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x00028AD8 File Offset: 0x00026CD8
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x00028B18 File Offset: 0x00026D18
		public unsafe List<TMP_SpriteCharacter> spriteCharacterTable
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 144942, RefRangeEnd = 144951, XrefRangeStart = 144941, XrefRangeEnd = 144942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterTable_Public_get_List_1_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_SpriteCharacter>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterTable_Internal_set_Void_List_1_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x00028B5C File Offset: 0x00026D5C
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x00028B9C File Offset: 0x00026D9C
		public unsafe Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 144952, RefRangeEnd = 144954, XrefRangeStart = 144951, XrefRangeEnd = 144952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterLookupTable_Public_get_Dictionary_2_UInt32_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_SpriteCharacter>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterLookupTable_Internal_set_Void_Dictionary_2_UInt32_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00028BE0 File Offset: 0x00026DE0
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x00028C20 File Offset: 0x00026E20
		public unsafe List<TMP_SpriteGlyph> spriteGlyphTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteGlyphTable_Public_get_List_1_TMP_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_SpriteGlyph>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteGlyphTable_Internal_set_Void_List_1_TMP_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00028C64 File Offset: 0x00026E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144954, XrefRangeEnd = 144960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00028C98 File Offset: 0x00026E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144960, XrefRangeEnd = 144974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetDefaultSpriteMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_GetDefaultSpriteMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00028CD8 File Offset: 0x00026ED8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 145062, RefRangeEnd = 145070, XrefRangeStart = 144974, XrefRangeEnd = 145062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLookupTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_UpdateLookupTables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00028D0C File Offset: 0x00026F0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 145074, RefRangeEnd = 145077, XrefRangeStart = 145070, XrefRangeEnd = 145074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpriteIndexFromHashcode(int hashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromHashcode_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00028D58 File Offset: 0x00026F58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 145081, RefRangeEnd = 145086, XrefRangeStart = 145077, XrefRangeEnd = 145081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpriteIndexFromUnicode(uint unicode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromUnicode_Public_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00028DA4 File Offset: 0x00026FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145086, XrefRangeEnd = 145095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpriteIndexFromName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromName_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00028DF4 File Offset: 0x00026FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145095, XrefRangeEnd = 145132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00028E64 File Offset: 0x00027064
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 145150, RefRangeEnd = 145155, XrefRangeStart = 145132, XrefRangeEnd = 145150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAssets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00028ED4 File Offset: 0x000270D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145158, RefRangeEnd = 145159, XrefRangeStart = 145155, XrefRangeEnd = 145158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00028F44 File Offset: 0x00027144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145159, XrefRangeEnd = 145212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00028FB4 File Offset: 0x000271B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 145230, RefRangeEnd = 145233, XrefRangeStart = 145212, XrefRangeEnd = 145230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAssets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00029024 File Offset: 0x00027224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145236, RefRangeEnd = 145237, XrefRangeStart = 145233, XrefRangeEnd = 145236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00029094 File Offset: 0x00027294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145237, XrefRangeEnd = 145259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGlyphTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SortGlyphTable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000290C8 File Offset: 0x000272C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145259, XrefRangeEnd = 145281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortCharacterTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x000290FC File Offset: 0x000272FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145281, XrefRangeEnd = 145325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGlyphAndCharacterTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SortGlyphAndCharacterTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00029130 File Offset: 0x00027330
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 145405, RefRangeEnd = 145407, XrefRangeStart = 145325, XrefRangeEnd = 145405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpgradeSpriteAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_UpgradeSpriteAsset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00029164 File Offset: 0x00027364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145407, XrefRangeEnd = 145420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0000663F File Offset: 0x0000483F
		public TMP_SpriteAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x000291A0 File Offset: 0x000273A0
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x00006648 File Offset: 0x00004848
		public unsafe Dictionary<int, int> m_NameLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_NameLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_NameLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x000291D0 File Offset: 0x000273D0
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x00006667 File Offset: 0x00004867
		public unsafe Dictionary<uint, int> m_GlyphIndexLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_GlyphIndexLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_GlyphIndexLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00029200 File Offset: 0x00027400
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x00006686 File Offset: 0x00004886
		public unsafe string m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_Version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_Version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00029228 File Offset: 0x00027428
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x000066A5 File Offset: 0x000048A5
		public FaceInfo m_FaceInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_FaceInfo);
				return new FaceInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_FaceInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00029258 File Offset: 0x00027458
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x000066D3 File Offset: 0x000048D3
		public unsafe Texture spriteSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_spriteSheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_spriteSheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x00029288 File Offset: 0x00027488
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x000066F2 File Offset: 0x000048F2
		public unsafe List<TMP_SpriteCharacter> m_SpriteCharacterTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_SpriteCharacter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x000292B8 File Offset: 0x000274B8
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x00006711 File Offset: 0x00004911
		public unsafe Dictionary<uint, TMP_SpriteCharacter> m_SpriteCharacterLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_SpriteCharacter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x000292E8 File Offset: 0x000274E8
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x00006730 File Offset: 0x00004930
		public unsafe List<TMP_SpriteGlyph> m_SpriteGlyphTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_SpriteGlyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00029318 File Offset: 0x00027518
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x0000674F File Offset: 0x0000494F
		public unsafe Dictionary<uint, TMP_SpriteGlyph> m_SpriteGlyphLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_SpriteGlyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00029348 File Offset: 0x00027548
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x0000676E File Offset: 0x0000496E
		public unsafe List<TMP_Sprite> spriteInfoList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_spriteInfoList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_spriteInfoList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00029378 File Offset: 0x00027578
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x0000678D File Offset: 0x0000498D
		public unsafe List<TMP_SpriteAsset> fallbackSpriteAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_fallbackSpriteAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_SpriteAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_fallbackSpriteAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x000293A8 File Offset: 0x000275A8
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x000067AC File Offset: 0x000049AC
		public unsafe bool m_IsSpriteAssetLookupTablesDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty)) = value;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x000293D0 File Offset: 0x000275D0
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x000067C7 File Offset: 0x000049C7
		public unsafe static HashSet<int> k_searchedSpriteAssets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_SpriteAsset.NativeFieldInfoPtr_k_searchedSpriteAssets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_SpriteAsset.NativeFieldInfoPtr_k_searchedSpriteAssets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeFieldInfoPtr_m_NameLookup;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndexLookup;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeFieldInfoPtr_m_FaceInfo;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeFieldInfoPtr_spriteSheet;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteCharacterTable;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteCharacterLookup;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteGlyphTable;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteGlyphLookup;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeFieldInfoPtr_spriteInfoList;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeFieldInfoPtr_fallbackSpriteAssets;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeFieldInfoPtr_k_searchedSpriteAssets;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Public_get_String_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_set_version_Internal_set_Void_String_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_set_faceInfo_Internal_set_Void_FaceInfo_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteCharacterTable_Public_get_List_1_TMP_SpriteCharacter_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteCharacterTable_Internal_set_Void_List_1_TMP_SpriteCharacter_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteCharacterLookupTable_Public_get_Dictionary_2_UInt32_TMP_SpriteCharacter_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteCharacterLookupTable_Internal_set_Void_Dictionary_2_UInt32_TMP_SpriteCharacter_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteGlyphTable_Public_get_List_1_TMP_SpriteGlyph_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteGlyphTable_Internal_set_Void_List_1_TMP_SpriteGlyph_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultSpriteMaterial_Private_Material_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLookupTables_Public_Void_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteIndexFromHashcode_Public_Int32_Int32_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteIndexFromUnicode_Public_Int32_UInt32_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteIndexFromName_Public_Int32_String_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByUnicode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByHashCode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_SortGlyphTable_Public_Void_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_SortGlyphAndCharacterTables_Internal_Void_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeSpriteAsset_Private_Void_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000A6 RID: 166
		[ObfuscatedName("TMPro.TMP_SpriteAsset+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000FE1 RID: 4065 RVA: 0x0003E9D0 File Offset: 0x0003CBD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr);
				TMP_SpriteAsset.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, "<>9");
				TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, "<>9__40_0");
				TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, "<>9__41_0");
				TMP_SpriteAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, 100664896);
				TMP_SpriteAsset.__c.NativeMethodInfoPtr__SortGlyphTable_b__40_0_Internal_UInt32_TMP_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, 100664897);
				TMP_SpriteAsset.__c.NativeMethodInfoPtr__SortCharacterTable_b__41_0_Internal_UInt32_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, 100664898);
			}

			// Token: 0x06000FE2 RID: 4066 RVA: 0x0003EA74 File Offset: 0x0003CC74
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FE3 RID: 4067 RVA: 0x0003EAB0 File Offset: 0x0003CCB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint _SortGlyphTable_b__40_0(TMP_SpriteGlyph item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.__c.NativeMethodInfoPtr__SortGlyphTable_b__40_0_Internal_UInt32_TMP_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000FE4 RID: 4068 RVA: 0x0003EB00 File Offset: 0x0003CD00
			[CallerCount(0)]
			public unsafe uint _SortCharacterTable_b__41_0(TMP_SpriteCharacter c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.__c.NativeMethodInfoPtr__SortCharacterTable_b__41_0_Internal_UInt32_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000FE5 RID: 4069 RVA: 0x0000998A File Offset: 0x00007B8A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005C5 RID: 1477
			// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x0003EB50 File Offset: 0x0003CD50
			// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x00009993 File Offset: 0x00007B93
			public unsafe static TMP_SpriteAsset.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C6 RID: 1478
			// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x0003EB78 File Offset: 0x0003CD78
			// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x000099A5 File Offset: 0x00007BA5
			public unsafe static Func<TMP_SpriteGlyph, uint> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TMP_SpriteGlyph, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C7 RID: 1479
			// (get) Token: 0x06000FEA RID: 4074 RVA: 0x0003EBA0 File Offset: 0x0003CDA0
			// (set) Token: 0x06000FEB RID: 4075 RVA: 0x000099B7 File Offset: 0x00007BB7
			public unsafe static Func<TMP_SpriteCharacter, uint> __9__41_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TMP_SpriteCharacter, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C70 RID: 3184
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000C71 RID: 3185
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x04000C72 RID: 3186
			private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x04000C73 RID: 3187
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C74 RID: 3188
			private static readonly IntPtr NativeMethodInfoPtr__SortGlyphTable_b__40_0_Internal_UInt32_TMP_SpriteGlyph_0;

			// Token: 0x04000C75 RID: 3189
			private static readonly IntPtr NativeMethodInfoPtr__SortCharacterTable_b__41_0_Internal_UInt32_TMP_SpriteCharacter_0;
		}
	}
}
