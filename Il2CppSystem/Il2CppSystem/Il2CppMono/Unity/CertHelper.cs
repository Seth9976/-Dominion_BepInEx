using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Unity
{
	// Token: 0x02000004 RID: 4
	public static class CertHelper : Object
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00010A70 File Offset: 0x0000EC70
		// Note: this type is marked as 'beforefieldinit'.
		static CertHelper()
		{
			Il2CppClassPointerStore<CertHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "CertHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CertHelper>.NativeClassPtr);
			CertHelper.NativeMethodInfoPtr_AddCertificatesToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509CertificateCollection_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertHelper>.NativeClassPtr, 100663303);
			CertHelper.NativeMethodInfoPtr_AddCertificateToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509Certificate_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertHelper>.NativeClassPtr, 100663304);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00010AC8 File Offset: 0x0000ECC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31621, XrefRangeEnd = 31632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddCertificatesToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = nativeCertificateChain;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertHelper.NativeMethodInfoPtr_AddCertificatesToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509CertificateCollection_ptr_unitytls_errorstate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00010B18 File Offset: 0x0000ED18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 31647, RefRangeEnd = 31650, XrefRangeStart = 31632, XrefRangeEnd = 31647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddCertificateToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509Certificate certificate, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = nativeCertificateChain;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertHelper.NativeMethodInfoPtr_AddCertificateToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509Certificate_ptr_unitytls_errorstate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020B8 File Offset: 0x000002B8
		public CertHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificatesToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509CertificateCollection_ptr_unitytls_errorstate_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificateToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509Certificate_ptr_unitytls_errorstate_0;
	}
}
