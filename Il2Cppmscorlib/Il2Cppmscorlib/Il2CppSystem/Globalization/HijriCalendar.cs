using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200023C RID: 572
	[Serializable]
	public class HijriCalendar : Calendar
	{
		// Token: 0x0600265B RID: 9819 RVA: 0x000CBBD8 File Offset: 0x000C9DD8
		// Note: this type is marked as 'beforefieldinit'.
		static HijriCalendar()
		{
			Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "HijriCalendar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr);
			HijriCalendar.NativeFieldInfoPtr_HijriEra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, "HijriEra");
			HijriCalendar.NativeFieldInfoPtr_HijriMonthDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, "HijriMonthDays");
			HijriCalendar.NativeFieldInfoPtr_m_HijriAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, "m_HijriAdvance");
			HijriCalendar.NativeFieldInfoPtr_calendarMinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, "calendarMinValue");
			HijriCalendar.NativeFieldInfoPtr_calendarMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, "calendarMaxValue");
			HijriCalendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669530);
			HijriCalendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669531);
			HijriCalendar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669532);
			HijriCalendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669533);
			HijriCalendar.NativeMethodInfoPtr_GetAbsoluteDateHijri_Private_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669534);
			HijriCalendar.NativeMethodInfoPtr_DaysUpToHijriYear_Private_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669535);
			HijriCalendar.NativeMethodInfoPtr_get_HijriAdjustment_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669536);
			HijriCalendar.NativeMethodInfoPtr_GetAdvanceHijriDate_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669537);
			HijriCalendar.NativeMethodInfoPtr_CheckTicksRange_Internal_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669538);
			HijriCalendar.NativeMethodInfoPtr_CheckEraRange_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669539);
			HijriCalendar.NativeMethodInfoPtr_CheckYearRange_Internal_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669540);
			HijriCalendar.NativeMethodInfoPtr_CheckYearMonthRange_Internal_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669541);
			HijriCalendar.NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669542);
			HijriCalendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669543);
			HijriCalendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669544);
			HijriCalendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669545);
			HijriCalendar.NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669546);
			HijriCalendar.NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669547);
			HijriCalendar.NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669548);
			HijriCalendar.NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669549);
			HijriCalendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669550);
			HijriCalendar.NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669551);
			HijriCalendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669552);
			HijriCalendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669553);
			HijriCalendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669554);
			HijriCalendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr, 100669555);
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x0600265C RID: 9820 RVA: 0x000CBE74 File Offset: 0x000CA074
		public unsafe override DateTime MinSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326947, XrefRangeEnd = 326951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x000CBEBC File Offset: 0x000CA0BC
		public unsafe override DateTime MaxSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326951, XrefRangeEnd = 326955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x000CBF04 File Offset: 0x000CA104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326955, XrefRangeEnd = 326956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HijriCalendar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HijriCalendar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HijriCalendar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x000CBF40 File Offset: 0x000CA140
		public unsafe override int ID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x000CBF88 File Offset: 0x000CA188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326956, XrefRangeEnd = 326964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetAbsoluteDateHijri(int y, int m, int d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref y;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HijriCalendar.NativeMethodInfoPtr_GetAbsoluteDateHijri_Private_Int64_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x000CBFF0 File Offset: 0x000CA1F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326964, RefRangeEnd = 326967, XrefRangeStart = 326964, XrefRangeEnd = 326964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long DaysUpToHijriYear(int HijriYear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref HijriYear;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HijriCalendar.NativeMethodInfoPtr_DaysUpToHijriYear_Private_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06002662 RID: 9826 RVA: 0x000CC03C File Offset: 0x000CA23C
		public unsafe int HijriAdjustment
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326967, XrefRangeEnd = 326970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HijriCalendar.NativeMethodInfoPtr_get_HijriAdjustment_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x000CC078 File Offset: 0x000CA278
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAdvanceHijriDate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HijriCalendar.NativeMethodInfoPtr_GetAdvanceHijriDate_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x000CC0A8 File Offset: 0x000CA2A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 326979, RefRangeEnd = 326981, XrefRangeStart = 326970, XrefRangeEnd = 326979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckTicksRange(long ticks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HijriCalendar.NativeMethodInfoPtr_CheckTicksRange_Internal_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x000CC0DC File Offset: 0x000CA2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326981, XrefRangeEnd = 326985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckEraRange(int era)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref era;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HijriCalendar.NativeMethodInfoPtr_CheckEraRange_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x000CC110 File Offset: 0x000CA310
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 326993, RefRangeEnd = 326997, XrefRangeStart = 326985, XrefRangeEnd = 326993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckYearRange(int year, int era)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HijriCalendar.NativeMethodInfoPtr_CheckYearRange_Internal_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x000CC150 File Offset: 0x000CA350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327001, RefRangeEnd = 327002, XrefRangeStart = 326997, XrefRangeEnd = 327001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckYearMonthRange(int year, int month, int era)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HijriCalendar.NativeMethodInfoPtr_CheckYearMonthRange_Internal_Static_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x000CC1A0 File Offset: 0x000CA3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327002, XrefRangeEnd = 327019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetDatePart(long ticks, int part)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref part;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x000CC204 File Offset: 0x000CA404
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x000CC258 File Offset: 0x000CA458
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x000CC2AC File Offset: 0x000CA4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327019, XrefRangeEnd = 327024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x000CC31C File Offset: 0x000CA51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327024, XrefRangeEnd = 327028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x000CC380 File Offset: 0x000CA580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327028, XrefRangeEnd = 327034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetEra(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x000CC3D4 File Offset: 0x000CA5D4
		public unsafe override Il2CppStructArray<int> Eras
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327034, XrefRangeEnd = 327041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x000CC420 File Offset: 0x000CA620
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x000CC474 File Offset: 0x000CA674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327041, XrefRangeEnd = 327045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x000CC4D8 File Offset: 0x000CA6D8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x000CC52C File Offset: 0x000CA72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327045, XrefRangeEnd = 327049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x000CC590 File Offset: 0x000CA790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327049, XrefRangeEnd = 327059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x000CC648 File Offset: 0x000CA848
		public unsafe override int TwoDigitYearMax
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327059, XrefRangeEnd = 327060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x000CC690 File Offset: 0x000CA890
		[CallerCount(0)]
		public unsafe override int ToFourDigitYear(int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HijriCalendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x0000D2B7 File Offset: 0x0000B4B7
		public HijriCalendar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06002677 RID: 9847 RVA: 0x000CC6E4 File Offset: 0x000CA8E4
		// (set) Token: 0x06002678 RID: 9848 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		public unsafe static int HijriEra
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HijriCalendar.NativeFieldInfoPtr_HijriEra, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HijriCalendar.NativeFieldInfoPtr_HijriEra, (void*)(&value));
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06002679 RID: 9849 RVA: 0x000CC700 File Offset: 0x000CA900
		// (set) Token: 0x0600267A RID: 9850 RVA: 0x0000D2CE File Offset: 0x0000B4CE
		public unsafe static Il2CppStructArray<int> HijriMonthDays
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HijriCalendar.NativeFieldInfoPtr_HijriMonthDays, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HijriCalendar.NativeFieldInfoPtr_HijriMonthDays, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x0600267B RID: 9851 RVA: 0x000CC728 File Offset: 0x000CA928
		// (set) Token: 0x0600267C RID: 9852 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
		public unsafe int m_HijriAdvance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HijriCalendar.NativeFieldInfoPtr_m_HijriAdvance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HijriCalendar.NativeFieldInfoPtr_m_HijriAdvance)) = value;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x0600267D RID: 9853 RVA: 0x000CC750 File Offset: 0x000CA950
		// (set) Token: 0x0600267E RID: 9854 RVA: 0x0000D2FB File Offset: 0x0000B4FB
		public unsafe static DateTime calendarMinValue
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(HijriCalendar.NativeFieldInfoPtr_calendarMinValue, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HijriCalendar.NativeFieldInfoPtr_calendarMinValue, (void*)(&value));
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x000CC76C File Offset: 0x000CA96C
		// (set) Token: 0x06002680 RID: 9856 RVA: 0x0000D309 File Offset: 0x0000B509
		public unsafe static DateTime calendarMaxValue
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(HijriCalendar.NativeFieldInfoPtr_calendarMaxValue, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HijriCalendar.NativeFieldInfoPtr_calendarMaxValue, (void*)(&value));
			}
		}

		// Token: 0x0400222B RID: 8747
		private static readonly IntPtr NativeFieldInfoPtr_HijriEra;

		// Token: 0x0400222C RID: 8748
		private static readonly IntPtr NativeFieldInfoPtr_HijriMonthDays;

		// Token: 0x0400222D RID: 8749
		private static readonly IntPtr NativeFieldInfoPtr_m_HijriAdvance;

		// Token: 0x0400222E RID: 8750
		private static readonly IntPtr NativeFieldInfoPtr_calendarMinValue;

		// Token: 0x0400222F RID: 8751
		private static readonly IntPtr NativeFieldInfoPtr_calendarMaxValue;

		// Token: 0x04002230 RID: 8752
		private static readonly IntPtr NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x04002231 RID: 8753
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x04002232 RID: 8754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002233 RID: 8755
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0;

		// Token: 0x04002234 RID: 8756
		private static readonly IntPtr NativeMethodInfoPtr_GetAbsoluteDateHijri_Private_Int64_Int32_Int32_Int32_0;

		// Token: 0x04002235 RID: 8757
		private static readonly IntPtr NativeMethodInfoPtr_DaysUpToHijriYear_Private_Int64_Int32_0;

		// Token: 0x04002236 RID: 8758
		private static readonly IntPtr NativeMethodInfoPtr_get_HijriAdjustment_Public_get_Int32_0;

		// Token: 0x04002237 RID: 8759
		private static readonly IntPtr NativeMethodInfoPtr_GetAdvanceHijriDate_Private_Static_Int32_0;

		// Token: 0x04002238 RID: 8760
		private static readonly IntPtr NativeMethodInfoPtr_CheckTicksRange_Internal_Static_Void_Int64_0;

		// Token: 0x04002239 RID: 8761
		private static readonly IntPtr NativeMethodInfoPtr_CheckEraRange_Internal_Static_Void_Int32_0;

		// Token: 0x0400223A RID: 8762
		private static readonly IntPtr NativeMethodInfoPtr_CheckYearRange_Internal_Static_Void_Int32_Int32_0;

		// Token: 0x0400223B RID: 8763
		private static readonly IntPtr NativeMethodInfoPtr_CheckYearMonthRange_Internal_Static_Void_Int32_Int32_Int32_0;

		// Token: 0x0400223C RID: 8764
		private static readonly IntPtr NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_Int64_Int32_0;

		// Token: 0x0400223D RID: 8765
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0;

		// Token: 0x0400223E RID: 8766
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0;

		// Token: 0x0400223F RID: 8767
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002240 RID: 8768
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x04002241 RID: 8769
		private static readonly IntPtr NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0;

		// Token: 0x04002242 RID: 8770
		private static readonly IntPtr NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002243 RID: 8771
		private static readonly IntPtr NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0;

		// Token: 0x04002244 RID: 8772
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x04002245 RID: 8773
		private static readonly IntPtr NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0;

		// Token: 0x04002246 RID: 8774
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0;

		// Token: 0x04002247 RID: 8775
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002248 RID: 8776
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0;

		// Token: 0x04002249 RID: 8777
		private static readonly IntPtr NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0;
	}
}
