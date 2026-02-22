using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000082 RID: 130
	public class MouseOverEvent : MouseEventBase<MouseOverEvent>
	{
		// Token: 0x06000736 RID: 1846 RVA: 0x00005162 File Offset: 0x00003362
		// Note: this type is marked as 'beforefieldinit'.
		static MouseOverEvent()
		{
			Il2CppClassPointerStore<MouseOverEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseOverEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseOverEvent>.NativeClassPtr);
			MouseOverEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseOverEvent>.NativeClassPtr, 100663973);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0002389C File Offset: 0x00021A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95566, XrefRangeEnd = 95569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseOverEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseOverEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseOverEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0000519B File Offset: 0x0000339B
		public MouseOverEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
