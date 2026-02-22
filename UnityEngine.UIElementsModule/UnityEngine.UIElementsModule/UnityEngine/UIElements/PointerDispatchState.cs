using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000025 RID: 37
	public class PointerDispatchState : Object
	{
		// Token: 0x06000278 RID: 632 RVA: 0x00013E60 File Offset: 0x00012060
		// Note: this type is marked as 'beforefieldinit'.
		static PointerDispatchState()
		{
			Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerDispatchState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr);
			PointerDispatchState.NativeFieldInfoPtr_m_PendingPointerCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, "m_PendingPointerCapture");
			PointerDispatchState.NativeFieldInfoPtr_m_PointerCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, "m_PointerCapture");
			PointerDispatchState.NativeFieldInfoPtr_m_ShouldSendCompatibilityMouseEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, "m_ShouldSendCompatibilityMouseEvents");
			PointerDispatchState.NativeMethodInfoPtr_GetCapturingElement_Public_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100663497);
			PointerDispatchState.NativeMethodInfoPtr_HasPointerCapture_Public_Boolean_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100663498);
			PointerDispatchState.NativeMethodInfoPtr_CapturePointer_Public_Void_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100663499);
			PointerDispatchState.NativeMethodInfoPtr_ReleasePointer_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100663500);
			PointerDispatchState.NativeMethodInfoPtr_ReleasePointer_Public_Void_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100663501);
			PointerDispatchState.NativeMethodInfoPtr_ProcessPointerCapture_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100663502);
			PointerDispatchState.NativeMethodInfoPtr_ActivateCompatibilityMouseEvents_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100663503);
			PointerDispatchState.NativeMethodInfoPtr_PreventCompatibilityMouseEvents_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100663504);
			PointerDispatchState.NativeMethodInfoPtr_ShouldSendCompatibilityMouseEvents_Public_Boolean_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDispatchState>.NativeClassPtr, 100663505);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00013F80 File Offset: 0x00012180
		[CallerCount(0)]
		public unsafe IEventHandler GetCapturingElement(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_GetCapturingElement_Public_IEventHandler_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr3) : null;
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00013FCC File Offset: 0x000121CC
		[CallerCount(0)]
		public unsafe bool HasPointerCapture(IEventHandler handler, int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_HasPointerCapture_Public_Boolean_IEventHandler_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00014028 File Offset: 0x00012228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92215, XrefRangeEnd = 92226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CapturePointer(IEventHandler handler, int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_CapturePointer_Public_Void_IEventHandler_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00014078 File Offset: 0x00012278
		[CallerCount(0)]
		public unsafe void ReleasePointer(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_ReleasePointer_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000140B8 File Offset: 0x000122B8
		[CallerCount(0)]
		public unsafe void ReleasePointer(IEventHandler handler, int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_ReleasePointer_Public_Void_IEventHandler_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00014108 File Offset: 0x00012308
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 92268, RefRangeEnd = 92272, XrefRangeStart = 92226, XrefRangeEnd = 92268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessPointerCapture(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_ProcessPointerCapture_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00014148 File Offset: 0x00012348
		[CallerCount(0)]
		public unsafe void ActivateCompatibilityMouseEvents(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_ActivateCompatibilityMouseEvents_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00014188 File Offset: 0x00012388
		[CallerCount(0)]
		public unsafe void PreventCompatibilityMouseEvents(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_PreventCompatibilityMouseEvents_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000141C8 File Offset: 0x000123C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92272, XrefRangeEnd = 92275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDispatchState.NativeMethodInfoPtr_ShouldSendCompatibilityMouseEvents_Public_Boolean_IPointerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000033F8 File Offset: 0x000015F8
		public PointerDispatchState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00014218 File Offset: 0x00012418
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00003401 File Offset: 0x00001601
		public unsafe Il2CppReferenceArray<IEventHandler> m_PendingPointerCapture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDispatchState.NativeFieldInfoPtr_m_PendingPointerCapture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IEventHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDispatchState.NativeFieldInfoPtr_m_PendingPointerCapture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00014248 File Offset: 0x00012448
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00003420 File Offset: 0x00001620
		public unsafe Il2CppReferenceArray<IEventHandler> m_PointerCapture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDispatchState.NativeFieldInfoPtr_m_PointerCapture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IEventHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDispatchState.NativeFieldInfoPtr_m_PointerCapture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00014278 File Offset: 0x00012478
		// (set) Token: 0x06000288 RID: 648 RVA: 0x0000343F File Offset: 0x0000163F
		public unsafe Il2CppStructArray<bool> m_ShouldSendCompatibilityMouseEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDispatchState.NativeFieldInfoPtr_m_ShouldSendCompatibilityMouseEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDispatchState.NativeFieldInfoPtr_m_ShouldSendCompatibilityMouseEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000345E File Offset: 0x0000165E
		public void Reset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr_m_PendingPointerCapture;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerCapture;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldSendCompatibilityMouseEvents;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_GetCapturingElement_Public_IEventHandler_Int32_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_HasPointerCapture_Public_Boolean_IEventHandler_Int32_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_CapturePointer_Public_Void_IEventHandler_Int32_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePointer_Public_Void_Int32_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePointer_Public_Void_IEventHandler_Int32_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPointerCapture_Public_Void_Int32_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_ActivateCompatibilityMouseEvents_Public_Void_Int32_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_PreventCompatibilityMouseEvents_Public_Void_Int32_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSendCompatibilityMouseEvents_Public_Boolean_IPointerEvent_0;
	}
}
