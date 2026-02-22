using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004E RID: 78
	public class PointerCaptureOutEvent : PointerCaptureEventBase<PointerCaptureOutEvent>
	{
		// Token: 0x0600052C RID: 1324 RVA: 0x000046F5 File Offset: 0x000028F5
		// Note: this type is marked as 'beforefieldinit'.
		static PointerCaptureOutEvent()
		{
			Il2CppClassPointerStore<PointerCaptureOutEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerCaptureOutEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerCaptureOutEvent>.NativeClassPtr);
			PointerCaptureOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureOutEvent>.NativeClassPtr, 100663692);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0001BEE0 File Offset: 0x0001A0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93575, XrefRangeEnd = 93578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerCaptureOutEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerCaptureOutEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0000472E File Offset: 0x0000292E
		public PointerCaptureOutEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
