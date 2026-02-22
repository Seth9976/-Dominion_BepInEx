using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200005E RID: 94
	public class IUpdateSelectedHandler : Il2CppObjectBase
	{
		// Token: 0x06000982 RID: 2434 RVA: 0x000056AB File Offset: 0x000038AB
		// Note: this type is marked as 'beforefieldinit'.
		static IUpdateSelectedHandler()
		{
			Il2CppClassPointerStore<IUpdateSelectedHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IUpdateSelectedHandler");
			IUpdateSelectedHandler.NativeMethodInfoPtr_OnUpdateSelected_Public_Abstract_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUpdateSelectedHandler>.NativeClassPtr, 100664682);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0002BB80 File Offset: 0x00029D80
		[CallerCount(0)]
		public unsafe virtual void OnUpdateSelected(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUpdateSelectedHandler.NativeMethodInfoPtr_OnUpdateSelected_Public_Abstract_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x000056DA File Offset: 0x000038DA
		public IUpdateSelectedHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateSelected_Public_Abstract_Virtual_New_Void_BaseEventData_0;
	}
}
