using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000021 RID: 33
	public class Panel : BaseVisualElementPanel
	{
		// Token: 0x060001CE RID: 462 RVA: 0x000120C8 File Offset: 0x000102C8
		// Note: this type is marked as 'beforefieldinit'.
		static Panel()
		{
			Il2CppClassPointerStore<Panel>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Panel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Panel>.NativeClassPtr);
			Panel.NativeFieldInfoPtr_m_RootContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_RootContainer");
			Panel.NativeFieldInfoPtr_m_VisualTreeUpdater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_VisualTreeUpdater");
			Panel.NativeFieldInfoPtr_m_PanelName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_PanelName");
			Panel.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_Version");
			Panel.NativeFieldInfoPtr_m_RepaintVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_RepaintVersion");
			Panel.NativeFieldInfoPtr_m_HierarchyVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_HierarchyVersion");
			Panel.NativeFieldInfoPtr_m_MarkerBeforeUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_MarkerBeforeUpdate");
			Panel.NativeFieldInfoPtr_m_MarkerUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_MarkerUpdate");
			Panel.NativeFieldInfoPtr_m_MarkerLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_MarkerLayout");
			Panel.NativeFieldInfoPtr_m_MarkerBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_MarkerBindings");
			Panel.NativeFieldInfoPtr_m_MarkerAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_MarkerAnimations");
			Panel.NativeFieldInfoPtr_s_MarkerPickAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "s_MarkerPickAll");
			Panel.NativeFieldInfoPtr__dispatcher_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<dispatcher>k__BackingField");
			Panel.NativeFieldInfoPtr_m_Scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_Scheduler");
			Panel.NativeFieldInfoPtr__ownerObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<ownerObject>k__BackingField");
			Panel.NativeFieldInfoPtr__contextType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<contextType>k__BackingField");
			Panel.NativeFieldInfoPtr__saveViewData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<saveViewData>k__BackingField");
			Panel.NativeFieldInfoPtr__getViewDataDictionary_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<getViewDataDictionary>k__BackingField");
			Panel.NativeFieldInfoPtr__focusController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<focusController>k__BackingField");
			Panel.NativeFieldInfoPtr__IMGUIEventInterests_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<IMGUIEventInterests>k__BackingField");
			Panel.NativeFieldInfoPtr__loadResourceFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<loadResourceFunc>k__BackingField");
			Panel.NativeFieldInfoPtr__TimeSinceStartup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<TimeSinceStartup>k__BackingField");
			Panel.NativeFieldInfoPtr__IMGUIContainersCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<IMGUIContainersCount>k__BackingField");
			Panel.NativeFieldInfoPtr__rootIMGUIContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<rootIMGUIContainer>k__BackingField");
			Panel.NativeFieldInfoPtr_m_StandardShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_StandardShader");
			Panel.NativeFieldInfoPtr_m_Atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_Atlas");
			Panel.NativeFieldInfoPtr_m_ValidatingLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_ValidatingLayout");
			Panel.NativeFieldInfoPtr_beforeAnyRepaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "beforeAnyRepaint");
			Panel.NativeMethodInfoPtr_get_visualTree_Public_Virtual_Final_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663447);
			Panel.NativeMethodInfoPtr_get_dispatcher_Public_Virtual_Final_get_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663448);
			Panel.NativeMethodInfoPtr_get_timerEventScheduler_Public_get_TimerEventScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663449);
			Panel.NativeMethodInfoPtr_get_scheduler_Internal_Virtual_get_IScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663450);
			Panel.NativeMethodInfoPtr_get_ownerObject_Public_Virtual_get_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663451);
			Panel.NativeMethodInfoPtr_get_contextType_Public_Virtual_get_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663452);
			Panel.NativeMethodInfoPtr_get_focusController_Public_Virtual_Final_get_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663453);
			Panel.NativeMethodInfoPtr_get_IMGUIEventInterests_Public_Virtual_get_EventInterests_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663454);
			Panel.NativeMethodInfoPtr_Focus_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663455);
			Panel.NativeMethodInfoPtr_Blur_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663456);
			Panel.NativeMethodInfoPtr_get_name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663457);
			Panel.NativeMethodInfoPtr_get_TimeSinceStartup_Private_Static_get_TimeMsFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663458);
			Panel.NativeMethodInfoPtr_get_IMGUIContainersCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663459);
			Panel.NativeMethodInfoPtr_get_rootIMGUIContainer_Public_Virtual_get_IMGUIContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663460);
			Panel.NativeMethodInfoPtr_get_version_Internal_Virtual_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663461);
			Panel.NativeMethodInfoPtr_TimeSinceStartupMs_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663462);
			Panel.NativeMethodInfoPtr_DefaultTimeSinceStartupMs_Internal_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663463);
			Panel.NativeMethodInfoPtr_PickAll_Private_Static_VisualElement_VisualElement_Vector2_List_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663464);
			Panel.NativeMethodInfoPtr_PerformPick_Private_Static_VisualElement_VisualElement_Vector2_List_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663465);
			Panel.NativeMethodInfoPtr_Pick_Public_Virtual_VisualElement_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663466);
			Panel.NativeMethodInfoPtr_ValidateLayout_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663467);
			Panel.NativeMethodInfoPtr_UpdateForRepaint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663468);
			Panel.NativeMethodInfoPtr_Repaint_Public_Virtual_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663469);
			Panel.NativeMethodInfoPtr_OnVersionChanged_Internal_Virtual_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100663470);
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00012508 File Offset: 0x00010708
		public unsafe override VisualElement visualTree
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_get_visualTree_Public_Virtual_Final_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00012548 File Offset: 0x00010748
		// (set) Token: 0x06000220 RID: 544 RVA: 0x0000316D File Offset: 0x0000136D
		public unsafe sealed override EventDispatcher dispatcher
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_get_dispatcher_Public_Virtual_Final_get_EventDispatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr3) : null;
			}
			set
			{
				this._dispatcher_k__BackingField = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00012588 File Offset: 0x00010788
		public unsafe TimerEventScheduler timerEventScheduler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91951, XrefRangeEnd = 91955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_get_timerEventScheduler_Public_get_TimerEventScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerEventScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x000125C8 File Offset: 0x000107C8
		public unsafe override IScheduler scheduler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_scheduler_Internal_Virtual_get_IScheduler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00012614 File Offset: 0x00010814
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00003176 File Offset: 0x00001376
		public unsafe override ScriptableObject ownerObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_ownerObject_Public_Virtual_get_ScriptableObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
			}
			set
			{
				this._ownerObject_k__BackingField = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00012660 File Offset: 0x00010860
		// (set) Token: 0x06000222 RID: 546 RVA: 0x0000317F File Offset: 0x0000137F
		public unsafe override ContextType contextType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_contextType_Public_Virtual_get_ContextType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._contextType_k__BackingField = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x000126A8 File Offset: 0x000108A8
		// (set) Token: 0x06000227 RID: 551 RVA: 0x000031AA File Offset: 0x000013AA
		public unsafe sealed override FocusController focusController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_get_focusController_Public_Virtual_Final_get_FocusController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr3) : null;
			}
			set
			{
				this._focusController_k__BackingField = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000126E8 File Offset: 0x000108E8
		// (set) Token: 0x06000228 RID: 552 RVA: 0x000031B3 File Offset: 0x000013B3
		public unsafe override EventInterests IMGUIEventInterests
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_IMGUIEventInterests_Public_Virtual_get_EventInterests_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._IMGUIEventInterests_k__BackingField = value;
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00012730 File Offset: 0x00010930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91957, RefRangeEnd = 91958, XrefRangeStart = 91955, XrefRangeEnd = 91957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Focus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_Focus_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00012764 File Offset: 0x00010964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91960, RefRangeEnd = 91961, XrefRangeStart = 91958, XrefRangeEnd = 91960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blur()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_Blur_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00012798 File Offset: 0x00010998
		// (set) Token: 0x0600022C RID: 556 RVA: 0x000031CB File Offset: 0x000013CB
		public unsafe string name
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 86624, RefRangeEnd = 86628, XrefRangeStart = 86624, XrefRangeEnd = 86628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_get_name_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this.m_PanelName = value;
				this.CreateMarkers();
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000127D0 File Offset: 0x000109D0
		// (set) Token: 0x0600022E RID: 558 RVA: 0x000031DC File Offset: 0x000013DC
		public unsafe static TimeMsFunction TimeSinceStartup
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91961, XrefRangeEnd = 91965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_get_TimeSinceStartup_Private_Static_get_TimeMsFunction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeMsFunction>(intPtr3) : null;
			}
			set
			{
				Panel._TimeSinceStartup_k__BackingField = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00012804 File Offset: 0x00010A04
		// (set) Token: 0x0600022F RID: 559 RVA: 0x000031E4 File Offset: 0x000013E4
		public unsafe override int IMGUIContainersCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_IMGUIContainersCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._IMGUIContainersCount_k__BackingField = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0001284C File Offset: 0x00010A4C
		// (set) Token: 0x06000230 RID: 560 RVA: 0x000031ED File Offset: 0x000013ED
		public unsafe override IMGUIContainer rootIMGUIContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_rootIMGUIContainer_Public_Virtual_get_IMGUIContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMGUIContainer>(intPtr3) : null;
			}
			set
			{
				this._rootIMGUIContainer_k__BackingField = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00012898 File Offset: 0x00010A98
		public unsafe override uint version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_version_Internal_Virtual_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000128E0 File Offset: 0x00010AE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 91974, RefRangeEnd = 91978, XrefRangeStart = 91965, XrefRangeEnd = 91974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long TimeSinceStartupMs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_TimeSinceStartupMs_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00012910 File Offset: 0x00010B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91978, XrefRangeEnd = 91979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long DefaultTimeSinceStartupMs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_DefaultTimeSinceStartupMs_Internal_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00012940 File Offset: 0x00010B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91979, XrefRangeEnd = 91983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(picked);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_PickAll_Private_Static_VisualElement_VisualElement_Vector2_List_1_VisualElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000129A4 File Offset: 0x00010BA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 92004, RefRangeEnd = 92007, XrefRangeStart = 91983, XrefRangeEnd = 92004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(picked);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_PerformPick_Private_Static_VisualElement_VisualElement_Vector2_List_1_VisualElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00012A08 File Offset: 0x00010C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92007, XrefRangeEnd = 92020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override VisualElement Pick(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_Pick_Public_Virtual_VisualElement_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00012A60 File Offset: 0x00010C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92020, XrefRangeEnd = 92023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ValidateLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_ValidateLayout_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00012A9C File Offset: 0x00010C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92023, XrefRangeEnd = 92029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateForRepaint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_UpdateForRepaint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00012AD0 File Offset: 0x00010CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92029, XrefRangeEnd = 92064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Repaint(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_Repaint_Public_Virtual_Void_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00012B20 File Offset: 0x00010D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92064, XrefRangeEnd = 92065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref versionChangeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_OnVersionChanged_Internal_Virtual_Void_VisualElement_VersionChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002E68 File Offset: 0x00001068
		public Panel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00012B7C File Offset: 0x00010D7C
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002E71 File Offset: 0x00001071
		public unsafe VisualElement m_RootContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_RootContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_RootContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00012BAC File Offset: 0x00010DAC
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00002E90 File Offset: 0x00001090
		public unsafe VisualTreeUpdater m_VisualTreeUpdater
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_VisualTreeUpdater);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeUpdater>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_VisualTreeUpdater), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00012BDC File Offset: 0x00010DDC
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00002EAF File Offset: 0x000010AF
		public unsafe string m_PanelName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_PanelName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_PanelName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00012C04 File Offset: 0x00010E04
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00002ECE File Offset: 0x000010CE
		public unsafe uint m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00012C2C File Offset: 0x00010E2C
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002EE9 File Offset: 0x000010E9
		public unsafe uint m_RepaintVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_RepaintVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_RepaintVersion)) = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00012C54 File Offset: 0x00010E54
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002F04 File Offset: 0x00001104
		public unsafe uint m_HierarchyVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_HierarchyVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_HierarchyVersion)) = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00012C7C File Offset: 0x00010E7C
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002F1F File Offset: 0x0000111F
		public unsafe ProfilerMarker m_MarkerBeforeUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerBeforeUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerBeforeUpdate)) = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00012CA4 File Offset: 0x00010EA4
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002F3A File Offset: 0x0000113A
		public unsafe ProfilerMarker m_MarkerUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerUpdate)) = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00012CCC File Offset: 0x00010ECC
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002F55 File Offset: 0x00001155
		public unsafe ProfilerMarker m_MarkerLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerLayout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerLayout)) = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00012CF4 File Offset: 0x00010EF4
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00002F70 File Offset: 0x00001170
		public unsafe ProfilerMarker m_MarkerBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerBindings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerBindings)) = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00012D1C File Offset: 0x00010F1C
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00002F8B File Offset: 0x0000118B
		public unsafe ProfilerMarker m_MarkerAnimations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerAnimations);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerAnimations)) = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00012D44 File Offset: 0x00010F44
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002FA6 File Offset: 0x000011A6
		public unsafe static ProfilerMarker s_MarkerPickAll
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(Panel.NativeFieldInfoPtr_s_MarkerPickAll, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Panel.NativeFieldInfoPtr_s_MarkerPickAll, (void*)(&value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00012D60 File Offset: 0x00010F60
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00002FB4 File Offset: 0x000011B4
		public unsafe EventDispatcher _dispatcher_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__dispatcher_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__dispatcher_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00012D90 File Offset: 0x00010F90
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002FD3 File Offset: 0x000011D3
		public unsafe TimerEventScheduler m_Scheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_Scheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerEventScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_Scheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00012DC0 File Offset: 0x00010FC0
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002FF2 File Offset: 0x000011F2
		public unsafe ScriptableObject _ownerObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__ownerObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__ownerObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00012DF0 File Offset: 0x00010FF0
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00003011 File Offset: 0x00001211
		public unsafe ContextType _contextType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__contextType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__contextType_k__BackingField)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00012E18 File Offset: 0x00011018
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0000302C File Offset: 0x0000122C
		public unsafe SavePersistentViewData _saveViewData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__saveViewData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SavePersistentViewData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__saveViewData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00012E48 File Offset: 0x00011048
		// (set) Token: 0x0600020B RID: 523 RVA: 0x0000304B File Offset: 0x0000124B
		public unsafe GetViewDataDictionary _getViewDataDictionary_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__getViewDataDictionary_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetViewDataDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__getViewDataDictionary_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00012E78 File Offset: 0x00011078
		// (set) Token: 0x0600020D RID: 525 RVA: 0x0000306A File Offset: 0x0000126A
		public unsafe FocusController _focusController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__focusController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__focusController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00012EA8 File Offset: 0x000110A8
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00003089 File Offset: 0x00001289
		public unsafe EventInterests _IMGUIEventInterests_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__IMGUIEventInterests_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__IMGUIEventInterests_k__BackingField)) = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00012ED0 File Offset: 0x000110D0
		// (set) Token: 0x06000211 RID: 529 RVA: 0x000030A4 File Offset: 0x000012A4
		public unsafe static LoadResourceFunction _loadResourceFunc_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Panel.NativeFieldInfoPtr__loadResourceFunc_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadResourceFunction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Panel.NativeFieldInfoPtr__loadResourceFunc_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00012EF8 File Offset: 0x000110F8
		// (set) Token: 0x06000213 RID: 531 RVA: 0x000030B6 File Offset: 0x000012B6
		public unsafe static TimeMsFunction _TimeSinceStartup_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Panel.NativeFieldInfoPtr__TimeSinceStartup_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeMsFunction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Panel.NativeFieldInfoPtr__TimeSinceStartup_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00012F20 File Offset: 0x00011120
		// (set) Token: 0x06000215 RID: 533 RVA: 0x000030C8 File Offset: 0x000012C8
		public unsafe int _IMGUIContainersCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__IMGUIContainersCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__IMGUIContainersCount_k__BackingField)) = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00012F48 File Offset: 0x00011148
		// (set) Token: 0x06000217 RID: 535 RVA: 0x000030E3 File Offset: 0x000012E3
		public unsafe IMGUIContainer _rootIMGUIContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__rootIMGUIContainer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMGUIContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__rootIMGUIContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00012F78 File Offset: 0x00011178
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00003102 File Offset: 0x00001302
		public unsafe Shader m_StandardShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_StandardShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_StandardShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00012FA8 File Offset: 0x000111A8
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00003121 File Offset: 0x00001321
		public unsafe AtlasBase m_Atlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_Atlas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtlasBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_Atlas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00012FD8 File Offset: 0x000111D8
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00003140 File Offset: 0x00001340
		public unsafe bool m_ValidatingLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_ValidatingLayout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_ValidatingLayout)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00013000 File Offset: 0x00011200
		// (set) Token: 0x0600021F RID: 543 RVA: 0x0000315B File Offset: 0x0000135B
		public unsafe static Action<Panel> beforeAnyRepaint
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Panel.NativeFieldInfoPtr_beforeAnyRepaint, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Panel>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Panel.NativeFieldInfoPtr_beforeAnyRepaint, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00003188 File Offset: 0x00001388
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00003190 File Offset: 0x00001390
		public override SavePersistentViewData saveViewData
		{
			get
			{
				return this._saveViewData_k__BackingField;
			}
			set
			{
				this._saveViewData_k__BackingField = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00003199 File Offset: 0x00001399
		// (set) Token: 0x06000226 RID: 550 RVA: 0x000031A1 File Offset: 0x000013A1
		public override GetViewDataDictionary getViewDataDictionary
		{
			get
			{
				return this._getViewDataDictionary_k__BackingField;
			}
			set
			{
				this._getViewDataDictionary_k__BackingField = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000229 RID: 553 RVA: 0x000031BC File Offset: 0x000013BC
		// (set) Token: 0x0600022A RID: 554 RVA: 0x000031C3 File Offset: 0x000013C3
		public static LoadResourceFunction loadResourceFunc
		{
			get
			{
				return Panel._loadResourceFunc_k__BackingField;
			}
			set
			{
				Panel._loadResourceFunc_k__BackingField = value;
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00013028 File Offset: 0x00011228
		public static Object LoadResource(string pathName, Type type, float dpiScaling)
		{
			bool flag = Panel.loadResourceFunc != null;
			Object @object;
			if (flag)
			{
				@object = Panel.loadResourceFunc.Invoke(pathName, type, dpiScaling);
			}
			else
			{
				@object = Resources.Load(pathName, type);
			}
			return @object;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00013068 File Offset: 0x00011268
		public void CreateMarkers()
		{
			bool flag = !String.IsNullOrEmpty(this.m_PanelName);
			if (flag)
			{
				this.m_MarkerBeforeUpdate = new ProfilerMarker(String.Concat("Panel.BeforeUpdate.", this.m_PanelName));
				this.m_MarkerUpdate = new ProfilerMarker(String.Concat("Panel.Update.", this.m_PanelName));
				this.m_MarkerLayout = new ProfilerMarker(String.Concat("Panel.Layout.", this.m_PanelName));
				this.m_MarkerBindings = new ProfilerMarker(String.Concat("Panel.Bindings.", this.m_PanelName));
				this.m_MarkerAnimations = new ProfilerMarker(String.Concat("Panel.Animations.", this.m_PanelName));
			}
			else
			{
				this.m_MarkerBeforeUpdate = new ProfilerMarker("Panel.BeforeUpdate");
				this.m_MarkerUpdate = new ProfilerMarker("Panel.Update");
				this.m_MarkerLayout = new ProfilerMarker("Panel.Layout");
				this.m_MarkerBindings = new ProfilerMarker("Panel.Bindings");
				this.m_MarkerAnimations = new ProfilerMarker("Panel.Animations");
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000231 RID: 561 RVA: 0x000031F6 File Offset: 0x000013F6
		public override uint repaintVersion
		{
			get
			{
				return this.m_RepaintVersion;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000232 RID: 562 RVA: 0x000031FE File Offset: 0x000013FE
		public override uint hierarchyVersion
		{
			get
			{
				return this.m_HierarchyVersion;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00013168 File Offset: 0x00011368
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00013180 File Offset: 0x00011380
		public override Shader standardShader
		{
			get
			{
				return this.m_StandardShader;
			}
			set
			{
				bool flag = this.m_StandardShader != value;
				if (flag)
				{
					this.m_StandardShader = value;
					base.InvokeStandardShaderChanged();
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000235 RID: 565 RVA: 0x000131B0 File Offset: 0x000113B0
		// (set) Token: 0x06000236 RID: 566 RVA: 0x000131C8 File Offset: 0x000113C8
		public override AtlasBase atlas
		{
			get
			{
				return this.m_Atlas;
			}
			set
			{
				bool flag = this.m_Atlas != value;
				if (flag)
				{
					AtlasBase atlas = this.m_Atlas;
					if (atlas != null)
					{
						atlas.InvokeRemovedFromPanel(this);
					}
					this.m_Atlas = value;
					base.InvokeAtlasChanged();
					AtlasBase atlas2 = this.m_Atlas;
					if (atlas2 != null)
					{
						atlas2.InvokeAssignedToPanel(this);
					}
				}
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0001321C File Offset: 0x0001141C
		public static Panel CreateEditorPanel(ScriptableObject ownerObject)
		{
			return new Panel(ownerObject, ContextType.Editor, EventDispatcher.CreateDefault());
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0001323C File Offset: 0x0001143C
		public override void Dispose(bool disposing)
		{
			bool disposed = base.disposed;
			if (!disposed)
			{
				if (disposing)
				{
					this.atlas = null;
					this.m_VisualTreeUpdater.Dispose();
				}
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0001327C File Offset: 0x0001147C
		public static VisualElement PickAllWithoutValidatingLayout(VisualElement root, Vector2 point)
		{
			return Panel.PickAll(root, point, null);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00013298 File Offset: 0x00011498
		public override VisualElement PickAll(Vector2 point, List<VisualElement> picked)
		{
			this.ValidateLayout();
			bool flag = picked != null;
			if (flag)
			{
				picked.Clear();
			}
			return Panel.PickAll(this.visualTree, point, picked);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00003206 File Offset: 0x00001406
		public override void UpdateAnimations()
		{
			this.m_VisualTreeUpdater.UpdateVisualTreePhase(VisualTreeUpdatePhase.Animation);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00003216 File Offset: 0x00001416
		public override void UpdateBindings()
		{
			this.m_VisualTreeUpdater.UpdateVisualTreePhase(VisualTreeUpdatePhase.Bindings);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00003226 File Offset: 0x00001426
		public override void ApplyStyles()
		{
			this.m_VisualTreeUpdater.UpdateVisualTreePhase(VisualTreeUpdatePhase.Styles);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00003236 File Offset: 0x00001436
		public static void add_beforeAnyRepaint(Action<Panel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00003243 File Offset: 0x00001443
		public static void remove_beforeAnyRepaint(Action<Panel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00003250 File Offset: 0x00001450
		public override void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase)
		{
			this.m_VisualTreeUpdater.SetUpdater(updater, phase);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000132D0 File Offset: 0x000114D0
		public override IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase)
		{
			return this.m_VisualTreeUpdater.GetUpdater(phase);
		}

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_m_RootContainer;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_m_VisualTreeUpdater;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_m_PanelName;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_m_RepaintVersion;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_m_HierarchyVersion;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkerBeforeUpdate;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkerUpdate;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkerLayout;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkerBindings;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkerAnimations;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerPickAll;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr__dispatcher_k__BackingField;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_m_Scheduler;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr__ownerObject_k__BackingField;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr__contextType_k__BackingField;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr__saveViewData_k__BackingField;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr__getViewDataDictionary_k__BackingField;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr__focusController_k__BackingField;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr__IMGUIEventInterests_k__BackingField;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr__loadResourceFunc_k__BackingField;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceStartup_k__BackingField;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr__IMGUIContainersCount_k__BackingField;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr__rootIMGUIContainer_k__BackingField;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_m_StandardShader;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_m_Atlas;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_m_ValidatingLayout;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_beforeAnyRepaint;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_get_visualTree_Public_Virtual_Final_get_VisualElement_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_get_dispatcher_Public_Virtual_Final_get_EventDispatcher_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_get_timerEventScheduler_Public_get_TimerEventScheduler_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_get_scheduler_Internal_Virtual_get_IScheduler_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_get_ownerObject_Public_Virtual_get_ScriptableObject_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_get_contextType_Public_Virtual_get_ContextType_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_get_focusController_Public_Virtual_Final_get_FocusController_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_get_IMGUIEventInterests_Public_Virtual_get_EventInterests_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_Focus_Internal_Void_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_Blur_Internal_Void_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Internal_get_String_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceStartup_Private_Static_get_TimeMsFunction_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_get_IMGUIContainersCount_Public_Virtual_get_Int32_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_get_rootIMGUIContainer_Public_Virtual_get_IMGUIContainer_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Internal_Virtual_get_UInt32_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_TimeSinceStartupMs_Public_Static_Int64_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_DefaultTimeSinceStartupMs_Internal_Static_Int64_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_PickAll_Private_Static_VisualElement_VisualElement_Vector2_List_1_VisualElement_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_PerformPick_Private_Static_VisualElement_VisualElement_Vector2_List_1_VisualElement_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_Pick_Public_Virtual_VisualElement_Vector2_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_ValidateLayout_Public_Virtual_Void_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_UpdateForRepaint_Private_Void_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_Repaint_Public_Virtual_Void_Event_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Internal_Virtual_Void_VisualElement_VersionChangeType_0;
	}
}
