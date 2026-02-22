using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200008A RID: 138
	public class NavigationSubmitEvent : NavigationEventBase<NavigationSubmitEvent>
	{
		// Token: 0x06000764 RID: 1892 RVA: 0x000052BE File Offset: 0x000034BE
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationSubmitEvent()
		{
			Il2CppClassPointerStore<NavigationSubmitEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "NavigationSubmitEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationSubmitEvent>.NativeClassPtr);
			NavigationSubmitEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationSubmitEvent>.NativeClassPtr, 100663994);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000241D0 File Offset: 0x000223D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95749, XrefRangeEnd = 95752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationSubmitEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationSubmitEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationSubmitEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000052F7 File Offset: 0x000034F7
		public NavigationSubmitEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
