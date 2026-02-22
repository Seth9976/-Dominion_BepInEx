using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x020000F3 RID: 243
	[Serializable]
	public class FileWebRequest : WebRequest
	{
		// Token: 0x06000E34 RID: 3636 RVA: 0x00045AB4 File Offset: 0x00043CB4
		// Note: this type is marked as 'beforefieldinit'.
		static FileWebRequest()
		{
			Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FileWebRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr);
			FileWebRequest.NativeFieldInfoPtr_s_GetRequestStreamCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "s_GetRequestStreamCallback");
			FileWebRequest.NativeFieldInfoPtr_s_GetResponseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "s_GetResponseCallback");
			FileWebRequest.NativeFieldInfoPtr_m_connectionGroupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_connectionGroupName");
			FileWebRequest.NativeFieldInfoPtr_m_contentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_contentLength");
			FileWebRequest.NativeFieldInfoPtr_m_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_credentials");
			FileWebRequest.NativeFieldInfoPtr_m_fileAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_fileAccess");
			FileWebRequest.NativeFieldInfoPtr_m_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_headers");
			FileWebRequest.NativeFieldInfoPtr_m_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_method");
			FileWebRequest.NativeFieldInfoPtr_m_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_proxy");
			FileWebRequest.NativeFieldInfoPtr_m_readerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_readerEvent");
			FileWebRequest.NativeFieldInfoPtr_m_readPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_readPending");
			FileWebRequest.NativeFieldInfoPtr_m_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_response");
			FileWebRequest.NativeFieldInfoPtr_m_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_stream");
			FileWebRequest.NativeFieldInfoPtr_m_syncHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_syncHint");
			FileWebRequest.NativeFieldInfoPtr_m_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_timeout");
			FileWebRequest.NativeFieldInfoPtr_m_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_uri");
			FileWebRequest.NativeFieldInfoPtr_m_writePending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_writePending");
			FileWebRequest.NativeFieldInfoPtr_m_writing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_writing");
			FileWebRequest.NativeFieldInfoPtr_m_WriteAResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_WriteAResult");
			FileWebRequest.NativeFieldInfoPtr_m_ReadAResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_ReadAResult");
			FileWebRequest.NativeFieldInfoPtr_m_Aborted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, "m_Aborted");
			FileWebRequest.NativeMethodInfoPtr__ctor_Internal_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665292);
			FileWebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665293);
			FileWebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665294);
			FileWebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665295);
			FileWebRequest.NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665296);
			FileWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665297);
			FileWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665298);
			FileWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665299);
			FileWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665300);
			FileWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665301);
			FileWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665302);
			FileWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665303);
			FileWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665304);
			FileWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665305);
			FileWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665306);
			FileWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665307);
			FileWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665308);
			FileWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665309);
			FileWebRequest.NativeMethodInfoPtr_GetRequestStreamCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665310);
			FileWebRequest.NativeMethodInfoPtr_GetResponseCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665311);
			FileWebRequest.NativeMethodInfoPtr_UnblockReader_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665312);
			FileWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665313);
			FileWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr, 100665314);
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00045E54 File Offset: 0x00044054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48889, XrefRangeEnd = 48904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileWebRequest(Uri uri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequest.NativeMethodInfoPtr__ctor_Internal_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00045EA0 File Offset: 0x000440A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48904, XrefRangeEnd = 48955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00045F04 File Offset: 0x00044104
		[CallerCount(0)]
		public new unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00045F60 File Offset: 0x00044160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48955, XrefRangeEnd = 48998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00045FC4 File Offset: 0x000441C4
		public unsafe bool Aborted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequest.NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00046000 File Offset: 0x00044200
		public unsafe override long ContentLength
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00046048 File Offset: 0x00044248
		// (set) Token: 0x06000E3C RID: 3644 RVA: 0x00046094 File Offset: 0x00044294
		public unsafe override ICredentials Credentials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x000460E4 File Offset: 0x000442E4
		public unsafe override WebHeaderCollection Headers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00046130 File Offset: 0x00044330
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x00046174 File Offset: 0x00044374
		public unsafe override string Method
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48998, XrefRangeEnd = 49002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x000461C4 File Offset: 0x000443C4
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x00046210 File Offset: 0x00044410
		public unsafe override IWebProxy Proxy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00046260 File Offset: 0x00044460
		public unsafe override int Timeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x000462A8 File Offset: 0x000444A8
		public unsafe override Uri RequestUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x000462F4 File Offset: 0x000444F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49002, XrefRangeEnd = 49015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginGetResponse(AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00046364 File Offset: 0x00044564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49015, XrefRangeEnd = 49023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
			}
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x000463C0 File Offset: 0x000445C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49023, XrefRangeEnd = 49048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WebResponse GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0004640C File Offset: 0x0004460C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49048, XrefRangeEnd = 49061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRequestStreamCallback(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequest.NativeMethodInfoPtr_GetRequestStreamCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00046444 File Offset: 0x00044644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49061, XrefRangeEnd = 49077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetResponseCallback(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequest.NativeMethodInfoPtr_GetResponseCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0004647C File Offset: 0x0004467C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49081, RefRangeEnd = 49082, XrefRangeStart = 49077, XrefRangeEnd = 49081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnblockReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequest.NativeMethodInfoPtr_UnblockReader_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x000464B0 File Offset: 0x000446B0
		public unsafe override bool UseDefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49082, XrefRangeEnd = 49085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x000464F8 File Offset: 0x000446F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49085, XrefRangeEnd = 49115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00007916 File Offset: 0x00005B16
		public FileWebRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00046534 File Offset: 0x00044734
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x0000791F File Offset: 0x00005B1F
		public unsafe static WaitCallback s_GetRequestStreamCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FileWebRequest.NativeFieldInfoPtr_s_GetRequestStreamCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileWebRequest.NativeFieldInfoPtr_s_GetRequestStreamCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0004655C File Offset: 0x0004475C
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00007931 File Offset: 0x00005B31
		public unsafe static WaitCallback s_GetResponseCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FileWebRequest.NativeFieldInfoPtr_s_GetResponseCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileWebRequest.NativeFieldInfoPtr_s_GetResponseCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00046584 File Offset: 0x00044784
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x00007943 File Offset: 0x00005B43
		public unsafe string m_connectionGroupName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_connectionGroupName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_connectionGroupName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x000465AC File Offset: 0x000447AC
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00007962 File Offset: 0x00005B62
		public unsafe long m_contentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_contentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_contentLength)) = value;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x000465D4 File Offset: 0x000447D4
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x0000797D File Offset: 0x00005B7D
		public unsafe ICredentials m_credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00046604 File Offset: 0x00044804
		// (set) Token: 0x06000E58 RID: 3672 RVA: 0x0000799C File Offset: 0x00005B9C
		public unsafe FileAccess m_fileAccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_fileAccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_fileAccess)) = value;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x0004662C File Offset: 0x0004482C
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x000079B7 File Offset: 0x00005BB7
		public unsafe WebHeaderCollection m_headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x0004665C File Offset: 0x0004485C
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x000079D6 File Offset: 0x00005BD6
		public unsafe string m_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x00046684 File Offset: 0x00044884
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x000079F5 File Offset: 0x00005BF5
		public unsafe IWebProxy m_proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x000466B4 File Offset: 0x000448B4
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x00007A14 File Offset: 0x00005C14
		public unsafe ManualResetEvent m_readerEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_readerEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_readerEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x000466E4 File Offset: 0x000448E4
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x00007A33 File Offset: 0x00005C33
		public unsafe bool m_readPending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_readPending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_readPending)) = value;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x0004670C File Offset: 0x0004490C
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x00007A4E File Offset: 0x00005C4E
		public unsafe WebResponse m_response
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_response);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_response), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x0004673C File Offset: 0x0004493C
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x00007A6D File Offset: 0x00005C6D
		public unsafe Stream m_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x0004676C File Offset: 0x0004496C
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x00007A8C File Offset: 0x00005C8C
		public unsafe bool m_syncHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_syncHint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_syncHint)) = value;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00046794 File Offset: 0x00044994
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x00007AA7 File Offset: 0x00005CA7
		public unsafe int m_timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_timeout)) = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x000467BC File Offset: 0x000449BC
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x00007AC2 File Offset: 0x00005CC2
		public unsafe Uri m_uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x000467EC File Offset: 0x000449EC
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00007AE1 File Offset: 0x00005CE1
		public unsafe bool m_writePending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_writePending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_writePending)) = value;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00046814 File Offset: 0x00044A14
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x00007AFC File Offset: 0x00005CFC
		public unsafe bool m_writing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_writing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_writing)) = value;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x0004683C File Offset: 0x00044A3C
		// (set) Token: 0x06000E72 RID: 3698 RVA: 0x00007B17 File Offset: 0x00005D17
		public unsafe LazyAsyncResult m_WriteAResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_WriteAResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LazyAsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_WriteAResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x0004686C File Offset: 0x00044A6C
		// (set) Token: 0x06000E74 RID: 3700 RVA: 0x00007B36 File Offset: 0x00005D36
		public unsafe LazyAsyncResult m_ReadAResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_ReadAResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LazyAsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_ReadAResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x0004689C File Offset: 0x00044A9C
		// (set) Token: 0x06000E76 RID: 3702 RVA: 0x00007B55 File Offset: 0x00005D55
		public unsafe int m_Aborted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_Aborted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebRequest.NativeFieldInfoPtr_m_Aborted)) = value;
			}
		}

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeFieldInfoPtr_s_GetRequestStreamCallback;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeFieldInfoPtr_s_GetResponseCallback;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeFieldInfoPtr_m_connectionGroupName;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeFieldInfoPtr_m_contentLength;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeFieldInfoPtr_m_credentials;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeFieldInfoPtr_m_fileAccess;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeFieldInfoPtr_m_headers;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeFieldInfoPtr_m_method;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeFieldInfoPtr_m_proxy;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeFieldInfoPtr_m_readerEvent;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeFieldInfoPtr_m_readPending;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeFieldInfoPtr_m_response;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeFieldInfoPtr_m_stream;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeFieldInfoPtr_m_syncHint;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeFieldInfoPtr_m_timeout;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeFieldInfoPtr_m_uri;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeFieldInfoPtr_m_writePending;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeFieldInfoPtr_m_writing;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeFieldInfoPtr_m_WriteAResult;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeFieldInfoPtr_m_ReadAResult;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeFieldInfoPtr_m_Aborted;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Uri_0;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestStreamCallback_Private_Static_Void_Object_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseCallback_Private_Static_Void_Object_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_UnblockReader_Internal_Void_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Void_0;
	}
}
