using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004F RID: 79
	public class PointerCaptureEvent : PointerCaptureEventBase<PointerCaptureEvent>
	{
		// Token: 0x0600052F RID: 1327 RVA: 0x00004737 File Offset: 0x00002937
		// Note: this type is marked as 'beforefieldinit'.
		static PointerCaptureEvent()
		{
			Il2CppClassPointerStore<PointerCaptureEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerCaptureEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerCaptureEvent>.NativeClassPtr);
			PointerCaptureEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEvent>.NativeClassPtr, 100663693);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0001BF1C File Offset: 0x0001A11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93578, XrefRangeEnd = 93581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerCaptureEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerCaptureEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00004770 File Offset: 0x00002970
		public PointerCaptureEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
