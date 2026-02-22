using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003C0 RID: 960
	public class IDynamicMessageSink : Il2CppObjectBase
	{
		// Token: 0x06003DEE RID: 15854 RVA: 0x00121F1C File Offset: 0x0012011C
		// Note: this type is marked as 'beforefieldinit'.
		static IDynamicMessageSink()
		{
			Il2CppClassPointerStore<IDynamicMessageSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IDynamicMessageSink");
			IDynamicMessageSink.NativeMethodInfoPtr_ProcessMessageFinish_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDynamicMessageSink>.NativeClassPtr, 100672406);
			IDynamicMessageSink.NativeMethodInfoPtr_ProcessMessageStart_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDynamicMessageSink>.NativeClassPtr, 100672407);
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x00121F6C File Offset: 0x0012016C
		[CallerCount(0)]
		public unsafe virtual void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replyMsg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCliSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDynamicMessageSink.NativeMethodInfoPtr_ProcessMessageFinish_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x00121FD8 File Offset: 0x001201D8
		[CallerCount(0)]
		public unsafe virtual void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reqMsg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCliSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDynamicMessageSink.NativeMethodInfoPtr_ProcessMessageStart_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x0001756E File Offset: 0x0001576E
		public IDynamicMessageSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003329 RID: 13097
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessageFinish_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0;

		// Token: 0x0400332A RID: 13098
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessageStart_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0;
	}
}
