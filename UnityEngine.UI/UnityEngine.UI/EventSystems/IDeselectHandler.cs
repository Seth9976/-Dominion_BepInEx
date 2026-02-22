using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000060 RID: 96
	public class IDeselectHandler : Il2CppObjectBase
	{
		// Token: 0x06000988 RID: 2440 RVA: 0x0000571B File Offset: 0x0000391B
		// Note: this type is marked as 'beforefieldinit'.
		static IDeselectHandler()
		{
			Il2CppClassPointerStore<IDeselectHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IDeselectHandler");
			IDeselectHandler.NativeMethodInfoPtr_OnDeselect_Public_Abstract_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeselectHandler>.NativeClassPtr, 100664684);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0002BC20 File Offset: 0x00029E20
		[CallerCount(0)]
		public unsafe virtual void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDeselectHandler.NativeMethodInfoPtr_OnDeselect_Public_Abstract_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0000574A File Offset: 0x0000394A
		public IDeselectHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Abstract_Virtual_New_Void_BaseEventData_0;
	}
}
