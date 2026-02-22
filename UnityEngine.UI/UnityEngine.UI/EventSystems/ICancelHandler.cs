using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000063 RID: 99
	public class ICancelHandler : Il2CppObjectBase
	{
		// Token: 0x06000991 RID: 2449 RVA: 0x000057C3 File Offset: 0x000039C3
		// Note: this type is marked as 'beforefieldinit'.
		static ICancelHandler()
		{
			Il2CppClassPointerStore<ICancelHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "ICancelHandler");
			ICancelHandler.NativeMethodInfoPtr_OnCancel_Public_Abstract_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICancelHandler>.NativeClassPtr, 100664687);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0002BD10 File Offset: 0x00029F10
		[CallerCount(0)]
		public unsafe virtual void OnCancel(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICancelHandler.NativeMethodInfoPtr_OnCancel_Public_Abstract_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x000057F2 File Offset: 0x000039F2
		public ICancelHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Abstract_Virtual_New_Void_BaseEventData_0;
	}
}
