using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000243 RID: 579
	[Serializable]
	public class ThaiBuddhistCalendar : Calendar
	{
		// Token: 0x06002779 RID: 10105 RVA: 0x000D03BC File Offset: 0x000CE5BC
		// Note: this type is marked as 'beforefieldinit'.
		static ThaiBuddhistCalendar()
		{
			Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "ThaiBuddhistCalendar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr);
			ThaiBuddhistCalendar.NativeFieldInfoPtr_thaiBuddhistEraInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, "thaiBuddhistEraInfo");
			ThaiBuddhistCalendar.NativeFieldInfoPtr_helper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, "helper");
			ThaiBuddhistCalendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669681);
			ThaiBuddhistCalendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669682);
			ThaiBuddhistCalendar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669683);
			ThaiBuddhistCalendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669684);
			ThaiBuddhistCalendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669685);
			ThaiBuddhistCalendar.NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669686);
			ThaiBuddhistCalendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669687);
			ThaiBuddhistCalendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669688);
			ThaiBuddhistCalendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669689);
			ThaiBuddhistCalendar.NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669690);
			ThaiBuddhistCalendar.NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669691);
			ThaiBuddhistCalendar.NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669692);
			ThaiBuddhistCalendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669693);
			ThaiBuddhistCalendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669694);
			ThaiBuddhistCalendar.NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669695);
			ThaiBuddhistCalendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669696);
			ThaiBuddhistCalendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr, 100669697);
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x000D0568 File Offset: 0x000CE768
		public unsafe override DateTime MinSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327781, XrefRangeEnd = 327785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x000D05B0 File Offset: 0x000CE7B0
		public unsafe override DateTime MaxSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327785, XrefRangeEnd = 327789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x000D05F8 File Offset: 0x000CE7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327789, XrefRangeEnd = 327798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThaiBuddhistCalendar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThaiBuddhistCalendar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThaiBuddhistCalendar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x000D0634 File Offset: 0x000CE834
		public unsafe override int ID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x000D067C File Offset: 0x000CE87C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x000D06EC File Offset: 0x000CE8EC
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x000D0750 File Offset: 0x000CE950
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x000D07A4 File Offset: 0x000CE9A4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x000D07F8 File Offset: 0x000CE9F8
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x000D085C File Offset: 0x000CEA5C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x000D08B0 File Offset: 0x000CEAB0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x000D0904 File Offset: 0x000CEB04
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x000D0958 File Offset: 0x000CEB58
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x000D09BC File Offset: 0x000CEBBC
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06002788 RID: 10120 RVA: 0x000D0A74 File Offset: 0x000CEC74
		public unsafe override Il2CppStructArray<int> Eras
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06002789 RID: 10121 RVA: 0x000D0AC0 File Offset: 0x000CECC0
		public unsafe override int TwoDigitYearMax
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327798, XrefRangeEnd = 327799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x000D0B08 File Offset: 0x000CED08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327799, XrefRangeEnd = 327819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToFourDigitYear(int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThaiBuddhistCalendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x0000D973 File Offset: 0x0000BB73
		public ThaiBuddhistCalendar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x0600278C RID: 10124 RVA: 0x000D0B5C File Offset: 0x000CED5C
		// (set) Token: 0x0600278D RID: 10125 RVA: 0x0000D97C File Offset: 0x0000BB7C
		public unsafe static Il2CppReferenceArray<EraInfo> thaiBuddhistEraInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThaiBuddhistCalendar.NativeFieldInfoPtr_thaiBuddhistEraInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EraInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThaiBuddhistCalendar.NativeFieldInfoPtr_thaiBuddhistEraInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x0600278E RID: 10126 RVA: 0x000D0B84 File Offset: 0x000CED84
		// (set) Token: 0x0600278F RID: 10127 RVA: 0x0000D98E File Offset: 0x0000BB8E
		public unsafe GregorianCalendarHelper helper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThaiBuddhistCalendar.NativeFieldInfoPtr_helper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GregorianCalendarHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThaiBuddhistCalendar.NativeFieldInfoPtr_helper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002310 RID: 8976
		private static readonly IntPtr NativeFieldInfoPtr_thaiBuddhistEraInfo;

		// Token: 0x04002311 RID: 8977
		private static readonly IntPtr NativeFieldInfoPtr_helper;

		// Token: 0x04002312 RID: 8978
		private static readonly IntPtr NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x04002313 RID: 8979
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x04002314 RID: 8980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002315 RID: 8981
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0;

		// Token: 0x04002316 RID: 8982
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002317 RID: 8983
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x04002318 RID: 8984
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0;

		// Token: 0x04002319 RID: 8985
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0;

		// Token: 0x0400231A RID: 8986
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x0400231B RID: 8987
		private static readonly IntPtr NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0;

		// Token: 0x0400231C RID: 8988
		private static readonly IntPtr NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0;

		// Token: 0x0400231D RID: 8989
		private static readonly IntPtr NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0;

		// Token: 0x0400231E RID: 8990
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0;

		// Token: 0x0400231F RID: 8991
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0;

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0;
	}
}
