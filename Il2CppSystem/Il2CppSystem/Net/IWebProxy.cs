using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000F7 RID: 247
	public class IWebProxy : Il2CppObjectBase
	{
		// Token: 0x06000EA2 RID: 3746 RVA: 0x0004750C File Offset: 0x0004570C
		// Note: this type is marked as 'beforefieldinit'.
		static IWebProxy()
		{
			Il2CppClassPointerStore<IWebProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IWebProxy");
			IWebProxy.NativeMethodInfoPtr_GetProxy_Public_Abstract_Virtual_New_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebProxy>.NativeClassPtr, 100665339);
			IWebProxy.NativeMethodInfoPtr_IsBypassed_Public_Abstract_Virtual_New_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebProxy>.NativeClassPtr, 100665340);
			IWebProxy.NativeMethodInfoPtr_get_Credentials_Public_Abstract_Virtual_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebProxy>.NativeClassPtr, 100665341);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00047570 File Offset: 0x00045770
		[CallerCount(0)]
		public unsafe virtual Uri GetProxy(Uri destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWebProxy.NativeMethodInfoPtr_GetProxy_Public_Abstract_Virtual_New_Uri_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x000475CC File Offset: 0x000457CC
		[CallerCount(0)]
		public unsafe virtual bool IsBypassed(Uri host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWebProxy.NativeMethodInfoPtr_IsBypassed_Public_Abstract_Virtual_New_Boolean_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x00047624 File Offset: 0x00045824
		public unsafe virtual ICredentials Credentials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWebProxy.NativeMethodInfoPtr_get_Credentials_Public_Abstract_Virtual_New_get_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00007C58 File Offset: 0x00005E58
		public IWebProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_GetProxy_Public_Abstract_Virtual_New_Uri_Uri_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_IsBypassed_Public_Abstract_Virtual_New_Boolean_Uri_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Abstract_Virtual_New_get_ICredentials_0;
	}
}
