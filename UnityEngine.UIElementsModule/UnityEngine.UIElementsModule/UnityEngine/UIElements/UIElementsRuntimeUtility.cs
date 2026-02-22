using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000038 RID: 56
	public static class UIElementsRuntimeUtility : Object
	{
		// Token: 0x060002CF RID: 719 RVA: 0x00014CC8 File Offset: 0x00012EC8
		// Note: this type is marked as 'beforefieldinit'.
		static UIElementsRuntimeUtility()
		{
			Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIElementsRuntimeUtility");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_s_onRepaintOverlayPanels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "s_onRepaintOverlayPanels");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_onCreatePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "onCreatePanel");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RegisteredPlayerloopCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "s_RegisteredPlayerloopCallback");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_s_SortedRuntimePanels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "s_SortedRuntimePanels");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_s_PanelOrderingDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "s_PanelOrderingDirty");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RepaintProfilerMarkerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "s_RepaintProfilerMarkerName");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RepaintProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "s_RepaintProfilerMarker");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_currentOverlayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "currentOverlayIndex");
			UIElementsRuntimeUtility.NativeFieldInfoPtr__activeEventSystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "<activeEventSystem>k__BackingField");
			UIElementsRuntimeUtility.NativeMethodInfoPtr_add_onCreatePanel_Public_Static_add_Void_Action_1_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100663528);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_remove_onCreatePanel_Public_Static_rem_Void_Action_1_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100663529);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_RepaintOverlayPanels_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100663531);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_RepaintOverlayPanel_Public_Static_Void_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100663532);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_get_activeEventSystem_Internal_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100663533);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_set_activeEventSystem_Private_Static_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100663534);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_RegisterEventSystem_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100663535);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_UnregisterEventSystem_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100663536);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_GetSortedPlayerPanels_Internal_Static_List_1_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100663537);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_SortPanels_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100663538);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00014E6C File Offset: 0x0001306C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92379, RefRangeEnd = 92380, XrefRangeStart = 92368, XrefRangeEnd = 92379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_onCreatePanel(Action<BaseRuntimePanel> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_add_onCreatePanel_Public_Static_add_Void_Action_1_BaseRuntimePanel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00014EA4 File Offset: 0x000130A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92391, RefRangeEnd = 92392, XrefRangeStart = 92380, XrefRangeEnd = 92391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_onCreatePanel(Action<BaseRuntimePanel> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_remove_onCreatePanel_Public_Static_rem_Void_Action_1_BaseRuntimePanel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00014EDC File Offset: 0x000130DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92392, XrefRangeEnd = 92431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RepaintOverlayPanels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_RepaintOverlayPanels_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00014F04 File Offset: 0x00013104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92440, RefRangeEnd = 92441, XrefRangeStart = 92431, XrefRangeEnd = 92440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RepaintOverlayPanel(BaseRuntimePanel panel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_RepaintOverlayPanel_Public_Static_Void_BaseRuntimePanel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00014F3C File Offset: 0x0001313C
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00014F70 File Offset: 0x00013170
		public unsafe static Object activeEventSystem
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92441, XrefRangeEnd = 92445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_get_activeEventSystem_Internal_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92445, XrefRangeEnd = 92449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_set_activeEventSystem_Private_Static_set_Void_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00014FA8 File Offset: 0x000131A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92488, RefRangeEnd = 92490, XrefRangeStart = 92449, XrefRangeEnd = 92488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterEventSystem(Object eventSystem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_RegisterEventSystem_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00014FE0 File Offset: 0x000131E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92509, RefRangeEnd = 92511, XrefRangeStart = 92490, XrefRangeEnd = 92509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterEventSystem(Object eventSystem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_UnregisterEventSystem_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00015018 File Offset: 0x00013218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92520, RefRangeEnd = 92521, XrefRangeStart = 92511, XrefRangeEnd = 92520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Panel> GetSortedPlayerPanels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_GetSortedPlayerPanels_Internal_Static_List_1_Panel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Panel>>(intPtr3) : null;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0001504C File Offset: 0x0001324C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92576, RefRangeEnd = 92578, XrefRangeStart = 92521, XrefRangeEnd = 92576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SortPanels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_SortPanels_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000036A9 File Offset: 0x000018A9
		public UIElementsRuntimeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00015074 File Offset: 0x00013274
		// (set) Token: 0x060002DC RID: 732 RVA: 0x000036B2 File Offset: 0x000018B2
		public unsafe static Action s_onRepaintOverlayPanels
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_onRepaintOverlayPanels, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_onRepaintOverlayPanels, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0001509C File Offset: 0x0001329C
		// (set) Token: 0x060002DE RID: 734 RVA: 0x000036C4 File Offset: 0x000018C4
		public unsafe static Action<BaseRuntimePanel> onCreatePanel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_onCreatePanel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BaseRuntimePanel>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_onCreatePanel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002DF RID: 735 RVA: 0x000150C4 File Offset: 0x000132C4
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x000036D6 File Offset: 0x000018D6
		public unsafe static bool s_RegisteredPlayerloopCallback
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RegisteredPlayerloopCallback, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RegisteredPlayerloopCallback, (void*)(&value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x000150E0 File Offset: 0x000132E0
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x000036E4 File Offset: 0x000018E4
		public unsafe static List<Panel> s_SortedRuntimePanels
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_SortedRuntimePanels, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Panel>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_SortedRuntimePanels, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00015108 File Offset: 0x00013308
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x000036F6 File Offset: 0x000018F6
		public unsafe static bool s_PanelOrderingDirty
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_PanelOrderingDirty, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_PanelOrderingDirty, (void*)(&value));
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00015124 File Offset: 0x00013324
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00003704 File Offset: 0x00001904
		public unsafe static string s_RepaintProfilerMarkerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RepaintProfilerMarkerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RepaintProfilerMarkerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00015144 File Offset: 0x00013344
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00003716 File Offset: 0x00001916
		public unsafe static ProfilerMarker s_RepaintProfilerMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RepaintProfilerMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RepaintProfilerMarker, (void*)(&value));
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00015160 File Offset: 0x00013360
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00003724 File Offset: 0x00001924
		public unsafe static int currentOverlayIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_currentOverlayIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_currentOverlayIndex, (void*)(&value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0001517C File Offset: 0x0001337C
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00003732 File Offset: 0x00001932
		public unsafe static Object _activeEventSystem_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr__activeEventSystem_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr__activeEventSystem_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000151A4 File Offset: 0x000133A4
		public static EventBase CreateEvent(Event systemEvent)
		{
			return UIElementsUtility.CreateEvent(systemEvent, systemEvent.rawType);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000151C4 File Offset: 0x000133C4
		public static void DisposeRuntimePanel(ScriptableObject ownerObject)
		{
			Panel panel;
			bool flag = UIElementsUtility.TryGetPanel(ownerObject.GetInstanceID(), out panel);
			if (flag)
			{
				panel.Dispose();
				UIElementsRuntimeUtility.RemoveCachedPanelInternal(ownerObject.GetInstanceID());
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000151F8 File Offset: 0x000133F8
		public static void RegisterCachedPanelInternal(int instanceID, IPanel panel)
		{
			UIElementsUtility.RegisterCachedPanel(instanceID, panel.TryCast<Panel>());
			UIElementsRuntimeUtility.s_PanelOrderingDirty = true;
			bool flag = !UIElementsRuntimeUtility.s_RegisteredPlayerloopCallback;
			if (flag)
			{
				UIElementsRuntimeUtility.s_RegisteredPlayerloopCallback = true;
				UIElementsRuntimeUtility.RegisterPlayerloopCallback();
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00015234 File Offset: 0x00013434
		public static void RemoveCachedPanelInternal(int instanceID)
		{
			UIElementsUtility.RemoveCachedPanel(instanceID);
			UIElementsRuntimeUtility.s_PanelOrderingDirty = true;
			UIElementsRuntimeUtility.s_SortedRuntimePanels.Clear();
			UIElementsUtility.GetAllPanels(UIElementsRuntimeUtility.s_SortedRuntimePanels, ContextType.Player);
			bool flag = UIElementsRuntimeUtility.s_SortedRuntimePanels.Count == 0;
			if (flag)
			{
				UIElementsRuntimeUtility.s_RegisteredPlayerloopCallback = false;
				UIElementsRuntimeUtility.UnregisterPlayerloopCallback();
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00003744 File Offset: 0x00001944
		public static void BeginRenderOverlays(int displayIndex)
		{
			UIElementsRuntimeUtility.currentOverlayIndex = 0;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00015288 File Offset: 0x00013488
		public static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority)
		{
			bool flag = UIElementsRuntimeUtility.currentOverlayIndex < 0;
			if (!flag)
			{
				List<Panel> sortedPlayerPanels = UIElementsRuntimeUtility.GetSortedPlayerPanels();
				while (UIElementsRuntimeUtility.currentOverlayIndex < sortedPlayerPanels.Count)
				{
					BaseRuntimePanel baseRuntimePanel = sortedPlayerPanels[UIElementsRuntimeUtility.currentOverlayIndex].TryCast<BaseRuntimePanel>();
					bool flag2 = baseRuntimePanel != null;
					if (flag2)
					{
						bool flag3 = baseRuntimePanel.sortingPriority >= maxPriority;
						if (flag3)
						{
							break;
						}
						bool flag4 = baseRuntimePanel.targetDisplay == displayIndex;
						if (flag4)
						{
							UIElementsRuntimeUtility.RepaintOverlayPanel(baseRuntimePanel);
						}
					}
					UIElementsRuntimeUtility.currentOverlayIndex++;
				}
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000374D File Offset: 0x0000194D
		public static void EndRenderOverlays(int displayIndex)
		{
			UIElementsRuntimeUtility.RenderOverlaysBeforePriority(displayIndex, float.MaxValue);
			UIElementsRuntimeUtility.currentOverlayIndex = -1;
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00003762 File Offset: 0x00001962
		public static bool useDefaultEventSystem
		{
			get
			{
				return UIElementsRuntimeUtility.activeEventSystem == null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000376F File Offset: 0x0000196F
		public static DefaultEventSystem defaultEventSystem
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00015314 File Offset: 0x00013514
		public static void UpdateRuntimePanels()
		{
			List<Panel>.Enumerator enumerator = UIElementsRuntimeUtility.GetSortedPlayerPanels().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Panel panel = enumerator.Current;
					BaseRuntimePanel baseRuntimePanel = panel.Cast<BaseRuntimePanel>();
					baseRuntimePanel.Update();
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			bool flag = Application.isPlaying && UIElementsRuntimeUtility.useDefaultEventSystem;
			if (flag)
			{
				UIElementsRuntimeUtility.defaultEventSystem.Update();
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000377C File Offset: 0x0000197C
		public static void RegisterPlayerloopCallback()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00003789 File Offset: 0x00001989
		public static void UnregisterPlayerloopCallback()
		{
			UIElementsRuntimeUtilityNative.UnregisterPlayerloopCallback();
			UIElementsRuntimeUtilityNative.UpdateRuntimePanelsCallback = null;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00003798 File Offset: 0x00001998
		public static void SetPanelOrderingDirty()
		{
			UIElementsRuntimeUtility.s_PanelOrderingDirty = true;
		}

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr_s_onRepaintOverlayPanels;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr_onCreatePanel;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr_s_RegisteredPlayerloopCallback;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_s_SortedRuntimePanels;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr_s_PanelOrderingDirty;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr_s_RepaintProfilerMarkerName;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeFieldInfoPtr_s_RepaintProfilerMarker;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeFieldInfoPtr_currentOverlayIndex;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr__activeEventSystem_k__BackingField;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_add_onCreatePanel_Public_Static_add_Void_Action_1_BaseRuntimePanel_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_remove_onCreatePanel_Public_Static_rem_Void_Action_1_BaseRuntimePanel_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_RepaintOverlayPanels_Public_Static_Void_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_RepaintOverlayPanel_Public_Static_Void_BaseRuntimePanel_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_get_activeEventSystem_Internal_Static_get_Object_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_set_activeEventSystem_Private_Static_set_Void_Object_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEventSystem_Public_Static_Void_Object_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterEventSystem_Public_Static_Void_Object_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_GetSortedPlayerPanels_Internal_Static_List_1_Panel_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_SortPanels_Private_Static_Void_0;

		// Token: 0x020001F4 RID: 500
		[ObfuscatedName("UnityEngine.UIElements.UIElementsRuntimeUtility+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600135C RID: 4956 RVA: 0x0003B324 File Offset: 0x00039524
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr);
				UIElementsRuntimeUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr, "<>9");
				UIElementsRuntimeUtility.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr, "<>9__43_0");
				UIElementsRuntimeUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr, 100663540);
				UIElementsRuntimeUtility.__c.NativeMethodInfoPtr__SortPanels_b__43_0_Internal_Int32_Panel_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr, 100663541);
			}

			// Token: 0x0600135D RID: 4957 RVA: 0x0003B3A0 File Offset: 0x000395A0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600135E RID: 4958 RVA: 0x0003B3DC File Offset: 0x000395DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92367, XrefRangeEnd = 92368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortPanels_b__43_0(Panel a, Panel b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.__c.NativeMethodInfoPtr__SortPanels_b__43_0_Internal_Int32_Panel_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600135F RID: 4959 RVA: 0x0000C783 File Offset: 0x0000A983
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000607 RID: 1543
			// (get) Token: 0x06001360 RID: 4960 RVA: 0x0003B43C File Offset: 0x0003963C
			// (set) Token: 0x06001361 RID: 4961 RVA: 0x0000C78C File Offset: 0x0000A98C
			public unsafe static UIElementsRuntimeUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementsRuntimeUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000608 RID: 1544
			// (get) Token: 0x06001362 RID: 4962 RVA: 0x0003B464 File Offset: 0x00039664
			// (set) Token: 0x06001363 RID: 4963 RVA: 0x0000C79E File Offset: 0x0000A99E
			public unsafe static Comparison<Panel> __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Panel>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400086F RID: 2159
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000870 RID: 2160
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x04000871 RID: 2161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000872 RID: 2162
			private static readonly IntPtr NativeMethodInfoPtr__SortPanels_b__43_0_Internal_Int32_Panel_Panel_0;
		}

		// Token: 0x020001F5 RID: 501
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
