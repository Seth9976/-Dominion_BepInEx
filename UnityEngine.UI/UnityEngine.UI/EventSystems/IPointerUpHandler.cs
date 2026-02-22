using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000056 RID: 86
	public class IPointerUpHandler : Il2CppObjectBase
	{
		// Token: 0x0600096A RID: 2410 RVA: 0x000054EB File Offset: 0x000036EB
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerUpHandler()
		{
			Il2CppClassPointerStore<IPointerUpHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerUpHandler");
			IPointerUpHandler.NativeMethodInfoPtr_OnPointerUp_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerUpHandler>.NativeClassPtr, 100664674);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0002B900 File Offset: 0x00029B00
		[CallerCount(0)]
		public unsafe virtual void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerUpHandler.NativeMethodInfoPtr_OnPointerUp_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0000551A File Offset: 0x0000371A
		public IPointerUpHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
