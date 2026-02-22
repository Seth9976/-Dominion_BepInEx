using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200008D RID: 141
	public class DetachFromPanelEvent : PanelChangedEventBase<DetachFromPanelEvent>
	{
		// Token: 0x06000778 RID: 1912 RVA: 0x00005399 File Offset: 0x00003599
		// Note: this type is marked as 'beforefieldinit'.
		static DetachFromPanelEvent()
		{
			Il2CppClassPointerStore<DetachFromPanelEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DetachFromPanelEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetachFromPanelEvent>.NativeClassPtr);
			DetachFromPanelEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetachFromPanelEvent>.NativeClassPtr, 100664001);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00024508 File Offset: 0x00022708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95763, XrefRangeEnd = 95766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DetachFromPanelEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetachFromPanelEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetachFromPanelEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000053D2 File Offset: 0x000035D2
		public DetachFromPanelEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
