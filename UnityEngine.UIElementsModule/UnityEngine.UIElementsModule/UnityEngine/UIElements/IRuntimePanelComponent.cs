using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x02000023 RID: 35
	public class IRuntimePanelComponent : Il2CppObjectBase
	{
		// Token: 0x06000268 RID: 616 RVA: 0x00003398 File Offset: 0x00001598
		// Note: this type is marked as 'beforefieldinit'.
		static IRuntimePanelComponent()
		{
			Il2CppClassPointerStore<IRuntimePanelComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IRuntimePanelComponent");
			IRuntimePanelComponent.NativeMethodInfoPtr_set_panel_Public_Abstract_Virtual_New_set_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRuntimePanelComponent>.NativeClassPtr, 100663486);
		}

		// Token: 0x170000CD RID: 205
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00013A44 File Offset: 0x00011C44
		public unsafe virtual IPanel panel
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRuntimePanelComponent.NativeMethodInfoPtr_set_panel_Public_Abstract_Virtual_New_set_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000033C7 File Offset: 0x000015C7
		public IRuntimePanelComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_set_panel_Public_Abstract_Virtual_New_set_Void_IPanel_0;
	}
}
