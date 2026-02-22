using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000029 RID: 41
	public static class SystemCertificateValidator : Object
	{
		// Token: 0x0600023E RID: 574 RVA: 0x00019338 File Offset: 0x00017538
		// Note: this type is marked as 'beforefieldinit'.
		static SystemCertificateValidator()
		{
			Il2CppClassPointerStore<SystemCertificateValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "SystemCertificateValidator");
			SystemCertificateValidator.NativeFieldInfoPtr_is_macosx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemCertificateValidator>.NativeClassPtr, "is_macosx");
			SystemCertificateValidator.NativeFieldInfoPtr_s_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemCertificateValidator>.NativeClassPtr, "s_flags");
			SystemCertificateValidator.NativeMethodInfoPtr_CreateX509Chain_Public_Static_X509Chain_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateValidator>.NativeClassPtr, 100663670);
			SystemCertificateValidator.NativeMethodInfoPtr_NeedsChain_Internal_Static_Boolean_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateValidator>.NativeClassPtr, 100663671);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000193B0 File Offset: 0x000175B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34319, XrefRangeEnd = 34330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Chain CreateX509Chain(X509CertificateCollection certs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemCertificateValidator.NativeMethodInfoPtr_CreateX509Chain_Public_Static_X509Chain_X509CertificateCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Chain>(intPtr3) : null;
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000193F4 File Offset: 0x000175F4
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NeedsChain(MonoTlsSettings settings)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemCertificateValidator.NativeMethodInfoPtr_NeedsChain_Internal_Static_Boolean_MonoTlsSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002DC7 File Offset: 0x00000FC7
		public SystemCertificateValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00019438 File Offset: 0x00017638
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00002DD0 File Offset: 0x00000FD0
		public unsafe static bool is_macosx
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SystemCertificateValidator.NativeFieldInfoPtr_is_macosx, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemCertificateValidator.NativeFieldInfoPtr_is_macosx, (void*)(&value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00019454 File Offset: 0x00017654
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00002DDE File Offset: 0x00000FDE
		public unsafe static X509KeyUsageFlags s_flags
		{
			get
			{
				X509KeyUsageFlags x509KeyUsageFlags;
				IL2CPP.il2cpp_field_static_get_value(SystemCertificateValidator.NativeFieldInfoPtr_s_flags, (void*)(&x509KeyUsageFlags));
				return x509KeyUsageFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemCertificateValidator.NativeFieldInfoPtr_s_flags, (void*)(&value));
			}
		}

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr_is_macosx;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr_s_flags;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_CreateX509Chain_Public_Static_X509Chain_X509CertificateCollection_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_NeedsChain_Internal_Static_Boolean_MonoTlsSettings_0;
	}
}
