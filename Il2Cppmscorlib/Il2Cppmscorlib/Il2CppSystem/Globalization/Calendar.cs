using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000227 RID: 551
	[Serializable]
	public class Calendar : Object
	{
		// Token: 0x060023BB RID: 9147 RVA: 0x000C2B40 File Offset: 0x000C0D40
		// Note: this type is marked as 'beforefieldinit'.
		static Calendar()
		{
			Il2CppClassPointerStore<Calendar>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "Calendar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Calendar>.NativeClassPtr);
			Calendar.NativeFieldInfoPtr_TicksPerMillisecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "TicksPerMillisecond");
			Calendar.NativeFieldInfoPtr_TicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "TicksPerSecond");
			Calendar.NativeFieldInfoPtr_TicksPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "TicksPerMinute");
			Calendar.NativeFieldInfoPtr_TicksPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "TicksPerHour");
			Calendar.NativeFieldInfoPtr_TicksPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "TicksPerDay");
			Calendar.NativeFieldInfoPtr_MillisPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "MillisPerSecond");
			Calendar.NativeFieldInfoPtr_MillisPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "MillisPerMinute");
			Calendar.NativeFieldInfoPtr_MillisPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "MillisPerHour");
			Calendar.NativeFieldInfoPtr_MillisPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "MillisPerDay");
			Calendar.NativeFieldInfoPtr_DaysPerYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "DaysPerYear");
			Calendar.NativeFieldInfoPtr_DaysPer4Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "DaysPer4Years");
			Calendar.NativeFieldInfoPtr_DaysPer100Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "DaysPer100Years");
			Calendar.NativeFieldInfoPtr_DaysPer400Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "DaysPer400Years");
			Calendar.NativeFieldInfoPtr_DaysTo10000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "DaysTo10000");
			Calendar.NativeFieldInfoPtr_MaxMillis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "MaxMillis");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_US = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN_US");
			Calendar.NativeFieldInfoPtr_CAL_JAPAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_JAPAN");
			Calendar.NativeFieldInfoPtr_CAL_TAIWAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_TAIWAN");
			Calendar.NativeFieldInfoPtr_CAL_KOREA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_KOREA");
			Calendar.NativeFieldInfoPtr_CAL_HIJRI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_HIJRI");
			Calendar.NativeFieldInfoPtr_CAL_THAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_THAI");
			Calendar.NativeFieldInfoPtr_CAL_HEBREW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_HEBREW");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ME_FRENCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN_ME_FRENCH");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ARABIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN_ARABIC");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_ENGLISH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN_XLIT_ENGLISH");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_FRENCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN_XLIT_FRENCH");
			Calendar.NativeFieldInfoPtr_CAL_JULIAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_JULIAN");
			Calendar.NativeFieldInfoPtr_CAL_JAPANESELUNISOLAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_JAPANESELUNISOLAR");
			Calendar.NativeFieldInfoPtr_CAL_CHINESELUNISOLAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_CHINESELUNISOLAR");
			Calendar.NativeFieldInfoPtr_CAL_SAKA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_SAKA");
			Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_CHN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_LUNAR_ETO_CHN");
			Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_KOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_LUNAR_ETO_KOR");
			Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_ROKUYOU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_LUNAR_ETO_ROKUYOU");
			Calendar.NativeFieldInfoPtr_CAL_KOREANLUNISOLAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_KOREANLUNISOLAR");
			Calendar.NativeFieldInfoPtr_CAL_TAIWANLUNISOLAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_TAIWANLUNISOLAR");
			Calendar.NativeFieldInfoPtr_CAL_PERSIAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_PERSIAN");
			Calendar.NativeFieldInfoPtr_CAL_UMALQURA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_UMALQURA");
			Calendar.NativeFieldInfoPtr_m_currentEraValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "m_currentEraValue");
			Calendar.NativeFieldInfoPtr_m_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "m_isReadOnly");
			Calendar.NativeFieldInfoPtr_CurrentEra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CurrentEra");
			Calendar.NativeFieldInfoPtr_twoDigitYearMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "twoDigitYearMax");
			Calendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669282);
			Calendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669283);
			Calendar.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669284);
			Calendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669285);
			Calendar.NativeMethodInfoPtr_get_BaseCalendarID_Internal_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669286);
			Calendar.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669287);
			Calendar.NativeMethodInfoPtr_SetReadOnlyState_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669288);
			Calendar.NativeMethodInfoPtr_get_CurrentEraValue_Internal_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669289);
			Calendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Abstract_Virtual_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669290);
			Calendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Abstract_Virtual_New_DayOfWeek_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669291);
			Calendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Abstract_Virtual_New_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669292);
			Calendar.NativeMethodInfoPtr_GetDaysInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669293);
			Calendar.NativeMethodInfoPtr_GetEra_Public_Abstract_Virtual_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669294);
			Calendar.NativeMethodInfoPtr_get_Eras_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669295);
			Calendar.NativeMethodInfoPtr_GetMonth_Public_Abstract_Virtual_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669296);
			Calendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669297);
			Calendar.NativeMethodInfoPtr_GetYear_Public_Abstract_Virtual_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669298);
			Calendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669299);
			Calendar.NativeMethodInfoPtr_IsLeapYear_Public_Abstract_Virtual_New_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669300);
			Calendar.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669301);
			Calendar.NativeMethodInfoPtr_TryToDateTime_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669302);
			Calendar.NativeMethodInfoPtr_IsValidYear_Internal_Virtual_New_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669303);
			Calendar.NativeMethodInfoPtr_IsValidMonth_Internal_Virtual_New_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669304);
			Calendar.NativeMethodInfoPtr_IsValidDay_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669305);
			Calendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669306);
			Calendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669307);
			Calendar.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669308);
			Calendar.NativeMethodInfoPtr_GetSystemTwoDigitYearSetting_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100669309);
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x000C30E8 File Offset: 0x000C12E8
		public unsafe virtual DateTime MinSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324682, XrefRangeEnd = 324686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x000C3130 File Offset: 0x000C1330
		public unsafe virtual DateTime MaxSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324686, XrefRangeEnd = 324690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x000C3178 File Offset: 0x000C1378
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 324691, RefRangeEnd = 324699, XrefRangeStart = 324690, XrefRangeEnd = 324691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Calendar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Calendar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Calendar.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060023BF RID: 9151 RVA: 0x000C31B4 File Offset: 0x000C13B4
		public unsafe virtual int ID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060023C0 RID: 9152 RVA: 0x000C31FC File Offset: 0x000C13FC
		public unsafe virtual int BaseCalendarID
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14894, RefRangeEnd = 14910, XrefRangeStart = 14894, XrefRangeEnd = 14910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_BaseCalendarID_Internal_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x000C3244 File Offset: 0x000C1444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324699, XrefRangeEnd = 324702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x000C3290 File Offset: 0x000C1490
		[CallerCount(0)]
		public unsafe void SetReadOnlyState(bool readOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Calendar.NativeMethodInfoPtr_SetReadOnlyState_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x000C32D0 File Offset: 0x000C14D0
		public unsafe virtual int CurrentEraValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324702, XrefRangeEnd = 324743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_CurrentEraValue_Internal_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x000C3318 File Offset: 0x000C1518
		[CallerCount(0)]
		public unsafe virtual int GetDayOfMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Abstract_Virtual_New_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x000C336C File Offset: 0x000C156C
		[CallerCount(0)]
		public unsafe virtual DayOfWeek GetDayOfWeek(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Abstract_Virtual_New_DayOfWeek_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x000C33C0 File Offset: 0x000C15C0
		[CallerCount(0)]
		public unsafe virtual int GetDaysInMonth(int year, int month, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Abstract_Virtual_New_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x000C3430 File Offset: 0x000C1630
		[CallerCount(0)]
		public unsafe virtual int GetDaysInYear(int year, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetDaysInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x000C3494 File Offset: 0x000C1694
		[CallerCount(0)]
		public unsafe virtual int GetEra(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetEra_Public_Abstract_Virtual_New_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060023C9 RID: 9161 RVA: 0x000C34E8 File Offset: 0x000C16E8
		public unsafe virtual Il2CppStructArray<int> Eras
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_Eras_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x000C3534 File Offset: 0x000C1734
		[CallerCount(0)]
		public unsafe virtual int GetMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetMonth_Public_Abstract_Virtual_New_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x000C3588 File Offset: 0x000C1788
		[CallerCount(0)]
		public unsafe virtual int GetMonthsInYear(int year, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x000C35EC File Offset: 0x000C17EC
		[CallerCount(0)]
		public unsafe virtual int GetYear(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetYear_Public_Abstract_Virtual_New_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x000C3640 File Offset: 0x000C1840
		[CallerCount(0)]
		public unsafe virtual bool IsLeapYear(int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x000C3694 File Offset: 0x000C1894
		[CallerCount(0)]
		public unsafe virtual bool IsLeapYear(int year, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_IsLeapYear_Public_Abstract_Virtual_New_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x000C36F8 File Offset: 0x000C18F8
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x000C37B0 File Offset: 0x000C19B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324743, XrefRangeEnd = 324748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_TryToDateTime_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x000C3878 File Offset: 0x000C1A78
		[CallerCount(0)]
		public unsafe virtual bool IsValidYear(int year, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_IsValidYear_Internal_Virtual_New_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x000C38DC File Offset: 0x000C1ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324748, XrefRangeEnd = 324749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValidMonth(int year, int month, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_IsValidMonth_Internal_Virtual_New_Boolean_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x000C394C File Offset: 0x000C1B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324749, XrefRangeEnd = 324750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValidDay(int year, int month, int day, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_IsValidDay_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060023D4 RID: 9172 RVA: 0x000C39CC File Offset: 0x000C1BCC
		public unsafe virtual int TwoDigitYearMax
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x000C3A14 File Offset: 0x000C1C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324750, RefRangeEnd = 324751, XrefRangeStart = 324750, XrefRangeEnd = 324750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ToFourDigitYear(int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x000C3A68 File Offset: 0x000C1C68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324755, RefRangeEnd = 324757, XrefRangeStart = 324751, XrefRangeEnd = 324755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long TimeToTicks(int hour, int minute, int second, int millisecond)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hour;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Calendar.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x000C3AD0 File Offset: 0x000C1CD0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 324760, RefRangeEnd = 324766, XrefRangeStart = 324757, XrefRangeEnd = 324760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref CalID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultYearValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Calendar.NativeMethodInfoPtr_GetSystemTwoDigitYearSetting_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x0000C04D File Offset: 0x0000A24D
		public Calendar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060023D9 RID: 9177 RVA: 0x000C3B1C File Offset: 0x000C1D1C
		// (set) Token: 0x060023DA RID: 9178 RVA: 0x0000C056 File Offset: 0x0000A256
		public unsafe static long TicksPerMillisecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&value));
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060023DB RID: 9179 RVA: 0x000C3B38 File Offset: 0x000C1D38
		// (set) Token: 0x060023DC RID: 9180 RVA: 0x0000C064 File Offset: 0x0000A264
		public unsafe static long TicksPerSecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_TicksPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_TicksPerSecond, (void*)(&value));
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060023DD RID: 9181 RVA: 0x000C3B54 File Offset: 0x000C1D54
		// (set) Token: 0x060023DE RID: 9182 RVA: 0x0000C072 File Offset: 0x0000A272
		public unsafe static long TicksPerMinute
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_TicksPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_TicksPerMinute, (void*)(&value));
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060023DF RID: 9183 RVA: 0x000C3B70 File Offset: 0x000C1D70
		// (set) Token: 0x060023E0 RID: 9184 RVA: 0x0000C080 File Offset: 0x0000A280
		public unsafe static long TicksPerHour
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_TicksPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_TicksPerHour, (void*)(&value));
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060023E1 RID: 9185 RVA: 0x000C3B8C File Offset: 0x000C1D8C
		// (set) Token: 0x060023E2 RID: 9186 RVA: 0x0000C08E File Offset: 0x0000A28E
		public unsafe static long TicksPerDay
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_TicksPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_TicksPerDay, (void*)(&value));
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060023E3 RID: 9187 RVA: 0x000C3BA8 File Offset: 0x000C1DA8
		// (set) Token: 0x060023E4 RID: 9188 RVA: 0x0000C09C File Offset: 0x0000A29C
		public unsafe static int MillisPerSecond
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_MillisPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_MillisPerSecond, (void*)(&value));
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060023E5 RID: 9189 RVA: 0x000C3BC4 File Offset: 0x000C1DC4
		// (set) Token: 0x060023E6 RID: 9190 RVA: 0x0000C0AA File Offset: 0x0000A2AA
		public unsafe static int MillisPerMinute
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_MillisPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_MillisPerMinute, (void*)(&value));
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060023E7 RID: 9191 RVA: 0x000C3BE0 File Offset: 0x000C1DE0
		// (set) Token: 0x060023E8 RID: 9192 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
		public unsafe static int MillisPerHour
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_MillisPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_MillisPerHour, (void*)(&value));
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060023E9 RID: 9193 RVA: 0x000C3BFC File Offset: 0x000C1DFC
		// (set) Token: 0x060023EA RID: 9194 RVA: 0x0000C0C6 File Offset: 0x0000A2C6
		public unsafe static int MillisPerDay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_MillisPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_MillisPerDay, (void*)(&value));
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x000C3C18 File Offset: 0x000C1E18
		// (set) Token: 0x060023EC RID: 9196 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
		public unsafe static int DaysPerYear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_DaysPerYear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_DaysPerYear, (void*)(&value));
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060023ED RID: 9197 RVA: 0x000C3C34 File Offset: 0x000C1E34
		// (set) Token: 0x060023EE RID: 9198 RVA: 0x0000C0E2 File Offset: 0x0000A2E2
		public unsafe static int DaysPer4Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_DaysPer4Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_DaysPer4Years, (void*)(&value));
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x000C3C50 File Offset: 0x000C1E50
		// (set) Token: 0x060023F0 RID: 9200 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		public unsafe static int DaysPer100Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_DaysPer100Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_DaysPer100Years, (void*)(&value));
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x000C3C6C File Offset: 0x000C1E6C
		// (set) Token: 0x060023F2 RID: 9202 RVA: 0x0000C0FE File Offset: 0x0000A2FE
		public unsafe static int DaysPer400Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_DaysPer400Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_DaysPer400Years, (void*)(&value));
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x000C3C88 File Offset: 0x000C1E88
		// (set) Token: 0x060023F4 RID: 9204 RVA: 0x0000C10C File Offset: 0x0000A30C
		public unsafe static int DaysTo10000
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_DaysTo10000, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_DaysTo10000, (void*)(&value));
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x000C3CA4 File Offset: 0x000C1EA4
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x0000C11A File Offset: 0x0000A31A
		public unsafe static long MaxMillis
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_MaxMillis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_MaxMillis, (void*)(&value));
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x000C3CC0 File Offset: 0x000C1EC0
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x0000C128 File Offset: 0x0000A328
		public unsafe static int CAL_GREGORIAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN, (void*)(&value));
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x000C3CDC File Offset: 0x000C1EDC
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x0000C136 File Offset: 0x0000A336
		public unsafe static int CAL_GREGORIAN_US
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_US, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_US, (void*)(&value));
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x000C3CF8 File Offset: 0x000C1EF8
		// (set) Token: 0x060023FC RID: 9212 RVA: 0x0000C144 File Offset: 0x0000A344
		public unsafe static int CAL_JAPAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_JAPAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_JAPAN, (void*)(&value));
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060023FD RID: 9213 RVA: 0x000C3D14 File Offset: 0x000C1F14
		// (set) Token: 0x060023FE RID: 9214 RVA: 0x0000C152 File Offset: 0x0000A352
		public unsafe static int CAL_TAIWAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_TAIWAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_TAIWAN, (void*)(&value));
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x000C3D30 File Offset: 0x000C1F30
		// (set) Token: 0x06002400 RID: 9216 RVA: 0x0000C160 File Offset: 0x0000A360
		public unsafe static int CAL_KOREA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_KOREA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_KOREA, (void*)(&value));
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x000C3D4C File Offset: 0x000C1F4C
		// (set) Token: 0x06002402 RID: 9218 RVA: 0x0000C16E File Offset: 0x0000A36E
		public unsafe static int CAL_HIJRI
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_HIJRI, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_HIJRI, (void*)(&value));
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x000C3D68 File Offset: 0x000C1F68
		// (set) Token: 0x06002404 RID: 9220 RVA: 0x0000C17C File Offset: 0x0000A37C
		public unsafe static int CAL_THAI
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_THAI, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_THAI, (void*)(&value));
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x000C3D84 File Offset: 0x000C1F84
		// (set) Token: 0x06002406 RID: 9222 RVA: 0x0000C18A File Offset: 0x0000A38A
		public unsafe static int CAL_HEBREW
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_HEBREW, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_HEBREW, (void*)(&value));
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x000C3DA0 File Offset: 0x000C1FA0
		// (set) Token: 0x06002408 RID: 9224 RVA: 0x0000C198 File Offset: 0x0000A398
		public unsafe static int CAL_GREGORIAN_ME_FRENCH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ME_FRENCH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ME_FRENCH, (void*)(&value));
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x000C3DBC File Offset: 0x000C1FBC
		// (set) Token: 0x0600240A RID: 9226 RVA: 0x0000C1A6 File Offset: 0x0000A3A6
		public unsafe static int CAL_GREGORIAN_ARABIC
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ARABIC, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ARABIC, (void*)(&value));
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x000C3DD8 File Offset: 0x000C1FD8
		// (set) Token: 0x0600240C RID: 9228 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
		public unsafe static int CAL_GREGORIAN_XLIT_ENGLISH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_ENGLISH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_ENGLISH, (void*)(&value));
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x000C3DF4 File Offset: 0x000C1FF4
		// (set) Token: 0x0600240E RID: 9230 RVA: 0x0000C1C2 File Offset: 0x0000A3C2
		public unsafe static int CAL_GREGORIAN_XLIT_FRENCH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_FRENCH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_FRENCH, (void*)(&value));
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x000C3E10 File Offset: 0x000C2010
		// (set) Token: 0x06002410 RID: 9232 RVA: 0x0000C1D0 File Offset: 0x0000A3D0
		public unsafe static int CAL_JULIAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_JULIAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_JULIAN, (void*)(&value));
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x000C3E2C File Offset: 0x000C202C
		// (set) Token: 0x06002412 RID: 9234 RVA: 0x0000C1DE File Offset: 0x0000A3DE
		public unsafe static int CAL_JAPANESELUNISOLAR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_JAPANESELUNISOLAR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_JAPANESELUNISOLAR, (void*)(&value));
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x000C3E48 File Offset: 0x000C2048
		// (set) Token: 0x06002414 RID: 9236 RVA: 0x0000C1EC File Offset: 0x0000A3EC
		public unsafe static int CAL_CHINESELUNISOLAR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_CHINESELUNISOLAR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_CHINESELUNISOLAR, (void*)(&value));
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x000C3E64 File Offset: 0x000C2064
		// (set) Token: 0x06002416 RID: 9238 RVA: 0x0000C1FA File Offset: 0x0000A3FA
		public unsafe static int CAL_SAKA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_SAKA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_SAKA, (void*)(&value));
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x000C3E80 File Offset: 0x000C2080
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x0000C208 File Offset: 0x0000A408
		public unsafe static int CAL_LUNAR_ETO_CHN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_CHN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_CHN, (void*)(&value));
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x000C3E9C File Offset: 0x000C209C
		// (set) Token: 0x0600241A RID: 9242 RVA: 0x0000C216 File Offset: 0x0000A416
		public unsafe static int CAL_LUNAR_ETO_KOR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_KOR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_KOR, (void*)(&value));
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x0600241B RID: 9243 RVA: 0x000C3EB8 File Offset: 0x000C20B8
		// (set) Token: 0x0600241C RID: 9244 RVA: 0x0000C224 File Offset: 0x0000A424
		public unsafe static int CAL_LUNAR_ETO_ROKUYOU
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_ROKUYOU, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_ROKUYOU, (void*)(&value));
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x000C3ED4 File Offset: 0x000C20D4
		// (set) Token: 0x0600241E RID: 9246 RVA: 0x0000C232 File Offset: 0x0000A432
		public unsafe static int CAL_KOREANLUNISOLAR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_KOREANLUNISOLAR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_KOREANLUNISOLAR, (void*)(&value));
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x000C3EF0 File Offset: 0x000C20F0
		// (set) Token: 0x06002420 RID: 9248 RVA: 0x0000C240 File Offset: 0x0000A440
		public unsafe static int CAL_TAIWANLUNISOLAR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_TAIWANLUNISOLAR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_TAIWANLUNISOLAR, (void*)(&value));
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002421 RID: 9249 RVA: 0x000C3F0C File Offset: 0x000C210C
		// (set) Token: 0x06002422 RID: 9250 RVA: 0x0000C24E File Offset: 0x0000A44E
		public unsafe static int CAL_PERSIAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_PERSIAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_PERSIAN, (void*)(&value));
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x000C3F28 File Offset: 0x000C2128
		// (set) Token: 0x06002424 RID: 9252 RVA: 0x0000C25C File Offset: 0x0000A45C
		public unsafe static int CAL_UMALQURA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_UMALQURA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_UMALQURA, (void*)(&value));
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x000C3F44 File Offset: 0x000C2144
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x0000C26A File Offset: 0x0000A46A
		public unsafe int m_currentEraValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_m_currentEraValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_m_currentEraValue)) = value;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x000C3F6C File Offset: 0x000C216C
		// (set) Token: 0x06002428 RID: 9256 RVA: 0x0000C285 File Offset: 0x0000A485
		public unsafe bool m_isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_m_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_m_isReadOnly)) = value;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x000C3F94 File Offset: 0x000C2194
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		public unsafe static int CurrentEra
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CurrentEra, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CurrentEra, (void*)(&value));
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x000C3FB0 File Offset: 0x000C21B0
		// (set) Token: 0x0600242C RID: 9260 RVA: 0x0000C2AE File Offset: 0x0000A4AE
		public unsafe int twoDigitYearMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_twoDigitYearMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_twoDigitYearMax)) = value;
			}
		}

		// Token: 0x04002012 RID: 8210
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMillisecond;

		// Token: 0x04002013 RID: 8211
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerSecond;

		// Token: 0x04002014 RID: 8212
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMinute;

		// Token: 0x04002015 RID: 8213
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerHour;

		// Token: 0x04002016 RID: 8214
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerDay;

		// Token: 0x04002017 RID: 8215
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerSecond;

		// Token: 0x04002018 RID: 8216
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerMinute;

		// Token: 0x04002019 RID: 8217
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerHour;

		// Token: 0x0400201A RID: 8218
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerDay;

		// Token: 0x0400201B RID: 8219
		private static readonly IntPtr NativeFieldInfoPtr_DaysPerYear;

		// Token: 0x0400201C RID: 8220
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer4Years;

		// Token: 0x0400201D RID: 8221
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer100Years;

		// Token: 0x0400201E RID: 8222
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer400Years;

		// Token: 0x0400201F RID: 8223
		private static readonly IntPtr NativeFieldInfoPtr_DaysTo10000;

		// Token: 0x04002020 RID: 8224
		private static readonly IntPtr NativeFieldInfoPtr_MaxMillis;

		// Token: 0x04002021 RID: 8225
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN;

		// Token: 0x04002022 RID: 8226
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN_US;

		// Token: 0x04002023 RID: 8227
		private static readonly IntPtr NativeFieldInfoPtr_CAL_JAPAN;

		// Token: 0x04002024 RID: 8228
		private static readonly IntPtr NativeFieldInfoPtr_CAL_TAIWAN;

		// Token: 0x04002025 RID: 8229
		private static readonly IntPtr NativeFieldInfoPtr_CAL_KOREA;

		// Token: 0x04002026 RID: 8230
		private static readonly IntPtr NativeFieldInfoPtr_CAL_HIJRI;

		// Token: 0x04002027 RID: 8231
		private static readonly IntPtr NativeFieldInfoPtr_CAL_THAI;

		// Token: 0x04002028 RID: 8232
		private static readonly IntPtr NativeFieldInfoPtr_CAL_HEBREW;

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN_ME_FRENCH;

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN_ARABIC;

		// Token: 0x0400202B RID: 8235
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_ENGLISH;

		// Token: 0x0400202C RID: 8236
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_FRENCH;

		// Token: 0x0400202D RID: 8237
		private static readonly IntPtr NativeFieldInfoPtr_CAL_JULIAN;

		// Token: 0x0400202E RID: 8238
		private static readonly IntPtr NativeFieldInfoPtr_CAL_JAPANESELUNISOLAR;

		// Token: 0x0400202F RID: 8239
		private static readonly IntPtr NativeFieldInfoPtr_CAL_CHINESELUNISOLAR;

		// Token: 0x04002030 RID: 8240
		private static readonly IntPtr NativeFieldInfoPtr_CAL_SAKA;

		// Token: 0x04002031 RID: 8241
		private static readonly IntPtr NativeFieldInfoPtr_CAL_LUNAR_ETO_CHN;

		// Token: 0x04002032 RID: 8242
		private static readonly IntPtr NativeFieldInfoPtr_CAL_LUNAR_ETO_KOR;

		// Token: 0x04002033 RID: 8243
		private static readonly IntPtr NativeFieldInfoPtr_CAL_LUNAR_ETO_ROKUYOU;

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeFieldInfoPtr_CAL_KOREANLUNISOLAR;

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeFieldInfoPtr_CAL_TAIWANLUNISOLAR;

		// Token: 0x04002036 RID: 8246
		private static readonly IntPtr NativeFieldInfoPtr_CAL_PERSIAN;

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeFieldInfoPtr_CAL_UMALQURA;

		// Token: 0x04002038 RID: 8248
		private static readonly IntPtr NativeFieldInfoPtr_m_currentEraValue;

		// Token: 0x04002039 RID: 8249
		private static readonly IntPtr NativeFieldInfoPtr_m_isReadOnly;

		// Token: 0x0400203A RID: 8250
		private static readonly IntPtr NativeFieldInfoPtr_CurrentEra;

		// Token: 0x0400203B RID: 8251
		private static readonly IntPtr NativeFieldInfoPtr_twoDigitYearMax;

		// Token: 0x0400203C RID: 8252
		private static readonly IntPtr NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_New_get_DateTime_0;

		// Token: 0x0400203D RID: 8253
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_New_get_DateTime_0;

		// Token: 0x0400203E RID: 8254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400203F RID: 8255
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Internal_Virtual_New_get_Int32_0;

		// Token: 0x04002040 RID: 8256
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseCalendarID_Internal_Virtual_New_get_Int32_0;

		// Token: 0x04002041 RID: 8257
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x04002042 RID: 8258
		private static readonly IntPtr NativeMethodInfoPtr_SetReadOnlyState_Internal_Void_Boolean_0;

		// Token: 0x04002043 RID: 8259
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEraValue_Internal_Virtual_New_get_Int32_0;

		// Token: 0x04002044 RID: 8260
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMonth_Public_Abstract_Virtual_New_Int32_DateTime_0;

		// Token: 0x04002045 RID: 8261
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfWeek_Public_Abstract_Virtual_New_DayOfWeek_DateTime_0;

		// Token: 0x04002046 RID: 8262
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInMonth_Public_Abstract_Virtual_New_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002047 RID: 8263
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0;

		// Token: 0x04002048 RID: 8264
		private static readonly IntPtr NativeMethodInfoPtr_GetEra_Public_Abstract_Virtual_New_Int32_DateTime_0;

		// Token: 0x04002049 RID: 8265
		private static readonly IntPtr NativeMethodInfoPtr_get_Eras_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400204A RID: 8266
		private static readonly IntPtr NativeMethodInfoPtr_GetMonth_Public_Abstract_Virtual_New_Int32_DateTime_0;

		// Token: 0x0400204B RID: 8267
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthsInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0;

		// Token: 0x0400204C RID: 8268
		private static readonly IntPtr NativeMethodInfoPtr_GetYear_Public_Abstract_Virtual_New_Int32_DateTime_0;

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Abstract_Virtual_New_Boolean_Int32_Int32_0;

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeMethodInfoPtr_TryToDateTime_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeMethodInfoPtr_IsValidYear_Internal_Virtual_New_Boolean_Int32_Int32_0;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeMethodInfoPtr_IsValidMonth_Internal_Virtual_New_Boolean_Int32_Int32_Int32_0;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeMethodInfoPtr_IsValidDay_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002054 RID: 8276
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002055 RID: 8277
		private static readonly IntPtr NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_New_Int32_Int32_0;

		// Token: 0x04002056 RID: 8278
		private static readonly IntPtr NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002057 RID: 8279
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemTwoDigitYearSetting_Internal_Static_Int32_Int32_Int32_0;
	}
}
