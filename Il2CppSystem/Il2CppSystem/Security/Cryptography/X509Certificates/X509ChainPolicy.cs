using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000097 RID: 151
	public sealed class X509ChainPolicy : Object
	{
		// Token: 0x06000905 RID: 2309 RVA: 0x000319E4 File Offset: 0x0002FBE4
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainPolicy()
		{
			Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainPolicy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr);
			X509ChainPolicy.NativeFieldInfoPtr_apps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "apps");
			X509ChainPolicy.NativeFieldInfoPtr_cert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "cert");
			X509ChainPolicy.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "store");
			X509ChainPolicy.NativeFieldInfoPtr_store2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "store2");
			X509ChainPolicy.NativeFieldInfoPtr_rflag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "rflag");
			X509ChainPolicy.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "mode");
			X509ChainPolicy.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "timeout");
			X509ChainPolicy.NativeFieldInfoPtr_vflags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "vflags");
			X509ChainPolicy.NativeFieldInfoPtr_vtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "vtime");
			X509ChainPolicy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100664473);
			X509ChainPolicy.NativeMethodInfoPtr__ctor_Internal_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100664474);
			X509ChainPolicy.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100664475);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00031B04 File Offset: 0x0002FD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42719, XrefRangeEnd = 42721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainPolicy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00031B40 File Offset: 0x0002FD40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42723, RefRangeEnd = 42724, XrefRangeStart = 42721, XrefRangeEnd = 42723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainPolicy(X509CertificateCollection store)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr__ctor_Internal_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00031B8C File Offset: 0x0002FD8C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 42739, RefRangeEnd = 42746, XrefRangeStart = 42724, XrefRangeEnd = 42739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00005A4D File Offset: 0x00003C4D
		public X509ChainPolicy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00031BC0 File Offset: 0x0002FDC0
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x00005A56 File Offset: 0x00003C56
		public unsafe OidCollection apps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_apps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OidCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_apps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00031BF0 File Offset: 0x0002FDF0
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00005A75 File Offset: 0x00003C75
		public unsafe OidCollection cert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_cert);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OidCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_cert), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00031C20 File Offset: 0x0002FE20
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x00005A94 File Offset: 0x00003C94
		public unsafe X509CertificateCollection store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00031C50 File Offset: 0x0002FE50
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x00005AB3 File Offset: 0x00003CB3
		public unsafe X509Certificate2Collection store2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_store2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_store2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00031C80 File Offset: 0x0002FE80
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x00005AD2 File Offset: 0x00003CD2
		public unsafe X509RevocationFlag rflag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_rflag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_rflag)) = value;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00031CA8 File Offset: 0x0002FEA8
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00005AED File Offset: 0x00003CED
		public unsafe X509RevocationMode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x00031CD0 File Offset: 0x0002FED0
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x00005B08 File Offset: 0x00003D08
		public unsafe TimeSpan timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_timeout)) = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00031CF8 File Offset: 0x0002FEF8
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x00005B23 File Offset: 0x00003D23
		public unsafe X509VerificationFlags vflags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_vflags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_vflags)) = value;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00031D20 File Offset: 0x0002FF20
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x00005B3E File Offset: 0x00003D3E
		public unsafe DateTime vtime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_vtime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_vtime)) = value;
			}
		}

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeFieldInfoPtr_apps;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeFieldInfoPtr_cert;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeFieldInfoPtr_store2;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeFieldInfoPtr_rflag;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeFieldInfoPtr_timeout;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeFieldInfoPtr_vflags;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeFieldInfoPtr_vtime;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509CertificateCollection_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
	}
}
