using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200024F RID: 591
	[Serializable]
	public class CultureInfo : Object
	{
		// Token: 0x06002886 RID: 10374 RVA: 0x000D41B0 File Offset: 0x000D23B0
		// Note: this type is marked as 'beforefieldinit'.
		static CultureInfo()
		{
			Il2CppClassPointerStore<CultureInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CultureInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr);
			CultureInfo.NativeFieldInfoPtr_invariant_culture_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "invariant_culture_info");
			CultureInfo.NativeFieldInfoPtr_shared_table_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "shared_table_lock");
			CultureInfo.NativeFieldInfoPtr_default_current_culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "default_current_culture");
			CultureInfo.NativeFieldInfoPtr_m_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_isReadOnly");
			CultureInfo.NativeFieldInfoPtr_cultureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "cultureID");
			CultureInfo.NativeFieldInfoPtr_parent_lcid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "parent_lcid");
			CultureInfo.NativeFieldInfoPtr_datetime_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "datetime_index");
			CultureInfo.NativeFieldInfoPtr_number_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "number_index");
			CultureInfo.NativeFieldInfoPtr_default_calendar_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "default_calendar_type");
			CultureInfo.NativeFieldInfoPtr_m_useUserOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_useUserOverride");
			CultureInfo.NativeFieldInfoPtr_numInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "numInfo");
			CultureInfo.NativeFieldInfoPtr_dateTimeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "dateTimeInfo");
			CultureInfo.NativeFieldInfoPtr_textInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "textInfo");
			CultureInfo.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_name");
			CultureInfo.NativeFieldInfoPtr_englishname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "englishname");
			CultureInfo.NativeFieldInfoPtr_nativename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "nativename");
			CultureInfo.NativeFieldInfoPtr_iso3lang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "iso3lang");
			CultureInfo.NativeFieldInfoPtr_iso2lang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "iso2lang");
			CultureInfo.NativeFieldInfoPtr_win3lang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "win3lang");
			CultureInfo.NativeFieldInfoPtr_territory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "territory");
			CultureInfo.NativeFieldInfoPtr_native_calendar_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "native_calendar_names");
			CultureInfo.NativeFieldInfoPtr_compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "compareInfo");
			CultureInfo.NativeFieldInfoPtr_textinfo_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "textinfo_data");
			CultureInfo.NativeFieldInfoPtr_m_dataItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_dataItem");
			CultureInfo.NativeFieldInfoPtr_calendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "calendar");
			CultureInfo.NativeFieldInfoPtr_parent_culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "parent_culture");
			CultureInfo.NativeFieldInfoPtr_constructed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "constructed");
			CultureInfo.NativeFieldInfoPtr_cached_serialized_form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "cached_serialized_form");
			CultureInfo.NativeFieldInfoPtr_m_cultureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_cultureData");
			CultureInfo.NativeFieldInfoPtr_m_isInherited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_isInherited");
			CultureInfo.NativeFieldInfoPtr_InvariantCultureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "InvariantCultureId");
			CultureInfo.NativeFieldInfoPtr_CalendarTypeBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "CalendarTypeBits");
			CultureInfo.NativeFieldInfoPtr_MSG_READONLY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "MSG_READONLY");
			CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "s_DefaultThreadCurrentUICulture");
			CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "s_DefaultThreadCurrentCulture");
			CultureInfo.NativeFieldInfoPtr_shared_by_number = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "shared_by_number");
			CultureInfo.NativeFieldInfoPtr_shared_by_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "shared_by_name");
			CultureInfo.NativeFieldInfoPtr_IsTaiwanSku = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "IsTaiwanSku");
			CultureInfo.NativeMethodInfoPtr_get_InvariantCulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669810);
			CultureInfo.NativeMethodInfoPtr_get_CurrentCulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669811);
			CultureInfo.NativeMethodInfoPtr_get_CurrentUICulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669812);
			CultureInfo.NativeMethodInfoPtr_ConstructCurrentCulture_Internal_Static_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669813);
			CultureInfo.NativeMethodInfoPtr_ConstructCurrentUICulture_Internal_Static_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669814);
			CultureInfo.NativeMethodInfoPtr_get_Territory_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669815);
			CultureInfo.NativeMethodInfoPtr_get_LCID_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669816);
			CultureInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669817);
			CultureInfo.NativeMethodInfoPtr_get_Calendar_Public_Virtual_New_get_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669818);
			CultureInfo.NativeMethodInfoPtr_get_Parent_Public_Virtual_New_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669819);
			CultureInfo.NativeMethodInfoPtr_get_TextInfo_Public_Virtual_New_get_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669820);
			CultureInfo.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669821);
			CultureInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669822);
			CultureInfo.NativeMethodInfoPtr_GetCultures_Public_Static_Il2CppReferenceArray_1_CultureInfo_CultureTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669823);
			CultureInfo.NativeMethodInfoPtr_GetTextInfoData_Private_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669824);
			CultureInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669825);
			CultureInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669826);
			CultureInfo.NativeMethodInfoPtr_get_CompareInfo_Public_Virtual_New_get_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669827);
			CultureInfo.NativeMethodInfoPtr_get_IsNeutralCulture_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669828);
			CultureInfo.NativeMethodInfoPtr_CheckNeutral_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669829);
			CultureInfo.NativeMethodInfoPtr_get_NumberFormat_Public_Virtual_New_get_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669830);
			CultureInfo.NativeMethodInfoPtr_set_NumberFormat_Public_Virtual_New_set_Void_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669831);
			CultureInfo.NativeMethodInfoPtr_get_DateTimeFormat_Public_Virtual_New_get_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669832);
			CultureInfo.NativeMethodInfoPtr_set_DateTimeFormat_Public_Virtual_New_set_Void_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669833);
			CultureInfo.NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669834);
			CultureInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669835);
			CultureInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669836);
			CultureInfo.NativeMethodInfoPtr_Construct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669837);
			CultureInfo.NativeMethodInfoPtr_construct_internal_locale_from_lcid_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669838);
			CultureInfo.NativeMethodInfoPtr_construct_internal_locale_from_name_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669839);
			CultureInfo.NativeMethodInfoPtr_get_current_locale_name_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669840);
			CultureInfo.NativeMethodInfoPtr_internal_get_cultures_Private_Static_Il2CppReferenceArray_1_CultureInfo_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669841);
			CultureInfo.NativeMethodInfoPtr_ConstructInvariant_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669842);
			CultureInfo.NativeMethodInfoPtr_CreateTextInfo_Private_TextInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669843);
			CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669844);
			CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669845);
			CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669846);
			CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669847);
			CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669848);
			CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669849);
			CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669850);
			CultureInfo.NativeMethodInfoPtr_insert_into_shared_tables_Private_Static_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669851);
			CultureInfo.NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669852);
			CultureInfo.NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669853);
			CultureInfo.NativeMethodInfoPtr_CreateCulture_Internal_Static_CultureInfo_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669854);
			CultureInfo.NativeMethodInfoPtr_CreateSpecificCulture_Public_Static_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669855);
			CultureInfo.NativeMethodInfoPtr_CreateSpecificCultureFromNeutral_Private_Static_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669856);
			CultureInfo.NativeMethodInfoPtr_get_CalendarType_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669857);
			CultureInfo.NativeMethodInfoPtr_CreateCalendar_Private_Static_Calendar_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669858);
			CultureInfo.NativeMethodInfoPtr_CreateNotFoundException_Private_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669859);
			CultureInfo.NativeMethodInfoPtr_get_DefaultThreadCurrentCulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669860);
			CultureInfo.NativeMethodInfoPtr_get_DefaultThreadCurrentUICulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669861);
			CultureInfo.NativeMethodInfoPtr_get_SortName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669862);
			CultureInfo.NativeMethodInfoPtr_get_UserDefaultUICulture_Internal_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669863);
			CultureInfo.NativeMethodInfoPtr_get_UserDefaultCulture_Internal_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669864);
			CultureInfo.NativeMethodInfoPtr_CheckDomainSafetyObject_Internal_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669865);
			CultureInfo.NativeMethodInfoPtr_get_HasInvariantCultureName_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669866);
			CultureInfo.NativeMethodInfoPtr_VerifyCultureName_Internal_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669867);
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06002887 RID: 10375 RVA: 0x000D4960 File Offset: 0x000D2B60
		public unsafe static CultureInfo InvariantCulture
		{
			[CallerCount(166)]
			[CachedScanResults(RefRangeStart = 328560, RefRangeEnd = 328726, XrefRangeStart = 328555, XrefRangeEnd = 328560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_InvariantCulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06002888 RID: 10376 RVA: 0x000D4994 File Offset: 0x000D2B94
		public unsafe static CultureInfo CurrentCulture
		{
			[CallerCount(70)]
			[CachedScanResults(RefRangeStart = 328729, RefRangeEnd = 328799, XrefRangeStart = 328726, XrefRangeEnd = 328729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_CurrentCulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06002889 RID: 10377 RVA: 0x000D49C8 File Offset: 0x000D2BC8
		public unsafe static CultureInfo CurrentUICulture
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 328802, RefRangeEnd = 328807, XrefRangeStart = 328799, XrefRangeEnd = 328802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_CurrentUICulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x000D49FC File Offset: 0x000D2BFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 328824, RefRangeEnd = 328827, XrefRangeStart = 328807, XrefRangeEnd = 328824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo ConstructCurrentCulture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_ConstructCurrentCulture_Internal_Static_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x000D4A30 File Offset: 0x000D2C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328827, XrefRangeEnd = 328831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo ConstructCurrentUICulture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_ConstructCurrentUICulture_Internal_Static_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x000D4A64 File Offset: 0x000D2C64
		public unsafe string Territory
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_Territory_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x0600288D RID: 10381 RVA: 0x000D4A9C File Offset: 0x000D2C9C
		public unsafe virtual int LCID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_LCID_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x000D4AE4 File Offset: 0x000D2CE4
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x0600288F RID: 10383 RVA: 0x000D4B28 File Offset: 0x000D2D28
		public unsafe virtual Calendar Calendar
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328831, XrefRangeEnd = 328836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_Calendar_Public_Virtual_New_get_Calendar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr3) : null;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x000D4B74 File Offset: 0x000D2D74
		public unsafe virtual CultureInfo Parent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328836, XrefRangeEnd = 328848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_Parent_Public_Virtual_New_get_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06002891 RID: 10385 RVA: 0x000D4BC0 File Offset: 0x000D2DC0
		public unsafe virtual TextInfo TextInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328848, XrefRangeEnd = 328860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_TextInfo_Public_Virtual_New_get_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x000D4C0C File Offset: 0x000D2E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328860, XrefRangeEnd = 328870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x000D4C58 File Offset: 0x000D2E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328870, XrefRangeEnd = 328873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x000D4CB0 File Offset: 0x000D2EB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328891, RefRangeEnd = 328892, XrefRangeStart = 328873, XrefRangeEnd = 328891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CultureInfo> GetCultures(CultureTypes types)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref types;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_GetCultures_Public_Static_Il2CppReferenceArray_1_CultureInfo_CultureTypes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CultureInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x000D4CF0 File Offset: 0x000D2EF0
		[CallerCount(0)]
		public unsafe CultureInfo.Data GetTextInfoData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_GetTextInfoData_Private_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x000D4D2C File Offset: 0x000D2F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328892, XrefRangeEnd = 328893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x000D4D74 File Offset: 0x000D2F74
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x000D4DB8 File Offset: 0x000D2FB8
		public unsafe virtual CompareInfo CompareInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328893, XrefRangeEnd = 328905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_CompareInfo_Public_Virtual_New_get_CompareInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x000D4E04 File Offset: 0x000D3004
		public unsafe virtual bool IsNeutralCulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328905, XrefRangeEnd = 328906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_IsNeutralCulture_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x000D4E4C File Offset: 0x000D304C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNeutral()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CheckNeutral_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x0600289B RID: 10395 RVA: 0x000D4E80 File Offset: 0x000D3080
		// (set) Token: 0x0600289C RID: 10396 RVA: 0x000D4ECC File Offset: 0x000D30CC
		public unsafe virtual NumberFormatInfo NumberFormat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328906, XrefRangeEnd = 328913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_NumberFormat_Public_Virtual_New_get_NumberFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328913, XrefRangeEnd = 328915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_set_NumberFormat_Public_Virtual_New_set_Void_NumberFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x000D4F1C File Offset: 0x000D311C
		// (set) Token: 0x0600289E RID: 10398 RVA: 0x000D4F68 File Offset: 0x000D3168
		public unsafe virtual DateTimeFormatInfo DateTimeFormat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328915, XrefRangeEnd = 328924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_DateTimeFormat_Public_Virtual_New_get_DateTimeFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328924, XrefRangeEnd = 328926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_set_DateTimeFormat_Public_Virtual_New_set_Void_DateTimeFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x000D4FB8 File Offset: 0x000D31B8
		public unsafe virtual string EnglishName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328926, XrefRangeEnd = 328927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x000D4FFC File Offset: 0x000D31FC
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x000D5038 File Offset: 0x000D3238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328927, XrefRangeEnd = 328940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetFormat(Type formatType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x000D5094 File Offset: 0x000D3294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328940, XrefRangeEnd = 328941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Construct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_Construct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x000D50C8 File Offset: 0x000D32C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328941, XrefRangeEnd = 328942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool construct_internal_locale_from_lcid(int lcid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lcid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_construct_internal_locale_from_lcid_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x000D5114 File Offset: 0x000D3314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328942, XrefRangeEnd = 328943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool construct_internal_locale_from_name(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_construct_internal_locale_from_name_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x000D5164 File Offset: 0x000D3364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328943, XrefRangeEnd = 328944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string get_current_locale_name()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_current_locale_name_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x000D5190 File Offset: 0x000D3390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328944, XrefRangeEnd = 328945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CultureInfo> internal_get_cultures(bool neutral, bool specific, bool installed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref neutral;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref specific;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref installed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_internal_get_cultures_Private_Static_Il2CppReferenceArray_1_CultureInfo_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CultureInfo>>(intPtr3) : null;
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x000D51EC File Offset: 0x000D33EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328945, XrefRangeEnd = 328963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConstructInvariant(bool read_only)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref read_only;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_ConstructInvariant_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x000D522C File Offset: 0x000D342C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328963, XrefRangeEnd = 328967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextInfo CreateTextInfo(bool readOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateTextInfo_Private_TextInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x000D5278 File Offset: 0x000D3478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328968, RefRangeEnd = 328969, XrefRangeStart = 328967, XrefRangeEnd = 328968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(int culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x000D52C0 File Offset: 0x000D34C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328969, XrefRangeEnd = 328970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(int culture, bool useUserOverride)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x000D5318 File Offset: 0x000D3518
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 328975, RefRangeEnd = 328980, XrefRangeStart = 328970, XrefRangeEnd = 328975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(int culture, bool useUserOverride, bool read_only)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref read_only;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x000D537C File Offset: 0x000D357C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328981, RefRangeEnd = 328983, XrefRangeStart = 328980, XrefRangeEnd = 328981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x000D53C8 File Offset: 0x000D35C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328984, RefRangeEnd = 328986, XrefRangeStart = 328983, XrefRangeEnd = 328984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(string name, bool useUserOverride)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000D5424 File Offset: 0x000D3624
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 329000, RefRangeEnd = 329006, XrefRangeStart = 328986, XrefRangeEnd = 329000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(string name, bool useUserOverride, bool read_only)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref read_only;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x000D548C File Offset: 0x000D368C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329006, XrefRangeEnd = 329007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x000D54C8 File Offset: 0x000D36C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 329038, RefRangeEnd = 329040, XrefRangeStart = 329007, XrefRangeEnd = 329038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void insert_into_shared_tables(CultureInfo c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_insert_into_shared_tables_Private_Static_Void_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x000D5500 File Offset: 0x000D3700
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 329062, RefRangeEnd = 329065, XrefRangeStart = 329040, XrefRangeEnd = 329062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo GetCultureInfo(int culture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x000D5540 File Offset: 0x000D3740
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 329087, RefRangeEnd = 329098, XrefRangeStart = 329065, XrefRangeEnd = 329087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo GetCultureInfo(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x000D5584 File Offset: 0x000D3784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329102, RefRangeEnd = 329103, XrefRangeStart = 329098, XrefRangeEnd = 329102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo CreateCulture(string name, bool reference)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateCulture_Internal_Static_CultureInfo_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x000D55D8 File Offset: 0x000D37D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329118, RefRangeEnd = 329119, XrefRangeStart = 329103, XrefRangeEnd = 329118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo CreateSpecificCulture(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateSpecificCulture_Public_Static_CultureInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x000D561C File Offset: 0x000D381C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329685, RefRangeEnd = 329686, XrefRangeStart = 329119, XrefRangeEnd = 329685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo CreateSpecificCultureFromNeutral(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateSpecificCultureFromNeutral_Private_Static_CultureInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x060028B6 RID: 10422 RVA: 0x000D5660 File Offset: 0x000D3860
		public unsafe int CalendarType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 329686, RefRangeEnd = 329689, XrefRangeStart = 329686, XrefRangeEnd = 329686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_CalendarType_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x000D569C File Offset: 0x000D389C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329710, RefRangeEnd = 329711, XrefRangeStart = 329689, XrefRangeEnd = 329710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Calendar CreateCalendar(int calendarType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateCalendar_Private_Static_Calendar_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr3) : null;
			}
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000D56DC File Offset: 0x000D38DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329711, XrefRangeEnd = 329722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateNotFoundException(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateNotFoundException_Private_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x000D5720 File Offset: 0x000D3920
		public unsafe static CultureInfo DefaultThreadCurrentCulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329722, XrefRangeEnd = 329727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_DefaultThreadCurrentCulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x000D5754 File Offset: 0x000D3954
		public unsafe static CultureInfo DefaultThreadCurrentUICulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329727, XrefRangeEnd = 329732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_DefaultThreadCurrentUICulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x000D5788 File Offset: 0x000D3988
		public unsafe string SortName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_SortName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x000D57C0 File Offset: 0x000D39C0
		public unsafe static CultureInfo UserDefaultUICulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329732, XrefRangeEnd = 329740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_UserDefaultUICulture_Internal_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x000D57F4 File Offset: 0x000D39F4
		public unsafe static CultureInfo UserDefaultCulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329740, XrefRangeEnd = 329744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_UserDefaultCulture_Internal_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x000D5828 File Offset: 0x000D3A28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 329752, RefRangeEnd = 329754, XrefRangeStart = 329744, XrefRangeEnd = 329752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckDomainSafetyObject(Object obj, Object container)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CheckDomainSafetyObject_Internal_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x060028BF RID: 10431 RVA: 0x000D5870 File Offset: 0x000D3A70
		public unsafe bool HasInvariantCultureName
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 329765, RefRangeEnd = 329771, XrefRangeStart = 329754, XrefRangeEnd = 329765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_HasInvariantCultureName_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x000D58AC File Offset: 0x000D3AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329777, RefRangeEnd = 329778, XrefRangeStart = 329771, XrefRangeEnd = 329777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool VerifyCultureName(string cultureName, bool throwException)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwException;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_VerifyCultureName_Internal_Static_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0000E024 File Offset: 0x0000C224
		public CultureInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060028C2 RID: 10434 RVA: 0x000D58FC File Offset: 0x000D3AFC
		// (set) Token: 0x060028C3 RID: 10435 RVA: 0x0000E02D File Offset: 0x0000C22D
		public unsafe static CultureInfo invariant_culture_info
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_invariant_culture_info, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_invariant_culture_info, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x000D5924 File Offset: 0x000D3B24
		// (set) Token: 0x060028C5 RID: 10437 RVA: 0x0000E03F File Offset: 0x0000C23F
		public unsafe static Object shared_table_lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_shared_table_lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_shared_table_lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060028C6 RID: 10438 RVA: 0x000D594C File Offset: 0x000D3B4C
		// (set) Token: 0x060028C7 RID: 10439 RVA: 0x0000E051 File Offset: 0x0000C251
		public unsafe static CultureInfo default_current_culture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_default_current_culture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_default_current_culture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060028C8 RID: 10440 RVA: 0x000D5974 File Offset: 0x000D3B74
		// (set) Token: 0x060028C9 RID: 10441 RVA: 0x0000E063 File Offset: 0x0000C263
		public unsafe bool m_isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_isReadOnly)) = value;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x000D599C File Offset: 0x000D3B9C
		// (set) Token: 0x060028CB RID: 10443 RVA: 0x0000E07E File Offset: 0x0000C27E
		public unsafe int cultureID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_cultureID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_cultureID)) = value;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060028CC RID: 10444 RVA: 0x000D59C4 File Offset: 0x000D3BC4
		// (set) Token: 0x060028CD RID: 10445 RVA: 0x0000E099 File Offset: 0x0000C299
		public unsafe int parent_lcid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_parent_lcid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_parent_lcid)) = value;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060028CE RID: 10446 RVA: 0x000D59EC File Offset: 0x000D3BEC
		// (set) Token: 0x060028CF RID: 10447 RVA: 0x0000E0B4 File Offset: 0x0000C2B4
		public unsafe int datetime_index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_datetime_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_datetime_index)) = value;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060028D0 RID: 10448 RVA: 0x000D5A14 File Offset: 0x000D3C14
		// (set) Token: 0x060028D1 RID: 10449 RVA: 0x0000E0CF File Offset: 0x0000C2CF
		public unsafe int number_index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_number_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_number_index)) = value;
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x000D5A3C File Offset: 0x000D3C3C
		// (set) Token: 0x060028D3 RID: 10451 RVA: 0x0000E0EA File Offset: 0x0000C2EA
		public unsafe int default_calendar_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_default_calendar_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_default_calendar_type)) = value;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x060028D4 RID: 10452 RVA: 0x000D5A64 File Offset: 0x000D3C64
		// (set) Token: 0x060028D5 RID: 10453 RVA: 0x0000E105 File Offset: 0x0000C305
		public unsafe bool m_useUserOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_useUserOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_useUserOverride)) = value;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x060028D6 RID: 10454 RVA: 0x000D5A8C File Offset: 0x000D3C8C
		// (set) Token: 0x060028D7 RID: 10455 RVA: 0x0000E120 File Offset: 0x0000C320
		public unsafe NumberFormatInfo numInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_numInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_numInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060028D8 RID: 10456 RVA: 0x000D5ABC File Offset: 0x000D3CBC
		// (set) Token: 0x060028D9 RID: 10457 RVA: 0x0000E13F File Offset: 0x0000C33F
		public unsafe DateTimeFormatInfo dateTimeInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_dateTimeInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_dateTimeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x060028DA RID: 10458 RVA: 0x000D5AEC File Offset: 0x000D3CEC
		// (set) Token: 0x060028DB RID: 10459 RVA: 0x0000E15E File Offset: 0x0000C35E
		public unsafe TextInfo textInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_textInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_textInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x060028DC RID: 10460 RVA: 0x000D5B1C File Offset: 0x000D3D1C
		// (set) Token: 0x060028DD RID: 10461 RVA: 0x0000E17D File Offset: 0x0000C37D
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x060028DE RID: 10462 RVA: 0x000D5B44 File Offset: 0x000D3D44
		// (set) Token: 0x060028DF RID: 10463 RVA: 0x0000E19C File Offset: 0x0000C39C
		public unsafe string englishname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_englishname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_englishname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x060028E0 RID: 10464 RVA: 0x000D5B6C File Offset: 0x000D3D6C
		// (set) Token: 0x060028E1 RID: 10465 RVA: 0x0000E1BB File Offset: 0x0000C3BB
		public unsafe string nativename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_nativename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_nativename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x060028E2 RID: 10466 RVA: 0x000D5B94 File Offset: 0x000D3D94
		// (set) Token: 0x060028E3 RID: 10467 RVA: 0x0000E1DA File Offset: 0x0000C3DA
		public unsafe string iso3lang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_iso3lang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_iso3lang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x060028E4 RID: 10468 RVA: 0x000D5BBC File Offset: 0x000D3DBC
		// (set) Token: 0x060028E5 RID: 10469 RVA: 0x0000E1F9 File Offset: 0x0000C3F9
		public unsafe string iso2lang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_iso2lang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_iso2lang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060028E6 RID: 10470 RVA: 0x000D5BE4 File Offset: 0x000D3DE4
		// (set) Token: 0x060028E7 RID: 10471 RVA: 0x0000E218 File Offset: 0x0000C418
		public unsafe string win3lang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_win3lang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_win3lang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060028E8 RID: 10472 RVA: 0x000D5C0C File Offset: 0x000D3E0C
		// (set) Token: 0x060028E9 RID: 10473 RVA: 0x0000E237 File Offset: 0x0000C437
		public unsafe string territory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_territory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_territory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060028EA RID: 10474 RVA: 0x000D5C34 File Offset: 0x000D3E34
		// (set) Token: 0x060028EB RID: 10475 RVA: 0x0000E256 File Offset: 0x0000C456
		public unsafe Il2CppStringArray native_calendar_names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_native_calendar_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_native_calendar_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060028EC RID: 10476 RVA: 0x000D5C64 File Offset: 0x000D3E64
		// (set) Token: 0x060028ED RID: 10477 RVA: 0x0000E275 File Offset: 0x0000C475
		public unsafe CompareInfo compareInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_compareInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_compareInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060028EE RID: 10478 RVA: 0x000D5C94 File Offset: 0x000D3E94
		// (set) Token: 0x060028EF RID: 10479 RVA: 0x0000E294 File Offset: 0x0000C494
		public unsafe void* textinfo_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_textinfo_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_textinfo_data)) = value;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x000D5CB8 File Offset: 0x000D3EB8
		// (set) Token: 0x060028F1 RID: 10481 RVA: 0x0000E2AF File Offset: 0x0000C4AF
		public unsafe int m_dataItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_dataItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_dataItem)) = value;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x060028F2 RID: 10482 RVA: 0x000D5CE0 File Offset: 0x000D3EE0
		// (set) Token: 0x060028F3 RID: 10483 RVA: 0x0000E2CA File Offset: 0x0000C4CA
		public unsafe Calendar calendar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_calendar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_calendar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x060028F4 RID: 10484 RVA: 0x000D5D10 File Offset: 0x000D3F10
		// (set) Token: 0x060028F5 RID: 10485 RVA: 0x0000E2E9 File Offset: 0x0000C4E9
		public unsafe CultureInfo parent_culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_parent_culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_parent_culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x060028F6 RID: 10486 RVA: 0x000D5D40 File Offset: 0x000D3F40
		// (set) Token: 0x060028F7 RID: 10487 RVA: 0x0000E308 File Offset: 0x0000C508
		public unsafe bool constructed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_constructed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_constructed)) = value;
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x060028F8 RID: 10488 RVA: 0x000D5D68 File Offset: 0x000D3F68
		// (set) Token: 0x060028F9 RID: 10489 RVA: 0x0000E323 File Offset: 0x0000C523
		public unsafe Il2CppStructArray<byte> cached_serialized_form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_cached_serialized_form);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_cached_serialized_form), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x060028FA RID: 10490 RVA: 0x000D5D98 File Offset: 0x000D3F98
		// (set) Token: 0x060028FB RID: 10491 RVA: 0x0000E342 File Offset: 0x0000C542
		public unsafe CultureData m_cultureData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_cultureData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_cultureData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x060028FC RID: 10492 RVA: 0x000D5DC8 File Offset: 0x000D3FC8
		// (set) Token: 0x060028FD RID: 10493 RVA: 0x0000E361 File Offset: 0x0000C561
		public unsafe bool m_isInherited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_isInherited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_isInherited)) = value;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x000D5DF0 File Offset: 0x000D3FF0
		// (set) Token: 0x060028FF RID: 10495 RVA: 0x0000E37C File Offset: 0x0000C57C
		public unsafe static int InvariantCultureId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_InvariantCultureId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_InvariantCultureId, (void*)(&value));
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06002900 RID: 10496 RVA: 0x000D5E0C File Offset: 0x000D400C
		// (set) Token: 0x06002901 RID: 10497 RVA: 0x0000E38A File Offset: 0x0000C58A
		public unsafe static int CalendarTypeBits
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_CalendarTypeBits, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_CalendarTypeBits, (void*)(&value));
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06002902 RID: 10498 RVA: 0x000D5E28 File Offset: 0x000D4028
		// (set) Token: 0x06002903 RID: 10499 RVA: 0x0000E398 File Offset: 0x0000C598
		public unsafe static string MSG_READONLY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_MSG_READONLY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_MSG_READONLY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06002904 RID: 10500 RVA: 0x000D5E48 File Offset: 0x000D4048
		// (set) Token: 0x06002905 RID: 10501 RVA: 0x0000E3AA File Offset: 0x0000C5AA
		public unsafe static CultureInfo s_DefaultThreadCurrentUICulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06002906 RID: 10502 RVA: 0x000D5E70 File Offset: 0x000D4070
		// (set) Token: 0x06002907 RID: 10503 RVA: 0x0000E3BC File Offset: 0x0000C5BC
		public unsafe static CultureInfo s_DefaultThreadCurrentCulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentCulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentCulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06002908 RID: 10504 RVA: 0x000D5E98 File Offset: 0x000D4098
		// (set) Token: 0x06002909 RID: 10505 RVA: 0x0000E3CE File Offset: 0x0000C5CE
		public unsafe static Dictionary<int, CultureInfo> shared_by_number
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_shared_by_number, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, CultureInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_shared_by_number, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x0600290A RID: 10506 RVA: 0x000D5EC0 File Offset: 0x000D40C0
		// (set) Token: 0x0600290B RID: 10507 RVA: 0x0000E3E0 File Offset: 0x0000C5E0
		public unsafe static Dictionary<string, CultureInfo> shared_by_name
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_shared_by_name, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, CultureInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_shared_by_name, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x000D5EE8 File Offset: 0x000D40E8
		// (set) Token: 0x0600290D RID: 10509 RVA: 0x0000E3F2 File Offset: 0x0000C5F2
		public unsafe static bool IsTaiwanSku
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_IsTaiwanSku, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_IsTaiwanSku, (void*)(&value));
			}
		}

		// Token: 0x040023E2 RID: 9186
		private static readonly IntPtr NativeFieldInfoPtr_invariant_culture_info;

		// Token: 0x040023E3 RID: 9187
		private static readonly IntPtr NativeFieldInfoPtr_shared_table_lock;

		// Token: 0x040023E4 RID: 9188
		private static readonly IntPtr NativeFieldInfoPtr_default_current_culture;

		// Token: 0x040023E5 RID: 9189
		private static readonly IntPtr NativeFieldInfoPtr_m_isReadOnly;

		// Token: 0x040023E6 RID: 9190
		private static readonly IntPtr NativeFieldInfoPtr_cultureID;

		// Token: 0x040023E7 RID: 9191
		private static readonly IntPtr NativeFieldInfoPtr_parent_lcid;

		// Token: 0x040023E8 RID: 9192
		private static readonly IntPtr NativeFieldInfoPtr_datetime_index;

		// Token: 0x040023E9 RID: 9193
		private static readonly IntPtr NativeFieldInfoPtr_number_index;

		// Token: 0x040023EA RID: 9194
		private static readonly IntPtr NativeFieldInfoPtr_default_calendar_type;

		// Token: 0x040023EB RID: 9195
		private static readonly IntPtr NativeFieldInfoPtr_m_useUserOverride;

		// Token: 0x040023EC RID: 9196
		private static readonly IntPtr NativeFieldInfoPtr_numInfo;

		// Token: 0x040023ED RID: 9197
		private static readonly IntPtr NativeFieldInfoPtr_dateTimeInfo;

		// Token: 0x040023EE RID: 9198
		private static readonly IntPtr NativeFieldInfoPtr_textInfo;

		// Token: 0x040023EF RID: 9199
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x040023F0 RID: 9200
		private static readonly IntPtr NativeFieldInfoPtr_englishname;

		// Token: 0x040023F1 RID: 9201
		private static readonly IntPtr NativeFieldInfoPtr_nativename;

		// Token: 0x040023F2 RID: 9202
		private static readonly IntPtr NativeFieldInfoPtr_iso3lang;

		// Token: 0x040023F3 RID: 9203
		private static readonly IntPtr NativeFieldInfoPtr_iso2lang;

		// Token: 0x040023F4 RID: 9204
		private static readonly IntPtr NativeFieldInfoPtr_win3lang;

		// Token: 0x040023F5 RID: 9205
		private static readonly IntPtr NativeFieldInfoPtr_territory;

		// Token: 0x040023F6 RID: 9206
		private static readonly IntPtr NativeFieldInfoPtr_native_calendar_names;

		// Token: 0x040023F7 RID: 9207
		private static readonly IntPtr NativeFieldInfoPtr_compareInfo;

		// Token: 0x040023F8 RID: 9208
		private static readonly IntPtr NativeFieldInfoPtr_textinfo_data;

		// Token: 0x040023F9 RID: 9209
		private static readonly IntPtr NativeFieldInfoPtr_m_dataItem;

		// Token: 0x040023FA RID: 9210
		private static readonly IntPtr NativeFieldInfoPtr_calendar;

		// Token: 0x040023FB RID: 9211
		private static readonly IntPtr NativeFieldInfoPtr_parent_culture;

		// Token: 0x040023FC RID: 9212
		private static readonly IntPtr NativeFieldInfoPtr_constructed;

		// Token: 0x040023FD RID: 9213
		private static readonly IntPtr NativeFieldInfoPtr_cached_serialized_form;

		// Token: 0x040023FE RID: 9214
		private static readonly IntPtr NativeFieldInfoPtr_m_cultureData;

		// Token: 0x040023FF RID: 9215
		private static readonly IntPtr NativeFieldInfoPtr_m_isInherited;

		// Token: 0x04002400 RID: 9216
		private static readonly IntPtr NativeFieldInfoPtr_InvariantCultureId;

		// Token: 0x04002401 RID: 9217
		private static readonly IntPtr NativeFieldInfoPtr_CalendarTypeBits;

		// Token: 0x04002402 RID: 9218
		private static readonly IntPtr NativeFieldInfoPtr_MSG_READONLY;

		// Token: 0x04002403 RID: 9219
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture;

		// Token: 0x04002404 RID: 9220
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultThreadCurrentCulture;

		// Token: 0x04002405 RID: 9221
		private static readonly IntPtr NativeFieldInfoPtr_shared_by_number;

		// Token: 0x04002406 RID: 9222
		private static readonly IntPtr NativeFieldInfoPtr_shared_by_name;

		// Token: 0x04002407 RID: 9223
		private static readonly IntPtr NativeFieldInfoPtr_IsTaiwanSku;

		// Token: 0x04002408 RID: 9224
		private static readonly IntPtr NativeMethodInfoPtr_get_InvariantCulture_Public_Static_get_CultureInfo_0;

		// Token: 0x04002409 RID: 9225
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCulture_Public_Static_get_CultureInfo_0;

		// Token: 0x0400240A RID: 9226
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentUICulture_Public_Static_get_CultureInfo_0;

		// Token: 0x0400240B RID: 9227
		private static readonly IntPtr NativeMethodInfoPtr_ConstructCurrentCulture_Internal_Static_CultureInfo_0;

		// Token: 0x0400240C RID: 9228
		private static readonly IntPtr NativeMethodInfoPtr_ConstructCurrentUICulture_Internal_Static_CultureInfo_0;

		// Token: 0x0400240D RID: 9229
		private static readonly IntPtr NativeMethodInfoPtr_get_Territory_Internal_get_String_0;

		// Token: 0x0400240E RID: 9230
		private static readonly IntPtr NativeMethodInfoPtr_get_LCID_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400240F RID: 9231
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x04002410 RID: 9232
		private static readonly IntPtr NativeMethodInfoPtr_get_Calendar_Public_Virtual_New_get_Calendar_0;

		// Token: 0x04002411 RID: 9233
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_Virtual_New_get_CultureInfo_0;

		// Token: 0x04002412 RID: 9234
		private static readonly IntPtr NativeMethodInfoPtr_get_TextInfo_Public_Virtual_New_get_TextInfo_0;

		// Token: 0x04002413 RID: 9235
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x04002414 RID: 9236
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002415 RID: 9237
		private static readonly IntPtr NativeMethodInfoPtr_GetCultures_Public_Static_Il2CppReferenceArray_1_CultureInfo_CultureTypes_0;

		// Token: 0x04002416 RID: 9238
		private static readonly IntPtr NativeMethodInfoPtr_GetTextInfoData_Private_Data_0;

		// Token: 0x04002417 RID: 9239
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002418 RID: 9240
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002419 RID: 9241
		private static readonly IntPtr NativeMethodInfoPtr_get_CompareInfo_Public_Virtual_New_get_CompareInfo_0;

		// Token: 0x0400241A RID: 9242
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNeutralCulture_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400241B RID: 9243
		private static readonly IntPtr NativeMethodInfoPtr_CheckNeutral_Private_Void_0;

		// Token: 0x0400241C RID: 9244
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberFormat_Public_Virtual_New_get_NumberFormatInfo_0;

		// Token: 0x0400241D RID: 9245
		private static readonly IntPtr NativeMethodInfoPtr_set_NumberFormat_Public_Virtual_New_set_Void_NumberFormatInfo_0;

		// Token: 0x0400241E RID: 9246
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeFormat_Public_Virtual_New_get_DateTimeFormatInfo_0;

		// Token: 0x0400241F RID: 9247
		private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeFormat_Public_Virtual_New_set_Void_DateTimeFormatInfo_0;

		// Token: 0x04002420 RID: 9248
		private static readonly IntPtr NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0;

		// Token: 0x04002421 RID: 9249
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

		// Token: 0x04002422 RID: 9250
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Virtual_New_Object_Type_0;

		// Token: 0x04002423 RID: 9251
		private static readonly IntPtr NativeMethodInfoPtr_Construct_Private_Void_0;

		// Token: 0x04002424 RID: 9252
		private static readonly IntPtr NativeMethodInfoPtr_construct_internal_locale_from_lcid_Private_Boolean_Int32_0;

		// Token: 0x04002425 RID: 9253
		private static readonly IntPtr NativeMethodInfoPtr_construct_internal_locale_from_name_Private_Boolean_String_0;

		// Token: 0x04002426 RID: 9254
		private static readonly IntPtr NativeMethodInfoPtr_get_current_locale_name_Private_Static_String_0;

		// Token: 0x04002427 RID: 9255
		private static readonly IntPtr NativeMethodInfoPtr_internal_get_cultures_Private_Static_Il2CppReferenceArray_1_CultureInfo_Boolean_Boolean_Boolean_0;

		// Token: 0x04002428 RID: 9256
		private static readonly IntPtr NativeMethodInfoPtr_ConstructInvariant_Private_Void_Boolean_0;

		// Token: 0x04002429 RID: 9257
		private static readonly IntPtr NativeMethodInfoPtr_CreateTextInfo_Private_TextInfo_Boolean_0;

		// Token: 0x0400242A RID: 9258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400242B RID: 9259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

		// Token: 0x0400242C RID: 9260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Boolean_0;

		// Token: 0x0400242D RID: 9261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400242E RID: 9262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x0400242F RID: 9263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_Boolean_Boolean_0;

		// Token: 0x04002430 RID: 9264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002431 RID: 9265
		private static readonly IntPtr NativeMethodInfoPtr_insert_into_shared_tables_Private_Static_Void_CultureInfo_0;

		// Token: 0x04002432 RID: 9266
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_Int32_0;

		// Token: 0x04002433 RID: 9267
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_String_0;

		// Token: 0x04002434 RID: 9268
		private static readonly IntPtr NativeMethodInfoPtr_CreateCulture_Internal_Static_CultureInfo_String_Boolean_0;

		// Token: 0x04002435 RID: 9269
		private static readonly IntPtr NativeMethodInfoPtr_CreateSpecificCulture_Public_Static_CultureInfo_String_0;

		// Token: 0x04002436 RID: 9270
		private static readonly IntPtr NativeMethodInfoPtr_CreateSpecificCultureFromNeutral_Private_Static_CultureInfo_String_0;

		// Token: 0x04002437 RID: 9271
		private static readonly IntPtr NativeMethodInfoPtr_get_CalendarType_Internal_get_Int32_0;

		// Token: 0x04002438 RID: 9272
		private static readonly IntPtr NativeMethodInfoPtr_CreateCalendar_Private_Static_Calendar_Int32_0;

		// Token: 0x04002439 RID: 9273
		private static readonly IntPtr NativeMethodInfoPtr_CreateNotFoundException_Private_Static_Exception_String_0;

		// Token: 0x0400243A RID: 9274
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultThreadCurrentCulture_Public_Static_get_CultureInfo_0;

		// Token: 0x0400243B RID: 9275
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultThreadCurrentUICulture_Public_Static_get_CultureInfo_0;

		// Token: 0x0400243C RID: 9276
		private static readonly IntPtr NativeMethodInfoPtr_get_SortName_Internal_get_String_0;

		// Token: 0x0400243D RID: 9277
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDefaultUICulture_Internal_Static_get_CultureInfo_0;

		// Token: 0x0400243E RID: 9278
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDefaultCulture_Internal_Static_get_CultureInfo_0;

		// Token: 0x0400243F RID: 9279
		private static readonly IntPtr NativeMethodInfoPtr_CheckDomainSafetyObject_Internal_Static_Void_Object_Object_0;

		// Token: 0x04002440 RID: 9280
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInvariantCultureName_Internal_get_Boolean_0;

		// Token: 0x04002441 RID: 9281
		private static readonly IntPtr NativeMethodInfoPtr_VerifyCultureName_Internal_Static_Boolean_String_Boolean_0;

		// Token: 0x020005E4 RID: 1508
		[StructLayout(2)]
		public struct Data
		{
			// Token: 0x0600522F RID: 21039 RVA: 0x0016ED04 File Offset: 0x0016CF04
			// Note: this type is marked as 'beforefieldinit'.
			static Data()
			{
				Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "Data");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr);
				CultureInfo.Data.NativeFieldInfoPtr_ansi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "ansi");
				CultureInfo.Data.NativeFieldInfoPtr_ebcdic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "ebcdic");
				CultureInfo.Data.NativeFieldInfoPtr_mac = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "mac");
				CultureInfo.Data.NativeFieldInfoPtr_oem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "oem");
				CultureInfo.Data.NativeFieldInfoPtr_right_to_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "right_to_left");
				CultureInfo.Data.NativeFieldInfoPtr_list_sep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "list_sep");
			}

			// Token: 0x06005230 RID: 21040 RVA: 0x0001F539 File Offset: 0x0001D739
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, ref this));
			}

			// Token: 0x0400429F RID: 17055
			private static readonly IntPtr NativeFieldInfoPtr_ansi;

			// Token: 0x040042A0 RID: 17056
			private static readonly IntPtr NativeFieldInfoPtr_ebcdic;

			// Token: 0x040042A1 RID: 17057
			private static readonly IntPtr NativeFieldInfoPtr_mac;

			// Token: 0x040042A2 RID: 17058
			private static readonly IntPtr NativeFieldInfoPtr_oem;

			// Token: 0x040042A3 RID: 17059
			private static readonly IntPtr NativeFieldInfoPtr_right_to_left;

			// Token: 0x040042A4 RID: 17060
			private static readonly IntPtr NativeFieldInfoPtr_list_sep;

			// Token: 0x040042A5 RID: 17061
			[FieldOffset(0)]
			public int ansi;

			// Token: 0x040042A6 RID: 17062
			[FieldOffset(4)]
			public int ebcdic;

			// Token: 0x040042A7 RID: 17063
			[FieldOffset(8)]
			public int mac;

			// Token: 0x040042A8 RID: 17064
			[FieldOffset(12)]
			public int oem;

			// Token: 0x040042A9 RID: 17065
			[FieldOffset(16)]
			[MarshalAs(4)]
			public bool right_to_left;

			// Token: 0x040042AA RID: 17066
			[FieldOffset(17)]
			public byte list_sep;
		}
	}
}
