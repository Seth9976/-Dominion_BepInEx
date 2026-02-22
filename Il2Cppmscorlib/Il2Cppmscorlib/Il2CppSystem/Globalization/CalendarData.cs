using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000228 RID: 552
	public class CalendarData : Object
	{
		// Token: 0x0600242D RID: 9261 RVA: 0x000C3FD8 File Offset: 0x000C21D8
		// Note: this type is marked as 'beforefieldinit'.
		static CalendarData()
		{
			Il2CppClassPointerStore<CalendarData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CalendarData");
			CalendarData.NativeFieldInfoPtr_MAX_CALENDARS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "MAX_CALENDARS");
			CalendarData.NativeFieldInfoPtr_sNativeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "sNativeName");
			CalendarData.NativeFieldInfoPtr_saShortDates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saShortDates");
			CalendarData.NativeFieldInfoPtr_saYearMonths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saYearMonths");
			CalendarData.NativeFieldInfoPtr_saLongDates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saLongDates");
			CalendarData.NativeFieldInfoPtr_sMonthDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "sMonthDay");
			CalendarData.NativeFieldInfoPtr_saEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saEraNames");
			CalendarData.NativeFieldInfoPtr_saAbbrevEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saAbbrevEraNames");
			CalendarData.NativeFieldInfoPtr_saAbbrevEnglishEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saAbbrevEnglishEraNames");
			CalendarData.NativeFieldInfoPtr_saDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saDayNames");
			CalendarData.NativeFieldInfoPtr_saAbbrevDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saAbbrevDayNames");
			CalendarData.NativeFieldInfoPtr_saSuperShortDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saSuperShortDayNames");
			CalendarData.NativeFieldInfoPtr_saMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saMonthNames");
			CalendarData.NativeFieldInfoPtr_saAbbrevMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saAbbrevMonthNames");
			CalendarData.NativeFieldInfoPtr_saMonthGenitiveNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saMonthGenitiveNames");
			CalendarData.NativeFieldInfoPtr_saAbbrevMonthGenitiveNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saAbbrevMonthGenitiveNames");
			CalendarData.NativeFieldInfoPtr_saLeapYearMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saLeapYearMonthNames");
			CalendarData.NativeFieldInfoPtr_iTwoDigitYearMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "iTwoDigitYearMax");
			CalendarData.NativeFieldInfoPtr_iCurrentEra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "iCurrentEra");
			CalendarData.NativeFieldInfoPtr_bUseUserOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "bUseUserOverrides");
			CalendarData.NativeFieldInfoPtr_Invariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "Invariant");
			CalendarData.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669310);
			CalendarData.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669312);
			CalendarData.NativeMethodInfoPtr_InitializeEraNames_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669313);
			CalendarData.NativeMethodInfoPtr_InitializeAbbreviatedEraNames_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669314);
			CalendarData.NativeMethodInfoPtr_GetCalendarData_Internal_Static_CalendarData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669315);
			CalendarData.NativeMethodInfoPtr_CalendarIdToCultureName_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669316);
			CalendarData.NativeMethodInfoPtr_nativeGetTwoDigitYearMax_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669317);
			CalendarData.NativeMethodInfoPtr_nativeGetCalendarData_Private_Static_Boolean_CalendarData_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669318);
			CalendarData.NativeMethodInfoPtr_fill_calendar_data_Private_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100669319);
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x000C4258 File Offset: 0x000C2458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324766, XrefRangeEnd = 324767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CalendarData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalendarData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x000C4294 File Offset: 0x000C2494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324840, RefRangeEnd = 324841, XrefRangeStart = 324767, XrefRangeEnd = 324840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CalendarData(string localeName, int calendarId, bool bUseUserOverrides)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalendarData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bUseUserOverrides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x000C42FC File Offset: 0x000C24FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324863, RefRangeEnd = 324864, XrefRangeStart = 324841, XrefRangeEnd = 324863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeEraNames(string localeName, int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_InitializeEraNames_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x000C434C File Offset: 0x000C254C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324871, RefRangeEnd = 324872, XrefRangeStart = 324864, XrefRangeEnd = 324871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeAbbreviatedEraNames(string localeName, int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_InitializeAbbreviatedEraNames_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x000C439C File Offset: 0x000C259C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324872, XrefRangeEnd = 324910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CalendarData GetCalendarData(int calendarId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_GetCalendarData_Internal_Static_CalendarData_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CalendarData>(intPtr3) : null;
			}
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x000C43DC File Offset: 0x000C25DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324910, XrefRangeEnd = 324921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CalendarIdToCultureName(int calendarId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_CalendarIdToCultureName_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x000C4414 File Offset: 0x000C2614
		[CallerCount(0)]
		public unsafe static int nativeGetTwoDigitYearMax(int calID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_nativeGetTwoDigitYearMax_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x000C4454 File Offset: 0x000C2654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324921, XrefRangeEnd = 324924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_nativeGetCalendarData_Private_Static_Boolean_CalendarData_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x000C44B8 File Offset: 0x000C26B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324924, XrefRangeEnd = 324925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool fill_calendar_data(string localeName, int datetimeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref datetimeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_fill_calendar_data_Private_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x0000C2C9 File Offset: 0x0000A4C9
		public CalendarData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x000C4514 File Offset: 0x000C2714
		// (set) Token: 0x06002439 RID: 9273 RVA: 0x0000C2D2 File Offset: 0x0000A4D2
		public unsafe static int MAX_CALENDARS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CalendarData.NativeFieldInfoPtr_MAX_CALENDARS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CalendarData.NativeFieldInfoPtr_MAX_CALENDARS, (void*)(&value));
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x000C4530 File Offset: 0x000C2730
		// (set) Token: 0x0600243B RID: 9275 RVA: 0x0000C2E0 File Offset: 0x0000A4E0
		public unsafe string sNativeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_sNativeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_sNativeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x0600243C RID: 9276 RVA: 0x000C4558 File Offset: 0x000C2758
		// (set) Token: 0x0600243D RID: 9277 RVA: 0x0000C2FF File Offset: 0x0000A4FF
		public unsafe Il2CppStringArray saShortDates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saShortDates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saShortDates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x0600243E RID: 9278 RVA: 0x000C4588 File Offset: 0x000C2788
		// (set) Token: 0x0600243F RID: 9279 RVA: 0x0000C31E File Offset: 0x0000A51E
		public unsafe Il2CppStringArray saYearMonths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saYearMonths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saYearMonths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x000C45B8 File Offset: 0x000C27B8
		// (set) Token: 0x06002441 RID: 9281 RVA: 0x0000C33D File Offset: 0x0000A53D
		public unsafe Il2CppStringArray saLongDates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saLongDates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saLongDates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x000C45E8 File Offset: 0x000C27E8
		// (set) Token: 0x06002443 RID: 9283 RVA: 0x0000C35C File Offset: 0x0000A55C
		public unsafe string sMonthDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_sMonthDay);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_sMonthDay), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x000C4610 File Offset: 0x000C2810
		// (set) Token: 0x06002445 RID: 9285 RVA: 0x0000C37B File Offset: 0x0000A57B
		public unsafe Il2CppStringArray saEraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saEraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saEraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06002446 RID: 9286 RVA: 0x000C4640 File Offset: 0x000C2840
		// (set) Token: 0x06002447 RID: 9287 RVA: 0x0000C39A File Offset: 0x0000A59A
		public unsafe Il2CppStringArray saAbbrevEraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevEraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevEraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x000C4670 File Offset: 0x000C2870
		// (set) Token: 0x06002449 RID: 9289 RVA: 0x0000C3B9 File Offset: 0x0000A5B9
		public unsafe Il2CppStringArray saAbbrevEnglishEraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevEnglishEraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevEnglishEraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x000C46A0 File Offset: 0x000C28A0
		// (set) Token: 0x0600244B RID: 9291 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		public unsafe Il2CppStringArray saDayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saDayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saDayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x000C46D0 File Offset: 0x000C28D0
		// (set) Token: 0x0600244D RID: 9293 RVA: 0x0000C3F7 File Offset: 0x0000A5F7
		public unsafe Il2CppStringArray saAbbrevDayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevDayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevDayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x0600244E RID: 9294 RVA: 0x000C4700 File Offset: 0x000C2900
		// (set) Token: 0x0600244F RID: 9295 RVA: 0x0000C416 File Offset: 0x0000A616
		public unsafe Il2CppStringArray saSuperShortDayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saSuperShortDayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saSuperShortDayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06002450 RID: 9296 RVA: 0x000C4730 File Offset: 0x000C2930
		// (set) Token: 0x06002451 RID: 9297 RVA: 0x0000C435 File Offset: 0x0000A635
		public unsafe Il2CppStringArray saMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x000C4760 File Offset: 0x000C2960
		// (set) Token: 0x06002453 RID: 9299 RVA: 0x0000C454 File Offset: 0x0000A654
		public unsafe Il2CppStringArray saAbbrevMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06002454 RID: 9300 RVA: 0x000C4790 File Offset: 0x000C2990
		// (set) Token: 0x06002455 RID: 9301 RVA: 0x0000C473 File Offset: 0x0000A673
		public unsafe Il2CppStringArray saMonthGenitiveNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saMonthGenitiveNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saMonthGenitiveNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06002456 RID: 9302 RVA: 0x000C47C0 File Offset: 0x000C29C0
		// (set) Token: 0x06002457 RID: 9303 RVA: 0x0000C492 File Offset: 0x0000A692
		public unsafe Il2CppStringArray saAbbrevMonthGenitiveNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevMonthGenitiveNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevMonthGenitiveNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06002458 RID: 9304 RVA: 0x000C47F0 File Offset: 0x000C29F0
		// (set) Token: 0x06002459 RID: 9305 RVA: 0x0000C4B1 File Offset: 0x0000A6B1
		public unsafe Il2CppStringArray saLeapYearMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saLeapYearMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saLeapYearMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x000C4820 File Offset: 0x000C2A20
		// (set) Token: 0x0600245B RID: 9307 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
		public unsafe int iTwoDigitYearMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_iTwoDigitYearMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_iTwoDigitYearMax)) = value;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x000C4848 File Offset: 0x000C2A48
		// (set) Token: 0x0600245D RID: 9309 RVA: 0x0000C4EB File Offset: 0x0000A6EB
		public unsafe int iCurrentEra
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_iCurrentEra);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_iCurrentEra)) = value;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x000C4870 File Offset: 0x000C2A70
		// (set) Token: 0x0600245F RID: 9311 RVA: 0x0000C506 File Offset: 0x0000A706
		public unsafe bool bUseUserOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_bUseUserOverrides);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_bUseUserOverrides)) = value;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x000C4898 File Offset: 0x000C2A98
		// (set) Token: 0x06002461 RID: 9313 RVA: 0x0000C521 File Offset: 0x0000A721
		public unsafe static CalendarData Invariant
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CalendarData.NativeFieldInfoPtr_Invariant, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CalendarData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CalendarData.NativeFieldInfoPtr_Invariant, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002058 RID: 8280
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CALENDARS;

		// Token: 0x04002059 RID: 8281
		private static readonly IntPtr NativeFieldInfoPtr_sNativeName;

		// Token: 0x0400205A RID: 8282
		private static readonly IntPtr NativeFieldInfoPtr_saShortDates;

		// Token: 0x0400205B RID: 8283
		private static readonly IntPtr NativeFieldInfoPtr_saYearMonths;

		// Token: 0x0400205C RID: 8284
		private static readonly IntPtr NativeFieldInfoPtr_saLongDates;

		// Token: 0x0400205D RID: 8285
		private static readonly IntPtr NativeFieldInfoPtr_sMonthDay;

		// Token: 0x0400205E RID: 8286
		private static readonly IntPtr NativeFieldInfoPtr_saEraNames;

		// Token: 0x0400205F RID: 8287
		private static readonly IntPtr NativeFieldInfoPtr_saAbbrevEraNames;

		// Token: 0x04002060 RID: 8288
		private static readonly IntPtr NativeFieldInfoPtr_saAbbrevEnglishEraNames;

		// Token: 0x04002061 RID: 8289
		private static readonly IntPtr NativeFieldInfoPtr_saDayNames;

		// Token: 0x04002062 RID: 8290
		private static readonly IntPtr NativeFieldInfoPtr_saAbbrevDayNames;

		// Token: 0x04002063 RID: 8291
		private static readonly IntPtr NativeFieldInfoPtr_saSuperShortDayNames;

		// Token: 0x04002064 RID: 8292
		private static readonly IntPtr NativeFieldInfoPtr_saMonthNames;

		// Token: 0x04002065 RID: 8293
		private static readonly IntPtr NativeFieldInfoPtr_saAbbrevMonthNames;

		// Token: 0x04002066 RID: 8294
		private static readonly IntPtr NativeFieldInfoPtr_saMonthGenitiveNames;

		// Token: 0x04002067 RID: 8295
		private static readonly IntPtr NativeFieldInfoPtr_saAbbrevMonthGenitiveNames;

		// Token: 0x04002068 RID: 8296
		private static readonly IntPtr NativeFieldInfoPtr_saLeapYearMonthNames;

		// Token: 0x04002069 RID: 8297
		private static readonly IntPtr NativeFieldInfoPtr_iTwoDigitYearMax;

		// Token: 0x0400206A RID: 8298
		private static readonly IntPtr NativeFieldInfoPtr_iCurrentEra;

		// Token: 0x0400206B RID: 8299
		private static readonly IntPtr NativeFieldInfoPtr_bUseUserOverrides;

		// Token: 0x0400206C RID: 8300
		private static readonly IntPtr NativeFieldInfoPtr_Invariant;

		// Token: 0x0400206D RID: 8301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400206E RID: 8302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Boolean_0;

		// Token: 0x0400206F RID: 8303
		private static readonly IntPtr NativeMethodInfoPtr_InitializeEraNames_Private_Void_String_Int32_0;

		// Token: 0x04002070 RID: 8304
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAbbreviatedEraNames_Private_Void_String_Int32_0;

		// Token: 0x04002071 RID: 8305
		private static readonly IntPtr NativeMethodInfoPtr_GetCalendarData_Internal_Static_CalendarData_Int32_0;

		// Token: 0x04002072 RID: 8306
		private static readonly IntPtr NativeMethodInfoPtr_CalendarIdToCultureName_Private_Static_String_Int32_0;

		// Token: 0x04002073 RID: 8307
		private static readonly IntPtr NativeMethodInfoPtr_nativeGetTwoDigitYearMax_Public_Static_Int32_Int32_0;

		// Token: 0x04002074 RID: 8308
		private static readonly IntPtr NativeMethodInfoPtr_nativeGetCalendarData_Private_Static_Boolean_CalendarData_String_Int32_0;

		// Token: 0x04002075 RID: 8309
		private static readonly IntPtr NativeMethodInfoPtr_fill_calendar_data_Private_Boolean_String_Int32_0;
	}
}
