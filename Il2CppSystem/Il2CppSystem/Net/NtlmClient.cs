using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000112 RID: 274
	public class NtlmClient : Object
	{
		// Token: 0x06001155 RID: 4437 RVA: 0x000514A8 File Offset: 0x0004F6A8
		// Note: this type is marked as 'beforefieldinit'.
		static NtlmClient()
		{
			Il2CppClassPointerStore<NtlmClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "NtlmClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr);
			NtlmClient.NativeFieldInfoPtr_authObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, "authObject");
			NtlmClient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, 100665690);
			NtlmClient.NativeMethodInfoPtr_Authenticate_Public_Virtual_Final_New_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, 100665691);
			NtlmClient.NativeMethodInfoPtr_PreAuthenticate_Public_Virtual_Final_New_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, 100665692);
			NtlmClient.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, 100665693);
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x0005153C File Offset: 0x0004F73C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52824, RefRangeEnd = 52825, XrefRangeStart = 52819, XrefRangeEnd = 52824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NtlmClient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmClient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00051578 File Offset: 0x0004F778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52825, XrefRangeEnd = 52830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06001158 RID: 4440 RVA: 0x000515EC File Offset: 0x0004F7EC
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

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x00051650 File Offset: 0x0004F850
		public unsafe virtual string AuthenticationType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52830, XrefRangeEnd = 52832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600115A RID: 4442 RVA: 0x00009064 File Offset: 0x00007264
		public NtlmClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x00051688 File Offset: 0x0004F888
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x0000906D File Offset: 0x0000726D
		public unsafe IAuthenticationModule authObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NtlmClient.NativeFieldInfoPtr_authObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAuthenticationModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NtlmClient.NativeFieldInfoPtr_authObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeFieldInfoPtr_authObject;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Virtual_Final_New_Authorization_String_WebRequest_ICredentials_0;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeMethodInfoPtr_PreAuthenticate_Public_Virtual_Final_New_Authorization_WebRequest_ICredentials_0;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_New_get_String_0;
	}
}
