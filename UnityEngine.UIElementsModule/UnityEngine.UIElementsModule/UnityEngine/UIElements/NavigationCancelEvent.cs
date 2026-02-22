using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000089 RID: 137
	public class NavigationCancelEvent : NavigationEventBase<NavigationCancelEvent>
	{
		// Token: 0x06000761 RID: 1889 RVA: 0x0000527C File Offset: 0x0000347C
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationCancelEvent()
		{
			Il2CppClassPointerStore<NavigationCancelEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "NavigationCancelEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationCancelEvent>.NativeClassPtr);
			NavigationCancelEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationCancelEvent>.NativeClassPtr, 100663993);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00024194 File Offset: 0x00022394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95746, XrefRangeEnd = 95749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationCancelEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationCancelEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationCancelEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x000052B5 File Offset: 0x000034B5
		public NavigationCancelEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
