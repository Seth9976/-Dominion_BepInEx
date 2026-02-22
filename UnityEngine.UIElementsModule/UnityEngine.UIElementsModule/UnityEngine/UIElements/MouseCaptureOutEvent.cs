using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000051 RID: 81
	public class MouseCaptureOutEvent : MouseCaptureEventBase<MouseCaptureOutEvent>
	{
		// Token: 0x06000538 RID: 1336 RVA: 0x0000478A File Offset: 0x0000298A
		// Note: this type is marked as 'beforefieldinit'.
		static MouseCaptureOutEvent()
		{
			Il2CppClassPointerStore<MouseCaptureOutEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseCaptureOutEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseCaptureOutEvent>.NativeClassPtr);
			MouseCaptureOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureOutEvent>.NativeClassPtr, 100663696);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0001C080 File Offset: 0x0001A280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93584, XrefRangeEnd = 93587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseCaptureOutEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseCaptureOutEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000047C3 File Offset: 0x000029C3
		public MouseCaptureOutEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
