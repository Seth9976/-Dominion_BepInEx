using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000059 RID: 89
	public class IInitializePotentialDragHandler : Il2CppObjectBase
	{
		// Token: 0x06000973 RID: 2419 RVA: 0x00005593 File Offset: 0x00003793
		// Note: this type is marked as 'beforefieldinit'.
		static IInitializePotentialDragHandler()
		{
			Il2CppClassPointerStore<IInitializePotentialDragHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IInitializePotentialDragHandler");
			IInitializePotentialDragHandler.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInitializePotentialDragHandler>.NativeClassPtr, 100664677);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0002B9F0 File Offset: 0x00029BF0
		[CallerCount(0)]
		public unsafe virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInitializePotentialDragHandler.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000055C2 File Offset: 0x000037C2
		public IInitializePotentialDragHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
