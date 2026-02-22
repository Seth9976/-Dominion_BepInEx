using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000237 RID: 567
	[Serializable]
	public class GregorianCalendarHelper : Object
	{
		// Token: 0x06002626 RID: 9766 RVA: 0x000CAE54 File Offset: 0x000C9054
		// Note: this type is marked as 'beforefieldinit'.
		static GregorianCalendarHelper()
		{
			Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "GregorianCalendarHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr);
			GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth365 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "DaysToMonth365");
			GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth366 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "DaysToMonth366");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_maxYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_maxYear");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_minYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_minYear");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_Cal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_Cal");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_EraInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_EraInfo");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_eras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_eras");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_minDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_minDate");
			GregorianCalendarHelper.NativeMethodInfoPtr_get_MaxYear_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669502);
			GregorianCalendarHelper.NativeMethodInfoPtr__ctor_Internal_Void_Calendar_Il2CppReferenceArray_1_EraInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669503);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetGregorianYear_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669504);
			GregorianCalendarHelper.NativeMethodInfoPtr_IsValidYear_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669505);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669506);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetAbsoluteDate_Internal_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669507);
			GregorianCalendarHelper.NativeMethodInfoPtr_DateToTicks_Internal_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669508);
			GregorianCalendarHelper.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669509);
			GregorianCalendarHelper.NativeMethodInfoPtr_CheckTicksRange_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669510);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetDayOfMonth_Public_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669511);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetDayOfWeek_Public_DayOfWeek_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669512);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetDaysInMonth_Public_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669513);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetDaysInYear_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669514);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetEra_Public_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669515);
			GregorianCalendarHelper.NativeMethodInfoPtr_get_Eras_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669516);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetMonth_Public_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669517);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetMonthsInYear_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669518);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetYear_Public_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669519);
			GregorianCalendarHelper.NativeMethodInfoPtr_IsLeapYear_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669520);
			GregorianCalendarHelper.NativeMethodInfoPtr_ToDateTime_Public_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669521);
			GregorianCalendarHelper.NativeMethodInfoPtr_ToFourDigitYear_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100669522);
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06002627 RID: 9767 RVA: 0x000CB0C8 File Offset: 0x000C92C8
		public unsafe int MaxYear
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_get_MaxYear_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x000CB104 File Offset: 0x000C9304
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326558, RefRangeEnd = 326561, XrefRangeStart = 326557, XrefRangeEnd = 326558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GregorianCalendarHelper(Calendar cal, Il2CppReferenceArray<EraInfo> eraInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cal);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eraInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr__ctor_Internal_Void_Calendar_Il2CppReferenceArray_1_EraInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x000CB164 File Offset: 0x000C9364
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 326562, RefRangeEnd = 326567, XrefRangeStart = 326561, XrefRangeEnd = 326562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGregorianYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetGregorianYear_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x000CB1BC File Offset: 0x000C93BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326568, RefRangeEnd = 326569, XrefRangeStart = 326567, XrefRangeEnd = 326568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_IsValidYear_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x000CB214 File Offset: 0x000C9414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326569, XrefRangeEnd = 326579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendarHelper.NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x000CB278 File Offset: 0x000C9478
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 326587, RefRangeEnd = 326589, XrefRangeStart = 326579, XrefRangeEnd = 326587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetAbsoluteDate(int year, int month, int day)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetAbsoluteDate_Internal_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x000CB2D4 File Offset: 0x000C94D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326589, XrefRangeEnd = 326593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long DateToTicks(int year, int month, int day)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_DateToTicks_Internal_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x000CB330 File Offset: 0x000C9530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326597, RefRangeEnd = 326598, XrefRangeStart = 326593, XrefRangeEnd = 326597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x000CB398 File Offset: 0x000C9598
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326600, RefRangeEnd = 326603, XrefRangeStart = 326598, XrefRangeEnd = 326600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTicksRange(long ticks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_CheckTicksRange_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x000CB3D8 File Offset: 0x000C95D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326604, RefRangeEnd = 326607, XrefRangeStart = 326603, XrefRangeEnd = 326604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDayOfMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetDayOfMonth_Public_Int32_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x000CB424 File Offset: 0x000C9624
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326610, RefRangeEnd = 326613, XrefRangeStart = 326607, XrefRangeEnd = 326610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DayOfWeek GetDayOfWeek(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetDayOfWeek_Public_DayOfWeek_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x000CB470 File Offset: 0x000C9670
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326622, RefRangeEnd = 326625, XrefRangeStart = 326613, XrefRangeEnd = 326622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDaysInMonth(int year, int month, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetDaysInMonth_Public_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x000CB4D8 File Offset: 0x000C96D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326626, RefRangeEnd = 326629, XrefRangeStart = 326625, XrefRangeEnd = 326626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDaysInYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetDaysInYear_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x000CB530 File Offset: 0x000C9730
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326631, RefRangeEnd = 326634, XrefRangeStart = 326629, XrefRangeEnd = 326631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetEra(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetEra_Public_Int32_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x000CB57C File Offset: 0x000C977C
		public unsafe Il2CppStructArray<int> Eras
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 326641, RefRangeEnd = 326644, XrefRangeStart = 326634, XrefRangeEnd = 326641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_get_Eras_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000CB5BC File Offset: 0x000C97BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326645, RefRangeEnd = 326648, XrefRangeStart = 326644, XrefRangeEnd = 326645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetMonth_Public_Int32_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x000CB608 File Offset: 0x000C9808
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326649, RefRangeEnd = 326652, XrefRangeStart = 326648, XrefRangeEnd = 326649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMonthsInYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetMonthsInYear_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x000CB660 File Offset: 0x000C9860
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326654, RefRangeEnd = 326657, XrefRangeStart = 326652, XrefRangeEnd = 326654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetYear(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetYear_Public_Int32_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x000CB6AC File Offset: 0x000C98AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326658, RefRangeEnd = 326661, XrefRangeStart = 326657, XrefRangeEnd = 326658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLeapYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_IsLeapYear_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x000CB704 File Offset: 0x000C9904
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326673, RefRangeEnd = 326676, XrefRangeStart = 326661, XrefRangeEnd = 326673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_ToDateTime_Public_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x000CB7B0 File Offset: 0x000C99B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326676, RefRangeEnd = 326677, XrefRangeStart = 326676, XrefRangeEnd = 326676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ToFourDigitYear(int year, int twoDigitYearMax)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref twoDigitYearMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_ToFourDigitYear_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x0000D18F File Offset: 0x0000B38F
		public GregorianCalendarHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x0600263D RID: 9789 RVA: 0x000CB808 File Offset: 0x000C9A08
		// (set) Token: 0x0600263E RID: 9790 RVA: 0x0000D198 File Offset: 0x0000B398
		public unsafe static Il2CppStructArray<int> DaysToMonth365
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth365, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth365, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x0600263F RID: 9791 RVA: 0x000CB830 File Offset: 0x000C9A30
		// (set) Token: 0x06002640 RID: 9792 RVA: 0x0000D1AA File Offset: 0x0000B3AA
		public unsafe static Il2CppStructArray<int> DaysToMonth366
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth366, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth366, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06002641 RID: 9793 RVA: 0x000CB858 File Offset: 0x000C9A58
		// (set) Token: 0x06002642 RID: 9794 RVA: 0x0000D1BC File Offset: 0x0000B3BC
		public unsafe int m_maxYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_maxYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_maxYear)) = value;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x000CB880 File Offset: 0x000C9A80
		// (set) Token: 0x06002644 RID: 9796 RVA: 0x0000D1D7 File Offset: 0x0000B3D7
		public unsafe int m_minYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_minYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_minYear)) = value;
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06002645 RID: 9797 RVA: 0x000CB8A8 File Offset: 0x000C9AA8
		// (set) Token: 0x06002646 RID: 9798 RVA: 0x0000D1F2 File Offset: 0x0000B3F2
		public unsafe Calendar m_Cal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_Cal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_Cal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06002647 RID: 9799 RVA: 0x000CB8D8 File Offset: 0x000C9AD8
		// (set) Token: 0x06002648 RID: 9800 RVA: 0x0000D211 File Offset: 0x0000B411
		public unsafe Il2CppReferenceArray<EraInfo> m_EraInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_EraInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EraInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_EraInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06002649 RID: 9801 RVA: 0x000CB908 File Offset: 0x000C9B08
		// (set) Token: 0x0600264A RID: 9802 RVA: 0x0000D230 File Offset: 0x0000B430
		public unsafe Il2CppStructArray<int> m_eras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_eras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_eras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x0600264B RID: 9803 RVA: 0x000CB938 File Offset: 0x000C9B38
		// (set) Token: 0x0600264C RID: 9804 RVA: 0x0000D24F File Offset: 0x0000B44F
		public unsafe DateTime m_minDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_minDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_minDate)) = value;
			}
		}

		// Token: 0x040021F7 RID: 8695
		private static readonly IntPtr NativeFieldInfoPtr_DaysToMonth365;

		// Token: 0x040021F8 RID: 8696
		private static readonly IntPtr NativeFieldInfoPtr_DaysToMonth366;

		// Token: 0x040021F9 RID: 8697
		private static readonly IntPtr NativeFieldInfoPtr_m_maxYear;

		// Token: 0x040021FA RID: 8698
		private static readonly IntPtr NativeFieldInfoPtr_m_minYear;

		// Token: 0x040021FB RID: 8699
		private static readonly IntPtr NativeFieldInfoPtr_m_Cal;

		// Token: 0x040021FC RID: 8700
		private static readonly IntPtr NativeFieldInfoPtr_m_EraInfo;

		// Token: 0x040021FD RID: 8701
		private static readonly IntPtr NativeFieldInfoPtr_m_eras;

		// Token: 0x040021FE RID: 8702
		private static readonly IntPtr NativeFieldInfoPtr_m_minDate;

		// Token: 0x040021FF RID: 8703
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxYear_Internal_get_Int32_0;

		// Token: 0x04002200 RID: 8704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Calendar_Il2CppReferenceArray_1_EraInfo_0;

		// Token: 0x04002201 RID: 8705
		private static readonly IntPtr NativeMethodInfoPtr_GetGregorianYear_Internal_Int32_Int32_Int32_0;

		// Token: 0x04002202 RID: 8706
		private static readonly IntPtr NativeMethodInfoPtr_IsValidYear_Internal_Boolean_Int32_Int32_0;

		// Token: 0x04002203 RID: 8707
		private static readonly IntPtr NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_Int64_Int32_0;

		// Token: 0x04002204 RID: 8708
		private static readonly IntPtr NativeMethodInfoPtr_GetAbsoluteDate_Internal_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x04002205 RID: 8709
		private static readonly IntPtr NativeMethodInfoPtr_DateToTicks_Internal_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x04002206 RID: 8710
		private static readonly IntPtr NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002207 RID: 8711
		private static readonly IntPtr NativeMethodInfoPtr_CheckTicksRange_Internal_Void_Int64_0;

		// Token: 0x04002208 RID: 8712
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMonth_Public_Int32_DateTime_0;

		// Token: 0x04002209 RID: 8713
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfWeek_Public_DayOfWeek_DateTime_0;

		// Token: 0x0400220A RID: 8714
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInMonth_Public_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400220B RID: 8715
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInYear_Public_Int32_Int32_Int32_0;

		// Token: 0x0400220C RID: 8716
		private static readonly IntPtr NativeMethodInfoPtr_GetEra_Public_Int32_DateTime_0;

		// Token: 0x0400220D RID: 8717
		private static readonly IntPtr NativeMethodInfoPtr_get_Eras_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400220E RID: 8718
		private static readonly IntPtr NativeMethodInfoPtr_GetMonth_Public_Int32_DateTime_0;

		// Token: 0x0400220F RID: 8719
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthsInYear_Public_Int32_Int32_Int32_0;

		// Token: 0x04002210 RID: 8720
		private static readonly IntPtr NativeMethodInfoPtr_GetYear_Public_Int32_DateTime_0;

		// Token: 0x04002211 RID: 8721
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Boolean_Int32_Int32_0;

		// Token: 0x04002212 RID: 8722
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002213 RID: 8723
		private static readonly IntPtr NativeMethodInfoPtr_ToFourDigitYear_Public_Int32_Int32_Int32_0;
	}
}
