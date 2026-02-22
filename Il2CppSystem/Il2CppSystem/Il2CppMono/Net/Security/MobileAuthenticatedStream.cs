using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000024 RID: 36
	public class MobileAuthenticatedStream : AuthenticatedStream
	{
		// Token: 0x06000193 RID: 403 RVA: 0x000167B4 File Offset: 0x000149B4
		// Note: this type is marked as 'beforefieldinit'.
		static MobileAuthenticatedStream()
		{
			Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MobileAuthenticatedStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr);
			MobileAuthenticatedStream.NativeFieldInfoPtr_xobileTlsContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "xobileTlsContext");
			MobileAuthenticatedStream.NativeFieldInfoPtr_lastException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "lastException");
			MobileAuthenticatedStream.NativeFieldInfoPtr_asyncHandshakeRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "asyncHandshakeRequest");
			MobileAuthenticatedStream.NativeFieldInfoPtr_asyncReadRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "asyncReadRequest");
			MobileAuthenticatedStream.NativeFieldInfoPtr_asyncWriteRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "asyncWriteRequest");
			MobileAuthenticatedStream.NativeFieldInfoPtr_readBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "readBuffer");
			MobileAuthenticatedStream.NativeFieldInfoPtr_writeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "writeBuffer");
			MobileAuthenticatedStream.NativeFieldInfoPtr_ioLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "ioLock");
			MobileAuthenticatedStream.NativeFieldInfoPtr_closeRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "closeRequested");
			MobileAuthenticatedStream.NativeFieldInfoPtr_shutdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "shutdown");
			MobileAuthenticatedStream.NativeFieldInfoPtr_uniqueNameInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "uniqueNameInteger");
			MobileAuthenticatedStream.NativeFieldInfoPtr__SslStream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<SslStream>k__BackingField");
			MobileAuthenticatedStream.NativeFieldInfoPtr__Settings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<Settings>k__BackingField");
			MobileAuthenticatedStream.NativeFieldInfoPtr__Provider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<Provider>k__BackingField");
			MobileAuthenticatedStream.NativeFieldInfoPtr_nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "nextId");
			MobileAuthenticatedStream.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "ID");
			MobileAuthenticatedStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663576);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_Settings_Public_get_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663577);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_Provider_Public_Virtual_Final_New_get_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663578);
			MobileAuthenticatedStream.NativeMethodInfoPtr_CheckThrow_Internal_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663579);
			MobileAuthenticatedStream.NativeMethodInfoPtr_GetSSPIException_Internal_Static_Exception_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663580);
			MobileAuthenticatedStream.NativeMethodInfoPtr_GetIOException_Internal_Static_Exception_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663581);
			MobileAuthenticatedStream.NativeMethodInfoPtr_SetException_Internal_ExceptionDispatchInfo_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663582);
			MobileAuthenticatedStream.NativeMethodInfoPtr_AuthenticateAsClient_Public_Virtual_Final_New_Void_String_X509CertificateCollection_SslProtocols_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663583);
			MobileAuthenticatedStream.NativeMethodInfoPtr_AuthenticateAsClientAsync_Public_Virtual_Final_New_Task_String_X509CertificateCollection_SslProtocols_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663584);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_AuthenticatedStream_Public_Virtual_Final_New_get_AuthenticatedStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663585);
			MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessAuthentication_Private_Task_Boolean_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663586);
			MobileAuthenticatedStream.NativeMethodInfoPtr_CreateContext_Protected_Abstract_Virtual_New_MobileTlsContext_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663587);
			MobileAuthenticatedStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663588);
			MobileAuthenticatedStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663589);
			MobileAuthenticatedStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663590);
			MobileAuthenticatedStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663591);
			MobileAuthenticatedStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663592);
			MobileAuthenticatedStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663593);
			MobileAuthenticatedStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663594);
			MobileAuthenticatedStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663595);
			MobileAuthenticatedStream.NativeMethodInfoPtr_StartOperation_Private_Task_1_Int32_OperationType_AsyncProtocolRequest_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663596);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InternalRead_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663597);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InternalRead_Private_ValueTuple_2_Int32_Boolean_AsyncProtocolRequest_BufferOffsetSize_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663598);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InternalWrite_Internal_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663599);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InternalWrite_Private_Boolean_AsyncProtocolRequest_BufferOffsetSize2_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663600);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InnerRead_Internal_Task_1_Int32_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663601);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InnerWrite_Internal_Task_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663602);
			MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessHandshake_Internal_AsyncOperationStatus_AsyncOperationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663603);
			MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessRead_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663604);
			MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessWrite_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663605);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663606);
			MobileAuthenticatedStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663607);
			MobileAuthenticatedStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663608);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_InternalLocalCertificate_Public_Virtual_Final_New_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663609);
			MobileAuthenticatedStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663610);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663611);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663612);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663613);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663614);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663615);
			MobileAuthenticatedStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663616);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663617);
			MobileAuthenticatedStream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663618);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663619);
			MobileAuthenticatedStream.NativeMethodInfoPtr__InnerWrite_b__67_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663621);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00016CA8 File Offset: 0x00014EA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33746, RefRangeEnd = 33748, XrefRangeStart = 33730, XrefRangeEnd = 33746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MobileAuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveInnerStreamOpen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MonoTlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00016D3C File Offset: 0x00014F3C
		public unsafe MonoTlsSettings Settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_get_Settings_Public_get_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00016D7C File Offset: 0x00014F7C
		public unsafe virtual MonoTlsProvider Provider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_get_Provider_Public_Virtual_Final_New_get_MonoTlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00016DBC File Offset: 0x00014FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33749, RefRangeEnd = 33750, XrefRangeStart = 33748, XrefRangeEnd = 33749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckThrow(bool authSuccessCheck, bool shutdownCheck = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref authSuccessCheck;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shutdownCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_CheckThrow_Internal_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00016E08 File Offset: 0x00015008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33759, RefRangeEnd = 33760, XrefRangeStart = 33750, XrefRangeEnd = 33759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetSSPIException(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_GetSSPIException_Internal_Static_Exception_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00016E4C File Offset: 0x0001504C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33768, RefRangeEnd = 33770, XrefRangeStart = 33760, XrefRangeEnd = 33768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetIOException(Exception e, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_GetIOException_Internal_Static_Exception_Exception_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00016EA4 File Offset: 0x000150A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 33772, RefRangeEnd = 33775, XrefRangeStart = 33770, XrefRangeEnd = 33772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionDispatchInfo SetException(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_SetException_Internal_ExceptionDispatchInfo_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00016EF4 File Offset: 0x000150F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33775, XrefRangeEnd = 33778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientCertificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabledSslProtocols;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkCertificateRevocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_AuthenticateAsClient_Public_Virtual_Final_New_Void_String_X509CertificateCollection_SslProtocols_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00016F64 File Offset: 0x00015164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33778, XrefRangeEnd = 33779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientCertificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabledSslProtocols;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkCertificateRevocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_AuthenticateAsClientAsync_Public_Virtual_Final_New_Task_String_X509CertificateCollection_SslProtocols_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00016FE4 File Offset: 0x000151E4
		public unsafe virtual AuthenticatedStream AuthenticatedStream
		{
			[CallerCount(734)]
			[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_get_AuthenticatedStream_Public_Virtual_Final_New_get_AuthenticatedStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AuthenticatedStream>(intPtr3) : null;
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00017024 File Offset: 0x00015224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33787, RefRangeEnd = 33789, XrefRangeStart = 33779, XrefRangeEnd = 33787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ProcessAuthentication(bool runSynchronously, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool clientCertRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref runSynchronously;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabledProtocols;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverCertificate);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientCertificates);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clientCertRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessAuthentication_Private_Task_Boolean_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000170D4 File Offset: 0x000152D4
		[CallerCount(0)]
		public unsafe virtual MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serverMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabledProtocols;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverCertificate);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientCertificates);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref askForClientCert;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_CreateContext_Protected_Abstract_Virtual_New_MobileTlsContext_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileTlsContext>(intPtr3) : null;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00017180 File Offset: 0x00015380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33789, XrefRangeEnd = 33799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback asyncCallback, Object asyncState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncState);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00017220 File Offset: 0x00015420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33799, XrefRangeEnd = 33802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int EndRead(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00017278 File Offset: 0x00015478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33802, XrefRangeEnd = 33812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginWrite(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback asyncCallback, Object asyncState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncState);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00017318 File Offset: 0x00015518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33812, XrefRangeEnd = 33813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndWrite(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00017368 File Offset: 0x00015568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33813, XrefRangeEnd = 33826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000173DC File Offset: 0x000155DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33826, XrefRangeEnd = 33839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00017448 File Offset: 0x00015648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33839, XrefRangeEnd = 33844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000174D8 File Offset: 0x000156D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33844, XrefRangeEnd = 33849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00017568 File Offset: 0x00015768
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 33861, RefRangeEnd = 33867, XrefRangeStart = 33849, XrefRangeEnd = 33861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncRequest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_StartOperation_Private_Task_1_Int32_OperationType_AsyncProtocolRequest_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000175E0 File Offset: 0x000157E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33888, RefRangeEnd = 33889, XrefRangeStart = 33867, XrefRangeEnd = 33888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalRead(Il2CppStructArray<byte> buffer, int offset, int size, out bool outWantMore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outWantMore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InternalRead_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00017658 File Offset: 0x00015858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33889, XrefRangeEnd = 33894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InternalRead_Private_ValueTuple_2_Int32_Boolean_AsyncProtocolRequest_BufferOffsetSize_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, bool>(intPtr);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000176E0 File Offset: 0x000158E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33910, RefRangeEnd = 33911, XrefRangeStart = 33894, XrefRangeEnd = 33910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalWrite(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InternalWrite_Internal_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0001774C File Offset: 0x0001594C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33911, XrefRangeEnd = 33916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InternalWrite_Private_Boolean_AsyncProtocolRequest_BufferOffsetSize2_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000177DC File Offset: 0x000159DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33928, RefRangeEnd = 33929, XrefRangeStart = 33916, XrefRangeEnd = 33928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sync;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestedSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InnerRead_Internal_Task_1_Int32_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00017850 File Offset: 0x00015A50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33937, RefRangeEnd = 33938, XrefRangeStart = 33929, XrefRangeEnd = 33937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task InnerWrite(bool sync, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sync;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InnerWrite_Internal_Task_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000178B4 File Offset: 0x00015AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33943, RefRangeEnd = 33944, XrefRangeStart = 33938, XrefRangeEnd = 33943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessHandshake_Internal_AsyncOperationStatus_AsyncOperationStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00017900 File Offset: 0x00015B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33948, RefRangeEnd = 33949, XrefRangeStart = 33944, XrefRangeEnd = 33948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(userBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessRead_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<int, bool>(intPtr);
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00017948 File Offset: 0x00015B48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33953, RefRangeEnd = 33954, XrefRangeStart = 33949, XrefRangeEnd = 33953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(userBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessWrite_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<int, bool>(intPtr);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00017990 File Offset: 0x00015B90
		public unsafe override bool IsAuthenticated
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33954, XrefRangeEnd = 33958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000179D8 File Offset: 0x00015BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33958, XrefRangeEnd = 33975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00017A24 File Offset: 0x00015C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00017A60 File Offset: 0x00015C60
		public unsafe virtual X509Certificate InternalLocalCertificate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33975, XrefRangeEnd = 33981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_get_InternalLocalCertificate_Public_Virtual_Final_New_get_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00017AA0 File Offset: 0x00015CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33981, XrefRangeEnd = 33986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long Seek(long offset, SeekOrigin origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00017B04 File Offset: 0x00015D04
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00017B4C File Offset: 0x00015D4C
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00017B94 File Offset: 0x00015D94
		public unsafe override bool CanSeek
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00017BDC File Offset: 0x00015DDC
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00017C24 File Offset: 0x00015E24
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00017C6C File Offset: 0x00015E6C
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33986, XrefRangeEnd = 33991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00017CB8 File Offset: 0x00015EB8
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00017D00 File Offset: 0x00015F00
		public unsafe override int ReadTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33991, XrefRangeEnd = 33992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33992, XrefRangeEnd = 33993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00017D4C File Offset: 0x00015F4C
		public unsafe override int WriteTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33993, XrefRangeEnd = 33994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00017D94 File Offset: 0x00015F94
		[CallerCount(0)]
		public unsafe void _InnerWrite_b__67_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr__InnerWrite_b__67_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002935 File Offset: 0x00000B35
		public MobileAuthenticatedStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00017DC8 File Offset: 0x00015FC8
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x0000293E File Offset: 0x00000B3E
		public unsafe MobileTlsContext xobileTlsContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_xobileTlsContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileTlsContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_xobileTlsContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00017DF8 File Offset: 0x00015FF8
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x0000295D File Offset: 0x00000B5D
		public unsafe ExceptionDispatchInfo lastException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_lastException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_lastException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00017E28 File Offset: 0x00016028
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0000297C File Offset: 0x00000B7C
		public unsafe AsyncProtocolRequest asyncHandshakeRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncHandshakeRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncHandshakeRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00017E58 File Offset: 0x00016058
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x0000299B File Offset: 0x00000B9B
		public unsafe AsyncProtocolRequest asyncReadRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncReadRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncReadRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00017E88 File Offset: 0x00016088
		// (set) Token: 0x060001CB RID: 459 RVA: 0x000029BA File Offset: 0x00000BBA
		public unsafe AsyncProtocolRequest asyncWriteRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncWriteRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncWriteRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00017EB8 File Offset: 0x000160B8
		// (set) Token: 0x060001CD RID: 461 RVA: 0x000029D9 File Offset: 0x00000BD9
		public unsafe BufferOffsetSize2 readBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_readBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_readBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00017EE8 File Offset: 0x000160E8
		// (set) Token: 0x060001CF RID: 463 RVA: 0x000029F8 File Offset: 0x00000BF8
		public unsafe BufferOffsetSize2 writeBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_writeBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_writeBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00017F18 File Offset: 0x00016118
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00002A17 File Offset: 0x00000C17
		public unsafe Object ioLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_ioLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_ioLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00017F48 File Offset: 0x00016148
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002A36 File Offset: 0x00000C36
		public unsafe int closeRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_closeRequested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_closeRequested)) = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00017F70 File Offset: 0x00016170
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002A51 File Offset: 0x00000C51
		public unsafe bool shutdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_shutdown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_shutdown)) = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00017F98 File Offset: 0x00016198
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002A6C File Offset: 0x00000C6C
		public unsafe static int uniqueNameInteger
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MobileAuthenticatedStream.NativeFieldInfoPtr_uniqueNameInteger, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MobileAuthenticatedStream.NativeFieldInfoPtr_uniqueNameInteger, (void*)(&value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00017FB4 File Offset: 0x000161B4
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002A7A File Offset: 0x00000C7A
		public unsafe SslStream _SslStream_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__SslStream_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SslStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__SslStream_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00017FE4 File Offset: 0x000161E4
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00002A99 File Offset: 0x00000C99
		public unsafe MonoTlsSettings _Settings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__Settings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__Settings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00018014 File Offset: 0x00016214
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00002AB8 File Offset: 0x00000CB8
		public unsafe MonoTlsProvider _Provider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__Provider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__Provider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00018044 File Offset: 0x00016244
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00002AD7 File Offset: 0x00000CD7
		public unsafe static int nextId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MobileAuthenticatedStream.NativeFieldInfoPtr_nextId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MobileAuthenticatedStream.NativeFieldInfoPtr_nextId, (void*)(&value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00018060 File Offset: 0x00016260
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002AE5 File Offset: 0x00000CE5
		public unsafe int ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_ID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_ID)) = value;
			}
		}

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeFieldInfoPtr_xobileTlsContext;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeFieldInfoPtr_lastException;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeFieldInfoPtr_asyncHandshakeRequest;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr_asyncReadRequest;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr_asyncWriteRequest;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr_readBuffer;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeFieldInfoPtr_writeBuffer;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeFieldInfoPtr_ioLock;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr_closeRequested;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_shutdown;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeFieldInfoPtr_uniqueNameInteger;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeFieldInfoPtr__SslStream_k__BackingField;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeFieldInfoPtr__Settings_k__BackingField;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeFieldInfoPtr__Provider_k__BackingField;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeFieldInfoPtr_nextId;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MonoTlsProvider_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_MonoTlsSettings_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_get_Provider_Public_Virtual_Final_New_get_MonoTlsProvider_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_CheckThrow_Internal_Void_Boolean_Boolean_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_GetSSPIException_Internal_Static_Exception_Exception_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_GetIOException_Internal_Static_Exception_Exception_String_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_SetException_Internal_ExceptionDispatchInfo_Exception_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_AuthenticateAsClient_Public_Virtual_Final_New_Void_String_X509CertificateCollection_SslProtocols_Boolean_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_AuthenticateAsClientAsync_Public_Virtual_Final_New_Task_String_X509CertificateCollection_SslProtocols_Boolean_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticatedStream_Public_Virtual_Final_New_get_AuthenticatedStream_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAuthentication_Private_Task_Boolean_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_CreateContext_Protected_Abstract_Virtual_New_MobileTlsContext_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_StartOperation_Private_Task_1_Int32_OperationType_AsyncProtocolRequest_CancellationToken_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_InternalRead_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Boolean_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_InternalRead_Private_ValueTuple_2_Int32_Boolean_AsyncProtocolRequest_BufferOffsetSize_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_InternalWrite_Internal_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_InternalWrite_Private_Boolean_AsyncProtocolRequest_BufferOffsetSize2_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_InnerRead_Internal_Task_1_Int32_Boolean_Int32_CancellationToken_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_InnerWrite_Internal_Task_Boolean_CancellationToken_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandshake_Internal_AsyncOperationStatus_AsyncOperationStatus_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRead_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_ProcessWrite_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalLocalCertificate_Public_Virtual_Final_New_get_X509Certificate_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_get_Int32_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_get_Int32_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr__InnerWrite_b__67_0_Private_Void_0;

		// Token: 0x0200017F RID: 383
		public enum OperationType
		{
			// Token: 0x040011F1 RID: 4593
			Read,
			// Token: 0x040011F2 RID: 4594
			Write,
			// Token: 0x040011F3 RID: 4595
			Shutdown
		}

		// Token: 0x02000180 RID: 384
		[ObfuscatedName("Mono.Net.Security.MobileAuthenticatedStream+<ProcessAuthentication>d__47")]
		public sealed class _ProcessAuthentication_d__47 : ValueType
		{
			// Token: 0x0600169A RID: 5786 RVA: 0x0006342C File Offset: 0x0006162C
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessAuthentication_d__47()
			{
				Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<ProcessAuthentication>d__47");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr);
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "<>1__state");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "<>t__builder");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_serverMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "serverMode");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_serverCertificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "serverCertificate");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_targetHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "targetHost");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "<>4__this");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_runSynchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "runSynchronously");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_enabledProtocols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "enabledProtocols");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_clientCertificates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "clientCertificates");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_clientCertRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "clientCertRequired");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "<>u__1");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, 100663622);
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, 100663623);
			}

			// Token: 0x0600169B RID: 5787 RVA: 0x0006355C File Offset: 0x0006175C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33580, XrefRangeEnd = 33627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600169C RID: 5788 RVA: 0x00063594 File Offset: 0x00061794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600169D RID: 5789 RVA: 0x0000BC8D File Offset: 0x00009E8D
			public _ProcessAuthentication_d__47(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600169E RID: 5790 RVA: 0x0000BC96 File Offset: 0x00009E96
			public _ProcessAuthentication_d__47()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr))
			{
			}

			// Token: 0x17000746 RID: 1862
			// (get) Token: 0x0600169F RID: 5791 RVA: 0x000635DC File Offset: 0x000617DC
			// (set) Token: 0x060016A0 RID: 5792 RVA: 0x0000BCA8 File Offset: 0x00009EA8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000747 RID: 1863
			// (get) Token: 0x060016A1 RID: 5793 RVA: 0x00063604 File Offset: 0x00061804
			// (set) Token: 0x060016A2 RID: 5794 RVA: 0x0000BCC3 File Offset: 0x00009EC3
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000748 RID: 1864
			// (get) Token: 0x060016A3 RID: 5795 RVA: 0x00063634 File Offset: 0x00061834
			// (set) Token: 0x060016A4 RID: 5796 RVA: 0x0000BCF1 File Offset: 0x00009EF1
			public unsafe bool serverMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_serverMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_serverMode)) = value;
				}
			}

			// Token: 0x17000749 RID: 1865
			// (get) Token: 0x060016A5 RID: 5797 RVA: 0x0006365C File Offset: 0x0006185C
			// (set) Token: 0x060016A6 RID: 5798 RVA: 0x0000BD0C File Offset: 0x00009F0C
			public unsafe X509Certificate serverCertificate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_serverCertificate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_serverCertificate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700074A RID: 1866
			// (get) Token: 0x060016A7 RID: 5799 RVA: 0x0006368C File Offset: 0x0006188C
			// (set) Token: 0x060016A8 RID: 5800 RVA: 0x0000BD2B File Offset: 0x00009F2B
			public unsafe string targetHost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_targetHost);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_targetHost), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700074B RID: 1867
			// (get) Token: 0x060016A9 RID: 5801 RVA: 0x000636B4 File Offset: 0x000618B4
			// (set) Token: 0x060016AA RID: 5802 RVA: 0x0000BD4A File Offset: 0x00009F4A
			public unsafe MobileAuthenticatedStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700074C RID: 1868
			// (get) Token: 0x060016AB RID: 5803 RVA: 0x000636E4 File Offset: 0x000618E4
			// (set) Token: 0x060016AC RID: 5804 RVA: 0x0000BD69 File Offset: 0x00009F69
			public unsafe bool runSynchronously
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_runSynchronously);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_runSynchronously)) = value;
				}
			}

			// Token: 0x1700074D RID: 1869
			// (get) Token: 0x060016AD RID: 5805 RVA: 0x0006370C File Offset: 0x0006190C
			// (set) Token: 0x060016AE RID: 5806 RVA: 0x0000BD84 File Offset: 0x00009F84
			public unsafe SslProtocols enabledProtocols
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_enabledProtocols);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_enabledProtocols)) = value;
				}
			}

			// Token: 0x1700074E RID: 1870
			// (get) Token: 0x060016AF RID: 5807 RVA: 0x00063734 File Offset: 0x00061934
			// (set) Token: 0x060016B0 RID: 5808 RVA: 0x0000BD9F File Offset: 0x00009F9F
			public unsafe X509CertificateCollection clientCertificates
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_clientCertificates);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_clientCertificates), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700074F RID: 1871
			// (get) Token: 0x060016B1 RID: 5809 RVA: 0x00063764 File Offset: 0x00061964
			// (set) Token: 0x060016B2 RID: 5810 RVA: 0x0000BDBE File Offset: 0x00009FBE
			public unsafe bool clientCertRequired
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_clientCertRequired);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_clientCertRequired)) = value;
				}
			}

			// Token: 0x17000750 RID: 1872
			// (get) Token: 0x060016B3 RID: 5811 RVA: 0x0006378C File Offset: 0x0006198C
			// (set) Token: 0x060016B4 RID: 5812 RVA: 0x0000BDD9 File Offset: 0x00009FD9
			public ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040011F4 RID: 4596
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040011F5 RID: 4597
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040011F6 RID: 4598
			private static readonly IntPtr NativeFieldInfoPtr_serverMode;

			// Token: 0x040011F7 RID: 4599
			private static readonly IntPtr NativeFieldInfoPtr_serverCertificate;

			// Token: 0x040011F8 RID: 4600
			private static readonly IntPtr NativeFieldInfoPtr_targetHost;

			// Token: 0x040011F9 RID: 4601
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040011FA RID: 4602
			private static readonly IntPtr NativeFieldInfoPtr_runSynchronously;

			// Token: 0x040011FB RID: 4603
			private static readonly IntPtr NativeFieldInfoPtr_enabledProtocols;

			// Token: 0x040011FC RID: 4604
			private static readonly IntPtr NativeFieldInfoPtr_clientCertificates;

			// Token: 0x040011FD RID: 4605
			private static readonly IntPtr NativeFieldInfoPtr_clientCertRequired;

			// Token: 0x040011FE RID: 4606
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040011FF RID: 4607
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001200 RID: 4608
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000181 RID: 385
		[ObfuscatedName("Mono.Net.Security.MobileAuthenticatedStream+<StartOperation>d__58")]
		public sealed class _StartOperation_d__58 : ValueType
		{
			// Token: 0x060016B5 RID: 5813 RVA: 0x000637BC File Offset: 0x000619BC
			// Note: this type is marked as 'beforefieldinit'.
			static _StartOperation_d__58()
			{
				Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<StartOperation>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr);
				MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, "<>1__state");
				MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, "<>t__builder");
				MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, "<>4__this");
				MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, "type");
				MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_asyncRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, "asyncRequest");
				MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, "cancellationToken");
				MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, "<>u__1");
				MobileAuthenticatedStream._StartOperation_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, 100663624);
				MobileAuthenticatedStream._StartOperation_d__58.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, 100663625);
			}

			// Token: 0x060016B6 RID: 5814 RVA: 0x0006389C File Offset: 0x00061A9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33627, XrefRangeEnd = 33658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._StartOperation_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016B7 RID: 5815 RVA: 0x000638D4 File Offset: 0x00061AD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33658, XrefRangeEnd = 33661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._StartOperation_d__58.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060016B8 RID: 5816 RVA: 0x0000BE07 File Offset: 0x0000A007
			public _StartOperation_d__58(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060016B9 RID: 5817 RVA: 0x0000BE10 File Offset: 0x0000A010
			public _StartOperation_d__58()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr))
			{
			}

			// Token: 0x17000751 RID: 1873
			// (get) Token: 0x060016BA RID: 5818 RVA: 0x0006391C File Offset: 0x00061B1C
			// (set) Token: 0x060016BB RID: 5819 RVA: 0x0000BE22 File Offset: 0x0000A022
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000752 RID: 1874
			// (get) Token: 0x060016BC RID: 5820 RVA: 0x00063944 File Offset: 0x00061B44
			// (set) Token: 0x060016BD RID: 5821 RVA: 0x0000BE3D File Offset: 0x0000A03D
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000753 RID: 1875
			// (get) Token: 0x060016BE RID: 5822 RVA: 0x00063974 File Offset: 0x00061B74
			// (set) Token: 0x060016BF RID: 5823 RVA: 0x0000BE6B File Offset: 0x0000A06B
			public unsafe MobileAuthenticatedStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000754 RID: 1876
			// (get) Token: 0x060016C0 RID: 5824 RVA: 0x000639A4 File Offset: 0x00061BA4
			// (set) Token: 0x060016C1 RID: 5825 RVA: 0x0000BE8A File Offset: 0x0000A08A
			public unsafe MobileAuthenticatedStream.OperationType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x17000755 RID: 1877
			// (get) Token: 0x060016C2 RID: 5826 RVA: 0x000639CC File Offset: 0x00061BCC
			// (set) Token: 0x060016C3 RID: 5827 RVA: 0x0000BEA5 File Offset: 0x0000A0A5
			public unsafe AsyncProtocolRequest asyncRequest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_asyncRequest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_asyncRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x060016C4 RID: 5828 RVA: 0x000639FC File Offset: 0x00061BFC
			// (set) Token: 0x060016C5 RID: 5829 RVA: 0x0000BEC4 File Offset: 0x0000A0C4
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000757 RID: 1879
			// (get) Token: 0x060016C6 RID: 5830 RVA: 0x00063A2C File Offset: 0x00061C2C
			// (set) Token: 0x060016C7 RID: 5831 RVA: 0x0000BEF2 File Offset: 0x0000A0F2
			public ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001201 RID: 4609
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001202 RID: 4610
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001203 RID: 4611
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001204 RID: 4612
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04001205 RID: 4613
			private static readonly IntPtr NativeFieldInfoPtr_asyncRequest;

			// Token: 0x04001206 RID: 4614
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001207 RID: 4615
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001208 RID: 4616
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001209 RID: 4617
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000182 RID: 386
		[ObfuscatedName("Mono.Net.Security.MobileAuthenticatedStream+<>c__DisplayClass66_0")]
		public sealed class __c__DisplayClass66_0 : Object
		{
			// Token: 0x060016C8 RID: 5832 RVA: 0x00063A5C File Offset: 0x00061C5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_0()
			{
				Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<>c__DisplayClass66_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr);
				MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr, "<>4__this");
				MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr, "len");
				MobileAuthenticatedStream.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr, 100663626);
				MobileAuthenticatedStream.__c__DisplayClass66_0.NativeMethodInfoPtr__InnerRead_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr, 100663627);
			}

			// Token: 0x060016C9 RID: 5833 RVA: 0x00063AD8 File Offset: 0x00061CD8
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016CA RID: 5834 RVA: 0x00063B14 File Offset: 0x00061D14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33661, XrefRangeEnd = 33662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _InnerRead_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeMethodInfoPtr__InnerRead_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060016CB RID: 5835 RVA: 0x0000BF20 File Offset: 0x0000A120
			public __c__DisplayClass66_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000758 RID: 1880
			// (get) Token: 0x060016CC RID: 5836 RVA: 0x00063B50 File Offset: 0x00061D50
			// (set) Token: 0x060016CD RID: 5837 RVA: 0x0000BF29 File Offset: 0x0000A129
			public unsafe MobileAuthenticatedStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x060016CE RID: 5838 RVA: 0x00063B80 File Offset: 0x00061D80
			// (set) Token: 0x060016CF RID: 5839 RVA: 0x0000BF48 File Offset: 0x0000A148
			public unsafe int len
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr_len);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr_len)) = value;
				}
			}

			// Token: 0x0400120A RID: 4618
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400120B RID: 4619
			private static readonly IntPtr NativeFieldInfoPtr_len;

			// Token: 0x0400120C RID: 4620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400120D RID: 4621
			private static readonly IntPtr NativeMethodInfoPtr__InnerRead_b__0_Internal_Int32_0;
		}

		// Token: 0x02000183 RID: 387
		[ObfuscatedName("Mono.Net.Security.MobileAuthenticatedStream+<InnerRead>d__66")]
		public sealed class _InnerRead_d__66 : ValueType
		{
			// Token: 0x060016D0 RID: 5840 RVA: 0x00063BA8 File Offset: 0x00061DA8
			// Note: this type is marked as 'beforefieldinit'.
			static _InnerRead_d__66()
			{
				Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<InnerRead>d__66");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr);
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "<>1__state");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "<>t__builder");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "<>4__this");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "cancellationToken");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_requestedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "requestedSize");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_sync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "sync");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "<>u__1");
				MobileAuthenticatedStream._InnerRead_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, 100663628);
				MobileAuthenticatedStream._InnerRead_d__66.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, 100663629);
			}

			// Token: 0x060016D1 RID: 5841 RVA: 0x00063C88 File Offset: 0x00061E88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33662, XrefRangeEnd = 33704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._InnerRead_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016D2 RID: 5842 RVA: 0x00063CC0 File Offset: 0x00061EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33704, XrefRangeEnd = 33707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._InnerRead_d__66.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060016D3 RID: 5843 RVA: 0x0000BF63 File Offset: 0x0000A163
			public _InnerRead_d__66(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060016D4 RID: 5844 RVA: 0x0000BF6C File Offset: 0x0000A16C
			public _InnerRead_d__66()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr))
			{
			}

			// Token: 0x1700075A RID: 1882
			// (get) Token: 0x060016D5 RID: 5845 RVA: 0x00063D08 File Offset: 0x00061F08
			// (set) Token: 0x060016D6 RID: 5846 RVA: 0x0000BF7E File Offset: 0x0000A17E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700075B RID: 1883
			// (get) Token: 0x060016D7 RID: 5847 RVA: 0x00063D30 File Offset: 0x00061F30
			// (set) Token: 0x060016D8 RID: 5848 RVA: 0x0000BF99 File Offset: 0x0000A199
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700075C RID: 1884
			// (get) Token: 0x060016D9 RID: 5849 RVA: 0x00063D60 File Offset: 0x00061F60
			// (set) Token: 0x060016DA RID: 5850 RVA: 0x0000BFC7 File Offset: 0x0000A1C7
			public unsafe MobileAuthenticatedStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700075D RID: 1885
			// (get) Token: 0x060016DB RID: 5851 RVA: 0x00063D90 File Offset: 0x00061F90
			// (set) Token: 0x060016DC RID: 5852 RVA: 0x0000BFE6 File Offset: 0x0000A1E6
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700075E RID: 1886
			// (get) Token: 0x060016DD RID: 5853 RVA: 0x00063DC0 File Offset: 0x00061FC0
			// (set) Token: 0x060016DE RID: 5854 RVA: 0x0000C014 File Offset: 0x0000A214
			public unsafe int requestedSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_requestedSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_requestedSize)) = value;
				}
			}

			// Token: 0x1700075F RID: 1887
			// (get) Token: 0x060016DF RID: 5855 RVA: 0x00063DE8 File Offset: 0x00061FE8
			// (set) Token: 0x060016E0 RID: 5856 RVA: 0x0000C02F File Offset: 0x0000A22F
			public unsafe bool sync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_sync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_sync)) = value;
				}
			}

			// Token: 0x17000760 RID: 1888
			// (get) Token: 0x060016E1 RID: 5857 RVA: 0x00063E10 File Offset: 0x00062010
			// (set) Token: 0x060016E2 RID: 5858 RVA: 0x0000C04A File Offset: 0x0000A24A
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400120E RID: 4622
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400120F RID: 4623
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001210 RID: 4624
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001211 RID: 4625
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001212 RID: 4626
			private static readonly IntPtr NativeFieldInfoPtr_requestedSize;

			// Token: 0x04001213 RID: 4627
			private static readonly IntPtr NativeFieldInfoPtr_sync;

			// Token: 0x04001214 RID: 4628
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001215 RID: 4629
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001216 RID: 4630
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000184 RID: 388
		[ObfuscatedName("Mono.Net.Security.MobileAuthenticatedStream+<InnerWrite>d__67")]
		public sealed class _InnerWrite_d__67 : ValueType
		{
			// Token: 0x060016E3 RID: 5859 RVA: 0x00063E40 File Offset: 0x00062040
			// Note: this type is marked as 'beforefieldinit'.
			static _InnerWrite_d__67()
			{
				Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<InnerWrite>d__67");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr);
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "<>1__state");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "<>t__builder");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "cancellationToken");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "<>4__this");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_sync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "sync");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "<>u__1");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, 100663630);
				MobileAuthenticatedStream._InnerWrite_d__67.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, 100663631);
			}

			// Token: 0x060016E4 RID: 5860 RVA: 0x00063F0C File Offset: 0x0006210C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33707, XrefRangeEnd = 33730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._InnerWrite_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016E5 RID: 5861 RVA: 0x00063F44 File Offset: 0x00062144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._InnerWrite_d__67.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060016E6 RID: 5862 RVA: 0x0000C078 File Offset: 0x0000A278
			public _InnerWrite_d__67(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060016E7 RID: 5863 RVA: 0x0000C081 File Offset: 0x0000A281
			public _InnerWrite_d__67()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr))
			{
			}

			// Token: 0x17000761 RID: 1889
			// (get) Token: 0x060016E8 RID: 5864 RVA: 0x00063F8C File Offset: 0x0006218C
			// (set) Token: 0x060016E9 RID: 5865 RVA: 0x0000C093 File Offset: 0x0000A293
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000762 RID: 1890
			// (get) Token: 0x060016EA RID: 5866 RVA: 0x00063FB4 File Offset: 0x000621B4
			// (set) Token: 0x060016EB RID: 5867 RVA: 0x0000C0AE File Offset: 0x0000A2AE
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000763 RID: 1891
			// (get) Token: 0x060016EC RID: 5868 RVA: 0x00063FE4 File Offset: 0x000621E4
			// (set) Token: 0x060016ED RID: 5869 RVA: 0x0000C0DC File Offset: 0x0000A2DC
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000764 RID: 1892
			// (get) Token: 0x060016EE RID: 5870 RVA: 0x00064014 File Offset: 0x00062214
			// (set) Token: 0x060016EF RID: 5871 RVA: 0x0000C10A File Offset: 0x0000A30A
			public unsafe MobileAuthenticatedStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000765 RID: 1893
			// (get) Token: 0x060016F0 RID: 5872 RVA: 0x00064044 File Offset: 0x00062244
			// (set) Token: 0x060016F1 RID: 5873 RVA: 0x0000C129 File Offset: 0x0000A329
			public unsafe bool sync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_sync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_sync)) = value;
				}
			}

			// Token: 0x17000766 RID: 1894
			// (get) Token: 0x060016F2 RID: 5874 RVA: 0x0006406C File Offset: 0x0006226C
			// (set) Token: 0x060016F3 RID: 5875 RVA: 0x0000C144 File Offset: 0x0000A344
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001217 RID: 4631
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001218 RID: 4632
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001219 RID: 4633
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400121A RID: 4634
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400121B RID: 4635
			private static readonly IntPtr NativeFieldInfoPtr_sync;

			// Token: 0x0400121C RID: 4636
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400121D RID: 4637
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400121E RID: 4638
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
