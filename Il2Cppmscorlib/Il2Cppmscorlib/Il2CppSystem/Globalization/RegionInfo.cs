using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000253 RID: 595
	[Serializable]
	public class RegionInfo : Object
	{
		// Token: 0x0600293F RID: 10559 RVA: 0x000D6AB4 File Offset: 0x000D4CB4
		// Note: this type is marked as 'beforefieldinit'.
		static RegionInfo()
		{
			Il2CppClassPointerStore<RegionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "RegionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr);
			RegionInfo.NativeFieldInfoPtr_currentRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "currentRegion");
			RegionInfo.NativeFieldInfoPtr_regionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "regionId");
			RegionInfo.NativeFieldInfoPtr_iso2Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "iso2Name");
			RegionInfo.NativeFieldInfoPtr_iso3Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "iso3Name");
			RegionInfo.NativeFieldInfoPtr_win3Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "win3Name");
			RegionInfo.NativeFieldInfoPtr_englishName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "englishName");
			RegionInfo.NativeFieldInfoPtr_nativeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "nativeName");
			RegionInfo.NativeFieldInfoPtr_currencySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "currencySymbol");
			RegionInfo.NativeFieldInfoPtr_isoCurrencySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "isoCurrencySymbol");
			RegionInfo.NativeFieldInfoPtr_currencyEnglishName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "currencyEnglishName");
			RegionInfo.NativeFieldInfoPtr_currencyNativeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "currencyNativeName");
			RegionInfo.NativeMethodInfoPtr_get_CurrentRegion_Public_Static_get_RegionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669890);
			RegionInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669891);
			RegionInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669892);
			RegionInfo.NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669893);
			RegionInfo.NativeMethodInfoPtr_GetByTerritory_Private_Boolean_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669894);
			RegionInfo.NativeMethodInfoPtr_construct_internal_region_from_name_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669895);
			RegionInfo.NativeMethodInfoPtr_get_CurrencyEnglishName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669896);
			RegionInfo.NativeMethodInfoPtr_get_CurrencySymbol_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669897);
			RegionInfo.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669898);
			RegionInfo.NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669899);
			RegionInfo.NativeMethodInfoPtr_get_GeoId_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669900);
			RegionInfo.NativeMethodInfoPtr_get_IsMetric_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669901);
			RegionInfo.NativeMethodInfoPtr_get_ISOCurrencySymbol_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669902);
			RegionInfo.NativeMethodInfoPtr_get_NativeName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669903);
			RegionInfo.NativeMethodInfoPtr_get_CurrencyNativeName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669904);
			RegionInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669905);
			RegionInfo.NativeMethodInfoPtr_get_ThreeLetterISORegionName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669906);
			RegionInfo.NativeMethodInfoPtr_get_ThreeLetterWindowsRegionName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669907);
			RegionInfo.NativeMethodInfoPtr_get_TwoLetterISORegionName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669908);
			RegionInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669909);
			RegionInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669910);
			RegionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669911);
			RegionInfo.NativeMethodInfoPtr_ClearCachedData_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100669912);
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x000D6D8C File Offset: 0x000D4F8C
		public unsafe static RegionInfo CurrentRegion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329956, XrefRangeEnd = 329985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr_get_CurrentRegion_Public_Static_get_RegionInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegionInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x000D6DC0 File Offset: 0x000D4FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329985, XrefRangeEnd = 329992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegionInfo(int culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x000D6E08 File Offset: 0x000D5008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329992, XrefRangeEnd = 330001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegionInfo(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x000D6E54 File Offset: 0x000D5054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330001, XrefRangeEnd = 330018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegionInfo(CultureInfo ci)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ci);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x000D6EA0 File Offset: 0x000D50A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330018, XrefRangeEnd = 330020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetByTerritory(CultureInfo ci)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ci);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr_GetByTerritory_Private_Boolean_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x000D6EF0 File Offset: 0x000D50F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330020, XrefRangeEnd = 330021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool construct_internal_region_from_name(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr_construct_internal_region_from_name_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06002946 RID: 10566 RVA: 0x000D6F40 File Offset: 0x000D5140
		public unsafe virtual string CurrencyEnglishName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_CurrencyEnglishName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06002947 RID: 10567 RVA: 0x000D6F84 File Offset: 0x000D5184
		public unsafe virtual string CurrencySymbol
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_CurrencySymbol_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06002948 RID: 10568 RVA: 0x000D6FC8 File Offset: 0x000D51C8
		public unsafe virtual string DisplayName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06002949 RID: 10569 RVA: 0x000D700C File Offset: 0x000D520C
		public unsafe virtual string EnglishName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x0600294A RID: 10570 RVA: 0x000D7050 File Offset: 0x000D5250
		public unsafe virtual int GeoId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_GeoId_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x0600294B RID: 10571 RVA: 0x000D7098 File Offset: 0x000D5298
		public unsafe virtual bool IsMetric
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330021, XrefRangeEnd = 330027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_IsMetric_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x0600294C RID: 10572 RVA: 0x000D70E0 File Offset: 0x000D52E0
		public unsafe virtual string ISOCurrencySymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_ISOCurrencySymbol_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x0600294D RID: 10573 RVA: 0x000D7124 File Offset: 0x000D5324
		public unsafe virtual string NativeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_NativeName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x000D7168 File Offset: 0x000D5368
		public unsafe virtual string CurrencyNativeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_CurrencyNativeName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x0600294F RID: 10575 RVA: 0x000D71AC File Offset: 0x000D53AC
		public unsafe virtual string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x000D71F0 File Offset: 0x000D53F0
		public unsafe virtual string ThreeLetterISORegionName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_ThreeLetterISORegionName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06002951 RID: 10577 RVA: 0x000D7234 File Offset: 0x000D5434
		public unsafe virtual string ThreeLetterWindowsRegionName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_ThreeLetterWindowsRegionName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06002952 RID: 10578 RVA: 0x000D7278 File Offset: 0x000D5478
		public unsafe virtual string TwoLetterISORegionName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_TwoLetterISORegionName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x000D72BC File Offset: 0x000D54BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330027, XrefRangeEnd = 330030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x000D7314 File Offset: 0x000D5514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330030, XrefRangeEnd = 330031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x000D735C File Offset: 0x000D555C
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x000D73A0 File Offset: 0x000D55A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330031, XrefRangeEnd = 330033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearCachedData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr_ClearCachedData_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x0000E581 File Offset: 0x0000C781
		public RegionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x000D73C8 File Offset: 0x000D55C8
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x0000E58A File Offset: 0x0000C78A
		public unsafe static RegionInfo currentRegion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegionInfo.NativeFieldInfoPtr_currentRegion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegionInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegionInfo.NativeFieldInfoPtr_currentRegion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x0600295A RID: 10586 RVA: 0x000D73F0 File Offset: 0x000D55F0
		// (set) Token: 0x0600295B RID: 10587 RVA: 0x0000E59C File Offset: 0x0000C79C
		public unsafe int regionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_regionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_regionId)) = value;
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x0600295C RID: 10588 RVA: 0x000D7418 File Offset: 0x000D5618
		// (set) Token: 0x0600295D RID: 10589 RVA: 0x0000E5B7 File Offset: 0x0000C7B7
		public unsafe string iso2Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_iso2Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_iso2Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x000D7440 File Offset: 0x000D5640
		// (set) Token: 0x0600295F RID: 10591 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
		public unsafe string iso3Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_iso3Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_iso3Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06002960 RID: 10592 RVA: 0x000D7468 File Offset: 0x000D5668
		// (set) Token: 0x06002961 RID: 10593 RVA: 0x0000E5F5 File Offset: 0x0000C7F5
		public unsafe string win3Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_win3Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_win3Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06002962 RID: 10594 RVA: 0x000D7490 File Offset: 0x000D5690
		// (set) Token: 0x06002963 RID: 10595 RVA: 0x0000E614 File Offset: 0x0000C814
		public unsafe string englishName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_englishName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_englishName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06002964 RID: 10596 RVA: 0x000D74B8 File Offset: 0x000D56B8
		// (set) Token: 0x06002965 RID: 10597 RVA: 0x0000E633 File Offset: 0x0000C833
		public unsafe string nativeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_nativeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_nativeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x000D74E0 File Offset: 0x000D56E0
		// (set) Token: 0x06002967 RID: 10599 RVA: 0x0000E652 File Offset: 0x0000C852
		public unsafe string currencySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x000D7508 File Offset: 0x000D5708
		// (set) Token: 0x06002969 RID: 10601 RVA: 0x0000E671 File Offset: 0x0000C871
		public unsafe string isoCurrencySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_isoCurrencySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_isoCurrencySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x000D7530 File Offset: 0x000D5730
		// (set) Token: 0x0600296B RID: 10603 RVA: 0x0000E690 File Offset: 0x0000C890
		public unsafe string currencyEnglishName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencyEnglishName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencyEnglishName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x0600296C RID: 10604 RVA: 0x000D7558 File Offset: 0x000D5758
		// (set) Token: 0x0600296D RID: 10605 RVA: 0x0000E6AF File Offset: 0x0000C8AF
		public unsafe string currencyNativeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencyNativeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencyNativeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002462 RID: 9314
		private static readonly IntPtr NativeFieldInfoPtr_currentRegion;

		// Token: 0x04002463 RID: 9315
		private static readonly IntPtr NativeFieldInfoPtr_regionId;

		// Token: 0x04002464 RID: 9316
		private static readonly IntPtr NativeFieldInfoPtr_iso2Name;

		// Token: 0x04002465 RID: 9317
		private static readonly IntPtr NativeFieldInfoPtr_iso3Name;

		// Token: 0x04002466 RID: 9318
		private static readonly IntPtr NativeFieldInfoPtr_win3Name;

		// Token: 0x04002467 RID: 9319
		private static readonly IntPtr NativeFieldInfoPtr_englishName;

		// Token: 0x04002468 RID: 9320
		private static readonly IntPtr NativeFieldInfoPtr_nativeName;

		// Token: 0x04002469 RID: 9321
		private static readonly IntPtr NativeFieldInfoPtr_currencySymbol;

		// Token: 0x0400246A RID: 9322
		private static readonly IntPtr NativeFieldInfoPtr_isoCurrencySymbol;

		// Token: 0x0400246B RID: 9323
		private static readonly IntPtr NativeFieldInfoPtr_currencyEnglishName;

		// Token: 0x0400246C RID: 9324
		private static readonly IntPtr NativeFieldInfoPtr_currencyNativeName;

		// Token: 0x0400246D RID: 9325
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentRegion_Public_Static_get_RegionInfo_0;

		// Token: 0x0400246E RID: 9326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400246F RID: 9327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002470 RID: 9328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0;

		// Token: 0x04002471 RID: 9329
		private static readonly IntPtr NativeMethodInfoPtr_GetByTerritory_Private_Boolean_CultureInfo_0;

		// Token: 0x04002472 RID: 9330
		private static readonly IntPtr NativeMethodInfoPtr_construct_internal_region_from_name_Private_Boolean_String_0;

		// Token: 0x04002473 RID: 9331
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyEnglishName_Public_Virtual_New_get_String_0;

		// Token: 0x04002474 RID: 9332
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencySymbol_Public_Virtual_New_get_String_0;

		// Token: 0x04002475 RID: 9333
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Virtual_New_get_String_0;

		// Token: 0x04002476 RID: 9334
		private static readonly IntPtr NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0;

		// Token: 0x04002477 RID: 9335
		private static readonly IntPtr NativeMethodInfoPtr_get_GeoId_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002478 RID: 9336
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMetric_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04002479 RID: 9337
		private static readonly IntPtr NativeMethodInfoPtr_get_ISOCurrencySymbol_Public_Virtual_New_get_String_0;

		// Token: 0x0400247A RID: 9338
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeName_Public_Virtual_New_get_String_0;

		// Token: 0x0400247B RID: 9339
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyNativeName_Public_Virtual_New_get_String_0;

		// Token: 0x0400247C RID: 9340
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x0400247D RID: 9341
		private static readonly IntPtr NativeMethodInfoPtr_get_ThreeLetterISORegionName_Public_Virtual_New_get_String_0;

		// Token: 0x0400247E RID: 9342
		private static readonly IntPtr NativeMethodInfoPtr_get_ThreeLetterWindowsRegionName_Public_Virtual_New_get_String_0;

		// Token: 0x0400247F RID: 9343
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoLetterISORegionName_Public_Virtual_New_get_String_0;

		// Token: 0x04002480 RID: 9344
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002481 RID: 9345
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002482 RID: 9346
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002483 RID: 9347
		private static readonly IntPtr NativeMethodInfoPtr_ClearCachedData_Internal_Static_Void_0;
	}
}
