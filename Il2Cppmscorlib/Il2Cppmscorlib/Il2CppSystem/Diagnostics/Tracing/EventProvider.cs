using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000512 RID: 1298
	public class EventProvider : Object
	{
		// Token: 0x06004AD4 RID: 19156 RVA: 0x00156A9C File Offset: 0x00154C9C
		// Note: this type is marked as 'beforefieldinit'.
		static EventProvider()
		{
			Il2CppClassPointerStore<EventProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventProvider>.NativeClassPtr);
			EventProvider.NativeFieldInfoPtr_m_setInformationMissing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_setInformationMissing");
			EventProvider.NativeFieldInfoPtr_m_etwCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_etwCallback");
			EventProvider.NativeFieldInfoPtr_m_thisGCHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_thisGCHandle");
			EventProvider.NativeFieldInfoPtr_m_regHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_regHandle");
			EventProvider.NativeFieldInfoPtr_m_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_level");
			EventProvider.NativeFieldInfoPtr_m_anyKeywordMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_anyKeywordMask");
			EventProvider.NativeFieldInfoPtr_m_allKeywordMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_allKeywordMask");
			EventProvider.NativeFieldInfoPtr_m_liveSessions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_liveSessions");
			EventProvider.NativeFieldInfoPtr_m_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_enabled");
			EventProvider.NativeFieldInfoPtr_m_providerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_providerId");
			EventProvider.NativeFieldInfoPtr_m_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_disposed");
			EventProvider.NativeFieldInfoPtr_s_returnCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "s_returnCode");
			EventProvider.NativeFieldInfoPtr_nibblebits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "nibblebits");
			EventProvider.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674389);
			EventProvider.NativeMethodInfoPtr_Register_Internal_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674390);
			EventProvider.NativeMethodInfoPtr_SetInformation_Internal_Int32_EVENT_INFO_CLASS_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674391);
			EventProvider.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674392);
			EventProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674393);
			EventProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674394);
			EventProvider.NativeMethodInfoPtr_Deregister_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674395);
			EventProvider.NativeMethodInfoPtr_EtwEnableCallBack_Private_Static_Void_byref_Guid_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674396);
			EventProvider.NativeMethodInfoPtr_EtwEnableCallBackImpl_Private_Void_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674397);
			EventProvider.NativeMethodInfoPtr_OnControllerCommand_Protected_Virtual_New_Void_ControllerCommand_IDictionary_2_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674398);
			EventProvider.NativeMethodInfoPtr_get_Level_Protected_get_EventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674399);
			EventProvider.NativeMethodInfoPtr_get_MatchAnyKeyword_Protected_get_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674400);
			EventProvider.NativeMethodInfoPtr_FindNull_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674401);
			EventProvider.NativeMethodInfoPtr_GetSessions_Private_List_1_Tuple_2_SessionInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674402);
			EventProvider.NativeMethodInfoPtr_GetSessionInfoCallback_Private_Static_Void_Int32_Int64_byref_List_1_SessionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674403);
			EventProvider.NativeMethodInfoPtr_GetSessionInfo_Private_Void_Action_2_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674404);
			EventProvider.NativeMethodInfoPtr_IndexOfSessionInList_Private_Static_Int32_List_1_SessionInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674405);
			EventProvider.NativeMethodInfoPtr_GetDataFromController_Private_Boolean_Int32_ptr_EVENT_FILTER_DESCRIPTOR_byref_ControllerCommand_byref_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674406);
			EventProvider.NativeMethodInfoPtr_IsEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674407);
			EventProvider.NativeMethodInfoPtr_IsEnabled_Public_Boolean_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674408);
			EventProvider.NativeMethodInfoPtr_GetLastWriteEventError_Public_Static_WriteEventErrorCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674409);
			EventProvider.NativeMethodInfoPtr_SetLastError_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674410);
			EventProvider.NativeMethodInfoPtr_EncodeObject_Private_Static_Object_byref_Object_byref_ptr_EventData_byref_ptr_Byte_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674411);
			EventProvider.NativeMethodInfoPtr_WriteEvent_Internal_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674412);
			EventProvider.NativeMethodInfoPtr_WriteEvent_FamOrAssem_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674413);
			EventProvider.NativeMethodInfoPtr_WriteEventRaw_Internal_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674414);
			EventProvider.NativeMethodInfoPtr_EventUnregister_Private_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674415);
			EventProvider.NativeMethodInfoPtr_bitcount_Private_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674416);
			EventProvider.NativeMethodInfoPtr_bitindex_Private_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674417);
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x00156E14 File Offset: 0x00155014
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x00156E50 File Offset: 0x00155050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372820, RefRangeEnd = 372821, XrefRangeStart = 372809, XrefRangeEnd = 372820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(Guid providerGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref providerGuid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_Register_Internal_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x00156E90 File Offset: 0x00155090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372832, RefRangeEnd = 372833, XrefRangeStart = 372821, XrefRangeEnd = 372832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SetInformation(UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS eventInfoClass, void* data, int dataSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventInfoClass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_SetInformation_Internal_Int32_EVENT_INFO_CLASS_ptr_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x00156EF4 File Offset: 0x001550F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372833, XrefRangeEnd = 372837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x00156F28 File Offset: 0x00155128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372837, XrefRangeEnd = 372847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x00156F74 File Offset: 0x00155174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x00156FB0 File Offset: 0x001551B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372847, XrefRangeEnd = 372849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_Deregister_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x00156FE4 File Offset: 0x001551E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372849, XrefRangeEnd = 372854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EtwEnableCallBack([In] ref Guid sourceId, [In] int controlCode, [In] byte setLevel, [In] long anyKeyword, [In] long allKeyword, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &sourceId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anyKeyword;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allKeyword;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = filterData;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = callbackContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_EtwEnableCallBack_Private_Static_Void_byref_Guid_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_ptr_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x0015706C File Offset: 0x0015526C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372905, RefRangeEnd = 372906, XrefRangeStart = 372854, XrefRangeEnd = 372905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EtwEnableCallBackImpl([In] int controlCode, [In] byte setLevel, [In] long anyKeyword, [In] long allKeyword, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controlCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anyKeyword;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allKeyword;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = filterData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_EtwEnableCallBackImpl_Private_Void_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x001570E4 File Offset: 0x001552E4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int sessionId, int etwSessionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref command;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwSessionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventProvider.NativeMethodInfoPtr_OnControllerCommand_Protected_Virtual_New_Void_ControllerCommand_IDictionary_2_String_String_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06004ADF RID: 19167 RVA: 0x0015715C File Offset: 0x0015535C
		public unsafe EventLevel Level
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_get_Level_Protected_get_EventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x06004AE0 RID: 19168 RVA: 0x00157198 File Offset: 0x00155398
		public unsafe EventKeywords MatchAnyKeyword
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_get_MatchAnyKeyword_Protected_get_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x001571D4 File Offset: 0x001553D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372906, XrefRangeEnd = 372907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNull(Il2CppStructArray<byte> buffer, int idx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_FindNull_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x00157224 File Offset: 0x00155424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372976, RefRangeEnd = 372977, XrefRangeStart = 372907, XrefRangeEnd = 372976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Tuple<EventProvider.SessionInfo, bool>> GetSessions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_GetSessions_Private_List_1_Tuple_2_SessionInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tuple<EventProvider.SessionInfo, bool>>>(intPtr3) : null;
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x00157264 File Offset: 0x00155464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372999, RefRangeEnd = 373000, XrefRangeStart = 372977, XrefRangeEnd = 372999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSessionInfoCallback(int etwSessionId, long matchAllKeywords, ref List<EventProvider.SessionInfo> sessionList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref etwSessionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchAllKeywords;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sessionList);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_GetSessionInfoCallback_Private_Static_Void_Int32_Int64_byref_List_1_SessionInfo_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sessionList = ((intPtr4 == 0) ? null : new List<EventProvider.SessionInfo>(intPtr4));
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x001572CC File Offset: 0x001554CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373010, RefRangeEnd = 373011, XrefRangeStart = 373000, XrefRangeEnd = 373010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSessionInfo(Action<int, long> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_GetSessionInfo_Private_Void_Action_2_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x00157310 File Offset: 0x00155510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373011, XrefRangeEnd = 373016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOfSessionInList(List<EventProvider.SessionInfo> sessions, int etwSessionId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sessions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwSessionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_IndexOfSessionInList_Private_Static_Int32_List_1_SessionInfo_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x00157360 File Offset: 0x00155560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373016, XrefRangeEnd = 373025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetDataFromController(int etwSessionId, UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, out ControllerCommand command, out Il2CppStructArray<byte> data, out int dataStart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref etwSessionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = filterData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &command;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dataStart;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_GetDataFromController_Private_Boolean_Int32_ptr_EVENT_FILTER_DESCRIPTOR_byref_ControllerCommand_byref_Il2CppStructArray_1_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x001573F8 File Offset: 0x001555F8
		[CallerCount(0)]
		public unsafe bool IsEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_IsEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AE8 RID: 19176 RVA: 0x00157434 File Offset: 0x00155634
		[CallerCount(0)]
		public unsafe bool IsEnabled(byte level, long keywords)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_IsEnabled_Public_Boolean_Byte_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x0015748C File Offset: 0x0015568C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373025, XrefRangeEnd = 373030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventProvider.WriteEventErrorCode GetLastWriteEventError()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_GetLastWriteEventError_Public_Static_WriteEventErrorCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x001574BC File Offset: 0x001556BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 373035, RefRangeEnd = 373040, XrefRangeStart = 373030, XrefRangeEnd = 373035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLastError(int error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_SetLastError_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x001574F0 File Offset: 0x001556F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373167, RefRangeEnd = 373168, XrefRangeStart = 373040, XrefRangeEnd = 373167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object EncodeObject(ref Object data, ref EventProvider.EventData* dataDescriptor, ref byte* dataBuffer, ref uint totalEventSize)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(dataDescriptor);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(dataBuffer);
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &totalEventSize;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_EncodeObject_Private_Static_Object_byref_Object_byref_ptr_EventData_byref_ptr_Byte_byref_UInt32_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			data = ((intPtr6 == 0) ? null : new Object(intPtr6));
			IntPtr intPtr7 = intPtr2;
			dataDescriptor = ((intPtr7 == 0) ? null : new EventProvider.EventData*(intPtr7));
			IntPtr intPtr8 = intPtr3;
			dataBuffer = ((intPtr8 == 0) ? null : new byte*(intPtr8));
			IntPtr intPtr9 = intPtr4;
			return (intPtr9 != 0) ? Il2CppObjectPool.Get<Object>(intPtr9) : null;
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x001575AC File Offset: 0x001557AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 373296, RefRangeEnd = 373298, XrefRangeStart = 373168, XrefRangeEnd = 373296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, [Optional] Il2CppReferenceArray<Object> eventPayload)
		{
			if (eventPayload == null)
			{
				eventPayload = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &eventDescriptor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventPayload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_WriteEvent_Internal_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x00157630 File Offset: 0x00155830
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 373305, RefRangeEnd = 373308, XrefRangeStart = 373298, XrefRangeEnd = 373305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, int dataCount, IntPtr data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &eventDescriptor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_WriteEvent_FamOrAssem_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x001576B0 File Offset: 0x001558B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373308, XrefRangeEnd = 373315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WriteEventRaw(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &eventDescriptor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = relatedActivityID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_WriteEventRaw_Internal_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x00157730 File Offset: 0x00155930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373315, XrefRangeEnd = 373316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint EventUnregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_EventUnregister_Private_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x0015776C File Offset: 0x0015596C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 373320, RefRangeEnd = 373323, XrefRangeStart = 373316, XrefRangeEnd = 373320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int bitcount(uint n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_bitcount_Private_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x001577AC File Offset: 0x001559AC
		[CallerCount(0)]
		public unsafe static int bitindex(uint n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_bitindex_Private_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x0001C10A File Offset: 0x0001A30A
		public unsafe bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, params Object[] eventPayload)
		{
			return this.WriteEvent(ref eventDescriptor, activityID, childActivityID, new Il2CppReferenceArray<Object>(eventPayload));
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x0001C11C File Offset: 0x0001A31C
		public EventProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06004AF4 RID: 19188 RVA: 0x001577EC File Offset: 0x001559EC
		// (set) Token: 0x06004AF5 RID: 19189 RVA: 0x0001C125 File Offset: 0x0001A325
		public unsafe static bool m_setInformationMissing
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(EventProvider.NativeFieldInfoPtr_m_setInformationMissing, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventProvider.NativeFieldInfoPtr_m_setInformationMissing, (void*)(&value));
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06004AF6 RID: 19190 RVA: 0x00157808 File Offset: 0x00155A08
		// (set) Token: 0x06004AF7 RID: 19191 RVA: 0x0001C133 File Offset: 0x0001A333
		public unsafe UnsafeNativeMethods.ManifestEtw.EtwEnableCallback m_etwCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_etwCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnsafeNativeMethods.ManifestEtw.EtwEnableCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_etwCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06004AF8 RID: 19192 RVA: 0x00157838 File Offset: 0x00155A38
		// (set) Token: 0x06004AF9 RID: 19193 RVA: 0x0001C152 File Offset: 0x0001A352
		public unsafe GCHandle m_thisGCHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_thisGCHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_thisGCHandle)) = value;
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06004AFA RID: 19194 RVA: 0x00157860 File Offset: 0x00155A60
		// (set) Token: 0x06004AFB RID: 19195 RVA: 0x0001C16D File Offset: 0x0001A36D
		public unsafe long m_regHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_regHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_regHandle)) = value;
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06004AFC RID: 19196 RVA: 0x00157888 File Offset: 0x00155A88
		// (set) Token: 0x06004AFD RID: 19197 RVA: 0x0001C188 File Offset: 0x0001A388
		public unsafe byte m_level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_level)) = value;
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06004AFE RID: 19198 RVA: 0x001578B0 File Offset: 0x00155AB0
		// (set) Token: 0x06004AFF RID: 19199 RVA: 0x0001C1A3 File Offset: 0x0001A3A3
		public unsafe long m_anyKeywordMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_anyKeywordMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_anyKeywordMask)) = value;
			}
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06004B00 RID: 19200 RVA: 0x001578D8 File Offset: 0x00155AD8
		// (set) Token: 0x06004B01 RID: 19201 RVA: 0x0001C1BE File Offset: 0x0001A3BE
		public unsafe long m_allKeywordMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_allKeywordMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_allKeywordMask)) = value;
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06004B02 RID: 19202 RVA: 0x00157900 File Offset: 0x00155B00
		// (set) Token: 0x06004B03 RID: 19203 RVA: 0x0001C1D9 File Offset: 0x0001A3D9
		public unsafe List<EventProvider.SessionInfo> m_liveSessions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_liveSessions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventProvider.SessionInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_liveSessions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06004B04 RID: 19204 RVA: 0x00157930 File Offset: 0x00155B30
		// (set) Token: 0x06004B05 RID: 19205 RVA: 0x0001C1F8 File Offset: 0x0001A3F8
		public unsafe bool m_enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_enabled)) = value;
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06004B06 RID: 19206 RVA: 0x00157958 File Offset: 0x00155B58
		// (set) Token: 0x06004B07 RID: 19207 RVA: 0x0001C213 File Offset: 0x0001A413
		public unsafe Guid m_providerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_providerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_providerId)) = value;
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06004B08 RID: 19208 RVA: 0x00157980 File Offset: 0x00155B80
		// (set) Token: 0x06004B09 RID: 19209 RVA: 0x0001C22E File Offset: 0x0001A42E
		public unsafe bool m_disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_disposed)) = value;
			}
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06004B0A RID: 19210 RVA: 0x001579A8 File Offset: 0x00155BA8
		// (set) Token: 0x06004B0B RID: 19211 RVA: 0x0001C249 File Offset: 0x0001A449
		public unsafe static EventProvider.WriteEventErrorCode s_returnCode
		{
			get
			{
				EventProvider.WriteEventErrorCode writeEventErrorCode;
				IL2CPP.il2cpp_field_static_get_value(EventProvider.NativeFieldInfoPtr_s_returnCode, (void*)(&writeEventErrorCode));
				return writeEventErrorCode;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventProvider.NativeFieldInfoPtr_s_returnCode, (void*)(&value));
			}
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06004B0C RID: 19212 RVA: 0x001579C4 File Offset: 0x00155BC4
		// (set) Token: 0x06004B0D RID: 19213 RVA: 0x0001C257 File Offset: 0x0001A457
		public unsafe static Il2CppStructArray<int> nibblebits
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventProvider.NativeFieldInfoPtr_nibblebits, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventProvider.NativeFieldInfoPtr_nibblebits, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C7D RID: 15485
		private static readonly IntPtr NativeFieldInfoPtr_m_setInformationMissing;

		// Token: 0x04003C7E RID: 15486
		private static readonly IntPtr NativeFieldInfoPtr_m_etwCallback;

		// Token: 0x04003C7F RID: 15487
		private static readonly IntPtr NativeFieldInfoPtr_m_thisGCHandle;

		// Token: 0x04003C80 RID: 15488
		private static readonly IntPtr NativeFieldInfoPtr_m_regHandle;

		// Token: 0x04003C81 RID: 15489
		private static readonly IntPtr NativeFieldInfoPtr_m_level;

		// Token: 0x04003C82 RID: 15490
		private static readonly IntPtr NativeFieldInfoPtr_m_anyKeywordMask;

		// Token: 0x04003C83 RID: 15491
		private static readonly IntPtr NativeFieldInfoPtr_m_allKeywordMask;

		// Token: 0x04003C84 RID: 15492
		private static readonly IntPtr NativeFieldInfoPtr_m_liveSessions;

		// Token: 0x04003C85 RID: 15493
		private static readonly IntPtr NativeFieldInfoPtr_m_enabled;

		// Token: 0x04003C86 RID: 15494
		private static readonly IntPtr NativeFieldInfoPtr_m_providerId;

		// Token: 0x04003C87 RID: 15495
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x04003C88 RID: 15496
		private static readonly IntPtr NativeFieldInfoPtr_s_returnCode;

		// Token: 0x04003C89 RID: 15497
		private static readonly IntPtr NativeFieldInfoPtr_nibblebits;

		// Token: 0x04003C8A RID: 15498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04003C8B RID: 15499
		private static readonly IntPtr NativeMethodInfoPtr_Register_Internal_Void_Guid_0;

		// Token: 0x04003C8C RID: 15500
		private static readonly IntPtr NativeMethodInfoPtr_SetInformation_Internal_Int32_EVENT_INFO_CLASS_ptr_Void_Int32_0;

		// Token: 0x04003C8D RID: 15501
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003C8E RID: 15502
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04003C8F RID: 15503
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04003C90 RID: 15504
		private static readonly IntPtr NativeMethodInfoPtr_Deregister_Private_Void_0;

		// Token: 0x04003C91 RID: 15505
		private static readonly IntPtr NativeMethodInfoPtr_EtwEnableCallBack_Private_Static_Void_byref_Guid_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_ptr_Void_0;

		// Token: 0x04003C92 RID: 15506
		private static readonly IntPtr NativeMethodInfoPtr_EtwEnableCallBackImpl_Private_Void_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_0;

		// Token: 0x04003C93 RID: 15507
		private static readonly IntPtr NativeMethodInfoPtr_OnControllerCommand_Protected_Virtual_New_Void_ControllerCommand_IDictionary_2_String_String_Int32_Int32_0;

		// Token: 0x04003C94 RID: 15508
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Protected_get_EventLevel_0;

		// Token: 0x04003C95 RID: 15509
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchAnyKeyword_Protected_get_EventKeywords_0;

		// Token: 0x04003C96 RID: 15510
		private static readonly IntPtr NativeMethodInfoPtr_FindNull_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04003C97 RID: 15511
		private static readonly IntPtr NativeMethodInfoPtr_GetSessions_Private_List_1_Tuple_2_SessionInfo_Boolean_0;

		// Token: 0x04003C98 RID: 15512
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionInfoCallback_Private_Static_Void_Int32_Int64_byref_List_1_SessionInfo_0;

		// Token: 0x04003C99 RID: 15513
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionInfo_Private_Void_Action_2_Int32_Int64_0;

		// Token: 0x04003C9A RID: 15514
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfSessionInList_Private_Static_Int32_List_1_SessionInfo_Int32_0;

		// Token: 0x04003C9B RID: 15515
		private static readonly IntPtr NativeMethodInfoPtr_GetDataFromController_Private_Boolean_Int32_ptr_EVENT_FILTER_DESCRIPTOR_byref_ControllerCommand_byref_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x04003C9C RID: 15516
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_0;

		// Token: 0x04003C9D RID: 15517
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_Byte_Int64_0;

		// Token: 0x04003C9E RID: 15518
		private static readonly IntPtr NativeMethodInfoPtr_GetLastWriteEventError_Public_Static_WriteEventErrorCode_0;

		// Token: 0x04003C9F RID: 15519
		private static readonly IntPtr NativeMethodInfoPtr_SetLastError_Private_Static_Void_Int32_0;

		// Token: 0x04003CA0 RID: 15520
		private static readonly IntPtr NativeMethodInfoPtr_EncodeObject_Private_Static_Object_byref_Object_byref_ptr_EventData_byref_ptr_Byte_byref_UInt32_0;

		// Token: 0x04003CA1 RID: 15521
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Internal_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003CA2 RID: 15522
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_FamOrAssem_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0;

		// Token: 0x04003CA3 RID: 15523
		private static readonly IntPtr NativeMethodInfoPtr_WriteEventRaw_Internal_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0;

		// Token: 0x04003CA4 RID: 15524
		private static readonly IntPtr NativeMethodInfoPtr_EventUnregister_Private_UInt32_0;

		// Token: 0x04003CA5 RID: 15525
		private static readonly IntPtr NativeMethodInfoPtr_bitcount_Private_Static_Int32_UInt32_0;

		// Token: 0x04003CA6 RID: 15526
		private static readonly IntPtr NativeMethodInfoPtr_bitindex_Private_Static_Int32_UInt32_0;

		// Token: 0x0200067C RID: 1660
		[StructLayout(2)]
		public struct EventData
		{
			// Token: 0x0600570E RID: 22286 RVA: 0x0017F4CC File Offset: 0x0017D6CC
			// Note: this type is marked as 'beforefieldinit'.
			static EventData()
			{
				Il2CppClassPointerStore<EventProvider.EventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "EventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventProvider.EventData>.NativeClassPtr);
				EventProvider.EventData.NativeFieldInfoPtr_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider.EventData>.NativeClassPtr, "Ptr");
				EventProvider.EventData.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider.EventData>.NativeClassPtr, "Size");
				EventProvider.EventData.NativeFieldInfoPtr_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider.EventData>.NativeClassPtr, "Reserved");
			}

			// Token: 0x0600570F RID: 22287 RVA: 0x00021B5C File Offset: 0x0001FD5C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventProvider.EventData>.NativeClassPtr, ref this));
			}

			// Token: 0x040045AD RID: 17837
			private static readonly IntPtr NativeFieldInfoPtr_Ptr;

			// Token: 0x040045AE RID: 17838
			private static readonly IntPtr NativeFieldInfoPtr_Size;

			// Token: 0x040045AF RID: 17839
			private static readonly IntPtr NativeFieldInfoPtr_Reserved;

			// Token: 0x040045B0 RID: 17840
			[FieldOffset(0)]
			public ulong Ptr;

			// Token: 0x040045B1 RID: 17841
			[FieldOffset(8)]
			public uint Size;

			// Token: 0x040045B2 RID: 17842
			[FieldOffset(12)]
			public uint Reserved;
		}

		// Token: 0x0200067D RID: 1661
		[StructLayout(2)]
		public struct SessionInfo
		{
			// Token: 0x06005710 RID: 22288 RVA: 0x0017F534 File Offset: 0x0017D734
			// Note: this type is marked as 'beforefieldinit'.
			static SessionInfo()
			{
				Il2CppClassPointerStore<EventProvider.SessionInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "SessionInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventProvider.SessionInfo>.NativeClassPtr);
				EventProvider.SessionInfo.NativeFieldInfoPtr_sessionIdBit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider.SessionInfo>.NativeClassPtr, "sessionIdBit");
				EventProvider.SessionInfo.NativeFieldInfoPtr_etwSessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider.SessionInfo>.NativeClassPtr, "etwSessionId");
				EventProvider.SessionInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider.SessionInfo>.NativeClassPtr, 100674419);
			}

			// Token: 0x06005711 RID: 22289 RVA: 0x0017F59C File Offset: 0x0017D79C
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 16465, RefRangeEnd = 16495, XrefRangeStart = 16465, XrefRangeEnd = 16495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SessionInfo(int sessionIdBit_, int etwSessionId_)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref sessionIdBit_;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwSessionId_;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.SessionInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005712 RID: 22290 RVA: 0x00021B6E File Offset: 0x0001FD6E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventProvider.SessionInfo>.NativeClassPtr, ref this));
			}

			// Token: 0x040045B3 RID: 17843
			private static readonly IntPtr NativeFieldInfoPtr_sessionIdBit;

			// Token: 0x040045B4 RID: 17844
			private static readonly IntPtr NativeFieldInfoPtr_etwSessionId;

			// Token: 0x040045B5 RID: 17845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0;

			// Token: 0x040045B6 RID: 17846
			[FieldOffset(0)]
			public int sessionIdBit;

			// Token: 0x040045B7 RID: 17847
			[FieldOffset(4)]
			public int etwSessionId;
		}

		// Token: 0x0200067E RID: 1662
		public enum WriteEventErrorCode
		{
			// Token: 0x040045B9 RID: 17849
			NoError,
			// Token: 0x040045BA RID: 17850
			NoFreeBuffers,
			// Token: 0x040045BB RID: 17851
			EventTooBig,
			// Token: 0x040045BC RID: 17852
			NullInput,
			// Token: 0x040045BD RID: 17853
			TooManyArgs,
			// Token: 0x040045BE RID: 17854
			Other
		}

		// Token: 0x0200067F RID: 1663
		public sealed class MonoPInvokeCallbackAttribute : Attribute
		{
			// Token: 0x06005713 RID: 22291 RVA: 0x00021B80 File Offset: 0x0001FD80
			// Note: this type is marked as 'beforefieldinit'.
			static MonoPInvokeCallbackAttribute()
			{
				Il2CppClassPointerStore<EventProvider.MonoPInvokeCallbackAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "MonoPInvokeCallbackAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventProvider.MonoPInvokeCallbackAttribute>.NativeClassPtr);
				EventProvider.MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider.MonoPInvokeCallbackAttribute>.NativeClassPtr, 100674420);
			}

			// Token: 0x06005714 RID: 22292 RVA: 0x0017F5DC File Offset: 0x0017D7DC
			[CallerCount(114)]
			[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MonoPInvokeCallbackAttribute(Type t)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventProvider.MonoPInvokeCallbackAttribute>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005715 RID: 22293 RVA: 0x00021BB4 File Offset: 0x0001FDB4
			public MonoPInvokeCallbackAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040045BF RID: 17855
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
		}

		// Token: 0x02000680 RID: 1664
		[ObfuscatedName("System.Diagnostics.Tracing.EventProvider+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Object
		{
			// Token: 0x06005716 RID: 22294 RVA: 0x0017F628 File Offset: 0x0017D828
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<EventProvider.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventProvider.__c__DisplayClass44_0>.NativeClassPtr);
				EventProvider.__c__DisplayClass44_0.NativeFieldInfoPtr_liveSessionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider.__c__DisplayClass44_0>.NativeClassPtr, "liveSessionList");
				EventProvider.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider.__c__DisplayClass44_0>.NativeClassPtr, 100674421);
				EventProvider.__c__DisplayClass44_0.NativeMethodInfoPtr__GetSessions_b__0_Internal_Void_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider.__c__DisplayClass44_0>.NativeClassPtr, 100674422);
			}

			// Token: 0x06005717 RID: 22295 RVA: 0x0017F690 File Offset: 0x0017D890
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventProvider.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005718 RID: 22296 RVA: 0x0017F6CC File Offset: 0x0017D8CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372805, XrefRangeEnd = 372809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetSessions_b__0(int etwSessionId, long matchAllKeywords)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref etwSessionId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchAllKeywords;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.__c__DisplayClass44_0.NativeMethodInfoPtr__GetSessions_b__0_Internal_Void_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005719 RID: 22297 RVA: 0x00021BBD File Offset: 0x0001FDBD
			public __c__DisplayClass44_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001669 RID: 5737
			// (get) Token: 0x0600571A RID: 22298 RVA: 0x0017F718 File Offset: 0x0017D918
			// (set) Token: 0x0600571B RID: 22299 RVA: 0x00021BC6 File Offset: 0x0001FDC6
			public unsafe List<EventProvider.SessionInfo> liveSessionList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.__c__DisplayClass44_0.NativeFieldInfoPtr_liveSessionList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventProvider.SessionInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.__c__DisplayClass44_0.NativeFieldInfoPtr_liveSessionList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045C0 RID: 17856
			private static readonly IntPtr NativeFieldInfoPtr_liveSessionList;

			// Token: 0x040045C1 RID: 17857
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040045C2 RID: 17858
			private static readonly IntPtr NativeMethodInfoPtr__GetSessions_b__0_Internal_Void_Int32_Int64_0;
		}
	}
}
