using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Net.Security;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Unity
{
	// Token: 0x02000007 RID: 7
	public class UnityTlsContext : MobileTlsContext
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00010DB0 File Offset: 0x0000EFB0
		// Note: this type is marked as 'beforefieldinit'.
		static UnityTlsContext()
		{
			Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "UnityTlsContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr);
			UnityTlsContext.NativeFieldInfoPtr_tlsContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "tlsContext");
			UnityTlsContext.NativeFieldInfoPtr_requestedClientCertChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "requestedClientCertChain");
			UnityTlsContext.NativeFieldInfoPtr_requestedClientKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "requestedClientKey");
			UnityTlsContext.NativeFieldInfoPtr_readCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "readCallback");
			UnityTlsContext.NativeFieldInfoPtr_writeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "writeCallback");
			UnityTlsContext.NativeFieldInfoPtr_certificateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "certificateCallback");
			UnityTlsContext.NativeFieldInfoPtr_verifyCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "verifyCallback");
			UnityTlsContext.NativeFieldInfoPtr_localClientCertificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "localClientCertificate");
			UnityTlsContext.NativeFieldInfoPtr_remoteCertificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "remoteCertificate");
			UnityTlsContext.NativeFieldInfoPtr_connectioninfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "connectioninfo");
			UnityTlsContext.NativeFieldInfoPtr_isAuthenticated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "isAuthenticated");
			UnityTlsContext.NativeFieldInfoPtr_hasContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "hasContext");
			UnityTlsContext.NativeFieldInfoPtr_closedGraceful = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "closedGraceful");
			UnityTlsContext.NativeFieldInfoPtr_writeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "writeBuffer");
			UnityTlsContext.NativeFieldInfoPtr_readBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "readBuffer");
			UnityTlsContext.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "handle");
			UnityTlsContext.NativeFieldInfoPtr_lastException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "lastException");
			UnityTlsContext.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663383);
			UnityTlsContext.NativeMethodInfoPtr_ExtractNativeKeyAndChainFromManagedCertificate_Private_Static_Void_X509Certificate_ptr_unitytls_errorstate_byref_ptr_unitytls_x509list_byref_ptr_unitytls_key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663384);
			UnityTlsContext.NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663385);
			UnityTlsContext.NativeMethodInfoPtr_get_LocalClientCertificate_Internal_Virtual_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663386);
			UnityTlsContext.NativeMethodInfoPtr_Read_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663387);
			UnityTlsContext.NativeMethodInfoPtr_Write_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663388);
			UnityTlsContext.NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663389);
			UnityTlsContext.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663390);
			UnityTlsContext.NativeMethodInfoPtr_StartHandshake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663391);
			UnityTlsContext.NativeMethodInfoPtr_ProcessHandshake_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663392);
			UnityTlsContext.NativeMethodInfoPtr_FinishHandshake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663393);
			UnityTlsContext.NativeMethodInfoPtr_WriteCallback_Private_Static_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663394);
			UnityTlsContext.NativeMethodInfoPtr_WriteCallback_Private_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663395);
			UnityTlsContext.NativeMethodInfoPtr_ReadCallback_Private_Static_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663396);
			UnityTlsContext.NativeMethodInfoPtr_ReadCallback_Private_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663397);
			UnityTlsContext.NativeMethodInfoPtr_VerifyCallback_Private_Static_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663398);
			UnityTlsContext.NativeMethodInfoPtr_VerifyCallback_Private_unitytls_x509verify_result_unitytls_x509list_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663399);
			UnityTlsContext.NativeMethodInfoPtr_CertificateCallback_Private_Static_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663400);
			UnityTlsContext.NativeMethodInfoPtr_CertificateCallback_Private_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663401);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000110B0 File Offset: 0x0000F2B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31914, RefRangeEnd = 31915, XrefRangeStart = 31808, XrefRangeEnd = 31914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityTlsContext(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabledProtocols;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverCertificate);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientCertificates);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref askForClientCert;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00011160 File Offset: 0x0000F360
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 31929, RefRangeEnd = 31931, XrefRangeStart = 31915, XrefRangeEnd = 31929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_ExtractNativeKeyAndChainFromManagedCertificate_Private_Static_Void_X509Certificate_ptr_unitytls_errorstate_byref_ptr_unitytls_x509list_byref_ptr_unitytls_key_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			nativeCertChain = ((intPtr5 == 0) ? null : new UnityTls.unitytls_x509list*(intPtr5));
			IntPtr intPtr6 = intPtr2;
			nativeKey = ((intPtr6 == 0) ? null : new UnityTls.unitytls_key*(intPtr6));
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000111E8 File Offset: 0x0000F3E8
		public unsafe override bool IsAuthenticated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00011230 File Offset: 0x0000F430
		public unsafe override X509Certificate LocalClientCertificate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_get_LocalClientCertificate_Internal_Virtual_get_X509Certificate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0001127C File Offset: 0x0000F47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31931, XrefRangeEnd = 31942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ValueTuple<int, bool> Read(Il2CppStructArray<byte> buffer, int offset, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_Read_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, bool>(intPtr);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000112EC File Offset: 0x0000F4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31942, XrefRangeEnd = 31953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ValueTuple<int, bool> Write(Il2CppStructArray<byte> buffer, int offset, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_Write_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, bool>(intPtr);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0001135C File Offset: 0x0000F55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31953, XrefRangeEnd = 31965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Shutdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00011398 File Offset: 0x0000F598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31965, XrefRangeEnd = 31969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000113E4 File Offset: 0x0000F5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31969, XrefRangeEnd = 31986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_StartHandshake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00011420 File Offset: 0x0000F620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31986, XrefRangeEnd = 31997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ProcessHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_ProcessHandshake_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00011468 File Offset: 0x0000F668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31997, XrefRangeEnd = 32010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FinishHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_FinishHandshake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000114A4 File Offset: 0x0000F6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32010, XrefRangeEnd = 32016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = userData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_WriteCallback_Private_Static_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00011508 File Offset: 0x0000F708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32037, RefRangeEnd = 32038, XrefRangeStart = 32016, XrefRangeEnd = 32037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_WriteCallback_Private_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0001156C File Offset: 0x0000F76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32038, XrefRangeEnd = 32044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = userData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_ReadCallback_Private_Static_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000115D0 File Offset: 0x0000F7D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32071, RefRangeEnd = 32072, XrefRangeStart = 32044, XrefRangeEnd = 32071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_ReadCallback_Private_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00011634 File Offset: 0x0000F834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32072, XrefRangeEnd = 32078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = userData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chain;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_VerifyCallback_Private_Static_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0001168C File Offset: 0x0000F88C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32099, RefRangeEnd = 32100, XrefRangeStart = 32078, XrefRangeEnd = 32099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref chain;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_VerifyCallback_Private_unitytls_x509verify_result_unitytls_x509list_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000116E4 File Offset: 0x0000F8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32100, XrefRangeEnd = 32106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = userData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ctx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = caList;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caListLen;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chain;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = key;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_CertificateCallback_Private_Static_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00011784 File Offset: 0x0000F984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32125, RefRangeEnd = 32126, XrefRangeStart = 32106, XrefRangeEnd = 32125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ctx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = caList;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caListLen;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chain;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = key;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_CertificateCallback_Private_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000020E5 File Offset: 0x000002E5
		public UnityTlsContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00011824 File Offset: 0x0000FA24
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000020EE File Offset: 0x000002EE
		public unsafe UnityTls.unitytls_tlsctx* tlsContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_tlsContext);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_tlsContext)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00011848 File Offset: 0x0000FA48
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002109 File Offset: 0x00000309
		public unsafe UnityTls.unitytls_x509list* requestedClientCertChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_requestedClientCertChain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_requestedClientCertChain)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0001186C File Offset: 0x0000FA6C
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002124 File Offset: 0x00000324
		public unsafe UnityTls.unitytls_key* requestedClientKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_requestedClientKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_requestedClientKey)) = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00011890 File Offset: 0x0000FA90
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0000213F File Offset: 0x0000033F
		public unsafe UnityTls.unitytls_tlsctx_read_callback readCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_readCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_tlsctx_read_callback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_readCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000118C0 File Offset: 0x0000FAC0
		// (set) Token: 0x0600003A RID: 58 RVA: 0x0000215E File Offset: 0x0000035E
		public unsafe UnityTls.unitytls_tlsctx_write_callback writeCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_writeCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_tlsctx_write_callback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_writeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000118F0 File Offset: 0x0000FAF0
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000217D File Offset: 0x0000037D
		public unsafe UnityTls.unitytls_tlsctx_certificate_callback certificateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_certificateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_tlsctx_certificate_callback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_certificateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00011920 File Offset: 0x0000FB20
		// (set) Token: 0x0600003E RID: 62 RVA: 0x0000219C File Offset: 0x0000039C
		public unsafe UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_verifyCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_tlsctx_x509verify_callback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_verifyCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00011950 File Offset: 0x0000FB50
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000021BB File Offset: 0x000003BB
		public unsafe X509Certificate localClientCertificate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_localClientCertificate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_localClientCertificate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00011980 File Offset: 0x0000FB80
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000021DA File Offset: 0x000003DA
		public unsafe X509Certificate remoteCertificate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_remoteCertificate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_remoteCertificate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000119B0 File Offset: 0x0000FBB0
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000021F9 File Offset: 0x000003F9
		public unsafe MonoTlsConnectionInfo connectioninfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_connectioninfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsConnectionInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_connectioninfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000119E0 File Offset: 0x0000FBE0
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002218 File Offset: 0x00000418
		public unsafe bool isAuthenticated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_isAuthenticated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_isAuthenticated)) = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00011A08 File Offset: 0x0000FC08
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002233 File Offset: 0x00000433
		public unsafe bool hasContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_hasContext);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_hasContext)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00011A30 File Offset: 0x0000FC30
		// (set) Token: 0x0600004A RID: 74 RVA: 0x0000224E File Offset: 0x0000044E
		public unsafe bool closedGraceful
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_closedGraceful);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_closedGraceful)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00011A58 File Offset: 0x0000FC58
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002269 File Offset: 0x00000469
		public unsafe Il2CppStructArray<byte> writeBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_writeBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_writeBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00011A88 File Offset: 0x0000FC88
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002288 File Offset: 0x00000488
		public unsafe Il2CppStructArray<byte> readBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_readBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_readBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00011AB8 File Offset: 0x0000FCB8
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000022A7 File Offset: 0x000004A7
		public unsafe GCHandle handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00011AE0 File Offset: 0x0000FCE0
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000022C2 File Offset: 0x000004C2
		public unsafe Exception lastException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_lastException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_lastException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_tlsContext;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_requestedClientCertChain;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_requestedClientKey;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_readCallback;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_writeCallback;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_certificateCallback;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_verifyCallback;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_localClientCertificate;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_remoteCertificate;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_connectioninfo;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_isAuthenticated;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_hasContext;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_closedGraceful;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_writeBuffer;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_readBuffer;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_lastException;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_ExtractNativeKeyAndChainFromManagedCertificate_Private_Static_Void_X509Certificate_ptr_unitytls_errorstate_byref_ptr_unitytls_x509list_byref_ptr_unitytls_key_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalClientCertificate_Internal_Virtual_get_X509Certificate_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_StartHandshake_Public_Virtual_Void_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandshake_Public_Virtual_Boolean_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_FinishHandshake_Public_Virtual_Void_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_WriteCallback_Private_Static_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_WriteCallback_Private_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_ReadCallback_Private_Static_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_ReadCallback_Private_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_VerifyCallback_Private_Static_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_VerifyCallback_Private_unitytls_x509verify_result_unitytls_x509list_ref_ptr_unitytls_errorstate_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_CertificateCallback_Private_Static_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_CertificateCallback_Private_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0;
	}
}
