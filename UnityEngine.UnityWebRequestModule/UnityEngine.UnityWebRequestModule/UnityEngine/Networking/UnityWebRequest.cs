using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnityEngineInternal;

namespace UnityEngine.Networking
{
	// Token: 0x02000006 RID: 6
	public class UnityWebRequest : Object
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00003B80 File Offset: 0x00001D80
		// Note: this type is marked as 'beforefieldinit'.
		static UnityWebRequest()
		{
			Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "UnityWebRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr);
			UnityWebRequest.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_Ptr");
			UnityWebRequest.NativeFieldInfoPtr_m_DownloadHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_DownloadHandler");
			UnityWebRequest.NativeFieldInfoPtr_m_UploadHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_UploadHandler");
			UnityWebRequest.NativeFieldInfoPtr_m_CertificateHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_CertificateHandler");
			UnityWebRequest.NativeFieldInfoPtr_m_Uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_Uri");
			UnityWebRequest.NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "<disposeCertificateHandlerOnDispose>k__BackingField");
			UnityWebRequest.NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "<disposeDownloadHandlerOnDispose>k__BackingField");
			UnityWebRequest.NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "<disposeUploadHandlerOnDispose>k__BackingField");
			UnityWebRequest.NativeMethodInfoPtr_GetWebErrorString_Private_Static_String_UnityWebRequestError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663327);
			UnityWebRequest.NativeMethodInfoPtr_GetHTTPStatusString_Internal_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663328);
			UnityWebRequest.NativeMethodInfoPtr_get_disposeCertificateHandlerOnDispose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663329);
			UnityWebRequest.NativeMethodInfoPtr_set_disposeCertificateHandlerOnDispose_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663330);
			UnityWebRequest.NativeMethodInfoPtr_get_disposeDownloadHandlerOnDispose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663331);
			UnityWebRequest.NativeMethodInfoPtr_set_disposeDownloadHandlerOnDispose_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663332);
			UnityWebRequest.NativeMethodInfoPtr_get_disposeUploadHandlerOnDispose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663333);
			UnityWebRequest.NativeMethodInfoPtr_set_disposeUploadHandlerOnDispose_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663334);
			UnityWebRequest.NativeMethodInfoPtr_Create_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663335);
			UnityWebRequest.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663336);
			UnityWebRequest.NativeMethodInfoPtr_InternalDestroy_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663337);
			UnityWebRequest.NativeMethodInfoPtr_InternalSetDefaults_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663338);
			UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663339);
			UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_DownloadHandler_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663340);
			UnityWebRequest.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663341);
			UnityWebRequest.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663342);
			UnityWebRequest.NativeMethodInfoPtr_DisposeHandlers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663343);
			UnityWebRequest.NativeMethodInfoPtr_BeginWebRequest_Internal_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663344);
			UnityWebRequest.NativeMethodInfoPtr_SendWebRequest_Public_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663345);
			UnityWebRequest.NativeMethodInfoPtr_Abort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663346);
			UnityWebRequest.NativeMethodInfoPtr_SetMethod_Private_UnityWebRequestError_UnityWebRequestMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663347);
			UnityWebRequest.NativeMethodInfoPtr_InternalSetMethod_Internal_Void_UnityWebRequestMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663348);
			UnityWebRequest.NativeMethodInfoPtr_SetCustomMethod_Private_UnityWebRequestError_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663349);
			UnityWebRequest.NativeMethodInfoPtr_InternalSetCustomMethod_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663350);
			UnityWebRequest.NativeMethodInfoPtr_set_method_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663351);
			UnityWebRequest.NativeMethodInfoPtr_GetError_Private_UnityWebRequestError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663352);
			UnityWebRequest.NativeMethodInfoPtr_get_error_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663353);
			UnityWebRequest.NativeMethodInfoPtr_get_url_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663354);
			UnityWebRequest.NativeMethodInfoPtr_set_url_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663355);
			UnityWebRequest.NativeMethodInfoPtr_GetUrl_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663356);
			UnityWebRequest.NativeMethodInfoPtr_SetUrl_Private_UnityWebRequestError_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663357);
			UnityWebRequest.NativeMethodInfoPtr_InternalSetUrl_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663358);
			UnityWebRequest.NativeMethodInfoPtr_get_responseCode_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663359);
			UnityWebRequest.NativeMethodInfoPtr_get_isModifiable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663360);
			UnityWebRequest.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663361);
			UnityWebRequest.NativeMethodInfoPtr_get_result_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663362);
			UnityWebRequest.NativeMethodInfoPtr_SetChunked_Private_UnityWebRequestError_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663363);
			UnityWebRequest.NativeMethodInfoPtr_set_chunkedTransfer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663364);
			UnityWebRequest.NativeMethodInfoPtr_InternalSetRequestHeader_Internal_UnityWebRequestError_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663365);
			UnityWebRequest.NativeMethodInfoPtr_SetRequestHeader_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663366);
			UnityWebRequest.NativeMethodInfoPtr_SetUploadHandler_Private_UnityWebRequestError_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663367);
			UnityWebRequest.NativeMethodInfoPtr_get_uploadHandler_Public_get_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663368);
			UnityWebRequest.NativeMethodInfoPtr_set_uploadHandler_Public_set_Void_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663369);
			UnityWebRequest.NativeMethodInfoPtr_SetDownloadHandler_Private_UnityWebRequestError_DownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663370);
			UnityWebRequest.NativeMethodInfoPtr_get_downloadHandler_Public_get_DownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663371);
			UnityWebRequest.NativeMethodInfoPtr_set_downloadHandler_Public_set_Void_DownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663372);
			UnityWebRequest.NativeMethodInfoPtr_get_certificateHandler_Public_get_CertificateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663373);
			UnityWebRequest.NativeMethodInfoPtr_SetTimeoutMsec_Private_UnityWebRequestError_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663374);
			UnityWebRequest.NativeMethodInfoPtr_set_timeout_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663375);
			UnityWebRequest.NativeMethodInfoPtr_Get_Public_Static_UnityWebRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663376);
			UnityWebRequest.NativeMethodInfoPtr_Post_Public_Static_UnityWebRequest_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663377);
			UnityWebRequest.NativeMethodInfoPtr_SetupPost_Private_Static_Void_UnityWebRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663378);
			UnityWebRequest.NativeMethodInfoPtr_Post_Public_Static_UnityWebRequest_String_WWWForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663379);
			UnityWebRequest.NativeMethodInfoPtr_SetupPost_Private_Static_Void_UnityWebRequest_WWWForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663380);
			UnityWebRequest.NativeMethodInfoPtr_EscapeURL_Public_Static_String_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663381);
			UnityWebRequest.ClearCookieCacheDelegateField = IL2CPP.ResolveICall<UnityWebRequest.ClearCookieCacheDelegate>("UnityEngine.Networking.UnityWebRequest::ClearCookieCache");
			UnityWebRequest.GetMethodDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetMethodDelegate>("UnityEngine.Networking.UnityWebRequest::GetMethod");
			UnityWebRequest.GetCustomMethodDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetCustomMethodDelegate>("UnityEngine.Networking.UnityWebRequest::GetCustomMethod");
			UnityWebRequest.get_use100ContinueDelegateField = IL2CPP.ResolveICall<UnityWebRequest.get_use100ContinueDelegate>("UnityEngine.Networking.UnityWebRequest::get_use100Continue");
			UnityWebRequest.set_use100ContinueDelegateField = IL2CPP.ResolveICall<UnityWebRequest.set_use100ContinueDelegate>("UnityEngine.Networking.UnityWebRequest::set_use100Continue");
			UnityWebRequest.GetUploadProgressDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetUploadProgressDelegate>("UnityEngine.Networking.UnityWebRequest::GetUploadProgress");
			UnityWebRequest.IsExecutingDelegateField = IL2CPP.ResolveICall<UnityWebRequest.IsExecutingDelegate>("UnityEngine.Networking.UnityWebRequest::IsExecuting");
			UnityWebRequest.GetDownloadProgressDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetDownloadProgressDelegate>("UnityEngine.Networking.UnityWebRequest::GetDownloadProgress");
			UnityWebRequest.get_uploadedBytesDelegateField = IL2CPP.ResolveICall<UnityWebRequest.get_uploadedBytesDelegate>("UnityEngine.Networking.UnityWebRequest::get_uploadedBytes");
			UnityWebRequest.get_downloadedBytesDelegateField = IL2CPP.ResolveICall<UnityWebRequest.get_downloadedBytesDelegate>("UnityEngine.Networking.UnityWebRequest::get_downloadedBytes");
			UnityWebRequest.GetRedirectLimitDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetRedirectLimitDelegate>("UnityEngine.Networking.UnityWebRequest::GetRedirectLimit");
			UnityWebRequest.SetRedirectLimitFromScriptingDelegateField = IL2CPP.ResolveICall<UnityWebRequest.SetRedirectLimitFromScriptingDelegate>("UnityEngine.Networking.UnityWebRequest::SetRedirectLimitFromScripting");
			UnityWebRequest.GetChunkedDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetChunkedDelegate>("UnityEngine.Networking.UnityWebRequest::GetChunked");
			UnityWebRequest.GetRequestHeaderDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetRequestHeaderDelegate>("UnityEngine.Networking.UnityWebRequest::GetRequestHeader");
			UnityWebRequest.GetResponseHeaderDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetResponseHeaderDelegate>("UnityEngine.Networking.UnityWebRequest::GetResponseHeader");
			UnityWebRequest.GetResponseHeaderKeysDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetResponseHeaderKeysDelegate>("UnityEngine.Networking.UnityWebRequest::GetResponseHeaderKeys");
			UnityWebRequest.SetCertificateHandlerDelegateField = IL2CPP.ResolveICall<UnityWebRequest.SetCertificateHandlerDelegate>("UnityEngine.Networking.UnityWebRequest::SetCertificateHandler");
			UnityWebRequest.GetTimeoutMsecDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetTimeoutMsecDelegate>("UnityEngine.Networking.UnityWebRequest::GetTimeoutMsec");
			UnityWebRequest.GetSuppressErrorsToConsoleDelegateField = IL2CPP.ResolveICall<UnityWebRequest.GetSuppressErrorsToConsoleDelegate>("UnityEngine.Networking.UnityWebRequest::GetSuppressErrorsToConsole");
			UnityWebRequest.SetSuppressErrorsToConsoleDelegateField = IL2CPP.ResolveICall<UnityWebRequest.SetSuppressErrorsToConsoleDelegate>("UnityEngine.Networking.UnityWebRequest::SetSuppressErrorsToConsole");
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000041C8 File Offset: 0x000023C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124406, XrefRangeEnd = 124408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref err;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetWebErrorString_Private_Static_String_UnityWebRequestError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004200 File Offset: 0x00002400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124410, RefRangeEnd = 124411, XrefRangeStart = 124408, XrefRangeEnd = 124410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetHTTPStatusString(long responseCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref responseCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetHTTPStatusString_Internal_Static_String_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00004238 File Offset: 0x00002438
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00004274 File Offset: 0x00002474
		public unsafe bool disposeCertificateHandlerOnDispose
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_disposeCertificateHandlerOnDispose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_disposeCertificateHandlerOnDispose_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000042B4 File Offset: 0x000024B4
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000042F0 File Offset: 0x000024F0
		public unsafe bool disposeDownloadHandlerOnDispose
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_disposeDownloadHandlerOnDispose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_disposeDownloadHandlerOnDispose_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00004330 File Offset: 0x00002530
		// (set) Token: 0x0600006F RID: 111 RVA: 0x0000436C File Offset: 0x0000256C
		public unsafe bool disposeUploadHandlerOnDispose
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_disposeUploadHandlerOnDispose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_disposeUploadHandlerOnDispose_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000043AC File Offset: 0x000025AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124411, XrefRangeEnd = 124413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Create_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000043DC File Offset: 0x000025DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124413, XrefRangeEnd = 124415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004410 File Offset: 0x00002610
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124421, RefRangeEnd = 124423, XrefRangeStart = 124415, XrefRangeEnd = 124421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalDestroy_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004444 File Offset: 0x00002644
		[CallerCount(0)]
		public unsafe void InternalSetDefaults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalSetDefaults_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004478 File Offset: 0x00002678
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 124428, RefRangeEnd = 124431, XrefRangeStart = 124423, XrefRangeEnd = 124428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest(string url, string method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000044D8 File Offset: 0x000026D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124431, XrefRangeEnd = 124438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(downloadHandler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uploadHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_DownloadHandler_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000455C File Offset: 0x0000275C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124438, XrefRangeEnd = 124443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityWebRequest.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004598 File Offset: 0x00002798
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124449, RefRangeEnd = 124451, XrefRangeStart = 124443, XrefRangeEnd = 124449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000045CC File Offset: 0x000027CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124455, RefRangeEnd = 124457, XrefRangeStart = 124451, XrefRangeEnd = 124455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeHandlers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_DisposeHandlers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004600 File Offset: 0x00002800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124457, XrefRangeEnd = 124459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequestAsyncOperation BeginWebRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_BeginWebRequest_Internal_UnityWebRequestAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequestAsyncOperation>(intPtr3) : null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004640 File Offset: 0x00002840
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 124461, RefRangeEnd = 124469, XrefRangeStart = 124459, XrefRangeEnd = 124461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequestAsyncOperation SendWebRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SendWebRequest_Public_UnityWebRequestAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequestAsyncOperation>(intPtr3) : null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004680 File Offset: 0x00002880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124469, XrefRangeEnd = 124471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Abort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000046B4 File Offset: 0x000028B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124471, XrefRangeEnd = 124473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref methodType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetMethod_Private_UnityWebRequestError_UnityWebRequestMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004700 File Offset: 0x00002900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124477, RefRangeEnd = 124478, XrefRangeStart = 124473, XrefRangeEnd = 124477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref methodType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalSetMethod_Internal_Void_UnityWebRequestMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004740 File Offset: 0x00002940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124478, XrefRangeEnd = 124480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(customMethodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetCustomMethod_Private_UnityWebRequestError_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004790 File Offset: 0x00002990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124480, XrefRangeEnd = 124484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetCustomMethod(string customMethodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(customMethodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalSetCustomMethod_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00005234 File Offset: 0x00003434
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000047D4 File Offset: 0x000029D4
		public unsafe string method
		{
			get
			{
				string text;
				switch (this.GetMethod())
				{
				case UnityWebRequest.UnityWebRequestMethod.Get:
					text = "GET";
					break;
				case UnityWebRequest.UnityWebRequestMethod.Post:
					text = "POST";
					break;
				case UnityWebRequest.UnityWebRequestMethod.Put:
					text = "PUT";
					break;
				case UnityWebRequest.UnityWebRequestMethod.Head:
					text = "HEAD";
					break;
				default:
					text = this.GetCustomMethod();
					break;
				}
				return text;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 124493, RefRangeEnd = 124496, XrefRangeStart = 124484, XrefRangeEnd = 124493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_method_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004818 File Offset: 0x00002A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124496, XrefRangeEnd = 124498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError GetError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetError_Private_UnityWebRequestError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00004854 File Offset: 0x00002A54
		public unsafe string error
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 124502, RefRangeEnd = 124506, XrefRangeStart = 124498, XrefRangeEnd = 124502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_error_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000488C File Offset: 0x00002A8C
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000048C4 File Offset: 0x00002AC4
		public unsafe string url
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 124508, RefRangeEnd = 124515, XrefRangeStart = 124506, XrefRangeEnd = 124508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_url_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 124525, RefRangeEnd = 124528, XrefRangeStart = 124515, XrefRangeEnd = 124525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_url_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004908 File Offset: 0x00002B08
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 124508, RefRangeEnd = 124515, XrefRangeStart = 124508, XrefRangeEnd = 124515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUrl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_GetUrl_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004940 File Offset: 0x00002B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124528, XrefRangeEnd = 124530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetUrl(string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetUrl_Private_UnityWebRequestError_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004990 File Offset: 0x00002B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124530, XrefRangeEnd = 124534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetUrl(string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalSetUrl_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000049D4 File Offset: 0x00002BD4
		public unsafe long responseCode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 124536, RefRangeEnd = 124539, XrefRangeStart = 124534, XrefRangeEnd = 124536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_responseCode_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00004A10 File Offset: 0x00002C10
		public unsafe bool isModifiable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124539, XrefRangeEnd = 124541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_isModifiable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00004A4C File Offset: 0x00002C4C
		public unsafe bool isDone
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 124543, RefRangeEnd = 124548, XrefRangeStart = 124541, XrefRangeEnd = 124543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00004A88 File Offset: 0x00002C88
		public unsafe UnityWebRequest.Result result
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 124550, RefRangeEnd = 124556, XrefRangeStart = 124548, XrefRangeEnd = 124550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_result_Public_get_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00004AC4 File Offset: 0x00002CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124556, XrefRangeEnd = 124558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetChunked(bool chunked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref chunked;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetChunked_Private_UnityWebRequestError_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000053FC File Offset: 0x000035FC
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00004B10 File Offset: 0x00002D10
		public unsafe bool chunkedTransfer
		{
			get
			{
				return this.GetChunked();
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 124562, RefRangeEnd = 124564, XrefRangeStart = 124558, XrefRangeEnd = 124562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_chunkedTransfer_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004B50 File Offset: 0x00002D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124564, XrefRangeEnd = 124566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_InternalSetRequestHeader_Internal_UnityWebRequestError_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004BB0 File Offset: 0x00002DB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124571, RefRangeEnd = 124572, XrefRangeStart = 124566, XrefRangeEnd = 124571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRequestHeader(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetRequestHeader_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004C04 File Offset: 0x00002E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124572, XrefRangeEnd = 124574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetUploadHandler_Private_UnityWebRequestError_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00004C54 File Offset: 0x00002E54
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00004C94 File Offset: 0x00002E94
		public unsafe UploadHandler uploadHandler
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 80223, RefRangeEnd = 80226, XrefRangeStart = 80223, XrefRangeEnd = 80226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_uploadHandler_Public_get_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UploadHandler>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 124578, RefRangeEnd = 124583, XrefRangeStart = 124574, XrefRangeEnd = 124578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_uploadHandler_Public_set_Void_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00004CD8 File Offset: 0x00002ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124583, XrefRangeEnd = 124585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetDownloadHandler_Private_UnityWebRequestError_DownloadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00004D28 File Offset: 0x00002F28
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00004D68 File Offset: 0x00002F68
		public unsafe DownloadHandler downloadHandler
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79925, RefRangeEnd = 79936, XrefRangeStart = 79925, XrefRangeEnd = 79936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_downloadHandler_Public_get_DownloadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DownloadHandler>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 124589, RefRangeEnd = 124594, XrefRangeStart = 124585, XrefRangeEnd = 124589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_downloadHandler_Public_set_Void_DownloadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00004DAC File Offset: 0x00002FAC
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00005498 File Offset: 0x00003698
		public unsafe CertificateHandler certificateHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_get_certificateHandler_Public_get_CertificateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CertificateHandler>(intPtr3) : null;
			}
			set
			{
				bool flag = !this.isModifiable;
				if (flag)
				{
					throw new InvalidOperationException("UnityWebRequest has already been sent; cannot modify the certificate handler");
				}
				UnityWebRequest.UnityWebRequestError unityWebRequestError = this.SetCertificateHandler(value);
				bool flag2 = unityWebRequestError > UnityWebRequest.UnityWebRequestError.OK;
				if (flag2)
				{
					throw new InvalidOperationException(UnityWebRequest.GetWebErrorString(unityWebRequestError));
				}
				this.m_CertificateHandler = value;
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004DEC File Offset: 0x00002FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124594, XrefRangeEnd = 124596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetTimeoutMsec_Private_UnityWebRequestError_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000054E4 File Offset: 0x000036E4
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00004E38 File Offset: 0x00003038
		public unsafe int timeout
		{
			get
			{
				return this.GetTimeoutMsec() / 1000;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 124604, RefRangeEnd = 124606, XrefRangeStart = 124596, XrefRangeEnd = 124604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_set_timeout_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004E78 File Offset: 0x00003078
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 124624, RefRangeEnd = 124629, XrefRangeStart = 124606, XrefRangeEnd = 124624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest Get(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Get_Public_Static_UnityWebRequest_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004EBC File Offset: 0x000030BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124636, RefRangeEnd = 124637, XrefRangeStart = 124629, XrefRangeEnd = 124636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest Post(string uri, string postData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(postData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Post_Public_Static_UnityWebRequest_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004F14 File Offset: 0x00003114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124666, RefRangeEnd = 124667, XrefRangeStart = 124637, XrefRangeEnd = 124666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupPost(UnityWebRequest request, string postData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(postData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetupPost_Private_Static_Void_UnityWebRequest_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00004F5C File Offset: 0x0000315C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124674, RefRangeEnd = 124675, XrefRangeStart = 124667, XrefRangeEnd = 124674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest Post(string uri, WWWForm formData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_Post_Public_Static_UnityWebRequest_String_WWWForm_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004FB4 File Offset: 0x000031B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124729, RefRangeEnd = 124730, XrefRangeStart = 124675, XrefRangeEnd = 124729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupPost(UnityWebRequest request, WWWForm formData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_SetupPost_Private_Static_Void_UnityWebRequest_WWWForm_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004FFC File Offset: 0x000031FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124743, RefRangeEnd = 124745, XrefRangeStart = 124730, XrefRangeEnd = 124743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EscapeURL(string s, Encoding e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequest.NativeMethodInfoPtr_EscapeURL_Public_Static_String_String_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000022AD File Offset: 0x000004AD
		public UnityWebRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000504C File Offset: 0x0000324C
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x000022B6 File Offset: 0x000004B6
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00005074 File Offset: 0x00003274
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000022D1 File Offset: 0x000004D1
		public unsafe DownloadHandler m_DownloadHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_DownloadHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DownloadHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_DownloadHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000050A4 File Offset: 0x000032A4
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x000022F0 File Offset: 0x000004F0
		public unsafe UploadHandler m_UploadHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_UploadHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UploadHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_UploadHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000050D4 File Offset: 0x000032D4
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000230F File Offset: 0x0000050F
		public unsafe CertificateHandler m_CertificateHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_CertificateHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CertificateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_CertificateHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00005104 File Offset: 0x00003304
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000232E File Offset: 0x0000052E
		public unsafe Uri m_Uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_Uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr_m_Uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00005134 File Offset: 0x00003334
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000234D File Offset: 0x0000054D
		public unsafe bool _disposeCertificateHandlerOnDispose_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField)) = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000515C File Offset: 0x0000335C
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002368 File Offset: 0x00000568
		public unsafe bool _disposeDownloadHandlerOnDispose_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00005184 File Offset: 0x00003384
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002383 File Offset: 0x00000583
		public unsafe bool _disposeUploadHandlerOnDispose_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequest.NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField)) = value;
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000239E File Offset: 0x0000059E
		public static void ClearCookieCache()
		{
			UnityWebRequest.ClearCookieCache(null, null);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000051AC File Offset: 0x000033AC
		public static void ClearCookieCache(Uri uri)
		{
			bool flag = uri == null;
			if (flag)
			{
				UnityWebRequest.ClearCookieCache(null, null);
			}
			else
			{
				string host = uri.Host;
				string text = uri.AbsolutePath;
				bool flag2 = text == "/";
				if (flag2)
				{
					text = null;
				}
				UnityWebRequest.ClearCookieCache(host, text);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000023A9 File Offset: 0x000005A9
		public static void ClearCookieCache(string domain, string path)
		{
			UnityWebRequest.ClearCookieCacheDelegateField(IL2CPP.ManagedStringToIl2Cpp(domain), IL2CPP.ManagedStringToIl2Cpp(path));
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000051F8 File Offset: 0x000033F8
		public AsyncOperation Send()
		{
			return this.SendWebRequest();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000023C1 File Offset: 0x000005C1
		public UnityWebRequest.UnityWebRequestMethod GetMethod()
		{
			return UnityWebRequest.GetMethodDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00005210 File Offset: 0x00003410
		public string GetCustomMethod()
		{
			IntPtr intPtr = UnityWebRequest.GetCustomMethodDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000023D3 File Offset: 0x000005D3
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000023E5 File Offset: 0x000005E5
		public bool use100Continue
		{
			get
			{
				return UnityWebRequest.get_use100ContinueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				UnityWebRequest.set_use100ContinueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00005290 File Offset: 0x00003490
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000052A8 File Offset: 0x000034A8
		public bool useHttpContinue
		{
			get
			{
				return this.use100Continue;
			}
			set
			{
				bool flag = !this.isModifiable;
				if (flag)
				{
					throw new InvalidOperationException("UnityWebRequest has already been sent and its 100-Continue setting cannot be altered");
				}
				this.use100Continue = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000052D8 File Offset: 0x000034D8
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000052F8 File Offset: 0x000034F8
		public Uri uri
		{
			get
			{
				return new Uri(this.GetUrl());
			}
			set
			{
				bool flag = !value.IsAbsoluteUri;
				if (flag)
				{
					throw new ArgumentException("URI must be absolute");
				}
				this.InternalSetUrl(global::UnityEngineInternal.WebRequestUtils.MakeUriString(value, value.OriginalString, false));
				this.m_Uri = value;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000023F8 File Offset: 0x000005F8
		public float GetUploadProgress()
		{
			return UnityWebRequest.GetUploadProgressDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000240A File Offset: 0x0000060A
		public bool IsExecuting()
		{
			return UnityWebRequest.IsExecutingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000533C File Offset: 0x0000353C
		public float uploadProgress
		{
			get
			{
				bool flag = !this.IsExecuting() && !this.isDone;
				float num;
				if (flag)
				{
					num = -1f;
				}
				else
				{
					num = this.GetUploadProgress();
				}
				return num;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00005374 File Offset: 0x00003574
		public bool isNetworkError
		{
			get
			{
				return this.result == UnityWebRequest.Result.ConnectionError;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00005390 File Offset: 0x00003590
		public bool isHttpError
		{
			get
			{
				return this.result == UnityWebRequest.Result.ProtocolError;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000241C File Offset: 0x0000061C
		public float GetDownloadProgress()
		{
			return UnityWebRequest.GetDownloadProgressDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000053AC File Offset: 0x000035AC
		public float downloadProgress
		{
			get
			{
				bool flag = !this.IsExecuting() && !this.isDone;
				float num;
				if (flag)
				{
					num = -1f;
				}
				else
				{
					num = this.GetDownloadProgress();
				}
				return num;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000242E File Offset: 0x0000062E
		public ulong uploadedBytes
		{
			get
			{
				return UnityWebRequest.get_uploadedBytesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002440 File Offset: 0x00000640
		public ulong downloadedBytes
		{
			get
			{
				return UnityWebRequest.get_downloadedBytesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002452 File Offset: 0x00000652
		public int GetRedirectLimit()
		{
			return UnityWebRequest.GetRedirectLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002464 File Offset: 0x00000664
		public void SetRedirectLimitFromScripting(int limit)
		{
			UnityWebRequest.SetRedirectLimitFromScriptingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), limit);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000053E4 File Offset: 0x000035E4
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002477 File Offset: 0x00000677
		public int redirectLimit
		{
			get
			{
				return this.GetRedirectLimit();
			}
			set
			{
				this.SetRedirectLimitFromScripting(value);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002482 File Offset: 0x00000682
		public bool GetChunked()
		{
			return UnityWebRequest.GetChunkedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005414 File Offset: 0x00003614
		public string GetRequestHeader(string name)
		{
			IntPtr intPtr = UnityWebRequest.GetRequestHeaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005440 File Offset: 0x00003640
		public string GetResponseHeader(string name)
		{
			IntPtr intPtr = UnityWebRequest.GetResponseHeaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000546C File Offset: 0x0000366C
		public Il2CppStringArray GetResponseHeaderKeys()
		{
			IntPtr intPtr = UnityWebRequest.GetResponseHeaderKeysDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002494 File Offset: 0x00000694
		public Dictionary<string, string> GetResponseHeaders()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000024A1 File Offset: 0x000006A1
		public UnityWebRequest.UnityWebRequestError SetCertificateHandler(CertificateHandler ch)
		{
			return UnityWebRequest.SetCertificateHandlerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(ch));
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000024B9 File Offset: 0x000006B9
		public int GetTimeoutMsec()
		{
			return UnityWebRequest.GetTimeoutMsecDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000024CB File Offset: 0x000006CB
		public bool GetSuppressErrorsToConsole()
		{
			return UnityWebRequest.GetSuppressErrorsToConsoleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000024DD File Offset: 0x000006DD
		public UnityWebRequest.UnityWebRequestError SetSuppressErrorsToConsole(bool suppress)
		{
			return UnityWebRequest.SetSuppressErrorsToConsoleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), suppress);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00005504 File Offset: 0x00003704
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000551C File Offset: 0x0000371C
		public bool suppressErrorsToConsole
		{
			get
			{
				return this.GetSuppressErrorsToConsole();
			}
			set
			{
				bool flag = !this.isModifiable;
				if (flag)
				{
					throw new InvalidOperationException("UnityWebRequest has already been sent; cannot modify the timeout");
				}
				UnityWebRequest.UnityWebRequestError unityWebRequestError = this.SetSuppressErrorsToConsole(value);
				bool flag2 = unityWebRequestError > UnityWebRequest.UnityWebRequestError.OK;
				if (flag2)
				{
					throw new InvalidOperationException(UnityWebRequest.GetWebErrorString(unityWebRequestError));
				}
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005560 File Offset: 0x00003760
		public static UnityWebRequest Get(Uri uri)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerBuffer(), null);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005588 File Offset: 0x00003788
		public static UnityWebRequest Delete(string uri)
		{
			return new UnityWebRequest(uri, "DELETE");
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000055A8 File Offset: 0x000037A8
		public static UnityWebRequest Delete(Uri uri)
		{
			return new UnityWebRequest(uri, "DELETE");
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000055C8 File Offset: 0x000037C8
		public static UnityWebRequest Head(string uri)
		{
			return new UnityWebRequest(uri, "HEAD");
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000055E8 File Offset: 0x000037E8
		public static UnityWebRequest Head(Uri uri)
		{
			return new UnityWebRequest(uri, "HEAD");
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000024F0 File Offset: 0x000006F0
		public static UnityWebRequest GetTexture(string uri)
		{
			throw new NotSupportedException("UnityWebRequest.GetTexture is obsolete. Use UnityWebRequestTexture.GetTexture instead.");
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000024FD File Offset: 0x000006FD
		public static UnityWebRequest GetTexture(string uri, bool nonReadable)
		{
			throw new NotSupportedException("UnityWebRequest.GetTexture is obsolete. Use UnityWebRequestTexture.GetTexture instead.");
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00005608 File Offset: 0x00003808
		public static UnityWebRequest GetAudioClip(string uri, AudioType audioType)
		{
			return null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000561C File Offset: 0x0000381C
		public static UnityWebRequest GetAssetBundle(string uri)
		{
			return null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005630 File Offset: 0x00003830
		public static UnityWebRequest GetAssetBundle(string uri, uint crc)
		{
			return null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00005644 File Offset: 0x00003844
		public static UnityWebRequest GetAssetBundle(string uri, uint version, uint crc)
		{
			return null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005658 File Offset: 0x00003858
		public static UnityWebRequest Put(string uri, Il2CppStructArray<byte> bodyData)
		{
			return new UnityWebRequest(uri, "PUT", new DownloadHandlerBuffer(), new UploadHandlerRaw(bodyData));
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005684 File Offset: 0x00003884
		public static UnityWebRequest Put(Uri uri, Il2CppStructArray<byte> bodyData)
		{
			return new UnityWebRequest(uri, "PUT", new DownloadHandlerBuffer(), new UploadHandlerRaw(bodyData));
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000056B0 File Offset: 0x000038B0
		public static UnityWebRequest Put(string uri, string bodyData)
		{
			return new UnityWebRequest(uri, "PUT", new DownloadHandlerBuffer(), new UploadHandlerRaw(Encoding.UTF8.GetBytes(bodyData)));
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000056E4 File Offset: 0x000038E4
		public static UnityWebRequest Put(Uri uri, string bodyData)
		{
			return new UnityWebRequest(uri, "PUT", new DownloadHandlerBuffer(), new UploadHandlerRaw(Encoding.UTF8.GetBytes(bodyData)));
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00005718 File Offset: 0x00003918
		public static UnityWebRequest Post(Uri uri, string postData)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, postData);
			return unityWebRequest;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00005740 File Offset: 0x00003940
		public static UnityWebRequest Post(Uri uri, WWWForm formData)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, formData);
			return unityWebRequest;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00005768 File Offset: 0x00003968
		public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections)
		{
			Il2CppStructArray<byte> il2CppStructArray = UnityWebRequest.GenerateBoundary();
			return UnityWebRequest.Post(uri, multipartFormSections, il2CppStructArray);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005788 File Offset: 0x00003988
		public static UnityWebRequest Post(Uri uri, List<IMultipartFormSection> multipartFormSections)
		{
			Il2CppStructArray<byte> il2CppStructArray = UnityWebRequest.GenerateBoundary();
			return UnityWebRequest.Post(uri, multipartFormSections, il2CppStructArray);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000057A8 File Offset: 0x000039A8
		public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections, Il2CppStructArray<byte> boundary)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, multipartFormSections, boundary);
			return unityWebRequest;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000057D0 File Offset: 0x000039D0
		public static UnityWebRequest Post(Uri uri, List<IMultipartFormSection> multipartFormSections, Il2CppStructArray<byte> boundary)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, multipartFormSections, boundary);
			return unityWebRequest;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000057F8 File Offset: 0x000039F8
		public static void SetupPost(UnityWebRequest request, List<IMultipartFormSection> multipartFormSections, Il2CppStructArray<byte> boundary)
		{
			request.downloadHandler = new DownloadHandlerBuffer();
			Il2CppStructArray<byte> il2CppStructArray = null;
			bool flag = multipartFormSections != null && multipartFormSections.Count != 0;
			if (flag)
			{
				il2CppStructArray = UnityWebRequest.SerializeFormSections(multipartFormSections, boundary);
			}
			bool flag2 = il2CppStructArray == null;
			if (!flag2)
			{
				request.uploadHandler = new UploadHandlerRaw(il2CppStructArray)
				{
					contentType = String.Concat("multipart/form-data; boundary=", Encoding.UTF8.GetString(boundary, 0, boundary.Length))
				};
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000586C File Offset: 0x00003A6C
		public static UnityWebRequest Post(string uri, Dictionary<string, string> formFields)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, formFields);
			return unityWebRequest;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00005894 File Offset: 0x00003A94
		public static UnityWebRequest Post(Uri uri, Dictionary<string, string> formFields)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			UnityWebRequest.SetupPost(unityWebRequest, formFields);
			return unityWebRequest;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000058BC File Offset: 0x00003ABC
		public static void SetupPost(UnityWebRequest request, Dictionary<string, string> formFields)
		{
			request.downloadHandler = new DownloadHandlerBuffer();
			Il2CppStructArray<byte> il2CppStructArray = null;
			bool flag = formFields != null && formFields.Count != 0;
			if (flag)
			{
				il2CppStructArray = UnityWebRequest.SerializeSimpleForm(formFields);
			}
			bool flag2 = il2CppStructArray == null;
			if (!flag2)
			{
				request.uploadHandler = new UploadHandlerRaw(il2CppStructArray)
				{
					contentType = "application/x-www-form-urlencoded"
				};
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00005918 File Offset: 0x00003B18
		public static string EscapeURL(string s)
		{
			return UnityWebRequest.EscapeURL(s, Encoding.UTF8);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00005938 File Offset: 0x00003B38
		public static string UnEscapeURL(string s)
		{
			return UnityWebRequest.UnEscapeURL(s, Encoding.UTF8);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005958 File Offset: 0x00003B58
		public static string UnEscapeURL(string s, Encoding e)
		{
			bool flag = s == null;
			string text;
			if (flag)
			{
				text = null;
			}
			else
			{
				bool flag2 = s.IndexOf('%') == -1 && s.IndexOf('+') == -1;
				if (flag2)
				{
					text = s;
				}
				else
				{
					Il2CppStructArray<byte> bytes = e.GetBytes(s);
					Il2CppStructArray<byte> il2CppStructArray = WWWTranscoder.URLDecode(bytes);
					text = e.GetString(il2CppStructArray);
				}
			}
			return text;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000059B0 File Offset: 0x00003BB0
		public static Il2CppStructArray<byte> SerializeFormSections(List<IMultipartFormSection> multipartFormSections, Il2CppStructArray<byte> boundary)
		{
			bool flag = multipartFormSections == null || multipartFormSections.Count == 0;
			Il2CppStructArray<byte> il2CppStructArray;
			if (flag)
			{
				il2CppStructArray = null;
			}
			else
			{
				Il2CppStructArray<byte> bytes = Encoding.UTF8.GetBytes("\r\n");
				Il2CppStructArray<byte> bytes2 = WWWForm.DefaultEncoding.GetBytes("--");
				int num = 0;
				List<IMultipartFormSection>.Enumerator enumerator = multipartFormSections.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						IMultipartFormSection multipartFormSection = enumerator.Current;
						num += 64 + multipartFormSection.sectionData.Length;
					}
				}
				finally
				{
					enumerator.Dispose();
				}
				List<byte> list = new List<byte>(num);
				List<IMultipartFormSection>.Enumerator enumerator2 = multipartFormSections.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						IMultipartFormSection multipartFormSection2 = enumerator2.Current;
						string text = "form-data";
						string sectionName = multipartFormSection2.sectionName;
						string fileName = multipartFormSection2.fileName;
						string text2 = String.Concat("Content-Disposition: ", text);
						bool flag2 = !String.IsNullOrEmpty(sectionName);
						if (flag2)
						{
							text2 = String.Concat(text2, "; name=\"", sectionName, "\"");
						}
						bool flag3 = !String.IsNullOrEmpty(fileName);
						if (flag3)
						{
							text2 = String.Concat(text2, "; filename=\"", fileName, "\"");
						}
						text2 = String.Concat(text2, "\r\n");
						string contentType = multipartFormSection2.contentType;
						bool flag4 = !String.IsNullOrEmpty(contentType);
						if (flag4)
						{
							text2 = String.Concat(text2, "Content-Type: ", contentType, "\r\n");
						}
						list.AddRange(bytes);
						list.AddRange(bytes2);
						list.AddRange(boundary);
						list.AddRange(bytes);
						list.AddRange(Encoding.UTF8.GetBytes(text2));
						list.AddRange(bytes);
						list.AddRange(multipartFormSection2.sectionData);
					}
				}
				finally
				{
					enumerator2.Dispose();
				}
				list.AddRange(bytes);
				list.AddRange(bytes2);
				list.AddRange(boundary);
				list.AddRange(bytes2);
				list.AddRange(bytes);
				il2CppStructArray = list.ToArray();
			}
			return il2CppStructArray;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000250A File Offset: 0x0000070A
		public static Il2CppStructArray<byte> GenerateBoundary()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005BE4 File Offset: 0x00003DE4
		public static Il2CppStructArray<byte> SerializeSimpleForm(Dictionary<string, string> formFields)
		{
			string text = "";
			Dictionary<string, string>.Enumerator enumerator = formFields.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, string> keyValuePair = enumerator.Current;
					bool flag = text.Length > 0;
					if (flag)
					{
						text = String.Concat(text, "&");
					}
					text = String.Concat(text, WWWTranscoder.DataEncode(keyValuePair.Key), "=", WWWTranscoder.DataEncode(keyValuePair.Value));
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			return Encoding.UTF8.GetBytes(text);
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_m_DownloadHandler;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_m_UploadHandler;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_m_CertificateHandler;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_m_Uri;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_GetWebErrorString_Private_Static_String_UnityWebRequestError_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPStatusString_Internal_Static_String_Int64_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_get_disposeCertificateHandlerOnDispose_Public_get_Boolean_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_set_disposeCertificateHandlerOnDispose_Public_set_Void_Boolean_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_get_disposeDownloadHandlerOnDispose_Public_get_Boolean_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_set_disposeDownloadHandlerOnDispose_Public_set_Void_Boolean_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_get_disposeUploadHandlerOnDispose_Public_get_Boolean_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_set_disposeUploadHandlerOnDispose_Public_set_Void_Boolean_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_IntPtr_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_InternalDestroy_Internal_Void_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetDefaults_Private_Void_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_DownloadHandler_UploadHandler_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_DisposeHandlers_Private_Void_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_BeginWebRequest_Internal_UnityWebRequestAsyncOperation_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_SendWebRequest_Public_UnityWebRequestAsyncOperation_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Void_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_SetMethod_Private_UnityWebRequestError_UnityWebRequestMethod_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetMethod_Internal_Void_UnityWebRequestMethod_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_SetCustomMethod_Private_UnityWebRequestError_String_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetCustomMethod_Internal_Void_String_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_set_method_Public_set_Void_String_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_GetError_Private_UnityWebRequestError_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_get_error_Public_get_String_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_get_url_Public_get_String_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_set_url_Public_set_Void_String_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_GetUrl_Private_String_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_SetUrl_Private_UnityWebRequestError_String_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetUrl_Private_Void_String_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_get_responseCode_Public_get_Int64_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_get_isModifiable_Public_get_Boolean_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_get_result_Public_get_Result_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_SetChunked_Private_UnityWebRequestError_Boolean_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_set_chunkedTransfer_Public_set_Void_Boolean_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetRequestHeader_Internal_UnityWebRequestError_String_String_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_SetRequestHeader_Public_Void_String_String_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_SetUploadHandler_Private_UnityWebRequestError_UploadHandler_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_get_uploadHandler_Public_get_UploadHandler_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_set_uploadHandler_Public_set_Void_UploadHandler_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_SetDownloadHandler_Private_UnityWebRequestError_DownloadHandler_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_get_downloadHandler_Public_get_DownloadHandler_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_set_downloadHandler_Public_set_Void_DownloadHandler_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_certificateHandler_Public_get_CertificateHandler_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeoutMsec_Private_UnityWebRequestError_Int32_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_set_timeout_Public_set_Void_Int32_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_UnityWebRequest_String_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Static_UnityWebRequest_String_String_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_SetupPost_Private_Static_Void_UnityWebRequest_String_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Static_UnityWebRequest_String_WWWForm_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_SetupPost_Private_Static_Void_UnityWebRequest_WWWForm_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_EscapeURL_Public_Static_String_String_Encoding_0;

		// Token: 0x04000074 RID: 116
		public const string kHttpVerbGET = "GET";

		// Token: 0x04000075 RID: 117
		public const string kHttpVerbHEAD = "HEAD";

		// Token: 0x04000076 RID: 118
		public const string kHttpVerbPOST = "POST";

		// Token: 0x04000077 RID: 119
		public const string kHttpVerbPUT = "PUT";

		// Token: 0x04000078 RID: 120
		public const string kHttpVerbCREATE = "CREATE";

		// Token: 0x04000079 RID: 121
		public const string kHttpVerbDELETE = "DELETE";

		// Token: 0x0400007A RID: 122
		private static readonly UnityWebRequest.ClearCookieCacheDelegate ClearCookieCacheDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly UnityWebRequest.GetMethodDelegate GetMethodDelegateField;

		// Token: 0x0400007C RID: 124
		private static readonly UnityWebRequest.GetCustomMethodDelegate GetCustomMethodDelegateField;

		// Token: 0x0400007D RID: 125
		private static readonly UnityWebRequest.get_use100ContinueDelegate get_use100ContinueDelegateField;

		// Token: 0x0400007E RID: 126
		private static readonly UnityWebRequest.set_use100ContinueDelegate set_use100ContinueDelegateField;

		// Token: 0x0400007F RID: 127
		private static readonly UnityWebRequest.GetUploadProgressDelegate GetUploadProgressDelegateField;

		// Token: 0x04000080 RID: 128
		private static readonly UnityWebRequest.IsExecutingDelegate IsExecutingDelegateField;

		// Token: 0x04000081 RID: 129
		private static readonly UnityWebRequest.GetDownloadProgressDelegate GetDownloadProgressDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly UnityWebRequest.get_uploadedBytesDelegate get_uploadedBytesDelegateField;

		// Token: 0x04000083 RID: 131
		private static readonly UnityWebRequest.get_downloadedBytesDelegate get_downloadedBytesDelegateField;

		// Token: 0x04000084 RID: 132
		private static readonly UnityWebRequest.GetRedirectLimitDelegate GetRedirectLimitDelegateField;

		// Token: 0x04000085 RID: 133
		private static readonly UnityWebRequest.SetRedirectLimitFromScriptingDelegate SetRedirectLimitFromScriptingDelegateField;

		// Token: 0x04000086 RID: 134
		private static readonly UnityWebRequest.GetChunkedDelegate GetChunkedDelegateField;

		// Token: 0x04000087 RID: 135
		private static readonly UnityWebRequest.GetRequestHeaderDelegate GetRequestHeaderDelegateField;

		// Token: 0x04000088 RID: 136
		private static readonly UnityWebRequest.GetResponseHeaderDelegate GetResponseHeaderDelegateField;

		// Token: 0x04000089 RID: 137
		private static readonly UnityWebRequest.GetResponseHeaderKeysDelegate GetResponseHeaderKeysDelegateField;

		// Token: 0x0400008A RID: 138
		private static readonly UnityWebRequest.SetCertificateHandlerDelegate SetCertificateHandlerDelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly UnityWebRequest.GetTimeoutMsecDelegate GetTimeoutMsecDelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly UnityWebRequest.GetSuppressErrorsToConsoleDelegate GetSuppressErrorsToConsoleDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly UnityWebRequest.SetSuppressErrorsToConsoleDelegate SetSuppressErrorsToConsoleDelegateField;

		// Token: 0x02000012 RID: 18
		public enum UnityWebRequestMethod
		{
			// Token: 0x040000C5 RID: 197
			Get,
			// Token: 0x040000C6 RID: 198
			Post,
			// Token: 0x040000C7 RID: 199
			Put,
			// Token: 0x040000C8 RID: 200
			Head,
			// Token: 0x040000C9 RID: 201
			Custom
		}

		// Token: 0x02000013 RID: 19
		public enum UnityWebRequestError
		{
			// Token: 0x040000CB RID: 203
			OK,
			// Token: 0x040000CC RID: 204
			Unknown,
			// Token: 0x040000CD RID: 205
			SDKError,
			// Token: 0x040000CE RID: 206
			UnsupportedProtocol,
			// Token: 0x040000CF RID: 207
			MalformattedUrl,
			// Token: 0x040000D0 RID: 208
			CannotResolveProxy,
			// Token: 0x040000D1 RID: 209
			CannotResolveHost,
			// Token: 0x040000D2 RID: 210
			CannotConnectToHost,
			// Token: 0x040000D3 RID: 211
			AccessDenied,
			// Token: 0x040000D4 RID: 212
			GenericHttpError,
			// Token: 0x040000D5 RID: 213
			WriteError,
			// Token: 0x040000D6 RID: 214
			ReadError,
			// Token: 0x040000D7 RID: 215
			OutOfMemory,
			// Token: 0x040000D8 RID: 216
			Timeout,
			// Token: 0x040000D9 RID: 217
			HTTPPostError,
			// Token: 0x040000DA RID: 218
			SSLCannotConnect,
			// Token: 0x040000DB RID: 219
			Aborted,
			// Token: 0x040000DC RID: 220
			TooManyRedirects,
			// Token: 0x040000DD RID: 221
			ReceivedNoData,
			// Token: 0x040000DE RID: 222
			SSLNotSupported,
			// Token: 0x040000DF RID: 223
			FailedToSendData,
			// Token: 0x040000E0 RID: 224
			FailedToReceiveData,
			// Token: 0x040000E1 RID: 225
			SSLCertificateError,
			// Token: 0x040000E2 RID: 226
			SSLCipherNotAvailable,
			// Token: 0x040000E3 RID: 227
			SSLCACertError,
			// Token: 0x040000E4 RID: 228
			UnrecognizedContentEncoding,
			// Token: 0x040000E5 RID: 229
			LoginFailed,
			// Token: 0x040000E6 RID: 230
			SSLShutdownFailed,
			// Token: 0x040000E7 RID: 231
			NoInternetConnection
		}

		// Token: 0x02000014 RID: 20
		public enum Result
		{
			// Token: 0x040000E9 RID: 233
			InProgress,
			// Token: 0x040000EA RID: 234
			Success,
			// Token: 0x040000EB RID: 235
			ConnectionError,
			// Token: 0x040000EC RID: 236
			ProtocolError,
			// Token: 0x040000ED RID: 237
			DataProcessingError
		}

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x0600015D RID: 349
		private delegate void ClearCookieCacheDelegate(IntPtr domain, IntPtr path);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x0600015F RID: 351
		private delegate UnityWebRequest.UnityWebRequestMethod GetMethodDelegate(IntPtr @this);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000161 RID: 353
		private delegate IntPtr GetCustomMethodDelegate(IntPtr @this);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x06000163 RID: 355
		private delegate bool get_use100ContinueDelegate(IntPtr @this);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x06000165 RID: 357
		private delegate void set_use100ContinueDelegate(IntPtr @this, bool value);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x06000167 RID: 359
		private delegate float GetUploadProgressDelegate(IntPtr @this);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000169 RID: 361
		private delegate bool IsExecutingDelegate(IntPtr @this);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x0600016B RID: 363
		private delegate float GetDownloadProgressDelegate(IntPtr @this);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x0600016D RID: 365
		private delegate ulong get_uploadedBytesDelegate(IntPtr @this);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x0600016F RID: 367
		private delegate ulong get_downloadedBytesDelegate(IntPtr @this);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x06000171 RID: 369
		private delegate int GetRedirectLimitDelegate(IntPtr @this);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x06000173 RID: 371
		private delegate void SetRedirectLimitFromScriptingDelegate(IntPtr @this, int limit);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x06000175 RID: 373
		private delegate bool GetChunkedDelegate(IntPtr @this);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x06000177 RID: 375
		private delegate IntPtr GetRequestHeaderDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x06000179 RID: 377
		private delegate IntPtr GetResponseHeaderDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x0600017B RID: 379
		private delegate IntPtr GetResponseHeaderKeysDelegate(IntPtr @this);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x0600017D RID: 381
		private delegate UnityWebRequest.UnityWebRequestError SetCertificateHandlerDelegate(IntPtr @this, IntPtr ch);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x0600017F RID: 383
		private delegate int GetTimeoutMsecDelegate(IntPtr @this);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x06000181 RID: 385
		private delegate bool GetSuppressErrorsToConsoleDelegate(IntPtr @this);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x06000183 RID: 387
		private delegate UnityWebRequest.UnityWebRequestError SetSuppressErrorsToConsoleDelegate(IntPtr @this, bool suppress);
	}
}
