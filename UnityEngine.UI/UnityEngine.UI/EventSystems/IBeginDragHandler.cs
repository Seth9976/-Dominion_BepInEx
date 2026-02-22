using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000058 RID: 88
	public class IBeginDragHandler : Il2CppObjectBase
	{
		// Token: 0x06000970 RID: 2416 RVA: 0x0000555B File Offset: 0x0000375B
		// Note: this type is marked as 'beforefieldinit'.
		static IBeginDragHandler()
		{
			Il2CppClassPointerStore<IBeginDragHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IBeginDragHandler");
			IBeginDragHandler.NativeMethodInfoPtr_OnBeginDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBeginDragHandler>.NativeClassPtr, 100664676);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0002B9A0 File Offset: 0x00029BA0
		[CallerCount(0)]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBeginDragHandler.NativeMethodInfoPtr_OnBeginDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0000558A File Offset: 0x0000378A
		public IBeginDragHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
