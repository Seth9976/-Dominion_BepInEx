using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000C5 RID: 197
	public class IAuthenticationModule : Il2CppObjectBase
	{
		// Token: 0x06000B7F RID: 2943 RVA: 0x0003BE60 File Offset: 0x0003A060
		// Note: this type is marked as 'beforefieldinit'.
		static IAuthenticationModule()
		{
			Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IAuthenticationModule");
			IAuthenticationModule.NativeMethodInfoPtr_Authenticate_Public_Abstract_Virtual_New_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr, 100664937);
			IAuthenticationModule.NativeMethodInfoPtr_PreAuthenticate_Public_Abstract_Virtual_New_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr, 100664938);
			IAuthenticationModule.NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr, 100664939);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0003BEC4 File Offset: 0x0003A0C4
		[CallerCount(0)]
		public unsafe virtual Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthenticationModule.NativeMethodInfoPtr_Authenticate_Public_Abstract_Virtual_New_Authorization_String_WebRequest_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0003BF44 File Offset: 0x0003A144
		[CallerCount(0)]
		public unsafe virtual Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthenticationModule.NativeMethodInfoPtr_PreAuthenticate_Public_Abstract_Virtual_New_Authorization_WebRequest_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0003BFB4 File Offset: 0x0003A1B4
		public unsafe virtual string AuthenticationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAuthenticationModule.NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x000067F1 File Offset: 0x000049F1
		public IAuthenticationModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Abstract_Virtual_New_Authorization_String_WebRequest_ICredentials_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_PreAuthenticate_Public_Abstract_Virtual_New_Authorization_WebRequest_ICredentials_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0;
	}
}
