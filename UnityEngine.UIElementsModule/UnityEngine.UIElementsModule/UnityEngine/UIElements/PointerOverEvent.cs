using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200009E RID: 158
	public sealed class PointerOverEvent : PointerEventBase<PointerOverEvent>
	{
		// Token: 0x06000865 RID: 2149 RVA: 0x000057BA File Offset: 0x000039BA
		// Note: this type is marked as 'beforefieldinit'.
		static PointerOverEvent()
		{
			Il2CppClassPointerStore<PointerOverEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerOverEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerOverEvent>.NativeClassPtr);
			PointerOverEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOverEvent>.NativeClassPtr, 100664124);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00027D38 File Offset: 0x00025F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96496, XrefRangeEnd = 96499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerOverEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerOverEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOverEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x000057F3 File Offset: 0x000039F3
		public PointerOverEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
