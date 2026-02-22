using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000052 RID: 82
	public class MouseCaptureEvent : MouseCaptureEventBase<MouseCaptureEvent>
	{
		// Token: 0x0600053B RID: 1339 RVA: 0x000047CC File Offset: 0x000029CC
		// Note: this type is marked as 'beforefieldinit'.
		static MouseCaptureEvent()
		{
			Il2CppClassPointerStore<MouseCaptureEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseCaptureEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseCaptureEvent>.NativeClassPtr);
			MouseCaptureEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureEvent>.NativeClassPtr, 100663697);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0001C0BC File Offset: 0x0001A2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93587, XrefRangeEnd = 93590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseCaptureEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseCaptureEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00004805 File Offset: 0x00002A05
		public MouseCaptureEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
