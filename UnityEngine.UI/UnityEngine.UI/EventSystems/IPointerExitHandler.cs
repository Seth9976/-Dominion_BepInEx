using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000054 RID: 84
	public class IPointerExitHandler : Il2CppObjectBase
	{
		// Token: 0x06000964 RID: 2404 RVA: 0x0000547B File Offset: 0x0000367B
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerExitHandler()
		{
			Il2CppClassPointerStore<IPointerExitHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerExitHandler");
			IPointerExitHandler.NativeMethodInfoPtr_OnPointerExit_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerExitHandler>.NativeClassPtr, 100664672);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0002B860 File Offset: 0x00029A60
		[CallerCount(0)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerExitHandler.NativeMethodInfoPtr_OnPointerExit_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000054AA File Offset: 0x000036AA
		public IPointerExitHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
