using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200005C RID: 92
	public class IDropHandler : Il2CppObjectBase
	{
		// Token: 0x0600097C RID: 2428 RVA: 0x0000563B File Offset: 0x0000383B
		// Note: this type is marked as 'beforefieldinit'.
		static IDropHandler()
		{
			Il2CppClassPointerStore<IDropHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IDropHandler");
			IDropHandler.NativeMethodInfoPtr_OnDrop_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDropHandler>.NativeClassPtr, 100664680);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0002BAE0 File Offset: 0x00029CE0
		[CallerCount(0)]
		public unsafe virtual void OnDrop(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDropHandler.NativeMethodInfoPtr_OnDrop_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0000566A File Offset: 0x0000386A
		public IDropHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_OnDrop_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
