using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x020000A9 RID: 169
	public static class DateTimeFormat : Object
	{
		// Token: 0x06000BD0 RID: 3024 RVA: 0x00057344 File Offset: 0x00055544
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeFormat()
		{
			Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeFormat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr);
			DateTimeFormat.NativeFieldInfoPtr_NullOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, "NullOffset");
			DateTimeFormat.NativeFieldInfoPtr_allStandardFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, "allStandardFormats");
			DateTimeFormat.NativeFieldInfoPtr_fixedNumberFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, "fixedNumberFormats");
			DateTimeFormat.NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665281);
			DateTimeFormat.NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665282);
			DateTimeFormat.NativeMethodInfoPtr_HebrewFormatDigits_Private_Static_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665283);
			DateTimeFormat.NativeMethodInfoPtr_ParseRepeatPattern_Internal_Static_Int32_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665284);
			DateTimeFormat.NativeMethodInfoPtr_FormatDayOfWeek_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665285);
			DateTimeFormat.NativeMethodInfoPtr_FormatMonth_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665286);
			DateTimeFormat.NativeMethodInfoPtr_FormatHebrewMonthName_Private_Static_String_DateTime_Int32_Int32_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665287);
			DateTimeFormat.NativeMethodInfoPtr_ParseQuoteString_Internal_Static_Int32_String_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665288);
			DateTimeFormat.NativeMethodInfoPtr_ParseNextChar_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665289);
			DateTimeFormat.NativeMethodInfoPtr_IsUseGenitiveForm_Private_Static_Boolean_String_Int32_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665290);
			DateTimeFormat.NativeMethodInfoPtr_FormatCustomized_Private_Static_String_DateTime_String_DateTimeFormatInfo_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665291);
			DateTimeFormat.NativeMethodInfoPtr_FormatCustomizedTimeZone_Private_Static_Void_DateTime_TimeSpan_String_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665292);
			DateTimeFormat.NativeMethodInfoPtr_FormatCustomizedRoundripTimeZone_Private_Static_Void_DateTime_TimeSpan_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665293);
			DateTimeFormat.NativeMethodInfoPtr_GetRealFormat_Internal_Static_String_String_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665294);
			DateTimeFormat.NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_String_byref_DateTime_byref_DateTimeFormatInfo_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665295);
			DateTimeFormat.NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665296);
			DateTimeFormat.NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_DateTimeFormatInfo_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665297);
			DateTimeFormat.NativeMethodInfoPtr_InvalidFormatForLocal_Internal_Static_Void_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665298);
			DateTimeFormat.NativeMethodInfoPtr_InvalidFormatForUtc_Internal_Static_Void_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665299);
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0005752C File Offset: 0x0005572C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 283764, RefRangeEnd = 283773, XrefRangeStart = 283760, XrefRangeEnd = 283764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatDigits(StringBuilder outputBuffer, int value, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00057580 File Offset: 0x00055780
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283774, RefRangeEnd = 283776, XrefRangeStart = 283773, XrefRangeEnd = 283774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideLengthLimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x000575E0 File Offset: 0x000557E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 283782, RefRangeEnd = 283785, XrefRangeStart = 283776, XrefRangeEnd = 283782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HebrewFormatDigits(StringBuilder outputBuffer, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_HebrewFormatDigits_Private_Static_Void_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00057624 File Offset: 0x00055824
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 283786, RefRangeEnd = 283792, XrefRangeStart = 283785, XrefRangeEnd = 283786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseRepeatPattern(string format, int pos, char patternChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref patternChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_ParseRepeatPattern_Internal_Static_Int32_String_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00057684 File Offset: 0x00055884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283792, XrefRangeEnd = 283795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dayOfWeek;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatDayOfWeek_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000576DC File Offset: 0x000558DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283795, XrefRangeEnd = 283798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref month;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeatCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatMonth_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00057734 File Offset: 0x00055934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283799, RefRangeEnd = 283800, XrefRangeStart = 283798, XrefRangeEnd = 283799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeatCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatHebrewMonthName_Private_Static_String_DateTime_Int32_Int32_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0005779C File Offset: 0x0005599C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283805, RefRangeEnd = 283807, XrefRangeStart = 283800, XrefRangeEnd = 283805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseQuoteString(string format, int pos, StringBuilder result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_ParseQuoteString_Internal_Static_Int32_String_Int32_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00057800 File Offset: 0x00055A00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283808, RefRangeEnd = 283810, XrefRangeStart = 283807, XrefRangeEnd = 283808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseNextChar(string format, int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_ParseNextChar_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00057850 File Offset: 0x00055A50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283817, RefRangeEnd = 283818, XrefRangeStart = 283810, XrefRangeEnd = 283817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUseGenitiveForm(string format, int index, int tokenLen, char patternToMatch)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref patternToMatch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_IsUseGenitiveForm_Private_Static_Boolean_String_Int32_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x000578BC File Offset: 0x00055ABC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283995, RefRangeEnd = 283997, XrefRangeStart = 283818, XrefRangeEnd = 283995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatCustomized(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatCustomized_Private_Static_String_DateTime_String_DateTimeFormatInfo_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00057928 File Offset: 0x00055B28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284049, RefRangeEnd = 284050, XrefRangeStart = 283997, XrefRangeEnd = 284049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, string format, int tokenLen, bool timeOnly, StringBuilder result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenLen;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOnly;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatCustomizedTimeZone_Private_Static_Void_DateTime_TimeSpan_String_Int32_Boolean_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000579AC File Offset: 0x00055BAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284064, RefRangeEnd = 284065, XrefRangeStart = 284050, XrefRangeEnd = 284064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatCustomizedRoundripTimeZone_Private_Static_Void_DateTime_TimeSpan_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00057A00 File Offset: 0x00055C00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284070, RefRangeEnd = 284072, XrefRangeStart = 284065, XrefRangeEnd = 284070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetRealFormat(string format, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_GetRealFormat_Internal_Static_String_String_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00057A50 File Offset: 0x00055C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284129, RefRangeEnd = 284130, XrefRangeStart = 284072, XrefRangeEnd = 284129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExpandPredefinedFormat(string format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dateTime;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_String_byref_DateTime_byref_DateTimeFormatInfo_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			dtfi = ((intPtr4 == 0) ? null : new DateTimeFormatInfo(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00057AD4 File Offset: 0x00055CD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 284135, RefRangeEnd = 284139, XrefRangeStart = 284130, XrefRangeEnd = 284135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00057B30 File Offset: 0x00055D30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 284167, RefRangeEnd = 284170, XrefRangeStart = 284139, XrefRangeEnd = 284167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_DateTimeFormatInfo_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00057B9C File Offset: 0x00055D9C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvalidFormatForLocal(string format, DateTime dateTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_InvalidFormatForLocal_Internal_Static_Void_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00057BE0 File Offset: 0x00055DE0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvalidFormatForUtc(string format, DateTime dateTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_InvalidFormatForUtc_Internal_Static_Void_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00005113 File Offset: 0x00003313
		public DateTimeFormat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x00057C24 File Offset: 0x00055E24
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x0000511C File Offset: 0x0000331C
		public unsafe static TimeSpan NullOffset
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormat.NativeFieldInfoPtr_NullOffset, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormat.NativeFieldInfoPtr_NullOffset, (void*)(&value));
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x00057C40 File Offset: 0x00055E40
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x0000512A File Offset: 0x0000332A
		public unsafe static Il2CppStructArray<char> allStandardFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormat.NativeFieldInfoPtr_allStandardFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormat.NativeFieldInfoPtr_allStandardFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00057C68 File Offset: 0x00055E68
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x0000513C File Offset: 0x0000333C
		public unsafe static Il2CppStringArray fixedNumberFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormat.NativeFieldInfoPtr_fixedNumberFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormat.NativeFieldInfoPtr_fixedNumberFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeFieldInfoPtr_NullOffset;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeFieldInfoPtr_allStandardFormats;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeFieldInfoPtr_fixedNumberFormats;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_Boolean_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_HebrewFormatDigits_Private_Static_Void_StringBuilder_Int32_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_ParseRepeatPattern_Internal_Static_Int32_String_Int32_Char_0;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr_FormatDayOfWeek_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr_FormatMonth_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr_FormatHebrewMonthName_Private_Static_String_DateTime_Int32_Int32_DateTimeFormatInfo_0;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_ParseQuoteString_Internal_Static_Int32_String_Int32_StringBuilder_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_ParseNextChar_Internal_Static_Int32_String_Int32_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_IsUseGenitiveForm_Private_Static_Boolean_String_Int32_Int32_Char_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_FormatCustomized_Private_Static_String_DateTime_String_DateTimeFormatInfo_TimeSpan_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_FormatCustomizedTimeZone_Private_Static_Void_DateTime_TimeSpan_String_Int32_Boolean_StringBuilder_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_FormatCustomizedRoundripTimeZone_Private_Static_Void_DateTime_TimeSpan_StringBuilder_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_GetRealFormat_Internal_Static_String_String_DateTimeFormatInfo_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_String_byref_DateTime_byref_DateTimeFormatInfo_byref_TimeSpan_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_DateTimeFormatInfo_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_DateTimeFormatInfo_TimeSpan_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_InvalidFormatForLocal_Internal_Static_Void_String_DateTime_0;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_InvalidFormatForUtc_Internal_Static_Void_String_DateTime_0;
	}
}
