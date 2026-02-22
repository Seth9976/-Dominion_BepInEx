using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppMono.Http
{
	// Token: 0x0200002C RID: 44
	public class NtlmClient : Object
	{
		// Token: 0x06000250 RID: 592 RVA: 0x0001969C File Offset: 0x0001789C
		// Note: this type is marked as 'beforefieldinit'.
		static NtlmClient()
		{
			Il2CppClassPointerStore<NtlmClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Http", "NtlmClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr);
			NtlmClient.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, "cache");
			NtlmClient.NativeMethodInfoPtr_Authenticate_Public_Virtual_Final_New_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, 100663680);
			NtlmClient.NativeMethodInfoPtr_PreAuthenticate_Public_Virtual_Final_New_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, 100663681);
			NtlmClient.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, 100663682);
			NtlmClient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, 100663683);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00019730 File Offset: 0x00017930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34410, XrefRangeEnd = 34454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmClient.NativeMethodInfoPtr_Authenticate_Public_Virtual_Final_New_Authorization_String_WebRequest_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000197A4 File Offset: 0x000179A4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmClient.NativeMethodInfoPtr_PreAuthenticate_Public_Virtual_Final_New_Authorization_WebRequest_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00019808 File Offset: 0x00017A08
		public unsafe virtual string AuthenticationType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34454, XrefRangeEnd = 34456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmClient.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00019840 File Offset: 0x00017A40
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NtlmClient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmClient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002E1D File Offset: 0x0000101D
		public NtlmClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0001987C File Offset: 0x00017A7C
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00002E26 File Offset: 0x00001026
		public unsafe static ConditionalWeakTable<HttpWebRequest, NtlmSession> cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NtlmClient.NativeFieldInfoPtr_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<HttpWebRequest, NtlmSession>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NtlmClient.NativeFieldInfoPtr_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Virtual_Final_New_Authorization_String_WebRequest_ICredentials_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_PreAuthenticate_Public_Virtual_Final_New_Authorization_WebRequest_ICredentials_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000188 RID: 392
		[ObfuscatedName("Mono.Http.NtlmClient+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001713 RID: 5907 RVA: 0x000645F4 File Offset: 0x000627F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NtlmClient.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NtlmClient.__c>.NativeClassPtr);
				NtlmClient.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NtlmClient.__c>.NativeClassPtr, "<>9");
				NtlmClient.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NtlmClient.__c>.NativeClassPtr, "<>9__1_0");
				NtlmClient.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient.__c>.NativeClassPtr, 100663686);
				NtlmClient.__c.NativeMethodInfoPtr__Authenticate_b__1_0_Internal_NtlmSession_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient.__c>.NativeClassPtr, 100663687);
			}

			// Token: 0x06001714 RID: 5908 RVA: 0x00064670 File Offset: 0x00062870
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NtlmClient.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmClient.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001715 RID: 5909 RVA: 0x000646AC File Offset: 0x000628AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34406, XrefRangeEnd = 34410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NtlmSession _Authenticate_b__1_0(HttpWebRequest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmClient.__c.NativeMethodInfoPtr__Authenticate_b__1_0_Internal_NtlmSession_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NtlmSession>(intPtr3) : null;
				}
			}

			// Token: 0x06001716 RID: 5910 RVA: 0x0000C2DF File Offset: 0x0000A4DF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000770 RID: 1904
			// (get) Token: 0x06001717 RID: 5911 RVA: 0x000646FC File Offset: 0x000628FC
			// (set) Token: 0x06001718 RID: 5912 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
			public unsafe static NtlmClient.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NtlmClient.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NtlmClient.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NtlmClient.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000771 RID: 1905
			// (get) Token: 0x06001719 RID: 5913 RVA: 0x00064724 File Offset: 0x00062924
			// (set) Token: 0x0600171A RID: 5914 RVA: 0x0000C2FA File Offset: 0x0000A4FA
			public unsafe static ConditionalWeakTable<HttpWebRequest, NtlmSession>.CreateValueCallback __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NtlmClient.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<HttpWebRequest, NtlmSession>.CreateValueCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NtlmClient.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400122E RID: 4654
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400122F RID: 4655
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001230 RID: 4656
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001231 RID: 4657
			private static readonly IntPtr NativeMethodInfoPtr__Authenticate_b__1_0_Internal_NtlmSession_HttpWebRequest_0;
		}
	}
}
