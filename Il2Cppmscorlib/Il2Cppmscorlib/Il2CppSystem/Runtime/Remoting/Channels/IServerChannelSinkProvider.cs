using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003CE RID: 974
	public class IServerChannelSinkProvider : Il2CppObjectBase
	{
		// Token: 0x06003E54 RID: 15956 RVA: 0x00017805 File Offset: 0x00015A05
		// Note: this type is marked as 'beforefieldinit'.
		static IServerChannelSinkProvider()
		{
			Il2CppClassPointerStore<IServerChannelSinkProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IServerChannelSinkProvider");
			IServerChannelSinkProvider.NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IServerChannelSinkProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IServerChannelSinkProvider>.NativeClassPtr, 100672455);
		}

		// Token: 0x17000FA1 RID: 4001
		// (set) Token: 0x06003E55 RID: 15957 RVA: 0x00123538 File Offset: 0x00121738
		public unsafe virtual IServerChannelSinkProvider Next
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IServerChannelSinkProvider.NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IServerChannelSinkProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x00017834 File Offset: 0x00015A34
		public IServerChannelSinkProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003365 RID: 13157
		private static readonly IntPtr NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IServerChannelSinkProvider_0;
	}
}
