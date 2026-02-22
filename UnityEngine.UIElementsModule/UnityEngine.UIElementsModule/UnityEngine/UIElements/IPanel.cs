using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001B RID: 27
	public class IPanel : Il2CppObjectBase
	{
		// Token: 0x06000148 RID: 328 RVA: 0x00010A60 File Offset: 0x0000EC60
		// Note: this type is marked as 'beforefieldinit'.
		static IPanel()
		{
			Il2CppClassPointerStore<IPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IPanel");
			IPanel.NativeMethodInfoPtr_get_visualTree_Public_Abstract_Virtual_New_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPanel>.NativeClassPtr, 100663405);
			IPanel.NativeMethodInfoPtr_get_dispatcher_Public_Abstract_Virtual_New_get_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPanel>.NativeClassPtr, 100663406);
			IPanel.NativeMethodInfoPtr_get_contextType_Public_Abstract_Virtual_New_get_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPanel>.NativeClassPtr, 100663407);
			IPanel.NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPanel>.NativeClassPtr, 100663408);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		public unsafe virtual VisualElement visualTree
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPanel.NativeMethodInfoPtr_get_visualTree_Public_Abstract_Virtual_New_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00010B24 File Offset: 0x0000ED24
		public unsafe virtual EventDispatcher dispatcher
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPanel.NativeMethodInfoPtr_get_dispatcher_Public_Abstract_Virtual_New_get_EventDispatcher_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr3) : null;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00010B70 File Offset: 0x0000ED70
		public unsafe virtual ContextType contextType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPanel.NativeMethodInfoPtr_get_contextType_Public_Abstract_Virtual_New_get_ContextType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00010BB8 File Offset: 0x0000EDB8
		public unsafe virtual FocusController focusController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPanel.NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr3) : null;
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002A50 File Offset: 0x00000C50
		public IPanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_get_visualTree_Public_Abstract_Virtual_New_get_VisualElement_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_get_dispatcher_Public_Abstract_Virtual_New_get_EventDispatcher_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_get_contextType_Public_Abstract_Virtual_New_get_ContextType_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0;
	}
}
