using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005A RID: 90
	public class EventBase : Object
	{
		// Token: 0x06000571 RID: 1393 RVA: 0x0001CB54 File Offset: 0x0001AD54
		// Note: this type is marked as 'beforefieldinit'.
		static EventBase()
		{
			Il2CppClassPointerStore<EventBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventBase>.NativeClassPtr);
			EventBase.NativeFieldInfoPtr_s_LastTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "s_LastTypeId");
			EventBase.NativeFieldInfoPtr_s_NextEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "s_NextEventId");
			EventBase.NativeFieldInfoPtr__timestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<timestamp>k__BackingField");
			EventBase.NativeFieldInfoPtr__eventId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<eventId>k__BackingField");
			EventBase.NativeFieldInfoPtr__triggerEventId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<triggerEventId>k__BackingField");
			EventBase.NativeFieldInfoPtr__propagation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<propagation>k__BackingField");
			EventBase.NativeFieldInfoPtr_m_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "m_Path");
			EventBase.NativeFieldInfoPtr__lifeCycleStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<lifeCycleStatus>k__BackingField");
			EventBase.NativeFieldInfoPtr__leafTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<leafTarget>k__BackingField");
			EventBase.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "m_Target");
			EventBase.NativeFieldInfoPtr__skipElements_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<skipElements>k__BackingField");
			EventBase.NativeFieldInfoPtr__propagationPhase_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<propagationPhase>k__BackingField");
			EventBase.NativeFieldInfoPtr_m_CurrentTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "m_CurrentTarget");
			EventBase.NativeFieldInfoPtr_m_ImguiEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "m_ImguiEvent");
			EventBase.NativeFieldInfoPtr__originalMousePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<originalMousePosition>k__BackingField");
			EventBase.NativeMethodInfoPtr_RegisterEventType_Protected_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663718);
			EventBase.NativeMethodInfoPtr_get_eventTypeId_Public_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663719);
			EventBase.NativeMethodInfoPtr_get_timestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663720);
			EventBase.NativeMethodInfoPtr_set_timestamp_Private_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663721);
			EventBase.NativeMethodInfoPtr_get_eventId_Internal_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663722);
			EventBase.NativeMethodInfoPtr_set_eventId_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663723);
			EventBase.NativeMethodInfoPtr_set_triggerEventId_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663724);
			EventBase.NativeMethodInfoPtr_SetTriggerEventId_Internal_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663725);
			EventBase.NativeMethodInfoPtr_get_propagation_Internal_get_EventPropagation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663726);
			EventBase.NativeMethodInfoPtr_set_propagation_Internal_set_Void_EventPropagation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663727);
			EventBase.NativeMethodInfoPtr_get_path_Internal_get_PropagationPaths_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663728);
			EventBase.NativeMethodInfoPtr_set_path_Internal_set_Void_PropagationPaths_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663729);
			EventBase.NativeMethodInfoPtr_get_lifeCycleStatus_Private_get_LifeCycleStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663730);
			EventBase.NativeMethodInfoPtr_set_lifeCycleStatus_Private_set_Void_LifeCycleStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663731);
			EventBase.NativeMethodInfoPtr_PreDispatch_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663732);
			EventBase.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_New_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663733);
			EventBase.NativeMethodInfoPtr_PostDispatch_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663734);
			EventBase.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_New_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663735);
			EventBase.NativeMethodInfoPtr_get_bubbles_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663736);
			EventBase.NativeMethodInfoPtr_get_tricklesDown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663737);
			EventBase.NativeMethodInfoPtr_get_leafTarget_Internal_get_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663738);
			EventBase.NativeMethodInfoPtr_set_leafTarget_Private_set_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663739);
			EventBase.NativeMethodInfoPtr_get_target_Public_get_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663740);
			EventBase.NativeMethodInfoPtr_set_target_Public_set_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663741);
			EventBase.NativeMethodInfoPtr_get_skipElements_Internal_get_List_1_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663742);
			EventBase.NativeMethodInfoPtr_Skip_Internal_Boolean_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663743);
			EventBase.NativeMethodInfoPtr_get_isPropagationStopped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663744);
			EventBase.NativeMethodInfoPtr_set_isPropagationStopped_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663745);
			EventBase.NativeMethodInfoPtr_StopPropagation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663746);
			EventBase.NativeMethodInfoPtr_get_isImmediatePropagationStopped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663747);
			EventBase.NativeMethodInfoPtr_set_isImmediatePropagationStopped_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663748);
			EventBase.NativeMethodInfoPtr_StopImmediatePropagation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663749);
			EventBase.NativeMethodInfoPtr_get_isDefaultPrevented_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663750);
			EventBase.NativeMethodInfoPtr_set_isDefaultPrevented_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663751);
			EventBase.NativeMethodInfoPtr_PreventDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663752);
			EventBase.NativeMethodInfoPtr_get_propagationPhase_Public_get_PropagationPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663753);
			EventBase.NativeMethodInfoPtr_set_propagationPhase_Internal_set_Void_PropagationPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663754);
			EventBase.NativeMethodInfoPtr_get_currentTarget_Public_Virtual_New_get_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663755);
			EventBase.NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_New_set_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663756);
			EventBase.NativeMethodInfoPtr_get_dispatch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663757);
			EventBase.NativeMethodInfoPtr_set_dispatch_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663758);
			EventBase.NativeMethodInfoPtr_MarkReceivedByDispatcher_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663759);
			EventBase.NativeMethodInfoPtr_get_dispatched_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663760);
			EventBase.NativeMethodInfoPtr_set_dispatched_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663761);
			EventBase.NativeMethodInfoPtr_get_processed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663762);
			EventBase.NativeMethodInfoPtr_set_processed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663763);
			EventBase.NativeMethodInfoPtr_get_processedByFocusController_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663764);
			EventBase.NativeMethodInfoPtr_set_processedByFocusController_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663765);
			EventBase.NativeMethodInfoPtr_get_stopDispatch_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663766);
			EventBase.NativeMethodInfoPtr_set_stopDispatch_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663767);
			EventBase.NativeMethodInfoPtr_get_propagateToIMGUI_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663768);
			EventBase.NativeMethodInfoPtr_set_propagateToIMGUI_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663769);
			EventBase.NativeMethodInfoPtr_get_imguiEventIsValid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663770);
			EventBase.NativeMethodInfoPtr_set_imguiEventIsValid_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663771);
			EventBase.NativeMethodInfoPtr_get_imguiEvent_Public_get_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663772);
			EventBase.NativeMethodInfoPtr_set_imguiEvent_Protected_set_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663773);
			EventBase.NativeMethodInfoPtr_get_originalMousePosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663774);
			EventBase.NativeMethodInfoPtr_set_originalMousePosition_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663775);
			EventBase.NativeMethodInfoPtr_Init_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663776);
			EventBase.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663777);
			EventBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663778);
			EventBase.NativeMethodInfoPtr_get_pooled_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663779);
			EventBase.NativeMethodInfoPtr_set_pooled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663780);
			EventBase.NativeMethodInfoPtr_Acquire_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663781);
			EventBase.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100663782);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0001D1C4 File Offset: 0x0001B3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93895, XrefRangeEnd = 93899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long RegisterEventType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_RegisterEventType_Protected_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0001D1F4 File Offset: 0x0001B3F4
		public unsafe virtual long eventTypeId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_get_eventTypeId_Public_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x0001D23C File Offset: 0x0001B43C
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x0001D278 File Offset: 0x0001B478
		public unsafe long timestamp
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_timestamp_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_timestamp_Private_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0001D2B8 File Offset: 0x0001B4B8
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x0001D2F4 File Offset: 0x0001B4F4
		public unsafe ulong eventId
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_eventId_Internal_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_eventId_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x00004B5C File Offset: 0x00002D5C
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x0001D334 File Offset: 0x0001B534
		public unsafe ulong triggerEventId
		{
			get
			{
				return this._triggerEventId_k__BackingField;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_triggerEventId_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0001D374 File Offset: 0x0001B574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriggerEventId(ulong id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_SetTriggerEventId_Internal_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0001D3B4 File Offset: 0x0001B5B4
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x0001D3F0 File Offset: 0x0001B5F0
		public unsafe EventBase.EventPropagation propagation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_propagation_Internal_get_EventPropagation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12782, RefRangeEnd = 12783, XrefRangeStart = 12782, XrefRangeEnd = 12783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_propagation_Internal_set_Void_EventPropagation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x0001D430 File Offset: 0x0001B630
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x0001D470 File Offset: 0x0001B670
		public unsafe PropagationPaths path
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 93906, RefRangeEnd = 93917, XrefRangeStart = 93899, XrefRangeEnd = 93906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_path_Internal_get_PropagationPaths_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropagationPaths>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93935, RefRangeEnd = 93936, XrefRangeStart = 93917, XrefRangeEnd = 93935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_path_Internal_set_Void_PropagationPaths_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x0001D4B4 File Offset: 0x0001B6B4
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
		public unsafe EventBase.LifeCycleStatus lifeCycleStatus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_lifeCycleStatus_Private_get_LifeCycleStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_lifeCycleStatus_Private_set_Void_LifeCycleStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0001D530 File Offset: 0x0001B730
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PreDispatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_PreDispatch_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0001D56C File Offset: 0x0001B76C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15010, RefRangeEnd = 15012, XrefRangeStart = 15010, XrefRangeEnd = 15012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PreDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_New_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0001D5BC File Offset: 0x0001B7BC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostDispatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_PostDispatch_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0001D5F8 File Offset: 0x0001B7F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93936, RefRangeEnd = 93938, XrefRangeStart = 93936, XrefRangeEnd = 93936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_New_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x0001D648 File Offset: 0x0001B848
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x0001E428 File Offset: 0x0001C628
		public unsafe bool bubbles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_bubbles_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				if (value)
				{
					this.propagation |= EventBase.EventPropagation.Bubbles;
				}
				else
				{
					this.propagation &= ~EventBase.EventPropagation.Bubbles;
				}
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0001D684 File Offset: 0x0001B884
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x0001E460 File Offset: 0x0001C660
		public unsafe bool tricklesDown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_tricklesDown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				if (value)
				{
					this.propagation |= EventBase.EventPropagation.TricklesDown;
				}
				else
				{
					this.propagation &= ~EventBase.EventPropagation.TricklesDown;
				}
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x0001D6C0 File Offset: 0x0001B8C0
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x0001D700 File Offset: 0x0001B900
		public unsafe IEventHandler leafTarget
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_leafTarget_Internal_get_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_leafTarget_Private_set_Void_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0001D744 File Offset: 0x0001B944
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x0001D784 File Offset: 0x0001B984
		public unsafe IEventHandler target
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86604, RefRangeEnd = 86605, XrefRangeStart = 86604, XrefRangeEnd = 86605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_target_Public_get_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 93938, RefRangeEnd = 93947, XrefRangeStart = 93938, XrefRangeEnd = 93938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_target_Public_set_Void_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x0001D7C8 File Offset: 0x0001B9C8
		public unsafe List<IEventHandler> skipElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_skipElements_Internal_get_List_1_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IEventHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0001D808 File Offset: 0x0001BA08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93951, RefRangeEnd = 93953, XrefRangeStart = 93947, XrefRangeEnd = 93951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Skip(IEventHandler h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(h);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_Skip_Internal_Boolean_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x0001D858 File Offset: 0x0001BA58
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x0001D894 File Offset: 0x0001BA94
		public unsafe bool isPropagationStopped
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 93953, RefRangeEnd = 93968, XrefRangeStart = 93953, XrefRangeEnd = 93953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_isPropagationStopped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_isPropagationStopped_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0001D8D4 File Offset: 0x0001BAD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93968, RefRangeEnd = 93969, XrefRangeStart = 93968, XrefRangeEnd = 93968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopPropagation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_StopPropagation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0001D908 File Offset: 0x0001BB08
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0001D944 File Offset: 0x0001BB44
		public unsafe bool isImmediatePropagationStopped
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93969, RefRangeEnd = 93970, XrefRangeStart = 93969, XrefRangeEnd = 93969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_isImmediatePropagationStopped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_isImmediatePropagationStopped_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0001D984 File Offset: 0x0001BB84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93970, RefRangeEnd = 93971, XrefRangeStart = 93970, XrefRangeEnd = 93970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopImmediatePropagation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_StopImmediatePropagation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0001D9B8 File Offset: 0x0001BBB8
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x0001D9F4 File Offset: 0x0001BBF4
		public unsafe bool isDefaultPrevented
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93971, RefRangeEnd = 93972, XrefRangeStart = 93971, XrefRangeEnd = 93971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_isDefaultPrevented_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_isDefaultPrevented_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0001DA34 File Offset: 0x0001BC34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93972, RefRangeEnd = 93973, XrefRangeStart = 93972, XrefRangeEnd = 93972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreventDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_PreventDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0001DA68 File Offset: 0x0001BC68
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0001DAA4 File Offset: 0x0001BCA4
		public unsafe PropagationPhase propagationPhase
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24292, RefRangeEnd = 24293, XrefRangeStart = 24292, XrefRangeEnd = 24293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_propagationPhase_Public_get_PropagationPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_propagationPhase_Internal_set_Void_PropagationPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0001DAE4 File Offset: 0x0001BCE4
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x0001DB30 File Offset: 0x0001BD30
		public unsafe virtual IEventHandler currentTarget
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86610, RefRangeEnd = 86612, XrefRangeStart = 86610, XrefRangeEnd = 86612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_get_currentTarget_Public_Virtual_New_get_IEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 93977, RefRangeEnd = 93979, XrefRangeStart = 93973, XrefRangeEnd = 93977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_New_set_Void_IEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0001DB80 File Offset: 0x0001BD80
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x0001DBBC File Offset: 0x0001BDBC
		public unsafe bool dispatch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_dispatch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_dispatch_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0001DBFC File Offset: 0x0001BDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93979, XrefRangeEnd = 93985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkReceivedByDispatcher()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_MarkReceivedByDispatcher_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0001DC30 File Offset: 0x0001BE30
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x0001DC6C File Offset: 0x0001BE6C
		public unsafe bool dispatched
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_dispatched_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_dispatched_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0001DCAC File Offset: 0x0001BEAC
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x0001DCE8 File Offset: 0x0001BEE8
		public unsafe bool processed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93985, RefRangeEnd = 93986, XrefRangeStart = 93985, XrefRangeEnd = 93985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_processed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_processed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0001DD28 File Offset: 0x0001BF28
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x0001DD64 File Offset: 0x0001BF64
		public unsafe bool processedByFocusController
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 93986, RefRangeEnd = 93988, XrefRangeStart = 93986, XrefRangeEnd = 93986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_processedByFocusController_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93988, RefRangeEnd = 93989, XrefRangeStart = 93988, XrefRangeEnd = 93988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_processedByFocusController_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0001DDA4 File Offset: 0x0001BFA4
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x0001DDE0 File Offset: 0x0001BFE0
		public unsafe bool stopDispatch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_stopDispatch_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_stopDispatch_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0001DE20 File Offset: 0x0001C020
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x0001DE5C File Offset: 0x0001C05C
		public unsafe bool propagateToIMGUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_propagateToIMGUI_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 93989, RefRangeEnd = 93991, XrefRangeStart = 93989, XrefRangeEnd = 93989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_propagateToIMGUI_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0001DE9C File Offset: 0x0001C09C
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x0001DED8 File Offset: 0x0001C0D8
		public unsafe bool imguiEventIsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_imguiEventIsValid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_imguiEventIsValid_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0001DF18 File Offset: 0x0001C118
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x0001DF58 File Offset: 0x0001C158
		public unsafe Event imguiEvent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93991, RefRangeEnd = 93992, XrefRangeStart = 93991, XrefRangeEnd = 93991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_imguiEvent_Public_get_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 93996, RefRangeEnd = 94003, XrefRangeStart = 93992, XrefRangeEnd = 93996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_imguiEvent_Protected_set_Void_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0001DF9C File Offset: 0x0001C19C
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x0001DFD8 File Offset: 0x0001C1D8
		public unsafe Vector2 originalMousePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_originalMousePosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_originalMousePosition_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0001E018 File Offset: 0x0001C218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94004, RefRangeEnd = 94005, XrefRangeStart = 94003, XrefRangeEnd = 94004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_Init_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0001E054 File Offset: 0x0001C254
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 94043, RefRangeEnd = 94045, XrefRangeStart = 94005, XrefRangeEnd = 94043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0001E088 File Offset: 0x0001C288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94053, RefRangeEnd = 94054, XrefRangeStart = 94045, XrefRangeEnd = 94053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0001E0C4 File Offset: 0x0001C2C4
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x0001E100 File Offset: 0x0001C300
		public unsafe bool pooled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 94054, RefRangeEnd = 94055, XrefRangeStart = 94054, XrefRangeEnd = 94054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_pooled_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 94055, RefRangeEnd = 94057, XrefRangeStart = 94055, XrefRangeEnd = 94055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_pooled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0001E140 File Offset: 0x0001C340
		[CallerCount(0)]
		public unsafe virtual void Acquire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_Acquire_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0001E17C File Offset: 0x0001C37C
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000049C0 File Offset: 0x00002BC0
		public EventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0001E1B8 File Offset: 0x0001C3B8
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x000049C9 File Offset: 0x00002BC9
		public unsafe static long s_LastTypeId
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(EventBase.NativeFieldInfoPtr_s_LastTypeId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventBase.NativeFieldInfoPtr_s_LastTypeId, (void*)(&value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x0001E1D4 File Offset: 0x0001C3D4
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x000049D7 File Offset: 0x00002BD7
		public unsafe static ulong s_NextEventId
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(EventBase.NativeFieldInfoPtr_s_NextEventId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventBase.NativeFieldInfoPtr_s_NextEventId, (void*)(&value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0001E1F0 File Offset: 0x0001C3F0
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x000049E5 File Offset: 0x00002BE5
		public unsafe long _timestamp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__timestamp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__timestamp_k__BackingField)) = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x0001E218 File Offset: 0x0001C418
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x00004A00 File Offset: 0x00002C00
		public unsafe ulong _eventId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__eventId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__eventId_k__BackingField)) = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x0001E240 File Offset: 0x0001C440
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x00004A1B File Offset: 0x00002C1B
		public unsafe ulong _triggerEventId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__triggerEventId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__triggerEventId_k__BackingField)) = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x0001E268 File Offset: 0x0001C468
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x00004A36 File Offset: 0x00002C36
		public unsafe EventBase.EventPropagation _propagation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__propagation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__propagation_k__BackingField)) = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0001E290 File Offset: 0x0001C490
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00004A51 File Offset: 0x00002C51
		public unsafe PropagationPaths m_Path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr_m_Path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropagationPaths>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr_m_Path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0001E2C0 File Offset: 0x0001C4C0
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00004A70 File Offset: 0x00002C70
		public unsafe EventBase.LifeCycleStatus _lifeCycleStatus_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__lifeCycleStatus_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__lifeCycleStatus_k__BackingField)) = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0001E2E8 File Offset: 0x0001C4E8
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x00004A8B File Offset: 0x00002C8B
		public unsafe IEventHandler _leafTarget_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__leafTarget_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__leafTarget_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0001E318 File Offset: 0x0001C518
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x00004AAA File Offset: 0x00002CAA
		public unsafe IEventHandler m_Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr_m_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0001E348 File Offset: 0x0001C548
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x00004AC9 File Offset: 0x00002CC9
		public unsafe List<IEventHandler> _skipElements_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__skipElements_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IEventHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__skipElements_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x0001E378 File Offset: 0x0001C578
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x00004AE8 File Offset: 0x00002CE8
		public unsafe PropagationPhase _propagationPhase_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__propagationPhase_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__propagationPhase_k__BackingField)) = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0001E3A0 File Offset: 0x0001C5A0
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x00004B03 File Offset: 0x00002D03
		public unsafe IEventHandler m_CurrentTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr_m_CurrentTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr_m_CurrentTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x0001E3D0 File Offset: 0x0001C5D0
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x00004B22 File Offset: 0x00002D22
		public unsafe Event m_ImguiEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr_m_ImguiEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr_m_ImguiEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0001E400 File Offset: 0x0001C600
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x00004B41 File Offset: 0x00002D41
		public unsafe Vector2 _originalMousePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__originalMousePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__originalMousePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr_s_LastTypeId;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr_s_NextEventId;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr__timestamp_k__BackingField;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr__eventId_k__BackingField;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr__triggerEventId_k__BackingField;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr__propagation_k__BackingField;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeFieldInfoPtr_m_Path;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr__lifeCycleStatus_k__BackingField;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr__leafTarget_k__BackingField;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr__skipElements_k__BackingField;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr__propagationPhase_k__BackingField;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentTarget;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_m_ImguiEvent;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr__originalMousePosition_k__BackingField;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEventType_Protected_Static_Int64_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_get_eventTypeId_Public_Virtual_New_get_Int64_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_get_timestamp_Public_get_Int64_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_set_timestamp_Private_set_Void_Int64_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_get_eventId_Internal_get_UInt64_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_set_eventId_Private_set_Void_UInt64_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_set_triggerEventId_Private_set_Void_UInt64_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_SetTriggerEventId_Internal_Void_UInt64_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_get_propagation_Internal_get_EventPropagation_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_set_propagation_Internal_set_Void_EventPropagation_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_get_path_Internal_get_PropagationPaths_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_set_path_Internal_set_Void_PropagationPaths_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_get_lifeCycleStatus_Private_get_LifeCycleStatus_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_set_lifeCycleStatus_Private_set_Void_LifeCycleStatus_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_PreDispatch_Protected_Virtual_New_Void_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_New_Void_IPanel_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_Protected_Virtual_New_Void_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_New_Void_IPanel_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_get_bubbles_Public_get_Boolean_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_get_tricklesDown_Public_get_Boolean_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_get_leafTarget_Internal_get_IEventHandler_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_set_leafTarget_Private_set_Void_IEventHandler_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_get_target_Public_get_IEventHandler_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_set_target_Public_set_Void_IEventHandler_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_get_skipElements_Internal_get_List_1_IEventHandler_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_Skip_Internal_Boolean_IEventHandler_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_get_isPropagationStopped_Public_get_Boolean_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_set_isPropagationStopped_Private_set_Void_Boolean_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_StopPropagation_Public_Void_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_get_isImmediatePropagationStopped_Public_get_Boolean_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_set_isImmediatePropagationStopped_Private_set_Void_Boolean_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_StopImmediatePropagation_Public_Void_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_get_isDefaultPrevented_Public_get_Boolean_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_set_isDefaultPrevented_Private_set_Void_Boolean_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_PreventDefault_Public_Void_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_get_propagationPhase_Public_get_PropagationPhase_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_set_propagationPhase_Internal_set_Void_PropagationPhase_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_get_currentTarget_Public_Virtual_New_get_IEventHandler_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_New_set_Void_IEventHandler_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_get_dispatch_Public_get_Boolean_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_set_dispatch_Internal_set_Void_Boolean_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_MarkReceivedByDispatcher_Internal_Void_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_get_dispatched_Private_get_Boolean_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_set_dispatched_Private_set_Void_Boolean_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_get_processed_Internal_get_Boolean_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_set_processed_Private_set_Void_Boolean_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_get_processedByFocusController_Internal_get_Boolean_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_set_processedByFocusController_Internal_set_Void_Boolean_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_get_stopDispatch_Internal_get_Boolean_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_set_stopDispatch_Internal_set_Void_Boolean_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_get_propagateToIMGUI_Internal_get_Boolean_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_set_propagateToIMGUI_Internal_set_Void_Boolean_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_get_imguiEventIsValid_Private_get_Boolean_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_set_imguiEventIsValid_Private_set_Void_Boolean_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_get_imguiEvent_Public_get_Event_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_set_imguiEvent_Protected_set_Void_Event_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_get_originalMousePosition_Public_get_Vector2_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_set_originalMousePosition_Private_set_Void_Vector2_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_New_Void_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_get_pooled_Protected_get_Boolean_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_set_pooled_Protected_set_Void_Boolean_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0200020E RID: 526
		[Flags]
		public enum EventPropagation
		{
			// Token: 0x040008A1 RID: 2209
			None = 0,
			// Token: 0x040008A2 RID: 2210
			Bubbles = 1,
			// Token: 0x040008A3 RID: 2211
			TricklesDown = 2,
			// Token: 0x040008A4 RID: 2212
			Cancellable = 4
		}

		// Token: 0x0200020F RID: 527
		[Flags]
		public enum LifeCycleStatus
		{
			// Token: 0x040008A6 RID: 2214
			None = 0,
			// Token: 0x040008A7 RID: 2215
			PropagationStopped = 1,
			// Token: 0x040008A8 RID: 2216
			ImmediatePropagationStopped = 2,
			// Token: 0x040008A9 RID: 2217
			DefaultPrevented = 4,
			// Token: 0x040008AA RID: 2218
			Dispatching = 8,
			// Token: 0x040008AB RID: 2219
			Pooled = 16,
			// Token: 0x040008AC RID: 2220
			IMGUIEventIsValid = 32,
			// Token: 0x040008AD RID: 2221
			StopDispatch = 64,
			// Token: 0x040008AE RID: 2222
			PropagateToIMGUI = 128,
			// Token: 0x040008AF RID: 2223
			Dispatched = 512,
			// Token: 0x040008B0 RID: 2224
			Processed = 1024,
			// Token: 0x040008B1 RID: 2225
			ProcessedByFocusController = 2048
		}
	}
}
