using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000245 RID: 581
	[Serializable]
	public class UmAlQuraCalendar : Calendar
	{
		// Token: 0x0600279A RID: 10138 RVA: 0x000D0E3C File Offset: 0x000CF03C
		// Note: this type is marked as 'beforefieldinit'.
		static UmAlQuraCalendar()
		{
			Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "UmAlQuraCalendar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr);
			UmAlQuraCalendar.NativeFieldInfoPtr_HijriYearInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, "HijriYearInfo");
			UmAlQuraCalendar.NativeFieldInfoPtr_minDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, "minDate");
			UmAlQuraCalendar.NativeFieldInfoPtr_maxDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, "maxDate");
			UmAlQuraCalendar.NativeMethodInfoPtr_InitDateMapping_Private_Static_Il2CppStructArray_1_DateMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669712);
			UmAlQuraCalendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669713);
			UmAlQuraCalendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669714);
			UmAlQuraCalendar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669715);
			UmAlQuraCalendar.NativeMethodInfoPtr_get_BaseCalendarID_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669716);
			UmAlQuraCalendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669717);
			UmAlQuraCalendar.NativeMethodInfoPtr_ConvertHijriToGregorian_Private_Static_Void_Int32_Int32_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669718);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetAbsoluteDateUmAlQura_Private_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669719);
			UmAlQuraCalendar.NativeMethodInfoPtr_CheckTicksRange_Internal_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669720);
			UmAlQuraCalendar.NativeMethodInfoPtr_CheckEraRange_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669721);
			UmAlQuraCalendar.NativeMethodInfoPtr_CheckYearRange_Internal_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669722);
			UmAlQuraCalendar.NativeMethodInfoPtr_CheckYearMonthRange_Internal_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669723);
			UmAlQuraCalendar.NativeMethodInfoPtr_ConvertGregorianToHijri_Private_Static_Void_DateTime_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669724);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669725);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669726);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669727);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669728);
			UmAlQuraCalendar.NativeMethodInfoPtr_RealGetDaysInYear_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669729);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669730);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669731);
			UmAlQuraCalendar.NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669732);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669733);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669734);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669735);
			UmAlQuraCalendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669736);
			UmAlQuraCalendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669737);
			UmAlQuraCalendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669738);
			UmAlQuraCalendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100669739);
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x000D10D8 File Offset: 0x000CF2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328036, XrefRangeEnd = 328047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<UmAlQuraCalendar.DateMapping> InitDateMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_InitDateMapping_Private_Static_Il2CppStructArray_1_DateMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UmAlQuraCalendar.DateMapping>>(intPtr3) : null;
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x0600279C RID: 10140 RVA: 0x000D110C File Offset: 0x000CF30C
		public unsafe override DateTime MinSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328047, XrefRangeEnd = 328051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x0600279D RID: 10141 RVA: 0x000D1154 File Offset: 0x000CF354
		public unsafe override DateTime MaxSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328051, XrefRangeEnd = 328055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x000D119C File Offset: 0x000CF39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328055, XrefRangeEnd = 328056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UmAlQuraCalendar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x0600279F RID: 10143 RVA: 0x000D11D8 File Offset: 0x000CF3D8
		public unsafe override int BaseCalendarID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_get_BaseCalendarID_Internal_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x000D1220 File Offset: 0x000CF420
		public unsafe override int ID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x000D1268 File Offset: 0x000CF468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328056, XrefRangeEnd = 328064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, ref int yg, ref int mg, ref int dg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref HijriYear;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref HijriMonth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref HijriDay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &yg;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mg;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_ConvertHijriToGregorian_Private_Static_Void_Int32_Int32_Int32_byref_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x000D12E4 File Offset: 0x000CF4E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 328085, RefRangeEnd = 328088, XrefRangeStart = 328064, XrefRangeEnd = 328085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetAbsoluteDateUmAlQura(int year, int month, int day)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_GetAbsoluteDateUmAlQura_Private_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x000D1340 File Offset: 0x000CF540
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328097, RefRangeEnd = 328099, XrefRangeStart = 328088, XrefRangeEnd = 328097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckTicksRange(long ticks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_CheckTicksRange_Internal_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x000D1374 File Offset: 0x000CF574
		[CallerCount(0)]
		public unsafe static void CheckEraRange(int era)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref era;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_CheckEraRange_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x000D13A8 File Offset: 0x000CF5A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 328102, RefRangeEnd = 328106, XrefRangeStart = 328099, XrefRangeEnd = 328102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_CheckYearRange_Internal_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x000D13E8 File Offset: 0x000CF5E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328110, RefRangeEnd = 328112, XrefRangeStart = 328106, XrefRangeEnd = 328110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_CheckYearMonthRange_Internal_Static_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x000D1438 File Offset: 0x000CF638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328132, RefRangeEnd = 328133, XrefRangeStart = 328112, XrefRangeEnd = 328132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertGregorianToHijri(DateTime time, ref int HijriYear, ref int HijriMonth, ref int HijriDay)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &HijriYear;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &HijriMonth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &HijriDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_ConvertGregorianToHijri_Private_Static_Void_DateTime_byref_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x000D1494 File Offset: 0x000CF694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328133, XrefRangeEnd = 328143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetDatePart(DateTime time, int part)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref part;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_DateTime_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x000D14F8 File Offset: 0x000CF6F8
		[CallerCount(0)]
		public unsafe override int GetDayOfMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x000D154C File Offset: 0x000CF74C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x000D15A0 File Offset: 0x000CF7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328143, XrefRangeEnd = 328148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x000D1610 File Offset: 0x000CF810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328152, RefRangeEnd = 328154, XrefRangeStart = 328148, XrefRangeEnd = 328152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RealGetDaysInYear(int year)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_RealGetDaysInYear_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x000D1650 File Offset: 0x000CF850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328154, XrefRangeEnd = 328159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x000D16B4 File Offset: 0x000CF8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328159, XrefRangeEnd = 328164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetEra(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x060027AF RID: 10159 RVA: 0x000D1708 File Offset: 0x000CF908
		public unsafe override Il2CppStructArray<int> Eras
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328164, XrefRangeEnd = 328167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x000D1754 File Offset: 0x000CF954
		[CallerCount(0)]
		public unsafe override int GetMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x000D17A8 File Offset: 0x000CF9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328167, XrefRangeEnd = 328171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x000D180C File Offset: 0x000CFA0C
		[CallerCount(0)]
		public unsafe override int GetYear(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x000D1860 File Offset: 0x000CFA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328171, XrefRangeEnd = 328176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x000D18C4 File Offset: 0x000CFAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328176, XrefRangeEnd = 328186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x000D197C File Offset: 0x000CFB7C
		public unsafe override int TwoDigitYearMax
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x000D19C4 File Offset: 0x000CFBC4
		[CallerCount(0)]
		public unsafe override int ToFourDigitYear(int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x0000D9E4 File Offset: 0x0000BBE4
		public UmAlQuraCalendar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x000D1A18 File Offset: 0x000CFC18
		// (set) Token: 0x060027B9 RID: 10169 RVA: 0x0000D9ED File Offset: 0x0000BBED
		public unsafe static Il2CppStructArray<UmAlQuraCalendar.DateMapping> HijriYearInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UmAlQuraCalendar.NativeFieldInfoPtr_HijriYearInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UmAlQuraCalendar.DateMapping>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UmAlQuraCalendar.NativeFieldInfoPtr_HijriYearInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x000D1A40 File Offset: 0x000CFC40
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x0000D9FF File Offset: 0x0000BBFF
		public unsafe static DateTime minDate
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(UmAlQuraCalendar.NativeFieldInfoPtr_minDate, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UmAlQuraCalendar.NativeFieldInfoPtr_minDate, (void*)(&value));
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x000D1A5C File Offset: 0x000CFC5C
		// (set) Token: 0x060027BD RID: 10173 RVA: 0x0000DA0D File Offset: 0x0000BC0D
		public unsafe static DateTime maxDate
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(UmAlQuraCalendar.NativeFieldInfoPtr_maxDate, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UmAlQuraCalendar.NativeFieldInfoPtr_maxDate, (void*)(&value));
			}
		}

		// Token: 0x04002329 RID: 9001
		private static readonly IntPtr NativeFieldInfoPtr_HijriYearInfo;

		// Token: 0x0400232A RID: 9002
		private static readonly IntPtr NativeFieldInfoPtr_minDate;

		// Token: 0x0400232B RID: 9003
		private static readonly IntPtr NativeFieldInfoPtr_maxDate;

		// Token: 0x0400232C RID: 9004
		private static readonly IntPtr NativeMethodInfoPtr_InitDateMapping_Private_Static_Il2CppStructArray_1_DateMapping_0;

		// Token: 0x0400232D RID: 9005
		private static readonly IntPtr NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x0400232E RID: 9006
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x0400232F RID: 9007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002330 RID: 9008
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseCalendarID_Internal_Virtual_get_Int32_0;

		// Token: 0x04002331 RID: 9009
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0;

		// Token: 0x04002332 RID: 9010
		private static readonly IntPtr NativeMethodInfoPtr_ConvertHijriToGregorian_Private_Static_Void_Int32_Int32_Int32_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04002333 RID: 9011
		private static readonly IntPtr NativeMethodInfoPtr_GetAbsoluteDateUmAlQura_Private_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x04002334 RID: 9012
		private static readonly IntPtr NativeMethodInfoPtr_CheckTicksRange_Internal_Static_Void_Int64_0;

		// Token: 0x04002335 RID: 9013
		private static readonly IntPtr NativeMethodInfoPtr_CheckEraRange_Internal_Static_Void_Int32_0;

		// Token: 0x04002336 RID: 9014
		private static readonly IntPtr NativeMethodInfoPtr_CheckYearRange_Internal_Static_Void_Int32_Int32_0;

		// Token: 0x04002337 RID: 9015
		private static readonly IntPtr NativeMethodInfoPtr_CheckYearMonthRange_Internal_Static_Void_Int32_Int32_Int32_0;

		// Token: 0x04002338 RID: 9016
		private static readonly IntPtr NativeMethodInfoPtr_ConvertGregorianToHijri_Private_Static_Void_DateTime_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04002339 RID: 9017
		private static readonly IntPtr NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_DateTime_Int32_0;

		// Token: 0x0400233A RID: 9018
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0;

		// Token: 0x0400233B RID: 9019
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0;

		// Token: 0x0400233C RID: 9020
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400233D RID: 9021
		private static readonly IntPtr NativeMethodInfoPtr_RealGetDaysInYear_Internal_Static_Int32_Int32_0;

		// Token: 0x0400233E RID: 9022
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x0400233F RID: 9023
		private static readonly IntPtr NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0;

		// Token: 0x04002340 RID: 9024
		private static readonly IntPtr NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002341 RID: 9025
		private static readonly IntPtr NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0;

		// Token: 0x04002342 RID: 9026
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x04002343 RID: 9027
		private static readonly IntPtr NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0;

		// Token: 0x04002344 RID: 9028
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0;

		// Token: 0x04002345 RID: 9029
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002346 RID: 9030
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0;

		// Token: 0x04002347 RID: 9031
		private static readonly IntPtr NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0;

		// Token: 0x020005E3 RID: 1507
		[StructLayout(2)]
		public struct DateMapping
		{
			// Token: 0x0600522C RID: 21036 RVA: 0x0016EC40 File Offset: 0x0016CE40
			// Note: this type is marked as 'beforefieldinit'.
			static DateMapping()
			{
				Il2CppClassPointerStore<UmAlQuraCalendar.DateMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, "DateMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UmAlQuraCalendar.DateMapping>.NativeClassPtr);
				UmAlQuraCalendar.DateMapping.NativeFieldInfoPtr_HijriMonthsLengthFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UmAlQuraCalendar.DateMapping>.NativeClassPtr, "HijriMonthsLengthFlags");
				UmAlQuraCalendar.DateMapping.NativeFieldInfoPtr_GregorianDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UmAlQuraCalendar.DateMapping>.NativeClassPtr, "GregorianDate");
				UmAlQuraCalendar.DateMapping.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar.DateMapping>.NativeClassPtr, 100669741);
			}

			// Token: 0x0600522D RID: 21037 RVA: 0x0016ECA8 File Offset: 0x0016CEA8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 328035, RefRangeEnd = 328036, XrefRangeStart = 328034, XrefRangeEnd = 328035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DateMapping(int MonthsLengthFlags, int GYear, int GMonth, int GDay)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref MonthsLengthFlags;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref GYear;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref GMonth;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref GDay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.DateMapping.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600522E RID: 21038 RVA: 0x0001F527 File Offset: 0x0001D727
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UmAlQuraCalendar.DateMapping>.NativeClassPtr, ref this));
			}

			// Token: 0x0400429A RID: 17050
			private static readonly IntPtr NativeFieldInfoPtr_HijriMonthsLengthFlags;

			// Token: 0x0400429B RID: 17051
			private static readonly IntPtr NativeFieldInfoPtr_GregorianDate;

			// Token: 0x0400429C RID: 17052
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_0;

			// Token: 0x0400429D RID: 17053
			[FieldOffset(0)]
			public int HijriMonthsLengthFlags;

			// Token: 0x0400429E RID: 17054
			[FieldOffset(8)]
			public DateTime GregorianDate;
		}
	}
}
