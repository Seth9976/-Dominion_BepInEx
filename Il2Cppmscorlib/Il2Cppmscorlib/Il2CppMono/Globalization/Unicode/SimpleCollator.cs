using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x0200001C RID: 28
	public class SimpleCollator : Object
	{
		// Token: 0x0600012D RID: 301 RVA: 0x00026720 File Offset: 0x00024920
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleCollator()
		{
			Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "SimpleCollator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr);
			SimpleCollator.NativeFieldInfoPtr_QuickCheckDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "QuickCheckDisabled");
			SimpleCollator.NativeFieldInfoPtr_invariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "invariant");
			SimpleCollator.NativeFieldInfoPtr_textInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "textInfo");
			SimpleCollator.NativeFieldInfoPtr_cjkIndexer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkIndexer");
			SimpleCollator.NativeFieldInfoPtr_contractions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "contractions");
			SimpleCollator.NativeFieldInfoPtr_level2Maps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "level2Maps");
			SimpleCollator.NativeFieldInfoPtr_unsafeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "unsafeFlags");
			SimpleCollator.NativeFieldInfoPtr_cjkCatTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkCatTable");
			SimpleCollator.NativeFieldInfoPtr_cjkLv1Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkLv1Table");
			SimpleCollator.NativeFieldInfoPtr_cjkLv2Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkLv2Table");
			SimpleCollator.NativeFieldInfoPtr_cjkLv2Indexer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkLv2Indexer");
			SimpleCollator.NativeFieldInfoPtr_lcid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "lcid");
			SimpleCollator.NativeFieldInfoPtr_frenchSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "frenchSort");
			SimpleCollator.NativeFieldInfoPtr_UnsafeFlagLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "UnsafeFlagLength");
			SimpleCollator.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663447);
			SimpleCollator.NativeMethodInfoPtr_SetCJKTable_Private_Void_CultureInfo_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663448);
			SimpleCollator.NativeMethodInfoPtr_GetNeutralCulture_Private_Static_CultureInfo_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663449);
			SimpleCollator.NativeMethodInfoPtr_Category_Private_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663450);
			SimpleCollator.NativeMethodInfoPtr_Level1_Private_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663451);
			SimpleCollator.NativeMethodInfoPtr_Level2_Private_Byte_Int32_ExtenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663452);
			SimpleCollator.NativeMethodInfoPtr_IsHalfKana_Private_Static_Boolean_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663453);
			SimpleCollator.NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663454);
			SimpleCollator.NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663455);
			SimpleCollator.NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663456);
			SimpleCollator.NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663457);
			SimpleCollator.NativeMethodInfoPtr_FilterOptions_Private_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663458);
			SimpleCollator.NativeMethodInfoPtr_GetExtenderType_Private_ExtenderType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663459);
			SimpleCollator.NativeMethodInfoPtr_ToDashTypeValue_Private_Static_Byte_ExtenderType_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663460);
			SimpleCollator.NativeMethodInfoPtr_FilterExtender_Private_Int32_Int32_ExtenderType_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663461);
			SimpleCollator.NativeMethodInfoPtr_IsIgnorable_Private_Static_Boolean_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663462);
			SimpleCollator.NativeMethodInfoPtr_IsSafe_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663463);
			SimpleCollator.NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663464);
			SimpleCollator.NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663465);
			SimpleCollator.NativeMethodInfoPtr_GetSortKey_Private_Void_String_Int32_Int32_SortKeyBuffer_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663466);
			SimpleCollator.NativeMethodInfoPtr_FillSortKeyRaw_Private_Void_Int32_ExtenderType_SortKeyBuffer_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663467);
			SimpleCollator.NativeMethodInfoPtr_FillSurrogateSortKeyRaw_Private_Void_Int32_SortKeyBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663468);
			SimpleCollator.NativeMethodInfoPtr_Compare_Internal_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663469);
			SimpleCollator.NativeMethodInfoPtr_ClearBuffer_Private_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663470);
			SimpleCollator.NativeMethodInfoPtr_CompareInternal_Private_Int32_String_Int32_Int32_String_Int32_Int32_byref_Boolean_byref_Boolean_Boolean_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663471);
			SimpleCollator.NativeMethodInfoPtr_CompareFlagPair_Private_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663472);
			SimpleCollator.NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663473);
			SimpleCollator.NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663474);
			SimpleCollator.NativeMethodInfoPtr_IsPrefix_Private_Boolean_String_String_Int32_Int32_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663475);
			SimpleCollator.NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663476);
			SimpleCollator.NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663477);
			SimpleCollator.NativeMethodInfoPtr_QuickIndexOf_Private_Int32_String_String_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663478);
			SimpleCollator.NativeMethodInfoPtr_IndexOf_Public_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663479);
			SimpleCollator.NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663480);
			SimpleCollator.NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663481);
			SimpleCollator.NativeMethodInfoPtr_IndexOfSortKey_Private_Int32_String_Int32_Int32_ptr_Byte_Char_Int32_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663482);
			SimpleCollator.NativeMethodInfoPtr_IndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663483);
			SimpleCollator.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663484);
			SimpleCollator.NativeMethodInfoPtr_LastIndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663485);
			SimpleCollator.NativeMethodInfoPtr_LastIndexOfSortKey_Private_Int32_String_Int32_Int32_Int32_ptr_Byte_Int32_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663486);
			SimpleCollator.NativeMethodInfoPtr_LastIndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663487);
			SimpleCollator.NativeMethodInfoPtr_MatchesForward_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663488);
			SimpleCollator.NativeMethodInfoPtr_MatchesForwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663489);
			SimpleCollator.NativeMethodInfoPtr_MatchesPrimitive_Private_Boolean_CompareOptions_ptr_Byte_Int32_ExtenderType_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663490);
			SimpleCollator.NativeMethodInfoPtr_MatchesBackward_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663491);
			SimpleCollator.NativeMethodInfoPtr_MatchesBackwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663492);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00026C00 File Offset: 0x00024E00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259309, RefRangeEnd = 259310, XrefRangeStart = 259278, XrefRangeEnd = 259309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleCollator(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00026C4C File Offset: 0x00024E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259310, XrefRangeEnd = 259319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cjkIndexer);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(catTable);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(lv1Table);
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(lv2Indexer);
			ptr5 = &intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5 = IL2CPP.Il2CppObjectBaseToPtr(lv2Table);
			ptr6 = &intPtr5;
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_SetCJKTable_Private_Void_CultureInfo_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
			IntPtr intPtr8 = intPtr;
			cjkIndexer = ((intPtr8 == 0) ? null : new CodePointIndexer(intPtr8));
			IntPtr intPtr9 = intPtr2;
			catTable = ((intPtr9 == 0) ? null : new byte*(intPtr9));
			IntPtr intPtr10 = intPtr3;
			lv1Table = ((intPtr10 == 0) ? null : new byte*(intPtr10));
			IntPtr intPtr11 = intPtr4;
			lv2Indexer = ((intPtr11 == 0) ? null : new CodePointIndexer(intPtr11));
			IntPtr intPtr12 = intPtr5;
			lv2Table = ((intPtr12 == 0) ? null : new byte*(intPtr12));
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00026D60 File Offset: 0x00024F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259319, XrefRangeEnd = 259320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo GetNeutralCulture(CultureInfo info)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetNeutralCulture_Private_Static_CultureInfo_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00026DA4 File Offset: 0x00024FA4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 259322, RefRangeEnd = 259333, XrefRangeStart = 259320, XrefRangeEnd = 259322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte Category(int cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_Category_Private_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00026DF0 File Offset: 0x00024FF0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 259335, RefRangeEnd = 259342, XrefRangeStart = 259333, XrefRangeEnd = 259335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte Level1(int cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_Level1_Private_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00026E3C File Offset: 0x0002503C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 259348, RefRangeEnd = 259361, XrefRangeStart = 259342, XrefRangeEnd = 259348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte Level2(int cp, SimpleCollator.ExtenderType ext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_Level2_Private_Byte_Int32_ExtenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00026E94 File Offset: 0x00025094
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 259362, RefRangeEnd = 259367, XrefRangeStart = 259361, XrefRangeEnd = 259362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHalfKana(int cp, CompareOptions opt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsHalfKana_Private_Static_Boolean_Int32_CompareOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00026EE0 File Offset: 0x000250E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 259373, RefRangeEnd = 259380, XrefRangeStart = 259367, XrefRangeEnd = 259373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contraction GetContraction(string s, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contraction>(intPtr3) : null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00026F4C File Offset: 0x0002514C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259384, RefRangeEnd = 259386, XrefRangeStart = 259380, XrefRangeEnd = 259384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contraction GetContraction(string s, int start, int end, Il2CppReferenceArray<Contraction> clist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contraction>(intPtr3) : null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00026FCC File Offset: 0x000251CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259386, XrefRangeEnd = 259392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contraction GetTailContraction(string s, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contraction>(intPtr3) : null;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00027038 File Offset: 0x00025238
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259396, RefRangeEnd = 259398, XrefRangeStart = 259392, XrefRangeEnd = 259396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contraction GetTailContraction(string s, int start, int end, Il2CppReferenceArray<Contraction> clist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contraction>(intPtr3) : null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000270B8 File Offset: 0x000252B8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 259405, RefRangeEnd = 259413, XrefRangeStart = 259398, XrefRangeEnd = 259405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FilterOptions(int i, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_FilterOptions_Private_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00027110 File Offset: 0x00025310
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 259413, RefRangeEnd = 259418, XrefRangeStart = 259413, XrefRangeEnd = 259413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleCollator.ExtenderType GetExtenderType(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetExtenderType_Private_ExtenderType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0002715C File Offset: 0x0002535C
		[CallerCount(0)]
		public unsafe static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ext;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_ToDashTypeValue_Private_Static_Byte_ExtenderType_CompareOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000271A8 File Offset: 0x000253A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 259440, RefRangeEnd = 259444, XrefRangeStart = 259418, XrefRangeEnd = 259440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_FilterExtender_Private_Int32_Int32_ExtenderType_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00027210 File Offset: 0x00025410
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 259448, RefRangeEnd = 259453, XrefRangeStart = 259444, XrefRangeEnd = 259448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIgnorable(int i, CompareOptions opt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsIgnorable_Private_Static_Boolean_Int32_CompareOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0002725C File Offset: 0x0002545C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259453, RefRangeEnd = 259455, XrefRangeStart = 259453, XrefRangeEnd = 259453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSafe(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsSafe_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000272A8 File Offset: 0x000254A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259456, RefRangeEnd = 259458, XrefRangeStart = 259455, XrefRangeEnd = 259456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey GetSortKey(string s, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00027308 File Offset: 0x00025508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259481, RefRangeEnd = 259482, XrefRangeStart = 259458, XrefRangeEnd = 259481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey GetSortKey(string s, int start, int length, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00027384 File Offset: 0x00025584
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259515, RefRangeEnd = 259517, XrefRangeStart = 259482, XrefRangeEnd = 259515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetSortKey_Private_Void_String_Int32_Int32_SortKeyBuffer_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00027404 File Offset: 0x00025604
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259527, RefRangeEnd = 259529, XrefRangeStart = 259517, XrefRangeEnd = 259527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_FillSortKeyRaw_Private_Void_Int32_ExtenderType_SortKeyBuffer_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00027470 File Offset: 0x00025670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259529, XrefRangeEnd = 259533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_FillSurrogateSortKeyRaw_Private_Void_Int32_SortKeyBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000274C0 File Offset: 0x000256C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259535, RefRangeEnd = 259537, XrefRangeStart = 259533, XrefRangeEnd = 259535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_Compare_Internal_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00027568 File Offset: 0x00025768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259537, XrefRangeEnd = 259538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBuffer(byte* buffer, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_ClearBuffer_Private_Void_ptr_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000275B4 File Offset: 0x000257B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 259676, RefRangeEnd = 259681, XrefRangeStart = 259538, XrefRangeEnd = 259676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &targetConsumed;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sourceConsumed;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipHeadingExtenders;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref immediateBreakup;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_CompareInternal_Private_Int32_String_Int32_Int32_String_Int32_Int32_byref_Boolean_byref_Boolean_Boolean_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00027698 File Offset: 0x00025898
		[CallerCount(0)]
		public unsafe int CompareFlagPair(bool b1, bool b2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_CompareFlagPair_Private_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000276F0 File Offset: 0x000258F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259682, RefRangeEnd = 259683, XrefRangeStart = 259681, XrefRangeEnd = 259682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPrefix(string src, string target, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00027760 File Offset: 0x00025960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259685, RefRangeEnd = 259686, XrefRangeStart = 259683, XrefRangeEnd = 259685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPrefix(string s, string target, int start, int length, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000277EC File Offset: 0x000259EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259686, XrefRangeEnd = 259687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipHeadingExtenders;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsPrefix_Private_Boolean_String_String_Int32_Int32_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00027884 File Offset: 0x00025A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259688, RefRangeEnd = 259689, XrefRangeStart = 259687, XrefRangeEnd = 259688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSuffix(string src, string target, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000278F4 File Offset: 0x00025AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259689, XrefRangeEnd = 259690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSuffix(string s, string target, int start, int length, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00027980 File Offset: 0x00025B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259690, XrefRangeEnd = 259697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &testWasUnable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_QuickIndexOf_Private_Int32_String_String_Int32_Int32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00027A0C File Offset: 0x00025C0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259703, RefRangeEnd = 259705, XrefRangeStart = 259697, XrefRangeEnd = 259703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string s, string target, int start, int length, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IndexOf_Public_Int32_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00027A98 File Offset: 0x00025C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259705, XrefRangeEnd = 259708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfOrdinal(string s, string target, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00027B14 File Offset: 0x00025D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259708, XrefRangeEnd = 259709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfOrdinal(string s, char target, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00027B8C File Offset: 0x00025D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259709, XrefRangeEnd = 259712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IndexOfSortKey_Private_Int32_String_Int32_Int32_ptr_Byte_Char_Int32_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00027C3C File Offset: 0x00025E3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259744, RefRangeEnd = 259745, XrefRangeStart = 259712, XrefRangeEnd = 259744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = targetSortKey;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00027CD4 File Offset: 0x00025ED4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 259749, RefRangeEnd = 259752, XrefRangeStart = 259745, XrefRangeEnd = 259749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(string s, string target, int start, int length, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00027D60 File Offset: 0x00025F60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259756, RefRangeEnd = 259757, XrefRangeStart = 259752, XrefRangeEnd = 259756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfOrdinal(string s, string target, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_LastIndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00027DDC File Offset: 0x00025FDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259760, RefRangeEnd = 259761, XrefRangeStart = 259757, XrefRangeEnd = 259760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orgStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_LastIndexOfSortKey_Private_Int32_String_Int32_Int32_Int32_ptr_Byte_Int32_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00027E8C File Offset: 0x0002608C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259791, RefRangeEnd = 259793, XrefRangeStart = 259761, XrefRangeEnd = 259791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = targetSortKey;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_LastIndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00027F24 File Offset: 0x00026124
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259794, RefRangeEnd = 259796, XrefRangeStart = 259793, XrefRangeEnd = 259794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_MatchesForward_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00027FC8 File Offset: 0x000261C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259796, XrefRangeEnd = 259799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(ct);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_MatchesForwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ct = ((intPtr4 == 0) ? null : new Contraction(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000280A4 File Offset: 0x000262A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259799, XrefRangeEnd = 259820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref si;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = target;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_MatchesPrimitive_Private_Boolean_CompareOptions_ptr_Byte_Int32_ExtenderType_ptr_Byte_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00028140 File Offset: 0x00026340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259821, RefRangeEnd = 259822, XrefRangeStart = 259820, XrefRangeEnd = 259821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orgStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_MatchesBackward_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000281F0 File Offset: 0x000263F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259822, XrefRangeEnd = 259835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orgStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(ct);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_MatchesBackwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ct = ((intPtr4 == 0) ? null : new Contraction(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002774 File Offset: 0x00000974
		public SimpleCollator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000282DC File Offset: 0x000264DC
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0000277D File Offset: 0x0000097D
		public unsafe static bool QuickCheckDisabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SimpleCollator.NativeFieldInfoPtr_QuickCheckDisabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SimpleCollator.NativeFieldInfoPtr_QuickCheckDisabled, (void*)(&value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000282F8 File Offset: 0x000264F8
		// (set) Token: 0x06000160 RID: 352 RVA: 0x0000278B File Offset: 0x0000098B
		public unsafe static SimpleCollator invariant
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SimpleCollator.NativeFieldInfoPtr_invariant, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleCollator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SimpleCollator.NativeFieldInfoPtr_invariant, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00028320 File Offset: 0x00026520
		// (set) Token: 0x06000162 RID: 354 RVA: 0x0000279D File Offset: 0x0000099D
		public unsafe TextInfo textInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_textInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_textInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00028350 File Offset: 0x00026550
		// (set) Token: 0x06000164 RID: 356 RVA: 0x000027BC File Offset: 0x000009BC
		public unsafe CodePointIndexer cjkIndexer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkIndexer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkIndexer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00028380 File Offset: 0x00026580
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000027DB File Offset: 0x000009DB
		public unsafe Il2CppReferenceArray<Contraction> contractions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_contractions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Contraction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_contractions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000283B0 File Offset: 0x000265B0
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000027FA File Offset: 0x000009FA
		public unsafe Il2CppReferenceArray<Level2Map> level2Maps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_level2Maps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level2Map>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_level2Maps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000283E0 File Offset: 0x000265E0
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00002819 File Offset: 0x00000A19
		public unsafe Il2CppStructArray<byte> unsafeFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_unsafeFlags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_unsafeFlags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00028410 File Offset: 0x00026610
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00002838 File Offset: 0x00000A38
		public unsafe byte* cjkCatTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkCatTable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkCatTable)) = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00028434 File Offset: 0x00026634
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002853 File Offset: 0x00000A53
		public unsafe byte* cjkLv1Table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv1Table);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv1Table)) = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00028458 File Offset: 0x00026658
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0000286E File Offset: 0x00000A6E
		public unsafe byte* cjkLv2Table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv2Table);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv2Table)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0002847C File Offset: 0x0002667C
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002889 File Offset: 0x00000A89
		public unsafe CodePointIndexer cjkLv2Indexer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv2Indexer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv2Indexer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000284AC File Offset: 0x000266AC
		// (set) Token: 0x06000174 RID: 372 RVA: 0x000028A8 File Offset: 0x00000AA8
		public unsafe int lcid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_lcid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_lcid)) = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000284D4 File Offset: 0x000266D4
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000028C3 File Offset: 0x00000AC3
		public unsafe bool frenchSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_frenchSort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_frenchSort)) = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000284FC File Offset: 0x000266FC
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000028DE File Offset: 0x00000ADE
		public unsafe static int UnsafeFlagLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SimpleCollator.NativeFieldInfoPtr_UnsafeFlagLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SimpleCollator.NativeFieldInfoPtr_UnsafeFlagLength, (void*)(&value));
			}
		}

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_QuickCheckDisabled;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_invariant;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_textInfo;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_cjkIndexer;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_contractions;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_level2Maps;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_unsafeFlags;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr_cjkCatTable;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_cjkLv1Table;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_cjkLv2Table;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_cjkLv2Indexer;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr_lcid;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr_frenchSort;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_UnsafeFlagLength;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_SetCJKTable_Private_Void_CultureInfo_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_GetNeutralCulture_Private_Static_CultureInfo_CultureInfo_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_Category_Private_Byte_Int32_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_Level1_Private_Byte_Int32_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_Level2_Private_Byte_Int32_ExtenderType_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_IsHalfKana_Private_Static_Boolean_Int32_CompareOptions_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_FilterOptions_Private_Int32_Int32_CompareOptions_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_GetExtenderType_Private_ExtenderType_Int32_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_ToDashTypeValue_Private_Static_Byte_ExtenderType_CompareOptions_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_FilterExtender_Private_Int32_Int32_ExtenderType_CompareOptions_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_IsIgnorable_Private_Static_Boolean_Int32_CompareOptions_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_IsSafe_Private_Boolean_Int32_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_CompareOptions_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_Int32_Int32_CompareOptions_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_GetSortKey_Private_Void_String_Int32_Int32_SortKeyBuffer_CompareOptions_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_FillSortKeyRaw_Private_Void_Int32_ExtenderType_SortKeyBuffer_CompareOptions_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_FillSurrogateSortKeyRaw_Private_Void_Int32_SortKeyBuffer_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Internal_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_ClearBuffer_Private_Void_ptr_Byte_Int32_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_CompareInternal_Private_Int32_String_Int32_Int32_String_Int32_Int32_byref_Boolean_byref_Boolean_Boolean_Boolean_byref_Context_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_CompareFlagPair_Private_Int32_Boolean_Boolean_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_CompareOptions_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_IsPrefix_Private_Boolean_String_String_Int32_Int32_Boolean_byref_Context_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_CompareOptions_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_QuickIndexOf_Private_Int32_String_String_Int32_Int32_byref_Boolean_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_Char_Int32_Int32_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfSortKey_Private_Int32_String_Int32_Int32_ptr_Byte_Char_Int32_Boolean_byref_Context_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfSortKey_Private_Int32_String_Int32_Int32_Int32_ptr_Byte_Int32_Boolean_byref_Context_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_MatchesForward_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_MatchesForwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_MatchesPrimitive_Private_Boolean_CompareOptions_ptr_Byte_Int32_ExtenderType_ptr_Byte_Int32_Boolean_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_MatchesBackward_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_MatchesBackwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0;

		// Token: 0x0200053B RID: 1339
		[StructLayout(2)]
		public struct Context
		{
			// Token: 0x06004D93 RID: 19859 RVA: 0x0015E2BC File Offset: 0x0015C4BC
			// Note: this type is marked as 'beforefieldinit'.
			static Context()
			{
				Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "Context");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr);
				SimpleCollator.Context.NativeFieldInfoPtr_Option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "Option");
				SimpleCollator.Context.NativeFieldInfoPtr_NeverMatchFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "NeverMatchFlags");
				SimpleCollator.Context.NativeFieldInfoPtr_AlwaysMatchFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "AlwaysMatchFlags");
				SimpleCollator.Context.NativeFieldInfoPtr_Buffer1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "Buffer1");
				SimpleCollator.Context.NativeFieldInfoPtr_Buffer2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "Buffer2");
				SimpleCollator.Context.NativeFieldInfoPtr_PrevCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "PrevCode");
				SimpleCollator.Context.NativeFieldInfoPtr_PrevSortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "PrevSortKey");
				SimpleCollator.Context.NativeMethodInfoPtr__ctor_Public_Void_CompareOptions_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, 100663494);
			}

			// Token: 0x06004D94 RID: 19860 RVA: 0x0015E388 File Offset: 0x0015C588
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 259273, RefRangeEnd = 259277, XrefRangeStart = 259273, XrefRangeEnd = 259273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Context(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref opt;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = alwaysMatchFlags;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = neverMatchFlags;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer1;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer2;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = prev1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.Context.NativeMethodInfoPtr__ctor_Public_Void_CompareOptions_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D95 RID: 19861 RVA: 0x0001D594 File Offset: 0x0001B794
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, ref this));
			}

			// Token: 0x04003EA1 RID: 16033
			private static readonly IntPtr NativeFieldInfoPtr_Option;

			// Token: 0x04003EA2 RID: 16034
			private static readonly IntPtr NativeFieldInfoPtr_NeverMatchFlags;

			// Token: 0x04003EA3 RID: 16035
			private static readonly IntPtr NativeFieldInfoPtr_AlwaysMatchFlags;

			// Token: 0x04003EA4 RID: 16036
			private static readonly IntPtr NativeFieldInfoPtr_Buffer1;

			// Token: 0x04003EA5 RID: 16037
			private static readonly IntPtr NativeFieldInfoPtr_Buffer2;

			// Token: 0x04003EA6 RID: 16038
			private static readonly IntPtr NativeFieldInfoPtr_PrevCode;

			// Token: 0x04003EA7 RID: 16039
			private static readonly IntPtr NativeFieldInfoPtr_PrevSortKey;

			// Token: 0x04003EA8 RID: 16040
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CompareOptions_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_0;

			// Token: 0x04003EA9 RID: 16041
			[FieldOffset(0)]
			public readonly CompareOptions Option;

			// Token: 0x04003EAA RID: 16042
			[FieldOffset(8)]
			public readonly IntPtr NeverMatchFlags;

			// Token: 0x04003EAB RID: 16043
			[FieldOffset(16)]
			public readonly IntPtr AlwaysMatchFlags;

			// Token: 0x04003EAC RID: 16044
			[FieldOffset(24)]
			public IntPtr Buffer1;

			// Token: 0x04003EAD RID: 16045
			[FieldOffset(32)]
			public IntPtr Buffer2;

			// Token: 0x04003EAE RID: 16046
			[FieldOffset(40)]
			public int PrevCode;

			// Token: 0x04003EAF RID: 16047
			[FieldOffset(48)]
			public IntPtr PrevSortKey;
		}

		// Token: 0x0200053C RID: 1340
		[StructLayout(2)]
		public struct PreviousInfo
		{
			// Token: 0x06004D96 RID: 19862 RVA: 0x0015E400 File Offset: 0x0015C600
			// Note: this type is marked as 'beforefieldinit'.
			static PreviousInfo()
			{
				Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "PreviousInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr);
				SimpleCollator.PreviousInfo.NativeFieldInfoPtr_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr, "Code");
				SimpleCollator.PreviousInfo.NativeFieldInfoPtr_SortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr, "SortKey");
				SimpleCollator.PreviousInfo.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr, 100663495);
			}

			// Token: 0x06004D97 RID: 19863 RVA: 0x0015E468 File Offset: 0x0015C668
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 259277, RefRangeEnd = 259278, XrefRangeStart = 259277, XrefRangeEnd = 259277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PreviousInfo(bool dummy)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dummy;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.PreviousInfo.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D98 RID: 19864 RVA: 0x0001D5A6 File Offset: 0x0001B7A6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr, ref this));
			}

			// Token: 0x04003EB0 RID: 16048
			private static readonly IntPtr NativeFieldInfoPtr_Code;

			// Token: 0x04003EB1 RID: 16049
			private static readonly IntPtr NativeFieldInfoPtr_SortKey;

			// Token: 0x04003EB2 RID: 16050
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

			// Token: 0x04003EB3 RID: 16051
			[FieldOffset(0)]
			public int Code;

			// Token: 0x04003EB4 RID: 16052
			[FieldOffset(8)]
			public IntPtr SortKey;
		}

		// Token: 0x0200053D RID: 1341
		public sealed class Escape : ValueType
		{
			// Token: 0x06004D99 RID: 19865 RVA: 0x0015E49C File Offset: 0x0015C69C
			// Note: this type is marked as 'beforefieldinit'.
			static Escape()
			{
				Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "Escape");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr);
				SimpleCollator.Escape.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr, "Source");
				SimpleCollator.Escape.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr, "Index");
				SimpleCollator.Escape.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr, "Start");
				SimpleCollator.Escape.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr, "End");
				SimpleCollator.Escape.NativeFieldInfoPtr_Optional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr, "Optional");
			}

			// Token: 0x06004D9A RID: 19866 RVA: 0x0001D5B8 File Offset: 0x0001B7B8
			public Escape(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004D9B RID: 19867 RVA: 0x0001D5C1 File Offset: 0x0001B7C1
			public Escape()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr))
			{
			}

			// Token: 0x170013C0 RID: 5056
			// (get) Token: 0x06004D9C RID: 19868 RVA: 0x0015E52C File Offset: 0x0015C72C
			// (set) Token: 0x06004D9D RID: 19869 RVA: 0x0001D5D3 File Offset: 0x0001B7D3
			public unsafe string Source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Source);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Source), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170013C1 RID: 5057
			// (get) Token: 0x06004D9E RID: 19870 RVA: 0x0015E554 File Offset: 0x0015C754
			// (set) Token: 0x06004D9F RID: 19871 RVA: 0x0001D5F2 File Offset: 0x0001B7F2
			public unsafe int Index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Index)) = value;
				}
			}

			// Token: 0x170013C2 RID: 5058
			// (get) Token: 0x06004DA0 RID: 19872 RVA: 0x0015E57C File Offset: 0x0015C77C
			// (set) Token: 0x06004DA1 RID: 19873 RVA: 0x0001D60D File Offset: 0x0001B80D
			public unsafe int Start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Start)) = value;
				}
			}

			// Token: 0x170013C3 RID: 5059
			// (get) Token: 0x06004DA2 RID: 19874 RVA: 0x0015E5A4 File Offset: 0x0015C7A4
			// (set) Token: 0x06004DA3 RID: 19875 RVA: 0x0001D628 File Offset: 0x0001B828
			public unsafe int End
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_End);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_End)) = value;
				}
			}

			// Token: 0x170013C4 RID: 5060
			// (get) Token: 0x06004DA4 RID: 19876 RVA: 0x0015E5CC File Offset: 0x0015C7CC
			// (set) Token: 0x06004DA5 RID: 19877 RVA: 0x0001D643 File Offset: 0x0001B843
			public unsafe int Optional
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Optional);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Optional)) = value;
				}
			}

			// Token: 0x04003EB5 RID: 16053
			private static readonly IntPtr NativeFieldInfoPtr_Source;

			// Token: 0x04003EB6 RID: 16054
			private static readonly IntPtr NativeFieldInfoPtr_Index;

			// Token: 0x04003EB7 RID: 16055
			private static readonly IntPtr NativeFieldInfoPtr_Start;

			// Token: 0x04003EB8 RID: 16056
			private static readonly IntPtr NativeFieldInfoPtr_End;

			// Token: 0x04003EB9 RID: 16057
			private static readonly IntPtr NativeFieldInfoPtr_Optional;
		}

		// Token: 0x0200053E RID: 1342
		public enum ExtenderType
		{
			// Token: 0x04003EBB RID: 16059
			None,
			// Token: 0x04003EBC RID: 16060
			Simple,
			// Token: 0x04003EBD RID: 16061
			Voiced,
			// Token: 0x04003EBE RID: 16062
			Conditional,
			// Token: 0x04003EBF RID: 16063
			Buggy
		}
	}
}
