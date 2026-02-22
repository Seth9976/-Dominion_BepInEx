using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Net
{
	// Token: 0x020000D5 RID: 213
	[Serializable]
	public class WebException : InvalidOperationException
	{
		// Token: 0x06000C47 RID: 3143 RVA: 0x0003E884 File Offset: 0x0003CA84
		// Note: this type is marked as 'beforefieldinit'.
		static WebException()
		{
			Il2CppClassPointerStore<WebException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebException>.NativeClassPtr);
			WebException.NativeFieldInfoPtr_m_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebException>.NativeClassPtr, "m_Status");
			WebException.NativeFieldInfoPtr_m_Response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebException>.NativeClassPtr, "m_Response");
			WebException.NativeFieldInfoPtr_m_InternalStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebException>.NativeClassPtr, "m_InternalStatus");
			WebException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100665023);
			WebException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100665024);
			WebException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100665025);
			WebException.NativeMethodInfoPtr__ctor_Public_Void_String_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100665026);
			WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_WebExceptionStatus_WebExceptionInternalStatus_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100665027);
			WebException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_WebExceptionStatus_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100665028);
			WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Exception_WebExceptionStatus_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100665029);
			WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_Exception_WebExceptionStatus_WebResponse_WebExceptionInternalStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100665030);
			WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Exception_WebExceptionStatus_WebResponse_WebExceptionInternalStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100665031);
			WebException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100665032);
			WebException.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100665033);
			WebException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100665034);
			WebException.NativeMethodInfoPtr_get_Status_Public_get_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100665035);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0003E9F4 File Offset: 0x0003CBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46457, XrefRangeEnd = 46458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0003EA30 File Offset: 0x0003CC30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46459, RefRangeEnd = 46460, XrefRangeStart = 46458, XrefRangeEnd = 46459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0003EA7C File Offset: 0x0003CC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46460, XrefRangeEnd = 46461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0003EADC File Offset: 0x0003CCDC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 46467, RefRangeEnd = 46478, XrefRangeStart = 46461, XrefRangeEnd = 46467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message, WebExceptionStatus status)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Public_Void_String_WebExceptionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0003EB38 File Offset: 0x0003CD38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 46484, RefRangeEnd = 46486, XrefRangeStart = 46478, XrefRangeEnd = 46484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalStatus;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_WebExceptionStatus_WebExceptionInternalStatus_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0003EBB4 File Offset: 0x0003CDB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 46492, RefRangeEnd = 46495, XrefRangeStart = 46486, XrefRangeEnd = 46492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_WebExceptionStatus_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0003EC34 File Offset: 0x0003CE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46495, XrefRangeEnd = 46505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Exception_WebExceptionStatus_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0003ECC4 File Offset: 0x0003CEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46505, XrefRangeEnd = 46511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_Exception_WebExceptionStatus_WebResponse_WebExceptionInternalStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0003ED50 File Offset: 0x0003CF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46511, XrefRangeEnd = 46521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Exception_WebExceptionStatus_WebResponse_WebExceptionInternalStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0003EDF0 File Offset: 0x0003CFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46521, XrefRangeEnd = 46522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0003EE54 File Offset: 0x0003D054
		[CallerCount(0)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0003EEB0 File Offset: 0x0003D0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0003EF14 File Offset: 0x0003D114
		public unsafe WebExceptionStatus Status
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 41028, RefRangeEnd = 41035, XrefRangeStart = 41028, XrefRangeEnd = 41035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr_get_Status_Public_get_WebExceptionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00006D3A File Offset: 0x00004F3A
		public WebException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0003EF50 File Offset: 0x0003D150
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x00006D43 File Offset: 0x00004F43
		public unsafe WebExceptionStatus m_Status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebException.NativeFieldInfoPtr_m_Status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebException.NativeFieldInfoPtr_m_Status)) = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0003EF78 File Offset: 0x0003D178
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x00006D5E File Offset: 0x00004F5E
		public unsafe WebResponse m_Response
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebException.NativeFieldInfoPtr_m_Response);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebException.NativeFieldInfoPtr_m_Response), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0003EFA8 File Offset: 0x0003D1A8
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x00006D7D File Offset: 0x00004F7D
		public unsafe WebExceptionInternalStatus m_InternalStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebException.NativeFieldInfoPtr_m_InternalStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebException.NativeFieldInfoPtr_m_InternalStatus)) = value;
			}
		}

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeFieldInfoPtr_m_Status;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeFieldInfoPtr_m_Response;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalStatus;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_WebExceptionStatus_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_WebExceptionStatus_WebExceptionInternalStatus_Exception_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_WebExceptionStatus_WebResponse_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_Exception_WebExceptionStatus_WebResponse_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Exception_WebExceptionStatus_WebResponse_WebExceptionInternalStatus_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_Exception_WebExceptionStatus_WebResponse_WebExceptionInternalStatus_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_WebExceptionStatus_0;
	}
}
