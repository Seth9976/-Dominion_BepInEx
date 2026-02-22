using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Unity
{
	// Token: 0x02000009 RID: 9
	public class UnityTlsProvider : MonoTlsProvider
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00011D44 File Offset: 0x0000FF44
		// Note: this type is marked as 'beforefieldinit'.
		static UnityTlsProvider()
		{
			Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "UnityTlsProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr);
			UnityTlsProvider.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663408);
			UnityTlsProvider.NativeMethodInfoPtr_get_ID_Public_Virtual_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663409);
			UnityTlsProvider.NativeMethodInfoPtr_get_SupportsSslStream_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663410);
			UnityTlsProvider.NativeMethodInfoPtr_get_SupportsMonoExtensions_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663411);
			UnityTlsProvider.NativeMethodInfoPtr_get_SupportsConnectionInfo_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663412);
			UnityTlsProvider.NativeMethodInfoPtr_get_SupportsCleanShutdown_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663413);
			UnityTlsProvider.NativeMethodInfoPtr_get_SupportedProtocols_Public_Virtual_get_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663414);
			UnityTlsProvider.NativeMethodInfoPtr_CreateSslStream_Public_Virtual_IMonoSslStream_Stream_Boolean_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663415);
			UnityTlsProvider.NativeMethodInfoPtr_CreateSslStreamInternal_Internal_Virtual_IMonoSslStream_SslStream_Stream_Boolean_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663416);
			UnityTlsProvider.NativeMethodInfoPtr_ValidateCertificate_Internal_Virtual_Boolean_ICertificateValidator2_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_MonoSslPolicyErrors_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663417);
			UnityTlsProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663418);
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00011E50 File Offset: 0x00010050
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32251, XrefRangeEnd = 32253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00011E94 File Offset: 0x00010094
		public unsafe override Guid ID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32253, XrefRangeEnd = 32257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_get_ID_Public_Virtual_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00011EDC File Offset: 0x000100DC
		public unsafe override bool SupportsSslStream
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_get_SupportsSslStream_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00011F24 File Offset: 0x00010124
		public unsafe override bool SupportsMonoExtensions
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_get_SupportsMonoExtensions_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00011F6C File Offset: 0x0001016C
		public unsafe override bool SupportsConnectionInfo
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_get_SupportsConnectionInfo_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00011FB4 File Offset: 0x000101B4
		public unsafe override bool SupportsCleanShutdown
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_get_SupportsCleanShutdown_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00011FFC File Offset: 0x000101FC
		public unsafe override SslProtocols SupportedProtocols
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_get_SupportedProtocols_Public_Virtual_get_SslProtocols_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00012044 File Offset: 0x00010244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32257, XrefRangeEnd = 32261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveInnerStreamOpen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_CreateSslStream_Public_Virtual_IMonoSslStream_Stream_Boolean_MonoTlsSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMonoSslStream>(intPtr3) : null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000120C0 File Offset: 0x000102C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32261, XrefRangeEnd = 32268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sslStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveInnerStreamOpen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_CreateSslStreamInternal_Internal_Virtual_IMonoSslStream_SslStream_Stream_Boolean_MonoTlsSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMonoSslStream>(intPtr3) : null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00012150 File Offset: 0x00010350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32268, XrefRangeEnd = 32279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificates);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wantsChain;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errors;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &status11;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_ValidateCertificate_Internal_Virtual_Boolean_ICertificateValidator2_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_MonoSslPolicyErrors_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chain = ((intPtr4 == 0) ? null : new X509Chain(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00012234 File Offset: 0x00010434
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityTlsProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000022EA File Offset: 0x000004EA
		public UnityTlsProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Public_Virtual_get_Guid_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsSslStream_Public_Virtual_get_Boolean_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsMonoExtensions_Public_Virtual_get_Boolean_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsConnectionInfo_Public_Virtual_get_Boolean_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsCleanShutdown_Internal_Virtual_get_Boolean_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportedProtocols_Public_Virtual_get_SslProtocols_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_CreateSslStream_Public_Virtual_IMonoSslStream_Stream_Boolean_MonoTlsSettings_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_CreateSslStreamInternal_Internal_Virtual_IMonoSslStream_SslStream_Stream_Boolean_MonoTlsSettings_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificate_Internal_Virtual_Boolean_ICertificateValidator2_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_MonoSslPolicyErrors_byref_Int32_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
