using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000C7 RID: 199
	public class ICredentials : Il2CppObjectBase
	{
		// Token: 0x06000B87 RID: 2951 RVA: 0x00006832 File Offset: 0x00004A32
		// Note: this type is marked as 'beforefieldinit'.
		static ICredentials()
		{
			Il2CppClassPointerStore<ICredentials>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ICredentials");
			ICredentials.NativeMethodInfoPtr_GetCredential_Public_Abstract_Virtual_New_NetworkCredential_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICredentials>.NativeClassPtr, 100664941);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0003C084 File Offset: 0x0003A284
		[CallerCount(0)]
		public unsafe virtual NetworkCredential GetCredential(Uri uri, string authType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(authType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICredentials.NativeMethodInfoPtr_GetCredential_Public_Abstract_Virtual_New_NetworkCredential_Uri_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr3) : null;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00006861 File Offset: 0x00004A61
		public ICredentials(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_GetCredential_Public_Abstract_Virtual_New_NetworkCredential_Uri_String_0;
	}
}
