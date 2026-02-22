using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004B RID: 75
	public class IVisualTreeUpdater : Il2CppObjectBase
	{
		// Token: 0x06000505 RID: 1285 RVA: 0x0001B8DC File Offset: 0x00019ADC
		// Note: this type is marked as 'beforefieldinit'.
		static IVisualTreeUpdater()
		{
			Il2CppClassPointerStore<IVisualTreeUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IVisualTreeUpdater");
			IVisualTreeUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Abstract_Virtual_New_get_ProfilerMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualTreeUpdater>.NativeClassPtr, 100663682);
			IVisualTreeUpdater.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualTreeUpdater>.NativeClassPtr, 100663683);
			IVisualTreeUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Abstract_Virtual_New_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualTreeUpdater>.NativeClassPtr, 100663684);
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0001B940 File Offset: 0x00019B40
		public unsafe virtual ProfilerMarker profilerMarker
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualTreeUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Abstract_Virtual_New_get_ProfilerMarker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0001B988 File Offset: 0x00019B88
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualTreeUpdater.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0001B9C4 File Offset: 0x00019BC4
		[CallerCount(0)]
		public unsafe virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref versionChangeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualTreeUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Abstract_Virtual_New_Void_VisualElement_VersionChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000045DF File Offset: 0x000027DF
		public IVisualTreeUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_get_profilerMarker_Public_Abstract_Virtual_New_get_ProfilerMarker_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Public_Abstract_Virtual_New_Void_VisualElement_VersionChangeType_0;
	}
}
