using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000061 RID: 97
	public class IMoveHandler : Il2CppObjectBase
	{
		// Token: 0x0600098B RID: 2443 RVA: 0x00005753 File Offset: 0x00003953
		// Note: this type is marked as 'beforefieldinit'.
		static IMoveHandler()
		{
			Il2CppClassPointerStore<IMoveHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IMoveHandler");
			IMoveHandler.NativeMethodInfoPtr_OnMove_Public_Abstract_Virtual_New_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMoveHandler>.NativeClassPtr, 100664685);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0002BC70 File Offset: 0x00029E70
		[CallerCount(0)]
		public unsafe virtual void OnMove(AxisEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMoveHandler.NativeMethodInfoPtr_OnMove_Public_Abstract_Virtual_New_Void_AxisEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00005782 File Offset: 0x00003982
		public IMoveHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_OnMove_Public_Abstract_Virtual_New_Void_AxisEventData_0;
	}
}
