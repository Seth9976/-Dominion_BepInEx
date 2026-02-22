using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000248 RID: 584
	public class CultureData : Object
	{
		// Token: 0x060027D1 RID: 10193 RVA: 0x000D1FB0 File Offset: 0x000D01B0
		// Note: this type is marked as 'beforefieldinit'.
		static CultureData()
		{
			Il2CppClassPointerStore<CultureData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CultureData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureData>.NativeClassPtr);
			CultureData.NativeFieldInfoPtr_sAM1159 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sAM1159");
			CultureData.NativeFieldInfoPtr_sPM2359 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sPM2359");
			CultureData.NativeFieldInfoPtr_sTimeSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sTimeSeparator");
			CultureData.NativeFieldInfoPtr_saLongTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "saLongTimes");
			CultureData.NativeFieldInfoPtr_saShortTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "saShortTimes");
			CultureData.NativeFieldInfoPtr_iFirstDayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iFirstDayOfWeek");
			CultureData.NativeFieldInfoPtr_iFirstWeekOfYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iFirstWeekOfYear");
			CultureData.NativeFieldInfoPtr_waCalendars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "waCalendars");
			CultureData.NativeFieldInfoPtr_calendars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "calendars");
			CultureData.NativeFieldInfoPtr_sISO639Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sISO639Language");
			CultureData.NativeFieldInfoPtr_sRealName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sRealName");
			CultureData.NativeFieldInfoPtr_bUseOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "bUseOverrides");
			CultureData.NativeFieldInfoPtr_calendarId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "calendarId");
			CultureData.NativeFieldInfoPtr_numberIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "numberIndex");
			CultureData.NativeFieldInfoPtr_iDefaultAnsiCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultAnsiCodePage");
			CultureData.NativeFieldInfoPtr_iDefaultOemCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultOemCodePage");
			CultureData.NativeFieldInfoPtr_iDefaultMacCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultMacCodePage");
			CultureData.NativeFieldInfoPtr_iDefaultEbcdicCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultEbcdicCodePage");
			CultureData.NativeFieldInfoPtr_isRightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "isRightToLeft");
			CultureData.NativeFieldInfoPtr_sListSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sListSeparator");
			CultureData.NativeFieldInfoPtr_s_Invariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "s_Invariant");
			CultureData.NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669751);
			CultureData.NativeMethodInfoPtr_get_Invariant_Public_Static_get_CultureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669752);
			CultureData.NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669753);
			CultureData.NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669754);
			CultureData.NativeMethodInfoPtr_GetCultureData_Internal_Static_CultureData_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669755);
			CultureData.NativeMethodInfoPtr_fill_culture_data_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669756);
			CultureData.NativeMethodInfoPtr_GetCalendar_Public_CalendarData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669757);
			CultureData.NativeMethodInfoPtr_get_LongTimes_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669758);
			CultureData.NativeMethodInfoPtr_get_ShortTimes_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669759);
			CultureData.NativeMethodInfoPtr_get_SISO639LANGNAME_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669760);
			CultureData.NativeMethodInfoPtr_get_IFIRSTDAYOFWEEK_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669761);
			CultureData.NativeMethodInfoPtr_get_IFIRSTWEEKOFYEAR_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669762);
			CultureData.NativeMethodInfoPtr_get_SAM1159_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669763);
			CultureData.NativeMethodInfoPtr_get_SPM2359_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669764);
			CultureData.NativeMethodInfoPtr_get_TimeSeparator_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669765);
			CultureData.NativeMethodInfoPtr_get_CalendarIds_Internal_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669766);
			CultureData.NativeMethodInfoPtr_get_IsInvariantCulture_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669767);
			CultureData.NativeMethodInfoPtr_get_CultureName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669768);
			CultureData.NativeMethodInfoPtr_get_SCOMPAREINFO_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669769);
			CultureData.NativeMethodInfoPtr_get_STEXTINFO_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669770);
			CultureData.NativeMethodInfoPtr_get_ILANGUAGE_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669771);
			CultureData.NativeMethodInfoPtr_get_UseUserOverride_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669772);
			CultureData.NativeMethodInfoPtr_EraNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669773);
			CultureData.NativeMethodInfoPtr_AbbrevEraNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669774);
			CultureData.NativeMethodInfoPtr_AbbreviatedEnglishEraNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669775);
			CultureData.NativeMethodInfoPtr_ShortDates_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669776);
			CultureData.NativeMethodInfoPtr_LongDates_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669777);
			CultureData.NativeMethodInfoPtr_YearMonths_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669778);
			CultureData.NativeMethodInfoPtr_DayNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669779);
			CultureData.NativeMethodInfoPtr_AbbreviatedDayNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669780);
			CultureData.NativeMethodInfoPtr_MonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669781);
			CultureData.NativeMethodInfoPtr_GenitiveMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669782);
			CultureData.NativeMethodInfoPtr_AbbreviatedMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669783);
			CultureData.NativeMethodInfoPtr_AbbreviatedGenitiveMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669784);
			CultureData.NativeMethodInfoPtr_LeapYearMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669785);
			CultureData.NativeMethodInfoPtr_MonthDay_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669786);
			CultureData.NativeMethodInfoPtr_DateSeparator_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669787);
			CultureData.NativeMethodInfoPtr_GetDateSeparator_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669788);
			CultureData.NativeMethodInfoPtr_GetSeparator_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669789);
			CultureData.NativeMethodInfoPtr_IndexOfTimePart_Private_Static_Int32_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669790);
			CultureData.NativeMethodInfoPtr_UnescapeNlsString_Private_Static_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669791);
			CultureData.NativeMethodInfoPtr_ReescapeWin32Strings_Internal_Static_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669792);
			CultureData.NativeMethodInfoPtr_ReescapeWin32String_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669793);
			CultureData.NativeMethodInfoPtr_GetNFIValues_Internal_Void_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669794);
			CultureData.NativeMethodInfoPtr_fill_number_data_Private_Static_Void_NumberFormatInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100669795);
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x000D2508 File Offset: 0x000D0708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328221, XrefRangeEnd = 328222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureData(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr__ctor_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x060027D3 RID: 10195 RVA: 0x000D2554 File Offset: 0x000D0754
		public unsafe static CultureData Invariant
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 328280, RefRangeEnd = 328284, XrefRangeStart = 328222, XrefRangeEnd = 328280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_Invariant_Public_Static_get_CultureData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr3) : null;
			}
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x000D2588 File Offset: 0x000D0788
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 328289, RefRangeEnd = 328292, XrefRangeStart = 328284, XrefRangeEnd = 328289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureData GetCultureData(string cultureName, bool useUserOverride)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr3) : null;
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x000D25DC File Offset: 0x000D07DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 328300, RefRangeEnd = 328304, XrefRangeStart = 328292, XrefRangeEnd = 328300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref datetimeIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numberIndex;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(iso2lang);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ansiCodePage;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oemCodePage;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref macCodePage;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ebcdicCodePage;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightToLeft;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(listSeparator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr3) : null;
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x000D26C8 File Offset: 0x000D08C8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureData GetCultureData(int culture, bool bUseUserOverride)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bUseUserOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetCultureData_Internal_Static_CultureData_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr3) : null;
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x000D2718 File Offset: 0x000D0918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328304, XrefRangeEnd = 328305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void fill_culture_data(int datetimeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref datetimeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_fill_culture_data_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x000D2758 File Offset: 0x000D0958
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 328313, RefRangeEnd = 328330, XrefRangeStart = 328305, XrefRangeEnd = 328313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CalendarData GetCalendar(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetCalendar_Public_CalendarData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CalendarData>(intPtr3) : null;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060027D9 RID: 10201 RVA: 0x000D27A4 File Offset: 0x000D09A4
		public unsafe Il2CppStringArray LongTimes
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 24994, RefRangeEnd = 25005, XrefRangeStart = 24994, XrefRangeEnd = 25005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_LongTimes_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x000D27E4 File Offset: 0x000D09E4
		public unsafe Il2CppStringArray ShortTimes
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 24944, RefRangeEnd = 24957, XrefRangeStart = 24944, XrefRangeEnd = 24957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_ShortTimes_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x000D2824 File Offset: 0x000D0A24
		public unsafe string SISO639LANGNAME
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_SISO639LANGNAME_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x000D285C File Offset: 0x000D0A5C
		public unsafe int IFIRSTDAYOFWEEK
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_IFIRSTDAYOFWEEK_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x000D2898 File Offset: 0x000D0A98
		public unsafe int IFIRSTWEEKOFYEAR
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_IFIRSTWEEKOFYEAR_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x060027DE RID: 10206 RVA: 0x000D28D4 File Offset: 0x000D0AD4
		public unsafe string SAM1159
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_SAM1159_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x000D290C File Offset: 0x000D0B0C
		public unsafe string SPM2359
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_SPM2359_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x000D2944 File Offset: 0x000D0B44
		public unsafe string TimeSeparator
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_TimeSeparator_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x000D297C File Offset: 0x000D0B7C
		public unsafe Il2CppStructArray<int> CalendarIds
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 328340, RefRangeEnd = 328342, XrefRangeStart = 328330, XrefRangeEnd = 328340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_CalendarIds_Internal_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x000D29BC File Offset: 0x000D0BBC
		public unsafe bool IsInvariantCulture
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 328343, RefRangeEnd = 328346, XrefRangeStart = 328342, XrefRangeEnd = 328343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_IsInvariantCulture_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x060027E3 RID: 10211 RVA: 0x000D29F8 File Offset: 0x000D0BF8
		public unsafe string CultureName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_CultureName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x000D2A30 File Offset: 0x000D0C30
		public unsafe string SCOMPAREINFO
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 328348, RefRangeEnd = 328349, XrefRangeStart = 328346, XrefRangeEnd = 328348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_SCOMPAREINFO_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x060027E5 RID: 10213 RVA: 0x000D2A68 File Offset: 0x000D0C68
		public unsafe string STEXTINFO
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_STEXTINFO_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x000D2AA0 File Offset: 0x000D0CA0
		public unsafe int ILANGUAGE
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_ILANGUAGE_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x060027E7 RID: 10215 RVA: 0x000D2ADC File Offset: 0x000D0CDC
		public unsafe bool UseUserOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_UseUserOverride_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x000D2B18 File Offset: 0x000D0D18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328350, RefRangeEnd = 328352, XrefRangeStart = 328349, XrefRangeEnd = 328350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray EraNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_EraNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x000D2B64 File Offset: 0x000D0D64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328353, RefRangeEnd = 328355, XrefRangeStart = 328352, XrefRangeEnd = 328353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray AbbrevEraNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_AbbrevEraNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x000D2BB0 File Offset: 0x000D0DB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 328356, RefRangeEnd = 328359, XrefRangeStart = 328355, XrefRangeEnd = 328356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray AbbreviatedEnglishEraNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_AbbreviatedEnglishEraNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x000D2BFC File Offset: 0x000D0DFC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 328360, RefRangeEnd = 328366, XrefRangeStart = 328359, XrefRangeEnd = 328360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray ShortDates(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_ShortDates_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x000D2C48 File Offset: 0x000D0E48
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 328367, RefRangeEnd = 328373, XrefRangeStart = 328366, XrefRangeEnd = 328367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray LongDates(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_LongDates_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x000D2C94 File Offset: 0x000D0E94
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 328374, RefRangeEnd = 328380, XrefRangeStart = 328373, XrefRangeEnd = 328374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray YearMonths(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_YearMonths_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x000D2CE0 File Offset: 0x000D0EE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 328381, RefRangeEnd = 328384, XrefRangeStart = 328380, XrefRangeEnd = 328381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray DayNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_DayNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x000D2D2C File Offset: 0x000D0F2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 328385, RefRangeEnd = 328388, XrefRangeStart = 328384, XrefRangeEnd = 328385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray AbbreviatedDayNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_AbbreviatedDayNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x000D2D78 File Offset: 0x000D0F78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328389, RefRangeEnd = 328391, XrefRangeStart = 328388, XrefRangeEnd = 328389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray MonthNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_MonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x000D2DC4 File Offset: 0x000D0FC4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 328392, RefRangeEnd = 328397, XrefRangeStart = 328391, XrefRangeEnd = 328392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GenitiveMonthNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GenitiveMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x000D2E10 File Offset: 0x000D1010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328398, RefRangeEnd = 328400, XrefRangeStart = 328397, XrefRangeEnd = 328398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray AbbreviatedMonthNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_AbbreviatedMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x000D2E5C File Offset: 0x000D105C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328401, RefRangeEnd = 328403, XrefRangeStart = 328400, XrefRangeEnd = 328401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray AbbreviatedGenitiveMonthNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_AbbreviatedGenitiveMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x000D2EA8 File Offset: 0x000D10A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 328404, RefRangeEnd = 328407, XrefRangeStart = 328403, XrefRangeEnd = 328404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray LeapYearMonthNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_LeapYearMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x000D2EF4 File Offset: 0x000D10F4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 328408, RefRangeEnd = 328414, XrefRangeStart = 328407, XrefRangeEnd = 328408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string MonthDay(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_MonthDay_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x000D2F38 File Offset: 0x000D1138
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 328421, RefRangeEnd = 328424, XrefRangeStart = 328414, XrefRangeEnd = 328421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DateSeparator(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_DateSeparator_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x000D2F7C File Offset: 0x000D117C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328424, XrefRangeEnd = 328427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDateSeparator(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetDateSeparator_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x000D2FB8 File Offset: 0x000D11B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328443, RefRangeEnd = 328445, XrefRangeStart = 328427, XrefRangeEnd = 328443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSeparator(string format, string timeParts)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(timeParts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetSeparator_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x000D3008 File Offset: 0x000D1208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328445, XrefRangeEnd = 328451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOfTimePart(string format, int startIndex, string timeParts)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(timeParts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_IndexOfTimePart_Private_Static_Int32_String_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x000D306C File Offset: 0x000D126C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328465, RefRangeEnd = 328466, XrefRangeStart = 328451, XrefRangeEnd = 328465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnescapeNlsString(string str, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_UnescapeNlsString_Private_Static_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x000D30C4 File Offset: 0x000D12C4
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ReescapeWin32Strings(Il2CppStringArray array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_ReescapeWin32Strings_Internal_Static_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x000D3108 File Offset: 0x000D1308
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReescapeWin32String(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_ReescapeWin32String_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x000D3144 File Offset: 0x000D1344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328468, RefRangeEnd = 328469, XrefRangeStart = 328466, XrefRangeEnd = 328468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetNFIValues(NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nfi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetNFIValues_Internal_Void_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x000D3188 File Offset: 0x000D1388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328469, XrefRangeEnd = 328470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void fill_number_data(NumberFormatInfo nfi, int numberIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numberIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_fill_number_data_Private_Static_Void_NumberFormatInfo_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x0000DA98 File Offset: 0x0000BC98
		public CultureData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x000D31CC File Offset: 0x000D13CC
		// (set) Token: 0x06002801 RID: 10241 RVA: 0x0000DAA1 File Offset: 0x0000BCA1
		public unsafe string sAM1159
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sAM1159);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sAM1159), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x000D31F4 File Offset: 0x000D13F4
		// (set) Token: 0x06002803 RID: 10243 RVA: 0x0000DAC0 File Offset: 0x0000BCC0
		public unsafe string sPM2359
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sPM2359);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sPM2359), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06002804 RID: 10244 RVA: 0x000D321C File Offset: 0x000D141C
		// (set) Token: 0x06002805 RID: 10245 RVA: 0x0000DADF File Offset: 0x0000BCDF
		public unsafe string sTimeSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sTimeSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sTimeSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06002806 RID: 10246 RVA: 0x000D3244 File Offset: 0x000D1444
		// (set) Token: 0x06002807 RID: 10247 RVA: 0x0000DAFE File Offset: 0x0000BCFE
		public unsafe Il2CppStringArray saLongTimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_saLongTimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_saLongTimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06002808 RID: 10248 RVA: 0x000D3274 File Offset: 0x000D1474
		// (set) Token: 0x06002809 RID: 10249 RVA: 0x0000DB1D File Offset: 0x0000BD1D
		public unsafe Il2CppStringArray saShortTimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_saShortTimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_saShortTimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x0600280A RID: 10250 RVA: 0x000D32A4 File Offset: 0x000D14A4
		// (set) Token: 0x0600280B RID: 10251 RVA: 0x0000DB3C File Offset: 0x0000BD3C
		public unsafe int iFirstDayOfWeek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iFirstDayOfWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iFirstDayOfWeek)) = value;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x0600280C RID: 10252 RVA: 0x000D32CC File Offset: 0x000D14CC
		// (set) Token: 0x0600280D RID: 10253 RVA: 0x0000DB57 File Offset: 0x0000BD57
		public unsafe int iFirstWeekOfYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iFirstWeekOfYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iFirstWeekOfYear)) = value;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x0600280E RID: 10254 RVA: 0x000D32F4 File Offset: 0x000D14F4
		// (set) Token: 0x0600280F RID: 10255 RVA: 0x0000DB72 File Offset: 0x0000BD72
		public unsafe Il2CppStructArray<int> waCalendars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_waCalendars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_waCalendars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06002810 RID: 10256 RVA: 0x000D3324 File Offset: 0x000D1524
		// (set) Token: 0x06002811 RID: 10257 RVA: 0x0000DB91 File Offset: 0x0000BD91
		public unsafe Il2CppReferenceArray<CalendarData> calendars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_calendars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CalendarData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_calendars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06002812 RID: 10258 RVA: 0x000D3354 File Offset: 0x000D1554
		// (set) Token: 0x06002813 RID: 10259 RVA: 0x0000DBB0 File Offset: 0x0000BDB0
		public unsafe string sISO639Language
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sISO639Language);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sISO639Language), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06002814 RID: 10260 RVA: 0x000D337C File Offset: 0x000D157C
		// (set) Token: 0x06002815 RID: 10261 RVA: 0x0000DBCF File Offset: 0x0000BDCF
		public unsafe string sRealName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sRealName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sRealName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06002816 RID: 10262 RVA: 0x000D33A4 File Offset: 0x000D15A4
		// (set) Token: 0x06002817 RID: 10263 RVA: 0x0000DBEE File Offset: 0x0000BDEE
		public unsafe bool bUseOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_bUseOverrides);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_bUseOverrides)) = value;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x000D33CC File Offset: 0x000D15CC
		// (set) Token: 0x06002819 RID: 10265 RVA: 0x0000DC09 File Offset: 0x0000BE09
		public unsafe int calendarId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_calendarId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_calendarId)) = value;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x0600281A RID: 10266 RVA: 0x000D33F4 File Offset: 0x000D15F4
		// (set) Token: 0x0600281B RID: 10267 RVA: 0x0000DC24 File Offset: 0x0000BE24
		public unsafe int numberIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_numberIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_numberIndex)) = value;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x0600281C RID: 10268 RVA: 0x000D341C File Offset: 0x000D161C
		// (set) Token: 0x0600281D RID: 10269 RVA: 0x0000DC3F File Offset: 0x0000BE3F
		public unsafe int iDefaultAnsiCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultAnsiCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultAnsiCodePage)) = value;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x0600281E RID: 10270 RVA: 0x000D3444 File Offset: 0x000D1644
		// (set) Token: 0x0600281F RID: 10271 RVA: 0x0000DC5A File Offset: 0x0000BE5A
		public unsafe int iDefaultOemCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultOemCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultOemCodePage)) = value;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002820 RID: 10272 RVA: 0x000D346C File Offset: 0x000D166C
		// (set) Token: 0x06002821 RID: 10273 RVA: 0x0000DC75 File Offset: 0x0000BE75
		public unsafe int iDefaultMacCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultMacCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultMacCodePage)) = value;
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06002822 RID: 10274 RVA: 0x000D3494 File Offset: 0x000D1694
		// (set) Token: 0x06002823 RID: 10275 RVA: 0x0000DC90 File Offset: 0x0000BE90
		public unsafe int iDefaultEbcdicCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultEbcdicCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultEbcdicCodePage)) = value;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002824 RID: 10276 RVA: 0x000D34BC File Offset: 0x000D16BC
		// (set) Token: 0x06002825 RID: 10277 RVA: 0x0000DCAB File Offset: 0x0000BEAB
		public unsafe bool isRightToLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_isRightToLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_isRightToLeft)) = value;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06002826 RID: 10278 RVA: 0x000D34E4 File Offset: 0x000D16E4
		// (set) Token: 0x06002827 RID: 10279 RVA: 0x0000DCC6 File Offset: 0x0000BEC6
		public unsafe string sListSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sListSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sListSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06002828 RID: 10280 RVA: 0x000D350C File Offset: 0x000D170C
		// (set) Token: 0x06002829 RID: 10281 RVA: 0x0000DCE5 File Offset: 0x0000BEE5
		public unsafe static CultureData s_Invariant
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureData.NativeFieldInfoPtr_s_Invariant, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureData.NativeFieldInfoPtr_s_Invariant, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002374 RID: 9076
		private static readonly IntPtr NativeFieldInfoPtr_sAM1159;

		// Token: 0x04002375 RID: 9077
		private static readonly IntPtr NativeFieldInfoPtr_sPM2359;

		// Token: 0x04002376 RID: 9078
		private static readonly IntPtr NativeFieldInfoPtr_sTimeSeparator;

		// Token: 0x04002377 RID: 9079
		private static readonly IntPtr NativeFieldInfoPtr_saLongTimes;

		// Token: 0x04002378 RID: 9080
		private static readonly IntPtr NativeFieldInfoPtr_saShortTimes;

		// Token: 0x04002379 RID: 9081
		private static readonly IntPtr NativeFieldInfoPtr_iFirstDayOfWeek;

		// Token: 0x0400237A RID: 9082
		private static readonly IntPtr NativeFieldInfoPtr_iFirstWeekOfYear;

		// Token: 0x0400237B RID: 9083
		private static readonly IntPtr NativeFieldInfoPtr_waCalendars;

		// Token: 0x0400237C RID: 9084
		private static readonly IntPtr NativeFieldInfoPtr_calendars;

		// Token: 0x0400237D RID: 9085
		private static readonly IntPtr NativeFieldInfoPtr_sISO639Language;

		// Token: 0x0400237E RID: 9086
		private static readonly IntPtr NativeFieldInfoPtr_sRealName;

		// Token: 0x0400237F RID: 9087
		private static readonly IntPtr NativeFieldInfoPtr_bUseOverrides;

		// Token: 0x04002380 RID: 9088
		private static readonly IntPtr NativeFieldInfoPtr_calendarId;

		// Token: 0x04002381 RID: 9089
		private static readonly IntPtr NativeFieldInfoPtr_numberIndex;

		// Token: 0x04002382 RID: 9090
		private static readonly IntPtr NativeFieldInfoPtr_iDefaultAnsiCodePage;

		// Token: 0x04002383 RID: 9091
		private static readonly IntPtr NativeFieldInfoPtr_iDefaultOemCodePage;

		// Token: 0x04002384 RID: 9092
		private static readonly IntPtr NativeFieldInfoPtr_iDefaultMacCodePage;

		// Token: 0x04002385 RID: 9093
		private static readonly IntPtr NativeFieldInfoPtr_iDefaultEbcdicCodePage;

		// Token: 0x04002386 RID: 9094
		private static readonly IntPtr NativeFieldInfoPtr_isRightToLeft;

		// Token: 0x04002387 RID: 9095
		private static readonly IntPtr NativeFieldInfoPtr_sListSeparator;

		// Token: 0x04002388 RID: 9096
		private static readonly IntPtr NativeFieldInfoPtr_s_Invariant;

		// Token: 0x04002389 RID: 9097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;

		// Token: 0x0400238A RID: 9098
		private static readonly IntPtr NativeMethodInfoPtr_get_Invariant_Public_Static_get_CultureData_0;

		// Token: 0x0400238B RID: 9099
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_0;

		// Token: 0x0400238C RID: 9100
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String_0;

		// Token: 0x0400238D RID: 9101
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureData_Internal_Static_CultureData_Int32_Boolean_0;

		// Token: 0x0400238E RID: 9102
		private static readonly IntPtr NativeMethodInfoPtr_fill_culture_data_Private_Void_Int32_0;

		// Token: 0x0400238F RID: 9103
		private static readonly IntPtr NativeMethodInfoPtr_GetCalendar_Public_CalendarData_Int32_0;

		// Token: 0x04002390 RID: 9104
		private static readonly IntPtr NativeMethodInfoPtr_get_LongTimes_Internal_get_Il2CppStringArray_0;

		// Token: 0x04002391 RID: 9105
		private static readonly IntPtr NativeMethodInfoPtr_get_ShortTimes_Internal_get_Il2CppStringArray_0;

		// Token: 0x04002392 RID: 9106
		private static readonly IntPtr NativeMethodInfoPtr_get_SISO639LANGNAME_Internal_get_String_0;

		// Token: 0x04002393 RID: 9107
		private static readonly IntPtr NativeMethodInfoPtr_get_IFIRSTDAYOFWEEK_Internal_get_Int32_0;

		// Token: 0x04002394 RID: 9108
		private static readonly IntPtr NativeMethodInfoPtr_get_IFIRSTWEEKOFYEAR_Internal_get_Int32_0;

		// Token: 0x04002395 RID: 9109
		private static readonly IntPtr NativeMethodInfoPtr_get_SAM1159_Internal_get_String_0;

		// Token: 0x04002396 RID: 9110
		private static readonly IntPtr NativeMethodInfoPtr_get_SPM2359_Internal_get_String_0;

		// Token: 0x04002397 RID: 9111
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSeparator_Internal_get_String_0;

		// Token: 0x04002398 RID: 9112
		private static readonly IntPtr NativeMethodInfoPtr_get_CalendarIds_Internal_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002399 RID: 9113
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInvariantCulture_Internal_get_Boolean_0;

		// Token: 0x0400239A RID: 9114
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureName_Internal_get_String_0;

		// Token: 0x0400239B RID: 9115
		private static readonly IntPtr NativeMethodInfoPtr_get_SCOMPAREINFO_Internal_get_String_0;

		// Token: 0x0400239C RID: 9116
		private static readonly IntPtr NativeMethodInfoPtr_get_STEXTINFO_Internal_get_String_0;

		// Token: 0x0400239D RID: 9117
		private static readonly IntPtr NativeMethodInfoPtr_get_ILANGUAGE_Internal_get_Int32_0;

		// Token: 0x0400239E RID: 9118
		private static readonly IntPtr NativeMethodInfoPtr_get_UseUserOverride_Internal_get_Boolean_0;

		// Token: 0x0400239F RID: 9119
		private static readonly IntPtr NativeMethodInfoPtr_EraNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x040023A0 RID: 9120
		private static readonly IntPtr NativeMethodInfoPtr_AbbrevEraNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x040023A1 RID: 9121
		private static readonly IntPtr NativeMethodInfoPtr_AbbreviatedEnglishEraNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x040023A2 RID: 9122
		private static readonly IntPtr NativeMethodInfoPtr_ShortDates_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x040023A3 RID: 9123
		private static readonly IntPtr NativeMethodInfoPtr_LongDates_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x040023A4 RID: 9124
		private static readonly IntPtr NativeMethodInfoPtr_YearMonths_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x040023A5 RID: 9125
		private static readonly IntPtr NativeMethodInfoPtr_DayNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x040023A6 RID: 9126
		private static readonly IntPtr NativeMethodInfoPtr_AbbreviatedDayNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x040023A7 RID: 9127
		private static readonly IntPtr NativeMethodInfoPtr_MonthNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x040023A8 RID: 9128
		private static readonly IntPtr NativeMethodInfoPtr_GenitiveMonthNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x040023A9 RID: 9129
		private static readonly IntPtr NativeMethodInfoPtr_AbbreviatedMonthNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x040023AA RID: 9130
		private static readonly IntPtr NativeMethodInfoPtr_AbbreviatedGenitiveMonthNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x040023AB RID: 9131
		private static readonly IntPtr NativeMethodInfoPtr_LeapYearMonthNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x040023AC RID: 9132
		private static readonly IntPtr NativeMethodInfoPtr_MonthDay_Internal_String_Int32_0;

		// Token: 0x040023AD RID: 9133
		private static readonly IntPtr NativeMethodInfoPtr_DateSeparator_Internal_String_Int32_0;

		// Token: 0x040023AE RID: 9134
		private static readonly IntPtr NativeMethodInfoPtr_GetDateSeparator_Private_Static_String_String_0;

		// Token: 0x040023AF RID: 9135
		private static readonly IntPtr NativeMethodInfoPtr_GetSeparator_Private_Static_String_String_String_0;

		// Token: 0x040023B0 RID: 9136
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfTimePart_Private_Static_Int32_String_Int32_String_0;

		// Token: 0x040023B1 RID: 9137
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeNlsString_Private_Static_String_String_Int32_Int32_0;

		// Token: 0x040023B2 RID: 9138
		private static readonly IntPtr NativeMethodInfoPtr_ReescapeWin32Strings_Internal_Static_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x040023B3 RID: 9139
		private static readonly IntPtr NativeMethodInfoPtr_ReescapeWin32String_Internal_Static_String_String_0;

		// Token: 0x040023B4 RID: 9140
		private static readonly IntPtr NativeMethodInfoPtr_GetNFIValues_Internal_Void_NumberFormatInfo_0;

		// Token: 0x040023B5 RID: 9141
		private static readonly IntPtr NativeMethodInfoPtr_fill_number_data_Private_Static_Void_NumberFormatInfo_Int32_0;
	}
}
