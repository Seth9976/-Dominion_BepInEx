using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x020000AA RID: 170
	public static class DateTimeParse : Object
	{
		// Token: 0x06000BEB RID: 3051 RVA: 0x00057C90 File Offset: 0x00055E90
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeParse()
		{
			Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeParse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr);
			DateTimeParse.NativeFieldInfoPtr_m_hebrewNumberParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, "m_hebrewNumberParser");
			DateTimeParse.NativeFieldInfoPtr_dateParsingStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, "dateParsingStates");
			DateTimeParse.NativeMethodInfoPtr_ParseExact_Internal_Static_DateTime_String_String_DateTimeFormatInfo_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665301);
			DateTimeParse.NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_String_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665302);
			DateTimeParse.NativeMethodInfoPtr_TryParseExactMultiple_Internal_Static_Boolean_String_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665303);
			DateTimeParse.NativeMethodInfoPtr_TryParseExactMultiple_Internal_Static_Boolean_String_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665304);
			DateTimeParse.NativeMethodInfoPtr_MatchWord_Private_Static_Boolean_byref___DTString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665305);
			DateTimeParse.NativeMethodInfoPtr_GetTimeZoneName_Private_Static_Boolean_byref___DTString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665306);
			DateTimeParse.NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665307);
			DateTimeParse.NativeMethodInfoPtr_ParseFraction_Private_Static_Boolean_byref___DTString_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665308);
			DateTimeParse.NativeMethodInfoPtr_ParseTimeZone_Private_Static_Boolean_byref___DTString_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665309);
			DateTimeParse.NativeMethodInfoPtr_HandleTimeZone_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665310);
			DateTimeParse.NativeMethodInfoPtr_Lex_Private_Static_Boolean_DS_byref___DTString_byref_DateTimeToken_byref_DateTimeRawInfo_byref_DateTimeResult_byref_DateTimeFormatInfo_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665311);
			DateTimeParse.NativeMethodInfoPtr_VerifyValidPunctuation_Private_Static_Boolean_byref___DTString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665312);
			DateTimeParse.NativeMethodInfoPtr_GetYearMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665313);
			DateTimeParse.NativeMethodInfoPtr_GetYearMonthOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665314);
			DateTimeParse.NativeMethodInfoPtr_GetMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665315);
			DateTimeParse.NativeMethodInfoPtr_TryAdjustYear_Private_Static_Boolean_byref_DateTimeResult_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665316);
			DateTimeParse.NativeMethodInfoPtr_SetDateYMD_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665317);
			DateTimeParse.NativeMethodInfoPtr_SetDateMDY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665318);
			DateTimeParse.NativeMethodInfoPtr_SetDateDMY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665319);
			DateTimeParse.NativeMethodInfoPtr_SetDateYDM_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665320);
			DateTimeParse.NativeMethodInfoPtr_GetDefaultYear_Private_Static_Void_byref_DateTimeResult_byref_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665321);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665322);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665323);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665324);
			DateTimeParse.NativeMethodInfoPtr_GetHebrewDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665325);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665326);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfMNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665327);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfYNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665328);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfNNY_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665329);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfYMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665330);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfYN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665331);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfYM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665332);
			DateTimeParse.NativeMethodInfoPtr_AdjustTimeMark_Private_Static_Void_DateTimeFormatInfo_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665333);
			DateTimeParse.NativeMethodInfoPtr_AdjustHour_Private_Static_Boolean_byref_Int32_TM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665334);
			DateTimeParse.NativeMethodInfoPtr_GetTimeOfN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665335);
			DateTimeParse.NativeMethodInfoPtr_GetTimeOfNN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665336);
			DateTimeParse.NativeMethodInfoPtr_GetTimeOfNNN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665337);
			DateTimeParse.NativeMethodInfoPtr_GetDateOfDSN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665338);
			DateTimeParse.NativeMethodInfoPtr_GetDateOfNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665339);
			DateTimeParse.NativeMethodInfoPtr_GetDateOfNNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665340);
			DateTimeParse.NativeMethodInfoPtr_ProcessDateTimeSuffix_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_byref_DateTimeToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665341);
			DateTimeParse.NativeMethodInfoPtr_ProcessHebrewTerminalState_Internal_Static_Boolean_DS_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665342);
			DateTimeParse.NativeMethodInfoPtr_ProcessTerminaltState_Internal_Static_Boolean_DS_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665343);
			DateTimeParse.NativeMethodInfoPtr_Parse_Internal_Static_DateTime_String_DateTimeFormatInfo_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665344);
			DateTimeParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665345);
			DateTimeParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665346);
			DateTimeParse.NativeMethodInfoPtr_DetermineTimeZoneAdjustments_Private_Static_Boolean_byref_DateTimeResult_DateTimeStyles_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665347);
			DateTimeParse.NativeMethodInfoPtr_DateTimeOffsetTimeZonePostProcessing_Private_Static_Boolean_byref_DateTimeResult_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665348);
			DateTimeParse.NativeMethodInfoPtr_AdjustTimeZoneToUniversal_Private_Static_Boolean_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665349);
			DateTimeParse.NativeMethodInfoPtr_AdjustTimeZoneToLocal_Private_Static_Boolean_byref_DateTimeResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665350);
			DateTimeParse.NativeMethodInfoPtr_ParseISO8601_Private_Static_Boolean_byref_DateTimeRawInfo_byref___DTString_DateTimeStyles_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665351);
			DateTimeParse.NativeMethodInfoPtr_MatchHebrewDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665352);
			DateTimeParse.NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665353);
			DateTimeParse.NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665354);
			DateTimeParse.NativeMethodInfoPtr_ParseFractionExact_Private_Static_Boolean_byref___DTString_Int32_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665355);
			DateTimeParse.NativeMethodInfoPtr_ParseSign_Private_Static_Boolean_byref___DTString_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665356);
			DateTimeParse.NativeMethodInfoPtr_ParseTimeZoneOffset_Private_Static_Boolean_byref___DTString_Int32_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665357);
			DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665358);
			DateTimeParse.NativeMethodInfoPtr_MatchMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665359);
			DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665360);
			DateTimeParse.NativeMethodInfoPtr_MatchDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665361);
			DateTimeParse.NativeMethodInfoPtr_MatchEraName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665362);
			DateTimeParse.NativeMethodInfoPtr_MatchTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665363);
			DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665364);
			DateTimeParse.NativeMethodInfoPtr_CheckNewValue_Private_Static_Boolean_byref_Int32_Int32_Char_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665365);
			DateTimeParse.NativeMethodInfoPtr_GetDateTimeNow_Private_Static_DateTime_byref_DateTimeResult_byref_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665366);
			DateTimeParse.NativeMethodInfoPtr_CheckDefaultDateTime_Private_Static_Boolean_byref_DateTimeResult_byref_Calendar_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665367);
			DateTimeParse.NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_String_byref_DateTimeFormatInfo_byref_ParsingInfo_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665368);
			DateTimeParse.NativeMethodInfoPtr_ParseByFormat_Private_Static_Boolean_byref___DTString_byref___DTString_byref_ParsingInfo_DateTimeFormatInfo_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665369);
			DateTimeParse.NativeMethodInfoPtr_TryParseQuoteString_Internal_Static_Boolean_String_Int32_StringBuilder_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665370);
			DateTimeParse.NativeMethodInfoPtr_DoStrictParse_Private_Static_Boolean_String_String_DateTimeStyles_DateTimeFormatInfo_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665371);
			DateTimeParse.NativeMethodInfoPtr_GetDateTimeParseException_Private_Static_Exception_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665372);
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00058288 File Offset: 0x00056488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284185, RefRangeEnd = 284187, XrefRangeStart = 284171, XrefRangeEnd = 284185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseExact_Internal_Static_DateTime_String_String_DateTimeFormatInfo_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x000582FC File Offset: 0x000564FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284208, RefRangeEnd = 284209, XrefRangeStart = 284187, XrefRangeEnd = 284208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_String_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00058384 File Offset: 0x00056584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284209, XrefRangeEnd = 284219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseExactMultiple(string s, Il2CppStringArray formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formats);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParseExactMultiple_Internal_Static_Boolean_String_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00058408 File Offset: 0x00056608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284233, RefRangeEnd = 284235, XrefRangeStart = 284219, XrefRangeEnd = 284233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseExactMultiple(string s, Il2CppStringArray formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formats);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParseExactMultiple_Internal_Static_Boolean_String_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00058490 File Offset: 0x00056690
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284241, RefRangeEnd = 284243, XrefRangeStart = 284235, XrefRangeEnd = 284241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchWord(ref __DTString str, string target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchWord_Private_Static_Boolean_byref___DTString_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x000584E4 File Offset: 0x000566E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284243, XrefRangeEnd = 284254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeZoneName(ref __DTString str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetTimeZoneName_Private_Static_Boolean_byref___DTString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00058528 File Offset: 0x00056728
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 284254, RefRangeEnd = 284257, XrefRangeStart = 284254, XrefRangeEnd = 284254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDigit(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00058568 File Offset: 0x00056768
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284262, RefRangeEnd = 284264, XrefRangeStart = 284257, XrefRangeEnd = 284262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseFraction(ref __DTString str, out double result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseFraction_Private_Static_Boolean_byref___DTString_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x000585B8 File Offset: 0x000567B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 284278, RefRangeEnd = 284281, XrefRangeStart = 284264, XrefRangeEnd = 284278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseTimeZone(ref __DTString str, ref TimeSpan result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseTimeZone_Private_Static_Boolean_byref___DTString_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00058608 File Offset: 0x00056808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284296, RefRangeEnd = 284298, XrefRangeStart = 284281, XrefRangeEnd = 284296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_HandleTimeZone_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00058660 File Offset: 0x00056860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284440, RefRangeEnd = 284441, XrefRangeStart = 284298, XrefRangeEnd = 284440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Lex(DateTimeParse.DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dtok;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_Lex_Private_Static_Boolean_DS_byref___DTString_byref_DateTimeToken_byref_DateTimeRawInfo_byref_DateTimeResult_byref_DateTimeFormatInfo_DateTimeStyles_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			dtfi = ((intPtr4 == 0) ? null : new DateTimeFormatInfo(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0005871C File Offset: 0x0005691C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 284444, RefRangeEnd = 284447, XrefRangeStart = 284441, XrefRangeEnd = 284444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool VerifyValidPunctuation(ref __DTString str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_VerifyValidPunctuation_Private_Static_Boolean_byref___DTString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00058760 File Offset: 0x00056960
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 284456, RefRangeEnd = 284461, XrefRangeStart = 284447, XrefRangeEnd = 284456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(datePattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetYearMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x000587C4 File Offset: 0x000569C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284467, RefRangeEnd = 284469, XrefRangeStart = 284461, XrefRangeEnd = 284467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetYearMonthOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00058828 File Offset: 0x00056A28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 284476, RefRangeEnd = 284480, XrefRangeStart = 284469, XrefRangeEnd = 284476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0005888C File Offset: 0x00056A8C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 284481, RefRangeEnd = 284496, XrefRangeStart = 284480, XrefRangeEnd = 284481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &adjustedYear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryAdjustYear_Private_Static_Boolean_byref_DateTimeResult_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x000588EC File Offset: 0x00056AEC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 284496, RefRangeEnd = 284510, XrefRangeStart = 284496, XrefRangeEnd = 284496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_SetDateYMD_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00058958 File Offset: 0x00056B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284510, XrefRangeEnd = 284514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_SetDateMDY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x000589C4 File Offset: 0x00056BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284514, XrefRangeEnd = 284518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_SetDateDMY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00058A30 File Offset: 0x00056C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284518, XrefRangeEnd = 284522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_SetDateYDM_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00058A9C File Offset: 0x00056C9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284526, RefRangeEnd = 284528, XrefRangeStart = 284522, XrefRangeEnd = 284526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDefaultYear_Private_Static_Void_byref_DateTimeResult_byref_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00058AE4 File Offset: 0x00056CE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284546, RefRangeEnd = 284548, XrefRangeStart = 284528, XrefRangeEnd = 284546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00058B54 File Offset: 0x00056D54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284597, RefRangeEnd = 284598, XrefRangeStart = 284548, XrefRangeEnd = 284597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00058BB8 File Offset: 0x00056DB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284619, RefRangeEnd = 284620, XrefRangeStart = 284598, XrefRangeEnd = 284619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00058C28 File Offset: 0x00056E28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284630, RefRangeEnd = 284631, XrefRangeStart = 284620, XrefRangeEnd = 284630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetHebrewDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00058C8C File Offset: 0x00056E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284652, RefRangeEnd = 284653, XrefRangeStart = 284631, XrefRangeEnd = 284652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00058CFC File Offset: 0x00056EFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284684, RefRangeEnd = 284686, XrefRangeStart = 284653, XrefRangeEnd = 284684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfMNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00058D60 File Offset: 0x00056F60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284700, RefRangeEnd = 284701, XrefRangeStart = 284686, XrefRangeEnd = 284700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfYNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00058DC4 File Offset: 0x00056FC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284718, RefRangeEnd = 284719, XrefRangeStart = 284701, XrefRangeEnd = 284718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfNNY_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00058E28 File Offset: 0x00057028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284725, RefRangeEnd = 284727, XrefRangeStart = 284719, XrefRangeEnd = 284725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfYMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00058E8C File Offset: 0x0005708C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284727, XrefRangeEnd = 284733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfYN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00058EF0 File Offset: 0x000570F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284738, RefRangeEnd = 284740, XrefRangeStart = 284733, XrefRangeEnd = 284738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfYM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00058F54 File Offset: 0x00057154
		[CallerCount(0)]
		public unsafe static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_AdjustTimeMark_Private_Static_Void_DateTimeFormatInfo_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00058F98 File Offset: 0x00057198
		[CallerCount(0)]
		public unsafe static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &hour;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_AdjustHour_Private_Static_Boolean_byref_Int32_TM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00058FE4 File Offset: 0x000571E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284742, RefRangeEnd = 284744, XrefRangeStart = 284740, XrefRangeEnd = 284742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeOfN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetTimeOfN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00059048 File Offset: 0x00057248
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284747, RefRangeEnd = 284749, XrefRangeStart = 284744, XrefRangeEnd = 284747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeOfNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetTimeOfNN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x000590AC File Offset: 0x000572AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284753, RefRangeEnd = 284755, XrefRangeStart = 284749, XrefRangeEnd = 284753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeOfNNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetTimeOfNNN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00059110 File Offset: 0x00057310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284755, XrefRangeEnd = 284757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDateOfDSN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00059160 File Offset: 0x00057360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284757, XrefRangeEnd = 284763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDateOfNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x000591B0 File Offset: 0x000573B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284797, RefRangeEnd = 284798, XrefRangeStart = 284763, XrefRangeEnd = 284797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDateOfNNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00059214 File Offset: 0x00057414
		[CallerCount(0)]
		public unsafe static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dtok;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ProcessDateTimeSuffix_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_byref_DateTimeToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00059274 File Offset: 0x00057474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284841, RefRangeEnd = 284842, XrefRangeStart = 284798, XrefRangeEnd = 284841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ProcessHebrewTerminalState_Internal_Static_Boolean_DS_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000592F4 File Offset: 0x000574F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284920, RefRangeEnd = 284921, XrefRangeStart = 284842, XrefRangeEnd = 284920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProcessTerminaltState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ProcessTerminaltState_Internal_Static_Boolean_DS_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00059374 File Offset: 0x00057574
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284926, RefRangeEnd = 284928, XrefRangeStart = 284921, XrefRangeEnd = 284926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_Parse_Internal_Static_DateTime_String_DateTimeFormatInfo_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x000593D8 File Offset: 0x000575D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284928, XrefRangeEnd = 284938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00059448 File Offset: 0x00057648
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285011, RefRangeEnd = 285014, XrefRangeStart = 284938, XrefRangeEnd = 285011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x000594BC File Offset: 0x000576BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285028, RefRangeEnd = 285030, XrefRangeStart = 285014, XrefRangeEnd = 285028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DetermineTimeZoneAdjustments(ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bTimeOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_DetermineTimeZoneAdjustments_Private_Static_Boolean_byref_DateTimeResult_DateTimeStyles_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0005951C File Offset: 0x0005771C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285030, XrefRangeEnd = 285045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DateTimeOffsetTimeZonePostProcessing(ref DateTimeResult result, DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_DateTimeOffsetTimeZonePostProcessing_Private_Static_Boolean_byref_DateTimeResult_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0005956C File Offset: 0x0005776C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285047, RefRangeEnd = 285048, XrefRangeStart = 285045, XrefRangeEnd = 285047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AdjustTimeZoneToUniversal(ref DateTimeResult result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_AdjustTimeZoneToUniversal_Private_Static_Boolean_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000595B0 File Offset: 0x000577B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285048, XrefRangeEnd = 285062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bTimeOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_AdjustTimeZoneToLocal_Private_Static_Boolean_byref_DateTimeResult_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00059600 File Offset: 0x00057800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285148, RefRangeEnd = 285149, XrefRangeStart = 285062, XrefRangeEnd = 285148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &raw;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseISO8601_Private_Static_Boolean_byref_DateTimeRawInfo_byref___DTString_DateTimeStyles_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00059674 File Offset: 0x00057874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285149, XrefRangeEnd = 285156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchHebrewDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x000596D4 File Offset: 0x000578D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285168, RefRangeEnd = 285169, XrefRangeStart = 285156, XrefRangeEnd = 285168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseDigits(ref __DTString str, int digitLen, out int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00059734 File Offset: 0x00057934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285169, XrefRangeEnd = 285172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDigitLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDigitLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x000597A0 File Offset: 0x000579A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285172, XrefRangeEnd = 285181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDigitLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseFractionExact_Private_Static_Boolean_byref___DTString_Int32_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00059800 File Offset: 0x00057A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285181, XrefRangeEnd = 285183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseSign(ref __DTString str, ref bool result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseSign_Private_Static_Boolean_byref___DTString_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00059850 File Offset: 0x00057A50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285210, RefRangeEnd = 285211, XrefRangeStart = 285183, XrefRangeEnd = 285210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseTimeZoneOffset_Private_Static_Boolean_byref___DTString_Int32_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x000598B0 File Offset: 0x00057AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285211, XrefRangeEnd = 285222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00059914 File Offset: 0x00057B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285222, XrefRangeEnd = 285240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00059978 File Offset: 0x00057B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285240, XrefRangeEnd = 285247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x000599DC File Offset: 0x00057BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285247, XrefRangeEnd = 285254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00059A40 File Offset: 0x00057C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285254, XrefRangeEnd = 285262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchEraName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00059AA4 File Offset: 0x00057CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285262, XrefRangeEnd = 285264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00059B08 File Offset: 0x00057D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285264, XrefRangeEnd = 285271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00059B6C File Offset: 0x00057D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285271, XrefRangeEnd = 285278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &currentValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref patternChar;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_CheckNewValue_Private_Static_Boolean_byref_Int32_Int32_Char_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00059BD8 File Offset: 0x00057DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285286, RefRangeEnd = 285287, XrefRangeStart = 285278, XrefRangeEnd = 285286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDateTimeNow_Private_Static_DateTime_byref_DateTimeResult_byref_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00059C28 File Offset: 0x00057E28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285292, RefRangeEnd = 285293, XrefRangeStart = 285287, XrefRangeEnd = 285292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cal);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_CheckDefaultDateTime_Private_Static_Boolean_byref_DateTimeResult_byref_Calendar_DateTimeStyles_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			cal = ((intPtr4 == 0) ? null : new Calendar(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00059CA4 File Offset: 0x00057EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285293, XrefRangeEnd = 285350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExpandPredefinedFormat(string format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_String_byref_DateTimeFormatInfo_byref_ParsingInfo_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			dtfi = ((intPtr4 == 0) ? null : new DateTimeFormatInfo(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00059D30 File Offset: 0x00057F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285350, XrefRangeEnd = 285411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseByFormat_Private_Static_Boolean_byref___DTString_byref___DTString_byref_ParsingInfo_DateTimeFormatInfo_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00059DC0 File Offset: 0x00057FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285411, XrefRangeEnd = 285415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseQuoteString(string format, int pos, StringBuilder result, out int returnValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &returnValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParseQuoteString_Internal_Static_Boolean_String_Int32_StringBuilder_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00059E30 File Offset: 0x00058030
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285425, RefRangeEnd = 285427, XrefRangeStart = 285415, XrefRangeEnd = 285425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoStrictParse(string s, string formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(formatParam);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_DoStrictParse_Private_Static_Boolean_String_String_DateTimeStyles_DateTimeFormatInfo_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00059EB8 File Offset: 0x000580B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285427, XrefRangeEnd = 285430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetDateTimeParseException(ref DateTimeResult result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDateTimeParseException_Private_Static_Exception_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0000514E File Offset: 0x0000334E
		public DateTimeParse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x00059F00 File Offset: 0x00058100
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x00005157 File Offset: 0x00003357
		public unsafe static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParse.NativeFieldInfoPtr_m_hebrewNumberParser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeParse.MatchNumberDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParse.NativeFieldInfoPtr_m_hebrewNumberParser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00059F28 File Offset: 0x00058128
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x00005169 File Offset: 0x00003369
		public unsafe static Il2CppReferenceArray<Il2CppStructArray<DateTimeParse.DS>> dateParsingStates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParse.NativeFieldInfoPtr_dateParsingStates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<DateTimeParse.DS>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParse.NativeFieldInfoPtr_dateParsingStates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeFieldInfoPtr_m_hebrewNumberParser;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeFieldInfoPtr_dateParsingStates;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_ParseExact_Internal_Static_DateTime_String_String_DateTimeFormatInfo_DateTimeStyles_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_String_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExactMultiple_Internal_Static_Boolean_String_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExactMultiple_Internal_Static_Boolean_String_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_MatchWord_Private_Static_Boolean_byref___DTString_String_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeZoneName_Private_Static_Boolean_byref___DTString_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_ParseFraction_Private_Static_Boolean_byref___DTString_byref_Double_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_ParseTimeZone_Private_Static_Boolean_byref___DTString_byref_TimeSpan_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_HandleTimeZone_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_Lex_Private_Static_Boolean_DS_byref___DTString_byref_DateTimeToken_byref_DateTimeRawInfo_byref_DateTimeResult_byref_DateTimeFormatInfo_DateTimeStyles_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_VerifyValidPunctuation_Private_Static_Boolean_byref___DTString_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_GetYearMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_GetYearMonthOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_TryAdjustYear_Private_Static_Boolean_byref_DateTimeResult_Int32_byref_Int32_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_SetDateYMD_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_SetDateMDY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_SetDateDMY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_SetDateYDM_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultYear_Private_Static_Void_byref_DateTimeResult_byref_DateTimeStyles_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_GetHebrewDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfYNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfNNY_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfYMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfYN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfYM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_AdjustTimeMark_Private_Static_Void_DateTimeFormatInfo_byref_DateTimeRawInfo_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_AdjustHour_Private_Static_Boolean_byref_Int32_TM_0;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeOfN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeOfNN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeOfNNN_Private_Static_Boolean_DateTimeFormatInfo_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_GetDateOfDSN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_GetDateOfNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_GetDateOfNNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDateTimeSuffix_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_byref_DateTimeToken_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHebrewTerminalState_Internal_Static_Boolean_DS_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTerminaltState_Internal_Static_Boolean_DS_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_DateTime_String_DateTimeFormatInfo_DateTimeStyles_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_DetermineTimeZoneAdjustments_Private_Static_Boolean_byref_DateTimeResult_DateTimeStyles_Boolean_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_DateTimeOffsetTimeZonePostProcessing_Private_Static_Boolean_byref_DateTimeResult_DateTimeStyles_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_AdjustTimeZoneToUniversal_Private_Static_Boolean_byref_DateTimeResult_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_AdjustTimeZoneToLocal_Private_Static_Boolean_byref_DateTimeResult_Boolean_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_ParseISO8601_Private_Static_Boolean_byref_DateTimeRawInfo_byref___DTString_DateTimeStyles_byref_DateTimeResult_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_MatchHebrewDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_Int32_byref_Int32_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_ParseFractionExact_Private_Static_Boolean_byref___DTString_Int32_byref_Double_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_ParseSign_Private_Static_Boolean_byref___DTString_byref_Boolean_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_ParseTimeZoneOffset_Private_Static_Boolean_byref___DTString_Int32_byref_TimeSpan_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_MatchAbbreviatedMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr_MatchMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_MatchAbbreviatedDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_MatchDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_MatchEraName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_MatchTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_MatchAbbreviatedTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_CheckNewValue_Private_Static_Boolean_byref_Int32_Int32_Char_byref_DateTimeResult_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTimeNow_Private_Static_DateTime_byref_DateTimeResult_byref_DateTimeStyles_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_CheckDefaultDateTime_Private_Static_Boolean_byref_DateTimeResult_byref_Calendar_DateTimeStyles_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_String_byref_DateTimeFormatInfo_byref_ParsingInfo_byref_DateTimeResult_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_ParseByFormat_Private_Static_Boolean_byref___DTString_byref___DTString_byref_ParsingInfo_DateTimeFormatInfo_byref_DateTimeResult_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_TryParseQuoteString_Internal_Static_Boolean_String_Int32_StringBuilder_byref_Int32_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_DoStrictParse_Private_Static_Boolean_String_String_DateTimeStyles_DateTimeFormatInfo_byref_DateTimeResult_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTimeParseException_Private_Static_Exception_byref_DateTimeResult_0;

		// Token: 0x02000593 RID: 1427
		public sealed class MatchNumberDelegate : MulticastDelegate
		{
			// Token: 0x06004F09 RID: 20233 RVA: 0x0001DE74 File Offset: 0x0001C074
			// Note: this type is marked as 'beforefieldinit'.
			static MatchNumberDelegate()
			{
				Il2CppClassPointerStore<DateTimeParse.MatchNumberDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, "MatchNumberDelegate");
				DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse.MatchNumberDelegate>.NativeClassPtr, 100665374);
				DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref___DTString_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse.MatchNumberDelegate>.NativeClassPtr, 100665375);
			}

			// Token: 0x06004F0A RID: 20234 RVA: 0x00163D70 File Offset: 0x00161F70
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MatchNumberDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeParse.MatchNumberDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F0B RID: 20235 RVA: 0x00163DCC File Offset: 0x00161FCC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 284170, RefRangeEnd = 284171, XrefRangeStart = 284170, XrefRangeEnd = 284170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Invoke(ref __DTString str, int digitLen, out int result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitLen;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref___DTString_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F0C RID: 20236 RVA: 0x0001DEB2 File Offset: 0x0001C0B2
			public MatchNumberDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003FC3 RID: 16323
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003FC4 RID: 16324
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref___DTString_Int32_byref_Int32_0;
		}

		// Token: 0x02000594 RID: 1428
		public enum DTT
		{
			// Token: 0x04003FC6 RID: 16326
			End,
			// Token: 0x04003FC7 RID: 16327
			NumEnd,
			// Token: 0x04003FC8 RID: 16328
			NumAmpm,
			// Token: 0x04003FC9 RID: 16329
			NumSpace,
			// Token: 0x04003FCA RID: 16330
			NumDatesep,
			// Token: 0x04003FCB RID: 16331
			NumTimesep,
			// Token: 0x04003FCC RID: 16332
			MonthEnd,
			// Token: 0x04003FCD RID: 16333
			MonthSpace,
			// Token: 0x04003FCE RID: 16334
			MonthDatesep,
			// Token: 0x04003FCF RID: 16335
			NumDatesuff,
			// Token: 0x04003FD0 RID: 16336
			NumTimesuff,
			// Token: 0x04003FD1 RID: 16337
			DayOfWeek,
			// Token: 0x04003FD2 RID: 16338
			YearSpace,
			// Token: 0x04003FD3 RID: 16339
			YearDateSep,
			// Token: 0x04003FD4 RID: 16340
			YearEnd,
			// Token: 0x04003FD5 RID: 16341
			TimeZone,
			// Token: 0x04003FD6 RID: 16342
			Era,
			// Token: 0x04003FD7 RID: 16343
			NumUTCTimeMark,
			// Token: 0x04003FD8 RID: 16344
			Unk,
			// Token: 0x04003FD9 RID: 16345
			NumLocalTimeMark,
			// Token: 0x04003FDA RID: 16346
			Max
		}

		// Token: 0x02000595 RID: 1429
		public enum TM
		{
			// Token: 0x04003FDC RID: 16348
			NotSet = -1,
			// Token: 0x04003FDD RID: 16349
			AM,
			// Token: 0x04003FDE RID: 16350
			PM
		}

		// Token: 0x02000596 RID: 1430
		public enum DS
		{
			// Token: 0x04003FE0 RID: 16352
			BEGIN,
			// Token: 0x04003FE1 RID: 16353
			N,
			// Token: 0x04003FE2 RID: 16354
			NN,
			// Token: 0x04003FE3 RID: 16355
			D_Nd,
			// Token: 0x04003FE4 RID: 16356
			D_NN,
			// Token: 0x04003FE5 RID: 16357
			D_NNd,
			// Token: 0x04003FE6 RID: 16358
			D_M,
			// Token: 0x04003FE7 RID: 16359
			D_MN,
			// Token: 0x04003FE8 RID: 16360
			D_NM,
			// Token: 0x04003FE9 RID: 16361
			D_MNd,
			// Token: 0x04003FEA RID: 16362
			D_NDS,
			// Token: 0x04003FEB RID: 16363
			D_Y,
			// Token: 0x04003FEC RID: 16364
			D_YN,
			// Token: 0x04003FED RID: 16365
			D_YNd,
			// Token: 0x04003FEE RID: 16366
			D_YM,
			// Token: 0x04003FEF RID: 16367
			D_YMd,
			// Token: 0x04003FF0 RID: 16368
			D_S,
			// Token: 0x04003FF1 RID: 16369
			T_S,
			// Token: 0x04003FF2 RID: 16370
			T_Nt,
			// Token: 0x04003FF3 RID: 16371
			T_NNt,
			// Token: 0x04003FF4 RID: 16372
			ERROR,
			// Token: 0x04003FF5 RID: 16373
			DX_NN,
			// Token: 0x04003FF6 RID: 16374
			DX_NNN,
			// Token: 0x04003FF7 RID: 16375
			DX_MN,
			// Token: 0x04003FF8 RID: 16376
			DX_NM,
			// Token: 0x04003FF9 RID: 16377
			DX_MNN,
			// Token: 0x04003FFA RID: 16378
			DX_DS,
			// Token: 0x04003FFB RID: 16379
			DX_DSN,
			// Token: 0x04003FFC RID: 16380
			DX_NDS,
			// Token: 0x04003FFD RID: 16381
			DX_NNDS,
			// Token: 0x04003FFE RID: 16382
			DX_YNN,
			// Token: 0x04003FFF RID: 16383
			DX_YMN,
			// Token: 0x04004000 RID: 16384
			DX_YN,
			// Token: 0x04004001 RID: 16385
			DX_YM,
			// Token: 0x04004002 RID: 16386
			TX_N,
			// Token: 0x04004003 RID: 16387
			TX_NN,
			// Token: 0x04004004 RID: 16388
			TX_NNN,
			// Token: 0x04004005 RID: 16389
			TX_TS,
			// Token: 0x04004006 RID: 16390
			DX_NNY
		}
	}
}
