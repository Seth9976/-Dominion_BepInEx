using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000110 RID: 272
	[StructLayout(2)]
	public struct XsdDateTime
	{
		// Token: 0x060010FE RID: 4350 RVA: 0x000505C8 File Offset: 0x0004E7C8
		// Note: this type is marked as 'beforefieldinit'.
		static XsdDateTime()
		{
			Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdDateTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr);
			XsdDateTime.NativeFieldInfoPtr_dt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "dt");
			XsdDateTime.NativeFieldInfoPtr_extra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "extra");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM_");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM_dd");
			XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_ddT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM_ddT");
			XsdDateTime.NativeFieldInfoPtr_LzHH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH");
			XsdDateTime.NativeFieldInfoPtr_LzHH_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_");
			XsdDateTime.NativeFieldInfoPtr_LzHH_mm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_mm");
			XsdDateTime.NativeFieldInfoPtr_LzHH_mm_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_mm_");
			XsdDateTime.NativeFieldInfoPtr_LzHH_mm_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_mm_ss");
			XsdDateTime.NativeFieldInfoPtr_Lz_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_");
			XsdDateTime.NativeFieldInfoPtr_Lz_zz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_zz");
			XsdDateTime.NativeFieldInfoPtr_Lz_zz_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_zz_");
			XsdDateTime.NativeFieldInfoPtr_Lz_zz_zz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_zz_zz");
			XsdDateTime.NativeFieldInfoPtr_Lz__ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__");
			XsdDateTime.NativeFieldInfoPtr_Lz__mm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm");
			XsdDateTime.NativeFieldInfoPtr_Lz__mm_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm_");
			XsdDateTime.NativeFieldInfoPtr_Lz__mm__ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm__");
			XsdDateTime.NativeFieldInfoPtr_Lz__mm_dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm_dd");
			XsdDateTime.NativeFieldInfoPtr_Lz___ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz___");
			XsdDateTime.NativeFieldInfoPtr_Lz___dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz___dd");
			XsdDateTime.NativeFieldInfoPtr_typeCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "typeCodes");
			XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_String_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665827);
			XsdDateTime.NativeMethodInfoPtr__ctor_Private_Void_Parser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665828);
			XsdDateTime.NativeMethodInfoPtr_InitiateXsdDateTime_Private_Void_Parser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665829);
			XsdDateTime.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_XsdDateTimeFlags_byref_XsdDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665830);
			XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTime_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665831);
			XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665832);
			XsdDateTime.NativeMethodInfoPtr_get_InternalTypeCode_Private_get_DateTimeTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665833);
			XsdDateTime.NativeMethodInfoPtr_get_InternalKind_Private_get_XsdDateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665834);
			XsdDateTime.NativeMethodInfoPtr_get_Year_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665835);
			XsdDateTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665836);
			XsdDateTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665837);
			XsdDateTime.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665838);
			XsdDateTime.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665839);
			XsdDateTime.NativeMethodInfoPtr_get_Second_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665840);
			XsdDateTime.NativeMethodInfoPtr_get_Fraction_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665841);
			XsdDateTime.NativeMethodInfoPtr_get_ZoneHour_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665842);
			XsdDateTime.NativeMethodInfoPtr_get_ZoneMinute_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665843);
			XsdDateTime.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTime_XsdDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665844);
			XsdDateTime.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_XsdDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665845);
			XsdDateTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665846);
			XsdDateTime.NativeMethodInfoPtr_PrintDate_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665847);
			XsdDateTime.NativeMethodInfoPtr_PrintTime_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665848);
			XsdDateTime.NativeMethodInfoPtr_PrintZone_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665849);
			XsdDateTime.NativeMethodInfoPtr_IntToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665850);
			XsdDateTime.NativeMethodInfoPtr_ShortToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100665851);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x000509E0 File Offset: 0x0004EBE0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 31008, RefRangeEnd = 31026, XrefRangeStart = 31006, XrefRangeEnd = 31008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDateTime(string text, XsdDateTimeFlags kinds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kinds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_String_XsdDateTimeFlags_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00050A24 File Offset: 0x0004EC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31026, XrefRangeEnd = 31027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDateTime(XsdDateTime.Parser parser)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parser));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr__ctor_Private_Void_Parser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00050A60 File Offset: 0x0004EC60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 31029, RefRangeEnd = 31032, XrefRangeStart = 31027, XrefRangeEnd = 31029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitiateXsdDateTime(XsdDateTime.Parser parser)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parser));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_InitiateXsdDateTime_Private_Void_Parser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00050A9C File Offset: 0x0004EC9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31034, RefRangeEnd = 31035, XrefRangeStart = 31032, XrefRangeEnd = 31034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kinds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_XsdDateTimeFlags_byref_XsdDateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00050AFC File Offset: 0x0004ECFC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 31049, RefRangeEnd = 31057, XrefRangeStart = 31035, XrefRangeEnd = 31049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDateTime(DateTime dateTime, XsdDateTimeFlags kinds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kinds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTime_XsdDateTimeFlags_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00050B3C File Offset: 0x0004ED3C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 31069, RefRangeEnd = 31077, XrefRangeStart = 31057, XrefRangeEnd = 31069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDateTime(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTimeOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kinds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_XsdDateTimeFlags_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x00050B7C File Offset: 0x0004ED7C
		public unsafe XsdDateTime.DateTimeTypeCode InternalTypeCode
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_InternalTypeCode_Private_get_DateTimeTypeCode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x00050BAC File Offset: 0x0004EDAC
		public unsafe XsdDateTime.XsdDateTimeKind InternalKind
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_InternalKind_Private_get_XsdDateTimeKind_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x00050BDC File Offset: 0x0004EDDC
		public unsafe int Year
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31077, XrefRangeEnd = 31078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Year_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x00050C0C File Offset: 0x0004EE0C
		public unsafe int Month
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31078, XrefRangeEnd = 31079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x00050C3C File Offset: 0x0004EE3C
		public unsafe int Day
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31079, XrefRangeEnd = 31080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x00050C6C File Offset: 0x0004EE6C
		public unsafe int Hour
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31080, XrefRangeEnd = 31081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x00050C9C File Offset: 0x0004EE9C
		public unsafe int Minute
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31081, XrefRangeEnd = 31082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x00050CCC File Offset: 0x0004EECC
		public unsafe int Second
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31082, XrefRangeEnd = 31083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Second_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x00050CFC File Offset: 0x0004EEFC
		public unsafe int Fraction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31092, RefRangeEnd = 31093, XrefRangeStart = 31083, XrefRangeEnd = 31092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_Fraction_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x00050D2C File Offset: 0x0004EF2C
		public unsafe int ZoneHour
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_ZoneHour_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x00050D5C File Offset: 0x0004EF5C
		public unsafe int ZoneMinute
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_get_ZoneMinute_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00050D8C File Offset: 0x0004EF8C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 31133, RefRangeEnd = 31143, XrefRangeStart = 31093, XrefRangeEnd = 31133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DateTime(XsdDateTime xdt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xdt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTime_XsdDateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00050DCC File Offset: 0x0004EFCC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 31173, RefRangeEnd = 31182, XrefRangeStart = 31143, XrefRangeEnd = 31173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DateTimeOffset(XsdDateTime xdt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xdt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_XsdDateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00050E0C File Offset: 0x0004F00C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 31279, RefRangeEnd = 31295, XrefRangeStart = 31182, XrefRangeEnd = 31279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00050E38 File Offset: 0x0004F038
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 31325, RefRangeEnd = 31327, XrefRangeStart = 31295, XrefRangeEnd = 31325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintDate(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_PrintDate_Private_Void_StringBuilder_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00050E70 File Offset: 0x0004F070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 31346, RefRangeEnd = 31348, XrefRangeStart = 31327, XrefRangeEnd = 31346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintTime(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_PrintTime_Private_Void_StringBuilder_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00050EA8 File Offset: 0x0004F0A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 31368, RefRangeEnd = 31371, XrefRangeStart = 31348, XrefRangeEnd = 31368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintZone(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_PrintZone_Private_Void_StringBuilder_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00050EE0 File Offset: 0x0004F0E0
		[CallerCount(0)]
		public unsafe void IntToCharArray(Il2CppStructArray<char> text, int start, int value, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_IntToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00050F40 File Offset: 0x0004F140
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 31371, RefRangeEnd = 31374, XrefRangeStart = 31371, XrefRangeEnd = 31371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShortToCharArray(Il2CppStructArray<char> text, int start, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.NativeMethodInfoPtr_ShortToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000077ED File Offset: 0x000059ED
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, ref this));
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x00050F94 File Offset: 0x0004F194
		// (set) Token: 0x0600111A RID: 4378 RVA: 0x000077FF File Offset: 0x000059FF
		public unsafe static int Lzyyyy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy, (void*)(&value));
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x00050FB0 File Offset: 0x0004F1B0
		// (set) Token: 0x0600111C RID: 4380 RVA: 0x0000780D File Offset: 0x00005A0D
		public unsafe static int Lzyyyy_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_, (void*)(&value));
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x00050FCC File Offset: 0x0004F1CC
		// (set) Token: 0x0600111E RID: 4382 RVA: 0x0000781B File Offset: 0x00005A1B
		public unsafe static int Lzyyyy_MM
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM, (void*)(&value));
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x00050FE8 File Offset: 0x0004F1E8
		// (set) Token: 0x06001120 RID: 4384 RVA: 0x00007829 File Offset: 0x00005A29
		public unsafe static int Lzyyyy_MM_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_, (void*)(&value));
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x00051004 File Offset: 0x0004F204
		// (set) Token: 0x06001122 RID: 4386 RVA: 0x00007837 File Offset: 0x00005A37
		public unsafe static int Lzyyyy_MM_dd
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_dd, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_dd, (void*)(&value));
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x00051020 File Offset: 0x0004F220
		// (set) Token: 0x06001124 RID: 4388 RVA: 0x00007845 File Offset: 0x00005A45
		public unsafe static int Lzyyyy_MM_ddT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_ddT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lzyyyy_MM_ddT, (void*)(&value));
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x0005103C File Offset: 0x0004F23C
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x00007853 File Offset: 0x00005A53
		public unsafe static int LzHH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_LzHH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_LzHH, (void*)(&value));
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x00051058 File Offset: 0x0004F258
		// (set) Token: 0x06001128 RID: 4392 RVA: 0x00007861 File Offset: 0x00005A61
		public unsafe static int LzHH_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_LzHH_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_LzHH_, (void*)(&value));
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x00051074 File Offset: 0x0004F274
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x0000786F File Offset: 0x00005A6F
		public unsafe static int LzHH_mm
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm, (void*)(&value));
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x00051090 File Offset: 0x0004F290
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x0000787D File Offset: 0x00005A7D
		public unsafe static int LzHH_mm_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm_, (void*)(&value));
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x000510AC File Offset: 0x0004F2AC
		// (set) Token: 0x0600112E RID: 4398 RVA: 0x0000788B File Offset: 0x00005A8B
		public unsafe static int LzHH_mm_ss
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm_ss, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_LzHH_mm_ss, (void*)(&value));
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x000510C8 File Offset: 0x0004F2C8
		// (set) Token: 0x06001130 RID: 4400 RVA: 0x00007899 File Offset: 0x00005A99
		public unsafe static int Lz_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz_, (void*)(&value));
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x000510E4 File Offset: 0x0004F2E4
		// (set) Token: 0x06001132 RID: 4402 RVA: 0x000078A7 File Offset: 0x00005AA7
		public unsafe static int Lz_zz
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz, (void*)(&value));
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x00051100 File Offset: 0x0004F300
		// (set) Token: 0x06001134 RID: 4404 RVA: 0x000078B5 File Offset: 0x00005AB5
		public unsafe static int Lz_zz_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz_, (void*)(&value));
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x0005111C File Offset: 0x0004F31C
		// (set) Token: 0x06001136 RID: 4406 RVA: 0x000078C3 File Offset: 0x00005AC3
		public unsafe static int Lz_zz_zz
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz_zz, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz_zz_zz, (void*)(&value));
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x00051138 File Offset: 0x0004F338
		// (set) Token: 0x06001138 RID: 4408 RVA: 0x000078D1 File Offset: 0x00005AD1
		public unsafe static int Lz__
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz__, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz__, (void*)(&value));
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x00051154 File Offset: 0x0004F354
		// (set) Token: 0x0600113A RID: 4410 RVA: 0x000078DF File Offset: 0x00005ADF
		public unsafe static int Lz__mm
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm, (void*)(&value));
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x00051170 File Offset: 0x0004F370
		// (set) Token: 0x0600113C RID: 4412 RVA: 0x000078ED File Offset: 0x00005AED
		public unsafe static int Lz__mm_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm_, (void*)(&value));
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x0005118C File Offset: 0x0004F38C
		// (set) Token: 0x0600113E RID: 4414 RVA: 0x000078FB File Offset: 0x00005AFB
		public unsafe static int Lz__mm__
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm__, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm__, (void*)(&value));
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x000511A8 File Offset: 0x0004F3A8
		// (set) Token: 0x06001140 RID: 4416 RVA: 0x00007909 File Offset: 0x00005B09
		public unsafe static int Lz__mm_dd
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm_dd, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz__mm_dd, (void*)(&value));
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x000511C4 File Offset: 0x0004F3C4
		// (set) Token: 0x06001142 RID: 4418 RVA: 0x00007917 File Offset: 0x00005B17
		public unsafe static int Lz___
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz___, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz___, (void*)(&value));
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x000511E0 File Offset: 0x0004F3E0
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x00007925 File Offset: 0x00005B25
		public unsafe static int Lz___dd
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_Lz___dd, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_Lz___dd, (void*)(&value));
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x000511FC File Offset: 0x0004F3FC
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x00007933 File Offset: 0x00005B33
		public unsafe static Il2CppStructArray<XmlTypeCode> typeCodes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdDateTime.NativeFieldInfoPtr_typeCodes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlTypeCode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdDateTime.NativeFieldInfoPtr_typeCodes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeFieldInfoPtr_dt;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeFieldInfoPtr_extra;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM_;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM_dd;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM_ddT;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeFieldInfoPtr_LzHH;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_mm;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_mm_;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_mm_ss;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeFieldInfoPtr_Lz_;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeFieldInfoPtr_Lz_zz;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeFieldInfoPtr_Lz_zz_;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeFieldInfoPtr_Lz_zz_zz;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeFieldInfoPtr_Lz__;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeFieldInfoPtr_Lz__mm;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeFieldInfoPtr_Lz__mm_;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeFieldInfoPtr_Lz__mm__;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeFieldInfoPtr_Lz__mm_dd;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeFieldInfoPtr_Lz___;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeFieldInfoPtr_Lz___dd;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeFieldInfoPtr_typeCodes;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_XsdDateTimeFlags_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Parser_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_InitiateXsdDateTime_Private_Void_Parser_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_XsdDateTimeFlags_byref_XsdDateTime_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_XsdDateTimeFlags_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_XsdDateTimeFlags_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalTypeCode_Private_get_DateTimeTypeCode_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalKind_Private_get_XsdDateTimeKind_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_get_Year_Public_get_Int32_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr_get_Month_Public_get_Int32_0;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr_get_Day_Public_get_Int32_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr_get_Hour_Public_get_Int32_0;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeMethodInfoPtr_get_Minute_Public_get_Int32_0;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr_get_Second_Public_get_Int32_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr_get_Fraction_Public_get_Int32_0;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_get_ZoneHour_Public_get_Int32_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_get_ZoneMinute_Public_get_Int32_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DateTime_XsdDateTime_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_XsdDateTime_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_PrintDate_Private_Void_StringBuilder_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_PrintTime_Private_Void_StringBuilder_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_PrintZone_Private_Void_StringBuilder_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_IntToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_Int32_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_ShortToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000D31 RID: 3377
		[FieldOffset(0)]
		public DateTime dt;

		// Token: 0x04000D32 RID: 3378
		[FieldOffset(8)]
		public uint extra;

		// Token: 0x02000139 RID: 313
		public enum DateTimeTypeCode
		{
			// Token: 0x04000EE0 RID: 3808
			DateTime,
			// Token: 0x04000EE1 RID: 3809
			Time,
			// Token: 0x04000EE2 RID: 3810
			Date,
			// Token: 0x04000EE3 RID: 3811
			GYearMonth,
			// Token: 0x04000EE4 RID: 3812
			GYear,
			// Token: 0x04000EE5 RID: 3813
			GMonthDay,
			// Token: 0x04000EE6 RID: 3814
			GDay,
			// Token: 0x04000EE7 RID: 3815
			GMonth,
			// Token: 0x04000EE8 RID: 3816
			XdrDateTime
		}

		// Token: 0x0200013A RID: 314
		public enum XsdDateTimeKind
		{
			// Token: 0x04000EEA RID: 3818
			Unspecified,
			// Token: 0x04000EEB RID: 3819
			Zulu,
			// Token: 0x04000EEC RID: 3820
			LocalWestOfZulu,
			// Token: 0x04000EED RID: 3821
			LocalEastOfZulu
		}

		// Token: 0x0200013B RID: 315
		public sealed class Parser : ValueType
		{
			// Token: 0x060012D8 RID: 4824 RVA: 0x00055E70 File Offset: 0x00054070
			// Note: this type is marked as 'beforefieldinit'.
			static Parser()
			{
				Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Parser");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr);
				XsdDateTime.Parser.NativeFieldInfoPtr_typeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "typeCode");
				XsdDateTime.Parser.NativeFieldInfoPtr_year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "year");
				XsdDateTime.Parser.NativeFieldInfoPtr_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "month");
				XsdDateTime.Parser.NativeFieldInfoPtr_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "day");
				XsdDateTime.Parser.NativeFieldInfoPtr_hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "hour");
				XsdDateTime.Parser.NativeFieldInfoPtr_minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "minute");
				XsdDateTime.Parser.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "second");
				XsdDateTime.Parser.NativeFieldInfoPtr_fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "fraction");
				XsdDateTime.Parser.NativeFieldInfoPtr_kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "kind");
				XsdDateTime.Parser.NativeFieldInfoPtr_zoneHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "zoneHour");
				XsdDateTime.Parser.NativeFieldInfoPtr_zoneMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "zoneMinute");
				XsdDateTime.Parser.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "text");
				XsdDateTime.Parser.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "length");
				XsdDateTime.Parser.NativeFieldInfoPtr_Power10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, "Power10");
				XsdDateTime.Parser.NativeMethodInfoPtr_Parse_Public_Boolean_String_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100665853);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseDate_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100665854);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseTimeAndZoneAndWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100665855);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseTimeAndWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100665856);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseTime_Private_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100665857);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseZoneAndWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100665858);
				XsdDateTime.Parser.NativeMethodInfoPtr_Parse4Dig_Private_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100665859);
				XsdDateTime.Parser.NativeMethodInfoPtr_Parse2Dig_Private_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100665860);
				XsdDateTime.Parser.NativeMethodInfoPtr_ParseChar_Private_Boolean_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100665861);
				XsdDateTime.Parser.NativeMethodInfoPtr_Test_Private_Static_Boolean_XsdDateTimeFlags_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr, 100665862);
			}

			// Token: 0x060012D9 RID: 4825 RVA: 0x0005607C File Offset: 0x0005427C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30898, RefRangeEnd = 30900, XrefRangeStart = 30873, XrefRangeEnd = 30898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Parse(string text, XsdDateTimeFlags kinds)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kinds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_Parse_Public_Boolean_String_XsdDateTimeFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060012DA RID: 4826 RVA: 0x000560DC File Offset: 0x000542DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30923, RefRangeEnd = 30924, XrefRangeStart = 30900, XrefRangeEnd = 30923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseDate(int start)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseDate_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060012DB RID: 4827 RVA: 0x0005612C File Offset: 0x0005432C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30924, XrefRangeEnd = 30926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseTimeAndZoneAndWhitespace(int start)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseTimeAndZoneAndWhitespace_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060012DC RID: 4828 RVA: 0x0005617C File Offset: 0x0005437C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30926, XrefRangeEnd = 30927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseTimeAndWhitespace(int start)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseTimeAndWhitespace_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060012DD RID: 4829 RVA: 0x000561CC File Offset: 0x000543CC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 30958, RefRangeEnd = 30961, XrefRangeStart = 30927, XrefRangeEnd = 30958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseTime(ref int start)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &start;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseTime_Private_Boolean_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060012DE RID: 4830 RVA: 0x0005621C File Offset: 0x0005441C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30988, RefRangeEnd = 30990, XrefRangeStart = 30961, XrefRangeEnd = 30988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ParseZoneAndWhitespace(int start)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseZoneAndWhitespace_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060012DF RID: 4831 RVA: 0x0005626C File Offset: 0x0005446C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30995, RefRangeEnd = 30996, XrefRangeStart = 30990, XrefRangeEnd = 30995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Parse4Dig(int start, ref int num)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_Parse4Dig_Private_Boolean_Int32_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060012E0 RID: 4832 RVA: 0x000562C8 File Offset: 0x000544C8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 30999, RefRangeEnd = 31006, XrefRangeStart = 30996, XrefRangeEnd = 30999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Parse2Dig(int start, ref int num)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_Parse2Dig_Private_Boolean_Int32_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060012E1 RID: 4833 RVA: 0x00056324 File Offset: 0x00054524
			[CallerCount(0)]
			public unsafe bool ParseChar(int start, char ch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_ParseChar_Private_Boolean_Int32_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060012E2 RID: 4834 RVA: 0x00056380 File Offset: 0x00054580
			[CallerCount(0)]
			public unsafe static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref left;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDateTime.Parser.NativeMethodInfoPtr_Test_Private_Static_Boolean_XsdDateTimeFlags_XsdDateTimeFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060012E3 RID: 4835 RVA: 0x0000875E File Offset: 0x0000695E
			public Parser(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060012E4 RID: 4836 RVA: 0x00008767 File Offset: 0x00006967
			public Parser()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdDateTime.Parser>.NativeClassPtr))
			{
			}

			// Token: 0x17000691 RID: 1681
			// (get) Token: 0x060012E5 RID: 4837 RVA: 0x000563CC File Offset: 0x000545CC
			// (set) Token: 0x060012E6 RID: 4838 RVA: 0x00008779 File Offset: 0x00006979
			public unsafe XsdDateTime.DateTimeTypeCode typeCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_typeCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_typeCode)) = value;
				}
			}

			// Token: 0x17000692 RID: 1682
			// (get) Token: 0x060012E7 RID: 4839 RVA: 0x000563F4 File Offset: 0x000545F4
			// (set) Token: 0x060012E8 RID: 4840 RVA: 0x00008794 File Offset: 0x00006994
			public unsafe int year
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_year);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_year)) = value;
				}
			}

			// Token: 0x17000693 RID: 1683
			// (get) Token: 0x060012E9 RID: 4841 RVA: 0x0005641C File Offset: 0x0005461C
			// (set) Token: 0x060012EA RID: 4842 RVA: 0x000087AF File Offset: 0x000069AF
			public unsafe int month
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_month);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_month)) = value;
				}
			}

			// Token: 0x17000694 RID: 1684
			// (get) Token: 0x060012EB RID: 4843 RVA: 0x00056444 File Offset: 0x00054644
			// (set) Token: 0x060012EC RID: 4844 RVA: 0x000087CA File Offset: 0x000069CA
			public unsafe int day
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_day);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_day)) = value;
				}
			}

			// Token: 0x17000695 RID: 1685
			// (get) Token: 0x060012ED RID: 4845 RVA: 0x0005646C File Offset: 0x0005466C
			// (set) Token: 0x060012EE RID: 4846 RVA: 0x000087E5 File Offset: 0x000069E5
			public unsafe int hour
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_hour);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_hour)) = value;
				}
			}

			// Token: 0x17000696 RID: 1686
			// (get) Token: 0x060012EF RID: 4847 RVA: 0x00056494 File Offset: 0x00054694
			// (set) Token: 0x060012F0 RID: 4848 RVA: 0x00008800 File Offset: 0x00006A00
			public unsafe int minute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_minute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_minute)) = value;
				}
			}

			// Token: 0x17000697 RID: 1687
			// (get) Token: 0x060012F1 RID: 4849 RVA: 0x000564BC File Offset: 0x000546BC
			// (set) Token: 0x060012F2 RID: 4850 RVA: 0x0000881B File Offset: 0x00006A1B
			public unsafe int second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_second);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_second)) = value;
				}
			}

			// Token: 0x17000698 RID: 1688
			// (get) Token: 0x060012F3 RID: 4851 RVA: 0x000564E4 File Offset: 0x000546E4
			// (set) Token: 0x060012F4 RID: 4852 RVA: 0x00008836 File Offset: 0x00006A36
			public unsafe int fraction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_fraction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_fraction)) = value;
				}
			}

			// Token: 0x17000699 RID: 1689
			// (get) Token: 0x060012F5 RID: 4853 RVA: 0x0005650C File Offset: 0x0005470C
			// (set) Token: 0x060012F6 RID: 4854 RVA: 0x00008851 File Offset: 0x00006A51
			public unsafe XsdDateTime.XsdDateTimeKind kind
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_kind);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_kind)) = value;
				}
			}

			// Token: 0x1700069A RID: 1690
			// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00056534 File Offset: 0x00054734
			// (set) Token: 0x060012F8 RID: 4856 RVA: 0x0000886C File Offset: 0x00006A6C
			public unsafe int zoneHour
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_zoneHour);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_zoneHour)) = value;
				}
			}

			// Token: 0x1700069B RID: 1691
			// (get) Token: 0x060012F9 RID: 4857 RVA: 0x0005655C File Offset: 0x0005475C
			// (set) Token: 0x060012FA RID: 4858 RVA: 0x00008887 File Offset: 0x00006A87
			public unsafe int zoneMinute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_zoneMinute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_zoneMinute)) = value;
				}
			}

			// Token: 0x1700069C RID: 1692
			// (get) Token: 0x060012FB RID: 4859 RVA: 0x00056584 File Offset: 0x00054784
			// (set) Token: 0x060012FC RID: 4860 RVA: 0x000088A2 File Offset: 0x00006AA2
			public unsafe string text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700069D RID: 1693
			// (get) Token: 0x060012FD RID: 4861 RVA: 0x000565AC File Offset: 0x000547AC
			// (set) Token: 0x060012FE RID: 4862 RVA: 0x000088C1 File Offset: 0x00006AC1
			public unsafe int length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdDateTime.Parser.NativeFieldInfoPtr_length)) = value;
				}
			}

			// Token: 0x1700069E RID: 1694
			// (get) Token: 0x060012FF RID: 4863 RVA: 0x000565D4 File Offset: 0x000547D4
			// (set) Token: 0x06001300 RID: 4864 RVA: 0x000088DC File Offset: 0x00006ADC
			public unsafe static Il2CppStructArray<int> Power10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XsdDateTime.Parser.NativeFieldInfoPtr_Power10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XsdDateTime.Parser.NativeFieldInfoPtr_Power10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000EEE RID: 3822
			private static readonly IntPtr NativeFieldInfoPtr_typeCode;

			// Token: 0x04000EEF RID: 3823
			private static readonly IntPtr NativeFieldInfoPtr_year;

			// Token: 0x04000EF0 RID: 3824
			private static readonly IntPtr NativeFieldInfoPtr_month;

			// Token: 0x04000EF1 RID: 3825
			private static readonly IntPtr NativeFieldInfoPtr_day;

			// Token: 0x04000EF2 RID: 3826
			private static readonly IntPtr NativeFieldInfoPtr_hour;

			// Token: 0x04000EF3 RID: 3827
			private static readonly IntPtr NativeFieldInfoPtr_minute;

			// Token: 0x04000EF4 RID: 3828
			private static readonly IntPtr NativeFieldInfoPtr_second;

			// Token: 0x04000EF5 RID: 3829
			private static readonly IntPtr NativeFieldInfoPtr_fraction;

			// Token: 0x04000EF6 RID: 3830
			private static readonly IntPtr NativeFieldInfoPtr_kind;

			// Token: 0x04000EF7 RID: 3831
			private static readonly IntPtr NativeFieldInfoPtr_zoneHour;

			// Token: 0x04000EF8 RID: 3832
			private static readonly IntPtr NativeFieldInfoPtr_zoneMinute;

			// Token: 0x04000EF9 RID: 3833
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x04000EFA RID: 3834
			private static readonly IntPtr NativeFieldInfoPtr_length;

			// Token: 0x04000EFB RID: 3835
			private static readonly IntPtr NativeFieldInfoPtr_Power10;

			// Token: 0x04000EFC RID: 3836
			private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Boolean_String_XsdDateTimeFlags_0;

			// Token: 0x04000EFD RID: 3837
			private static readonly IntPtr NativeMethodInfoPtr_ParseDate_Private_Boolean_Int32_0;

			// Token: 0x04000EFE RID: 3838
			private static readonly IntPtr NativeMethodInfoPtr_ParseTimeAndZoneAndWhitespace_Private_Boolean_Int32_0;

			// Token: 0x04000EFF RID: 3839
			private static readonly IntPtr NativeMethodInfoPtr_ParseTimeAndWhitespace_Private_Boolean_Int32_0;

			// Token: 0x04000F00 RID: 3840
			private static readonly IntPtr NativeMethodInfoPtr_ParseTime_Private_Boolean_byref_Int32_0;

			// Token: 0x04000F01 RID: 3841
			private static readonly IntPtr NativeMethodInfoPtr_ParseZoneAndWhitespace_Private_Boolean_Int32_0;

			// Token: 0x04000F02 RID: 3842
			private static readonly IntPtr NativeMethodInfoPtr_Parse4Dig_Private_Boolean_Int32_byref_Int32_0;

			// Token: 0x04000F03 RID: 3843
			private static readonly IntPtr NativeMethodInfoPtr_Parse2Dig_Private_Boolean_Int32_byref_Int32_0;

			// Token: 0x04000F04 RID: 3844
			private static readonly IntPtr NativeMethodInfoPtr_ParseChar_Private_Boolean_Int32_Char_0;

			// Token: 0x04000F05 RID: 3845
			private static readonly IntPtr NativeMethodInfoPtr_Test_Private_Static_Boolean_XsdDateTimeFlags_XsdDateTimeFlags_0;
		}
	}
}
