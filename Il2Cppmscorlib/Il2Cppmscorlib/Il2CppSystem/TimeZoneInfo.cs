using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000F4 RID: 244
	[Serializable]
	public sealed class TimeZoneInfo : Object
	{
		// Token: 0x0600110B RID: 4363 RVA: 0x000709A4 File Offset: 0x0006EBA4
		// Note: this type is marked as 'beforefieldinit'.
		static TimeZoneInfo()
		{
			Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TimeZoneInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr);
			TimeZoneInfo.NativeFieldInfoPtr_baseUtcOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "baseUtcOffset");
			TimeZoneInfo.NativeFieldInfoPtr_daylightDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "daylightDisplayName");
			TimeZoneInfo.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "displayName");
			TimeZoneInfo.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "id");
			TimeZoneInfo.NativeFieldInfoPtr_local = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "local");
			TimeZoneInfo.NativeFieldInfoPtr_transitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "transitions");
			TimeZoneInfo.NativeFieldInfoPtr_readlinkNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "readlinkNotFound");
			TimeZoneInfo.NativeFieldInfoPtr_standardDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "standardDisplayName");
			TimeZoneInfo.NativeFieldInfoPtr_supportsDaylightSavingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "supportsDaylightSavingTime");
			TimeZoneInfo.NativeFieldInfoPtr_utc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "utc");
			TimeZoneInfo.NativeFieldInfoPtr_timeZoneDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "timeZoneDirectory");
			TimeZoneInfo.NativeFieldInfoPtr_adjustmentRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "adjustmentRules");
			TimeZoneInfo.NativeFieldInfoPtr_timeZoneKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "timeZoneKey");
			TimeZoneInfo.NativeFieldInfoPtr_localZoneKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "localZoneKey");
			TimeZoneInfo.NativeFieldInfoPtr_systemTimeZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "systemTimeZones");
			TimeZoneInfo.NativeMethodInfoPtr_UtcOffsetOutOfRange_Internal_Static_Boolean_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666207);
			TimeZoneInfo.NativeMethodInfoPtr_CreateAdjustmentRule_Private_Static_List_1_AdjustmentRule_Int32_byref_Il2CppStructArray_1_Int64_byref_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666208);
			TimeZoneInfo.NativeMethodInfoPtr_CreateLocalUnity_Private_Static_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666209);
			TimeZoneInfo.NativeMethodInfoPtr_EnumDynamicTimeZoneInformation_Internal_Static_UInt32_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666210);
			TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666211);
			TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformationWin32_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666212);
			TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformationEffectiveYears_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666213);
			TimeZoneInfo.NativeMethodInfoPtr_GetTimeZoneInformationForYear_Internal_Static_Boolean_UInt16_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666214);
			TimeZoneInfo.NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Internal_Static_AdjustmentRule_byref_DYNAMIC_TIME_ZONE_INFORMATION_DateTime_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666215);
			TimeZoneInfo.NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_DYNAMIC_TIME_ZONE_INFORMATION_byref_TransitionTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666216);
			TimeZoneInfo.NativeMethodInfoPtr_TryCreateTimeZone_Internal_Static_TimeZoneInfo_DYNAMIC_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666217);
			TimeZoneInfo.NativeMethodInfoPtr_GetLocalTimeZoneInfoWinRTFallback_Internal_Static_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666218);
			TimeZoneInfo.NativeMethodInfoPtr_GetLocalTimeZoneKeyNameWin32Fallback_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666219);
			TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneByIdWinRTFallback_Internal_Static_TimeZoneInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666220);
			TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZonesWinRTFallback_Internal_Static_List_1_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666221);
			TimeZoneInfo.NativeMethodInfoPtr_get_BaseUtcOffset_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666222);
			TimeZoneInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666223);
			TimeZoneInfo.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666224);
			TimeZoneInfo.NativeMethodInfoPtr_get_Local_Public_Static_get_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666225);
			TimeZoneInfo.NativeMethodInfoPtr_readlink_Private_Static_Int32_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666226);
			TimeZoneInfo.NativeMethodInfoPtr_readlink_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666227);
			TimeZoneInfo.NativeMethodInfoPtr_TryGetNameFromPath_Private_Static_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666228);
			TimeZoneInfo.NativeMethodInfoPtr_CreateLocal_Private_Static_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666229);
			TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneByIdCore_Private_Static_TimeZoneInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666230);
			TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZonesCore_Private_Static_Void_List_1_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666231);
			TimeZoneInfo.NativeMethodInfoPtr_get_SupportsDaylightSavingTime_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666232);
			TimeZoneInfo.NativeMethodInfoPtr_get_Utc_Public_Static_get_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666233);
			TimeZoneInfo.NativeMethodInfoPtr_get_TimeZoneDirectory_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666234);
			TimeZoneInfo.NativeMethodInfoPtr_get_IsWindows_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666235);
			TimeZoneInfo.NativeMethodInfoPtr_TrimSpecial_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666236);
			TimeZoneInfo.NativeMethodInfoPtr_get_TimeZoneKey_Private_Static_get_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666237);
			TimeZoneInfo.NativeMethodInfoPtr_get_LocalZoneKey_Private_Static_get_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666238);
			TimeZoneInfo.NativeMethodInfoPtr_TryAddTicks_Private_Static_Boolean_DateTime_Int64_byref_DateTime_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666239);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertTime_Public_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666240);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeFromUtc_Private_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666241);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeFromUtc_Public_Static_DateTime_DateTime_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666242);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeToUtc_Internal_Static_DateTime_DateTime_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666243);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeToUtc_Public_Static_DateTime_DateTime_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666244);
			TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeToUtc_Private_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666245);
			TimeZoneInfo.NativeMethodInfoPtr_GetDateTimeNowUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666246);
			TimeZoneInfo.NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666247);
			TimeZoneInfo.NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666248);
			TimeZoneInfo.NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666249);
			TimeZoneInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666250);
			TimeZoneInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666251);
			TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneById_Public_Static_TimeZoneInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666252);
			TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneByFileName_Private_Static_TimeZoneInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666253);
			TimeZoneInfo.NativeMethodInfoPtr_FromRegistryKey_Private_Static_TimeZoneInfo_String_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666254);
			TimeZoneInfo.NativeMethodInfoPtr_ParseRegTzi_Private_Static_Void_List_1_AdjustmentRule_Int32_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666255);
			TimeZoneInfo.NativeMethodInfoPtr_GetAdjustmentRules_Public_Il2CppReferenceArray_1_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666256);
			TimeZoneInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666257);
			TimeZoneInfo.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666258);
			TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZones_Public_Static_ReadOnlyCollection_1_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666259);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Public_TimeSpan_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666260);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Private_TimeSpan_DateTime_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666261);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffsetHelper_Private_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666262);
			TimeZoneInfo.NativeMethodInfoPtr_HasSameRules_Public_Boolean_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666263);
			TimeZoneInfo.NativeMethodInfoPtr_IsAmbiguousTime_Public_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666264);
			TimeZoneInfo.NativeMethodInfoPtr_IsAmbiguousLocalDstFromUtc_Private_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666265);
			TimeZoneInfo.NativeMethodInfoPtr_IsInDST_Private_Boolean_AdjustmentRule_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666266);
			TimeZoneInfo.NativeMethodInfoPtr_IsInDSTForYear_Private_Boolean_AdjustmentRule_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666267);
			TimeZoneInfo.NativeMethodInfoPtr_IsInvalidTime_Public_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666268);
			TimeZoneInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666269);
			TimeZoneInfo.NativeMethodInfoPtr_Validate_Private_Static_Void_String_TimeSpan_Il2CppReferenceArray_1_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666270);
			TimeZoneInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666271);
			TimeZoneInfo.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666272);
			TimeZoneInfo.NativeMethodInfoPtr__ctor_Private_Void_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666273);
			TimeZoneInfo.NativeMethodInfoPtr_GetApplicableRule_Private_AdjustmentRule_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666274);
			TimeZoneInfo.NativeMethodInfoPtr_TryGetTransitionOffset_Private_Boolean_DateTime_byref_TimeSpan_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666275);
			TimeZoneInfo.NativeMethodInfoPtr_TransitionPoint_Private_Static_DateTime_TransitionTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666276);
			TimeZoneInfo.NativeMethodInfoPtr_ValidateRules_Private_Static_Il2CppReferenceArray_1_AdjustmentRule_List_1_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666277);
			TimeZoneInfo.NativeMethodInfoPtr_BuildFromStream_Private_Static_TimeZoneInfo_String_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666278);
			TimeZoneInfo.NativeMethodInfoPtr_ValidTZFile_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666279);
			TimeZoneInfo.NativeMethodInfoPtr_SwapInt32_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666280);
			TimeZoneInfo.NativeMethodInfoPtr_ReadBigEndianInt32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666281);
			TimeZoneInfo.NativeMethodInfoPtr_ParseTZBuffer_Private_Static_TimeZoneInfo_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666282);
			TimeZoneInfo.NativeMethodInfoPtr_ParseAbbreviations_Private_Static_Dictionary_2_Int32_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666283);
			TimeZoneInfo.NativeMethodInfoPtr_ParseTimesTypes_Private_Static_Dictionary_2_Int32_TimeType_Il2CppStructArray_1_Byte_Int32_Int32_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666284);
			TimeZoneInfo.NativeMethodInfoPtr_ParseTransitions_Private_Static_List_1_KeyValuePair_2_DateTime_TimeType_Il2CppStructArray_1_Byte_Int32_Int32_Dictionary_2_Int32_TimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666285);
			TimeZoneInfo.NativeMethodInfoPtr_DateTimeFromUnixTime_Private_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666286);
			TimeZoneInfo.NativeMethodInfoPtr_GetLocalUtcOffset_Internal_Static_TimeSpan_DateTime_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666287);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Internal_TimeSpan_DateTime_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666288);
			TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666289);
			TimeZoneInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100666290);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00071190 File Offset: 0x0006F390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298835, RefRangeEnd = 298836, XrefRangeStart = 298835, XrefRangeEnd = 298835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UtcOffsetOutOfRange(TimeSpan offset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_UtcOffsetOutOfRange_Internal_Static_Boolean_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x000711D0 File Offset: 0x0006F3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298836, XrefRangeEnd = 298893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<TimeZoneInfo.AdjustmentRule> CreateAdjustmentRule(int year, out Il2CppStructArray<long> data, out Il2CppStringArray names, string standardNameCurrentYear, string daylightNameCurrentYear)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standardNameCurrentYear);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(daylightNameCurrentYear);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateAdjustmentRule_Private_Static_List_1_AdjustmentRule_Int32_byref_Il2CppStructArray_1_Int64_byref_Il2CppStringArray_String_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			data = ((intPtr5 == 0) ? null : new Il2CppStructArray<long>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			names = ((intPtr6 == 0) ? null : new Il2CppStringArray(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<List<TimeZoneInfo.AdjustmentRule>>(intPtr7) : null;
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x0007127C File Offset: 0x0006F47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298893, XrefRangeEnd = 299097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo CreateLocalUnity()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateLocalUnity_Private_Static_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x000712B0 File Offset: 0x0006F4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299097, XrefRangeEnd = 299102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint EnumDynamicTimeZoneInformation(uint dwIndex, out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwIndex;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_EnumDynamicTimeZoneInformation_Internal_Static_UInt32_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			lpTimeZoneInformation = ((intPtr4 == 0) ? null : new TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00071310 File Offset: 0x0006F510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299102, XrefRangeEnd = 299107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetDynamicTimeZoneInformation(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pTimeZoneInformation = ((intPtr4 == 0) ? null : new TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00071364 File Offset: 0x0006F564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299107, XrefRangeEnd = 299112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetDynamicTimeZoneInformationWin32(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformationWin32_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pTimeZoneInformation = ((intPtr4 == 0) ? null : new TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x000713B8 File Offset: 0x0006F5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299112, XrefRangeEnd = 299117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetDynamicTimeZoneInformationEffectiveYears(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(lpTimeZoneInformation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &FirstYear;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &LastYear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetDynamicTimeZoneInformationEffectiveYears_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00071418 File Offset: 0x0006F618
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 299125, RefRangeEnd = 299128, XrefRangeStart = 299117, XrefRangeEnd = 299125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeZoneInformationForYear(ushort wYear, ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out TimeZoneInfo.TIME_ZONE_INFORMATION ptzi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref wYear;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pdtzi);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetTimeZoneInformationForYear_Internal_Static_Boolean_UInt16_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ptzi = ((intPtr4 == 0) ? null : new TimeZoneInfo.TIME_ZONE_INFORMATION(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0007148C File Offset: 0x0006F68C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 299158, RefRangeEnd = 299162, XrefRangeStart = 299128, XrefRangeEnd = 299158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(timeZoneInformation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endDate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultBaseUtcOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Internal_Static_AdjustmentRule_byref_DYNAMIC_TIME_ZONE_INFORMATION_DateTime_DateTime_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.AdjustmentRule>(intPtr3) : null;
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x000714FC File Offset: 0x0006F6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299162, XrefRangeEnd = 299172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TransitionTimeFromTimeZoneInformation(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(timeZoneInformation));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &transitionTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readStartDate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_DYNAMIC_TIME_ZONE_INFORMATION_byref_TransitionTime_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00071560 File Offset: 0x0006F760
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299233, RefRangeEnd = 299235, XrefRangeStart = 299172, XrefRangeEnd = 299233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo TryCreateTimeZone(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(timeZoneInformation));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryCreateTimeZone_Internal_Static_TimeZoneInfo_DYNAMIC_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x000715AC File Offset: 0x0006F7AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 299246, RefRangeEnd = 299249, XrefRangeStart = 299235, XrefRangeEnd = 299246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetLocalTimeZoneInfoWinRTFallback_Internal_Static_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000715E0 File Offset: 0x0006F7E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299260, RefRangeEnd = 299261, XrefRangeStart = 299249, XrefRangeEnd = 299260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLocalTimeZoneKeyNameWin32Fallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetLocalTimeZoneKeyNameWin32Fallback_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0007160C File Offset: 0x0006F80C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299296, RefRangeEnd = 299297, XrefRangeStart = 299261, XrefRangeEnd = 299296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneByIdWinRTFallback_Internal_Static_TimeZoneInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00071650 File Offset: 0x0006F850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299322, RefRangeEnd = 299323, XrefRangeStart = 299297, XrefRangeEnd = 299322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<TimeZoneInfo> GetSystemTimeZonesWinRTFallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZonesWinRTFallback_Internal_Static_List_1_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TimeZoneInfo>>(intPtr3) : null;
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x00071684 File Offset: 0x0006F884
		public unsafe TimeSpan BaseUtcOffset
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_BaseUtcOffset_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x000716C0 File Offset: 0x0006F8C0
		public unsafe string DisplayName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x000716F8 File Offset: 0x0006F8F8
		public unsafe string Id
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x00071730 File Offset: 0x0006F930
		public unsafe static TimeZoneInfo Local
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 299329, RefRangeEnd = 299352, XrefRangeStart = 299323, XrefRangeEnd = 299329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_Local_Public_Static_get_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00071764 File Offset: 0x0006F964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299352, XrefRangeEnd = 299355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int readlink(string path, Il2CppStructArray<byte> buffer, int buflen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buflen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_readlink_Private_Static_Int32_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x000717C8 File Offset: 0x0006F9C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299370, RefRangeEnd = 299371, XrefRangeStart = 299355, XrefRangeEnd = 299370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string readlink(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_readlink_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00071804 File Offset: 0x0006FA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299371, XrefRangeEnd = 299403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetNameFromPath(string path, out string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryGetNameFromPath_Private_Static_Boolean_String_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			name = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00071860 File Offset: 0x0006FA60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299444, RefRangeEnd = 299445, XrefRangeStart = 299403, XrefRangeEnd = 299444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo CreateLocal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateLocal_Private_Static_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00071894 File Offset: 0x0006FA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299445, XrefRangeEnd = 299451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo FindSystemTimeZoneByIdCore(string id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneByIdCore_Private_Static_TimeZoneInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x000718D8 File Offset: 0x0006FAD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299479, RefRangeEnd = 299481, XrefRangeStart = 299451, XrefRangeEnd = 299479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSystemTimeZonesCore(List<TimeZoneInfo> systemTimeZones)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemTimeZones);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZonesCore_Private_Static_Void_List_1_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x00071910 File Offset: 0x0006FB10
		public unsafe bool SupportsDaylightSavingTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_SupportsDaylightSavingTime_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x0007194C File Offset: 0x0006FB4C
		public unsafe static TimeZoneInfo Utc
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 299488, RefRangeEnd = 299501, XrefRangeStart = 299481, XrefRangeEnd = 299488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_Utc_Public_Static_get_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x00071980 File Offset: 0x0006FB80
		public unsafe static string TimeZoneDirectory
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 299506, RefRangeEnd = 299510, XrefRangeStart = 299501, XrefRangeEnd = 299506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_TimeZoneDirectory_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x000719AC File Offset: 0x0006FBAC
		public unsafe static bool IsWindows
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299510, XrefRangeEnd = 299511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_IsWindows_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x000719DC File Offset: 0x0006FBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299511, XrefRangeEnd = 299523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TrimSpecial(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TrimSpecial_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x00071A18 File Offset: 0x0006FC18
		public unsafe static RegistryKey TimeZoneKey
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 299535, RefRangeEnd = 299538, XrefRangeStart = 299523, XrefRangeEnd = 299535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_TimeZoneKey_Private_Static_get_RegistryKey_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x00071A4C File Offset: 0x0006FC4C
		public unsafe static RegistryKey LocalZoneKey
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 299550, RefRangeEnd = 299553, XrefRangeStart = 299538, XrefRangeEnd = 299550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_get_LocalZoneKey_Private_Static_get_RegistryKey_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
			}
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00071A80 File Offset: 0x0006FC80
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 299564, RefRangeEnd = 299577, XrefRangeStart = 299553, XrefRangeEnd = 299564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryAddTicks(DateTime date, long ticks, out DateTime result, DateTimeKind kind = DateTimeKind.Unspecified)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref date;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ticks;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryAddTicks_Private_Static_Boolean_DateTime_Int64_byref_DateTime_DateTimeKind_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00071AE8 File Offset: 0x0006FCE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299586, RefRangeEnd = 299587, XrefRangeStart = 299577, XrefRangeEnd = 299586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceTimeZone);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationTimeZone);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertTime_Public_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00071B4C File Offset: 0x0006FD4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299593, RefRangeEnd = 299595, XrefRangeStart = 299587, XrefRangeEnd = 299593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ConvertTimeFromUtc(DateTime dateTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeFromUtc_Private_DateTime_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00071B98 File Offset: 0x0006FD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299595, XrefRangeEnd = 299602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationTimeZone);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeFromUtc_Public_Static_DateTime_DateTime_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00071BE8 File Offset: 0x0006FDE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 299604, RefRangeEnd = 299607, XrefRangeStart = 299602, XrefRangeEnd = 299604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeToUtc_Internal_Static_DateTime_DateTime_TimeZoneInfoOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00071C34 File Offset: 0x0006FE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299607, XrefRangeEnd = 299608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceTimeZone);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeToUtc_Public_Static_DateTime_DateTime_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x00071C84 File Offset: 0x0006FE84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299616, RefRangeEnd = 299618, XrefRangeStart = 299608, XrefRangeEnd = 299616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfoOptions flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceTimeZone);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ConvertTimeToUtc_Private_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfoOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00071CE4 File Offset: 0x0006FEE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299634, RefRangeEnd = 299635, XrefRangeStart = 299618, XrefRangeEnd = 299634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAmbiguousLocalDst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetDateTimeNowUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00071D30 File Offset: 0x0006FF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299635, XrefRangeEnd = 299636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standardDisplayName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00071DA8 File Offset: 0x0006FFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299636, XrefRangeEnd = 299637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> adjustmentRules)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standardDisplayName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(daylightDisplayName);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRules);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00071E44 File Offset: 0x00070044
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 299641, RefRangeEnd = 299646, XrefRangeStart = 299637, XrefRangeEnd = 299641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> adjustmentRules, bool disableDaylightSavingTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standardDisplayName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(daylightDisplayName);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRules);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref disableDaylightSavingTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00071EF0 File Offset: 0x000700F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299646, XrefRangeEnd = 299650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00071F40 File Offset: 0x00070140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299650, XrefRangeEnd = 299652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TimeZoneInfo other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x00071F90 File Offset: 0x00070190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299685, RefRangeEnd = 299686, XrefRangeStart = 299652, XrefRangeEnd = 299685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo FindSystemTimeZoneById(string id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneById_Public_Static_TimeZoneInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00071FD4 File Offset: 0x000701D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299690, RefRangeEnd = 299692, XrefRangeStart = 299686, XrefRangeEnd = 299690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo FindSystemTimeZoneByFileName(string id, string filepath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filepath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_FindSystemTimeZoneByFileName_Private_Static_TimeZoneInfo_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0007202C File Offset: 0x0007022C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299734, RefRangeEnd = 299735, XrefRangeStart = 299692, XrefRangeEnd = 299734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo FromRegistryKey(string id, RegistryKey key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_FromRegistryKey_Private_Static_TimeZoneInfo_String_RegistryKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00072084 File Offset: 0x00070284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299770, RefRangeEnd = 299771, XrefRangeStart = 299735, XrefRangeEnd = 299770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseRegTzi(List<TimeZoneInfo.AdjustmentRule> adjustmentRules, int start_year, int end_year, Il2CppStructArray<byte> buffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRules);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start_year;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end_year;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ParseRegTzi_Private_Static_Void_List_1_AdjustmentRule_Int32_Int32_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x000720E8 File Offset: 0x000702E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299771, XrefRangeEnd = 299774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> GetAdjustmentRules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetAdjustmentRules_Public_Il2CppReferenceArray_1_AdjustmentRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule>>(intPtr3) : null;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00072128 File Offset: 0x00070328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299774, XrefRangeEnd = 299783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00072164 File Offset: 0x00070364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299783, XrefRangeEnd = 299807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x000721C0 File Offset: 0x000703C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299807, XrefRangeEnd = 299825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetSystemTimeZones_Public_Static_ReadOnlyCollection_1_TimeZoneInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TimeZoneInfo>>(intPtr3) : null;
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x000721F4 File Offset: 0x000703F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 299826, RefRangeEnd = 299831, XrefRangeStart = 299825, XrefRangeEnd = 299826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan GetUtcOffset(DateTime dateTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Public_TimeSpan_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00072240 File Offset: 0x00070440
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 299838, RefRangeEnd = 299845, XrefRangeStart = 299831, XrefRangeEnd = 299838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan GetUtcOffset(DateTime dateTime, out bool isDST, bool forOffset = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isDST;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Private_TimeSpan_DateTime_byref_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x000722A8 File Offset: 0x000704A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299865, RefRangeEnd = 299867, XrefRangeStart = 299845, XrefRangeEnd = 299865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetUtcOffsetHelper(DateTime dateTime, TimeZoneInfo tz, out bool isDST, bool forOffset = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tz);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isDST;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffsetHelper_Private_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00072314 File Offset: 0x00070514
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299872, RefRangeEnd = 299874, XrefRangeStart = 299867, XrefRangeEnd = 299872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSameRules(TimeZoneInfo other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_HasSameRules_Public_Boolean_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00072364 File Offset: 0x00070564
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299895, RefRangeEnd = 299897, XrefRangeStart = 299874, XrefRangeEnd = 299895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAmbiguousTime(DateTime dateTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_IsAmbiguousTime_Public_Boolean_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x000723B0 File Offset: 0x000705B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299897, XrefRangeEnd = 299911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAmbiguousLocalDstFromUtc(DateTime dateTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_IsAmbiguousLocalDstFromUtc_Private_Boolean_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x000723FC File Offset: 0x000705FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299919, RefRangeEnd = 299921, XrefRangeStart = 299911, XrefRangeEnd = 299919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInDST(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rule);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_IsInDST_Private_Boolean_AdjustmentRule_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00072458 File Offset: 0x00070658
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299933, RefRangeEnd = 299935, XrefRangeStart = 299921, XrefRangeEnd = 299933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInDSTForYear(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime, int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rule);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_IsInDSTForYear_Private_Boolean_AdjustmentRule_DateTime_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x000724C4 File Offset: 0x000706C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 299949, RefRangeEnd = 299952, XrefRangeStart = 299935, XrefRangeEnd = 299949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInvalidTime(DateTime dateTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_IsInvalidTime_Public_Boolean_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00072510 File Offset: 0x00070710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299952, XrefRangeEnd = 299953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00072554 File Offset: 0x00070754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299983, RefRangeEnd = 299984, XrefRangeStart = 299953, XrefRangeEnd = 299983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Validate(string id, TimeSpan baseUtcOffset, Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> adjustmentRules)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRules);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_Validate_Private_Static_Void_String_TimeSpan_Il2CppReferenceArray_1_AdjustmentRule_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x000725AC File Offset: 0x000707AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x000725E4 File Offset: 0x000707E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299984, XrefRangeEnd = 300041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00072648 File Offset: 0x00070848
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 300073, RefRangeEnd = 300076, XrefRangeStart = 300041, XrefRangeEnd = 300073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> adjustmentRules, bool disableDaylightSavingTime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standardDisplayName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(daylightDisplayName);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRules);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref disableDaylightSavingTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr__ctor_Private_Void_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x000726FC File Offset: 0x000708FC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 300093, RefRangeEnd = 300101, XrefRangeStart = 300076, XrefRangeEnd = 300093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo.AdjustmentRule GetApplicableRule(DateTime dateTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetApplicableRule_Private_AdjustmentRule_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.AdjustmentRule>(intPtr3) : null;
			}
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x00072748 File Offset: 0x00070948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300145, RefRangeEnd = 300146, XrefRangeStart = 300101, XrefRangeEnd = 300145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetTransitionOffset(DateTime dateTime, out TimeSpan offset, out bool isDst, bool forOffset = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isDst;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TryGetTransitionOffset_Private_Boolean_DateTime_byref_TimeSpan_byref_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x000727BC File Offset: 0x000709BC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 300163, RefRangeEnd = 300172, XrefRangeStart = 300146, XrefRangeEnd = 300163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime TransitionPoint(TimeZoneInfo.TransitionTime transition, int year)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_TransitionPoint_Private_Static_DateTime_TransitionTime_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00072808 File Offset: 0x00070A08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300186, RefRangeEnd = 300187, XrefRangeStart = 300172, XrefRangeEnd = 300186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> ValidateRules(List<TimeZoneInfo.AdjustmentRule> adjustmentRules)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(adjustmentRules);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ValidateRules_Private_Static_Il2CppReferenceArray_1_AdjustmentRule_List_1_AdjustmentRule_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule>>(intPtr3) : null;
			}
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0007284C File Offset: 0x00070A4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300199, RefRangeEnd = 300200, XrefRangeStart = 300187, XrefRangeEnd = 300199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo BuildFromStream(string id, Stream stream)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_BuildFromStream_Private_Static_TimeZoneInfo_String_Stream_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x000728A4 File Offset: 0x00070AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300200, XrefRangeEnd = 300208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidTZFile(Il2CppStructArray<byte> buffer, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ValidTZFile_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x000728F4 File Offset: 0x00070AF4
		[CallerCount(0)]
		public unsafe static int SwapInt32(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_SwapInt32_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00072934 File Offset: 0x00070B34
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 300213, RefRangeEnd = 300223, XrefRangeStart = 300208, XrefRangeEnd = 300213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadBigEndianInt32(Il2CppStructArray<byte> buffer, int start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ReadBigEndianInt32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00072984 File Offset: 0x00070B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300356, RefRangeEnd = 300357, XrefRangeStart = 300223, XrefRangeEnd = 300356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo ParseTZBuffer(string id, Il2CppStructArray<byte> buffer, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ParseTZBuffer_Private_Static_TimeZoneInfo_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr3) : null;
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x000729E8 File Offset: 0x00070BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300381, RefRangeEnd = 300382, XrefRangeStart = 300357, XrefRangeEnd = 300381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, string> ParseAbbreviations(Il2CppStructArray<byte> buffer, int index, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ParseAbbreviations_Private_Static_Dictionary_2_Int32_String_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00072A48 File Offset: 0x00070C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300382, XrefRangeEnd = 300399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, TimeType> ParseTimesTypes(Il2CppStructArray<byte> buffer, int index, int count, Dictionary<int, string> abbreviations)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abbreviations);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ParseTimesTypes_Private_Static_Dictionary_2_Int32_TimeType_Il2CppStructArray_1_Byte_Int32_Int32_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TimeType>>(intPtr3) : null;
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00072ABC File Offset: 0x00070CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300399, XrefRangeEnd = 300417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<KeyValuePair<DateTime, TimeType>> ParseTransitions(Il2CppStructArray<byte> buffer, int index, int count, Dictionary<int, TimeType> time_types)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(time_types);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_ParseTransitions_Private_Static_List_1_KeyValuePair_2_DateTime_TimeType_Il2CppStructArray_1_Byte_Int32_Int32_Dictionary_2_Int32_TimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<DateTime, TimeType>>>(intPtr3) : null;
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00072B30 File Offset: 0x00070D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300417, XrefRangeEnd = 300419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime DateTimeFromUnixTime(long unix_time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unix_time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_DateTimeFromUnixTime_Private_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00072B70 File Offset: 0x00070D70
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 300421, RefRangeEnd = 300428, XrefRangeStart = 300419, XrefRangeEnd = 300421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetLocalUtcOffset_Internal_Static_TimeSpan_DateTime_TimeZoneInfoOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00072BBC File Offset: 0x00070DBC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 299826, RefRangeEnd = 299831, XrefRangeStart = 299826, XrefRangeEnd = 299831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffset_Internal_TimeSpan_DateTime_TimeZoneInfoOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00072C14 File Offset: 0x00070E14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 300444, RefRangeEnd = 300446, XrefRangeStart = 300428, XrefRangeEnd = 300444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(zone);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isDaylightSavings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAmbiguousLocalDst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr_GetUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00072C80 File Offset: 0x00070E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300446, XrefRangeEnd = 300449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x000062DF File Offset: 0x000044DF
		public TimeZoneInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x00072CBC File Offset: 0x00070EBC
		// (set) Token: 0x06001162 RID: 4450 RVA: 0x000062E8 File Offset: 0x000044E8
		public unsafe TimeSpan baseUtcOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_baseUtcOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_baseUtcOffset)) = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x00072CE4 File Offset: 0x00070EE4
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x00006303 File Offset: 0x00004503
		public unsafe string daylightDisplayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_daylightDisplayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_daylightDisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x00072D0C File Offset: 0x00070F0C
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x00006322 File Offset: 0x00004522
		public unsafe string displayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_displayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x00072D34 File Offset: 0x00070F34
		// (set) Token: 0x06001168 RID: 4456 RVA: 0x00006341 File Offset: 0x00004541
		public unsafe string id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x00072D5C File Offset: 0x00070F5C
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x00006360 File Offset: 0x00004560
		public unsafe static TimeZoneInfo local
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_local, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_local, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x00072D84 File Offset: 0x00070F84
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x00006372 File Offset: 0x00004572
		public unsafe List<KeyValuePair<DateTime, TimeType>> transitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_transitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<DateTime, TimeType>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_transitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x00072DB4 File Offset: 0x00070FB4
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x00006391 File Offset: 0x00004591
		public unsafe static bool readlinkNotFound
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_readlinkNotFound, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_readlinkNotFound, (void*)(&value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x00072DD0 File Offset: 0x00070FD0
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x0000639F File Offset: 0x0000459F
		public unsafe string standardDisplayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_standardDisplayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_standardDisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x00072DF8 File Offset: 0x00070FF8
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x000063BE File Offset: 0x000045BE
		public unsafe bool supportsDaylightSavingTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_supportsDaylightSavingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_supportsDaylightSavingTime)) = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x00072E20 File Offset: 0x00071020
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x000063D9 File Offset: 0x000045D9
		public unsafe static TimeZoneInfo utc
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_utc, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_utc, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x00072E48 File Offset: 0x00071048
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x000063EB File Offset: 0x000045EB
		public unsafe static string timeZoneDirectory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_timeZoneDirectory, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_timeZoneDirectory, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x00072E68 File Offset: 0x00071068
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x000063FD File Offset: 0x000045FD
		public unsafe Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule> adjustmentRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_adjustmentRules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TimeZoneInfo.AdjustmentRule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.NativeFieldInfoPtr_adjustmentRules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x00072E98 File Offset: 0x00071098
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x0000641C File Offset: 0x0000461C
		public unsafe static RegistryKey timeZoneKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_timeZoneKey, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_timeZoneKey, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x00072EC0 File Offset: 0x000710C0
		// (set) Token: 0x0600117C RID: 4476 RVA: 0x0000642E File Offset: 0x0000462E
		public unsafe static RegistryKey localZoneKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_localZoneKey, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_localZoneKey, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x00072EE8 File Offset: 0x000710E8
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x00006440 File Offset: 0x00004640
		public unsafe static ReadOnlyCollection<TimeZoneInfo> systemTimeZones
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.NativeFieldInfoPtr_systemTimeZones, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TimeZoneInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.NativeFieldInfoPtr_systemTimeZones, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeFieldInfoPtr_baseUtcOffset;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeFieldInfoPtr_daylightDisplayName;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeFieldInfoPtr_displayName;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeFieldInfoPtr_local;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeFieldInfoPtr_transitions;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeFieldInfoPtr_readlinkNotFound;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeFieldInfoPtr_standardDisplayName;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeFieldInfoPtr_supportsDaylightSavingTime;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeFieldInfoPtr_utc;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeFieldInfoPtr_timeZoneDirectory;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeFieldInfoPtr_adjustmentRules;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeFieldInfoPtr_timeZoneKey;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeFieldInfoPtr_localZoneKey;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeFieldInfoPtr_systemTimeZones;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_UtcOffsetOutOfRange_Internal_Static_Boolean_TimeSpan_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_CreateAdjustmentRule_Private_Static_List_1_AdjustmentRule_Int32_byref_Il2CppStructArray_1_Int64_byref_Il2CppStringArray_String_String_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocalUnity_Private_Static_TimeZoneInfo_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_EnumDynamicTimeZoneInformation_Internal_Static_UInt32_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicTimeZoneInformationWin32_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicTimeZoneInformationEffectiveYears_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_UInt32_byref_UInt32_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeZoneInformationForYear_Internal_Static_Boolean_UInt16_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_TIME_ZONE_INFORMATION_0;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Internal_Static_AdjustmentRule_byref_DYNAMIC_TIME_ZONE_INFORMATION_DateTime_DateTime_Int32_0;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_DYNAMIC_TIME_ZONE_INFORMATION_byref_TransitionTime_Boolean_0;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr_TryCreateTimeZone_Internal_Static_TimeZoneInfo_DYNAMIC_TIME_ZONE_INFORMATION_0;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalTimeZoneInfoWinRTFallback_Internal_Static_TimeZoneInfo_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalTimeZoneKeyNameWin32Fallback_Internal_Static_String_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_FindSystemTimeZoneByIdWinRTFallback_Internal_Static_TimeZoneInfo_String_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemTimeZonesWinRTFallback_Internal_Static_List_1_TimeZoneInfo_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUtcOffset_Public_get_TimeSpan_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_get_Local_Public_Static_get_TimeZoneInfo_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_readlink_Private_Static_Int32_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_readlink_Private_Static_String_String_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_TryGetNameFromPath_Private_Static_Boolean_String_byref_String_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocal_Private_Static_TimeZoneInfo_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_FindSystemTimeZoneByIdCore_Private_Static_TimeZoneInfo_String_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemTimeZonesCore_Private_Static_Void_List_1_TimeZoneInfo_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsDaylightSavingTime_Public_get_Boolean_0;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr_get_Utc_Public_Static_get_TimeZoneInfo_0;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeZoneDirectory_Private_Static_get_String_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWindows_Private_Static_get_Boolean_0;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr_TrimSpecial_Private_Static_String_String_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeZoneKey_Private_Static_get_RegistryKey_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalZoneKey_Private_Static_get_RegistryKey_0;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr_TryAddTicks_Private_Static_Boolean_DateTime_Int64_byref_DateTime_DateTimeKind_0;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTime_Public_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_0;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTimeFromUtc_Private_DateTime_DateTime_0;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTimeFromUtc_Public_Static_DateTime_DateTime_TimeZoneInfo_0;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTimeToUtc_Internal_Static_DateTime_DateTime_TimeZoneInfoOptions_0;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTimeToUtc_Public_Static_DateTime_DateTime_TimeZoneInfo_0;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTimeToUtc_Private_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfoOptions_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTimeNowUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_byref_Boolean_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_0;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_0;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeZoneInfo_0;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeMethodInfoPtr_FindSystemTimeZoneById_Public_Static_TimeZoneInfo_String_0;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeMethodInfoPtr_FindSystemTimeZoneByFileName_Private_Static_TimeZoneInfo_String_String_0;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr_FromRegistryKey_Private_Static_TimeZoneInfo_String_RegistryKey_0;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeMethodInfoPtr_ParseRegTzi_Private_Static_Void_List_1_AdjustmentRule_Int32_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeMethodInfoPtr_GetAdjustmentRules_Public_Il2CppReferenceArray_1_AdjustmentRule_0;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemTimeZones_Public_Static_ReadOnlyCollection_1_TimeZoneInfo_0;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffset_Public_TimeSpan_DateTime_0;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffset_Private_TimeSpan_DateTime_byref_Boolean_Boolean_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffsetHelper_Private_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_Boolean_0;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr_HasSameRules_Public_Boolean_TimeZoneInfo_0;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeMethodInfoPtr_IsAmbiguousTime_Public_Boolean_DateTime_0;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr_IsAmbiguousLocalDstFromUtc_Private_Boolean_DateTime_0;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeMethodInfoPtr_IsInDST_Private_Boolean_AdjustmentRule_DateTime_0;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeMethodInfoPtr_IsInDSTForYear_Private_Boolean_AdjustmentRule_DateTime_Int32_0;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr_IsInvalidTime_Public_Boolean_DateTime_0;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Private_Static_Void_String_TimeSpan_Il2CppReferenceArray_1_AdjustmentRule_0;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeMethodInfoPtr_GetApplicableRule_Private_AdjustmentRule_DateTime_0;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTransitionOffset_Private_Boolean_DateTime_byref_TimeSpan_byref_Boolean_Boolean_0;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeMethodInfoPtr_TransitionPoint_Private_Static_DateTime_TransitionTime_Int32_0;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeMethodInfoPtr_ValidateRules_Private_Static_Il2CppReferenceArray_1_AdjustmentRule_List_1_AdjustmentRule_0;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeMethodInfoPtr_BuildFromStream_Private_Static_TimeZoneInfo_String_Stream_0;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeMethodInfoPtr_ValidTZFile_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeMethodInfoPtr_SwapInt32_Private_Static_Int32_Int32_0;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeMethodInfoPtr_ReadBigEndianInt32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeMethodInfoPtr_ParseTZBuffer_Private_Static_TimeZoneInfo_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeMethodInfoPtr_ParseAbbreviations_Private_Static_Dictionary_2_Int32_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeMethodInfoPtr_ParseTimesTypes_Private_Static_Dictionary_2_Int32_TimeType_Il2CppStructArray_1_Byte_Int32_Int32_Dictionary_2_Int32_String_0;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeMethodInfoPtr_ParseTransitions_Private_Static_List_1_KeyValuePair_2_DateTime_TimeType_Il2CppStructArray_1_Byte_Int32_Int32_Dictionary_2_Int32_TimeType_0;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeMethodInfoPtr_DateTimeFromUnixTime_Private_Static_DateTime_Int64_0;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalUtcOffset_Internal_Static_TimeSpan_DateTime_TimeZoneInfoOptions_0;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffset_Internal_TimeSpan_DateTime_TimeZoneInfoOptions_0;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_byref_Boolean_0;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0200059E RID: 1438
		[Serializable]
		public sealed class AdjustmentRule : Object
		{
			// Token: 0x06004F3B RID: 20283 RVA: 0x0016485C File Offset: 0x00162A5C
			// Note: this type is marked as 'beforefieldinit'.
			static AdjustmentRule()
			{
				Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "AdjustmentRule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr);
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_dateStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "m_dateStart");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_dateEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "m_dateEnd");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "m_daylightDelta");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightTransitionStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "m_daylightTransitionStart");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightTransitionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "m_daylightTransitionEnd");
				TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_baseUtcOffsetDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, "m_baseUtcOffsetDelta");
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DateStart_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666291);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DateEnd_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666292);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightDelta_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666293);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightTransitionStart_Public_get_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666294);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightTransitionEnd_Public_get_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666295);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666296);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666297);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666298);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_CreateAdjustmentRule_Public_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666299);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_CreateAdjustmentRule_Internal_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666300);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_ValidateAdjustmentRule_Private_Static_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666301);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666302);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666303);
				TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr, 100666304);
			}

			// Token: 0x17001428 RID: 5160
			// (get) Token: 0x06004F3C RID: 20284 RVA: 0x00164A18 File Offset: 0x00162C18
			public unsafe DateTime DateStart
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DateStart_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001429 RID: 5161
			// (get) Token: 0x06004F3D RID: 20285 RVA: 0x00164A54 File Offset: 0x00162C54
			public unsafe DateTime DateEnd
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DateEnd_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700142A RID: 5162
			// (get) Token: 0x06004F3E RID: 20286 RVA: 0x00164A90 File Offset: 0x00162C90
			public unsafe TimeSpan DaylightDelta
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightDelta_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700142B RID: 5163
			// (get) Token: 0x06004F3F RID: 20287 RVA: 0x00164ACC File Offset: 0x00162CCC
			public unsafe TimeZoneInfo.TransitionTime DaylightTransitionStart
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightTransitionStart_Public_get_TransitionTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700142C RID: 5164
			// (get) Token: 0x06004F40 RID: 20288 RVA: 0x00164B08 File Offset: 0x00162D08
			public unsafe TimeZoneInfo.TransitionTime DaylightTransitionEnd
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_get_DaylightTransitionEnd_Public_get_TransitionTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F41 RID: 20289 RVA: 0x00164B44 File Offset: 0x00162D44
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 298566, RefRangeEnd = 298567, XrefRangeStart = 298549, XrefRangeEnd = 298566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(TimeZoneInfo.AdjustmentRule other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AdjustmentRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F42 RID: 20290 RVA: 0x00164B94 File Offset: 0x00162D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298567, XrefRangeEnd = 298568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F43 RID: 20291 RVA: 0x00164BD0 File Offset: 0x00162DD0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdjustmentRule()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F44 RID: 20292 RVA: 0x00164C0C File Offset: 0x00162E0C
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 298577, RefRangeEnd = 298587, XrefRangeStart = 298568, XrefRangeEnd = 298577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dateStart;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateEnd;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightDelta;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionStart;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionEnd;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_CreateAdjustmentRule_Public_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.AdjustmentRule>(intPtr3) : null;
			}

			// Token: 0x06004F45 RID: 20293 RVA: 0x00164C84 File Offset: 0x00162E84
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 298595, RefRangeEnd = 298597, XrefRangeStart = 298587, XrefRangeEnd = 298595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dateStart;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateEnd;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightDelta;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionStart;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionEnd;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseUtcOffsetDelta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_CreateAdjustmentRule_Internal_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.AdjustmentRule>(intPtr3) : null;
			}

			// Token: 0x06004F46 RID: 20294 RVA: 0x00164D0C File Offset: 0x00162F0C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 298616, RefRangeEnd = 298619, XrefRangeStart = 298597, XrefRangeEnd = 298616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dateStart;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateEnd;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightDelta;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionStart;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daylightTransitionEnd;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_ValidateAdjustmentRule_Private_Static_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F47 RID: 20295 RVA: 0x00164D78 File Offset: 0x00162F78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298619, XrefRangeEnd = 298620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F48 RID: 20296 RVA: 0x00164DBC File Offset: 0x00162FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298620, XrefRangeEnd = 298648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F49 RID: 20297 RVA: 0x00164E18 File Offset: 0x00163018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298648, XrefRangeEnd = 298700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdjustmentRule(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.AdjustmentRule>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.AdjustmentRule.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F4A RID: 20298 RVA: 0x0001E033 File Offset: 0x0001C233
			public AdjustmentRule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001422 RID: 5154
			// (get) Token: 0x06004F4B RID: 20299 RVA: 0x00164E7C File Offset: 0x0016307C
			// (set) Token: 0x06004F4C RID: 20300 RVA: 0x0001E03C File Offset: 0x0001C23C
			public unsafe DateTime m_dateStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_dateStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_dateStart)) = value;
				}
			}

			// Token: 0x17001423 RID: 5155
			// (get) Token: 0x06004F4D RID: 20301 RVA: 0x00164EA4 File Offset: 0x001630A4
			// (set) Token: 0x06004F4E RID: 20302 RVA: 0x0001E057 File Offset: 0x0001C257
			public unsafe DateTime m_dateEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_dateEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_dateEnd)) = value;
				}
			}

			// Token: 0x17001424 RID: 5156
			// (get) Token: 0x06004F4F RID: 20303 RVA: 0x00164ECC File Offset: 0x001630CC
			// (set) Token: 0x06004F50 RID: 20304 RVA: 0x0001E072 File Offset: 0x0001C272
			public unsafe TimeSpan m_daylightDelta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightDelta);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightDelta)) = value;
				}
			}

			// Token: 0x17001425 RID: 5157
			// (get) Token: 0x06004F51 RID: 20305 RVA: 0x00164EF4 File Offset: 0x001630F4
			// (set) Token: 0x06004F52 RID: 20306 RVA: 0x0001E08D File Offset: 0x0001C28D
			public unsafe TimeZoneInfo.TransitionTime m_daylightTransitionStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightTransitionStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightTransitionStart)) = value;
				}
			}

			// Token: 0x17001426 RID: 5158
			// (get) Token: 0x06004F53 RID: 20307 RVA: 0x00164F1C File Offset: 0x0016311C
			// (set) Token: 0x06004F54 RID: 20308 RVA: 0x0001E0A8 File Offset: 0x0001C2A8
			public unsafe TimeZoneInfo.TransitionTime m_daylightTransitionEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightTransitionEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_daylightTransitionEnd)) = value;
				}
			}

			// Token: 0x17001427 RID: 5159
			// (get) Token: 0x06004F55 RID: 20309 RVA: 0x00164F44 File Offset: 0x00163144
			// (set) Token: 0x06004F56 RID: 20310 RVA: 0x0001E0C3 File Offset: 0x0001C2C3
			public unsafe TimeSpan m_baseUtcOffsetDelta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_baseUtcOffsetDelta);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.AdjustmentRule.NativeFieldInfoPtr_m_baseUtcOffsetDelta)) = value;
				}
			}

			// Token: 0x0400404B RID: 16459
			private static readonly IntPtr NativeFieldInfoPtr_m_dateStart;

			// Token: 0x0400404C RID: 16460
			private static readonly IntPtr NativeFieldInfoPtr_m_dateEnd;

			// Token: 0x0400404D RID: 16461
			private static readonly IntPtr NativeFieldInfoPtr_m_daylightDelta;

			// Token: 0x0400404E RID: 16462
			private static readonly IntPtr NativeFieldInfoPtr_m_daylightTransitionStart;

			// Token: 0x0400404F RID: 16463
			private static readonly IntPtr NativeFieldInfoPtr_m_daylightTransitionEnd;

			// Token: 0x04004050 RID: 16464
			private static readonly IntPtr NativeFieldInfoPtr_m_baseUtcOffsetDelta;

			// Token: 0x04004051 RID: 16465
			private static readonly IntPtr NativeMethodInfoPtr_get_DateStart_Public_get_DateTime_0;

			// Token: 0x04004052 RID: 16466
			private static readonly IntPtr NativeMethodInfoPtr_get_DateEnd_Public_get_DateTime_0;

			// Token: 0x04004053 RID: 16467
			private static readonly IntPtr NativeMethodInfoPtr_get_DaylightDelta_Public_get_TimeSpan_0;

			// Token: 0x04004054 RID: 16468
			private static readonly IntPtr NativeMethodInfoPtr_get_DaylightTransitionStart_Public_get_TransitionTime_0;

			// Token: 0x04004055 RID: 16469
			private static readonly IntPtr NativeMethodInfoPtr_get_DaylightTransitionEnd_Public_get_TransitionTime_0;

			// Token: 0x04004056 RID: 16470
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AdjustmentRule_0;

			// Token: 0x04004057 RID: 16471
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x04004058 RID: 16472
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x04004059 RID: 16473
			private static readonly IntPtr NativeMethodInfoPtr_CreateAdjustmentRule_Public_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_0;

			// Token: 0x0400405A RID: 16474
			private static readonly IntPtr NativeMethodInfoPtr_CreateAdjustmentRule_Internal_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_0;

			// Token: 0x0400405B RID: 16475
			private static readonly IntPtr NativeMethodInfoPtr_ValidateAdjustmentRule_Private_Static_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_0;

			// Token: 0x0400405C RID: 16476
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

			// Token: 0x0400405D RID: 16477
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x0400405E RID: 16478
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;
		}

		// Token: 0x0200059F RID: 1439
		[Serializable]
		[StructLayout(2)]
		public struct TransitionTime
		{
			// Token: 0x06004F57 RID: 20311 RVA: 0x00164F6C File Offset: 0x0016316C
			// Note: this type is marked as 'beforefieldinit'.
			static TransitionTime()
			{
				Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "TransitionTime");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr);
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr_m_timeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "m_timeOfDay");
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr_m_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "m_month");
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr_m_week = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "m_week");
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr_m_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "m_day");
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr_m_dayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "m_dayOfWeek");
				TimeZoneInfo.TransitionTime.NativeFieldInfoPtr_m_isFixedDateRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, "m_isFixedDateRule");
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_TimeOfDay_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666305);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666306);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Week_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666307);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666308);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666309);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_IsFixedDateRule_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666310);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666311);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TransitionTime_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666312);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666313);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666314);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateFixedDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666315);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateFloatingDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666316);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateTransitionTime_Private_Static_TransitionTime_DateTime_Int32_Int32_Int32_DayOfWeek_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666317);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_ValidateTransitionTime_Private_Static_Void_DateTime_Int32_Int32_Int32_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666318);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666319);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666320);
				TimeZoneInfo.TransitionTime.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, 100666321);
			}

			// Token: 0x1700142D RID: 5165
			// (get) Token: 0x06004F58 RID: 20312 RVA: 0x00165164 File Offset: 0x00163364
			public unsafe DateTime TimeOfDay
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_TimeOfDay_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700142E RID: 5166
			// (get) Token: 0x06004F59 RID: 20313 RVA: 0x00165194 File Offset: 0x00163394
			public unsafe int Month
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700142F RID: 5167
			// (get) Token: 0x06004F5A RID: 20314 RVA: 0x001651C4 File Offset: 0x001633C4
			public unsafe int Week
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Week_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001430 RID: 5168
			// (get) Token: 0x06004F5B RID: 20315 RVA: 0x001651F4 File Offset: 0x001633F4
			public unsafe int Day
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001431 RID: 5169
			// (get) Token: 0x06004F5C RID: 20316 RVA: 0x00165224 File Offset: 0x00163424
			public unsafe DayOfWeek DayOfWeek
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001432 RID: 5170
			// (get) Token: 0x06004F5D RID: 20317 RVA: 0x00165254 File Offset: 0x00163454
			public unsafe bool IsFixedDateRule
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_get_IsFixedDateRule_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F5E RID: 20318 RVA: 0x00165284 File Offset: 0x00163484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298700, XrefRangeEnd = 298704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F5F RID: 20319 RVA: 0x001652C8 File Offset: 0x001634C8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 298705, RefRangeEnd = 298706, XrefRangeStart = 298704, XrefRangeEnd = 298705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool operator !=(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TransitionTime_TransitionTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F60 RID: 20320 RVA: 0x00165314 File Offset: 0x00163514
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 298711, RefRangeEnd = 298717, XrefRangeStart = 298706, XrefRangeEnd = 298711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(TimeZoneInfo.TransitionTime other)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref other;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionTime_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F61 RID: 20321 RVA: 0x00165354 File Offset: 0x00163554
			[CallerCount(0)]
			public unsafe override int GetHashCode()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F62 RID: 20322 RVA: 0x00165384 File Offset: 0x00163584
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 298718, RefRangeEnd = 298743, XrefRangeStart = 298717, XrefRangeEnd = 298718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeZoneInfo.TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref timeOfDay;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateFixedDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F63 RID: 20323 RVA: 0x001653E0 File Offset: 0x001635E0
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 298744, RefRangeEnd = 298749, XrefRangeStart = 298743, XrefRangeEnd = 298744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeZoneInfo.TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref timeOfDay;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref week;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dayOfWeek;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateFloatingDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_DayOfWeek_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F64 RID: 20324 RVA: 0x00165448 File Offset: 0x00163648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298749, XrefRangeEnd = 298750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeZoneInfo.TransitionTime CreateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref timeOfDay;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref week;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dayOfWeek;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFixedDateRule;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_CreateTransitionTime_Private_Static_TransitionTime_DateTime_Int32_Int32_Int32_DayOfWeek_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F65 RID: 20325 RVA: 0x001654CC File Offset: 0x001636CC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 298755, RefRangeEnd = 298759, XrefRangeStart = 298750, XrefRangeEnd = 298755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref timeOfDay;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref week;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dayOfWeek;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_ValidateTransitionTime_Private_Static_Void_DateTime_Int32_Int32_Int32_DayOfWeek_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F66 RID: 20326 RVA: 0x00165538 File Offset: 0x00163738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298759, XrefRangeEnd = 298760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F67 RID: 20327 RVA: 0x00165570 File Offset: 0x00163770
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298760, XrefRangeEnd = 298781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F68 RID: 20328 RVA: 0x001655C0 File Offset: 0x001637C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298781, XrefRangeEnd = 298834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TransitionTime(SerializationInfo info, StreamingContext context)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.TransitionTime.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F69 RID: 20329 RVA: 0x0001E0DE File Offset: 0x0001C2DE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeZoneInfo.TransitionTime>.NativeClassPtr, ref this));
			}

			// Token: 0x0400405F RID: 16479
			private static readonly IntPtr NativeFieldInfoPtr_m_timeOfDay;

			// Token: 0x04004060 RID: 16480
			private static readonly IntPtr NativeFieldInfoPtr_m_month;

			// Token: 0x04004061 RID: 16481
			private static readonly IntPtr NativeFieldInfoPtr_m_week;

			// Token: 0x04004062 RID: 16482
			private static readonly IntPtr NativeFieldInfoPtr_m_day;

			// Token: 0x04004063 RID: 16483
			private static readonly IntPtr NativeFieldInfoPtr_m_dayOfWeek;

			// Token: 0x04004064 RID: 16484
			private static readonly IntPtr NativeFieldInfoPtr_m_isFixedDateRule;

			// Token: 0x04004065 RID: 16485
			private static readonly IntPtr NativeMethodInfoPtr_get_TimeOfDay_Public_get_DateTime_0;

			// Token: 0x04004066 RID: 16486
			private static readonly IntPtr NativeMethodInfoPtr_get_Month_Public_get_Int32_0;

			// Token: 0x04004067 RID: 16487
			private static readonly IntPtr NativeMethodInfoPtr_get_Week_Public_get_Int32_0;

			// Token: 0x04004068 RID: 16488
			private static readonly IntPtr NativeMethodInfoPtr_get_Day_Public_get_Int32_0;

			// Token: 0x04004069 RID: 16489
			private static readonly IntPtr NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0;

			// Token: 0x0400406A RID: 16490
			private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedDateRule_Public_get_Boolean_0;

			// Token: 0x0400406B RID: 16491
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x0400406C RID: 16492
			private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TransitionTime_TransitionTime_0;

			// Token: 0x0400406D RID: 16493
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionTime_0;

			// Token: 0x0400406E RID: 16494
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x0400406F RID: 16495
			private static readonly IntPtr NativeMethodInfoPtr_CreateFixedDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_0;

			// Token: 0x04004070 RID: 16496
			private static readonly IntPtr NativeMethodInfoPtr_CreateFloatingDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_DayOfWeek_0;

			// Token: 0x04004071 RID: 16497
			private static readonly IntPtr NativeMethodInfoPtr_CreateTransitionTime_Private_Static_TransitionTime_DateTime_Int32_Int32_Int32_DayOfWeek_Boolean_0;

			// Token: 0x04004072 RID: 16498
			private static readonly IntPtr NativeMethodInfoPtr_ValidateTransitionTime_Private_Static_Void_DateTime_Int32_Int32_Int32_DayOfWeek_0;

			// Token: 0x04004073 RID: 16499
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

			// Token: 0x04004074 RID: 16500
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004075 RID: 16501
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004076 RID: 16502
			[FieldOffset(0)]
			public DateTime m_timeOfDay;

			// Token: 0x04004077 RID: 16503
			[FieldOffset(8)]
			public byte m_month;

			// Token: 0x04004078 RID: 16504
			[FieldOffset(9)]
			public byte m_week;

			// Token: 0x04004079 RID: 16505
			[FieldOffset(10)]
			public byte m_day;

			// Token: 0x0400407A RID: 16506
			[FieldOffset(12)]
			public DayOfWeek m_dayOfWeek;

			// Token: 0x0400407B RID: 16507
			[FieldOffset(16)]
			[MarshalAs(4)]
			public bool m_isFixedDateRule;
		}

		// Token: 0x020005A0 RID: 1440
		[StructLayout(2)]
		public struct SYSTEMTIME
		{
			// Token: 0x06004F6A RID: 20330 RVA: 0x00165610 File Offset: 0x00163810
			// Note: this type is marked as 'beforefieldinit'.
			static SYSTEMTIME()
			{
				Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "SYSTEMTIME");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr);
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wYear");
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wMonth");
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wDayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wDayOfWeek");
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wDay");
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wHour");
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wMinute");
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wSecond");
				TimeZoneInfo.SYSTEMTIME.NativeFieldInfoPtr_wMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, "wMilliseconds");
			}

			// Token: 0x06004F6B RID: 20331 RVA: 0x0001E0F0 File Offset: 0x0001C2F0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeZoneInfo.SYSTEMTIME>.NativeClassPtr, ref this));
			}

			// Token: 0x0400407C RID: 16508
			private static readonly IntPtr NativeFieldInfoPtr_wYear;

			// Token: 0x0400407D RID: 16509
			private static readonly IntPtr NativeFieldInfoPtr_wMonth;

			// Token: 0x0400407E RID: 16510
			private static readonly IntPtr NativeFieldInfoPtr_wDayOfWeek;

			// Token: 0x0400407F RID: 16511
			private static readonly IntPtr NativeFieldInfoPtr_wDay;

			// Token: 0x04004080 RID: 16512
			private static readonly IntPtr NativeFieldInfoPtr_wHour;

			// Token: 0x04004081 RID: 16513
			private static readonly IntPtr NativeFieldInfoPtr_wMinute;

			// Token: 0x04004082 RID: 16514
			private static readonly IntPtr NativeFieldInfoPtr_wSecond;

			// Token: 0x04004083 RID: 16515
			private static readonly IntPtr NativeFieldInfoPtr_wMilliseconds;

			// Token: 0x04004084 RID: 16516
			[FieldOffset(0)]
			public ushort wYear;

			// Token: 0x04004085 RID: 16517
			[FieldOffset(2)]
			public ushort wMonth;

			// Token: 0x04004086 RID: 16518
			[FieldOffset(4)]
			public ushort wDayOfWeek;

			// Token: 0x04004087 RID: 16519
			[FieldOffset(6)]
			public ushort wDay;

			// Token: 0x04004088 RID: 16520
			[FieldOffset(8)]
			public ushort wHour;

			// Token: 0x04004089 RID: 16521
			[FieldOffset(10)]
			public ushort wMinute;

			// Token: 0x0400408A RID: 16522
			[FieldOffset(12)]
			public ushort wSecond;

			// Token: 0x0400408B RID: 16523
			[FieldOffset(14)]
			public ushort wMilliseconds;
		}

		// Token: 0x020005A1 RID: 1441
		[StructLayout(3, CharSet = 3)]
		public sealed class TIME_ZONE_INFORMATION : ValueType
		{
			// Token: 0x06004F6C RID: 20332 RVA: 0x001656DC File Offset: 0x001638DC
			// Note: this type is marked as 'beforefieldinit'.
			static TIME_ZONE_INFORMATION()
			{
				Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "TIME_ZONE_INFORMATION");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr);
				TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_Bias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, "Bias");
				TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, "StandardName");
				TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, "StandardDate");
				TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, "StandardBias");
				TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, "DaylightName");
				TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, "DaylightDate");
				TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, "DaylightBias");
			}

			// Token: 0x06004F6D RID: 20333 RVA: 0x0001E102 File Offset: 0x0001C302
			public TIME_ZONE_INFORMATION(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004F6E RID: 20334 RVA: 0x0001E10B File Offset: 0x0001C30B
			public TIME_ZONE_INFORMATION()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr))
			{
			}

			// Token: 0x17001433 RID: 5171
			// (get) Token: 0x06004F6F RID: 20335 RVA: 0x00165794 File Offset: 0x00163994
			// (set) Token: 0x06004F70 RID: 20336 RVA: 0x0001E11D File Offset: 0x0001C31D
			public unsafe int Bias
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_Bias);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_Bias)) = value;
				}
			}

			// Token: 0x17001434 RID: 5172
			// (get) Token: 0x06004F71 RID: 20337 RVA: 0x001657BC File Offset: 0x001639BC
			// (set) Token: 0x06004F72 RID: 20338 RVA: 0x0001E138 File Offset: 0x0001C338
			public unsafe string StandardName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001435 RID: 5173
			// (get) Token: 0x06004F73 RID: 20339 RVA: 0x001657E4 File Offset: 0x001639E4
			// (set) Token: 0x06004F74 RID: 20340 RVA: 0x0001E157 File Offset: 0x0001C357
			public unsafe TimeZoneInfo.SYSTEMTIME StandardDate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardDate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardDate)) = value;
				}
			}

			// Token: 0x17001436 RID: 5174
			// (get) Token: 0x06004F75 RID: 20341 RVA: 0x0016580C File Offset: 0x00163A0C
			// (set) Token: 0x06004F76 RID: 20342 RVA: 0x0001E172 File Offset: 0x0001C372
			public unsafe int StandardBias
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardBias);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardBias)) = value;
				}
			}

			// Token: 0x17001437 RID: 5175
			// (get) Token: 0x06004F77 RID: 20343 RVA: 0x00165834 File Offset: 0x00163A34
			// (set) Token: 0x06004F78 RID: 20344 RVA: 0x0001E18D File Offset: 0x0001C38D
			public unsafe string DaylightName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001438 RID: 5176
			// (get) Token: 0x06004F79 RID: 20345 RVA: 0x0016585C File Offset: 0x00163A5C
			// (set) Token: 0x06004F7A RID: 20346 RVA: 0x0001E1AC File Offset: 0x0001C3AC
			public unsafe TimeZoneInfo.SYSTEMTIME DaylightDate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightDate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightDate)) = value;
				}
			}

			// Token: 0x17001439 RID: 5177
			// (get) Token: 0x06004F7B RID: 20347 RVA: 0x00165884 File Offset: 0x00163A84
			// (set) Token: 0x06004F7C RID: 20348 RVA: 0x0001E1C7 File Offset: 0x0001C3C7
			public unsafe int DaylightBias
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightBias);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightBias)) = value;
				}
			}

			// Token: 0x0400408C RID: 16524
			private static readonly IntPtr NativeFieldInfoPtr_Bias;

			// Token: 0x0400408D RID: 16525
			private static readonly IntPtr NativeFieldInfoPtr_StandardName;

			// Token: 0x0400408E RID: 16526
			private static readonly IntPtr NativeFieldInfoPtr_StandardDate;

			// Token: 0x0400408F RID: 16527
			private static readonly IntPtr NativeFieldInfoPtr_StandardBias;

			// Token: 0x04004090 RID: 16528
			private static readonly IntPtr NativeFieldInfoPtr_DaylightName;

			// Token: 0x04004091 RID: 16529
			private static readonly IntPtr NativeFieldInfoPtr_DaylightDate;

			// Token: 0x04004092 RID: 16530
			private static readonly IntPtr NativeFieldInfoPtr_DaylightBias;
		}

		// Token: 0x020005A2 RID: 1442
		[StructLayout(3, CharSet = 3)]
		public sealed class DYNAMIC_TIME_ZONE_INFORMATION : ValueType
		{
			// Token: 0x06004F7D RID: 20349 RVA: 0x001658AC File Offset: 0x00163AAC
			// Note: this type is marked as 'beforefieldinit'.
			static DYNAMIC_TIME_ZONE_INFORMATION()
			{
				Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "DYNAMIC_TIME_ZONE_INFORMATION");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr);
				TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TZI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr, "TZI");
				TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TimeZoneKeyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr, "TimeZoneKeyName");
				TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DynamicDaylightTimeDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr, "DynamicDaylightTimeDisabled");
			}

			// Token: 0x06004F7E RID: 20350 RVA: 0x0001E1E2 File Offset: 0x0001C3E2
			public DYNAMIC_TIME_ZONE_INFORMATION(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004F7F RID: 20351 RVA: 0x0001E1EB File Offset: 0x0001C3EB
			public DYNAMIC_TIME_ZONE_INFORMATION()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr))
			{
			}

			// Token: 0x1700143A RID: 5178
			// (get) Token: 0x06004F80 RID: 20352 RVA: 0x00165914 File Offset: 0x00163B14
			// (set) Token: 0x06004F81 RID: 20353 RVA: 0x0001E1FD File Offset: 0x0001C3FD
			public TimeZoneInfo.TIME_ZONE_INFORMATION TZI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TZI);
					return new TimeZoneInfo.TIME_ZONE_INFORMATION(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TZI), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeZoneInfo.TIME_ZONE_INFORMATION>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700143B RID: 5179
			// (get) Token: 0x06004F82 RID: 20354 RVA: 0x00165944 File Offset: 0x00163B44
			// (set) Token: 0x06004F83 RID: 20355 RVA: 0x0001E22B File Offset: 0x0001C42B
			public unsafe string TimeZoneKeyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TimeZoneKeyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_TimeZoneKeyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700143C RID: 5180
			// (get) Token: 0x06004F84 RID: 20356 RVA: 0x0016596C File Offset: 0x00163B6C
			// (set) Token: 0x06004F85 RID: 20357 RVA: 0x0001E24A File Offset: 0x0001C44A
			public unsafe byte DynamicDaylightTimeDisabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DynamicDaylightTimeDisabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DynamicDaylightTimeDisabled)) = value;
				}
			}

			// Token: 0x04004093 RID: 16531
			private static readonly IntPtr NativeFieldInfoPtr_TZI;

			// Token: 0x04004094 RID: 16532
			private static readonly IntPtr NativeFieldInfoPtr_TimeZoneKeyName;

			// Token: 0x04004095 RID: 16533
			private static readonly IntPtr NativeFieldInfoPtr_DynamicDaylightTimeDisabled;
		}

		// Token: 0x020005A3 RID: 1443
		[ObfuscatedName("System.TimeZoneInfo+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004F86 RID: 20358 RVA: 0x00165994 File Offset: 0x00163B94
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr);
				TimeZoneInfo.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr, "<>9");
				TimeZoneInfo.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr, "<>9__19_0");
				TimeZoneInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr, 100666323);
				TimeZoneInfo.__c.NativeMethodInfoPtr__CreateLocalUnity_b__19_0_Internal_Int32_AdjustmentRule_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr, 100666324);
			}

			// Token: 0x06004F87 RID: 20359 RVA: 0x00165A10 File Offset: 0x00163C10
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F88 RID: 20360 RVA: 0x00165A4C File Offset: 0x00163C4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298834, XrefRangeEnd = 298835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CreateLocalUnity_b__19_0(TimeZoneInfo.AdjustmentRule rule1, TimeZoneInfo.AdjustmentRule rule2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rule1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rule2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneInfo.__c.NativeMethodInfoPtr__CreateLocalUnity_b__19_0_Internal_Int32_AdjustmentRule_AdjustmentRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F89 RID: 20361 RVA: 0x0001E265 File Offset: 0x0001C465
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700143D RID: 5181
			// (get) Token: 0x06004F8A RID: 20362 RVA: 0x00165AAC File Offset: 0x00163CAC
			// (set) Token: 0x06004F8B RID: 20363 RVA: 0x0001E26E File Offset: 0x0001C46E
			public unsafe static TimeZoneInfo.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700143E RID: 5182
			// (get) Token: 0x06004F8C RID: 20364 RVA: 0x00165AD4 File Offset: 0x00163CD4
			// (set) Token: 0x06004F8D RID: 20365 RVA: 0x0001E280 File Offset: 0x0001C480
			public unsafe static Comparison<TimeZoneInfo.AdjustmentRule> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeZoneInfo.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<TimeZoneInfo.AdjustmentRule>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeZoneInfo.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004096 RID: 16534
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004097 RID: 16535
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04004098 RID: 16536
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004099 RID: 16537
			private static readonly IntPtr NativeMethodInfoPtr__CreateLocalUnity_b__19_0_Internal_Int32_AdjustmentRule_AdjustmentRule_0;
		}
	}
}
