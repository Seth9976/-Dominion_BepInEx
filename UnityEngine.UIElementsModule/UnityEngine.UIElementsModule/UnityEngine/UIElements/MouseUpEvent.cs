using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200007A RID: 122
	public class MouseUpEvent : MouseEventBase<MouseUpEvent>
	{
		// Token: 0x06000704 RID: 1796 RVA: 0x00022D6C File Offset: 0x00020F6C
		// Note: this type is marked as 'beforefieldinit'.
		static MouseUpEvent()
		{
			Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseUpEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr);
			MouseUpEvent.NativeMethodInfoPtr_MakeFromPointerEvent_Private_Static_MouseUpEvent_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr, 100663944);
			MouseUpEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr, 100663945);
			MouseUpEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr, 100663946);
			MouseUpEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerCancelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr, 100663947);
			MouseUpEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr, 100663948);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00022E00 File Offset: 0x00021000
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 95450, RefRangeEnd = 95456, XrefRangeStart = 95423, XrefRangeEnd = 95450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseUpEvent MakeFromPointerEvent(IPointerEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseUpEvent.NativeMethodInfoPtr_MakeFromPointerEvent_Private_Static_MouseUpEvent_IPointerEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseUpEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00022E44 File Offset: 0x00021044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95456, XrefRangeEnd = 95457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseUpEvent GetPooled(PointerUpEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseUpEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerUpEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseUpEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00022E88 File Offset: 0x00021088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseUpEvent GetPooled(PointerMoveEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseUpEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerMoveEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseUpEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00022ECC File Offset: 0x000210CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseUpEvent GetPooled(PointerCancelEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseUpEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerCancelEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseUpEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00022F10 File Offset: 0x00021110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95457, XrefRangeEnd = 95460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseUpEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseUpEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000050BE File Offset: 0x000032BE
		public MouseUpEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00022F4C File Offset: 0x0002114C
		public new static MouseUpEvent GetPooled(Event systemEvent)
		{
			bool flag = systemEvent != null;
			if (flag)
			{
				PointerDeviceState.ReleaseButton(PointerId.mousePointerId, systemEvent.button);
			}
			return MouseEventBase<MouseUpEvent>.GetPooled(systemEvent);
		}

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_MakeFromPointerEvent_Private_Static_MouseUpEvent_IPointerEvent_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerUpEvent_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerMoveEvent_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerCancelEvent_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
