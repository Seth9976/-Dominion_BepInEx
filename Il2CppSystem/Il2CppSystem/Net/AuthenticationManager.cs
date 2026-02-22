using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net
{
	// Token: 0x020000FD RID: 253
	public class AuthenticationManager : Object
	{
		// Token: 0x06000EE5 RID: 3813 RVA: 0x0004852C File Offset: 0x0004672C
		// Note: this type is marked as 'beforefieldinit'.
		static AuthenticationManager()
		{
			Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "AuthenticationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr);
			AuthenticationManager.NativeFieldInfoPtr_modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, "modules");
			AuthenticationManager.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, "locker");
			AuthenticationManager.NativeFieldInfoPtr_credential_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, "credential_policy");
			AuthenticationManager.NativeMethodInfoPtr_EnsureModules_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100665376);
			AuthenticationManager.NativeMethodInfoPtr_Authenticate_Public_Static_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100665377);
			AuthenticationManager.NativeMethodInfoPtr_DoAuthenticate_Private_Static_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100665378);
			AuthenticationManager.NativeMethodInfoPtr_PreAuthenticate_Public_Static_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100665379);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x000485E8 File Offset: 0x000467E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49591, RefRangeEnd = 49593, XrefRangeStart = 49558, XrefRangeEnd = 49591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureModules()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationManager.NativeMethodInfoPtr_EnsureModules_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00048610 File Offset: 0x00046810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49615, RefRangeEnd = 49617, XrefRangeStart = 49593, XrefRangeEnd = 49615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationManager.NativeMethodInfoPtr_Authenticate_Public_Static_Authorization_String_WebRequest_ICredentials_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00048678 File Offset: 0x00046878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49651, RefRangeEnd = 49652, XrefRangeStart = 49617, XrefRangeEnd = 49651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationManager.NativeMethodInfoPtr_DoAuthenticate_Private_Static_Authorization_String_WebRequest_ICredentials_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x000486E0 File Offset: 0x000468E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49685, RefRangeEnd = 49686, XrefRangeStart = 49652, XrefRangeEnd = 49685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationManager.NativeMethodInfoPtr_PreAuthenticate_Public_Static_Authorization_WebRequest_ICredentials_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00007E43 File Offset: 0x00006043
		public AuthenticationManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x00048738 File Offset: 0x00046938
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x00007E4C File Offset: 0x0000604C
		public unsafe static ArrayList modules
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AuthenticationManager.NativeFieldInfoPtr_modules, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AuthenticationManager.NativeFieldInfoPtr_modules, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x00048760 File Offset: 0x00046960
		// (set) Token: 0x06000EEE RID: 3822 RVA: 0x00007E5E File Offset: 0x0000605E
		public unsafe static Object locker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AuthenticationManager.NativeFieldInfoPtr_locker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AuthenticationManager.NativeFieldInfoPtr_locker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00048788 File Offset: 0x00046988
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x00007E70 File Offset: 0x00006070
		public unsafe static ICredentialPolicy credential_policy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AuthenticationManager.NativeFieldInfoPtr_credential_policy, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentialPolicy>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AuthenticationManager.NativeFieldInfoPtr_credential_policy, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeFieldInfoPtr_modules;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeFieldInfoPtr_credential_policy;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr_EnsureModules_Private_Static_Void_0;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Static_Authorization_String_WebRequest_ICredentials_0;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr_DoAuthenticate_Private_Static_Authorization_String_WebRequest_ICredentials_0;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr_PreAuthenticate_Public_Static_Authorization_WebRequest_ICredentials_0;
	}
}
