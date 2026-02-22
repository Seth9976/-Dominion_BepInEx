using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000055 RID: 85
	public class IPointerDownHandler : Il2CppObjectBase
	{
		// Token: 0x06000967 RID: 2407 RVA: 0x000054B3 File Offset: 0x000036B3
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerDownHandler()
		{
			Il2CppClassPointerStore<IPointerDownHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerDownHandler");
			IPointerDownHandler.NativeMethodInfoPtr_OnPointerDown_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerDownHandler>.NativeClassPtr, 100664673);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0002B8B0 File Offset: 0x00029AB0
		[CallerCount(0)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerDownHandler.NativeMethodInfoPtr_OnPointerDown_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000054E2 File Offset: 0x000036E2
		public IPointerDownHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
