using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200023D RID: 573
	[Serializable]
	public class JapaneseCalendar : Calendar
	{
		// Token: 0x06002681 RID: 9857 RVA: 0x000CC788 File Offset: 0x000CA988
		// Note: this type is marked as 'beforefieldinit'.
		static JapaneseCalendar()
		{
			Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "JapaneseCalendar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr);
			JapaneseCalendar.NativeFieldInfoPtr_calendarMinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, "calendarMinValue");
			JapaneseCalendar.NativeFieldInfoPtr_japaneseEraInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, "japaneseEraInfo");
			JapaneseCalendar.NativeFieldInfoPtr_s_defaultInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, "s_defaultInstance");
			JapaneseCalendar.NativeFieldInfoPtr_helper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, "helper");
			JapaneseCalendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669557);
			JapaneseCalendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669558);
			JapaneseCalendar.NativeMethodInfoPtr_GetEraInfo_Internal_Static_Il2CppReferenceArray_1_EraInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669559);
			JapaneseCalendar.NativeMethodInfoPtr_GetErasFromRegistry_Private_Static_Il2CppReferenceArray_1_EraInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669560);
			JapaneseCalendar.NativeMethodInfoPtr_GetDefaultInstance_Internal_Static_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669561);
			JapaneseCalendar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669562);
			JapaneseCalendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669563);
			JapaneseCalendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669564);
			JapaneseCalendar.NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669565);
			JapaneseCalendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669566);
			JapaneseCalendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669567);
			JapaneseCalendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669568);
			JapaneseCalendar.NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669569);
			JapaneseCalendar.NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669570);
			JapaneseCalendar.NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669571);
			JapaneseCalendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669572);
			JapaneseCalendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669573);
			JapaneseCalendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669574);
			JapaneseCalendar.NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669575);
			JapaneseCalendar.NativeMethodInfoPtr_EraNames_Internal_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669576);
			JapaneseCalendar.NativeMethodInfoPtr_AbbrevEraNames_Internal_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669577);
			JapaneseCalendar.NativeMethodInfoPtr_EnglishEraNames_Internal_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669578);
			JapaneseCalendar.NativeMethodInfoPtr_IsValidYear_Internal_Virtual_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669579);
			JapaneseCalendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr, 100669580);
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06002682 RID: 9858 RVA: 0x000CC9E8 File Offset: 0x000CABE8
		public unsafe override DateTime MinSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327060, XrefRangeEnd = 327064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06002683 RID: 9859 RVA: 0x000CCA30 File Offset: 0x000CAC30
		public unsafe override DateTime MaxSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327064, XrefRangeEnd = 327068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x000CCA78 File Offset: 0x000CAC78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 327131, RefRangeEnd = 327135, XrefRangeStart = 327068, XrefRangeEnd = 327131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<EraInfo> GetEraInfo()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JapaneseCalendar.NativeMethodInfoPtr_GetEraInfo_Internal_Static_Il2CppReferenceArray_1_EraInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EraInfo>>(intPtr3) : null;
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x000CCAAC File Offset: 0x000CACAC
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<EraInfo> GetErasFromRegistry()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JapaneseCalendar.NativeMethodInfoPtr_GetErasFromRegistry_Private_Static_Il2CppReferenceArray_1_EraInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EraInfo>>(intPtr3) : null;
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x000CCAE0 File Offset: 0x000CACE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327151, RefRangeEnd = 327153, XrefRangeStart = 327135, XrefRangeEnd = 327151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Calendar GetDefaultInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JapaneseCalendar.NativeMethodInfoPtr_GetDefaultInstance_Internal_Static_Calendar_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr3) : null;
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x000CCB14 File Offset: 0x000CAD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327168, RefRangeEnd = 327169, XrefRangeStart = 327153, XrefRangeEnd = 327168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JapaneseCalendar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JapaneseCalendar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JapaneseCalendar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x000CCB50 File Offset: 0x000CAD50
		public unsafe override int ID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x000CCB98 File Offset: 0x000CAD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327169, XrefRangeEnd = 327171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x000CCC08 File Offset: 0x000CAE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327171, XrefRangeEnd = 327173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x000CCC6C File Offset: 0x000CAE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327173, XrefRangeEnd = 327175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetDayOfMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x000CCCC0 File Offset: 0x000CAEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327175, XrefRangeEnd = 327177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DayOfWeek GetDayOfWeek(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x000CCD14 File Offset: 0x000CAF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327177, XrefRangeEnd = 327179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x000CCD78 File Offset: 0x000CAF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327179, XrefRangeEnd = 327181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetEra(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x000CCDCC File Offset: 0x000CAFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327181, XrefRangeEnd = 327183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x000CCE20 File Offset: 0x000CB020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327183, XrefRangeEnd = 327185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetYear(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x000CCE74 File Offset: 0x000CB074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327185, XrefRangeEnd = 327187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x000CCED8 File Offset: 0x000CB0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327187, XrefRangeEnd = 327189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x000CCF90 File Offset: 0x000CB190
		[CallerCount(0)]
		public unsafe override int ToFourDigitYear(int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x000CCFE4 File Offset: 0x000CB1E4
		public unsafe override Il2CppStructArray<int> Eras
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327189, XrefRangeEnd = 327191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x000CD030 File Offset: 0x000CB230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327191, XrefRangeEnd = 327200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray EraNames()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JapaneseCalendar.NativeMethodInfoPtr_EraNames_Internal_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x000CD064 File Offset: 0x000CB264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327200, XrefRangeEnd = 327209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray AbbrevEraNames()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JapaneseCalendar.NativeMethodInfoPtr_AbbrevEraNames_Internal_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x000CD098 File Offset: 0x000CB298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327218, RefRangeEnd = 327219, XrefRangeStart = 327209, XrefRangeEnd = 327218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray EnglishEraNames()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JapaneseCalendar.NativeMethodInfoPtr_EnglishEraNames_Internal_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x000CD0CC File Offset: 0x000CB2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327219, XrefRangeEnd = 327221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValidYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_IsValidYear_Internal_Virtual_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06002699 RID: 9881 RVA: 0x000CD130 File Offset: 0x000CB330
		public unsafe override int TwoDigitYearMax
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327221, XrefRangeEnd = 327222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JapaneseCalendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x0000D317 File Offset: 0x0000B517
		public JapaneseCalendar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x000CD178 File Offset: 0x000CB378
		// (set) Token: 0x0600269C RID: 9884 RVA: 0x0000D320 File Offset: 0x0000B520
		public unsafe static DateTime calendarMinValue
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(JapaneseCalendar.NativeFieldInfoPtr_calendarMinValue, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JapaneseCalendar.NativeFieldInfoPtr_calendarMinValue, (void*)(&value));
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x0600269D RID: 9885 RVA: 0x000CD194 File Offset: 0x000CB394
		// (set) Token: 0x0600269E RID: 9886 RVA: 0x0000D32E File Offset: 0x0000B52E
		public unsafe static Il2CppReferenceArray<EraInfo> japaneseEraInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JapaneseCalendar.NativeFieldInfoPtr_japaneseEraInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EraInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JapaneseCalendar.NativeFieldInfoPtr_japaneseEraInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x0600269F RID: 9887 RVA: 0x000CD1BC File Offset: 0x000CB3BC
		// (set) Token: 0x060026A0 RID: 9888 RVA: 0x0000D340 File Offset: 0x0000B540
		public unsafe static Calendar s_defaultInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JapaneseCalendar.NativeFieldInfoPtr_s_defaultInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JapaneseCalendar.NativeFieldInfoPtr_s_defaultInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x060026A1 RID: 9889 RVA: 0x000CD1E4 File Offset: 0x000CB3E4
		// (set) Token: 0x060026A2 RID: 9890 RVA: 0x0000D352 File Offset: 0x0000B552
		public unsafe GregorianCalendarHelper helper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JapaneseCalendar.NativeFieldInfoPtr_helper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GregorianCalendarHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JapaneseCalendar.NativeFieldInfoPtr_helper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400224A RID: 8778
		private static readonly IntPtr NativeFieldInfoPtr_calendarMinValue;

		// Token: 0x0400224B RID: 8779
		private static readonly IntPtr NativeFieldInfoPtr_japaneseEraInfo;

		// Token: 0x0400224C RID: 8780
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultInstance;

		// Token: 0x0400224D RID: 8781
		private static readonly IntPtr NativeFieldInfoPtr_helper;

		// Token: 0x0400224E RID: 8782
		private static readonly IntPtr NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x0400224F RID: 8783
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x04002250 RID: 8784
		private static readonly IntPtr NativeMethodInfoPtr_GetEraInfo_Internal_Static_Il2CppReferenceArray_1_EraInfo_0;

		// Token: 0x04002251 RID: 8785
		private static readonly IntPtr NativeMethodInfoPtr_GetErasFromRegistry_Private_Static_Il2CppReferenceArray_1_EraInfo_0;

		// Token: 0x04002252 RID: 8786
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Internal_Static_Calendar_0;

		// Token: 0x04002253 RID: 8787
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002254 RID: 8788
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0;

		// Token: 0x04002255 RID: 8789
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002256 RID: 8790
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x04002257 RID: 8791
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0;

		// Token: 0x04002258 RID: 8792
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0;

		// Token: 0x04002259 RID: 8793
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x0400225A RID: 8794
		private static readonly IntPtr NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0;

		// Token: 0x0400225B RID: 8795
		private static readonly IntPtr NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0;

		// Token: 0x0400225C RID: 8796
		private static readonly IntPtr NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0;

		// Token: 0x0400225D RID: 8797
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0;

		// Token: 0x0400225E RID: 8798
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400225F RID: 8799
		private static readonly IntPtr NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0;

		// Token: 0x04002260 RID: 8800
		private static readonly IntPtr NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002261 RID: 8801
		private static readonly IntPtr NativeMethodInfoPtr_EraNames_Internal_Static_Il2CppStringArray_0;

		// Token: 0x04002262 RID: 8802
		private static readonly IntPtr NativeMethodInfoPtr_AbbrevEraNames_Internal_Static_Il2CppStringArray_0;

		// Token: 0x04002263 RID: 8803
		private static readonly IntPtr NativeMethodInfoPtr_EnglishEraNames_Internal_Static_Il2CppStringArray_0;

		// Token: 0x04002264 RID: 8804
		private static readonly IntPtr NativeMethodInfoPtr_IsValidYear_Internal_Virtual_Boolean_Int32_Int32_0;

		// Token: 0x04002265 RID: 8805
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0;
	}
}
