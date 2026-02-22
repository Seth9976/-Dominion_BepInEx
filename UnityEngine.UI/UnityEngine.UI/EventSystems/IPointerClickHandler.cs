using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000057 RID: 87
	public class IPointerClickHandler : Il2CppObjectBase
	{
		// Token: 0x0600096D RID: 2413 RVA: 0x00005523 File Offset: 0x00003723
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerClickHandler()
		{
			Il2CppClassPointerStore<IPointerClickHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerClickHandler");
			IPointerClickHandler.NativeMethodInfoPtr_OnPointerClick_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerClickHandler>.NativeClassPtr, 100664675);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0002B950 File Offset: 0x00029B50
		[CallerCount(0)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerClickHandler.NativeMethodInfoPtr_OnPointerClick_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00005552 File Offset: 0x00003752
		public IPointerClickHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
