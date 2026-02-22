using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200005F RID: 95
	public class ISelectHandler : Il2CppObjectBase
	{
		// Token: 0x06000985 RID: 2437 RVA: 0x000056E3 File Offset: 0x000038E3
		// Note: this type is marked as 'beforefieldinit'.
		static ISelectHandler()
		{
			Il2CppClassPointerStore<ISelectHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "ISelectHandler");
			ISelectHandler.NativeMethodInfoPtr_OnSelect_Public_Abstract_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectHandler>.NativeClassPtr, 100664683);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0002BBD0 File Offset: 0x00029DD0
		[CallerCount(0)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectHandler.NativeMethodInfoPtr_OnSelect_Public_Abstract_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00005712 File Offset: 0x00003912
		public ISelectHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Abstract_Virtual_New_Void_BaseEventData_0;
	}
}
