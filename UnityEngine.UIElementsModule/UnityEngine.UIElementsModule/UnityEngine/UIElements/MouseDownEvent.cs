using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000079 RID: 121
	public class MouseDownEvent : MouseEventBase<MouseDownEvent>
	{
		// Token: 0x060006FD RID: 1789 RVA: 0x00022BB0 File Offset: 0x00020DB0
		// Note: this type is marked as 'beforefieldinit'.
		static MouseDownEvent()
		{
			Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseDownEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr);
			MouseDownEvent.NativeMethodInfoPtr_MakeFromPointerEvent_Private_Static_MouseDownEvent_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr, 100663940);
			MouseDownEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseDownEvent_PointerDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr, 100663941);
			MouseDownEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseDownEvent_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr, 100663942);
			MouseDownEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr, 100663943);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00022C30 File Offset: 0x00020E30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 95415, RefRangeEnd = 95419, XrefRangeStart = 95388, XrefRangeEnd = 95415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseDownEvent.NativeMethodInfoPtr_MakeFromPointerEvent_Private_Static_MouseDownEvent_IPointerEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseDownEvent>(intPtr3) : null;
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00022C74 File Offset: 0x00020E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95419, XrefRangeEnd = 95420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseDownEvent GetPooled(PointerDownEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseDownEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseDownEvent_PointerDownEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseDownEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00022CB8 File Offset: 0x00020EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseDownEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseDownEvent_PointerMoveEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseDownEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00022CFC File Offset: 0x00020EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95420, XrefRangeEnd = 95423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseDownEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseDownEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x000050B5 File Offset: 0x000032B5
		public MouseDownEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00022D38 File Offset: 0x00020F38
		public new static MouseDownEvent GetPooled(Event systemEvent)
		{
			bool flag = systemEvent != null;
			if (flag)
			{
				PointerDeviceState.PressButton(PointerId.mousePointerId, systemEvent.button);
			}
			return MouseEventBase<MouseDownEvent>.GetPooled(systemEvent);
		}

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_MakeFromPointerEvent_Private_Static_MouseDownEvent_IPointerEvent_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_MouseDownEvent_PointerDownEvent_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_MouseDownEvent_PointerMoveEvent_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
