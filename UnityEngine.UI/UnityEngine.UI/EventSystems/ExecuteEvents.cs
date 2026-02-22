using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000067 RID: 103
	public static class ExecuteEvents : Object
	{
		// Token: 0x060009ED RID: 2541 RVA: 0x0002D5B4 File Offset: 0x0002B7B4
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteEvents()
		{
			Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "ExecuteEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr);
			ExecuteEvents.NativeFieldInfoPtr_s_PointerMoveHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerMoveHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_PointerEnterHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerEnterHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_PointerExitHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerExitHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_PointerDownHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerDownHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_PointerUpHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerUpHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_PointerClickHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerClickHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_InitializePotentialDragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_InitializePotentialDragHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_BeginDragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_BeginDragHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_DragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_DragHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_EndDragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_EndDragHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_DropHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_DropHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_ScrollHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_ScrollHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_UpdateSelectedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_UpdateSelectedHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_SelectHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_SelectHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_DeselectHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_DeselectHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_MoveHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_MoveHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_SubmitHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_SubmitHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_CancelHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_CancelHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_InternalTransformList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_InternalTransformList");
			ExecuteEvents.NativeMethodInfoPtr_ValidateEventData_Public_Static_T_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664748);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerMoveHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664749);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerEnterHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664750);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerExitHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664751);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerDownHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664752);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerUpHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664753);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerClickHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664754);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IInitializePotentialDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664755);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IBeginDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664756);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664757);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IEndDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664758);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDropHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664759);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IScrollHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664760);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IUpdateSelectedHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664761);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ISelectHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664762);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDeselectHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664763);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IMoveHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664764);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ISubmitHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664765);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ICancelHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664766);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerMoveHandler_Public_Static_get_EventFunction_1_IPointerMoveHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664767);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerEnterHandler_Public_Static_get_EventFunction_1_IPointerEnterHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664768);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerExitHandler_Public_Static_get_EventFunction_1_IPointerExitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664769);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerDownHandler_Public_Static_get_EventFunction_1_IPointerDownHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664770);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerUpHandler_Public_Static_get_EventFunction_1_IPointerUpHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664771);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerClickHandler_Public_Static_get_EventFunction_1_IPointerClickHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664772);
			ExecuteEvents.NativeMethodInfoPtr_get_initializePotentialDrag_Public_Static_get_EventFunction_1_IInitializePotentialDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664773);
			ExecuteEvents.NativeMethodInfoPtr_get_beginDragHandler_Public_Static_get_EventFunction_1_IBeginDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664774);
			ExecuteEvents.NativeMethodInfoPtr_get_dragHandler_Public_Static_get_EventFunction_1_IDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664775);
			ExecuteEvents.NativeMethodInfoPtr_get_endDragHandler_Public_Static_get_EventFunction_1_IEndDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664776);
			ExecuteEvents.NativeMethodInfoPtr_get_dropHandler_Public_Static_get_EventFunction_1_IDropHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664777);
			ExecuteEvents.NativeMethodInfoPtr_get_scrollHandler_Public_Static_get_EventFunction_1_IScrollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664778);
			ExecuteEvents.NativeMethodInfoPtr_get_updateSelectedHandler_Public_Static_get_EventFunction_1_IUpdateSelectedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664779);
			ExecuteEvents.NativeMethodInfoPtr_get_selectHandler_Public_Static_get_EventFunction_1_ISelectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664780);
			ExecuteEvents.NativeMethodInfoPtr_get_deselectHandler_Public_Static_get_EventFunction_1_IDeselectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664781);
			ExecuteEvents.NativeMethodInfoPtr_get_moveHandler_Public_Static_get_EventFunction_1_IMoveHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664782);
			ExecuteEvents.NativeMethodInfoPtr_get_submitHandler_Public_Static_get_EventFunction_1_ISubmitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664783);
			ExecuteEvents.NativeMethodInfoPtr_get_cancelHandler_Public_Static_get_EventFunction_1_ICancelHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664784);
			ExecuteEvents.NativeMethodInfoPtr_GetEventChain_Private_Static_Void_GameObject_IList_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664785);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664786);
			ExecuteEvents.NativeMethodInfoPtr_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664787);
			ExecuteEvents.NativeMethodInfoPtr_ShouldSendToComponent_Private_Static_Boolean_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664788);
			ExecuteEvents.NativeMethodInfoPtr_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664789);
			ExecuteEvents.NativeMethodInfoPtr_CanHandleEvent_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664790);
			ExecuteEvents.NativeMethodInfoPtr_GetEventHandler_Public_Static_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664791);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0002DAD0 File Offset: 0x0002BCD0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 121627, RefRangeEnd = 121640, XrefRangeStart = 121618, XrefRangeEnd = 121627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ValidateEventData<T>(BaseEventData data) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_ValidateEventData_Public_Static_T_BaseEventData_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0002DB10 File Offset: 0x0002BD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121640, XrefRangeEnd = 121650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerMoveHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerMoveHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0002DB58 File Offset: 0x0002BD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121650, XrefRangeEnd = 121660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerEnterHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerEnterHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0002DBA0 File Offset: 0x0002BDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121660, XrefRangeEnd = 121670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerExitHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerExitHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0002DBE8 File Offset: 0x0002BDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121670, XrefRangeEnd = 121680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerDownHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerDownHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0002DC30 File Offset: 0x0002BE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121680, XrefRangeEnd = 121690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerUpHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerUpHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0002DC78 File Offset: 0x0002BE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121690, XrefRangeEnd = 121700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerClickHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerClickHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0002DCC0 File Offset: 0x0002BEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121700, XrefRangeEnd = 121710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IInitializePotentialDragHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0002DD08 File Offset: 0x0002BF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121710, XrefRangeEnd = 121720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IBeginDragHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IBeginDragHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0002DD50 File Offset: 0x0002BF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121720, XrefRangeEnd = 121730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IDragHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDragHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0002DD98 File Offset: 0x0002BF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121730, XrefRangeEnd = 121740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IEndDragHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IEndDragHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0002DDE0 File Offset: 0x0002BFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121740, XrefRangeEnd = 121750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IDropHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDropHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0002DE28 File Offset: 0x0002C028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121750, XrefRangeEnd = 121760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IScrollHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IScrollHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0002DE70 File Offset: 0x0002C070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121760, XrefRangeEnd = 121764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IUpdateSelectedHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0002DEB8 File Offset: 0x0002C0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121764, XrefRangeEnd = 121768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(ISelectHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ISelectHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0002DF00 File Offset: 0x0002C100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121768, XrefRangeEnd = 121772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IDeselectHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDeselectHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0002DF48 File Offset: 0x0002C148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121772, XrefRangeEnd = 121783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IMoveHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IMoveHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0002DF90 File Offset: 0x0002C190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121783, XrefRangeEnd = 121787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(ISubmitHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ISubmitHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0002DFD8 File Offset: 0x0002C1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121787, XrefRangeEnd = 121791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(ICancelHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ICancelHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0002E020 File Offset: 0x0002C220
		public unsafe static ExecuteEvents.EventFunction<IPointerMoveHandler> pointerMoveHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121791, XrefRangeEnd = 121795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerMoveHandler_Public_Static_get_EventFunction_1_IPointerMoveHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerMoveHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x0002E054 File Offset: 0x0002C254
		public unsafe static ExecuteEvents.EventFunction<IPointerEnterHandler> pointerEnterHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121795, XrefRangeEnd = 121799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerEnterHandler_Public_Static_get_EventFunction_1_IPointerEnterHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerEnterHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0002E088 File Offset: 0x0002C288
		public unsafe static ExecuteEvents.EventFunction<IPointerExitHandler> pointerExitHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121799, XrefRangeEnd = 121803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerExitHandler_Public_Static_get_EventFunction_1_IPointerExitHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerExitHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0002E0BC File Offset: 0x0002C2BC
		public unsafe static ExecuteEvents.EventFunction<IPointerDownHandler> pointerDownHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121803, XrefRangeEnd = 121807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerDownHandler_Public_Static_get_EventFunction_1_IPointerDownHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerDownHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0002E0F0 File Offset: 0x0002C2F0
		public unsafe static ExecuteEvents.EventFunction<IPointerUpHandler> pointerUpHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121807, XrefRangeEnd = 121811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerUpHandler_Public_Static_get_EventFunction_1_IPointerUpHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerUpHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x0002E124 File Offset: 0x0002C324
		public unsafe static ExecuteEvents.EventFunction<IPointerClickHandler> pointerClickHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121811, XrefRangeEnd = 121815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerClickHandler_Public_Static_get_EventFunction_1_IPointerClickHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerClickHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0002E158 File Offset: 0x0002C358
		public unsafe static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> initializePotentialDrag
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121815, XrefRangeEnd = 121819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_initializePotentialDrag_Public_Static_get_EventFunction_1_IInitializePotentialDragHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IInitializePotentialDragHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0002E18C File Offset: 0x0002C38C
		public unsafe static ExecuteEvents.EventFunction<IBeginDragHandler> beginDragHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121819, XrefRangeEnd = 121823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_beginDragHandler_Public_Static_get_EventFunction_1_IBeginDragHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IBeginDragHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0002E1C0 File Offset: 0x0002C3C0
		public unsafe static ExecuteEvents.EventFunction<IDragHandler> dragHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121823, XrefRangeEnd = 121827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_dragHandler_Public_Static_get_EventFunction_1_IDragHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDragHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0002E1F4 File Offset: 0x0002C3F4
		public unsafe static ExecuteEvents.EventFunction<IEndDragHandler> endDragHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121827, XrefRangeEnd = 121831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_endDragHandler_Public_Static_get_EventFunction_1_IEndDragHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IEndDragHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0002E228 File Offset: 0x0002C428
		public unsafe static ExecuteEvents.EventFunction<IDropHandler> dropHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121831, XrefRangeEnd = 121835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_dropHandler_Public_Static_get_EventFunction_1_IDropHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDropHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0002E25C File Offset: 0x0002C45C
		public unsafe static ExecuteEvents.EventFunction<IScrollHandler> scrollHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121835, XrefRangeEnd = 121839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_scrollHandler_Public_Static_get_EventFunction_1_IScrollHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IScrollHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0002E290 File Offset: 0x0002C490
		public unsafe static ExecuteEvents.EventFunction<IUpdateSelectedHandler> updateSelectedHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121839, XrefRangeEnd = 121843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_updateSelectedHandler_Public_Static_get_EventFunction_1_IUpdateSelectedHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IUpdateSelectedHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0002E2C4 File Offset: 0x0002C4C4
		public unsafe static ExecuteEvents.EventFunction<ISelectHandler> selectHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121843, XrefRangeEnd = 121847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_selectHandler_Public_Static_get_EventFunction_1_ISelectHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ISelectHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0002E2F8 File Offset: 0x0002C4F8
		public unsafe static ExecuteEvents.EventFunction<IDeselectHandler> deselectHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121847, XrefRangeEnd = 121851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_deselectHandler_Public_Static_get_EventFunction_1_IDeselectHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDeselectHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0002E32C File Offset: 0x0002C52C
		public unsafe static ExecuteEvents.EventFunction<IMoveHandler> moveHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121851, XrefRangeEnd = 121855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_moveHandler_Public_Static_get_EventFunction_1_IMoveHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IMoveHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0002E360 File Offset: 0x0002C560
		public unsafe static ExecuteEvents.EventFunction<ISubmitHandler> submitHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121855, XrefRangeEnd = 121859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_submitHandler_Public_Static_get_EventFunction_1_ISubmitHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ISubmitHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0002E394 File Offset: 0x0002C594
		public unsafe static ExecuteEvents.EventFunction<ICancelHandler> cancelHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121859, XrefRangeEnd = 121863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_cancelHandler_Public_Static_get_EventFunction_1_ICancelHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ICancelHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0002E3C8 File Offset: 0x0002C5C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121879, RefRangeEnd = 121880, XrefRangeStart = 121863, XrefRangeEnd = 121879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetEventChain(GameObject root, IList<Transform> eventChain)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_GetEventChain_Private_Static_Void_GameObject_IList_1_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0002E410 File Offset: 0x0002C610
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 121927, RefRangeEnd = 121960, XrefRangeStart = 121880, XrefRangeEnd = 121927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(functor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0002E478 File Offset: 0x0002C678
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 121976, RefRangeEnd = 121991, XrefRangeStart = 121960, XrefRangeEnd = 121976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callbackFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0002E4E0 File Offset: 0x0002C6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121991, XrefRangeEnd = 122000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldSendToComponent<T>(Component component)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_ShouldSendToComponent_Private_Static_Boolean_Component_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0002E524 File Offset: 0x0002C724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122000, XrefRangeEnd = 122037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0002E56C File Offset: 0x0002C76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122037, XrefRangeEnd = 122050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanHandleEvent<T>(GameObject go)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_CanHandleEvent_Public_Static_Boolean_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0002E5B0 File Offset: 0x0002C7B0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 122065, RefRangeEnd = 122082, XrefRangeStart = 122050, XrefRangeEnd = 122065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject GetEventHandler<T>(GameObject root)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_GetEventHandler_Public_Static_GameObject_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0000596E File Offset: 0x00003B6E
		public ExecuteEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0002E5F4 File Offset: 0x0002C7F4
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00005977 File Offset: 0x00003B77
		public unsafe static ExecuteEvents.EventFunction<IPointerMoveHandler> s_PointerMoveHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerMoveHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerMoveHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerMoveHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x0002E61C File Offset: 0x0002C81C
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x00005989 File Offset: 0x00003B89
		public unsafe static ExecuteEvents.EventFunction<IPointerEnterHandler> s_PointerEnterHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerEnterHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerEnterHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerEnterHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x0002E644 File Offset: 0x0002C844
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x0000599B File Offset: 0x00003B9B
		public unsafe static ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerExitHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerExitHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerExitHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x0002E66C File Offset: 0x0002C86C
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x000059AD File Offset: 0x00003BAD
		public unsafe static ExecuteEvents.EventFunction<IPointerDownHandler> s_PointerDownHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerDownHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerDownHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerDownHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x0002E694 File Offset: 0x0002C894
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x000059BF File Offset: 0x00003BBF
		public unsafe static ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerUpHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerUpHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerUpHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0002E6BC File Offset: 0x0002C8BC
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x000059D1 File Offset: 0x00003BD1
		public unsafe static ExecuteEvents.EventFunction<IPointerClickHandler> s_PointerClickHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerClickHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerClickHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerClickHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0002E6E4 File Offset: 0x0002C8E4
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x000059E3 File Offset: 0x00003BE3
		public unsafe static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_InitializePotentialDragHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IInitializePotentialDragHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_InitializePotentialDragHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0002E70C File Offset: 0x0002C90C
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x000059F5 File Offset: 0x00003BF5
		public unsafe static ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_BeginDragHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IBeginDragHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_BeginDragHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0002E734 File Offset: 0x0002C934
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x00005A07 File Offset: 0x00003C07
		public unsafe static ExecuteEvents.EventFunction<IDragHandler> s_DragHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_DragHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDragHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_DragHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0002E75C File Offset: 0x0002C95C
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x00005A19 File Offset: 0x00003C19
		public unsafe static ExecuteEvents.EventFunction<IEndDragHandler> s_EndDragHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_EndDragHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IEndDragHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_EndDragHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0002E784 File Offset: 0x0002C984
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x00005A2B File Offset: 0x00003C2B
		public unsafe static ExecuteEvents.EventFunction<IDropHandler> s_DropHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_DropHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDropHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_DropHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0002E7AC File Offset: 0x0002C9AC
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x00005A3D File Offset: 0x00003C3D
		public unsafe static ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_ScrollHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IScrollHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_ScrollHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0002E7D4 File Offset: 0x0002C9D4
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x00005A4F File Offset: 0x00003C4F
		public unsafe static ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_UpdateSelectedHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IUpdateSelectedHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_UpdateSelectedHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0002E7FC File Offset: 0x0002C9FC
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00005A61 File Offset: 0x00003C61
		public unsafe static ExecuteEvents.EventFunction<ISelectHandler> s_SelectHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_SelectHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ISelectHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_SelectHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0002E824 File Offset: 0x0002CA24
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00005A73 File Offset: 0x00003C73
		public unsafe static ExecuteEvents.EventFunction<IDeselectHandler> s_DeselectHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_DeselectHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDeselectHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_DeselectHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0002E84C File Offset: 0x0002CA4C
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00005A85 File Offset: 0x00003C85
		public unsafe static ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_MoveHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IMoveHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_MoveHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0002E874 File Offset: 0x0002CA74
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00005A97 File Offset: 0x00003C97
		public unsafe static ExecuteEvents.EventFunction<ISubmitHandler> s_SubmitHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_SubmitHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ISubmitHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_SubmitHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0002E89C File Offset: 0x0002CA9C
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00005AA9 File Offset: 0x00003CA9
		public unsafe static ExecuteEvents.EventFunction<ICancelHandler> s_CancelHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_CancelHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ICancelHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_CancelHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0002E8C4 File Offset: 0x0002CAC4
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x00005ABB File Offset: 0x00003CBB
		public unsafe static List<Transform> s_InternalTransformList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_InternalTransformList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_InternalTransformList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerMoveHandler;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerEnterHandler;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerExitHandler;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerDownHandler;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerUpHandler;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerClickHandler;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeFieldInfoPtr_s_InitializePotentialDragHandler;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeFieldInfoPtr_s_BeginDragHandler;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeFieldInfoPtr_s_DragHandler;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeFieldInfoPtr_s_EndDragHandler;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeFieldInfoPtr_s_DropHandler;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeFieldInfoPtr_s_ScrollHandler;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeFieldInfoPtr_s_UpdateSelectedHandler;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeFieldInfoPtr_s_SelectHandler;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeFieldInfoPtr_s_DeselectHandler;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeFieldInfoPtr_s_MoveHandler;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeFieldInfoPtr_s_SubmitHandler;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeFieldInfoPtr_s_CancelHandler;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalTransformList;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEventData_Public_Static_T_BaseEventData_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerMoveHandler_BaseEventData_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerEnterHandler_BaseEventData_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerExitHandler_BaseEventData_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerDownHandler_BaseEventData_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerUpHandler_BaseEventData_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerClickHandler_BaseEventData_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IInitializePotentialDragHandler_BaseEventData_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IBeginDragHandler_BaseEventData_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IDragHandler_BaseEventData_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IEndDragHandler_BaseEventData_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IDropHandler_BaseEventData_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IScrollHandler_BaseEventData_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IUpdateSelectedHandler_BaseEventData_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_ISelectHandler_BaseEventData_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IDeselectHandler_BaseEventData_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IMoveHandler_BaseEventData_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_ISubmitHandler_BaseEventData_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_ICancelHandler_BaseEventData_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerMoveHandler_Public_Static_get_EventFunction_1_IPointerMoveHandler_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerEnterHandler_Public_Static_get_EventFunction_1_IPointerEnterHandler_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerExitHandler_Public_Static_get_EventFunction_1_IPointerExitHandler_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerDownHandler_Public_Static_get_EventFunction_1_IPointerDownHandler_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerUpHandler_Public_Static_get_EventFunction_1_IPointerUpHandler_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerClickHandler_Public_Static_get_EventFunction_1_IPointerClickHandler_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_get_initializePotentialDrag_Public_Static_get_EventFunction_1_IInitializePotentialDragHandler_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_get_beginDragHandler_Public_Static_get_EventFunction_1_IBeginDragHandler_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_get_dragHandler_Public_Static_get_EventFunction_1_IDragHandler_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_get_endDragHandler_Public_Static_get_EventFunction_1_IEndDragHandler_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_get_dropHandler_Public_Static_get_EventFunction_1_IDropHandler_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollHandler_Public_Static_get_EventFunction_1_IScrollHandler_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_get_updateSelectedHandler_Public_Static_get_EventFunction_1_IUpdateSelectedHandler_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_get_selectHandler_Public_Static_get_EventFunction_1_ISelectHandler_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_get_deselectHandler_Public_Static_get_EventFunction_1_IDeselectHandler_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_get_moveHandler_Public_Static_get_EventFunction_1_IMoveHandler_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_get_submitHandler_Public_Static_get_EventFunction_1_ISubmitHandler_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_get_cancelHandler_Public_Static_get_EventFunction_1_ICancelHandler_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_GetEventChain_Private_Static_Void_GameObject_IList_1_Transform_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSendToComponent_Private_Static_Boolean_Component_0;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_CanHandleEvent_Public_Static_Boolean_GameObject_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_GetEventHandler_Public_Static_GameObject_GameObject_0;

		// Token: 0x020000C7 RID: 199
		public sealed class EventFunction<T1> : MulticastDelegate
		{
			// Token: 0x06000D45 RID: 3397 RVA: 0x00038B80 File Offset: 0x00036D80
			// Note: this type is marked as 'beforefieldinit'.
			static EventFunction()
			{
				Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "EventFunction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)) })).TypeHandle.value);
				ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr, 100665132);
				ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr, 100665133);
				ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T1_BaseEventData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr, 100665134);
				ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr, 100665135);
			}

			// Token: 0x06000D46 RID: 3398 RVA: 0x00038C2C File Offset: 0x00036E2C
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D47 RID: 3399 RVA: 0x00038C88 File Offset: 0x00036E88
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 10628, RefRangeEnd = 10662, XrefRangeStart = 10628, XrefRangeEnd = 10662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(T1 handler, BaseEventData eventData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T1).IsValueType)
					{
						T1 t = handler;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref handler;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x06000D48 RID: 3400 RVA: 0x00038D14 File Offset: 0x00036F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121617, XrefRangeEnd = 121618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T1).IsValueType)
					{
						T1 t = handler;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref handler;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T1_BaseEventData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x06000D49 RID: 3401 RVA: 0x00038DD4 File Offset: 0x00036FD4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D4A RID: 3402 RVA: 0x00007094 File Offset: 0x00005294
			public EventFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000D4B RID: 3403 RVA: 0x0000709D File Offset: 0x0000529D
			public static implicit operator ExecuteEvents.EventFunction<T1>(Action<T1, BaseEventData> A_0)
			{
				return DelegateSupport.ConvertDelegate<ExecuteEvents.EventFunction<T1>>(A_0);
			}

			// Token: 0x06000D4C RID: 3404 RVA: 0x000070A5 File Offset: 0x000052A5
			public static ExecuteEvents.EventFunction<T1>operator +(ExecuteEvents.EventFunction<T1> A_0, ExecuteEvents.EventFunction<T1> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ExecuteEvents.EventFunction<T1>>();
			}

			// Token: 0x06000D4D RID: 3405 RVA: 0x000070B3 File Offset: 0x000052B3
			public static ExecuteEvents.EventFunction<T1>operator -(ExecuteEvents.EventFunction<T1> A_0, ExecuteEvents.EventFunction<T1> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ExecuteEvents.EventFunction<T1>>();
				}
				return delegate2;
			}

			// Token: 0x04000A57 RID: 2647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000A58 RID: 2648
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_BaseEventData_0;

			// Token: 0x04000A59 RID: 2649
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T1_BaseEventData_AsyncCallback_Object_0;

			// Token: 0x04000A5A RID: 2650
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020000C8 RID: 200
		private sealed class MethodInfoStoreGeneric_ValidateEventData_Public_Static_T_BaseEventData_0<T>
		{
			// Token: 0x04000A5B RID: 2651
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_ValidateEventData_Public_Static_T_BaseEventData_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C9 RID: 201
		private sealed class MethodInfoStoreGeneric_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0<T>
		{
			// Token: 0x04000A5C RID: 2652
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CA RID: 202
		private sealed class MethodInfoStoreGeneric_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0<T>
		{
			// Token: 0x04000A5D RID: 2653
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CB RID: 203
		private sealed class MethodInfoStoreGeneric_ShouldSendToComponent_Private_Static_Boolean_Component_0<T>
		{
			// Token: 0x04000A5E RID: 2654
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_ShouldSendToComponent_Private_Static_Boolean_Component_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CC RID: 204
		private sealed class MethodInfoStoreGeneric_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0<T>
		{
			// Token: 0x04000A5F RID: 2655
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CD RID: 205
		private sealed class MethodInfoStoreGeneric_CanHandleEvent_Public_Static_Boolean_GameObject_0<T>
		{
			// Token: 0x04000A60 RID: 2656
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_CanHandleEvent_Public_Static_Boolean_GameObject_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CE RID: 206
		private sealed class MethodInfoStoreGeneric_GetEventHandler_Public_Static_GameObject_GameObject_0<T>
		{
			// Token: 0x04000A61 RID: 2657
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_GetEventHandler_Public_Static_GameObject_GameObject_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
