using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000025 RID: 37
	public class MobileTlsContext : Object
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x00018088 File Offset: 0x00016288
		// Note: this type is marked as 'beforefieldinit'.
		static MobileTlsContext()
		{
			Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MobileTlsContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr);
			MobileTlsContext.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "parent");
			MobileTlsContext.NativeFieldInfoPtr_serverMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "serverMode");
			MobileTlsContext.NativeFieldInfoPtr_targetHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "targetHost");
			MobileTlsContext.NativeFieldInfoPtr_serverName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "serverName");
			MobileTlsContext.NativeFieldInfoPtr_enabledProtocols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "enabledProtocols");
			MobileTlsContext.NativeFieldInfoPtr_serverCertificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "serverCertificate");
			MobileTlsContext.NativeFieldInfoPtr_clientCertificates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "clientCertificates");
			MobileTlsContext.NativeFieldInfoPtr_askForClientCert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "askForClientCert");
			MobileTlsContext.NativeFieldInfoPtr_certificateValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "certificateValidator");
			MobileTlsContext.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663632);
			MobileTlsContext.NativeMethodInfoPtr_get_Parent_Internal_get_MobileAuthenticatedStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663633);
			MobileTlsContext.NativeMethodInfoPtr_get_Settings_Public_get_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663634);
			MobileTlsContext.NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663635);
			MobileTlsContext.NativeMethodInfoPtr_get_IsServer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663636);
			MobileTlsContext.NativeMethodInfoPtr_get_TargetHost_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663637);
			MobileTlsContext.NativeMethodInfoPtr_get_ServerName_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663638);
			MobileTlsContext.NativeMethodInfoPtr_get_ClientCertificates_Protected_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663639);
			MobileTlsContext.NativeMethodInfoPtr_StartHandshake_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663640);
			MobileTlsContext.NativeMethodInfoPtr_ProcessHandshake_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663641);
			MobileTlsContext.NativeMethodInfoPtr_FinishHandshake_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663642);
			MobileTlsContext.NativeMethodInfoPtr_get_LocalServerCertificate_Internal_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663643);
			MobileTlsContext.NativeMethodInfoPtr_get_LocalClientCertificate_Internal_Abstract_Virtual_New_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663644);
			MobileTlsContext.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663645);
			MobileTlsContext.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663646);
			MobileTlsContext.NativeMethodInfoPtr_Shutdown_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663647);
			MobileTlsContext.NativeMethodInfoPtr_ValidateCertificate_Protected_Boolean_X509Certificate_X509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663648);
			MobileTlsContext.NativeMethodInfoPtr_SelectClientCertificate_Protected_X509Certificate_X509Certificate_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663649);
			MobileTlsContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663650);
			MobileTlsContext.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663651);
			MobileTlsContext.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663652);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00018310 File Offset: 0x00016510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34002, RefRangeEnd = 34003, XrefRangeStart = 33994, XrefRangeEnd = 34002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MobileTlsContext(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000183C0 File Offset: 0x000165C0
		public unsafe MobileAuthenticatedStream Parent
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_Parent_Internal_get_MobileAuthenticatedStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr3) : null;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00018400 File Offset: 0x00016600
		public unsafe MonoTlsSettings Settings
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 34003, RefRangeEnd = 34009, XrefRangeStart = 34003, XrefRangeEnd = 34003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_Settings_Public_get_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00018440 File Offset: 0x00016640
		public unsafe virtual bool IsAuthenticated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00018488 File Offset: 0x00016688
		public unsafe bool IsServer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_IsServer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000184C4 File Offset: 0x000166C4
		public unsafe string TargetHost
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_TargetHost_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000184FC File Offset: 0x000166FC
		public unsafe string ServerName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_ServerName_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00018534 File Offset: 0x00016734
		public unsafe X509CertificateCollection ClientCertificates
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_ClientCertificates_Protected_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00018574 File Offset: 0x00016774
		[CallerCount(0)]
		public unsafe virtual void StartHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_StartHandshake_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000185B0 File Offset: 0x000167B0
		[CallerCount(0)]
		public unsafe virtual bool ProcessHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_ProcessHandshake_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000185F8 File Offset: 0x000167F8
		[CallerCount(0)]
		public unsafe virtual void FinishHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_FinishHandshake_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00018634 File Offset: 0x00016834
		public unsafe X509Certificate LocalServerCertificate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_LocalServerCertificate_Internal_get_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00018674 File Offset: 0x00016874
		public unsafe virtual X509Certificate LocalClientCertificate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_get_LocalClientCertificate_Internal_Abstract_Virtual_New_get_X509Certificate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000186C0 File Offset: 0x000168C0
		[CallerCount(0)]
		public unsafe virtual ValueTuple<int, bool> Read(Il2CppStructArray<byte> buffer, int offset, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, bool>(intPtr);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00018730 File Offset: 0x00016930
		[CallerCount(0)]
		public unsafe virtual ValueTuple<int, bool> Write(Il2CppStructArray<byte> buffer, int offset, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, bool>(intPtr);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000187A0 File Offset: 0x000169A0
		[CallerCount(0)]
		public unsafe virtual void Shutdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_Shutdown_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000187DC File Offset: 0x000169DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34012, RefRangeEnd = 34014, XrefRangeStart = 34009, XrefRangeEnd = 34012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateCertificate(X509Certificate leaf, X509Chain chain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leaf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_ValidateCertificate_Protected_Boolean_X509Certificate_X509Chain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0001883C File Offset: 0x00016A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34022, RefRangeEnd = 34023, XrefRangeStart = 34014, XrefRangeEnd = 34022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate SelectClientCertificate(X509Certificate serverCertificate, Il2CppStringArray acceptableIssuers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serverCertificate);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acceptableIssuers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_SelectClientCertificate_Protected_X509Certificate_X509Certificate_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000188A0 File Offset: 0x00016AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34023, XrefRangeEnd = 34027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000188D4 File Offset: 0x00016AD4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00018920 File Offset: 0x00016B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34027, XrefRangeEnd = 34030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002B00 File Offset: 0x00000D00
		public MobileTlsContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0001895C File Offset: 0x00016B5C
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00002B09 File Offset: 0x00000D09
		public unsafe MobileAuthenticatedStream parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0001898C File Offset: 0x00016B8C
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00002B28 File Offset: 0x00000D28
		public unsafe bool serverMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_serverMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_serverMode)) = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000189B4 File Offset: 0x00016BB4
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00002B43 File Offset: 0x00000D43
		public unsafe string targetHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_targetHost);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_targetHost), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001FF RID: 511 RVA: 0x000189DC File Offset: 0x00016BDC
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00002B62 File Offset: 0x00000D62
		public unsafe string serverName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_serverName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_serverName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00018A04 File Offset: 0x00016C04
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00002B81 File Offset: 0x00000D81
		public unsafe SslProtocols enabledProtocols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_enabledProtocols);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_enabledProtocols)) = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00018A2C File Offset: 0x00016C2C
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00002B9C File Offset: 0x00000D9C
		public unsafe X509Certificate serverCertificate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_serverCertificate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_serverCertificate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00018A5C File Offset: 0x00016C5C
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00002BBB File Offset: 0x00000DBB
		public unsafe X509CertificateCollection clientCertificates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_clientCertificates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_clientCertificates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00018A8C File Offset: 0x00016C8C
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00002BDA File Offset: 0x00000DDA
		public unsafe bool askForClientCert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_askForClientCert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_askForClientCert)) = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00018AB4 File Offset: 0x00016CB4
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00002BF5 File Offset: 0x00000DF5
		public unsafe ICertificateValidator2 certificateValidator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_certificateValidator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICertificateValidator2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_certificateValidator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_serverMode;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_targetHost;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_serverName;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_enabledProtocols;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_serverCertificate;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_clientCertificates;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_askForClientCert;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_certificateValidator;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Internal_get_MobileAuthenticatedStream_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_MonoTlsSettings_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_get_IsServer_Public_get_Boolean_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetHost_Protected_get_String_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerName_Protected_get_String_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificates_Protected_get_X509CertificateCollection_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_StartHandshake_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandshake_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_FinishHandshake_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalServerCertificate_Internal_get_X509Certificate_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalClientCertificate_Internal_Abstract_Virtual_New_get_X509Certificate_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificate_Protected_Boolean_X509Certificate_X509Chain_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_SelectClientCertificate_Protected_X509Certificate_X509Certificate_Il2CppStringArray_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
