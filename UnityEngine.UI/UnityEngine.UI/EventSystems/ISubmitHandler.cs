using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000062 RID: 98
	public class ISubmitHandler : Il2CppObjectBase
	{
		// Token: 0x0600098E RID: 2446 RVA: 0x0000578B File Offset: 0x0000398B
		// Note: this type is marked as 'beforefieldinit'.
		static ISubmitHandler()
		{
			Il2CppClassPointerStore<ISubmitHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "ISubmitHandler");
			ISubmitHandler.NativeMethodInfoPtr_OnSubmit_Public_Abstract_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISubmitHandler>.NativeClassPtr, 100664686);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0002BCC0 File Offset: 0x00029EC0
		[CallerCount(0)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISubmitHandler.NativeMethodInfoPtr_OnSubmit_Public_Abstract_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x000057BA File Offset: 0x000039BA
		public ISubmitHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Abstract_Virtual_New_Void_BaseEventData_0;
	}
}
