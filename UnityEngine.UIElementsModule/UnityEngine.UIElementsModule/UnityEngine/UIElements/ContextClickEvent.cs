using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200007C RID: 124
	public class ContextClickEvent : MouseEventBase<ContextClickEvent>
	{
		// Token: 0x06000711 RID: 1809 RVA: 0x000050D0 File Offset: 0x000032D0
		// Note: this type is marked as 'beforefieldinit'.
		static ContextClickEvent()
		{
			Il2CppClassPointerStore<ContextClickEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ContextClickEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextClickEvent>.NativeClassPtr);
			ContextClickEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextClickEvent>.NativeClassPtr, 100663951);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0002307C File Offset: 0x0002127C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95466, XrefRangeEnd = 95469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextClickEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextClickEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextClickEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00005109 File Offset: 0x00003309
		public ContextClickEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
