using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x0200003B RID: 59
	public class UIElementsUtility : Object
	{
		// Token: 0x0600030F RID: 783 RVA: 0x00015920 File Offset: 0x00013B20
		// Note: this type is marked as 'beforefieldinit'.
		static UIElementsUtility()
		{
			Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIElementsUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr);
			UIElementsUtility.NativeFieldInfoPtr_s_ContainerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_ContainerStack");
			UIElementsUtility.NativeFieldInfoPtr_s_UIElementsCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_UIElementsCache");
			UIElementsUtility.NativeFieldInfoPtr_s_EventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_EventInstance");
			UIElementsUtility.NativeFieldInfoPtr_editorPlayModeTintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "editorPlayModeTintColor");
			UIElementsUtility.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_Instance");
			UIElementsUtility.NativeFieldInfoPtr_s_PanelsIterationList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_PanelsIterationList");
			UIElementsUtility.NativeFieldInfoPtr_s_RepaintProfilerMarkerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_RepaintProfilerMarkerName");
			UIElementsUtility.NativeFieldInfoPtr_s_EventProfilerMarkerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_EventProfilerMarkerName");
			UIElementsUtility.NativeFieldInfoPtr_s_RepaintProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_RepaintProfilerMarker");
			UIElementsUtility.NativeFieldInfoPtr_s_EventProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_EventProfilerMarker");
			UIElementsUtility.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100663564);
			UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_MakeCurrentIMGUIContainerDirty_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100663565);
			UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_TakeCapture_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100663566);
			UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_ReleaseCapture_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100663567);
			UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_ProcessEvent_Private_Virtual_Final_New_Boolean_Int32_IntPtr_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100663568);
			UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_CleanupRoots_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100663569);
			UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_EndContainerGUIFromException_Private_Virtual_Final_New_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100663570);
			UIElementsUtility.NativeMethodInfoPtr_RemoveCachedPanel_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100663571);
			UIElementsUtility.NativeMethodInfoPtr_BeginContainerGUI_Internal_Static_Void_LayoutCache_Event_IMGUIContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100663572);
			UIElementsUtility.NativeMethodInfoPtr_EndContainerGUI_Internal_Static_Void_Event_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100663573);
			UIElementsUtility.NativeMethodInfoPtr_CreateEvent_Internal_Static_EventBase_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100663574);
			UIElementsUtility.NativeMethodInfoPtr_CreateEvent_Internal_Static_EventBase_Event_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100663575);
			UIElementsUtility.NativeMethodInfoPtr_DoDispatch_Private_Static_Boolean_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100663576);
			UIElementsUtility.NativeMethodInfoPtr_GetAllPanels_Internal_Static_Void_List_1_Panel_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100663577);
			UIElementsUtility.NativeMethodInfoPtr_GetPanelsIterator_Internal_Static_Enumerator_Int32_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100663578);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00015B44 File Offset: 0x00013D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92762, XrefRangeEnd = 92775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIElementsUtility()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00015B80 File Offset: 0x00013D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92775, XrefRangeEnd = 92781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_UIElements_IUIElementsUtility_MakeCurrentIMGUIContainerDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_MakeCurrentIMGUIContainerDirty_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00015BBC File Offset: 0x00013DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92781, XrefRangeEnd = 92791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_UIElements_IUIElementsUtility_TakeCapture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_TakeCapture_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00015BF8 File Offset: 0x00013DF8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 59613, RefRangeEnd = 59618, XrefRangeStart = 59613, XrefRangeEnd = 59618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_UIElements_IUIElementsUtility_ReleaseCapture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_ReleaseCapture_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00015C34 File Offset: 0x00013E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92791, XrefRangeEnd = 92805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_UIElements_IUIElementsUtility_ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeEventPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &eventHandled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_ProcessEvent_Private_Virtual_Final_New_Boolean_Int32_IntPtr_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00015C9C File Offset: 0x00013E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92805, XrefRangeEnd = 92811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_UIElements_IUIElementsUtility_CleanupRoots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_CleanupRoots_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00015CD8 File Offset: 0x00013ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92811, XrefRangeEnd = 92823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_UIElements_IUIElementsUtility_EndContainerGUIFromException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_EndContainerGUIFromException_Private_Virtual_Final_New_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00015D28 File Offset: 0x00013F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92831, RefRangeEnd = 92832, XrefRangeStart = 92823, XrefRangeEnd = 92831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveCachedPanel(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_RemoveCachedPanel_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00015D5C File Offset: 0x00013F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92862, RefRangeEnd = 92863, XrefRangeStart = 92832, XrefRangeEnd = 92862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, Event evt, IMGUIContainer container)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cache);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_BeginContainerGUI_Internal_Static_Void_LayoutCache_Event_IMGUIContainer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00015DB8 File Offset: 0x00013FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92900, RefRangeEnd = 92901, XrefRangeStart = 92863, XrefRangeEnd = 92900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndContainerGUI(Event evt, Rect layoutSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layoutSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_EndContainerGUI_Internal_Static_Void_Event_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00015DFC File Offset: 0x00013FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92901, XrefRangeEnd = 92907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventBase CreateEvent(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_CreateEvent_Internal_Static_EventBase_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00015E40 File Offset: 0x00014040
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92955, RefRangeEnd = 92957, XrefRangeStart = 92907, XrefRangeEnd = 92955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventBase CreateEvent(Event systemEvent, EventType eventType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_CreateEvent_Internal_Static_EventBase_Event_EventType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00015E94 File Offset: 0x00014094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93010, RefRangeEnd = 93011, XrefRangeStart = 92957, XrefRangeEnd = 93010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoDispatch(BaseVisualElementPanel panel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_DoDispatch_Private_Static_Boolean_BaseVisualElementPanel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00015ED8 File Offset: 0x000140D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93011, XrefRangeEnd = 93032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetAllPanels(List<Panel> panels, ContextType contextType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panels);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contextType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_GetAllPanels_Internal_Static_Void_List_1_Panel_ContextType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00015F1C File Offset: 0x0001411C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93032, XrefRangeEnd = 93039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, Panel>.Enumerator GetPanelsIterator()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_GetPanelsIterator_Internal_Static_Enumerator_Int32_Panel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Dictionary<int, Panel>.Enumerator(intPtr);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000037C5 File Offset: 0x000019C5
		public UIElementsUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00015F48 File Offset: 0x00014148
		// (set) Token: 0x06000321 RID: 801 RVA: 0x000037CE File Offset: 0x000019CE
		public unsafe static Stack<IMGUIContainer> s_ContainerStack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_ContainerStack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<IMGUIContainer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_ContainerStack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00015F70 File Offset: 0x00014170
		// (set) Token: 0x06000323 RID: 803 RVA: 0x000037E0 File Offset: 0x000019E0
		public unsafe static Dictionary<int, Panel> s_UIElementsCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_UIElementsCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Panel>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_UIElementsCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00015F98 File Offset: 0x00014198
		// (set) Token: 0x06000325 RID: 805 RVA: 0x000037F2 File Offset: 0x000019F2
		public unsafe static Event s_EventInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_EventInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_EventInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00015FC0 File Offset: 0x000141C0
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00003804 File Offset: 0x00001A04
		public unsafe static Color editorPlayModeTintColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_editorPlayModeTintColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_editorPlayModeTintColor, (void*)(&value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00015FDC File Offset: 0x000141DC
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00003812 File Offset: 0x00001A12
		public unsafe static UIElementsUtility s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementsUtility>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00016004 File Offset: 0x00014204
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00003824 File Offset: 0x00001A24
		public unsafe static List<Panel> s_PanelsIterationList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_PanelsIterationList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Panel>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_PanelsIterationList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0001602C File Offset: 0x0001422C
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00003836 File Offset: 0x00001A36
		public unsafe static string s_RepaintProfilerMarkerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_RepaintProfilerMarkerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_RepaintProfilerMarkerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0001604C File Offset: 0x0001424C
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00003848 File Offset: 0x00001A48
		public unsafe static string s_EventProfilerMarkerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_EventProfilerMarkerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_EventProfilerMarkerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0001606C File Offset: 0x0001426C
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0000385A File Offset: 0x00001A5A
		public unsafe static ProfilerMarker s_RepaintProfilerMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_RepaintProfilerMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_RepaintProfilerMarker, (void*)(&value));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00016088 File Offset: 0x00014288
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00003868 File Offset: 0x00001A68
		public unsafe static ProfilerMarker s_EventProfilerMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_EventProfilerMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_EventProfilerMarker, (void*)(&value));
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000160A4 File Offset: 0x000142A4
		public static IMGUIContainer GetCurrentIMGUIContainer()
		{
			bool flag = UIElementsUtility.s_ContainerStack.Count > 0;
			IMGUIContainer imguicontainer;
			if (flag)
			{
				imguicontainer = UIElementsUtility.s_ContainerStack.Peek();
			}
			else
			{
				imguicontainer = null;
			}
			return imguicontainer;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000160D8 File Offset: 0x000142D8
		public void UnityEngine.UIElements.IUIElementsUtility.UpdateSchedulers()
		{
			UIElementsUtility.s_PanelsIterationList.Clear();
			UIElementsUtility.GetAllPanels(UIElementsUtility.s_PanelsIterationList, ContextType.Editor);
			List<Panel>.Enumerator enumerator = UIElementsUtility.s_PanelsIterationList.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Panel panel = enumerator.Current;
					panel.timerEventScheduler.UpdateScheduledEvents();
					panel.UpdateAnimations();
					panel.UpdateBindings();
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0001615C File Offset: 0x0001435C
		public void UnityEngine.UIElements.IUIElementsUtility.RequestRepaintForPanels(Action<ScriptableObject> repaintCallback)
		{
			Dictionary<int, Panel>.Enumerator panelsIterator = UIElementsUtility.GetPanelsIterator();
			while (panelsIterator.MoveNext())
			{
				KeyValuePair<int, Panel> keyValuePair = panelsIterator.Current;
				Panel value = keyValuePair.Value;
				bool flag = value.contextType != ContextType.Editor;
				if (!flag)
				{
					bool isDirty = value.isDirty;
					if (isDirty)
					{
						repaintCallback.Invoke(value.ownerObject);
					}
				}
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00003876 File Offset: 0x00001A76
		public static void RegisterCachedPanel(int instanceID, Panel panel)
		{
			UIElementsUtility.s_UIElementsCache.Add(instanceID, panel);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000161C0 File Offset: 0x000143C0
		public static bool TryGetPanel(int instanceID, out Panel panel)
		{
			return UIElementsUtility.s_UIElementsCache.TryGetValue(instanceID, out panel);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000161E0 File Offset: 0x000143E0
		public static Panel FindOrCreateEditorPanel(ScriptableObject ownerObject)
		{
			Panel panel;
			bool flag = !UIElementsUtility.s_UIElementsCache.TryGetValue(ownerObject.GetInstanceID(), out panel);
			if (flag)
			{
				panel = Panel.CreateEditorPanel(ownerObject);
				UIElementsUtility.RegisterCachedPanel(ownerObject.GetInstanceID(), panel);
			}
			else
			{
				Debug.Assert(ContextType.Editor == panel.contextType, "Panel is not an editor panel.");
			}
			return panel;
		}

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr_s_ContainerStack;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr_s_UIElementsCache;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr_s_EventInstance;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeFieldInfoPtr_editorPlayModeTintColor;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeFieldInfoPtr_s_PanelsIterationList;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeFieldInfoPtr_s_RepaintProfilerMarkerName;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeFieldInfoPtr_s_EventProfilerMarkerName;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeFieldInfoPtr_s_RepaintProfilerMarker;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeFieldInfoPtr_s_EventProfilerMarker;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_MakeCurrentIMGUIContainerDirty_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_TakeCapture_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_ReleaseCapture_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_ProcessEvent_Private_Virtual_Final_New_Boolean_Int32_IntPtr_byref_Boolean_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_CleanupRoots_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_EndContainerGUIFromException_Private_Virtual_Final_New_Boolean_Exception_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCachedPanel_Public_Static_Void_Int32_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_BeginContainerGUI_Internal_Static_Void_LayoutCache_Event_IMGUIContainer_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_EndContainerGUI_Internal_Static_Void_Event_Rect_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_CreateEvent_Internal_Static_EventBase_Event_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_CreateEvent_Internal_Static_EventBase_Event_EventType_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_DoDispatch_Private_Static_Boolean_BaseVisualElementPanel_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_GetAllPanels_Internal_Static_Void_List_1_Panel_ContextType_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_GetPanelsIterator_Internal_Static_Enumerator_Int32_Panel_0;
	}
}
