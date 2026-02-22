using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003CB RID: 971
	public class IChannelSender : Il2CppObjectBase
	{
		// Token: 0x06003E4B RID: 15947 RVA: 0x0001775D File Offset: 0x0001595D
		// Note: this type is marked as 'beforefieldinit'.
		static IChannelSender()
		{
			Il2CppClassPointerStore<IChannelSender>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IChannelSender");
			IChannelSender.NativeMethodInfoPtr_CreateMessageSink_Public_Abstract_Virtual_New_IMessageSink_String_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannelSender>.NativeClassPtr, 100672452);
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x00123414 File Offset: 0x00121614
		[CallerCount(0)]
		public unsafe virtual IMessageSink CreateMessageSink(string url, Object remoteChannelData, out string objectURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteChannelData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannelSender.NativeMethodInfoPtr_CreateMessageSink_Public_Abstract_Virtual_New_IMessageSink_String_Object_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			objectURI = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr4) : null;
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x0001778C File Offset: 0x0001598C
		public IChannelSender(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003362 RID: 13154
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessageSink_Public_Abstract_Virtual_New_IMessageSink_String_Object_byref_String_0;
	}
}
