using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000233 RID: 563
	public class DateTimeFormatInfoScanner : Object
	{
		// Token: 0x060025D9 RID: 9689 RVA: 0x000C9828 File Offset: 0x000C7A28
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeFormatInfoScanner()
		{
			Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "DateTimeFormatInfoScanner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr);
			DateTimeFormatInfoScanner.NativeFieldInfoPtr_m_dateWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, "m_dateWords");
			DateTimeFormatInfoScanner.NativeFieldInfoPtr_s_knownWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, "s_knownWords");
			DateTimeFormatInfoScanner.NativeFieldInfoPtr_m_ymdFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, "m_ymdFlags");
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_get_KnownWords_Private_Static_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669460);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_SkipWhiteSpacesAndNonLetter_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669461);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddDateWordOrPostfix_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669462);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddDateWords_Internal_Int32_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669463);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_ScanRepeatChar_Internal_Static_Int32_String_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669464);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddIgnorableSymbols_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669465);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_ScanDateWord_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669466);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetDateWordsOfDTFI_Internal_Il2CppStringArray_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669467);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagGenitiveMonth_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669468);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseSpaceInMonthNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669469);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseSpaceInDayNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669470);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseHebrewCalendar_Internal_Static_FORMATFLAGS_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669471);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_EqualStringArrays_Private_Static_Boolean_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669472);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_ArrayElementsHaveSpace_Private_Static_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669473);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_ArrayElementsBeginWithDigit_Private_Static_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669474);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100669475);
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x000C99D4 File Offset: 0x000C7BD4
		public unsafe static Dictionary<string, string> KnownWords
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 326240, RefRangeEnd = 326241, XrefRangeStart = 326145, XrefRangeEnd = 326240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_get_KnownWords_Private_Static_get_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x000C9A08 File Offset: 0x000C7C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326241, XrefRangeEnd = 326248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_SkipWhiteSpacesAndNonLetter_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x000C9A58 File Offset: 0x000C7C58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 326277, RefRangeEnd = 326279, XrefRangeStart = 326248, XrefRangeEnd = 326277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDateWordOrPostfix(string formatPostfix, string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(formatPostfix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddDateWordOrPostfix_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x000C9AAC File Offset: 0x000C7CAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 326304, RefRangeEnd = 326306, XrefRangeStart = 326279, XrefRangeEnd = 326304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddDateWords(string pattern, int index, string formatPostfix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(formatPostfix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddDateWords_Internal_Int32_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x000C9B1C File Offset: 0x000C7D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326306, XrefRangeEnd = 326308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ScanRepeatChar(string pattern, char ch, int index, out int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_ScanRepeatChar_Internal_Static_Int32_String_Char_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x000C9B88 File Offset: 0x000C7D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326323, RefRangeEnd = 326324, XrefRangeStart = 326308, XrefRangeEnd = 326323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddIgnorableSymbols(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddIgnorableSymbols_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x000C9BCC File Offset: 0x000C7DCC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 326349, RefRangeEnd = 326355, XrefRangeStart = 326324, XrefRangeEnd = 326349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanDateWord(string pattern)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_ScanDateWord_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x000C9C10 File Offset: 0x000C7E10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326380, RefRangeEnd = 326381, XrefRangeStart = 326355, XrefRangeEnd = 326380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetDateWordsOfDTFI(DateTimeFormatInfo dtfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetDateWordsOfDTFI_Internal_Il2CppStringArray_DateTimeFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x000C9C60 File Offset: 0x000C7E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326381, XrefRangeEnd = 326386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FORMATFLAGS GetFormatFlagGenitiveMonth(Il2CppStringArray monthNames, Il2CppStringArray genitveMonthNames, Il2CppStringArray abbrevMonthNames, Il2CppStringArray genetiveAbbrevMonthNames)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(monthNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genitveMonthNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abbrevMonthNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genetiveAbbrevMonthNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagGenitiveMonth_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x000C9CD8 File Offset: 0x000C7ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326386, XrefRangeEnd = 326394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(Il2CppStringArray monthNames, Il2CppStringArray genitveMonthNames, Il2CppStringArray abbrevMonthNames, Il2CppStringArray genetiveAbbrevMonthNames)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(monthNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genitveMonthNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abbrevMonthNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genetiveAbbrevMonthNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseSpaceInMonthNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x000C9D50 File Offset: 0x000C7F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326394, XrefRangeEnd = 326396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(Il2CppStringArray dayNames, Il2CppStringArray abbrevDayNames)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dayNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abbrevDayNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseSpaceInDayNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x000C9DA4 File Offset: 0x000C7FA4
		[CallerCount(0)]
		public unsafe static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseHebrewCalendar_Internal_Static_FORMATFLAGS_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x000C9DE4 File Offset: 0x000C7FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326396, XrefRangeEnd = 326398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EqualStringArrays(Il2CppStringArray array1, Il2CppStringArray array2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_EqualStringArrays_Private_Static_Boolean_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x000C9E38 File Offset: 0x000C8038
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 326405, RefRangeEnd = 326417, XrefRangeStart = 326398, XrefRangeEnd = 326405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ArrayElementsHaveSpace(Il2CppStringArray array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_ArrayElementsHaveSpace_Private_Static_Boolean_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x000C9E7C File Offset: 0x000C807C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 326428, RefRangeEnd = 326436, XrefRangeStart = 326417, XrefRangeEnd = 326428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ArrayElementsBeginWithDigit(Il2CppStringArray array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_ArrayElementsBeginWithDigit_Private_Static_Boolean_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x000C9EC0 File Offset: 0x000C80C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326436, XrefRangeEnd = 326443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeFormatInfoScanner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x0000CFF3 File Offset: 0x0000B1F3
		public DateTimeFormatInfoScanner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x060025EB RID: 9707 RVA: 0x000C9EFC File Offset: 0x000C80FC
		// (set) Token: 0x060025EC RID: 9708 RVA: 0x0000CFFC File Offset: 0x0000B1FC
		public unsafe List<string> m_dateWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfoScanner.NativeFieldInfoPtr_m_dateWords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfoScanner.NativeFieldInfoPtr_m_dateWords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x000C9F2C File Offset: 0x000C812C
		// (set) Token: 0x060025EE RID: 9710 RVA: 0x0000D01B File Offset: 0x0000B21B
		public unsafe static Dictionary<string, string> s_knownWords
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfoScanner.NativeFieldInfoPtr_s_knownWords, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfoScanner.NativeFieldInfoPtr_s_knownWords, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x060025EF RID: 9711 RVA: 0x000C9F54 File Offset: 0x000C8154
		// (set) Token: 0x060025F0 RID: 9712 RVA: 0x0000D02D File Offset: 0x0000B22D
		public unsafe DateTimeFormatInfoScanner.FoundDatePattern m_ymdFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfoScanner.NativeFieldInfoPtr_m_ymdFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfoScanner.NativeFieldInfoPtr_m_ymdFlags)) = value;
			}
		}

		// Token: 0x040021B4 RID: 8628
		private static readonly IntPtr NativeFieldInfoPtr_m_dateWords;

		// Token: 0x040021B5 RID: 8629
		private static readonly IntPtr NativeFieldInfoPtr_s_knownWords;

		// Token: 0x040021B6 RID: 8630
		private static readonly IntPtr NativeFieldInfoPtr_m_ymdFlags;

		// Token: 0x040021B7 RID: 8631
		private static readonly IntPtr NativeMethodInfoPtr_get_KnownWords_Private_Static_get_Dictionary_2_String_String_0;

		// Token: 0x040021B8 RID: 8632
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhiteSpacesAndNonLetter_Internal_Static_Int32_String_Int32_0;

		// Token: 0x040021B9 RID: 8633
		private static readonly IntPtr NativeMethodInfoPtr_AddDateWordOrPostfix_Internal_Void_String_String_0;

		// Token: 0x040021BA RID: 8634
		private static readonly IntPtr NativeMethodInfoPtr_AddDateWords_Internal_Int32_String_Int32_String_0;

		// Token: 0x040021BB RID: 8635
		private static readonly IntPtr NativeMethodInfoPtr_ScanRepeatChar_Internal_Static_Int32_String_Char_Int32_byref_Int32_0;

		// Token: 0x040021BC RID: 8636
		private static readonly IntPtr NativeMethodInfoPtr_AddIgnorableSymbols_Internal_Void_String_0;

		// Token: 0x040021BD RID: 8637
		private static readonly IntPtr NativeMethodInfoPtr_ScanDateWord_Internal_Void_String_0;

		// Token: 0x040021BE RID: 8638
		private static readonly IntPtr NativeMethodInfoPtr_GetDateWordsOfDTFI_Internal_Il2CppStringArray_DateTimeFormatInfo_0;

		// Token: 0x040021BF RID: 8639
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatFlagGenitiveMonth_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x040021C0 RID: 8640
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatFlagUseSpaceInMonthNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x040021C1 RID: 8641
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatFlagUseSpaceInDayNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x040021C2 RID: 8642
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatFlagUseHebrewCalendar_Internal_Static_FORMATFLAGS_Int32_0;

		// Token: 0x040021C3 RID: 8643
		private static readonly IntPtr NativeMethodInfoPtr_EqualStringArrays_Private_Static_Boolean_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x040021C4 RID: 8644
		private static readonly IntPtr NativeMethodInfoPtr_ArrayElementsHaveSpace_Private_Static_Boolean_Il2CppStringArray_0;

		// Token: 0x040021C5 RID: 8645
		private static readonly IntPtr NativeMethodInfoPtr_ArrayElementsBeginWithDigit_Private_Static_Boolean_Il2CppStringArray_0;

		// Token: 0x040021C6 RID: 8646
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005DD RID: 1501
		public enum FoundDatePattern
		{
			// Token: 0x0400425F RID: 16991
			None,
			// Token: 0x04004260 RID: 16992
			FoundYearPatternFlag,
			// Token: 0x04004261 RID: 16993
			FoundMonthPatternFlag,
			// Token: 0x04004262 RID: 16994
			FoundDayPatternFlag = 4,
			// Token: 0x04004263 RID: 16995
			FoundYMDPatternFlag = 7
		}
	}
}
