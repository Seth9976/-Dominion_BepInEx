using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000052 RID: 82
	public class IPointerMoveHandler : Il2CppObjectBase
	{
		// Token: 0x0600095E RID: 2398 RVA: 0x0000540B File Offset: 0x0000360B
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerMoveHandler()
		{
			Il2CppClassPointerStore<IPointerMoveHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerMoveHandler");
			IPointerMoveHandler.NativeMethodInfoPtr_OnPointerMove_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerMoveHandler>.NativeClassPtr, 100664670);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0002B7C0 File Offset: 0x000299C0
		[CallerCount(0)]
		public unsafe virtual void OnPointerMove(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerMoveHandler.NativeMethodInfoPtr_OnPointerMove_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0000543A File Offset: 0x0000363A
		public IPointerMoveHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerMove_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
