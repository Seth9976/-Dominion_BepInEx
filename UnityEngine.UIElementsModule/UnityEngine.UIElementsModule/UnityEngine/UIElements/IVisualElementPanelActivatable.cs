using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000046 RID: 70
	public class IVisualElementPanelActivatable : Il2CppObjectBase
	{
		// Token: 0x060004DF RID: 1247 RVA: 0x0001B0AC File Offset: 0x000192AC
		// Note: this type is marked as 'beforefieldinit'.
		static IVisualElementPanelActivatable()
		{
			Il2CppClassPointerStore<IVisualElementPanelActivatable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IVisualElementPanelActivatable");
			IVisualElementPanelActivatable.NativeMethodInfoPtr_get_element_Public_Abstract_Virtual_New_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementPanelActivatable>.NativeClassPtr, 100663664);
			IVisualElementPanelActivatable.NativeMethodInfoPtr_CanBeActivated_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementPanelActivatable>.NativeClassPtr, 100663665);
			IVisualElementPanelActivatable.NativeMethodInfoPtr_OnPanelActivate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementPanelActivatable>.NativeClassPtr, 100663666);
			IVisualElementPanelActivatable.NativeMethodInfoPtr_OnPanelDeactivate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementPanelActivatable>.NativeClassPtr, 100663667);
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0001B124 File Offset: 0x00019324
		public unsafe virtual VisualElement element
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementPanelActivatable.NativeMethodInfoPtr_get_element_Public_Abstract_Virtual_New_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0001B170 File Offset: 0x00019370
		[CallerCount(0)]
		public unsafe virtual bool CanBeActivated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementPanelActivatable.NativeMethodInfoPtr_CanBeActivated_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0001B1B8 File Offset: 0x000193B8
		[CallerCount(0)]
		public unsafe virtual void OnPanelActivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementPanelActivatable.NativeMethodInfoPtr_OnPanelActivate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0001B1F4 File Offset: 0x000193F4
		[CallerCount(0)]
		public unsafe virtual void OnPanelDeactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementPanelActivatable.NativeMethodInfoPtr_OnPanelDeactivate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000044C0 File Offset: 0x000026C0
		public IVisualElementPanelActivatable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_get_element_Public_Abstract_Virtual_New_get_VisualElement_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_CanBeActivated_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelActivate_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDeactivate_Public_Abstract_Virtual_New_Void_0;
	}
}
