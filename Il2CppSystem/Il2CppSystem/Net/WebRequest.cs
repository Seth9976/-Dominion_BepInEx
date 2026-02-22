using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Net.Cache;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Principal;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x020000DC RID: 220
	[Serializable]
	public class WebRequest : MarshalByRefObject
	{
		// Token: 0x06000C9E RID: 3230 RVA: 0x000400F8 File Offset: 0x0003E2F8
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequest()
		{
			Il2CppClassPointerStore<WebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequest>.NativeClassPtr);
			WebRequest.NativeFieldInfoPtr_s_PrefixList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "s_PrefixList");
			WebRequest.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "s_InternalSyncObject");
			WebRequest.NativeFieldInfoPtr_s_DefaultTimerQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "s_DefaultTimerQueue");
			WebRequest.NativeFieldInfoPtr_m_AuthenticationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "m_AuthenticationLevel");
			WebRequest.NativeFieldInfoPtr_m_ImpersonationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "m_ImpersonationLevel");
			WebRequest.NativeFieldInfoPtr_m_CachePolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "m_CachePolicy");
			WebRequest.NativeFieldInfoPtr_m_CacheProtocol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "m_CacheProtocol");
			WebRequest.NativeFieldInfoPtr_m_CacheBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "m_CacheBinding");
			WebRequest.NativeFieldInfoPtr_webRequestCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "webRequestCreate");
			WebRequest.NativeFieldInfoPtr_s_DefaultWebProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "s_DefaultWebProxy");
			WebRequest.NativeFieldInfoPtr_s_DefaultWebProxyInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "s_DefaultWebProxyInitialized");
			WebRequest.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665075);
			WebRequest.NativeMethodInfoPtr_Create_Private_Static_WebRequest_Uri_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665076);
			WebRequest.NativeMethodInfoPtr_Create_Public_Static_WebRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665077);
			WebRequest.NativeMethodInfoPtr_Create_Public_Static_WebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665078);
			WebRequest.NativeMethodInfoPtr_get_PrefixList_Internal_Static_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665079);
			WebRequest.NativeMethodInfoPtr_PopulatePrefixList_Private_Static_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665080);
			WebRequest.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665081);
			WebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665082);
			WebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665083);
			WebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665084);
			WebRequest.NativeMethodInfoPtr_set_CachePolicy_Public_Virtual_New_set_Void_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665085);
			WebRequest.NativeMethodInfoPtr_InternalSetCachePolicy_Private_Void_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665086);
			WebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665087);
			WebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665088);
			WebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_New_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665089);
			WebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_New_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665090);
			WebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665091);
			WebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665092);
			WebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_New_set_Void_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665093);
			WebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665094);
			WebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_New_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665095);
			WebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_New_set_Void_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665096);
			WebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665097);
			WebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_New_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665098);
			WebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665099);
			WebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_New_WebResponse_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665100);
			WebRequest.NativeMethodInfoPtr_GetResponseAsync_Public_Virtual_New_Task_1_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665101);
			WebRequest.NativeMethodInfoPtr_SafeCaptureIdenity_Private_WindowsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665102);
			WebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665103);
			WebRequest.NativeMethodInfoPtr_get_CacheProtocol_Internal_get_RequestCacheProtocol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665104);
			WebRequest.NativeMethodInfoPtr_set_CacheProtocol_Internal_set_Void_RequestCacheProtocol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665105);
			WebRequest.NativeMethodInfoPtr_get_InternalDefaultWebProxy_Internal_Static_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665106);
			WebRequest.NativeMethodInfoPtr_get_DefaultWebProxy_Public_Static_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665107);
			WebRequest.NativeMethodInfoPtr__GetResponseAsync_b__79_0_Private_Task_1_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665109);
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x000404AC File Offset: 0x0003E6AC
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 47189, RefRangeEnd = 47191, XrefRangeStart = 47174, XrefRangeEnd = 47189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x000404E0 File Offset: 0x0003E6E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 47221, RefRangeEnd = 47223, XrefRangeStart = 47191, XrefRangeEnd = 47221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebRequest Create(Uri requestUri, bool useUriBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUriBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_Create_Private_Static_WebRequest_Uri_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00040534 File Offset: 0x0003E734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47237, RefRangeEnd = 47238, XrefRangeStart = 47223, XrefRangeEnd = 47237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebRequest Create(string requestUriString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(requestUriString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_Create_Public_Static_WebRequest_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00040578 File Offset: 0x0003E778
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 47252, RefRangeEnd = 47255, XrefRangeStart = 47238, XrefRangeEnd = 47252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebRequest Create(Uri requestUri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_Create_Public_Static_WebRequest_Uri_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x000405BC File Offset: 0x0003E7BC
		public unsafe static ArrayList PrefixList
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 47279, RefRangeEnd = 47280, XrefRangeStart = 47255, XrefRangeEnd = 47279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_get_PrefixList_Internal_Static_get_ArrayList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x000405F0 File Offset: 0x0003E7F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47317, RefRangeEnd = 47318, XrefRangeStart = 47280, XrefRangeEnd = 47317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArrayList PopulatePrefixList()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_PopulatePrefixList_Private_Static_ArrayList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00040624 File Offset: 0x0003E824
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 47319, RefRangeEnd = 47326, XrefRangeStart = 47318, XrefRangeEnd = 47319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00040660 File Offset: 0x0003E860
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x000406C4 File Offset: 0x0003E8C4
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00040720 File Offset: 0x0003E920
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003C5 RID: 965
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x00040784 File Offset: 0x0003E984
		public unsafe virtual RequestCachePolicy CachePolicy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47326, XrefRangeEnd = 47331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_CachePolicy_Public_Virtual_New_set_Void_RequestCachePolicy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x000407D4 File Offset: 0x0003E9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetCachePolicy(RequestCachePolicy policy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(policy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_InternalSetCachePolicy_Private_Void_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00040818 File Offset: 0x0003EA18
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x0004085C File Offset: 0x0003EA5C
		public unsafe virtual string Method
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47331, XrefRangeEnd = 47334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47334, XrefRangeEnd = 47337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x000408AC File Offset: 0x0003EAAC
		public unsafe virtual Uri RequestUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47337, XrefRangeEnd = 47340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_New_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x000408F8 File Offset: 0x0003EAF8
		public unsafe virtual WebHeaderCollection Headers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47340, XrefRangeEnd = 47343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_New_get_WebHeaderCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x00040944 File Offset: 0x0003EB44
		public unsafe virtual long ContentLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47343, XrefRangeEnd = 47346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x0004098C File Offset: 0x0003EB8C
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x000409D8 File Offset: 0x0003EBD8
		public unsafe virtual ICredentials Credentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47346, XrefRangeEnd = 47349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_New_get_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47349, XrefRangeEnd = 47352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_New_set_Void_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00040A28 File Offset: 0x0003EC28
		public unsafe virtual bool UseDefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47352, XrefRangeEnd = 47355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00040A70 File Offset: 0x0003EC70
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x00040ABC File Offset: 0x0003ECBC
		public unsafe virtual IWebProxy Proxy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47355, XrefRangeEnd = 47358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_New_get_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47358, XrefRangeEnd = 47361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_New_set_Void_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00040B0C File Offset: 0x0003ED0C
		public unsafe virtual int Timeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47361, XrefRangeEnd = 47364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00040B54 File Offset: 0x0003ED54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47364, XrefRangeEnd = 47367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WebResponse GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_New_WebResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00040BA0 File Offset: 0x0003EDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47367, XrefRangeEnd = 47370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAsyncResult BeginGetResponse(AsyncCallback callback, Object state)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00040C10 File Offset: 0x0003EE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47370, XrefRangeEnd = 47373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_New_WebResponse_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
			}
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00040C6C File Offset: 0x0003EE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47373, XrefRangeEnd = 47414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<WebResponse> GetResponseAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_GetResponseAsync_Public_Virtual_New_Task_1_WebResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebResponse>>(intPtr3) : null;
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00040CB8 File Offset: 0x0003EEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47414, XrefRangeEnd = 47418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowsIdentity SafeCaptureIdenity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_SafeCaptureIdenity_Private_WindowsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WindowsIdentity>(intPtr3) : null;
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00040CF8 File Offset: 0x0003EEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47418, XrefRangeEnd = 47421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x00040D34 File Offset: 0x0003EF34
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x00040D74 File Offset: 0x0003EF74
		public unsafe RequestCacheProtocol CacheProtocol
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_get_CacheProtocol_Internal_get_RequestCacheProtocol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestCacheProtocol>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_set_CacheProtocol_Internal_set_Void_RequestCacheProtocol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00040DB8 File Offset: 0x0003EFB8
		public unsafe static IWebProxy InternalDefaultWebProxy
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 47449, RefRangeEnd = 47452, XrefRangeStart = 47421, XrefRangeEnd = 47449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_get_InternalDefaultWebProxy_Internal_Static_get_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00040DEC File Offset: 0x0003EFEC
		public unsafe static IWebProxy DefaultWebProxy
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 47456, RefRangeEnd = 47459, XrefRangeStart = 47452, XrefRangeEnd = 47456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_get_DefaultWebProxy_Public_Static_get_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00040E20 File Offset: 0x0003F020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47459, XrefRangeEnd = 47488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebResponse> _GetResponseAsync_b__79_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr__GetResponseAsync_b__79_0_Private_Task_1_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebResponse>>(intPtr3) : null;
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00006EB7 File Offset: 0x000050B7
		public WebRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00040E60 File Offset: 0x0003F060
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x00006EC0 File Offset: 0x000050C0
		public unsafe static ArrayList s_PrefixList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_s_PrefixList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_s_PrefixList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00040E88 File Offset: 0x0003F088
		// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x00006ED2 File Offset: 0x000050D2
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00040EB0 File Offset: 0x0003F0B0
		// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x00006EE4 File Offset: 0x000050E4
		public unsafe static TimerThread.Queue s_DefaultTimerQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_s_DefaultTimerQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.Queue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_s_DefaultTimerQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x00040ED8 File Offset: 0x0003F0D8
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x00006EF6 File Offset: 0x000050F6
		public unsafe AuthenticationLevel m_AuthenticationLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_AuthenticationLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_AuthenticationLevel)) = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x00040F00 File Offset: 0x0003F100
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x00006F11 File Offset: 0x00005111
		public unsafe TokenImpersonationLevel m_ImpersonationLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_ImpersonationLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_ImpersonationLevel)) = value;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00040F28 File Offset: 0x0003F128
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x00006F2C File Offset: 0x0000512C
		public unsafe RequestCachePolicy m_CachePolicy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CachePolicy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCachePolicy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CachePolicy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00040F58 File Offset: 0x0003F158
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x00006F4B File Offset: 0x0000514B
		public unsafe RequestCacheProtocol m_CacheProtocol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CacheProtocol);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCacheProtocol>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CacheProtocol), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00040F88 File Offset: 0x0003F188
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x00006F6A File Offset: 0x0000516A
		public unsafe RequestCacheBinding m_CacheBinding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CacheBinding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCacheBinding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CacheBinding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00040FB8 File Offset: 0x0003F1B8
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x00006F89 File Offset: 0x00005189
		public unsafe static WebRequest.DesignerWebRequestCreate webRequestCreate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_webRequestCreate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequest.DesignerWebRequestCreate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_webRequestCreate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x00040FE0 File Offset: 0x0003F1E0
		// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x00006F9B File Offset: 0x0000519B
		public unsafe static IWebProxy s_DefaultWebProxy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_s_DefaultWebProxy, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_s_DefaultWebProxy, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x00041008 File Offset: 0x0003F208
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x00006FAD File Offset: 0x000051AD
		public unsafe static bool s_DefaultWebProxyInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_s_DefaultWebProxyInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_s_DefaultWebProxyInitialized, (void*)(&value));
			}
		}

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeFieldInfoPtr_s_PrefixList;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultTimerQueue;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeFieldInfoPtr_m_AuthenticationLevel;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeFieldInfoPtr_m_ImpersonationLevel;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeFieldInfoPtr_m_CachePolicy;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheProtocol;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheBinding;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeFieldInfoPtr_webRequestCreate;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultWebProxy;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultWebProxyInitialized;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_WebRequest_Uri_Boolean_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_WebRequest_String_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_WebRequest_Uri_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefixList_Internal_Static_get_ArrayList_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_PopulatePrefixList_Private_Static_ArrayList_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_set_CachePolicy_Public_Virtual_New_set_Void_RequestCachePolicy_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetCachePolicy_Private_Void_RequestCachePolicy_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_Virtual_New_get_String_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_set_Method_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestUri_Public_Virtual_New_get_Uri_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_New_get_WebHeaderCollection_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLength_Public_Virtual_New_get_Int64_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_New_get_ICredentials_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_set_Credentials_Public_Virtual_New_set_Void_ICredentials_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_get_Proxy_Public_Virtual_New_get_IWebProxy_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_set_Proxy_Public_Virtual_New_set_Void_IWebProxy_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_get_Timeout_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_New_WebResponse_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_EndGetResponse_Public_Virtual_New_WebResponse_IAsyncResult_0;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseAsync_Public_Virtual_New_Task_1_WebResponse_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_SafeCaptureIdenity_Private_WindowsIdentity_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_New_Void_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_get_CacheProtocol_Internal_get_RequestCacheProtocol_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_set_CacheProtocol_Internal_set_Void_RequestCacheProtocol_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalDefaultWebProxy_Internal_Static_get_IWebProxy_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultWebProxy_Public_Static_get_IWebProxy_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr__GetResponseAsync_b__79_0_Private_Task_1_WebResponse_0;

		// Token: 0x020001AC RID: 428
		public class DesignerWebRequestCreate : Object
		{
			// Token: 0x0600186C RID: 6252 RVA: 0x0006928C File Offset: 0x0006748C
			// Note: this type is marked as 'beforefieldinit'.
			static DesignerWebRequestCreate()
			{
				Il2CppClassPointerStore<WebRequest.DesignerWebRequestCreate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "DesignerWebRequestCreate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequest.DesignerWebRequestCreate>.NativeClassPtr);
				WebRequest.DesignerWebRequestCreate.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.DesignerWebRequestCreate>.NativeClassPtr, 100665110);
				WebRequest.DesignerWebRequestCreate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.DesignerWebRequestCreate>.NativeClassPtr, 100665111);
			}

			// Token: 0x0600186D RID: 6253 RVA: 0x000692E0 File Offset: 0x000674E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47125, XrefRangeEnd = 47129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual WebRequest Create(Uri uri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.DesignerWebRequestCreate.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
				}
			}

			// Token: 0x0600186E RID: 6254 RVA: 0x00069330 File Offset: 0x00067530
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DesignerWebRequestCreate()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequest.DesignerWebRequestCreate>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.DesignerWebRequestCreate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600186F RID: 6255 RVA: 0x0000CC99 File Offset: 0x0000AE99
			public DesignerWebRequestCreate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400135E RID: 4958
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0;

			// Token: 0x0400135F RID: 4959
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001AD RID: 429
		public class WebProxyWrapperOpaque : Object
		{
			// Token: 0x06001870 RID: 6256 RVA: 0x0006936C File Offset: 0x0006756C
			// Note: this type is marked as 'beforefieldinit'.
			static WebProxyWrapperOpaque()
			{
				Il2CppClassPointerStore<WebRequest.WebProxyWrapperOpaque>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "WebProxyWrapperOpaque");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequest.WebProxyWrapperOpaque>.NativeClassPtr);
				WebRequest.WebProxyWrapperOpaque.NativeFieldInfoPtr_webProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest.WebProxyWrapperOpaque>.NativeClassPtr, "webProxy");
				WebRequest.WebProxyWrapperOpaque.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.WebProxyWrapperOpaque>.NativeClassPtr, 100665112);
				WebRequest.WebProxyWrapperOpaque.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.WebProxyWrapperOpaque>.NativeClassPtr, 100665113);
				WebRequest.WebProxyWrapperOpaque.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.WebProxyWrapperOpaque>.NativeClassPtr, 100665114);
			}

			// Token: 0x06001871 RID: 6257 RVA: 0x000693E8 File Offset: 0x000675E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47129, XrefRangeEnd = 47131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Uri GetProxy(Uri destination)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.WebProxyWrapperOpaque.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
				}
			}

			// Token: 0x06001872 RID: 6258 RVA: 0x00069438 File Offset: 0x00067638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47131, XrefRangeEnd = 47133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool IsBypassed(Uri host)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.WebProxyWrapperOpaque.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170007D4 RID: 2004
			// (get) Token: 0x06001873 RID: 6259 RVA: 0x00069488 File Offset: 0x00067688
			public unsafe virtual ICredentials Credentials
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 47133, RefRangeEnd = 47137, XrefRangeStart = 47133, XrefRangeEnd = 47133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.WebProxyWrapperOpaque.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
				}
			}

			// Token: 0x06001874 RID: 6260 RVA: 0x0000CCA2 File Offset: 0x0000AEA2
			public WebProxyWrapperOpaque(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007D3 RID: 2003
			// (get) Token: 0x06001875 RID: 6261 RVA: 0x000694C8 File Offset: 0x000676C8
			// (set) Token: 0x06001876 RID: 6262 RVA: 0x0000CCAB File Offset: 0x0000AEAB
			public unsafe WebProxy webProxy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.WebProxyWrapperOpaque.NativeFieldInfoPtr_webProxy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebProxy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.WebProxyWrapperOpaque.NativeFieldInfoPtr_webProxy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001360 RID: 4960
			private static readonly IntPtr NativeFieldInfoPtr_webProxy;

			// Token: 0x04001361 RID: 4961
			private static readonly IntPtr NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0;

			// Token: 0x04001362 RID: 4962
			private static readonly IntPtr NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0;

			// Token: 0x04001363 RID: 4963
			private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0;
		}

		// Token: 0x020001AE RID: 430
		public class WebProxyWrapper : WebRequest.WebProxyWrapperOpaque
		{
			// Token: 0x06001877 RID: 6263 RVA: 0x0000CCCA File Offset: 0x0000AECA
			// Note: this type is marked as 'beforefieldinit'.
			static WebProxyWrapper()
			{
				Il2CppClassPointerStore<WebRequest.WebProxyWrapper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "WebProxyWrapper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequest.WebProxyWrapper>.NativeClassPtr);
				WebRequest.WebProxyWrapper.NativeMethodInfoPtr_get_WebProxy_Internal_get_WebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.WebProxyWrapper>.NativeClassPtr, 100665115);
			}

			// Token: 0x170007D5 RID: 2005
			// (get) Token: 0x06001878 RID: 6264 RVA: 0x000694F8 File Offset: 0x000676F8
			public unsafe WebProxy WebProxy
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.WebProxyWrapper.NativeMethodInfoPtr_get_WebProxy_Internal_get_WebProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebProxy>(intPtr3) : null;
				}
			}

			// Token: 0x06001879 RID: 6265 RVA: 0x0000CCFE File Offset: 0x0000AEFE
			public WebProxyWrapper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001364 RID: 4964
			private static readonly IntPtr NativeMethodInfoPtr_get_WebProxy_Internal_get_WebProxy_0;
		}

		// Token: 0x020001AF RID: 431
		[ObfuscatedName("System.Net.WebRequest+<>c__DisplayClass79_0")]
		public sealed class __c__DisplayClass79_0 : Object
		{
			// Token: 0x0600187A RID: 6266 RVA: 0x00069538 File Offset: 0x00067738
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass79_0()
			{
				Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "<>c__DisplayClass79_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr);
				WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr_currentUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr, "currentUser");
				WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr, "<>4__this");
				WebRequest.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr, 100665116);
				WebRequest.__c__DisplayClass79_0.NativeMethodInfoPtr__GetResponseAsync_b__1_Internal_Task_1_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr, 100665117);
			}

			// Token: 0x0600187B RID: 6267 RVA: 0x000695B4 File Offset: 0x000677B4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass79_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600187C RID: 6268 RVA: 0x000695F0 File Offset: 0x000677F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47137, XrefRangeEnd = 47174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<WebResponse> _GetResponseAsync_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.__c__DisplayClass79_0.NativeMethodInfoPtr__GetResponseAsync_b__1_Internal_Task_1_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebResponse>>(intPtr3) : null;
			}

			// Token: 0x0600187D RID: 6269 RVA: 0x0000CD07 File Offset: 0x0000AF07
			public __c__DisplayClass79_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007D6 RID: 2006
			// (get) Token: 0x0600187E RID: 6270 RVA: 0x00069630 File Offset: 0x00067830
			// (set) Token: 0x0600187F RID: 6271 RVA: 0x0000CD10 File Offset: 0x0000AF10
			public unsafe WindowsIdentity currentUser
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr_currentUser);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowsIdentity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr_currentUser), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D7 RID: 2007
			// (get) Token: 0x06001880 RID: 6272 RVA: 0x00069660 File Offset: 0x00067860
			// (set) Token: 0x06001881 RID: 6273 RVA: 0x0000CD2F File Offset: 0x0000AF2F
			public unsafe WebRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001365 RID: 4965
			private static readonly IntPtr NativeFieldInfoPtr_currentUser;

			// Token: 0x04001366 RID: 4966
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001367 RID: 4967
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001368 RID: 4968
			private static readonly IntPtr NativeMethodInfoPtr__GetResponseAsync_b__1_Internal_Task_1_WebResponse_0;
		}
	}
}
