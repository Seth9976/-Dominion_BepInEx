using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000235 RID: 565
	[Serializable]
	public class GregorianCalendar : Calendar
	{
		// Token: 0x060025F1 RID: 9713 RVA: 0x000C9F7C File Offset: 0x000C817C
		// Note: this type is marked as 'beforefieldinit'.
		static GregorianCalendar()
		{
			Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "GregorianCalendar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr);
			GregorianCalendar.NativeFieldInfoPtr_m_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, "m_type");
			GregorianCalendar.NativeFieldInfoPtr_DaysToMonth365 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, "DaysToMonth365");
			GregorianCalendar.NativeFieldInfoPtr_DaysToMonth366 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, "DaysToMonth366");
			GregorianCalendar.NativeFieldInfoPtr_s_defaultInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, "s_defaultInstance");
			GregorianCalendar.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669476);
			GregorianCalendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669477);
			GregorianCalendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669478);
			GregorianCalendar.NativeMethodInfoPtr_GetDefaultInstance_Internal_Static_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669479);
			GregorianCalendar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669480);
			GregorianCalendar.NativeMethodInfoPtr__ctor_Public_Void_GregorianCalendarTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669481);
			GregorianCalendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669482);
			GregorianCalendar.NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669483);
			GregorianCalendar.NativeMethodInfoPtr_GetAbsoluteDate_Internal_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669484);
			GregorianCalendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669485);
			GregorianCalendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669486);
			GregorianCalendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669487);
			GregorianCalendar.NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669488);
			GregorianCalendar.NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669489);
			GregorianCalendar.NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669490);
			GregorianCalendar.NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669491);
			GregorianCalendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669492);
			GregorianCalendar.NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669493);
			GregorianCalendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669494);
			GregorianCalendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669495);
			GregorianCalendar.NativeMethodInfoPtr_TryToDateTime_Internal_Virtual_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669496);
			GregorianCalendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669497);
			GregorianCalendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr, 100669498);
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x000CA1C8 File Offset: 0x000C83C8
		[CallerCount(0)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendar.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x000CA210 File Offset: 0x000C8410
		public unsafe override DateTime MinSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326443, XrefRangeEnd = 326447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x000CA258 File Offset: 0x000C8458
		public unsafe override DateTime MaxSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326447, XrefRangeEnd = 326451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x000CA2A0 File Offset: 0x000C84A0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 326467, RefRangeEnd = 326478, XrefRangeStart = 326451, XrefRangeEnd = 326467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Calendar GetDefaultInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendar.NativeMethodInfoPtr_GetDefaultInstance_Internal_Static_Calendar_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr3) : null;
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x000CA2D4 File Offset: 0x000C84D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326478, XrefRangeEnd = 326479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GregorianCalendar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x000CA310 File Offset: 0x000C8510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326479, XrefRangeEnd = 326480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GregorianCalendar(GregorianCalendarTypes type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GregorianCalendar>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendar.NativeMethodInfoPtr__ctor_Public_Void_GregorianCalendarTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x000CA358 File Offset: 0x000C8558
		public unsafe override int ID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x000CA3A0 File Offset: 0x000C85A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326480, XrefRangeEnd = 326489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x000CA404 File Offset: 0x000C8604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326497, RefRangeEnd = 326498, XrefRangeStart = 326489, XrefRangeEnd = 326497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendar.NativeMethodInfoPtr_GetAbsoluteDate_Internal_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x000CA460 File Offset: 0x000C8660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326498, XrefRangeEnd = 326499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetDayOfMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x000CA4B4 File Offset: 0x000C86B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326499, XrefRangeEnd = 326500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DayOfWeek GetDayOfWeek(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x000CA508 File Offset: 0x000C8708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326500, XrefRangeEnd = 326508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x000CA578 File Offset: 0x000C8778
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x000CA5DC File Offset: 0x000C87DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15454, RefRangeEnd = 15455, XrefRangeStart = 15454, XrefRangeEnd = 15455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetEra(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x000CA630 File Offset: 0x000C8830
		public unsafe override Il2CppStructArray<int> Eras
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326508, XrefRangeEnd = 326511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x000CA67C File Offset: 0x000C887C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326511, XrefRangeEnd = 326512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x000CA6D0 File Offset: 0x000C88D0
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x000CA734 File Offset: 0x000C8934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326512, XrefRangeEnd = 326513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetYear(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x000CA788 File Offset: 0x000C8988
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x000CA7EC File Offset: 0x000C89EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326513, XrefRangeEnd = 326514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x000CA8A4 File Offset: 0x000C8AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326514, XrefRangeEnd = 326518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_TryToDateTime_Internal_Virtual_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06002607 RID: 9735 RVA: 0x000CA96C File Offset: 0x000C8B6C
		public unsafe override int TwoDigitYearMax
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326518, XrefRangeEnd = 326519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x000CA9B4 File Offset: 0x000C8BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326519, XrefRangeEnd = 326546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToFourDigitYear(int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x0000D048 File Offset: 0x0000B248
		public GregorianCalendar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x000CAA08 File Offset: 0x000C8C08
		// (set) Token: 0x0600260B RID: 9739 RVA: 0x0000D051 File Offset: 0x0000B251
		public unsafe GregorianCalendarTypes m_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendar.NativeFieldInfoPtr_m_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendar.NativeFieldInfoPtr_m_type)) = value;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x000CAA30 File Offset: 0x000C8C30
		// (set) Token: 0x0600260D RID: 9741 RVA: 0x0000D06C File Offset: 0x0000B26C
		public unsafe static Il2CppStructArray<int> DaysToMonth365
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GregorianCalendar.NativeFieldInfoPtr_DaysToMonth365, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GregorianCalendar.NativeFieldInfoPtr_DaysToMonth365, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x000CAA58 File Offset: 0x000C8C58
		// (set) Token: 0x0600260F RID: 9743 RVA: 0x0000D07E File Offset: 0x0000B27E
		public unsafe static Il2CppStructArray<int> DaysToMonth366
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GregorianCalendar.NativeFieldInfoPtr_DaysToMonth366, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GregorianCalendar.NativeFieldInfoPtr_DaysToMonth366, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x000CAA80 File Offset: 0x000C8C80
		// (set) Token: 0x06002611 RID: 9745 RVA: 0x0000D090 File Offset: 0x0000B290
		public unsafe static Calendar s_defaultInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GregorianCalendar.NativeFieldInfoPtr_s_defaultInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GregorianCalendar.NativeFieldInfoPtr_s_defaultInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040021D2 RID: 8658
		private static readonly IntPtr NativeFieldInfoPtr_m_type;

		// Token: 0x040021D3 RID: 8659
		private static readonly IntPtr NativeFieldInfoPtr_DaysToMonth365;

		// Token: 0x040021D4 RID: 8660
		private static readonly IntPtr NativeFieldInfoPtr_DaysToMonth366;

		// Token: 0x040021D5 RID: 8661
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultInstance;

		// Token: 0x040021D6 RID: 8662
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x040021D7 RID: 8663
		private static readonly IntPtr NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x040021D8 RID: 8664
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x040021D9 RID: 8665
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Internal_Static_Calendar_0;

		// Token: 0x040021DA RID: 8666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040021DB RID: 8667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GregorianCalendarTypes_0;

		// Token: 0x040021DC RID: 8668
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0;

		// Token: 0x040021DD RID: 8669
		private static readonly IntPtr NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_Int64_Int32_0;

		// Token: 0x040021DE RID: 8670
		private static readonly IntPtr NativeMethodInfoPtr_GetAbsoluteDate_Internal_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x040021DF RID: 8671
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0;

		// Token: 0x040021E0 RID: 8672
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0;

		// Token: 0x040021E1 RID: 8673
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0;

		// Token: 0x040021E2 RID: 8674
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x040021E3 RID: 8675
		private static readonly IntPtr NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0;

		// Token: 0x040021E4 RID: 8676
		private static readonly IntPtr NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040021E5 RID: 8677
		private static readonly IntPtr NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0;

		// Token: 0x040021E6 RID: 8678
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x040021E7 RID: 8679
		private static readonly IntPtr NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0;

		// Token: 0x040021E8 RID: 8680
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0;

		// Token: 0x040021E9 RID: 8681
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x040021EA RID: 8682
		private static readonly IntPtr NativeMethodInfoPtr_TryToDateTime_Internal_Virtual_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0;

		// Token: 0x040021EB RID: 8683
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0;

		// Token: 0x040021EC RID: 8684
		private static readonly IntPtr NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0;
	}
}
