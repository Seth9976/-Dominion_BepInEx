using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x0200010D RID: 269
	[Serializable]
	public class HttpWebRequest : WebRequest
	{
		// Token: 0x06001043 RID: 4163 RVA: 0x0004D83C File Offset: 0x0004BA3C
		// Note: this type is marked as 'beforefieldinit'.
		static HttpWebRequest()
		{
			Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpWebRequest");
			HttpWebRequest.NativeFieldInfoPtr_requestUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "requestUri");
			HttpWebRequest.NativeFieldInfoPtr_actualUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "actualUri");
			HttpWebRequest.NativeFieldInfoPtr_hostChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "hostChanged");
			HttpWebRequest.NativeFieldInfoPtr_allowAutoRedirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "allowAutoRedirect");
			HttpWebRequest.NativeFieldInfoPtr_allowBuffering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "allowBuffering");
			HttpWebRequest.NativeFieldInfoPtr_certificates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "certificates");
			HttpWebRequest.NativeFieldInfoPtr_connectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "connectionGroup");
			HttpWebRequest.NativeFieldInfoPtr_haveContentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "haveContentLength");
			HttpWebRequest.NativeFieldInfoPtr_contentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "contentLength");
			HttpWebRequest.NativeFieldInfoPtr_continueDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "continueDelegate");
			HttpWebRequest.NativeFieldInfoPtr_cookieContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "cookieContainer");
			HttpWebRequest.NativeFieldInfoPtr_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "credentials");
			HttpWebRequest.NativeFieldInfoPtr_haveResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "haveResponse");
			HttpWebRequest.NativeFieldInfoPtr_requestSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "requestSent");
			HttpWebRequest.NativeFieldInfoPtr_webHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "webHeaders");
			HttpWebRequest.NativeFieldInfoPtr_keepAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "keepAlive");
			HttpWebRequest.NativeFieldInfoPtr_maxAutoRedirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "maxAutoRedirect");
			HttpWebRequest.NativeFieldInfoPtr_mediaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "mediaType");
			HttpWebRequest.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "method");
			HttpWebRequest.NativeFieldInfoPtr_initialMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "initialMethod");
			HttpWebRequest.NativeFieldInfoPtr_pipelined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "pipelined");
			HttpWebRequest.NativeFieldInfoPtr_preAuthenticate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "preAuthenticate");
			HttpWebRequest.NativeFieldInfoPtr_usedPreAuth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "usedPreAuth");
			HttpWebRequest.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "version");
			HttpWebRequest.NativeFieldInfoPtr_force_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "force_version");
			HttpWebRequest.NativeFieldInfoPtr_actualVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "actualVersion");
			HttpWebRequest.NativeFieldInfoPtr_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "proxy");
			HttpWebRequest.NativeFieldInfoPtr_sendChunked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "sendChunked");
			HttpWebRequest.NativeFieldInfoPtr_servicePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "servicePoint");
			HttpWebRequest.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "timeout");
			HttpWebRequest.NativeFieldInfoPtr_writeStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "writeStream");
			HttpWebRequest.NativeFieldInfoPtr_webResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "webResponse");
			HttpWebRequest.NativeFieldInfoPtr_responseTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "responseTask");
			HttpWebRequest.NativeFieldInfoPtr_currentOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "currentOperation");
			HttpWebRequest.NativeFieldInfoPtr_aborted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "aborted");
			HttpWebRequest.NativeFieldInfoPtr_gotRequestStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "gotRequestStream");
			HttpWebRequest.NativeFieldInfoPtr_redirects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "redirects");
			HttpWebRequest.NativeFieldInfoPtr_expectContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "expectContinue");
			HttpWebRequest.NativeFieldInfoPtr_getResponseCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "getResponseCalled");
			HttpWebRequest.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "locker");
			HttpWebRequest.NativeFieldInfoPtr_finished_reading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "finished_reading");
			HttpWebRequest.NativeFieldInfoPtr_auto_decomp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "auto_decomp");
			HttpWebRequest.NativeFieldInfoPtr_defaultMaxResponseHeadersLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "defaultMaxResponseHeadersLength");
			HttpWebRequest.NativeFieldInfoPtr_readWriteTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "readWriteTimeout");
			HttpWebRequest.NativeFieldInfoPtr_tlsProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "tlsProvider");
			HttpWebRequest.NativeFieldInfoPtr_tlsSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "tlsSettings");
			HttpWebRequest.NativeFieldInfoPtr_certValidationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "certValidationCallback");
			HttpWebRequest.NativeFieldInfoPtr_auth_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "auth_state");
			HttpWebRequest.NativeFieldInfoPtr_proxy_auth_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "proxy_auth_state");
			HttpWebRequest.NativeFieldInfoPtr_host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "host");
			HttpWebRequest.NativeFieldInfoPtr_ResendContentFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "ResendContentFactory");
			HttpWebRequest.NativeFieldInfoPtr__ThrowOnError_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<ThrowOnError>k__BackingField");
			HttpWebRequest.NativeFieldInfoPtr_unsafe_auth_blah = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "unsafe_auth_blah");
			HttpWebRequest.NativeMethodInfoPtr__ctor_Public_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665561);
			HttpWebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665562);
			HttpWebRequest.NativeMethodInfoPtr_ResetAuthorization_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665563);
			HttpWebRequest.NativeMethodInfoPtr_get_Address_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665564);
			HttpWebRequest.NativeMethodInfoPtr_set_Address_Internal_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665565);
			HttpWebRequest.NativeMethodInfoPtr_get_AllowWriteStreamBuffering_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665566);
			HttpWebRequest.NativeMethodInfoPtr_get_AutomaticDecompression_Public_get_DecompressionMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665567);
			HttpWebRequest.NativeMethodInfoPtr_get_InternalAllowBuffering_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665568);
			HttpWebRequest.NativeMethodInfoPtr_get_MethodWithBuffer_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665569);
			HttpWebRequest.NativeMethodInfoPtr_get_TlsProvider_Internal_get_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665570);
			HttpWebRequest.NativeMethodInfoPtr_get_TlsSettings_Internal_get_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665571);
			HttpWebRequest.NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665572);
			HttpWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665573);
			HttpWebRequest.NativeMethodInfoPtr_set_InternalContentLength_Internal_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665574);
			HttpWebRequest.NativeMethodInfoPtr_get_ThrowOnError_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665575);
			HttpWebRequest.NativeMethodInfoPtr_set_ThrowOnError_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665576);
			HttpWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665577);
			HttpWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665578);
			HttpWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665579);
			HttpWebRequest.NativeMethodInfoPtr_get_Host_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665580);
			HttpWebRequest.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665581);
			HttpWebRequest.NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665582);
			HttpWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665583);
			HttpWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665584);
			HttpWebRequest.NativeMethodInfoPtr_get_ProtocolVersion_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665585);
			HttpWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665586);
			HttpWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665587);
			HttpWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665588);
			HttpWebRequest.NativeMethodInfoPtr_get_SendChunked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665589);
			HttpWebRequest.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665590);
			HttpWebRequest.NativeMethodInfoPtr_get_ServicePointNoLock_Internal_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665591);
			HttpWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665592);
			HttpWebRequest.NativeMethodInfoPtr_get_TransferEncoding_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665593);
			HttpWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665594);
			HttpWebRequest.NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665595);
			HttpWebRequest.NativeMethodInfoPtr_get_ExpectContinue_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665596);
			HttpWebRequest.NativeMethodInfoPtr_set_ExpectContinue_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665597);
			HttpWebRequest.NativeMethodInfoPtr_get_AuthUri_Internal_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665598);
			HttpWebRequest.NativeMethodInfoPtr_get_ProxyQuery_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665599);
			HttpWebRequest.NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_get_ServerCertValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665600);
			HttpWebRequest.NativeMethodInfoPtr_GetServicePoint_Internal_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665601);
			HttpWebRequest.NativeMethodInfoPtr_SendRequest_Private_WebOperation_Boolean_BufferOffsetSize_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665602);
			HttpWebRequest.NativeMethodInfoPtr_RunWithTimeout_Internal_Static_Task_1_T_Func_2_CancellationToken_Task_1_T_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665603);
			HttpWebRequest.NativeMethodInfoPtr_RunWithTimeout_Private_Task_1_T_Func_2_CancellationToken_Task_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665604);
			HttpWebRequest.NativeMethodInfoPtr_MyGetResponseAsync_Private_Task_1_HttpWebResponse_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665605);
			HttpWebRequest.NativeMethodInfoPtr_GetResponseFromData_Private_Task_1_ValueTuple_5_HttpWebResponse_Boolean_Boolean_BufferOffsetSize_WebOperation_WebResponseStream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665606);
			HttpWebRequest.NativeMethodInfoPtr_FlattenException_Internal_Static_Exception_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665607);
			HttpWebRequest.NativeMethodInfoPtr_GetWebException_Private_WebException_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665608);
			HttpWebRequest.NativeMethodInfoPtr_CreateRequestAbortedException_Internal_Static_WebException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665609);
			HttpWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665610);
			HttpWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665611);
			HttpWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665612);
			HttpWebRequest.NativeMethodInfoPtr_set_FinishedReading_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665613);
			HttpWebRequest.NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665614);
			HttpWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665615);
			HttpWebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665616);
			HttpWebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665617);
			HttpWebRequest.NativeMethodInfoPtr_CheckRequestStarted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665618);
			HttpWebRequest.NativeMethodInfoPtr_DoContinueDelegate_Internal_Void_Int32_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665619);
			HttpWebRequest.NativeMethodInfoPtr_RewriteRedirectToGet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665620);
			HttpWebRequest.NativeMethodInfoPtr_Redirect_Private_Boolean_HttpStatusCode_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665621);
			HttpWebRequest.NativeMethodInfoPtr_GetHeaders_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665622);
			HttpWebRequest.NativeMethodInfoPtr_DoPreAuthenticate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665623);
			HttpWebRequest.NativeMethodInfoPtr_GetRequestHeaders_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665624);
			HttpWebRequest.NativeMethodInfoPtr_HandleNtlmAuth_Private_ValueTuple_2_WebOperation_Boolean_WebResponseStream_HttpWebResponse_BufferOffsetSize_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665625);
			HttpWebRequest.NativeMethodInfoPtr_CheckAuthorization_Private_Boolean_WebResponse_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665626);
			HttpWebRequest.NativeMethodInfoPtr_GetRewriteHandler_Private_ValueTuple_2_Task_1_BufferOffsetSize_WebException_HttpWebResponse_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665627);
			HttpWebRequest.NativeMethodInfoPtr_CheckFinalStatus_Private_ValueTuple_4_Boolean_Boolean_Task_1_BufferOffsetSize_WebException_HttpWebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665628);
			HttpWebRequest.NativeMethodInfoPtr__GetRewriteHandler_b__263_0_Private_Task_1_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665629);
			HttpWebRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, 100665630);
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0004E200 File Offset: 0x0004C400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51758, XrefRangeEnd = 51782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebRequest(Uri uri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr__ctor_Public_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0004E24C File Offset: 0x0004C44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51782, XrefRangeEnd = 51897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0004E2B0 File Offset: 0x0004C4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51897, XrefRangeEnd = 51899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAuthorization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_ResetAuthorization_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x0004E2E4 File Offset: 0x0004C4E4
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x0004E324 File Offset: 0x0004C524
		public unsafe Uri Address
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_Address_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_Address_Internal_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x0004E368 File Offset: 0x0004C568
		public unsafe virtual bool AllowWriteStreamBuffering
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_AllowWriteStreamBuffering_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x0004E3B0 File Offset: 0x0004C5B0
		public unsafe DecompressionMethods AutomaticDecompression
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_AutomaticDecompression_Public_get_DecompressionMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x0004E3EC File Offset: 0x0004C5EC
		public unsafe bool InternalAllowBuffering
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 51899, RefRangeEnd = 51900, XrefRangeStart = 51899, XrefRangeEnd = 51899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_InternalAllowBuffering_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x0004E428 File Offset: 0x0004C628
		public unsafe bool MethodWithBuffer
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 51915, RefRangeEnd = 51917, XrefRangeStart = 51900, XrefRangeEnd = 51915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_MethodWithBuffer_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x0004E464 File Offset: 0x0004C664
		public unsafe MonoTlsProvider TlsProvider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_TlsProvider_Internal_get_MonoTlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr3) : null;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x0004E4A4 File Offset: 0x0004C6A4
		public unsafe MonoTlsSettings TlsSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_TlsSettings_Internal_get_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x0004E4E4 File Offset: 0x0004C6E4
		public unsafe X509CertificateCollection ClientCertificates
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 51921, RefRangeEnd = 51922, XrefRangeStart = 51917, XrefRangeEnd = 51921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x0004E524 File Offset: 0x0004C724
		public unsafe override long ContentLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000540 RID: 1344
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x0004E56C File Offset: 0x0004C76C
		public unsafe long InternalContentLength
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_InternalContentLength_Internal_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x0004E5AC File Offset: 0x0004C7AC
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x0004E5E8 File Offset: 0x0004C7E8
		public unsafe bool ThrowOnError
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ThrowOnError_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_ThrowOnError_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x0004E628 File Offset: 0x0004C828
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x0004E674 File Offset: 0x0004C874
		public unsafe override ICredentials Credentials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x0004E6C4 File Offset: 0x0004C8C4
		public unsafe override WebHeaderCollection Headers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x0004E710 File Offset: 0x0004C910
		public unsafe string Host
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 51923, RefRangeEnd = 51924, XrefRangeStart = 51922, XrefRangeEnd = 51923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_Host_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x0004E748 File Offset: 0x0004C948
		public unsafe bool KeepAlive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x0004E784 File Offset: 0x0004C984
		public unsafe int ReadWriteTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x0004E7C0 File Offset: 0x0004C9C0
		// (set) Token: 0x0600105B RID: 4187 RVA: 0x0004E804 File Offset: 0x0004CA04
		public unsafe override string Method
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51924, XrefRangeEnd = 51953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x0004E854 File Offset: 0x0004CA54
		public unsafe Version ProtocolVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ProtocolVersion_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x0004E894 File Offset: 0x0004CA94
		// (set) Token: 0x0600105E RID: 4190 RVA: 0x0004E8E0 File Offset: 0x0004CAE0
		public unsafe override IWebProxy Proxy
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12693, RefRangeEnd = 12694, XrefRangeStart = 12693, XrefRangeEnd = 12694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51953, XrefRangeEnd = 51960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600105F RID: 4191 RVA: 0x0004E930 File Offset: 0x0004CB30
		public unsafe override Uri RequestUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x0004E97C File Offset: 0x0004CB7C
		public unsafe bool SendChunked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_SendChunked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x0004E9B8 File Offset: 0x0004CBB8
		public unsafe ServicePoint ServicePoint
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 51961, RefRangeEnd = 51966, XrefRangeStart = 51960, XrefRangeEnd = 51961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x0004E9F8 File Offset: 0x0004CBF8
		public unsafe ServicePoint ServicePointNoLock
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ServicePointNoLock_Internal_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x0004EA38 File Offset: 0x0004CC38
		public unsafe override int Timeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x0004EA80 File Offset: 0x0004CC80
		public unsafe string TransferEncoding
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 51970, RefRangeEnd = 51971, XrefRangeStart = 51966, XrefRangeEnd = 51970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_TransferEncoding_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x0004EAB8 File Offset: 0x0004CCB8
		public unsafe override bool UseDefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51971, XrefRangeEnd = 51975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x0004EB00 File Offset: 0x0004CD00
		public unsafe bool UnsafeAuthenticatedConnectionSharing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x0004EB3C File Offset: 0x0004CD3C
		// (set) Token: 0x06001068 RID: 4200 RVA: 0x0004EB78 File Offset: 0x0004CD78
		public unsafe bool ExpectContinue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ExpectContinue_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_ExpectContinue_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x0004EBB8 File Offset: 0x0004CDB8
		public unsafe Uri AuthUri
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_AuthUri_Internal_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x0004EBF8 File Offset: 0x0004CDF8
		public unsafe bool ProxyQuery
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 51975, RefRangeEnd = 51976, XrefRangeStart = 51975, XrefRangeEnd = 51975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ProxyQuery_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x0004EC34 File Offset: 0x0004CE34
		public unsafe ServerCertValidationCallback ServerCertValidationCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_get_ServerCertValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr3) : null;
			}
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0004EC74 File Offset: 0x0004CE74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 51983, RefRangeEnd = 51986, XrefRangeStart = 51976, XrefRangeEnd = 51983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePoint GetServicePoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetServicePoint_Internal_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0004ECB4 File Offset: 0x0004CEB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51997, RefRangeEnd = 51998, XrefRangeStart = 51986, XrefRangeEnd = 51997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref redirecting;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writeBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_SendRequest_Private_WebOperation_Boolean_BufferOffsetSize_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr3) : null;
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0004ED2C File Offset: 0x0004CF2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52004, RefRangeEnd = 52005, XrefRangeStart = 51998, XrefRangeEnd = 52004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abort);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.MethodInfoStoreGeneric_RunWithTimeout_Internal_Static_Task_1_T_Func_2_CancellationToken_Task_1_T_Int32_Action_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0004ED90 File Offset: 0x0004CF90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52012, RefRangeEnd = 52013, XrefRangeStart = 52005, XrefRangeEnd = 52012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.MethodInfoStoreGeneric_RunWithTimeout_Private_Task_1_T_Func_2_CancellationToken_Task_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0004EDE0 File Offset: 0x0004CFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52013, XrefRangeEnd = 52025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_MyGetResponseAsync_Private_Task_1_HttpWebResponse_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpWebResponse>>(intPtr3) : null;
			}
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0004EE38 File Offset: 0x0004D038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52037, RefRangeEnd = 52038, XrefRangeStart = 52025, XrefRangeEnd = 52037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetResponseFromData_Private_Task_1_ValueTuple_5_HttpWebResponse_Boolean_Boolean_BufferOffsetSize_WebOperation_WebResponseStream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>>(intPtr3) : null;
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0004EEA0 File Offset: 0x0004D0A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 52044, RefRangeEnd = 52047, XrefRangeStart = 52038, XrefRangeEnd = 52044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception FlattenException(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_FlattenException_Internal_Static_Exception_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0004EEE4 File Offset: 0x0004D0E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52067, RefRangeEnd = 52068, XrefRangeStart = 52047, XrefRangeEnd = 52067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException GetWebException(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetWebException_Private_WebException_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
			}
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0004EF34 File Offset: 0x0004D134
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 52078, RefRangeEnd = 52081, XrefRangeStart = 52068, XrefRangeEnd = 52078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebException CreateRequestAbortedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_CreateRequestAbortedException_Internal_Static_WebException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0004EF68 File Offset: 0x0004D168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52081, XrefRangeEnd = 52101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0004EFD8 File Offset: 0x0004D1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52101, XrefRangeEnd = 52104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0004F034 File Offset: 0x0004D234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52104, XrefRangeEnd = 52107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WebResponse GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
		}

		// Token: 0x17000556 RID: 1366
		// (set) Token: 0x06001078 RID: 4216 RVA: 0x0004F080 File Offset: 0x0004D280
		public unsafe bool FinishedReading
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_set_FinishedReading_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001079 RID: 4217 RVA: 0x0004F0C0 File Offset: 0x0004D2C0
		public unsafe bool Aborted
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 52108, RefRangeEnd = 52118, XrefRangeStart = 52107, XrefRangeEnd = 52108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0004F0FC File Offset: 0x0004D2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52118, XrefRangeEnd = 52122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0004F138 File Offset: 0x0004D338
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0004F194 File Offset: 0x0004D394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52122, XrefRangeEnd = 52203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpWebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0004F1F8 File Offset: 0x0004D3F8
		[CallerCount(0)]
		public unsafe void CheckRequestStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_CheckRequestStarted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0004F22C File Offset: 0x0004D42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52203, XrefRangeEnd = 52207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoContinueDelegate(int statusCode, WebHeaderCollection headers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref statusCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_DoContinueDelegate_Internal_Void_Int32_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0004F27C File Offset: 0x0004D47C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52212, RefRangeEnd = 52213, XrefRangeStart = 52207, XrefRangeEnd = 52212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RewriteRedirectToGet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_RewriteRedirectToGet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0004F2B0 File Offset: 0x0004D4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52213, XrefRangeEnd = 52234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Redirect(HttpStatusCode code, WebResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_Redirect_Private_Boolean_HttpStatusCode_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0004F30C File Offset: 0x0004D50C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52335, RefRangeEnd = 52336, XrefRangeStart = 52234, XrefRangeEnd = 52335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetHeaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetHeaders_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0004F344 File Offset: 0x0004D544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52356, RefRangeEnd = 52357, XrefRangeStart = 52336, XrefRangeEnd = 52356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoPreAuthenticate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_DoPreAuthenticate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0004F378 File Offset: 0x0004D578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52395, RefRangeEnd = 52396, XrefRangeStart = 52357, XrefRangeEnd = 52395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetRequestHeaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetRequestHeaders_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0004F3B8 File Offset: 0x0004D5B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52415, RefRangeEnd = 52416, XrefRangeStart = 52396, XrefRangeEnd = 52415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<WebOperation, bool> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writeBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_HandleNtlmAuth_Private_ValueTuple_2_WebOperation_Boolean_WebResponseStream_HttpWebResponse_BufferOffsetSize_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<WebOperation, bool>(intPtr);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0004F43C File Offset: 0x0004D63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52416, XrefRangeEnd = 52418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckAuthorization(WebResponse response, HttpStatusCode code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_CheckAuthorization_Private_Boolean_WebResponse_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x0004F498 File Offset: 0x0004D698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52431, RefRangeEnd = 52432, XrefRangeStart = 52418, XrefRangeEnd = 52431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<Task<BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref redirect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_GetRewriteHandler_Private_ValueTuple_2_Task_1_BufferOffsetSize_WebException_HttpWebResponse_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<Task<BufferOffsetSize>, WebException>(intPtr);
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0004F4F0 File Offset: 0x0004D6F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52449, RefRangeEnd = 52450, XrefRangeStart = 52432, XrefRangeEnd = 52449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr_CheckFinalStatus_Private_ValueTuple_4_Boolean_Boolean_Task_1_BufferOffsetSize_WebException_HttpWebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(intPtr);
			}
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0004F538 File Offset: 0x0004D738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52450, XrefRangeEnd = 52462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<BufferOffsetSize> _GetRewriteHandler_b__263_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr__GetRewriteHandler_b__263_0_Private_Task_1_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<BufferOffsetSize>>(intPtr3) : null;
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0004F578 File Offset: 0x0004D778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52462, XrefRangeEnd = 52465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0000873A File Offset: 0x0000693A
		public HttpWebRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x0004F5B4 File Offset: 0x0004D7B4
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x00008743 File Offset: 0x00006943
		public unsafe Uri requestUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_requestUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_requestUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x0004F5E4 File Offset: 0x0004D7E4
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x00008762 File Offset: 0x00006962
		public unsafe Uri actualUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_actualUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_actualUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x0004F614 File Offset: 0x0004D814
		// (set) Token: 0x06001090 RID: 4240 RVA: 0x00008781 File Offset: 0x00006981
		public unsafe bool hostChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_hostChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_hostChanged)) = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x0004F63C File Offset: 0x0004D83C
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x0000879C File Offset: 0x0000699C
		public unsafe bool allowAutoRedirect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_allowAutoRedirect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_allowAutoRedirect)) = value;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x0004F664 File Offset: 0x0004D864
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x000087B7 File Offset: 0x000069B7
		public unsafe bool allowBuffering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_allowBuffering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_allowBuffering)) = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x0004F68C File Offset: 0x0004D88C
		// (set) Token: 0x06001096 RID: 4246 RVA: 0x000087D2 File Offset: 0x000069D2
		public unsafe X509CertificateCollection certificates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_certificates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_certificates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x0004F6BC File Offset: 0x0004D8BC
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x000087F1 File Offset: 0x000069F1
		public unsafe string connectionGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_connectionGroup);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_connectionGroup), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0004F6E4 File Offset: 0x0004D8E4
		// (set) Token: 0x0600109A RID: 4250 RVA: 0x00008810 File Offset: 0x00006A10
		public unsafe bool haveContentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_haveContentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_haveContentLength)) = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0004F70C File Offset: 0x0004D90C
		// (set) Token: 0x0600109C RID: 4252 RVA: 0x0000882B File Offset: 0x00006A2B
		public unsafe long contentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_contentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_contentLength)) = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x0004F734 File Offset: 0x0004D934
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x00008846 File Offset: 0x00006A46
		public unsafe HttpContinueDelegate continueDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_continueDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContinueDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_continueDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x0004F764 File Offset: 0x0004D964
		// (set) Token: 0x060010A0 RID: 4256 RVA: 0x00008865 File Offset: 0x00006A65
		public unsafe CookieContainer cookieContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_cookieContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_cookieContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x0004F794 File Offset: 0x0004D994
		// (set) Token: 0x060010A2 RID: 4258 RVA: 0x00008884 File Offset: 0x00006A84
		public unsafe ICredentials credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x0004F7C4 File Offset: 0x0004D9C4
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x000088A3 File Offset: 0x00006AA3
		public unsafe bool haveResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_haveResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_haveResponse)) = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0004F7EC File Offset: 0x0004D9EC
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x000088BE File Offset: 0x00006ABE
		public unsafe bool requestSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_requestSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_requestSent)) = value;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x0004F814 File Offset: 0x0004DA14
		// (set) Token: 0x060010A8 RID: 4264 RVA: 0x000088D9 File Offset: 0x00006AD9
		public unsafe WebHeaderCollection webHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_webHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_webHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x0004F844 File Offset: 0x0004DA44
		// (set) Token: 0x060010AA RID: 4266 RVA: 0x000088F8 File Offset: 0x00006AF8
		public unsafe bool keepAlive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_keepAlive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_keepAlive)) = value;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x0004F86C File Offset: 0x0004DA6C
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x00008913 File Offset: 0x00006B13
		public unsafe int maxAutoRedirect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_maxAutoRedirect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_maxAutoRedirect)) = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x0004F894 File Offset: 0x0004DA94
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x0000892E File Offset: 0x00006B2E
		public unsafe string mediaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_mediaType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_mediaType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x0004F8BC File Offset: 0x0004DABC
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x0000894D File Offset: 0x00006B4D
		public unsafe string method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x0004F8E4 File Offset: 0x0004DAE4
		// (set) Token: 0x060010B2 RID: 4274 RVA: 0x0000896C File Offset: 0x00006B6C
		public unsafe string initialMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_initialMethod);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_initialMethod), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0004F90C File Offset: 0x0004DB0C
		// (set) Token: 0x060010B4 RID: 4276 RVA: 0x0000898B File Offset: 0x00006B8B
		public unsafe bool pipelined
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_pipelined);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_pipelined)) = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x0004F934 File Offset: 0x0004DB34
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x000089A6 File Offset: 0x00006BA6
		public unsafe bool preAuthenticate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_preAuthenticate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_preAuthenticate)) = value;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x0004F95C File Offset: 0x0004DB5C
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x000089C1 File Offset: 0x00006BC1
		public unsafe bool usedPreAuth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_usedPreAuth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_usedPreAuth)) = value;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x0004F984 File Offset: 0x0004DB84
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x000089DC File Offset: 0x00006BDC
		public unsafe Version version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x0004F9B4 File Offset: 0x0004DBB4
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x000089FB File Offset: 0x00006BFB
		public unsafe bool force_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_force_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_force_version)) = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x0004F9DC File Offset: 0x0004DBDC
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x00008A16 File Offset: 0x00006C16
		public unsafe Version actualVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_actualVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_actualVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x0004FA0C File Offset: 0x0004DC0C
		// (set) Token: 0x060010C0 RID: 4288 RVA: 0x00008A35 File Offset: 0x00006C35
		public unsafe IWebProxy proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x0004FA3C File Offset: 0x0004DC3C
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x00008A54 File Offset: 0x00006C54
		public unsafe bool sendChunked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_sendChunked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_sendChunked)) = value;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x0004FA64 File Offset: 0x0004DC64
		// (set) Token: 0x060010C4 RID: 4292 RVA: 0x00008A6F File Offset: 0x00006C6F
		public unsafe ServicePoint servicePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_servicePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_servicePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x0004FA94 File Offset: 0x0004DC94
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x00008A8E File Offset: 0x00006C8E
		public unsafe int timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_timeout)) = value;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x0004FABC File Offset: 0x0004DCBC
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x00008AA9 File Offset: 0x00006CA9
		public unsafe WebRequestStream writeStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_writeStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_writeStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x0004FAEC File Offset: 0x0004DCEC
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x00008AC8 File Offset: 0x00006CC8
		public unsafe HttpWebResponse webResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_webResponse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_webResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x0004FB1C File Offset: 0x0004DD1C
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x00008AE7 File Offset: 0x00006CE7
		public unsafe WebCompletionSource responseTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_responseTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_responseTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x0004FB4C File Offset: 0x0004DD4C
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x00008B06 File Offset: 0x00006D06
		public unsafe WebOperation currentOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_currentOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_currentOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x0004FB7C File Offset: 0x0004DD7C
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x00008B25 File Offset: 0x00006D25
		public unsafe int aborted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_aborted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_aborted)) = value;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x0004FBA4 File Offset: 0x0004DDA4
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x00008B40 File Offset: 0x00006D40
		public unsafe bool gotRequestStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_gotRequestStream);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_gotRequestStream)) = value;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x0004FBCC File Offset: 0x0004DDCC
		// (set) Token: 0x060010D4 RID: 4308 RVA: 0x00008B5B File Offset: 0x00006D5B
		public unsafe int redirects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_redirects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_redirects)) = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x0004FBF4 File Offset: 0x0004DDF4
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x00008B76 File Offset: 0x00006D76
		public unsafe bool expectContinue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_expectContinue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_expectContinue)) = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0004FC1C File Offset: 0x0004DE1C
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x00008B91 File Offset: 0x00006D91
		public unsafe bool getResponseCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_getResponseCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_getResponseCalled)) = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x0004FC44 File Offset: 0x0004DE44
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x00008BAC File Offset: 0x00006DAC
		public unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x0004FC74 File Offset: 0x0004DE74
		// (set) Token: 0x060010DC RID: 4316 RVA: 0x00008BCB File Offset: 0x00006DCB
		public unsafe bool finished_reading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_finished_reading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_finished_reading)) = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x0004FC9C File Offset: 0x0004DE9C
		// (set) Token: 0x060010DE RID: 4318 RVA: 0x00008BE6 File Offset: 0x00006DE6
		public unsafe DecompressionMethods auto_decomp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_auto_decomp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_auto_decomp)) = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x0004FCC4 File Offset: 0x0004DEC4
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x00008C01 File Offset: 0x00006E01
		public unsafe static int defaultMaxResponseHeadersLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HttpWebRequest.NativeFieldInfoPtr_defaultMaxResponseHeadersLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpWebRequest.NativeFieldInfoPtr_defaultMaxResponseHeadersLength, (void*)(&value));
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x0004FCE0 File Offset: 0x0004DEE0
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x00008C0F File Offset: 0x00006E0F
		public unsafe int readWriteTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_readWriteTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_readWriteTimeout)) = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x0004FD08 File Offset: 0x0004DF08
		// (set) Token: 0x060010E4 RID: 4324 RVA: 0x00008C2A File Offset: 0x00006E2A
		public unsafe MonoTlsProvider tlsProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_tlsProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_tlsProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x0004FD38 File Offset: 0x0004DF38
		// (set) Token: 0x060010E6 RID: 4326 RVA: 0x00008C49 File Offset: 0x00006E49
		public unsafe MonoTlsSettings tlsSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_tlsSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_tlsSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x0004FD68 File Offset: 0x0004DF68
		// (set) Token: 0x060010E8 RID: 4328 RVA: 0x00008C68 File Offset: 0x00006E68
		public unsafe ServerCertValidationCallback certValidationCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_certValidationCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_certValidationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x0004FD98 File Offset: 0x0004DF98
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x00008C87 File Offset: 0x00006E87
		public HttpWebRequest.AuthorizationState auth_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_auth_state);
				return new HttpWebRequest.AuthorizationState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_auth_state), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x0004FDC8 File Offset: 0x0004DFC8
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x00008CB5 File Offset: 0x00006EB5
		public HttpWebRequest.AuthorizationState proxy_auth_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_proxy_auth_state);
				return new HttpWebRequest.AuthorizationState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_proxy_auth_state), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x0004FDF8 File Offset: 0x0004DFF8
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x00008CE3 File Offset: 0x00006EE3
		public unsafe string host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_host);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_host), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x0004FE20 File Offset: 0x0004E020
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x00008D02 File Offset: 0x00006F02
		public unsafe Func<Stream, Task> ResendContentFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_ResendContentFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, Task>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_ResendContentFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x0004FE50 File Offset: 0x0004E050
		// (set) Token: 0x060010F2 RID: 4338 RVA: 0x00008D21 File Offset: 0x00006F21
		public unsafe bool _ThrowOnError_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr__ThrowOnError_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr__ThrowOnError_k__BackingField)) = value;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x0004FE78 File Offset: 0x0004E078
		// (set) Token: 0x060010F4 RID: 4340 RVA: 0x00008D3C File Offset: 0x00006F3C
		public unsafe bool unsafe_auth_blah
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_unsafe_auth_blah);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.NativeFieldInfoPtr_unsafe_auth_blah)) = value;
			}
		}

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeFieldInfoPtr_requestUri;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeFieldInfoPtr_actualUri;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeFieldInfoPtr_hostChanged;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeFieldInfoPtr_allowAutoRedirect;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeFieldInfoPtr_allowBuffering;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeFieldInfoPtr_certificates;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeFieldInfoPtr_connectionGroup;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeFieldInfoPtr_haveContentLength;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeFieldInfoPtr_contentLength;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeFieldInfoPtr_continueDelegate;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeFieldInfoPtr_cookieContainer;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeFieldInfoPtr_credentials;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeFieldInfoPtr_haveResponse;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeFieldInfoPtr_requestSent;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeFieldInfoPtr_webHeaders;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeFieldInfoPtr_keepAlive;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeFieldInfoPtr_maxAutoRedirect;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeFieldInfoPtr_mediaType;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeFieldInfoPtr_initialMethod;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeFieldInfoPtr_pipelined;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeFieldInfoPtr_preAuthenticate;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeFieldInfoPtr_usedPreAuth;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeFieldInfoPtr_force_version;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeFieldInfoPtr_actualVersion;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeFieldInfoPtr_proxy;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeFieldInfoPtr_sendChunked;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeFieldInfoPtr_servicePoint;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeFieldInfoPtr_timeout;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeFieldInfoPtr_writeStream;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeFieldInfoPtr_webResponse;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeFieldInfoPtr_responseTask;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeFieldInfoPtr_currentOperation;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeFieldInfoPtr_aborted;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeFieldInfoPtr_gotRequestStream;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeFieldInfoPtr_redirects;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeFieldInfoPtr_expectContinue;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeFieldInfoPtr_getResponseCalled;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeFieldInfoPtr_finished_reading;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeFieldInfoPtr_auto_decomp;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeFieldInfoPtr_defaultMaxResponseHeadersLength;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeFieldInfoPtr_readWriteTimeout;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeFieldInfoPtr_tlsProvider;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeFieldInfoPtr_tlsSettings;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeFieldInfoPtr_certValidationCallback;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeFieldInfoPtr_auth_state;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeFieldInfoPtr_proxy_auth_state;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeFieldInfoPtr_host;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeFieldInfoPtr_ResendContentFactory;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeFieldInfoPtr__ThrowOnError_k__BackingField;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeFieldInfoPtr_unsafe_auth_blah;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_ResetAuthorization_Private_Void_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_Uri_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_set_Address_Internal_set_Void_Uri_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowWriteStreamBuffering_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_get_AutomaticDecompression_Public_get_DecompressionMethods_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalAllowBuffering_Internal_get_Boolean_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodWithBuffer_Private_get_Boolean_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_get_TlsProvider_Internal_get_MonoTlsProvider_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_get_TlsSettings_Internal_get_MonoTlsSettings_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_set_InternalContentLength_Internal_set_Void_Int64_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_get_ThrowOnError_Internal_get_Boolean_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_set_ThrowOnError_Internal_set_Void_Boolean_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_get_Host_Public_get_String_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtocolVersion_Public_get_Version_0;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_get_SendChunked_Public_get_Boolean_0;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePointNoLock_Internal_get_ServicePoint_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_get_TransferEncoding_Public_get_String_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Public_get_Boolean_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpectContinue_Internal_get_Boolean_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_set_ExpectContinue_Internal_set_Void_Boolean_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthUri_Internal_get_Uri_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_get_ProxyQuery_Internal_get_Boolean_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_get_ServerCertValidationCallback_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_GetServicePoint_Internal_ServicePoint_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_SendRequest_Private_WebOperation_Boolean_BufferOffsetSize_CancellationToken_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_RunWithTimeout_Internal_Static_Task_1_T_Func_2_CancellationToken_Task_1_T_Int32_Action_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_RunWithTimeout_Private_Task_1_T_Func_2_CancellationToken_Task_1_T_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_MyGetResponseAsync_Private_Task_1_HttpWebResponse_CancellationToken_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseFromData_Private_Task_1_ValueTuple_5_HttpWebResponse_Boolean_Boolean_BufferOffsetSize_WebOperation_WebResponseStream_CancellationToken_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_FlattenException_Internal_Static_Exception_Exception_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr_GetWebException_Private_WebException_Exception_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_CreateRequestAbortedException_Internal_Static_WebException_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_set_FinishedReading_Internal_set_Void_Boolean_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_get_Aborted_Internal_get_Boolean_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Void_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr_CheckRequestStarted_Private_Void_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr_DoContinueDelegate_Internal_Void_Int32_WebHeaderCollection_0;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr_RewriteRedirectToGet_Private_Void_0;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_Redirect_Private_Boolean_HttpStatusCode_WebResponse_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_GetHeaders_Private_String_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_DoPreAuthenticate_Private_Void_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestHeaders_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_HandleNtlmAuth_Private_ValueTuple_2_WebOperation_Boolean_WebResponseStream_HttpWebResponse_BufferOffsetSize_CancellationToken_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_CheckAuthorization_Private_Boolean_WebResponse_HttpStatusCode_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_GetRewriteHandler_Private_ValueTuple_2_Task_1_BufferOffsetSize_WebException_HttpWebResponse_Boolean_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_CheckFinalStatus_Private_ValueTuple_4_Boolean_Boolean_Task_1_BufferOffsetSize_WebException_HttpWebResponse_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr__GetRewriteHandler_b__263_0_Private_Task_1_BufferOffsetSize_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001C1 RID: 449
		public enum NtlmAuthState
		{
			// Token: 0x040013B4 RID: 5044
			None,
			// Token: 0x040013B5 RID: 5045
			Challenge,
			// Token: 0x040013B6 RID: 5046
			Response
		}

		// Token: 0x020001C2 RID: 450
		public sealed class AuthorizationState : ValueType
		{
			// Token: 0x060018FD RID: 6397 RVA: 0x0006ABD4 File Offset: 0x00068DD4
			// Note: this type is marked as 'beforefieldinit'.
			static AuthorizationState()
			{
				Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "AuthorizationState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr);
				HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, "request");
				HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, "isProxy");
				HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, "isCompleted");
				HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_ntlm_auth_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, "ntlm_auth_state");
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100665631);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_NtlmAuthState_Public_get_NtlmAuthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100665632);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_IsNtlmAuthenticated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100665633);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100665634);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_CheckAuthorization_Public_Boolean_WebResponse_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100665635);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100665636);
				HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr, 100665637);
			}

			// Token: 0x170007F8 RID: 2040
			// (get) Token: 0x060018FE RID: 6398 RVA: 0x0006ACDC File Offset: 0x00068EDC
			public unsafe bool IsCompleted
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170007F9 RID: 2041
			// (get) Token: 0x060018FF RID: 6399 RVA: 0x0006AD20 File Offset: 0x00068F20
			public unsafe HttpWebRequest.NtlmAuthState NtlmAuthState
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_NtlmAuthState_Public_get_NtlmAuthState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170007FA RID: 2042
			// (get) Token: 0x06001900 RID: 6400 RVA: 0x0006AD64 File Offset: 0x00068F64
			public unsafe bool IsNtlmAuthenticated
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_get_IsNtlmAuthenticated_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001901 RID: 6401 RVA: 0x0006ADA8 File Offset: 0x00068FA8
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 51467, RefRangeEnd = 51475, XrefRangeStart = 51467, XrefRangeEnd = 51467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AuthorizationState(HttpWebRequest request, bool isProxy)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isProxy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001902 RID: 6402 RVA: 0x0006AE08 File Offset: 0x00069008
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 51499, RefRangeEnd = 51502, XrefRangeStart = 51475, XrefRangeEnd = 51499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool CheckAuthorization(WebResponse response, HttpStatusCode code)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_CheckAuthorization_Public_Boolean_WebResponse_HttpStatusCode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001903 RID: 6403 RVA: 0x0006AE68 File Offset: 0x00069068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51502, XrefRangeEnd = 51508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001904 RID: 6404 RVA: 0x0006AEA0 File Offset: 0x000690A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51508, XrefRangeEnd = 51521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.AuthorizationState.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06001905 RID: 6405 RVA: 0x0000D1A4 File Offset: 0x0000B3A4
			public AuthorizationState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001906 RID: 6406 RVA: 0x0000D1AD File Offset: 0x0000B3AD
			public AuthorizationState()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest.AuthorizationState>.NativeClassPtr))
			{
			}

			// Token: 0x170007F4 RID: 2036
			// (get) Token: 0x06001907 RID: 6407 RVA: 0x0006AEDC File Offset: 0x000690DC
			// (set) Token: 0x06001908 RID: 6408 RVA: 0x0000D1BF File Offset: 0x0000B3BF
			public unsafe HttpWebRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007F5 RID: 2037
			// (get) Token: 0x06001909 RID: 6409 RVA: 0x0006AF0C File Offset: 0x0006910C
			// (set) Token: 0x0600190A RID: 6410 RVA: 0x0000D1DE File Offset: 0x0000B3DE
			public unsafe bool isProxy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isProxy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isProxy)) = value;
				}
			}

			// Token: 0x170007F6 RID: 2038
			// (get) Token: 0x0600190B RID: 6411 RVA: 0x0006AF34 File Offset: 0x00069134
			// (set) Token: 0x0600190C RID: 6412 RVA: 0x0000D1F9 File Offset: 0x0000B3F9
			public unsafe bool isCompleted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isCompleted);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_isCompleted)) = value;
				}
			}

			// Token: 0x170007F7 RID: 2039
			// (get) Token: 0x0600190D RID: 6413 RVA: 0x0006AF5C File Offset: 0x0006915C
			// (set) Token: 0x0600190E RID: 6414 RVA: 0x0000D214 File Offset: 0x0000B414
			public unsafe HttpWebRequest.NtlmAuthState ntlm_auth_state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_ntlm_auth_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.AuthorizationState.NativeFieldInfoPtr_ntlm_auth_state)) = value;
				}
			}

			// Token: 0x040013B7 RID: 5047
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x040013B8 RID: 5048
			private static readonly IntPtr NativeFieldInfoPtr_isProxy;

			// Token: 0x040013B9 RID: 5049
			private static readonly IntPtr NativeFieldInfoPtr_isCompleted;

			// Token: 0x040013BA RID: 5050
			private static readonly IntPtr NativeFieldInfoPtr_ntlm_auth_state;

			// Token: 0x040013BB RID: 5051
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

			// Token: 0x040013BC RID: 5052
			private static readonly IntPtr NativeMethodInfoPtr_get_NtlmAuthState_Public_get_NtlmAuthState_0;

			// Token: 0x040013BD RID: 5053
			private static readonly IntPtr NativeMethodInfoPtr_get_IsNtlmAuthenticated_Public_get_Boolean_0;

			// Token: 0x040013BE RID: 5054
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Boolean_0;

			// Token: 0x040013BF RID: 5055
			private static readonly IntPtr NativeMethodInfoPtr_CheckAuthorization_Public_Boolean_WebResponse_HttpStatusCode_0;

			// Token: 0x040013C0 RID: 5056
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

			// Token: 0x040013C1 RID: 5057
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}

		// Token: 0x020001C3 RID: 451
		[ObfuscatedName("System.Net.HttpWebRequest+<>c__234`1")]
		[Serializable]
		public sealed class __c__234<T> : Object
		{
			// Token: 0x0600190F RID: 6415 RVA: 0x0006AF84 File Offset: 0x00069184
			// Note: this type is marked as 'beforefieldinit'.
			static __c__234()
			{
				Il2CppClassPointerStore<HttpWebRequest.__c__234<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<>c__234`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest.__c__234<T>>.NativeClassPtr);
				HttpWebRequest.__c__234<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__c__234<T>>.NativeClassPtr, "<>9");
				HttpWebRequest.__c__234<T>.NativeFieldInfoPtr___9__234_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__c__234<T>>.NativeClassPtr, "<>9__234_0");
				HttpWebRequest.__c__234<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.__c__234<T>>.NativeClassPtr, 100665639);
				HttpWebRequest.__c__234<T>.NativeMethodInfoPtr__RunWithTimeout_b__234_0_Internal_Nullable_1_Int32_Task_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.__c__234<T>>.NativeClassPtr, 100665640);
			}

			// Token: 0x06001910 RID: 6416 RVA: 0x0006B03C File Offset: 0x0006923C
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__234()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest.__c__234<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.__c__234<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001911 RID: 6417 RVA: 0x0006B078 File Offset: 0x00069278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51521, XrefRangeEnd = 51525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<int> _RunWithTimeout_b__234_0(Task<T> t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.__c__234<T>.NativeMethodInfoPtr__RunWithTimeout_b__234_0_Internal_Nullable_1_Int32_Task_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<int>(intPtr);
				}
			}

			// Token: 0x06001912 RID: 6418 RVA: 0x0000D22F File Offset: 0x0000B42F
			public __c__234(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007FB RID: 2043
			// (get) Token: 0x06001913 RID: 6419 RVA: 0x0006B0C0 File Offset: 0x000692C0
			// (set) Token: 0x06001914 RID: 6420 RVA: 0x0000D238 File Offset: 0x0000B438
			public unsafe static HttpWebRequest.__c__234<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HttpWebRequest.__c__234<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest.__c__234<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HttpWebRequest.__c__234<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007FC RID: 2044
			// (get) Token: 0x06001915 RID: 6421 RVA: 0x0006B0E8 File Offset: 0x000692E8
			// (set) Token: 0x06001916 RID: 6422 RVA: 0x0000D24A File Offset: 0x0000B44A
			public unsafe static Func<Task<T>, Nullable<int>> __9__234_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HttpWebRequest.__c__234<T>.NativeFieldInfoPtr___9__234_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Task<T>, Nullable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HttpWebRequest.__c__234<T>.NativeFieldInfoPtr___9__234_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013C2 RID: 5058
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040013C3 RID: 5059
			private static readonly IntPtr NativeFieldInfoPtr___9__234_0;

			// Token: 0x040013C4 RID: 5060
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013C5 RID: 5061
			private static readonly IntPtr NativeMethodInfoPtr__RunWithTimeout_b__234_0_Internal_Nullable_1_Int32_Task_1_T_0;
		}

		// Token: 0x020001C4 RID: 452
		[ObfuscatedName("System.Net.HttpWebRequest+<RunWithTimeout>d__234`1")]
		public sealed class _RunWithTimeout_d__234<T> : ValueType
		{
			// Token: 0x06001917 RID: 6423 RVA: 0x0006B110 File Offset: 0x00069310
			// Note: this type is marked as 'beforefieldinit'.
			static _RunWithTimeout_d__234()
			{
				Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<RunWithTimeout>d__234`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr);
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "<>1__state");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "<>t__builder");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "timeout");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_func = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "func");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__timeoutTask_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "<timeoutTask>5__1");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__cts_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "<cts>5__2");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_abort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "abort");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__workerTask_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "<workerTask>5__3");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, "<>u__1");
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, 100665641);
				HttpWebRequest._RunWithTimeout_d__234<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr, 100665642);
			}

			// Token: 0x06001918 RID: 6424 RVA: 0x0006B254 File Offset: 0x00069454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51525, XrefRangeEnd = 51567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._RunWithTimeout_d__234<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001919 RID: 6425 RVA: 0x0006B28C File Offset: 0x0006948C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51567, XrefRangeEnd = 51581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._RunWithTimeout_d__234<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600191A RID: 6426 RVA: 0x0000D25C File Offset: 0x0000B45C
			public _RunWithTimeout_d__234(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600191B RID: 6427 RVA: 0x0000D265 File Offset: 0x0000B465
			public _RunWithTimeout_d__234()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest._RunWithTimeout_d__234<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170007FD RID: 2045
			// (get) Token: 0x0600191C RID: 6428 RVA: 0x0006B2D4 File Offset: 0x000694D4
			// (set) Token: 0x0600191D RID: 6429 RVA: 0x0000D277 File Offset: 0x0000B477
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007FE RID: 2046
			// (get) Token: 0x0600191E RID: 6430 RVA: 0x0006B2FC File Offset: 0x000694FC
			// (set) Token: 0x0600191F RID: 6431 RVA: 0x0000D292 File Offset: 0x0000B492
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007FF RID: 2047
			// (get) Token: 0x06001920 RID: 6432 RVA: 0x0006B32C File Offset: 0x0006952C
			// (set) Token: 0x06001921 RID: 6433 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
			public unsafe int timeout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_timeout);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_timeout)) = value;
				}
			}

			// Token: 0x17000800 RID: 2048
			// (get) Token: 0x06001922 RID: 6434 RVA: 0x0006B354 File Offset: 0x00069554
			// (set) Token: 0x06001923 RID: 6435 RVA: 0x0000D2DB File Offset: 0x0000B4DB
			public unsafe Func<CancellationToken, Task<T>> func
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_func);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CancellationToken, Task<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_func), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000801 RID: 2049
			// (get) Token: 0x06001924 RID: 6436 RVA: 0x0006B384 File Offset: 0x00069584
			// (set) Token: 0x06001925 RID: 6437 RVA: 0x0000D2FA File Offset: 0x0000B4FA
			public unsafe Task _timeoutTask_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__timeoutTask_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__timeoutTask_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000802 RID: 2050
			// (get) Token: 0x06001926 RID: 6438 RVA: 0x0006B3B4 File Offset: 0x000695B4
			// (set) Token: 0x06001927 RID: 6439 RVA: 0x0000D319 File Offset: 0x0000B519
			public unsafe CancellationTokenSource _cts_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__cts_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__cts_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000803 RID: 2051
			// (get) Token: 0x06001928 RID: 6440 RVA: 0x0006B3E4 File Offset: 0x000695E4
			// (set) Token: 0x06001929 RID: 6441 RVA: 0x0000D338 File Offset: 0x0000B538
			public unsafe Action abort
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_abort);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr_abort), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000804 RID: 2052
			// (get) Token: 0x0600192A RID: 6442 RVA: 0x0006B414 File Offset: 0x00069614
			// (set) Token: 0x0600192B RID: 6443 RVA: 0x0000D357 File Offset: 0x0000B557
			public unsafe Task<T> _workerTask_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__workerTask_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr__workerTask_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000805 RID: 2053
			// (get) Token: 0x0600192C RID: 6444 RVA: 0x0006B444 File Offset: 0x00069644
			// (set) Token: 0x0600192D RID: 6445 RVA: 0x0000D376 File Offset: 0x0000B576
			public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._RunWithTimeout_d__234<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040013C6 RID: 5062
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040013C7 RID: 5063
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040013C8 RID: 5064
			private static readonly IntPtr NativeFieldInfoPtr_timeout;

			// Token: 0x040013C9 RID: 5065
			private static readonly IntPtr NativeFieldInfoPtr_func;

			// Token: 0x040013CA RID: 5066
			private static readonly IntPtr NativeFieldInfoPtr__timeoutTask_5__1;

			// Token: 0x040013CB RID: 5067
			private static readonly IntPtr NativeFieldInfoPtr__cts_5__2;

			// Token: 0x040013CC RID: 5068
			private static readonly IntPtr NativeFieldInfoPtr_abort;

			// Token: 0x040013CD RID: 5069
			private static readonly IntPtr NativeFieldInfoPtr__workerTask_5__3;

			// Token: 0x040013CE RID: 5070
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040013CF RID: 5071
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013D0 RID: 5072
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001C5 RID: 453
		[ObfuscatedName("System.Net.HttpWebRequest+<MyGetResponseAsync>d__236")]
		public sealed class _MyGetResponseAsync_d__236 : ValueType
		{
			// Token: 0x0600192E RID: 6446 RVA: 0x0006B474 File Offset: 0x00069674
			// Note: this type is marked as 'beforefieldinit'.
			static _MyGetResponseAsync_d__236()
			{
				Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<MyGetResponseAsync>d__236");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr);
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<>1__state");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<>t__builder");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<>4__this");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "cancellationToken");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__operation_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<operation>5__1");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__throwMe_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<throwMe>5__2");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__completion_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<completion>5__3");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__redirect_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<redirect>5__4");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__response_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<response>5__5");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__ntlm_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<ntlm>5__6");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__mustReadAll_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<mustReadAll>5__7");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__stream_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<stream>5__8");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__writeBuffer_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<writeBuffer>5__9");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<>u__1");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<>u__2");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<>u__3");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, "<>u__4");
				HttpWebRequest._MyGetResponseAsync_d__236.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, 100665643);
				HttpWebRequest._MyGetResponseAsync_d__236.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr, 100665644);
			}

			// Token: 0x0600192F RID: 6447 RVA: 0x0006B61C File Offset: 0x0006981C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51581, XrefRangeEnd = 51667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._MyGetResponseAsync_d__236.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001930 RID: 6448 RVA: 0x0006B654 File Offset: 0x00069854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51667, XrefRangeEnd = 51670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._MyGetResponseAsync_d__236.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001931 RID: 6449 RVA: 0x0000D3A4 File Offset: 0x0000B5A4
			public _MyGetResponseAsync_d__236(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001932 RID: 6450 RVA: 0x0000D3AD File Offset: 0x0000B5AD
			public _MyGetResponseAsync_d__236()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest._MyGetResponseAsync_d__236>.NativeClassPtr))
			{
			}

			// Token: 0x17000806 RID: 2054
			// (get) Token: 0x06001933 RID: 6451 RVA: 0x0006B69C File Offset: 0x0006989C
			// (set) Token: 0x06001934 RID: 6452 RVA: 0x0000D3BF File Offset: 0x0000B5BF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000807 RID: 2055
			// (get) Token: 0x06001935 RID: 6453 RVA: 0x0006B6C4 File Offset: 0x000698C4
			// (set) Token: 0x06001936 RID: 6454 RVA: 0x0000D3DA File Offset: 0x0000B5DA
			public AsyncTaskMethodBuilder<HttpWebResponse> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<HttpWebResponse>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpWebResponse>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpWebResponse>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000808 RID: 2056
			// (get) Token: 0x06001937 RID: 6455 RVA: 0x0006B6F4 File Offset: 0x000698F4
			// (set) Token: 0x06001938 RID: 6456 RVA: 0x0000D408 File Offset: 0x0000B608
			public unsafe HttpWebRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000809 RID: 2057
			// (get) Token: 0x06001939 RID: 6457 RVA: 0x0006B724 File Offset: 0x00069924
			// (set) Token: 0x0600193A RID: 6458 RVA: 0x0000D427 File Offset: 0x0000B627
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700080A RID: 2058
			// (get) Token: 0x0600193B RID: 6459 RVA: 0x0006B754 File Offset: 0x00069954
			// (set) Token: 0x0600193C RID: 6460 RVA: 0x0000D455 File Offset: 0x0000B655
			public unsafe WebOperation _operation_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__operation_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__operation_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700080B RID: 2059
			// (get) Token: 0x0600193D RID: 6461 RVA: 0x0006B784 File Offset: 0x00069984
			// (set) Token: 0x0600193E RID: 6462 RVA: 0x0000D474 File Offset: 0x0000B674
			public unsafe WebException _throwMe_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__throwMe_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__throwMe_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700080C RID: 2060
			// (get) Token: 0x0600193F RID: 6463 RVA: 0x0006B7B4 File Offset: 0x000699B4
			// (set) Token: 0x06001940 RID: 6464 RVA: 0x0000D493 File Offset: 0x0000B693
			public unsafe WebCompletionSource _completion_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__completion_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__completion_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700080D RID: 2061
			// (get) Token: 0x06001941 RID: 6465 RVA: 0x0006B7E4 File Offset: 0x000699E4
			// (set) Token: 0x06001942 RID: 6466 RVA: 0x0000D4B2 File Offset: 0x0000B6B2
			public unsafe bool _redirect_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__redirect_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__redirect_5__4)) = value;
				}
			}

			// Token: 0x1700080E RID: 2062
			// (get) Token: 0x06001943 RID: 6467 RVA: 0x0006B80C File Offset: 0x00069A0C
			// (set) Token: 0x06001944 RID: 6468 RVA: 0x0000D4CD File Offset: 0x0000B6CD
			public unsafe HttpWebResponse _response_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__response_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebResponse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__response_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700080F RID: 2063
			// (get) Token: 0x06001945 RID: 6469 RVA: 0x0006B83C File Offset: 0x00069A3C
			// (set) Token: 0x06001946 RID: 6470 RVA: 0x0000D4EC File Offset: 0x0000B6EC
			public unsafe WebOperation _ntlm_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__ntlm_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__ntlm_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000810 RID: 2064
			// (get) Token: 0x06001947 RID: 6471 RVA: 0x0006B86C File Offset: 0x00069A6C
			// (set) Token: 0x06001948 RID: 6472 RVA: 0x0000D50B File Offset: 0x0000B70B
			public unsafe bool _mustReadAll_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__mustReadAll_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__mustReadAll_5__7)) = value;
				}
			}

			// Token: 0x17000811 RID: 2065
			// (get) Token: 0x06001949 RID: 6473 RVA: 0x0006B894 File Offset: 0x00069A94
			// (set) Token: 0x0600194A RID: 6474 RVA: 0x0000D526 File Offset: 0x0000B726
			public unsafe WebResponseStream _stream_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__stream_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__stream_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000812 RID: 2066
			// (get) Token: 0x0600194B RID: 6475 RVA: 0x0006B8C4 File Offset: 0x00069AC4
			// (set) Token: 0x0600194C RID: 6476 RVA: 0x0000D545 File Offset: 0x0000B745
			public unsafe BufferOffsetSize _writeBuffer_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__writeBuffer_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr__writeBuffer_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000813 RID: 2067
			// (get) Token: 0x0600194D RID: 6477 RVA: 0x0006B8F4 File Offset: 0x00069AF4
			// (set) Token: 0x0600194E RID: 6478 RVA: 0x0000D564 File Offset: 0x0000B764
			public TaskAwaiter<WebRequestStream> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<WebRequestStream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<WebRequestStream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<WebRequestStream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000814 RID: 2068
			// (get) Token: 0x0600194F RID: 6479 RVA: 0x0006B924 File Offset: 0x00069B24
			// (set) Token: 0x06001950 RID: 6480 RVA: 0x0000D592 File Offset: 0x0000B792
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000815 RID: 2069
			// (get) Token: 0x06001951 RID: 6481 RVA: 0x0006B954 File Offset: 0x00069B54
			// (set) Token: 0x06001952 RID: 6482 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
			public TaskAwaiter<WebResponseStream> __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__3);
					return new TaskAwaiter<WebResponseStream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<WebResponseStream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<WebResponseStream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000816 RID: 2070
			// (get) Token: 0x06001953 RID: 6483 RVA: 0x0006B984 File Offset: 0x00069B84
			// (set) Token: 0x06001954 RID: 6484 RVA: 0x0000D5EE File Offset: 0x0000B7EE
			public ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.ConfiguredTaskAwaiter __u__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__4);
					return new ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._MyGetResponseAsync_d__236.NativeFieldInfoPtr___u__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040013D1 RID: 5073
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040013D2 RID: 5074
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040013D3 RID: 5075
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040013D4 RID: 5076
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040013D5 RID: 5077
			private static readonly IntPtr NativeFieldInfoPtr__operation_5__1;

			// Token: 0x040013D6 RID: 5078
			private static readonly IntPtr NativeFieldInfoPtr__throwMe_5__2;

			// Token: 0x040013D7 RID: 5079
			private static readonly IntPtr NativeFieldInfoPtr__completion_5__3;

			// Token: 0x040013D8 RID: 5080
			private static readonly IntPtr NativeFieldInfoPtr__redirect_5__4;

			// Token: 0x040013D9 RID: 5081
			private static readonly IntPtr NativeFieldInfoPtr__response_5__5;

			// Token: 0x040013DA RID: 5082
			private static readonly IntPtr NativeFieldInfoPtr__ntlm_5__6;

			// Token: 0x040013DB RID: 5083
			private static readonly IntPtr NativeFieldInfoPtr__mustReadAll_5__7;

			// Token: 0x040013DC RID: 5084
			private static readonly IntPtr NativeFieldInfoPtr__stream_5__8;

			// Token: 0x040013DD RID: 5085
			private static readonly IntPtr NativeFieldInfoPtr__writeBuffer_5__9;

			// Token: 0x040013DE RID: 5086
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040013DF RID: 5087
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040013E0 RID: 5088
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x040013E1 RID: 5089
			private static readonly IntPtr NativeFieldInfoPtr___u__4;

			// Token: 0x040013E2 RID: 5090
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013E3 RID: 5091
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001C6 RID: 454
		[ObfuscatedName("System.Net.HttpWebRequest+<GetResponseFromData>d__237")]
		public sealed class _GetResponseFromData_d__237 : ValueType
		{
			// Token: 0x06001955 RID: 6485 RVA: 0x0006B9B4 File Offset: 0x00069BB4
			// Note: this type is marked as 'beforefieldinit'.
			static _GetResponseFromData_d__237()
			{
				Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<GetResponseFromData>d__237");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr);
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<>1__state");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<>t__builder");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<>4__this");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "stream");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "cancellationToken");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__throwMe_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<throwMe>5__1");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__rewriteHandler_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<rewriteHandler>5__2");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__redirect_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<redirect>5__3");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__response_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<response>5__4");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__writeBuffer_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<writeBuffer>5__5");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__mustReadAll_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<mustReadAll>5__6");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<>u__1");
				HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, "<>u__2");
				HttpWebRequest._GetResponseFromData_d__237.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, 100665645);
				HttpWebRequest._GetResponseFromData_d__237.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr, 100665646);
			}

			// Token: 0x06001956 RID: 6486 RVA: 0x0006BB0C File Offset: 0x00069D0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51670, XrefRangeEnd = 51725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._GetResponseFromData_d__237.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001957 RID: 6487 RVA: 0x0006BB44 File Offset: 0x00069D44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51725, XrefRangeEnd = 51728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest._GetResponseFromData_d__237.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001958 RID: 6488 RVA: 0x0000D61C File Offset: 0x0000B81C
			public _GetResponseFromData_d__237(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001959 RID: 6489 RVA: 0x0000D625 File Offset: 0x0000B825
			public _GetResponseFromData_d__237()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest._GetResponseFromData_d__237>.NativeClassPtr))
			{
			}

			// Token: 0x17000817 RID: 2071
			// (get) Token: 0x0600195A RID: 6490 RVA: 0x0006BB8C File Offset: 0x00069D8C
			// (set) Token: 0x0600195B RID: 6491 RVA: 0x0000D637 File Offset: 0x0000B837
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000818 RID: 2072
			// (get) Token: 0x0600195C RID: 6492 RVA: 0x0006BBB4 File Offset: 0x00069DB4
			// (set) Token: 0x0600195D RID: 6493 RVA: 0x0000D652 File Offset: 0x0000B852
			public AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000819 RID: 2073
			// (get) Token: 0x0600195E RID: 6494 RVA: 0x0006BBE4 File Offset: 0x00069DE4
			// (set) Token: 0x0600195F RID: 6495 RVA: 0x0000D680 File Offset: 0x0000B880
			public unsafe HttpWebRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700081A RID: 2074
			// (get) Token: 0x06001960 RID: 6496 RVA: 0x0006BC14 File Offset: 0x00069E14
			// (set) Token: 0x06001961 RID: 6497 RVA: 0x0000D69F File Offset: 0x0000B89F
			public unsafe WebResponseStream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700081B RID: 2075
			// (get) Token: 0x06001962 RID: 6498 RVA: 0x0006BC44 File Offset: 0x00069E44
			// (set) Token: 0x06001963 RID: 6499 RVA: 0x0000D6BE File Offset: 0x0000B8BE
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700081C RID: 2076
			// (get) Token: 0x06001964 RID: 6500 RVA: 0x0006BC74 File Offset: 0x00069E74
			// (set) Token: 0x06001965 RID: 6501 RVA: 0x0000D6EC File Offset: 0x0000B8EC
			public unsafe WebException _throwMe_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__throwMe_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__throwMe_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700081D RID: 2077
			// (get) Token: 0x06001966 RID: 6502 RVA: 0x0006BCA4 File Offset: 0x00069EA4
			// (set) Token: 0x06001967 RID: 6503 RVA: 0x0000D70B File Offset: 0x0000B90B
			public unsafe Task<BufferOffsetSize> _rewriteHandler_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__rewriteHandler_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<BufferOffsetSize>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__rewriteHandler_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700081E RID: 2078
			// (get) Token: 0x06001968 RID: 6504 RVA: 0x0006BCD4 File Offset: 0x00069ED4
			// (set) Token: 0x06001969 RID: 6505 RVA: 0x0000D72A File Offset: 0x0000B92A
			public unsafe bool _redirect_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__redirect_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__redirect_5__3)) = value;
				}
			}

			// Token: 0x1700081F RID: 2079
			// (get) Token: 0x0600196A RID: 6506 RVA: 0x0006BCFC File Offset: 0x00069EFC
			// (set) Token: 0x0600196B RID: 6507 RVA: 0x0000D745 File Offset: 0x0000B945
			public unsafe HttpWebResponse _response_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__response_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebResponse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__response_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000820 RID: 2080
			// (get) Token: 0x0600196C RID: 6508 RVA: 0x0006BD2C File Offset: 0x00069F2C
			// (set) Token: 0x0600196D RID: 6509 RVA: 0x0000D764 File Offset: 0x0000B964
			public unsafe BufferOffsetSize _writeBuffer_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__writeBuffer_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__writeBuffer_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000821 RID: 2081
			// (get) Token: 0x0600196E RID: 6510 RVA: 0x0006BD5C File Offset: 0x00069F5C
			// (set) Token: 0x0600196F RID: 6511 RVA: 0x0000D783 File Offset: 0x0000B983
			public unsafe bool _mustReadAll_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__mustReadAll_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr__mustReadAll_5__6)) = value;
				}
			}

			// Token: 0x17000822 RID: 2082
			// (get) Token: 0x06001970 RID: 6512 RVA: 0x0006BD84 File Offset: 0x00069F84
			// (set) Token: 0x06001971 RID: 6513 RVA: 0x0000D79E File Offset: 0x0000B99E
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000823 RID: 2083
			// (get) Token: 0x06001972 RID: 6514 RVA: 0x0006BDB4 File Offset: 0x00069FB4
			// (set) Token: 0x06001973 RID: 6515 RVA: 0x0000D7CC File Offset: 0x0000B9CC
			public ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest._GetResponseFromData_d__237.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040013E4 RID: 5092
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040013E5 RID: 5093
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040013E6 RID: 5094
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040013E7 RID: 5095
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x040013E8 RID: 5096
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040013E9 RID: 5097
			private static readonly IntPtr NativeFieldInfoPtr__throwMe_5__1;

			// Token: 0x040013EA RID: 5098
			private static readonly IntPtr NativeFieldInfoPtr__rewriteHandler_5__2;

			// Token: 0x040013EB RID: 5099
			private static readonly IntPtr NativeFieldInfoPtr__redirect_5__3;

			// Token: 0x040013EC RID: 5100
			private static readonly IntPtr NativeFieldInfoPtr__response_5__4;

			// Token: 0x040013ED RID: 5101
			private static readonly IntPtr NativeFieldInfoPtr__writeBuffer_5__5;

			// Token: 0x040013EE RID: 5102
			private static readonly IntPtr NativeFieldInfoPtr__mustReadAll_5__6;

			// Token: 0x040013EF RID: 5103
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040013F0 RID: 5104
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040013F1 RID: 5105
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013F2 RID: 5106
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001C7 RID: 455
		[ObfuscatedName("System.Net.HttpWebRequest+<<GetRewriteHandler>b__263_0>d")]
		public sealed class __GetRewriteHandler_b__263_0_d : ValueType
		{
			// Token: 0x06001974 RID: 6516 RVA: 0x0006BDE4 File Offset: 0x00069FE4
			// Note: this type is marked as 'beforefieldinit'.
			static __GetRewriteHandler_b__263_0_d()
			{
				Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr, "<<GetRewriteHandler>b__263_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr);
				HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr, "<>1__state");
				HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr, "<>t__builder");
				HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr, "<>4__this");
				HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr__ms_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr, "<ms>5__1");
				HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr, "<>u__1");
				HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr, 100665647);
				HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr, 100665648);
			}

			// Token: 0x06001975 RID: 6517 RVA: 0x0006BE9C File Offset: 0x0006A09C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51728, XrefRangeEnd = 51755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001976 RID: 6518 RVA: 0x0006BED4 File Offset: 0x0006A0D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51755, XrefRangeEnd = 51758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001977 RID: 6519 RVA: 0x0000D7FA File Offset: 0x0000B9FA
			public __GetRewriteHandler_b__263_0_d(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001978 RID: 6520 RVA: 0x0000D803 File Offset: 0x0000BA03
			public __GetRewriteHandler_b__263_0_d()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequest.__GetRewriteHandler_b__263_0_d>.NativeClassPtr))
			{
			}

			// Token: 0x17000824 RID: 2084
			// (get) Token: 0x06001979 RID: 6521 RVA: 0x0006BF1C File Offset: 0x0006A11C
			// (set) Token: 0x0600197A RID: 6522 RVA: 0x0000D815 File Offset: 0x0000BA15
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000825 RID: 2085
			// (get) Token: 0x0600197B RID: 6523 RVA: 0x0006BF44 File Offset: 0x0006A144
			// (set) Token: 0x0600197C RID: 6524 RVA: 0x0000D830 File Offset: 0x0000BA30
			public AsyncTaskMethodBuilder<BufferOffsetSize> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<BufferOffsetSize>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<BufferOffsetSize>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<BufferOffsetSize>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000826 RID: 2086
			// (get) Token: 0x0600197D RID: 6525 RVA: 0x0006BF74 File Offset: 0x0006A174
			// (set) Token: 0x0600197E RID: 6526 RVA: 0x0000D85E File Offset: 0x0000BA5E
			public unsafe HttpWebRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000827 RID: 2087
			// (get) Token: 0x0600197F RID: 6527 RVA: 0x0006BFA4 File Offset: 0x0006A1A4
			// (set) Token: 0x06001980 RID: 6528 RVA: 0x0000D87D File Offset: 0x0000BA7D
			public unsafe MemoryStream _ms_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr__ms_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr__ms_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000828 RID: 2088
			// (get) Token: 0x06001981 RID: 6529 RVA: 0x0006BFD4 File Offset: 0x0006A1D4
			// (set) Token: 0x06001982 RID: 6530 RVA: 0x0000D89C File Offset: 0x0000BA9C
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpWebRequest.__GetRewriteHandler_b__263_0_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040013F3 RID: 5107
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040013F4 RID: 5108
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040013F5 RID: 5109
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040013F6 RID: 5110
			private static readonly IntPtr NativeFieldInfoPtr__ms_5__1;

			// Token: 0x040013F7 RID: 5111
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040013F8 RID: 5112
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013F9 RID: 5113
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001C8 RID: 456
		private sealed class MethodInfoStoreGeneric_RunWithTimeout_Internal_Static_Task_1_T_Func_2_CancellationToken_Task_1_T_Int32_Action_0<T>
		{
			// Token: 0x040013FA RID: 5114
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpWebRequest.NativeMethodInfoPtr_RunWithTimeout_Internal_Static_Task_1_T_Func_2_CancellationToken_Task_1_T_Int32_Action_0, Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001C9 RID: 457
		private sealed class MethodInfoStoreGeneric_RunWithTimeout_Private_Task_1_T_Func_2_CancellationToken_Task_1_T_0<T>
		{
			// Token: 0x040013FB RID: 5115
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpWebRequest.NativeMethodInfoPtr_RunWithTimeout_Private_Task_1_T_Func_2_CancellationToken_Task_1_T_0, Il2CppClassPointerStore<HttpWebRequest>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
