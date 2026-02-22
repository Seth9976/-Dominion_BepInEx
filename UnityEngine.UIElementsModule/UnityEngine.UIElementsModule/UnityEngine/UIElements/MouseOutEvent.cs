using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000083 RID: 131
	public class MouseOutEvent : MouseEventBase<MouseOutEvent>
	{
		// Token: 0x06000739 RID: 1849 RVA: 0x000051A4 File Offset: 0x000033A4
		// Note: this type is marked as 'beforefieldinit'.
		static MouseOutEvent()
		{
			Il2CppClassPointerStore<MouseOutEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseOutEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseOutEvent>.NativeClassPtr);
			MouseOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseOutEvent>.NativeClassPtr, 100663974);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000238D8 File Offset: 0x00021AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95569, XrefRangeEnd = 95572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseOutEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseOutEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000051DD File Offset: 0x000033DD
		public MouseOutEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
