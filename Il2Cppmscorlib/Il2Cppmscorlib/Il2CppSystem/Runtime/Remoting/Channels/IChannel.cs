using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003C8 RID: 968
	public class IChannel : Il2CppObjectBase
	{
		// Token: 0x06003E41 RID: 15937 RVA: 0x0012324C File Offset: 0x0012144C
		// Note: this type is marked as 'beforefieldinit'.
		static IChannel()
		{
			Il2CppClassPointerStore<IChannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IChannel");
			IChannel.NativeMethodInfoPtr_get_ChannelName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannel>.NativeClassPtr, 100672448);
			IChannel.NativeMethodInfoPtr_get_ChannelPriority_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannel>.NativeClassPtr, 100672449);
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06003E42 RID: 15938 RVA: 0x0012329C File Offset: 0x0012149C
		public unsafe virtual string ChannelName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannel.NativeMethodInfoPtr_get_ChannelName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06003E43 RID: 15939 RVA: 0x001232E0 File Offset: 0x001214E0
		public unsafe virtual int ChannelPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannel.NativeMethodInfoPtr_get_ChannelPriority_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x00017727 File Offset: 0x00015927
		public IChannel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400335E RID: 13150
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400335F RID: 13151
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelPriority_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
