using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security.Private
{
	// Token: 0x0200002A RID: 42
	public static class CallbackHelpers : Object
	{
		// Token: 0x06000246 RID: 582 RVA: 0x00019470 File Offset: 0x00017670
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackHelpers()
		{
			Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security.Private", "CallbackHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr);
			CallbackHelpers.NativeMethodInfoPtr_MonoToPublic_Internal_Static_RemoteCertificateValidationCallback_MonoRemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr, 100663672);
			CallbackHelpers.NativeMethodInfoPtr_MonoToInternal_Internal_Static_LocalCertSelectionCallback_MonoLocalCertificateSelectionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr, 100663673);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000194C8 File Offset: 0x000176C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34339, XrefRangeEnd = 34349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RemoteCertificateValidationCallback MonoToPublic(MonoRemoteCertificateValidationCallback callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.NativeMethodInfoPtr_MonoToPublic_Internal_Static_RemoteCertificateValidationCallback_MonoRemoteCertificateValidationCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RemoteCertificateValidationCallback>(intPtr3) : null;
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0001950C File Offset: 0x0001770C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34349, XrefRangeEnd = 34359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.NativeMethodInfoPtr_MonoToInternal_Internal_Static_LocalCertSelectionCallback_MonoLocalCertificateSelectionCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalCertSelectionCallback>(intPtr3) : null;
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002DEC File Offset: 0x00000FEC
		public CallbackHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_MonoToPublic_Internal_Static_RemoteCertificateValidationCallback_MonoRemoteCertificateValidationCallback_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_MonoToInternal_Internal_Static_LocalCertSelectionCallback_MonoLocalCertificateSelectionCallback_0;

		// Token: 0x02000186 RID: 390
		[ObfuscatedName("Mono.Net.Security.Private.CallbackHelpers+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06001707 RID: 5895 RVA: 0x00064344 File Offset: 0x00062544
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass5_0>.NativeClassPtr);
				CallbackHelpers.__c__DisplayClass5_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass5_0>.NativeClassPtr, "callback");
				CallbackHelpers.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass5_0>.NativeClassPtr, 100663674);
				CallbackHelpers.__c__DisplayClass5_0.NativeMethodInfoPtr__MonoToPublic_b__0_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass5_0>.NativeClassPtr, 100663675);
			}

			// Token: 0x06001708 RID: 5896 RVA: 0x000643AC File Offset: 0x000625AC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001709 RID: 5897 RVA: 0x000643E8 File Offset: 0x000625E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34330, XrefRangeEnd = 34332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MonoToPublic_b__0(Object t, X509Certificate c, X509Chain ch, SslPolicyErrors e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ch);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref e;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.__c__DisplayClass5_0.NativeMethodInfoPtr__MonoToPublic_b__0_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600170A RID: 5898 RVA: 0x0000C28F File Offset: 0x0000A48F
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700076E RID: 1902
			// (get) Token: 0x0600170B RID: 5899 RVA: 0x00064468 File Offset: 0x00062668
			// (set) Token: 0x0600170C RID: 5900 RVA: 0x0000C298 File Offset: 0x0000A498
			public unsafe MonoRemoteCertificateValidationCallback callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackHelpers.__c__DisplayClass5_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoRemoteCertificateValidationCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackHelpers.__c__DisplayClass5_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001228 RID: 4648
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04001229 RID: 4649
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400122A RID: 4650
			private static readonly IntPtr NativeMethodInfoPtr__MonoToPublic_b__0_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0;
		}

		// Token: 0x02000187 RID: 391
		[ObfuscatedName("Mono.Net.Security.Private.CallbackHelpers+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600170D RID: 5901 RVA: 0x00064498 File Offset: 0x00062698
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass8_0>.NativeClassPtr);
				CallbackHelpers.__c__DisplayClass8_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass8_0>.NativeClassPtr, "callback");
				CallbackHelpers.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass8_0>.NativeClassPtr, 100663676);
				CallbackHelpers.__c__DisplayClass8_0.NativeMethodInfoPtr__MonoToInternal_b__0_Internal_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass8_0>.NativeClassPtr, 100663677);
			}

			// Token: 0x0600170E RID: 5902 RVA: 0x00064500 File Offset: 0x00062700
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600170F RID: 5903 RVA: 0x0006453C File Offset: 0x0006273C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34332, XrefRangeEnd = 34339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe X509Certificate _MonoToInternal_b__0(string t, X509CertificateCollection lc, X509Certificate rc, Il2CppStringArray ai)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lc);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rc);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ai);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.__c__DisplayClass8_0.NativeMethodInfoPtr__MonoToInternal_b__0_Internal_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}

			// Token: 0x06001710 RID: 5904 RVA: 0x0000C2B7 File Offset: 0x0000A4B7
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700076F RID: 1903
			// (get) Token: 0x06001711 RID: 5905 RVA: 0x000645C4 File Offset: 0x000627C4
			// (set) Token: 0x06001712 RID: 5906 RVA: 0x0000C2C0 File Offset: 0x0000A4C0
			public unsafe MonoLocalCertificateSelectionCallback callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackHelpers.__c__DisplayClass8_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoLocalCertificateSelectionCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackHelpers.__c__DisplayClass8_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400122B RID: 4651
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400122C RID: 4652
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400122D RID: 4653
			private static readonly IntPtr NativeMethodInfoPtr__MonoToInternal_b__0_Internal_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0;
		}
	}
}
