using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Text;

namespace Il2CppSystem.Net
{
	// Token: 0x0200010A RID: 266
	public sealed class FtpWebRequest : WebRequest
	{
		// Token: 0x06000F9B RID: 3995 RVA: 0x0004B288 File Offset: 0x00049488
		// Note: this type is marked as 'beforefieldinit'.
		static FtpWebRequest()
		{
			Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FtpWebRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr);
			FtpWebRequest.NativeFieldInfoPtr_requestUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "requestUri");
			FtpWebRequest.NativeFieldInfoPtr_file_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "file_name");
			FtpWebRequest.NativeFieldInfoPtr_servicePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "servicePoint");
			FtpWebRequest.NativeFieldInfoPtr_origDataStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "origDataStream");
			FtpWebRequest.NativeFieldInfoPtr_dataStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "dataStream");
			FtpWebRequest.NativeFieldInfoPtr_controlStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "controlStream");
			FtpWebRequest.NativeFieldInfoPtr_controlReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "controlReader");
			FtpWebRequest.NativeFieldInfoPtr_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "credentials");
			FtpWebRequest.NativeFieldInfoPtr_hostEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "hostEntry");
			FtpWebRequest.NativeFieldInfoPtr_localEndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "localEndPoint");
			FtpWebRequest.NativeFieldInfoPtr_remoteEndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "remoteEndPoint");
			FtpWebRequest.NativeFieldInfoPtr_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "proxy");
			FtpWebRequest.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "timeout");
			FtpWebRequest.NativeFieldInfoPtr_rwTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "rwTimeout");
			FtpWebRequest.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "offset");
			FtpWebRequest.NativeFieldInfoPtr_binary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "binary");
			FtpWebRequest.NativeFieldInfoPtr_enableSsl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "enableSsl");
			FtpWebRequest.NativeFieldInfoPtr_usePassive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "usePassive");
			FtpWebRequest.NativeFieldInfoPtr_keepAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "keepAlive");
			FtpWebRequest.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "method");
			FtpWebRequest.NativeFieldInfoPtr_renameTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "renameTo");
			FtpWebRequest.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "locker");
			FtpWebRequest.NativeFieldInfoPtr_requestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "requestState");
			FtpWebRequest.NativeFieldInfoPtr_asyncResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "asyncResult");
			FtpWebRequest.NativeFieldInfoPtr_ftpResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "ftpResponse");
			FtpWebRequest.NativeFieldInfoPtr_requestStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "requestStream");
			FtpWebRequest.NativeFieldInfoPtr_initial_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "initial_path");
			FtpWebRequest.NativeFieldInfoPtr_supportedCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "supportedCommands");
			FtpWebRequest.NativeFieldInfoPtr_dataEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, "dataEncoding");
			FtpWebRequest.NativeMethodInfoPtr__ctor_Internal_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665481);
			FtpWebRequest.NativeMethodInfoPtr_GetMustImplement_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665482);
			FtpWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665483);
			FtpWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665484);
			FtpWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665485);
			FtpWebRequest.NativeMethodInfoPtr_get_EnableSsl_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665486);
			FtpWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665487);
			FtpWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665488);
			FtpWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665489);
			FtpWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665490);
			FtpWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665491);
			FtpWebRequest.NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665492);
			FtpWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665493);
			FtpWebRequest.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665494);
			FtpWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665495);
			FtpWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665496);
			FtpWebRequest.NativeMethodInfoPtr_get_DataType_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665497);
			FtpWebRequest.NativeMethodInfoPtr_get_State_Private_get_RequestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665498);
			FtpWebRequest.NativeMethodInfoPtr_set_State_Private_set_Void_RequestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665499);
			FtpWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665500);
			FtpWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665501);
			FtpWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665502);
			FtpWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665503);
			FtpWebRequest.NativeMethodInfoPtr_GetServicePoint_Private_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665504);
			FtpWebRequest.NativeMethodInfoPtr_ResolveHost_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665505);
			FtpWebRequest.NativeMethodInfoPtr_ProcessRequest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665506);
			FtpWebRequest.NativeMethodInfoPtr_SetType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665507);
			FtpWebRequest.NativeMethodInfoPtr_GetRemoteFolderPath_Private_String_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665508);
			FtpWebRequest.NativeMethodInfoPtr_CWDAndSetFileName_Private_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665509);
			FtpWebRequest.NativeMethodInfoPtr_ProcessMethod_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665510);
			FtpWebRequest.NativeMethodInfoPtr_CloseControlConnection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665511);
			FtpWebRequest.NativeMethodInfoPtr_CloseDataConnection_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665512);
			FtpWebRequest.NativeMethodInfoPtr_CloseConnection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665513);
			FtpWebRequest.NativeMethodInfoPtr_ProcessSimpleMethod_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665514);
			FtpWebRequest.NativeMethodInfoPtr_UploadData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665515);
			FtpWebRequest.NativeMethodInfoPtr_DownloadData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665516);
			FtpWebRequest.NativeMethodInfoPtr_CheckRequestStarted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665517);
			FtpWebRequest.NativeMethodInfoPtr_OpenControlConnection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665518);
			FtpWebRequest.NativeMethodInfoPtr_GetInitialPath_Private_Static_String_FtpStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665519);
			FtpWebRequest.NativeMethodInfoPtr_SetupPassiveConnection_Private_Socket_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665520);
			FtpWebRequest.NativeMethodInfoPtr_GetPortV4_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665521);
			FtpWebRequest.NativeMethodInfoPtr_GetPortV6_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665522);
			FtpWebRequest.NativeMethodInfoPtr_FormatAddress_Private_String_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665523);
			FtpWebRequest.NativeMethodInfoPtr_FormatAddressV6_Private_String_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665524);
			FtpWebRequest.NativeMethodInfoPtr_CreateExceptionFromResponse_Private_Exception_FtpStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665525);
			FtpWebRequest.NativeMethodInfoPtr_SetTransferCompleted_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665526);
			FtpWebRequest.NativeMethodInfoPtr_OperationCompleted_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665527);
			FtpWebRequest.NativeMethodInfoPtr_SetCompleteWithError_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665528);
			FtpWebRequest.NativeMethodInfoPtr_InitDataConnection_Private_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665529);
			FtpWebRequest.NativeMethodInfoPtr_OpenDataConnection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665530);
			FtpWebRequest.NativeMethodInfoPtr_Authenticate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665531);
			FtpWebRequest.NativeMethodInfoPtr_SendCommand_Private_FtpStatus_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665532);
			FtpWebRequest.NativeMethodInfoPtr_SendCommand_Private_FtpStatus_Boolean_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665533);
			FtpWebRequest.NativeMethodInfoPtr_ServiceNotAvailable_Internal_Static_FtpStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665534);
			FtpWebRequest.NativeMethodInfoPtr_GetResponseStatus_Internal_FtpStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665535);
			FtpWebRequest.NativeMethodInfoPtr_InitiateSecureConnection_Private_Void_byref_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665536);
			FtpWebRequest.NativeMethodInfoPtr_ChangeToSSLSocket_Internal_Boolean_byref_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665537);
			FtpWebRequest.NativeMethodInfoPtr_InFinalState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665538);
			FtpWebRequest.NativeMethodInfoPtr_InProgress_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665539);
			FtpWebRequest.NativeMethodInfoPtr_CheckIfAborted_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665540);
			FtpWebRequest.NativeMethodInfoPtr_CheckFinalState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr, 100665541);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0004B9C0 File Offset: 0x00049BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50526, XrefRangeEnd = 50543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpWebRequest(Uri uri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpWebRequest>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr__ctor_Internal_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x0004BA0C File Offset: 0x00049C0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 50547, RefRangeEnd = 50549, XrefRangeStart = 50543, XrefRangeEnd = 50547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetMustImplement()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetMustImplement_Private_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x0004BA40 File Offset: 0x00049C40
		public unsafe override long ContentLength
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x0004BA7C File Offset: 0x00049C7C
		// (set) Token: 0x06000FA0 RID: 4000 RVA: 0x0004BABC File Offset: 0x00049CBC
		public unsafe override ICredentials Credentials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50549, XrefRangeEnd = 50552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x0004BB00 File Offset: 0x00049D00
		public unsafe bool EnableSsl
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_EnableSsl_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x0004BB3C File Offset: 0x00049D3C
		public unsafe override WebHeaderCollection Headers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50552, XrefRangeEnd = 50559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x0004BB7C File Offset: 0x00049D7C
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x0004BBB4 File Offset: 0x00049DB4
		public unsafe override string Method
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50559, XrefRangeEnd = 50567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x0004BBF8 File Offset: 0x00049DF8
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x0004BC38 File Offset: 0x00049E38
		public unsafe override IWebProxy Proxy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50567, XrefRangeEnd = 50568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x0004BC7C File Offset: 0x00049E7C
		public unsafe int ReadWriteTimeout
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20877, RefRangeEnd = 20878, XrefRangeStart = 20877, XrefRangeEnd = 20878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x0004BCB8 File Offset: 0x00049EB8
		public unsafe override Uri RequestUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x0004BCF8 File Offset: 0x00049EF8
		public unsafe ServicePoint ServicePoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50568, XrefRangeEnd = 50569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0004BD38 File Offset: 0x00049F38
		public unsafe override bool UseDefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50569, XrefRangeEnd = 50576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x0004BD74 File Offset: 0x00049F74
		public unsafe override int Timeout
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20876, RefRangeEnd = 20877, XrefRangeStart = 20876, XrefRangeEnd = 20877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x0004BDB0 File Offset: 0x00049FB0
		public unsafe string DataType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50576, XrefRangeEnd = 50580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_DataType_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x0004BDE8 File Offset: 0x00049FE8
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x0004BE24 File Offset: 0x0004A024
		public unsafe FtpWebRequest.RequestState State
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 50583, RefRangeEnd = 50625, XrefRangeStart = 50580, XrefRangeEnd = 50583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_get_State_Private_get_RequestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 50632, RefRangeEnd = 50648, XrefRangeStart = 50625, XrefRangeEnd = 50632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_set_State_Private_set_Void_RequestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x0004BE64 File Offset: 0x0004A064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50648, XrefRangeEnd = 50668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0004BE98 File Offset: 0x0004A098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50668, XrefRangeEnd = 50700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x0004BEFC File Offset: 0x0004A0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50700, XrefRangeEnd = 50705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
			}
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0004BF4C File Offset: 0x0004A14C
		[CallerCount(0)]
		public unsafe override WebResponse GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0004BF8C File Offset: 0x0004A18C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 50709, RefRangeEnd = 50714, XrefRangeStart = 50705, XrefRangeEnd = 50709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePoint GetServicePoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetServicePoint_Private_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x0004BFCC File Offset: 0x0004A1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50714, XrefRangeEnd = 50717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResolveHost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_ResolveHost_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0004C000 File Offset: 0x0004A200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50717, XrefRangeEnd = 50726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_ProcessRequest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0004C034 File Offset: 0x0004A234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50726, XrefRangeEnd = 50737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_SetType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0004C068 File Offset: 0x0004A268
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50765, RefRangeEnd = 50766, XrefRangeStart = 50737, XrefRangeEnd = 50765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRemoteFolderPath(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetRemoteFolderPath_Private_String_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0004C0B0 File Offset: 0x0004A2B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50782, RefRangeEnd = 50783, XrefRangeStart = 50766, XrefRangeEnd = 50782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CWDAndSetFileName(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CWDAndSetFileName_Private_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x0004C0F4 File Offset: 0x0004A2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50783, XrefRangeEnd = 50869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_ProcessMethod_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0004C128 File Offset: 0x0004A328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50869, XrefRangeEnd = 50875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseControlConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CloseControlConnection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x0004C15C File Offset: 0x0004A35C
		[CallerCount(0)]
		public unsafe void CloseDataConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CloseDataConnection_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x0004C190 File Offset: 0x0004A390
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 50881, RefRangeEnd = 50884, XrefRangeStart = 50875, XrefRangeEnd = 50881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CloseConnection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0004C1C4 File Offset: 0x0004A3C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50924, RefRangeEnd = 50925, XrefRangeStart = 50884, XrefRangeEnd = 50924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSimpleMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_ProcessSimpleMethod_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0004C1F8 File Offset: 0x0004A3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50925, XrefRangeEnd = 50935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UploadData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_UploadData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x0004C22C File Offset: 0x0004A42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50935, XrefRangeEnd = 50945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DownloadData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_DownloadData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x0004C260 File Offset: 0x0004A460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50945, XrefRangeEnd = 50946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRequestStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CheckRequestStarted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x0004C294 File Offset: 0x0004A494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50999, RefRangeEnd = 51000, XrefRangeStart = 50946, XrefRangeEnd = 50999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenControlConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_OpenControlConnection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0004C2C8 File Offset: 0x0004A4C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51009, RefRangeEnd = 51010, XrefRangeStart = 51000, XrefRangeEnd = 51009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetInitialPath(FtpStatus status)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(status);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetInitialPath_Private_Static_String_FtpStatus_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0004C304 File Offset: 0x0004A504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51010, XrefRangeEnd = 51022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket SetupPassiveConnection(string statusDescription, bool ipv6)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(statusDescription);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ipv6;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_SetupPassiveConnection_Private_Socket_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0004C364 File Offset: 0x0004A564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51043, RefRangeEnd = 51044, XrefRangeStart = 51022, XrefRangeEnd = 51043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPortV4(string responseString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(responseString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetPortV4_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0004C3B4 File Offset: 0x0004A5B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51089, RefRangeEnd = 51090, XrefRangeStart = 51044, XrefRangeEnd = 51089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPortV6(string responseString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(responseString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetPortV6_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0004C404 File Offset: 0x0004A604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51090, XrefRangeEnd = 51104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatAddress(IPAddress address, int Port)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_FormatAddress_Private_String_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0004C45C File Offset: 0x0004A65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51104, XrefRangeEnd = 51117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatAddressV6(IPAddress address, int port)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_FormatAddressV6_Private_String_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0004C4B4 File Offset: 0x0004A6B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51128, RefRangeEnd = 51129, XrefRangeStart = 51117, XrefRangeEnd = 51128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CreateExceptionFromResponse(FtpStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(status);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CreateExceptionFromResponse_Private_Exception_FtpStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0004C504 File Offset: 0x0004A704
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 51135, RefRangeEnd = 51137, XrefRangeStart = 51129, XrefRangeEnd = 51135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransferCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_SetTransferCompleted_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0004C538 File Offset: 0x0004A738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51137, XrefRangeEnd = 51138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OperationCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_OperationCompleted_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0004C56C File Offset: 0x0004A76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51138, XrefRangeEnd = 51139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCompleteWithError(Exception exc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_SetCompleteWithError_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0004C5B0 File Offset: 0x0004A7B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51188, RefRangeEnd = 51189, XrefRangeStart = 51139, XrefRangeEnd = 51188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket InitDataConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_InitDataConnection_Private_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0004C5F0 File Offset: 0x0004A7F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 51226, RefRangeEnd = 51230, XrefRangeStart = 51189, XrefRangeEnd = 51226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenDataConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_OpenDataConnection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x0004C624 File Offset: 0x0004A824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51295, RefRangeEnd = 51296, XrefRangeStart = 51230, XrefRangeEnd = 51295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Authenticate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_Authenticate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0004C658 File Offset: 0x0004A858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51296, XrefRangeEnd = 51297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpStatus SendCommand(string command, [Optional] Il2CppStringArray parameters)
		{
			if (parameters == null)
			{
				parameters = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_SendCommand_Private_FtpStatus_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FtpStatus>(intPtr3) : null;
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0004C6C8 File Offset: 0x0004A8C8
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 51306, RefRangeEnd = 51325, XrefRangeStart = 51297, XrefRangeEnd = 51306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpStatus SendCommand(bool waitResponse, string command, [Optional] Il2CppStringArray parameters)
		{
			if (parameters == null)
			{
				parameters = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref waitResponse;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(command);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_SendCommand_Private_FtpStatus_Boolean_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FtpStatus>(intPtr3) : null;
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0004C748 File Offset: 0x0004A948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51325, XrefRangeEnd = 51332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FtpStatus ServiceNotAvailable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_ServiceNotAvailable_Internal_Static_FtpStatus_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FtpStatus>(intPtr3) : null;
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0004C77C File Offset: 0x0004A97C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 51349, RefRangeEnd = 51353, XrefRangeStart = 51332, XrefRangeEnd = 51349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpStatus GetResponseStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_GetResponseStatus_Internal_FtpStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FtpStatus>(intPtr3) : null;
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x0004C7BC File Offset: 0x0004A9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51353, XrefRangeEnd = 51372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitiateSecureConnection(ref Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_InitiateSecureConnection_Private_Void_byref_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				stream = ((intPtr4 == 0) ? null : new Stream(intPtr4));
			}
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0004C814 File Offset: 0x0004AA14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 51386, RefRangeEnd = 51389, XrefRangeStart = 51372, XrefRangeEnd = 51386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ChangeToSSLSocket(ref Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_ChangeToSSLSocket_Internal_Boolean_byref_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				stream = ((intPtr4 == 0) ? null : new Stream(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0004C878 File Offset: 0x0004AA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51389, XrefRangeEnd = 51392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InFinalState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_InFinalState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0004C8B4 File Offset: 0x0004AAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51392, XrefRangeEnd = 51396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_InProgress_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0004C8F0 File Offset: 0x0004AAF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 51397, RefRangeEnd = 51399, XrefRangeStart = 51396, XrefRangeEnd = 51397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckIfAborted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CheckIfAborted_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0004C924 File Offset: 0x0004AB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51399, XrefRangeEnd = 51402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckFinalState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebRequest.NativeMethodInfoPtr_CheckFinalState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00008246 File Offset: 0x00006446
		public FtpStatus SendCommand(string command, params string[] parameters)
		{
			return this.SendCommand(command, new Il2CppStringArray(parameters));
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00008255 File Offset: 0x00006455
		public FtpStatus SendCommand(bool waitResponse, string command, params string[] parameters)
		{
			return this.SendCommand(waitResponse, command, new Il2CppStringArray(parameters));
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00008265 File Offset: 0x00006465
		public FtpWebRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x0004C958 File Offset: 0x0004AB58
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x0000826E File Offset: 0x0000646E
		public unsafe Uri requestUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_requestUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_requestUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0004C988 File Offset: 0x0004AB88
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x0000828D File Offset: 0x0000648D
		public unsafe string file_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_file_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_file_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0004C9B0 File Offset: 0x0004ABB0
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x000082AC File Offset: 0x000064AC
		public unsafe ServicePoint servicePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_servicePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_servicePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0004C9E0 File Offset: 0x0004ABE0
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x000082CB File Offset: 0x000064CB
		public unsafe Stream origDataStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_origDataStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_origDataStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x0004CA10 File Offset: 0x0004AC10
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x000082EA File Offset: 0x000064EA
		public unsafe Stream dataStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_dataStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_dataStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x0004CA40 File Offset: 0x0004AC40
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x00008309 File Offset: 0x00006509
		public unsafe Stream controlStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_controlStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_controlStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x0004CA70 File Offset: 0x0004AC70
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x00008328 File Offset: 0x00006528
		public unsafe StreamReader controlReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_controlReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_controlReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x0004CAA0 File Offset: 0x0004ACA0
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x00008347 File Offset: 0x00006547
		public unsafe NetworkCredential credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x0004CAD0 File Offset: 0x0004ACD0
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x00008366 File Offset: 0x00006566
		public unsafe IPHostEntry hostEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_hostEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_hostEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x0004CB00 File Offset: 0x0004AD00
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x00008385 File Offset: 0x00006585
		public unsafe IPEndPoint localEndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_localEndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_localEndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x0004CB30 File Offset: 0x0004AD30
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x000083A4 File Offset: 0x000065A4
		public unsafe IPEndPoint remoteEndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_remoteEndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_remoteEndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0004CB60 File Offset: 0x0004AD60
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x000083C3 File Offset: 0x000065C3
		public unsafe IWebProxy proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x0004CB90 File Offset: 0x0004AD90
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x000083E2 File Offset: 0x000065E2
		public unsafe int timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_timeout)) = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x0004CBB8 File Offset: 0x0004ADB8
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x000083FD File Offset: 0x000065FD
		public unsafe int rwTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_rwTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_rwTimeout)) = value;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x0004CBE0 File Offset: 0x0004ADE0
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x00008418 File Offset: 0x00006618
		public unsafe long offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x0004CC08 File Offset: 0x0004AE08
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x00008433 File Offset: 0x00006633
		public unsafe bool binary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_binary);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_binary)) = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x0004CC30 File Offset: 0x0004AE30
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x0000844E File Offset: 0x0000664E
		public unsafe bool enableSsl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_enableSsl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_enableSsl)) = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x0004CC58 File Offset: 0x0004AE58
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x00008469 File Offset: 0x00006669
		public unsafe bool usePassive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_usePassive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_usePassive)) = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x0004CC80 File Offset: 0x0004AE80
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x00008484 File Offset: 0x00006684
		public unsafe bool keepAlive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_keepAlive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_keepAlive)) = value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x0004CCA8 File Offset: 0x0004AEA8
		// (set) Token: 0x06001003 RID: 4099 RVA: 0x0000849F File Offset: 0x0000669F
		public unsafe string method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x0004CCD0 File Offset: 0x0004AED0
		// (set) Token: 0x06001005 RID: 4101 RVA: 0x000084BE File Offset: 0x000066BE
		public unsafe string renameTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_renameTo);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_renameTo), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x0004CCF8 File Offset: 0x0004AEF8
		// (set) Token: 0x06001007 RID: 4103 RVA: 0x000084DD File Offset: 0x000066DD
		public unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x0004CD28 File Offset: 0x0004AF28
		// (set) Token: 0x06001009 RID: 4105 RVA: 0x000084FC File Offset: 0x000066FC
		public unsafe FtpWebRequest.RequestState requestState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_requestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_requestState)) = value;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x0004CD50 File Offset: 0x0004AF50
		// (set) Token: 0x0600100B RID: 4107 RVA: 0x00008517 File Offset: 0x00006717
		public unsafe FtpAsyncResult asyncResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_asyncResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FtpAsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_asyncResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x0004CD80 File Offset: 0x0004AF80
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x00008536 File Offset: 0x00006736
		public unsafe FtpWebResponse ftpResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_ftpResponse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FtpWebResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_ftpResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x0004CDB0 File Offset: 0x0004AFB0
		// (set) Token: 0x0600100F RID: 4111 RVA: 0x00008555 File Offset: 0x00006755
		public unsafe Stream requestStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_requestStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_requestStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x0004CDE0 File Offset: 0x0004AFE0
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x00008574 File Offset: 0x00006774
		public unsafe string initial_path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_initial_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_initial_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x0004CE08 File Offset: 0x0004B008
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x00008593 File Offset: 0x00006793
		public unsafe static Il2CppStringArray supportedCommands
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FtpWebRequest.NativeFieldInfoPtr_supportedCommands, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FtpWebRequest.NativeFieldInfoPtr_supportedCommands, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x0004CE30 File Offset: 0x0004B030
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x000085A5 File Offset: 0x000067A5
		public unsafe Encoding dataEncoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_dataEncoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebRequest.NativeFieldInfoPtr_dataEncoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeFieldInfoPtr_requestUri;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeFieldInfoPtr_file_name;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeFieldInfoPtr_servicePoint;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeFieldInfoPtr_origDataStream;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeFieldInfoPtr_dataStream;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeFieldInfoPtr_controlStream;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeFieldInfoPtr_controlReader;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeFieldInfoPtr_credentials;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeFieldInfoPtr_hostEntry;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeFieldInfoPtr_localEndPoint;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeFieldInfoPtr_remoteEndPoint;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeFieldInfoPtr_proxy;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeFieldInfoPtr_timeout;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeFieldInfoPtr_rwTimeout;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeFieldInfoPtr_binary;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeFieldInfoPtr_enableSsl;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeFieldInfoPtr_usePassive;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeFieldInfoPtr_keepAlive;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeFieldInfoPtr_renameTo;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeFieldInfoPtr_requestState;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeFieldInfoPtr_asyncResult;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeFieldInfoPtr_ftpResponse;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeFieldInfoPtr_requestStream;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeFieldInfoPtr_initial_path;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeFieldInfoPtr_supportedCommands;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeFieldInfoPtr_dataEncoding;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Uri_0;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr_GetMustImplement_Private_Static_Exception_0;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLength_Public_Virtual_get_Int64_0;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_get_ICredentials_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr_set_Credentials_Public_Virtual_set_Void_ICredentials_0;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableSsl_Public_get_Boolean_0;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_Virtual_get_String_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr_set_Method_Public_Virtual_set_Void_String_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_get_Proxy_Public_Virtual_get_IWebProxy_0;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_set_Proxy_Public_Virtual_set_Void_IWebProxy_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadWriteTimeout_Public_get_Int32_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestUri_Public_Virtual_get_Uri_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_get_Boolean_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_get_Timeout_Public_Virtual_get_Int32_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Private_get_String_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Private_get_RequestState_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_RequestState_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Void_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr_EndGetResponse_Public_Virtual_WebResponse_IAsyncResult_0;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_WebResponse_0;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr_GetServicePoint_Private_ServicePoint_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_ResolveHost_Private_Void_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRequest_Private_Void_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr_SetType_Private_Void_0;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_GetRemoteFolderPath_Private_String_Uri_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_CWDAndSetFileName_Private_Void_Uri_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMethod_Private_Void_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_CloseControlConnection_Private_Void_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_CloseDataConnection_Internal_Void_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_CloseConnection_Private_Void_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSimpleMethod_Private_Void_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr_UploadData_Private_Void_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_DownloadData_Private_Void_0;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr_CheckRequestStarted_Private_Void_0;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr_OpenControlConnection_Private_Void_0;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr_GetInitialPath_Private_Static_String_FtpStatus_0;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr_SetupPassiveConnection_Private_Socket_String_Boolean_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr_GetPortV4_Private_Int32_String_0;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr_GetPortV6_Private_Int32_String_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr_FormatAddress_Private_String_IPAddress_Int32_0;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr_FormatAddressV6_Private_String_IPAddress_Int32_0;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeMethodInfoPtr_CreateExceptionFromResponse_Private_Exception_FtpStatus_0;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr_SetTransferCompleted_Internal_Void_0;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr_OperationCompleted_Internal_Void_0;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr_SetCompleteWithError_Private_Void_Exception_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr_InitDataConnection_Private_Socket_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_OpenDataConnection_Private_Void_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Private_Void_0;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_SendCommand_Private_FtpStatus_String_Il2CppStringArray_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_SendCommand_Private_FtpStatus_Boolean_String_Il2CppStringArray_0;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_ServiceNotAvailable_Internal_Static_FtpStatus_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseStatus_Internal_FtpStatus_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_InitiateSecureConnection_Private_Void_byref_Stream_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr_ChangeToSSLSocket_Internal_Boolean_byref_Stream_0;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_InFinalState_Private_Boolean_0;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_InProgress_Private_Boolean_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_CheckIfAborted_Internal_Void_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_CheckFinalState_Private_Void_0;

		// Token: 0x020001C0 RID: 448
		public enum RequestState
		{
			// Token: 0x040013AA RID: 5034
			Before,
			// Token: 0x040013AB RID: 5035
			Scheduled,
			// Token: 0x040013AC RID: 5036
			Connecting,
			// Token: 0x040013AD RID: 5037
			Authenticating,
			// Token: 0x040013AE RID: 5038
			OpeningData,
			// Token: 0x040013AF RID: 5039
			TransferInProgress,
			// Token: 0x040013B0 RID: 5040
			Finished,
			// Token: 0x040013B1 RID: 5041
			Aborted,
			// Token: 0x040013B2 RID: 5042
			Error
		}
	}
}
