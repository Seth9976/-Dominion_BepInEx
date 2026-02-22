using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200022F RID: 559
	[Serializable]
	public sealed class DateTimeFormatInfo : Object
	{
		// Token: 0x060024C8 RID: 9416 RVA: 0x000C633C File Offset: 0x000C453C
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeFormatInfo()
		{
			Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "DateTimeFormatInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr);
			DateTimeFormatInfo.NativeFieldInfoPtr_invariantInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "invariantInfo");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_cultureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_cultureData");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_name");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_langName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_langName");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_compareInfo");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_cultureInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_cultureInfo");
			DateTimeFormatInfo.NativeFieldInfoPtr_amDesignator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "amDesignator");
			DateTimeFormatInfo.NativeFieldInfoPtr_pmDesignator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "pmDesignator");
			DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dateSeparator");
			DateTimeFormatInfo.NativeFieldInfoPtr_generalShortTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "generalShortTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_generalLongTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "generalLongTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_timeSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "timeSeparator");
			DateTimeFormatInfo.NativeFieldInfoPtr_monthDayPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "monthDayPattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_dateTimeOffsetPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dateTimeOffsetPattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_rfc1123Pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "rfc1123Pattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_sortableDateTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "sortableDateTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_universalSortableDateTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "universalSortableDateTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_calendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "calendar");
			DateTimeFormatInfo.NativeFieldInfoPtr_firstDayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "firstDayOfWeek");
			DateTimeFormatInfo.NativeFieldInfoPtr_calendarWeekRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "calendarWeekRule");
			DateTimeFormatInfo.NativeFieldInfoPtr_fullDateTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "fullDateTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "abbreviatedDayNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_superShortDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_superShortDayNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_dayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dayNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "abbreviatedMonthNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_monthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "monthNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_genitiveMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "genitiveMonthNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_genitiveAbbreviatedMonthNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_leapYearMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "leapYearMonthNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_longDatePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "longDatePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_shortDatePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "shortDatePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_yearMonthPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "yearMonthPattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_longTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "longTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_shortTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "shortTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_allYearMonthPatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allYearMonthPatterns");
			DateTimeFormatInfo.NativeFieldInfoPtr_allShortDatePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allShortDatePatterns");
			DateTimeFormatInfo.NativeFieldInfoPtr_allLongDatePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allLongDatePatterns");
			DateTimeFormatInfo.NativeFieldInfoPtr_allShortTimePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allShortTimePatterns");
			DateTimeFormatInfo.NativeFieldInfoPtr_allLongTimePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allLongTimePatterns");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_eraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_eraNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_abbrevEraNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEnglishEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_abbrevEnglishEraNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_optionalCalendars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "optionalCalendars");
			DateTimeFormatInfo.NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "DEFAULT_ALL_DATETIMES_SIZE");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_isReadOnly");
			DateTimeFormatInfo.NativeFieldInfoPtr_formatFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "formatFlags");
			DateTimeFormatInfo.NativeFieldInfoPtr_preferExistingTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "preferExistingTokens");
			DateTimeFormatInfo.NativeFieldInfoPtr_CultureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CultureID");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_useUserOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_useUserOverride");
			DateTimeFormatInfo.NativeFieldInfoPtr_bUseCalendarInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "bUseCalendarInfo");
			DateTimeFormatInfo.NativeFieldInfoPtr_nDataItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "nDataItem");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_isDefaultCalendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_isDefaultCalendar");
			DateTimeFormatInfo.NativeFieldInfoPtr_s_calendarNativeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "s_calendarNativeNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_dateWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_dateWords");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_fullTimeSpanPositivePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_fullTimeSpanPositivePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_fullTimeSpanNegativePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_fullTimeSpanNegativePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_InvalidDateTimeStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "InvalidDateTimeStyles");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_dtfiTokenHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_dtfiTokenHash");
			DateTimeFormatInfo.NativeFieldInfoPtr_TOKEN_HASH_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "TOKEN_HASH_SIZE");
			DateTimeFormatInfo.NativeFieldInfoPtr_SECOND_PRIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "SECOND_PRIME");
			DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dateSeparatorOrTimeZoneOffset");
			DateTimeFormatInfo.NativeFieldInfoPtr_invariantDateSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "invariantDateSeparator");
			DateTimeFormatInfo.NativeFieldInfoPtr_invariantTimeSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "invariantTimeSeparator");
			DateTimeFormatInfo.NativeFieldInfoPtr_IgnorablePeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "IgnorablePeriod");
			DateTimeFormatInfo.NativeFieldInfoPtr_IgnorableComma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "IgnorableComma");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKYearSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKYearSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKMonthSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKMonthSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKDaySuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKDaySuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanYearSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanYearSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMonthSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanMonthSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanDaySuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanDaySuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanHourSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanHourSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMinuteSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanMinuteSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanSecondSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanSecondSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKHourSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKHourSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_ChineseHourSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "ChineseHourSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKMinuteSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKMinuteSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKSecondSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKSecondSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_LocalTimeMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "LocalTimeMark");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanLangName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanLangName");
			DateTimeFormatInfo.NativeFieldInfoPtr_JapaneseLangName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "JapaneseLangName");
			DateTimeFormatInfo.NativeFieldInfoPtr_EnglishLangName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "EnglishLangName");
			DateTimeFormatInfo.NativeFieldInfoPtr_s_jajpDTFI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "s_jajpDTFI");
			DateTimeFormatInfo.NativeFieldInfoPtr_s_zhtwDTFI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "s_zhtwDTFI");
			DateTimeFormatInfo.NativeMethodInfoPtr_InitPreferExistingTokens_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669364);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_CultureName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669365);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_Culture_Private_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669366);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_LanguageName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669367);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669368);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetDayOfWeekNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669369);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedMonthNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669370);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetMonthNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669371);
			DateTimeFormatInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669372);
			DateTimeFormatInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669373);
			DateTimeFormatInfo.NativeMethodInfoPtr_InitializeOverridableProperties_Private_Void_CultureData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669374);
			DateTimeFormatInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669375);
			DateTimeFormatInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669376);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669377);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669378);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetInstance_Public_Static_DateTimeFormatInfo_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669379);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669380);
			DateTimeFormatInfo.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669381);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AMDesignator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669382);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_Calendar_Public_get_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669383);
			DateTimeFormatInfo.NativeMethodInfoPtr_set_Calendar_Public_set_Void_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669384);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_OptionalCalendars_Private_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669385);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_EraNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669386);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetEraName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669387);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedEraNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669388);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedEraName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669389);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedEnglishEraNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669390);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_DateSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669391);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_FullDateTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669392);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_LongDatePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669393);
			DateTimeFormatInfo.NativeMethodInfoPtr_set_LongDatePattern_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669394);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_LongTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669395);
			DateTimeFormatInfo.NativeMethodInfoPtr_set_LongTimePattern_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669396);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthDayPattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669397);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_PMDesignator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669398);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_RFC1123Pattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669399);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_ShortDatePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669400);
			DateTimeFormatInfo.NativeMethodInfoPtr_set_ShortDatePattern_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669401);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_ShortTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669402);
			DateTimeFormatInfo.NativeMethodInfoPtr_set_ShortTimePattern_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669403);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_SortableDateTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669404);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_GeneralShortTimePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669405);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_GeneralLongTimePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669406);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_DateTimeOffsetPattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669407);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_TimeSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669408);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UniversalSortableDateTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669409);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_YearMonthPattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669410);
			DateTimeFormatInfo.NativeMethodInfoPtr_set_YearMonthPattern_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669411);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedDayNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669412);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_DayNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669413);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedMonthNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669414);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669415);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_HasSpacesInMonthNames_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669416);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_HasSpacesInDayNames_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669417);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetMonthName_Internal_String_Int32_MonthNameStyles_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669418);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetGenitiveMonthNames_Private_Il2CppStringArray_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669419);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetLeapYearMonthNames_Internal_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669420);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedDayName_Public_String_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669421);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetCombinedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669422);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetAllDateTimePatterns_Public_Il2CppStringArray_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669423);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetDayName_Public_String_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669424);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedMonthName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669425);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetMonthName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669426);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetMergedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669427);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AllYearMonthPatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669428);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AllShortDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669429);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AllShortTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669430);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AllLongDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669431);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AllLongTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669432);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedYearMonthPatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669433);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedShortDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669434);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedLongDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669435);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedShortTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669436);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedLongTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669437);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669438);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthGenitiveNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669439);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_FullTimeSpanPositivePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669440);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_FullTimeSpanNegativePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669441);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669442);
			DateTimeFormatInfo.NativeMethodInfoPtr_ValidateStyles_Internal_Static_Void_DateTimeStyles_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669443);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_FormatFlags_Internal_get_DateTimeFormatFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669444);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_HasForceTwoDigitYears_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669445);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_HasYearMonthAdjustment_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669446);
			DateTimeFormatInfo.NativeMethodInfoPtr_YearMonthAdjustment_Internal_Boolean_byref_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669447);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetJapaneseCalendarDTFI_Internal_Static_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669448);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetTaiwanCalendarDTFI_Internal_Static_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669449);
			DateTimeFormatInfo.NativeMethodInfoPtr_ClearTokenHashTable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669450);
			DateTimeFormatInfo.NativeMethodInfoPtr_CreateTokenHashTable_Internal_Il2CppReferenceArray_1_TokenHashValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669451);
			DateTimeFormatInfo.NativeMethodInfoPtr_AddMonthNames_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669452);
			DateTimeFormatInfo.NativeMethodInfoPtr_TryParseHebrewNumber_Private_Static_Boolean_byref___DTString_byref_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669453);
			DateTimeFormatInfo.NativeMethodInfoPtr_IsHebrewChar_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669454);
			DateTimeFormatInfo.NativeMethodInfoPtr_Tokenize_Internal_Boolean_TokenType_byref_TokenType_byref_Int32_byref___DTString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669455);
			DateTimeFormatInfo.NativeMethodInfoPtr_InsertAtCurrentHashNode_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_Char_TokenType_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669456);
			DateTimeFormatInfo.NativeMethodInfoPtr_InsertHash_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_TokenType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100669457);
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x000C7154 File Offset: 0x000C5354
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InitPreferExistingTokens()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_InitPreferExistingTokens_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x000C7184 File Offset: 0x000C5384
		public unsafe string CultureName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_CultureName_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x060024CB RID: 9419 RVA: 0x000C71BC File Offset: 0x000C53BC
		public unsafe CultureInfo Culture
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 325201, RefRangeEnd = 325206, XrefRangeStart = 325197, XrefRangeEnd = 325201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_Culture_Private_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x000C71FC File Offset: 0x000C53FC
		public unsafe string LanguageName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_LanguageName_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x000C7234 File Offset: 0x000C5434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325207, RefRangeEnd = 325208, XrefRangeStart = 325206, XrefRangeEnd = 325207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetAbbreviatedDayOfWeekNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x000C7274 File Offset: 0x000C5474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325209, RefRangeEnd = 325210, XrefRangeStart = 325208, XrefRangeEnd = 325209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetDayOfWeekNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetDayOfWeekNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x000C72B4 File Offset: 0x000C54B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325211, RefRangeEnd = 325213, XrefRangeStart = 325210, XrefRangeEnd = 325211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetAbbreviatedMonthNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedMonthNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x000C72F4 File Offset: 0x000C54F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325214, RefRangeEnd = 325216, XrefRangeStart = 325213, XrefRangeEnd = 325214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetMonthNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetMonthNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x000C7334 File Offset: 0x000C5534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325216, XrefRangeEnd = 325227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeFormatInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x000C7370 File Offset: 0x000C5570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325229, RefRangeEnd = 325230, XrefRangeStart = 325227, XrefRangeEnd = 325229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeFormatInfo(CultureData cultureData, Calendar cal)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cultureData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_Calendar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x000C73D0 File Offset: 0x000C55D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325230, XrefRangeEnd = 325236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeOverridableProperties(CultureData cultureData, int calendarID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cultureData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_InitializeOverridableProperties_Private_Void_CultureData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x000C7420 File Offset: 0x000C5620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325236, XrefRangeEnd = 325256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x000C7468 File Offset: 0x000C5668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325256, XrefRangeEnd = 325285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x000C74B0 File Offset: 0x000C56B0
		public unsafe static DateTimeFormatInfo InvariantInfo
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 325310, RefRangeEnd = 325330, XrefRangeStart = 325285, XrefRangeEnd = 325310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x060024D7 RID: 9431 RVA: 0x000C74E4 File Offset: 0x000C56E4
		public unsafe static DateTimeFormatInfo CurrentInfo
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 325336, RefRangeEnd = 325340, XrefRangeStart = 325330, XrefRangeEnd = 325336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x000C7518 File Offset: 0x000C5718
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 325353, RefRangeEnd = 325362, XrefRangeStart = 325340, XrefRangeEnd = 325353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeFormatInfo GetInstance(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetInstance_Public_Static_DateTimeFormatInfo_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x000C755C File Offset: 0x000C575C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325362, XrefRangeEnd = 325369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetFormat(Type formatType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x000C75AC File Offset: 0x000C57AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 325374, RefRangeEnd = 325377, XrefRangeStart = 325369, XrefRangeEnd = 325374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060024DB RID: 9435 RVA: 0x000C75EC File Offset: 0x000C57EC
		public unsafe string AMDesignator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AMDesignator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x000C7624 File Offset: 0x000C5824
		// (set) Token: 0x060024DD RID: 9437 RVA: 0x000C7664 File Offset: 0x000C5864
		public unsafe Calendar Calendar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_Calendar_Public_get_Calendar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 325389, RefRangeEnd = 325396, XrefRangeStart = 325377, XrefRangeEnd = 325389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_set_Calendar_Public_set_Void_Calendar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x000C76A8 File Offset: 0x000C58A8
		public unsafe Il2CppStructArray<int> OptionalCalendars
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325396, XrefRangeEnd = 325397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_OptionalCalendars_Private_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060024DF RID: 9439 RVA: 0x000C76E8 File Offset: 0x000C58E8
		public unsafe Il2CppStringArray EraNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325397, XrefRangeEnd = 325398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_EraNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x000C7728 File Offset: 0x000C5928
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 325399, RefRangeEnd = 325405, XrefRangeStart = 325398, XrefRangeEnd = 325399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetEraName(int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref era;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetEraName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060024E1 RID: 9441 RVA: 0x000C776C File Offset: 0x000C596C
		public unsafe Il2CppStringArray AbbreviatedEraNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325405, XrefRangeEnd = 325406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedEraNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x000C77AC File Offset: 0x000C59AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 325407, RefRangeEnd = 325410, XrefRangeStart = 325406, XrefRangeEnd = 325407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAbbreviatedEraName(int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref era;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedEraName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060024E3 RID: 9443 RVA: 0x000C77F0 File Offset: 0x000C59F0
		public unsafe Il2CppStringArray AbbreviatedEnglishEraNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325410, XrefRangeEnd = 325411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedEnglishEraNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x000C7830 File Offset: 0x000C5A30
		public unsafe string DateSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_DateSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x060024E5 RID: 9445 RVA: 0x000C7868 File Offset: 0x000C5A68
		public unsafe string FullDateTimePattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325411, XrefRangeEnd = 325416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_FullDateTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x000C78A0 File Offset: 0x000C5AA0
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x000C78D8 File Offset: 0x000C5AD8
		public unsafe string LongDatePattern
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 325417, RefRangeEnd = 325420, XrefRangeStart = 325416, XrefRangeEnd = 325417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_LongDatePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_set_LongDatePattern_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x000C791C File Offset: 0x000C5B1C
		// (set) Token: 0x060024E9 RID: 9449 RVA: 0x000C7954 File Offset: 0x000C5B54
		public unsafe string LongTimePattern
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 325421, RefRangeEnd = 325425, XrefRangeStart = 325420, XrefRangeEnd = 325421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_LongTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_set_LongTimePattern_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x000C7998 File Offset: 0x000C5B98
		public unsafe string MonthDayPattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325425, XrefRangeEnd = 325426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthDayPattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060024EB RID: 9451 RVA: 0x000C79D0 File Offset: 0x000C5BD0
		public unsafe string PMDesignator
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_PMDesignator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x000C7A08 File Offset: 0x000C5C08
		public unsafe string RFC1123Pattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325426, XrefRangeEnd = 325428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_RFC1123Pattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060024ED RID: 9453 RVA: 0x000C7A40 File Offset: 0x000C5C40
		// (set) Token: 0x060024EE RID: 9454 RVA: 0x000C7A78 File Offset: 0x000C5C78
		public unsafe string ShortDatePattern
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 325429, RefRangeEnd = 325440, XrefRangeStart = 325428, XrefRangeEnd = 325429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_ShortDatePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_set_ShortDatePattern_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x060024EF RID: 9455 RVA: 0x000C7ABC File Offset: 0x000C5CBC
		// (set) Token: 0x060024F0 RID: 9456 RVA: 0x000C7AF4 File Offset: 0x000C5CF4
		public unsafe string ShortTimePattern
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 325441, RefRangeEnd = 325442, XrefRangeStart = 325440, XrefRangeEnd = 325441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_ShortTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_set_ShortTimePattern_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060024F1 RID: 9457 RVA: 0x000C7B38 File Offset: 0x000C5D38
		public unsafe string SortableDateTimePattern
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 325444, RefRangeEnd = 325446, XrefRangeStart = 325442, XrefRangeEnd = 325444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_SortableDateTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x000C7B70 File Offset: 0x000C5D70
		public unsafe string GeneralShortTimePattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325446, XrefRangeEnd = 325451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_GeneralShortTimePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060024F3 RID: 9459 RVA: 0x000C7BA8 File Offset: 0x000C5DA8
		public unsafe string GeneralLongTimePattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325451, XrefRangeEnd = 325456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_GeneralLongTimePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x000C7BE0 File Offset: 0x000C5DE0
		public unsafe string DateTimeOffsetPattern
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 325470, RefRangeEnd = 325471, XrefRangeStart = 325456, XrefRangeEnd = 325470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_DateTimeOffsetPattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x000C7C18 File Offset: 0x000C5E18
		public unsafe string TimeSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_TimeSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x000C7C50 File Offset: 0x000C5E50
		public unsafe string UniversalSortableDateTimePattern
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 325473, RefRangeEnd = 325475, XrefRangeStart = 325471, XrefRangeEnd = 325473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UniversalSortableDateTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x000C7C88 File Offset: 0x000C5E88
		// (set) Token: 0x060024F8 RID: 9464 RVA: 0x000C7CC0 File Offset: 0x000C5EC0
		public unsafe string YearMonthPattern
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 325476, RefRangeEnd = 325482, XrefRangeStart = 325475, XrefRangeEnd = 325476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_YearMonthPattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_set_YearMonthPattern_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x000C7D04 File Offset: 0x000C5F04
		public unsafe Il2CppStringArray AbbreviatedDayNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325482, XrefRangeEnd = 325486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedDayNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x000C7D44 File Offset: 0x000C5F44
		public unsafe Il2CppStringArray DayNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325486, XrefRangeEnd = 325490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_DayNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x000C7D84 File Offset: 0x000C5F84
		public unsafe Il2CppStringArray AbbreviatedMonthNames
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 325494, RefRangeEnd = 325496, XrefRangeStart = 325490, XrefRangeEnd = 325494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedMonthNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060024FC RID: 9468 RVA: 0x000C7DC4 File Offset: 0x000C5FC4
		public unsafe Il2CppStringArray MonthNames
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 325500, RefRangeEnd = 325502, XrefRangeStart = 325496, XrefRangeEnd = 325500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x000C7E04 File Offset: 0x000C6004
		public unsafe bool HasSpacesInMonthNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325502, XrefRangeEnd = 325503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_HasSpacesInMonthNames_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060024FE RID: 9470 RVA: 0x000C7E40 File Offset: 0x000C6040
		public unsafe bool HasSpacesInDayNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325503, XrefRangeEnd = 325504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_HasSpacesInDayNames_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x000C7E7C File Offset: 0x000C607C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 325511, RefRangeEnd = 325514, XrefRangeStart = 325504, XrefRangeEnd = 325511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref month;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref abbreviated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetMonthName_Internal_String_Int32_MonthNameStyles_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x000C7EDC File Offset: 0x000C60DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325515, RefRangeEnd = 325516, XrefRangeStart = 325514, XrefRangeEnd = 325515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetGenitiveMonthNames(bool abbreviated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref abbreviated;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetGenitiveMonthNames_Private_Il2CppStringArray_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x000C7F28 File Offset: 0x000C6128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325517, RefRangeEnd = 325518, XrefRangeStart = 325516, XrefRangeEnd = 325517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetLeapYearMonthNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetLeapYearMonthNames_Internal_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x000C7F68 File Offset: 0x000C6168
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 325519, RefRangeEnd = 325525, XrefRangeStart = 325518, XrefRangeEnd = 325519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAbbreviatedDayName(DayOfWeek dayofweek)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dayofweek;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedDayName_Public_String_DayOfWeek_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x000C7FAC File Offset: 0x000C61AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325525, XrefRangeEnd = 325532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetCombinedPatterns(Il2CppStringArray patterns1, Il2CppStringArray patterns2, string connectString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(patterns1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(patterns2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(connectString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetCombinedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x000C8014 File Offset: 0x000C6214
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 325545, RefRangeEnd = 325550, XrefRangeStart = 325532, XrefRangeEnd = 325545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetAllDateTimePatterns(char format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetAllDateTimePatterns_Public_Il2CppStringArray_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x000C8060 File Offset: 0x000C6260
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 325551, RefRangeEnd = 325556, XrefRangeStart = 325550, XrefRangeEnd = 325551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDayName(DayOfWeek dayofweek)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dayofweek;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetDayName_Public_String_DayOfWeek_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x000C80A4 File Offset: 0x000C62A4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 325557, RefRangeEnd = 325565, XrefRangeStart = 325556, XrefRangeEnd = 325557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAbbreviatedMonthName(int month)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref month;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedMonthName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x000C80E8 File Offset: 0x000C62E8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 325566, RefRangeEnd = 325576, XrefRangeStart = 325565, XrefRangeEnd = 325566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetMonthName(int month)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref month;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetMonthName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x000C812C File Offset: 0x000C632C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 325589, RefRangeEnd = 325594, XrefRangeStart = 325576, XrefRangeEnd = 325589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetMergedPatterns(Il2CppStringArray patterns, string defaultPattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(patterns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultPattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetMergedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x000C8184 File Offset: 0x000C6384
		public unsafe Il2CppStringArray AllYearMonthPatterns
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 325601, RefRangeEnd = 325602, XrefRangeStart = 325594, XrefRangeEnd = 325601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AllYearMonthPatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x0600250A RID: 9482 RVA: 0x000C81C4 File Offset: 0x000C63C4
		public unsafe Il2CppStringArray AllShortDatePatterns
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 325609, RefRangeEnd = 325610, XrefRangeStart = 325602, XrefRangeEnd = 325609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AllShortDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x000C8204 File Offset: 0x000C6404
		public unsafe Il2CppStringArray AllShortTimePatterns
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 325619, RefRangeEnd = 325621, XrefRangeStart = 325610, XrefRangeEnd = 325619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AllShortTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x0600250C RID: 9484 RVA: 0x000C8244 File Offset: 0x000C6444
		public unsafe Il2CppStringArray AllLongDatePatterns
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 325628, RefRangeEnd = 325629, XrefRangeStart = 325621, XrefRangeEnd = 325628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AllLongDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x000C8284 File Offset: 0x000C6484
		public unsafe Il2CppStringArray AllLongTimePatterns
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 325638, RefRangeEnd = 325639, XrefRangeStart = 325629, XrefRangeEnd = 325638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AllLongTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x0600250E RID: 9486 RVA: 0x000C82C4 File Offset: 0x000C64C4
		public unsafe Il2CppStringArray UnclonedYearMonthPatterns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325639, XrefRangeEnd = 325640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedYearMonthPatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x000C8304 File Offset: 0x000C6504
		public unsafe Il2CppStringArray UnclonedShortDatePatterns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325640, XrefRangeEnd = 325641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedShortDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06002510 RID: 9488 RVA: 0x000C8344 File Offset: 0x000C6544
		public unsafe Il2CppStringArray UnclonedLongDatePatterns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325641, XrefRangeEnd = 325642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedLongDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x000C8384 File Offset: 0x000C6584
		public unsafe Il2CppStringArray UnclonedShortTimePatterns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325642, XrefRangeEnd = 325643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedShortTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x000C83C4 File Offset: 0x000C65C4
		public unsafe Il2CppStringArray UnclonedLongTimePatterns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325643, XrefRangeEnd = 325644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedLongTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x000C8404 File Offset: 0x000C6604
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x000C8440 File Offset: 0x000C6640
		public unsafe Il2CppStringArray MonthGenitiveNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325644, XrefRangeEnd = 325648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthGenitiveNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06002515 RID: 9493 RVA: 0x000C8480 File Offset: 0x000C6680
		public unsafe string FullTimeSpanPositivePattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325648, XrefRangeEnd = 325658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_FullTimeSpanPositivePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x000C84B8 File Offset: 0x000C66B8
		public unsafe string FullTimeSpanNegativePattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325658, XrefRangeEnd = 325671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_FullTimeSpanNegativePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x000C84F0 File Offset: 0x000C66F0
		public unsafe CompareInfo CompareInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 325673, RefRangeEnd = 325674, XrefRangeStart = 325671, XrefRangeEnd = 325673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x000C8530 File Offset: 0x000C6730
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 325674, RefRangeEnd = 325677, XrefRangeStart = 325674, XrefRangeEnd = 325674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateStyles(DateTimeStyles style, string parameterName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_ValidateStyles_Internal_Static_Void_DateTimeStyles_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x000C8574 File Offset: 0x000C6774
		public unsafe DateTimeFormatFlags FormatFlags
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 325712, RefRangeEnd = 325730, XrefRangeStart = 325677, XrefRangeEnd = 325712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_FormatFlags_Internal_get_DateTimeFormatFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x000C85B0 File Offset: 0x000C67B0
		public unsafe bool HasForceTwoDigitYears
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_HasForceTwoDigitYears_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x000C85EC File Offset: 0x000C67EC
		public unsafe bool HasYearMonthAdjustment
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325730, XrefRangeEnd = 325731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_HasYearMonthAdjustment_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x000C8628 File Offset: 0x000C6828
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 325733, RefRangeEnd = 325737, XrefRangeStart = 325731, XrefRangeEnd = 325733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parsedMonthName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_YearMonthAdjustment_Internal_Boolean_byref_Int32_byref_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x000C8690 File Offset: 0x000C6890
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325757, RefRangeEnd = 325759, XrefRangeStart = 325737, XrefRangeEnd = 325757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeFormatInfo GetJapaneseCalendarDTFI()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetJapaneseCalendarDTFI_Internal_Static_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x000C86C4 File Offset: 0x000C68C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325779, RefRangeEnd = 325781, XrefRangeStart = 325759, XrefRangeEnd = 325779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeFormatInfo GetTaiwanCalendarDTFI()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetTaiwanCalendarDTFI_Internal_Static_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x000C86F8 File Offset: 0x000C68F8
		[CallerCount(0)]
		public unsafe void ClearTokenHashTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_ClearTokenHashTable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x000C872C File Offset: 0x000C692C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325995, RefRangeEnd = 325996, XrefRangeStart = 325781, XrefRangeEnd = 325995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TokenHashValue> CreateTokenHashTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_CreateTokenHashTable_Internal_Il2CppReferenceArray_1_TokenHashValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TokenHashValue>>(intPtr3) : null;
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x000C876C File Offset: 0x000C696C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325996, XrefRangeEnd = 326001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMonthNames(Il2CppReferenceArray<TokenHashValue> temp, string monthPostfix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(temp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(monthPostfix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_AddMonthNames_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x000C87C0 File Offset: 0x000C69C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326001, XrefRangeEnd = 326013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &badFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_TryParseHebrewNumber_Private_Static_Boolean_byref___DTString_byref_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x000C8820 File Offset: 0x000C6A20
		[CallerCount(0)]
		public unsafe static bool IsHebrewChar(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_IsHebrewChar_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x000C8860 File Offset: 0x000C6A60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 326045, RefRangeEnd = 326047, XrefRangeStart = 326013, XrefRangeEnd = 326045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref TokenMask;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tokenType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tokenValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_Tokenize_Internal_Boolean_TokenType_byref_TokenType_byref_Int32_byref___DTString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x000C88DC File Offset: 0x000C6ADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326060, RefRangeEnd = 326061, XrefRangeStart = 326047, XrefRangeEnd = 326060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertAtCurrentHashNode(Il2CppReferenceArray<TokenHashValue> hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashcode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashProbe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_InsertAtCurrentHashNode_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_Char_TokenType_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x000C8984 File Offset: 0x000C6B84
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 326090, RefRangeEnd = 326145, XrefRangeStart = 326061, XrefRangeEnd = 326090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertHash(Il2CppReferenceArray<TokenHashValue> hashTable, string str, TokenType tokenType, int tokenValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_InsertHash_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_TokenType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x0000C752 File Offset: 0x0000A952
		public DateTimeFormatInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x000C89F4 File Offset: 0x000C6BF4
		// (set) Token: 0x06002529 RID: 9513 RVA: 0x0000C75B File Offset: 0x0000A95B
		public unsafe static DateTimeFormatInfo invariantInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x000C8A1C File Offset: 0x000C6C1C
		// (set) Token: 0x0600252B RID: 9515 RVA: 0x0000C76D File Offset: 0x0000A96D
		public unsafe CultureData m_cultureData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_cultureData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_cultureData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x000C8A4C File Offset: 0x000C6C4C
		// (set) Token: 0x0600252D RID: 9517 RVA: 0x0000C78C File Offset: 0x0000A98C
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x000C8A74 File Offset: 0x000C6C74
		// (set) Token: 0x0600252F RID: 9519 RVA: 0x0000C7AB File Offset: 0x0000A9AB
		public unsafe string m_langName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_langName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_langName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x000C8A9C File Offset: 0x000C6C9C
		// (set) Token: 0x06002531 RID: 9521 RVA: 0x0000C7CA File Offset: 0x0000A9CA
		public unsafe CompareInfo m_compareInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_compareInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_compareInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x000C8ACC File Offset: 0x000C6CCC
		// (set) Token: 0x06002533 RID: 9523 RVA: 0x0000C7E9 File Offset: 0x0000A9E9
		public unsafe CultureInfo m_cultureInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_cultureInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_cultureInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x000C8AFC File Offset: 0x000C6CFC
		// (set) Token: 0x06002535 RID: 9525 RVA: 0x0000C808 File Offset: 0x0000AA08
		public unsafe string amDesignator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_amDesignator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_amDesignator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x000C8B24 File Offset: 0x000C6D24
		// (set) Token: 0x06002537 RID: 9527 RVA: 0x0000C827 File Offset: 0x0000AA27
		public unsafe string pmDesignator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_pmDesignator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_pmDesignator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x000C8B4C File Offset: 0x000C6D4C
		// (set) Token: 0x06002539 RID: 9529 RVA: 0x0000C846 File Offset: 0x0000AA46
		public unsafe string dateSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x0600253A RID: 9530 RVA: 0x000C8B74 File Offset: 0x000C6D74
		// (set) Token: 0x0600253B RID: 9531 RVA: 0x0000C865 File Offset: 0x0000AA65
		public unsafe string generalShortTimePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_generalShortTimePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_generalShortTimePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x0600253C RID: 9532 RVA: 0x000C8B9C File Offset: 0x000C6D9C
		// (set) Token: 0x0600253D RID: 9533 RVA: 0x0000C884 File Offset: 0x0000AA84
		public unsafe string generalLongTimePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_generalLongTimePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_generalLongTimePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x000C8BC4 File Offset: 0x000C6DC4
		// (set) Token: 0x0600253F RID: 9535 RVA: 0x0000C8A3 File Offset: 0x0000AAA3
		public unsafe string timeSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_timeSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_timeSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x000C8BEC File Offset: 0x000C6DEC
		// (set) Token: 0x06002541 RID: 9537 RVA: 0x0000C8C2 File Offset: 0x0000AAC2
		public unsafe string monthDayPattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_monthDayPattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_monthDayPattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x000C8C14 File Offset: 0x000C6E14
		// (set) Token: 0x06002543 RID: 9539 RVA: 0x0000C8E1 File Offset: 0x0000AAE1
		public unsafe string dateTimeOffsetPattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dateTimeOffsetPattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dateTimeOffsetPattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x000C8C3C File Offset: 0x000C6E3C
		// (set) Token: 0x06002545 RID: 9541 RVA: 0x0000C900 File Offset: 0x0000AB00
		public unsafe static string rfc1123Pattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_rfc1123Pattern, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_rfc1123Pattern, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06002546 RID: 9542 RVA: 0x000C8C5C File Offset: 0x000C6E5C
		// (set) Token: 0x06002547 RID: 9543 RVA: 0x0000C912 File Offset: 0x0000AB12
		public unsafe static string sortableDateTimePattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_sortableDateTimePattern, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_sortableDateTimePattern, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06002548 RID: 9544 RVA: 0x000C8C7C File Offset: 0x000C6E7C
		// (set) Token: 0x06002549 RID: 9545 RVA: 0x0000C924 File Offset: 0x0000AB24
		public unsafe static string universalSortableDateTimePattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_universalSortableDateTimePattern, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_universalSortableDateTimePattern, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x0600254A RID: 9546 RVA: 0x000C8C9C File Offset: 0x000C6E9C
		// (set) Token: 0x0600254B RID: 9547 RVA: 0x0000C936 File Offset: 0x0000AB36
		public unsafe Calendar calendar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_calendar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_calendar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x0600254C RID: 9548 RVA: 0x000C8CCC File Offset: 0x000C6ECC
		// (set) Token: 0x0600254D RID: 9549 RVA: 0x0000C955 File Offset: 0x0000AB55
		public unsafe int firstDayOfWeek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_firstDayOfWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_firstDayOfWeek)) = value;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x000C8CF4 File Offset: 0x000C6EF4
		// (set) Token: 0x0600254F RID: 9551 RVA: 0x0000C970 File Offset: 0x0000AB70
		public unsafe int calendarWeekRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_calendarWeekRule);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_calendarWeekRule)) = value;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06002550 RID: 9552 RVA: 0x000C8D1C File Offset: 0x000C6F1C
		// (set) Token: 0x06002551 RID: 9553 RVA: 0x0000C98B File Offset: 0x0000AB8B
		public unsafe string fullDateTimePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_fullDateTimePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_fullDateTimePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06002552 RID: 9554 RVA: 0x000C8D44 File Offset: 0x000C6F44
		// (set) Token: 0x06002553 RID: 9555 RVA: 0x0000C9AA File Offset: 0x0000ABAA
		public unsafe Il2CppStringArray abbreviatedDayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedDayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedDayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06002554 RID: 9556 RVA: 0x000C8D74 File Offset: 0x000C6F74
		// (set) Token: 0x06002555 RID: 9557 RVA: 0x0000C9C9 File Offset: 0x0000ABC9
		public unsafe Il2CppStringArray m_superShortDayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_superShortDayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_superShortDayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06002556 RID: 9558 RVA: 0x000C8DA4 File Offset: 0x000C6FA4
		// (set) Token: 0x06002557 RID: 9559 RVA: 0x0000C9E8 File Offset: 0x0000ABE8
		public unsafe Il2CppStringArray dayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06002558 RID: 9560 RVA: 0x000C8DD4 File Offset: 0x000C6FD4
		// (set) Token: 0x06002559 RID: 9561 RVA: 0x0000CA07 File Offset: 0x0000AC07
		public unsafe Il2CppStringArray abbreviatedMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x000C8E04 File Offset: 0x000C7004
		// (set) Token: 0x0600255B RID: 9563 RVA: 0x0000CA26 File Offset: 0x0000AC26
		public unsafe Il2CppStringArray monthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_monthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_monthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x0600255C RID: 9564 RVA: 0x000C8E34 File Offset: 0x000C7034
		// (set) Token: 0x0600255D RID: 9565 RVA: 0x0000CA45 File Offset: 0x0000AC45
		public unsafe Il2CppStringArray genitiveMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_genitiveMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_genitiveMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x000C8E64 File Offset: 0x000C7064
		// (set) Token: 0x0600255F RID: 9567 RVA: 0x0000CA64 File Offset: 0x0000AC64
		public unsafe Il2CppStringArray m_genitiveAbbreviatedMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x000C8E94 File Offset: 0x000C7094
		// (set) Token: 0x06002561 RID: 9569 RVA: 0x0000CA83 File Offset: 0x0000AC83
		public unsafe Il2CppStringArray leapYearMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_leapYearMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_leapYearMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x000C8EC4 File Offset: 0x000C70C4
		// (set) Token: 0x06002563 RID: 9571 RVA: 0x0000CAA2 File Offset: 0x0000ACA2
		public unsafe string longDatePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_longDatePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_longDatePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x000C8EEC File Offset: 0x000C70EC
		// (set) Token: 0x06002565 RID: 9573 RVA: 0x0000CAC1 File Offset: 0x0000ACC1
		public unsafe string shortDatePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_shortDatePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_shortDatePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x000C8F14 File Offset: 0x000C7114
		// (set) Token: 0x06002567 RID: 9575 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		public unsafe string yearMonthPattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_yearMonthPattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_yearMonthPattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x000C8F3C File Offset: 0x000C713C
		// (set) Token: 0x06002569 RID: 9577 RVA: 0x0000CAFF File Offset: 0x0000ACFF
		public unsafe string longTimePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_longTimePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_longTimePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x000C8F64 File Offset: 0x000C7164
		// (set) Token: 0x0600256B RID: 9579 RVA: 0x0000CB1E File Offset: 0x0000AD1E
		public unsafe string shortTimePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_shortTimePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_shortTimePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x000C8F8C File Offset: 0x000C718C
		// (set) Token: 0x0600256D RID: 9581 RVA: 0x0000CB3D File Offset: 0x0000AD3D
		public unsafe Il2CppStringArray allYearMonthPatterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allYearMonthPatterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allYearMonthPatterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x000C8FBC File Offset: 0x000C71BC
		// (set) Token: 0x0600256F RID: 9583 RVA: 0x0000CB5C File Offset: 0x0000AD5C
		public unsafe Il2CppStringArray allShortDatePatterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allShortDatePatterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allShortDatePatterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x000C8FEC File Offset: 0x000C71EC
		// (set) Token: 0x06002571 RID: 9585 RVA: 0x0000CB7B File Offset: 0x0000AD7B
		public unsafe Il2CppStringArray allLongDatePatterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allLongDatePatterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allLongDatePatterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x000C901C File Offset: 0x000C721C
		// (set) Token: 0x06002573 RID: 9587 RVA: 0x0000CB9A File Offset: 0x0000AD9A
		public unsafe Il2CppStringArray allShortTimePatterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allShortTimePatterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allShortTimePatterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x000C904C File Offset: 0x000C724C
		// (set) Token: 0x06002575 RID: 9589 RVA: 0x0000CBB9 File Offset: 0x0000ADB9
		public unsafe Il2CppStringArray allLongTimePatterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allLongTimePatterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allLongTimePatterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x000C907C File Offset: 0x000C727C
		// (set) Token: 0x06002577 RID: 9591 RVA: 0x0000CBD8 File Offset: 0x0000ADD8
		public unsafe Il2CppStringArray m_eraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_eraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_eraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x000C90AC File Offset: 0x000C72AC
		// (set) Token: 0x06002579 RID: 9593 RVA: 0x0000CBF7 File Offset: 0x0000ADF7
		public unsafe Il2CppStringArray m_abbrevEraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x000C90DC File Offset: 0x000C72DC
		// (set) Token: 0x0600257B RID: 9595 RVA: 0x0000CC16 File Offset: 0x0000AE16
		public unsafe Il2CppStringArray m_abbrevEnglishEraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEnglishEraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEnglishEraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x000C910C File Offset: 0x000C730C
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x0000CC35 File Offset: 0x0000AE35
		public unsafe Il2CppStructArray<int> optionalCalendars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_optionalCalendars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_optionalCalendars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x000C913C File Offset: 0x000C733C
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x0000CC54 File Offset: 0x0000AE54
		public unsafe static int DEFAULT_ALL_DATETIMES_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE, (void*)(&value));
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x000C9158 File Offset: 0x000C7358
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x0000CC62 File Offset: 0x0000AE62
		public unsafe bool m_isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_isReadOnly)) = value;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06002582 RID: 9602 RVA: 0x000C9180 File Offset: 0x000C7380
		// (set) Token: 0x06002583 RID: 9603 RVA: 0x0000CC7D File Offset: 0x0000AE7D
		public unsafe DateTimeFormatFlags formatFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_formatFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_formatFlags)) = value;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x000C91A8 File Offset: 0x000C73A8
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x0000CC98 File Offset: 0x0000AE98
		public unsafe static bool preferExistingTokens
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_preferExistingTokens, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_preferExistingTokens, (void*)(&value));
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x000C91C4 File Offset: 0x000C73C4
		// (set) Token: 0x06002587 RID: 9607 RVA: 0x0000CCA6 File Offset: 0x0000AEA6
		public unsafe int CultureID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_CultureID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_CultureID)) = value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x000C91EC File Offset: 0x000C73EC
		// (set) Token: 0x06002589 RID: 9609 RVA: 0x0000CCC1 File Offset: 0x0000AEC1
		public unsafe bool m_useUserOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_useUserOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_useUserOverride)) = value;
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x000C9214 File Offset: 0x000C7414
		// (set) Token: 0x0600258B RID: 9611 RVA: 0x0000CCDC File Offset: 0x0000AEDC
		public unsafe bool bUseCalendarInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_bUseCalendarInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_bUseCalendarInfo)) = value;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x0600258C RID: 9612 RVA: 0x000C923C File Offset: 0x000C743C
		// (set) Token: 0x0600258D RID: 9613 RVA: 0x0000CCF7 File Offset: 0x0000AEF7
		public unsafe int nDataItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_nDataItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_nDataItem)) = value;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x000C9264 File Offset: 0x000C7464
		// (set) Token: 0x0600258F RID: 9615 RVA: 0x0000CD12 File Offset: 0x0000AF12
		public unsafe bool m_isDefaultCalendar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_isDefaultCalendar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_isDefaultCalendar)) = value;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x000C928C File Offset: 0x000C748C
		// (set) Token: 0x06002591 RID: 9617 RVA: 0x0000CD2D File Offset: 0x0000AF2D
		public unsafe static Hashtable s_calendarNativeNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_calendarNativeNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_calendarNativeNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x000C92B4 File Offset: 0x000C74B4
		// (set) Token: 0x06002593 RID: 9619 RVA: 0x0000CD3F File Offset: 0x0000AF3F
		public unsafe Il2CppStringArray m_dateWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_dateWords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_dateWords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x000C92E4 File Offset: 0x000C74E4
		// (set) Token: 0x06002595 RID: 9621 RVA: 0x0000CD5E File Offset: 0x0000AF5E
		public unsafe string m_fullTimeSpanPositivePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_fullTimeSpanPositivePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_fullTimeSpanPositivePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x000C930C File Offset: 0x000C750C
		// (set) Token: 0x06002597 RID: 9623 RVA: 0x0000CD7D File Offset: 0x0000AF7D
		public unsafe string m_fullTimeSpanNegativePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_fullTimeSpanNegativePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_fullTimeSpanNegativePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x000C9334 File Offset: 0x000C7534
		// (set) Token: 0x06002599 RID: 9625 RVA: 0x0000CD9C File Offset: 0x0000AF9C
		public unsafe static DateTimeStyles InvalidDateTimeStyles
		{
			get
			{
				DateTimeStyles dateTimeStyles;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_InvalidDateTimeStyles, (void*)(&dateTimeStyles));
				return dateTimeStyles;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_InvalidDateTimeStyles, (void*)(&value));
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x0600259A RID: 9626 RVA: 0x000C9350 File Offset: 0x000C7550
		// (set) Token: 0x0600259B RID: 9627 RVA: 0x0000CDAA File Offset: 0x0000AFAA
		public unsafe Il2CppReferenceArray<TokenHashValue> m_dtfiTokenHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_dtfiTokenHash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TokenHashValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_dtfiTokenHash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x000C9380 File Offset: 0x000C7580
		// (set) Token: 0x0600259D RID: 9629 RVA: 0x0000CDC9 File Offset: 0x0000AFC9
		public unsafe static int TOKEN_HASH_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_TOKEN_HASH_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_TOKEN_HASH_SIZE, (void*)(&value));
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x000C939C File Offset: 0x000C759C
		// (set) Token: 0x0600259F RID: 9631 RVA: 0x0000CDD7 File Offset: 0x0000AFD7
		public unsafe static int SECOND_PRIME
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_SECOND_PRIME, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_SECOND_PRIME, (void*)(&value));
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x000C93B8 File Offset: 0x000C75B8
		// (set) Token: 0x060025A1 RID: 9633 RVA: 0x0000CDE5 File Offset: 0x0000AFE5
		public unsafe static string dateSeparatorOrTimeZoneOffset
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x000C93D8 File Offset: 0x000C75D8
		// (set) Token: 0x060025A3 RID: 9635 RVA: 0x0000CDF7 File Offset: 0x0000AFF7
		public unsafe static string invariantDateSeparator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantDateSeparator, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantDateSeparator, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x000C93F8 File Offset: 0x000C75F8
		// (set) Token: 0x060025A5 RID: 9637 RVA: 0x0000CE09 File Offset: 0x0000B009
		public unsafe static string invariantTimeSeparator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantTimeSeparator, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantTimeSeparator, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x000C9418 File Offset: 0x000C7618
		// (set) Token: 0x060025A7 RID: 9639 RVA: 0x0000CE1B File Offset: 0x0000B01B
		public unsafe static string IgnorablePeriod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_IgnorablePeriod, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_IgnorablePeriod, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x000C9438 File Offset: 0x000C7638
		// (set) Token: 0x060025A9 RID: 9641 RVA: 0x0000CE2D File Offset: 0x0000B02D
		public unsafe static string IgnorableComma
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_IgnorableComma, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_IgnorableComma, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x000C9458 File Offset: 0x000C7658
		// (set) Token: 0x060025AB RID: 9643 RVA: 0x0000CE3F File Offset: 0x0000B03F
		public unsafe static string CJKYearSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKYearSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKYearSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x000C9478 File Offset: 0x000C7678
		// (set) Token: 0x060025AD RID: 9645 RVA: 0x0000CE51 File Offset: 0x0000B051
		public unsafe static string CJKMonthSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKMonthSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKMonthSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x000C9498 File Offset: 0x000C7698
		// (set) Token: 0x060025AF RID: 9647 RVA: 0x0000CE63 File Offset: 0x0000B063
		public unsafe static string CJKDaySuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKDaySuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKDaySuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x000C94B8 File Offset: 0x000C76B8
		// (set) Token: 0x060025B1 RID: 9649 RVA: 0x0000CE75 File Offset: 0x0000B075
		public unsafe static string KoreanYearSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanYearSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanYearSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x000C94D8 File Offset: 0x000C76D8
		// (set) Token: 0x060025B3 RID: 9651 RVA: 0x0000CE87 File Offset: 0x0000B087
		public unsafe static string KoreanMonthSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMonthSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMonthSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x060025B4 RID: 9652 RVA: 0x000C94F8 File Offset: 0x000C76F8
		// (set) Token: 0x060025B5 RID: 9653 RVA: 0x0000CE99 File Offset: 0x0000B099
		public unsafe static string KoreanDaySuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanDaySuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanDaySuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060025B6 RID: 9654 RVA: 0x000C9518 File Offset: 0x000C7718
		// (set) Token: 0x060025B7 RID: 9655 RVA: 0x0000CEAB File Offset: 0x0000B0AB
		public unsafe static string KoreanHourSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanHourSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanHourSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x000C9538 File Offset: 0x000C7738
		// (set) Token: 0x060025B9 RID: 9657 RVA: 0x0000CEBD File Offset: 0x0000B0BD
		public unsafe static string KoreanMinuteSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMinuteSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMinuteSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x060025BA RID: 9658 RVA: 0x000C9558 File Offset: 0x000C7758
		// (set) Token: 0x060025BB RID: 9659 RVA: 0x0000CECF File Offset: 0x0000B0CF
		public unsafe static string KoreanSecondSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanSecondSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanSecondSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x000C9578 File Offset: 0x000C7778
		// (set) Token: 0x060025BD RID: 9661 RVA: 0x0000CEE1 File Offset: 0x0000B0E1
		public unsafe static string CJKHourSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKHourSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKHourSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x060025BE RID: 9662 RVA: 0x000C9598 File Offset: 0x000C7798
		// (set) Token: 0x060025BF RID: 9663 RVA: 0x0000CEF3 File Offset: 0x0000B0F3
		public unsafe static string ChineseHourSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_ChineseHourSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_ChineseHourSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060025C0 RID: 9664 RVA: 0x000C95B8 File Offset: 0x000C77B8
		// (set) Token: 0x060025C1 RID: 9665 RVA: 0x0000CF05 File Offset: 0x0000B105
		public unsafe static string CJKMinuteSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKMinuteSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKMinuteSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x060025C2 RID: 9666 RVA: 0x000C95D8 File Offset: 0x000C77D8
		// (set) Token: 0x060025C3 RID: 9667 RVA: 0x0000CF17 File Offset: 0x0000B117
		public unsafe static string CJKSecondSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKSecondSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKSecondSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x060025C4 RID: 9668 RVA: 0x000C95F8 File Offset: 0x000C77F8
		// (set) Token: 0x060025C5 RID: 9669 RVA: 0x0000CF29 File Offset: 0x0000B129
		public unsafe static string LocalTimeMark
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_LocalTimeMark, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_LocalTimeMark, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x060025C6 RID: 9670 RVA: 0x000C9618 File Offset: 0x000C7818
		// (set) Token: 0x060025C7 RID: 9671 RVA: 0x0000CF3B File Offset: 0x0000B13B
		public unsafe static string KoreanLangName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanLangName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanLangName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x060025C8 RID: 9672 RVA: 0x000C9638 File Offset: 0x000C7838
		// (set) Token: 0x060025C9 RID: 9673 RVA: 0x0000CF4D File Offset: 0x0000B14D
		public unsafe static string JapaneseLangName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_JapaneseLangName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_JapaneseLangName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x060025CA RID: 9674 RVA: 0x000C9658 File Offset: 0x000C7858
		// (set) Token: 0x060025CB RID: 9675 RVA: 0x0000CF5F File Offset: 0x0000B15F
		public unsafe static string EnglishLangName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_EnglishLangName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_EnglishLangName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x000C9678 File Offset: 0x000C7878
		// (set) Token: 0x060025CD RID: 9677 RVA: 0x0000CF71 File Offset: 0x0000B171
		public unsafe static DateTimeFormatInfo s_jajpDTFI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_jajpDTFI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_jajpDTFI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x000C96A0 File Offset: 0x000C78A0
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x0000CF83 File Offset: 0x0000B183
		public unsafe static DateTimeFormatInfo s_zhtwDTFI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_zhtwDTFI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_zhtwDTFI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020DD RID: 8413
		private static readonly IntPtr NativeFieldInfoPtr_invariantInfo;

		// Token: 0x040020DE RID: 8414
		private static readonly IntPtr NativeFieldInfoPtr_m_cultureData;

		// Token: 0x040020DF RID: 8415
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x040020E0 RID: 8416
		private static readonly IntPtr NativeFieldInfoPtr_m_langName;

		// Token: 0x040020E1 RID: 8417
		private static readonly IntPtr NativeFieldInfoPtr_m_compareInfo;

		// Token: 0x040020E2 RID: 8418
		private static readonly IntPtr NativeFieldInfoPtr_m_cultureInfo;

		// Token: 0x040020E3 RID: 8419
		private static readonly IntPtr NativeFieldInfoPtr_amDesignator;

		// Token: 0x040020E4 RID: 8420
		private static readonly IntPtr NativeFieldInfoPtr_pmDesignator;

		// Token: 0x040020E5 RID: 8421
		private static readonly IntPtr NativeFieldInfoPtr_dateSeparator;

		// Token: 0x040020E6 RID: 8422
		private static readonly IntPtr NativeFieldInfoPtr_generalShortTimePattern;

		// Token: 0x040020E7 RID: 8423
		private static readonly IntPtr NativeFieldInfoPtr_generalLongTimePattern;

		// Token: 0x040020E8 RID: 8424
		private static readonly IntPtr NativeFieldInfoPtr_timeSeparator;

		// Token: 0x040020E9 RID: 8425
		private static readonly IntPtr NativeFieldInfoPtr_monthDayPattern;

		// Token: 0x040020EA RID: 8426
		private static readonly IntPtr NativeFieldInfoPtr_dateTimeOffsetPattern;

		// Token: 0x040020EB RID: 8427
		private static readonly IntPtr NativeFieldInfoPtr_rfc1123Pattern;

		// Token: 0x040020EC RID: 8428
		private static readonly IntPtr NativeFieldInfoPtr_sortableDateTimePattern;

		// Token: 0x040020ED RID: 8429
		private static readonly IntPtr NativeFieldInfoPtr_universalSortableDateTimePattern;

		// Token: 0x040020EE RID: 8430
		private static readonly IntPtr NativeFieldInfoPtr_calendar;

		// Token: 0x040020EF RID: 8431
		private static readonly IntPtr NativeFieldInfoPtr_firstDayOfWeek;

		// Token: 0x040020F0 RID: 8432
		private static readonly IntPtr NativeFieldInfoPtr_calendarWeekRule;

		// Token: 0x040020F1 RID: 8433
		private static readonly IntPtr NativeFieldInfoPtr_fullDateTimePattern;

		// Token: 0x040020F2 RID: 8434
		private static readonly IntPtr NativeFieldInfoPtr_abbreviatedDayNames;

		// Token: 0x040020F3 RID: 8435
		private static readonly IntPtr NativeFieldInfoPtr_m_superShortDayNames;

		// Token: 0x040020F4 RID: 8436
		private static readonly IntPtr NativeFieldInfoPtr_dayNames;

		// Token: 0x040020F5 RID: 8437
		private static readonly IntPtr NativeFieldInfoPtr_abbreviatedMonthNames;

		// Token: 0x040020F6 RID: 8438
		private static readonly IntPtr NativeFieldInfoPtr_monthNames;

		// Token: 0x040020F7 RID: 8439
		private static readonly IntPtr NativeFieldInfoPtr_genitiveMonthNames;

		// Token: 0x040020F8 RID: 8440
		private static readonly IntPtr NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames;

		// Token: 0x040020F9 RID: 8441
		private static readonly IntPtr NativeFieldInfoPtr_leapYearMonthNames;

		// Token: 0x040020FA RID: 8442
		private static readonly IntPtr NativeFieldInfoPtr_longDatePattern;

		// Token: 0x040020FB RID: 8443
		private static readonly IntPtr NativeFieldInfoPtr_shortDatePattern;

		// Token: 0x040020FC RID: 8444
		private static readonly IntPtr NativeFieldInfoPtr_yearMonthPattern;

		// Token: 0x040020FD RID: 8445
		private static readonly IntPtr NativeFieldInfoPtr_longTimePattern;

		// Token: 0x040020FE RID: 8446
		private static readonly IntPtr NativeFieldInfoPtr_shortTimePattern;

		// Token: 0x040020FF RID: 8447
		private static readonly IntPtr NativeFieldInfoPtr_allYearMonthPatterns;

		// Token: 0x04002100 RID: 8448
		private static readonly IntPtr NativeFieldInfoPtr_allShortDatePatterns;

		// Token: 0x04002101 RID: 8449
		private static readonly IntPtr NativeFieldInfoPtr_allLongDatePatterns;

		// Token: 0x04002102 RID: 8450
		private static readonly IntPtr NativeFieldInfoPtr_allShortTimePatterns;

		// Token: 0x04002103 RID: 8451
		private static readonly IntPtr NativeFieldInfoPtr_allLongTimePatterns;

		// Token: 0x04002104 RID: 8452
		private static readonly IntPtr NativeFieldInfoPtr_m_eraNames;

		// Token: 0x04002105 RID: 8453
		private static readonly IntPtr NativeFieldInfoPtr_m_abbrevEraNames;

		// Token: 0x04002106 RID: 8454
		private static readonly IntPtr NativeFieldInfoPtr_m_abbrevEnglishEraNames;

		// Token: 0x04002107 RID: 8455
		private static readonly IntPtr NativeFieldInfoPtr_optionalCalendars;

		// Token: 0x04002108 RID: 8456
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE;

		// Token: 0x04002109 RID: 8457
		private static readonly IntPtr NativeFieldInfoPtr_m_isReadOnly;

		// Token: 0x0400210A RID: 8458
		private static readonly IntPtr NativeFieldInfoPtr_formatFlags;

		// Token: 0x0400210B RID: 8459
		private static readonly IntPtr NativeFieldInfoPtr_preferExistingTokens;

		// Token: 0x0400210C RID: 8460
		private static readonly IntPtr NativeFieldInfoPtr_CultureID;

		// Token: 0x0400210D RID: 8461
		private static readonly IntPtr NativeFieldInfoPtr_m_useUserOverride;

		// Token: 0x0400210E RID: 8462
		private static readonly IntPtr NativeFieldInfoPtr_bUseCalendarInfo;

		// Token: 0x0400210F RID: 8463
		private static readonly IntPtr NativeFieldInfoPtr_nDataItem;

		// Token: 0x04002110 RID: 8464
		private static readonly IntPtr NativeFieldInfoPtr_m_isDefaultCalendar;

		// Token: 0x04002111 RID: 8465
		private static readonly IntPtr NativeFieldInfoPtr_s_calendarNativeNames;

		// Token: 0x04002112 RID: 8466
		private static readonly IntPtr NativeFieldInfoPtr_m_dateWords;

		// Token: 0x04002113 RID: 8467
		private static readonly IntPtr NativeFieldInfoPtr_m_fullTimeSpanPositivePattern;

		// Token: 0x04002114 RID: 8468
		private static readonly IntPtr NativeFieldInfoPtr_m_fullTimeSpanNegativePattern;

		// Token: 0x04002115 RID: 8469
		private static readonly IntPtr NativeFieldInfoPtr_InvalidDateTimeStyles;

		// Token: 0x04002116 RID: 8470
		private static readonly IntPtr NativeFieldInfoPtr_m_dtfiTokenHash;

		// Token: 0x04002117 RID: 8471
		private static readonly IntPtr NativeFieldInfoPtr_TOKEN_HASH_SIZE;

		// Token: 0x04002118 RID: 8472
		private static readonly IntPtr NativeFieldInfoPtr_SECOND_PRIME;

		// Token: 0x04002119 RID: 8473
		private static readonly IntPtr NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset;

		// Token: 0x0400211A RID: 8474
		private static readonly IntPtr NativeFieldInfoPtr_invariantDateSeparator;

		// Token: 0x0400211B RID: 8475
		private static readonly IntPtr NativeFieldInfoPtr_invariantTimeSeparator;

		// Token: 0x0400211C RID: 8476
		private static readonly IntPtr NativeFieldInfoPtr_IgnorablePeriod;

		// Token: 0x0400211D RID: 8477
		private static readonly IntPtr NativeFieldInfoPtr_IgnorableComma;

		// Token: 0x0400211E RID: 8478
		private static readonly IntPtr NativeFieldInfoPtr_CJKYearSuff;

		// Token: 0x0400211F RID: 8479
		private static readonly IntPtr NativeFieldInfoPtr_CJKMonthSuff;

		// Token: 0x04002120 RID: 8480
		private static readonly IntPtr NativeFieldInfoPtr_CJKDaySuff;

		// Token: 0x04002121 RID: 8481
		private static readonly IntPtr NativeFieldInfoPtr_KoreanYearSuff;

		// Token: 0x04002122 RID: 8482
		private static readonly IntPtr NativeFieldInfoPtr_KoreanMonthSuff;

		// Token: 0x04002123 RID: 8483
		private static readonly IntPtr NativeFieldInfoPtr_KoreanDaySuff;

		// Token: 0x04002124 RID: 8484
		private static readonly IntPtr NativeFieldInfoPtr_KoreanHourSuff;

		// Token: 0x04002125 RID: 8485
		private static readonly IntPtr NativeFieldInfoPtr_KoreanMinuteSuff;

		// Token: 0x04002126 RID: 8486
		private static readonly IntPtr NativeFieldInfoPtr_KoreanSecondSuff;

		// Token: 0x04002127 RID: 8487
		private static readonly IntPtr NativeFieldInfoPtr_CJKHourSuff;

		// Token: 0x04002128 RID: 8488
		private static readonly IntPtr NativeFieldInfoPtr_ChineseHourSuff;

		// Token: 0x04002129 RID: 8489
		private static readonly IntPtr NativeFieldInfoPtr_CJKMinuteSuff;

		// Token: 0x0400212A RID: 8490
		private static readonly IntPtr NativeFieldInfoPtr_CJKSecondSuff;

		// Token: 0x0400212B RID: 8491
		private static readonly IntPtr NativeFieldInfoPtr_LocalTimeMark;

		// Token: 0x0400212C RID: 8492
		private static readonly IntPtr NativeFieldInfoPtr_KoreanLangName;

		// Token: 0x0400212D RID: 8493
		private static readonly IntPtr NativeFieldInfoPtr_JapaneseLangName;

		// Token: 0x0400212E RID: 8494
		private static readonly IntPtr NativeFieldInfoPtr_EnglishLangName;

		// Token: 0x0400212F RID: 8495
		private static readonly IntPtr NativeFieldInfoPtr_s_jajpDTFI;

		// Token: 0x04002130 RID: 8496
		private static readonly IntPtr NativeFieldInfoPtr_s_zhtwDTFI;

		// Token: 0x04002131 RID: 8497
		private static readonly IntPtr NativeMethodInfoPtr_InitPreferExistingTokens_Private_Static_Boolean_0;

		// Token: 0x04002132 RID: 8498
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureName_Private_get_String_0;

		// Token: 0x04002133 RID: 8499
		private static readonly IntPtr NativeMethodInfoPtr_get_Culture_Private_get_CultureInfo_0;

		// Token: 0x04002134 RID: 8500
		private static readonly IntPtr NativeMethodInfoPtr_get_LanguageName_Private_get_String_0;

		// Token: 0x04002135 RID: 8501
		private static readonly IntPtr NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNames_Private_Il2CppStringArray_0;

		// Token: 0x04002136 RID: 8502
		private static readonly IntPtr NativeMethodInfoPtr_internalGetDayOfWeekNames_Private_Il2CppStringArray_0;

		// Token: 0x04002137 RID: 8503
		private static readonly IntPtr NativeMethodInfoPtr_internalGetAbbreviatedMonthNames_Private_Il2CppStringArray_0;

		// Token: 0x04002138 RID: 8504
		private static readonly IntPtr NativeMethodInfoPtr_internalGetMonthNames_Private_Il2CppStringArray_0;

		// Token: 0x04002139 RID: 8505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400213A RID: 8506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureData_Calendar_0;

		// Token: 0x0400213B RID: 8507
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOverridableProperties_Private_Void_CultureData_Int32_0;

		// Token: 0x0400213C RID: 8508
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x0400213D RID: 8509
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x0400213E RID: 8510
		private static readonly IntPtr NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_DateTimeFormatInfo_0;

		// Token: 0x0400213F RID: 8511
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_DateTimeFormatInfo_0;

		// Token: 0x04002140 RID: 8512
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Public_Static_DateTimeFormatInfo_IFormatProvider_0;

		// Token: 0x04002141 RID: 8513
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0;

		// Token: 0x04002142 RID: 8514
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04002143 RID: 8515
		private static readonly IntPtr NativeMethodInfoPtr_get_AMDesignator_Public_get_String_0;

		// Token: 0x04002144 RID: 8516
		private static readonly IntPtr NativeMethodInfoPtr_get_Calendar_Public_get_Calendar_0;

		// Token: 0x04002145 RID: 8517
		private static readonly IntPtr NativeMethodInfoPtr_set_Calendar_Public_set_Void_Calendar_0;

		// Token: 0x04002146 RID: 8518
		private static readonly IntPtr NativeMethodInfoPtr_get_OptionalCalendars_Private_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002147 RID: 8519
		private static readonly IntPtr NativeMethodInfoPtr_get_EraNames_Internal_get_Il2CppStringArray_0;

		// Token: 0x04002148 RID: 8520
		private static readonly IntPtr NativeMethodInfoPtr_GetEraName_Public_String_Int32_0;

		// Token: 0x04002149 RID: 8521
		private static readonly IntPtr NativeMethodInfoPtr_get_AbbreviatedEraNames_Internal_get_Il2CppStringArray_0;

		// Token: 0x0400214A RID: 8522
		private static readonly IntPtr NativeMethodInfoPtr_GetAbbreviatedEraName_Public_String_Int32_0;

		// Token: 0x0400214B RID: 8523
		private static readonly IntPtr NativeMethodInfoPtr_get_AbbreviatedEnglishEraNames_Internal_get_Il2CppStringArray_0;

		// Token: 0x0400214C RID: 8524
		private static readonly IntPtr NativeMethodInfoPtr_get_DateSeparator_Public_get_String_0;

		// Token: 0x0400214D RID: 8525
		private static readonly IntPtr NativeMethodInfoPtr_get_FullDateTimePattern_Public_get_String_0;

		// Token: 0x0400214E RID: 8526
		private static readonly IntPtr NativeMethodInfoPtr_get_LongDatePattern_Public_get_String_0;

		// Token: 0x0400214F RID: 8527
		private static readonly IntPtr NativeMethodInfoPtr_set_LongDatePattern_Public_set_Void_String_0;

		// Token: 0x04002150 RID: 8528
		private static readonly IntPtr NativeMethodInfoPtr_get_LongTimePattern_Public_get_String_0;

		// Token: 0x04002151 RID: 8529
		private static readonly IntPtr NativeMethodInfoPtr_set_LongTimePattern_Public_set_Void_String_0;

		// Token: 0x04002152 RID: 8530
		private static readonly IntPtr NativeMethodInfoPtr_get_MonthDayPattern_Public_get_String_0;

		// Token: 0x04002153 RID: 8531
		private static readonly IntPtr NativeMethodInfoPtr_get_PMDesignator_Public_get_String_0;

		// Token: 0x04002154 RID: 8532
		private static readonly IntPtr NativeMethodInfoPtr_get_RFC1123Pattern_Public_get_String_0;

		// Token: 0x04002155 RID: 8533
		private static readonly IntPtr NativeMethodInfoPtr_get_ShortDatePattern_Public_get_String_0;

		// Token: 0x04002156 RID: 8534
		private static readonly IntPtr NativeMethodInfoPtr_set_ShortDatePattern_Public_set_Void_String_0;

		// Token: 0x04002157 RID: 8535
		private static readonly IntPtr NativeMethodInfoPtr_get_ShortTimePattern_Public_get_String_0;

		// Token: 0x04002158 RID: 8536
		private static readonly IntPtr NativeMethodInfoPtr_set_ShortTimePattern_Public_set_Void_String_0;

		// Token: 0x04002159 RID: 8537
		private static readonly IntPtr NativeMethodInfoPtr_get_SortableDateTimePattern_Public_get_String_0;

		// Token: 0x0400215A RID: 8538
		private static readonly IntPtr NativeMethodInfoPtr_get_GeneralShortTimePattern_Internal_get_String_0;

		// Token: 0x0400215B RID: 8539
		private static readonly IntPtr NativeMethodInfoPtr_get_GeneralLongTimePattern_Internal_get_String_0;

		// Token: 0x0400215C RID: 8540
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeOffsetPattern_Internal_get_String_0;

		// Token: 0x0400215D RID: 8541
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSeparator_Public_get_String_0;

		// Token: 0x0400215E RID: 8542
		private static readonly IntPtr NativeMethodInfoPtr_get_UniversalSortableDateTimePattern_Public_get_String_0;

		// Token: 0x0400215F RID: 8543
		private static readonly IntPtr NativeMethodInfoPtr_get_YearMonthPattern_Public_get_String_0;

		// Token: 0x04002160 RID: 8544
		private static readonly IntPtr NativeMethodInfoPtr_set_YearMonthPattern_Public_set_Void_String_0;

		// Token: 0x04002161 RID: 8545
		private static readonly IntPtr NativeMethodInfoPtr_get_AbbreviatedDayNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04002162 RID: 8546
		private static readonly IntPtr NativeMethodInfoPtr_get_DayNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04002163 RID: 8547
		private static readonly IntPtr NativeMethodInfoPtr_get_AbbreviatedMonthNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04002164 RID: 8548
		private static readonly IntPtr NativeMethodInfoPtr_get_MonthNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04002165 RID: 8549
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSpacesInMonthNames_Internal_get_Boolean_0;

		// Token: 0x04002166 RID: 8550
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSpacesInDayNames_Internal_get_Boolean_0;

		// Token: 0x04002167 RID: 8551
		private static readonly IntPtr NativeMethodInfoPtr_internalGetMonthName_Internal_String_Int32_MonthNameStyles_Boolean_0;

		// Token: 0x04002168 RID: 8552
		private static readonly IntPtr NativeMethodInfoPtr_internalGetGenitiveMonthNames_Private_Il2CppStringArray_Boolean_0;

		// Token: 0x04002169 RID: 8553
		private static readonly IntPtr NativeMethodInfoPtr_internalGetLeapYearMonthNames_Internal_Il2CppStringArray_0;

		// Token: 0x0400216A RID: 8554
		private static readonly IntPtr NativeMethodInfoPtr_GetAbbreviatedDayName_Public_String_DayOfWeek_0;

		// Token: 0x0400216B RID: 8555
		private static readonly IntPtr NativeMethodInfoPtr_GetCombinedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0;

		// Token: 0x0400216C RID: 8556
		private static readonly IntPtr NativeMethodInfoPtr_GetAllDateTimePatterns_Public_Il2CppStringArray_Char_0;

		// Token: 0x0400216D RID: 8557
		private static readonly IntPtr NativeMethodInfoPtr_GetDayName_Public_String_DayOfWeek_0;

		// Token: 0x0400216E RID: 8558
		private static readonly IntPtr NativeMethodInfoPtr_GetAbbreviatedMonthName_Public_String_Int32_0;

		// Token: 0x0400216F RID: 8559
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthName_Public_String_Int32_0;

		// Token: 0x04002170 RID: 8560
		private static readonly IntPtr NativeMethodInfoPtr_GetMergedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_String_0;

		// Token: 0x04002171 RID: 8561
		private static readonly IntPtr NativeMethodInfoPtr_get_AllYearMonthPatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x04002172 RID: 8562
		private static readonly IntPtr NativeMethodInfoPtr_get_AllShortDatePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x04002173 RID: 8563
		private static readonly IntPtr NativeMethodInfoPtr_get_AllShortTimePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x04002174 RID: 8564
		private static readonly IntPtr NativeMethodInfoPtr_get_AllLongDatePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x04002175 RID: 8565
		private static readonly IntPtr NativeMethodInfoPtr_get_AllLongTimePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x04002176 RID: 8566
		private static readonly IntPtr NativeMethodInfoPtr_get_UnclonedYearMonthPatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x04002177 RID: 8567
		private static readonly IntPtr NativeMethodInfoPtr_get_UnclonedShortDatePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x04002178 RID: 8568
		private static readonly IntPtr NativeMethodInfoPtr_get_UnclonedLongDatePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x04002179 RID: 8569
		private static readonly IntPtr NativeMethodInfoPtr_get_UnclonedShortTimePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x0400217A RID: 8570
		private static readonly IntPtr NativeMethodInfoPtr_get_UnclonedLongTimePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x0400217B RID: 8571
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

		// Token: 0x0400217C RID: 8572
		private static readonly IntPtr NativeMethodInfoPtr_get_MonthGenitiveNames_Public_get_Il2CppStringArray_0;

		// Token: 0x0400217D RID: 8573
		private static readonly IntPtr NativeMethodInfoPtr_get_FullTimeSpanPositivePattern_Internal_get_String_0;

		// Token: 0x0400217E RID: 8574
		private static readonly IntPtr NativeMethodInfoPtr_get_FullTimeSpanNegativePattern_Internal_get_String_0;

		// Token: 0x0400217F RID: 8575
		private static readonly IntPtr NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0;

		// Token: 0x04002180 RID: 8576
		private static readonly IntPtr NativeMethodInfoPtr_ValidateStyles_Internal_Static_Void_DateTimeStyles_String_0;

		// Token: 0x04002181 RID: 8577
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatFlags_Internal_get_DateTimeFormatFlags_0;

		// Token: 0x04002182 RID: 8578
		private static readonly IntPtr NativeMethodInfoPtr_get_HasForceTwoDigitYears_Internal_get_Boolean_0;

		// Token: 0x04002183 RID: 8579
		private static readonly IntPtr NativeMethodInfoPtr_get_HasYearMonthAdjustment_Internal_get_Boolean_0;

		// Token: 0x04002184 RID: 8580
		private static readonly IntPtr NativeMethodInfoPtr_YearMonthAdjustment_Internal_Boolean_byref_Int32_byref_Int32_Boolean_0;

		// Token: 0x04002185 RID: 8581
		private static readonly IntPtr NativeMethodInfoPtr_GetJapaneseCalendarDTFI_Internal_Static_DateTimeFormatInfo_0;

		// Token: 0x04002186 RID: 8582
		private static readonly IntPtr NativeMethodInfoPtr_GetTaiwanCalendarDTFI_Internal_Static_DateTimeFormatInfo_0;

		// Token: 0x04002187 RID: 8583
		private static readonly IntPtr NativeMethodInfoPtr_ClearTokenHashTable_Private_Void_0;

		// Token: 0x04002188 RID: 8584
		private static readonly IntPtr NativeMethodInfoPtr_CreateTokenHashTable_Internal_Il2CppReferenceArray_1_TokenHashValue_0;

		// Token: 0x04002189 RID: 8585
		private static readonly IntPtr NativeMethodInfoPtr_AddMonthNames_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_0;

		// Token: 0x0400218A RID: 8586
		private static readonly IntPtr NativeMethodInfoPtr_TryParseHebrewNumber_Private_Static_Boolean_byref___DTString_byref_Boolean_byref_Int32_0;

		// Token: 0x0400218B RID: 8587
		private static readonly IntPtr NativeMethodInfoPtr_IsHebrewChar_Private_Static_Boolean_Char_0;

		// Token: 0x0400218C RID: 8588
		private static readonly IntPtr NativeMethodInfoPtr_Tokenize_Internal_Boolean_TokenType_byref_TokenType_byref_Int32_byref___DTString_0;

		// Token: 0x0400218D RID: 8589
		private static readonly IntPtr NativeMethodInfoPtr_InsertAtCurrentHashNode_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_Char_TokenType_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400218E RID: 8590
		private static readonly IntPtr NativeMethodInfoPtr_InsertHash_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_TokenType_Int32_0;
	}
}
