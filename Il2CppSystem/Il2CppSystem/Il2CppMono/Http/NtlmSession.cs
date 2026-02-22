using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Protocol.Ntlm;
using Il2CppSystem;
using Il2CppSystem.Net;

namespace Il2CppMono.Http
{
	// Token: 0x0200002B RID: 43
	public class NtlmSession : Object
	{
		// Token: 0x0600024A RID: 586 RVA: 0x00019550 File Offset: 0x00017750
		// Note: this type is marked as 'beforefieldinit'.
		static NtlmSession()
		{
			Il2CppClassPointerStore<NtlmSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Http", "NtlmSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NtlmSession>.NativeClassPtr);
			NtlmSession.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NtlmSession>.NativeClassPtr, "message");
			NtlmSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmSession>.NativeClassPtr, 100663678);
			NtlmSession.NativeMethodInfoPtr_Authenticate_Public_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmSession>.NativeClassPtr, 100663679);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000195BC File Offset: 0x000177BC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NtlmSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NtlmSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000195F8 File Offset: 0x000177F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34405, RefRangeEnd = 34406, XrefRangeStart = 34359, XrefRangeEnd = 34405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmSession.NativeMethodInfoPtr_Authenticate_Public_Authorization_String_WebRequest_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002DF5 File Offset: 0x00000FF5
		public NtlmSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0001966C File Offset: 0x0001786C
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00002DFE File Offset: 0x00000FFE
		public unsafe MessageBase message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NtlmSession.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NtlmSession.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Authorization_String_WebRequest_ICredentials_0;
	}
}
