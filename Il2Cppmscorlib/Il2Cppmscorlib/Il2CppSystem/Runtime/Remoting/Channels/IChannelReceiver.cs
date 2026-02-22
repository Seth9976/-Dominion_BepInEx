using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003CA RID: 970
	public class IChannelReceiver : Il2CppObjectBase
	{
		// Token: 0x06003E47 RID: 15943 RVA: 0x00123328 File Offset: 0x00121528
		// Note: this type is marked as 'beforefieldinit'.
		static IChannelReceiver()
		{
			Il2CppClassPointerStore<IChannelReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IChannelReceiver");
			IChannelReceiver.NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannelReceiver>.NativeClassPtr, 100672450);
			IChannelReceiver.NativeMethodInfoPtr_StartListening_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannelReceiver>.NativeClassPtr, 100672451);
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06003E48 RID: 15944 RVA: 0x00123378 File Offset: 0x00121578
		public unsafe virtual Object ChannelData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannelReceiver.NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x001233C4 File Offset: 0x001215C4
		[CallerCount(0)]
		public unsafe virtual void StartListening(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannelReceiver.NativeMethodInfoPtr_StartListening_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x00017754 File Offset: 0x00015954
		public IChannelReceiver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003360 RID: 13152
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04003361 RID: 13153
		private static readonly IntPtr NativeMethodInfoPtr_StartListening_Public_Abstract_Virtual_New_Void_Object_0;
	}
}
