using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x0200001E RID: 30
	public static class CertificateValidationHelper : Object
	{
		// Token: 0x06000189 RID: 393 RVA: 0x0000917C File Offset: 0x0000737C
		// Note: this type is marked as 'beforefieldinit'.
		static CertificateValidationHelper()
		{
			Il2CppClassPointerStore<CertificateValidationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "CertificateValidationHelper");
			CertificateValidationHelper.NativeFieldInfoPtr_noX509Chain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateValidationHelper>.NativeClassPtr, "noX509Chain");
			CertificateValidationHelper.NativeFieldInfoPtr_supportsTrustAnchors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateValidationHelper>.NativeClassPtr, "supportsTrustAnchors");
			CertificateValidationHelper.NativeMethodInfoPtr_GetInternalValidator_Internal_Static_ICertificateValidator2_MonoTlsSettings_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateValidationHelper>.NativeClassPtr, 100663502);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000091E0 File Offset: 0x000073E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 9058, RefRangeEnd = 9059, XrefRangeStart = 9055, XrefRangeEnd = 9058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICertificateValidator2 GetInternalValidator(MonoTlsSettings settings, MonoTlsProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateValidationHelper.NativeMethodInfoPtr_GetInternalValidator_Internal_Static_ICertificateValidator2_MonoTlsSettings_MonoTlsProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICertificateValidator2>(intPtr3) : null;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002B31 File Offset: 0x00000D31
		public CertificateValidationHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00009238 File Offset: 0x00007438
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00002B3A File Offset: 0x00000D3A
		public unsafe static bool noX509Chain
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CertificateValidationHelper.NativeFieldInfoPtr_noX509Chain, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CertificateValidationHelper.NativeFieldInfoPtr_noX509Chain, (void*)(&value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00009254 File Offset: 0x00007454
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00002B48 File Offset: 0x00000D48
		public unsafe static bool supportsTrustAnchors
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CertificateValidationHelper.NativeFieldInfoPtr_supportsTrustAnchors, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CertificateValidationHelper.NativeFieldInfoPtr_supportsTrustAnchors, (void*)(&value));
			}
		}

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeFieldInfoPtr_noX509Chain;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeFieldInfoPtr_supportsTrustAnchors;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalValidator_Internal_Static_ICertificateValidator2_MonoTlsSettings_MonoTlsProvider_0;
	}
}
