using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x02000076 RID: 118
	public class IMouseEvent : Il2CppObjectBase
	{
		// Token: 0x060006B1 RID: 1713 RVA: 0x000218B8 File Offset: 0x0001FAB8
		// Note: this type is marked as 'beforefieldinit'.
		static IMouseEvent()
		{
			Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IMouseEvent");
			IMouseEvent.NativeMethodInfoPtr_get_modifiers_Public_Abstract_Virtual_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100663898);
			IMouseEvent.NativeMethodInfoPtr_get_mousePosition_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100663899);
			IMouseEvent.NativeMethodInfoPtr_get_mouseDelta_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100663900);
			IMouseEvent.NativeMethodInfoPtr_get_clickCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100663901);
			IMouseEvent.NativeMethodInfoPtr_get_button_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100663902);
			IMouseEvent.NativeMethodInfoPtr_get_pressedButtons_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100663903);
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00021958 File Offset: 0x0001FB58
		public unsafe virtual EventModifiers modifiers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_modifiers_Public_Abstract_Virtual_New_get_EventModifiers_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x000219A0 File Offset: 0x0001FBA0
		public unsafe virtual Vector2 mousePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_mousePosition_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x000219E8 File Offset: 0x0001FBE8
		public unsafe virtual Vector2 mouseDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_mouseDelta_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00021A30 File Offset: 0x0001FC30
		public unsafe virtual int clickCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_clickCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00021A78 File Offset: 0x0001FC78
		public unsafe virtual int button
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_button_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00021AC0 File Offset: 0x0001FCC0
		public unsafe virtual int pressedButtons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_pressedButtons_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00004F80 File Offset: 0x00003180
		public IMouseEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_Abstract_Virtual_New_get_EventModifiers_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseDelta_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_get_pressedButtons_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
