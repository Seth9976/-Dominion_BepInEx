using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000024 RID: 36
	public static class PointerCaptureHelper : Object
	{
		// Token: 0x0600026B RID: 619 RVA: 0x00013A94 File Offset: 0x00011C94
		// Note: this type is marked as 'beforefieldinit'.
		static PointerCaptureHelper()
		{
			Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerCaptureHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr);
			PointerCaptureHelper.NativeMethodInfoPtr_GetStateFor_Private_Static_PointerDispatchState_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100663487);
			PointerCaptureHelper.NativeMethodInfoPtr_HasPointerCapture_Public_Static_Boolean_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100663488);
			PointerCaptureHelper.NativeMethodInfoPtr_CapturePointer_Public_Static_Void_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100663489);
			PointerCaptureHelper.NativeMethodInfoPtr_ReleasePointer_Public_Static_Void_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100663490);
			PointerCaptureHelper.NativeMethodInfoPtr_GetCapturingElement_Public_Static_IEventHandler_IPanel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100663491);
			PointerCaptureHelper.NativeMethodInfoPtr_ReleasePointer_Public_Static_Void_IPanel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100663492);
			PointerCaptureHelper.NativeMethodInfoPtr_ActivateCompatibilityMouseEvents_Internal_Static_Void_IPanel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100663493);
			PointerCaptureHelper.NativeMethodInfoPtr_PreventCompatibilityMouseEvents_Internal_Static_Void_IPanel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100663494);
			PointerCaptureHelper.NativeMethodInfoPtr_ShouldSendCompatibilityMouseEvents_Internal_Static_Boolean_IPanel_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100663495);
			PointerCaptureHelper.NativeMethodInfoPtr_ProcessPointerCapture_Internal_Static_Void_IPanel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureHelper>.NativeClassPtr, 100663496);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00013B8C File Offset: 0x00011D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92141, XrefRangeEnd = 92147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PointerDispatchState GetStateFor(IEventHandler handler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_GetStateFor_Private_Static_PointerDispatchState_IEventHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerDispatchState>(intPtr3) : null;
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00013BD0 File Offset: 0x00011DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92147, XrefRangeEnd = 92153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasPointerCapture(this IEventHandler handler, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_HasPointerCapture_Public_Static_Boolean_IEventHandler_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00013C20 File Offset: 0x00011E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92153, XrefRangeEnd = 92170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CapturePointer(this IEventHandler handler, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_CapturePointer_Public_Static_Void_IEventHandler_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00013C64 File Offset: 0x00011E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92170, XrefRangeEnd = 92176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleasePointer(this IEventHandler handler, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_ReleasePointer_Public_Static_Void_IEventHandler_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00013CA8 File Offset: 0x00011EA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92179, RefRangeEnd = 92180, XrefRangeStart = 92176, XrefRangeEnd = 92179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEventHandler GetCapturingElement(this IPanel panel, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_GetCapturingElement_Public_Static_IEventHandler_IPanel_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr3) : null;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00013CFC File Offset: 0x00011EFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92183, RefRangeEnd = 92184, XrefRangeStart = 92180, XrefRangeEnd = 92183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleasePointer(this IPanel panel, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_ReleasePointer_Public_Static_Void_IPanel_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00013D40 File Offset: 0x00011F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92184, XrefRangeEnd = 92187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActivateCompatibilityMouseEvents(this IPanel panel, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_ActivateCompatibilityMouseEvents_Internal_Static_Void_IPanel_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00013D84 File Offset: 0x00011F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92187, XrefRangeEnd = 92190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PreventCompatibilityMouseEvents(this IPanel panel, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_PreventCompatibilityMouseEvents_Internal_Static_Void_IPanel_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00013DC8 File Offset: 0x00011FC8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 92205, RefRangeEnd = 92210, XrefRangeStart = 92190, XrefRangeEnd = 92205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldSendCompatibilityMouseEvents(this IPanel panel, IPointerEvent evt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_ShouldSendCompatibilityMouseEvents_Internal_Static_Boolean_IPanel_IPointerEvent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00013E1C File Offset: 0x0001201C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92214, RefRangeEnd = 92215, XrefRangeStart = 92210, XrefRangeEnd = 92214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessPointerCapture(this IPanel panel, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureHelper.NativeMethodInfoPtr_ProcessPointerCapture_Internal_Static_Void_IPanel_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000033D0 File Offset: 0x000015D0
		public PointerCaptureHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000033D9 File Offset: 0x000015D9
		public static void ResetPointerDispatchState(IPanel panel)
		{
			if (panel != null)
			{
				EventDispatcher dispatcher = panel.dispatcher;
				if (dispatcher != null)
				{
					dispatcher.pointerState.Reset();
				}
			}
		}

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_GetStateFor_Private_Static_PointerDispatchState_IEventHandler_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_HasPointerCapture_Public_Static_Boolean_IEventHandler_Int32_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_CapturePointer_Public_Static_Void_IEventHandler_Int32_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePointer_Public_Static_Void_IEventHandler_Int32_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_GetCapturingElement_Public_Static_IEventHandler_IPanel_Int32_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePointer_Public_Static_Void_IPanel_Int32_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_ActivateCompatibilityMouseEvents_Internal_Static_Void_IPanel_Int32_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_PreventCompatibilityMouseEvents_Internal_Static_Void_IPanel_Int32_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSendCompatibilityMouseEvents_Internal_Static_Boolean_IPanel_IPointerEvent_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPointerCapture_Internal_Static_Void_IPanel_Int32_0;
	}
}
