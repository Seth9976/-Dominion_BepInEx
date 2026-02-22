using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000065 RID: 101
	public class EventTrigger : MonoBehaviour
	{
		// Token: 0x060009D2 RID: 2514 RVA: 0x0002CC90 File Offset: 0x0002AE90
		// Note: this type is marked as 'beforefieldinit'.
		static EventTrigger()
		{
			Il2CppClassPointerStore<EventTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "EventTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr);
			EventTrigger.NativeFieldInfoPtr_m_Delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, "m_Delegates");
			EventTrigger.NativeMethodInfoPtr_get_delegates_Public_get_List_1_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664725);
			EventTrigger.NativeMethodInfoPtr_set_delegates_Public_set_Void_List_1_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664726);
			EventTrigger.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664727);
			EventTrigger.NativeMethodInfoPtr_get_triggers_Public_get_List_1_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664728);
			EventTrigger.NativeMethodInfoPtr_set_triggers_Public_set_Void_List_1_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664729);
			EventTrigger.NativeMethodInfoPtr_Execute_Private_Void_EventTriggerType_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664730);
			EventTrigger.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664731);
			EventTrigger.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664732);
			EventTrigger.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664733);
			EventTrigger.NativeMethodInfoPtr_OnDrop_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664734);
			EventTrigger.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664735);
			EventTrigger.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664736);
			EventTrigger.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664737);
			EventTrigger.NativeMethodInfoPtr_OnSelect_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664738);
			EventTrigger.NativeMethodInfoPtr_OnDeselect_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664739);
			EventTrigger.NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664740);
			EventTrigger.NativeMethodInfoPtr_OnMove_Public_Virtual_New_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664741);
			EventTrigger.NativeMethodInfoPtr_OnUpdateSelected_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664742);
			EventTrigger.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664743);
			EventTrigger.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664744);
			EventTrigger.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664745);
			EventTrigger.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664746);
			EventTrigger.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, 100664747);
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0002CEA0 File Offset: 0x0002B0A0
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x0002CEE0 File Offset: 0x0002B0E0
		public unsafe List<EventTrigger.Entry> delegates
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121553, XrefRangeEnd = 121559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventTrigger.NativeMethodInfoPtr_get_delegates_Public_get_List_1_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EventTrigger.Entry>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventTrigger.NativeMethodInfoPtr_set_delegates_Public_set_Void_List_1_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0002CF24 File Offset: 0x0002B124
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventTrigger.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0002CF60 File Offset: 0x0002B160
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x0002CFA0 File Offset: 0x0002B1A0
		public unsafe List<EventTrigger.Entry> triggers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventTrigger.NativeMethodInfoPtr_get_triggers_Public_get_List_1_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EventTrigger.Entry>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventTrigger.NativeMethodInfoPtr_set_triggers_Public_set_Void_List_1_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0002CFE4 File Offset: 0x0002B1E4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 121583, RefRangeEnd = 121600, XrefRangeStart = 121559, XrefRangeEnd = 121583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(EventTriggerType id, BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventTrigger.NativeMethodInfoPtr_Execute_Private_Void_EventTriggerType_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0002D034 File Offset: 0x0002B234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121600, XrefRangeEnd = 121601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0002D084 File Offset: 0x0002B284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121601, XrefRangeEnd = 121602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0002D0D4 File Offset: 0x0002B2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121602, XrefRangeEnd = 121603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0002D124 File Offset: 0x0002B324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121603, XrefRangeEnd = 121604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDrop(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnDrop_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0002D174 File Offset: 0x0002B374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121604, XrefRangeEnd = 121605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0002D1C4 File Offset: 0x0002B3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121605, XrefRangeEnd = 121606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0002D214 File Offset: 0x0002B414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121606, XrefRangeEnd = 121607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0002D264 File Offset: 0x0002B464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121607, XrefRangeEnd = 121608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnSelect_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0002D2B4 File Offset: 0x0002B4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121608, XrefRangeEnd = 121609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnDeselect_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0002D304 File Offset: 0x0002B504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121609, XrefRangeEnd = 121610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnScroll(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0002D354 File Offset: 0x0002B554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121610, XrefRangeEnd = 121611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMove(AxisEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnMove_Public_Virtual_New_Void_AxisEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0002D3A4 File Offset: 0x0002B5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121611, XrefRangeEnd = 121612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUpdateSelected(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnUpdateSelected_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0002D3F4 File Offset: 0x0002B5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121612, XrefRangeEnd = 121613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0002D444 File Offset: 0x0002B644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121613, XrefRangeEnd = 121614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0002D494 File Offset: 0x0002B694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121614, XrefRangeEnd = 121615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0002D4E4 File Offset: 0x0002B6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121615, XrefRangeEnd = 121616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0002D534 File Offset: 0x0002B734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121616, XrefRangeEnd = 121617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCancel(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventTrigger.NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00005946 File Offset: 0x00003B46
		public EventTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x0002D584 File Offset: 0x0002B784
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x0000594F File Offset: 0x00003B4F
		public unsafe List<EventTrigger.Entry> m_Delegates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTrigger.NativeFieldInfoPtr_m_Delegates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventTrigger.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTrigger.NativeFieldInfoPtr_m_Delegates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeFieldInfoPtr_m_Delegates;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_get_delegates_Public_get_List_1_Entry_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_set_delegates_Public_set_Void_List_1_Entry_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_get_triggers_Public_get_List_1_Entry_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_set_triggers_Public_set_Void_List_1_Entry_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_EventTriggerType_BaseEventData_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_OnDrop_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_OnMove_Public_Virtual_New_Void_AxisEventData_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateSelected_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x020000C5 RID: 197
		[Serializable]
		public class TriggerEvent : UnityEvent<BaseEventData>
		{
			// Token: 0x06000D3B RID: 3387 RVA: 0x00007014 File Offset: 0x00005214
			// Note: this type is marked as 'beforefieldinit'.
			static TriggerEvent()
			{
				Il2CppClassPointerStore<EventTrigger.TriggerEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, "TriggerEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventTrigger.TriggerEvent>.NativeClassPtr);
				EventTrigger.TriggerEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger.TriggerEvent>.NativeClassPtr, 100665130);
			}

			// Token: 0x06000D3C RID: 3388 RVA: 0x00038A48 File Offset: 0x00036C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121543, XrefRangeEnd = 121546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TriggerEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventTrigger.TriggerEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventTrigger.TriggerEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D3D RID: 3389 RVA: 0x00007048 File Offset: 0x00005248
			public TriggerEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000A53 RID: 2643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000C6 RID: 198
		[Serializable]
		public class Entry : Object
		{
			// Token: 0x06000D3E RID: 3390 RVA: 0x00038A84 File Offset: 0x00036C84
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<EventTrigger.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventTrigger>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventTrigger.Entry>.NativeClassPtr);
				EventTrigger.Entry.NativeFieldInfoPtr_eventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTrigger.Entry>.NativeClassPtr, "eventID");
				EventTrigger.Entry.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTrigger.Entry>.NativeClassPtr, "callback");
				EventTrigger.Entry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTrigger.Entry>.NativeClassPtr, 100665131);
			}

			// Token: 0x06000D3F RID: 3391 RVA: 0x00038AEC File Offset: 0x00036CEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121546, XrefRangeEnd = 121553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventTrigger.Entry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventTrigger.Entry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D40 RID: 3392 RVA: 0x00007051 File Offset: 0x00005251
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000458 RID: 1112
			// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00038B28 File Offset: 0x00036D28
			// (set) Token: 0x06000D42 RID: 3394 RVA: 0x0000705A File Offset: 0x0000525A
			public unsafe EventTriggerType eventID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTrigger.Entry.NativeFieldInfoPtr_eventID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTrigger.Entry.NativeFieldInfoPtr_eventID)) = value;
				}
			}

			// Token: 0x17000459 RID: 1113
			// (get) Token: 0x06000D43 RID: 3395 RVA: 0x00038B50 File Offset: 0x00036D50
			// (set) Token: 0x06000D44 RID: 3396 RVA: 0x00007075 File Offset: 0x00005275
			public unsafe EventTrigger.TriggerEvent callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTrigger.Entry.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger.TriggerEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTrigger.Entry.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A54 RID: 2644
			private static readonly IntPtr NativeFieldInfoPtr_eventID;

			// Token: 0x04000A55 RID: 2645
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04000A56 RID: 2646
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
