using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace TMPro
{
	// Token: 0x02000037 RID: 55
	public static class TMP_FontUtilities : Object
	{
		// Token: 0x060005B6 RID: 1462 RVA: 0x0001C400 File Offset: 0x0001A600
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_FontUtilities()
		{
			Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr);
			TMP_FontUtilities.NativeFieldInfoPtr_k_searchedFontAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, "k_searchedFontAssets");
			TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663833);
			TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663834);
			TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663835);
			TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663836);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0001C494 File Offset: 0x0001A694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140600, XrefRangeEnd = 140615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr5) : null;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0001C50C File Offset: 0x0001A70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140615, XrefRangeEnd = 140625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fonts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr5) : null;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0001C584 File Offset: 0x0001A784
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 140656, RefRangeEnd = 140660, XrefRangeStart = 140625, XrefRangeEnd = 140656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr5) : null;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0001C5FC File Offset: 0x0001A7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140660, XrefRangeEnd = 140670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fonts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr5) : null;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00004DF7 File Offset: 0x00002FF7
		public TMP_FontUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x0001C674 File Offset: 0x0001A874
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x00004E00 File Offset: 0x00003000
		public unsafe static List<int> k_searchedFontAssets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontUtilities.NativeFieldInfoPtr_k_searchedFontAssets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontUtilities.NativeFieldInfoPtr_k_searchedFontAssets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeFieldInfoPtr_k_searchedFontAssets;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0;
	}
}
