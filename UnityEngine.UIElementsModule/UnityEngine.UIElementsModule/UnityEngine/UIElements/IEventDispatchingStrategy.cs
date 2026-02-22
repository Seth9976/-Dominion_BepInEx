using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x0200006C RID: 108
	public class IEventDispatchingStrategy : Il2CppObjectBase
	{
		// Token: 0x0600066D RID: 1645 RVA: 0x00020988 File Offset: 0x0001EB88
		// Note: this type is marked as 'beforefieldinit'.
		static IEventDispatchingStrategy()
		{
			Il2CppClassPointerStore<IEventDispatchingStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IEventDispatchingStrategy");
			IEventDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Abstract_Virtual_New_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventDispatchingStrategy>.NativeClassPtr, 100663865);
			IEventDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Abstract_Virtual_New_Void_EventBase_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventDispatchingStrategy>.NativeClassPtr, 100663866);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000209D8 File Offset: 0x0001EBD8
		[CallerCount(0)]
		public unsafe virtual bool CanDispatchEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEventDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Abstract_Virtual_New_Boolean_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00020A30 File Offset: 0x0001EC30
		[CallerCount(0)]
		public unsafe virtual void DispatchEvent(EventBase evt, IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEventDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Abstract_Virtual_New_Void_EventBase_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00004E30 File Offset: 0x00003030
		public IEventDispatchingStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_CanDispatchEvent_Public_Abstract_Virtual_New_Boolean_EventBase_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvent_Public_Abstract_Virtual_New_Void_EventBase_IPanel_0;
	}
}
