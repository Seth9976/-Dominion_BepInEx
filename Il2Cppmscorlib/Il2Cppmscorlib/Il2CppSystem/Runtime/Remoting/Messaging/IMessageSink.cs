using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003F8 RID: 1016
	public class IMessageSink : Il2CppObjectBase
	{
		// Token: 0x06004012 RID: 16402 RVA: 0x00129530 File Offset: 0x00127730
		// Note: this type is marked as 'beforefieldinit'.
		static IMessageSink()
		{
			Il2CppClassPointerStore<IMessageSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "IMessageSink");
			IMessageSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Abstract_Virtual_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageSink>.NativeClassPtr, 100672650);
			IMessageSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Abstract_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageSink>.NativeClassPtr, 100672651);
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x00129580 File Offset: 0x00127780
		[CallerCount(0)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Abstract_Virtual_New_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x001295DC File Offset: 0x001277DC
		[CallerCount(0)]
		public unsafe virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Abstract_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x0001848F File Offset: 0x0001668F
		public IMessageSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400347A RID: 13434
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Abstract_Virtual_New_IMessage_IMessage_0;

		// Token: 0x0400347B RID: 13435
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Abstract_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0;
	}
}
