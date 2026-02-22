using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200007B RID: 123
	public class MouseMoveEvent : MouseEventBase<MouseMoveEvent>
	{
		// Token: 0x0600070C RID: 1804 RVA: 0x00022F80 File Offset: 0x00021180
		// Note: this type is marked as 'beforefieldinit'.
		static MouseMoveEvent()
		{
			Il2CppClassPointerStore<MouseMoveEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseMoveEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseMoveEvent>.NativeClassPtr);
			MouseMoveEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseMoveEvent_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMoveEvent>.NativeClassPtr, 100663949);
			MouseMoveEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMoveEvent>.NativeClassPtr, 100663950);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00022FD8 File Offset: 0x000211D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95460, XrefRangeEnd = 95463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseMoveEvent GetPooled(PointerMoveEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMoveEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseMoveEvent_PointerMoveEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseMoveEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0002301C File Offset: 0x0002121C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95463, XrefRangeEnd = 95466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseMoveEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseMoveEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMoveEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x000050C7 File Offset: 0x000032C7
		public MouseMoveEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00023058 File Offset: 0x00021258
		public new static MouseMoveEvent GetPooled(Event systemEvent)
		{
			MouseMoveEvent pooled = MouseEventBase<MouseMoveEvent>.GetPooled(systemEvent);
			pooled.button = 0;
			return pooled;
		}

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_MouseMoveEvent_PointerMoveEvent_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
