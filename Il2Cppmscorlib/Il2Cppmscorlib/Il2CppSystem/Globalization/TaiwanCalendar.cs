using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000241 RID: 577
	[Serializable]
	public class TaiwanCalendar : Calendar
	{
		// Token: 0x0600271A RID: 10010 RVA: 0x000CE7B0 File Offset: 0x000CC9B0
		// Note: this type is marked as 'beforefieldinit'.
		static TaiwanCalendar()
		{
			Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "TaiwanCalendar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr);
			TaiwanCalendar.NativeFieldInfoPtr_taiwanEraInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, "taiwanEraInfo");
			TaiwanCalendar.NativeFieldInfoPtr_s_defaultInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, "s_defaultInstance");
			TaiwanCalendar.NativeFieldInfoPtr_helper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, "helper");
			TaiwanCalendar.NativeFieldInfoPtr_calendarMinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, "calendarMinValue");
			TaiwanCalendar.NativeMethodInfoPtr_GetDefaultInstance_Internal_Static_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669621);
			TaiwanCalendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669622);
			TaiwanCalendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669623);
			TaiwanCalendar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669624);
			TaiwanCalendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669625);
			TaiwanCalendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669626);
			TaiwanCalendar.NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669627);
			TaiwanCalendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669628);
			TaiwanCalendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669629);
			TaiwanCalendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669630);
			TaiwanCalendar.NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669631);
			TaiwanCalendar.NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669632);
			TaiwanCalendar.NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669633);
			TaiwanCalendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669634);
			TaiwanCalendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669635);
			TaiwanCalendar.NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669636);
			TaiwanCalendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669637);
			TaiwanCalendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr, 100669638);
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x000CE998 File Offset: 0x000CCB98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327544, RefRangeEnd = 327546, XrefRangeStart = 327528, XrefRangeEnd = 327544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Calendar GetDefaultInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaiwanCalendar.NativeMethodInfoPtr_GetDefaultInstance_Internal_Static_Calendar_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr3) : null;
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x0600271C RID: 10012 RVA: 0x000CE9CC File Offset: 0x000CCBCC
		public unsafe override DateTime MinSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327546, XrefRangeEnd = 327550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x0600271D RID: 10013 RVA: 0x000CEA14 File Offset: 0x000CCC14
		public unsafe override DateTime MaxSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327550, XrefRangeEnd = 327554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x000CEA5C File Offset: 0x000CCC5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327569, RefRangeEnd = 327570, XrefRangeStart = 327554, XrefRangeEnd = 327569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaiwanCalendar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaiwanCalendar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaiwanCalendar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x0600271F RID: 10015 RVA: 0x000CEA98 File Offset: 0x000CCC98
		public unsafe override int ID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x000CEAE0 File Offset: 0x000CCCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetDaysInMonth(int year, int month, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x000CEB50 File Offset: 0x000CCD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetDaysInYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x000CEBB4 File Offset: 0x000CCDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetDayOfMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x000CEC08 File Offset: 0x000CCE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DayOfWeek GetDayOfWeek(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x000CEC5C File Offset: 0x000CCE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetMonthsInYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x000CECC0 File Offset: 0x000CCEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetEra(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x000CED14 File Offset: 0x000CCF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x000CED68 File Offset: 0x000CCF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetYear(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x000CEDBC File Offset: 0x000CCFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsLeapYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x000CEE20 File Offset: 0x000CD020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x0600272A RID: 10026 RVA: 0x000CEED8 File Offset: 0x000CD0D8
		public unsafe override Il2CppStructArray<int> Eras
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x000CEF24 File Offset: 0x000CD124
		public unsafe override int TwoDigitYearMax
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x000CEF6C File Offset: 0x000CD16C
		[CallerCount(0)]
		public unsafe override int ToFourDigitYear(int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaiwanCalendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x0000D7BB File Offset: 0x0000B9BB
		public TaiwanCalendar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x000CEFC0 File Offset: 0x000CD1C0
		// (set) Token: 0x0600272F RID: 10031 RVA: 0x0000D7C4 File Offset: 0x0000B9C4
		public unsafe static Il2CppReferenceArray<EraInfo> taiwanEraInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaiwanCalendar.NativeFieldInfoPtr_taiwanEraInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EraInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaiwanCalendar.NativeFieldInfoPtr_taiwanEraInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06002730 RID: 10032 RVA: 0x000CEFE8 File Offset: 0x000CD1E8
		// (set) Token: 0x06002731 RID: 10033 RVA: 0x0000D7D6 File Offset: 0x0000B9D6
		public unsafe static Calendar s_defaultInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaiwanCalendar.NativeFieldInfoPtr_s_defaultInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaiwanCalendar.NativeFieldInfoPtr_s_defaultInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06002732 RID: 10034 RVA: 0x000CF010 File Offset: 0x000CD210
		// (set) Token: 0x06002733 RID: 10035 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
		public unsafe GregorianCalendarHelper helper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaiwanCalendar.NativeFieldInfoPtr_helper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GregorianCalendarHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaiwanCalendar.NativeFieldInfoPtr_helper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x000CF040 File Offset: 0x000CD240
		// (set) Token: 0x06002735 RID: 10037 RVA: 0x0000D807 File Offset: 0x0000BA07
		public unsafe static DateTime calendarMinValue
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(TaiwanCalendar.NativeFieldInfoPtr_calendarMinValue, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaiwanCalendar.NativeFieldInfoPtr_calendarMinValue, (void*)(&value));
			}
		}

		// Token: 0x040022C5 RID: 8901
		private static readonly IntPtr NativeFieldInfoPtr_taiwanEraInfo;

		// Token: 0x040022C6 RID: 8902
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultInstance;

		// Token: 0x040022C7 RID: 8903
		private static readonly IntPtr NativeFieldInfoPtr_helper;

		// Token: 0x040022C8 RID: 8904
		private static readonly IntPtr NativeFieldInfoPtr_calendarMinValue;

		// Token: 0x040022C9 RID: 8905
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Internal_Static_Calendar_0;

		// Token: 0x040022CA RID: 8906
		private static readonly IntPtr NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x040022CB RID: 8907
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x040022CC RID: 8908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040022CD RID: 8909
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0;

		// Token: 0x040022CE RID: 8910
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0;

		// Token: 0x040022CF RID: 8911
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x040022D0 RID: 8912
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0;

		// Token: 0x040022D1 RID: 8913
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0;

		// Token: 0x040022D2 RID: 8914
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x040022D3 RID: 8915
		private static readonly IntPtr NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0;

		// Token: 0x040022D4 RID: 8916
		private static readonly IntPtr NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0;

		// Token: 0x040022D5 RID: 8917
		private static readonly IntPtr NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0;

		// Token: 0x040022D6 RID: 8918
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0;

		// Token: 0x040022D7 RID: 8919
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x040022D8 RID: 8920
		private static readonly IntPtr NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040022D9 RID: 8921
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0;

		// Token: 0x040022DA RID: 8922
		private static readonly IntPtr NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0;
	}
}
