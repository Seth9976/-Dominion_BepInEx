using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x02000064 RID: 100
	public class IEventHandler : Il2CppObjectBase
	{
		// Token: 0x06000634 RID: 1588 RVA: 0x0001FBE4 File Offset: 0x0001DDE4
		// Note: this type is marked as 'beforefieldinit'.
		static IEventHandler()
		{
			Il2CppClassPointerStore<IEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IEventHandler");
			IEventHandler.NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventHandler>.NativeClassPtr, 100663834);
			IEventHandler.NativeMethodInfoPtr_HandleEvent_Public_Abstract_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventHandler>.NativeClassPtr, 100663835);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0001FC34 File Offset: 0x0001DE34
		[CallerCount(0)]
		public unsafe virtual void SendEvent(EventBase e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEventHandler.NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0001FC84 File Offset: 0x0001DE84
		[CallerCount(0)]
		public unsafe virtual void HandleEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEventHandler.NativeMethodInfoPtr_HandleEvent_Public_Abstract_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00004D4A File Offset: 0x00002F4A
		public IEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_EventBase_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_HandleEvent_Public_Abstract_Virtual_New_Void_EventBase_0;
	}
}
