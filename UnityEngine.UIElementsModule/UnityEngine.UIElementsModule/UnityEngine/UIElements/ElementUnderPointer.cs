using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000059 RID: 89
	public class ElementUnderPointer : Object
	{
		// Token: 0x0600055B RID: 1371 RVA: 0x0001C6AC File Offset: 0x0001A8AC
		// Note: this type is marked as 'beforefieldinit'.
		static ElementUnderPointer()
		{
			Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ElementUnderPointer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr);
			ElementUnderPointer.NativeFieldInfoPtr_m_PendingTopElementUnderPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, "m_PendingTopElementUnderPointer");
			ElementUnderPointer.NativeFieldInfoPtr_m_TopElementUnderPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, "m_TopElementUnderPointer");
			ElementUnderPointer.NativeFieldInfoPtr_m_TriggerPointerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, "m_TriggerPointerEvent");
			ElementUnderPointer.NativeFieldInfoPtr_m_TriggerMouseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, "m_TriggerMouseEvent");
			ElementUnderPointer.NativeFieldInfoPtr_m_PickingPointerPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, "m_PickingPointerPositions");
			ElementUnderPointer.NativeFieldInfoPtr_m_IsPickingPointerTemporaries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, "m_IsPickingPointerTemporaries");
			ElementUnderPointer.NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_byref_Vector2_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100663711);
			ElementUnderPointer.NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100663712);
			ElementUnderPointer.NativeMethodInfoPtr_GetEventPointerPosition_Private_Vector2_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100663713);
			ElementUnderPointer.NativeMethodInfoPtr_SetTemporaryElementUnderPointer_Internal_Void_VisualElement_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100663714);
			ElementUnderPointer.NativeMethodInfoPtr_SetElementUnderPointer_Internal_Void_VisualElement_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100663715);
			ElementUnderPointer.NativeMethodInfoPtr_SetElementUnderPointer_Private_Void_VisualElement_EventBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100663716);
			ElementUnderPointer.NativeMethodInfoPtr_CommitElementUnderPointers_Internal_Void_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100663717);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0001C7E0 File Offset: 0x0001A9E0
		[CallerCount(0)]
		public unsafe VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pickPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isTemporary;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_byref_Vector2_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0001C848 File Offset: 0x0001AA48
		[CallerCount(0)]
		public unsafe VisualElement GetTopElementUnderPointer(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0001C894 File Offset: 0x0001AA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93703, XrefRangeEnd = 93709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetEventPointerPosition(EventBase triggerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr_GetEventPointerPosition_Private_Vector2_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0001C8E4 File Offset: 0x0001AAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93709, XrefRangeEnd = 93710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newElementUnderPointer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr_SetTemporaryElementUnderPointer_Internal_Void_VisualElement_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0001C938 File Offset: 0x0001AB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93710, XrefRangeEnd = 93711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newElementUnderPointer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr_SetElementUnderPointer_Internal_Void_VisualElement_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0001C98C File Offset: 0x0001AB8C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 93761, RefRangeEnd = 93769, XrefRangeStart = 93711, XrefRangeEnd = 93761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent, bool temporary)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newElementUnderPointer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref temporary;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr_SetElementUnderPointer_Private_Void_VisualElement_EventBase_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0001C9F0 File Offset: 0x0001ABF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 93892, RefRangeEnd = 93895, XrefRangeStart = 93769, XrefRangeEnd = 93892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommitElementUnderPointers(EventDispatcher dispatcher)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dispatcher);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr_CommitElementUnderPointers_Internal_Void_EventDispatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000048F0 File Offset: 0x00002AF0
		public ElementUnderPointer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x0001CA34 File Offset: 0x0001AC34
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x000048F9 File Offset: 0x00002AF9
		public unsafe Il2CppReferenceArray<VisualElement> m_PendingTopElementUnderPointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_PendingTopElementUnderPointer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_PendingTopElementUnderPointer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0001CA64 File Offset: 0x0001AC64
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x00004918 File Offset: 0x00002B18
		public unsafe Il2CppReferenceArray<VisualElement> m_TopElementUnderPointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_TopElementUnderPointer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_TopElementUnderPointer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x0001CA94 File Offset: 0x0001AC94
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00004937 File Offset: 0x00002B37
		public unsafe Il2CppReferenceArray<IPointerEvent> m_TriggerPointerEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_TriggerPointerEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPointerEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_TriggerPointerEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0001CAC4 File Offset: 0x0001ACC4
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00004956 File Offset: 0x00002B56
		public unsafe Il2CppReferenceArray<IMouseEvent> m_TriggerMouseEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_TriggerMouseEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IMouseEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_TriggerMouseEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0001CAF4 File Offset: 0x0001ACF4
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x00004975 File Offset: 0x00002B75
		public unsafe Il2CppStructArray<Vector2> m_PickingPointerPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_PickingPointerPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_PickingPointerPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0001CB24 File Offset: 0x0001AD24
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x00004994 File Offset: 0x00002B94
		public unsafe Il2CppStructArray<bool> m_IsPickingPointerTemporaries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_IsPickingPointerTemporaries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_IsPickingPointerTemporaries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x000049B3 File Offset: 0x00002BB3
		public void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeFieldInfoPtr_m_PendingTopElementUnderPointer;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeFieldInfoPtr_m_TopElementUnderPointer;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeFieldInfoPtr_m_TriggerPointerEvent;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeFieldInfoPtr_m_TriggerMouseEvent;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeFieldInfoPtr_m_PickingPointerPositions;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeFieldInfoPtr_m_IsPickingPointerTemporaries;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_byref_Vector2_byref_Boolean_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_GetEventPointerPosition_Private_Vector2_EventBase_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_SetTemporaryElementUnderPointer_Internal_Void_VisualElement_EventBase_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_SetElementUnderPointer_Internal_Void_VisualElement_EventBase_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_SetElementUnderPointer_Private_Void_VisualElement_EventBase_Boolean_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_CommitElementUnderPointers_Internal_Void_EventDispatcher_0;
	}
}
