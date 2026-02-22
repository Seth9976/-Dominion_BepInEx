using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200008C RID: 140
	public class AttachToPanelEvent : PanelChangedEventBase<AttachToPanelEvent>
	{
		// Token: 0x06000775 RID: 1909 RVA: 0x00005357 File Offset: 0x00003557
		// Note: this type is marked as 'beforefieldinit'.
		static AttachToPanelEvent()
		{
			Il2CppClassPointerStore<AttachToPanelEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "AttachToPanelEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachToPanelEvent>.NativeClassPtr);
			AttachToPanelEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachToPanelEvent>.NativeClassPtr, 100664000);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000244CC File Offset: 0x000226CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95760, XrefRangeEnd = 95763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttachToPanelEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttachToPanelEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachToPanelEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00005390 File Offset: 0x00003590
		public AttachToPanelEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
