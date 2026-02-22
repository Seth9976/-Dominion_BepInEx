using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200005A RID: 90
	public class IDragHandler : Il2CppObjectBase
	{
		// Token: 0x06000976 RID: 2422 RVA: 0x000055CB File Offset: 0x000037CB
		// Note: this type is marked as 'beforefieldinit'.
		static IDragHandler()
		{
			Il2CppClassPointerStore<IDragHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IDragHandler");
			IDragHandler.NativeMethodInfoPtr_OnDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragHandler>.NativeClassPtr, 100664678);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0002BA40 File Offset: 0x00029C40
		[CallerCount(0)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragHandler.NativeMethodInfoPtr_OnDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000055FA File Offset: 0x000037FA
		public IDragHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
