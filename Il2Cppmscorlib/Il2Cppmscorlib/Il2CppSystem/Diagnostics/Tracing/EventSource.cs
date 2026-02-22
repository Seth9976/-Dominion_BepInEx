using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000506 RID: 1286
	public class EventSource : Object
	{
		// Token: 0x060049AB RID: 18859 RVA: 0x00151D14 File Offset: 0x0014FF14
		// Note: this type is marked as 'beforefieldinit'.
		static EventSource()
		{
			Il2CppClassPointerStore<EventSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSource>.NativeClassPtr);
			EventSource.NativeFieldInfoPtr_providerMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "providerMetadata");
			EventSource.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_name");
			EventSource.NativeFieldInfoPtr_m_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_id");
			EventSource.NativeFieldInfoPtr_m_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_guid");
			EventSource.NativeFieldInfoPtr_m_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_eventData");
			EventSource.NativeFieldInfoPtr_m_rawManifest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_rawManifest");
			EventSource.NativeFieldInfoPtr_m_eventCommandExecuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_eventCommandExecuted");
			EventSource.NativeFieldInfoPtr_m_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_config");
			EventSource.NativeFieldInfoPtr_m_eventSourceEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_eventSourceEnabled");
			EventSource.NativeFieldInfoPtr_m_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_level");
			EventSource.NativeFieldInfoPtr_m_matchAnyKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_matchAnyKeyword");
			EventSource.NativeFieldInfoPtr_m_Dispatchers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_Dispatchers");
			EventSource.NativeFieldInfoPtr_m_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_provider");
			EventSource.NativeFieldInfoPtr_m_completelyInited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_completelyInited");
			EventSource.NativeFieldInfoPtr_m_constructionException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_constructionException");
			EventSource.NativeFieldInfoPtr_m_outOfBandMessageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_outOfBandMessageCount");
			EventSource.NativeFieldInfoPtr_m_deferredCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_deferredCommands");
			EventSource.NativeFieldInfoPtr_m_traits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_traits");
			EventSource.NativeFieldInfoPtr_s_currentPid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "s_currentPid");
			EventSource.NativeFieldInfoPtr_m_EventSourceExceptionRecurenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_EventSourceExceptionRecurenceCount");
			EventSource.NativeFieldInfoPtr_m_curLiveSessions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_curLiveSessions");
			EventSource.NativeFieldInfoPtr_m_etwSessionIdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_etwSessionIdMap");
			EventSource.NativeFieldInfoPtr_m_legacySessions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_legacySessions");
			EventSource.NativeFieldInfoPtr_m_keywordTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_keywordTriggers");
			EventSource.NativeFieldInfoPtr_m_activityFilteringForETWEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_activityFilteringForETWEnabled");
			EventSource.NativeFieldInfoPtr_s_activityDying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "s_activityDying");
			EventSource.NativeFieldInfoPtr_m_activityTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_activityTracker");
			EventSource.NativeFieldInfoPtr_namespaceBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "namespaceBytes");
			EventSource.NativeFieldInfoPtr_AspNetEventSourceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "AspNetEventSourceGuid");
			EventSource.NativeMethodInfoPtr_WriteMultiMerge_Private_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674207);
			EventSource.NativeMethodInfoPtr_WriteMultiMergeInner_Private_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674208);
			EventSource.NativeMethodInfoPtr_WriteMultiMerge_Internal_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674209);
			EventSource.NativeMethodInfoPtr_WriteCleanup_Private_Void_ptr_GCHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674210);
			EventSource.NativeMethodInfoPtr_InitializeProviderMetadata_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674211);
			EventSource.NativeMethodInfoPtr_AddValueToMetaData_Private_Static_Int32_List_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674212);
			EventSource.NativeMethodInfoPtr_HexDigit_Private_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674213);
			EventSource.NativeMethodInfoPtr_UpdateDescriptor_Private_NameInfo_String_TraceLoggingEventTypes_byref_EventSourceOptions_byref_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674214);
			EventSource.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674215);
			EventSource.NativeMethodInfoPtr_get_Guid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674216);
			EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674217);
			EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_EventLevel_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674218);
			EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_EventLevel_EventKeywords_EventChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674219);
			EventSource.NativeMethodInfoPtr_GetGuid_Public_Static_Guid_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674220);
			EventSource.NativeMethodInfoPtr_GetName_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674221);
			EventSource.NativeMethodInfoPtr_SetCurrentThreadActivityId_Public_Static_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674222);
			EventSource.NativeMethodInfoPtr_get_CurrentThreadActivityId_Public_Static_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674223);
			EventSource.NativeMethodInfoPtr_get_InternalCurrentThreadActivityId_Internal_Static_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674224);
			EventSource.NativeMethodInfoPtr_get_FallbackActivityId_Internal_Static_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674225);
			EventSource.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674226);
			EventSource.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674227);
			EventSource.NativeMethodInfoPtr__ctor_Protected_Void_EventSourceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674228);
			EventSource.NativeMethodInfoPtr__ctor_Protected_Void_EventSourceSettings_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674229);
			EventSource.NativeMethodInfoPtr_OnEventCommand_Protected_Virtual_New_Void_EventCommandEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674230);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674231);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674232);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674233);
			EventSource.NativeMethodInfoPtr_WriteEventCore_Protected_Void_Int32_Int32_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674234);
			EventSource.NativeMethodInfoPtr_WriteEventWithRelatedActivityIdCore_Protected_Void_Int32_ptr_Guid_Int32_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674235);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674236);
			EventSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674237);
			EventSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674238);
			EventSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674239);
			EventSource.NativeMethodInfoPtr_WriteStringToListener_Internal_Void_EventListener_String_SessionMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674240);
			EventSource.NativeMethodInfoPtr_WriteEventRaw_Private_Void_String_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674241);
			EventSource.NativeMethodInfoPtr_Initialize_Private_Void_Guid_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674242);
			EventSource.NativeMethodInfoPtr_GetName_Private_Static_String_Type_EventManifestOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674243);
			EventSource.NativeMethodInfoPtr_GenerateGuidFromName_Private_Static_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674244);
			EventSource.NativeMethodInfoPtr_DecodeObject_Private_Object_Int32_Int32_byref_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674245);
			EventSource.NativeMethodInfoPtr_GetDispatcher_Private_EventDispatcher_EventListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674246);
			EventSource.NativeMethodInfoPtr_WriteEventVarargs_Private_Void_Int32_ptr_Guid_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674247);
			EventSource.NativeMethodInfoPtr_SerializeEventArgs_Private_Il2CppReferenceArray_1_Object_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674248);
			EventSource.NativeMethodInfoPtr_LogEventArgsMismatches_Private_Void_Il2CppReferenceArray_1_ParameterInfo_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674249);
			EventSource.NativeMethodInfoPtr_GetParamLengthIncludingByteArray_Private_Int32_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674250);
			EventSource.NativeMethodInfoPtr_WriteToAllListeners_Private_Void_Int32_ptr_Guid_Int32_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674251);
			EventSource.NativeMethodInfoPtr_WriteToAllListeners_Private_Void_Int32_ptr_Guid_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674252);
			EventSource.NativeMethodInfoPtr_DispatchToAllListeners_Private_Void_Int32_ptr_Guid_EventWrittenEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674253);
			EventSource.NativeMethodInfoPtr_WriteEventString_Private_Void_EventLevel_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674254);
			EventSource.NativeMethodInfoPtr_WriteStringToAllListeners_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674255);
			EventSource.NativeMethodInfoPtr_GetEtwSessionMask_Private_SessionMask_Int32_ptr_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674256);
			EventSource.NativeMethodInfoPtr_IsEnabledByDefault_Private_Boolean_Int32_Boolean_EventLevel_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674257);
			EventSource.NativeMethodInfoPtr_IsEnabledCommon_Private_Boolean_Boolean_EventLevel_EventKeywords_EventLevel_EventKeywords_EventChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674258);
			EventSource.NativeMethodInfoPtr_ThrowEventSourceException_Private_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674259);
			EventSource.NativeMethodInfoPtr_ValidateEventOpcodeForTransfer_Private_Void_byref_EventMetadata_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674260);
			EventSource.NativeMethodInfoPtr_GetOpcodeWithDefault_Internal_Static_EventOpcode_EventOpcode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674261);
			EventSource.NativeMethodInfoPtr_SendCommand_Internal_Void_EventListener_Int32_Int32_EventCommand_Boolean_EventLevel_EventKeywords_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674262);
			EventSource.NativeMethodInfoPtr_DoCommand_Internal_Void_EventCommandEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674263);
			EventSource.NativeMethodInfoPtr_UpdateEtwSession_Internal_Void_Int32_Int32_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674264);
			EventSource.NativeMethodInfoPtr_ParseCommandArgs_Internal_Static_Boolean_IDictionary_2_String_String_byref_Boolean_byref_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674265);
			EventSource.NativeMethodInfoPtr_UpdateKwdTriggers_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674266);
			EventSource.NativeMethodInfoPtr_EnableEventForDispatcher_Internal_Boolean_EventDispatcher_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674267);
			EventSource.NativeMethodInfoPtr_AnyEventEnabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674268);
			EventSource.NativeMethodInfoPtr_get_IsDisposed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674269);
			EventSource.NativeMethodInfoPtr_EnsureDescriptorsInitialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674270);
			EventSource.NativeMethodInfoPtr_SendManifest_Private_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674271);
			EventSource.NativeMethodInfoPtr_GetCustomAttributeHelper_Internal_Static_Attribute_MemberInfo_Type_EventManifestOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674272);
			EventSource.NativeMethodInfoPtr_AttributeTypeNamesMatch_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674273);
			EventSource.NativeMethodInfoPtr_GetEventSourceBaseType_Private_Static_Type_Type_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674274);
			EventSource.NativeMethodInfoPtr_CreateManifestAndDescriptors_Private_Static_Il2CppStructArray_1_Byte_Type_String_EventSource_EventManifestOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674275);
			EventSource.NativeMethodInfoPtr_RemoveFirstArgIfRelatedActivityId_Private_Static_Boolean_byref_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674276);
			EventSource.NativeMethodInfoPtr_AddProviderEnumKind_Private_Static_Void_ManifestBuilder_FieldInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674277);
			EventSource.NativeMethodInfoPtr_AddEventDescriptor_Private_Static_Void_byref_Il2CppReferenceArray_1_EventMetadata_String_EventAttribute_Il2CppReferenceArray_1_ParameterInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674278);
			EventSource.NativeMethodInfoPtr_TrimEventDescriptors_Private_Static_Void_byref_Il2CppReferenceArray_1_EventMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674279);
			EventSource.NativeMethodInfoPtr_AddListener_Internal_Void_EventListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674280);
			EventSource.NativeMethodInfoPtr_DebugCheckEvent_Private_Static_Void_byref_Dictionary_2_String_String_Il2CppReferenceArray_1_EventMetadata_MethodInfo_EventAttribute_ManifestBuilder_EventManifestOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674281);
			EventSource.NativeMethodInfoPtr_GetHelperCallFirstArg_Private_Static_Int32_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674282);
			EventSource.NativeMethodInfoPtr_ReportOutOfBandMessage_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674283);
			EventSource.NativeMethodInfoPtr_ValidateSettings_Private_EventSourceSettings_EventSourceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674284);
			EventSource.NativeMethodInfoPtr_get_ThrowOnEventWriteErrors_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674285);
			EventSource.NativeMethodInfoPtr_get_SelfDescribingEvents_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674286);
			EventSource.NativeMethodInfoPtr_ReportActivitySamplingInfo_Private_Void_EventListener_SessionMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674287);
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x001525DC File Offset: 0x001507DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370134, XrefRangeEnd = 370137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, [Optional] Il2CppReferenceArray<Object> values)
		{
			if (values == null)
			{
				values = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteMultiMerge_Private_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x0015267C File Offset: 0x0015087C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370177, RefRangeEnd = 370179, XrefRangeStart = 370137, XrefRangeEnd = 370177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMultiMergeInner(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, [Optional] Il2CppReferenceArray<Object> values)
		{
			if (values == null)
			{
				values = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteMultiMergeInner_Private_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x0015271C File Offset: 0x0015091C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370208, RefRangeEnd = 370209, XrefRangeStart = 370179, XrefRangeEnd = 370208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, EventSource.EventData* data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteMultiMerge_Internal_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_ptr_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x001527A8 File Offset: 0x001509A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370209, XrefRangeEnd = 370217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCleanup(GCHandle* pPins, int cPins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pPins;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cPins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteCleanup_Private_Void_ptr_GCHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x001527F4 File Offset: 0x001509F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370270, RefRangeEnd = 370271, XrefRangeStart = 370217, XrefRangeEnd = 370270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeProviderMetadata()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_InitializeProviderMetadata_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x00152828 File Offset: 0x00150A28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370295, RefRangeEnd = 370296, XrefRangeStart = 370271, XrefRangeEnd = 370295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AddValueToMetaData(List<byte> metaData, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metaData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_AddValueToMetaData_Private_Static_Int32_List_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x0015287C File Offset: 0x00150A7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370296, RefRangeEnd = 370298, XrefRangeStart = 370296, XrefRangeEnd = 370296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int HexDigit(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_HexDigit_Private_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x001528BC File Offset: 0x00150ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370298, XrefRangeEnd = 370304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo UpdateDescriptor(string name, TraceLoggingEventTypes eventInfo, ref EventSourceOptions options, out EventDescriptor descriptor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &descriptor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_UpdateDescriptor_Private_NameInfo_String_TraceLoggingEventTypes_byref_EventSourceOptions_byref_EventDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x060049B4 RID: 18868 RVA: 0x0015293C File Offset: 0x00150B3C
		public unsafe string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x060049B5 RID: 18869 RVA: 0x00152974 File Offset: 0x00150B74
		public unsafe Guid Guid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_Guid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049B6 RID: 18870 RVA: 0x001529B0 File Offset: 0x00150BB0
		[CallerCount(0)]
		public unsafe bool IsEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049B7 RID: 18871 RVA: 0x001529EC File Offset: 0x00150BEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370304, RefRangeEnd = 370306, XrefRangeStart = 370304, XrefRangeEnd = 370304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEnabled(EventLevel level, EventKeywords keywords)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywords;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_EventLevel_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049B8 RID: 18872 RVA: 0x00152A44 File Offset: 0x00150C44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370304, RefRangeEnd = 370306, XrefRangeStart = 370304, XrefRangeEnd = 370306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEnabled(EventLevel level, EventKeywords keywords, EventChannel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywords;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_EventLevel_EventKeywords_EventChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049B9 RID: 18873 RVA: 0x00152AAC File Offset: 0x00150CAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370326, RefRangeEnd = 370329, XrefRangeStart = 370306, XrefRangeEnd = 370326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid GetGuid(Type eventSourceType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSourceType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetGuid_Public_Static_Guid_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x00152AF0 File Offset: 0x00150CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370329, XrefRangeEnd = 370333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(Type eventSourceType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSourceType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetName_Public_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x00152B2C File Offset: 0x00150D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370333, XrefRangeEnd = 370359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCurrentThreadActivityId(Guid activityId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref activityId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_SetCurrentThreadActivityId_Public_Static_Void_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x060049BC RID: 18876 RVA: 0x00152B60 File Offset: 0x00150D60
		public unsafe static Guid CurrentThreadActivityId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370359, XrefRangeEnd = 370360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_CurrentThreadActivityId_Public_Static_get_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x060049BD RID: 18877 RVA: 0x00152B90 File Offset: 0x00150D90
		public unsafe static Guid InternalCurrentThreadActivityId
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 370372, RefRangeEnd = 370376, XrefRangeStart = 370360, XrefRangeEnd = 370372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_InternalCurrentThreadActivityId_Internal_Static_get_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x060049BE RID: 18878 RVA: 0x00152BC0 File Offset: 0x00150DC0
		public unsafe static Guid FallbackActivityId
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 370382, RefRangeEnd = 370384, XrefRangeStart = 370376, XrefRangeEnd = 370382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_FallbackActivityId_Internal_Static_get_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x00152BF0 File Offset: 0x00150DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370384, XrefRangeEnd = 370399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSource.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060049C0 RID: 18880 RVA: 0x00152C34 File Offset: 0x00150E34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370410, RefRangeEnd = 370412, XrefRangeStart = 370399, XrefRangeEnd = 370410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C1 RID: 18881 RVA: 0x00152C70 File Offset: 0x00150E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370412, XrefRangeEnd = 370423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSource(EventSourceSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref settings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr__ctor_Protected_Void_EventSourceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049C2 RID: 18882 RVA: 0x00152CB8 File Offset: 0x00150EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370423, XrefRangeEnd = 370434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSource(EventSourceSettings settings, [Optional] Il2CppStringArray traits)
		{
			if (traits == null)
			{
				traits = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref settings;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(traits);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr__ctor_Protected_Void_EventSourceSettings_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C3 RID: 18883 RVA: 0x00152D20 File Offset: 0x00150F20
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEventCommand(EventCommandEventArgs command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSource.NativeMethodInfoPtr_OnEventCommand_Protected_Virtual_New_Void_EventCommandEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x00152D70 File Offset: 0x00150F70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370438, RefRangeEnd = 370439, XrefRangeStart = 370434, XrefRangeEnd = 370438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, int arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C5 RID: 18885 RVA: 0x00152DBC File Offset: 0x00150FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370450, RefRangeEnd = 370451, XrefRangeStart = 370439, XrefRangeEnd = 370450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, string arg1, string arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C6 RID: 18886 RVA: 0x00152E20 File Offset: 0x00151020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370464, RefRangeEnd = 370465, XrefRangeStart = 370451, XrefRangeEnd = 370464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, string arg1, string arg2, string arg3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x00152E98 File Offset: 0x00151098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370465, XrefRangeEnd = 370466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventDataCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEventCore_Protected_Void_Int32_Int32_ptr_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x00152EF4 File Offset: 0x001510F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 370553, RefRangeEnd = 370557, XrefRangeStart = 370466, XrefRangeEnd = 370553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEventWithRelatedActivityIdCore(int eventId, Guid* relatedActivityId, int eventDataCount, EventSource.EventData* data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = relatedActivityId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventDataCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEventWithRelatedActivityIdCore_Protected_Void_Int32_ptr_Guid_Int32_ptr_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x00152F5C File Offset: 0x0015115C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370558, RefRangeEnd = 370559, XrefRangeStart = 370557, XrefRangeEnd = 370558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x00152FBC File Offset: 0x001511BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370563, RefRangeEnd = 370564, XrefRangeStart = 370559, XrefRangeEnd = 370563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x00152FF0 File Offset: 0x001511F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370564, XrefRangeEnd = 370574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x0015303C File Offset: 0x0015123C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x00153078 File Offset: 0x00151278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370593, RefRangeEnd = 370595, XrefRangeStart = 370574, XrefRangeEnd = 370593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteStringToListener(EventListener listener, string msg, SessionMask m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteStringToListener_Internal_Void_EventListener_String_SessionMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x001530DC File Offset: 0x001512DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370604, RefRangeEnd = 370606, XrefRangeStart = 370595, XrefRangeEnd = 370604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEventRaw(string eventName, ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &eventDescriptor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = relatedActivityID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEventRaw_Private_Void_String_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x00153164 File Offset: 0x00151364
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370655, RefRangeEnd = 370658, XrefRangeStart = 370606, XrefRangeEnd = 370655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Guid eventSourceGuid, string eventSourceName, Il2CppStringArray traits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventSourceGuid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventSourceName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(traits);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_Initialize_Private_Void_Guid_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x001531C8 File Offset: 0x001513C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 370673, RefRangeEnd = 370677, XrefRangeStart = 370658, XrefRangeEnd = 370673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(Type eventSourceType, EventManifestOptions flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSourceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetName_Private_Static_String_Type_EventManifestOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x00153214 File Offset: 0x00151414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370677, XrefRangeEnd = 370690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid GenerateGuidFromName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GenerateGuidFromName_Private_Static_Guid_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049D2 RID: 18898 RVA: 0x00153258 File Offset: 0x00151458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370845, RefRangeEnd = 370846, XrefRangeStart = 370690, XrefRangeEnd = 370845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object DecodeObject(int eventId, int parameterId, ref EventSource.EventData* data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameterId;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_DecodeObject_Private_Object_Int32_Int32_byref_ptr_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new EventSource.EventData*(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x060049D3 RID: 18899 RVA: 0x001532DC File Offset: 0x001514DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370847, RefRangeEnd = 370848, XrefRangeStart = 370846, XrefRangeEnd = 370847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDispatcher GetDispatcher(EventListener listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetDispatcher_Private_EventDispatcher_EventListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr3) : null;
			}
		}

		// Token: 0x060049D4 RID: 18900 RVA: 0x0015332C File Offset: 0x0015152C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370942, RefRangeEnd = 370943, XrefRangeStart = 370848, XrefRangeEnd = 370942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEventVarargs(int eventId, Guid* childActivityID, Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEventVarargs_Private_Void_Int32_ptr_Guid_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049D5 RID: 18901 RVA: 0x0015338C File Offset: 0x0015158C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370957, RefRangeEnd = 370958, XrefRangeStart = 370943, XrefRangeEnd = 370957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> SerializeEventArgs(int eventId, Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_SerializeEventArgs_Private_Il2CppReferenceArray_1_Object_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060049D6 RID: 18902 RVA: 0x001533EC File Offset: 0x001515EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370979, RefRangeEnd = 370980, XrefRangeStart = 370958, XrefRangeEnd = 370979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogEventArgsMismatches(Il2CppReferenceArray<ParameterInfo> infos, Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(infos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_LogEventArgsMismatches_Private_Void_Il2CppReferenceArray_1_ParameterInfo_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049D7 RID: 18903 RVA: 0x00153440 File Offset: 0x00151640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370980, XrefRangeEnd = 370988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParamLengthIncludingByteArray(Il2CppReferenceArray<ParameterInfo> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetParamLengthIncludingByteArray_Private_Int32_Il2CppReferenceArray_1_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x00153490 File Offset: 0x00151690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371062, RefRangeEnd = 371063, XrefRangeStart = 370988, XrefRangeEnd = 371062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteToAllListeners(int eventId, Guid* childActivityID, int eventDataCount, EventSource.EventData* data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventDataCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteToAllListeners_Private_Void_Int32_ptr_Guid_Int32_ptr_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x001534F8 File Offset: 0x001516F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371081, RefRangeEnd = 371083, XrefRangeStart = 371063, XrefRangeEnd = 371081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteToAllListeners(int eventId, Guid* childActivityID, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteToAllListeners_Private_Void_Int32_ptr_Guid_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x00153564 File Offset: 0x00151764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371092, RefRangeEnd = 371093, XrefRangeStart = 371083, XrefRangeEnd = 371092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchToAllListeners(int eventId, Guid* childActivityID, EventWrittenEventArgs eventCallbackArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCallbackArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_DispatchToAllListeners_Private_Void_Int32_ptr_Guid_EventWrittenEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x001535C4 File Offset: 0x001517C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371132, RefRangeEnd = 371133, XrefRangeStart = 371093, XrefRangeEnd = 371132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEventString(EventLevel level, long keywords, string msgString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywords;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msgString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEventString_Private_Void_EventLevel_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049DC RID: 18908 RVA: 0x00153624 File Offset: 0x00151824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371173, RefRangeEnd = 371174, XrefRangeStart = 371133, XrefRangeEnd = 371173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteStringToAllListeners(string eventName, string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteStringToAllListeners_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049DD RID: 18909 RVA: 0x00153678 File Offset: 0x00151878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371201, RefRangeEnd = 371203, XrefRangeStart = 371174, XrefRangeEnd = 371201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SessionMask GetEtwSessionMask(int eventId, Guid* childActivityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetEtwSessionMask_Private_SessionMask_Int32_ptr_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x001536D0 File Offset: 0x001518D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371203, XrefRangeEnd = 371207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEnabledByDefault(int eventNum, bool enable, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentMatchAnyKeyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_IsEnabledByDefault_Private_Boolean_Int32_Boolean_EventLevel_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x00153744 File Offset: 0x00151944
		[CallerCount(0)]
		public unsafe bool IsEnabledCommon(bool enabled, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword, EventLevel eventLevel, EventKeywords eventKeywords, EventChannel eventChannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentMatchAnyKeyword;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventKeywords;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventChannel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_IsEnabledCommon_Private_Boolean_Boolean_EventLevel_EventKeywords_EventLevel_EventKeywords_EventChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x001537D4 File Offset: 0x001519D4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 371284, RefRangeEnd = 371295, XrefRangeStart = 371207, XrefRangeEnd = 371284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowEventSourceException(string eventName, Exception innerEx = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerEx);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_ThrowEventSourceException_Private_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x00153828 File Offset: 0x00151A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371295, XrefRangeEnd = 371296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEventOpcodeForTransfer(ref EventSource.EventMetadata eventData, string eventName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_ValidateEventOpcodeForTransfer_Private_Void_byref_EventMetadata_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x00153880 File Offset: 0x00151A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371296, XrefRangeEnd = 371302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventOpcode GetOpcodeWithDefault(EventOpcode opcode, string eventName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetOpcodeWithDefault_Internal_Static_EventOpcode_EventOpcode_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x001538D0 File Offset: 0x00151AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371318, RefRangeEnd = 371319, XrefRangeStart = 371302, XrefRangeEnd = 371318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCommand(EventListener listener, int perEventSourceSessionId, int etwSessionId, EventCommand command, bool enable, EventLevel level, EventKeywords matchAnyKeyword, IDictionary<string, string> commandArguments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref perEventSourceSessionId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwSessionId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref command;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enable;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchAnyKeyword;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commandArguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_SendCommand_Internal_Void_EventListener_Int32_Int32_EventCommand_Boolean_EventLevel_EventKeywords_IDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x0015397C File Offset: 0x00151B7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371408, RefRangeEnd = 371410, XrefRangeStart = 371319, XrefRangeEnd = 371408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCommand(EventCommandEventArgs commandArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandArgs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_DoCommand_Internal_Void_EventCommandEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x001539C0 File Offset: 0x00151BC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371424, RefRangeEnd = 371426, XrefRangeStart = 371410, XrefRangeEnd = 371424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEtwSession(int sessionIdBit, int etwSessionId, bool bEnable, string activityFilters, bool participateInSampling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sessionIdBit;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwSessionId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnable;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activityFilters);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref participateInSampling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_UpdateEtwSession_Internal_Void_Int32_Int32_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049E6 RID: 18918 RVA: 0x00153A3C File Offset: 0x00151C3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371448, RefRangeEnd = 371449, XrefRangeStart = 371426, XrefRangeEnd = 371448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseCommandArgs(IDictionary<string, string> commandArguments, out bool participateInSampling, out string activityFilters, out int sessionIdBit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandArguments);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &participateInSampling;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sessionIdBit;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_ParseCommandArgs_Internal_Static_Boolean_IDictionary_2_String_String_byref_Boolean_byref_String_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			activityFilters = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060049E7 RID: 18919 RVA: 0x00153AB4 File Offset: 0x00151CB4
		[CallerCount(0)]
		public unsafe void UpdateKwdTriggers(bool enable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_UpdateKwdTriggers_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049E8 RID: 18920 RVA: 0x00153AF4 File Offset: 0x00151CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371449, XrefRangeEnd = 371454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EnableEventForDispatcher(EventDispatcher dispatcher, int eventId, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dispatcher);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_EnableEventForDispatcher_Internal_Boolean_EventDispatcher_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049E9 RID: 18921 RVA: 0x00153B60 File Offset: 0x00151D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371454, XrefRangeEnd = 371459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AnyEventEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_AnyEventEnabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x060049EA RID: 18922 RVA: 0x00153B9C File Offset: 0x00151D9C
		public unsafe bool IsDisposed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371460, RefRangeEnd = 371461, XrefRangeStart = 371459, XrefRangeEnd = 371460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_IsDisposed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049EB RID: 18923 RVA: 0x00153BD8 File Offset: 0x00151DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371504, RefRangeEnd = 371505, XrefRangeStart = 371461, XrefRangeEnd = 371504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureDescriptorsInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_EnsureDescriptorsInitialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049EC RID: 18924 RVA: 0x00153C0C File Offset: 0x00151E0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 371526, RefRangeEnd = 371530, XrefRangeStart = 371505, XrefRangeEnd = 371526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendManifest(Il2CppStructArray<byte> rawManifest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawManifest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_SendManifest_Private_Boolean_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x00153C5C File Offset: 0x00151E5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 371544, RefRangeEnd = 371547, XrefRangeStart = 371530, XrefRangeEnd = 371544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttributeHelper(MemberInfo member, Type attributeType, EventManifestOptions flags = EventManifestOptions.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetCustomAttributeHelper_Internal_Static_Attribute_MemberInfo_Type_EventManifestOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x060049EE RID: 18926 RVA: 0x00153CC0 File Offset: 0x00151EC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 371558, RefRangeEnd = 371561, XrefRangeStart = 371547, XrefRangeEnd = 371558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AttributeTypeNamesMatch(Type attributeType, Type reflectedAttributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedAttributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_AttributeTypeNamesMatch_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x00153D14 File Offset: 0x00151F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371561, XrefRangeEnd = 371578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetEventSourceBaseType(Type eventSourceType, bool allowEventSourceOverride, bool reflectionOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSourceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowEventSourceOverride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reflectionOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetEventSourceBaseType_Private_Static_Type_Type_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x00153D74 File Offset: 0x00151F74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371624, RefRangeEnd = 371625, XrefRangeStart = 371578, XrefRangeEnd = 371624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> CreateManifestAndDescriptors(Type eventSourceType, string eventSourceDllName, EventSource source, EventManifestOptions flags = EventManifestOptions.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSourceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventSourceDllName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_CreateManifestAndDescriptors_Private_Static_Il2CppStructArray_1_Byte_Type_String_EventSource_EventManifestOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x00153DEC File Offset: 0x00151FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371625, XrefRangeEnd = 371639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveFirstArgIfRelatedActivityId(ref Il2CppReferenceArray<ParameterInfo> args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_RemoveFirstArgIfRelatedActivityId_Private_Static_Boolean_byref_Il2CppReferenceArray_1_ParameterInfo_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				args = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<ParameterInfo>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x00153E44 File Offset: 0x00152044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371639, XrefRangeEnd = 371693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddProviderEnumKind(ManifestBuilder manifest, FieldInfo staticField, string providerEnumKind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(manifest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(staticField);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerEnumKind);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_AddProviderEnumKind_Private_Static_Void_ManifestBuilder_FieldInfo_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x00153EA0 File Offset: 0x001520A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371693, XrefRangeEnd = 371705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddEventDescriptor(ref Il2CppReferenceArray<EventSource.EventMetadata> eventData, string eventName, EventAttribute eventAttribute, Il2CppReferenceArray<ParameterInfo> eventParameters, bool hasRelatedActivityID)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventAttribute);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventParameters);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasRelatedActivityID;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_AddEventDescriptor_Private_Static_Void_byref_Il2CppReferenceArray_1_EventMetadata_String_EventAttribute_Il2CppReferenceArray_1_ParameterInfo_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			eventData = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<EventSource.EventMetadata>(intPtr4));
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x00153F30 File Offset: 0x00152130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371705, XrefRangeEnd = 371709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrimEventDescriptors(ref Il2CppReferenceArray<EventSource.EventMetadata> eventData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_TrimEventDescriptors_Private_Static_Void_byref_Il2CppReferenceArray_1_EventMetadata_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				eventData = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<EventSource.EventMetadata>(intPtr4));
			}
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x00153F7C File Offset: 0x0015217C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371727, RefRangeEnd = 371728, XrefRangeStart = 371709, XrefRangeEnd = 371727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListener(EventListener listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_AddListener_Internal_Void_EventListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x00153FC0 File Offset: 0x001521C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371728, XrefRangeEnd = 371867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DebugCheckEvent(ref Dictionary<string, string> eventsByName, Il2CppReferenceArray<EventSource.EventMetadata> eventData, MethodInfo method, EventAttribute eventAttribute, ManifestBuilder manifest, EventManifestOptions options)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(eventsByName);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventAttribute);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manifest);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_DebugCheckEvent_Private_Static_Void_byref_Dictionary_2_String_String_Il2CppReferenceArray_1_EventMetadata_MethodInfo_EventAttribute_ManifestBuilder_EventManifestOptions_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			eventsByName = ((intPtr4 == 0) ? null : new Dictionary<string, string>(intPtr4));
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x00154064 File Offset: 0x00152264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371868, RefRangeEnd = 371869, XrefRangeStart = 371867, XrefRangeEnd = 371868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHelperCallFirstArg(MethodInfo method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetHelperCallFirstArg_Private_Static_Int32_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x001540A8 File Offset: 0x001522A8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 371885, RefRangeEnd = 371896, XrefRangeStart = 371869, XrefRangeEnd = 371885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReportOutOfBandMessage(string msg, bool flush)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_ReportOutOfBandMessage_Internal_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x001540F8 File Offset: 0x001522F8
		[CallerCount(0)]
		public unsafe EventSourceSettings ValidateSettings(EventSourceSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref settings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_ValidateSettings_Private_EventSourceSettings_EventSourceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x060049FA RID: 18938 RVA: 0x00154144 File Offset: 0x00152344
		public unsafe bool ThrowOnEventWriteErrors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_ThrowOnEventWriteErrors_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x060049FB RID: 18939 RVA: 0x00154180 File Offset: 0x00152380
		public unsafe bool SelfDescribingEvents
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_SelfDescribingEvents_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x001541BC File Offset: 0x001523BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371948, RefRangeEnd = 371949, XrefRangeStart = 371896, XrefRangeEnd = 371948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReportActivitySamplingInfo(EventListener listener, SessionMask sessions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_ReportActivitySamplingInfo_Private_Void_EventListener_SessionMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049FD RID: 18941 RVA: 0x0001B9AE File Offset: 0x00019BAE
		public unsafe void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, params Object[] values)
		{
			this.WriteMultiMerge(eventName, ref options, eventTypes, activityID, childActivityID, new Il2CppReferenceArray<Object>(values));
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x0001B9C4 File Offset: 0x00019BC4
		public unsafe void WriteMultiMergeInner(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, params Object[] values)
		{
			this.WriteMultiMergeInner(eventName, ref options, eventTypes, activityID, childActivityID, new Il2CppReferenceArray<Object>(values));
		}

		// Token: 0x060049FF RID: 18943 RVA: 0x0001B9DA File Offset: 0x00019BDA
		public EventSource(EventSourceSettings settings, params string[] traits)
			: this(settings, new Il2CppStringArray(traits))
		{
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x0001B9E9 File Offset: 0x00019BE9
		public void WriteEvent(int eventId, params Object[] args)
		{
			this.WriteEvent(eventId, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x0001B9F8 File Offset: 0x00019BF8
		public unsafe void WriteToAllListeners(int eventId, Guid* childActivityID, params Object[] args)
		{
			this.WriteToAllListeners(eventId, childActivityID, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x0001BA08 File Offset: 0x00019C08
		public EventSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06004A03 RID: 18947 RVA: 0x0015420C File Offset: 0x0015240C
		// (set) Token: 0x06004A04 RID: 18948 RVA: 0x0001BA11 File Offset: 0x00019C11
		public unsafe Il2CppStructArray<byte> providerMetadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_providerMetadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_providerMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06004A05 RID: 18949 RVA: 0x0015423C File Offset: 0x0015243C
		// (set) Token: 0x06004A06 RID: 18950 RVA: 0x0001BA30 File Offset: 0x00019C30
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06004A07 RID: 18951 RVA: 0x00154264 File Offset: 0x00152464
		// (set) Token: 0x06004A08 RID: 18952 RVA: 0x0001BA4F File Offset: 0x00019C4F
		public unsafe int m_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_id)) = value;
			}
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x06004A09 RID: 18953 RVA: 0x0015428C File Offset: 0x0015248C
		// (set) Token: 0x06004A0A RID: 18954 RVA: 0x0001BA6A File Offset: 0x00019C6A
		public unsafe Guid m_guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_guid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_guid)) = value;
			}
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x06004A0B RID: 18955 RVA: 0x001542B4 File Offset: 0x001524B4
		// (set) Token: 0x06004A0C RID: 18956 RVA: 0x0001BA85 File Offset: 0x00019C85
		public unsafe Il2CppReferenceArray<EventSource.EventMetadata> m_eventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_eventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventSource.EventMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x06004A0D RID: 18957 RVA: 0x001542E4 File Offset: 0x001524E4
		// (set) Token: 0x06004A0E RID: 18958 RVA: 0x0001BAA4 File Offset: 0x00019CA4
		public unsafe Il2CppStructArray<byte> m_rawManifest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_rawManifest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_rawManifest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x06004A0F RID: 18959 RVA: 0x00154314 File Offset: 0x00152514
		// (set) Token: 0x06004A10 RID: 18960 RVA: 0x0001BAC3 File Offset: 0x00019CC3
		public unsafe EventHandler<EventCommandEventArgs> m_eventCommandExecuted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_eventCommandExecuted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<EventCommandEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_eventCommandExecuted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x06004A11 RID: 18961 RVA: 0x00154344 File Offset: 0x00152544
		// (set) Token: 0x06004A12 RID: 18962 RVA: 0x0001BAE2 File Offset: 0x00019CE2
		public unsafe EventSourceSettings m_config
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_config);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_config)) = value;
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06004A13 RID: 18963 RVA: 0x0015436C File Offset: 0x0015256C
		// (set) Token: 0x06004A14 RID: 18964 RVA: 0x0001BAFD File Offset: 0x00019CFD
		public unsafe bool m_eventSourceEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_eventSourceEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_eventSourceEnabled)) = value;
			}
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06004A15 RID: 18965 RVA: 0x00154394 File Offset: 0x00152594
		// (set) Token: 0x06004A16 RID: 18966 RVA: 0x0001BB18 File Offset: 0x00019D18
		public unsafe EventLevel m_level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_level)) = value;
			}
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06004A17 RID: 18967 RVA: 0x001543BC File Offset: 0x001525BC
		// (set) Token: 0x06004A18 RID: 18968 RVA: 0x0001BB33 File Offset: 0x00019D33
		public unsafe EventKeywords m_matchAnyKeyword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_matchAnyKeyword);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_matchAnyKeyword)) = value;
			}
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06004A19 RID: 18969 RVA: 0x001543E4 File Offset: 0x001525E4
		// (set) Token: 0x06004A1A RID: 18970 RVA: 0x0001BB4E File Offset: 0x00019D4E
		public unsafe EventDispatcher m_Dispatchers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_Dispatchers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_Dispatchers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06004A1B RID: 18971 RVA: 0x00154414 File Offset: 0x00152614
		// (set) Token: 0x06004A1C RID: 18972 RVA: 0x0001BB6D File Offset: 0x00019D6D
		public unsafe EventSource.OverideEventProvider m_provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSource.OverideEventProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06004A1D RID: 18973 RVA: 0x00154444 File Offset: 0x00152644
		// (set) Token: 0x06004A1E RID: 18974 RVA: 0x0001BB8C File Offset: 0x00019D8C
		public unsafe bool m_completelyInited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_completelyInited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_completelyInited)) = value;
			}
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x06004A1F RID: 18975 RVA: 0x0015446C File Offset: 0x0015266C
		// (set) Token: 0x06004A20 RID: 18976 RVA: 0x0001BBA7 File Offset: 0x00019DA7
		public unsafe Exception m_constructionException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_constructionException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_constructionException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x06004A21 RID: 18977 RVA: 0x0015449C File Offset: 0x0015269C
		// (set) Token: 0x06004A22 RID: 18978 RVA: 0x0001BBC6 File Offset: 0x00019DC6
		public unsafe byte m_outOfBandMessageCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_outOfBandMessageCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_outOfBandMessageCount)) = value;
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06004A23 RID: 18979 RVA: 0x001544C4 File Offset: 0x001526C4
		// (set) Token: 0x06004A24 RID: 18980 RVA: 0x0001BBE1 File Offset: 0x00019DE1
		public unsafe EventCommandEventArgs m_deferredCommands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_deferredCommands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCommandEventArgs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_deferredCommands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x06004A25 RID: 18981 RVA: 0x001544F4 File Offset: 0x001526F4
		// (set) Token: 0x06004A26 RID: 18982 RVA: 0x0001BC00 File Offset: 0x00019E00
		public unsafe Il2CppStringArray m_traits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_traits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_traits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x06004A27 RID: 18983 RVA: 0x00154524 File Offset: 0x00152724
		// (set) Token: 0x06004A28 RID: 18984 RVA: 0x0001BC1F File Offset: 0x00019E1F
		public unsafe static uint s_currentPid
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(EventSource.NativeFieldInfoPtr_s_currentPid, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSource.NativeFieldInfoPtr_s_currentPid, (void*)(&value));
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x06004A29 RID: 18985 RVA: 0x00154540 File Offset: 0x00152740
		// (set) Token: 0x06004A2A RID: 18986 RVA: 0x0001BC2D File Offset: 0x00019E2D
		public unsafe static byte m_EventSourceExceptionRecurenceCount
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(EventSource.NativeFieldInfoPtr_m_EventSourceExceptionRecurenceCount, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSource.NativeFieldInfoPtr_m_EventSourceExceptionRecurenceCount, (void*)(&value));
			}
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06004A2B RID: 18987 RVA: 0x0015455C File Offset: 0x0015275C
		// (set) Token: 0x06004A2C RID: 18988 RVA: 0x0001BC3B File Offset: 0x00019E3B
		public unsafe SessionMask m_curLiveSessions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_curLiveSessions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_curLiveSessions)) = value;
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06004A2D RID: 18989 RVA: 0x00154584 File Offset: 0x00152784
		// (set) Token: 0x06004A2E RID: 18990 RVA: 0x0001BC56 File Offset: 0x00019E56
		public unsafe Il2CppReferenceArray<EtwSession> m_etwSessionIdMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_etwSessionIdMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EtwSession>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_etwSessionIdMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06004A2F RID: 18991 RVA: 0x001545B4 File Offset: 0x001527B4
		// (set) Token: 0x06004A30 RID: 18992 RVA: 0x0001BC75 File Offset: 0x00019E75
		public unsafe List<EtwSession> m_legacySessions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_legacySessions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EtwSession>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_legacySessions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x06004A31 RID: 18993 RVA: 0x001545E4 File Offset: 0x001527E4
		// (set) Token: 0x06004A32 RID: 18994 RVA: 0x0001BC94 File Offset: 0x00019E94
		public unsafe long m_keywordTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_keywordTriggers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_keywordTriggers)) = value;
			}
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x06004A33 RID: 18995 RVA: 0x0015460C File Offset: 0x0015280C
		// (set) Token: 0x06004A34 RID: 18996 RVA: 0x0001BCAF File Offset: 0x00019EAF
		public unsafe SessionMask m_activityFilteringForETWEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_activityFilteringForETWEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_activityFilteringForETWEnabled)) = value;
			}
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x06004A35 RID: 18997 RVA: 0x00154634 File Offset: 0x00152834
		// (set) Token: 0x06004A36 RID: 18998 RVA: 0x0001BCCA File Offset: 0x00019ECA
		public unsafe static Action<Guid> s_activityDying
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventSource.NativeFieldInfoPtr_s_activityDying, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Guid>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSource.NativeFieldInfoPtr_s_activityDying, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x06004A37 RID: 18999 RVA: 0x0015465C File Offset: 0x0015285C
		// (set) Token: 0x06004A38 RID: 19000 RVA: 0x0001BCDC File Offset: 0x00019EDC
		public unsafe ActivityTracker m_activityTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_activityTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_activityTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x06004A39 RID: 19001 RVA: 0x0015468C File Offset: 0x0015288C
		// (set) Token: 0x06004A3A RID: 19002 RVA: 0x0001BCFB File Offset: 0x00019EFB
		public unsafe static Il2CppStructArray<byte> namespaceBytes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventSource.NativeFieldInfoPtr_namespaceBytes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSource.NativeFieldInfoPtr_namespaceBytes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x06004A3B RID: 19003 RVA: 0x001546B4 File Offset: 0x001528B4
		// (set) Token: 0x06004A3C RID: 19004 RVA: 0x0001BD0D File Offset: 0x00019F0D
		public unsafe static Guid AspNetEventSourceGuid
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(EventSource.NativeFieldInfoPtr_AspNetEventSourceGuid, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSource.NativeFieldInfoPtr_AspNetEventSourceGuid, (void*)(&value));
			}
		}

		// Token: 0x04003B8E RID: 15246
		private static readonly IntPtr NativeFieldInfoPtr_providerMetadata;

		// Token: 0x04003B8F RID: 15247
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x04003B90 RID: 15248
		private static readonly IntPtr NativeFieldInfoPtr_m_id;

		// Token: 0x04003B91 RID: 15249
		private static readonly IntPtr NativeFieldInfoPtr_m_guid;

		// Token: 0x04003B92 RID: 15250
		private static readonly IntPtr NativeFieldInfoPtr_m_eventData;

		// Token: 0x04003B93 RID: 15251
		private static readonly IntPtr NativeFieldInfoPtr_m_rawManifest;

		// Token: 0x04003B94 RID: 15252
		private static readonly IntPtr NativeFieldInfoPtr_m_eventCommandExecuted;

		// Token: 0x04003B95 RID: 15253
		private static readonly IntPtr NativeFieldInfoPtr_m_config;

		// Token: 0x04003B96 RID: 15254
		private static readonly IntPtr NativeFieldInfoPtr_m_eventSourceEnabled;

		// Token: 0x04003B97 RID: 15255
		private static readonly IntPtr NativeFieldInfoPtr_m_level;

		// Token: 0x04003B98 RID: 15256
		private static readonly IntPtr NativeFieldInfoPtr_m_matchAnyKeyword;

		// Token: 0x04003B99 RID: 15257
		private static readonly IntPtr NativeFieldInfoPtr_m_Dispatchers;

		// Token: 0x04003B9A RID: 15258
		private static readonly IntPtr NativeFieldInfoPtr_m_provider;

		// Token: 0x04003B9B RID: 15259
		private static readonly IntPtr NativeFieldInfoPtr_m_completelyInited;

		// Token: 0x04003B9C RID: 15260
		private static readonly IntPtr NativeFieldInfoPtr_m_constructionException;

		// Token: 0x04003B9D RID: 15261
		private static readonly IntPtr NativeFieldInfoPtr_m_outOfBandMessageCount;

		// Token: 0x04003B9E RID: 15262
		private static readonly IntPtr NativeFieldInfoPtr_m_deferredCommands;

		// Token: 0x04003B9F RID: 15263
		private static readonly IntPtr NativeFieldInfoPtr_m_traits;

		// Token: 0x04003BA0 RID: 15264
		private static readonly IntPtr NativeFieldInfoPtr_s_currentPid;

		// Token: 0x04003BA1 RID: 15265
		private static readonly IntPtr NativeFieldInfoPtr_m_EventSourceExceptionRecurenceCount;

		// Token: 0x04003BA2 RID: 15266
		private static readonly IntPtr NativeFieldInfoPtr_m_curLiveSessions;

		// Token: 0x04003BA3 RID: 15267
		private static readonly IntPtr NativeFieldInfoPtr_m_etwSessionIdMap;

		// Token: 0x04003BA4 RID: 15268
		private static readonly IntPtr NativeFieldInfoPtr_m_legacySessions;

		// Token: 0x04003BA5 RID: 15269
		private static readonly IntPtr NativeFieldInfoPtr_m_keywordTriggers;

		// Token: 0x04003BA6 RID: 15270
		private static readonly IntPtr NativeFieldInfoPtr_m_activityFilteringForETWEnabled;

		// Token: 0x04003BA7 RID: 15271
		private static readonly IntPtr NativeFieldInfoPtr_s_activityDying;

		// Token: 0x04003BA8 RID: 15272
		private static readonly IntPtr NativeFieldInfoPtr_m_activityTracker;

		// Token: 0x04003BA9 RID: 15273
		private static readonly IntPtr NativeFieldInfoPtr_namespaceBytes;

		// Token: 0x04003BAA RID: 15274
		private static readonly IntPtr NativeFieldInfoPtr_AspNetEventSourceGuid;

		// Token: 0x04003BAB RID: 15275
		private static readonly IntPtr NativeMethodInfoPtr_WriteMultiMerge_Private_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003BAC RID: 15276
		private static readonly IntPtr NativeMethodInfoPtr_WriteMultiMergeInner_Private_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003BAD RID: 15277
		private static readonly IntPtr NativeMethodInfoPtr_WriteMultiMerge_Internal_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_ptr_EventData_0;

		// Token: 0x04003BAE RID: 15278
		private static readonly IntPtr NativeMethodInfoPtr_WriteCleanup_Private_Void_ptr_GCHandle_Int32_0;

		// Token: 0x04003BAF RID: 15279
		private static readonly IntPtr NativeMethodInfoPtr_InitializeProviderMetadata_Private_Void_0;

		// Token: 0x04003BB0 RID: 15280
		private static readonly IntPtr NativeMethodInfoPtr_AddValueToMetaData_Private_Static_Int32_List_1_Byte_String_0;

		// Token: 0x04003BB1 RID: 15281
		private static readonly IntPtr NativeMethodInfoPtr_HexDigit_Private_Static_Int32_Char_0;

		// Token: 0x04003BB2 RID: 15282
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDescriptor_Private_NameInfo_String_TraceLoggingEventTypes_byref_EventSourceOptions_byref_EventDescriptor_0;

		// Token: 0x04003BB3 RID: 15283
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04003BB4 RID: 15284
		private static readonly IntPtr NativeMethodInfoPtr_get_Guid_Public_get_Guid_0;

		// Token: 0x04003BB5 RID: 15285
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_0;

		// Token: 0x04003BB6 RID: 15286
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_EventLevel_EventKeywords_0;

		// Token: 0x04003BB7 RID: 15287
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_EventLevel_EventKeywords_EventChannel_0;

		// Token: 0x04003BB8 RID: 15288
		private static readonly IntPtr NativeMethodInfoPtr_GetGuid_Public_Static_Guid_Type_0;

		// Token: 0x04003BB9 RID: 15289
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_Type_0;

		// Token: 0x04003BBA RID: 15290
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentThreadActivityId_Public_Static_Void_Guid_0;

		// Token: 0x04003BBB RID: 15291
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentThreadActivityId_Public_Static_get_Guid_0;

		// Token: 0x04003BBC RID: 15292
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalCurrentThreadActivityId_Internal_Static_get_Guid_0;

		// Token: 0x04003BBD RID: 15293
		private static readonly IntPtr NativeMethodInfoPtr_get_FallbackActivityId_Internal_Static_get_Guid_0;

		// Token: 0x04003BBE RID: 15294
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003BBF RID: 15295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003BC0 RID: 15296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_EventSourceSettings_0;

		// Token: 0x04003BC1 RID: 15297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_EventSourceSettings_Il2CppStringArray_0;

		// Token: 0x04003BC2 RID: 15298
		private static readonly IntPtr NativeMethodInfoPtr_OnEventCommand_Protected_Virtual_New_Void_EventCommandEventArgs_0;

		// Token: 0x04003BC3 RID: 15299
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int32_0;

		// Token: 0x04003BC4 RID: 15300
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_String_0;

		// Token: 0x04003BC5 RID: 15301
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_String_String_0;

		// Token: 0x04003BC6 RID: 15302
		private static readonly IntPtr NativeMethodInfoPtr_WriteEventCore_Protected_Void_Int32_Int32_ptr_EventData_0;

		// Token: 0x04003BC7 RID: 15303
		private static readonly IntPtr NativeMethodInfoPtr_WriteEventWithRelatedActivityIdCore_Protected_Void_Int32_ptr_Guid_Int32_ptr_EventData_0;

		// Token: 0x04003BC8 RID: 15304
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003BC9 RID: 15305
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003BCA RID: 15306
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04003BCB RID: 15307
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04003BCC RID: 15308
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringToListener_Internal_Void_EventListener_String_SessionMask_0;

		// Token: 0x04003BCD RID: 15309
		private static readonly IntPtr NativeMethodInfoPtr_WriteEventRaw_Private_Void_String_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0;

		// Token: 0x04003BCE RID: 15310
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_Guid_String_Il2CppStringArray_0;

		// Token: 0x04003BCF RID: 15311
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Private_Static_String_Type_EventManifestOptions_0;

		// Token: 0x04003BD0 RID: 15312
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGuidFromName_Private_Static_Guid_String_0;

		// Token: 0x04003BD1 RID: 15313
		private static readonly IntPtr NativeMethodInfoPtr_DecodeObject_Private_Object_Int32_Int32_byref_ptr_EventData_0;

		// Token: 0x04003BD2 RID: 15314
		private static readonly IntPtr NativeMethodInfoPtr_GetDispatcher_Private_EventDispatcher_EventListener_0;

		// Token: 0x04003BD3 RID: 15315
		private static readonly IntPtr NativeMethodInfoPtr_WriteEventVarargs_Private_Void_Int32_ptr_Guid_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003BD4 RID: 15316
		private static readonly IntPtr NativeMethodInfoPtr_SerializeEventArgs_Private_Il2CppReferenceArray_1_Object_Int32_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003BD5 RID: 15317
		private static readonly IntPtr NativeMethodInfoPtr_LogEventArgsMismatches_Private_Void_Il2CppReferenceArray_1_ParameterInfo_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003BD6 RID: 15318
		private static readonly IntPtr NativeMethodInfoPtr_GetParamLengthIncludingByteArray_Private_Int32_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04003BD7 RID: 15319
		private static readonly IntPtr NativeMethodInfoPtr_WriteToAllListeners_Private_Void_Int32_ptr_Guid_Int32_ptr_EventData_0;

		// Token: 0x04003BD8 RID: 15320
		private static readonly IntPtr NativeMethodInfoPtr_WriteToAllListeners_Private_Void_Int32_ptr_Guid_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003BD9 RID: 15321
		private static readonly IntPtr NativeMethodInfoPtr_DispatchToAllListeners_Private_Void_Int32_ptr_Guid_EventWrittenEventArgs_0;

		// Token: 0x04003BDA RID: 15322
		private static readonly IntPtr NativeMethodInfoPtr_WriteEventString_Private_Void_EventLevel_Int64_String_0;

		// Token: 0x04003BDB RID: 15323
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringToAllListeners_Private_Void_String_String_0;

		// Token: 0x04003BDC RID: 15324
		private static readonly IntPtr NativeMethodInfoPtr_GetEtwSessionMask_Private_SessionMask_Int32_ptr_Guid_0;

		// Token: 0x04003BDD RID: 15325
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledByDefault_Private_Boolean_Int32_Boolean_EventLevel_EventKeywords_0;

		// Token: 0x04003BDE RID: 15326
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledCommon_Private_Boolean_Boolean_EventLevel_EventKeywords_EventLevel_EventKeywords_EventChannel_0;

		// Token: 0x04003BDF RID: 15327
		private static readonly IntPtr NativeMethodInfoPtr_ThrowEventSourceException_Private_Void_String_Exception_0;

		// Token: 0x04003BE0 RID: 15328
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEventOpcodeForTransfer_Private_Void_byref_EventMetadata_String_0;

		// Token: 0x04003BE1 RID: 15329
		private static readonly IntPtr NativeMethodInfoPtr_GetOpcodeWithDefault_Internal_Static_EventOpcode_EventOpcode_String_0;

		// Token: 0x04003BE2 RID: 15330
		private static readonly IntPtr NativeMethodInfoPtr_SendCommand_Internal_Void_EventListener_Int32_Int32_EventCommand_Boolean_EventLevel_EventKeywords_IDictionary_2_String_String_0;

		// Token: 0x04003BE3 RID: 15331
		private static readonly IntPtr NativeMethodInfoPtr_DoCommand_Internal_Void_EventCommandEventArgs_0;

		// Token: 0x04003BE4 RID: 15332
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEtwSession_Internal_Void_Int32_Int32_Boolean_String_Boolean_0;

		// Token: 0x04003BE5 RID: 15333
		private static readonly IntPtr NativeMethodInfoPtr_ParseCommandArgs_Internal_Static_Boolean_IDictionary_2_String_String_byref_Boolean_byref_String_byref_Int32_0;

		// Token: 0x04003BE6 RID: 15334
		private static readonly IntPtr NativeMethodInfoPtr_UpdateKwdTriggers_Internal_Void_Boolean_0;

		// Token: 0x04003BE7 RID: 15335
		private static readonly IntPtr NativeMethodInfoPtr_EnableEventForDispatcher_Internal_Boolean_EventDispatcher_Int32_Boolean_0;

		// Token: 0x04003BE8 RID: 15336
		private static readonly IntPtr NativeMethodInfoPtr_AnyEventEnabled_Private_Boolean_0;

		// Token: 0x04003BE9 RID: 15337
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDisposed_Private_get_Boolean_0;

		// Token: 0x04003BEA RID: 15338
		private static readonly IntPtr NativeMethodInfoPtr_EnsureDescriptorsInitialized_Private_Void_0;

		// Token: 0x04003BEB RID: 15339
		private static readonly IntPtr NativeMethodInfoPtr_SendManifest_Private_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003BEC RID: 15340
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributeHelper_Internal_Static_Attribute_MemberInfo_Type_EventManifestOptions_0;

		// Token: 0x04003BED RID: 15341
		private static readonly IntPtr NativeMethodInfoPtr_AttributeTypeNamesMatch_Private_Static_Boolean_Type_Type_0;

		// Token: 0x04003BEE RID: 15342
		private static readonly IntPtr NativeMethodInfoPtr_GetEventSourceBaseType_Private_Static_Type_Type_Boolean_Boolean_0;

		// Token: 0x04003BEF RID: 15343
		private static readonly IntPtr NativeMethodInfoPtr_CreateManifestAndDescriptors_Private_Static_Il2CppStructArray_1_Byte_Type_String_EventSource_EventManifestOptions_0;

		// Token: 0x04003BF0 RID: 15344
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFirstArgIfRelatedActivityId_Private_Static_Boolean_byref_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04003BF1 RID: 15345
		private static readonly IntPtr NativeMethodInfoPtr_AddProviderEnumKind_Private_Static_Void_ManifestBuilder_FieldInfo_String_0;

		// Token: 0x04003BF2 RID: 15346
		private static readonly IntPtr NativeMethodInfoPtr_AddEventDescriptor_Private_Static_Void_byref_Il2CppReferenceArray_1_EventMetadata_String_EventAttribute_Il2CppReferenceArray_1_ParameterInfo_Boolean_0;

		// Token: 0x04003BF3 RID: 15347
		private static readonly IntPtr NativeMethodInfoPtr_TrimEventDescriptors_Private_Static_Void_byref_Il2CppReferenceArray_1_EventMetadata_0;

		// Token: 0x04003BF4 RID: 15348
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Internal_Void_EventListener_0;

		// Token: 0x04003BF5 RID: 15349
		private static readonly IntPtr NativeMethodInfoPtr_DebugCheckEvent_Private_Static_Void_byref_Dictionary_2_String_String_Il2CppReferenceArray_1_EventMetadata_MethodInfo_EventAttribute_ManifestBuilder_EventManifestOptions_0;

		// Token: 0x04003BF6 RID: 15350
		private static readonly IntPtr NativeMethodInfoPtr_GetHelperCallFirstArg_Private_Static_Int32_MethodInfo_0;

		// Token: 0x04003BF7 RID: 15351
		private static readonly IntPtr NativeMethodInfoPtr_ReportOutOfBandMessage_Internal_Void_String_Boolean_0;

		// Token: 0x04003BF8 RID: 15352
		private static readonly IntPtr NativeMethodInfoPtr_ValidateSettings_Private_EventSourceSettings_EventSourceSettings_0;

		// Token: 0x04003BF9 RID: 15353
		private static readonly IntPtr NativeMethodInfoPtr_get_ThrowOnEventWriteErrors_Private_get_Boolean_0;

		// Token: 0x04003BFA RID: 15354
		private static readonly IntPtr NativeMethodInfoPtr_get_SelfDescribingEvents_Private_get_Boolean_0;

		// Token: 0x04003BFB RID: 15355
		private static readonly IntPtr NativeMethodInfoPtr_ReportActivitySamplingInfo_Private_Void_EventListener_SessionMask_0;

		// Token: 0x02000675 RID: 1653
		[StructLayout(2)]
		public struct EventData
		{
			// Token: 0x060056A0 RID: 22176 RVA: 0x0017E170 File Offset: 0x0017C370
			// Note: this type is marked as 'beforefieldinit'.
			static EventData()
			{
				Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "EventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr);
				EventSource.EventData.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, "m_Ptr");
				EventSource.EventData.NativeFieldInfoPtr_m_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, "m_Size");
				EventSource.EventData.NativeFieldInfoPtr_m_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, "m_Reserved");
				EventSource.EventData.NativeMethodInfoPtr_get_DataPointer_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, 100674289);
				EventSource.EventData.NativeMethodInfoPtr_set_DataPointer_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, 100674290);
				EventSource.EventData.NativeMethodInfoPtr_set_Size_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, 100674291);
				EventSource.EventData.NativeMethodInfoPtr_SetMetadata_Internal_Void_ptr_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, 100674292);
			}

			// Token: 0x17001646 RID: 5702
			// (get) Token: 0x060056A1 RID: 22177 RVA: 0x0017E228 File Offset: 0x0017C428
			// (set) Token: 0x060056A2 RID: 22178 RVA: 0x0017E258 File Offset: 0x0017C458
			public unsafe IntPtr DataPointer
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 370076, RefRangeEnd = 370078, XrefRangeStart = 370075, XrefRangeEnd = 370076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.EventData.NativeMethodInfoPtr_get_DataPointer_Public_get_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 370079, RefRangeEnd = 370085, XrefRangeStart = 370078, XrefRangeEnd = 370079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.EventData.NativeMethodInfoPtr_set_DataPointer_Public_set_Void_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001647 RID: 5703
			// (set) Token: 0x060056A3 RID: 22179 RVA: 0x0017E28C File Offset: 0x0017C48C
			public unsafe int Size
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.EventData.NativeMethodInfoPtr_set_Size_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060056A4 RID: 22180 RVA: 0x0017E2C0 File Offset: 0x0017C4C0
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 370090, RefRangeEnd = 370096, XrefRangeStart = 370085, XrefRangeEnd = 370090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetMetadata(byte* pointer, int size, int reserved)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = pointer;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reserved;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.EventData.NativeMethodInfoPtr_SetMetadata_Internal_Void_ptr_Byte_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056A5 RID: 22181 RVA: 0x00021745 File Offset: 0x0001F945
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, ref this));
			}

			// Token: 0x04004569 RID: 17769
			private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

			// Token: 0x0400456A RID: 17770
			private static readonly IntPtr NativeFieldInfoPtr_m_Size;

			// Token: 0x0400456B RID: 17771
			private static readonly IntPtr NativeFieldInfoPtr_m_Reserved;

			// Token: 0x0400456C RID: 17772
			private static readonly IntPtr NativeMethodInfoPtr_get_DataPointer_Public_get_IntPtr_0;

			// Token: 0x0400456D RID: 17773
			private static readonly IntPtr NativeMethodInfoPtr_set_DataPointer_Public_set_Void_IntPtr_0;

			// Token: 0x0400456E RID: 17774
			private static readonly IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_Int32_0;

			// Token: 0x0400456F RID: 17775
			private static readonly IntPtr NativeMethodInfoPtr_SetMetadata_Internal_Void_ptr_Byte_Int32_Int32_0;

			// Token: 0x04004570 RID: 17776
			[FieldOffset(0)]
			public long m_Ptr;

			// Token: 0x04004571 RID: 17777
			[FieldOffset(8)]
			public int m_Size;

			// Token: 0x04004572 RID: 17778
			[FieldOffset(12)]
			public int m_Reserved;
		}

		// Token: 0x02000676 RID: 1654
		public sealed class Sha1ForNonSecretPurposes : ValueType
		{
			// Token: 0x060056A6 RID: 22182 RVA: 0x0017E310 File Offset: 0x0017C510
			// Note: this type is marked as 'beforefieldinit'.
			static Sha1ForNonSecretPurposes()
			{
				Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "Sha1ForNonSecretPurposes");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr);
				EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, "length");
				EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, "w");
				EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, "pos");
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674293);
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Append_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674294);
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Append_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674295);
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Finish_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674296);
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Drain_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674297);
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Rol1_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674298);
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Rol5_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674299);
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Rol30_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674300);
			}

			// Token: 0x060056A7 RID: 22183 RVA: 0x0017E418 File Offset: 0x0017C618
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 370099, RefRangeEnd = 370100, XrefRangeStart = 370096, XrefRangeEnd = 370099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Start()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056A8 RID: 22184 RVA: 0x0017E450 File Offset: 0x0017C650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370100, XrefRangeEnd = 370101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Append(byte input)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref input;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Append_Public_Void_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056A9 RID: 22185 RVA: 0x0017E494 File Offset: 0x0017C694
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 370103, RefRangeEnd = 370105, XrefRangeStart = 370101, XrefRangeEnd = 370103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Append(Il2CppStructArray<byte> input)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Append_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056AA RID: 22186 RVA: 0x0017E4DC File Offset: 0x0017C6DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 370115, RefRangeEnd = 370116, XrefRangeStart = 370105, XrefRangeEnd = 370115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Finish(Il2CppStructArray<byte> output)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Finish_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056AB RID: 22187 RVA: 0x0017E524 File Offset: 0x0017C724
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 370116, RefRangeEnd = 370128, XrefRangeStart = 370116, XrefRangeEnd = 370116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Drain()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Drain_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056AC RID: 22188 RVA: 0x0017E55C File Offset: 0x0017C75C
			[CallerCount(0)]
			public unsafe static uint Rol1(uint input)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref input;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Rol1_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060056AD RID: 22189 RVA: 0x0017E59C File Offset: 0x0017C79C
			[CallerCount(0)]
			public unsafe static uint Rol5(uint input)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref input;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Rol5_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060056AE RID: 22190 RVA: 0x0017E5DC File Offset: 0x0017C7DC
			[CallerCount(0)]
			public unsafe static uint Rol30(uint input)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref input;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Rol30_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060056AF RID: 22191 RVA: 0x00021757 File Offset: 0x0001F957
			public Sha1ForNonSecretPurposes(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060056B0 RID: 22192 RVA: 0x00021760 File Offset: 0x0001F960
			public Sha1ForNonSecretPurposes()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr))
			{
			}

			// Token: 0x17001648 RID: 5704
			// (get) Token: 0x060056B1 RID: 22193 RVA: 0x0017E61C File Offset: 0x0017C81C
			// (set) Token: 0x060056B2 RID: 22194 RVA: 0x00021772 File Offset: 0x0001F972
			public unsafe long length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_length)) = value;
				}
			}

			// Token: 0x17001649 RID: 5705
			// (get) Token: 0x060056B3 RID: 22195 RVA: 0x0017E644 File Offset: 0x0017C844
			// (set) Token: 0x060056B4 RID: 22196 RVA: 0x0002178D File Offset: 0x0001F98D
			public unsafe Il2CppStructArray<uint> w
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_w);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_w), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700164A RID: 5706
			// (get) Token: 0x060056B5 RID: 22197 RVA: 0x0017E674 File Offset: 0x0017C874
			// (set) Token: 0x060056B6 RID: 22198 RVA: 0x000217AC File Offset: 0x0001F9AC
			public unsafe int pos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_pos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_pos)) = value;
				}
			}

			// Token: 0x04004573 RID: 17779
			private static readonly IntPtr NativeFieldInfoPtr_length;

			// Token: 0x04004574 RID: 17780
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x04004575 RID: 17781
			private static readonly IntPtr NativeFieldInfoPtr_pos;

			// Token: 0x04004576 RID: 17782
			private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

			// Token: 0x04004577 RID: 17783
			private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_Byte_0;

			// Token: 0x04004578 RID: 17784
			private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004579 RID: 17785
			private static readonly IntPtr NativeMethodInfoPtr_Finish_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400457A RID: 17786
			private static readonly IntPtr NativeMethodInfoPtr_Drain_Private_Void_0;

			// Token: 0x0400457B RID: 17787
			private static readonly IntPtr NativeMethodInfoPtr_Rol1_Private_Static_UInt32_UInt32_0;

			// Token: 0x0400457C RID: 17788
			private static readonly IntPtr NativeMethodInfoPtr_Rol5_Private_Static_UInt32_UInt32_0;

			// Token: 0x0400457D RID: 17789
			private static readonly IntPtr NativeMethodInfoPtr_Rol30_Private_Static_UInt32_UInt32_0;
		}

		// Token: 0x02000677 RID: 1655
		public class OverideEventProvider : EventProvider
		{
			// Token: 0x060056B7 RID: 22199 RVA: 0x0017E69C File Offset: 0x0017C89C
			// Note: this type is marked as 'beforefieldinit'.
			static OverideEventProvider()
			{
				Il2CppClassPointerStore<EventSource.OverideEventProvider>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "OverideEventProvider");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSource.OverideEventProvider>.NativeClassPtr);
				EventSource.OverideEventProvider.NativeFieldInfoPtr_m_eventSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.OverideEventProvider>.NativeClassPtr, "m_eventSource");
				EventSource.OverideEventProvider.NativeMethodInfoPtr__ctor_Public_Void_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.OverideEventProvider>.NativeClassPtr, 100674301);
				EventSource.OverideEventProvider.NativeMethodInfoPtr_OnControllerCommand_Protected_Virtual_Void_ControllerCommand_IDictionary_2_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.OverideEventProvider>.NativeClassPtr, 100674302);
			}

			// Token: 0x060056B8 RID: 22200 RVA: 0x0017E704 File Offset: 0x0017C904
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 370132, RefRangeEnd = 370133, XrefRangeStart = 370128, XrefRangeEnd = 370132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OverideEventProvider(EventSource eventSource)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource.OverideEventProvider>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSource);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.OverideEventProvider.NativeMethodInfoPtr__ctor_Public_Void_EventSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056B9 RID: 22201 RVA: 0x0017E750 File Offset: 0x0017C950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370133, XrefRangeEnd = 370134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int perEventSourceSessionId, int etwSessionId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref command;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref perEventSourceSessionId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwSessionId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSource.OverideEventProvider.NativeMethodInfoPtr_OnControllerCommand_Protected_Virtual_Void_ControllerCommand_IDictionary_2_String_String_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056BA RID: 22202 RVA: 0x000217C7 File Offset: 0x0001F9C7
			public OverideEventProvider(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700164B RID: 5707
			// (get) Token: 0x060056BB RID: 22203 RVA: 0x0017E7C8 File Offset: 0x0017C9C8
			// (set) Token: 0x060056BC RID: 22204 RVA: 0x000217D0 File Offset: 0x0001F9D0
			public unsafe EventSource m_eventSource
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.OverideEventProvider.NativeFieldInfoPtr_m_eventSource);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.OverideEventProvider.NativeFieldInfoPtr_m_eventSource), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400457E RID: 17790
			private static readonly IntPtr NativeFieldInfoPtr_m_eventSource;

			// Token: 0x0400457F RID: 17791
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSource_0;

			// Token: 0x04004580 RID: 17792
			private static readonly IntPtr NativeMethodInfoPtr_OnControllerCommand_Protected_Virtual_Void_ControllerCommand_IDictionary_2_String_String_Int32_Int32_0;
		}

		// Token: 0x02000678 RID: 1656
		public sealed class EventMetadata : ValueType
		{
			// Token: 0x060056BD RID: 22205 RVA: 0x0017E7F8 File Offset: 0x0017C9F8
			// Note: this type is marked as 'beforefieldinit'.
			static EventMetadata()
			{
				Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "EventMetadata");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr);
				EventSource.EventMetadata.NativeFieldInfoPtr_Descriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "Descriptor");
				EventSource.EventMetadata.NativeFieldInfoPtr_Tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "Tags");
				EventSource.EventMetadata.NativeFieldInfoPtr_EnabledForAnyListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "EnabledForAnyListener");
				EventSource.EventMetadata.NativeFieldInfoPtr_EnabledForETW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "EnabledForETW");
				EventSource.EventMetadata.NativeFieldInfoPtr_HasRelatedActivityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "HasRelatedActivityID");
				EventSource.EventMetadata.NativeFieldInfoPtr_TriggersActivityTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "TriggersActivityTracking");
				EventSource.EventMetadata.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "Name");
				EventSource.EventMetadata.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "Message");
				EventSource.EventMetadata.NativeFieldInfoPtr_Parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "Parameters");
				EventSource.EventMetadata.NativeFieldInfoPtr_TraceLoggingEventTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "TraceLoggingEventTypes");
				EventSource.EventMetadata.NativeFieldInfoPtr_ActivityOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "ActivityOptions");
			}

			// Token: 0x060056BE RID: 22206 RVA: 0x000217EF File Offset: 0x0001F9EF
			public EventMetadata(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060056BF RID: 22207 RVA: 0x000217F8 File Offset: 0x0001F9F8
			public EventMetadata()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr))
			{
			}

			// Token: 0x1700164C RID: 5708
			// (get) Token: 0x060056C0 RID: 22208 RVA: 0x0017E900 File Offset: 0x0017CB00
			// (set) Token: 0x060056C1 RID: 22209 RVA: 0x0002180A File Offset: 0x0001FA0A
			public unsafe EventDescriptor Descriptor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Descriptor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Descriptor)) = value;
				}
			}

			// Token: 0x1700164D RID: 5709
			// (get) Token: 0x060056C2 RID: 22210 RVA: 0x0017E928 File Offset: 0x0017CB28
			// (set) Token: 0x060056C3 RID: 22211 RVA: 0x00021825 File Offset: 0x0001FA25
			public unsafe EventTags Tags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Tags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Tags)) = value;
				}
			}

			// Token: 0x1700164E RID: 5710
			// (get) Token: 0x060056C4 RID: 22212 RVA: 0x0017E950 File Offset: 0x0017CB50
			// (set) Token: 0x060056C5 RID: 22213 RVA: 0x00021840 File Offset: 0x0001FA40
			public unsafe bool EnabledForAnyListener
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_EnabledForAnyListener);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_EnabledForAnyListener)) = value;
				}
			}

			// Token: 0x1700164F RID: 5711
			// (get) Token: 0x060056C6 RID: 22214 RVA: 0x0017E978 File Offset: 0x0017CB78
			// (set) Token: 0x060056C7 RID: 22215 RVA: 0x0002185B File Offset: 0x0001FA5B
			public unsafe bool EnabledForETW
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_EnabledForETW);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_EnabledForETW)) = value;
				}
			}

			// Token: 0x17001650 RID: 5712
			// (get) Token: 0x060056C8 RID: 22216 RVA: 0x0017E9A0 File Offset: 0x0017CBA0
			// (set) Token: 0x060056C9 RID: 22217 RVA: 0x00021876 File Offset: 0x0001FA76
			public unsafe bool HasRelatedActivityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_HasRelatedActivityID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_HasRelatedActivityID)) = value;
				}
			}

			// Token: 0x17001651 RID: 5713
			// (get) Token: 0x060056CA RID: 22218 RVA: 0x0017E9C8 File Offset: 0x0017CBC8
			// (set) Token: 0x060056CB RID: 22219 RVA: 0x00021891 File Offset: 0x0001FA91
			public unsafe byte TriggersActivityTracking
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_TriggersActivityTracking);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_TriggersActivityTracking)) = value;
				}
			}

			// Token: 0x17001652 RID: 5714
			// (get) Token: 0x060056CC RID: 22220 RVA: 0x0017E9F0 File Offset: 0x0017CBF0
			// (set) Token: 0x060056CD RID: 22221 RVA: 0x000218AC File Offset: 0x0001FAAC
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001653 RID: 5715
			// (get) Token: 0x060056CE RID: 22222 RVA: 0x0017EA18 File Offset: 0x0017CC18
			// (set) Token: 0x060056CF RID: 22223 RVA: 0x000218CB File Offset: 0x0001FACB
			public unsafe string Message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001654 RID: 5716
			// (get) Token: 0x060056D0 RID: 22224 RVA: 0x0017EA40 File Offset: 0x0017CC40
			// (set) Token: 0x060056D1 RID: 22225 RVA: 0x000218EA File Offset: 0x0001FAEA
			public unsafe Il2CppReferenceArray<ParameterInfo> Parameters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Parameters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Parameters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001655 RID: 5717
			// (get) Token: 0x060056D2 RID: 22226 RVA: 0x0017EA70 File Offset: 0x0017CC70
			// (set) Token: 0x060056D3 RID: 22227 RVA: 0x00021909 File Offset: 0x0001FB09
			public unsafe TraceLoggingEventTypes TraceLoggingEventTypes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_TraceLoggingEventTypes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingEventTypes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_TraceLoggingEventTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001656 RID: 5718
			// (get) Token: 0x060056D4 RID: 22228 RVA: 0x0017EAA0 File Offset: 0x0017CCA0
			// (set) Token: 0x060056D5 RID: 22229 RVA: 0x00021928 File Offset: 0x0001FB28
			public unsafe EventActivityOptions ActivityOptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_ActivityOptions);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_ActivityOptions)) = value;
				}
			}

			// Token: 0x04004581 RID: 17793
			private static readonly IntPtr NativeFieldInfoPtr_Descriptor;

			// Token: 0x04004582 RID: 17794
			private static readonly IntPtr NativeFieldInfoPtr_Tags;

			// Token: 0x04004583 RID: 17795
			private static readonly IntPtr NativeFieldInfoPtr_EnabledForAnyListener;

			// Token: 0x04004584 RID: 17796
			private static readonly IntPtr NativeFieldInfoPtr_EnabledForETW;

			// Token: 0x04004585 RID: 17797
			private static readonly IntPtr NativeFieldInfoPtr_HasRelatedActivityID;

			// Token: 0x04004586 RID: 17798
			private static readonly IntPtr NativeFieldInfoPtr_TriggersActivityTracking;

			// Token: 0x04004587 RID: 17799
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04004588 RID: 17800
			private static readonly IntPtr NativeFieldInfoPtr_Message;

			// Token: 0x04004589 RID: 17801
			private static readonly IntPtr NativeFieldInfoPtr_Parameters;

			// Token: 0x0400458A RID: 17802
			private static readonly IntPtr NativeFieldInfoPtr_TraceLoggingEventTypes;

			// Token: 0x0400458B RID: 17803
			private static readonly IntPtr NativeFieldInfoPtr_ActivityOptions;
		}
	}
}
